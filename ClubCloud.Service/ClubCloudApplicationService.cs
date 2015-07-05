namespace ClubCloud.Service
{
    using ClubCloud.KNLTB.ServIt.CrmService;
    using ClubCloud.Model;
    using Microsoft.SharePoint;
    using Microsoft.SharePoint.Administration;
    using Microsoft.SharePoint.Client.Services;
    using Microsoft.SharePoint.Utilities;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Core.Objects;
    using System.Data.Entity.Migrations;
    using System.Data.Entity.Spatial;
    using System.Data.SqlClient;
    using System.Diagnostics;
    using System.Drawing;
    using System.Globalization;
    using System.IO;
    using System.Linq;
    using System.Linq.Expressions;
    using System.Net;
    using System.ServiceModel;
    using System.ServiceModel.Activation;
    using System.Text.RegularExpressions;
    using System.Threading.Tasks;

    /// <summary>
	/// The WCF Service.
	/// </summary>
	[BasicHttpBindingServiceMetadataExchangeEndpoint]
	[ServiceFactoryUsingAuthSchemeInEndpointAddress(UsingAuthSchemeInEndpointAddress = true)]
	[AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
	[System.Runtime.InteropServices.Guid("e00d1eca-a977-4ba9-a357-5fd35dfc0f63")]
	[ServiceBehavior(Namespace = "http://clubcloud.nl/", Name = "ClubCloudService", IncludeExceptionDetailInFaults = true)]
	[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1812:AvoidUninstantiatedInternalClasses", Justification = "Instantiated by the WCF runtime automatically.")]
	internal partial class ClubCloudApplicationService : ClubCloud.Service.IClubCloudApplicationService
	{
		#region Global

		/// <summary>
		/// 
		/// </summary>
		/// <param name="catalog"></param>
		private static void CheckDatabase(string catalog = null)
		{
			if (catalog == null)
			{
				using (ClubCloud.Model.BeheerContainer Beheermodel = new Model.BeheerContainer(GetConnectionString(catalog)))
				{
					Beheermodel.Database.CreateIfNotExists();
					Beheermodel.Database.Initialize(false);
					Beheermodel.Database.CompatibleWithModel(false);
				}
				return;
			}

			if (catalog.StartsWith("ClubCloudService_Store", StringComparison.InvariantCultureIgnoreCase))
			{
				using (ClubCloud.Model.StoreContainer Storemodel = new Model.StoreContainer(GetConnectionString(catalog)))
				{
					Storemodel.Database.CreateIfNotExists();
					Storemodel.Database.Initialize(false);
					Storemodel.Database.CompatibleWithModel(false);
				}
			}

			if (catalog.StartsWith("ClubCloudService_Boekhouding", StringComparison.InvariantCultureIgnoreCase))
			{
				using (ClubCloud.Model.BoekhoudingContainer Boekhoudingmodel = new Model.BoekhoudingContainer(GetConnectionString(catalog)))
				{
					Boekhoudingmodel.Database.CreateIfNotExists();
					Boekhoudingmodel.Database.Initialize(false);
					Boekhoudingmodel.Database.CompatibleWithModel(false);
				}
			}

			if (catalog.StartsWith("ClubCloudService_SignalR", StringComparison.InvariantCultureIgnoreCase))
			{
				using (ClubCloud.Model.SignalRContainer SignalRmodel = new Model.SignalRContainer(GetConnectionString(catalog)))
				{
					SignalRmodel.Database.CreateIfNotExists();
					SignalRmodel.Database.Initialize(false);
					SignalRmodel.Database.CompatibleWithModel(false);
				}
			}

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="catalog"></param>
		/// <returns></returns>
		private static string GetConnectionString(string catalog = null)
		{
			ClubCloudServiceApplication application = SPIisWebServiceApplication.Current as ClubCloudServiceApplication;
			SqlConnectionStringBuilder builder = null;

			if (application == null)
			{
				throw new InvalidOperationException("Could not find the current Service Application.");
			}

			using (SqlConnection connection = new SqlConnection(application.Database.DatabaseConnectionString + ";MultipleActiveResultSets=true;"))
			{
				builder = new SqlConnectionStringBuilder(connection.ConnectionString);

				if (!string.IsNullOrWhiteSpace(catalog))
				{
					builder.InitialCatalog = catalog;
				}
			}

			if (builder != null)
			{
				return builder.ConnectionString;
			}

			return application.Database.DatabaseConnectionString;
		}


        /// <summary>
        /// 
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="verenigingId"></param>
		private void ValidateBondsnummer(ref string bondsnummer, Guid verenigingId)
		{
            using (new SPMonitoredScope("ValidateBondsnummer"))
            {
                try
                {
                    Guid working_verenigingId = verenigingId;
                    string working_bondsnummer = bondsnummer;                    

                    ClubCloud_Gebruiker gebruiker = null;
                    ClubCloud_Setting settings = null;

                    gebruiker = beheerModel.ClubCloud_Gebruikers.FirstOrDefault(g => g.Bondsnummer == working_bondsnummer);

                    if (gebruiker != null)
                    {
                        settings = beheerModel.ClubCloud_Settings.Find(int.Parse(gebruiker.Bondsnummer));
                    }

                    if (settings != null)
                    {
                        if (!settings.Access && !string.IsNullOrEmpty(settings.Password))
                        {
                            gebruiker = null;
                        }
                    }
                    else
                    {
                        gebruiker = null;
                    }

                    if (gebruiker == null && verenigingId != Guid.Empty)
                    {
                        List<ClubCloud_Functionaris> functionarissen = new List<ClubCloud_Functionaris>();

                        functionarissen = beheerModel.ClubCloud_Functionarissen.Where(f => f.VerenigingId.Value == verenigingId && f.Autorisatie == true && (f.FunctieId == new Guid("516B73DD-61B8-4B5F-BD15-78232C2D071C") || f.FunctieId == new Guid("C91FB5B2-E6CB-4B34-B9DC-BEBDFD6D35C7"))).ToList();

                        if (functionarissen != null && functionarissen.Count > 0)
                        {
                            foreach (ClubCloud_Functionaris functionaris in functionarissen)
                            {
                                gebruiker = beheerModel.ClubCloud_Gebruikers.Find(functionaris.GebruikerId.Value);

                                settings = beheerModel.ClubCloud_Settings.Find(int.Parse(gebruiker.Bondsnummer));
                                if (settings != null)
                                {
                                    if (settings.Access && !string.IsNullOrEmpty(settings.Password))
                                    {
                                        break;
                                    }
                                }
                            }
                        }
                    }

                    if (gebruiker != null)
                    {
                        bondsnummer = gebruiker.Bondsnummer;
                    }
                    /*
                    else
                    {
                        if (working_bondsnummer != "0000000" || working_bondsnummer != "0")
                        {
                            if (settings == null)
                            {
                                settings = beheerModel.ClubCloud_Settings.Find(int.Parse(working_bondsnummer));

                                if (!settings.Access && string.IsNullOrWhiteSpace(settings.Password))
                                    bondsnummer = string.Empty;
                            }
                        }
                    }
                    */
                }
                catch (Exception ex)
                {
                    Logger.WriteLog(Logger.Category.Unexpected, ex.Source, ex.Message);
                }
            }
		}

        /// <summary>
        /// 
        /// </summary>
        /// <param name="settings"></param>
        private void ValidateSettings(ref ClubCloud_Setting settings)
        {
            ClubCloud_Setting working_settings = (ClubCloud_Setting)settings.Clone();
            string working_Id = working_settings.Id.ToString();
            Guid working_VerenigingId = working_settings.VerenigingId.Value;

            ValidateBondsnummer(ref working_Id, working_VerenigingId);

            if (!string.IsNullOrWhiteSpace(working_Id) && (working_Id != "0000000" || working_Id != "0"))
            {
                working_settings = beheerModel.ClubCloud_Settings.Find(int.Parse(working_Id));
                if (working_settings != null)
                    settings = (ClubCloud_Setting)working_settings.Clone();
            }

            try { beheerModel.ObjectContext.Detach(working_settings); }
            catch { }
        }

		#endregion

		#region Security

		private ClubCloud_Setting GetSettings(int bondsnummer, ClubCloud_Functie functie = null)
		{
			ClubCloud_Setting settings = null;
			List<ClubCloud_Functie> functies = new List<ClubCloud_Functie>();

			if (functie != null)
			{
				functies.Add(functie);
			}
			else
			{
				ClubCloud_Functie ledenadministratie = beheerModel.ClubCloud_Functies.Find(new Guid("C91FB5B2-E6CB-4B34-B9DC-BEBDFD6D35C7"));
				if (ledenadministratie != null)
					functies.Add(ledenadministratie);

				ClubCloud_Functie gedelegeerd_gedenadministratie = beheerModel.ClubCloud_Functies.Find(new Guid("516B73DD-61B8-4B5F-BD15-78232C2D071C"));
				if (gedelegeerd_gedenadministratie != null)
					functies.Add(gedelegeerd_gedenadministratie);
			}

			ClubCloud_Setting usersettings = beheerModel.ClubCloud_Settings.Find(bondsnummer);

			bool heeftFunctie = false;

			if (usersettings != null && usersettings.Access && !string.IsNullOrEmpty(usersettings.Password) && usersettings.GebruikerId.HasValue)
			{
                List<ClubCloud_Functionaris> functionarissen = GetFunctionarissenForGebruikerById(usersettings.GebruikerId.Value, false, usersettings);

				foreach (ClubCloud_Functionaris functionaris in functionarissen)
				{
					if (functies.Any(f => f.Id == functionaris.FunctieId))
					{
						heeftFunctie = true;
						break;
					}
				}
			}
			else
			{
				if (usersettings != null && usersettings.VerenigingId.HasValue)
				{
                    List<ClubCloud_Functionaris> functionarissen = GetFunctionarissenForVerenigingById(usersettings.VerenigingId.Value, false, usersettings);

					foreach (ClubCloud_Functionaris functionaris in functionarissen)
					{
						//ClubCloud_Functie afunctie = FunctieById(bondsnummer, functionaris.FunctieId.Value, false, usersettings);
						//if (afunctie != null && functies.Contains(afunctie))
						//if (functies.Contains( f => f.id == functioniris.FinctieIdfunctionaris.ClubCloud_Functie))
						if (functies.Any(f => f.Id == functionaris.FunctieId))
						{
							usersettings = beheerModel.ClubCloud_Settings.FirstOrDefault(g => g.GebruikerId == functionaris.GebruikerId);// .Find(functionaris.ClubCloud_Gebruiker.Bondsnummer);
							if (usersettings != null && usersettings.Access && !string.IsNullOrEmpty(usersettings.Password))
							{
								heeftFunctie = true;
								break;
							}
						}
					}
				}
			}

			if (heeftFunctie)
			{
				settings = usersettings;
			}
			else
			{
				//No earlier contact has been made.
				if (usersettings != null && usersettings.Access && !string.IsNullOrEmpty(usersettings.Password))
				{
					settings = usersettings;
				}
			}

            try { beheerModel.ObjectContext.Detach(usersettings); }
            catch { }

            try { beheerModel.ObjectContext.Detach(settings); }
            catch { }

			return settings;
		}

		private ClubCloud_Setting GetSettings(string bondsnummer)
		{
			int nummer;
			if(int.TryParse(bondsnummer,out nummer))
				return GetSettings(nummer);

			return null;
		}

		#endregion

        #region KNLTB

        #region Service

        private static Dictionary<string, ClubCloud.KNLTB.ServIt.CrmService.CrmService> _crmServices;

        public Dictionary<string, ClubCloud.KNLTB.ServIt.CrmService.CrmService> CrmServices
        {
            get
            {
                if (_crmServices == null)
                    _crmServices = new Dictionary<string, CrmService>();

                return _crmServices;
            }
        }

        #endregion

        #region CookieContainer

        /// <summary>
        /// 
        /// </summary>
        private static SortedList<string, CookieContainer> _containers;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="wachtwoord"></param>
        /// <returns></returns>
        private CookieContainer RequestContainer(string bondsnummer, string wachtwoord, bool decrypt = true)
        {
            CookieContainer container = null;// new CookieContainer();

            if (_containers == null)
                _containers = new SortedList<string, CookieContainer>();

            if (_crmServices == null)
                _crmServices = new Dictionary<string, CrmService>();

            bool expired = false;
            if (_containers.Keys.Contains(bondsnummer))
            {
                container = _containers.FirstOrDefault(c => c.Key == bondsnummer).Value;

                CookieCollection cookies = container.GetCookies(new Uri("http://www.mijnknltb.nl"));
                cookies.Add(container.GetCookies(new Uri("http://servit.mijnknltb.nl")));
                cookies.Add(container.GetCookies(new Uri("http://mijnknltb.nl")));

                foreach (Cookie cookie in cookies)
                {
                    if (DateTime.Now.Subtract(cookie.TimeStamp).Minutes > 19)
                    //if (cookie.Expired)
                    {
                        cookie.Expired = true;
                        expired = cookie.Expired;
                        //break;
                    }
                }
            }

            if (container != null && container.Count > 0 && !expired)
            {
                return container;
            }
            else
            {
                if (_containers.Keys.Contains(bondsnummer))
                {
                    _containers.Remove(bondsnummer);
                }

                ClubCloud.KNLTB.Security.KNLTBContainer KNLTBContainer = new KNLTB.Security.KNLTBContainer();
                if (decrypt)
                {
                    ClubCloud_Setting settings = GetClubCloudSettings(bondsnummer);
                    string decrypted = BeheerEncryption.Decrypt(settings.Password, settings.VerenigingId.Value.ToString(), settings.GebruikerId.Value.ToString());
                    KNLTBContainer.MijnRequestAcces(bondsnummer, decrypted);
                }
                else
                {
                    KNLTBContainer.MijnRequestAcces(bondsnummer, wachtwoord);
                }

                Stopwatch s = new Stopwatch();
                s.Start();
                //TODO
                while (KNLTBContainer.Container == null && s.Elapsed < TimeSpan.FromSeconds(30)) { }
                s.Stop();

                _containers.Add(bondsnummer, KNLTBContainer.Container);

                if (_crmServices.ContainsKey(bondsnummer))
                {
                    _crmServices[bondsnummer].CrmCookieContainer = KNLTBContainer.Container;
                }
                else
                {
                    _crmServices.Add(bondsnummer, new CrmService(KNLTBContainer.Container));
                }

                return KNLTBContainer.Container;
            }
        }

        #endregion

        #region Retrieve

        /// <summary>
        /// 
        /// </summary>
        /// <param name="service"></param>
        /// <param name="entityName"></param>
        /// <param name="moreRecords"></param>
        /// <param name="pageNum"></param>
        /// <param name="filter"></param>
        /// <returns></returns>
        private List<BusinessEntity> RetrieveMultiple(ClubCloud.KNLTB.ServIt.CrmService.CrmService service, string entityName, out bool moreRecords, ref int pageNum, FilterExpression filter = null, LinkEntity link = null)
        {
            RetrieveMultipleResponse results = null;
            List<BusinessEntity> entities = new List<BusinessEntity>();

            //ColumnSetBase cols = new AllColumns();

            FilterExpression expression = new FilterExpression();
            if (filter != null)
            {
                expression = filter;
            }

            PagingInfo pageInfo = new PagingInfo();
            /*
            //Limit while debugging
#if DEBUG
            pageInfo.Count = 20;
#else
            pageInfo.Count = 50;
#endif
            */
            pageInfo.Count = 50;
            pageInfo.PageNumber = pageNum;
            QueryExpression query = new QueryExpression();

            query.EntityName = entityName;
            query.ColumnSet = new AllColumns();
            query.Criteria = expression;
            query.LinkEntities = new LinkEntity[] { link };
            query.PageInfo = pageInfo;
            query.Distinct = true;

            // Create the request object.
            RetrieveMultipleRequest request = new RetrieveMultipleRequest();

            // Set the properties of the request object.
            request.Query = query;
            //request.ReturnDynamicEntities = true;

            // Execute the request.
            try
            {
                results = (RetrieveMultipleResponse)service.Execute(request);
            }
            catch (Exception ex)
            {
                string exception = ex.ToString();
            }

            moreRecords = false;

            if (results != null)
            {
                moreRecords = results.BusinessEntityCollection.MoreRecords;
                if (moreRecords)
                {
                    pageNum++;
                }

                entities = results.BusinessEntityCollection.BusinessEntities.ToList<BusinessEntity>();
            }
            /*
#if DEBUG
            moreRecords = false;
#endif
            */

            return entities;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="service"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        private BusinessEntity RetrieveEntity(ClubCloud.KNLTB.ServIt.CrmService.CrmService service, string entityName, Guid Id)// TargetRetrieve target)
        {
            BusinessEntity entity = null;

            //RetrieveResponse result = null;
            //RetrieveRequest request = new RetrieveRequest();
            //request.ColumnSet = new AllColumns();
            //request.ReturnDynamicEntities = true;
            //request.Target = target;

            try
            {
                entity = service.Retrieve(entityName, Id, new AllColumns());

                /*
                if (result != null)
                {
                    entity = result.BusinessEntity;
                }
                */
            }
            catch (Exception ex)
            {
                string exception = ex.ToString();
                //throw ex;
                entity = null;
            }
            return entity;
        }

        #endregion

        #region Update

        /// <summary>
        /// 
        /// </summary>
        /// <param name="service"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        private bool UpdateEntity(ClubCloud.KNLTB.ServIt.CrmService.CrmService service, BusinessEntity entity)//TargetUpdate target)
        {
            bool succes = true;
            //UpdateResponse result = null;
            //UpdateRequest request = new UpdateRequest();
            //request.Target = target;

            try
            {
                service.Update(entity);
            }
            catch (Exception ex)
            {
                succes = false;
                string exception = ex.ToString();
                //throw ex;
            }
            return succes;
        }

        #endregion

        #region Create

        /// <summary>
        /// 
        /// </summary>
        /// <param name="service"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        private Guid CreateEntity(ClubCloud.KNLTB.ServIt.CrmService.CrmService service, BusinessEntity entity)//TargetCreate target)
        {
            Guid newId = Guid.Empty;

            //CreateResponse result = null;
            //CreateRequest request = new CreateRequest();
            //request.Target = target;

            try
            {
                newId = service.Create(entity);
                //newId = result.id;
            }
            catch (Exception ex)
            {
                string exception = ex.ToString();
                //throw ex;
            }
            return newId;
        }

        #endregion

        #region Delete

        /// <summary>
        /// 
        /// </summary>
        /// <param name="service"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        private bool DeleteEntity(ClubCloud.KNLTB.ServIt.CrmService.CrmService service, string entityName, Guid Id)// TargetDelete target)
        {
            bool succes = true;

            //DeleteResponse result = null;
            //DeleteRequest request = new DeleteRequest();
            //request.Target = target;

            try
            {
                service.Delete(entityName, Id);//.Execute(request);
            }
            catch (Exception ex)
            {
                succes = false;
                string exception = ex.ToString();
                //throw ex;
            }
            return succes;
        }

        #endregion

        #region State

        /// <summary>
        /// 
        /// </summary>
        /// <param name="service"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        private bool StateEntity(ClubCloud.KNLTB.ServIt.CrmService.CrmService service, Request request)
        {
            bool succes = true;

            Response result = null;

            try
            {
                result = (Response)service.Execute(request);
            }
            catch (Exception ex)
            {
                succes = false;
                string exception = ex.ToString();
                throw ex;
            }
            return succes;
        }

        #endregion

        #endregion

        #region Accommodatie

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="AccommodatieId"></param>
        /// <param name="refresh"></param>
        /// <param name="settings"></param>
        /// <returns></returns>
        private ClubCloud_Accommodatie GetAccommodatieById(string bondsnummer, Guid Id, bool refresh = false, ClubCloud_Setting settings = null)
        {
            ClubCloud_Accommodatie entity = null;

            entity = beheerModel.ClubCloud_Accommodaties.Find(Id);

            if (entity == null || refresh)
            {
                if (settings == null)
                    settings = GetSettings(bondsnummer);

                if (settings != null && settings.Access && !string.IsNullOrWhiteSpace(settings.Password))
                {
                    CookieContainer cc = RequestContainer(settings.Id.ToString(), settings.Password);

                    if (cc != null)
                    {
                        using (ClubCloud.KNLTB.ServIt.CrmService.CrmService service = CrmServices[settings.Id.ToString()])
                        {
                            sgt_alg_accommodatie accommodatie = RetrieveEntity(service, "sgt_alg_accommodatie", Id) as sgt_alg_accommodatie;

                            if (accommodatie != null && accommodatie.sgt_alg_accommodatieid.Value == Id)
                            {
                                if (entity == null)
                                    entity = beheerModel.ClubCloud_Accommodaties.Create();

                                entity.Id = accommodatie.sgt_alg_accommodatieid.Value;

                                AccommodatieToEntity(accommodatie, entity, settings);

                                beheerModel.ClubCloud_Accommodaties.AddOrUpdate(entity);

                                beheerModel.SaveChanges();

                                if (accommodatie.sgt_alg_accommodatieid.Value != null)
                                {
                                    GetAddressenForAccommodatieById(settings.Id.ToString(), accommodatie.sgt_alg_accommodatieid.Value, refresh, settings);
                                }

                                if (accommodatie.sgt_districtid != null)
                                {
                                    ClubCloud_District district = GetDistrictById(accommodatie.sgt_districtid.Value, false, settings);
                                    if (district != null)
                                        entity.ClubCloud_District = district;
                                }

                                if (accommodatie.sgt_regioid != null)
                                {
                                    ClubCloud_Regio regio = GetRegioById(accommodatie.sgt_regioid.Value, false, settings);
                                    if (regio != null)
                                        entity.ClubCloud_Regio = regio;
                                }

                                beheerModel.SaveChanges();
                            }
                        }
                    }
                }

                entity = beheerModel.ClubCloud_Accommodaties.Find(Id);
            }

            return entity;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="refresh"></param>
        /// <param name="settings"></param>
        /// <returns></returns>
        private List<ClubCloud_Accommodatie> GetAccommodaties(string bondsnummer, bool refresh, ClubCloud_Setting settings)
        {
            List<ClubCloud_Accommodatie> accommodaties = new List<ClubCloud_Accommodatie>();

            accommodaties = beheerModel.ClubCloud_Accommodaties.ToList();

            if (accommodaties == null || accommodaties.Count == 0 || refresh)
            {
                accommodaties = new List<ClubCloud_Accommodatie>();

                if (settings == null)
                    settings = GetSettings(bondsnummer);

                if (settings != null && settings.Access && !string.IsNullOrWhiteSpace(settings.Password))
                {
                    CookieContainer cc = RequestContainer(settings.Id.ToString(), settings.Password);

                    if (cc != null)
                    {
                        using (ClubCloud.KNLTB.ServIt.CrmService.CrmService service = CrmServices[settings.Id.ToString()])
                        {
                            bool moreRecords = true;
                            int pageNum = 1;
                            while (moreRecords)
                            {
                                List<BusinessEntity> entities = RetrieveMultiple(service, "sgt_alg_accommodatie", out moreRecords, ref pageNum);

                                foreach (sgt_alg_accommodatie accommodatie in entities)
                                {
                                    ClubCloud_Accommodatie entity = beheerModel.ClubCloud_Accommodaties.Find(accommodatie.sgt_alg_accommodatieid.Value);

                                    if (entity == null)
                                        entity = beheerModel.ClubCloud_Accommodaties.Create();

                                    entity.Id = accommodatie.sgt_alg_accommodatieid.Value;

                                    AccommodatieToEntity(accommodatie, entity, settings);

                                    beheerModel.ClubCloud_Accommodaties.AddOrUpdate(entity);
                                }

                                beheerModel.SaveChanges();

                                foreach (sgt_alg_accommodatie accommodatie in entities)
                                {
                                    ClubCloud_Accommodatie entity = beheerModel.ClubCloud_Accommodaties.Find(accommodatie.sgt_alg_accommodatieid.Value);

                                    if (accommodatie.sgt_alg_accommodatieid.Value != null)
                                    {
                                        GetAddressenForAccommodatieById(settings.Id.ToString(), accommodatie.sgt_alg_accommodatieid.Value, refresh, settings);
                                    }

                                    if (accommodatie.sgt_districtid != null)
                                    {
                                        ClubCloud_District district = GetDistrictById(accommodatie.sgt_districtid.Value, false, settings);
                                        if (district != null)
                                            entity.ClubCloud_District = district;
                                    }

                                    if (accommodatie.sgt_regioid != null)
                                    {
                                        ClubCloud_Regio regio = GetRegioById(accommodatie.sgt_regioid.Value, false, settings);
                                        if (regio != null)
                                            entity.ClubCloud_Regio = regio;
                                    }
                                }

                                beheerModel.SaveChanges();
                            }
                        }
                    }
                }
                accommodaties = beheerModel.ClubCloud_Accommodaties.ToList();
            }
            return accommodaties;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="entity"></param>
        /// <param name="settings"></param>
        /// <returns></returns>
        private ClubCloud_Accommodatie SetAccommodatie(string bondsnummer, ClubCloud_Accommodatie entity, ClubCloud_Setting settings)
        {
            try
            {
                if (entity.Id != Guid.Empty)
                {
                    if (settings == null)
                        settings = GetSettings(bondsnummer);

                    if (settings != null && settings.Access && !string.IsNullOrWhiteSpace(settings.Password))
                    {
                        CookieContainer cc = RequestContainer(settings.Id.ToString(), settings.Password);

                        if (cc != null)
                        {
                            using (ClubCloud.KNLTB.ServIt.CrmService.CrmService service = CrmServices[settings.Id.ToString()])
                            {
                                sgt_alg_accommodatie found = RetrieveEntity(service, "sgt_alg_accommodatie", entity.Id) as sgt_alg_accommodatie;// "sgt_alg_accommodatie", out moreRecords, ref pageNum, expression);

                                if (found != null && found.sgt_alg_accommodatieid.Value == entity.Id)
                                {
                                    EntityToAccommodatie(found, entity, settings);

                                    //TargetUpdateSgt_alg_accommodatie update = new TargetUpdateSgt_alg_accommodatie { Sgt_alg_accommodatie = accommodatie };
                                    //UpdateEntity(service, update);
                                    UpdateEntity(service, found);
                                }

                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                string message = ex.Message;
            }

            if (entity.Id == Guid.Empty)
                entity.Id = Guid.NewGuid();

            return entity;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="entity"></param>
        /// <param name="refresh"></param>
        /// <param name="settings"></param>
        /// <returns></returns>
        private List<ClubCloud_Vereniging> GetVerenigingenForAccommodatie(string bondsnummer, ClubCloud_Accommodatie entity, bool refresh, ClubCloud_Setting settings)
        {
            return GetVerenigingenForAccommodatieById(bondsnummer, entity.Id, refresh, settings);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="Id"></param>
        /// <param name="refresh"></param>
        /// <param name="settings"></param>
        /// <returns></returns>
        private List<ClubCloud_Vereniging> GetVerenigingenForAccommodatieById(string bondsnummer, Guid Id, bool refresh, ClubCloud_Setting settings)
        {
            List<ClubCloud_Vereniging> result = null;

            ClubCloud_Accommodatie accommodatie = GetAccommodatieById(Id);

            if (accommodatie != null)
            {
                if (accommodatie.ClubCloud_Vereniging == null || accommodatie.ClubCloud_Vereniging.Count == 0)
                {
                    result = beheerModel.ClubCloud_Verenigingen.Where(v => v.AccommodatieId.Value == Id).ToList();

                    foreach (ClubCloud_Vereniging vereniging in result)
                    {
                        accommodatie.ClubCloud_Vereniging.Add(vereniging);
                    }
                    beheerModel.SaveChanges();
                }

                if (refresh)
                {
                    result = new List<ClubCloud_Vereniging>();

                    if (settings == null || !settings.Access)
                        settings = GetSettings(bondsnummer);

                    if (settings != null && settings.Access && !string.IsNullOrWhiteSpace(settings.Password))
                    {
                        CookieContainer cc = RequestContainer(settings.Id.ToString(), settings.Password);

                        if (cc != null)
                        {
                            using (ClubCloud.KNLTB.ServIt.CrmService.CrmService service = CrmServices[settings.Id.ToString()])
                            {
                                bool moreRecords = true;
                                int pageNum = 1;
                                while (moreRecords)
                                {
                                    ConditionExpression condition = new ConditionExpression { AttributeName = "sgt_hoofdaccomodatieid", Operator = ConditionOperator.Equal, uiname = accommodatie.Naam, uitype = "sgt_alg_accommodatie", Values = new object[1] { accommodatie.Id } };
                                    FilterExpression expression = new FilterExpression { FilterOperator = LogicalOperator.And, Conditions = new ConditionExpression[1] { condition } };

                                    List<BusinessEntity> entities = RetrieveMultiple(service, "account", out moreRecords, ref pageNum, expression);


                                    foreach (account account in entities)
                                    {
                                        ClubCloud_Vereniging entity = beheerModel.ClubCloud_Verenigingen.Find(account.accountid.Value);

                                        if (entity == null)
                                        {
                                            entity = beheerModel.ClubCloud_Verenigingen.Create();
                                            entity.Id = account.accountid.Value;
                                        }

                                        VerenigingToEntity(account, entity, settings);

                                        beheerModel.ClubCloud_Verenigingen.AddOrUpdate(entity);

                                    }
                                    beheerModel.SaveChanges();

                                    foreach (account account in entities)
                                    {
                                        ClubCloud_Vereniging entity = beheerModel.ClubCloud_Verenigingen.Find(account.accountid.Value);

                                        if (account.sgt_districtid != null)
                                        {
                                            ClubCloud_District district = GetDistrictById(account.sgt_districtid.Value, false, settings);
                                            entity.ClubCloud_District = district;
                                            //account.DistrictId = account.sgt_districtid.Value;
                                        }

                                        if (account.sgt_rechtsvormid != null)
                                        {
                                            ClubCloud_Rechtsvorm rechtsvorm = GetRechtsvormById(account.sgt_rechtsvormid.Value, false, settings);
                                            entity.ClubCloud_Rechtsvorm = rechtsvorm;
                                            //account.RechtsvormId = account.sgt_rechtsvormid.Value;
                                        }

                                        if (account.sgt_hoofdaccomodatieid != null)
                                        {
                                            ClubCloud_Accommodatie Accommodatie = GetAccommodatieById(account.sgt_hoofdaccomodatieid.Value, false, settings);
                                            entity.ClubCloud_Accommodatie = Accommodatie;
                                            //account.AccommodatieId = account.sgt_hoofdaccomodatieid.Value;
                                        }

                                        if (account.parentaccountid != null)
                                        {
                                            ClubCloud_Regio regio = GetRegioById(account.parentaccountid.Value, false, settings);
                                            entity.ClubCloud_Regio = regio;
                                            //account.RegioId = account.parentaccountid.Value;
                                        }

                                        if (account.address1_addressid != null)
                                        {
                                            ClubCloud_Address bezoek = GetAddressById(account.address1_addressid.Value, false, settings);
                                            entity.ClubCloud_Address.Add(bezoek);
                                        }

                                        if (account.address2_addressid != null)
                                        {
                                            ClubCloud_Address post = GetAddressById(account.address2_addressid.Value, false, settings);
                                            entity.ClubCloud_Address.Add(post);
                                        }
                                    }

                                    beheerModel.SaveChanges();

                                    foreach (account account in entities)
                                    {
                                        ClubCloud_Vereniging entity = beheerModel.ClubCloud_Verenigingen.Find(account.accountid.Value);
                                        accommodatie.ClubCloud_Vereniging.Add(entity);
                                    }
                                    beheerModel.SaveChanges();
                                }
                            }
                        }
                    }
                    result = beheerModel.ClubCloud_Verenigingen.Where(v => v.AccommodatieId.Value == Id).ToList();
                }
            }
            return result;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="entity"></param>
        /// <param name="refresh"></param>
        /// <param name="settings"></param>
        /// <returns></returns>
        private ClubCloud_District GetDistrictForAccommodatie(string bondsnummer, ClubCloud_Accommodatie entity, bool refresh, ClubCloud_Setting settings)
        {
            return GetDistrictForAccommodatieById(bondsnummer, entity.Id, refresh, settings);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="Id"></param>
        /// <param name="refresh"></param>
        /// <param name="settings"></param>
        /// <returns></returns>
        private ClubCloud_District GetDistrictForAccommodatieById(string bondsnummer, Guid Id, bool refresh, ClubCloud_Setting settings)
        {
            ClubCloud_District result = null;

            ClubCloud_Accommodatie accommodatie = GetAccommodatieById(Id);
            if(accommodatie != null)
            {
                if(accommodatie.ClubCloud_District == null && accommodatie.DistrictId != null)
                {
                    result = beheerModel.ClubCloud_Districten.Find(accommodatie.DistrictId.Value);

                    if (result != null)
                    {
                        accommodatie.ClubCloud_District = result;
                        beheerModel.SaveChanges();
                    }
                    else
                    {
                        result = GetDistrictById(bondsnummer, accommodatie.DistrictId.Value, refresh, settings);
                        if (result != null)
                        {
                            accommodatie.ClubCloud_District = result;
                            beheerModel.SaveChanges();
                        }

                    }
                }
            }
            return result;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="entity"></param>
        /// <param name="refresh"></param>
        /// <param name="settings"></param>
        /// <returns></returns>
        private ClubCloud_Regio GetRegioForAccommodatie(string bondsnummer, ClubCloud_Accommodatie entity, bool refresh, ClubCloud_Setting settings)
        {
            return GetRegioForAccommodatieById(bondsnummer, entity.Id, refresh, settings);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="Id"></param>
        /// <param name="refresh"></param>
        /// <param name="settings"></param>
        /// <returns></returns>
        private ClubCloud_Regio GetRegioForAccommodatieById(string bondsnummer, Guid Id, bool refresh, ClubCloud_Setting settings)
        {
            ClubCloud_Regio result = null;

            ClubCloud_Accommodatie accommodatie = GetAccommodatieById(Id);
            if (accommodatie != null)
            {
                if (accommodatie.ClubCloud_Regio == null && accommodatie.RegioId != null)
                {
                    result = beheerModel.ClubCloud_Regios.Find(accommodatie.RegioId.Value);

                    if (result != null)
                    {
                        accommodatie.ClubCloud_Regio = result;
                        beheerModel.SaveChanges();
                    }
                    else
                    {
                        result = GetRegioById(bondsnummer, accommodatie.RegioId.Value, refresh, settings);
                        if (result != null)
                        {
                            accommodatie.ClubCloud_Regio = result;
                            beheerModel.SaveChanges();
                        }

                    }
                }
            }
            return result;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="entity"></param>
        /// <param name="refresh"></param>
        /// <param name="settings"></param>
        /// <returns></returns>
        private List<ClubCloud_Baanblok> GetBaanblokkenForAccommodatie(string bondsnummer, ClubCloud_Accommodatie entity, bool refresh, ClubCloud_Setting settings)
        {
            return GetBaanblokkenForAccommodatieById(bondsnummer, entity.Id, refresh, settings);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="Id"></param>
        /// <param name="refresh"></param>
        /// <param name="settings"></param>
        /// <returns></returns>
        private List<ClubCloud_Baanblok> GetBaanblokkenForAccommodatieById(string bondsnummer, Guid Id, bool refresh, ClubCloud_Setting settings)
        {
            List<ClubCloud_Baanblok> result = new List<ClubCloud_Baanblok>();

            ClubCloud_Accommodatie accommodatie = GetAccommodatieById(Id);

            if (accommodatie != null)
            {
                if (accommodatie.ClubCloud_Baan == null || accommodatie.ClubCloud_Baan.Count == 0)
                {
                    result = beheerModel.ClubCloud_Baanblokken.Where(b => b.AccommodatieId == Id).ToList();

                    foreach (ClubCloud_Baanblok baanblok in result)
                    {
                        accommodatie.ClubCloud_Baanblok.Add(baanblok);
                    }
                    beheerModel.SaveChanges();

                }

                if (refresh)
                {
                    result = new List<ClubCloud_Baanblok>();

                    if (settings == null || !settings.Access)
                        settings = GetSettings(bondsnummer);

                    if (settings != null && settings.Access && !string.IsNullOrWhiteSpace(settings.Password))
                    {
                        CookieContainer cc = RequestContainer(settings.Id.ToString(), settings.Password);

                        if (cc != null)
                        {
                            using (ClubCloud.KNLTB.ServIt.CrmService.CrmService service = CrmServices[settings.Id.ToString()])
                            {
                                bool moreRecords = true;
                                int pageNum = 1;
                                while (moreRecords)
                                {
                                    ConditionExpression condition = new ConditionExpression { AttributeName = "sgt_accommodatieid", Operator = ConditionOperator.Equal, uiname = accommodatie.Naam, uitype = "sgt_alg_accommodatie", Values = new object[1] { accommodatie.Id } };
                                    FilterExpression expression = new FilterExpression { FilterOperator = LogicalOperator.And, Conditions = new ConditionExpression[1] { condition } };

                                    List<BusinessEntity> entities = RetrieveMultiple(service, "sgt_alg_baanblok", out moreRecords, ref pageNum, expression);


                                    foreach (sgt_alg_baanblok baanblok in entities)
                                    {
                                        ClubCloud_Baanblok entity = beheerModel.ClubCloud_Baanblokken.Find(baanblok.sgt_alg_baanblokid.Value);

                                        if (entity == null)
                                        {
                                            entity = beheerModel.ClubCloud_Baanblokken.Create();
                                            entity.Id = baanblok.sgt_alg_baanblokid.Value;
                                        }

                                        BaanblokToEntity(baanblok, entity, settings);

                                        beheerModel.ClubCloud_Baanblokken.AddOrUpdate(entity);

                                    }
                                    beheerModel.SaveChanges();

                                    foreach (sgt_alg_baanblok baanblok in entities)
                                    {
                                        ClubCloud_Baanblok entity = beheerModel.ClubCloud_Baanblokken.Find(baanblok.sgt_alg_baanblokid.Value);
                                        accommodatie.ClubCloud_Baanblok.Add(entity);
                                    }
                                    beheerModel.SaveChanges();
                                }
                            }
                        }
                    }
                    result = beheerModel.ClubCloud_Baanblokken.Where(b => b.AccommodatieId.Value == Id).ToList();
                }
            }
            

            return result;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="entity"></param>
        /// <param name="refresh"></param>
        /// <param name="settings"></param>
        /// <returns></returns>
        private List<ClubCloud_Baan> GetBanenForAccommodatie(string bondsnummer, ClubCloud_Accommodatie entity, bool refresh, ClubCloud_Setting settings)
        {
            return GetBanenForAccommodatieById(bondsnummer, entity.Id, refresh, settings);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="Id"></param>
        /// <param name="refresh"></param>
        /// <param name="settings"></param>
        /// <returns></returns>
        private List<ClubCloud_Baan> GetBanenForAccommodatieById(string bondsnummer, Guid Id, bool refresh, ClubCloud_Setting settings)
        {
            List<ClubCloud_Baan> result = new List<ClubCloud_Baan>();

            ClubCloud_Accommodatie accommodatie = GetAccommodatieById(Id);

            if (accommodatie != null)
            {
                if (accommodatie.ClubCloud_Baan == null || accommodatie.ClubCloud_Baan.Count == 0)
                {
                    result = beheerModel.ClubCloud_Banen.Where(b => b.AccommodatieId.Value == Id).ToList();

                    foreach (ClubCloud_Baan baan in result)
                    {
                        accommodatie.ClubCloud_Baan.Add(baan);
                    }
                    beheerModel.SaveChanges();
                }

                if (refresh || result.Count != accommodatie.BanenAantal)
                {
                    if (settings == null || !settings.Access)
                        settings = GetSettings(bondsnummer);

                    if (settings != null && settings.Access && !string.IsNullOrWhiteSpace(settings.Password))
                    {
                        CookieContainer cc = RequestContainer(settings.Id.ToString(), settings.Password);

                        if (cc != null)
                        {
                            using (ClubCloud.KNLTB.ServIt.CrmService.CrmService service = CrmServices[settings.Id.ToString()])
                            {
                                bool moreRecords = true;
                                int pageNum = 1;
                                int banen_totaal = 0;

                                while (moreRecords)
                                {
                                    ConditionExpression condition = new ConditionExpression { AttributeName = "sgt_alg_accommodatieid", Operator = ConditionOperator.Equal, uiname = accommodatie.Naam, uitype = "sgt_alg_accommodatie", Values = new object[1] { accommodatie.Id } };
                                    FilterExpression expression = new FilterExpression { FilterOperator = LogicalOperator.And, Conditions = new ConditionExpression[1] { condition } };
                                    LinkEntity link = new LinkEntity { LinkToEntityName = "sgt_alg_accommodatie", LinkFromAttributeName = "sgt_accommodatieid", LinkToAttributeName = "sgt_alg_accommodatieid", LinkCriteria = expression };
                                    List<BusinessEntity> entities = RetrieveMultiple(service, "sgt_alg_baan", out moreRecords, ref pageNum, null, link);

                                    foreach (sgt_alg_baan baan in entities)
                                    {
                                        banen_totaal++;

                                        ClubCloud_Baan entity = beheerModel.ClubCloud_Banen.Find(baan.sgt_alg_baanid.Value);

                                        if(entity == null)
                                            entity = beheerModel.ClubCloud_Banen.Create();

                                        entity.Id = baan.sgt_alg_baanid.Value;

                                        BaanToEntity(baan, entity, settings);
                                        beheerModel.ClubCloud_Banen.AddOrUpdate(entity);
                                        /*
                                        bool isnew = false;
                                        if (entity == null)
                                        {
                                            
                                            entity.Id = baan.sgt_alg_baanid.Value;
                                            isnew = true;
                                        }

                                        entity.Naam = baan.sgt_alg_baan1;
                                        entity.Nummer = -1;
                                        string found = Regex.Match(baan.sgt_alg_baan1, @"\d+").Value;
                                        if (!string.IsNullOrWhiteSpace(found))
                                            entity.Nummer = int.Parse(found);

                                        if (baan.sgt_accommodatieid != null)
                                        {
                                            //accommodatie = GetAccommodatieById(bondsnummer, entity.sgt_accommodatieid.Value, false, settings);
                                            //if (accommodatie != null)
                                            entity.ClubCloud_Accommodatie = accommodatie;
                                            entity.AccommodatieId = baan.sgt_accommodatieid.Value;
                                        }

                                        if (baan.sgt_baanblokid != null)
                                        {
                                            ClubCloud_Baanblok baanblok = GetBaanblokById(baan.sgt_baanblokid.Value, refresh, settings); //GetBaanblokById(bondsnummer, entity.sgt_baanblokid.Value, false, settings);
                                            if (baanblok != null)
                                                entity.ClubCloud_Baanblok = baanblok;
                                            entity.BaanblokId = baan.sgt_baanblokid.Value;
                                        }


                                        if (baan.sgt_status != null)
                                            entity.Status = baan.sgt_status.name;

                                        if (baan.sgt_datum_keuring != null)
                                            entity.Keuring = DateTime.Parse(baan.sgt_datum_keuring.Value);
                                        entity.Actief = baan.statuscode.name;

                                        if (isnew)
                                            beheerModel.ClubCloud_Banen.Add(entity);
                                         */
                                    }
                                    accommodatie.BanenAantal = banen_totaal;
                                    beheerModel.SaveChanges();

                                    foreach (sgt_alg_baan baan in entities)
                                    {
                                        ClubCloud_Baan entity = beheerModel.ClubCloud_Banen.Find(baan.sgt_alg_baanid.Value);
                                        if (baan.sgt_baanblokid != null)
                                        {
                                            ClubCloud_Baanblok baanblok = GetBaanblokById(baan.sgt_baanblokid.Value, false, settings);
                                            if (baanblok != null)
                                                entity.ClubCloud_Baanblok = baanblok;
                                        }
                                    }

                                    foreach (sgt_alg_baan baan in entities)
                                    {
                                        ClubCloud_Baan entity = beheerModel.ClubCloud_Banen.Find(baan.sgt_alg_baanid.Value);
                                        accommodatie.ClubCloud_Baan.Add(entity);
                                    }

                                    beheerModel.SaveChanges();

                                }
                            }
                        }
                    }
                }
            }

            result = beheerModel.ClubCloud_Banen.Where(b => b.AccommodatieId.Value == Id).ToList();

            return result;
        }

        /*
        /// <summary>
        /// sgt_alg_baansoort
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="baansoortId"></param>
        /// <param name="refresh"></param>
        /// <returns></returns>
        private List<ClubCloud_Baan> GetBanenByAccommodatieId(string bondsnummer, Guid accommodatieId, bool refresh = false)
        {
            List<ClubCloud_Baan> banen = new List<ClubCloud_Baan>();

            ClubCloud_Accommodatie accommodatie = GetAccommodatieById(bondsnummer, accommodatieId);


            banen = beheerModel.ClubCloud_Banen.Where(b => b.AccommodatieId.Value == accommodatieId).ToList();

            if (banen == null || banen.Count == 0 || banen.Count != accommodatie.BanenAantal || refresh)
            {
                banen = new List<ClubCloud_Baan>();
                ClubCloud_Setting settings = GetSettings(bondsnummer);
                if (settings != null && settings.Access && !string.IsNullOrWhiteSpace(settings.Password))
                {
                    CookieContainer cc = RequestContainer(settings.Id.ToString(), settings.Password);

                    if (cc != null)
                    {
                        using (ClubCloud.KNLTB.ServIt.CrmService.CrmService service = CrmServices[settings.Id.ToString()])
                        {

                            ClubCloud_Accommodatie Accommodatie = beheerModel.ClubCloud_Accommodaties.Find(accommodatieId);
                            bool moreRecords = true;
                            int pageNum = 1;
                            int banen_totaal = 0;

                            while (moreRecords)
                            {
                                //<condition attribute="sgt_alg_accommodatieid" operator="eq" uiname="Kampong" uitype="sgt_alg_accommodatie" value="{11029F99-522E-4FC4-A86D-694E003F8BB2}"/>
                                ConditionExpression condition = new ConditionExpression { AttributeName = "sgt_alg_accommodatieid", Operator = ConditionOperator.Equal, uiname = Accommodatie.Naam, uitype = "sgt_alg_accommodatie", Values = new object[1] { Accommodatie.Id } };
                                //<filter type="and">
                                FilterExpression expression = new FilterExpression { FilterOperator = LogicalOperator.And, Conditions = new ConditionExpression[1] { condition } };
                                //<link-entity name="sgt_alg_accommodatie" from="sgt_alg_accommodatieid" to="sgt_accommodatieid" alias="aa">
                                LinkEntity link = new LinkEntity { LinkToEntityName = "sgt_alg_accommodatie", LinkFromAttributeName = "sgt_accommodatieid", LinkToAttributeName = "sgt_alg_accommodatieid", LinkCriteria = expression };
                                List<BusinessEntity> entities = RetrieveMultiple(service, "sgt_alg_baan", out moreRecords, ref pageNum, null, link);

                                foreach (sgt_alg_baan entity in entities)
                                {
                                    banen_totaal++;

                                    ClubCloud_Baan baan = beheerModel.ClubCloud_Banen.Find(entity.sgt_alg_baanid.Value);

                                    if (baan == null)
                                    {
                                        baan = beheerModel.ClubCloud_Banen.Create();
                                        baan.Id = entity.sgt_alg_baanid.Value;
                                        baan.Naam = entity.sgt_alg_baan1;
                                        baan.Nummer = -1;
                                        string found = Regex.Match(entity.sgt_alg_baan1, @"\d+").Value;
                                        if (!string.IsNullOrWhiteSpace(found))
                                            baan.Nummer = int.Parse(found);

                                        if (entity.sgt_accommodatieid != null)
                                        {
                                            accommodatie = GetAccommodatieById(bondsnummer, entity.sgt_accommodatieid.Value, false, settings);
                                            if (accommodatie != null)
                                                baan.ClubCloud_Accommodatie = accommodatie;
                                            baan.AccommodatieId = entity.sgt_accommodatieid.Value;
                                        }

                                        if (entity.sgt_baanblokid != null)
                                        {
                                            ClubCloud_Baanblok baanblok = GetBaanblokById(bondsnummer, entity.sgt_baanblokid.Value, false, settings);
                                            if (baanblok != null)
                                                baan.ClubCloud_Baanblok = baanblok;
                                            baan.BaanblokId = entity.sgt_baanblokid.Value;
                                        }


                                        if (entity.sgt_status != null)
                                            baan.Status = entity.sgt_status.name;

                                        if (entity.sgt_datum_keuring != null)
                                            baan.Keuring = DateTime.Parse(entity.sgt_datum_keuring.Value);

                                        baan.Actief = entity.statuscode.name;

                                        beheerModel.ClubCloud_Banen.Add(baan);
                                    }
                                    else
                                    {
                                        baan.Naam = entity.sgt_alg_baan1;
                                        baan.Nummer = -1;
                                        string found = Regex.Match(entity.sgt_alg_baan1, @"\d+").Value;
                                        if (!string.IsNullOrWhiteSpace(found))
                                            baan.Nummer = int.Parse(found);

                                        if (entity.sgt_accommodatieid != null)
                                        {
                                            accommodatie = GetAccommodatieById(bondsnummer, entity.sgt_accommodatieid.Value, false, settings);

                                            if (accommodatie != null)
                                                baan.ClubCloud_Accommodatie = accommodatie;
                                            baan.AccommodatieId = entity.sgt_accommodatieid.Value;
                                        }

                                        if (entity.sgt_baanblokid != null)
                                        {
                                            ClubCloud_Baanblok baanblok = GetBaanblokById(bondsnummer, entity.sgt_baanblokid.Value, false, settings);
                                            if (baanblok != null)
                                                baan.ClubCloud_Baanblok = baanblok;
                                            baan.BaanblokId = entity.sgt_baanblokid.Value;
                                        }

                                        if (entity.sgt_status != null)
                                            baan.Status = entity.sgt_status.name;

                                        if (entity.sgt_datum_keuring != null)
                                            baan.Keuring = DateTime.Parse(entity.sgt_datum_keuring.Value);

                                        baan.Actief = entity.statuscode.name;

                                    }
                                    beheerModel.SaveChanges();
                                }
                            }

                            Accommodatie.BanenAantal = banen_totaal;
                            beheerModel.SaveChanges();
                        }
                    }
                }
                banen = beheerModel.ClubCloud_Banen.Where(b => b.AccommodatieId.Value == accommodatieId).ToList();
            }
            return banen;
        }
        */

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="entity"></param>
        /// <param name="refresh"></param>
        /// <param name="settings"></param>
        /// <returns></returns>
        private List<ClubCloud_BaanSpeciaal> GetBanenSpeciaalForAccommodatie(string bondsnummer, ClubCloud_Accommodatie entity, bool refresh, ClubCloud_Setting settings)
        {
            return GetBanenSpeciaalForAccommodatieById(bondsnummer, entity.Id, refresh, settings);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="Id"></param>
        /// <param name="refresh"></param>
        /// <param name="settings"></param>
        /// <returns></returns>
        private List<ClubCloud_BaanSpeciaal> GetBanenSpeciaalForAccommodatieById(string bondsnummer, Guid Id, bool refresh, ClubCloud_Setting settings)
        {
            List<ClubCloud_BaanSpeciaal> result = null;

            ClubCloud_Accommodatie accommodatie = GetAccommodatieById(Id);

            if (accommodatie != null)
            {
                if (accommodatie.ClubCloud_BaanSpeciaal == null || accommodatie.ClubCloud_BaanSpeciaal.Count == 0)
                {
                    result = beheerModel.ClubCloud_BanenSpeciaal.Where(b => b.AccommodatieId.Value == Id).ToList();

                    foreach (ClubCloud_BaanSpeciaal baan in result)
                    {
                        accommodatie.ClubCloud_BaanSpeciaal.Add(baan);
                    }
                    beheerModel.SaveChanges();
                }

                if (refresh)
                {
                    if (settings == null)
                        settings = GetSettings(bondsnummer);

                    if (settings != null && settings.Access && !string.IsNullOrWhiteSpace(settings.Password))
                    {
                        CookieContainer cc = RequestContainer(settings.Id.ToString(), settings.Password);

                        if (cc != null)
                        {
                            using (ClubCloud.KNLTB.ServIt.CrmService.CrmService service = CrmServices[settings.Id.ToString()])
                            {
                                bool moreRecords = true;
                                int pageNum = 1;
                                while (moreRecords)
                                {
                                    ConditionExpression condition = new ConditionExpression { AttributeName = "sgt_alg_accommodatieid", Operator = ConditionOperator.Equal, uiname = accommodatie.Naam, uitype = "sgt_alg_accommodatie", Values = new object[1] { accommodatie.Id } };
                                    FilterExpression expression = new FilterExpression { FilterOperator = LogicalOperator.And, Conditions = new ConditionExpression[1] { condition } };
                                    LinkEntity link = new LinkEntity { LinkToEntityName = "sgt_alg_accommodatie", LinkFromAttributeName = "sgt_accommodatieid", LinkToAttributeName = "sgt_alg_accommodatieid", LinkCriteria = expression };
                                    List<BusinessEntity> entities = RetrieveMultiple(service, "sgt_alg_speciale_baan", out moreRecords, ref pageNum, null, link);

                                    foreach (sgt_alg_speciale_baan baanspeciaal in entities)
                                    {
                                        ClubCloud_BaanSpeciaal entity = beheerModel.ClubCloud_BanenSpeciaal.Find(baanspeciaal.sgt_alg_speciale_baanid.Value);

                                        if(entity == null)
                                            entity = beheerModel.ClubCloud_BanenSpeciaal.Create();

                                        entity.Id = baanspeciaal.sgt_alg_speciale_baanid.Value;

                                        BaanspeciaalToEntity(baanspeciaal, entity, settings);
                                        beheerModel.ClubCloud_BanenSpeciaal.AddOrUpdate(entity);
                                        /*
                                        ClubCloud_BaanSpeciaal baanspeciaal = beheerModel.ClubCloud_BanenSpeciaal.Find(baanspeciaal2.sgt_alg_speciale_baanid.Value);

                                        if (baanspeciaal == null)
                                        {
                                            baanspeciaal = beheerModel.ClubCloud_BanenSpeciaal.Create();
                                            baanspeciaal.Id = baanspeciaal2.sgt_alg_speciale_baanid.Value;
                                            baanspeciaal.Naam = baanspeciaal2.sgt_name;

                                            if (baanspeciaal2.sgt_accomodatieid != null)
                                            {
                                                ClubCloud_Accommodatie accommodatie = GetAccommodatieById(bondsnummer, baanspeciaal2.sgt_accomodatieid.Value, false);
                                                baanspeciaal.ClubCloud_Accommodatie = accommodatie;
                                                baanspeciaal.AccommodatieId = baanspeciaal2.sgt_accomodatieid.Value;
                                            }

                                            if (baanspeciaal2.sgt_soort_baan != null)
                                            {
                                                baanspeciaal.Baansoort = baanspeciaal2.sgt_soort_baan.name;
                                            }

                                            if (baanspeciaal2.sgt_toplaagid != null)
                                            {
                                                ClubCloud_Baantoplaag toplaag = GetBaanToplaagById(bondsnummer, baanspeciaal2.sgt_toplaagid.Value, false);
                                                baanspeciaal.ClubCloud_Baantoplaag = toplaag;
                                                baanspeciaal.BaantoplaagId = baanspeciaal2.sgt_toplaagid.Value;
                                            }

                                            baanspeciaal.Actief = baanspeciaal2.statuscode.name;

                                            beheerModel.ClubCloud_BanenSpeciaal.Add(baanspeciaal);
                                        }
                                        else
                                        {
                                            baanspeciaal.Naam = baanspeciaal2.sgt_name;

                                            if (baanspeciaal2.sgt_accomodatieid != null)
                                            {
                                                ClubCloud_Accommodatie accommodatie = GetAccommodatieById(bondsnummer, baanspeciaal2.sgt_accomodatieid.Value, false);
                                                baanspeciaal.ClubCloud_Accommodatie = accommodatie;
                                                baanspeciaal.AccommodatieId = baanspeciaal2.sgt_accomodatieid.Value;
                                            }

                                            if (baanspeciaal2.sgt_soort_baan != null)
                                            {
                                                baanspeciaal.Baansoort = baanspeciaal2.sgt_soort_baan.name;
                                            }

                                            if (baanspeciaal2.sgt_toplaagid != null)
                                            {
                                                ClubCloud_Baantoplaag toplaag = GetBaanToplaagById(bondsnummer, baanspeciaal2.sgt_toplaagid.Value, false);
                                                baanspeciaal.ClubCloud_Baantoplaag = toplaag;
                                                baanspeciaal.BaantoplaagId = baanspeciaal2.sgt_toplaagid.Value;
                                            }

                                            baanspeciaal.Actief = baanspeciaal2.statuscode.name;
                                        }
                                        */

                                    }
                                    beheerModel.SaveChanges();

                                    foreach (sgt_alg_speciale_baan baanspeciaal in entities)
                                    {
                                        ClubCloud_BaanSpeciaal entity = beheerModel.ClubCloud_BanenSpeciaal.Find(baanspeciaal.sgt_alg_speciale_baanid.Value);

                                        if (baanspeciaal.sgt_accomodatieid != null)
                                        {
                                            if (accommodatie != null)
                                                entity.ClubCloud_Accommodatie = accommodatie;
                                        }

                                        if (baanspeciaal.sgt_toplaagid != null)
                                        {
                                            ClubCloud_Baantoplaag toplaag = GetBaantoplaagById(baanspeciaal.sgt_toplaagid.Value, false, settings);
                                            if (toplaag != null)
                                                entity.ClubCloud_Baantoplaag = toplaag;
                                        }
                                    }
                                    beheerModel.SaveChanges();
                                }
                            }
                        }
                    }
                }
            }

            result = beheerModel.ClubCloud_BanenSpeciaal.Where(b => b.AccommodatieId.Value == Id).ToList();
            return result;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="entity"></param>
        /// <param name="refresh"></param>
        /// <param name="settings"></param>
        /// <returns></returns>
        private List<ClubCloud_Address> GetAddressenForAccommodatie(string bondsnummer, ClubCloud_Accommodatie entity, bool refresh, ClubCloud_Setting settings)
        {
            return GetAddressenForAccommodatieById(bondsnummer, entity.Id, refresh, settings);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="Id"></param>
        /// <param name="refresh"></param>
        /// <param name="settings"></param>
        /// <returns></returns>
        private List<ClubCloud_Address> GetAddressenForAccommodatieById(string bondsnummer, Guid Id, bool refresh, ClubCloud_Setting settings)
        {
            List<ClubCloud_Address> result = null;

            ClubCloud_Accommodatie entity = GetAccommodatieById(Id);
            if (entity != null)
            {
                if (entity.ClubCloud_Address == null || entity.ClubCloud_Address.Count == 0)
                {
                    result = beheerModel.ClubCloud_Addressen.Where(b => b.ParentId.Value == Id).ToList();

                    foreach (ClubCloud_Address address in result)
                    {
                        entity.ClubCloud_Address.Add(address);
                    }
                    beheerModel.SaveChanges();
                }

                if (refresh)
                {
                    if (settings == null)
                        settings = GetSettings(bondsnummer);

                    if (settings != null && settings.Access && !string.IsNullOrWhiteSpace(settings.Password))
                    {
                        CookieContainer cc = RequestContainer(settings.Id.ToString(), settings.Password);

                        if (cc != null)
                        {
                            using (ClubCloud.KNLTB.ServIt.CrmService.CrmService service = CrmServices[settings.Id.ToString()])
                            {
                                sgt_alg_accommodatie accommodatie = RetrieveEntity(service, "sgt_alg_accommodatie", Id) as sgt_alg_accommodatie;

                                if (accommodatie != null && accommodatie.sgt_alg_accommodatieid.Value == Id)
                                {
                                    List<ClubCloud_Address> entities = beheerModel.ClubCloud_Addressen.Where(b => b.ParentId.Value == Id).ToList();

                                    ClubCloud_Address bezoek_entity = null;
                                    ClubCloud_Address post_entity = null;

                                    if (entities != null && entities.Count > 0)
                                    {
                                        bezoek_entity = entities.SingleOrDefault(a => a.Naam == AddressSoort.Bezoekadres);
                                        post_entity = entities.SingleOrDefault(a => a.Naam == AddressSoort.Postadres);
                                    }

                                    if (bezoek_entity == null)
                                    { bezoek_entity = beheerModel.ClubCloud_Addressen.Create(); bezoek_entity.Id = Guid.NewGuid(); bezoek_entity.ParentId = Id; }

                                    if (post_entity == null)
                                    { post_entity = beheerModel.ClubCloud_Addressen.Create(); post_entity.Id = Guid.NewGuid(); post_entity.ParentId = Id; }


                                    if (accommodatie.sgt_bezoekadreslandcodeid != null)
                                    {
                                        bezoek_entity.LandId = accommodatie.sgt_bezoekadreslandcodeid.Value;
                                    }

                                    bezoek_entity.Naam = AddressSoort.Bezoekadres;
                                    bezoek_entity.Gemeente = accommodatie.sgt_bezoekadres_gemeente;
                                    bezoek_entity.Nummer = accommodatie.sgt_bezoekadres_huisnummer;
                                    bezoek_entity.Stad = accommodatie.sgt_bezoekadres_plaats;
                                    bezoek_entity.Postcode = accommodatie.sgt_bezoekadres_postcode;
                                    bezoek_entity.Straat = accommodatie.sgt_bezoekadres_straat;
                                    bezoek_entity.Toevoeging = accommodatie.sgt_bezoekadres_toevoeging;
                                    bezoek_entity.Actief = ActiefSoort.Actief;
                                    bezoek_entity.Gewijzigd = DateTime.Now;

                                    beheerModel.ClubCloud_Addressen.AddOrUpdate(bezoek_entity);

                                    if (accommodatie.sgt_postadreslandcodeid != null)
                                    {
                                        post_entity.LandId = accommodatie.sgt_bezoekadreslandcodeid.Value;
                                    }

                                    post_entity.Naam = AddressSoort.Postadres;
                                    post_entity.Gemeente = accommodatie.sgt_bezoekadres_gemeente;
                                    post_entity.Nummer = accommodatie.sgt_bezoekadres_huisnummer;
                                    post_entity.Stad = accommodatie.sgt_bezoekadres_plaats;
                                    post_entity.Postcode = accommodatie.sgt_bezoekadres_postcode;
                                    post_entity.Straat = accommodatie.sgt_bezoekadres_straat;
                                    post_entity.Toevoeging = accommodatie.sgt_bezoekadres_toevoeging;
                                    post_entity.Actief = ActiefSoort.Actief;
                                    post_entity.Gewijzigd = DateTime.Now;

                                    beheerModel.ClubCloud_Addressen.AddOrUpdate(post_entity);

                                    beheerModel.SaveChanges();

                                    bezoek_entity.ClubCloud_Accommodatie = entity;
                                    if (accommodatie.sgt_bezoekadreslandcodeid != null)
                                    {
                                        ClubCloud_Land land = GetLandById(accommodatie.sgt_bezoekadreslandcodeid.Value, false, settings);
                                        bezoek_entity.ClubCloud_Land = land;
                                    }

                                    post_entity.ClubCloud_Accommodatie = entity;
                                    if (accommodatie.sgt_postadreslandcodeid != null)
                                    {
                                        ClubCloud_Land land = GetLandById(accommodatie.sgt_postadreslandcodeid.Value, false, settings);
                                        post_entity.ClubCloud_Land = land;
                                    }

                                    beheerModel.SaveChanges();

                                    bezoek_entity.ClubCloud_Accommodatie = entity;
                                    post_entity.ClubCloud_Accommodatie = entity;
                                    entity.ClubCloud_Address.Add(bezoek_entity);
                                    entity.ClubCloud_Address.Add(post_entity);

                                    beheerModel.SaveChanges();
                                }
                            }

                        }
                    }

                    result = beheerModel.ClubCloud_Addressen.Where(b => b.ParentId.Value == Id).ToList();
                }
            }
            return result;
        }


        /*
        /// <summary>
        /// 
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="verenigingId"></param>
        /// <param name="refresh"></param>
        /// <param name="settings"></param>
        /// <returns></returns>
        private ClubCloud_Accommodatie GetAccommodatieByVereniging(string bondsnummer, Guid verenigingId, bool refresh = false, ClubCloud_Setting settings = null)
        {
            ClubCloud_Accommodatie Accommodatie = new ClubCloud_Accommodatie();

            Guid AccommodatieId = beheerModel.ClubCloud_Verenigingen.Find(verenigingId).AccommodatieId.Value;
            Accommodatie = beheerModel.ClubCloud_Accommodaties.Find(AccommodatieId);

            if (Accommodatie == null || refresh)
            {
                if (settings == null)
                {
                    settings = GetSettings(bondsnummer);
                }

                if (settings != null && settings.Access && !string.IsNullOrWhiteSpace(settings.Password))
                {
                    CookieContainer cc = RequestContainer(settings.Id.ToString(), settings.Password);

                    if (cc != null)
                    {
                        using (ClubCloud.KNLTB.ServIt.CrmService.CrmService service = CrmServices[settings.Id.ToString()])
                        {

                            //CrmService.CrmCookieContainer = cc;

                            bool moreRecords = true;
                            int pageNum = 1;
                            while (moreRecords)
                            {
                                ConditionExpression condition = new ConditionExpression { AttributeName = "sgt_alg_accommodatieid", Operator = ConditionOperator.Equal, Values = new object[1] { AccommodatieId } };
                                FilterExpression expression = new FilterExpression { FilterOperator = LogicalOperator.And, Conditions = new ConditionExpression[1] { condition } };

                                List<BusinessEntity> entities = RetrieveMultiple(service, "sgt_alg_accommodatie", out moreRecords, ref pageNum, expression);

                                foreach (sgt_alg_accommodatie entity in entities)
                                {
                                    Accommodatie = beheerModel.ClubCloud_Accommodaties.Find(entity.sgt_alg_accommodatieid.Value);

                                    if (Accommodatie == null)
                                    {
                                        Accommodatie = beheerModel.ClubCloud_Accommodaties.Create();
                                        Accommodatie.Id = entity.sgt_alg_accommodatieid.Value;
                                        EntityToAccommodatie(entity, Accommodatie, beheerModel, bondsnummer, settings);
                                        beheerModel.ClubCloud_Accommodaties.Add(Accommodatie);
                                    }
                                    else
                                    {
                                        EntityToAccommodatie(entity, Accommodatie, beheerModel, bondsnummer, settings);
                                    }
                                    beheerModel.SaveChanges();
                                }
                            }
                        }
                    }
                }
                Accommodatie = beheerModel.ClubCloud_Accommodaties.Find(AccommodatieId);
            }
            return Accommodatie;
        }
        */

        #region Mapping

        /// <summary>
        /// 
        /// </summary>
        /// <param name="accommodatie"></param>
        /// <param name="entity"></param>
        /// <param name="model"></param>
        /// <param name="bondsnummer"></param>
        /// <param name="settings"></param>
        private void AccommodatieToEntity(sgt_alg_accommodatie accommodatie, ClubCloud_Accommodatie entity, ClubCloud_Setting settings)        
        {
            entity.Naam = accommodatie.sgt_alg_accommodatie1;

            if (accommodatie.sgt_totaal_aantal_banen != null)
            {
                entity.BanenAantal = accommodatie.sgt_totaal_aantal_banen.Value;
            }

            if (accommodatie.sgt_aantal_banen_binnen != null)
            {
                entity.BanenAantalBinnen = accommodatie.sgt_aantal_banen_binnen.Value;
            }

            if (accommodatie.sgt_aantal_banen_buiten != null)
            {
                entity.BanenAantalBuiten = accommodatie.sgt_aantal_banen_buiten.Value;
            }

            if (accommodatie.sgt_blaashal != null)
            {
                entity.Blaashal = accommodatie.sgt_blaashal.Value;
            }

            if (accommodatie.sgt_soort_blaashal != null)
            {
                entity.BlaashalSoort = accommodatie.sgt_soort_blaashal.name;
            }

            if (accommodatie.sgt_baan_blaashal != null)
            {
                entity.BlaashalAantalBanen = accommodatie.sgt_baan_blaashal.Value;
            }

            if (accommodatie.sgt_playgrounds != null)
            {
                entity.Playgrounds = accommodatie.sgt_playgrounds.Value;
            }

            if (accommodatie.sgt_aantal_playgrounds != null)
            {
                entity.PlaygroundsAantal = accommodatie.sgt_aantal_playgrounds.Value;
            }

            if (accommodatie.sgt_oefenmuren != null)
            {
                entity.Oefenmuren = accommodatie.sgt_oefenmuren.Value;
            }

            if (accommodatie.sgt_aantal_oefenmuren != null)
            {
                entity.OefenmurenAantal = accommodatie.sgt_aantal_oefenmuren.Value;
            }

            if (accommodatie.sgt_minibanen != null)
            {
                entity.Minibanen = accommodatie.sgt_minibanen.Value;
            }

            if (accommodatie.sgt_aantal_minibanen != null)
            {
                entity.MinibanenAantal = accommodatie.sgt_aantal_minibanen.Value;
            }

            if (accommodatie.sgt_overkapping != null)
            {
                entity.Overkapping = accommodatie.sgt_overkapping.Value;
            }

            if (accommodatie.sgt_soort_overkapping != null)
            {
                entity.OverkappingSoort = accommodatie.sgt_soort_overkapping.name;
            }

            if (accommodatie.sgt_aantal_parkeerplaatsen != null)
            {
                entity.AantalParkeerplaatsen = accommodatie.sgt_aantal_parkeerplaatsen.Value;
            }

            if (accommodatie.sgt_aantal_mv_parkeerplaatsen != null)
            {
                entity.AantalParkeerplaatsenMindervalide = accommodatie.sgt_aantal_mv_parkeerplaatsen.Value;
            }

            if (accommodatie.sgt_ov_bereikbaar != null)
            {
                entity.MetOVBereikbaar = accommodatie.sgt_ov_bereikbaar.Value;
            }

            if (accommodatie.sgt_email != null)
            {
                entity.Email = accommodatie.sgt_email;
            }

            if (accommodatie.sgt_telefoon != null)
            {
                entity.Telefoon = accommodatie.sgt_telefoon;
            }

            if (accommodatie.sgt_website != null)
            {
                entity.Website = accommodatie.sgt_website;
            }

            if (accommodatie.sgt_status_clubhuis != null)
            {
                entity.ClubhuisStatus = accommodatie.sgt_status_clubhuis.name;
            }

            if (accommodatie.sgt_bouwjaar_clubhuis != null)
            {
                entity.ClubhuisBouwjaar = accommodatie.sgt_bouwjaar_clubhuis;
            }

            if (accommodatie.sgt_bouwaardid != null)
            {
                entity.ClubhuisBouwaard = accommodatie.sgt_bouwaardid.name;
            }

            if (accommodatie.sgt_m2_clubhuis != null)
            {
                entity.ClubhuisOppervlakte = accommodatie.sgt_m2_clubhuis.Value;
            }

            if (accommodatie.sgt_liggingid != null)
            {
                entity.ClubhuisLigging = accommodatie.sgt_liggingid.name;
            }

            if (accommodatie.sgt_beveiliging != null)
            {
                entity.ClubhuisBeveiliging = accommodatie.sgt_beveiliging.name;
            }

            if (accommodatie.sgt_status_hal != null)
            {
                entity.HalStatus = accommodatie.sgt_status_hal.name;
            }

            if (accommodatie.sgt_bouwjaar_hal != null)
            {
                entity.HalBouwjaar = accommodatie.sgt_bouwjaar_hal;
            }

            if (accommodatie.sgt_klasse_hal != null)
            {
                entity.HalBouwaard = accommodatie.sgt_klasse_hal.name;
            }

            if (accommodatie.sgt_m2_hal != null)
            {
                entity.HalOppervlakte = accommodatie.sgt_m2_hal.Value;
            }

            /*
            entity.sgt_aantal_douches_dames;
            entity.sgt_aantal_douches_heren;
            entity.sgt_aantal_ehbo_fysio_ruimtes;
            entity.sgt_aantal_fysio_ruimtes;
            entity.sgt_aantal_kleed_wasruimtes;
            entity.sgt_aantal_kleedruimte_dames;

            entity.sgt_aantal_toiletten;
            entity.sgt_aantal_toiletten_dames;
			
            entity.sgt_aantal_verg_wed_ruimtes;
            entity.sgt_aantal_wasruimtes_clubhuis;
            entity.sgt_aantal_wasruimtes_dames;
            entity.sgt_aantal_wasruimtes_heren;
            entity.sgt_aantal_wedstrijdruimtes;
			
			
            entity.sgt_ehbo_ruimte;
            entity.sgt_fysio_ruimte;
            entity.sgt_jeugdhonk;
            entity.sgt_kantine;
            entity.sgt_keuken;
            entity.sgt_kleedruimte;
            entity.sgt_kleedruimte_dames;
					 
            entity.sgt_rolstoeltoegankelijk;
            entity.sgt_soortverlichtingid;
            entity.sgt_speeltoestellen;
            entity.sgt_toiletten_mindervaliden;
            entity.sgt_vergaderruimte;
            entity.sgt_wasruimte;
            entity.sgt_wasruimte_dames;
            entity.sgt_wedstrijdruimte;
            */

            if (accommodatie.sgt_districtid != null)
            {
                //ClubCloud_District district = GetDistrictById(accommodatie.sgt_districtid.Value, false, settings);
                //entity.ClubCloud_District = district;
                entity.DistrictId = accommodatie.sgt_districtid.Value;
            }

            if (accommodatie.sgt_regioid != null)
            {
                //ClubCloud_Regio regio = GetRegioById(accommodatie.sgt_regioid.Value, false, settings);
                //entity.ClubCloud_Regio = regio;
                entity.RegioId = accommodatie.sgt_regioid.Value;
            }

            entity.Gewijzigd = DateTime.Now;
            /*
            Accommodatie.RolStoeltoegankelijk = entity.statuscode.name;            
            Accommodatie.Speeltoestellen = entity.statuscode.name;
            Accommodatie.Actief = entity.statuscode.name;
            */

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="entity"></param>
        /// <param name="accommodatie"></param>
        private void EntityToAccommodatie(sgt_alg_accommodatie accommodatie, ClubCloud_Accommodatie entity, ClubCloud_Setting settings)
        {

        }

        #endregion

        #endregion

        #region Address

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="addressId"></param>
        /// <param name="refresh"></param>
        /// <returns></returns>
        private ClubCloud_Address GetAddressById(string bondsnummer, Guid Id, bool refresh = false, ClubCloud_Setting settings = null)
        {
            ClubCloud_Address entity = null;

            entity = beheerModel.ClubCloud_Addressen.Find(Id);

            if (entity == null || refresh)
            {
                if (settings == null)
                    settings = GetSettings(bondsnummer);

                if (settings.Access && !string.IsNullOrWhiteSpace(settings.Password))
                {
                    CookieContainer cc = RequestContainer(settings.Id.ToString(), settings.Password);

                    if (cc != null)
                    {
                        using (ClubCloud.KNLTB.ServIt.CrmService.CrmService service = CrmServices[settings.Id.ToString()])
                        {
                            customeraddress address = RetrieveEntity(service, "customeraddress", Id) as customeraddress;

                            if (address != null && address.customeraddressid.Value == Id)
                            {
                                if (entity == null)
                                    entity = beheerModel.ClubCloud_Addressen.Create();

                                entity.Id = address.customeraddressid.Value;

                                AddressToEntity(address, entity, settings);

                                beheerModel.ClubCloud_Addressen.AddOrUpdate(entity);

                                beheerModel.SaveChanges();

                                Guid landid;
                                if (Guid.TryParse(address.country, out landid))
                                {
                                    ClubCloud_Land land = beheerModel.ClubCloud_Landen.Find(landid);
                                    if (land != null)
                                        entity.ClubCloud_Land = land;
                                }

                                beheerModel.SaveChanges();
                            }
                        }
                    }
                }
                entity = beheerModel.ClubCloud_Addressen.Find(Id);
            }
            return entity;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="refresh"></param>
        /// <param name="settings"></param>
        /// <returns></returns>
        private List<ClubCloud_Address> GetAddressen(string bondsnummer, bool refresh, ClubCloud_Setting settings)
        {
            List<ClubCloud_Address> addressen = new List<ClubCloud_Address>();

            addressen = beheerModel.ClubCloud_Addressen.ToList();

            if (addressen == null || addressen.Count == 0 || refresh)
            {
                addressen = new List<ClubCloud_Address>();

                if (settings == null)
                    settings = GetSettings(bondsnummer);

                if (settings != null && settings.Access && !string.IsNullOrWhiteSpace(settings.Password))
                {
                    CookieContainer cc = RequestContainer(settings.Id.ToString(), settings.Password);

                    if (cc != null)
                    {
                        using (ClubCloud.KNLTB.ServIt.CrmService.CrmService service = CrmServices[settings.Id.ToString()])
                        {
                            bool moreRecords = true;
                            int pageNum = 1;
                            while (moreRecords)
                            {
                                List<BusinessEntity> entities = RetrieveMultiple(service, "customeraddress", out moreRecords, ref pageNum);

                                foreach (customeraddress address in entities)
                                {
                                    ClubCloud_Address entity = beheerModel.ClubCloud_Addressen.Find(address.customeraddressid.Value);

                                    if (entity == null)
                                        entity = beheerModel.ClubCloud_Addressen.Create();

                                    entity.Id = address.customeraddressid.Value;

                                    AddressToEntity(address, entity, settings);

                                    beheerModel.ClubCloud_Addressen.AddOrUpdate(entity);
                                }
                                beheerModel.SaveChanges();

                                foreach (customeraddress address in entities)
                                {
                                    ClubCloud_Address entity = beheerModel.ClubCloud_Addressen.Find(address.customeraddressid.Value);

                                    Guid landid;
                                    if (Guid.TryParse(address.country, out landid))
                                    {
                                        ClubCloud_Land land = beheerModel.ClubCloud_Landen.Find(landid);
                                        if (land != null)
                                            entity.ClubCloud_Land = land;
                                    }
                                }

                                beheerModel.SaveChanges();
                            }
                        }
                    }
                }
                addressen = beheerModel.ClubCloud_Addressen.ToList();
            }
            return addressen;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="entity"></param>
        /// <param name="settings"></param>
        /// <returns></returns>
        private ClubCloud_Address SetAddress(string bondsnummer, ClubCloud_Address entity, ClubCloud_Setting settings)
        {
            try
            {
                if (entity.Id != Guid.Empty)
                {
                    if (settings == null)
                        settings = GetSettings(bondsnummer);

                    if (settings != null && settings.Access && !string.IsNullOrWhiteSpace(settings.Password))
                    {
                        CookieContainer cc = RequestContainer(settings.Id.ToString(), settings.Password);

                        if (cc != null)
                        {
                            using (ClubCloud.KNLTB.ServIt.CrmService.CrmService service = CrmServices[settings.Id.ToString()])
                            {
                                customeraddress found = RetrieveEntity(service, "customeraddress", entity.Id) as customeraddress;

                                if (found != null && found.customeraddressid.Value == entity.Id)
                                {
                                    EntityToAddress(found, entity, settings);

                                    //TargetUpdateCustomerAddress update = new TargetUpdateCustomerAddress {  CustomerAddress = found };
                                    //UpdateEntity(service, update);
                                    //UpdateEntity(service, found);
                                }

                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                string message = ex.Message;
            }

            if (entity.Id == Guid.Empty)
                entity.Id = Guid.NewGuid();

            return entity;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bonsnummer"></param>
        /// <param name="entity"></param>
        /// <param name="refresh"></param>
        /// <param name="settings"></param>
        /// <returns></returns>
        private ClubCloud_Vereniging GetVerenigingForAddress(string bondsnummer, ClubCloud_Address entity, bool refresh, ClubCloud_Setting settings)
        {
            return GetVerenigingForAddressById(bondsnummer, entity.Id, refresh, settings);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="Id"></param>
        /// <param name="refresh"></param>
        /// <param name="settings"></param>
        /// <returns></returns>
        private ClubCloud_Vereniging GetVerenigingForAddressById(string bondsnummer, Guid Id, bool refresh, ClubCloud_Setting settings)
        {
            ClubCloud_Vereniging result = null;

            ClubCloud_Address address = GetAddressById(Id);
            if (address != null)
            {
                if (address.ClubCloud_Vereniging == null && address.ParentId != null)
                {
                    result = beheerModel.ClubCloud_Verenigingen.Find(address.ParentId.Value);

                    if (result != null)
                    {
                        address.ClubCloud_Vereniging = result;
                        beheerModel.SaveChanges();
                    }
                    else
                    {
                        result = GetVerenigingById(bondsnummer, address.ParentId.Value, true, settings);

                        if (result != null)
                        {
                            address.ClubCloud_Vereniging = result;
                            beheerModel.SaveChanges();
                        }

                    }
                }

            }
            return result;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="entity"></param>
        /// <param name="refresh"></param>
        /// <param name="settings"></param>
        /// <returns></returns>
        private ClubCloud_Gebruiker GetGebruikerForAddress(string bondsnummer, ClubCloud_Address entity, bool refresh, ClubCloud_Setting settings)
        {
            return GetGebruikerForAddressById(bondsnummer, entity.Id, refresh, settings);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="Id"></param>
        /// <param name="refresh"></param>
        /// <param name="settings"></param>
        /// <returns></returns>
        private ClubCloud_Gebruiker GetGebruikerForAddressById(string bondsnummer, Guid Id, bool refresh, ClubCloud_Setting settings)
        {
            ClubCloud_Gebruiker result = null;

            ClubCloud_Address address = GetAddressById(Id);
            if (address != null)
            {
                if (address.ClubCloud_Gebruiker == null && address.ParentId != null)
                {
                    result = beheerModel.ClubCloud_Gebruikers.Find(address.ParentId.Value);

                    if (result != null)
                    {
                        address.ClubCloud_Gebruiker = result;
                        beheerModel.SaveChanges();
                    }
                    else
                    {
                        result = GetGebruikerById(bondsnummer, address.ParentId.Value, true, settings);

                        if (result != null)
                        {
                            address.ClubCloud_Gebruiker = result;
                            beheerModel.SaveChanges();
                        }

                    }
                }

            }
            return result;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="entity"></param>
        /// <param name="refresh"></param>
        /// <param name="settings"></param>
        /// <returns></returns>
        private ClubCloud_Regio GetRegioForAddress(string bondsnummer, ClubCloud_Address entity, bool refresh, ClubCloud_Setting settings)
        {
            return GetRegioForAddressById(bondsnummer, entity.Id, refresh, settings);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="Id"></param>
        /// <param name="refresh"></param>
        /// <param name="settings"></param>
        /// <returns></returns>
        private ClubCloud_Regio GetRegioForAddressById(string bondsnummer, Guid Id, bool refresh, ClubCloud_Setting settings)
        {
            ClubCloud_Regio result = null;

            ClubCloud_Address address = GetAddressById(Id);
            if (address != null)
            {
                if (address.ClubCloud_Regio == null && address.ParentId != null)
                {
                    result = beheerModel.ClubCloud_Regios.Find(address.ParentId.Value);

                    if (result != null)
                    {
                        address.ClubCloud_Regio = result;
                        beheerModel.SaveChanges();
                    }
                    else
                    {
                        result = GetRegioById(bondsnummer, address.ParentId.Value, true, settings);

                        if (result != null)
                        {
                            address.ClubCloud_Regio = result;
                            beheerModel.SaveChanges();
                        }

                    }
                }

            }
            return result;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="entity"></param>
        /// <param name="refresh"></param>
        /// <param name="settings"></param>
        /// <returns></returns>
        private ClubCloud_Land GetLandForAddress(string bondsnummer, ClubCloud_Address entity, bool refresh, ClubCloud_Setting settings)
        {
            return GetLandForAddressById(bondsnummer, entity.Id, refresh, settings);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="entity"></param>
        /// <param name="refresh"></param>
        /// <param name="settings"></param>
        /// <returns></returns>
        private ClubCloud_Land GetLandForAddressById(string bondsnummer, Guid Id, bool refresh, ClubCloud_Setting settings)
        {
            ClubCloud_Land result = null;

            ClubCloud_Address address = GetAddressById(Id);
            if (address != null)
            {
                if (address.ClubCloud_Land == null && address.LandId != null)
                {
                    result = beheerModel.ClubCloud_Landen.Find(address.LandId.Value);

                    if (result != null)
                    {
                        address.ClubCloud_Land = result;
                        beheerModel.SaveChanges();
                    }
                    else
                    {
                        result = GetLandById(bondsnummer, address.LandId.Value, true, settings);

                        if (result != null)
                        {
                            address.ClubCloud_Land = result;
                            beheerModel.SaveChanges();
                        }

                    }
                }

            }
            return result;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="entity"></param>
        /// <param name="refresh"></param>
        /// <param name="settings"></param>
        /// <returns></returns>
        private ClubCloud_Accommodatie GetAccommodatieForAddress(string bondsnummer, ClubCloud_Address entity, bool refresh, ClubCloud_Setting settings)
        {
            return GetAccommodatieForAddressById(bondsnummer, entity.Id, refresh, settings);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="Id"></param>
        /// <param name="refresh"></param>
        /// <param name="settings"></param>
        /// <returns></returns>
        private ClubCloud_Accommodatie GetAccommodatieForAddressById(string bondsnummer, Guid Id, bool refresh, ClubCloud_Setting settings)
        {
            ClubCloud_Accommodatie result = null;

            ClubCloud_Address address = GetAddressById(Id);
            if (address != null)
            {
                if (address.ClubCloud_Accommodatie == null && address.ParentId != null)
                {
                    result = beheerModel.ClubCloud_Accommodaties.Find(address.ParentId.Value);

                    if (result != null)
                    {
                        address.ClubCloud_Accommodatie = result;
                        beheerModel.SaveChanges();
                    }
                    else
                    {
                        result = GetAccommodatieById(bondsnummer, address.ParentId.Value, true, settings);

                        if (result != null)
                        {
                            address.ClubCloud_Accommodatie = result;
                            beheerModel.SaveChanges();
                        }

                    }
                }

            }
            return result;
        }

        /*
        /// <summary>
        /// 
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="parentId"></param>
        /// <param name="refresh"></param>
        /// <returns>List<ClubCloud_Address></returns>
        private List<ClubCloud_Address> GetAddressByParent(string bondsnummer, Guid parentId, bool refresh = false, ClubCloud_Setting settings = null)
        {
            List<ClubCloud_Address> addressen = new List<ClubCloud_Address>();

            addressen = beheerModel.ClubCloud_Addressen.Where(a => a.ParentId == parentId).ToList();

            if (addressen == null || refresh)
            {
                if (settings == null)
                {
                    settings = GetSettings(bondsnummer);
                }

                if (settings != null && settings.Access && !string.IsNullOrWhiteSpace(settings.Password))
                {
                    CookieContainer cc = RequestContainer(settings.Id.ToString(), settings.Password);

                    if (cc != null)
                    {
                        using (ClubCloud.KNLTB.ServIt.CrmService.CrmService service = CrmServices[settings.Id.ToString()])
                        {

                            bool moreRecords = true;
                            int pageNum = 1;
                            while (moreRecords)
                            {
                                ConditionExpression condition = new ConditionExpression { AttributeName = "parentid", Operator = ConditionOperator.Equal, Values = new object[1] { parentId } };
                                FilterExpression expression = new FilterExpression { FilterOperator = LogicalOperator.And, Conditions = new ConditionExpression[1] { condition } };

                                List<BusinessEntity> entities = RetrieveMultiple(service, "customeraddress", out moreRecords, ref pageNum, expression);

                                foreach (customeraddress entity in entities)
                                {
                                    ClubCloud_Address address = beheerModel.ClubCloud_Addressen.Find(entity.customeraddressid.Value);

                                    if (addressen == null)
                                    {
                                        address = beheerModel.ClubCloud_Addressen.Create();
                                        address.Id = entity.customeraddressid.Value;
                                        address.Stad = entity.city;
                                        if (entity.latitude != null)
                                        {
                                            address.Latitude = entity.latitude.Value;
                                        }
                                        if (entity.longitude != null)
                                        {
                                            address.Longitude = entity.longitude.Value;
                                        }

                                        if (entity.latitude != null && entity.longitude != null)
                                        {
                                            string LatitudeCI = entity.latitude.Value.ToString(CultureInfo.InvariantCulture);
                                            string LongitudeCI = entity.longitude.Value.ToString(CultureInfo.InvariantCulture);

                                            string PointInText = string.Format("POINT({0} {1})", LongitudeCI, LatitudeCI);

                                            address.GeoLocation = DbGeography.PointFromText(PointInText, 4326);
                                        }
                                        address.Gemeente = entity.county;
                                        address.Land = entity.country;
                                        address.Fax = entity.fax;
                                        address.Straat = entity.line1;
                                        address.Nummer = entity.line2;
                                        address.Toevoeging = entity.line3;
                                        address.Naam = entity.name;
                                        if (entity.parentid != null)
                                        {
                                            address.ParentId = entity.parentid.Value;
                                        }
                                        address.Postcode = entity.postalcode;
                                        address.Postbus = entity.postofficebox;
                                        address.Provincie = entity.stateorprovince;
                                        address.TelefoonPrimair = entity.telephone1;
                                        address.TelefoonSecundair = entity.telephone2;
                                        address.TelefoonTertiair = entity.telephone3;
                                        address.Gewijzigd = DateTime.Now;
                                        beheerModel.ClubCloud_Addressen.Add(address);
                                        //addressen.Add(address);

                                    }
                                    else
                                    {
                                        address.Stad = entity.city;
                                        if (entity.latitude != null)
                                        {
                                            address.Latitude = entity.latitude.Value;
                                        }
                                        if (entity.longitude != null)
                                        {
                                            address.Longitude = entity.longitude.Value;
                                        }

                                        if (entity.latitude != null && entity.longitude != null)
                                        {
                                            string LatitudeCI = entity.latitude.Value.ToString(CultureInfo.InvariantCulture);
                                            string LongitudeCI = entity.longitude.Value.ToString(CultureInfo.InvariantCulture);

                                            string PointInText = string.Format("POINT({0} {1})", LongitudeCI, LatitudeCI);

                                            address.GeoLocation = DbGeography.PointFromText(PointInText, 4326);
                                        }

                                        address.Gemeente = entity.county;
                                        address.Land = entity.country;
                                        address.Fax = entity.fax;
                                        address.Straat = entity.line1;
                                        address.Nummer = entity.line2;
                                        address.Toevoeging = entity.line3;
                                        address.Naam = entity.name;
                                        if (entity.parentid != null)
                                        {
                                            address.ParentId = entity.parentid.Value;
                                        }
                                        address.Postcode = entity.postalcode;
                                        address.Postbus = entity.postofficebox;
                                        address.Provincie = entity.stateorprovince;
                                        address.TelefoonPrimair = entity.telephone1;
                                        address.TelefoonSecundair = entity.telephone2;
                                        address.TelefoonTertiair = entity.telephone3;
                                        address.Gewijzigd = DateTime.Now;
                                        //addressen.Add(address);
                                    }
                                    beheerModel.SaveChanges();
                                }
                            }
                        }
                    }
                }
                addressen = beheerModel.ClubCloud_Addressen.Where(a => a.ParentId == parentId).ToList();
            }

            return addressen;
        }
        */

        #region Mapping

        /// <summary>
        /// 
        /// </summary>
        /// <param name="entity"></param>
        /// <param name="address"></param>
        private void EntityToAddress(customeraddress address, ClubCloud_Address entity, ClubCloud_Setting settings)
        {
            address.city = entity.Stad;
            if (entity.Latitude != null)
            {
                address.latitude = new CrmFloat { Value = entity.Latitude.Value };
            }
            if (entity.Longitude != null)
            {
                address.longitude = new CrmFloat { Value = entity.Longitude.Value };
            }

            address.county = entity.Gemeente;
            address.country = entity.LandId.Value.ToString();
            address.fax = entity.Fax;
            address.line1 = entity.Straat;
            address.line2 = entity.Nummer;
            address.line3 = entity.Toevoeging;
            address.name = entity.Naam.ToString();

            /*
            //No parent update on address             
            if (entity.ParentId != null)
            {
                address.parentid = new Lookup{  entity.ParentId.Value;
            }
            */

            address.postalcode = entity.Postcode;
            address.postofficebox = entity.Postbus;
            address.stateorprovince = entity.Provincie;
            address.telephone1 = entity.TelefoonPrimair;
            address.telephone2 = entity.TelefoonSecundair;
            address.telephone3 = entity.TelefoonTertiair;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="address"></param>
        /// <param name="entity"></param>
        private void AddressToEntity(customeraddress address, ClubCloud_Address entity, ClubCloud_Setting settings)
        {
            entity.Naam  = (AddressSoort)address.addressnumber.Value;

            entity.Stad = address.city;
            if (address.latitude != null)
            {
                entity.Latitude = address.latitude.Value;
            }
            if (address.longitude != null)
            {
                entity.Longitude = address.longitude.Value;
            }

            if (address.latitude != null && address.longitude != null)
            {
                string LatitudeCI = address.latitude.Value.ToString(CultureInfo.InvariantCulture);
                string LongitudeCI = address.longitude.Value.ToString(CultureInfo.InvariantCulture);

                string PointInText = string.Format("POINT({0} {1})", LongitudeCI, LatitudeCI);
                entity.GeoLocation = DbGeography.PointFromText(PointInText, 4326);
            }

            entity.Gemeente = address.county;
            Guid landid;
            if(Guid.TryParse(address.country, out landid))
                entity.LandId = landid;
                //entity.LandId = address.country;

            entity.Fax = address.fax;
            entity.Straat = address.line1;
            entity.Nummer = address.line2;
            entity.Toevoeging = address.line3;
            //entity.Naam = address.name.ToString();

            if (address.parentid != null)
            {
                entity.ParentId = address.parentid.Value;
            }
            entity.Postcode = address.postalcode;
            entity.Postbus = address.postofficebox;
            entity.Provincie = address.stateorprovince;
            entity.TelefoonPrimair = address.telephone1;
            entity.TelefoonSecundair = address.telephone2;
            entity.TelefoonTertiair = address.telephone3;
            entity.Gewijzigd = DateTime.Now;
        }

        #endregion

        #endregion

        #region Afbeelding

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="Id"></param>
        /// <param name="refresh"></param>
        /// <param name="settings"></param>
        /// <returns></returns>
        private ClubCloud_Sponsor_Afbeelding GetAfbeeldingById(string bondsnummer, Guid Id, bool refresh, ClubCloud_Setting settings)
        {
            return beheerModel.ClubCloud_Sponsor_Afbeeldingen.Find(Id);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="refresh"></param>
        /// <param name="settings"></param>
        /// <returns></returns>
        private List<ClubCloud_Sponsor_Afbeelding> GetAfbeeldingen(string bondsnummer, bool refresh, ClubCloud_Setting settings)
        {
            return beheerModel.ClubCloud_Sponsor_Afbeeldingen.ToList();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="entity"></param>
        /// <param name="settings"></param>
        /// <returns></returns>
        private ClubCloud_Sponsor_Afbeelding SetAfbeelding(string bondsnummer, ClubCloud_Sponsor_Afbeelding entity, ClubCloud_Setting settings)
        {
            if (entity.Id == Guid.Empty)
                entity.Id = Guid.NewGuid();

            return entity;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="entity"></param>
        /// <param name="refresh"></param>
        /// <param name="settings"></param>
        /// <returns></returns>
        private List<ClubCloud_Sponsor> GetSponsorenForAfbeelding(string bondsnummer, ClubCloud_Sponsor_Afbeelding entity, bool refresh, ClubCloud_Setting settings)
        {
            return GetSponsorenForAfbeeldingById(bondsnummer, entity.Id, refresh, settings);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="Id"></param>
        /// <param name="refresh"></param>
        /// <param name="settings"></param>
        /// <returns></returns>
        private List<ClubCloud_Sponsor> GetSponsorenForAfbeeldingById(string bondsnummer, Guid Id, bool refresh, ClubCloud_Setting settings)
        {
            List<ClubCloud_Sponsor> result = null;

            ClubCloud_Sponsor_Afbeelding afbeelding = GetAfbeeldingById(Id);
            if (afbeelding != null)
            {
                if (afbeelding.ClubCloud_Sponsor == null || afbeelding.ClubCloud_Sponsor.Count == 0)
                {
                    result = beheerModel.ClubCloud_Sponsoren.Where(v => v.AfbeeldingId.Value == Id).ToList();

                    foreach (ClubCloud_Sponsor item in result)
                    {
                        afbeelding.ClubCloud_Sponsor.Add(item);
                    }
                    beheerModel.SaveChanges();
                }

            }
            return result;
        }

        #endregion

        #region Afhang

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="Id"></param>
        /// <param name="refresh"></param>
        /// <param name="settings"></param>
        /// <returns></returns>
        private ClubCloud_Afhang GetAfhangById(string bondsnummer, Guid Id, bool refresh, ClubCloud_Setting settings)
        {
            return beheerModel.ClubCloud_Afhangen.Find(Id);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="refresh"></param>
        /// <param name="settings"></param>
        /// <returns></returns>
        private List<ClubCloud_Afhang> GetAfhangen(string bondsnummer, bool refresh, ClubCloud_Setting settings)
        {
            return beheerModel.ClubCloud_Afhangen.ToList();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="entity"></param>
        /// <param name="settings"></param>
        /// <returns></returns>
        private ClubCloud_Afhang SetAfhang(string bondsnummer, ClubCloud_Afhang entity, ClubCloud_Setting settings)
        {
            if (entity.Id == Guid.Empty)
                entity.Id = Guid.NewGuid();

            return entity;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="entity"></param>
        /// <param name="refresh"></param>
        /// <param name="settings"></param>
        /// <returns></returns>
        private ClubCloud_Vereniging GetVerenigingForAfhang(string bondsnummer, ClubCloud_Afhang entity, bool refresh, ClubCloud_Setting settings)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="Id"></param>
        /// <param name="refresh"></param>
        /// <param name="settings"></param>
        /// <returns></returns>
        private ClubCloud_Vereniging GetVerenigingForAfhangById(string bondsnummer, Guid Id, bool refresh, ClubCloud_Setting settings)
        {
            throw new NotImplementedException();
        }

        #endregion

        #region Baan

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="Id"></param>
        /// <param name="refresh"></param>
        /// <param name="settings"></param>
        /// <returns></returns>
        private ClubCloud_Baan GetBaanById(string bondsnummer, Guid Id, bool refresh, ClubCloud_Setting settings)
        {
            ClubCloud_Baan entity = new ClubCloud_Baan();
            entity = beheerModel.ClubCloud_Banen.Find(Id);

            if (entity == null || refresh)
            {
                if (settings == null)
                    settings = GetSettings(bondsnummer);

                if (settings != null && settings.Access && !string.IsNullOrWhiteSpace(settings.Password))
                {
                    CookieContainer cc = RequestContainer(settings.Id.ToString(), settings.Password);

                    if (cc != null)
                    {
                        using (ClubCloud.KNLTB.ServIt.CrmService.CrmService service = CrmServices[settings.Id.ToString()])
                        {

                            sgt_alg_baan baan = RetrieveEntity(service, "sgt_alg_baan", Id) as sgt_alg_baan;

                            if (baan != null && baan.sgt_alg_baanid.Value == Id)
                            {
                                if (entity == null)
                                    entity = beheerModel.ClubCloud_Banen.Create();

                                entity.Id = baan.sgt_alg_baanid.Value;

                                BaanToEntity(baan, entity, settings);

                                beheerModel.ClubCloud_Banen.AddOrUpdate(entity);

                                beheerModel.SaveChanges();

                                if (baan.sgt_accommodatieid != null)
                                {
                                    ClubCloud_Accommodatie accommodatie = GetAccommodatieById(baan.sgt_accommodatieid.Value, false, settings);
                                    if (accommodatie != null)
                                        entity.ClubCloud_Accommodatie = accommodatie;
                                }

                                if (baan.sgt_baanblokid != null)
                                {
                                    ClubCloud_Baanblok baanblok = GetBaanblokById(baan.sgt_baanblokid.Value, false, settings);
                                    if (baanblok != null)
                                        entity.ClubCloud_Baanblok = baanblok;
                                }

                                beheerModel.SaveChanges();
                            }
                        }
                    }
                }
            }

            entity = beheerModel.ClubCloud_Banen.Find(Id);

            return entity;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="verenigingId"></param>
        /// <param name="refresh"></param>
        /// <returns></returns>
        private List<ClubCloud_Baan> GetBanen(string bondsnummer, bool refresh = false, ClubCloud_Setting settings = null)
        {
            List<ClubCloud_Baan> banen = new List<ClubCloud_Baan>();

            banen = beheerModel.ClubCloud_Banen.ToList();

            if (banen == null || banen.Count == 0 || refresh)
            {
                banen = new List<ClubCloud_Baan>();

                if (settings == null)
                    settings = GetSettings(bondsnummer);

                if (settings != null && settings.Access && !string.IsNullOrWhiteSpace(settings.Password))
                {
                    CookieContainer cc = RequestContainer(settings.Id.ToString(), settings.Password);

                    if (cc != null)
                    {
                        using (ClubCloud.KNLTB.ServIt.CrmService.CrmService service = CrmServices[settings.Id.ToString()])
                        {
                            bool moreRecords = true;
                            int pageNum = 1;
                            while (moreRecords)
                            {
                                List<BusinessEntity> entities = RetrieveMultiple(service, "sgt_alg_baan", out moreRecords, ref pageNum);

                                foreach (sgt_alg_baan baan in entities)
                                {
                                    ClubCloud_Baan entity = beheerModel.ClubCloud_Banen.Find(baan.sgt_alg_baanid.Value);

                                    if (entity == null)
                                        entity = beheerModel.ClubCloud_Banen.Create();

                                    entity.Id = baan.sgt_alg_baanid.Value;

                                    BaanToEntity(baan, entity, settings);
                                    beheerModel.ClubCloud_Banen.AddOrUpdate(entity);                                    
                                }
                                beheerModel.SaveChanges();

                                foreach (sgt_alg_baan baan in entities)
                                {
                                    ClubCloud_Baan entity = beheerModel.ClubCloud_Banen.Find(baan.sgt_alg_baanid.Value);

                                    if (baan.sgt_accommodatieid != null)
                                    {
                                        ClubCloud_Accommodatie accommodatie = GetAccommodatieById(baan.sgt_accommodatieid.Value, false, settings);
                                        if (accommodatie != null)
                                            entity.ClubCloud_Accommodatie = accommodatie;
                                    }

                                    if (baan.sgt_baanblokid != null)
                                    {
                                        ClubCloud_Baanblok baanblok = GetBaanblokById(baan.sgt_baanblokid.Value, false, settings);
                                        if (baanblok != null)
                                            entity.ClubCloud_Baanblok = baanblok;
                                    }
                                }
                                beheerModel.SaveChanges();
                            }
                        }
                    }
                }
                banen = beheerModel.ClubCloud_Banen.ToList();
            }
            return banen;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="entity"></param>
        /// <param name="settings"></param>
        /// <returns></returns>
        private ClubCloud_Baan SetBaan(string bondsnummer, ClubCloud_Baan entity, ClubCloud_Setting settings)
        {
            try
            {
                if (entity.Id != Guid.Empty)
                {
                    if (settings == null)
                        settings = GetSettings(bondsnummer);

                    if (settings != null && settings.Access && !string.IsNullOrWhiteSpace(settings.Password))
                    {
                        CookieContainer cc = RequestContainer(settings.Id.ToString(), settings.Password);

                        if (cc != null)
                        {
                            using (ClubCloud.KNLTB.ServIt.CrmService.CrmService service = CrmServices[settings.Id.ToString()])
                            {
                                sgt_alg_baan found = RetrieveEntity(service, "sgt_alg_baan", entity.Id) as sgt_alg_baan;

                                if (found != null && found.sgt_alg_baanid.Value == entity.Id)
                                {
                                    EntityToBaan(found, entity, settings);

                                    //TargetUpdateSgt_alg_baan update = new TargetUpdateSgt_alg_baan { Sgt_alg_baan = found };
                                    //UpdateEntity(service, update);
                                    UpdateEntity(service, found);
                                }

                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                string message = ex.Message;
            }

            if (entity.Id == Guid.Empty)
                entity.Id = Guid.NewGuid();

            return entity;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="entity"></param>
        /// <param name="refresh"></param>
        /// <param name="settings"></param>
        /// <returns></returns>
        private ClubCloud_Baanblok GetBaanblokForBaan(string bondsnummer, ClubCloud_Baan entity, bool refresh, ClubCloud_Setting settings)
        {
            return GetBaanblokForBaanById(bondsnummer, entity.Id, refresh, settings);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="Id"></param>
        /// <param name="refresh"></param>
        /// <param name="settings"></param>
        /// <returns></returns>
        private ClubCloud_Baanblok GetBaanblokForBaanById(string bondsnummer, Guid Id, bool refresh, ClubCloud_Setting settings)
        {
            ClubCloud_Baanblok result = null;

            ClubCloud_Baan baan = GetBaanById(Id);
            if (baan != null)
            {
                if (baan.ClubCloud_Baanblok == null && baan.BaanblokId != null)
                {
                    result = beheerModel.ClubCloud_Baanblokken.Find(baan.BaanblokId.Value);

                    if (result != null)
                    {
                        baan.ClubCloud_Baanblok = result;
                        beheerModel.SaveChanges();
                    }
                    else
                    {
                        result = GetBaanblokById(bondsnummer, baan.BaanblokId.Value, true, settings);

                        if (result != null)
                        {
                            baan.ClubCloud_Baanblok = result;
                            beheerModel.SaveChanges();
                        }
                    }
                }

            }
            return result;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="entity"></param>
        /// <param name="refresh"></param>
        /// <param name="settings"></param>
        /// <returns></returns>
        private ClubCloud_Accommodatie GetAccommodatieForBaan(string bondsnummer, ClubCloud_Baan entity, bool refresh, ClubCloud_Setting settings)
        {
            return GetAccommodatieForBaanById(bondsnummer, entity.Id, refresh, settings);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="Id"></param>
        /// <param name="refresh"></param>
        /// <param name="settings"></param>
        /// <returns></returns>
        private ClubCloud_Accommodatie GetAccommodatieForBaanById(string bondsnummer, Guid Id, bool refresh, ClubCloud_Setting settings)
        {
            ClubCloud_Accommodatie result = null;

            ClubCloud_Baan baan = GetBaanById(Id);
            if (baan != null)
            {
                if (baan.ClubCloud_Accommodatie == null && baan.AccommodatieId != null)
                {
                    result = beheerModel.ClubCloud_Accommodaties.Find(baan.AccommodatieId);

                    if (result != null)
                    {
                        baan.ClubCloud_Accommodatie = result;
                        beheerModel.SaveChanges();
                    }
                    else
                    {
                        result = GetAccommodatieById(bondsnummer, baan.AccommodatieId.Value, refresh, settings);

                        if (result != null)
                        {
                            baan.ClubCloud_Accommodatie = result;
                            beheerModel.SaveChanges();
                        }
                    }
                }

            }
            return result;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="entity"></param>
        /// <param name="refresh"></param>
        /// <param name="settings"></param>
        /// <returns></returns>
        private List<ClubCloud_Baanschema> GetBaanschemasForBaan(string bondsnummer, ClubCloud_Baan entity, bool refresh, ClubCloud_Setting settings)
        {
            return GetBaanschemasForBaanById(bondsnummer, entity.Id, refresh, settings);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="Id"></param>
        /// <param name="refresh"></param>
        /// <param name="settings"></param>
        /// <returns></returns>
        private List<ClubCloud_Baanschema> GetBaanschemasForBaanById(string bondsnummer, Guid Id, bool refresh, ClubCloud_Setting settings)
        {
            List<ClubCloud_Baanschema> result = null;

            ClubCloud_Baan baan = GetBaanById(Id);
            if (baan != null)
            {
                if (baan.ClubCloud_Baanschema == null || baan.ClubCloud_Baanschema.Count == 0)
                {
                    result = beheerModel.ClubCloud_Baanschemas.Where(v => v.BaanId.Value == Id).ToList();

                    foreach (ClubCloud_Baanschema item in result)
                    {
                        baan.ClubCloud_Baanschema.Add(item);
                    }
                    beheerModel.SaveChanges();
                }

            }
            return result;
        }

        #region Mapping

        /// <summary>
        /// 
        /// </summary>
        /// <param name="baan"></param>
        /// <param name="entity"></param>
        private void EntityToBaan(sgt_alg_baan baan, ClubCloud_Baan entity, ClubCloud_Setting settings = null)
        {
            //baan.sgt_alg_baan1 = entity.Naam;

            //if (entity.AccommodatieId != null)
            //{
            //    ClubCloud_Accommodatie accommodatie = GetAccommodatieById(bondsnummer, entity.sgt_accommodatieid.Value, false, settings);
            //    if (accommodatie != null)
            //        baan.sgt_accommodatieid = new Lookup { name = accommodatie.Naam, Value = accommodatie.Id };
            //}

            //if (entity.Baanblokid != null)
            //{
            //    ClubCloud_Baanblok baanblok = GetBaanblokById(bondsnummer, entity.sgt_baanblokid.Value, false, settings);
            //    if (baanblok != null)
            //        baan.sgt_baanblokid = new Lookup{ name = baanblok.Naam, Value = baanblok.Id};
            //}

            //if (entity.sgt_datum_keuring != null)
            //    baan.Keuring = DateTime.Parse(entity.sgt_datum_keuring.Value);

            //baan.Actief = entity.statuscode.name;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="baan"></param>
        /// <param name="entity"></param>
        private void BaanToEntity(sgt_alg_baan baan, ClubCloud_Baan entity, ClubCloud_Setting settings)
        {
            entity.Naam = baan.sgt_alg_baan1;
            entity.Nummer = -1;
            string found = Regex.Match(baan.sgt_alg_baan1, @"\d+").Value;
            if (!string.IsNullOrWhiteSpace(found))
                entity.Nummer = int.Parse(found);

            if (baan.sgt_accommodatieid != null)
            {
                //ClubCloud_Accommodatie accommodatie = GetAccommodatieById(baan.sgt_accommodatieid.Value, false, settings);
                //if (accommodatie != null)
                //    entity.ClubCloud_Accommodatie = accommodatie;
                entity.AccommodatieId = baan.sgt_accommodatieid.Value;
            }

            if (baan.sgt_baanblokid != null)
            {
                //ClubCloud_Baanblok baanblok = GetBaanblokById(baan.sgt_baanblokid.Value, false, settings);
                //if (baanblok != null)
                //    entity.ClubCloud_Baanblok = baanblok;
                entity.BaanblokId = baan.sgt_baanblokid.Value;
            }

            if (baan.sgt_status != null)
                entity.Status = baan.sgt_status.name;

            if (baan.sgt_datum_keuring != null)
                entity.Keuring = DateTime.Parse(baan.sgt_datum_keuring.Value);

            entity.Actief = (ActiefSoort)baan.statuscode.Value;
        }

        #endregion

        #endregion

        #region BaanBlok

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="baanblokId"></param>
        /// <param name="refresh"></param>
        /// <param name="settings"></param>
        /// <returns></returns>
        private ClubCloud_Baanblok GetBaanblokById(string bondsnummer, Guid Id, bool refresh, ClubCloud_Setting settings)
        {
            ClubCloud_Baanblok entity = null;

            entity = beheerModel.ClubCloud_Baanblokken.Find(Id);

            if (entity == null || refresh)
            {

                if (settings == null)
                    settings = GetSettings(bondsnummer);

                if (settings != null && settings.Access && !string.IsNullOrWhiteSpace(settings.Password))
                {
                    CookieContainer cc = RequestContainer(settings.Id.ToString(), settings.Password);

                    if (cc != null)
                    {
                        using (ClubCloud.KNLTB.ServIt.CrmService.CrmService service = CrmServices[settings.Id.ToString()])
                        {
                            sgt_alg_baanblok baanblok = RetrieveEntity(service, "sgt_alg_baanblok", Id) as sgt_alg_baanblok;

                            if (baanblok != null && baanblok.sgt_alg_baanblokid.Value == Id)
                            {
                                if (entity == null)
                                    entity = beheerModel.ClubCloud_Baanblokken.Create();

                                entity.Id = baanblok.sgt_alg_baanblokid.Value;

                                BaanblokToEntity(baanblok, entity, settings);

                                beheerModel.ClubCloud_Baanblokken.AddOrUpdate(entity);

                                beheerModel.SaveChanges();

                                if (baanblok.sgt_accommodatieid != null)
                                {
                                    ClubCloud_Accommodatie accommodatie = GetAccommodatieById(baanblok.sgt_accommodatieid.Value, false, settings);
                                    if (accommodatie != null)
                                        entity.ClubCloud_Accommodatie = accommodatie;
                                }

                                if (baanblok.sgt_baansoortid != null)
                                {
                                    ClubCloud_Baansoort baansoort = GetBaansoortById(baanblok.sgt_baansoortid.Value, false, settings);
                                    if (baansoort != null)
                                        entity.ClubCloud_Baansoort = baansoort;
                                }

                                if (baanblok.sgt_baantypeid != null)
                                {
                                    ClubCloud_Baantype baantype = GetBaantypeById(baanblok.sgt_baantypeid.Value, false, settings);
                                    if (baantype != null)
                                        entity.ClubCloud_Baantype = baantype;
                                }

                                beheerModel.SaveChanges();
                            }
                        }
                    }
                }
            }
            entity = beheerModel.ClubCloud_Baanblokken.Find(Id);

            return entity;

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="refresh"></param>
        /// <param name="settings"></param>
        /// <returns></returns>
        private List<ClubCloud_Baanblok> GetBaanblokken(string bondsnummer, bool refresh, ClubCloud_Setting settings)
        {
            List<ClubCloud_Baanblok> baanblokken = new List<ClubCloud_Baanblok>();

            baanblokken = beheerModel.ClubCloud_Baanblokken.ToList();

            if (baanblokken == null || baanblokken.Count == 0 || refresh)
            {
                baanblokken = new List<ClubCloud_Baanblok>();

                if (settings == null)
                    settings = GetSettings(bondsnummer);

                if (settings != null && settings.Access && !string.IsNullOrWhiteSpace(settings.Password))
                {
                    CookieContainer cc = RequestContainer(settings.Id.ToString(), settings.Password);

                    if (cc != null)
                    {
                        using (ClubCloud.KNLTB.ServIt.CrmService.CrmService service = CrmServices[settings.Id.ToString()])
                        {

                            bool moreRecords = true;
                            int pageNum = 1;
                            while (moreRecords)
                            {
                                List<BusinessEntity> entities = RetrieveMultiple(service, "sgt_alg_baanblok", out moreRecords, ref pageNum);

                                foreach (sgt_alg_baanblok baanblok in entities)
                                {
                                    ClubCloud_Baanblok entity = beheerModel.ClubCloud_Baanblokken.Find(baanblok.sgt_alg_baanblokid.Value);

                                    if (entity == null)
                                        entity = beheerModel.ClubCloud_Baanblokken.Create();

                                    entity.Id = baanblok.sgt_alg_baanblokid.Value;

                                    BaanblokToEntity(baanblok, entity, settings);

                                    beheerModel.ClubCloud_Baanblokken.AddOrUpdate(entity);
                                }

                                beheerModel.SaveChanges();

                                foreach (sgt_alg_baanblok baanblok in entities)
                                {
                                    ClubCloud_Baanblok entity = beheerModel.ClubCloud_Baanblokken.Find(baanblok.sgt_alg_baanblokid.Value);

                                    if (baanblok.sgt_accommodatieid != null)
                                    {
                                        ClubCloud_Accommodatie accommodatie = GetAccommodatieById(baanblok.sgt_accommodatieid.Value, false, settings);
                                        if (accommodatie != null)
                                            entity.ClubCloud_Accommodatie = accommodatie;
                                    }

                                    if (baanblok.sgt_baansoortid != null)
                                    {
                                        ClubCloud_Baansoort baansoort = GetBaansoortById(baanblok.sgt_baansoortid.Value, false, settings);
                                        if (baansoort != null)
                                            entity.ClubCloud_Baansoort = baansoort;
                                    }

                                    if (baanblok.sgt_baantypeid != null)
                                    {
                                        ClubCloud_Baantype baantype = GetBaantypeById(baanblok.sgt_baantypeid.Value, false, settings);
                                        if (baantype != null)
                                            entity.ClubCloud_Baantype = baantype;
                                    }
                                }

                                beheerModel.SaveChanges();
                            }
                        }
                    }
                }
            }
            baanblokken = beheerModel.ClubCloud_Baanblokken.ToList();

            return baanblokken;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="entity"></param>
        /// <param name="settings"></param>
        /// <returns></returns>
        private ClubCloud_Baanblok SetBaanblok(string bondsnummer, ClubCloud_Baanblok entity, ClubCloud_Setting settings)
        {
            if (entity.Id == Guid.Empty)
                entity.Id = Guid.NewGuid();

            return entity;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="entity"></param>
        /// <param name="refresh"></param>
        /// <param name="settings"></param>
        /// <returns></returns>
        private List<ClubCloud_Baan> GetBanenForBaanblok(string bondsnummer, ClubCloud_Baanblok entity, bool refresh, ClubCloud_Setting settings)
        {
            return GetBanenForBaanblokById(bondsnummer, entity.Id, refresh, settings);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="Id"></param>
        /// <param name="refresh"></param>
        /// <param name="settings"></param>
        /// <returns></returns>
        private List<ClubCloud_Baan> GetBanenForBaanblokById(string bondsnummer, Guid Id, bool refresh, ClubCloud_Setting settings)
        {
            List<ClubCloud_Baan> result = null;

            ClubCloud_Baanblok baanblok = GetBaanblokById(Id);
            if (baanblok != null)
            {
                if (baanblok.ClubCloud_Baan == null || baanblok.ClubCloud_Baan.Count == 0)
                {
                    result = beheerModel.ClubCloud_Banen.Where(v => v.BaanblokId.Value == Id).ToList();

                    foreach (ClubCloud_Baan item in result)
                    {
                        baanblok.ClubCloud_Baan.Add(item);
                    }
                    beheerModel.SaveChanges();
                }

            }
            return result;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="entity"></param>
        /// <param name="refresh"></param>
        /// <param name="settings"></param>
        /// <returns></returns>
        private ClubCloud_Accommodatie GetAccommodatieForBaanblok(string bondsnummer, ClubCloud_Baanblok entity, bool refresh, ClubCloud_Setting settings)
        {
            return GetAccommodatieForBaanblokById(bondsnummer, entity.Id, refresh, settings);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="Id"></param>
        /// <param name="refresh"></param>
        /// <param name="settings"></param>
        /// <returns></returns>
        private ClubCloud_Accommodatie GetAccommodatieForBaanblokById(string bondsnummer, Guid Id, bool refresh, ClubCloud_Setting settings)
        {
            ClubCloud_Accommodatie result = null;

            ClubCloud_Baanblok baanblok = GetBaanblokById(Id);
            if (baanblok != null)
            {
                if (baanblok.ClubCloud_Accommodatie == null && baanblok.AccommodatieId != null)
                {
                    result = beheerModel.ClubCloud_Accommodaties.Find(baanblok.AccommodatieId.Value);

                    if (result != null)
                    {
                        baanblok.ClubCloud_Accommodatie = result;
                        beheerModel.SaveChanges();
                    }
                    else
                    {
                        result = GetAccommodatieById(bondsnummer, baanblok.AccommodatieId.Value, true, settings);

                        if (result != null)
                        {
                            baanblok.ClubCloud_Accommodatie = result;
                            beheerModel.SaveChanges();
                        }
                    }
                }

            }
            return result;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="entity"></param>
        /// <param name="refresh"></param>
        /// <param name="settings"></param>
        /// <returns></returns>
        private ClubCloud_Baantype GetBaantypeForBaanblok(string bondsnummer, ClubCloud_Baanblok entity, bool refresh, ClubCloud_Setting settings)
        {
            return GetBaantypeForBaanblokById(bondsnummer, entity.Id, refresh, settings);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="Id"></param>
        /// <param name="refresh"></param>
        /// <param name="settings"></param>
        /// <returns></returns>
        private ClubCloud_Baantype GetBaantypeForBaanblokById(string bondsnummer, Guid Id, bool refresh, ClubCloud_Setting settings)
        {
            ClubCloud_Baantype result = null;

            ClubCloud_Baanblok baanblok = GetBaanblokById(Id);
            if (baanblok != null)
            {
                if (baanblok.ClubCloud_Baantype == null && baanblok.BaantypeId != null)
                {
                    result = beheerModel.ClubCloud_Baantypes.Find(baanblok.BaantypeId.Value);

                    if (result != null)
                    {
                        baanblok.ClubCloud_Baantype = result;
                        beheerModel.SaveChanges();
                    }
                    else
                    {
                        result = GetBaantypeById(bondsnummer, baanblok.BaantypeId.Value, true, settings);

                        if (result != null)
                        {
                            baanblok.ClubCloud_Baantype = result;
                            beheerModel.SaveChanges();
                        }
                    }
                }

            }
            return result;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="entity"></param>
        /// <param name="refresh"></param>
        /// <param name="settings"></param>
        /// <returns></returns>
        private ClubCloud_Baansoort GetBaansoortForBaanblok(string bondsnummer, ClubCloud_Baanblok entity, bool refresh, ClubCloud_Setting settings)
        {
            return GetBaansoortForBaanblokById(bondsnummer, entity.Id, refresh, settings);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="Id"></param>
        /// <param name="refresh"></param>
        /// <param name="settings"></param>
        /// <returns></returns>
        private ClubCloud_Baansoort GetBaansoortForBaanblokById(string bondsnummer, Guid Id, bool refresh, ClubCloud_Setting settings)
        {
            ClubCloud_Baansoort result = null;

            ClubCloud_Baanblok baanblok = GetBaanblokById(Id);
            if (baanblok != null)
            {
                if (baanblok.ClubCloud_Baansoort == null && baanblok.BaansoortId != null)
                {
                    result = beheerModel.ClubCloud_Baansoorten.Find(baanblok.BaansoortId.Value);

                    if (result != null)
                    {
                        baanblok.ClubCloud_Baansoort = result;
                        beheerModel.SaveChanges();
                    }
                    else
                    {
                        result = GetBaansoortById(bondsnummer, baanblok.BaansoortId.Value, true, settings);

                        if (result != null)
                        {
                            baanblok.ClubCloud_Baansoort = result;
                            beheerModel.SaveChanges();
                        }
                    }
                }

            }
            return result;
        }

        #region Mapping

        /// <summary>
        /// 
        /// </summary>
        /// <param name="baanblok"></param>
        /// <param name="entity"></param>
        /// <param name="settings"></param>
        private void BaanblokToEntity(sgt_alg_baanblok baanblok, ClubCloud_Baanblok entity, ClubCloud_Setting settings)
        {
            entity.Naam = baanblok.sgt_alg_baanblok1;

            if (baanblok.sgt_accommodatieid != null)
            {
                //ClubCloud_Accommodatie accommodatie = GetAccommodatieById(baanblok.sgt_accommodatieid.Value, false, settings);
                //if (accommodatie != null)
                //    entity.ClubCloud_Accommodatie = accommodatie;
                entity.AccommodatieId = baanblok.sgt_accommodatieid.Value;
            }

            if (baanblok.sgt_baansoortid != null)
            {
                //ClubCloud_Baansoort baansoort = GetBaansoortById(baanblok.sgt_baansoortid.Value, false,settings);
                //if (baansoort != null)
                //    entity.ClubCloud_Baansoort = baansoort;
                entity.BaansoortId = baanblok.sgt_baansoortid.Value;
            }

            if (baanblok.sgt_baantypeid != null)
            {
                //ClubCloud_Baantype baantype = GetBaantypeById(baanblok.sgt_baantypeid.Value, false, settings);
                //if (baantype != null)
                //    entity.ClubCloud_Baantype = baantype;
                entity.BaantypeId = baanblok.sgt_baantypeid.Value;
            }

            if (baanblok.sgt_verlichting != null)
            {
                entity.Verlichting = baanblok.sgt_verlichting.Value;
            }

            if (baanblok.sgt_locatie_bb != null)
            {
                entity.Locatie = baanblok.sgt_locatie_bb.name; ;
            }

            entity.Actief = (ActiefSoort)baanblok.statuscode.Value;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="baanblok"></param>
        /// <param name="entity"></param>
        /// <param name="settings"></param>
        private void EntityToBaanblok(sgt_alg_baanblok baanblok, ClubCloud_Baanblok entity, ClubCloud_Setting settings)
        {            
        }

        #endregion

        #endregion

        #region Baanschema

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="Id"></param>
        /// <param name="refresh"></param>
        /// <param name="settings"></param>
        /// <returns></returns>
        private ClubCloud_Baanschema GetBaanschemaById(string bondsnummer, Guid Id, bool refresh, ClubCloud_Setting settings)
        {
            return beheerModel.ClubCloud_Baanschemas.Find(Id);
        }

        /// <summary>
        /// /
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="refresh"></param>
        /// <param name="settings"></param>
        /// <returns></returns>
        private List<ClubCloud_Baanschema> GetBaanschemas(string bondsnummer, bool refresh, ClubCloud_Setting settings)
        {
            return beheerModel.ClubCloud_Baanschemas.Where(b => b.VerenigingId == settings.VerenigingId).ToList();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="entity"></param>
        /// <param name="settings"></param>
        /// <returns></returns>
        private ClubCloud_Baanschema SetBaanschema(string bondsnummer, ClubCloud_Baanschema entity, ClubCloud_Setting settings)
        {
            if (entity.Id == Guid.Empty)
                entity.Id = Guid.NewGuid();

            return entity;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="entity"></param>
        /// <param name="refresh"></param>
        /// <param name="settings"></param>
        /// <returns></returns>
        private ClubCloud_Baan GetBaanForBaanschema(string bondsnummer, ClubCloud_Baanschema entity, bool refresh, ClubCloud_Setting settings)
        {
            return GetBaanForBaanschemaById(bondsnummer, entity.Id, refresh, settings);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="Id"></param>
        /// <param name="refresh"></param>
        /// <param name="settings"></param>
        /// <returns></returns>
        private ClubCloud_Baan GetBaanForBaanschemaById(string bondsnummer, Guid Id, bool refresh, ClubCloud_Setting settings)
        {
            ClubCloud_Baan result = null;

            ClubCloud_Baanschema baanschema = beheerModel.ClubCloud_Baanschemas.Find(Id);
            if (baanschema != null)
            {
                if (baanschema.ClubCloud_Baan == null && baanschema.BaanId != null)
                {
                    result = beheerModel.ClubCloud_Banen.Find(baanschema.BaanId.Value);

                    if (result != null)
                    {
                        baanschema.ClubCloud_Baan = result;
                        beheerModel.SaveChanges();
                    }
                    else
                    {
                        result = GetBaanById(bondsnummer, baanschema.BaanId.Value, true, settings);

                        if (result != null)
                        {
                            baanschema.ClubCloud_Baan = result;
                            beheerModel.SaveChanges();
                        }
                    }
                }

            }
            return result;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="entity"></param>
        /// <param name="refresh"></param>
        /// <param name="settings"></param>
        /// <returns></returns>
        private ClubCloud_Vereniging GetVerenigingForBaanschema(string bondsnummer, ClubCloud_Baanschema entity, bool refresh, ClubCloud_Setting settings)
        {
            return GetVerenigingForBaanschemaById(bondsnummer, entity.Id, refresh, settings);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="Id"></param>
        /// <param name="refresh"></param>
        /// <param name="settings"></param>
        /// <returns></returns>
        private ClubCloud_Vereniging GetVerenigingForBaanschemaById(string bondsnummer, Guid Id, bool refresh, ClubCloud_Setting settings)
        {
            ClubCloud_Vereniging result = null;

            ClubCloud_Baanschema baanschema = beheerModel.ClubCloud_Baanschemas.Find(Id);
            if (baanschema != null)
            {
                if (baanschema.ClubCloud_Vereniging == null && baanschema.VerenigingId != null)
                {
                    result = beheerModel.ClubCloud_Verenigingen.Find(baanschema.VerenigingId.Value);

                    if (result != null)
                    {
                        baanschema.ClubCloud_Vereniging = result;
                        beheerModel.SaveChanges();
                    }
                    else
                    {
                        result = GetVerenigingById(bondsnummer, baanschema.VerenigingId.Value, true, settings);

                        if (result != null)
                        {
                            baanschema.ClubCloud_Vereniging = result;
                            beheerModel.SaveChanges();
                        }
                    }
                }

            }
            return result;
        }

        #endregion

        #region Baansoort

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="Id"></param>
        /// <param name="refresh"></param>
        /// <param name="settings"></param>
        /// <returns></returns>
        private ClubCloud_Baansoort GetBaansoortById(string bondsnummer, Guid Id, bool refresh, ClubCloud_Setting settings)
        {
            ClubCloud_Baansoort entity = null;

            entity = beheerModel.ClubCloud_Baansoorten.Find(Id);

            if (entity == null || refresh)
            {
                if (settings == null)
                    settings = GetSettings(bondsnummer);

                if (settings != null && settings.Access && !string.IsNullOrWhiteSpace(settings.Password))
                {
                    CookieContainer cc = RequestContainer(settings.Id.ToString(), settings.Password);

                    if (cc != null)
                    {
                        using (ClubCloud.KNLTB.ServIt.CrmService.CrmService service = CrmServices[settings.Id.ToString()])
                        {
                            sgt_alg_baansoort baansoort = RetrieveEntity(service, "sgt_alg_baansoort", Id) as sgt_alg_baansoort;

                            if (baansoort != null && baansoort.sgt_alg_baansoortid.Value == Id)
                            {
                                if(entity == null)
                                    entity = beheerModel.ClubCloud_Baansoorten.Create();

                                entity.Id = baansoort.sgt_alg_baansoortid.Value;

                                BaansoortToEntity(baansoort, entity, settings);

                                beheerModel.ClubCloud_Baansoorten.AddOrUpdate(entity);

                                beheerModel.SaveChanges();

                                if (baansoort.sgt_baantypeid != null)
                                {
                                    ClubCloud_Baantype baantype = GetBaantypeById(baansoort.sgt_baantypeid.Value, false, settings);
                                    if (baantype != null)
                                        entity.ClubCloud_Baantype = baantype;
                                    entity.BaantypeId = baansoort.sgt_baantypeid.Value;
                                }

                                beheerModel.SaveChanges();
                            }
                        }
                    }
                }
            }

            entity = beheerModel.ClubCloud_Baansoorten.Find(Id);

            return entity;
        }

        /// <summary>
        /// sgt_alg_baansoort
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="refresh"></param>
        /// <returns></returns>
        private List<ClubCloud_Baansoort> GetBaansoorten(string bondsnummer, bool refresh, ClubCloud_Setting settings)
        {
            List<ClubCloud_Baansoort> baansoorten = new List<ClubCloud_Baansoort>();

            baansoorten = beheerModel.ClubCloud_Baansoorten.ToList();

            if (baansoorten == null || baansoorten.Count == 0 || refresh)
            {
                if (settings == null)
                    settings = GetSettings(bondsnummer);

                if (settings != null && settings.Access && !string.IsNullOrWhiteSpace(settings.Password))
                {
                    CookieContainer cc = RequestContainer(settings.Id.ToString(), settings.Password);

                    if (cc != null)
                    {
                        using (ClubCloud.KNLTB.ServIt.CrmService.CrmService service = CrmServices[settings.Id.ToString()])
                        {
                            bool moreRecords = true;
                            int pageNum = 1;
                            while (moreRecords)
                            {
                                List<BusinessEntity> entities = RetrieveMultiple(service, "sgt_alg_baansoort", out moreRecords, ref pageNum);

                                foreach (sgt_alg_baansoort baansoort in entities)
                                {
                                    ClubCloud_Baansoort entity = beheerModel.ClubCloud_Baansoorten.Find(baansoort.sgt_alg_baansoortid.Value);

                                    if(entity == null)
                                        entity = beheerModel.ClubCloud_Baansoorten.Create();

                                    entity.Id = baansoort.sgt_alg_baansoortid.Value;

                                    BaansoortToEntity(baansoort, entity, settings);

                                    beheerModel.ClubCloud_Baansoorten.AddOrUpdate(entity);
                                }

                                beheerModel.SaveChanges();

                                foreach (sgt_alg_baansoort baansoort in entities)
                                {
                                    ClubCloud_Baansoort entity = beheerModel.ClubCloud_Baansoorten.Find(baansoort.sgt_alg_baansoortid.Value);
                                    if (baansoort.sgt_baantypeid != null)
                                    {
                                        ClubCloud_Baantype baantype = GetBaantypeById(baansoort.sgt_baantypeid.Value, false, settings);
                                        if (baantype != null)
                                            entity.ClubCloud_Baantype = baantype;
                                        entity.BaantypeId = baansoort.sgt_baantypeid.Value;
                                    }
                                }

                                beheerModel.SaveChanges();
                            }
                        }
                    }
                }
                baansoorten = beheerModel.ClubCloud_Baansoorten.ToList();
            }

            return baansoorten;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="entity"></param>
        /// <param name="settings"></param>
        /// <returns></returns>
        private ClubCloud_Baansoort SetBaansoort(string bondsnummer, ClubCloud_Baansoort entity, ClubCloud_Setting settings)
        {
            if (entity.Id == Guid.Empty)
                entity.Id = Guid.NewGuid();

            return entity;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="entity"></param>
        /// <param name="refresh"></param>
        /// <param name="settings"></param>
        /// <returns></returns>
        private ClubCloud_Baantype GetBaantypeForBaansoort(string bondsnummer, ClubCloud_Baansoort entity, bool refresh, ClubCloud_Setting settings)
        {
            return GetBaantypeForBaansoortById(bondsnummer, entity.Id, refresh, settings);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="Id"></param>
        /// <param name="refresh"></param>
        /// <param name="settings"></param>
        /// <returns></returns>
        private ClubCloud_Baantype GetBaantypeForBaansoortById(string bondsnummer, Guid Id, bool refresh, ClubCloud_Setting settings)
        {
            ClubCloud_Baantype result = null;

            ClubCloud_Baansoort baansoort = beheerModel.ClubCloud_Baansoorten.Find(Id);
            if (baansoort != null)
            {
                if (baansoort.ClubCloud_Baantype == null && baansoort.BaantypeId != null)
                {
                    result = beheerModel.ClubCloud_Baantypes.Find(baansoort.BaantypeId.Value);

                    if (result != null)
                    {
                        baansoort.ClubCloud_Baantype = result;
                        beheerModel.SaveChanges();
                    }
                    else
                    {
                        result = GetBaantypeById(bondsnummer, baansoort.BaantypeId.Value, true, settings);

                        if (result != null)
                        {
                            baansoort.ClubCloud_Baantype = result;
                            beheerModel.SaveChanges();
                        }
                    }
                }

            }
            return result;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="entity"></param>
        /// <param name="refresh"></param>
        /// <param name="settings"></param>
        /// <returns></returns>
        private List<ClubCloud_Baanblok> GetBaanblokkenForBaansoort(string bondsnummer, ClubCloud_Baansoort entity, bool refresh, ClubCloud_Setting settings)
        {
            return GetBaanblokkenForBaansoortById(bondsnummer, entity.Id, refresh, settings);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="Id"></param>
        /// <param name="refresh"></param>
        /// <param name="settings"></param>
        /// <returns></returns>
        private List<ClubCloud_Baanblok> GetBaanblokkenForBaansoortById(string bondsnummer, Guid Id, bool refresh, ClubCloud_Setting settings)
        {
            List<ClubCloud_Baanblok> result = null;

            ClubCloud_Baansoort baansoort = beheerModel.ClubCloud_Baansoorten.Find(Id);
            if (baansoort != null)
            {
                if (baansoort.ClubCloud_Baanblok == null || baansoort.ClubCloud_Baanblok.Count == 0)
                {
                    result = beheerModel.ClubCloud_Baanblokken.Where(v => v.BaansoortId.Value == Id).ToList();

                    foreach (ClubCloud_Baanblok item in result)
                    {
                        baansoort.ClubCloud_Baanblok.Add(item);
                    }
                    beheerModel.SaveChanges();
                }

            }
            return result;
        }

        #region Mapping
        /// <summary>
        /// 
        /// </summary>
        /// <param name="baansoort"></param>
        /// <param name="entity"></param>
        /// <param name="settings"></param>
        private void BaansoortToEntity(sgt_alg_baansoort baansoort, ClubCloud_Baansoort entity, ClubCloud_Setting settings)
        {
            entity.Naam = baansoort.sgt_alg_baansoort1;

            if (baansoort.sgt_beschrijving != null)
            {
                entity.Beschrijving = baansoort.sgt_beschrijving;
            }

            if (baansoort.sgt_omschrijving != null)
            {
                entity.Omschrijving = baansoort.sgt_omschrijving;
            }

            if (baansoort.sgt_baantypeid != null)
            {
                //ClubCloud_Baantype baantype = GetBaantypeById(baansoort.sgt_baantypeid.Value, false, settings);
                //if(baantype != null)
                //    entity.ClubCloud_Baantype = baantype;
                entity.BaantypeId = baansoort.sgt_baantypeid.Value;
            }

            if (baansoort.sgt_verkorte_code != null)
            {
                entity.Code = baansoort.sgt_verkorte_code;
            }

            if (baansoort.sgt_meervoudsnaam != null)
            {
                entity.Meervoud = baansoort.sgt_meervoudsnaam;
            }
            entity.Actief = (ActiefSoort)baansoort.statuscode.Value;
        }

        private void EntityToBaansoort(sgt_alg_baansoort baansoort, ClubCloud_Baansoort entity, ClubCloud_Setting settings)
        {

        }

        #endregion

        #endregion

        #region BaanSpeciaal

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="baantypeId"></param>
        /// <param name="naam"></param>
        /// <param name="refresh"></param>
        /// <returns></returns>
        private ClubCloud_BaanSpeciaal GetBaanSpeciaalById(string bondsnummer, Guid Id, bool refresh, ClubCloud_Setting settings)
        {
            ClubCloud_BaanSpeciaal entity = new ClubCloud_BaanSpeciaal();

            entity = beheerModel.ClubCloud_BanenSpeciaal.Find(Id);

            if (entity == null || refresh)
            {
                if(settings == null)
                    settings = GetSettings(bondsnummer);

                if (settings != null && settings.Access && !string.IsNullOrWhiteSpace(settings.Password))
                {
                    CookieContainer cc = RequestContainer(settings.Id.ToString(), settings.Password);

                    if (cc != null)
                    {
                        using (ClubCloud.KNLTB.ServIt.CrmService.CrmService service = CrmServices[settings.Id.ToString()])
                        {
                            sgt_alg_speciale_baan specialebaan = RetrieveEntity(service, "sgt_alg_speciale_baan", Id) as sgt_alg_speciale_baan;

                            if (specialebaan != null && specialebaan.sgt_alg_speciale_baanid.Value == Id)
                            {
                                if(entity == null)
                                    entity = beheerModel.ClubCloud_BanenSpeciaal.Create();

                                entity.Id = specialebaan.sgt_alg_speciale_baanid.Value;
                                BaanspeciaalToEntity(specialebaan, entity, settings);

                                beheerModel.ClubCloud_BanenSpeciaal.AddOrUpdate(entity);

                                beheerModel.SaveChanges();

                                if (specialebaan.sgt_accomodatieid != null)
                                {
                                    ClubCloud_Accommodatie accommodatie = GetAccommodatieById(specialebaan.sgt_accomodatieid.Value, false, settings);
                                    if(accommodatie != null)
                                        entity.ClubCloud_Accommodatie = accommodatie;
                                }

                                if (specialebaan.sgt_toplaagid != null)
                                {
                                    ClubCloud_Baantoplaag toplaag = GetBaantoplaagById(specialebaan.sgt_toplaagid.Value, false, settings);
                                    if(toplaag != null)
                                        entity.ClubCloud_Baantoplaag = toplaag;
                                }

                                beheerModel.SaveChanges();
                            }
                        }
                    }
                }
                entity = beheerModel.ClubCloud_BanenSpeciaal.Find(Id);
            }

            return entity;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="refresh"></param>
        /// <returns></returns>
        private List<ClubCloud_BaanSpeciaal> GetBanenSpeciaal(string bondsnummer, bool refresh = false, ClubCloud_Setting settings = null)
        {
            List<ClubCloud_BaanSpeciaal> banenspeciaal = new List<ClubCloud_BaanSpeciaal>();

            banenspeciaal = beheerModel.ClubCloud_BanenSpeciaal.ToList();

            if (banenspeciaal == null || banenspeciaal.Count == 0 || refresh)
            {
                if (settings == null)
                    settings = GetSettings(bondsnummer);

                if (settings != null && settings.Access && !string.IsNullOrWhiteSpace(settings.Password))
                {
                    CookieContainer cc = RequestContainer(settings.Id.ToString(), settings.Password);

                    if (cc != null)
                    {
                        using (ClubCloud.KNLTB.ServIt.CrmService.CrmService service = CrmServices[settings.Id.ToString()])
                        {
                            bool moreRecords = true;
                            int pageNum = 1;
                            while (moreRecords)
                            {
                                List<BusinessEntity> entities = RetrieveMultiple(service, "sgt_alg_speciale_baan", out moreRecords, ref pageNum);

                                foreach (sgt_alg_speciale_baan specialebaan in entities)
                                {
                                    ClubCloud_BaanSpeciaal entity = beheerModel.ClubCloud_BanenSpeciaal.Find(specialebaan.sgt_alg_speciale_baanid.Value);

                                    if(entity == null)
                                        entity = beheerModel.ClubCloud_BanenSpeciaal.Create();

                                    entity.Id = specialebaan.sgt_alg_speciale_baanid.Value;
                                    BaanspeciaalToEntity(specialebaan, entity, settings);
                                    beheerModel.ClubCloud_BanenSpeciaal.AddOrUpdate(entity);
                                }
                                beheerModel.SaveChanges();

                                foreach (sgt_alg_speciale_baan specialebaan in entities)
                                {
                                    ClubCloud_BaanSpeciaal entity = beheerModel.ClubCloud_BanenSpeciaal.Find(specialebaan.sgt_alg_speciale_baanid.Value);

                                    if (specialebaan.sgt_accomodatieid != null)
                                    {
                                        ClubCloud_Accommodatie accommodatie = GetAccommodatieById(specialebaan.sgt_accomodatieid.Value, false, settings);
                                        if (accommodatie != null)
                                            entity.ClubCloud_Accommodatie = accommodatie;
                                    }

                                    if (specialebaan.sgt_toplaagid != null)
                                    {
                                        ClubCloud_Baantoplaag toplaag = GetBaantoplaagById(specialebaan.sgt_toplaagid.Value, false, settings);
                                        if (toplaag != null)
                                            entity.ClubCloud_Baantoplaag = toplaag;
                                    }
                                }

                                beheerModel.SaveChanges();
                            }
                        }
                    }
                }
                banenspeciaal = beheerModel.ClubCloud_BanenSpeciaal.ToList();
            }

            return banenspeciaal;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="entity"></param>
        /// <param name="settings"></param>
        /// <returns></returns>
        private ClubCloud_BaanSpeciaal SetBaanSpeciaal(string bondsnummer, ClubCloud_BaanSpeciaal entity, ClubCloud_Setting settings)
        {
            if (entity.Id == Guid.Empty)
                entity.Id = Guid.NewGuid();

            return entity;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="entity"></param>
        /// <param name="refresh"></param>
        /// <param name="settings"></param>
        /// <returns></returns>
        private ClubCloud_Accommodatie GetAccommodatieForBaanSpeciaal(string bondsnummer, ClubCloud_BaanSpeciaal entity, bool refresh, ClubCloud_Setting settings)
        {
            return GetAccommodatieForBaanSpeciaalById(bondsnummer, entity.Id, refresh, settings);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="Id"></param>
        /// <param name="refresh"></param>
        /// <param name="settings"></param>
        /// <returns></returns>
        private ClubCloud_Accommodatie GetAccommodatieForBaanSpeciaalById(string bondsnummer, Guid Id, bool refresh, ClubCloud_Setting settings)
        {
            ClubCloud_Accommodatie result = null;

            ClubCloud_BaanSpeciaal specialebaan = beheerModel.ClubCloud_BanenSpeciaal.Find(Id);
            if (specialebaan != null)
            {
                if (specialebaan.ClubCloud_Accommodatie == null && specialebaan.AccommodatieId != null)
                {
                    result = beheerModel.ClubCloud_Accommodaties.Find(specialebaan.AccommodatieId.Value);

                    if (result != null)
                    {
                        specialebaan.ClubCloud_Accommodatie = result;
                        beheerModel.SaveChanges();
                    }
                    else
                    {
                        result = GetAccommodatieById(bondsnummer, specialebaan.AccommodatieId.Value, true, settings);

                        if (result != null)
                        {
                            specialebaan.ClubCloud_Accommodatie = result;
                            beheerModel.SaveChanges();
                        }
                    }
                }

            }
            return result;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="entity"></param>
        /// <param name="refresh"></param>
        /// <param name="settings"></param>
        /// <returns></returns>
        private ClubCloud_Baantoplaag GetBaantoplaagForBaanSpeciaal(string bondsnummer, ClubCloud_BaanSpeciaal entity, bool refresh, ClubCloud_Setting settings)
        {
            return GetBaantoplaagForBaanSpeciaalById(bondsnummer, entity.Id, refresh, settings);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="Id"></param>
        /// <param name="refresh"></param>
        /// <param name="settings"></param>
        /// <returns></returns>
        private ClubCloud_Baantoplaag GetBaantoplaagForBaanSpeciaalById(string bondsnummer, Guid Id, bool refresh, ClubCloud_Setting settings)
        {
            ClubCloud_Baantoplaag result = null;

            ClubCloud_BaanSpeciaal specialebaan = beheerModel.ClubCloud_BanenSpeciaal.Find(Id);
            if (specialebaan != null)
            {
                if (specialebaan.ClubCloud_Baantoplaag == null && specialebaan.BaantoplaagId != null)
                {
                    result = beheerModel.ClubCloud_Baantoplagen.Find(specialebaan.BaantoplaagId.Value);

                    if (result != null)
                    {
                        specialebaan.ClubCloud_Baantoplaag = result;
                        beheerModel.SaveChanges();
                    }
                    else
                    {
                        result = GetBaantoplaagById(bondsnummer, specialebaan.BaantoplaagId.Value, true, settings);

                        if (result != null)
                        {
                            specialebaan.ClubCloud_Baantoplaag = result;
                            beheerModel.SaveChanges();
                        }
                    }
                }

            }
            return result;
        }

        #region Mapping

        /// <summary>
        /// 
        /// </summary>
        /// <param name="specialebaan"></param>
        /// <param name="entity"></param>
        /// <param name="settings"></param>
        private void BaanspeciaalToEntity(sgt_alg_speciale_baan specialebaan, ClubCloud_BaanSpeciaal entity, ClubCloud_Setting settings)
        {
            entity.Naam = specialebaan.sgt_name;

            if (specialebaan.sgt_accomodatieid != null)
            {
                //ClubCloud_Accommodatie accommodatie = GetAccommodatieById(specialebaan.sgt_accomodatieid.Value, false, settings);
                //if(accommodatie != null)
                //    entity.ClubCloud_Accommodatie = accommodatie;
                entity.AccommodatieId = specialebaan.sgt_accomodatieid.Value;
            }

            if (specialebaan.sgt_soort_baan != null)
            {
                entity.Baansoort = (BaanSoort)specialebaan.sgt_soort_baan.Value;
            }

            if (specialebaan.sgt_toplaagid != null)
            {
                //ClubCloud_Baantoplaag toplaag = GetBaantoplaagById(specialebaan.sgt_toplaagid.Value, false, settings);
                //if(toplaag != null)
                //    entity.ClubCloud_Baantoplaag = toplaag;
                entity.BaantoplaagId = specialebaan.sgt_toplaagid.Value;
            }

            entity.Actief = (ActiefSoort)specialebaan.statuscode.Value;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="specialebaan"></param>
        /// <param name="entity"></param>
        /// <param name="settings"></param>
        private void EntityToBaanspeciaal(sgt_alg_speciale_baan specialebaan, ClubCloud_BaanSpeciaal entity, ClubCloud_Setting settings)
        {

        }

        #endregion

        #endregion

        #region Baantoplaag

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="Id"></param>
        /// <param name="refresh"></param>
        /// <param name="settings"></param>
        /// <returns></returns>
        private ClubCloud_Baantoplaag GetBaantoplaagById(string bondsnummer, Guid Id, bool refresh, ClubCloud_Setting settings)
        {
            ClubCloud_Baantoplaag entity = null;

            entity = beheerModel.ClubCloud_Baantoplagen.Find(Id);

            if (entity == null || refresh)
            {
                if(settings == null)
                    settings = GetSettings(bondsnummer);

                if (settings != null && settings.Access && !string.IsNullOrWhiteSpace(settings.Password))
                {
                    CookieContainer cc = RequestContainer(settings.Id.ToString(), settings.Password);

                    if (cc != null)
                    {
                        using (ClubCloud.KNLTB.ServIt.CrmService.CrmService service = CrmServices[settings.Id.ToString()])
                        {
                            sgt_alg_toplaag toplaag = RetrieveEntity(service, "sgt_alg_toplaag", Id) as sgt_alg_toplaag;

                            if (toplaag != null && toplaag.sgt_alg_toplaagid.Value == Id)
                            {
                                if (entity == null)
                                    entity = beheerModel.ClubCloud_Baantoplagen.Create();

                                entity.Id = toplaag.sgt_alg_toplaagid.Value;

                                BaantoplaagToEntity(toplaag, entity, settings);

                                beheerModel.ClubCloud_Baantoplagen.AddOrUpdate(entity);

                                beheerModel.SaveChanges();
                            }
                            
                        }
                    }
                }
                entity = beheerModel.ClubCloud_Baantoplagen.Find(Id);
            }
            return entity;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="refresh"></param>
        /// <returns></returns>
        private List<ClubCloud_Baantoplaag> GetBaantoplagen(string bondsnummer, bool refresh = false, ClubCloud_Setting settings = null)
        {

            List<ClubCloud_Baantoplaag> baantoplagen = new List<ClubCloud_Baantoplaag>();

            baantoplagen = beheerModel.ClubCloud_Baantoplagen.ToList();

            if (baantoplagen == null || baantoplagen.Count == 0 || refresh)
            {
                if (settings == null)
                    settings = GetSettings(bondsnummer);

                if (settings != null && settings.Access && !string.IsNullOrWhiteSpace(settings.Password))
                {
                    CookieContainer cc = RequestContainer(settings.Id.ToString(), settings.Password);

                    if (cc != null)
                    {
                        using (ClubCloud.KNLTB.ServIt.CrmService.CrmService service = CrmServices[settings.Id.ToString()])
                        {
                            bool moreRecords = true;
                            int pageNum = 1;
                            while (moreRecords)
                            {
                                List<BusinessEntity> entities = RetrieveMultiple(service, "sgt_alg_toplaag", out moreRecords, ref pageNum);

                                foreach (sgt_alg_toplaag toplaag in entities)
                                {
                                    ClubCloud_Baantoplaag entity = beheerModel.ClubCloud_Baantoplagen.Find(toplaag.sgt_alg_toplaagid.Value);

                                    if (entity == null)
                                        entity = beheerModel.ClubCloud_Baantoplagen.Create();

                                    entity.Id = toplaag.sgt_alg_toplaagid.Value;
                                    BaantoplaagToEntity(toplaag, entity, settings);
                                    beheerModel.ClubCloud_Baantoplagen.AddOrUpdate(entity);
                                }
                                beheerModel.SaveChanges();
                            }
                        }
                    }
                }
                baantoplagen = beheerModel.ClubCloud_Baantoplagen.ToList();
            }

            return baantoplagen;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="entity"></param>
        /// <param name="settings"></param>
        /// <returns></returns>
        private ClubCloud_Baantoplaag SetBaantoplaag(string bondsnummer, ClubCloud_Baantoplaag entity, ClubCloud_Setting settings)
        {
            if (entity.Id == Guid.Empty)
                entity.Id = Guid.NewGuid();

            return entity;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="entity"></param>
        /// <param name="refresh"></param>
        /// <param name="settings"></param>
        /// <returns></returns>
        private List<ClubCloud_BaanSpeciaal> GetBanenSpeciaalForBaantoplaag(string bondsnummer, ClubCloud_Baantoplaag entity, bool refresh, ClubCloud_Setting settings)
        {
            return GetBanenSpeciaalForBaantoplaagById(bondsnummer, entity.Id, refresh, settings);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="Id"></param>
        /// <param name="refresh"></param>
        /// <param name="settings"></param>
        /// <returns></returns>
        private List<ClubCloud_BaanSpeciaal> GetBanenSpeciaalForBaantoplaagById(string bondsnummer, Guid Id, bool refresh, ClubCloud_Setting settings)
        {
            List<ClubCloud_BaanSpeciaal> result = null;

            ClubCloud_Baantoplaag baantoplaag = beheerModel.ClubCloud_Baantoplagen.Find(Id);
            if (baantoplaag != null)
            {
                if (baantoplaag.ClubCloud_BaanSpeciaal == null || baantoplaag.ClubCloud_BaanSpeciaal.Count == 0)
                {
                    result = beheerModel.ClubCloud_BanenSpeciaal.Where(v => v.BaantoplaagId.Value == Id).ToList();

                    foreach (ClubCloud_BaanSpeciaal item in result)
                    {
                        baantoplaag.ClubCloud_BaanSpeciaal.Add(item);
                    }
                    beheerModel.SaveChanges();
                }

            }
            return result;
        }

        #region Mapping

        /// <summary>
        /// 
        /// </summary>
        /// <param name="toplaag"></param>
        /// <param name="entity"></param>
        /// <param name="settings"></param>
        private void BaantoplaagToEntity(sgt_alg_toplaag toplaag, ClubCloud_Baantoplaag entity, ClubCloud_Setting settings)
        {
            entity.Naam = toplaag.sgt_alg_toplaag1;

            if (toplaag.sgt_beschrijving != null)
            {
                entity.Beschrijving = toplaag.sgt_beschrijving;
            }

            if (toplaag.sgt_omschrijving != null)
            {
                entity.Omschrijving = toplaag.sgt_omschrijving;
            }

            if (toplaag.sgt_verkorte_code != null)
            {
                entity.Code = toplaag.sgt_verkorte_code;
            }

            if (toplaag.sgt_meervoudsnaam != null)
            {
                entity.Meervoud = toplaag.sgt_meervoudsnaam;
            }

            entity.Actief = (ActiefSoort)toplaag.statuscode.Value;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="toplaag"></param>
        /// <param name="entity"></param>
        /// <param name="settings"></param>
        private void EntityToBaantoplaag(sgt_alg_toplaag toplaag, ClubCloud_Baantoplaag entity, ClubCloud_Setting settings)
        {

        }

        #endregion

        #endregion

        #region Baantype

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="Id"></param>
        /// <param name="refresh"></param>
        /// <param name="settings"></param>
        /// <returns></returns>
        private ClubCloud_Baantype GetBaantypeById(string bondsnummer, Guid Id, bool refresh, ClubCloud_Setting settings)
        {
            ClubCloud_Baantype entity = new ClubCloud_Baantype();

            entity = beheerModel.ClubCloud_Baantypes.Find(Id);

            if (entity == null || refresh)
            {
                if(settings == null)
                    settings = GetSettings(bondsnummer);

                if (settings != null && settings.Access && !string.IsNullOrWhiteSpace(settings.Password))
                {
                    CookieContainer cc = RequestContainer(settings.Id.ToString(), settings.Password);

                    if (cc != null)
                    {
                        using (ClubCloud.KNLTB.ServIt.CrmService.CrmService service = CrmServices[settings.Id.ToString()])
                        {
                            sgt_alg_baantype baantype = RetrieveEntity(service, "sgt_alg_baantype", Id) as sgt_alg_baantype;

                            if (baantype != null && baantype.sgt_alg_baantypeid.Value == Id)
                            {
                                if (entity == null)
                                    entity = beheerModel.ClubCloud_Baantypes.Create();

                                entity.Id = baantype.sgt_alg_baantypeid.Value;

                                BaantypeToEntity(baantype, entity, settings);

                                beheerModel.ClubCloud_Baantypes.AddOrUpdate(entity);
                            }
                            beheerModel.SaveChanges();
                        }
                    }
                }
                entity = beheerModel.ClubCloud_Baantypes.Find(Id);
            }
            return entity;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="refresh"></param>
        /// <returns></returns>
        private List<ClubCloud_Baantype> GetBaantypes(string bondsnummer, bool refresh = false, ClubCloud_Setting settings = null)
        {
            List<ClubCloud_Baantype> baantypes = new List<ClubCloud_Baantype>();

            baantypes = beheerModel.ClubCloud_Baantypes.ToList();

            if (baantypes == null || baantypes.Count == 0 || refresh)
            {
                if (settings == null)
                    settings = GetSettings(bondsnummer);

                if (settings != null && settings.Access && !string.IsNullOrWhiteSpace(settings.Password))
                {
                    CookieContainer cc = RequestContainer(settings.Id.ToString(), settings.Password);

                    if (cc != null)
                    {
                        using (ClubCloud.KNLTB.ServIt.CrmService.CrmService service = CrmServices[settings.Id.ToString()])
                        {
                            bool moreRecords = true;
                            int pageNum = 1;
                            while (moreRecords)
                            {
                                List<BusinessEntity> entities = RetrieveMultiple(service, "sgt_alg_baantype", out moreRecords, ref pageNum);

                                foreach (sgt_alg_baantype baantype in entities)
                                {
                                    ClubCloud_Baantype entity = beheerModel.ClubCloud_Baantypes.Find(baantype.sgt_alg_baantypeid.Value);

                                    if (entity == null)
                                        entity = beheerModel.ClubCloud_Baantypes.Create();

                                    entity.Id = baantype.sgt_alg_baantypeid.Value;

                                    BaantypeToEntity(baantype, entity, settings);

                                    beheerModel.ClubCloud_Baantypes.AddOrUpdate(entity);
                                }
                                beheerModel.SaveChanges();
                            }
                        }
                    }
                }
                baantypes = beheerModel.ClubCloud_Baantypes.ToList();
            }
            return baantypes;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="entity"></param>
        /// <param name="settings"></param>
        /// <returns></returns>
        private ClubCloud_Baantype SetBaantype(string bondsnummer, ClubCloud_Baantype entity, ClubCloud_Setting settings)
        {
            if (entity.Id == Guid.Empty)
                entity.Id = Guid.NewGuid();

            return entity;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="entity"></param>
        /// <param name="refresh"></param>
        /// <param name="settings"></param>
        /// <returns></returns>
        private List<ClubCloud_Baansoort> GetBaansoortenForBaantype(string bondsnummer, ClubCloud_Baantype entity, bool refresh, ClubCloud_Setting settings)
        {
            return GetBaansoortenForBaantypeById(bondsnummer, entity.Id, refresh, settings);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="Id"></param>
        /// <param name="refresh"></param>
        /// <param name="settings"></param>
        /// <returns></returns>
        private List<ClubCloud_Baansoort> GetBaansoortenForBaantypeById(string bondsnummer, Guid Id, bool refresh, ClubCloud_Setting settings)
        {
            List<ClubCloud_Baansoort> result = null;

            ClubCloud_Baantype baantype = beheerModel.ClubCloud_Baantypes.Find(Id);
            if (baantype != null)
            {
                if (baantype.ClubCloud_Baansoort == null || baantype.ClubCloud_Baansoort.Count == 0)
                {
                    result = beheerModel.ClubCloud_Baansoorten.Where(v => v.BaantypeId.Value == Id).ToList();

                    foreach (ClubCloud_Baansoort item in result)
                    {
                        baantype.ClubCloud_Baansoort.Add(item);
                    }
                    beheerModel.SaveChanges();
                }

            }
            return result;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="entity"></param>
        /// <param name="refresh"></param>
        /// <param name="settings"></param>
        /// <returns></returns>
        private List<ClubCloud_Baanblok> GetBaanblokkenForBaantype(string bondsnummer, ClubCloud_Baantype entity, bool refresh, ClubCloud_Setting settings)
        {
            return GetBaanblokkenForBaantypeById(bondsnummer, entity.Id, refresh, settings);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="Id"></param>
        /// <param name="refresh"></param>
        /// <param name="settings"></param>
        /// <returns></returns>
        private List<ClubCloud_Baanblok> GetBaanblokkenForBaantypeById(string bondsnummer, Guid Id, bool refresh, ClubCloud_Setting settings)
        {
            List<ClubCloud_Baanblok> result = null;

            ClubCloud_Baantype baantype = beheerModel.ClubCloud_Baantypes.Find(Id);
            if (baantype != null)
            {
                if (baantype.ClubCloud_Baanblok == null || baantype.ClubCloud_Baanblok.Count == 0)
                {
                    result = beheerModel.ClubCloud_Baanblokken.Where(v => v.BaantypeId.Value == Id).ToList();

                    foreach (ClubCloud_Baanblok item in result)
                    {
                        baantype.ClubCloud_Baanblok.Add(item);
                    }
                    beheerModel.SaveChanges();
                }

            }
            return result;
        }

        #region Mapping

        /// <summary>
        /// 
        /// </summary>
        /// <param name="baantype"></param>
        /// <param name="entity"></param>
        /// <param name="settings"></param>
        private void BaantypeToEntity(sgt_alg_baantype baantype, ClubCloud_Baantype entity, ClubCloud_Setting settings)
        {
            entity.Naam = baantype.sgt_alg_baantype1;

            if (baantype.sgt_beschrijving != null)
            {
                entity.Beschrijving = baantype.sgt_beschrijving;
            }

            if (baantype.sgt_omschrijving != null)
            {
                entity.Omschrijving = baantype.sgt_omschrijving;
            }

            if (baantype.sgt_verkorte_code != null)
            {
                entity.Code = baantype.sgt_verkorte_code;
            }

            if (baantype.sgt_meervoudsnaam != null)
            {
                entity.Meervoud = baantype.sgt_meervoudsnaam;
            }

            entity.Actief = (ActiefSoort)baantype.statuscode.Value;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="baantype"></param>
        /// <param name="entity"></param>
        /// <param name="settings"></param>
        private void EntityToBaantype(sgt_alg_baantype baantype, ClubCloud_Baantype entity, ClubCloud_Setting settings)
        {

        }

        #endregion

        #endregion

        #region Bestuursorgaan

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="Id"></param>
        /// <param name="refresh"></param>
        /// <param name="settings"></param>
        /// <returns></returns>
        private ClubCloud_Bestuursorgaan GetBestuursorgaanById(string bondsnummer, Guid Id, bool refresh, ClubCloud_Setting settings)
        {
            ClubCloud_Bestuursorgaan entity = null;

            entity = beheerModel.ClubCloud_Bestuursorganen.Find(Id);

            if (entity == null || refresh)
            {
                if (settings == null)
                {
                    settings = GetSettings(bondsnummer);
                }

                if (settings != null && settings.Access && !string.IsNullOrWhiteSpace(settings.Password))
                {
                    CookieContainer cc = RequestContainer(settings.Id.ToString(), settings.Password);

                    if (cc != null)
                    {
                        using (ClubCloud.KNLTB.ServIt.CrmService.CrmService service = CrmServices[settings.Id.ToString()])
                        {
                            sgt_alg_bestuursorgaan bestuursorgaan = RetrieveEntity(service, "sgt_alg_bestuursorgaan", Id) as sgt_alg_bestuursorgaan;

                            if (bestuursorgaan != null && bestuursorgaan.sgt_alg_bestuursorgaanid.Value == Id)
                            {
                                if (entity == null)
                                    entity = beheerModel.ClubCloud_Bestuursorganen.Create();

                                entity.Id = bestuursorgaan.sgt_alg_bestuursorgaanid.Value;

                                BestuursorgaanToEntity(bestuursorgaan, entity, settings);

                                beheerModel.ClubCloud_Bestuursorganen.AddOrUpdate(entity);

                                beheerModel.SaveChanges();

                                if (bestuursorgaan.sgt_basisorganisatieid != null)
                                {
                                    ClubCloud_Vereniging vereniging = GetVerenigingById(bestuursorgaan.sgt_basisorganisatieid.Value, false, settings);
                                    if (vereniging != null)
                                        entity.ClubCloud_Vereniging = vereniging;
                                }

                                beheerModel.SaveChanges();

                            }
                        }
                    }
                }
                entity = beheerModel.ClubCloud_Bestuursorganen.Find(Id);
            }
            return entity;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="refresh"></param>
        /// <param name="settings"></param>
        /// <returns></returns>
        private List<ClubCloud_Bestuursorgaan> GetBestuursorganen(string bondsnummer, bool refresh, ClubCloud_Setting settings)
        {
            List<ClubCloud_Bestuursorgaan> bestuursorganen = new List<ClubCloud_Bestuursorgaan>();

            bestuursorganen = beheerModel.ClubCloud_Bestuursorganen.ToList();

            if (bestuursorganen != null && bestuursorganen.Count == 0 || refresh)
            {
                if (settings == null)
                {
                    settings = GetSettings(bondsnummer);
                }

                if (settings != null && settings.Access && !string.IsNullOrWhiteSpace(settings.Password))
                {
                    CookieContainer cc = RequestContainer(settings.Id.ToString(), settings.Password);

                    if (cc != null)
                    {
                        using (ClubCloud.KNLTB.ServIt.CrmService.CrmService service = CrmServices[settings.Id.ToString()])
                        {
                            bool moreRecords = true;
                            int pageNum = 1;
                            while (moreRecords)
                            {
                                List<BusinessEntity> entities = RetrieveMultiple(service, "sgt_alg_bestuursorgaan", out moreRecords, ref pageNum);

                                foreach (sgt_alg_bestuursorgaan bestuursorgaan in entities)
                                {
                                    ClubCloud_Bestuursorgaan entity = beheerModel.ClubCloud_Bestuursorganen.Find(bestuursorgaan.sgt_alg_bestuursorgaanid.Value);

                                    if (entity == null)
                                        entity = beheerModel.ClubCloud_Bestuursorganen.Create();

                                    entity.Id = bestuursorgaan.sgt_alg_bestuursorgaanid.Value;
                                    BestuursorgaanToEntity(bestuursorgaan, entity, settings);
                                    beheerModel.ClubCloud_Bestuursorganen.AddOrUpdate(entity);
                                }
                                beheerModel.SaveChanges();

                                foreach (sgt_alg_bestuursorgaan bestuursorgaan in entities)
                                {
                                    ClubCloud_Bestuursorgaan entity = beheerModel.ClubCloud_Bestuursorganen.Find(bestuursorgaan.sgt_alg_bestuursorgaanid.Value);

                                    if (bestuursorgaan.sgt_basisorganisatieid != null)
                                    {
                                        ClubCloud_Vereniging vereniging = GetVerenigingById(bestuursorgaan.sgt_basisorganisatieid.Value, false, settings);
                                        if (vereniging != null)
                                            entity.ClubCloud_Vereniging = vereniging;
                                    }
                                }
                                beheerModel.SaveChanges();
                            }
                        }
                    }
                }
                bestuursorganen = beheerModel.ClubCloud_Bestuursorganen.ToList();
            }
            return bestuursorganen;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="entity"></param>
        /// <param name="settings"></param>
        /// <returns></returns>
        private ClubCloud_Bestuursorgaan SetBestuursorgaan(string bondsnummer, ClubCloud_Bestuursorgaan entity, ClubCloud_Setting settings)
        {
            if (entity.Id == Guid.Empty)
                entity.Id = Guid.NewGuid();

            return entity;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="entity"></param>
        /// <param name="refresh"></param>
        /// <param name="settings"></param>
        /// <returns></returns>
        private List<ClubCloud_Functionaris> GetFunctionarissenForBestuursorgaan(string bondsnummer, ClubCloud_Bestuursorgaan entity, bool refresh, ClubCloud_Setting settings)
        {
            return GetFunctionarissenForBestuursorgaanById(bondsnummer, entity.Id, refresh, settings);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="Id"></param>
        /// <param name="refresh"></param>
        /// <param name="settings"></param>
        /// <returns></returns>
        private List<ClubCloud_Functionaris> GetFunctionarissenForBestuursorgaanById(string bondsnummer, Guid Id, bool refresh, ClubCloud_Setting settings)
        {
            List<ClubCloud_Functionaris> result = null;

            ClubCloud_Bestuursorgaan bestuursorgaan = beheerModel.ClubCloud_Bestuursorganen.Find(Id);
            if (bestuursorgaan != null)
            {
                if (bestuursorgaan.ClubCloud_Functionaris == null || bestuursorgaan.ClubCloud_Functionaris.Count == 0)
                {
                    result = beheerModel.ClubCloud_Functionarissen.Where(v => v.BestuursorgaanId.Value == Id).ToList();

                    foreach (ClubCloud_Functionaris functionaris in result)
                    {
                        bestuursorgaan.ClubCloud_Functionaris.Add(functionaris);
                    }
                    beheerModel.SaveChanges();
                }

            }
            return result;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="entity"></param>
        /// <param name="refresh"></param>
        /// <param name="settings"></param>
        /// <returns></returns>
        private ClubCloud_Vereniging GetVerenigingForBestuursorgaan(string bondsnummer, ClubCloud_Bestuursorgaan entity, bool refresh, ClubCloud_Setting settings)
        {
            return GetVerenigingForBestuursorgaanById(bondsnummer, entity.Id, refresh, settings);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="Id"></param>
        /// <param name="refresh"></param>
        /// <param name="settings"></param>
        /// <returns></returns>
        private ClubCloud_Vereniging GetVerenigingForBestuursorgaanById(string bondsnummer, Guid Id, bool refresh, ClubCloud_Setting settings)
        {
            ClubCloud_Vereniging result = null;

            ClubCloud_Bestuursorgaan bestuursorgaan = beheerModel.ClubCloud_Bestuursorganen.Find(Id);
            if (bestuursorgaan != null)
            {
                if (bestuursorgaan.ClubCloud_Vereniging == null && bestuursorgaan.VerenigingId != null)
                {
                    result = beheerModel.ClubCloud_Verenigingen.Find(bestuursorgaan.VerenigingId.Value);

                    if (result != null)
                    {
                        bestuursorgaan.ClubCloud_Vereniging = result;
                        beheerModel.SaveChanges();
                    }
                    else
                    {
                        result = GetVerenigingById(bondsnummer, bestuursorgaan.VerenigingId.Value, true, settings);

                        if (result != null)
                        {
                            bestuursorgaan.ClubCloud_Vereniging = result;
                            beheerModel.SaveChanges();
                        }

                    }
                }

            }
            return result;
        }

        #region Mapping

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bestuursorgaan"></param>
        /// <param name="entity"></param>
        /// <param name="settings"></param>
        private void BestuursorgaanToEntity(sgt_alg_bestuursorgaan bestuursorgaan, ClubCloud_Bestuursorgaan entity, ClubCloud_Setting settings)
        {
            entity.Naam = bestuursorgaan.sgt_alg_bestuursorgaan1;
            entity.Beschrijving = string.IsNullOrWhiteSpace(bestuursorgaan.sgt_beschrijving) ? "" : bestuursorgaan.sgt_beschrijving;

            if (bestuursorgaan.sgt_basisorganisatieid != null)
            {
                //ClubCloud_Vereniging vereniging = GetVerenigingById(bestuursorgaan.sgt_basisorganisatieid.Value, false, settings);
                //if (vereniging != null)
                //    entity.ClubCloud_Vereniging = vereniging;

                entity.VerenigingId = bestuursorgaan.sgt_basisorganisatieid.Value;
            }

            if (bestuursorgaan.sgt_typebestuursorgaanid != null)
            {
                entity.Groep = string.IsNullOrWhiteSpace(bestuursorgaan.sgt_typebestuursorgaanid.name) ? "" : bestuursorgaan.sgt_typebestuursorgaanid.name;
            }
            else
            {
                entity.Groep = "";
            }

            entity.Actief = (ActiefSoort)bestuursorgaan.statuscode.Value;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bestuursorgaan"></param>
        /// <param name="entity"></param>
        /// <param name="settings"></param>
        private void EntityToBestuursorgaan(sgt_alg_bestuursorgaan bestuursorgaan, ClubCloud_Bestuursorgaan entity, ClubCloud_Setting settings)
        {

        }

        #endregion

        #endregion

        #region Bouwaard

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="Id"></param>
        /// <param name="refresh"></param>
        /// <param name="settings"></param>
        /// <returns></returns>
        private ClubCloud_Bouwaard GetBouwaardById(string bondsnummer, Guid Id, bool refresh, ClubCloud_Setting settings)
        {
            ClubCloud_Bouwaard entity = null;

            entity = beheerModel.ClubCloud_Bouwaarden.Find(Id);

            if (entity == null || refresh)
            {
                if (settings == null)
                {
                    settings = GetSettings(bondsnummer);
                }

                if (settings != null && settings.Access && !string.IsNullOrWhiteSpace(settings.Password))
                {
                    CookieContainer cc = RequestContainer(settings.Id.ToString(), settings.Password);

                    if (cc != null)
                    {
                        using (ClubCloud.KNLTB.ServIt.CrmService.CrmService service = CrmServices[settings.Id.ToString()])
                        {
                            sgt_alg_bouwaard bouwaard = RetrieveEntity(service, "sgt_alg_bouwaard", Id) as sgt_alg_bouwaard;

                            if (bouwaard != null && bouwaard.sgt_alg_bouwaardid.Value == Id)
                            {
                                if (entity == null)
                                    entity = beheerModel.ClubCloud_Bouwaarden.Create();

                                entity.Id = bouwaard.sgt_alg_bouwaardid.Value;
                                BouwaardToEntity(bouwaard, entity, settings);
                                beheerModel.ClubCloud_Bouwaarden.AddOrUpdate(entity);
                                
                                beheerModel.SaveChanges();
                            }
                        }
                    }
                }
                entity = beheerModel.ClubCloud_Bouwaarden.Find(Id);
            }
            return entity;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="refresh"></param>
        /// <param name="settings"></param>
        /// <returns></returns>
        private List<ClubCloud_Bouwaard> GetBouwaarden(string bondsnummer, bool refresh, ClubCloud_Setting settings)
        {
            List<ClubCloud_Bouwaard> bouwaarden = new List<ClubCloud_Bouwaard>();

            bouwaarden = beheerModel.ClubCloud_Bouwaarden.ToList();

            if (bouwaarden != null && bouwaarden.Count == 0 || refresh)
            {
                if (settings == null)
                {
                    settings = GetSettings(bondsnummer);
                }

                if (settings != null && settings.Access && !string.IsNullOrWhiteSpace(settings.Password))
                {
                    CookieContainer cc = RequestContainer(settings.Id.ToString(), settings.Password);

                    if (cc != null)
                    {
                        using (ClubCloud.KNLTB.ServIt.CrmService.CrmService service = CrmServices[settings.Id.ToString()])
                        {
                            bool moreRecords = true;
                            int pageNum = 1;
                            while (moreRecords)
                            {
                                List<BusinessEntity> entities = RetrieveMultiple(service, "sgt_alg_bouwaard", out moreRecords, ref pageNum);

                                foreach (sgt_alg_bouwaard bouwaard in entities)
                                {
                                    ClubCloud_Bouwaard entity = beheerModel.ClubCloud_Bouwaarden.Find(bouwaard.sgt_alg_bouwaardid.Value);

                                    if (entity == null)
                                        entity = beheerModel.ClubCloud_Bouwaarden.Create();

                                    entity.Id = bouwaard.sgt_alg_bouwaardid.Value;
                                    BouwaardToEntity(bouwaard, entity, settings);
                                    beheerModel.ClubCloud_Bouwaarden.AddOrUpdate(entity);
                                }
                                beheerModel.SaveChanges();
                            }
                        }
                    }
                }
                bouwaarden = beheerModel.ClubCloud_Bouwaarden.ToList();
            }
            return bouwaarden;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="entity"></param>
        /// <param name="settings"></param>
        /// <returns></returns>
        private ClubCloud_Bouwaard SetBouwaard(string bondsnummer, ClubCloud_Bouwaard entity, ClubCloud_Setting settings)
        {
            if (entity.Id == Guid.Empty)
                entity.Id = Guid.NewGuid();

            return entity;
        }

        #region Mapping

        private void BouwaardToEntity(sgt_alg_bouwaard bouwaard, ClubCloud_Bouwaard entity, ClubCloud_Setting settings)
        {
            entity.Naam = bouwaard.sgt_alg_bouwaard1;

            if (bouwaard.sgt_beschrijving != null)
            {
                entity.Beschrijving = bouwaard.sgt_beschrijving;
            }

            if (bouwaard.sgt_omschrijving != null)
            {
                entity.Omschrijving = bouwaard.sgt_omschrijving;
            }

            if (bouwaard.sgt_verkorte_code != null)
            {
                entity.Code = bouwaard.sgt_verkorte_code;
            }

            if (bouwaard.sgt_meervoudsnaam != null)
            {
                entity.Meervoud = bouwaard.sgt_meervoudsnaam;
            }

            entity.Actief = (ActiefSoort)bouwaard.statuscode.Value;
        }

        private void EntityToBouwaard(sgt_alg_bouwaard bouwaard, ClubCloud_Bouwaard entity, ClubCloud_Setting settings)
        {

        }
        #endregion

        #endregion

        #region District

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="districtId"></param>
        /// <param name="refresh"></param>
        /// <returns></returns>
        private ClubCloud_District GetDistrictById(string bondsnummer, Guid Id, bool refresh, ClubCloud_Setting settings)
        {
            ClubCloud_District entity = null;

            entity = beheerModel.ClubCloud_Districten.Find(Id);

            if (entity == null || refresh)
            {
                if (settings == null)
                    settings = GetSettings(bondsnummer);

                if (settings != null && settings.Access && !string.IsNullOrWhiteSpace(settings.Password))
                {
                    CookieContainer cc = RequestContainer(settings.Id.ToString(), settings.Password);

                    if (cc != null)
                    {
                        using (ClubCloud.KNLTB.ServIt.CrmService.CrmService service = CrmServices[settings.Id.ToString()])
                        {
                            sgt_alg_district district = RetrieveEntity(service, "sgt_alg_district", Id) as sgt_alg_district;

                            if (district != null && district.sgt_alg_districtid.Value == Id)
                            {
                                if (entity == null)
                                    entity = beheerModel.ClubCloud_Districten.Create();

                                entity.Id = district.sgt_alg_districtid.Value;

                                DistrictToEntity(district, entity, settings);

                                beheerModel.ClubCloud_Districten.AddOrUpdate(entity);

                                beheerModel.SaveChanges();

                                if (district.sgt_regioid != null)
                                {
                                    ClubCloud_Regio regio = GetRegioById(district.sgt_regioid.Value, false, settings);
                                    if (regio != null)
                                        entity.ClubCloud_Regio = regio;
                                }

                                beheerModel.SaveChanges();
                            }
                        }
                    }
                }
                entity = beheerModel.ClubCloud_Districten.Find(Id);
            }
            return entity;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="refresh"></param>
        /// <returns></returns>
        private List<ClubCloud_District> GetDistricten(string bondsnummer, bool refresh, ClubCloud_Setting settings)
        {
            List<ClubCloud_District> districten = new List<ClubCloud_District>();

            districten = beheerModel.ClubCloud_Districten.ToList();

            if (districten == null && districten.Count == 0 || refresh)
            {
                if (settings == null)
                {
                    settings = GetSettings(bondsnummer);
                }

                if (settings != null && settings.Access && !string.IsNullOrWhiteSpace(settings.Password))
                {
                    CookieContainer cc = RequestContainer(settings.Id.ToString(), settings.Password);

                    if (cc != null)
                    {
                        using (ClubCloud.KNLTB.ServIt.CrmService.CrmService service = CrmServices[settings.Id.ToString()])
                        {
                            bool moreRecords = true;
                            int pageNum = 1;
                            while (moreRecords)
                            {
                                List<BusinessEntity> entities = RetrieveMultiple(service, "sgt_alg_district", out moreRecords, ref pageNum);

                                foreach (sgt_alg_district district in entities)
                                {
                                    ClubCloud_District entity = beheerModel.ClubCloud_Districten.Find(district.sgt_alg_districtid.Value);

                                    if (entity == null)
                                        entity = beheerModel.ClubCloud_Districten.Create();

                                    entity.Id = district.sgt_alg_districtid.Value;
                                    DistrictToEntity(district, entity, settings);
                                    beheerModel.ClubCloud_Districten.AddOrUpdate(entity);
                                }
                                beheerModel.SaveChanges();

                                foreach (sgt_alg_district district in entities)
                                {
                                    ClubCloud_District entity = beheerModel.ClubCloud_Districten.Find(district.sgt_alg_districtid.Value);

                                    if (district.sgt_regioid != null)
                                    {
                                        ClubCloud_Regio regio = GetRegioById(district.sgt_regioid.Value, false, settings);
                                        if (regio != null)
                                            entity.ClubCloud_Regio = regio;
                                    }
                                }

                                beheerModel.SaveChanges();

                            }
                        }
                    }
                }
                districten = beheerModel.ClubCloud_Districten.ToList();
            }
            return districten;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="entity"></param>
        /// <param name="settings"></param>
        /// <returns></returns>
        private ClubCloud_District SetDistrict(string bondsnummer, ClubCloud_District entity, ClubCloud_Setting settings)
        {
            if (entity.Id == Guid.Empty)
                entity.Id = Guid.NewGuid();

            return entity;
        }

        private List<ClubCloud_Functionaris> GetFunctionarissenForDistrict(string bondsnummer, ClubCloud_District entity, bool refresh, ClubCloud_Setting settings)
        {
            return GetFunctionarissenForDistrictById(bondsnummer, entity.Id, refresh, settings);
        }

        private List<ClubCloud_Functionaris> GetFunctionarissenForDistrictById(string bondsnummer, Guid Id, bool refresh, ClubCloud_Setting settings)
        {
            List<ClubCloud_Functionaris> result = null;

            ClubCloud_District district = beheerModel.ClubCloud_Districten.Find(Id);
            if (district != null)
            {
                if (district.ClubCloud_Functionaris == null || district.ClubCloud_Functionaris.Count == 0)
                {
                    result = beheerModel.ClubCloud_Functionarissen.Where(v => v.DistrictId.Value == Id).ToList();

                    foreach (ClubCloud_Functionaris functionaris in result)
                    {
                        district.ClubCloud_Functionaris.Add(functionaris);
                    }
                    beheerModel.SaveChanges();
                }

            }
            return result;
        }

        private List<ClubCloud_Vereniging> GetVerenigingenForDistrict(string bondsnummer, ClubCloud_District entity, bool refresh, ClubCloud_Setting settings)
        {
            return GetVerenigingenForDistrictById(bondsnummer, entity.Id, refresh, settings);
        }

        private List<ClubCloud_Vereniging> GetVerenigingenForDistrictById(string bondsnummer, Guid Id, bool refresh, ClubCloud_Setting settings)
        {
            List<ClubCloud_Vereniging> result = null;

            ClubCloud_District district = beheerModel.ClubCloud_Districten.Find(Id);
            if (district != null)
            {
                if (district.ClubCloud_Vereniging == null || district.ClubCloud_Vereniging.Count == 0)
                {
                    result = beheerModel.ClubCloud_Verenigingen.Where(v => v.DistrictId.Value == Id).ToList();

                    foreach (ClubCloud_Vereniging vereniging in result)
                    {
                        district.ClubCloud_Vereniging.Add(vereniging);
                    }
                    beheerModel.SaveChanges();
                }

            }
            return result;
        }

        private ClubCloud_Regio GetRegioForDistrict(string bondsnummer, ClubCloud_District entity, bool refresh, ClubCloud_Setting settings)
        {
            return GetRegioForDistrictById(bondsnummer, entity.Id, refresh, settings);
        }

        private ClubCloud_Regio GetRegioForDistrictById(string bondsnummer, Guid Id, bool refresh, ClubCloud_Setting settings)
        {
            ClubCloud_Regio result = null;

            ClubCloud_District district = beheerModel.ClubCloud_Districten.Find(Id);
            if (district != null)
            {
                if (district.ClubCloud_Regio == null && district.RegioId != null)
                {
                    result = beheerModel.ClubCloud_Regios.Find(district.RegioId.Value);

                    if (result != null)
                    {
                        district.ClubCloud_Regio = result;
                        beheerModel.SaveChanges();
                    }
                    else
                    {
                        result = GetRegioById(bondsnummer, district.RegioId.Value, refresh, settings);
                        if (result != null)
                        {
                            district.ClubCloud_Regio = result;
                            beheerModel.SaveChanges();
                        }

                    }
                }

            }
            return result;
        }

        private List<ClubCloud_Accommodatie> GetAccommodatiesForDistrict(string bondsnummer, ClubCloud_District entity, bool refresh, ClubCloud_Setting settings)
        {
            return GetAccommodatiesForDistrictById(bondsnummer, entity.Id, refresh, settings);
        }

        private List<ClubCloud_Accommodatie> GetAccommodatiesForDistrictById(string bondsnummer, Guid Id, bool refresh, ClubCloud_Setting settings)
        {
            List<ClubCloud_Accommodatie> result = null;

            ClubCloud_District district = beheerModel.ClubCloud_Districten.Find(Id);
            if (district != null)
            {
                if (district.ClubCloud_Accommodatie == null || district.ClubCloud_Accommodatie.Count == 0)
                {
                    result = beheerModel.ClubCloud_Accommodaties.Where(v => v.DistrictId.Value == Id).ToList();

                    foreach (ClubCloud_Accommodatie accommodatie in result)
                    {
                        district.ClubCloud_Accommodatie.Add(accommodatie);
                    }
                    beheerModel.SaveChanges();
                }

            }
            return result;
        }

        #region Mapping

        /// <summary>
        /// 
        /// </summary>
        /// <param name="district"></param>
        /// <param name="entity"></param>
        /// <param name="settings"></param>
        private void DistrictToEntity(sgt_alg_district district, ClubCloud_District entity, ClubCloud_Setting settings)
        {
            entity.Beschrijving = district.sgt_beschrijving;
            entity.Naam = district.sgt_alg_district1;
            entity.Omschrijving = district.sgt_omschrijving;
            entity.Beschrijving = district.sgt_beschrijving;

            if (district.sgt_regioid != null)
            {
                //ClubCloud_Regio regio = GetRegioById(district.sgt_regioid.Value, false, settings);
                //if(regio != null)
                //    entity.ClubCloud_Regio = regio;
                entity.RegioId = district.sgt_regioid.Value;
            }

            entity.Actief = (ActiefSoort)district.statuscode.Value;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="district"></param>
        /// <param name="entity"></param>
        /// <param name="settings"></param>
        private void EntityToDistrict(sgt_alg_district district, ClubCloud_District entity, ClubCloud_Setting settings)
        {

        }

        #endregion

        #endregion

        #region Foto

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="Id"></param>
        /// <param name="refresh"></param>
        /// <param name="settings"></param>
        /// <returns></returns>
        private ClubCloud_Foto GetFotoById(string bondsnummer, Guid Id, bool refresh, ClubCloud_Setting settings)
        {
            ClubCloud_Foto foto = new ClubCloud_Foto();

            ClubCloud_Gebruiker gebruiker = beheerModel.ClubCloud_Gebruikers.Find(settings.GebruikerId.Value);

            if (gebruiker != null)
            {
                foto = beheerModel.ClubCloud_Fotos.SingleOrDefault(f => f.FotoId == gebruiker.FotoId || f.FotoId == settings.Id);
            }

            if ((foto == null && gebruiker != null) || refresh)
            {
                foto = RetrieveFoto(bondsnummer, gebruiker.Bondsnummer, gebruiker.FotoId);
            }
            return foto;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="refresh"></param>
        /// <param name="settings"></param>
        /// <returns></returns>
        private List<ClubCloud_Foto> GetFotos(string bondsnummer, bool refresh, ClubCloud_Setting settings)
        {
            return new List<ClubCloud_Foto>();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="entity"></param>
        /// <param name="settings"></param>
        /// <returns></returns>
        private ClubCloud_Foto SetFoto(string bondsnummer, ClubCloud_Foto entity, ClubCloud_Setting settings)
        {
            if (entity.Id == Guid.Empty)
                entity.Id = Guid.NewGuid();

            return entity;
        }

        /*
        public ClubCloud_Foto GetFotoById(string bondsnummer, Guid verenigingId, Guid gebruikerId, bool refresh = false)
        {
            ClubCloud_Foto foto = null;
            ValidateBondsnummer(ref bondsnummer, verenigingId);
            foto = FotoByGebruikerId(bondsnummer, gebruikerId, refresh);
            return foto;
        }
        */
        /*
        private ClubCloud_Foto FotoByBondsnummer(string bondsnummer, string nummer, bool refresh = false)
        {
            ClubCloud_Foto foto = new ClubCloud_Foto();

            ClubCloud_Gebruiker gebruiker = beheerModel.ClubCloud_Gebruikers.SingleOrDefault(g => g.Bondsnummer == nummer);

            if (gebruiker != null)
            {
                int ibondsnummer = int.Parse(gebruiker.Bondsnummer);
                foto = beheerModel.ClubCloud_Fotos.SingleOrDefault(f => f.FotoId == gebruiker.FotoId || f.FotoId == ibondsnummer);
            }

            if ((foto == null && gebruiker != null) || refresh)
            {
                foto = RetrieveFoto(bondsnummer, gebruiker.Bondsnummer, gebruiker.FotoId);
            }

            return foto;
        }
        */
        /*
        private ClubCloud_Foto FotoByGebruikerId(string bondsnummer, Guid gebruikerId, bool refresh = false)
        {
            ClubCloud_Foto foto = new ClubCloud_Foto();

            ClubCloud_Gebruiker gebruiker = beheerModel.ClubCloud_Gebruikers.Find(gebruikerId);

            if (gebruiker != null)
            {
                int ibondsnummer = int.Parse(gebruiker.Bondsnummer);
                foto = beheerModel.ClubCloud_Fotos.SingleOrDefault(f => f.FotoId == gebruiker.FotoId || f.FotoId == ibondsnummer);
            }

            if ((foto == null && gebruiker != null) || refresh)
            {
                foto = RetrieveFoto(bondsnummer, gebruiker.Bondsnummer, gebruiker.FotoId);
            }
            return foto;
        }
        */
        
        private ClubCloud_Foto RetrieveFoto(string bondsnummer, string nummer, int FotoId)
        {
            ClubCloud_Foto foto = new ClubCloud_Foto();
            ClubCloud_Setting settings = GetSettings(bondsnummer);

            if (settings != null && settings.Access && !string.IsNullOrWhiteSpace(settings.Password))
            {
                CookieContainer cc = RequestContainer(settings.Id.ToString(), settings.Password);

                if (cc != null)
                {
                    using (ClubCloud.KNLTB.Media.KNLTBFoto KNLTBfoto = new KNLTB.Media.KNLTBFoto())
                    {
                        Tuple<Image, string, long> result = Task.Run(async () => await KNLTBfoto.RequestFotoAsync(nummer, cc)).Result;
                        Image data = result.Item1;

                        if (data != null)
                        {
                            foto = beheerModel.ClubCloud_Fotos.Create();
                            foto.Id = Guid.NewGuid();
                            foto.ContentType = result.Item2;
                            foto.ContentLength = result.Item3;

                            MemoryStream ms = new MemoryStream();
                            data.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                            foto.ContentData = ms.ToArray();
                            foto.Gewijzigd = DateTime.Now;

                            if (FotoId > 0)
                            {
                                foto.FotoId = FotoId;
                            }
                            else
                            {
                                foto.FotoId = int.Parse(nummer);
                            }

                            beheerModel.ClubCloud_Fotos.Add(foto);
                            beheerModel.SaveChanges();
                        }
                        else
                        {
                            return null;
                        }
                    }
                }
            }
            return foto;
        }

        /*
        private ClubCloud_Foto SetFoto(ClubCloud_Foto foto)
        {
            ClubCloud_Foto tobeupdated = beheerModel.ClubCloud_Fotos.Find(foto.Id);

            if (tobeupdated != null)
            {
                beheerModel.Entry(tobeupdated).CurrentValues.SetValues(foto);
                beheerModel.SaveChanges();
            }
            tobeupdated = beheerModel.ClubCloud_Fotos.Find(foto.Id);
            return tobeupdated;
        }
        */

        #endregion

        #region Functie

        /// <summary>
        /// sgt_alg_functie
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="functieId"></param>
        /// <param name="refresh"></param>
        /// <returns></returns>
        private ClubCloud_Functie GetFunctieById(string bondsnummer, Guid Id, bool refresh = false, ClubCloud_Setting settings = null)
        {
            ClubCloud_Functie entity = null;

            entity = beheerModel.ClubCloud_Functies.Find(Id);

            if (entity == null || refresh)
            {
                if (settings == null)
                    settings = GetSettings(bondsnummer);

                if (settings != null && settings.Access && !string.IsNullOrWhiteSpace(settings.Password))
                {
                    CookieContainer cc = RequestContainer(settings.Id.ToString(), settings.Password);

                    if (cc != null)
                    {
                        using (ClubCloud.KNLTB.ServIt.CrmService.CrmService service = CrmServices[settings.Id.ToString()])
                        {
                            sgt_alg_functie functie = RetrieveEntity(service, "sgt_alg_functie", Id) as sgt_alg_functie;

                            if (functie != null && functie.sgt_alg_functieid.Value == Id)
                            {
                                if (entity == null)
                                    entity = beheerModel.ClubCloud_Functies.Create();

                                entity.Id = functie.sgt_alg_functieid.Value;

                                FunctieToEntity(functie, entity, settings);

                                beheerModel.ClubCloud_Functies.AddOrUpdate(entity);

                                bool result = CreateOrUpdateRoleFunctie(entity, settings).Result;//.RunSynchronously();

                                beheerModel.SaveChanges();
                            }
                        }
                    }
                }
                entity = beheerModel.ClubCloud_Functies.Find(Id);
            }
            return entity;
        }

        /// <summary>
        /// sgt_alg_functie
        /// </summary>
        private List<ClubCloud_Functie> GetFuncties(string bondsnummer, bool refresh, ClubCloud_Setting settings)
        {
            List<ClubCloud_Functie> functies = new List<ClubCloud_Functie>();

            functies = beheerModel.ClubCloud_Functies.ToList();

            if (functies != null && functies.Count == 0 || refresh)
            {
                if (settings == null)
                    settings = GetSettings(bondsnummer);

                if (settings != null && settings.Access && !string.IsNullOrWhiteSpace(settings.Password))
                {
                    CookieContainer cc = RequestContainer(settings.Id.ToString(), settings.Password);

                    if (cc != null)
                    {
                        using (ClubCloud.KNLTB.ServIt.CrmService.CrmService service = CrmServices[settings.Id.ToString()])
                        {
                            bool moreRecords = true;
                            int pageNum = 1;
                            while (moreRecords)
                            {
                                List<BusinessEntity> entities = RetrieveMultiple(service, "sgt_alg_functie", out moreRecords, ref pageNum);

                                foreach (sgt_alg_functie functie in entities)
                                {
                                    ClubCloud_Functie entity = beheerModel.ClubCloud_Functies.Find(functie.sgt_alg_functieid.Value);

                                    if (entity == null)
                                        entity = beheerModel.ClubCloud_Functies.Create();

                                    entity.Id = functie.sgt_alg_functieid.Value;

                                    FunctieToEntity(functie, entity, settings);

                                    beheerModel.ClubCloud_Functies.AddOrUpdate(entity);

                                    bool result = CreateOrUpdateRoleFunctie(entity, settings).Result;//.RunSynchronously();
                                }
                                beheerModel.SaveChanges();
                            }
                        }
                    }
                }
                functies = beheerModel.ClubCloud_Functies.ToList();
            }
            return functies;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="entity"></param>
        /// <param name="settings"></param>
        /// <returns></returns>
        private ClubCloud_Functie SetFunctie(string bondsnummer, ClubCloud_Functie entity, ClubCloud_Setting settings)
        {
            if (entity.Id == Guid.Empty)
                entity.Id = Guid.NewGuid();

            return entity;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="entity"></param>
        /// <param name="refresh"></param>
        /// <param name="settings"></param>
        /// <returns></returns>
        private List<ClubCloud_Functionaris> GetFunctionarissenForFunctie(string bondsnummer, ClubCloud_Functie entity, bool refresh, ClubCloud_Setting settings)
        {
            return GetFunctionarissenForFunctieById(bondsnummer, entity.Id, refresh, settings);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="Id"></param>
        /// <param name="refresh"></param>
        /// <param name="settings"></param>
        /// <returns></returns>
        private List<ClubCloud_Functionaris> GetFunctionarissenForFunctieById(string bondsnummer, Guid Id, bool refresh, ClubCloud_Setting settings)
        {
            List<ClubCloud_Functionaris> result = null;

            ClubCloud_Functie functie = beheerModel.ClubCloud_Functies.Find(Id);
            if (functie != null)
            {
                if (functie.ClubCloud_Functionaris == null || functie.ClubCloud_Functionaris.Count == 0)
                {
                    result = beheerModel.ClubCloud_Functionarissen.Where(v => v.FunctieId.Value == Id).ToList();

                    foreach (ClubCloud_Functionaris functionaris in result)
                    {
                        functie.ClubCloud_Functionaris.Add(functionaris);
                    }
                    beheerModel.SaveChanges();
                }

            }
            return result;
        }

        #region Mapping

        /// <summary>
        /// 
        /// </summary>
        /// <param name="functie"></param>
        /// <param name="entity"></param>
        /// <param name="settings"></param>
        private void FunctieToEntity(sgt_alg_functie functie, ClubCloud_Functie entity, ClubCloud_Setting settings)
        {
            entity.Naam = functie.sgt_alg_functie1;
            entity.Beschrijving = functie.sgt_beschrijving;
            entity.Code = functie.sgt_verkorte_code;
            entity.Meervoud = functie.sgt_meervoudsnaam;

            entity.Omschrijving = functie.sgt_omschrijving;
            if (functie.sgt_toegang_crm_toegestaan != null)
            {
                entity.Toegang = functie.sgt_toegang_crm_toegestaan.Value;
            }

            entity.Actief = (ActiefSoort)functie.statuscode.Value;
        }

        private void EntityToFunctie(sgt_alg_functie functie, ClubCloud_Functie entity, ClubCloud_Setting settings)
        {

        }

        #endregion

        #endregion

        #region Functionaris

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="Id"></param>
        /// <param name="refresh"></param>
        /// <param name="settings"></param>
        /// <returns></returns>
        private ClubCloud_Functionaris GetFunctionarisById(string bondsnummer, Guid Id, bool refresh, ClubCloud_Setting settings)
        {
            ClubCloud_Functionaris entity = null;

            entity = beheerModel.ClubCloud_Functionarissen.Find(Id);

            if (entity == null || refresh)
            {
                if (settings == null)
                    settings = GetSettings(bondsnummer);

                if (settings != null && settings.Access && !string.IsNullOrWhiteSpace(settings.Password))
                {
                    CookieContainer cc = RequestContainer(settings.Id.ToString(), settings.Password);

                    if (cc != null)
                    {
                        using (ClubCloud.KNLTB.ServIt.CrmService.CrmService service = CrmServices[settings.Id.ToString()])
                        {
                            sgt_alg_functionaris functionaris = RetrieveEntity(service, "sgt_alg_functionaris", Id) as sgt_alg_functionaris;

                            if (functionaris != null && functionaris.sgt_alg_functionarisid.Value == Id)
                            {
                                if (entity == null)
                                    entity = beheerModel.ClubCloud_Functionarissen.Create();

                                entity.Id = functionaris.sgt_alg_functionarisid.Value;

                                FunctionarisToEntity(functionaris, entity, settings);

                                beheerModel.ClubCloud_Functionarissen.AddOrUpdate(entity);

                                beheerModel.SaveChanges();

                                if (functionaris.sgt_functieid != null)
                                {
                                    ClubCloud_Functie functie = GetFunctieById(functionaris.sgt_functieid.Value, false, settings);
                                    entity.ClubCloud_Functie = functie;
                                    //entity.FunctieId = functionaris.sgt_functieid.Value;
                                }

                                if (functionaris.sgt_functionarisid != null)
                                {
                                    ClubCloud_Gebruiker gebruiker = GetGebruikerById(functionaris.sgt_functionarisid.Value, false, settings);
                                    entity.ClubCloud_Gebruiker = gebruiker;
                                    //entity.GebruikerId = functionaris.sgt_functionarisid.Value;
                                }

                                ClubCloud_Vereniging vereniging = null;
                                if (functionaris.sgt_basisorganisatieid != null)
                                {
                                    vereniging = GetVerenigingById(functionaris.sgt_basisorganisatieid.Value, false, settings);
                                    entity.ClubCloud_Vereniging = vereniging;
                                    //entity.VerenigingId = functionaris.sgt_basisorganisatieid.Value;
                                }

                                if (functionaris.sgt_bestuursorgaanid != null)
                                {
                                    ClubCloud_Bestuursorgaan orgaan = GetBestuursorgaanById(functionaris.sgt_bestuursorgaanid.Value, false, settings);
                                    entity.ClubCloud_Bestuursorgaan = orgaan;
                                    //entity.BestuursorgaanId = functionaris.sgt_bestuursorgaanid.Value;
                                }

                                beheerModel.SaveChanges();

                                bool succes = CreateOrUpdateRoleFunctionaris(entity, settings).Result;
                            }
                        }
                    }
                }
                entity = beheerModel.ClubCloud_Functionarissen.Find(Id);
            }
            return entity;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="refresh"></param>
        /// <param name="settings"></param>
        /// <returns></returns>
        private List<ClubCloud_Functionaris> GetFunctionarissen(string bondsnummer, bool refresh, ClubCloud_Setting settings)
        {
            List<ClubCloud_Functionaris> functionarissen = new List<ClubCloud_Functionaris>();

            functionarissen = beheerModel.ClubCloud_Functionarissen.ToList();

            if (functionarissen != null && functionarissen.Count == 0 || refresh)
            {
                if (settings == null)
                    settings = GetSettings(bondsnummer);

                if (settings != null && settings.Access && !string.IsNullOrWhiteSpace(settings.Password))
                {
                    CookieContainer cc = RequestContainer(settings.Id.ToString(), settings.Password);

                    if (cc != null)
                    {
                        using (ClubCloud.KNLTB.ServIt.CrmService.CrmService service = CrmServices[settings.Id.ToString()])
                        {
                            bool moreRecords = true;
                            int pageNum = 1;
                            while (moreRecords)
                            {
                                List<BusinessEntity> entities = RetrieveMultiple(service, "sgt_alg_functionaris", out moreRecords, ref pageNum);

                                foreach (sgt_alg_functionaris functionaris in entities)
                                {
                                    ClubCloud_Functionaris entity = beheerModel.ClubCloud_Functionarissen.Find(functionaris.sgt_alg_functionarisid.Value);

                                    if (entity == null)
                                        entity = beheerModel.ClubCloud_Functionarissen.Create();

                                    entity.Id = functionaris.sgt_alg_functionarisid.Value;

                                    FunctionarisToEntity(functionaris, entity, settings);

                                    beheerModel.ClubCloud_Functionarissen.AddOrUpdate(entity);
                                }
                                beheerModel.SaveChanges();

                                foreach (sgt_alg_functionaris functionaris in entities)
                                {
                                    ClubCloud_Functionaris entity = beheerModel.ClubCloud_Functionarissen.Find(functionaris.sgt_alg_functionarisid.Value);

                                    if (functionaris.sgt_functieid != null)
                                    {
                                        ClubCloud_Functie functie = GetFunctieById(functionaris.sgt_functieid.Value, false, settings);
                                        entity.ClubCloud_Functie = functie;
                                        //entity.FunctieId = functionaris.sgt_functieid.Value;
                                    }

                                    if (functionaris.sgt_functionarisid != null)
                                    {
                                        ClubCloud_Gebruiker gebruiker = GetGebruikerById(functionaris.sgt_functionarisid.Value, false, settings);
                                        entity.ClubCloud_Gebruiker = gebruiker;
                                        //entity.GebruikerId = functionaris.sgt_functionarisid.Value;
                                    }

                                    ClubCloud_Vereniging vereniging = null;
                                    if (functionaris.sgt_basisorganisatieid != null)
                                    {
                                        vereniging = GetVerenigingById(functionaris.sgt_basisorganisatieid.Value, false, settings);
                                        entity.ClubCloud_Vereniging = vereniging;
                                        //entity.VerenigingId = functionaris.sgt_basisorganisatieid.Value;
                                    }

                                    if (functionaris.sgt_bestuursorgaanid != null)
                                    {
                                        ClubCloud_Bestuursorgaan orgaan = GetBestuursorgaanById(functionaris.sgt_bestuursorgaanid.Value, false, settings);
                                        entity.ClubCloud_Bestuursorgaan = orgaan;
                                        //entity.BestuursorgaanId = functionaris.sgt_bestuursorgaanid.Value;
                                    }
                                }

                                beheerModel.SaveChanges();

                                foreach (sgt_alg_functionaris functionaris in entities)
                                {
                                    ClubCloud_Functionaris entity = beheerModel.ClubCloud_Functionarissen.Find(functionaris.sgt_alg_functionarisid.Value);
                                    bool succes = CreateOrUpdateRoleFunctionaris(entity, settings).Result;
                                }
                            }
                        }
                    }
                }
                functionarissen = beheerModel.ClubCloud_Functionarissen.ToList();
            }
            return functionarissen;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="entity"></param>
        /// <param name="settings"></param>
        /// <returns></returns>
        private ClubCloud_Functionaris SetFunctionaris(string bondsnummer, ClubCloud_Functionaris entity, ClubCloud_Setting settings)
        {
            if (entity.Id == Guid.Empty)
                entity.Id = Guid.NewGuid();

            return entity;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="entity"></param>
        /// <param name="refresh"></param>
        /// <param name="settings"></param>
        /// <returns></returns>
        private ClubCloud_Functie GetFunctieForFunctionaris(string bondsnummer, ClubCloud_Functionaris entity, bool refresh, ClubCloud_Setting settings)
        {
            return GetFunctieForFunctionarisById(bondsnummer, entity.Id, refresh, settings);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="Id"></param>
        /// <param name="refresh"></param>
        /// <param name="settings"></param>
        /// <returns></returns>
        private ClubCloud_Functie GetFunctieForFunctionarisById(string bondsnummer, Guid Id, bool refresh, ClubCloud_Setting settings)
        {
            ClubCloud_Functie result = null;

            ClubCloud_Functionaris functionaris = beheerModel.ClubCloud_Functionarissen.Find(Id);
            if (functionaris != null)
            {
                if (functionaris.ClubCloud_Functie == null && functionaris.FunctieId != null)
                {
                    result = beheerModel.ClubCloud_Functies.Find(functionaris.FunctieId.Value);

                    if (result != null)
                    {
                        functionaris.ClubCloud_Functie = result;
                        beheerModel.SaveChanges();
                    }
                    else
                    {
                        result = GetFunctieById(bondsnummer, functionaris.FunctieId.Value, refresh, settings);
                        if (result != null)
                        {
                            functionaris.ClubCloud_Functie = result;
                            beheerModel.SaveChanges();
                        }

                    }
                }

            }
            return result;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="entity"></param>
        /// <param name="refresh"></param>
        /// <param name="settings"></param>
        /// <returns></returns>
        private ClubCloud_Vereniging GetVerenigingForFunctionaris(string bondsnummer, ClubCloud_Functionaris entity, bool refresh, ClubCloud_Setting settings)
        {
            return GetVerenigingForFunctionarisById(bondsnummer, entity.Id, refresh, settings);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="Id"></param>
        /// <param name="refresh"></param>
        /// <param name="settings"></param>
        /// <returns></returns>
        private ClubCloud_Vereniging GetVerenigingForFunctionarisById(string bondsnummer, Guid Id, bool refresh, ClubCloud_Setting settings)
        {
            ClubCloud_Vereniging result = null;

            ClubCloud_Functionaris functionaris = beheerModel.ClubCloud_Functionarissen.Find(Id);
            if (functionaris != null)
            {
                if (functionaris.ClubCloud_Vereniging == null && functionaris.VerenigingId != null)
                {
                    result = beheerModel.ClubCloud_Verenigingen.Find(functionaris.VerenigingId.Value);

                    if (result != null)
                    {
                        functionaris.ClubCloud_Vereniging = result;
                        beheerModel.SaveChanges();
                    }
                    else
                    {
                        result = GetVerenigingById(bondsnummer, functionaris.VerenigingId.Value, refresh, settings);
                        if (result != null)
                        {
                            functionaris.ClubCloud_Vereniging = result;
                            beheerModel.SaveChanges();
                        }

                    }
                }

            }
            return result;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="entity"></param>
        /// <param name="refresh"></param>
        /// <param name="settings"></param>
        /// <returns></returns>
        private ClubCloud_Gebruiker GetGebruikerForFunctionaris(string bondsnummer, ClubCloud_Functionaris entity, bool refresh, ClubCloud_Setting settings)
        {
            return GetGebruikerForFunctionarisById(bondsnummer, entity.Id, refresh, settings);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="Id"></param>
        /// <param name="refresh"></param>
        /// <param name="settings"></param>
        /// <returns></returns>
        private ClubCloud_Gebruiker GetGebruikerForFunctionarisById(string bondsnummer, Guid Id, bool refresh, ClubCloud_Setting settings)
        {
            ClubCloud_Gebruiker result = null;

            ClubCloud_Functionaris functionaris = beheerModel.ClubCloud_Functionarissen.Find(Id);
            if (functionaris != null)
            {
                if (functionaris.ClubCloud_Gebruiker == null && functionaris.GebruikerId != null)
                {
                    result = beheerModel.ClubCloud_Gebruikers.Find(functionaris.GebruikerId.Value);

                    if (result != null)
                    {
                        functionaris.ClubCloud_Gebruiker = result;
                        beheerModel.SaveChanges();
                    }
                    else
                    {
                        result = GetGebruikerById(bondsnummer, functionaris.GebruikerId.Value, refresh, settings);
                        if (result != null)
                        {
                            functionaris.ClubCloud_Gebruiker = result;
                            beheerModel.SaveChanges();
                        }

                    }
                }

            }
            return result;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="entity"></param>
        /// <param name="refresh"></param>
        /// <param name="settings"></param>
        /// <returns></returns>
        private ClubCloud_District GetDistrictForFunctionaris(string bondsnummer, ClubCloud_Functionaris entity, bool refresh, ClubCloud_Setting settings)
        {
            return GetDistrictForFunctionarisById(bondsnummer, entity.Id, refresh, settings);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="Id"></param>
        /// <param name="refresh"></param>
        /// <param name="settings"></param>
        /// <returns></returns>
        private ClubCloud_District GetDistrictForFunctionarisById(string bondsnummer, Guid Id, bool refresh, ClubCloud_Setting settings)
        {
            ClubCloud_District result = null;

            ClubCloud_Functionaris functionaris = beheerModel.ClubCloud_Functionarissen.Find(Id);
            if (functionaris != null)
            {
                if (functionaris.ClubCloud_District == null && functionaris.DistrictId != null)
                {
                    result = beheerModel.ClubCloud_Districten.Find(functionaris.DistrictId.Value);

                    if (result != null)
                    {
                        functionaris.ClubCloud_District = result;
                        beheerModel.SaveChanges();
                    }
                    else
                    {
                        result = GetDistrictById(bondsnummer, functionaris.DistrictId.Value, refresh, settings);
                        if (result != null)
                        {
                            functionaris.ClubCloud_District = result;
                            beheerModel.SaveChanges();
                        }

                    }
                }

            }
            return result;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="entity"></param>
        /// <param name="refresh"></param>
        /// <param name="settings"></param>
        /// <returns></returns>
        private ClubCloud_Bestuursorgaan GetBestuursorgaanForFunctionaris(string bondsnummer, ClubCloud_Functionaris entity, bool refresh, ClubCloud_Setting settings)
        {
            return GetBestuursorgaanForFunctionarisById(bondsnummer, entity.Id, refresh, settings);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="Id"></param>
        /// <param name="refresh"></param>
        /// <param name="settings"></param>
        /// <returns></returns>
        private ClubCloud_Bestuursorgaan GetBestuursorgaanForFunctionarisById(string bondsnummer, Guid Id, bool refresh, ClubCloud_Setting settings)
        {
            ClubCloud_Bestuursorgaan result = null;

            ClubCloud_Functionaris functionaris = beheerModel.ClubCloud_Functionarissen.Find(Id);
            if (functionaris != null)
            {
                if (functionaris.ClubCloud_Bestuursorgaan == null && functionaris.BestuursorgaanId != null)
                {
                    result = beheerModel.ClubCloud_Bestuursorganen.Find(functionaris.BestuursorgaanId.Value);

                    if (result != null)
                    {
                        functionaris.ClubCloud_Bestuursorgaan = result;
                        beheerModel.SaveChanges();
                    }
                    else
                    {
                        result = GetBestuursorgaanById(bondsnummer, functionaris.BestuursorgaanId.Value, refresh, settings);
                        if (result != null)
                        {
                            functionaris.ClubCloud_Bestuursorgaan = result;
                            beheerModel.SaveChanges();
                        }

                    }
                }

            }
            return result;
        }

        /*
        /// <summary>
        /// 
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="functionaris"></param>
        /// <param name="refresh"></param>
        /// <returns></returns>
        private ClubCloud_Functionaris FunctionarisCreate(string bondsnummer, ClubCloud_Functionaris functionaris, bool refresh = false)
        {
            if (functionaris.Id == null)
            {
                sgt_alg_functionaris sgt_functionaris = new sgt_alg_functionaris
                {
                    //sgt_alg_name = functionaris.GebruikerNaam,
                    sgt_basisorganisatieid = new Lookup { name = functionaris.ClubCloud_Vereniging.Naam, Value = functionaris.ClubCloud_Vereniging.Id },
                    //sgt_bestuursorgaanid = new Lookup { name = functionaris.BestuursorgaanNaam, Value = functionaris.BestuursorgaanId },
                    //sgt_districtid = new Lookup { name = functionaris.DistrictNaam, Value = functionaris.DistrictId },
                    //sgt_functieid = new Lookup { name = functionaris.FunctieNaam, Value = functionaris.FunctieId },
                    //sgt_functionarisid = new Lookup { name = functionaris.GebruikerNaam, Value = functionaris.GebruikerId },
                    sgt_termijn_begint = new CrmDateTime { Value = functionaris.TermijnBegin.ToString() },
                    sgt_termijn_loopt_af = new CrmDateTime { Value = functionaris.TermijnEinde.Value.ToString() }
                };

                TargetCreateSgt_alg_functionaris create = new TargetCreateSgt_alg_functionaris { Sgt_alg_functionaris = sgt_functionaris };


                beheerModel.ClubCloud_Functionarissen.Add(functionaris);

                beheerModel.SaveChanges();
            }
            //}

            return functionaris;
        }
        */

        /*
        /// <summary>
        /// sgt_alg_functionaris
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="VerenigingId"></param>
        /// <param name="FunctieId"></param>
        /// <param name="refresh"></param>
        /// <returns></returns>
        private List<ClubCloud_Functionaris> GetFunctionarissenByFunctie(string bondsnummer, Guid VerenigingId, Guid FunctieId, bool refresh = false, ClubCloud_Setting settings = null)
        {
            List<ClubCloud_Functionaris> functionarissen = new List<ClubCloud_Functionaris>();

            functionarissen = beheerModel.ClubCloud_Functionarissen.Where(f => f.VerenigingId == VerenigingId && f.FunctieId == FunctieId).ToList(); // && f.Actief == Sgt_alg_functionarisState.Active.ToString()).ToList();

            if (functionarissen != null && functionarissen.Count == 0 || refresh)
            {
                if (settings == null)
                {
                    settings = GetSettings(bondsnummer);
                }

                if (settings != null && settings.Access && !string.IsNullOrWhiteSpace(settings.Password))
                {
                    CookieContainer cc = RequestContainer(settings.Id.ToString(), settings.Password);

                    if (cc != null)
                    {
                        using (ClubCloud.KNLTB.ServIt.CrmService.CrmService service = CrmServices[settings.Id.ToString()])
                        {

                            //CrmService.CrmCookieContainer = cc; 
                            //ClubCloud.KNLTB.ServIt.CrmService.CrmService service = new KNLTB.ServIt.CrmService.CrmService(cc);

                            ConditionExpression condition = new ConditionExpression { AttributeName = "sgt_functieid", Operator = ConditionOperator.Equal, Values = new object[1] { FunctieId } };
                            FilterExpression expression = new FilterExpression { FilterOperator = LogicalOperator.And, Conditions = new ConditionExpression[1] { condition } };

                            bool moreRecords = true;
                            int pageNum = 1;
                            while (moreRecords)
                            {
                                List<BusinessEntity> entities = RetrieveMultiple(service, "sgt_alg_functionaris", out moreRecords, ref pageNum, expression);

                                foreach (sgt_alg_functionaris entity in entities)
                                {
                                    ClubCloud_Functionaris functionaris = beheerModel.ClubCloud_Functionarissen.SingleOrDefault(f => f.Id == entity.sgt_alg_functionarisid.Value);

                                    if (functionaris == null)
                                    {
                                        functionaris = beheerModel.ClubCloud_Functionarissen.Create();
                                        functionaris.Id = entity.sgt_alg_functionarisid.Value;
                                        FunctionarisToEntity(entity, functionaris, settings);


                                        beheerModel.ClubCloud_Functionarissen.Add(functionaris);
                                        //functionarissen.Add(functionaris);

                                    }
                                    else
                                    {
                                        //ClubCloud_Functionaris tobeupdated = new ClubCloud_Functionaris();
                                        FunctionarisToEntity(entity, functionaris, settings);
                                        //beheerModel.Entry(functionaris).CurrentValues.SetValues(tobeupdated);                                    

                                        //EntityToFunctionaris(entity, functionaris, bondsnummer);
                                        //functionarissen.Add(functionaris);
                                    }

                                    beheerModel.SaveChanges();
                                }
                            }
                        }
                    }
                }
                functionarissen = beheerModel.ClubCloud_Functionarissen.Where(f => f.VerenigingId == VerenigingId && f.FunctieId == FunctieId).ToList(); // && f.Actief == Sgt_alg_functionarisState.Active.ToString()).ToList();
            }
            return functionarissen;
        }
        */

        /*
        /// <summary>
        /// 
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="gebruikerId"></param>
        /// <param name="refresh"></param>
        /// <returns></returns>
        private List<ClubCloud_Functionaris> FunctionarissenByGebruiker(int bondsnummer, Guid gebruikerId, bool refresh = false, ClubCloud_Setting settings = null)
        {
            return FunctionarissenByGebruiker(bondsnummer.ToString(), gebruikerId, refresh, settings);
        }
        */

        /*
        private async Task GetFunctionarissenByGebruikerAsync(string bondsnummer, List<BusinessEntity> entities)
        {
            foreach (contact entity in entities)
            {
                if (entity.sgt_is_functionaris != null && entity.sgt_is_functionaris.Value)
                {
                    ClubCloud_Gebruiker gebruiker = beheerModel.ClubCloud_Gebruikers.Find(entity.contactid.Value);

                    List<ClubCloud_Functionaris> functionarissen = GetFunctionarissenByGebruiker(bondsnummer, entity.contactid.Value);
                    foreach (ClubCloud_Functionaris functionaris in functionarissen)
                    {
                        gebruiker.ClubCloud_Functionaris.Add(functionaris);
                    }
                }
            }
        }
        */

        /*
        /// <summary>
        /// sgt_alg_functionaris
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="VerenigingId"></param>
        /// <param name="gebruikerId"></param>
        /// <param name="refresh"></param>
        /// <returns></returns>
        private List<ClubCloud_Functionaris> GetFunctionarissenByGebruiker(string bondsnummer, Guid gebruikerId, bool refresh = false, ClubCloud_Setting settings = null)
        {
            return GetFunctionarissenByGebruiker(int.Parse(bondsnummer), gebruikerId, refresh, settings);
        }
        */

        /*
        /// <summary>
        /// 
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="VerenigingId"></param>
        /// <param name="refresh"></param>
        /// <returns></returns>
        private List<ClubCloud_Functionaris> GetFunctionarissenByVereniging(int bondsnummer, Guid VerenigingId, bool refresh = false, ClubCloud_Setting settings = null)
        {
            return GetFunctionarissenByVereniging(bondsnummer.ToString(), VerenigingId, refresh, settings);
        }
        */

        /*
        /// <summary>
        /// sgt_alg_functionaris
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="VerenigingId"></param>
        /// <param name="refresh"></param>
        /// <returns></returns>
        private List<ClubCloud_Functionaris> GetFunctionarissenByVereniging(string bondsnummer, Guid VerenigingId, bool refresh = false, ClubCloud_Setting settings = null)
        {
            List<ClubCloud_Functionaris> functionarissen = new List<ClubCloud_Functionaris>();

            functionarissen = beheerModel.ClubCloud_Functionarissen.Where(f => f.VerenigingId == VerenigingId).ToList(); // && f.Actief == Sgt_alg_functionarisState.Active.ToString()).ToList();

            if (functionarissen != null && functionarissen.Count == 0 || refresh)
            {
                if (settings == null)
                {
                    settings = GetSettings(bondsnummer);
                }

                if (settings != null && settings.Access && !string.IsNullOrWhiteSpace(settings.Password))
                {
                    CookieContainer cc = RequestContainer(settings.Id.ToString(), settings.Password);

                    if (cc != null)
                    {
                        using (ClubCloud.KNLTB.ServIt.CrmService.CrmService service = CrmServices[settings.Id.ToString()])
                        {

                            //CrmService.CrmCookieContainer = cc;
                            //ClubCloud.KNLTB.ServIt.CrmService.CrmService service = new KNLTB.ServIt.CrmService.CrmService(cc);

                            ConditionExpression condition = new ConditionExpression { AttributeName = "sgt_basisorganisatieid", Operator = ConditionOperator.Equal, Values = new object[1] { VerenigingId } };
                            FilterExpression expression = new FilterExpression { FilterOperator = LogicalOperator.And, Conditions = new ConditionExpression[1] { condition } };

                            bool moreRecords = true;
                            int pageNum = 1;
                            while (moreRecords)
                            {

                                List<BusinessEntity> entities = RetrieveMultiple(service, "sgt_alg_functionaris", out moreRecords, ref pageNum, expression);

                                foreach (sgt_alg_functionaris entity in entities)
                                {
                                    ClubCloud_Functionaris functionaris = beheerModel.ClubCloud_Functionarissen.Find(entity.sgt_alg_functionarisid.Value);

                                    if (functionaris == null)
                                    {
                                        //functionaris = beheerModel.ClubCloud_Functionarissen.Create();
                                        //functionaris.Id = entity.sgt_alg_functionarisid.Value;
                                        functionaris = new ClubCloud_Functionaris();
                                        FunctionarisToEntity(entity, functionaris, settings);

                                        //beheerModel.ClubCloud_Functionarissen.Add(functionaris);
                                    }
                                    else
                                    {
                                        FunctionarisToEntity(entity, functionaris, settings);
                                    }
                                    beheerModel.SaveChanges();
                                }
                            }
                        }
                    }
                }
                functionarissen = beheerModel.ClubCloud_Functionarissen.Where(f => f.VerenigingId == VerenigingId).ToList(); // && f.Actief == Sgt_alg_functionarisState.Active.ToString()).ToList();
            }
            return functionarissen;
        }
        */

        /*
        /// <summary>
        /// 
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="functionaris"></param>
        /// <param name="refresh"></param>
        /// <returns></returns>
        private ClubCloud_Functionaris FunctionarisUpdate(string bondsnummer, ClubCloud_Functionaris functionaris, bool refresh = false)
        {
            //CheckDatabase();
            ClubCloud_Functionaris updatable = functionaris;


            //if (beheerModel == null)
            //{
            //    beheerModel = new Model.BeheerContainer(GetConnectionString());
            //}

            //using (ClubCloud.Model.BeheerContainer model = new Model.BeheerContainer(GetConnectionString()))
            //{

            updatable = beheerModel.ClubCloud_Functionarissen.Find(functionaris.Id);
            updatable.TermijnBegin = functionaris.TermijnBegin;
            updatable.TermijnEinde = functionaris.TermijnEinde;


            if (beheerModel.ChangeTracker.HasChanges())
            {
                ClubCloud_Setting settings = GetSettings(bondsnummer);

                if (settings != null && settings.Access && !string.IsNullOrWhiteSpace(settings.Password))
                {
                    CookieContainer cc = RequestContainer(settings.Id.ToString(), settings.Password);

                    if (cc != null)
                    {
                        using (ClubCloud.KNLTB.ServIt.CrmService.CrmService service = CrmServices[settings.Id.ToString()])
                        {

                            //CrmService.CrmCookieContainer = cc; 
                            //ClubCloud.KNLTB.ServIt.CrmService.CrmService service = new KNLTB.ServIt.CrmService.CrmService(cc);

                            sgt_alg_functionaris sgt_functionaris = new sgt_alg_functionaris
                            {
                                sgt_termijn_begint = new CrmDateTime { Value = functionaris.TermijnBegin.ToString() },
                                sgt_termijn_loopt_af = new CrmDateTime { Value = functionaris.TermijnEinde.Value.ToString() }
                            };

                            TargetUpdateSgt_alg_functionaris update = new TargetUpdateSgt_alg_functionaris { Sgt_alg_functionaris = sgt_functionaris };

                            UpdateRequest updateRequest = new UpdateRequest { Target = update };
                            UpdateResponse updateResponse = service.Execute(updateRequest) as UpdateResponse;

                            if (updatable.Actief != functionaris.Actief)
                            {
                                updatable.Actief = functionaris.Actief;

                                SetStateSgt_alg_functionarisRequest stateRequest = null;
                                if (functionaris.Actief == Sgt_alg_functieState.Active.ToString())
                                {
                                    stateRequest = new SetStateSgt_alg_functionarisRequest { EntityId = functionaris.Id, Sgt_alg_functionarisState = Sgt_alg_functionarisState.Active, Sgt_alg_functionarisStatus = 1 };
                                }
                                else
                                {
                                    stateRequest = new SetStateSgt_alg_functionarisRequest { EntityId = functionaris.Id, Sgt_alg_functionarisState = Sgt_alg_functionarisState.Inactive, Sgt_alg_functionarisStatus = 2 };
                                }

                                SetStateSgt_alg_functionarisResponse stateResponse = service.Execute(stateRequest) as SetStateSgt_alg_functionarisResponse;
                            }
                        }
                    }
                }

                beheerModel.SaveChanges();
                updatable = beheerModel.ClubCloud_Functionarissen.Find(functionaris.Id);
            }
            //}

            return updatable;
        }
        */

        /*
        /// <summary>
        /// 
        /// </summary>
        /// <param name="entity"></param>
        /// <param name="functionaris"></param>
        /// <param name="bondsnummer"></param>
        private void EntityToFunctionaris(sgt_alg_functionaris entity, ClubCloud_Functionaris functionaris, string bondsnummer, ClubCloud_Setting settings = null)
        {
            if (entity.sgt_functieid != null)
            {
                ClubCloud_Functie functie = GetFunctieById(bondsnummer, entity.sgt_functieid.Value, false, settings);
                functionaris.ClubCloud_Functie = functie;
                functionaris.FunctieId = entity.sgt_functieid.Value;
            }

            if (entity.sgt_functionarisid != null)
            {
                ClubCloud_Gebruiker gebruiker = GebruikerById(bondsnummer, entity.sgt_functionarisid.Value, false, settings);
                functionaris.ClubCloud_Gebruiker = gebruiker;
                functionaris.GebruikerId = entity.sgt_functionarisid.Value;
            }

            ClubCloud_Vereniging vereniging = null;
            if (entity.sgt_basisorganisatieid != null)
            {
                vereniging = GetVerenigingById(bondsnummer, entity.sgt_basisorganisatieid.Value, false, settings);
                functionaris.ClubCloud_Vereniging = vereniging;
                functionaris.VerenigingId = entity.sgt_basisorganisatieid.Value;
            }

            if (entity.sgt_bestuursorgaanid != null)
            {
                ClubCloud_Bestuursorgaan orgaan = GetBestuursorgaanById(bondsnummer, entity.sgt_bestuursorgaanid.Value, false, settings);
                functionaris.ClubCloud_Bestuursorgaan = orgaan;
                functionaris.BestuursorgaanId = entity.sgt_bestuursorgaanid.Value;
            }

            if (entity.sgt_termijn_begint != null)
            {
                functionaris.TermijnBegin = DateTime.Parse(entity.sgt_termijn_begint.Value);
            }
            else
            {
                if (vereniging != null && vereniging.Oprichting.HasValue)
                {
                    functionaris.TermijnBegin = vereniging.Oprichting.Value;
                }
                else
                {
                    functionaris.TermijnBegin = DateTime.Now;
                }
            }

            if (entity.sgt_termijn_loopt_af != null)
            {
                functionaris.TermijnEinde = DateTime.Parse(entity.sgt_termijn_loopt_af.Value); ;
            }
            if (entity.sgt_autorisatie_gezet != null)
            {
                functionaris.Autorisatie = entity.sgt_autorisatie_gezet.Value;
            }
            functionaris.Actief = entity.statuscode.name;
            functionaris.Gewijzigd = DateTime.Now;

        }
        */

        /*
        /// <summar>
        /// y
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="gebruikerId"></param>
        /// <param name="refresh"></param>
        /// <param name="settings"></param>
        /// <returns></returns>
        private List<ClubCloud_Functionaris> GetFunctionarissenByGebruiker(int bondsnummer, Guid gebruikerId, bool refresh, ClubCloud_Setting settings = null)
        {
            List<ClubCloud_Functionaris> functionarissen = new List<ClubCloud_Functionaris>();

            functionarissen = beheerModel.ClubCloud_Functionarissen.Where(f => f.GebruikerId == gebruikerId).ToList();// && f.Actief == Sgt_alg_functionarisState.Active.ToString()).ToList();

            if (functionarissen != null && functionarissen.Count == 0 || refresh)
            {
                if (settings == null)
                {
                    settings = GetSettings(bondsnummer);
                }

                if (settings != null && settings.Access && !string.IsNullOrWhiteSpace(settings.Password))
                {
                    CookieContainer cc = RequestContainer(settings.Id.ToString(), settings.Password);

                    if (cc != null)
                    {
                        using (ClubCloud.KNLTB.ServIt.CrmService.CrmService service = CrmServices[settings.Id.ToString()])
                        {

                            //CrmService.CrmCookieContainer = cc;
                            //ClubCloud.KNLTB.ServIt.CrmService.CrmService service = new KNLTB.ServIt.CrmService.CrmService(cc);

                            ConditionExpression condition = new ConditionExpression { AttributeName = "sgt_functionarisid", Operator = ConditionOperator.Equal, Values = new object[1] { gebruikerId } };
                            FilterExpression expression = new FilterExpression { FilterOperator = LogicalOperator.And, Conditions = new ConditionExpression[1] { condition } };

                            bool moreRecords = true;
                            int pageNum = 1;
                            while (moreRecords)
                            {
                                List<BusinessEntity> entities = RetrieveMultiple(service, "sgt_alg_functionaris", out moreRecords, ref pageNum, expression);

                                foreach (sgt_alg_functionaris entity in entities)
                                {
                                    ClubCloud_Functionaris functionaris = beheerModel.ClubCloud_Functionarissen.Find(entity.sgt_alg_functionarisid.Value);

                                    if (functionaris == null)
                                    {
                                        functionaris = beheerModel.ClubCloud_Functionarissen.Create();
                                        functionaris.Id = entity.sgt_alg_functionarisid.Value;

                                        FunctionarisToEntity(entity, functionaris, settings);

                                        beheerModel.ClubCloud_Functionarissen.Add(functionaris);
                                        //functionarissen.Add(functionaris);

                                    }
                                    else
                                    {
                                        FunctionarisToEntity(entity, functionaris, settings);
                                        //functionarissen.Add(functionaris);
                                    }
                                    beheerModel.SaveChanges();
                                }
                            }
                        }
                    }
                }
                functionarissen = beheerModel.ClubCloud_Functionarissen.Where(f => f.GebruikerId == gebruikerId).ToList();// && f.Actief == Sgt_alg_functionarisState.Active.ToString()).ToList();
            }
            return functionarissen;
        }
        */

        #region Mapping

        /// <summary>
        /// 
        /// </summary>
        /// <param name="functionaris"></param>
        /// <param name="entity"></param>
        /// <param name="settings"></param>
        private void FunctionarisToEntity(sgt_alg_functionaris functionaris, ClubCloud_Functionaris entity, ClubCloud_Setting settings)
        {
            if (functionaris.sgt_functieid != null)
            {
                //ClubCloud_Functie functie = GetFunctieById(functionaris.sgt_functieid.Value, false, settings);
                //entity.ClubCloud_Functie = functie;
                entity.FunctieId = functionaris.sgt_functieid.Value;
            }

            if (functionaris.sgt_functionarisid != null)
            {
                //ClubCloud_Gebruiker gebruiker = GetGebruikerById(functionaris.sgt_functionarisid.Value, false, settings);
                //entity.ClubCloud_Gebruiker = gebruiker;
                entity.GebruikerId = functionaris.sgt_functionarisid.Value;
            }

            ClubCloud_Vereniging vereniging = null;
            if (functionaris.sgt_basisorganisatieid != null)
            {
                //vereniging = GetVerenigingById(functionaris.sgt_basisorganisatieid.Value, false, settings);
                //entity.ClubCloud_Vereniging = vereniging;
                entity.VerenigingId = functionaris.sgt_basisorganisatieid.Value;
            }

            if (functionaris.sgt_bestuursorgaanid != null)
            {
                //ClubCloud_Bestuursorgaan orgaan = GetBestuursorgaanById(functionaris.sgt_bestuursorgaanid.Value, false, settings);
                //entity.ClubCloud_Bestuursorgaan = orgaan;
                entity.BestuursorgaanId = functionaris.sgt_bestuursorgaanid.Value;
            }

            if (functionaris.sgt_termijn_begint != null)
            {
                entity.TermijnBegin = DateTime.Parse(functionaris.sgt_termijn_begint.Value);
            }
            else
            {
                if (vereniging != null && vereniging.Oprichting.HasValue)
                {
                    entity.TermijnBegin = vereniging.Oprichting.Value;
                }
                else
                {
                    entity.TermijnBegin = DateTime.Now;
                }
            }

            if (functionaris.sgt_termijn_loopt_af != null)
            {
                entity.TermijnEinde = DateTime.Parse(functionaris.sgt_termijn_loopt_af.Value); ;
            }
            if (functionaris.sgt_autorisatie_gezet != null)
            {
                entity.Autorisatie = functionaris.sgt_autorisatie_gezet.Value;
            }
            entity.Actief = (ActiefSoort)functionaris.statuscode.Value;
            entity.Gewijzigd = DateTime.Now;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="functionaris"></param>
        /// <param name="entity"></param>
        /// <param name="settings"></param>
        private void EntityToFunctionaris(sgt_alg_functionaris functionaris, ClubCloud_Functionaris entity, ClubCloud_Setting settings)
        {

        }

        #endregion

        #endregion

        #region Gebruiker

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="Id"></param>
        /// <param name="refresh"></param>
        /// <param name="settings"></param>
        /// <returns></returns>
        private ClubCloud_Gebruiker GetGebruikerById(string bondsnummer, Guid Id, bool refresh, ClubCloud_Setting settings)
        {
            ClubCloud_Gebruiker entity = null;

            entity = beheerModel.ClubCloud_Gebruikers.Find(Id);

            if (entity == null || refresh)
            {
                if (settings == null)
                    settings = GetSettings(bondsnummer);

                ClubCloud_Vereniging vereniging = GetVerenigingById(bondsnummer, settings.VerenigingId.Value, false);

                if (settings != null && settings.Access && !string.IsNullOrWhiteSpace(settings.Password))
                {
                    CookieContainer cc = RequestContainer(settings.Id.ToString(), settings.Password);

                    if (cc != null)
                    {
                        using (ClubCloud.KNLTB.ServIt.CrmService.CrmService service = CrmServices[settings.Id.ToString()])
                        {
                            contact contact = RetrieveEntity(service, "contact", Id) as contact;

                            if (contact != null && contact.contactid.Value == Id)
                            {
                                if (entity == null)
                                    entity = beheerModel.ClubCloud_Gebruikers.Create();

                                entity.Id = contact.contactid.Value;

                                GebruikerToEntity(contact, entity, settings);

                                beheerModel.ClubCloud_Gebruikers.AddOrUpdate(entity);

                                beheerModel.SaveChanges();

                                entity.VerenigingId = vereniging.Id;
                                entity.ClubCloud_Vereniging = vereniging;

                                if (contact.parentcustomerid != null)
                                {
                                    ClubCloud_Vereniging parent = GetVerenigingById(contact.parentcustomerid.Value, false, settings);
                                    if (parent != null)
                                        entity.ClubCloud_Vereniging = parent;
                                }

                                if (contact.sgt_nationaliteitid != null)
                                {
                                    ClubCloud_Nationaliteit nationaliteit = GetNationaliteitById(contact.sgt_nationaliteitid.Value, false, settings);
                                    if (nationaliteit != null)
                                        entity.ClubCloud_Nationaliteit = nationaliteit;
                                }

                                if (contact.address1_addressid != null)
                                {
                                    ClubCloud_Address bezoek = GetAddressById(contact.address1_addressid.Value, false, settings);
                                    if (bezoek != null)
                                        entity.ClubCloud_Address.Add(bezoek);
                                }
                                if (contact.address2_addressid != null)
                                {
                                    ClubCloud_Address post = GetAddressById(contact.address2_addressid.Value, false, settings);
                                    if (post != null)
                                        entity.ClubCloud_Address.Add(post);
                                }

                                beheerModel.SaveChanges();

                                int _bondsnummer;

                                if (int.TryParse(contact.sgt_bondsnummer, out _bondsnummer))
                                {
                                    ClubCloud_Setting usersettings = beheerModel.ClubCloud_Settings.Find(_bondsnummer);

                                    if (usersettings == null)
                                        usersettings = beheerModel.ClubCloud_Settings.Create();

                                    usersettings.Id = _bondsnummer;
                                    usersettings.Access = false;
                                    usersettings.Agree = false;
                                    usersettings.facebook_allow = false;
                                    usersettings.facebook_setting = Facebook.None;
                                    usersettings.financieel = Financieel.None;
                                    usersettings.privacy = Privacy.None;
                                    usersettings.twitter_allow = false;
                                    usersettings.twitter_setting = Twitter.None;

                                    usersettings.VerenigingId = vereniging.Id;
                                    usersettings.ClubCloud_Vereniging = vereniging;

                                    if (contact.parentcustomerid != null)
                                        usersettings.VerenigingId = contact.parentcustomerid.Value;

                                    if (contact.contactid != null)
                                        usersettings.GebruikerId = contact.contactid.Value;

                                }

                                beheerModel.SaveChanges();

                                bool result = CreateOrUpdateMembershipGebruiker(entity, settings).Result;

                                if (contact.sgt_is_functionaris != null && contact.sgt_is_functionaris.Value)
                                {
                                    GetFunctionarissenForGebruikerById(bondsnummer, contact.contactid.Value, refresh, settings);
                                }

                                beheerModel.SaveChanges();
                            }
                        }
                    }
                }
                entity = beheerModel.ClubCloud_Gebruikers.Find(Id);
            }
            return entity;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bondnummer"></param>
        /// <param name="refresh"></param>
        /// <param name="settings"></param>
        /// <returns></returns>
        private List<ClubCloud_Gebruiker> GetGebruikers(string bondsnummer, bool refresh, ClubCloud_Setting settings)
        {
            List<ClubCloud_Gebruiker> gebruikers = new List<ClubCloud_Gebruiker>();
            if (settings == null)
                settings = GetSettings(bondsnummer);

            ClubCloud_Vereniging vereniging = GetVerenigingById(settings.VerenigingId.Value, false, settings);
            gebruikers = beheerModel.ClubCloud_Gebruikers.Where(g => g.VerenigingId == vereniging.Id).ToList();

            if (gebruikers != null && gebruikers.Count == 0 || refresh)
            {
                if (settings == null)
                    settings = GetSettings(bondsnummer);

                if (settings != null && settings.Access && !string.IsNullOrWhiteSpace(settings.Password))
                {
                    CookieContainer cc = RequestContainer(settings.Id.ToString(), settings.Password);

                    if (cc != null)
                    {
                        using (ClubCloud.KNLTB.ServIt.CrmService.CrmService service = CrmServices[settings.Id.ToString()])
                        {
                            bool moreRecords = true;
                            int pageNum = 1;
                            while (moreRecords)
                            {
                                ConditionExpression condition = new ConditionExpression { AttributeName = "sgt_primaire_vereniging_id", Operator = ConditionOperator.Equal, Values = new object[1] { vereniging.Id } };
                                FilterExpression expression = new FilterExpression { FilterOperator = LogicalOperator.And, Conditions = new ConditionExpression[1] { condition } };

                                List<BusinessEntity> entities = RetrieveMultiple(service, "contact", out moreRecords, ref pageNum, expression);

                                foreach (contact contact in entities)
                                {
                                    ClubCloud_Gebruiker entity = beheerModel.ClubCloud_Gebruikers.Find(contact.contactid.Value);

                                    if (entity == null)
                                        entity = beheerModel.ClubCloud_Gebruikers.Create();

                                    entity.Id = contact.contactid.Value;

                                    GebruikerToEntity(contact, entity, settings);

                                    beheerModel.ClubCloud_Gebruikers.AddOrUpdate(entity);
                                }
                                beheerModel.SaveChanges();

                                foreach (contact contact in entities)
                                {
                                    ClubCloud_Gebruiker entity = beheerModel.ClubCloud_Gebruikers.Find(contact.contactid.Value);

                                    entity.VerenigingId = vereniging.Id;
                                    entity.ClubCloud_Vereniging = vereniging;

                                    if (contact.parentcustomerid != null)
                                    {
                                        vereniging = GetVerenigingById(contact.parentcustomerid.Value, false, settings);
                                        if (vereniging != null)
                                            entity.ClubCloud_Vereniging = vereniging;
                                    }

                                    if (contact.sgt_nationaliteitid != null)
                                    {
                                        ClubCloud_Nationaliteit nationaliteit = GetNationaliteitById(contact.sgt_nationaliteitid.Value, false, settings);
                                        if (nationaliteit != null)
                                            entity.ClubCloud_Nationaliteit = nationaliteit;
                                    }

                                    if (contact.address1_addressid != null)
                                    {
                                        ClubCloud_Address bezoek = GetAddressById(contact.address1_addressid.Value, false, settings);
                                        if (bezoek != null)
                                            entity.ClubCloud_Address.Add(bezoek);
                                    }
                                    if (contact.address2_addressid != null)
                                    {
                                        ClubCloud_Address post = GetAddressById(contact.address2_addressid.Value, false, settings);
                                        if (post != null)
                                            entity.ClubCloud_Address.Add(post);
                                    }
                                }

                                beheerModel.SaveChanges();

                                foreach (contact contact in entities)
                                {
                                    int _bondsnummer;
                                    if (int.TryParse(contact.sgt_bondsnummer, out _bondsnummer))
                                    {
                                        ClubCloud_Setting usersettings = beheerModel.ClubCloud_Settings.Find(_bondsnummer);

                                        if (usersettings == null)
                                            usersettings = beheerModel.ClubCloud_Settings.Create();

                                        usersettings.Id = _bondsnummer;
                                        usersettings.Access = false;
                                        usersettings.Agree = false;
                                        usersettings.facebook_allow = false;
                                        usersettings.facebook_setting = Facebook.None;
                                        usersettings.financieel = Financieel.None;
                                        usersettings.privacy = Privacy.None;
                                        usersettings.twitter_allow = false;
                                        usersettings.twitter_setting = Twitter.None;

                                        usersettings.VerenigingId = vereniging.Id;
                                        usersettings.ClubCloud_Vereniging = vereniging;

                                        if (contact.parentcustomerid != null)
                                            usersettings.VerenigingId = contact.parentcustomerid.Value;

                                        if (contact.contactid != null)
                                            usersettings.GebruikerId = contact.contactid.Value;

                                        usersettings.Gewijzigd = DateTime.Now;
                                        beheerModel.ClubCloud_Settings.AddOrUpdate(usersettings);
                                    }
                                }
                                beheerModel.SaveChanges();

                                foreach (contact entity in entities)
                                {
                                    ClubCloud_Gebruiker gebruiker = beheerModel.ClubCloud_Gebruikers.Find(entity.contactid.Value);
                                    bool result = CreateOrUpdateMembershipGebruiker(gebruiker, settings).Result;
                                }

                                foreach (contact entity in entities)
                                {
                                    ClubCloud_Gebruiker gebruiker = beheerModel.ClubCloud_Gebruikers.Find(entity.contactid.Value);

                                    if (entity.sgt_is_functionaris != null && entity.sgt_is_functionaris.Value)
                                    {
                                        GetFunctionarissenForGebruikerById(bondsnummer, entity.contactid.Value, refresh, settings);
                                    }
                                }

                                beheerModel.SaveChanges();
                            }
                        }
                    }
                }

                gebruikers = beheerModel.ClubCloud_Gebruikers.Where(g => g.VerenigingId == vereniging.Id).ToList();
            }

            return gebruikers;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bondnummer"></param>
        /// <param name="entity"></param>
        /// <param name="settings"></param>
        /// <returns></returns>
        private ClubCloud_Gebruiker SetGebruiker(string bondnummer, ClubCloud_Gebruiker entity, ClubCloud_Setting settings)
        {
            if (entity.Id == Guid.Empty)


                entity.Id = Guid.NewGuid();

            return entity;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="entity"></param>
        /// <param name="refresh"></param>
        /// <param name="settings"></param>
        /// <returns></returns>
        private List<ClubCloud_Functionaris> GetFunctionarissenForGebruiker(string bondsnummer, ClubCloud_Gebruiker entity, bool refresh, ClubCloud_Setting settings)
        {
            return GetFunctionarissenForGebruikerById(bondsnummer, entity.Id, refresh, settings);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="Id"></param>
        /// <param name="refresh"></param>
        /// <param name="settings"></param>
        /// <returns></returns>
        private List<ClubCloud_Functionaris> GetFunctionarissenForGebruikerById(string bondsnummer, Guid Id, bool refresh, ClubCloud_Setting settings)
        {
            List<ClubCloud_Functionaris> result = null;

            ClubCloud_Gebruiker gebruiker = beheerModel.ClubCloud_Gebruikers.Find(Id);

            if (gebruiker != null)
            {
                if (gebruiker.ClubCloud_Functionaris == null || gebruiker.ClubCloud_Functionaris.Count == 0)
                {
                    result = beheerModel.ClubCloud_Functionarissen.Where(v => v.GebruikerId.Value == Id).ToList();

                    foreach (ClubCloud_Functionaris functionaris in result)
                    {
                        gebruiker.ClubCloud_Functionaris.Add(functionaris);
                    }
                    beheerModel.SaveChanges();
                }

                if (refresh)
                {
                    if (settings == null)
                        settings = GetSettings(bondsnummer);

                    if (settings != null && settings.Access && !string.IsNullOrWhiteSpace(settings.Password))
                    {
                        CookieContainer cc = RequestContainer(settings.Id.ToString(), settings.Password);

                        if (cc != null)
                        {
                            using (ClubCloud.KNLTB.ServIt.CrmService.CrmService service = CrmServices[settings.Id.ToString()])
                            {
                                bool moreRecords = true;
                                int pageNum = 1;
                                while (moreRecords)
                                {
                                    ConditionExpression condition = new ConditionExpression { AttributeName = "contactid", Operator = ConditionOperator.Equal, uitype = "contactid", Values = new object[1] { gebruiker.Id } };
                                    FilterExpression expression = new FilterExpression { FilterOperator = LogicalOperator.And, Conditions = new ConditionExpression[1] { condition } };
                                    LinkEntity link = new LinkEntity { LinkToEntityName = "contact", LinkFromAttributeName = "sgt_functionarisid", LinkToAttributeName = "contactid", LinkCriteria = expression };
                                    List<BusinessEntity> entities = RetrieveMultiple(service, "sgt_alg_functionaris", out moreRecords, ref pageNum, null, link);

                                    foreach (sgt_alg_functionaris functionaris in entities)
                                    {
                                        ClubCloud_Functionaris entity = beheerModel.ClubCloud_Functionarissen.Find(functionaris.sgt_alg_functionarisid.Value);

                                        if (entity == null)
                                            entity = beheerModel.ClubCloud_Functionarissen.Create();

                                        entity.Id = functionaris.sgt_alg_functionarisid.Value;

                                        FunctionarisToEntity(functionaris, entity, settings);

                                        beheerModel.ClubCloud_Functionarissen.AddOrUpdate(entity);
                                    }

                                    beheerModel.SaveChanges();

                                    foreach (sgt_alg_functionaris functionaris in entities)
                                    {
                                        ClubCloud_Functionaris entity = beheerModel.ClubCloud_Functionarissen.Find(functionaris.sgt_alg_functionarisid.Value);

                                        if (functionaris.sgt_functieid != null)
                                        {
                                            ClubCloud_Functie functie = GetFunctieById(functionaris.sgt_functieid.Value, false, settings);
                                            entity.ClubCloud_Functie = functie;
                                            //entity.FunctieId = functionaris.sgt_functieid.Value;
                                        }

                                        if (functionaris.sgt_functionarisid != null)
                                        {
                                            entity.ClubCloud_Gebruiker = gebruiker;
                                            //entity.GebruikerId = functionaris.sgt_functionarisid.Value;
                                        }

                                        ClubCloud_Vereniging vereniging = null;
                                        if (functionaris.sgt_basisorganisatieid != null)
                                        {
                                            vereniging = GetVerenigingById(functionaris.sgt_basisorganisatieid.Value, false, settings);
                                            entity.ClubCloud_Vereniging = vereniging;
                                            //entity.VerenigingId = functionaris.sgt_basisorganisatieid.Value;
                                        }

                                        if (functionaris.sgt_bestuursorgaanid != null)
                                        {
                                            ClubCloud_Bestuursorgaan orgaan = GetBestuursorgaanById(functionaris.sgt_bestuursorgaanid.Value, false, settings);
                                            entity.ClubCloud_Bestuursorgaan = orgaan;
                                            //entity.BestuursorgaanId = functionaris.sgt_bestuursorgaanid.Value;
                                        }
                                    }

                                    beheerModel.SaveChanges();

                                    foreach (sgt_alg_functionaris functionaris in entities)
                                    {
                                        ClubCloud_Functionaris entity = beheerModel.ClubCloud_Functionarissen.Find(functionaris.sgt_alg_functionarisid.Value);
                                        bool succes = CreateOrUpdateRoleFunctionaris(entity, settings).Result;
                                    }
                                }
                            }
                        }
                    }

                    result = beheerModel.ClubCloud_Functionarissen.Where(v => v.GebruikerId.Value == Id).ToList();

                    foreach (ClubCloud_Functionaris functionaris in result)
                    {
                        gebruiker.ClubCloud_Functionaris.Add(functionaris);
                    }
                    beheerModel.SaveChanges();
                }

            }
            return result;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="entity"></param>
        /// <param name="refresh"></param>
        /// <param name="settings"></param>
        /// <returns></returns>
        private List<ClubCloud_Lidmaatschap> GetLidmaatschappenForGebruiker(string bondsnummer, ClubCloud_Gebruiker entity, bool refresh, ClubCloud_Setting settings)
        {
            return GetLidmaatschappenForGebruikerById(bondsnummer, entity.Id, refresh, settings);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="Id"></param>
        /// <param name="refresh"></param>
        /// <param name="settings"></param>
        /// <returns></returns>
        private List<ClubCloud_Lidmaatschap> GetLidmaatschappenForGebruikerById(string bondsnummer, Guid Id, bool refresh, ClubCloud_Setting settings)
        {
            List<ClubCloud_Lidmaatschap> result = null;

            ClubCloud_Gebruiker gebruiker = beheerModel.ClubCloud_Gebruikers.Find(Id);
            if (gebruiker != null)
            {
                if (gebruiker.ClubCloud_Lidmaatschap == null || gebruiker.ClubCloud_Lidmaatschap.Count == 0)
                {
                    result = beheerModel.ClubCloud_Lidmaatschappen.Where(v => v.GebruikerId.Value == Id).ToList();

                    foreach (ClubCloud_Lidmaatschap lidmaatschap in result)
                    {
                        gebruiker.ClubCloud_Lidmaatschap.Add(lidmaatschap);
                    }
                    beheerModel.SaveChanges();
                }

            }
            return result;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="entity"></param>
        /// <param name="refresh"></param>
        /// <param name="settings"></param>
        /// <returns></returns>
        private List<ClubCloud_Address> GetAddressenForGebruiker(string bondsnummer, ClubCloud_Gebruiker entity, bool refresh, ClubCloud_Setting settings)
        {
            return GetAddressenForGebruikerById(bondsnummer, entity.Id, refresh, settings);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="Id"></param>
        /// <param name="refresh"></param>
        /// <param name="settings"></param>
        /// <returns></returns>
        private List<ClubCloud_Address> GetAddressenForGebruikerById(string bondsnummer, Guid Id, bool refresh, ClubCloud_Setting settings)
        {
            List<ClubCloud_Address> result = null;

            ClubCloud_Gebruiker gebruiker = beheerModel.ClubCloud_Gebruikers.Find(Id);
            if (gebruiker != null)
            {
                if (gebruiker.ClubCloud_Address == null || gebruiker.ClubCloud_Address.Count == 0)
                {
                    result = beheerModel.ClubCloud_Addressen.Where(v => v.ParentId.Value == Id).ToList();

                    foreach (ClubCloud_Address address in result)
                    {
                        gebruiker.ClubCloud_Address.Add(address);
                    }
                    beheerModel.SaveChanges();
                }

                if (refresh)
                {
                    if (settings == null)
                        settings = GetSettings(bondsnummer);

                    if (settings != null && settings.Access && !string.IsNullOrWhiteSpace(settings.Password))
                    {
                        CookieContainer cc = RequestContainer(settings.Id.ToString(), settings.Password);

                        if (cc != null)
                        {
                            using (ClubCloud.KNLTB.ServIt.CrmService.CrmService service = CrmServices[settings.Id.ToString()])
                            {
                                bool moreRecords = true;
                                int pageNum = 1;
                                while (moreRecords)
                                {
                                    ConditionExpression condition = new ConditionExpression { AttributeName = "parentid", Operator = ConditionOperator.Equal, Values = new object[1] { Id } };
                                    FilterExpression expression = new FilterExpression { FilterOperator = LogicalOperator.And, Conditions = new ConditionExpression[1] { condition } };

                                    List<BusinessEntity> entities = RetrieveMultiple(service, "customeraddress", out moreRecords, ref pageNum, expression);

                                    foreach (customeraddress address in entities)
                                    {
                                        ClubCloud_Address entity = beheerModel.ClubCloud_Addressen.Find(address.customeraddressid.Value);

                                        if (entity == null)
                                            entity = beheerModel.ClubCloud_Addressen.Create();

                                        entity.Id = address.customeraddressid.Value;

                                        AddressToEntity(address, entity, settings);

                                        beheerModel.ClubCloud_Addressen.AddOrUpdate(entity);
                                    }

                                    beheerModel.SaveChanges();

                                    foreach (customeraddress address in entities)
                                    {
                                        ClubCloud_Address entity = beheerModel.ClubCloud_Addressen.Find(address.customeraddressid.Value);

                                        Guid landid;
                                        if (Guid.TryParse(address.country, out landid))
                                        {
                                            ClubCloud_Land land = beheerModel.ClubCloud_Landen.Find(landid);
                                            if (land != null)
                                                entity.ClubCloud_Land = land;
                                        }
                                    }

                                    beheerModel.SaveChanges();
                                }
                            }
                        }
                    }

                    result = beheerModel.ClubCloud_Addressen.Where(v => v.ParentId.Value == Id).ToList();

                    foreach (ClubCloud_Address address in result)
                    {
                        gebruiker.ClubCloud_Address.Add(address);
                    }
                    beheerModel.SaveChanges();
                }
            }
            return result;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="entity"></param>
        /// <param name="refresh"></param>
        /// <param name="settings"></param>
        /// <returns></returns>
        private ClubCloud_Vereniging GetVerenigingForGebruiker(string bondsnummer, ClubCloud_Gebruiker entity, bool refresh, ClubCloud_Setting settings)
        {
            return GetVerenigingForGebruikerById(bondsnummer, entity.Id, refresh, settings);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="Id"></param>
        /// <param name="refresh"></param>
        /// <param name="settings"></param>
        /// <returns></returns>
        private ClubCloud_Vereniging GetVerenigingForGebruikerById(string bondsnummer, Guid Id, bool refresh, ClubCloud_Setting settings)
        {
            ClubCloud_Vereniging result = null;

            ClubCloud_Gebruiker gebruiker = beheerModel.ClubCloud_Gebruikers.Find(Id);
            if (gebruiker != null)
            {
                if (gebruiker.ClubCloud_Vereniging == null)
                {
                    result = beheerModel.ClubCloud_Verenigingen.Find(gebruiker.VerenigingId.Value);

                    if (result != null)
                    {
                        gebruiker.ClubCloud_Vereniging = result;
                        beheerModel.SaveChanges();
                    }
                    else
                    {
                        result = GetVerenigingById(bondsnummer, gebruiker.VerenigingId.Value, refresh, settings);
                        if (result != null)
                        {
                            gebruiker.ClubCloud_Vereniging = result;
                            beheerModel.SaveChanges();
                        }

                    }
                }

            }
            return result;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="entity"></param>
        /// <param name="refresh"></param>
        /// <param name="settings"></param>
        /// <returns></returns>
        private List<ClubCloud_Profiel> GetProfielenForGebruiker(string bondsnummer, ClubCloud_Gebruiker entity, bool refresh, ClubCloud_Setting settings)
        {
            return GetProfielenForGebruikerById(bondsnummer, entity.Id, refresh, settings);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="Id"></param>
        /// <param name="refresh"></param>
        /// <param name="settings"></param>
        /// <returns></returns>
        private List<ClubCloud_Profiel> GetProfielenForGebruikerById(string bondsnummer, Guid Id, bool refresh, ClubCloud_Setting settings)
        {
            List<ClubCloud_Profiel> result = null;

            ClubCloud_Gebruiker gebruiker = beheerModel.ClubCloud_Gebruikers.Find(Id);
            if (gebruiker != null)
            {
                if (gebruiker.ClubCloud_Profiel == null || gebruiker.ClubCloud_Profiel.Count == 0)
                {
                    result = beheerModel.ClubCloud_Profielen.Where(v => v.GebruikerId.Value == Id).ToList();

                    foreach (ClubCloud_Profiel profiel in result)
                    {
                        gebruiker.ClubCloud_Profiel.Add(profiel);
                    }
                    beheerModel.SaveChanges();
                }

            }
            return result;

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="entity"></param>
        /// <param name="refresh"></param>
        /// <param name="settings"></param>
        /// <returns></returns>
        private List<ClubCloud_Setting> GetSettingsForGebruiker(string bondsnummer, ClubCloud_Gebruiker entity, bool refresh, ClubCloud_Setting settings)
        {
            return GetSettingsForGebruikerById(bondsnummer, entity.Id, refresh, settings);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="Id"></param>
        /// <param name="refresh"></param>
        /// <param name="settings"></param>
        /// <returns></returns>
        private List<ClubCloud_Setting> GetSettingsForGebruikerById(string bondsnummer, Guid Id, bool refresh, ClubCloud_Setting settings)
        {
            List<ClubCloud_Setting> result = null;

            ClubCloud_Gebruiker gebruiker = beheerModel.ClubCloud_Gebruikers.Find(Id);
            if (gebruiker != null)
            {
                if (gebruiker.ClubCloud_Setting == null || gebruiker.ClubCloud_Setting.Count == 0)
                {
                    result = beheerModel.ClubCloud_Settings.Where(v => v.GebruikerId.Value == Id).ToList();

                    foreach (ClubCloud_Setting item in result)
                    {
                        gebruiker.ClubCloud_Setting.Add(item);
                    }
                    beheerModel.SaveChanges();
                }

            }
            return result;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="entity"></param>
        /// <param name="refresh"></param>
        /// <param name="settings"></param>
        /// <returns></returns>
        private ClubCloud_Nationaliteit GetNationaliteitForGebruiker(string bondsnummer, ClubCloud_Gebruiker entity, bool refresh, ClubCloud_Setting settings)
        {
            return GetNationaliteitForGebruikerById(bondsnummer, entity.Id, refresh, settings);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="Id"></param>
        /// <param name="refresh"></param>
        /// <param name="settings"></param>
        /// <returns></returns>
        private ClubCloud_Nationaliteit GetNationaliteitForGebruikerById(string bondsnummer, Guid Id, bool refresh, ClubCloud_Setting settings)
        {
            ClubCloud_Nationaliteit result = null;

            ClubCloud_Gebruiker gebruiker = beheerModel.ClubCloud_Gebruikers.Find(Id);
            if (gebruiker != null)
            {
                if (gebruiker.ClubCloud_Nationaliteit == null)
                {
                    result = beheerModel.ClubCloud_Nationaliteiten.Find(gebruiker.NationaliteitId.Value);

                    if (result != null)
                    {
                        gebruiker.ClubCloud_Nationaliteit = result;
                        beheerModel.SaveChanges();
                    }
                    else
                    {
                        result = GetNationaliteitById(bondsnummer,gebruiker.NationaliteitId.Value, refresh, settings);
                        if (result != null)
                        {
                            gebruiker.ClubCloud_Nationaliteit = result;
                            beheerModel.SaveChanges();
                        }

                    }
                }

            }
            return result;
        }

        /*
        /// <summary>
        /// contact
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="gebruikerId"></param>
        /// <param name="refresh"></param>
        /// <returns></returns>
        private ClubCloud_Gebruiker GebruikerById(string bondsnummer, Guid gebruikerId, bool refresh = false, ClubCloud_Setting settings = null)
        {
            ClubCloud_Gebruiker gebruiker = new ClubCloud_Gebruiker();

            gebruiker = beheerModel.ClubCloud_Gebruikers.Find(gebruikerId);

            if (gebruiker == null || refresh)
            {
                if (settings == null)
                {
                    settings = GetSettings(bondsnummer);
                }

                if (settings != null && settings.Access && !string.IsNullOrWhiteSpace(settings.Password))
                {
                    CookieContainer cc = RequestContainer(settings.Id.ToString(), settings.Password);

                    if (cc != null)
                    {
                        using (ClubCloud.KNLTB.ServIt.CrmService.CrmService service = CrmServices[settings.Id.ToString()])
                        {
                            bool moreRecords = true;
                            int pageNum = 1;
                            while (moreRecords)
                            {
                                ConditionExpression condition = new ConditionExpression { AttributeName = "contactid", Operator = ConditionOperator.Equal, Values = new object[1] { gebruikerId } };
                                FilterExpression expression = new FilterExpression { FilterOperator = LogicalOperator.And, Conditions = new ConditionExpression[1] { condition } };

                                List<BusinessEntity> entities = RetrieveMultiple(service, "contact", out moreRecords, ref pageNum, expression);

                                foreach (contact entity in entities)
                                {
                                    if (settings.Id == int.Parse(entity.sgt_bondsnummer) && (settings.GebruikerId == null || settings.VerenigingId == null))
                                    {
                                        ClubCloud_Setting updatesettings = beheerModel.ClubCloud_Settings.Find(settings.Id);
                                        if (entity.sgt_primaire_vereniging_id != null)
                                            updatesettings.VerenigingId = entity.sgt_primaire_vereniging_id.Value;

                                        if (entity.contactid != null)
                                            updatesettings.GebruikerId = entity.contactid.Value;

                                        beheerModel.SaveChanges();
                                        settings = updatesettings;
                                    }

                                    gebruiker = beheerModel.ClubCloud_Gebruikers.Find(entity.contactid.Value);

                                    if (gebruiker == null)
                                    {
                                        gebruiker = beheerModel.ClubCloud_Gebruikers.Create();
                                        gebruiker.Id = entity.contactid.Value;

                                        ContactToGebruiker(entity, entity.sgt_primaire_vereniging_id.Value, gebruiker, bondsnummer, settings);

                                        beheerModel.ClubCloud_Gebruikers.Add(gebruiker);

                                    }
                                    else
                                    {
                                        ContactToGebruiker(entity, entity.sgt_primaire_vereniging_id.Value, gebruiker, bondsnummer, settings);
                                    }

                                    beheerModel.SaveChanges();

                                    CreateOrUpdateMembershipGebruiker(gebruiker, settings);

                                    if (entity.sgt_is_functionaris != null && entity.sgt_is_functionaris.Value)
                                    {
                                        GetFunctionarissenForGebruikerById(bondsnummer, entity.contactid.Value, false, settings);
                                    }
                                }
                            }
                        }
                    }
                }
                gebruiker = beheerModel.ClubCloud_Gebruikers.Find(gebruikerId);
            }
            return gebruiker;
        }
        */

        /// <summary>
        /// contact
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="nummer"></param>
        /// <param name="refresh"></param>
        /// <returns></returns>
        private ClubCloud_Gebruiker GebruikerByNummer(string bondsnummer, string nummer, bool refresh = false, ClubCloud_Setting settings = null, bool decrypt = true)
        {
            ClubCloud_Gebruiker entity = new ClubCloud_Gebruiker();

            entity = beheerModel.ClubCloud_Gebruikers.SingleOrDefault(g => g.Bondsnummer == nummer);

            if (entity == null || refresh)
            {
                if (settings == null)
                    settings = GetSettings(bondsnummer);

                ClubCloud_Vereniging vereniging = GetVerenigingById(bondsnummer, settings.VerenigingId.Value, false);

                if (settings != null && settings.Access && !string.IsNullOrWhiteSpace(settings.Password))
                {
                    CookieContainer cc = RequestContainer(settings.Id.ToString(), settings.Password, decrypt);

                    if (cc != null)
                    {
                        using (ClubCloud.KNLTB.ServIt.CrmService.CrmService service = CrmServices[settings.Id.ToString()])
                        {
                            bool moreRecords = true;
                            int pageNum = 1;
                            while (moreRecords)
                            {
                                ConditionExpression condition = new ConditionExpression { AttributeName = "sgt_bondsnummer", Operator = ConditionOperator.Equal, Values = new object[1] { nummer } };
                                FilterExpression expression = new FilterExpression { FilterOperator = LogicalOperator.And, Conditions = new ConditionExpression[1] { condition } };

                                List<BusinessEntity> entities = RetrieveMultiple(service, "contact", out moreRecords, ref pageNum, expression);

                                foreach (contact contact in entities)
                                {
                                    entity = beheerModel.ClubCloud_Gebruikers.Find(contact.contactid.Value);

                                    if (entity == null)
                                        entity = beheerModel.ClubCloud_Gebruikers.Create();

                                    entity.Id = contact.contactid.Value;

                                    GebruikerToEntity(contact, entity, settings);

                                    beheerModel.ClubCloud_Gebruikers.AddOrUpdate(entity);
                                }
                                beheerModel.SaveChanges();

                                foreach (contact contact in entities)
                                {
                                    entity = beheerModel.ClubCloud_Gebruikers.Find(contact.contactid.Value);

                                    entity.VerenigingId = vereniging.Id;
                                    entity.ClubCloud_Vereniging = vereniging;

                                    if (contact.parentcustomerid != null)
                                    {
                                        ClubCloud_Vereniging parent = GetVerenigingById(contact.parentcustomerid.Value, false, settings);
                                        if (parent != null)
                                            entity.ClubCloud_Vereniging = parent;
                                    }

                                    if (contact.sgt_nationaliteitid != null)
                                    {
                                        ClubCloud_Nationaliteit nationaliteit = GetNationaliteitById(contact.sgt_nationaliteitid.Value, false, settings);
                                        if (nationaliteit != null)
                                            entity.ClubCloud_Nationaliteit = nationaliteit;
                                    }

                                    if (contact.address1_addressid != null)
                                    {
                                        ClubCloud_Address bezoek = GetAddressById(contact.address1_addressid.Value, false, settings);
                                        if (bezoek != null)
                                            entity.ClubCloud_Address.Add(bezoek);
                                    }
                                    if (contact.address2_addressid != null)
                                    {
                                        ClubCloud_Address post = GetAddressById(contact.address2_addressid.Value, false, settings);
                                        if (post != null)
                                            entity.ClubCloud_Address.Add(post);
                                    }
                                }

                                beheerModel.SaveChanges();

                                foreach (contact contact in entities)
                                {
                                    entity = beheerModel.ClubCloud_Gebruikers.Find(contact.contactid.Value);

                                    int _bondsnummer;
                                    if (int.TryParse(contact.sgt_bondsnummer, out _bondsnummer))
                                    {
                                        ClubCloud_Setting usersettings = beheerModel.ClubCloud_Settings.Find(_bondsnummer);

                                        if (usersettings == null)
                                            usersettings = beheerModel.ClubCloud_Settings.Create();

                                        usersettings.Id = _bondsnummer;
                                        usersettings.Access = false;
                                        usersettings.Agree = false;
                                        usersettings.facebook_allow = false;
                                        usersettings.facebook_setting = Facebook.None;
                                        usersettings.financieel = Financieel.None;
                                        usersettings.privacy = Privacy.None;
                                        usersettings.twitter_allow = false;
                                        usersettings.twitter_setting = Twitter.None;

                                        usersettings.VerenigingId = vereniging.Id;
                                        usersettings.ClubCloud_Vereniging = vereniging;

                                        if (contact.parentcustomerid != null)
                                            usersettings.VerenigingId = contact.parentcustomerid.Value;

                                        if (contact.contactid != null)
                                            usersettings.GebruikerId = contact.contactid.Value;

                                        usersettings.Gewijzigd = DateTime.Now;
                                        beheerModel.ClubCloud_Settings.AddOrUpdate(usersettings);
                                    }
                                }
                                beheerModel.SaveChanges();

                                foreach (contact contact in entities)
                                {
                                    entity = beheerModel.ClubCloud_Gebruikers.Find(contact.contactid.Value);

                                    bool result = CreateOrUpdateMembershipGebruiker(entity, settings).Result;
                                }

                                foreach (contact contact in entities)
                                {
                                    entity = beheerModel.ClubCloud_Gebruikers.Find(contact.contactid.Value);

                                    if (contact.sgt_is_functionaris != null && contact.sgt_is_functionaris.Value)
                                    {
                                        GetFunctionarissenForGebruikerById(bondsnummer, contact.contactid.Value, refresh, settings);
                                    }
                                }

                                beheerModel.SaveChanges();
                            }
                        }
                    }
                }
                entity = beheerModel.ClubCloud_Gebruikers.SingleOrDefault(g => g.Bondsnummer == nummer);
            }
            return entity;
        }
 
        /*
        /// <summary>
        /// 
        /// </summary>
        /// <param name="entity"></param>
        /// <param name="gebruiker"></param>
        /// <param name="bondsnummer"></param>
        private void ContactToGebruiker(contact entity, Guid verenigingId, ClubCloud_Gebruiker gebruiker, string bondsnummer, ClubCloud_Setting settings = null)
        {
            gebruiker.Bondsnummer = entity.sgt_bondsnummer;
            gebruiker.Beschrijving = entity.description;

            if (entity.parentcustomerid != null)
            {
                gebruiker.VerenigingId = entity.parentcustomerid.Value;
            }
            else
            {
                gebruiker.VerenigingId = verenigingId;
            }

            ClubCloud_Vereniging vereniging = GetVerenigingById(bondsnummer, gebruiker.VerenigingId.Value, false, settings);
            gebruiker.ClubCloud_Vereniging = vereniging;

            //gebruiker.EmailGeheim;
            gebruiker.EmailKNLTB = entity.emailaddress1;
            gebruiker.EmailWebSite = entity.emailaddress2;
            gebruiker.EmailOverig = entity.emailaddress3;

            if (entity.sgt_telefoon_geheim != null)
            {
                gebruiker.TelefoonGeheim = entity.sgt_telefoon_geheim.Value;
            }

            gebruiker.TelefoonOverdag = entity.telephone1;
            gebruiker.TelefoonAvond = entity.telephone2;
            gebruiker.TelefoonOverig = entity.telephone3;
            gebruiker.Mobiel = entity.mobilephone;
            gebruiker.Fax = entity.fax;

            gebruiker.FTPsite = entity.ftpsiteurl;
            gebruiker.Website = entity.websiteurl;

            gebruiker.BankIban = entity.sgt_iban_code;
            gebruiker.BankNummer = entity.sgt_rekeningnummer;
            gebruiker.BankPlaats = entity.sgt_rekeningnummer_plaats;

            gebruiker.Roepnaam = entity.nickname;
            gebruiker.Aanhef = entity.salutation;
            gebruiker.Voornaam = entity.firstname;
            gebruiker.Voornamen = entity.sgt_voornamen;
            gebruiker.Volledigenaam = entity.fullname;
            gebruiker.Achternaam = entity.lastname;
            gebruiker.Tussenvoegsel = entity.middlename;
            gebruiker.Achtervoegsel = entity.suffix;

            //TODO
            //gebruiker.Geslacht = (Geslacht)Enum.Parse(typeof(Geslacht), entity.gendercode.name);
            if (entity.birthdate != null)
            {
                gebruiker.Geboortedatum = DateTime.Parse(entity.birthdate.Value);
            }
            gebruiker.Geboorteplaats = entity.sgt_geboorteplaats;
            if (entity.sgt_datum_overleden != null)
            {
                gebruiker.OverlijdensDatum = DateTime.Parse(entity.sgt_datum_overleden.Value);
            }
            if (entity.sgt_nationaliteitid != null)
            {
                ClubCloud_Nationaliteit nationaliteit = GetNationaliteitById(bondsnummer, entity.sgt_nationaliteitid.Value, false, settings);
                gebruiker.ClubCloud_Nationaliteit = nationaliteit;
                gebruiker.NationaliteitId = entity.sgt_nationaliteitid.Value;

            }

            //if (entity.sgt_2e_nationaliteitid != null)
            //{
            //    gebruiker.NationaliteitId = entity.sgt_2e_nationaliteitid.Value;
            //}
         
            gebruiker.Beroep = entity.jobtitle;

           
            //if (entity.haschildrencode != null)
            //{
            //    gebruiker.Kinderen = entity.haschildrencode.Value;
            //}
            

            if (entity.numberofchildren != null)
            {
                gebruiker.KinderenAantal = entity.numberofchildren.Value;
            }
            else
            {
                gebruiker.KinderenAantal = 0;
            }
            gebruiker.Partner = entity.spousesname;

            gebruiker.AanhefBrief = entity.sgt_aanhef_briefhoofd_nl;
            gebruiker.AanhefAttentie = entity.sgt_aanhef_tav_nl;

            if (!String.IsNullOrWhiteSpace(entity.sgt_fotonummer))
            {
                gebruiker.FotoId = int.Parse(entity.sgt_fotonummer);
            }

            if (entity.sgt_adres_geheim != null)
            {
                gebruiker.AddressGeheim = entity.sgt_adres_geheim.Value;
            }

            //GetAddressByIdAsync(bondsnummer, entity.address1_addressid.Value, false, settings);
            ClubCloud_Address bezoek = GetAddressById(bondsnummer, entity.address1_addressid.Value, false, settings);
            gebruiker.ClubCloud_Address.Add(bezoek);
            //GetAddressByIdAsync(bondsnummer, entity.address2_addressid.Value, false, settings);
            ClubCloud_Address post = GetAddressById(bondsnummer, entity.address2_addressid.Value, false, settings);
            gebruiker.ClubCloud_Address.Add(post);

            gebruiker.Actief = entity.statuscode.name;
            gebruiker.Gewijzigd = DateTime.Now;

        }
        */

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="entity"></param>
        /// <param name="refresh"></param>
        /// <param name="settings"></param>
        /// <returns></returns>
        private ClubCloud_Foto GetFotoForGebruiker(string bondsnummer, ClubCloud_Gebruiker entity, bool refresh, ClubCloud_Setting settings)
        {
            return GetFotoForGebruikerById(bondsnummer, entity.Id, refresh, settings);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Id"></param>
        /// <param name="refresh"></param>
        /// <param name="settings"></param>
        /// <returns></returns>
        public ClubCloud_Foto GetFotoForGebruikerById(string bondsnummer, Guid Id, bool refresh = false, ClubCloud_Setting settings = null)
        {
            ClubCloud_Foto result = null;

            if (settings != null)
                ValidateSettings(ref settings);

            ClubCloud_Gebruiker gebruiker = beheerModel.ClubCloud_Gebruikers.Find(Id);

            if (gebruiker != null)
            {
                result = beheerModel.ClubCloud_Fotos.SingleOrDefault(f => f.FotoId == gebruiker.FotoId || f.FotoId == settings.Id);
            }

            if (result != null && !refresh)
                return result;

            result = RetrieveFoto(settings.Id.ToString(), gebruiker.Bondsnummer, gebruiker.FotoId);

            if (result != null)
                return result;

            return new ClubCloud_Foto();
        }

        /// <summary>
        /// sgt_alg_lidmaatschap
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="lidId"></param>
        /// <param name="refresh"></param>
        /// <returns></returns>
        private List<ClubCloud_Lidmaatschap> GetLidmaatschappenByGebruiker(string bondsnummer, Guid gebruikerId, bool refresh = false)
        {
            List<ClubCloud_Lidmaatschap> lidmaatschappen = new List<ClubCloud_Lidmaatschap>();

            lidmaatschappen = beheerModel.ClubCloud_Lidmaatschappen.Where(l => l.GebruikerId == gebruikerId).ToList();

            if (lidmaatschappen != null && lidmaatschappen.Count == 0 || refresh)
            {
                ClubCloud_Setting settings = GetSettings(bondsnummer);

                if (settings != null && settings.Access && !string.IsNullOrWhiteSpace(settings.Password))
                {
                    CookieContainer cc = RequestContainer(settings.Id.ToString(), settings.Password);

                    if (cc != null)
                    {
                        using (ClubCloud.KNLTB.ServIt.CrmService.CrmService service = CrmServices[settings.Id.ToString()])
                        {
                            bool moreRecords = true;
                            int pageNum = 1;
                            while (moreRecords)
                            {
                                ConditionExpression condition = new ConditionExpression { AttributeName = "sgt_lidid", Operator = ConditionOperator.Equal, Values = new object[1] { gebruikerId } };
                                FilterExpression expression = new FilterExpression { FilterOperator = LogicalOperator.And, Conditions = new ConditionExpression[1] { condition } };

                                List<BusinessEntity> entities = RetrieveMultiple(service, "sgt_alg_lidmaatschap", out moreRecords, ref pageNum, expression);

                                foreach (sgt_alg_lidmaatschap lidmaatschap in entities)
                                {
                                    ClubCloud_Lidmaatschap entity = beheerModel.ClubCloud_Lidmaatschappen.Find(lidmaatschap.sgt_alg_lidmaatschapid.Value);

                                    if (entity == null)
                                        entity = beheerModel.ClubCloud_Lidmaatschappen.Create();

                                    entity.Id = lidmaatschap.sgt_alg_lidmaatschapid.Value;

                                    LidmaatschapToEntity(lidmaatschap, entity, bondsnummer, settings);

                                    beheerModel.ClubCloud_Lidmaatschappen.AddOrUpdate(entity);
                                }

                                beheerModel.SaveChanges();

                                foreach (sgt_alg_lidmaatschap lidmaatschap in entities)
                                {
                                    ClubCloud_Lidmaatschap entity = beheerModel.ClubCloud_Lidmaatschappen.Find(lidmaatschap.sgt_alg_lidmaatschapid.Value);

                                    if (lidmaatschap.sgt_lidid != null)
                                    {
                                        ClubCloud_Gebruiker gebruiker = GetGebruikerById(lidmaatschap.sgt_lidid.Value, false, settings);
                                        if(gebruiker != null)
                                            entity.ClubCloud_Gebruiker = gebruiker;
                                    }

                                    if (lidmaatschap.sgt_soort_lidmaatschapid != null)
                                    {
                                        ClubCloud_Lidmaatschapsoort soort = GetLidmaatschapsoortById(bondsnummer, lidmaatschap.sgt_soort_lidmaatschapid.Value, false, settings);
                                        if (soort != null)
                                            entity.ClubCloud_Lidmaatschapsoort = soort;
                                    }

                                    if (lidmaatschap.sgt_verenigingid != null)
                                    {
                                        ClubCloud_Vereniging vereniging = GetVerenigingById(bondsnummer, lidmaatschap.sgt_verenigingid.Value, false, settings);
                                        if (vereniging != null)
                                            entity.ClubCloud_Vereniging = vereniging;
                                    }
                                }

                                beheerModel.SaveChanges();
                            }
                        }
                    }
                }
                lidmaatschappen = beheerModel.ClubCloud_Lidmaatschappen.Where(l => l.GebruikerId == gebruikerId).ToList();
            }


            return lidmaatschappen;
        }

        #region Mapping

        /// <summary>
        /// 
        /// </summary>
        /// <param name="contact"></param>
        /// <param name="contact"></param>
        /// <param name="settings"></param>
        private void GebruikerToEntity(contact contact, ClubCloud_Gebruiker entity, ClubCloud_Setting settings)
        {
            entity.Bondsnummer = contact.sgt_bondsnummer;
            entity.Beschrijving = contact.description;

            if (contact.parentcustomerid != null)
            {
                //ClubCloud_Vereniging vereniging = GetVerenigingById(contact.parentcustomerid.Value, false, settings);
                //if(vereniging != null)
                //    entity.ClubCloud_Vereniging = vereniging;
                entity.VerenigingId = contact.parentcustomerid.Value;
            }
            //else
            //{
                //ClubCloud_Vereniging vereniging = GetVerenigingById(settings.VerenigingId.Value, false, settings);
                //if (vereniging != null)
                //   entity.ClubCloud_Vereniging = vereniging;
            //    entity.VerenigingId = settings.VerenigingId;
            //}
            //entity.EmailGeheim;

            entity.EmailKNLTB = contact.emailaddress1;
            entity.EmailWebSite = contact.emailaddress2;
            entity.EmailOverig = contact.emailaddress3;

            if (contact.sgt_telefoon_geheim != null)
            {
                entity.TelefoonGeheim = contact.sgt_telefoon_geheim.Value;
            }

            entity.TelefoonOverdag = contact.telephone1;
            entity.TelefoonAvond = contact.telephone2;
            entity.TelefoonOverig = contact.telephone3;
            entity.Mobiel = contact.mobilephone;
            entity.Fax = contact.fax;

            entity.FTPsite = contact.ftpsiteurl;
            entity.Website = contact.websiteurl;

            entity.BankIban = contact.sgt_iban_code;
            entity.BankNummer = contact.sgt_rekeningnummer;
            entity.BankPlaats = contact.sgt_rekeningnummer_plaats;

            entity.Roepnaam = contact.nickname;
            entity.Aanhef = contact.salutation;
            entity.Voornaam = contact.firstname;
            entity.Voornamen = contact.sgt_voornamen;
            entity.Volledigenaam = contact.fullname;
            entity.Achternaam = contact.lastname;
            entity.Tussenvoegsel = contact.middlename;
            entity.Achtervoegsel = contact.suffix;

            if (contact.gendercode != null)
                entity.Geslacht = (GeslachtSoort)contact.gendercode.Value;//(GeslachtSoort)Enum.Parse(typeof(GeslachtSoort), contact.gendercode.Value);

            if (contact.birthdate != null)
            {
                entity.Geboortedatum = DateTime.Parse(contact.birthdate.Value);
            }

            entity.Geboorteplaats = contact.sgt_geboorteplaats;

            if (contact.sgt_datum_overleden != null)
            {
                entity.OverlijdensDatum = DateTime.Parse(contact.sgt_datum_overleden.Value);
            }

            if (contact.sgt_nationaliteitid != null)
            {
                //ClubCloud_Nationaliteit nationaliteit = GetNationaliteitById(contact.sgt_nationaliteitid.Value, false, settings);
                //entity.ClubCloud_Nationaliteit = nationaliteit;
                entity.NationaliteitId = contact.sgt_nationaliteitid.Value;

            }
            /*
            if (entity.sgt_2e_nationaliteitid != null)
            {
                gebruiker.NationaliteitId = entity.sgt_2e_nationaliteitid.Value;
            }
            */
            entity.Beroep = contact.jobtitle;

            /*
            if (entity.haschildrencode != null)
            {
                gebruiker.Kinderen = entity.haschildrencode.Value;
            }
            */

            if (contact.numberofchildren != null)
            {
                entity.KinderenAantal = contact.numberofchildren.Value;
            }
            else
            {
                entity.KinderenAantal = 0;
            }
            entity.Partner = contact.spousesname;

            entity.AanhefBrief = contact.sgt_aanhef_briefhoofd_nl;
            entity.AanhefAttentie = contact.sgt_aanhef_tav_nl;

            if (!String.IsNullOrWhiteSpace(contact.sgt_fotonummer))
            {
                entity.FotoId = int.Parse(contact.sgt_fotonummer);
            }

            if (contact.sgt_adres_geheim != null)
            {
                entity.AddressGeheim = contact.sgt_adres_geheim.Value;
            }

            //GetAddressByIdAsync(bondsnummer, entity.address1_addressid.Value, false, settings);
            //ClubCloud_Address bezoek = GetAddressById(contact.address1_addressid.Value, false, settings);
            //entity.ClubCloud_Address.Add(bezoek);
            //GetAddressByIdAsync(bondsnummer, entity.address2_addressid.Value, false, settings);
            //ClubCloud_Address post = GetAddressById(contact.address2_addressid.Value, false, settings);
            //entity.ClubCloud_Address.Add(post);

            entity.Actief = (ActiefSoort)contact.statuscode.Value;
            entity.Gewijzigd = DateTime.Now;
        }

        private void EntityToGebruiker(contact contact, ClubCloud_Gebruiker entity, ClubCloud_Setting settings)
        {

        }

        #endregion

        #endregion

        #region Land

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="Id"></param>
        /// <param name="refresh"></param>
        /// <param name="settings"></param>
        /// <returns></returns>
        private ClubCloud_Land GetLandById(string bondsnummer, Guid Id, bool refresh, ClubCloud_Setting settings)
        {
            ClubCloud_Land entity = null;

            entity = beheerModel.ClubCloud_Landen.Find(Id);

            if (entity == null || refresh)
            {
                if (settings == null)
                    settings = GetSettings(bondsnummer);

                if (settings != null && settings.Access && !string.IsNullOrWhiteSpace(settings.Password))
                {
                    CookieContainer cc = RequestContainer(settings.Id.ToString(), settings.Password);

                    if (cc != null)
                    {
                        using (ClubCloud.KNLTB.ServIt.CrmService.CrmService service = CrmServices[settings.Id.ToString()])
                        {
                            sgt_alg_landcode land = RetrieveEntity(service, "sgt_alg_landcode", Id) as sgt_alg_landcode;

                            if (land != null && land.sgt_alg_landcodeid.Value == Id)
                            {
                                if (entity == null)
                                    entity = beheerModel.ClubCloud_Landen.Create();

                                entity.Id = land.sgt_alg_landcodeid.Value;
                                entity.Naam = land.sgt_omschrijving;
                                entity.Code = land.sgt_alg_landcode1;

                                beheerModel.ClubCloud_Landen.AddOrUpdate(entity);
                                beheerModel.SaveChanges();
                            }
                        }
                    }
                }
                entity = beheerModel.ClubCloud_Landen.Find(Id);
            }

            return entity;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="refresh"></param>
        /// <param name="settings"></param>
        /// <returns></returns>
        private List<ClubCloud_Land> GetLanden(string bondsnummer, bool refresh, ClubCloud_Setting settings)
        {
            List<ClubCloud_Land> landen = new List<ClubCloud_Land>();
            landen = beheerModel.ClubCloud_Landen.ToList();

            if (landen == null || landen.Count == 0 || refresh)
            {
                if (settings == null)
                {
                    settings = GetSettings(bondsnummer);
                }

                if (settings != null && settings.Access && !string.IsNullOrWhiteSpace(settings.Password))
                {
                    CookieContainer cc = RequestContainer(settings.Id.ToString(), settings.Password);

                    if (cc != null)
                    {
                        using (ClubCloud.KNLTB.ServIt.CrmService.CrmService service = CrmServices[settings.Id.ToString()])
                        {
                            bool moreRecords = true;
                            int pageNum = 1;
                            while (moreRecords)
                            {

                                List<BusinessEntity> entities = RetrieveMultiple(service, "sgt_alg_landcode", out moreRecords, ref pageNum);

                                foreach (sgt_alg_landcode land in entities)
                                {
                                    ClubCloud_Land entity = beheerModel.ClubCloud_Landen.Find(land.sgt_alg_landcodeid.Value);

                                    if (entity == null)
                                        entity = beheerModel.ClubCloud_Landen.Create();

                                    entity.Id = land.sgt_alg_landcodeid.Value;
                                    entity.Naam = land.sgt_omschrijving;
                                    entity.Code = land.sgt_alg_landcode1;

                                    beheerModel.ClubCloud_Landen.AddOrUpdate(entity);
                                }
                                beheerModel.SaveChanges();
                            }
                        }
                    }
                }
                landen = beheerModel.ClubCloud_Landen.ToList();
            }
            return landen;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="entity"></param>
        /// <param name="settings"></param>
        /// <returns></returns>
        private ClubCloud_Land SetLand(string bondsnummer, ClubCloud_Land entity, ClubCloud_Setting settings)
        {
            if (entity.Id == Guid.Empty)
                entity.Id = Guid.NewGuid();

            return entity;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="entity"></param>
        /// <param name="refresh"></param>
        /// <param name="settings"></param>
        /// <returns></returns>
        private List<ClubCloud_Address> GetAddressenForLand(string bondsnummer, ClubCloud_Land entity, bool refresh, ClubCloud_Setting settings)
        {
            return GetAddressenForLandById(bondsnummer, entity.Id, refresh, settings);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="entity"></param>
        /// <param name="refresh"></param>
        /// <param name="settings"></param>
        /// <returns></returns>
        private List<ClubCloud_Address> GetAddressenForLandById(string bondsnummer, Guid Id, bool refresh, ClubCloud_Setting settings)
        {
            List<ClubCloud_Address> result = null;

            ClubCloud_Land land = beheerModel.ClubCloud_Landen.Find(Id);
            if (land != null)
            {
                if (land.ClubCloud_Address == null || land.ClubCloud_Address.Count == 0)
                {
                    result = beheerModel.ClubCloud_Addressen.Where(v => v.LandId.Value == Id).ToList();

                    foreach (ClubCloud_Address address in result)
                    {
                        land.ClubCloud_Address.Add(address);
                    }
                    beheerModel.SaveChanges();
                }

            }
            return result;
        }


        #endregion

        #region Lidmaatschap

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="Id"></param>
        /// <param name="refresh"></param>
        /// <param name="settings"></param>
        /// <returns></returns>
        private ClubCloud_Lidmaatschap GetLidmaatschapById(string bondsnummer, Guid Id, bool refresh, ClubCloud_Setting settings)
        {
            ClubCloud_Lidmaatschap entity = null;

            entity = beheerModel.ClubCloud_Lidmaatschappen.Find(Id);

            if (entity == null || refresh)
            {
                if(settings == null)
                    settings = GetSettings(bondsnummer);

                if (settings != null && settings.Access && !string.IsNullOrWhiteSpace(settings.Password))
                {
                    CookieContainer cc = RequestContainer(settings.Id.ToString(), settings.Password);

                    if (cc != null)
                    {
                        using (ClubCloud.KNLTB.ServIt.CrmService.CrmService service = CrmServices[settings.Id.ToString()])
                        {
                            sgt_alg_lidmaatschap lidmaatschap = RetrieveEntity(service, "sgt_alg_lidmaatschap", Id) as sgt_alg_lidmaatschap;

                            if (lidmaatschap != null && lidmaatschap.sgt_alg_lidmaatschapid.Value == Id)
                            {
                                if (entity == null)
                                    entity = beheerModel.ClubCloud_Lidmaatschappen.Create();

                                entity.Id = lidmaatschap.sgt_alg_lidmaatschapid.Value;

                                LidmaatschapToEntity(lidmaatschap, entity, bondsnummer, settings);

                                beheerModel.ClubCloud_Lidmaatschappen.AddOrUpdate(entity);
                                beheerModel.SaveChanges();


                                if (lidmaatschap.sgt_lidid != null)
                                {
                                    ClubCloud_Gebruiker gebruiker = GetGebruikerById(lidmaatschap.sgt_lidid.Value, false, settings);
                                    if (gebruiker != null)
                                        entity.ClubCloud_Gebruiker = gebruiker;
                                }

                                if (lidmaatschap.sgt_soort_lidmaatschapid != null)
                                {
                                    ClubCloud_Lidmaatschapsoort soort = GetLidmaatschapsoortById(bondsnummer, lidmaatschap.sgt_soort_lidmaatschapid.Value, false, settings);
                                    if (soort != null)
                                        entity.ClubCloud_Lidmaatschapsoort = soort;
                                }

                                if (lidmaatschap.sgt_verenigingid != null)
                                {
                                    ClubCloud_Vereniging vereniging = GetVerenigingById(bondsnummer, lidmaatschap.sgt_verenigingid.Value, false, settings);
                                    if (vereniging != null)
                                        entity.ClubCloud_Vereniging = vereniging;
                                }
                                beheerModel.SaveChanges();
                            }
                        }
                    }
                }
                entity = beheerModel.ClubCloud_Lidmaatschappen.Find(Id);
            }
            return entity;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="refresh"></param>
        /// <param name="settings"></param>
        /// <returns></returns>
        private List<ClubCloud_Lidmaatschap> GetLidmaatschappen(string bondsnummer, bool refresh, ClubCloud_Setting settings)
        {
            List<ClubCloud_Lidmaatschap> lidmaatschappen = new List<ClubCloud_Lidmaatschap>();

            lidmaatschappen = beheerModel.ClubCloud_Lidmaatschappen.Where(l => l.VerenigingId == settings.VerenigingId.Value).ToList();

            if (lidmaatschappen != null && lidmaatschappen.Count == 0 || refresh)
            {
                if(settings == null)
                    settings = GetSettings(bondsnummer);

                if (settings != null && settings.Access && !string.IsNullOrWhiteSpace(settings.Password))
                {
                    CookieContainer cc = RequestContainer(settings.Id.ToString(), settings.Password);

                    if (cc != null)
                    {
                        using (ClubCloud.KNLTB.ServIt.CrmService.CrmService service = CrmServices[settings.Id.ToString()])
                        {

                            bool moreRecords = true;
                            int pageNum = 1;
                            while (moreRecords)
                            {
                                List<BusinessEntity> entities = RetrieveMultiple(service, "sgt_alg_lidmaatschap", out moreRecords, ref pageNum);

                                foreach (sgt_alg_lidmaatschap lidmaatschap in entities)
                                {
                                    ClubCloud_Lidmaatschap entity = beheerModel.ClubCloud_Lidmaatschappen.Find(lidmaatschap.sgt_alg_lidmaatschapid.Value);

                                    if (entity == null)
                                        entity = beheerModel.ClubCloud_Lidmaatschappen.Create();

                                    entity.Id = lidmaatschap.sgt_alg_lidmaatschapid.Value;

                                    LidmaatschapToEntity(lidmaatschap, entity, bondsnummer, settings);

                                    beheerModel.ClubCloud_Lidmaatschappen.Add(entity);
                                }
                                beheerModel.SaveChanges();

                                foreach (sgt_alg_lidmaatschap lidmaatschap in entities)
                                {
                                    ClubCloud_Lidmaatschap entity = beheerModel.ClubCloud_Lidmaatschappen.Find(lidmaatschap.sgt_alg_lidmaatschapid.Value);

                                    if (lidmaatschap.sgt_lidid != null)
                                    {
                                        ClubCloud_Gebruiker gebruiker = GetGebruikerById(lidmaatschap.sgt_lidid.Value, false, settings);
                                        if (gebruiker != null)
                                            entity.ClubCloud_Gebruiker = gebruiker;
                                    }

                                    if (lidmaatschap.sgt_soort_lidmaatschapid != null)
                                    {
                                        ClubCloud_Lidmaatschapsoort soort = GetLidmaatschapsoortById(bondsnummer, lidmaatschap.sgt_soort_lidmaatschapid.Value, false, settings);
                                        if (soort != null)
                                            entity.ClubCloud_Lidmaatschapsoort = soort;
                                    }

                                    if (lidmaatschap.sgt_verenigingid != null)
                                    {
                                        ClubCloud_Vereniging vereniging = GetVerenigingById(bondsnummer, lidmaatschap.sgt_verenigingid.Value, false, settings);
                                        if (vereniging != null)
                                            entity.ClubCloud_Vereniging = vereniging;
                                    }
                                }

                                beheerModel.SaveChanges();
                            }
                        }
                    }
                }
                lidmaatschappen = beheerModel.ClubCloud_Lidmaatschappen.Where(l => l.VerenigingId == settings.VerenigingId.Value).ToList();
            }
            return lidmaatschappen;
        }
        private ClubCloud_Lidmaatschap SetLidmaatschap(string bondsnummer, ClubCloud_Lidmaatschap entity, ClubCloud_Setting settings)
        {
            if (entity.Id == Guid.Empty)
                entity.Id = Guid.NewGuid();

            return entity;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="entity"></param>
        /// <param name="refresh"></param>
        /// <param name="settings"></param>
        /// <returns></returns>
        private ClubCloud_Vereniging GetVerenigingForLidmaatschap(string bondsnummer, ClubCloud_Lidmaatschap entity, bool refresh, ClubCloud_Setting settings)
        {
            return GetVerenigingForLidmaatschapById(bondsnummer, entity.Id, refresh, settings);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="Id"></param>
        /// <param name="refresh"></param>
        /// <param name="settings"></param>
        /// <returns></returns>
        private ClubCloud_Vereniging GetVerenigingForLidmaatschapById(string bondsnummer, Guid Id, bool refresh, ClubCloud_Setting settings)
        {
            ClubCloud_Vereniging result = null;

            ClubCloud_Lidmaatschap lidmaatschap = beheerModel.ClubCloud_Lidmaatschappen.Find(Id);
            if (lidmaatschap != null)
            {
                if (lidmaatschap.ClubCloud_Vereniging == null)
                {
                    result = beheerModel.ClubCloud_Verenigingen.Find(lidmaatschap.VerenigingId.Value);

                    if (result != null)
                    {
                        lidmaatschap.ClubCloud_Vereniging = result;
                        beheerModel.SaveChanges();
                    }
                }

            }
            return result;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="entity"></param>
        /// <param name="refresh"></param>
        /// <param name="settings"></param>
        /// <returns></returns>
        private ClubCloud_Gebruiker GetGebruikerForLidmaatschap(string bondsnummer, ClubCloud_Lidmaatschap entity, bool refresh, ClubCloud_Setting settings)
        {
            return GetGebruikerForLidmaatschapById(bondsnummer, entity.Id, refresh, settings);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="Id"></param>
        /// <param name="refresh"></param>
        /// <param name="settings"></param>
        /// <returns></returns>
        private ClubCloud_Gebruiker GetGebruikerForLidmaatschapById(string bondsnummer, Guid Id, bool refresh, ClubCloud_Setting settings)
        {
            ClubCloud_Gebruiker result = null;

            ClubCloud_Lidmaatschap lidmaatschap = beheerModel.ClubCloud_Lidmaatschappen.Find(Id);
            if (lidmaatschap != null)
            {
                if (lidmaatschap.ClubCloud_Gebruiker == null)
                {
                    result = beheerModel.ClubCloud_Gebruikers.Find(lidmaatschap.GebruikerId.Value);

                    if (result != null)
                    {
                        lidmaatschap.ClubCloud_Gebruiker = result;
                        beheerModel.SaveChanges();
                    }
                }

            }
            return result;

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="entity"></param>
        /// <param name="refresh"></param>
        /// <param name="settings"></param>
        /// <returns></returns>
        private ClubCloud_Lidmaatschapsoort GetLidmaatschapsoortForLidmaatschap(string bondsnummer, ClubCloud_Lidmaatschap entity, bool refresh, ClubCloud_Setting settings)
        {
            return GetLidmaatschapsoortForLidmaatschapById(bondsnummer, entity.Id, refresh, settings);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="Id"></param>
        /// <param name="refresh"></param>
        /// <param name="settings"></param>
        /// <returns></returns>
        private ClubCloud_Lidmaatschapsoort GetLidmaatschapsoortForLidmaatschapById(string bondsnummer, Guid Id, bool refresh, ClubCloud_Setting settings)
        {
            ClubCloud_Lidmaatschapsoort result = null;

            ClubCloud_Lidmaatschap lidmaatschap = beheerModel.ClubCloud_Lidmaatschappen.Find(Id);
            if (lidmaatschap != null)
            {
                if (lidmaatschap.ClubCloud_Lidmaatschapsoort == null)
                {
                    result = beheerModel.ClubCloud_Lidmaatschapsoorten.Find(lidmaatschap.LidmaatschapsoortId.Value);

                    if (result != null)
                    {
                        lidmaatschap.ClubCloud_Lidmaatschapsoort = result;
                        beheerModel.SaveChanges();
                    }
                }

            }
            return result;
        }

        /*
        /// <summary>
        /// sgt_alg_lidmaatschap
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="lidmaatschapId"></param>
        /// <param name="refresh"></param>
        /// <returns></returns>
        private ClubCloud_Lidmaatschap GetLidmaatschapById(string bondsnummer, Guid lidmaatschapId, bool refresh = false)
        {

        }
        */

        /// <summary>
        /// sgt_alg_lidmaatschap
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="verenigingId"></param>
        /// <param name="refresh"></param>
        /// <returns></returns>
        private List<ClubCloud_Lidmaatschap> GetLidmaatschappenByVereniging(string bondsnummer, Guid verenigingId, bool refresh = false, ClubCloud_Setting settings = null)
        {
            List<ClubCloud_Lidmaatschap> lidmaatschappen = new List<ClubCloud_Lidmaatschap>();

            lidmaatschappen = beheerModel.ClubCloud_Lidmaatschappen.Where(f => f.VerenigingId == verenigingId && f.Actief == ActiefSoort.Actief).ToList();

            if (lidmaatschappen != null && lidmaatschappen.Count == 0 || refresh)
            {
                if (settings == null)
                {
                    settings = GetSettings(bondsnummer);
                }

                if (settings != null && settings.Access && !string.IsNullOrWhiteSpace(settings.Password))
                {
                    CookieContainer cc = RequestContainer(settings.Id.ToString(), settings.Password);

                    if (cc != null)
                    {
                        using (ClubCloud.KNLTB.ServIt.CrmService.CrmService service = CrmServices[settings.Id.ToString()])
                        {
                            bool moreRecords = true;
                            int pageNum = 1;
                            while (moreRecords)
                            {
                                ConditionExpression condition = new ConditionExpression { AttributeName = "sgt_verenigingid", Operator = ConditionOperator.Equal, Values = new object[1] { verenigingId } };
                                FilterExpression expression = new FilterExpression { FilterOperator = LogicalOperator.And, Conditions = new ConditionExpression[1] { condition } };

                                List<BusinessEntity> entities = RetrieveMultiple(service, "sgt_alg_lidmaatschap", out moreRecords, ref pageNum, expression);

                                foreach (sgt_alg_lidmaatschap lidmaatschap in entities)
                                {
                                    ClubCloud_Lidmaatschap entity = beheerModel.ClubCloud_Lidmaatschappen.Find(lidmaatschap.sgt_alg_lidmaatschapid.Value);

                                    if (entity == null)
                                        entity = beheerModel.ClubCloud_Lidmaatschappen.Create();

                                    entity.Id = lidmaatschap.sgt_alg_lidmaatschapid.Value;

                                    LidmaatschapToEntity(lidmaatschap, entity, bondsnummer, settings);

                                    beheerModel.ClubCloud_Lidmaatschappen.AddOrUpdate(entity);
                                }
                                beheerModel.SaveChanges();

                                foreach (sgt_alg_lidmaatschap lidmaatschap in entities)
                                {
                                    ClubCloud_Lidmaatschap entity = beheerModel.ClubCloud_Lidmaatschappen.Find(lidmaatschap.sgt_alg_lidmaatschapid.Value);

                                    if (lidmaatschap.sgt_lidid != null)
                                    {
                                        ClubCloud_Gebruiker gebruiker = GetGebruikerById(lidmaatschap.sgt_lidid.Value, false, settings);
                                        if (gebruiker != null)
                                            entity.ClubCloud_Gebruiker = gebruiker;
                                    }

                                    if (lidmaatschap.sgt_soort_lidmaatschapid != null)
                                    {
                                        ClubCloud_Lidmaatschapsoort soort = GetLidmaatschapsoortById(bondsnummer, lidmaatschap.sgt_soort_lidmaatschapid.Value, false, settings);
                                        if (soort != null)
                                            entity.ClubCloud_Lidmaatschapsoort = soort;
                                    }

                                    if (lidmaatschap.sgt_verenigingid != null)
                                    {
                                        ClubCloud_Vereniging vereniging = GetVerenigingById(bondsnummer, lidmaatschap.sgt_verenigingid.Value, false, settings);
                                        if (vereniging != null)
                                            entity.ClubCloud_Vereniging = vereniging;
                                    }
                                }

                                beheerModel.SaveChanges();
                            }
                        }
                    }
                }
                lidmaatschappen = beheerModel.ClubCloud_Lidmaatschappen.Where(f => f.VerenigingId == verenigingId && f.Actief == ActiefSoort.Actief).ToList();
            }
            return lidmaatschappen;
        }

        #region Mapping

        /// <summary>
        /// 
        /// </summary>
        /// <param name="lidmaatschap"></param>
        /// <param name="entity"></param>
        /// <param name="bondsnummer"></param>
        /// <param name="settings"></param>
        private void LidmaatschapToEntity(sgt_alg_lidmaatschap lidmaatschap, ClubCloud_Lidmaatschap entity, string bondsnummer, ClubCloud_Setting settings)
        {
            if (lidmaatschap.sgt_autorisatie_gezet != null)
            {
                entity.Autorisatie = lidmaatschap.sgt_autorisatie_gezet.Value;
            }
            //lidmaatschap.BondsNummer = entity.sgt_alg_bondsnummer;

            if (lidmaatschap.sgt_lidid != null)
            {
                //ClubCloud_Gebruiker gebruiker = GetGebruikerById(lidmaatschap.sgt_lidid.Value, false, settings);
                //entity.ClubCloud_Gebruiker = gebruiker;
                entity.GebruikerId = lidmaatschap.sgt_lidid.Value;
            }

            entity.Bondsnummer = lidmaatschap.sgt_alg_bondsnummer;
            entity.InternNummer = lidmaatschap.sgt_lidnummer_bij_vereniging;

            if (lidmaatschap.sgt_soort_lidmaatschapid != null)
            {
                //ClubCloud_Lidmaatschapsoort soort = GetLidmaatschapsoortById(bondsnummer,lidmaatschap.sgt_soort_lidmaatschapid.Value, false, settings);
                //lidmaatschap.SoortNaam = entity.sgt_soort_lidmaatschapid.name;
                //entity.ClubCloud_Lidmaatschapsoort = soort;
                entity.LidmaatschapsoortId = lidmaatschap.sgt_soort_lidmaatschapid.Value;
            }

            if (lidmaatschap.sgt_verenigingid != null)
            {
                //ClubCloud_Vereniging vereniging = GetVerenigingById(bondsnummer, lidmaatschap.sgt_verenigingid.Value, false, settings);
                //entity.ClubCloud_Vereniging = vereniging;
                entity.VerenigingId = lidmaatschap.sgt_verenigingid.Value;
            }

            if (lidmaatschap.sgt_lidmaatschap_vanaf != null)
            {
                entity.Begin = DateTime.Parse(lidmaatschap.sgt_lidmaatschap_vanaf.Value);
            }

            if (lidmaatschap.sgt_lidmaatschap_beeindigd != null)
            {
                entity.Einde = DateTime.Parse(lidmaatschap.sgt_lidmaatschap_beeindigd.Value);
            }

            if (lidmaatschap.sgt_datum_opgezegd != null)
            {
                entity.Opzegging = DateTime.Parse(lidmaatschap.sgt_datum_opgezegd.Value);
            }

            if (lidmaatschap.sgt_nieuwe_pas_nodig != null)
            {
                entity.PasNieuw = lidmaatschap.sgt_nieuwe_pas_nodig.Value;
            }

            if (lidmaatschap.sgt_pastypeid != null)
            {
                entity.PasTypeNaam = lidmaatschap.sgt_pastypeid.name;
                entity.PasTypeId = lidmaatschap.sgt_pastypeid.Value;
            }

            if (lidmaatschap.sgt_wedstrijdpas != null)
            {
                entity.PasWedstrijd = lidmaatschap.sgt_wedstrijdpas.Value;
            }

            entity.PasVolgnummer = lidmaatschap.sgt_volgnummer_pas;

            if (lidmaatschap.sgt_noodpas_nodig != null)
            {
                entity.PasNood = lidmaatschap.sgt_noodpas_nodig.Value;
            }

            if (lidmaatschap.sgt_datum_laatste_noodpas != null)
            {
                entity.PasNoodDatum = DateTime.Parse(lidmaatschap.sgt_datum_laatste_noodpas.Value);
            }

            if (lidmaatschap.sgt_datum_laatste_pas != null)
            {
                entity.PasDatum = DateTime.Parse(lidmaatschap.sgt_datum_laatste_pas.Value);
            }

            if (lidmaatschap.sgt_speelsterkte_dubbel != null)
            {
                entity.SpeelsterkteDubbel = lidmaatschap.sgt_speelsterkte_dubbel.Value;
            }
            if (lidmaatschap.sgt_speelsterkte_enkel != null)
            {
                entity.SpeelsterkteEnkel = lidmaatschap.sgt_speelsterkte_enkel.Value;
            }

            entity.Actief = (ActiefSoort)lidmaatschap.statuscode.Value;
            entity.Gewijzigd = DateTime.Now;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="entity"></param>
        /// <param name="lidmaatschap"></param>
        /// <param name="bondsnummer"></param>
        private void EntityToLidmaatschap(sgt_alg_lidmaatschap lidmaatschap, ClubCloud_Lidmaatschap entity, string bondsnummer, ClubCloud_Setting settings)
        {

        }

        #endregion

        #endregion

        #region Lidmaatschapsoort

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="Id"></param>
        /// <param name="refresh"></param>
        /// <param name="settings"></param>
        /// <returns></returns>
        private ClubCloud_Lidmaatschapsoort GetLidmaatschapsoortById(string bondsnummer, Guid Id, bool refresh, ClubCloud_Setting settings)
        {
            ClubCloud_Lidmaatschapsoort entity = null;

            entity = beheerModel.ClubCloud_Lidmaatschapsoorten.Find(Id);

            if (entity == null || refresh)
            {
                if (settings == null)
                    settings = GetSettings(bondsnummer);

                if (settings != null && settings.Access && !string.IsNullOrWhiteSpace(settings.Password))
                {
                    CookieContainer cc = RequestContainer(settings.Id.ToString(), settings.Password);

                    if (cc != null)
                    {
                        using (ClubCloud.KNLTB.ServIt.CrmService.CrmService service = CrmServices[settings.Id.ToString()])
                        {
                            sgt_alg_soort_lidmaatschap lidmaatschapsoort = RetrieveEntity(service, "sgt_alg_soort_lidmaatschap", Id) as sgt_alg_soort_lidmaatschap;

                            if (lidmaatschapsoort != null && lidmaatschapsoort.sgt_alg_soort_lidmaatschapid.Value == Id)
                            {
                                if (entity == null)
                                    entity = beheerModel.ClubCloud_Lidmaatschapsoorten.Create();

                                entity.Id = lidmaatschapsoort.sgt_alg_soort_lidmaatschapid.Value;

                                LidmaatschapsoortToEntity(lidmaatschapsoort, entity, settings);

                                beheerModel.ClubCloud_Lidmaatschapsoorten.AddOrUpdate(entity);
                                beheerModel.SaveChanges();
                            }
                        }
                    }
                }
                entity = beheerModel.ClubCloud_Lidmaatschapsoorten.Find(Id);
            }

            return entity;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="refresh"></param>
        /// <param name="settings"></param>
        /// <returns></returns>
        private List<ClubCloud_Lidmaatschapsoort> GetLidmaatschapsoorten(string bondsnummer, bool refresh, ClubCloud_Setting settings)
        {
            List<ClubCloud_Lidmaatschapsoort> lidmaatschapsoorten = new List<ClubCloud_Lidmaatschapsoort>();
            lidmaatschapsoorten = beheerModel.ClubCloud_Lidmaatschapsoorten.ToList();

            if (lidmaatschapsoorten == null || lidmaatschapsoorten.Count == 0 || refresh)
            {
                if (settings == null)
                {
                    settings = GetSettings(bondsnummer);
                }

                if (settings != null && settings.Access && !string.IsNullOrWhiteSpace(settings.Password))
                {
                    CookieContainer cc = RequestContainer(settings.Id.ToString(), settings.Password);

                    if (cc != null)
                    {
                        using (ClubCloud.KNLTB.ServIt.CrmService.CrmService service = CrmServices[settings.Id.ToString()])
                        {
                            bool moreRecords = true;
                            int pageNum = 1;
                            while (moreRecords)
                            {

                                List<BusinessEntity> entities = RetrieveMultiple(service, "sgt_alg_soort_lidmaatschap", out moreRecords, ref pageNum);

                                foreach (sgt_alg_soort_lidmaatschap lidmaatschapsoort in entities)
                                {
                                    ClubCloud_Lidmaatschapsoort entity = beheerModel.ClubCloud_Lidmaatschapsoorten.Find(lidmaatschapsoort.sgt_alg_soort_lidmaatschapid.Value);

                                    if (entity == null)
                                        entity = beheerModel.ClubCloud_Lidmaatschapsoorten.Create();

                                    entity.Id = lidmaatschapsoort.sgt_alg_soort_lidmaatschapid.Value;

                                    LidmaatschapsoortToEntity(lidmaatschapsoort, entity, settings);

                                    beheerModel.ClubCloud_Lidmaatschapsoorten.AddOrUpdate(entity);

                                }
                                beheerModel.SaveChanges();

                            }
                        }
                    }
                }
                lidmaatschapsoorten = beheerModel.ClubCloud_Lidmaatschapsoorten.ToList();
            }
            return lidmaatschapsoorten;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="entity"></param>
        /// <param name="settings"></param>
        /// <returns></returns>
        private ClubCloud_Lidmaatschapsoort SetLidmaatschapsoort(string bondsnummer, ClubCloud_Lidmaatschapsoort entity, ClubCloud_Setting settings)
        {
            if (entity.Id == Guid.Empty)
                entity.Id = Guid.NewGuid();

            return entity;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="entity"></param>
        /// <param name="refresh"></param>
        /// <param name="settings"></param>
        /// <returns></returns>
        private List<ClubCloud_Lidmaatschap> GetLidmaatschappenForLidmaatschapsoort(string bondsnummer, ClubCloud_Lidmaatschapsoort entity, bool refresh, ClubCloud_Setting settings)
        {
            return GetLidmaatschappenForLidmaatschapsoortById(bondsnummer, entity.Id, refresh, settings);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="Id"></param>
        /// <param name="refresh"></param>
        /// <param name="settings"></param>
        /// <returns></returns>
        private List<ClubCloud_Lidmaatschap> GetLidmaatschappenForLidmaatschapsoortById(string bondsnummer, Guid Id, bool refresh, ClubCloud_Setting settings)
        {
            List<ClubCloud_Lidmaatschap> result = null;

            ClubCloud_Lidmaatschapsoort lidmaatschapsoort = beheerModel.ClubCloud_Lidmaatschapsoorten.Find(Id);
            if (lidmaatschapsoort != null)
            {
                if (lidmaatschapsoort.ClubCloud_Lidmaatschap == null || lidmaatschapsoort.ClubCloud_Lidmaatschap.Count == 0)
                {
                    result = beheerModel.ClubCloud_Lidmaatschappen.Where(v => v.LidmaatschapsoortId.Value == Id).ToList();

                    foreach (ClubCloud_Lidmaatschap functionaris in result)
                    {
                        lidmaatschapsoort.ClubCloud_Lidmaatschap.Add(functionaris);
                    }
                    beheerModel.SaveChanges();
                }

            }
            return result;
        }

        private ClubCloud_Vereniging GetVerenigingForLidmaatschapsoort(string bondsnummer, ClubCloud_Lidmaatschapsoort entity, bool refresh, ClubCloud_Setting settings)
        {
            return GetVerenigingForLidmaatschapsoortById(bondsnummer, entity.Id, refresh, settings);
        }

        private ClubCloud_Vereniging GetVerenigingForLidmaatschapsoortById(string bondsnummer, Guid Id, bool refresh, ClubCloud_Setting settings)
        {
            ClubCloud_Vereniging result = null;

            ClubCloud_Lidmaatschapsoort lidmaatschapsoorten = beheerModel.ClubCloud_Lidmaatschapsoorten.Find(Id);
            if (lidmaatschapsoorten != null)
            {
                if (lidmaatschapsoorten.ClubCloud_Vereniging == null)
                {
                    result = beheerModel.ClubCloud_Verenigingen.Find(lidmaatschapsoorten.VerenigingId.Value);

                    if (result != null)
                    {
                        lidmaatschapsoorten.ClubCloud_Vereniging = result;
                        beheerModel.SaveChanges();
                    }
                }

            }
            return result;
        }

        #region Mapping

        /// <summary>
        /// 
        /// </summary>
        /// <param name="functie"></param>
        /// <param name="entitys"></param>
        /// <param name="settings"></param>
        private void LidmaatschapsoortToEntity(sgt_alg_soort_lidmaatschap lidmaatschapsoort, ClubCloud_Lidmaatschapsoort entity, ClubCloud_Setting settings)
        {
            entity.Naam = lidmaatschapsoort.sgt_alg_soort_lidmaatschap1;
            entity.Beschrijving = lidmaatschapsoort.sgt_beschrijving;
            entity.Contributie = lidmaatschapsoort.sgt_contributie.Value;
            entity.Omschrijving = lidmaatschapsoort.sgt_omschrijving;
            entity.Code = lidmaatschapsoort.sgt_verkorte_code;
            entity.Actief = (ActiefSoort)lidmaatschapsoort.statuscode.Value;
        }

        private void EntityToLidmaatschapsoort(sgt_alg_soort_lidmaatschap lidmaatschapsoort, ClubCloud_Lidmaatschapsoort entity, ClubCloud_Setting settings)
        {

        }

        #endregion

        #endregion

        #region Nationaliteit

        /// <summary>
        /// TargetRetrieveSgt_alg_nationaliteit
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="refresh"></param>
        /// <returns></returns>
        private ClubCloud_Nationaliteit GetNationaliteitById(string bondsnummer, Guid Id, bool refresh = false, ClubCloud_Setting settings = null)
        {
            ClubCloud_Nationaliteit entity = null;

            entity = beheerModel.ClubCloud_Nationaliteiten.Find(Id);

            if (entity == null || refresh)
            {
                if (settings == null)
                    settings = GetSettings(bondsnummer);

                if (settings.Access && !string.IsNullOrWhiteSpace(settings.Password))
                {
                    CookieContainer cc = RequestContainer(settings.Id.ToString(), settings.Password);

                    if (cc != null)
                    {
                        using (ClubCloud.KNLTB.ServIt.CrmService.CrmService service = CrmServices[settings.Id.ToString()])
                        {
                            sgt_alg_nationaliteit nationaliteit = RetrieveEntity(service, "sgt_alg_nationaliteit", Id) as sgt_alg_nationaliteit;

                            if (nationaliteit != null && nationaliteit.sgt_alg_nationaliteitid.Value == Id)
                            {
                                if (entity == null)
                                    entity = beheerModel.ClubCloud_Nationaliteiten.Create();

                                entity.Id = nationaliteit.sgt_alg_nationaliteitid.Value;
                                entity.Naam = nationaliteit.sgt_alg_nationaliteit1;
                                entity.Code = nationaliteit.sgt_verkorte_code;
                                beheerModel.ClubCloud_Nationaliteiten.AddOrUpdate(entity);
                                beheerModel.SaveChanges();
                            } 
                        }
                    }
                }
                entity = beheerModel.ClubCloud_Nationaliteiten.Find(Id);
            }
            return entity;
        }

        /// <summary>
        /// GetNationaliteiten
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="refresh"></param>
        /// <returns></returns>
        private List<ClubCloud_Nationaliteit> GetNationaliteiten(string bondsnummer, bool refresh = false, ClubCloud_Setting settings = null)
        {
            List<ClubCloud_Nationaliteit> nationaliteiten = new List<ClubCloud_Nationaliteit>();

            nationaliteiten = beheerModel.ClubCloud_Nationaliteiten.Where(n => n.Naam != string.Empty).ToList<ClubCloud_Nationaliteit>();

            if (nationaliteiten == null && nationaliteiten.Count == 0 || refresh)
            {
                if (settings == null)
                    settings = GetSettings(bondsnummer);

                if (settings.Access && !string.IsNullOrWhiteSpace(settings.Password))
                {
                    CookieContainer cc = RequestContainer(settings.Id.ToString(), settings.Password);

                    if (cc != null)
                    {
                        using (ClubCloud.KNLTB.ServIt.CrmService.CrmService service = CrmServices[settings.Id.ToString()])
                        {
                            bool moreRecords = true;
                            int pageNum = 1;
                            while (moreRecords)
                            {
                                List<BusinessEntity> entities = RetrieveMultiple(service, "sgt_alg_nationaliteit", out moreRecords, ref pageNum);

                                foreach (sgt_alg_nationaliteit nationaliteit in entities)
                                {
                                    ClubCloud_Nationaliteit entity = beheerModel.ClubCloud_Nationaliteiten.Find(nationaliteit.sgt_alg_nationaliteitid.Value);

                                    if (entity == null)
                                        entity = beheerModel.ClubCloud_Nationaliteiten.Create();

                                    entity.Id = nationaliteit.sgt_alg_nationaliteitid.Value;
                                    entity.Naam = nationaliteit.sgt_alg_nationaliteit1;
                                    entity.Code = nationaliteit.sgt_verkorte_code;
                                    beheerModel.ClubCloud_Nationaliteiten.AddOrUpdate(entity);
                                }
                                beheerModel.SaveChanges();

                            }
                        }
                    }
                }
                nationaliteiten = beheerModel.ClubCloud_Nationaliteiten.Where(n => n.Naam != string.Empty).ToList<ClubCloud_Nationaliteit>();
            }
            return nationaliteiten;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="entity"></param>
        /// <param name="settings"></param>
        /// <returns></returns>
        private ClubCloud_Nationaliteit SetNationaliteit(string bondsnummer, ClubCloud_Nationaliteit entity, ClubCloud_Setting settings)
        {
            if (entity.Id == Guid.Empty)
                entity.Id = Guid.NewGuid();

            return entity;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="entity"></param>
        /// <param name="refresh"></param>
        /// <param name="settings"></param>
        /// <returns></returns>
        private List<ClubCloud_Gebruiker> GetGebruikersForNationaliteit(string bondsnummer, ClubCloud_Nationaliteit entity, bool refresh, ClubCloud_Setting settings)
        {
            return GetGebruikersForNationaliteitById(bondsnummer, entity.Id, refresh, settings);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="Id"></param>
        /// <param name="refresh"></param>
        /// <param name="settings"></param>
        /// <returns></returns>
        private List<ClubCloud_Gebruiker> GetGebruikersForNationaliteitById(string bondsnummer, Guid Id, bool refresh, ClubCloud_Setting settings)
        {
            List<ClubCloud_Gebruiker> result = null;

            ClubCloud_Nationaliteit nationaliteit = beheerModel.ClubCloud_Nationaliteiten.Find(Id);
            if (nationaliteit != null)
            {
                if (nationaliteit.ClubCloud_Gebruiker == null || nationaliteit.ClubCloud_Gebruiker.Count == 0)
                {
                    result = beheerModel.ClubCloud_Gebruikers.Where(v => v.NationaliteitId.Value == Id).ToList();

                    foreach (ClubCloud_Gebruiker gebruiker in result)
                    {
                        nationaliteit.ClubCloud_Gebruiker.Add(gebruiker);
                    }
                    beheerModel.SaveChanges();
                }

            }
            return result;
        }

        #endregion

        #region Profiel

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="Id"></param>
        /// <param name="refresh"></param>
        /// <param name="settings"></param>
        /// <returns></returns>
        private ClubCloud_Profiel GetProfielById(string bondsnummer, Guid Id, bool refresh, ClubCloud_Setting settings)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="refresh"></param>
        /// <param name="settings"></param>
        /// <returns></returns>
        private List<ClubCloud_Profiel> GetProfielen(string bondsnummer, bool refresh, ClubCloud_Setting settings)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="entity"></param>
        /// <param name="settings"></param>
        /// <returns></returns>
        private ClubCloud_Profiel SetProfiel(string bondsnummer, ClubCloud_Profiel entity, ClubCloud_Setting settings)
        {
            if (entity.Id == Guid.Empty)
                entity.Id = Guid.NewGuid();

            return entity;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="entity"></param>
        /// <param name="refresh"></param>
        /// <param name="settings"></param>
        /// <returns></returns>
        private ClubCloud_Gebruiker GetGebruikerForProfiel(string bondsnummer, ClubCloud_Profiel entity, bool refresh, ClubCloud_Setting settings)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="Id"></param>
        /// <param name="refresh"></param>
        /// <param name="settings"></param>
        /// <returns></returns>
        private ClubCloud_Gebruiker GetGebruikerForProfielById(string bondsnummer, Guid Id, bool refresh, ClubCloud_Setting settings)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// sgt_dss_spelersprofiel
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="gebruikerId"></param>
        /// <param name="refresh"></param>
        /// <returns></returns>
        private List<ClubCloud_Profiel> GetSpelersProfielByGebruiker(string bondsnummer, Guid gebruikerId, bool refresh = false)
        {
            List<ClubCloud_Profiel> profielen = new List<ClubCloud_Profiel>();

            profielen = beheerModel.ClubCloud_Profielen.Where(p => p.GebruikerId == gebruikerId).ToList();

            if (profielen == null || profielen.Count == 0 || refresh)
            {
                ClubCloud_Setting settings = GetSettings(bondsnummer);

                if (settings != null && settings.Access && !string.IsNullOrWhiteSpace(settings.Password))
                {
                    CookieContainer cc = RequestContainer(settings.Id.ToString(), settings.Password);

                    if (cc != null)
                    {
                        using (ClubCloud.KNLTB.ServIt.CrmService.CrmService service = CrmServices[settings.Id.ToString()])
                        {

                            //CrmService.CrmCookieContainer = cc; 
                            //ClubCloud.KNLTB.ServIt.CrmService.CrmService service = new KNLTB.ServIt.CrmService.CrmService(cc);

                            bool moreRecords = true;
                            int pageNum = 1;
                            while (moreRecords)
                            {
                                ConditionExpression condition = new ConditionExpression { AttributeName = "sgt_naamid ", Operator = ConditionOperator.Equal, Values = new object[1] { gebruikerId } };
                                FilterExpression expression = new FilterExpression { FilterOperator = LogicalOperator.And, Conditions = new ConditionExpression[1] { condition } };

                                List<BusinessEntity> entities = RetrieveMultiple(service, "sgt_dss_spelersprofiel", out moreRecords, ref pageNum, expression);

                                foreach (sgt_dss_spelersprofiel entity in entities)
                                {
                                    ClubCloud_Profiel profiel = beheerModel.ClubCloud_Profielen.Find(entity.sgt_dss_spelersprofielid.Value, DateTime.Parse(entity.sgt_datum_dss.Value));

                                    if (profiel == null)
                                    {
                                        profiel = beheerModel.ClubCloud_Profielen.Create();
                                        profiel.Id = entity.sgt_dss_spelersprofielid.Value;
                                        EntityToProfiel(entity, profiel, bondsnummer, refresh, settings);
                                        beheerModel.ClubCloud_Profielen.Add(profiel);
                                    }
                                    else
                                    {
                                        EntityToProfiel(entity, profiel, bondsnummer, refresh, settings);
                                    }
                                    beheerModel.SaveChanges();
                                }
                            }
                        }
                    }
                }
                profielen = beheerModel.ClubCloud_Profielen.Where(p => p.GebruikerId == gebruikerId).ToList();
            }
            return profielen;
        }

        /// <summary>
        /// sgt_dss_spelersprofiel
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="profielId"></param>
        /// <param name="refresh"></param>
        /// <returns></returns>
        private ClubCloud_Profiel GetSpelersProfielById(string bondsnummer, Guid profielId, bool refresh = false)
        {
            ClubCloud_Profiel profiel = new ClubCloud_Profiel();

            profiel = beheerModel.ClubCloud_Profielen.SingleOrDefault(p => p.Id == profielId);

            if (profiel == null || refresh)
            {
                ClubCloud_Setting settings = GetSettings(bondsnummer);

                if (settings != null && settings.Access && !string.IsNullOrWhiteSpace(settings.Password))
                {
                    CookieContainer cc = RequestContainer(settings.Id.ToString(), settings.Password);

                    if (cc != null)
                    {
                        using (ClubCloud.KNLTB.ServIt.CrmService.CrmService service = CrmServices[settings.Id.ToString()])
                        {

                            //CrmService.CrmCookieContainer = cc; 
                            //ClubCloud.KNLTB.ServIt.CrmService.CrmService service = new KNLTB.ServIt.CrmService.CrmService(cc);

                            bool moreRecords = true;
                            int pageNum = 1;
                            while (moreRecords)
                            {
                                ConditionExpression condition = new ConditionExpression { AttributeName = "sgt_dss_spelersprofielid", Operator = ConditionOperator.Equal, Values = new object[1] { profielId } };
                                FilterExpression expression = new FilterExpression { FilterOperator = LogicalOperator.And, Conditions = new ConditionExpression[1] { condition } };

                                List<BusinessEntity> entities = RetrieveMultiple(service, "sgt_dss_spelersprofiel", out moreRecords, ref pageNum, expression);

                                foreach (sgt_dss_spelersprofiel entity in entities)
                                {
                                    profiel = beheerModel.ClubCloud_Profielen.Find(entity.sgt_dss_spelersprofielid.Value, DateTime.Parse(entity.sgt_datum_dss.Value));

                                    if (profiel == null)
                                    {
                                        profiel = beheerModel.ClubCloud_Profielen.Create();
                                        profiel.Id = entity.sgt_dss_spelersprofielid.Value;
                                        EntityToProfiel(entity, profiel, bondsnummer, refresh, settings);
                                        beheerModel.ClubCloud_Profielen.Add(profiel);
                                    }
                                    else
                                    {
                                        EntityToProfiel(entity, profiel, bondsnummer, refresh, settings);
                                    }
                                    beheerModel.SaveChanges();
                                }
                            }
                        }
                    }
                }
                profiel = beheerModel.ClubCloud_Profielen.SingleOrDefault(p => p.Id == profielId);
            }
            return profiel;
        }

        /// <summary>
        /// sgt_dss_spelersprofiel
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="nummer"></param>
        /// <param name="refresh"></param>
        /// <returns></returns>
        private List<ClubCloud_Profiel> GetSpelersProfielByNummer(string bondsnummer, string nummer, bool refresh = false)
        {
            List<ClubCloud_Profiel> profielen = new List<ClubCloud_Profiel>();

            profielen = beheerModel.ClubCloud_Profielen.Where(p => p.Bondsnummer == nummer).ToList();

            if (profielen == null || profielen.Count == 0 || refresh)
            {
                ClubCloud_Setting settings = GetSettings(bondsnummer);

                if (settings != null && settings.Access && !string.IsNullOrWhiteSpace(settings.Password))
                {
                    CookieContainer cc = RequestContainer(settings.Id.ToString(), settings.Password);

                    if (cc != null)
                    {
                        using (ClubCloud.KNLTB.ServIt.CrmService.CrmService service = CrmServices[settings.Id.ToString()])
                        {

                            //CrmService.CrmCookieContainer = cc; 
                            //ClubCloud.KNLTB.ServIt.CrmService.CrmService service = new KNLTB.ServIt.CrmService.CrmService(cc);

                            bool moreRecords = true;
                            int pageNum = 1;
                            while (moreRecords)
                            {
                                ConditionExpression condition = new ConditionExpression { AttributeName = "sgt_dss_bondsnummer", Operator = ConditionOperator.Equal, Values = new object[1] { nummer } };
                                FilterExpression expression = new FilterExpression { FilterOperator = LogicalOperator.And, Conditions = new ConditionExpression[1] { condition } };

                                List<BusinessEntity> entities = RetrieveMultiple(service, "sgt_dss_spelersprofiel", out moreRecords, ref pageNum, expression);

                                foreach (sgt_dss_spelersprofiel entity in entities)
                                {
                                    ClubCloud_Profiel profiel = beheerModel.ClubCloud_Profielen.Find(entity.sgt_dss_spelersprofielid.Value, DateTime.Parse(entity.sgt_datum_dss.Value));

                                    if (profiel == null)
                                    {
                                        profiel = beheerModel.ClubCloud_Profielen.Create();
                                        profiel.Id = entity.sgt_dss_spelersprofielid.Value;
                                        EntityToProfiel(entity, profiel, bondsnummer, refresh, settings);
                                        beheerModel.ClubCloud_Profielen.Add(profiel);
                                    }
                                    else
                                    {
                                        EntityToProfiel(entity, profiel, bondsnummer, refresh, settings);
                                    }
                                    beheerModel.SaveChanges();
                                }
                            }
                        }
                    }
                }
                profielen = beheerModel.ClubCloud_Profielen.Where(p => p.Bondsnummer == nummer).ToList();
            }
            return profielen;
        }

        private void EntityToProfiel(sgt_dss_spelersprofiel entity, ClubCloud_Profiel profiel, string bondsnummer, bool refresh = false, ClubCloud_Setting settings = null)
        {
            profiel.Bondsnummer = entity.sgt_dss_bondsnummer;

            if (entity.sgt_naamid != null && settings != null)
            {
                ClubCloud_Gebruiker gebruiker = GetGebruikerById(bondsnummer, entity.sgt_naamid.Value, false, settings);
                profiel.GebruikerId = gebruiker.Id;
                profiel.ClubCloud_Gebruiker = gebruiker;
            }

            profiel.GebruikerId = entity.sgt_naamid.Value;

            if (entity.sgt_aantal_partij_resultaten_dubbel != null)
                profiel.Enkel_Aantal = entity.sgt_aantal_partij_resultaten_dubbel.Value;

            if (entity.sgt_aantal_partij_resultatenenkel != null)
                profiel.Dubbel_aantal = entity.sgt_aantal_partij_resultatenenkel.Value;

            if (entity.sgt_speelsterkte_enkel != null)
                profiel.Enkel_Speelsterkte = entity.sgt_speelsterkte_enkel.Value;

            if (entity.sgt_speelsterkte_enkel_oud != null)
                profiel.Enkel_Speelsterkte_Vorig = entity.sgt_speelsterkte_enkel_oud.Value;

            if (entity.sgt_speelsterkte_dubbel != null)
                profiel.Dubbel_Speelsterkte = entity.sgt_speelsterkte_dubbel.Value;

            if (entity.sgt_speelsterkte_dubbel_oud != null)
                profiel.Dubbel_Speelsterkte_Vorig = entity.sgt_speelsterkte_dubbel_oud.Value;

            if (entity.sgt_eindejaarsrating_enkel != null)
                profiel.Enkel_Rating_Eindejaar = entity.sgt_eindejaarsrating_enkel.Value;

            if (entity.sgt_eindejaarsrating_dubbel != null)
                profiel.Dubbel_Rating_Eindejaar = entity.sgt_eindejaarsrating_dubbel.Value;

            if (entity.sgt_rating_enkel != null)
                profiel.Enkel_Rating_Actueel = entity.sgt_rating_enkel.Value;

            if (entity.sgt_rating_dubbel != null)
                profiel.Dubbel_Rating_Actueel = entity.sgt_rating_dubbel.Value;

            if (entity.sgt_datum_dss != null)
                profiel.Datum = DateTime.Parse(entity.sgt_datum_dss.Value);

            profiel.Actief = (ActiefSoort)entity.statuscode.Value;
            profiel.Gewijzigd = DateTime.Now;

        }

        #endregion

        #region Rechtsvorm

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="Id"></param>
        /// <param name="refresh"></param>
        /// <param name="settings"></param>
        /// <returns></returns>
        private ClubCloud_Rechtsvorm GetRechtsvormById(string bondsnummer, Guid Id, bool refresh = false, ClubCloud_Setting settings = null)
        {

            ClubCloud_Rechtsvorm entity = new ClubCloud_Rechtsvorm();

            entity = beheerModel.ClubCloud_Rechtsvormen.Find(Id);

            if (entity != null || refresh)
            {
                if (settings == null)
                {
                    settings = GetSettings(bondsnummer);
                }

                if (settings != null && settings.Access && !string.IsNullOrWhiteSpace(settings.Password))
                {
                    CookieContainer cc = RequestContainer(settings.Id.ToString(), settings.Password);

                    if (cc != null)
                    {
                        using (ClubCloud.KNLTB.ServIt.CrmService.CrmService service = CrmServices[settings.Id.ToString()])
                        {
                            sgt_alg_rechtsvorm rechtsvorm = RetrieveEntity(service, "sgt_alg_rechtsvorm", Id) as sgt_alg_rechtsvorm;

                            if (rechtsvorm != null && rechtsvorm.sgt_alg_rechtsvormid.Value == Id)
                            {
                                if (entity == null)
                                    entity = beheerModel.ClubCloud_Rechtsvormen.Create();

                                entity.Id = rechtsvorm.sgt_alg_rechtsvormid.Value;

                                RechtsvormToEntity(rechtsvorm, entity, settings);

                                beheerModel.ClubCloud_Rechtsvormen.AddOrUpdate(entity);

                                beheerModel.SaveChanges();
                            } 
                        }
                    }
                }
                entity = beheerModel.ClubCloud_Rechtsvormen.Find(Id);
            }
            return entity;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="refresh"></param>
        /// <param name="settings"></param>
        /// <returns></returns>
        private List<ClubCloud_Rechtsvorm> GetRechtsvormen(string bondsnummer, bool refresh = false, ClubCloud_Setting settings = null)
        {
            List<ClubCloud_Rechtsvorm> rechtsvormen = new List<ClubCloud_Rechtsvorm>();

            rechtsvormen = beheerModel.ClubCloud_Rechtsvormen.ToList();

            if (rechtsvormen != null && rechtsvormen.Count == 0)
            {
                if (settings == null)
                {
                    settings = GetSettings(bondsnummer);
                }

                if (settings != null && settings.Access && !string.IsNullOrWhiteSpace(settings.Password))
                {
                    CookieContainer cc = RequestContainer(settings.Id.ToString(), settings.Password);

                    if (cc != null)
                    {
                        using (ClubCloud.KNLTB.ServIt.CrmService.CrmService service = CrmServices[settings.Id.ToString()])
                        {
                            bool moreRecords = true;
                            int pageNum = 1;
                            while (moreRecords)
                            {
                                List<BusinessEntity> entities = RetrieveMultiple(service, "sgt_alg_rechtsvorm", out moreRecords, ref pageNum);

                                foreach (sgt_alg_rechtsvorm rechtsvorm in entities)
                                {
                                    ClubCloud_Rechtsvorm entity = beheerModel.ClubCloud_Rechtsvormen.Find(rechtsvorm.sgt_alg_rechtsvormid.Value);

                                    if (entity == null)
                                        entity = beheerModel.ClubCloud_Rechtsvormen.Create();

                                    entity.Id = rechtsvorm.sgt_alg_rechtsvormid.Value;

                                    RechtsvormToEntity(rechtsvorm, entity, settings);

                                    beheerModel.ClubCloud_Rechtsvormen.AddOrUpdate(entity);
                                }
                                beheerModel.SaveChanges();
                            }
                        }
                    }
                }
                rechtsvormen = beheerModel.ClubCloud_Rechtsvormen.ToList();
            }
            return rechtsvormen;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="entity"></param>
        /// <param name="settings"></param>
        /// <returns></returns>
        private ClubCloud_Rechtsvorm SetRechtsvorm(string bondsnummer, ClubCloud_Rechtsvorm entity, ClubCloud_Setting settings)
        {
            if (entity.Id == Guid.Empty)
                entity.Id = Guid.NewGuid();

            return entity;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="entity"></param>
        /// <param name="refresh"></param>
        /// <param name="settings"></param>
        /// <returns></returns>
        private List<ClubCloud_Vereniging> GetVerenigingenForRechtsvorm(string bondsnummer, ClubCloud_Rechtsvorm entity, bool refresh, ClubCloud_Setting settings)
        {
            return GetVerenigingenForRechtsvormById(bondsnummer, entity.Id, refresh, settings);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="Id"></param>
        /// <param name="refresh"></param>
        /// <param name="settings"></param>
        /// <returns></returns>
        private List<ClubCloud_Vereniging> GetVerenigingenForRechtsvormById(string bondsnummer, Guid Id, bool refresh, ClubCloud_Setting settings)
        {
            List<ClubCloud_Vereniging> result = null;

            ClubCloud_Rechtsvorm rechtsvorm = beheerModel.ClubCloud_Rechtsvormen.Find(Id);
            if (rechtsvorm != null)
            {
                if (rechtsvorm.ClubCloud_Vereniging == null || rechtsvorm.ClubCloud_Vereniging.Count == 0)
                {
                    result = beheerModel.ClubCloud_Verenigingen.Where(v => v.RechtsvormId.Value == Id).ToList();

                    foreach (ClubCloud_Vereniging vereniging in result)
                    {
                        rechtsvorm.ClubCloud_Vereniging.Add(vereniging);
                    }
                    beheerModel.SaveChanges();
                }

            }
            return result;
        }

        #region Mapping

        private void RechtsvormToEntity(sgt_alg_rechtsvorm rechtsvorm, ClubCloud_Rechtsvorm entity, ClubCloud_Setting settings)
        {
            entity.Naam = rechtsvorm.sgt_alg_rechtsvorm1;
            entity.Omschrijving = rechtsvorm.sgt_omschrijving;
            entity.Beschrijving = rechtsvorm.sgt_beschrijving;
            entity.Meervoud = rechtsvorm.sgt_meervoudsnaam;
            entity.Code = rechtsvorm.sgt_verkorte_code;
            entity.Actief = (ActiefSoort)rechtsvorm.statuscode.Value;
        }

        private void EntityToRechtsvorm(sgt_alg_rechtsvorm rechtsvorm, ClubCloud_Rechtsvorm entity, ClubCloud_Setting settings)
        {

        }

        #endregion

        #endregion

        #region Regio

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="Id"></param>
        /// <param name="naam"></param>
        /// <param name="refresh"></param>
        /// <returns></returns>
        private ClubCloud_Regio GetRegioById(string bondsnummer, Guid Id, bool refresh = false, ClubCloud_Setting settings = null)
        {
            ClubCloud_Regio entity = new ClubCloud_Regio();

            entity = beheerModel.ClubCloud_Regios.Find(Id);

            if (entity == null && refresh)
            {
                if (settings == null)
                {
                    settings = GetSettings(bondsnummer);
                }

                if (settings != null && settings.Access && !string.IsNullOrWhiteSpace(settings.Password))
                {
                    CookieContainer cc = RequestContainer(settings.Id.ToString(), settings.Password);

                    if (cc != null)
                    {
                        using (ClubCloud.KNLTB.ServIt.CrmService.CrmService service = CrmServices[settings.Id.ToString()])
                        {
                            account regio = RetrieveEntity(service, "account", Id) as account;

                            if (regio != null && regio.accountid.Value == Id)
                            {
                                if (entity == null)
                                    entity = beheerModel.ClubCloud_Regios.Create();

                                entity.Id = regio.accountid.Value;
                                entity.Naam = string.IsNullOrWhiteSpace(regio.name) ? "" : regio.name;
                                entity.EmailKNLTB = string.IsNullOrWhiteSpace(regio.emailaddress1) ? "" : regio.emailaddress1;
                                entity.TelefoonOverdag = string.IsNullOrWhiteSpace(regio.telephone1) ? "" : regio.telephone1;
                                entity.TelefoonAvond = string.IsNullOrWhiteSpace(regio.telephone2) ? "" : regio.telephone2;
                                entity.Fax = string.IsNullOrWhiteSpace(regio.fax) ? "" : regio.fax;
                                entity.Actief = (ActiefSoort)regio.statuscode.Value;

                                beheerModel.ClubCloud_Regios.AddOrUpdate(entity);

                                beheerModel.SaveChanges();

                                if (regio.address1_addressid != null)
                                {
                                    ClubCloud_Address bezoek = GetAddressById(bondsnummer, regio.address1_addressid.Value, false, settings);
                                    if(bezoek != null)
                                        entity.ClubCloud_Address.Add(bezoek);
                                }

                                if (regio.address2_addressid != null)
                                {
                                    ClubCloud_Address post = GetAddressById(bondsnummer, regio.address2_addressid.Value, false, settings);
                                    if (post != null)
                                        entity.ClubCloud_Address.Add(post);
                                }

                                beheerModel.SaveChanges();
                            }
                            
                        }
                    }

                }
                entity = beheerModel.ClubCloud_Regios.Find(Id);
            }
            return entity;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="refresh"></param>
        /// <returns></returns>
        private List<ClubCloud_Regio> GetRegios(string bondsnummer, bool refresh = false, ClubCloud_Setting settings = null)
        {
            List<ClubCloud_Regio> regios = new List<ClubCloud_Regio>();

            regios = beheerModel.ClubCloud_Regios.ToList();

            if (regios == null || regios.Count == 0 || refresh)
            {
                if (settings == null)
                {
                    settings = GetSettings(bondsnummer);
                }

                if (settings != null && settings.Access && !string.IsNullOrWhiteSpace(settings.Password))
                {
                    CookieContainer cc = RequestContainer(settings.Id.ToString(), settings.Password);

                    if (cc != null)
                    {
                        using (ClubCloud.KNLTB.ServIt.CrmService.CrmService service = CrmServices[settings.Id.ToString()])
                        {
                            bool moreRecords = true;
                            int pageNum = 1;
                            while (moreRecords)
                            {
                                ConditionExpression condition = new ConditionExpression { AttributeName = "sgt_regio", Operator = ConditionOperator.Equal, Values = new object[1] { true } };
                                FilterExpression expression = new FilterExpression { FilterOperator = LogicalOperator.And, Conditions = new ConditionExpression[1] { condition } };

                                List<BusinessEntity> entities = RetrieveMultiple(service, "account", out moreRecords, ref pageNum, expression);

                                foreach (account regio in entities)
                                {
                                    ClubCloud_Regio entity = beheerModel.ClubCloud_Regios.Find(regio.accountid.Value);

                                    if (entity == null)
                                        entity = beheerModel.ClubCloud_Regios.Create();


                                    entity.Id = regio.accountid.Value;
                                    entity.Naam = string.IsNullOrWhiteSpace(regio.name) ? "" : regio.name; //entity.name;
                                    entity.EmailKNLTB = string.IsNullOrWhiteSpace(regio.emailaddress1) ? "" : regio.emailaddress1; //entity.emailaddress1;
                                    entity.TelefoonOverdag = string.IsNullOrWhiteSpace(regio.telephone1) ? "" : regio.telephone1; //entity.telephone1;
                                    entity.TelefoonAvond = string.IsNullOrWhiteSpace(regio.telephone2) ? "" : regio.telephone2; //entity.telephone2;
                                    entity.Fax = string.IsNullOrWhiteSpace(regio.fax) ? "" : regio.fax; //entity.fax;
                                    entity.Actief = (ActiefSoort)regio.statuscode.Value;

                                    beheerModel.ClubCloud_Regios.AddOrUpdate(entity);
                                }

                                beheerModel.SaveChanges();

                                foreach (account regio in entities)
                                {
                                    ClubCloud_Regio entity = beheerModel.ClubCloud_Regios.Find(regio.accountid.Value);

                                    if (regio.address1_addressid != null)
                                    {
                                        ClubCloud_Address bezoek = GetAddressById(bondsnummer, regio.address1_addressid.Value, false, settings);
                                        if (bezoek != null)
                                            entity.ClubCloud_Address.Add(bezoek);
                                    }

                                    if (regio.address2_addressid != null)
                                    {
                                        ClubCloud_Address post = GetAddressById(bondsnummer, regio.address2_addressid.Value, false, settings);
                                        if (post != null)
                                            entity.ClubCloud_Address.Add(post);
                                    }
                                }

                                beheerModel.SaveChanges();
                            }
                        }
                    }
                }
                regios = beheerModel.ClubCloud_Regios.ToList();
            }
            return regios;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="entity"></param>
        /// <param name="settings"></param>
        /// <returns></returns>
        private ClubCloud_Regio SetRegio(string bondsnummer, ClubCloud_Regio entity, ClubCloud_Setting settings)
        {
            if (entity.Id == Guid.Empty)
                entity.Id = Guid.NewGuid();

            return entity;
        }

        private List<ClubCloud_Vereniging> GetVerenigingenForRegio(string bondsnummer, ClubCloud_Regio entity, bool refresh, ClubCloud_Setting settings)
        {
            throw new NotImplementedException();
        }

        private List<ClubCloud_Vereniging> GetVerenigingenForRegioById(string bondsnummer, Guid Id, bool refresh, ClubCloud_Setting settings)
        {
            throw new NotImplementedException();
        }

        private List<ClubCloud_District> GetDistrictenForRegio(string bondsnummer, ClubCloud_Regio entity, bool refresh, ClubCloud_Setting settings)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// sgt_alg_district
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="regioId"></param>
        /// <param name="refresh"></param>
        /// <returns></returns>
        private ClubCloud_District GetDistrictByRegio(string bondsnummer, Guid regioId, bool refresh = false, ClubCloud_Setting settings = null)
        {
            ClubCloud_District district = new ClubCloud_District();

            district = beheerModel.ClubCloud_Districten.SingleOrDefault(d => d.RegioId == regioId);

            if (district == null || refresh)
            {
                if (settings == null)
                {
                    settings = GetSettings(bondsnummer);
                }

                if (settings != null && settings.Access && !string.IsNullOrWhiteSpace(settings.Password))
                {
                    CookieContainer cc = RequestContainer(settings.Id.ToString(), settings.Password);

                    if (cc != null)
                    {
                        using (ClubCloud.KNLTB.ServIt.CrmService.CrmService service = CrmServices[settings.Id.ToString()])
                        {
                            bool moreRecords = true;
                            int pageNum = 1;
                            while (moreRecords)
                            {
                                ConditionExpression condition = new ConditionExpression { AttributeName = "sgt_regioid", Operator = ConditionOperator.Equal, Values = new object[1] { regioId } };
                                FilterExpression expression = new FilterExpression { FilterOperator = LogicalOperator.And, Conditions = new ConditionExpression[1] { condition } };

                                List<BusinessEntity> entities = RetrieveMultiple(service, "sgt_alg_district", out moreRecords, ref pageNum, expression);

                                foreach (sgt_alg_district entity in entities)
                                {
                                    district = beheerModel.ClubCloud_Districten.Find(entity.sgt_alg_districtid.Value);

                                    if (district == null)
                                        district = beheerModel.ClubCloud_Districten.Create();

                                    district.Id = entity.sgt_alg_districtid.Value;
                                    district.Beschrijving = entity.sgt_beschrijving;
                                    district.Naam = entity.sgt_alg_district1;
                                    district.Omschrijving = entity.sgt_omschrijving;
                                    district.Beschrijving = entity.sgt_beschrijving;

                                    if (entity.sgt_regioid != null)
                                    {
                                        district.RegioId = entity.sgt_regioid.Value;
                                    }

                                    district.Actief = (ActiefSoort)entity.statuscode.Value;

                                    beheerModel.ClubCloud_Districten.AddOrUpdate(district);
                                }

                                beheerModel.SaveChanges();

                                foreach (sgt_alg_district entity in entities)
                                {
                                    district = beheerModel.ClubCloud_Districten.Find(entity.sgt_alg_districtid.Value);

                                    if (entity.sgt_regioid != null)
                                    {
                                        ClubCloud_Regio regio = GetRegioById(bondsnummer, entity.sgt_regioid.Value, false);
                                        district.ClubCloud_Regio = regio;
                                    }
                                }

                                beheerModel.SaveChanges();
                            }
                        }
                    }
                }
                district = beheerModel.ClubCloud_Districten.SingleOrDefault(d => d.RegioId == regioId);
            }
            return district;
        }

        private List<ClubCloud_District> GetDistrictenForRegioById(string bondsnummer, Guid Id, bool refresh, ClubCloud_Setting settings)
        {
            throw new NotImplementedException();
        }

        private List<ClubCloud_Accommodatie> GetAccommodatiesForRegio(string bondsnummer, ClubCloud_Regio entity, bool refresh, ClubCloud_Setting settings)
        {
            throw new NotImplementedException();
        }

        private List<ClubCloud_Accommodatie> GetAccommodatiesForRegioById(string bondsnummer, Guid Id, bool refresh, ClubCloud_Setting settings)
        {
            throw new NotImplementedException();
        }

        private List<ClubCloud_Address> GetAddressenForRegio(string bondsnummer, ClubCloud_Regio entity, bool refresh, ClubCloud_Setting settings)
        {
            throw new NotImplementedException();
        }

        private List<ClubCloud_Address> GetAddressenForRegioById(string bondsnummer, Guid Id, bool refresh, ClubCloud_Setting settings)
        {
            throw new NotImplementedException();
        }

        #endregion

        #region Reservering

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="Id"></param>
        /// <param name="refresh"></param>
        /// <param name="settings"></param>
        /// <returns></returns>
        private ClubCloud_Reservering GetReserveringById(string bondsnummer, Guid Id, bool refresh, ClubCloud_Setting settings)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="refresh"></param>
        /// <param name="settings"></param>
        /// <returns></returns>
        private List<ClubCloud_Reservering> GetReserveringen(string bondsnummer, bool refresh, ClubCloud_Setting settings)
        {
            throw new NotImplementedException();
        }

        public ClubCloud_Baan GetBaanForReserveringById(Guid reserveringId, bool refresh, ClubCloud_Setting settings)
        {
            if (settings != null)
                ValidateSettings(ref settings);

            ClubCloud_Reservering entity = null;
            ClubCloud_Baan result = null;

            try
            {
                entity = beheerModel.ClubCloud_Reserveringen.Find(reserveringId);
                if (entity != null )
                    beheerModel.Entry(entity).Reference(e => e.ClubCloud_Baan).Load();

                result = entity.ClubCloud_Baan;

                if (result == null && entity.BaanId != null)
                    result = beheerModel.ClubCloud_Banen.Find(entity.BaanId.Value);

                if (result != null)
                    return result;

                return new ClubCloud_Baan();
            }
            finally
            {
                if (entity != null)
                    try { beheerModel.ObjectContext.Detach(entity); }
                    catch { }
                if (result != null)
                {
                    try { beheerModel.ObjectContext.Detach(result); }
                    catch { }
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="entity"></param>
        /// <param name="settings"></param>
        /// <returns></returns>
        private ClubCloud_Reservering SetReservering(string bondsnummer, ClubCloud_Reservering entity, ClubCloud_Setting settings)
        {
            if (entity.Id == Guid.Empty)
                entity.Id = Guid.NewGuid();

            return entity;
        }

        #endregion

        #region Setting

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="Id"></param>
        /// <param name="refresh"></param>
        /// <param name="settings"></param>
        /// <returns></returns>
        private ClubCloud_Setting GetSettingById(string bondsnummer, int Id, bool refresh, ClubCloud_Setting settings)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="refresh"></param>
        /// <param name="settings"></param>
        /// <returns></returns>
        private List<ClubCloud_Setting> GetSettings(string bondsnummer, bool refresh, ClubCloud_Setting settings)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="entity"></param>
        /// <param name="settings"></param>
        /// <returns></returns>
        private ClubCloud_Setting SetSetting(string bondsnummer, ClubCloud_Setting entity, ClubCloud_Setting settings)
        {
            if (entity.Id == null)
                entity.Id = int.MaxValue;

            return entity;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="entity"></param>
        /// <param name="refresh"></param>
        /// <param name="settings"></param>
        /// <returns></returns>
        private ClubCloud_Gebruiker GetGebruikerForSetting(string bondsnummer, ClubCloud_Setting entity, bool refresh, ClubCloud_Setting settings)
        {
            throw new NotImplementedException();
        }

        private ClubCloud_Gebruiker GetGebruikerForSettingById(string bondsnummer, int Id, bool refresh, ClubCloud_Setting settings)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="entity"></param>
        /// <param name="refresh"></param>
        /// <param name="settings"></param>
        /// <returns></returns>
        private ClubCloud_Vereniging GetVerenigingForSetting(string bondsnummer, ClubCloud_Setting entity, bool refresh, ClubCloud_Setting settings)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="Id"></param>
        /// <param name="refresh"></param>
        /// <param name="settings"></param>
        /// <returns></returns>
        private ClubCloud_Vereniging GetVerenigingForSettingById(string bondsnummer, int Id, bool refresh, ClubCloud_Setting settings)
        {
            throw new NotImplementedException();
        }

        #endregion

        #region Sponsor

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="Id"></param>
        /// <param name="refresh"></param>
        /// <param name="settings"></param>
        /// <returns></returns>
        private ClubCloud_Sponsor GetSponsorById(string bondsnummer, Guid Id, bool refresh, ClubCloud_Setting settings)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="refresh"></param>
        /// <param name="settings"></param>
        /// <returns></returns>
        private List<ClubCloud_Sponsor> GetSponsoren(string bondsnummer, bool refresh, ClubCloud_Setting settings)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="entity"></param>
        /// <param name="settings"></param>
        /// <returns></returns>
        private ClubCloud_Sponsor SetSponsor(string bondsnummer, ClubCloud_Sponsor entity, ClubCloud_Setting settings)
        {
            if (entity.Id == Guid.Empty)
                entity.Id = Guid.NewGuid();

            return entity;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="entity"></param>
        /// <param name="refresh"></param>
        /// <param name="settings"></param>
        /// <returns></returns>
        private ClubCloud_Vereniging GetVerenigingForSponsor(string bondsnummer, ClubCloud_Sponsor entity, bool refresh, ClubCloud_Setting settings)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="Id"></param>
        /// <param name="refresh"></param>
        /// <param name="settings"></param>
        /// <returns></returns>
        private ClubCloud_Vereniging GetVerenigingForSponsorById(string bondsnummer, Guid Id, bool refresh, ClubCloud_Setting settings)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="entity"></param>
        /// <param name="refresh"></param>
        /// <param name="settings"></param>
        /// <returns></returns>
        private ClubCloud_Sponsor_Afbeelding GetAfbeeldingForSponsor(string bondsnummer, ClubCloud_Sponsor entity, bool refresh, ClubCloud_Setting settings)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="Id"></param>
        /// <param name="refresh"></param>
        /// <param name="settings"></param>
        /// <returns></returns>
        private ClubCloud_Sponsor_Afbeelding GetAfbeeldingForSponsorById(string bondsnummer, Guid Id, bool refresh, ClubCloud_Setting settings)
        {
            throw new NotImplementedException();
        }

        #region Get

        public List<ClubCloud_Sponsor> GetSponsorenByVerenigingId(string bondsnummer, Guid verenigingId, bool refresh)
        {
            List<ClubCloud_Sponsor> sponsoren = new List<ClubCloud_Sponsor>();
            sponsoren = beheerModel.ClubCloud_Sponsoren.Where(f => f.VerenigingId == verenigingId).ToList();
            return sponsoren;
        }
        /*
        public ClubCloud_Sponsor GetSponsorById(string bondsnummer, Guid verenigingId, Guid sponsorId, bool refresh)
        {
            ClubCloud_Sponsor sponsor = new ClubCloud_Sponsor();
            sponsor = beheerModel.ClubCloud_Sponsoren.Find(sponsorId);//.Where(f => f.VerenigingId == verenigingId).ToList();
            return sponsor;
        }
        */

        public ClubCloud_Sponsor_Afbeelding GetSponsorImageById(string bondsnummer, Guid verenigingId, Guid afbeeldingId, bool refresh)
        {
            ClubCloud_Sponsor_Afbeelding afbeelding = new ClubCloud_Sponsor_Afbeelding();
            afbeelding = beheerModel.ClubCloud_Sponsor_Afbeeldingen.Find(afbeeldingId);
            return afbeelding;
        }

        public List<ClubCloud_Sponsor> GetSponsorImageUsageById(string bondsnummer, Guid verenigingId, Guid imageId, bool refresh)
        {
            List<ClubCloud_Sponsor> sponsoren = new List<ClubCloud_Sponsor>();
            sponsoren = beheerModel.ClubCloud_Sponsoren.Where(f => f.AfbeeldingId == imageId).ToList();
            return sponsoren;
        }

        #endregion

        #region Set
        /*
        public ClubCloud_Sponsor SetSponsor(ClubCloud_Sponsor sponsor)
        {
            ClubCloud_Sponsor tobeupdated = beheerModel.ClubCloud_Sponsoren.Find(sponsor.Id);

            if (tobeupdated != null)
            {
                beheerModel.Entry(tobeupdated).CurrentValues.SetValues(sponsor);
                beheerModel.SaveChanges();
            }
            tobeupdated = beheerModel.ClubCloud_Sponsoren.Find(sponsor.Id);
            return tobeupdated;
        }
        */

        public ClubCloud_Sponsor_Afbeelding SetSponsorImage(ClubCloud_Sponsor_Afbeelding afbeelding)
        {
            ClubCloud_Sponsor_Afbeelding tobeupdated = beheerModel.ClubCloud_Sponsor_Afbeeldingen.Find(afbeelding.Id);

            if (tobeupdated != null)
            {
                beheerModel.Entry(tobeupdated).CurrentValues.SetValues(afbeelding);
                beheerModel.SaveChanges();
            }
            tobeupdated = beheerModel.ClubCloud_Sponsor_Afbeeldingen.Find(afbeelding.Id);
            return tobeupdated;
        }

        #endregion

        #region Delete
        /*
        public bool DeleteSponsor(ClubCloud_Sponsor sponsor)
        {
            bool succes = true;
            try
            {
                bool removeimage = false;

                if (sponsor.AfbeeldingId.HasValue)
                {
                    removeimage = true;
                    List<ClubCloud_Sponsor> sponsoren = new List<ClubCloud_Sponsor>();
                    sponsoren = beheerModel.ClubCloud_Sponsoren.Where(f => f.AfbeeldingId == sponsor.AfbeeldingId && f.Id != sponsor.Id).ToList();
                    if (sponsoren != null && sponsoren.Count > 0)
                    {
                        removeimage = false;
                    }

                }
                ClubCloud_Sponsor toberemoved = beheerModel.ClubCloud_Sponsoren.Find(sponsor.Id);
                beheerModel.ClubCloud_Sponsoren.Remove(toberemoved);
                beheerModel.SaveChanges();

                if (removeimage)
                {
                    ClubCloud_Sponsor_Afbeelding afbeelding = beheerModel.ClubCloud_Sponsor_Afbeeldingen.Find(sponsor.AfbeeldingId);
                    beheerModel.ClubCloud_Sponsor_Afbeeldingen.Remove(afbeelding);
                    beheerModel.SaveChanges();
                }
            }
            catch { succes = false; }

            return succes;

        }
        */
        public bool DeleteSponsorImage(ClubCloud_Sponsor_Afbeelding afbeelding)
        {
            bool succes = true;
            try
            {
                bool removeimage = true;

                List<ClubCloud_Sponsor> sponsoren = new List<ClubCloud_Sponsor>();
                sponsoren = beheerModel.ClubCloud_Sponsoren.Where(f => f.AfbeeldingId == afbeelding.Id).ToList();
                if (sponsoren != null && sponsoren.Count > 0)
                {
                    removeimage = false;
                }

                if (removeimage)
                {
                    ClubCloud_Sponsor_Afbeelding toberemoved = beheerModel.ClubCloud_Sponsor_Afbeeldingen.Find(afbeelding.Id);
                    beheerModel.ClubCloud_Sponsor_Afbeeldingen.Remove(toberemoved);
                    beheerModel.SaveChanges();
                }
                succes = removeimage;
            }
            catch { succes = false; }

            return succes;
        }

        #endregion

        #endregion

        #region Vereniging

        /// <summary>
        /// account
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="Id"></param>
        /// <param name="refresh"></param>
        /// <returns></returns>
        private ClubCloud_Vereniging GetVerenigingById(string bondsnummer, Guid Id, bool refresh = false, ClubCloud_Setting settings = null)
        {
            ClubCloud_Vereniging entity = null;

            entity = beheerModel.ClubCloud_Verenigingen.Find(Id);

            if (entity == null || refresh)
            {
                if (settings == null)
                    settings = GetSettings(bondsnummer);

                if (settings != null && settings.Access && !string.IsNullOrWhiteSpace(settings.Password))
                {
                    CookieContainer cc = RequestContainer(settings.Id.ToString(), settings.Password);

                    if (cc != null)
                    {
                        using (ClubCloud.KNLTB.ServIt.CrmService.CrmService service = CrmServices[settings.Id.ToString()])
                        {
                            account account = RetrieveEntity(service, "account", Id) as account;

                            if (account != null && account.accountid.Value == Id)
                            {
                                if (entity == null)
                                    entity = beheerModel.ClubCloud_Verenigingen.Create();

                                entity.Id = account.accountid.Value;

                                VerenigingToEntity(account, entity, settings);

                                beheerModel.ClubCloud_Verenigingen.AddOrUpdate(entity);

                                beheerModel.SaveChanges();

                                if (account.sgt_districtid != null)
                                {
                                    ClubCloud_District district = GetDistrictById(account.sgt_districtid.Value, false, settings);
                                    entity.ClubCloud_District = district;
                                }

                                if (account.sgt_rechtsvormid != null)
                                {
                                    ClubCloud_Rechtsvorm rechtsvorm = GetRechtsvormById(account.sgt_rechtsvormid.Value, false, settings);
                                    entity.ClubCloud_Rechtsvorm = rechtsvorm;
                                }

                                if (account.sgt_hoofdaccomodatieid != null)
                                {
                                    ClubCloud_Accommodatie Accommodatie = GetAccommodatieById(account.sgt_hoofdaccomodatieid.Value, false, settings);
                                    entity.ClubCloud_Accommodatie = Accommodatie;
                                }

                                if (account.parentaccountid != null)
                                {
                                    ClubCloud_Regio regio = GetRegioById(account.parentaccountid.Value, false, settings);
                                    entity.ClubCloud_Regio = regio;
                                }

                                if (account.address1_addressid != null)
                                {
                                    ClubCloud_Address bezoek = GetAddressById(account.address1_addressid.Value, false, settings);
                                    entity.ClubCloud_Address.Add(bezoek);
                                }

                                if (account.address2_addressid != null)
                                {
                                    ClubCloud_Address post = GetAddressById(account.address2_addressid.Value, false, settings);
                                    entity.ClubCloud_Address.Add(post);
                                }

                                beheerModel.SaveChanges();

                                CreateOrUpdateMembershipVereniging(entity, settings);

                            }
                        }
                    }
                }
                entity = beheerModel.ClubCloud_Verenigingen.Find(Id);
            }
            return entity;

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="refresh"></param>
        /// <param name="settings"></param>
        /// <returns></returns>
        private List<ClubCloud_Vereniging> GetVerenigingen(string bondsnummer, bool refresh, ClubCloud_Setting settings)
        {
            List<ClubCloud_Vereniging> verenigingen = new List<ClubCloud_Vereniging>();

            verenigingen = beheerModel.ClubCloud_Verenigingen.ToList();

            if (verenigingen == null || verenigingen.Count == 0 || refresh)
            {
                if (settings == null)
                {
                    settings = GetSettings(bondsnummer);
                }
                if (settings != null && settings.Access && !string.IsNullOrWhiteSpace(settings.Password))
                {
                    CookieContainer cc = RequestContainer(settings.Id.ToString(), settings.Password);

                    if (cc != null)
                    {
                        using (ClubCloud.KNLTB.ServIt.CrmService.CrmService service = CrmServices[settings.Id.ToString()])
                        {
                            bool moreRecords = true;
                            int pageNum = 1;
                            while (moreRecords)
                            {
                                ConditionExpression condition = new ConditionExpression { AttributeName = "sgt_vereniging", Operator = ConditionOperator.Equal, Values = new object[1] { true } };
                                FilterExpression expression = new FilterExpression { FilterOperator = LogicalOperator.And, Conditions = new ConditionExpression[1] { condition } };

                                List<BusinessEntity> entities = RetrieveMultiple(service, "account", out moreRecords, ref pageNum, expression);

                                foreach (account entity in entities)
                                {
                                    ClubCloud_Vereniging vereniging = beheerModel.ClubCloud_Verenigingen.Find(entity.accountid.Value);

                                    if (vereniging == null)
                                        vereniging = beheerModel.ClubCloud_Verenigingen.Create();

                                    vereniging.Id = entity.accountid.Value;

                                    VerenigingToEntity(entity, vereniging, settings);

                                    beheerModel.ClubCloud_Verenigingen.AddOrUpdate(vereniging);
                                }
                                beheerModel.SaveChanges();

                                foreach (account account in entities)
                                {
                                    ClubCloud_Vereniging entity = beheerModel.ClubCloud_Verenigingen.Find(account.accountid.Value);

                                    if (account.sgt_districtid != null)
                                    {
                                        ClubCloud_District district = GetDistrictById(account.sgt_districtid.Value, false, settings);
                                        entity.ClubCloud_District = district;
                                    }

                                    if (account.sgt_rechtsvormid != null)
                                    {
                                        ClubCloud_Rechtsvorm rechtsvorm = GetRechtsvormById(account.sgt_rechtsvormid.Value, false, settings);
                                        entity.ClubCloud_Rechtsvorm = rechtsvorm;
                                    }

                                    if (account.sgt_hoofdaccomodatieid != null)
                                    {
                                        ClubCloud_Accommodatie Accommodatie = GetAccommodatieById(account.sgt_hoofdaccomodatieid.Value, false, settings);
                                        entity.ClubCloud_Accommodatie = Accommodatie;
                                    }

                                    if (account.parentaccountid != null)
                                    {
                                        ClubCloud_Regio regio = GetRegioById(account.parentaccountid.Value, false, settings);
                                        entity.ClubCloud_Regio = regio;
                                    }

                                    if (account.address1_addressid != null)
                                    {
                                        ClubCloud_Address bezoek = GetAddressById(account.address1_addressid.Value, false, settings);
                                        entity.ClubCloud_Address.Add(bezoek);
                                    }

                                    if (account.address2_addressid != null)
                                    {
                                        ClubCloud_Address post = GetAddressById(account.address2_addressid.Value, false, settings);
                                        entity.ClubCloud_Address.Add(post);
                                    }
                                }

                                beheerModel.SaveChanges();

                                foreach (account account in entities)
                                {
                                    ClubCloud_Vereniging entity = beheerModel.ClubCloud_Verenigingen.Find(account.accountid.Value);

                                    CreateOrUpdateMembershipVereniging(entity, settings);
                                }

                            }
                        }
                    }
                }
                verenigingen = beheerModel.ClubCloud_Verenigingen.ToList();
            }
            return verenigingen;

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="entity"></param>
        /// <param name="settings"></param>
        /// <returns></returns>
        private ClubCloud_Vereniging SetVereniging(string bondsnummer, ClubCloud_Vereniging entity, ClubCloud_Setting settings)
        {
            if (entity.Id == Guid.Empty)
                entity.Id = Guid.NewGuid();

            return entity;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="entity"></param>
        /// <param name="refresh"></param>
        /// <param name="settings"></param>
        /// <returns></returns>
        private List<ClubCloud_Functionaris> GetFunctionarissenForVereniging(string bondsnummer, ClubCloud_Vereniging entity, bool refresh, ClubCloud_Setting settings)
        {
            return GetFunctionarissenForVerenigingById(bondsnummer, entity.Id, refresh, settings);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="Id"></param>
        /// <param name="refresh"></param>
        /// <param name="settings"></param>
        /// <returns></returns>
        private List<ClubCloud_Functionaris> GetFunctionarissenForVerenigingById(string bondsnummer, Guid Id, bool refresh, ClubCloud_Setting settings)
        {
            List<ClubCloud_Functionaris> result = null;

            ClubCloud_Vereniging vereniging = beheerModel.ClubCloud_Verenigingen.Find(Id);
            if (vereniging != null)
            {
                if (vereniging.ClubCloud_Functionaris == null || vereniging.ClubCloud_Functionaris.Count == 0)
                {
                    result = beheerModel.ClubCloud_Functionarissen.Where(v => v.VerenigingId.Value == Id).ToList();

                    foreach (ClubCloud_Functionaris functionaris in result)
                    {
                        vereniging.ClubCloud_Functionaris.Add(functionaris);
                    }
                    beheerModel.SaveChanges();
                }

            }
            return result;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="entity"></param>
        /// <param name="refresh"></param>
        /// <param name="settings"></param>
        /// <returns></returns>
        private List<ClubCloud_Lidmaatschap> GetLidmaatschappenForVereniging(string bondsnummer, ClubCloud_Vereniging entity, bool refresh, ClubCloud_Setting settings)
        {
            return GetLidmaatschappenForVerenigingById(bondsnummer, entity.Id, refresh, settings);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="Id"></param>
        /// <param name="refresh"></param>
        /// <param name="settings"></param>
        /// <returns></returns>
        private List<ClubCloud_Lidmaatschap> GetLidmaatschappenForVerenigingById(string bondsnummer, Guid Id, bool refresh, ClubCloud_Setting settings)
        {
            List<ClubCloud_Lidmaatschap> result = null;

            ClubCloud_Vereniging vereniging = beheerModel.ClubCloud_Verenigingen.Find(Id);
            if (vereniging != null)
            {
                if (vereniging.ClubCloud_Lidmaatschap == null || vereniging.ClubCloud_Lidmaatschap.Count == 0)
                {
                    result = beheerModel.ClubCloud_Lidmaatschappen.Where(v => v.VerenigingId.Value == Id).ToList();

                    foreach (ClubCloud_Lidmaatschap lidmaatschap in result)
                    {
                        vereniging.ClubCloud_Lidmaatschap.Add(lidmaatschap);
                    }
                    beheerModel.SaveChanges();
                }

            }
            return result;
        }

        private List<ClubCloud_Lidmaatschapsoort> GetLidmaatschapsoortenForVereniging(string bondsnummer, ClubCloud_Vereniging entity, bool refresh, ClubCloud_Setting settings)
        {
            return GetLidmaatschapsoortenForVerenigingById(bondsnummer, entity.Id, refresh, settings);
        }

        private List<ClubCloud_Lidmaatschapsoort> GetLidmaatschapsoortenForVerenigingById(string bondsnummer, Guid Id, bool refresh, ClubCloud_Setting settings)
        {
            List<ClubCloud_Lidmaatschapsoort> result = null;

            ClubCloud_Vereniging vereniging = beheerModel.ClubCloud_Verenigingen.Find(Id);
            if (vereniging != null)
            {
                if (vereniging.ClubCloud_Lidmaatschapsoort == null || vereniging.ClubCloud_Lidmaatschapsoort.Count == 6)
                {
                    result = beheerModel.ClubCloud_Lidmaatschapsoorten.Where(v => v.VerenigingId.Value == Id || v.VerenigingId == null).ToList();

                    foreach (ClubCloud_Lidmaatschapsoort lidmaatschapsoort in result)
                    {
                        if(lidmaatschapsoort.VerenigingId != null)
                            vereniging.ClubCloud_Lidmaatschapsoort.Add(lidmaatschapsoort);
                    }
                    beheerModel.SaveChanges();
                }

            }
            return result;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="entity"></param>
        /// <param name="refresh"></param>
        /// <param name="settings"></param>
        /// <returns></returns>
        private List<ClubCloud_Bestuursorgaan> GetBestuursorganenForVereniging(string bondsnummer, ClubCloud_Vereniging entity, bool refresh, ClubCloud_Setting settings)
        {
            return GetBestuursorganenForVerenigingById(bondsnummer, entity.Id, refresh, settings);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="Id"></param>
        /// <param name="refresh"></param>
        /// <param name="settings"></param>
        /// <returns></returns>
        private List<ClubCloud_Bestuursorgaan> GetBestuursorganenForVerenigingById(string bondsnummer, Guid Id, bool refresh, ClubCloud_Setting settings)
        {
            List<ClubCloud_Bestuursorgaan> result = null;

            ClubCloud_Vereniging vereniging = beheerModel.ClubCloud_Verenigingen.Find(Id);
            if (vereniging != null)
            {
                if (vereniging.ClubCloud_Bestuursorgaan == null || vereniging.ClubCloud_Bestuursorgaan.Count == 0)
                {
                    result = beheerModel.ClubCloud_Bestuursorganen.Where(v => v.VerenigingId.Value == Id).ToList();

                    foreach (ClubCloud_Bestuursorgaan bestuursorgaan in result)
                    {
                        vereniging.ClubCloud_Bestuursorgaan.Add(bestuursorgaan);
                    }
                    beheerModel.SaveChanges();
                }

            }
            return result;
        }

        /// <summary>
        /// sgt_alg_bestuursorgaan
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="verenigingId"></param>
        /// <param name="refresh"></param>
        /// <returns></returns>
        private List<ClubCloud_Bestuursorgaan> GetBestuursOrgaanByVereniging(string bondsnummer, Guid verenigingId, bool refresh = false, ClubCloud_Setting settings = null)
        {
            List<ClubCloud_Bestuursorgaan> bestuursorganen = new List<ClubCloud_Bestuursorgaan>();

            bestuursorganen = beheerModel.ClubCloud_Bestuursorganen.Where(b => b.VerenigingId == verenigingId).ToList();

            if (bestuursorganen != null && bestuursorganen.Count == 0 || refresh)
            {
                if (settings == null)
                    settings = GetSettings(bondsnummer);

                if (settings != null && settings.Access && !string.IsNullOrWhiteSpace(settings.Password))
                {
                    CookieContainer cc = RequestContainer(settings.Id.ToString(), settings.Password);

                    if (cc != null)
                    {
                        using (ClubCloud.KNLTB.ServIt.CrmService.CrmService service = CrmServices[settings.Id.ToString()])
                        {
                            bool moreRecords = true;
                            int pageNum = 1;
                            while (moreRecords)
                            {
                                ConditionExpression condition = new ConditionExpression { AttributeName = "sgt_basisorganisatieid", Operator = ConditionOperator.Equal, Values = new object[1] { verenigingId } };
                                FilterExpression expression = new FilterExpression { FilterOperator = LogicalOperator.And, Conditions = new ConditionExpression[1] { condition } };

                                List<BusinessEntity> entities = RetrieveMultiple(service, "sgt_alg_bestuursorgaan", out moreRecords, ref pageNum, expression);

                                foreach (sgt_alg_bestuursorgaan entity in entities)
                                {
                                    ClubCloud_Bestuursorgaan bestuursorgaan = beheerModel.ClubCloud_Bestuursorganen.Find(entity.sgt_alg_bestuursorgaanid.Value);

                                    if (bestuursorgaan == null)
                                        bestuursorgaan = beheerModel.ClubCloud_Bestuursorganen.Create();

                                    bestuursorgaan.Id = entity.sgt_alg_bestuursorgaanid.Value;
                                    bestuursorgaan.Naam = entity.sgt_alg_bestuursorgaan1;
                                    bestuursorgaan.Beschrijving = string.IsNullOrWhiteSpace(entity.sgt_beschrijving) ? "" : entity.sgt_beschrijving;

                                    if (entity.sgt_basisorganisatieid != null)
                                    {
                                        //ClubCloud_Vereniging vereniging = GetVerenigingById(bondsnummer, entity.sgt_basisorganisatieid.Value, false, settings);
                                        //if (vereniging != null)
                                        //    bestuursorgaan.ClubCloud_Vereniging = vereniging;

                                        bestuursorgaan.VerenigingId = entity.sgt_basisorganisatieid.Value;
                                    }

                                    if (entity.sgt_typebestuursorgaanid != null)
                                    {
                                        bestuursorgaan.Groep = string.IsNullOrWhiteSpace(entity.sgt_typebestuursorgaanid.name) ? "" : entity.sgt_typebestuursorgaanid.name;
                                    }
                                    else
                                    {
                                        bestuursorgaan.Groep = "";
                                    }
                                    bestuursorgaan.Actief = (ActiefSoort)entity.statuscode.Value;

                                    beheerModel.ClubCloud_Bestuursorganen.AddOrUpdate(bestuursorgaan);
                                    
                                }

                                beheerModel.SaveChanges();

                                foreach (sgt_alg_bestuursorgaan entity in entities)
                                {
                                    ClubCloud_Bestuursorgaan bestuursorgaan = beheerModel.ClubCloud_Bestuursorganen.Find(entity.sgt_alg_bestuursorgaanid.Value);

                                    if (entity.sgt_basisorganisatieid != null)
                                    {
                                        ClubCloud_Vereniging vereniging = GetVerenigingById(bondsnummer, entity.sgt_basisorganisatieid.Value, false, settings);
                                        if (vereniging != null)
                                            bestuursorgaan.ClubCloud_Vereniging = vereniging;

                                        bestuursorgaan.VerenigingId = entity.sgt_basisorganisatieid.Value;
                                    }
                                }

                                beheerModel.SaveChanges();

                            }
                        }
                    }

                }
                bestuursorganen = beheerModel.ClubCloud_Bestuursorganen.Where(b => b.VerenigingId == verenigingId).ToList();
            }

            return bestuursorganen;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="entity"></param>
        /// <param name="refresh"></param>
        /// <param name="settings"></param>
        /// <returns></returns>
        private ClubCloud_District GetDistrictForVereniging(string bondsnummer, ClubCloud_Vereniging entity, bool refresh, ClubCloud_Setting settings)
        {
            return GetDistrictForVerenigingById(bondsnummer, entity.Id, refresh, settings);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="Id"></param>
        /// <param name="refresh"></param>
        /// <param name="settings"></param>
        /// <returns></returns>
        private ClubCloud_District GetDistrictForVerenigingById(string bondsnummer, Guid Id, bool refresh, ClubCloud_Setting settings)
        {
            ClubCloud_District result = null;

            ClubCloud_Vereniging vereniging = beheerModel.ClubCloud_Verenigingen.Find(Id);
            if (vereniging != null)
            {
                if (vereniging.ClubCloud_District == null && vereniging.DistrictId != null)
                {
                    result = beheerModel.ClubCloud_Districten.Find(vereniging.DistrictId.Value);

                    if (result != null)
                    {
                        vereniging.ClubCloud_District = result;
                        beheerModel.SaveChanges();
                    }
                }

            }
            return result;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="entity"></param>
        /// <param name="refresh"></param>
        /// <param name="settings"></param>
        /// <returns></returns>
        private ClubCloud_Rechtsvorm GetRechtsvormForVereniging(string bondsnummer, ClubCloud_Vereniging entity, bool refresh, ClubCloud_Setting settings)
        {
            return GetRechtsvormForVerenigingById(bondsnummer, entity.Id, refresh, settings);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="Id"></param>
        /// <param name="refresh"></param>
        /// <param name="settings"></param>
        /// <returns></returns>
        private ClubCloud_Rechtsvorm GetRechtsvormForVerenigingById(string bondsnummer, Guid Id, bool refresh, ClubCloud_Setting settings)
        {
            ClubCloud_Rechtsvorm result = null;

            ClubCloud_Vereniging vereniging = beheerModel.ClubCloud_Verenigingen.Find(Id);
            if (vereniging != null)
            {
                if (vereniging.ClubCloud_Rechtsvorm == null && vereniging.RechtsvormId != null)
                {
                    result = beheerModel.ClubCloud_Rechtsvormen.Find(vereniging.RechtsvormId.Value);

                    if (result != null)
                    {
                        vereniging.ClubCloud_Rechtsvorm = result;
                        beheerModel.SaveChanges();
                    }
                }

            }
            return result;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="entity"></param>
        /// <param name="refresh"></param>
        /// <param name="settings"></param>
        /// <returns></returns>
        private ClubCloud_Accommodatie GetAccommodatieForVereniging(string bondsnummer, ClubCloud_Vereniging entity, bool refresh, ClubCloud_Setting settings)
        {
            return GetAccommodatieForVerenigingById(bondsnummer, entity.Id, refresh, settings);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="Id"></param>
        /// <param name="refresh"></param>
        /// <param name="settings"></param>
        /// <returns></returns>
        private ClubCloud_Accommodatie GetAccommodatieForVerenigingById(string bondsnummer, Guid Id, bool refresh, ClubCloud_Setting settings)
        {
            ClubCloud_Accommodatie result = null;

            ClubCloud_Vereniging vereniging = beheerModel.ClubCloud_Verenigingen.Find(Id);
            if (vereniging != null)
            {
                if (vereniging.ClubCloud_Accommodatie == null && vereniging.AccommodatieId != null)
                {
                    result = beheerModel.ClubCloud_Accommodaties.Find(vereniging.AccommodatieId.Value);

                    if (result != null)
                    {
                        result.ClubCloud_Vereniging.Add(vereniging);
                        //vereniging.ClubCloud_Accommodatie = result;
                        beheerModel.SaveChanges();
                    }
                }

            }
            return result;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="entity"></param>
        /// <param name="refresh"></param>
        /// <param name="settings"></param>
        /// <returns></returns>
        private List<ClubCloud_Address> GetAddressenForVereniging(string bondsnummer, ClubCloud_Vereniging entity, bool refresh, ClubCloud_Setting settings)
        {
            return GetAddressenForVerenigingById(bondsnummer, entity.Id, refresh, settings);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="Id"></param>
        /// <param name="refresh"></param>
        /// <param name="settings"></param>
        /// <returns></returns>
        private List<ClubCloud_Address> GetAddressenForVerenigingById(string bondsnummer, Guid Id, bool refresh, ClubCloud_Setting settings)
        {
            List<ClubCloud_Address> result = null;

            ClubCloud_Vereniging vereniging = beheerModel.ClubCloud_Verenigingen.Find(Id);
            if (vereniging != null)
            {
                if (vereniging.ClubCloud_Address == null || vereniging.ClubCloud_Address.Count == 0)
                {
                    result = beheerModel.ClubCloud_Addressen.Where(v => v.ParentId.Value == Id).ToList();

                    foreach (ClubCloud_Address address in result)
                    {
                        address.ClubCloud_Vereniging = vereniging;
                        //vereniging.ClubCloud_Address.Add(address);
                    }
                    beheerModel.SaveChanges();
                }

                if (refresh)
                {
                    if (settings == null)
                        settings = GetSettings(bondsnummer);

                    if (settings != null && settings.Access && !string.IsNullOrWhiteSpace(settings.Password))
                    {
                        CookieContainer cc = RequestContainer(settings.Id.ToString(), settings.Password);

                        if (cc != null)
                        {
                            using (ClubCloud.KNLTB.ServIt.CrmService.CrmService service = CrmServices[settings.Id.ToString()])
                            {
                                bool moreRecords = true;
                                int pageNum = 1;
                                while (moreRecords)
                                {
                                    ConditionExpression condition = new ConditionExpression { AttributeName = "parentid", Operator = ConditionOperator.Equal, Values = new object[1] { Id } };
                                    FilterExpression expression = new FilterExpression { FilterOperator = LogicalOperator.And, Conditions = new ConditionExpression[1] { condition } };

                                    List<BusinessEntity> entities = RetrieveMultiple(service, "customeraddress", out moreRecords, ref pageNum, expression);

                                    foreach (customeraddress address in entities)
                                    {
                                        ClubCloud_Address entity = beheerModel.ClubCloud_Addressen.Find(address.customeraddressid.Value);

                                        if (entity == null)
                                            entity = beheerModel.ClubCloud_Addressen.Create();

                                        entity.Id = address.customeraddressid.Value;

                                        AddressToEntity(address, entity, settings);

                                        beheerModel.ClubCloud_Addressen.AddOrUpdate(entity);
                                    }
                                    beheerModel.SaveChanges();

                                    foreach (customeraddress address in entities)
                                    {
                                        ClubCloud_Address entity = beheerModel.ClubCloud_Addressen.Find(address.customeraddressid.Value);

                                        Guid landid;
                                        if (Guid.TryParse(address.country, out landid))
                                        {
                                            ClubCloud_Land land = beheerModel.ClubCloud_Landen.Find(landid);
                                            if (land != null)
                                                entity.ClubCloud_Land = land;
                                        }
                                    }

                                    beheerModel.SaveChanges();
                                }
                                
                            }
                        }
                    }

                    result = beheerModel.ClubCloud_Addressen.Where(v => v.ParentId.Value == Id).ToList();

                    foreach (ClubCloud_Address address in result)
                    {
                        vereniging.ClubCloud_Address.Add(address);
                    }
                    beheerModel.SaveChanges();
                }
            }
            return result;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="entity"></param>
        /// <param name="refresh"></param>
        /// <param name="settings"></param>
        /// <returns></returns>
        private ClubCloud_Regio GetRegioForVereniging(string bondsnummer, ClubCloud_Vereniging entity, bool refresh, ClubCloud_Setting settings)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="Id"></param>
        /// <param name="refresh"></param>
        /// <param name="settings"></param>
        /// <returns></returns>
        private ClubCloud_Regio GetRegioForVerenigingById(string bondsnummer, Guid Id, bool refresh, ClubCloud_Setting settings)
        {
            ClubCloud_Regio result = null;

            ClubCloud_Vereniging vereniging = beheerModel.ClubCloud_Verenigingen.Find(Id);
            if (vereniging != null)
            {
                if (vereniging.ClubCloud_Regio == null && vereniging.RegioId != null)
                {
                    result = beheerModel.ClubCloud_Regios.Find(vereniging.RegioId.Value);

                    if (result != null)
                    {
                        vereniging.ClubCloud_Regio = result;
                        beheerModel.SaveChanges();
                    }
                }

            }
            return result;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="entity"></param>
        /// <param name="refresh"></param>
        /// <param name="settings"></param>
        /// <returns></returns>
        private List<ClubCloud_Gebruiker> GetGebruikersForVereniging(string bondsnummer, ClubCloud_Vereniging entity, bool refresh, ClubCloud_Setting settings)
        {
            return GetGebruikersForVerenigingById(bondsnummer, entity.Id, refresh, settings);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="Id"></param>
        /// <param name="refresh"></param>
        /// <param name="settings"></param>
        /// <returns></returns>
        private List<ClubCloud_Gebruiker> GetGebruikersForVerenigingById(string bondsnummer, Guid Id, bool refresh, ClubCloud_Setting settings)
        {
            List<ClubCloud_Gebruiker> result = null;

            ClubCloud_Vereniging vereniging = beheerModel.ClubCloud_Verenigingen.Find(Id);
            if (vereniging != null)
            {
                if (vereniging.ClubCloud_Gebruiker == null || vereniging.ClubCloud_Gebruiker.Count == 0)
                {
                    result = beheerModel.ClubCloud_Gebruikers.Where(v => v.VerenigingId.Value == Id).ToList();

                    foreach (ClubCloud_Gebruiker gebruiker in result)
                    {
                        vereniging.ClubCloud_Gebruiker.Add(gebruiker);
                    }
                    beheerModel.SaveChanges();
                }

                if (refresh)
                {
                    if (settings == null)
                        settings = GetSettings(bondsnummer);

                    if (settings != null && settings.Access && !string.IsNullOrWhiteSpace(settings.Password))
                    {
                        CookieContainer cc = RequestContainer(settings.Id.ToString(), settings.Password);

                        if (cc != null)
                        {
                            using (ClubCloud.KNLTB.ServIt.CrmService.CrmService service = CrmServices[settings.Id.ToString()])
                            {
                                bool moreRecords = true;
                                int pageNum = 1;
                                while (moreRecords)
                                {
                                    ConditionExpression condition = new ConditionExpression { AttributeName = "sgt_primaire_vereniging_id", Operator = ConditionOperator.Equal, Values = new object[1] { vereniging.Id } };
                                    FilterExpression expression = new FilterExpression { FilterOperator = LogicalOperator.And, Conditions = new ConditionExpression[1] { condition } };

                                    List<BusinessEntity> entities = RetrieveMultiple(service, "contact", out moreRecords, ref pageNum, expression);

                                    foreach (contact contact in entities)
                                    {
                                        ClubCloud_Gebruiker entity = beheerModel.ClubCloud_Gebruikers.Find(contact.contactid.Value);

                                        if (entity == null)
                                            entity = beheerModel.ClubCloud_Gebruikers.Create();

                                        entity.Id = contact.contactid.Value;

                                        GebruikerToEntity(contact, entity, settings);

                                        beheerModel.ClubCloud_Gebruikers.AddOrUpdate(entity);
                                    }
                                    beheerModel.SaveChanges();

                                    foreach (contact contact in entities)
                                    {
                                        ClubCloud_Gebruiker entity = beheerModel.ClubCloud_Gebruikers.Find(contact.contactid.Value);

                                        entity.VerenigingId = vereniging.Id;
                                        entity.ClubCloud_Vereniging = vereniging;

                                        if (contact.parentcustomerid != null)
                                        {
                                            vereniging = GetVerenigingById(contact.parentcustomerid.Value, false, settings);
                                            if (vereniging != null)
                                                entity.ClubCloud_Vereniging = vereniging;
                                        }

                                        if (contact.sgt_nationaliteitid != null)
                                        {
                                            ClubCloud_Nationaliteit nationaliteit = GetNationaliteitById(contact.sgt_nationaliteitid.Value, false, settings);
                                            if (nationaliteit != null)
                                                entity.ClubCloud_Nationaliteit = nationaliteit;
                                        }

                                        if (contact.address1_addressid != null)
                                        {
                                            ClubCloud_Address bezoek = GetAddressById(contact.address1_addressid.Value, false, settings);
                                            if (bezoek != null)
                                                entity.ClubCloud_Address.Add(bezoek);
                                        }
                                        if (contact.address2_addressid != null)
                                        {
                                            ClubCloud_Address post = GetAddressById(contact.address2_addressid.Value, false, settings);
                                            if (post != null)
                                                entity.ClubCloud_Address.Add(post);
                                        }
                                    }

                                    beheerModel.SaveChanges();

                                    foreach (contact contact in entities)
                                    {
                                        int _bondsnummer;
                                        if (int.TryParse(contact.sgt_bondsnummer, out _bondsnummer))
                                        {
                                            ClubCloud_Setting usersettings = beheerModel.ClubCloud_Settings.Find(_bondsnummer);

                                            if (usersettings == null)
                                                usersettings = beheerModel.ClubCloud_Settings.Create();

                                            usersettings.Id = _bondsnummer;
                                            usersettings.Access = false;
                                            usersettings.Agree = false;
                                            usersettings.facebook_allow = false;
                                            usersettings.facebook_setting = Facebook.None;
                                            usersettings.financieel = Financieel.None;
                                            usersettings.privacy = Privacy.None;
                                            usersettings.twitter_allow = false;
                                            usersettings.twitter_setting = Twitter.None;

                                            usersettings.VerenigingId = vereniging.Id;
                                            usersettings.ClubCloud_Vereniging = vereniging;

                                            if (contact.parentcustomerid != null)
                                                usersettings.VerenigingId = contact.parentcustomerid.Value;

                                            if (contact.contactid != null)
                                                usersettings.GebruikerId = contact.contactid.Value;

                                            usersettings.Gewijzigd = DateTime.Now;
                                            beheerModel.ClubCloud_Settings.AddOrUpdate(usersettings);
                                        }
                                    }
                                    beheerModel.SaveChanges();

                                    foreach (contact entity in entities)
                                    {
                                        ClubCloud_Gebruiker gebruiker = beheerModel.ClubCloud_Gebruikers.Find(entity.contactid.Value);
                                        bool succes = CreateOrUpdateMembershipGebruiker(gebruiker, settings).Result;
                                    }

                                    foreach (contact entity in entities)
                                    {
                                        ClubCloud_Gebruiker gebruiker = beheerModel.ClubCloud_Gebruikers.Find(entity.contactid.Value);

                                        if (entity.sgt_is_functionaris != null && entity.sgt_is_functionaris.Value)
                                        {
                                            GetFunctionarissenForGebruikerById(bondsnummer, entity.contactid.Value, refresh, settings);
                                        }
                                    }

                                    beheerModel.SaveChanges();

                                }
                            }
                        }
                    }

                    result = beheerModel.ClubCloud_Gebruikers.Where(v => v.VerenigingId.Value == Id).ToList();

                    foreach (ClubCloud_Gebruiker gebruiker in result)
                    {
                        vereniging.ClubCloud_Gebruiker.Add(gebruiker);
                    }
                    beheerModel.SaveChanges();
                }
            }
            return result;
        }

        /*
        /// <summary>
        /// 
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="verenigingId"></param>
        /// <param name="refresh"></param>
        /// <returns></returns>
        private List<ClubCloud_Gebruiker> GetGebruikersByVereniging(string bondsnummer, Guid verenigingId, bool refresh = false)
        {
            List<ClubCloud_Gebruiker> gebruikers = new List<ClubCloud_Gebruiker>();

            gebruikers = beheerModel.ClubCloud_Gebruikers.Where(f => f.VerenigingId == verenigingId && f.Actief.Equals("Actief", StringComparison.CurrentCultureIgnoreCase)).ToList();

            if (gebruikers != null && gebruikers.Count == 0 || refresh)
            {
                ClubCloud_Setting settings = GetSettings(bondsnummer);

                if (settings != null && settings.Access && !string.IsNullOrWhiteSpace(settings.Password))
                {
                    CookieContainer cc = RequestContainer(settings.Id.ToString(), settings.Password);

                    if (cc != null)
                    {
                        using (ClubCloud.KNLTB.ServIt.CrmService.CrmService service = CrmServices[settings.Id.ToString()])
                        {

                            //CrmService.CrmCookieContainer = cc; 
                            //ClubCloud.KNLTB.ServIt.CrmService.CrmService service = new KNLTB.ServIt.CrmService.CrmService(cc);

                            bool moreRecords = true;
                            int pageNum = 1;
                            while (moreRecords)
                            {
                                ConditionExpression condition = new ConditionExpression { AttributeName = "sgt_primaire_vereniging_id", Operator = ConditionOperator.Equal, Values = new object[1] { verenigingId } };
                                FilterExpression expression = new FilterExpression { FilterOperator = LogicalOperator.And, Conditions = new ConditionExpression[1] { condition } };

                                List<BusinessEntity> entities = RetrieveMultiple(service, "contact", out moreRecords, ref pageNum, expression);

                                foreach (contact entity in entities)
                                {
                                    if (settings.Id == int.Parse(entity.sgt_bondsnummer) && (settings.GebruikerId == null || settings.VerenigingId == null))
                                    {
                                        ClubCloud_Setting updatesettings = beheerModel.ClubCloud_Settings.Find(settings.Id);
                                        if (entity.parentcustomerid != null)
                                            updatesettings.VerenigingId = entity.parentcustomerid.Value;

                                        if (entity.contactid != null)
                                            updatesettings.GebruikerId = entity.contactid.Value;

                                        beheerModel.SaveChanges();
                                        settings = updatesettings;
                                    }

                                    ClubCloud_Gebruiker gebruiker = beheerModel.ClubCloud_Gebruikers.Find(entity.contactid.Value);

                                    if (gebruiker == null)
                                    {
                                        gebruiker = beheerModel.ClubCloud_Gebruikers.Create();
                                        gebruiker.Id = entity.contactid.Value;

                                        ContactToGebruiker(entity, verenigingId, gebruiker, bondsnummer);

                                        beheerModel.ClubCloud_Gebruikers.Add(gebruiker);
                                    }
                                    else
                                    {
                                        ContactToGebruiker(entity, verenigingId, gebruiker, bondsnummer);
                                    }

                                    beheerModel.SaveChanges();

                                    CreateOrUpdateMembershipGebruiker(gebruiker, settings);

                                    if (entity.sgt_is_functionaris != null && entity.sgt_is_functionaris.Value)
                                    {
                                        GetFunctionarissenByGebruiker(bondsnummer, entity.contactid.Value);
                                    }

                                }
                            }
                        }
                    }
                }
                gebruikers = beheerModel.ClubCloud_Gebruikers.Where(f => f.VerenigingId == verenigingId && f.Actief.Equals("Actief", StringComparison.CurrentCultureIgnoreCase)).ToList();
            }
            return gebruikers;
        }
        */

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="entity"></param>
        /// <param name="refresh"></param>
        /// <param name="settings"></param>
        /// <returns></returns>
        private List<ClubCloud_Afhang> GetAfhangenForVereniging(string bondsnummer, ClubCloud_Vereniging entity, bool refresh, ClubCloud_Setting settings)
        {
            return GetAfhangenForVerenigingById(bondsnummer, entity.Id, refresh, settings);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="Id"></param>
        /// <param name="refresh"></param>
        /// <param name="settings"></param>
        /// <returns></returns>
        private List<ClubCloud_Afhang> GetAfhangenForVerenigingById(string bondsnummer, Guid Id, bool refresh, ClubCloud_Setting settings)
        {
            List<ClubCloud_Afhang> result = null;

            ClubCloud_Vereniging vereniging = beheerModel.ClubCloud_Verenigingen.Find(Id);
            if (vereniging != null)
            {
                if (vereniging.ClubCloud_Afhang == null || vereniging.ClubCloud_Afhang.Count == 0)
                {
                    result = beheerModel.ClubCloud_Afhangen.Where(v => v.VerenigingId.Value == Id).ToList();

                    foreach (ClubCloud_Afhang afhang in result)
                    {
                        vereniging.ClubCloud_Afhang.Add(afhang);
                    }
                    beheerModel.SaveChanges();
                }

            }
            return result;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="entity"></param>
        /// <param name="refresh"></param>
        /// <param name="settings"></param>
        /// <returns></returns>
        private List<ClubCloud_Sponsor> GetSponsorenForVereniging(string bondsnummer, ClubCloud_Vereniging entity, bool refresh, ClubCloud_Setting settings)
        {
            return GetSponsorenForVerenigingById(bondsnummer, entity.Id, refresh, settings);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="Id"></param>
        /// <param name="refresh"></param>
        /// <param name="settings"></param>
        /// <returns></returns>
        private List<ClubCloud_Sponsor> GetSponsorenForVerenigingById(string bondsnummer, Guid Id, bool refresh, ClubCloud_Setting settings)
        {
            List<ClubCloud_Sponsor> result = null;

            ClubCloud_Vereniging vereniging = beheerModel.ClubCloud_Verenigingen.Find(Id);
            if (vereniging != null)
            {
                if (vereniging.ClubCloud_Sponsor == null || vereniging.ClubCloud_Sponsor.Count == 0)
                {
                    result = beheerModel.ClubCloud_Sponsoren.Where(v => v.VerenigingId == Id).ToList();

                    foreach (ClubCloud_Sponsor sponsor in result)
                    {
                        vereniging.ClubCloud_Sponsor.Add(sponsor);
                    }
                    beheerModel.SaveChanges();
                }

            }
            return result;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="entity"></param>
        /// <param name="refresh"></param>
        /// <param name="settings"></param>
        /// <returns></returns>
        private List<ClubCloud_Setting> GetSettingsForVereniging(string bondsnummer, ClubCloud_Vereniging entity, bool refresh, ClubCloud_Setting settings)
        {
            return GetSettingsForVerenigingById(bondsnummer, entity.Id, refresh, settings);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="Id"></param>
        /// <param name="refresh"></param>
        /// <param name="settings"></param>
        /// <returns></returns>
        private List<ClubCloud_Setting> GetSettingsForVerenigingById(string bondsnummer, Guid Id, bool refresh, ClubCloud_Setting settings)
        {
            List<ClubCloud_Setting> result = null;

            ClubCloud_Vereniging vereniging = beheerModel.ClubCloud_Verenigingen.Find(Id);
            if (vereniging != null)
            {
                if (vereniging.ClubCloud_Setting == null || vereniging.ClubCloud_Setting.Count == 0)
                {
                    result = beheerModel.ClubCloud_Settings.Where(v => v.VerenigingId.Value == Id).ToList();

                    foreach (ClubCloud_Setting setting in result)
                    {
                        vereniging.ClubCloud_Setting.Add(setting);
                    }
                    beheerModel.SaveChanges();
                }

            }
            return result;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="entity"></param>
        /// <param name="refresh"></param>
        /// <param name="settings"></param>
        /// <returns></returns>
        private List<ClubCloud_Baanschema> GetBaanschemasForVereniging(string bondsnummer, ClubCloud_Vereniging entity, bool refresh, ClubCloud_Setting settings)
        {
            return GetBaanschemasForVerenigingById(bondsnummer, entity.Id, refresh, settings);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="Id"></param>
        /// <param name="refresh"></param>
        /// <param name="settings"></param>
        /// <returns></returns>
        private List<ClubCloud_Baanschema> GetBaanschemasForVerenigingById(string bondsnummer, Guid Id, bool refresh, ClubCloud_Setting settings)
        {
            List<ClubCloud_Baanschema> result = null;

            ClubCloud_Vereniging vereniging = beheerModel.ClubCloud_Verenigingen.Find(Id);
            if (vereniging != null)
            {
                if (vereniging.ClubCloud_Baanschema == null || vereniging.ClubCloud_Baanschema.Count == 0)
                {
                    result = beheerModel.ClubCloud_Baanschemas.Where(v => v.VerenigingId.Value == Id).ToList();

                    foreach (ClubCloud_Baanschema baanschema in result)
                    {
                        vereniging.ClubCloud_Baanschema.Add(baanschema);
                    }
                    beheerModel.SaveChanges();
                }

            }
            return result;
        }


        /// <summary>
        /// account
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="verenigingNummer"></param>
        /// <param name="refresh"></param>
        /// <returns></returns>
        private ClubCloud_Vereniging VerenigingByNummer(string bondsnummer, string verenigingNummer, bool refresh = false, ClubCloud_Setting settings = null)
        {
            ClubCloud_Vereniging entity = new ClubCloud_Vereniging();

            entity = beheerModel.ClubCloud_Verenigingen.SingleOrDefault(l => l.Nummer == verenigingNummer);

            if (entity == null || refresh)
            {
                if (settings == null)
                {
                    settings = GetSettings(bondsnummer);
                }

                if (settings != null && settings.Access && !string.IsNullOrWhiteSpace(settings.Password))
                {
                    CookieContainer cc = RequestContainer(settings.Id.ToString(), settings.Password);

                    if (cc != null)
                    {
                        using (ClubCloud.KNLTB.ServIt.CrmService.CrmService service = CrmServices[settings.Id.ToString()])
                        {

                            //CrmService.CrmCookieContainer = cc;
                            //ClubCloud.KNLTB.ServIt.CrmService.CrmService service = new KNLTB.ServIt.CrmService.CrmService(cc);

                            bool moreRecords = true;
                            int pageNum = 1;
                            while (moreRecords)
                            {
                                ConditionExpression condition = new ConditionExpression { AttributeName = "accountnumber", Operator = ConditionOperator.Equal, Values = new object[1] { verenigingNummer } };
                                FilterExpression expression = new FilterExpression { FilterOperator = LogicalOperator.And, Conditions = new ConditionExpression[1] { condition } };

                                List<BusinessEntity> entities = RetrieveMultiple(service, "account", out moreRecords, ref pageNum, expression);

                                foreach (account account in entities)
                                {
                                    entity = beheerModel.ClubCloud_Verenigingen.Find(account.accountid.Value);

                                    if (entity == null)
                                        entity = beheerModel.ClubCloud_Verenigingen.Create();
                                    entity.Id = account.accountid.Value;


                                    VerenigingToEntity(account, entity, settings);

                                    beheerModel.ClubCloud_Verenigingen.AddOrUpdate(entity);
                                }
                                beheerModel.SaveChanges();

                                foreach (account account in entities)
                                {
                                    entity = beheerModel.ClubCloud_Verenigingen.Find(account.accountid.Value);

                                    if (account.sgt_districtid != null)
                                    {
                                        ClubCloud_District district = GetDistrictById(account.sgt_districtid.Value, false, settings);
                                        entity.ClubCloud_District = district;
                                        //account.DistrictId = account.sgt_districtid.Value;
                                    }

                                    if (account.sgt_rechtsvormid != null)
                                    {
                                        ClubCloud_Rechtsvorm rechtsvorm = GetRechtsvormById(account.sgt_rechtsvormid.Value, false, settings);
                                        entity.ClubCloud_Rechtsvorm = rechtsvorm;
                                        //account.RechtsvormId = account.sgt_rechtsvormid.Value;
                                    }

                                    if (account.sgt_hoofdaccomodatieid != null)
                                    {
                                        ClubCloud_Accommodatie Accommodatie = GetAccommodatieById(account.sgt_hoofdaccomodatieid.Value, false, settings);
                                        entity.ClubCloud_Accommodatie = Accommodatie;
                                        //account.AccommodatieId = account.sgt_hoofdaccomodatieid.Value;
                                    }

                                    if (account.parentaccountid != null)
                                    {
                                        ClubCloud_Regio regio = GetRegioById(account.parentaccountid.Value, false, settings);
                                        entity.ClubCloud_Regio = regio;
                                        //account.RegioId = account.parentaccountid.Value;
                                    }

                                    if (account.address1_addressid != null)
                                    {
                                        ClubCloud_Address bezoek = GetAddressById(account.address1_addressid.Value, false, settings);
                                        entity.ClubCloud_Address.Add(bezoek);
                                    }

                                    if (account.address2_addressid != null)
                                    {
                                        ClubCloud_Address post = GetAddressById(account.address2_addressid.Value, false, settings);
                                        entity.ClubCloud_Address.Add(post);
                                    }
                                }

                                beheerModel.SaveChanges();

                                foreach (account account in entities)
                                {
                                    entity = beheerModel.ClubCloud_Verenigingen.Find(account.accountid.Value);

                                    CreateOrUpdateMembershipVereniging(entity, settings);
                                }


                            }
                        }
                    }
                }
                entity = beheerModel.ClubCloud_Verenigingen.SingleOrDefault(l => l.Nummer == verenigingNummer);
            }
            return entity;
        }

        #region Mapping

        /// <summary>
        /// 
        /// </summary>
        /// <param name="entity"></param>
        /// <param name="vereniging"></param>
        /// <param name="bondsnummer"></param>
        private void entityToVereniging(account entity, ClubCloud_Vereniging vereniging, string bondsnummer, ClubCloud_Setting settings = null)
        {
            vereniging.Nummer = entity.accountnumber;
            vereniging.Naam = entity.name;

            if (entity.sgt_districtid != null)
            {
                ClubCloud_District district = GetDistrictById(bondsnummer, entity.sgt_districtid.Value, false, settings);
                vereniging.ClubCloud_District = district;
                vereniging.DistrictId = entity.sgt_districtid.Value;
            }

            vereniging.KvKnummer = entity.sgt_kvk_nummer;
            if (entity.sgt_kvkplaatsid != null)
            {
                vereniging.KvKplaats = entity.sgt_kvkplaatsid.name;
            }

            vereniging.BankNummer = entity.sgt_rekeningnummer;
            vereniging.BankIban = entity.sgt_iban_code;
            vereniging.BankPlaats = entity.sgt_rekeningnummer_plaats;

            if (entity.sgt_rechtsvormid != null)
            {
                ClubCloud_Rechtsvorm rechtsvorm = GetRechtsvormById(bondsnummer, entity.sgt_rechtsvormid.Value, false, settings);
                vereniging.ClubCloud_Rechtsvorm = rechtsvorm;
                vereniging.RechtsvormId = entity.sgt_rechtsvormid.Value;
            }

            if (entity.sgt_hoofdaccomodatieid != null)
            {
                ClubCloud_Accommodatie Accommodatie = GetAccommodatieById(bondsnummer, entity.sgt_hoofdaccomodatieid.Value, false, settings);
                vereniging.ClubCloud_Accommodatie = Accommodatie;
                vereniging.AccommodatieId = entity.sgt_hoofdaccomodatieid.Value;
            }

            if (entity.address1_addressid != null)
            {
                ClubCloud_Address bezoek = GetAddressById(bondsnummer, entity.address1_addressid.Value, false, settings);
                vereniging.ClubCloud_Address.Add(bezoek);
            }
            if (entity.address2_addressid != null)
            {
                ClubCloud_Address post = GetAddressById(bondsnummer, entity.address2_addressid.Value, false, settings);
                vereniging.ClubCloud_Address.Add(post);
            }

            if (entity.parentaccountid != null)
            {
                ClubCloud_Regio regio = GetRegioById(bondsnummer, entity.parentaccountid.Value, false, settings);
                vereniging.ClubCloud_Regio = regio;
                vereniging.RegioId = entity.parentaccountid.Value;
            }

            vereniging.EmailKNLTB = entity.emailaddress1;
            vereniging.EmailWebSite = entity.emailaddress2;
            vereniging.EmailOverig = entity.emailaddress3;
            vereniging.Fax = entity.fax;
            vereniging.FTPsite = entity.ftpsiteurl;
            vereniging.Website = entity.websiteurl;
            vereniging.Beschrijving = entity.description;
            vereniging.TelefoonOverdag = entity.telephone1;
            vereniging.TelefoonAvond = entity.telephone2;
            vereniging.TelefoonOverig = entity.telephone1;
            if (entity.sgt_datum_oprichting != null)
            {
                vereniging.Oprichting = DateTime.Parse(entity.sgt_datum_oprichting.Value);
            }
            if (entity.sgt_datumer_kenning != null)
            {
                vereniging.Erkenning = DateTime.Parse(entity.sgt_datumer_kenning.Value);
            }
            if (entity.sgt_datum_afmelding != null)
            {
                vereniging.Gestopt = DateTime.Parse(entity.sgt_datum_afmelding.Value);
            }
            if (entity.sgt_aantal_maanden_geopend != null)
            {
                vereniging.Maanden = entity.sgt_aantal_maanden_geopend.Value;
            }
            vereniging.Actief = (ActiefSoort)entity.statuscode.Value;
            vereniging.Gewijzigd = DateTime.Now;


        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="account2"></param>
        /// <param name="entity2"></param>
        private void VerenigingToEntity(account account, ClubCloud_Vereniging entity, ClubCloud_Setting settings)
        {
            entity.Nummer = account.accountnumber;
            entity.Naam = account.name;
            entity.KvKnummer = account.sgt_kvk_nummer;
            if (account.sgt_kvkplaatsid != null)
            {
                entity.KvKplaats = account.sgt_kvkplaatsid.name;
            }

            entity.BankNummer = account.sgt_rekeningnummer;
            entity.BankIban = account.sgt_iban_code;
            entity.BankPlaats = account.sgt_rekeningnummer_plaats;

            if (account.sgt_districtid != null)
            {
                //ClubCloud_District district = GetDistrictById(account.sgt_districtid.Value, false, settings);
                //entity.ClubCloud_District = district;
                entity.DistrictId = account.sgt_districtid.Value;
            }

            if (account.sgt_rechtsvormid != null)
            {
                //ClubCloud_Rechtsvorm rechtsvorm = GetRechtsvormById(account.sgt_rechtsvormid.Value, false, settings);
                //entity.ClubCloud_Rechtsvorm = rechtsvorm;
                entity.RechtsvormId = account.sgt_rechtsvormid.Value;
            }

            if (account.sgt_hoofdaccomodatieid != null)
            {
                //ClubCloud_Accommodatie Accommodatie = GetAccommodatieById(account.sgt_hoofdaccomodatieid.Value, false, settings);
                //entity.ClubCloud_Accommodatie = Accommodatie;
                entity.AccommodatieId = account.sgt_hoofdaccomodatieid.Value;
            }

            if (account.parentaccountid != null)
            {
                //ClubCloud_Regio regio = GetRegioById(account.parentaccountid.Value, false, settings);
                //entity.ClubCloud_Regio = regio;
                entity.RegioId = account.parentaccountid.Value;
            }

            if (account.address1_addressid != null)
            {
                //ClubCloud_Address bezoek = GetAddressById(account.address1_addressid.Value, false, settings);
                //entity.ClubCloud_Address.Add(bezoek);
            }

            if (account.address2_addressid != null)
            {
                //ClubCloud_Address post = GetAddressById(account.address2_addressid.Value, false, settings);
                //entity.ClubCloud_Address.Add(post);
            }


            entity.EmailKNLTB = account.emailaddress1;
            entity.EmailWebSite = account.emailaddress2;
            entity.EmailOverig = account.emailaddress3;
            entity.Fax = account.fax;
            entity.FTPsite = account.ftpsiteurl;
            entity.Website = account.websiteurl;
            entity.Beschrijving = account.description;
            entity.TelefoonOverdag = account.telephone1;
            entity.TelefoonAvond = account.telephone2;
            entity.TelefoonOverig = account.telephone3;

            if (account.sgt_datum_oprichting != null)
            {
                entity.Oprichting = DateTime.Parse(account.sgt_datum_oprichting.Value);
            }
            if (account.sgt_datumer_kenning != null)
            {
                entity.Erkenning = DateTime.Parse(account.sgt_datumer_kenning.Value);
            }
            if (account.sgt_datum_afmelding != null)
            {
                entity.Gestopt = DateTime.Parse(account.sgt_datum_afmelding.Value);
            }
            if (account.sgt_aantal_maanden_geopend != null)
            {
                entity.Maanden = account.sgt_aantal_maanden_geopend.Value;
            }
            entity.Actief = (ActiefSoort)account.statuscode.Value;
            entity.Gewijzigd = DateTime.Now;
        }

        #endregion

        #endregion

        //<!-- Region Specifiek -->

        #region Gebruikers

        #region Settings

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <returns></returns>
        public ClubCloud_Setting GetClubCloudSettings(int bondsnummer)
        {
            return GetClubCloudSettings(bondsnummer.ToString());
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <returns></returns>
        public ClubCloud_Setting GetClubCloudSettings(string bondsnummer)
        {
            ClubCloud_Setting currentsettings = null;// new ClubCloud_Setting();
            int nummer;

            if (!int.TryParse(bondsnummer, out nummer))
            {
                return currentsettings;
            }

            try
            {
                currentsettings = beheerModel.ClubCloud_Settings.Find(nummer);
                if(currentsettings != null)
                    beheerModel.ObjectContext.Refresh(RefreshMode.StoreWins, currentsettings);
            }
            catch
            {

                currentsettings = null;
            }

            if (currentsettings == null)
            {
                currentsettings = beheerModel.ClubCloud_Settings.Create();
                currentsettings.Id = nummer;

                currentsettings.Gewijzigd = DateTime.Now;
                beheerModel.ClubCloud_Settings.AddOrUpdate(currentsettings);
                beheerModel.SaveChanges();

                ClubCloud_Gebruiker gebruiker = beheerModel.ClubCloud_Gebruikers.Where(g => g.Bondsnummer == nummer.ToString()).FirstOrDefault();

                if (gebruiker != null)
                {
                    currentsettings.GebruikerId = gebruiker.Id;
                    currentsettings.ClubCloud_Gebruiker = gebruiker;
                }

                ClubCloud_Vereniging vereniging = null;

                if (gebruiker != null && gebruiker.VerenigingId.HasValue)
                    vereniging = beheerModel.ClubCloud_Verenigingen.Find(gebruiker.VerenigingId.Value);

                if (vereniging != null)
                {
                    currentsettings.VerenigingId = vereniging.Id;
                    currentsettings.ClubCloud_Vereniging = vereniging;
                }

                currentsettings.Gewijzigd = DateTime.Now;
                beheerModel.ClubCloud_Settings.AddOrUpdate(currentsettings);
                beheerModel.SaveChanges();
            }
            /*
            else
            {
                vereniging = beheerModel.ClubCloud_Verenigingen.Where(v => v.Nummer == nummer.ToString()).FirstOrDefault();

                if (vereniging != null)
                {
                    currentsettings.VerenigingId = vereniging.Id;
                    currentsettings.ClubCloud_Vereniging = vereniging;
                }
            }
            */

            currentsettings = beheerModel.ClubCloud_Settings.Find(nummer);

            if (currentsettings != null)
                beheerModel.ObjectContext.Refresh(RefreshMode.StoreWins, currentsettings);

            return currentsettings;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="settings"></param>
        /// <returns></returns>
        public ClubCloud_Setting SetClubCloudSettings(ClubCloud_Setting settings)
        {
            ClubCloud_Setting tobeupdated = beheerModel.ClubCloud_Settings.Find(settings.Id);

            if (tobeupdated != null)
            {
                beheerModel.Entry(tobeupdated).CurrentValues.SetValues(settings);
                beheerModel.SaveChanges();
            }
            tobeupdated = beheerModel.ClubCloud_Settings.Find(settings.Id);
            beheerModel.ObjectContext.Refresh(RefreshMode.StoreWins, tobeupdated);

            return tobeupdated;
        }

        /*
        public ClubCloud_Setting SetFaceBook(ClubCloud_Setting settings)
        {
            //CheckDatabase();

            ClubCloud_Setting currentsettings = new ClubCloud_Setting();
            using (ClubCloud.Model.BeheerContainer model = new Model.BeheerContainer(GetConnectionString()))
            {
                currentsettings = beheerModel.ClubCloud_Settings.Find(settings.Id);
                currentsettings.facebook_allow = settings.facebook_allow;
                currentsettings.facebook_access_token = settings.facebook_access_token;
                currentsettings.facebook_setting = settings.facebook_setting;
                currentsettings.Gewijzigd = DateTime.Now;
                beheerModel.SaveChanges();
            }

            currentsettings.Password = string.Empty;
            return currentsettings;
        }

        public ClubCloud_Setting SetFinancieel(ClubCloud_Setting settings)
        {
            //CheckDatabase();

            ClubCloud_Setting currentsettings = new ClubCloud_Setting();

            //if (beheerModel == null)
            //{
            //    beheerModel = new Model.BeheerContainer(GetConnectionString());
            //}

            //using (ClubCloud.Model.BeheerContainer model = new Model.BeheerContainer(GetConnectionString()))
            //{

            currentsettings = beheerModel.ClubCloud_Settings.Find(settings.Id);
            currentsettings.financieel = settings.financieel;
            currentsettings.Gewijzigd = DateTime.Now;
            beheerModel.SaveChanges();
            //}

            currentsettings.Password = string.Empty;
            return currentsettings;
        }
        */

        /// <summary>
        /// 
        /// </summary>
        /// <param name="settings"></param>
        /// <returns></returns>
        public ClubCloud_Setting SetMijnKNLTB(ClubCloud_Setting settings)
        {
            ClubCloud_Setting currentsettings = GetClubCloudSettings(settings.Id);
            //currentsettings = beheerModel.ClubCloud_Settings.Find(settings.Id);

            bool parse = false;
            if (settings.Agree && (currentsettings.Password != settings.Password))
            {
                currentsettings.Agree = settings.Agree;
                currentsettings.Password = settings.Password;
                currentsettings.Gewijzigd = DateTime.Now;
                beheerModel.SaveChanges();
                parse = true;
            }

            if (parse)
            {
                CookieContainer cc = RequestContainer(currentsettings.Id.ToString(), currentsettings.Password, false);

                if (cc != null)
                {
                    using (ClubCloud.KNLTB.ServIt.CrmService.CrmService service = CrmServices[settings.Id.ToString()])
                    {
                        //CrmService.CrmCookieContainer = cc;//
                        //ClubCloud.KNLTB.ServIt.CrmService.CrmService service = new KNLTB.ServIt.CrmService.CrmService(cc);

                        try
                        {
                            WhoAmIResponse response = service.Execute(new WhoAmIRequest()) as WhoAmIResponse;

                            currentsettings.Access = true;
                            currentsettings.Gewijzigd = DateTime.Now;
                            beheerModel.SaveChanges();

                            ClubCloud_Gebruiker gebruiker = GebruikerByNummer(currentsettings.Id.ToString(), currentsettings.Id.ToString(), true, currentsettings, false);

                            if (gebruiker != null)
                            {
                                currentsettings.GebruikerId = gebruiker.Id;
                                currentsettings.ClubCloud_Gebruiker = gebruiker;
                                if (gebruiker.VerenigingId.HasValue)
                                {
                                    ClubCloud_Vereniging vereniging = beheerModel.ClubCloud_Verenigingen.Find(gebruiker.VerenigingId.Value);
                                    currentsettings.VerenigingId = gebruiker.VerenigingId.Value;
                                    currentsettings.ClubCloud_Vereniging = vereniging;
                                    beheerModel.SaveChanges();
                                }

                                if (currentsettings.Access && currentsettings.VerenigingId.HasValue && currentsettings.GebruikerId.HasValue)
                                {
                                    string encrypted = BeheerEncryption.Encrypt(currentsettings.Password, currentsettings.VerenigingId.Value.ToString(), currentsettings.GebruikerId.Value.ToString());

                                    currentsettings.Password = encrypted;
                                    currentsettings.Gewijzigd = DateTime.Now;
                                    beheerModel.SaveChanges();
                                }

                                List<ClubCloud_Lidmaatschap> lidmaatschappen = GetLidmaatschappenByGebruiker(currentsettings.Id.ToString(), gebruiker.Id);
                            }
                        }
                        catch (WebException wex)
                        {
                            HttpWebResponse response = wex.Response as HttpWebResponse;
                            if (response.StatusCode == HttpStatusCode.Forbidden)
                            {
                                currentsettings.Access = false;
                                currentsettings.Gewijzigd = DateTime.Now;
                                beheerModel.SaveChanges();
                            }
                        }
                    }
                }
            }


            return currentsettings;
        }

        /*
        public ClubCloud_Setting SetPrivacy(ClubCloud_Setting settings)
        {
            //CheckDatabase();

            ClubCloud_Setting currentsettings = new ClubCloud_Setting();

            //if (beheerModel == null)
            //{
            //    beheerModel = new Model.BeheerContainer(GetConnectionString());
            //}

            //using (ClubCloud.Model.BeheerContainer model = new Model.BeheerContainer(GetConnectionString()))
            //{

            currentsettings = beheerModel.ClubCloud_Settings.Find(settings.Id);
            currentsettings.privacy = settings.privacy;
            currentsettings.Gewijzigd = DateTime.Now;
            beheerModel.SaveChanges();
            //}

            currentsettings.Password = string.Empty;
            return currentsettings;
        }

        public ClubCloud_Setting SetTracking(ClubCloud_Setting settings)
        {
            //CheckDatabase();

            ClubCloud_Setting currentsettings = new ClubCloud_Setting();

            //if (beheerModel == null)
            //{
            //    beheerModel = new Model.BeheerContainer(GetConnectionString());
            //}

            //using (ClubCloud.Model.BeheerContainer model = new Model.BeheerContainer(GetConnectionString()))
            //{

            currentsettings = beheerModel.ClubCloud_Settings.Find(settings.Id);
            //currentsettings.mijnknltb_tracking = settings.mijnknltb_tracking;
            currentsettings.Gewijzigd = DateTime.Now;
            beheerModel.SaveChanges();
            //}

            currentsettings.Password = string.Empty;
            return currentsettings;
        }

        public ClubCloud_Setting SetTwitter(ClubCloud_Setting settings)
        {
            //CheckDatabase();

            ClubCloud_Setting currentsettings = new ClubCloud_Setting();

            //if (beheerModel == null)
            //{
            //    beheerModel = new Model.BeheerContainer(GetConnectionString());
            //}

            //using (ClubCloud.Model.BeheerContainer model = new Model.BeheerContainer(GetConnectionString()))
            //{

            currentsettings = beheerModel.ClubCloud_Settings.Find(settings.Id);
            currentsettings.twitter_allow = settings.twitter_allow;
            currentsettings.twitter_oauth_token = settings.twitter_oauth_token;
            currentsettings.twitter_oauth_token_secret = settings.twitter_oauth_token_secret;
            currentsettings.twitter_setting = settings.twitter_setting;
            currentsettings.Gewijzigd = DateTime.Now;
            beheerModel.SaveChanges();
            //}

            currentsettings.Password = string.Empty;
            return currentsettings;
        }
        */

        #endregion

        public bool SetClubCloudGebruiker(string bondsnummer, Guid verenigingId, ClubCloud_Gebruiker gebruiker, bool refresh = false)
        {
            try
            {
                ClubCloud_Setting settings = beheerModel.ClubCloud_Settings.Find(int.Parse(gebruiker.Bondsnummer));
                ClubCloud_Gebruiker currentgebruiker = beheerModel.ClubCloud_Gebruikers.Find(gebruiker.Id);

                if (currentgebruiker != null)
                {
                    if (settings != null)
                    {
                        if (!settings.GebruikerId.HasValue)
                        {
                            settings.ClubCloud_Gebruiker = currentgebruiker;
                            settings.GebruikerId = gebruiker.Id;
                            beheerModel.SaveChanges();
                        }

                        if (!settings.VerenigingId.HasValue)
                        {
                            ClubCloud_Vereniging vereniging = beheerModel.ClubCloud_Verenigingen.Find(settings.VerenigingId.Value);
                            settings.ClubCloud_Vereniging = vereniging;
                            settings.VerenigingId = gebruiker.VerenigingId.Value;
                            beheerModel.SaveChanges();
                        }
                    }

                    currentgebruiker.Aanhef = gebruiker.Aanhef;
                    currentgebruiker.AanhefAttentie = gebruiker.AanhefAttentie;
                    currentgebruiker.AanhefBrief = gebruiker.AanhefBrief;
                    currentgebruiker.Achternaam = gebruiker.Achternaam;
                    currentgebruiker.Achtervoegsel = gebruiker.Achtervoegsel;
                    //currentgebruiker.Actief = gebruiker.Actief;
                    currentgebruiker.AddressGeheim = gebruiker.AddressGeheim;
                    currentgebruiker.BankIban = gebruiker.BankIban;
                    currentgebruiker.BankNummer = gebruiker.BankNummer;
                    currentgebruiker.BankPlaats = gebruiker.BankPlaats;
                    currentgebruiker.Beroep = gebruiker.Beroep;
                    currentgebruiker.Beschrijving = gebruiker.Beschrijving;
                    //currentgebruiker.Bondsnummer = gebruiker.Bondsnummer;
                    currentgebruiker.EmailGeheim = gebruiker.EmailGeheim;
                    currentgebruiker.EmailKNLTB = gebruiker.EmailKNLTB;
                    currentgebruiker.EmailOverig = gebruiker.EmailOverig;
                    currentgebruiker.EmailWebSite = gebruiker.EmailWebSite;
                    currentgebruiker.Fax = gebruiker.Fax;
                    //currentgebruiker.FotoId = gebruiker.FotoId;
                    currentgebruiker.FTPsite = gebruiker.FTPsite;
                    currentgebruiker.Geboortedatum = gebruiker.Geboortedatum.Value;
                    currentgebruiker.Geboorteplaats = gebruiker.Geboorteplaats;
                    currentgebruiker.Geslacht = gebruiker.Geslacht;
                    currentgebruiker.Gewijzigd = DateTime.Now;
                    //currentgebruiker.Id = gebruiker.Id;
                    currentgebruiker.Kinderen = gebruiker.Kinderen;
                    currentgebruiker.KinderenAantal = gebruiker.KinderenAantal;
                    currentgebruiker.Mobiel = gebruiker.Mobiel;
                    currentgebruiker.NationaliteitId = gebruiker.NationaliteitId.Value;
                    if (gebruiker.OverlijdensDatum.HasValue)
                        currentgebruiker.OverlijdensDatum = gebruiker.OverlijdensDatum.Value;
                    currentgebruiker.Partner = gebruiker.Partner;
                    currentgebruiker.Roepnaam = gebruiker.Roepnaam;
                    currentgebruiker.TelefoonAvond = gebruiker.TelefoonAvond;
                    currentgebruiker.TelefoonGeheim = gebruiker.TelefoonGeheim;
                    currentgebruiker.TelefoonOverdag = gebruiker.TelefoonOverdag;
                    currentgebruiker.TelefoonOverig = gebruiker.TelefoonOverig;
                    currentgebruiker.Tussenvoegsel = gebruiker.Tussenvoegsel;
                    //currentgebruiker.VerenigingId = gebruiker.VerenigingId;
                    currentgebruiker.Volledigenaam = string.Format("{0} {1}, {2}", gebruiker.Tussenvoegsel, gebruiker.Achternaam, gebruiker.Voorletters);
                    currentgebruiker.Voorletters = gebruiker.Voorletters;
                    currentgebruiker.Voornaam = gebruiker.Voornaam;
                    currentgebruiker.Voornamen = gebruiker.Voornamen;
                    currentgebruiker.Website = gebruiker.Website;

                    if (beheerModel.ChangeTracker.HasChanges())
                    {
                        //UpdateMembershipuser(gebruiker);
                    }
                    beheerModel.SaveChanges();

                    if (gebruiker.ClubCloud_Address != null && gebruiker.ClubCloud_Address.Count > 0)
                    {
                        foreach (ClubCloud_Address address in gebruiker.ClubCloud_Address)
                        {
                            ClubCloud_Address currentaddress = beheerModel.ClubCloud_Addressen.Find(address.Id);
                            //currentaddress.Actief = address.Actief;
                            currentaddress.AddressGeheim = address.AddressGeheim;
                            currentaddress.Fax = address.Fax;
                            currentaddress.GeoLocation = address.GeoLocation;
                            currentaddress.Gewijzigd = DateTime.Now;
                            //currentaddress.Id = address.Id;
                            currentaddress.Gemeente = address.Gemeente;
                            currentaddress.LandId = address.LandId.Value;
                            currentaddress.Latitude = address.Latitude;
                            currentaddress.Longitude = address.Longitude;
                            currentaddress.Naam = address.Naam;
                            currentaddress.Nummer = address.Nummer;
                            //currentaddress.ParentId = address.ParentId.Value;
                            currentaddress.Postbus = address.Postbus;
                            currentaddress.Postcode = address.Postcode;
                            currentaddress.Provincie = address.Provincie;
                            currentaddress.Stad = address.Stad;
                            currentaddress.Straat = address.Straat;
                            currentaddress.TelefoonPrimair = address.TelefoonPrimair;
                            currentaddress.TelefoonSecundair = address.TelefoonSecundair;
                            currentaddress.TelefoonTertiair = address.TelefoonTertiair;
                            currentaddress.Toevoeging = address.Toevoeging;

                            beheerModel.SaveChanges();
                        }
                    }

                    if (gebruiker.ClubCloud_Lidmaatschap != null && gebruiker.ClubCloud_Lidmaatschap.Count > 0)
                    {
                        foreach (ClubCloud_Lidmaatschap lidmaatschap in gebruiker.ClubCloud_Lidmaatschap)
                        {
                            ClubCloud_Lidmaatschap currentlidmaatschap = beheerModel.ClubCloud_Lidmaatschappen.Find(lidmaatschap.Id);
                            //currentlidmaatschap.Actief = lidmaatschap.Actief;
                            currentlidmaatschap.Autorisatie = lidmaatschap.Autorisatie;
                            currentlidmaatschap.Begin = lidmaatschap.Begin;
                            currentlidmaatschap.Einde = lidmaatschap.Einde.Value;
                            currentlidmaatschap.Gewijzigd = DateTime.Now;
                            currentlidmaatschap.InternNummer = lidmaatschap.InternNummer;
                            currentlidmaatschap.Opzegging = lidmaatschap.Opzegging.Value;
                            currentlidmaatschap.PasDatum = lidmaatschap.PasDatum.Value;
                            currentlidmaatschap.PasNieuw = lidmaatschap.PasNieuw;
                            currentlidmaatschap.PasNood = currentlidmaatschap.PasNood;
                            currentlidmaatschap.PasNoodDatum = lidmaatschap.PasNoodDatum.Value;
                            currentlidmaatschap.PasTypeId = lidmaatschap.PasTypeId;
                            currentlidmaatschap.PasTypeNaam = lidmaatschap.PasTypeNaam;
                            currentlidmaatschap.PasVolgnummer = lidmaatschap.PasVolgnummer;
                            currentlidmaatschap.PasWedstrijd = lidmaatschap.PasWedstrijd;
                            currentlidmaatschap.LidmaatschapsoortId = lidmaatschap.LidmaatschapsoortId.Value;
                            //currentlidmaatschap.SoortNaam = lidmaatschap.SoortNaam;
                            currentlidmaatschap.SpeelsterkteDubbel = lidmaatschap.SpeelsterkteDubbel;
                            currentlidmaatschap.SpeelsterkteEnkel = lidmaatschap.SpeelsterkteEnkel;
                            //currentlidmaatschap.VerenigingId = lidmaatschap.VerenigingId.Value;
                            beheerModel.SaveChanges();
                        }
                    }
                }

                beheerModel.SaveChanges();
                return true;
            }
            catch { return false; }

        }

        public ClubCloud_Gebruiker GetGebruikerByNummer(string bondsnummer, Guid verenigingId, string nummer, bool refresh = false)
        {
            ClubCloud_Gebruiker gebruiker = null;
            ValidateBondsnummer(ref bondsnummer, verenigingId);
            gebruiker = GebruikerByNummer(bondsnummer, nummer, refresh);
            return gebruiker;
        }

        /*
        public ClubCloud_Foto GetFotoByNummer(string bondsnummer, Guid verenigingId, string nummer, bool refresh = false)
        {
            ClubCloud_Foto foto = null;
            ValidateBondsnummer(ref bondsnummer, verenigingId);
            foto = FotoByBondsnummer(bondsnummer, nummer, refresh);
            return foto;
        }
        */

        /*
        public ClubCloud_Foto UpdateFoto(string bondsnummer, Guid verenigingId, ClubCloud_Foto foto)
        {
            ValidateBondsnummer(ref bondsnummer, verenigingId);
            foto = SetFoto(foto);
            return foto;
        }
        */

        /*
        public ClubCloud_Gebruiker GetGebruikerById(string bondsnummer, Guid verenigingId, Guid gebruikerId, bool refresh = false)
        {
            ClubCloud_Gebruiker gebruiker = null;
            ValidateBondsnummer(ref bondsnummer, verenigingId);
            gebruiker = GebruikerById(bondsnummer, gebruikerId, refresh);
            return gebruiker;
        }
        */

        public List<ClubCloud_Address> GetAddressByGebruikerId(string bondsnummer, Guid verenigingId, Guid gebruikerId, bool refresh = false)
        {
            List<ClubCloud_Address> addressen = null;
            ValidateBondsnummer(ref bondsnummer, verenigingId);
            addressen = GetAddressenForGebruikerById(bondsnummer, gebruikerId, refresh, new ClubCloud_Setting { Id = int.Parse(bondsnummer), VerenigingId = verenigingId });
            return addressen;
        }

        public List<ClubCloud_Lidmaatschap> GetLidmaatschapByGebruikerId(string bondsnummer, Guid verenigingId, Guid gebruikerId, bool refresh = false)
        {
            List<ClubCloud_Lidmaatschap> lidmaatschappen = null;
            ValidateBondsnummer(ref bondsnummer, verenigingId);
            lidmaatschappen = GetLidmaatschappenByGebruiker(bondsnummer, gebruikerId, refresh);
            return lidmaatschappen;
        }

        #endregion

        #region Club

        /*
        public ClubCloud_Vereniging GetVerenigingById(string bondsnummer, Guid verenigingId, bool refresh = false)
        {
            //CheckDatabase();

            ValidateBondsnummer(ref bondsnummer, verenigingId);

            ClubCloud_Vereniging vereniging = new ClubCloud_Vereniging();


            vereniging = GetVerenigingById(bondsnummer, verenigingId, refresh, null);

            return vereniging;
        }
        */
        /*
        public ClubCloud_Vereniging GetVerenigingByNummer(string bondsnummer, string vereniginsnummer, bool refresh = false)
        {
            //CheckDatabase();

            ClubCloud_Vereniging vereniging = new ClubCloud_Vereniging();
            using (ClubCloud.Model.BeheerContainer model = new Model.BeheerContainer(GetConnectionString()))
            {
                vereniging = beheerModel.ClubCloud_Verenigingen.FirstOrDefault(v => v.Nummer == vereniginsnummer);
                //vereniging = beheerModel.ClubCloud_Verenigingen.Select<ClubCloud_Vereniging, ClubCloud_Vereniging>(v => v.Verenigingsnummer == vereniginsnummer).First<ClubCloud_Vereniging>();

                if (vereniging == null || refresh)
                {
                    ClubCloud_Setting settings = GetSettings(bondsnummer);

                    if (settings != null && settings.Access && !string.IsNullOrWhiteSpace(settings.Password))
                    {
                        CookieContainer cc = RequestContainer(settings.Id.ToString(), settings.Password);

                        if (cc != null)
                        {
                        }
                    }
                }
            }

            return vereniging;
        }
        */

        #endregion

        #region Mijn

        #endregion

        #region Afhangen

        #region Vereniging

        /// <summary>
		/// 
		/// </summary>
		/// <param name="bondsnummer"></param>
		/// <param name="Latitude"></param>
		/// <param name="Longitude"></param>
		/// <param name="refresh"></param>
		/// <returns></returns>
		public ClubCloud_Vereniging GetVerenigingByLocation(string bondsnummer, double Latitude, double Longitude, bool refresh = false)
		{
			ClubCloud_Vereniging vereniging = null;
			ClubCloud_Address address;// = null;

			try
			{

				string LatitudeCI = Latitude.ToString(CultureInfo.InvariantCulture);
				//double LatitudeCI = double.Parse(Latitude, CultureInfo.InvariantCulture);
				string LongitudeCI = Longitude.ToString(CultureInfo.InvariantCulture);
				//double LongitudeCI = double.Parse(Longitude, CultureInfo.InvariantCulture);

				string PointInText = string.Format("POINT({0} {1})", LongitudeCI, LatitudeCI);
				// 4326 is most common coordinate system used by GPS/Maps
				DbGeography Location = DbGeography.PointFromText(PointInText, 4326);

				System.Data.ConnectionState state = beheerModel.Database.Connection.State;

				address = (from u in beheerModel.ClubCloud_Addressen
						   where u.GeoLocation != null
						   orderby u.GeoLocation.Distance(Location)
						   select u).FirstOrDefault();

				//&& u.GeoLocation.Distance(Location) < 100
				//address = beheerModel.ClubCloud_Addressen.FirstOrDefault(a => a.GeoLocation.Distance(Location) < 99999.0);

				if (address != null && address.ParentId.Value != null && address.GeoLocation != null)
				{
					double? distance = address.GeoLocation.Distance(Location);
					ValidateBondsnummer(ref bondsnummer, address.ParentId.Value);
					return GetVerenigingById(bondsnummer, address.ParentId.Value, refresh);
					//return _vereniging;
				}
				//}
			}
			catch (Exception ex)
			{
				ex.ToString();
			}

			return vereniging;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="bondsnummer"></param>
		/// <param name="verenigingNummer"></param>
		/// <param name="refresh"></param>
		/// <returns></returns>
		public ClubCloud_Vereniging GetVerenigingByNummer(string bondsnummer, string verenigingNummer, bool refresh = false)
		{
			ClubCloud_Vereniging vereniging = null;

			vereniging = VerenigingByNummer(bondsnummer, verenigingNummer, refresh);
			return vereniging;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="bondsnummer"></param>
		/// <param name="verenigingId"></param>
		/// <param name="refresh"></param>
		/// <returns></returns>
		public ClubCloud_Vereniging GetVerenigingId(string bondsnummer, Guid verenigingId, bool refresh = false)
		{
			ClubCloud_Vereniging vereniging = null;
			ValidateBondsnummer(ref bondsnummer, verenigingId);
			vereniging = GetVerenigingById(bondsnummer, verenigingId, refresh);
			return vereniging;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="bondsnummer"></param>
		/// <param name="verenigingId"></param>
		/// <param name="refresh"></param>
		/// <returns></returns>
		public ClubCloud_Afhang GetVerenigingAfhangSettings(string bondsnummer, Guid verenigingId, bool refresh)
		{
			ClubCloud_Afhang afhang = null;
			ValidateBondsnummer(ref bondsnummer, verenigingId);
			afhang = beheerModel.ClubCloud_Afhangen.SingleOrDefault(a => a.VerenigingId == verenigingId);

			if (afhang == null)
			{
				afhang = beheerModel.ClubCloud_Afhangen.Create();
				afhang.Id = Guid.NewGuid();
				afhang.MaandBegin = MonthSoort.januari;
                afhang.MaandEinde = MonthSoort.december;
				afhang.BaanBegin = TimeSpan.FromHours(8);
				afhang.BaanEinde = TimeSpan.FromHours(23);
				afhang.VerenigingId = verenigingId;
				 ClubCloud_Vereniging vereniging = GetVerenigingById(bondsnummer, verenigingId, false);
				if(vereniging != null)
					afhang.ClubCloud_Vereniging = vereniging;

				beheerModel.ClubCloud_Afhangen.Add(afhang);
				beheerModel.SaveChanges();
			}
			return afhang;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="bondsnummer"></param>
		/// <param name="verenigingId"></param>
		/// <param name="afhang"></param>
		/// <param name="refresh"></param>
		/// <returns></returns>
		public ClubCloud_Afhang SetVerenigingAfhangSettings(string bondsnummer, Guid verenigingId, ClubCloud_Afhang afhang, bool refresh)
		{
			ValidateBondsnummer(ref bondsnummer, verenigingId);
			ClubCloud_Afhang tobeupdated = beheerModel.ClubCloud_Afhangen.SingleOrDefault(a => a.VerenigingId == verenigingId);
			beheerModel.Entry(tobeupdated).CurrentValues.SetValues(afhang);
			beheerModel.SaveChanges();
			tobeupdated = beheerModel.ClubCloud_Afhangen.Find(afhang.Id);
			return tobeupdated;
		}

		#endregion

		/// <summary>
		/// 
		/// </summary>
		/// <param name="bondsnummer"></param>
		/// <param name="verenigingId"></param>
		/// <param name="refresh"></param>
		/// <returns></returns>
		public List<ClubCloud_Gebruiker> GetGebruikersForReserveringById(string bondsnummer, Guid verenigingId, Guid reserveringId, bool refresh = false)
		{
			List<ClubCloud_Gebruiker> gebruikers = new List<ClubCloud_Gebruiker>();

			ClubCloud_Reservering reservering = beheerModel.ClubCloud_Reserveringen.Find(reserveringId);

			if (reservering != null || refresh)
			{
				ValidateBondsnummer(ref bondsnummer, verenigingId);
				if (reservering.Gebruiker_Een != null && reservering.Gebruiker_Een.HasValue)
				{
                    ClubCloud_Gebruiker Gebruiker_Een = GetGebruikerById(bondsnummer, reservering.Gebruiker_Een.Value, false, new ClubCloud_Setting { Id = int.Parse(bondsnummer), VerenigingId = verenigingId });
					gebruikers.Add(Gebruiker_Een);
				}

				if (reservering.Gebruiker_Twee != null && reservering.Gebruiker_Twee.HasValue)
				{
                    ClubCloud_Gebruiker Gebruiker_Twee = GetGebruikerById(bondsnummer, reservering.Gebruiker_Twee.Value, false, new ClubCloud_Setting { Id = int.Parse(bondsnummer), VerenigingId = verenigingId });
					gebruikers.Add(Gebruiker_Twee);
				}

				if (reservering.Gebruiker_Drie != null && reservering.Gebruiker_Drie.HasValue)
				{
                    ClubCloud_Gebruiker Gebruiker_Drie = GetGebruikerById(bondsnummer, reservering.Gebruiker_Drie.Value, false, new ClubCloud_Setting { Id = int.Parse(bondsnummer), VerenigingId = verenigingId });
					gebruikers.Add(Gebruiker_Drie);
				}

				if (reservering.Gebruiker_Vier != null && reservering.Gebruiker_Vier.HasValue)
				{
                    ClubCloud_Gebruiker Gebruiker_Vier = GetGebruikerById(bondsnummer, reservering.Gebruiker_Vier.Value, false, new ClubCloud_Setting { Id = int.Parse(bondsnummer), VerenigingId = verenigingId });
					gebruikers.Add(Gebruiker_Vier);
				}
			}

			return gebruikers;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="bondsnummer"></param>
		/// <param name="verenigingId"></param>
		/// <param name="refresh"></param>
		/// <returns></returns>
		public List<ClubCloud_Reservering> GetReserveringenByVerenigingId(string bondsnummer, Guid verenigingId, bool refresh = false)
		{
			List<ClubCloud_Reservering> reserveringen = new List<ClubCloud_Reservering>();

			ValidateBondsnummer(ref bondsnummer, verenigingId);

			ClubCloud_Vereniging vereniging = GetVerenigingById(bondsnummer, verenigingId, refresh, null);

			List<ClubCloud_Baan> banen = beheerModel.ClubCloud_Banen.Where(b => b.AccommodatieId == vereniging.AccommodatieId.Value).ToList();

			DateTime today = DateTime.Today;
			DateTime tomorrow = DateTime.Today.AddDays(1);
			foreach (ClubCloud_Baan baan in banen)
			{
				List<ClubCloud_Reservering> baanreserveringen = beheerModel.ClubCloud_Reserveringen.Where(r => r.BaanId.Value == baan.Id && DbFunctions.TruncateTime(r.Datum) >= today && DbFunctions.TruncateTime(r.Datum) < tomorrow).ToList();
				reserveringen.AddRange(baanreserveringen);
			}
			/*
			foreach(ClubCloud_Reservering reservering in reserveringen )
			{
				if (reservering.Gebruiker_Een.HasValue)
				{
					ClubCloud_Gebruiker gebruiker = beheerModel.ClubCloud_Gebruikers.Find(reservering.Gebruiker_Een.Value);
					reservering.ClubCloud_Gebruiker_Een = gebruiker;
				}

				if (reservering.Gebruiker_Twee.HasValue)
				{
					ClubCloud_Gebruiker gebruiker = beheerModel.ClubCloud_Gebruikers.Find(reservering.Gebruiker_Twee.Value);
					reservering.ClubCloud_Gebruiker_Twee = gebruiker;
				}

				if (reservering.Gebruiker_Drie.HasValue)
				{
					ClubCloud_Gebruiker gebruiker = beheerModel.ClubCloud_Gebruikers.Find(reservering.Gebruiker_Drie.Value);
					reservering.ClubCloud_Gebruiker_Drie = gebruiker;
				}

				if (reservering.Gebruiker_Vier.HasValue)
				{
					ClubCloud_Gebruiker gebruiker = beheerModel.ClubCloud_Gebruikers.Find(reservering.Gebruiker_Vier.Value);
					reservering.ClubCloud_Gebruiker_Vier = gebruiker;
				}
			}
			*/
			//}

			return reserveringen;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="bondsnummer"></param>
		/// <param name="nummer"></param>
		/// <param name="refresh"></param>
		/// <returns></returns>
		public List<ClubCloud_Reservering> GetReserveringenByBondsnummer(string bondsnummer, Guid verenigingId, string nummer, bool refresh = false)
		{
			List<ClubCloud_Reservering> reserveringen = new List<ClubCloud_Reservering>();

			ValidateBondsnummer(ref bondsnummer, verenigingId);

			ClubCloud_Gebruiker gebruiker = GebruikerByNummer(bondsnummer, nummer);

			DateTime today = DateTime.Today;
			DateTime tomorrow = DateTime.Today.AddDays(1);
			reserveringen = beheerModel.ClubCloud_Reserveringen.Where(r => (r.Gebruiker_Een.Value == gebruiker.Id || r.Gebruiker_Twee.Value == gebruiker.Id || r.Gebruiker_Drie.Value == gebruiker.Id || r.Gebruiker_Vier.Value == gebruiker.Id) && DbFunctions.TruncateTime(r.Datum) >= today && DbFunctions.TruncateTime(r.Datum) < tomorrow).ToList();
			return reserveringen;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="bondsnummer"></param>
		/// <param name="verenigingId"></param>
		/// <param name="date"></param>
		/// <param name="refresh"></param>
		/// <returns></returns>
        public List<ClubCloud_Reservering> GetReserveringenByDate(string bondsnummer, Guid verenigingId, DateTime date, bool refresh = false)
        {
            List<ClubCloud_Reservering> reserveringen = new List<ClubCloud_Reservering>();

            ValidateBondsnummer(ref bondsnummer, verenigingId);

            ClubCloud_Vereniging vereniging = GetVerenigingById(bondsnummer, verenigingId, refresh, null);

            List<ClubCloud_Baan> banen = beheerModel.ClubCloud_Banen.Where(b => b.AccommodatieId == vereniging.AccommodatieId.Value).ToList();

            DateTime today = date;
            DateTime tomorrow = today.AddDays(1);
            foreach (ClubCloud_Baan baan in banen)
            {
                List<ClubCloud_Reservering> baanreserveringen = beheerModel.ClubCloud_Reserveringen.Where(r => r.BaanId.Value == baan.Id && DbFunctions.TruncateTime(r.Datum) >= today && DbFunctions.TruncateTime(r.Datum) < tomorrow).ToList();
                reserveringen.AddRange(baanreserveringen);
            }
            return reserveringen;
        }

		/// <summary>
		/// 
		/// </summary>
		/// <param name="bondsnummer"></param>
		/// <param name="reserveringId"></param>
		/// <param name="refresh"></param>
		/// <returns></returns>
		public ClubCloud_Reservering GetReserveringByReserveringId(string bondsnummer, Guid verenigingId, Guid reserveringId, bool refresh = false)
		{
			ClubCloud_Reservering reservering = null;

			ValidateBondsnummer(ref bondsnummer, verenigingId);

			reservering = beheerModel.ClubCloud_Reserveringen.Find(reserveringId);

			return reservering;

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="bondsnummer"></param>
		/// <param name="baanId"></param>
		/// <param name="refresh"></param>
		/// <returns></returns>
		public List<ClubCloud_Reservering> GetReserveringenByBaanId(string bondsnummer, Guid verenigingId, Guid baanId, bool refresh = false)
		{
			List<ClubCloud_Reservering> reserveringen = new List<ClubCloud_Reservering>();

			ValidateBondsnummer(ref bondsnummer, verenigingId);

			DateTime today = DateTime.Today;
			DateTime tomorrow = DateTime.Today.AddDays(1);

			reserveringen = beheerModel.ClubCloud_Reserveringen.Where(r => r.BaanId.Value == baanId && DbFunctions.TruncateTime(r.Datum) >= today && DbFunctions.TruncateTime(r.Datum) < tomorrow).ToList();

			return reserveringen;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="bondsnummer"></param>
		/// <param name="verenigingId"></param>
		/// <param name="baanId"></param>
		/// <param name="leden"></param>
		/// <param name="tijd"></param>
		/// <param name="final"></param>
		/// <param name="push"></param>
		/// <returns></returns>
		public ClubCloud_Reservering AddReservering(string bondsnummer, Guid verenigingId, Guid baanId, Guid[] gebruikers, DateTime Datum, TimeSpan Tijd, TimeSpan Duur, ReserveringSoort Soort = ReserveringSoort.Afhangen, bool final = false, bool push = false, string Beschrijving = "")
		{
			ClubCloud_Reservering reservering = new ClubCloud_Reservering();
			try
			{

				reservering = beheerModel.ClubCloud_Reserveringen.Create();
				reservering.Id = Guid.NewGuid();

				ClubCloud_Baan baan = beheerModel.ClubCloud_Banen.Find(baanId);
				if (baan != null)
				{
					reservering.BaanId = baanId;
					reservering.ClubCloud_Baan = baan;
				}

				reservering.Datum = Datum;
				reservering.Tijd = Tijd;
				reservering.Duur = Duur;
				reservering.ReserveringSoort = Soort;
				reservering.Beschrijving = Beschrijving;
				reservering.Final = final;

				foreach (Guid gebruiker in gebruikers)
				{
					if (reservering.Gebruiker_Een == null)// || reservering.Gebruiker_Een.Value != Guid.Empty)
					{
						ClubCloud_Gebruiker speler = beheerModel.ClubCloud_Gebruikers.Find(gebruiker);
						if (speler != null)
						{
							reservering.Gebruiker_Een = gebruiker;
							reservering.ClubCloud_Gebruiker_Een = speler;
						}
						continue;
					}

					if (reservering.Gebruiker_Twee == null)// || reservering.Gebruiker_Twee.Value != Guid.Empty)
					{
						ClubCloud_Gebruiker speler = beheerModel.ClubCloud_Gebruikers.Find(gebruiker);
						if (speler != null)
						{
							reservering.Gebruiker_Twee = gebruiker;
							reservering.ClubCloud_Gebruiker_Twee = speler;
						}
						continue;
					}

					if (reservering.Gebruiker_Drie == null)// || reservering.Gebruiker_Drie.Value != Guid.Empty)
					{
						ClubCloud_Gebruiker speler = beheerModel.ClubCloud_Gebruikers.Find(gebruiker);
						if (speler != null)
						{
							reservering.Gebruiker_Drie = gebruiker;
							reservering.ClubCloud_Gebruiker_Drie = speler;
						}

						continue;
					}

					if (reservering.Gebruiker_Vier == null)// || reservering.Gebruiker_Vier.Value != Guid.Empty)
					{
						ClubCloud_Gebruiker speler = beheerModel.ClubCloud_Gebruikers.Find(gebruiker);
						if (speler != null)
						{
							reservering.Gebruiker_Vier = gebruiker;
							reservering.ClubCloud_Gebruiker_Vier = speler;
						}

						continue;
					}
				}
				beheerModel.ClubCloud_Reserveringen.Add(reservering);
				beheerModel.SaveChanges();
			}
			catch (Exception ex)
			{
				throw new Exception("Saving error:"+ ex.Message);
			}

			return reservering;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="bondsnummer"></param>
		/// <param name="verenigingId"></param>
		/// <param name="reserveringId"></param>
		/// <param name="baanId"></param>
		/// <param name="leden"></param>
		/// <param name="tijd"></param>
		/// <param name="final"></param>
		/// <param name="push"></param>
		/// <returns></returns>
		public ClubCloud_Reservering UpdateReservering(string bondsnummer, Guid verenigingId, ClubCloud_Reservering reservering, bool final = false, bool push = false)
		{
			ClubCloud_Reservering Ureservering = beheerModel.ClubCloud_Reserveringen.Find(reservering.Id);

			if (Ureservering != null)
			{

				ClubCloud_Baan baan = beheerModel.ClubCloud_Banen.Find(reservering.BaanId);
				if (baan != null)
				{
					Ureservering.BaanId = reservering.BaanId;
					Ureservering.ClubCloud_Baan = baan;
				}

				//Ureservering.BaanId = reservering.BaanId;
				Ureservering.Datum = reservering.Datum;
				Ureservering.Tijd = reservering.Tijd;
				Ureservering.Duur = reservering.Duur;
                Ureservering.ReserveringSoort = reservering.ReserveringSoort;
				Ureservering.Beschrijving = reservering.Beschrijving;
				Ureservering.Final = reservering.Final;

				Ureservering.Gebruiker_Een = null;
				if (reservering.Gebruiker_Een != null && reservering.Gebruiker_Een.Value != Guid.Empty)
				{
					ClubCloud_Gebruiker speler = beheerModel.ClubCloud_Gebruikers.Find(reservering.Gebruiker_Een.Value);
					if (speler != null)
					{
						Ureservering.Gebruiker_Een = reservering.Gebruiker_Een.Value;
						Ureservering.ClubCloud_Gebruiker_Een = speler;
					}

					//Ureservering.Gebruiker_Een = reservering.Gebruiker_Een.Value;
				}

				Ureservering.Gebruiker_Twee = null;
				if (reservering.Gebruiker_Twee != null && reservering.Gebruiker_Twee.Value != Guid.Empty)
				{
					ClubCloud_Gebruiker speler = beheerModel.ClubCloud_Gebruikers.Find(reservering.Gebruiker_Een.Value);
					if (speler != null)
					{
						Ureservering.Gebruiker_Twee = reservering.Gebruiker_Een.Value;
						Ureservering.ClubCloud_Gebruiker_Drie = speler;
					}

					//Ureservering.Gebruiker_Twee = reservering.Gebruiker_Twee.Value;
				}

				Ureservering.Gebruiker_Drie = null;
				if (reservering.Gebruiker_Twee != null && reservering.Gebruiker_Drie.Value != Guid.Empty)
				{
					ClubCloud_Gebruiker speler = beheerModel.ClubCloud_Gebruikers.Find(reservering.Gebruiker_Een.Value);
					if (speler != null)
					{
						Ureservering.Gebruiker_Twee = reservering.Gebruiker_Een.Value;
						Ureservering.ClubCloud_Gebruiker_Drie = speler;
					}

					//Ureservering.Gebruiker_Drie = reservering.Gebruiker_Drie.Value;
				}

				Ureservering.Gebruiker_Vier = null;
				if (reservering.Gebruiker_Vier != null && reservering.Gebruiker_Vier.Value != Guid.Empty)
				{
					ClubCloud_Gebruiker speler = beheerModel.ClubCloud_Gebruikers.Find(reservering.Gebruiker_Een.Value);
					if (speler != null)
					{
						Ureservering.Gebruiker_Vier = reservering.Gebruiker_Een.Value;
						Ureservering.ClubCloud_Gebruiker_Vier = speler;
					}

					//Ureservering.Gebruiker_Vier = reservering.Gebruiker_Vier.Value;
				}
			}
			beheerModel.SaveChanges();

			return reservering;
		}

        /*
		/// <summary>
		/// 
		/// </summary>
		/// <param name="bondsnummer"></param>
		/// <param name="verenigingId"></param>
		/// <param name="reserveringId"></param>
		/// <param name="push"></param>
		/// <returns></returns>
		public bool DeleteReservering(string bondsnummer, Guid verenigingId, Guid reserveringId, bool push = false)
		{
			try
			{
				ClubCloud_Reservering reservering = beheerModel.ClubCloud_Reserveringen.Find(reserveringId);
				beheerModel.ClubCloud_Reserveringen.Remove(reservering);
				beheerModel.SaveChanges();
			}
			catch (Exception)
			{
				return false;
			}
			return true;
		}
        */

		#region Banen
        /*
		/// <summary>
		/// 
		/// </summary>
		/// <param name="bondsnummer"></param>
		/// <param name="verenigingId"></param>
		/// <param name="refresh"></param>
		/// <returns></returns>
		public List<ClubCloud_Baan> GetBanenByVerenigingId(string bondsnummer, Guid verenigingId, bool refresh = false)
		{
			ValidateBondsnummer(ref bondsnummer, verenigingId);
			List<ClubCloud_Baan> banen = new List<ClubCloud_Baan>();

			ClubCloud_Vereniging vereniging = GetVerenigingById(bondsnummer, verenigingId, refresh);

			if (vereniging != null)
			{
				banen = GetBanenByAccommodatieId(bondsnummer, vereniging.AccommodatieId.Value, refresh);
			}
			return banen;
		}
        */
        /*
		/// <summary>
		/// 
		/// </summary>
		/// <param name="bondsnummer"></param>
		/// <param name="accommodatieId"></param>
		/// <param name="refresh"></param>
		/// <returns></returns>
		public List<ClubCloud_Baan> GetBanenByAccommodatieId(string bondsnummer, Guid verenigingId, Guid accommodatieId, bool refresh = false)
		{
			List<ClubCloud_Baan> banen = new List<ClubCloud_Baan>();
			ValidateBondsnummer(ref bondsnummer, verenigingId);
			banen = GetBanenByAccommodatieId(bondsnummer, accommodatieId, refresh);
			return banen;
		}
        */
        /*
		/// <summary>
		/// 
		/// </summary>
		/// <param name="bondsnummer"></param>
		/// <param name="verenigingId"></param>
		/// <param name="baanId"></param>
		/// <param name="refresh"></param>
		/// <returns></returns>
		public ClubCloud_Baan GetBaanById(string bondsnummer, Guid verenigingId, Guid baanId, bool refresh = false)
		{
			ClubCloud_Baan baan = new ClubCloud_Baan();
			ValidateBondsnummer(ref bondsnummer, verenigingId);
			baan = GetBaanById(bondsnummer, baanId, refresh);
			return baan;
		}
        */

		/// <summary>
		/// 
		/// </summary>
		/// <param name="bondsnummer"></param>
		/// <param name="verenigingId"></param>
		/// <param name="refresh"></param>
		/// <returns></returns>
		public List<ClubCloud_Baanschema> GetBaanSchemaByVerenigingId(string bondsnummer, Guid verenigingId, bool refresh = false)
		{
			return GetBaanSchemaByDate(bondsnummer, verenigingId, DateTime.Now, refresh);
			/*
			List<ClubCloud_Baanschema> baanschema = new List<ClubCloud_Baanschema>();

			ValidateBondsnummer(ref bondsnummer, verenigingId);

			List<ClubCloud_Baan> banen = GetBanenByVerenigingId(bondsnummer, verenigingId, refresh);

			if (banen != null && banen.Count > 0 || refresh)
			{
				Month maand = (Month) Enum.Parse(typeof(Model.Month), DateTime.Now.Month.ToString());
				foreach (ClubCloud_Baan baan in banen)
				{
					List<ClubCloud_Baanschema> schemaperbaan = beheerModel.ClubCloud_Baanschemas.Where(b => b.BaanId.Value == baan.Id && b.VerenigingId == verenigingId && b.Beschikbaar == true && b.MaandBegin <= maand && b.MaandEinde >= maand).ToList();
					if(schemaperbaan != null && schemaperbaan.Count > 0)
						baanschema.AddRange(schemaperbaan);
				}
			}

			return baanschema;
			*/
		}

		public List<ClubCloud_Baanschema> GetBaanSchemaByDate(string bondsnummer, Guid verenigingId, DateTime date, bool refresh = false)
		{
			if (date == null)
				date = DateTime.Now;

			List<ClubCloud_Baanschema> baanschema = new List<ClubCloud_Baanschema>();

			ValidateBondsnummer(ref bondsnummer, verenigingId);

            ClubCloud_Accommodatie accommodatie = GetAccommodatieForVerenigingById(verenigingId, refresh, new ClubCloud_Setting { Id = int.Parse(bondsnummer), VerenigingId = verenigingId });

            List<ClubCloud_Baan> banen = GetBanenForAccommodatie(accommodatie, refresh, new ClubCloud_Setting { Id = int.Parse(bondsnummer), VerenigingId = verenigingId });

			if (banen != null && banen.Count > 0 || refresh)
			{
                MonthSoort maand = (MonthSoort)Enum.Parse(typeof(Model.MonthSoort), date.Month.ToString());
				foreach (ClubCloud_Baan baan in banen)
				{
					List<ClubCloud_Baanschema> schemaperbaan = beheerModel.ClubCloud_Baanschemas.Where(b => b.BaanId.Value == baan.Id && b.VerenigingId == verenigingId && b.Beschikbaar == true && b.MaandBegin <= maand && b.MaandEinde >= maand).ToList();
					if (schemaperbaan != null && schemaperbaan.Count > 0)
						baanschema.AddRange(schemaperbaan);
				}
			}

			return baanschema;

		}

        /*
		/// <summary>
		/// 
		/// </summary>
		/// <param name="bondsnummer"></param>
		/// <param name="accommodatieId"></param>
		/// <param name="refresh"></param>
		/// <returns></returns>
		public List<ClubCloud_Baanschema> GetBaanSchemaByAccommodatieId(string bondsnummer, Guid verenigingId, Guid accommodatieId, bool refresh = false)
		{
			List<ClubCloud_Baanschema> baanschema = new List<ClubCloud_Baanschema>();

			ValidateBondsnummer(ref bondsnummer, verenigingId);
			List<ClubCloud_Baan> banen = GetBanenByAccommodatieId(bondsnummer, accommodatieId, refresh);

			if (banen != null && banen.Count > 0 || refresh)
			{

				//if (beheerModel == null)
				//{
				//    beheerModel = new Model.BeheerContainer(GetConnectionString());
				//}

				//using (ClubCloud.Model.BeheerContainer model = new Model.BeheerContainer(GetConnectionString()))
				//{


				foreach (ClubCloud_Baan baan in banen)
				{
					List<ClubCloud_Baanschema> schemaperbaan = beheerModel.ClubCloud_Baanschemas.Where(b => b.BaanId.Value == baan.Id).ToList();
					baanschema.AddRange(schemaperbaan);
				}
				//}
			}

			return baanschema;
		}
        */

		public List<ClubCloud_Baanblok> GetBaanblokkenByAccommodatieId(string bondsnummer, Guid verenigingId, Guid accommodatieId, bool refresh)
		{
			List<ClubCloud_Baanblok> baanblokken = new List<ClubCloud_Baanblok>();

			ValidateBondsnummer(ref bondsnummer, verenigingId);

            baanblokken = GetBaanblokkenForAccommodatieById(accommodatieId, refresh, new ClubCloud_Setting { Id = int.Parse(bondsnummer), VerenigingId = verenigingId });

			return baanblokken;
		}
        /*
		public ClubCloud_Baansoort GetBaansoortById(string bondsnummer, Guid verenigingId, Guid accommodatieId, Guid baansoortId, bool refresh)
		{
			ClubCloud_Baansoort baansoort = new ClubCloud_Baansoort();
			ValidateBondsnummer(ref bondsnummer, verenigingId);

			baansoort = GetBaansoortById(bondsnummer, baansoortId, refresh);

			return baansoort;
		}
        */

        /*
		public ClubCloud_Baantype GetBaantypeById(string bondsnummer, Guid verenigingId, Guid accommodatieId, Guid baantypeId, bool refresh)
		{
			ClubCloud_Baantype baantype = new ClubCloud_Baantype();
			ValidateBondsnummer(ref bondsnummer, verenigingId);

			baantype = GetBaantypeById(bondsnummer, baantypeId, refresh);

			return baantype;
		}
        */

		#endregion
        /*
		public List<ClubCloud_Gebruiker> GetGebruikersBySearch(string bondsnummer, string prefixText, int count, bool refresh = false)
		{
			string fts = BeheerFullTextInterceptor.Fts(prefixText);


			//if (beheerModel == null)
			//{
			//    beheerModel = new Model.BeheerContainer(GetConnectionString());
			//}

			//using (ClubCloud.Model.BeheerContainer model = new Model.BeheerContainer(GetConnectionString()))
			//{

			List<ClubCloud_Gebruiker> gebruikers = beheerModel.ClubCloud_Gebruikers.Where(g => g.Volledigenaam.Contains(fts)).Take(count).ToList();
			return gebruikers;
			//}
			//return new List<ClubCloud_Gebruiker>();
		}
        */

		#endregion

		#region Beheer

        /*
		public ClubCloud_Gebruiker_DataView GetGebruikersByQuery(string bondsnummer, Guid verenigingId, System.Web.UI.DataSourceSelectArguments selectArgs = null, List<System.Web.UI.WebControls.Parameter> parameters = null, bool refresh = false)
		{
			ClubCloud_Gebruiker_DataView gebruikersDV = new ClubCloud_Gebruiker_DataView();

			ValidateBondsnummer(ref bondsnummer, verenigingId);

            //GetClubCloud_GebruikersByQuery(selectArgs, parameters);
			//if (beheerModel == null)
			//{
			//    beheerModel = new Model.BeheerContainer(GetConnectionString());
			//}

			//using (ClubCloud.Model.BeheerContainer model = new Model.BeheerContainer(GetConnectionString()))
			//{

			StringBuilder querybuilder = new StringBuilder("SELECT * FROM dbo.ClubCloud_Gebruiker");
			List<SqlParameter> sqlparams = new List<SqlParameter>();
			List<SqlParameter> sqlparamscount = new List<SqlParameter>();
			string and = " AND ";
			if (parameters != null && parameters.Count > 0)
			{
				querybuilder.Append(" WHERE ");

				foreach (System.Web.UI.WebControls.Parameter parameter in parameters)
				{
					querybuilder.Append(parameter.Name + " = @" + parameter.Name + and);
					Type type = TypeConvertor.ToNetType(parameter.DbType);
					object value = TypeDescriptor.GetConverter(type).ConvertFrom(parameter.DefaultValue);// typeof(string)));

					sqlparams.Add(new SqlParameter { Value = value, ParameterName = "@" + parameter.Name, DbType = parameter.DbType, Direction = parameter.Direction });
					sqlparamscount.Add(new SqlParameter { Value = value, ParameterName = "@" + parameter.Name, DbType = parameter.DbType, Direction = parameter.Direction });
				}

				querybuilder.Remove(querybuilder.Length - and.Length, and.Length);

			}

			if (!string.IsNullOrWhiteSpace(selectArgs.SortExpression))
			{
				querybuilder.Append(" ORDER BY " + selectArgs.SortExpression);
			}

			gebruikersDV.ClubCloud_Gebruiker = beheerModel.Database.SqlQuery<ClubCloud_Gebruiker>(querybuilder.ToString(), sqlparams.ToArray()).Skip(selectArgs.StartRowIndex).Take(selectArgs.MaximumRows).ToList<ClubCloud_Gebruiker>();

			if (selectArgs.RetrieveTotalRowCount)
			{

				gebruikersDV.TotalRowCount = beheerModel.Database.SqlQuery<ClubCloud_Gebruiker>(querybuilder.ToString(), sqlparamscount.ToArray()).Count();
			}
			//}
			return gebruikersDV;
		}
        */

		/*
		internal static void Where(Type type, string name, System.Web.UI.WebControls.ParameterCollection parameters)
		{
			System.Web.UI.WebControls.LinqDataSource source = new System.Web.UI.WebControls.LinqDataSource();
			source.WhereParameters.Add(parameters[0]);
			//source.
			foreach (System.Web.UI.WebControls.Parameter parameter in parameters)
			{
				//System.Linq.Queryable q= Queryable.Where()
			}
		}
		*/

		internal static Expression GebruikerOrderByExpression(string expression)
		{
			try
			{
				if (expression.Contains("DESC"))
				{
					expression = expression.Replace("DESC", "").Trim();
				}

				ParameterExpression param = Expression.Parameter(typeof(ClubCloud_Gebruiker), "gebruiker");
				//Expression.Convert(Expression.Property(param, expression));
				return Expression.Lambda<Func<ClubCloud_Gebruiker, object>>(Expression.Convert(Expression.Property(param, expression), typeof(object)), param);

				//List<ClubCloud_Gebruiker> source = new List<ClubCloud_Gebruiker> ();
				//source.AsQueryable<ClubCloud_Gebruiker>().OrderByDescending<ClubCloud_Gebruiker, object>(sortExpression,param);
				/*
				if (!SortDescending)
					return source.AsQueryable<ClubCloud_Gebruiker>().OrderBy<ClubCloud_Gebruiker, object>(sortExpression);
				else
					return source.AsQueryable<ClubCloud_Gebruiker>().OrderByDescending<ClubCloud_Gebruiker, object>(sortExpression);
				 */
			}
			catch
			{
				return null;
			}
		}

		/*
		private List<ClubCloud_Gebruiker> SortGebruikers(List<ClubCloud_Gebruiker> gebuikers, string sort)
		{
			switch (sort.ToLower())
			{
				default:
					gebuikers = gebuikers.OrderBy(u => u.FirstName).ThenBy(u => u.LastName);
					break;
				case "namedesc":
					gebuikers = gebuikers.OrderByDescending(u => u.FirstName).ThenByDescending(u => u.LastName);
					break;
				case "emailasc":
					gebuikers = gebuikers.OrderBy(u => u.Email);
					break;
				case "emaildesc":
					gebuikers = gebuikers.OrderByDescending(u => u.Email);
					break;
				case "typeasc":
					gebuikers = gebuikers.OrderBy(u => u.UsertypeSortingOrder);
					break;
				case "typedesc":
					gebuikers = gebuikers.OrderByDescending(u => u.UsertypeSortingOrder);
					break;
			}
			return gebuikers;
		}
		*/

		#endregion

		#region Administrator

		public void TriggerMetaData(string bondsnummer, bool refresh)
		{
			beheerModel.Database.Initialize(refresh);
			ClubCloud_Setting settings = GetSettings(bondsnummer);

            if (settings != null)
            {
                CookieContainer cc = RequestContainer(settings.Id.ToString(), settings.Password);

                if (cc != null)
                {
                    using (ClubCloud.KNLTB.ServIt.CrmService.CrmService service = CrmServices[settings.Id.ToString()])
                    {
                        WhoAmIResponse response = service.Execute(new WhoAmIRequest()) as WhoAmIResponse;
                    }
                }
            }
		}

		public void NationaliteitenUpdate(string bondsnummer, bool refresh)
		{
			GetNationaliteiten(bondsnummer, true, null);
		}

        public void LandenUpdate(string bondsnummer, bool refresh)
        {
            GetLanden(bondsnummer, true, null);
        }

        public void BouwaardenUpdate(string bondsnummer, bool refresh)
        {
            GetBouwaarden(bondsnummer, true, null);
        }

		public void DistrictenUpdate(string bondsnummer, bool refresh)
		{
			GetDistricten(bondsnummer, true, null);
		}

		public void RechtsvormenUpdate(string bondsnummer, bool refresh)
		{
			GetRechtsvormen(bondsnummer, true, null);
		}

		public void FunctiesUpdate(string bondsnummer, bool refresh)
		{
			GetFuncties(bondsnummer, true, null);
		}

		public void BestuursOrganenUpdate(string bondsnummer, bool refresh)
		{
			GetBestuursorganen(bondsnummer, true, null);
		}

		public void LidmaatschapSoortenUpdate(string bondsnummer, bool refresh)
		{
			GetLidmaatschapsoorten(bondsnummer, true, null);
		}

		public void RegiosUpdate(string bondsnummer, bool refresh)
		{
			GetRegios(bondsnummer, true, null);
		}

		public void ToplagenUpdate(string bondsnummer, bool refresh)
		{
			GetBaantoplagen(bondsnummer, true, null);
		}

		public void BaansoortenUpdate(string bondsnummer, bool refresh)
		{
			GetBaansoorten(bondsnummer, true, null);
		}

		public void BaantypesUpdate(string bondsnummer, bool refresh)
		{
			GetBaantypes(bondsnummer, true, null);
		}

		public void BanenSpeciaalUpdate(string bondsnummer, bool refresh)
		{
			GetBanenSpeciaal(bondsnummer, true, null);
		}

		public void BaanBlokkenUpdate(string bondsnummer, bool refresh)
		{
            GetBaanblokken(bondsnummer, true, null);
		}

		public void BanenUpdate(string bondsnummer, bool refresh)
		{
			GetBanen(bondsnummer, true, null);
		}

        /*
        public void AccommodatiesUpdate(string bondsnummer, bool refresh)
        {
            GetAccommodaties(bondsnummer, true, null);
        }
        */

        public bool AccommodatiesUpdate(string bondsnummer, int pageNum, bool refresh)
        {
            bool moreRecords = true;

            ClubCloud_Setting settings = GetSettings(bondsnummer);

            if (settings != null && settings.Access && !string.IsNullOrWhiteSpace(settings.Password))
            {
                CookieContainer cc = RequestContainer(settings.Id.ToString(), settings.Password);

                if (cc != null)
                {
                    using (ClubCloud.KNLTB.ServIt.CrmService.CrmService service = CrmServices[settings.Id.ToString()])
                    {
                        List<BusinessEntity> entities = RetrieveMultiple(service, "sgt_alg_accommodatie", out moreRecords, ref pageNum);

                        foreach (sgt_alg_accommodatie accommodatie in entities)
                        {
                            ClubCloud_Accommodatie entity = beheerModel.ClubCloud_Accommodaties.Find(accommodatie.sgt_alg_accommodatieid.Value);

                            if (entity == null)
                                entity = beheerModel.ClubCloud_Accommodaties.Create();

                            entity.Id = accommodatie.sgt_alg_accommodatieid.Value;

                            AccommodatieToEntity(accommodatie, entity, settings);

                            beheerModel.ClubCloud_Accommodaties.AddOrUpdate(entity);
                        }

                        beheerModel.SaveChanges();

                        foreach (sgt_alg_accommodatie accommodatie in entities)
                        {
                            if (accommodatie.sgt_alg_accommodatieid.Value != null)
                            {

                                ClubCloud_Accommodatie entity = beheerModel.ClubCloud_Accommodaties.Find(accommodatie.sgt_alg_accommodatieid.Value);

                                List<ClubCloud_Address> adressen = beheerModel.ClubCloud_Addressen.Where(b => b.ParentId.Value == accommodatie.sgt_alg_accommodatieid.Value).ToList();

                                ClubCloud_Address bezoek_entity = null;
                                ClubCloud_Address post_entity = null;

                                if (adressen != null && adressen.Count > 0)
                                {
                                    bezoek_entity = adressen.SingleOrDefault(a => a.Naam == AddressSoort.Bezoekadres);
                                    post_entity = adressen.SingleOrDefault(a => a.Naam == AddressSoort.Postadres);
                                }

                                if (bezoek_entity == null)
                                { bezoek_entity = beheerModel.ClubCloud_Addressen.Create(); bezoek_entity.Id = Guid.NewGuid(); bezoek_entity.ParentId = accommodatie.sgt_alg_accommodatieid.Value; }

                                if (post_entity == null)
                                { post_entity = beheerModel.ClubCloud_Addressen.Create(); post_entity.Id = Guid.NewGuid(); post_entity.ParentId = accommodatie.sgt_alg_accommodatieid.Value; }


                                if (accommodatie.sgt_bezoekadreslandcodeid != null)
                                {
                                    bezoek_entity.LandId = accommodatie.sgt_bezoekadreslandcodeid.Value;
                                }

                                bezoek_entity.Naam = AddressSoort.Bezoekadres;
                                bezoek_entity.Gemeente = accommodatie.sgt_bezoekadres_gemeente;
                                bezoek_entity.Nummer = accommodatie.sgt_bezoekadres_huisnummer;
                                bezoek_entity.Stad = accommodatie.sgt_bezoekadres_plaats;
                                bezoek_entity.Postcode = accommodatie.sgt_bezoekadres_postcode;
                                bezoek_entity.Straat = accommodatie.sgt_bezoekadres_straat;
                                bezoek_entity.Toevoeging = accommodatie.sgt_bezoekadres_toevoeging;
                                bezoek_entity.Actief = ActiefSoort.Actief;
                                bezoek_entity.Gewijzigd = DateTime.Now;

                                beheerModel.ClubCloud_Addressen.AddOrUpdate(bezoek_entity);

                                if (accommodatie.sgt_postadreslandcodeid != null)
                                {
                                    post_entity.LandId = accommodatie.sgt_bezoekadreslandcodeid.Value;
                                }

                                post_entity.Naam = AddressSoort.Postadres;
                                post_entity.Gemeente = accommodatie.sgt_bezoekadres_gemeente;
                                post_entity.Nummer = accommodatie.sgt_bezoekadres_huisnummer;
                                post_entity.Stad = accommodatie.sgt_bezoekadres_plaats;
                                post_entity.Postcode = accommodatie.sgt_bezoekadres_postcode;
                                post_entity.Straat = accommodatie.sgt_bezoekadres_straat;
                                post_entity.Toevoeging = accommodatie.sgt_bezoekadres_toevoeging;
                                post_entity.Actief = ActiefSoort.Actief;
                                post_entity.Gewijzigd = DateTime.Now;

                                beheerModel.ClubCloud_Addressen.AddOrUpdate(post_entity);

                                beheerModel.SaveChanges();

                                bezoek_entity.ClubCloud_Accommodatie = entity;
                                if (accommodatie.sgt_bezoekadreslandcodeid != null)
                                {
                                    ClubCloud_Land land = GetLandById(accommodatie.sgt_bezoekadreslandcodeid.Value, false, settings);
                                    bezoek_entity.ClubCloud_Land = land;
                                }

                                post_entity.ClubCloud_Accommodatie = entity;
                                if (accommodatie.sgt_postadreslandcodeid != null)
                                {
                                    ClubCloud_Land land = GetLandById(accommodatie.sgt_postadreslandcodeid.Value, false, settings);
                                    post_entity.ClubCloud_Land = land;
                                }

                                beheerModel.SaveChanges();


                                if (accommodatie.sgt_districtid != null)
                                {
                                    ClubCloud_District district = GetDistrictById(accommodatie.sgt_districtid.Value, false, settings);
                                    if (district != null)
                                        entity.ClubCloud_District = district;
                                }

                                if (accommodatie.sgt_regioid != null)
                                {
                                    ClubCloud_Regio regio = GetRegioById(accommodatie.sgt_regioid.Value, false, settings);
                                    if (regio != null)
                                        entity.ClubCloud_Regio = regio;
                                }

                                beheerModel.SaveChanges();
                            }
                        }

                        beheerModel.SaveChanges();
                    }
                }
            }
            return moreRecords;
        }
        
		/// <summary>
		/// 
		/// </summary>
		/// <param name="bondsnummer"></param>
		/// <param name="verenigingNummer"></param>
		/// <param name="refresh"></param>
		/// <param name="settings"></param>
		public bool VerenigingenUpdate(string bondsnummer, int pageNum = 1, bool refresh = false)
		{
			bool moreRecords = true;

			ClubCloud_Setting settings = GetSettings(bondsnummer);

			if (settings != null && settings.Access && !string.IsNullOrWhiteSpace(settings.Password))
			{
				CookieContainer cc = RequestContainer(settings.Id.ToString(), settings.Password);

				if (cc != null)
				{
					using (ClubCloud.KNLTB.ServIt.CrmService.CrmService service = CrmServices[settings.Id.ToString()])
					{

						ConditionExpression condition = new ConditionExpression { AttributeName = "sgt_vereniging", Operator = ConditionOperator.Equal, Values = new object[1] { true } };
						FilterExpression expression = new FilterExpression { FilterOperator = LogicalOperator.And, Conditions = new ConditionExpression[1] { condition } };

						List<BusinessEntity> entities = RetrieveMultiple(service, "account", out moreRecords, ref pageNum, expression);

                        foreach (account entity in entities)
                        {
                            ClubCloud_Vereniging vereniging = beheerModel.ClubCloud_Verenigingen.Find(entity.accountid.Value);

                            if (vereniging == null)
                                vereniging = beheerModel.ClubCloud_Verenigingen.Create();

                            vereniging.Id = entity.accountid.Value;
                            VerenigingToEntity(entity, vereniging, settings);

                            beheerModel.ClubCloud_Verenigingen.AddOrUpdate(vereniging);
                        }

                        beheerModel.SaveChanges();

                        foreach (account account in entities)
                        {
                            ClubCloud_Vereniging entity = beheerModel.ClubCloud_Verenigingen.Find(account.accountid.Value);

                            if (account.sgt_districtid != null)
                            {
                                ClubCloud_District district = GetDistrictById(account.sgt_districtid.Value, false, settings);
                                entity.ClubCloud_District = district;
                                //account.DistrictId = account.sgt_districtid.Value;
                            }

                            if (account.sgt_rechtsvormid != null)
                            {
                                ClubCloud_Rechtsvorm rechtsvorm = GetRechtsvormById(account.sgt_rechtsvormid.Value, false, settings);
                                entity.ClubCloud_Rechtsvorm = rechtsvorm;
                                //account.RechtsvormId = account.sgt_rechtsvormid.Value;
                            }

                            if (account.sgt_hoofdaccomodatieid != null)
                            {
                                ClubCloud_Accommodatie Accommodatie = GetAccommodatieById(account.sgt_hoofdaccomodatieid.Value, false, settings);
                                entity.ClubCloud_Accommodatie = Accommodatie;
                                //account.AccommodatieId = account.sgt_hoofdaccomodatieid.Value;
                            }

                            if (account.parentaccountid != null)
                            {
                                ClubCloud_Regio regio = GetRegioById(account.parentaccountid.Value, false, settings);
                                entity.ClubCloud_Regio = regio;
                                //account.RegioId = account.parentaccountid.Value;
                            }

                            if (account.address1_addressid != null)
                            {
                                ClubCloud_Address bezoek = GetAddressById(account.address1_addressid.Value, false, settings);
                                entity.ClubCloud_Address.Add(bezoek);
                            }

                            if (account.address2_addressid != null)
                            {
                                ClubCloud_Address post = GetAddressById(account.address2_addressid.Value, false, settings);
                                entity.ClubCloud_Address.Add(post);
                            }
                        }

                        beheerModel.SaveChanges();

                        foreach (account account in entities)
                        {
                            ClubCloud_Vereniging entity = beheerModel.ClubCloud_Verenigingen.Find(account.accountid.Value);

                            CreateOrUpdateMembershipVereniging(entity, settings);
                        }


					}
				}
			}
			return moreRecords;
		}

		public bool GebruikersUpdate(string bondsnummer, string verenigingNummer, int pageNum = 1, bool refresh = false)
		{
			bool moreRecords = true;

			ClubCloud_Setting settings = GetSettings(bondsnummer);
			ClubCloud_Vereniging vereniging = VerenigingByNummer(bondsnummer, verenigingNummer, refresh);

			if (settings != null && settings.Access && !string.IsNullOrWhiteSpace(settings.Password))
			{
				CookieContainer cc = RequestContainer(settings.Id.ToString(), settings.Password);

				if (cc != null)
				{
                    using (ClubCloud.KNLTB.ServIt.CrmService.CrmService service = CrmServices[settings.Id.ToString()])
                    {

                        ConditionExpression condition = new ConditionExpression { AttributeName = "sgt_primaire_vereniging_id", Operator = ConditionOperator.Equal, Values = new object[1] { vereniging.Id } };
                        FilterExpression expression = new FilterExpression { FilterOperator = LogicalOperator.And, Conditions = new ConditionExpression[1] { condition } };

                        List<BusinessEntity> entities = RetrieveMultiple(service, "contact", out moreRecords, ref pageNum, expression);

                        foreach (contact contact in entities)
                        {
                            ClubCloud_Gebruiker gebruiker = beheerModel.ClubCloud_Gebruikers.Find(contact.contactid.Value);

                            if (gebruiker == null)
                                gebruiker = beheerModel.ClubCloud_Gebruikers.Create();

                            gebruiker.Id = contact.contactid.Value;

                            GebruikerToEntity(contact, gebruiker, settings);

                            beheerModel.ClubCloud_Gebruikers.AddOrUpdate(gebruiker);
                        }
                        beheerModel.SaveChanges();

                        foreach (contact contact in entities)
                        {
                            ClubCloud_Gebruiker entity = beheerModel.ClubCloud_Gebruikers.Find(contact.contactid.Value);

                            entity.VerenigingId = vereniging.Id;
                            entity.ClubCloud_Vereniging = vereniging;

                            if (contact.parentcustomerid != null)
                            {
                                vereniging = GetVerenigingById(contact.parentcustomerid.Value, false, settings);
                                if (vereniging != null)
                                    entity.ClubCloud_Vereniging = vereniging;
                            }

                            if (contact.sgt_nationaliteitid != null)
                            {
                                ClubCloud_Nationaliteit nationaliteit = GetNationaliteitById(contact.sgt_nationaliteitid.Value, false, settings);
                                if (nationaliteit != null)
                                    entity.ClubCloud_Nationaliteit = nationaliteit;
                            }

                            if (contact.address1_addressid != null)
                            {
                                ClubCloud_Address bezoek = GetAddressById(contact.address1_addressid.Value, false, settings);
                                if (bezoek != null)
                                    entity.ClubCloud_Address.Add(bezoek);
                            }

                            if (contact.address2_addressid != null)
                            {
                                ClubCloud_Address post = GetAddressById(contact.address2_addressid.Value, false, settings);
                                if (post != null)
                                    entity.ClubCloud_Address.Add(post);
                            }
                        }

                        beheerModel.SaveChanges();

                        foreach (contact contact in entities)
                        {
                            int _bondsnummer;
                            if (int.TryParse(contact.sgt_bondsnummer, out _bondsnummer))
                            {
                                ClubCloud_Setting usersettings = beheerModel.ClubCloud_Settings.Find(_bondsnummer);

                                if (usersettings == null)
                                    usersettings = beheerModel.ClubCloud_Settings.Create();

                                usersettings.Id = _bondsnummer;
                                usersettings.Access = false;
                                usersettings.Agree = false;
                                usersettings.facebook_allow = false;
                                usersettings.facebook_setting = Facebook.None;
                                usersettings.financieel = Financieel.None;
                                usersettings.privacy = Privacy.None;
                                usersettings.twitter_allow = false;
                                usersettings.twitter_setting = Twitter.None;

                                usersettings.VerenigingId = vereniging.Id;
                                usersettings.ClubCloud_Vereniging = vereniging;

                                if (contact.parentcustomerid != null)
                                    usersettings.VerenigingId = contact.parentcustomerid.Value;

                                if (contact.contactid != null)
                                    usersettings.GebruikerId = contact.contactid.Value;

                                usersettings.Gewijzigd = DateTime.Now;
                                beheerModel.ClubCloud_Settings.AddOrUpdate(usersettings);
                            }
                        }
                        beheerModel.SaveChanges();

                        foreach (contact entity in entities)
                        {
                            ClubCloud_Gebruiker gebruiker = beheerModel.ClubCloud_Gebruikers.Find(entity.contactid.Value);
                            bool result = CreateOrUpdateMembershipGebruiker(gebruiker, settings).Result;
                        }

                        foreach (contact entity in entities)
                        {
                            ClubCloud_Gebruiker gebruiker = beheerModel.ClubCloud_Gebruikers.Find(entity.contactid.Value);

                            if (entity.sgt_is_functionaris != null && entity.sgt_is_functionaris.Value)
                            {
                                GetFunctionarissenForGebruikerById(bondsnummer, entity.contactid.Value, refresh, settings);
                            }
                        }

                        beheerModel.SaveChanges();
                    }
				}
			}
			return moreRecords;
		}

		public void LidmaatschappenUpdate(string bondsnummer, Guid verenigingId, bool refresh = false)
		{
			GetLidmaatschappenByVereniging(bondsnummer, verenigingId, refresh, null);
		}

		public void VerenigingZimbra(string bondsnummer, ClubCloud_Vereniging vereniging)
		{
			ClubCloud_Setting settings = GetSettings(bondsnummer);

			if (settings != null && settings.Access && !string.IsNullOrWhiteSpace(settings.Password))
			{
				CreateOrUpdateMembershipVereniging(vereniging, settings);
			}
		}

		public void GebruikerZimbra(string bondsnummer, ClubCloud_Gebruiker gebruiker)
		{
			ClubCloud_Setting settings = GetSettings(bondsnummer);

			if (settings != null && settings.Access && !string.IsNullOrWhiteSpace(settings.Password))
			{
				CreateOrUpdateMembershipGebruiker(gebruiker, settings);
			}
		}

        /*
		public List<ClubCloud_Functionaris> GetFunctionarissen()
		{
			return beheerModel.ClubCloud_Functionarissen.Where(f => f.Actief != string.Empty).ToList();
		}
        */

        /*
		public List<ClubCloud_Vereniging> GetVerenigingen()
		{
			return beheerModel.ClubCloud_Verenigingen.Where(f => f.Actief != string.Empty).ToList();
		}
        */

        /*
		public List<ClubCloud_Accommodatie> GetAccommodaties()
		{
			return beheerModel.ClubCloud_Accommodaties.Where(f => f.Actief != string.Empty).ToList();
		}
        */

		public ClubCloud_Gebruiker CreateGebruiker(ClubCloud_Gebruiker gebruiker)
		{
			ClubCloud_Setting settings = GetClubCloudSettings(gebruiker.Bondsnummer);
			CreateOrUpdateMembershipGebruiker(gebruiker, settings);
			return gebruiker;
		}

		#endregion

		#region Package

		public List<ApplicationInfo> GetApplications()
		{
			List<ApplicationInfo> applicationInfos = storeModel.ApplicationInfoes.Where(a => a.Status == ApplicationStatus.Published).ToList();
			storeModel.ObjectContext.Refresh(RefreshMode.StoreWins, applicationInfos);
			return applicationInfos;
		}

		public ApplicationInfo GetApplicationInfoByName(string applicationName)
		{
			return storeModel.ApplicationInfoes.Where(a => a.ApplicationName == applicationName).FirstOrDefault();
		}

		public ApplicationInfo SetApplicationInfo(ApplicationInfo applicationInfo)
		{
			ApplicationInfo _applicationInfo = storeModel.ApplicationInfoes.Find(applicationInfo.Id);

			if (_applicationInfo != null)
			{
				storeModel.Entry(_applicationInfo).CurrentValues.SetValues(applicationInfo);
			}
			else
			{
				_applicationInfo = storeModel.ApplicationInfoes.Add(applicationInfo);

			}
			storeModel.SaveChanges();
			storeModel.ObjectContext.Refresh(RefreshMode.StoreWins, _applicationInfo);

			return _applicationInfo;
		}

		public ApplicationVersion SetApplicationVersion(int applicationInfoId, ApplicationVersion applicationVersion)
		{
			ApplicationInfo _applicationInfo = storeModel.ApplicationInfoes.Find(applicationInfoId);
			ApplicationVersion _applicationVersion = storeModel.ApplicationVersions.Where(v => v.ApplicationInfoId == applicationInfoId && v.Version == applicationVersion.Version).FirstOrDefault();
			if (_applicationInfo != null)
			{
				if (_applicationVersion != null)
				{
					applicationVersion.Id = _applicationVersion.Id;
					applicationVersion.ApplicationInfo = _applicationInfo;
					storeModel.Entry(_applicationVersion).CurrentValues.SetValues(applicationVersion);
				}
				else
				{
					applicationVersion.ApplicationInfo = _applicationInfo;
					_applicationVersion = storeModel.ApplicationVersions.Add(applicationVersion);
				}
				storeModel.SaveChanges();
				storeModel.ObjectContext.Refresh(RefreshMode.StoreWins, _applicationVersion);
			}

			return _applicationVersion;
		}

		public ApplicationProcessorArchitecture SetApplicationProcessorArchitecture(int applicationVersionId, ApplicationProcessorArchitecture applicationProcessorArchitecture)
		{
			ApplicationVersion _applicationVersion = storeModel.ApplicationVersions.Find(applicationVersionId);
			ApplicationProcessorArchitecture _applicationProcessorArchitecture = storeModel.ApplicationProcessorArchitectures.Where(a => a.ApplicationVersionId == applicationVersionId && a.Version == applicationProcessorArchitecture.Version).FirstOrDefault();

			if (_applicationVersion != null)
			{
				if (_applicationProcessorArchitecture != null)
				{
					applicationProcessorArchitecture.Id = _applicationProcessorArchitecture.Id;
					applicationProcessorArchitecture.ApplicationVersion = _applicationVersion;
					storeModel.Entry(_applicationProcessorArchitecture).CurrentValues.SetValues(applicationProcessorArchitecture);
				}
				else
				{
					applicationProcessorArchitecture.ApplicationVersion = _applicationVersion;
					_applicationProcessorArchitecture = storeModel.ApplicationProcessorArchitectures.Add(applicationProcessorArchitecture);
				}
				storeModel.SaveChanges();
				storeModel.ObjectContext.Refresh(RefreshMode.StoreWins, _applicationProcessorArchitecture);
			}
			return _applicationProcessorArchitecture;
		}

		public List<ApplicationInfo> GetApplicationInfos()
		{
			List<ApplicationInfo> applicationInfos = storeModel.ApplicationInfoes.Where(a => a.Status == ApplicationStatus.Published).ToList();
			storeModel.ObjectContext.Refresh(RefreshMode.StoreWins, applicationInfos);
			return applicationInfos;
		}

		public ApplicationVersion GetApplicationVersion(int applicationInfoId, string version)
		{
			ApplicationVersion applicationVersion = storeModel.ApplicationVersions.Where(v => v.ApplicationInfoId == applicationInfoId && v.Version == version).FirstOrDefault();
			storeModel.ObjectContext.Refresh(RefreshMode.StoreWins, applicationVersion);
			return applicationVersion;

		}

		public List<ApplicationProcessorArchitecture> GetApplicationProcessorArchitecture(int applicationVersionId, string version)
		{
			List<ApplicationProcessorArchitecture> applicationProcessorArchitectures = storeModel.ApplicationProcessorArchitectures.Where(a => a.ApplicationVersionId == applicationVersionId && a.Version == version).ToList();
			storeModel.ObjectContext.Refresh(RefreshMode.StoreWins, applicationProcessorArchitectures);
			return applicationProcessorArchitectures;
		}

		#endregion

        #region SignlR

        public string ScaleOutConnection(string catalog)
        {
            try
            {
                return GetConnectionString(catalog);
            }
            catch { }
            finally
            {
                CheckDatabase(catalog);
            }
            return string.Empty;
        }

        #endregion

		#region Aanmelden
		public bool CreateClubCloudWebSite(string verenigingsnummer)
		{
			bool succeed = false;

			try
			{

				ClubCloudServiceApplication application = SPIisWebServiceApplication.Current as ClubCloudServiceApplication;
				if (application == null)
				{
					throw new InvalidOperationException("Could not find the current Service Application.");
				}

				//SPDatabaseParameters databaseParameters = null;
				SqlConnectionStringBuilder builder = null;

				using (SqlConnection connection = new SqlConnection(application.Database.DatabaseConnectionString))
				{
					builder = new SqlConnectionStringBuilder(connection.ConnectionString);
				}
				string contentDatabase = null;
				if (builder != null)
				{
					builder.InitialCatalog = string.Format("ClubCloudService_{0}_WebSite", verenigingsnummer);

					/*
						SPSecurity.RunWithElevatedPrivileges(delegate()
						{
							SPWebService contentservice = Microsoft.SharePoint.Administration.SPWebService.ContentService;
							contentservice.RemoteAdministratorAccessDenied = false;
							contentservice.Update();
						});
					*/
					//SPSecurity.RunWithElevatedPrivileges(delegate()
					//{

					//SPWebApplication webapp = SPWebApplication.Lookup(new Uri("http://websites.clubcloud.nl"));

					//SPContentDatabase spcontentdatabase = webapp.ContentDatabases.Add(builder.DataSource, builder.InitialCatalog, null, null, 2000, 5000, 0, true);
					/*
					SPContentDatabase spcontentdatabase = SPContentDatabase.CreateUnattachedContentDatabase(builder);
					*/

					//spcontentdatabase.Provision();

					//spcontentdatabase.GrantOwnerAccessToDatabaseAccount();

					/*
					ClubCloudWebSiteDatabase ccDatabase = new ClubCloudWebSiteDatabase(databaseParameters);

					ccDatabase.Provision();

					ccDatabase.GrantApplicationPoolAccess(application.ApplicationPool.ProcessAccount.SecurityIdentifier);
					*/
					/*
					if (!string.IsNullOrEmpty(databaseParameters.FailoverPartner))
					{
						spcontentdatabase.AddFailoverServiceInstance(databaseParameters.FailoverPartner);
					}
					*/
					//spcontentdatabase.Update(true);
					contentDatabase = builder.InitialCatalog;
					//});
					/*
						SPSecurity.RunWithElevatedPrivileges(delegate()
						{
							SPWebService contentservice = Microsoft.SharePoint.Administration.SPWebService.ContentService;
							contentservice.RemoteAdministratorAccessDenied = true;
							contentservice.Update();
						});
					*/

					builder.InitialCatalog = string.Format("ClubCloudService_{0}_Data", verenigingsnummer);

					using (ClubCloud.Model.BeheerContainer model = new Model.BeheerContainer(builder.ConnectionString))
					{

						if (beheerModel.Database.CreateIfNotExists())
						{
							beheerModel.Database.Initialize(true);
						}
					}

					SPSecurity.RunWithElevatedPrivileges(delegate()
					{
						//using (SPSite eSite = new SPSite("http://websites.clubcloud.nl"))
						//{
						//using (SPWeb eWeb = eSite.OpenWeb())
						//{
						//eWeb.AllowUnsafeUpdates = true;
						//SPWebApplication webApp = eSite.WebApplication;
						//SPSiteCollection sites = eSite.WebApplication.Sites;
						//var rootQuery = from SPSite site in webApp.Sites select site;
						//SPSite rootSite = rootQuery.FirstOrDefault();
						SPWebApplication webApp = SPWebApplication.Lookup(new Uri("http://websites.clubcloud.nl"));
						SPContentDatabase newDatabase = null;

						if (webApp != null)
						{
							bool continueValue = false;
							if (!string.IsNullOrEmpty(contentDatabase))
							{
								//check if database exists
								var query = from SPContentDatabase database in webApp.ContentDatabases
											where database.Name == contentDatabase
											select database;

								//var config = from SPContentDatabase database in webApp.ContentDatabases
								//             /* where database.TypeName == contentDatabase*/
								//             select database;
								newDatabase = query.FirstOrDefault();

							}
							continueValue = newDatabase == null ? false : true;

							if (continueValue)
							{
								ClubCloud_Vereniging vereniging = null;
								builder.InitialCatalog = "ClubCloudService_DB";
								using (ClubCloud.Model.BeheerContainer model = new Model.BeheerContainer(builder.ConnectionString))
								{
									vereniging = beheerModel.ClubCloud_Verenigingen.Add(new ClubCloud_Vereniging { Nummer = verenigingsnummer, Naam = "S.V. Kampong", Id = new Guid("02ada6c7-80f9-4671-91f9-898ea5da3ccd") });
									beheerModel.SaveChanges();

									//vereniging = beheerModel.ClubCloud_Verenigingen.Find(int.Parse(verenigingsnummer));
								}

								if (vereniging != null)
								{

									string url = string.Format("http://{0}.clubcloud.nl", verenigingsnummer);
									SPSite createdSite = webApp.Sites.Add(url, vereniging.Naam, vereniging.Naam, 1043, "STS#1", @"12073385",
									"Rutger hemrika", "12073385@clubcloud.nl", null, null, null, true);
									//createdSite.SetUrl(new Uri("http://"++".clubcloud.n"))
									SPContentDatabase database = createdSite.ContentDatabase;
									if (database.Name != contentDatabase)
									{
										Dictionary<SPSite, string> failed = new Dictionary<SPSite, string>();

										database.Move(newDatabase, new List<SPSite>() { createdSite }, out failed);

										if (failed.Count > 0)
										{
											succeed = false;
										}
										else
										{
											succeed = true;
										}
									}
									else
									{
										succeed = true;
									}
								}
							}
						}
						//}
						//}
					});

					succeed = true;
				}
				else
				{
					succeed = false;
				}
			}
			catch (Exception ex)
			{
				string message = ex.Message;
				succeed = false;
			}

			return succeed;
		}
		
		#endregion
    }
}