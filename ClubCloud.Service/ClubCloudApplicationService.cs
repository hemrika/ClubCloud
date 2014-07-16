//-----------------------------------------------------------------------
// <copyright file="HelloWorldWCFService.cs" company="">
// Copyright © 
// </copyright>
//-----------------------------------------------------------------------

namespace ClubCloud.Service
{
	using System;
	using System.Linq;
	using System.Data.SqlClient;
	using System.ServiceModel;
	using Microsoft.SharePoint.Administration;
	using Microsoft.SharePoint.Client.Services;
	using System.ServiceModel.Activation;
	using ClubCloud.Service.Model;
	using ClubCloud.KNLTB.ServIt.LedenAdministratieService;
	using System.Net;
	using Microsoft.SharePoint;
	using System.Collections.Generic;
	using System.Diagnostics;
	using System.Xml.Serialization;
	using System.Xml;
	using System.Text;
	using System.IO;
	using ClubCloud.Provider;
	using System.Web.Security;
	using ClubCloud.KNLTB.ServIt.CompetitieService;
    using ClubCloud.KNLTB.ServIt.CrmService;

	/// <summary>
	/// The WCF Service.
	/// </summary>
	[BasicHttpBindingServiceMetadataExchangeEndpoint]
	[AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
	[System.Runtime.InteropServices.Guid("e00d1eca-a977-4ba9-a357-5fd35dfc0f63")]
	[ServiceBehavior(Namespace = "http://clubcloud.nl/", Name = "ClubCloudService")]
	[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1812:AvoidUninstantiatedInternalClasses", Justification = "Instantiated by the WCF runtime automatically.")]
	internal class ClubCloudApplicationService : IClubCloudApplicationService
	{
		#region Global

		private static SortedList<string, CookieContainer> containers;

		private CookieContainer RequestContainer(string bondsnummer, string wachtwoord)
		{
			CookieContainer container = new CookieContainer();
			if(containers == null)
			{
				containers = new SortedList<string, CookieContainer>();
			}

			bool expired = false;
			if (containers.Keys.Contains(bondsnummer))
			{
				container = containers.SingleOrDefault(c => c.Key == bondsnummer).Value;

				CookieCollection cookies = container.GetCookies(new Uri("http://www.mijnknltb.nl"));
				cookies.Add(container.GetCookies(new Uri("http://servit.mijnknltb.nl")));
				cookies.Add(container.GetCookies(new Uri("http://mijnknltb.nl")));

				foreach (Cookie cookie in cookies)
				{
					if(cookie.Expired)
					{
						expired = cookie.Expired;
						break;
					}
				}
			}

			if (container != null && container.Count > 0  && !expired)
			{
				return container;
			}
			else
			{
				if (containers.Keys.Contains(bondsnummer))
				{
					containers.Remove(bondsnummer);
				}

				ClubCloud.KNLTB.Security.KNLTBContainer KNLTBContainer = new KNLTB.Security.KNLTBContainer();
				KNLTBContainer.MijnRequestAcces(bondsnummer, wachtwoord);

				Stopwatch s = new Stopwatch();
				s.Start();
				while (KNLTBContainer.Container == null && s.Elapsed < TimeSpan.FromSeconds(30)) { }
				s.Stop();

				containers.Add(bondsnummer, KNLTBContainer.Container);

				return KNLTBContainer.Container;
			}
		}

        private List<BusinessEntity> RetrieveMultiple(ClubCloud.KNLTB.ServIt.CrmService.CrmService service, string entityName, out bool moreRecords,ref int pageNum)
        {
            return RetrieveMultiple(service, entityName, out moreRecords, ref pageNum, null);
        }

        private List<BusinessEntity> RetrieveMultiple(ClubCloud.KNLTB.ServIt.CrmService.CrmService service, string entityName, out bool moreRecords, ref int pageNum, FilterExpression filter)
        {
            List<BusinessEntity> entities = new List<BusinessEntity>();

            ColumnSetBase cols = new AllColumns();
            FilterExpression expression = new FilterExpression();
            if (filter != null)
            {
                expression = filter;
            }

            PagingInfo pageInfo = new PagingInfo();
            pageInfo.Count = 50;
            pageInfo.PageNumber = pageNum;
            QueryExpression query = new QueryExpression();

            query.EntityName = entityName;
            query.ColumnSet = cols;
            query.Criteria = expression;
            query.PageInfo = pageInfo;
            query.Distinct = true;

            // Create the request object.
            RetrieveMultipleRequest request = new RetrieveMultipleRequest();

            // Set the properties of the request object.
            request.Query = query;

            // Execute the request.
            RetrieveMultipleResponse results = (RetrieveMultipleResponse)service.Execute(request);
            moreRecords = results.BusinessEntityCollection.MoreRecords;
            if (moreRecords)
            {
                pageNum++;
            }

            entities = results.BusinessEntityCollection.BusinessEntities.ToList<BusinessEntity>();

            return entities;
        }

		private static string GetConnectionString(string catalog = null)
		{
			ClubCloudServiceApplication application = SPIisWebServiceApplication.Current as ClubCloudServiceApplication;
			SqlConnectionStringBuilder builder = null;

			if (application == null)
			{
				throw new InvalidOperationException("Could not find the current Service Application.");
			}

			using (SqlConnection connection = new SqlConnection(application.Database.DatabaseConnectionString))
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

		private static void CheckDatabase(string catalog = null)
		{
			using (ClubCloud.Service.Model.ClubCloudModelContainer model = new Model.ClubCloudModelContainer(GetConnectionString(catalog)))
			{
				model.Database.Initialize(true);
				model.Database.CreateIfNotExists();
				model.Database.CompatibleWithModel(false);
			}

            /*
            using (ClubCloud.Service.Model.MijnModelContainer model = new Model.MijnModelContainer(GetConnectionString(catalog)))
            {
                model.Database.Initialize(true);
                model.Database.CreateIfNotExists();
                model.Database.CompatibleWithModel(false);
            }
            */
		}


		/// <summary>
		/// Serialize List<Object> to one XML string
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="value"></param>
		/// <returns></returns>
		private static string SerializeObjectList<T>(T value)
		{
			XmlSerializer serializer = new XmlSerializer(typeof(T));
			XmlWriterSettings settings = new XmlWriterSettings();
			settings.Encoding = new UnicodeEncoding(false, false);
			settings.Indent = false;
			settings.OmitXmlDeclaration = false;
			using (StringWriter textWriter = new StringWriter())
			{
				using (XmlWriter xmlWriter = XmlWriter.Create(textWriter, settings))
				{
					serializer.Serialize(xmlWriter, value);
				}
				return textWriter.ToString();
			}
		}

		/// <summary>
		/// Deserialize XML string with multiple instances of 'separatorNode' to List<Object>
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="xml"></param>
		/// <param name="separatorNode"></param>
		/// <returns></returns>
		public static List<T> DeserializeObjectList<T>(string xml, string separatorNode)
		{
			XmlDocument doc = new XmlDocument();
			doc.LoadXml(xml);
			XmlElement root = doc.DocumentElement;
			XmlNodeList nodes = root.SelectNodes(separatorNode);
			List<T> instances = new List<T>();
			foreach (XmlNode node in nodes)
			{
				XmlSerializer serializer = new XmlSerializer(typeof(T));
				XmlReaderSettings settings = new XmlReaderSettings();
				using (StringReader textReader = new StringReader(node.OuterXml))
				{
					using (XmlReader xmlReader = XmlReader.Create(textReader, settings))
					{
						instances.Add((T)serializer.Deserialize(xmlReader));
					}
				}
			}
			return instances;
		}

		

		public void CheckDatabaseExists()
		{
			CheckDatabase();
		}

		#endregion

		#region Methods

		#region Gebruikers

		#region Settings

		public ClubCloud_Setting SetPrivacy(ClubCloud_Setting settings)
		{
			CheckDatabase();

			ClubCloud_Setting currentsettings = new ClubCloud_Setting();
			using (ClubCloud.Service.Model.ClubCloudModelContainer model = new Model.ClubCloudModelContainer(GetConnectionString()))
			{
				currentsettings = model.ClubCloud_Settings.Find(settings.Id);
				currentsettings.privacy = settings.privacy;
				model.SaveChanges();
			}

			currentsettings.mijnknltb_password = string.Empty;
			return currentsettings;
		}

		public ClubCloud_Setting SetMijnKNLTB(ClubCloud_Setting settings)
		{
			CheckDatabase();

			ClubCloud_Setting currentsettings = new ClubCloud_Setting();
			using (ClubCloud.Service.Model.ClubCloudModelContainer model = new Model.ClubCloudModelContainer(GetConnectionString()))
			{
				currentsettings = model.ClubCloud_Settings.Find(settings.Id);

				currentsettings.mijnknltb_allow = settings.mijnknltb_allow;
				if (currentsettings.mijnknltb_allow && (currentsettings.mijnknltb_password != settings.mijnknltb_password))
				{
					currentsettings.mijnknltb_password = settings.mijnknltb_password;
				}
				model.SaveChanges();
			}

			currentsettings.mijnknltb_password = string.Empty;
			return currentsettings;
		}

		public ClubCloud_Setting SetTwitter(ClubCloud_Setting settings)
		{
			CheckDatabase();

			ClubCloud_Setting currentsettings = new ClubCloud_Setting();
			using (ClubCloud.Service.Model.ClubCloudModelContainer model = new Model.ClubCloudModelContainer(GetConnectionString()))
			{
				currentsettings = model.ClubCloud_Settings.Find(settings.Id);
				currentsettings.twitter_allow = settings.twitter_allow;
				currentsettings.twitter_oauth_token = settings.twitter_oauth_token;
				currentsettings.twitter_oauth_token_secret = settings.twitter_oauth_token_secret;
				currentsettings.twitter_setting = settings.twitter_setting;
				model.SaveChanges();
			}

			currentsettings.mijnknltb_password = string.Empty;
			return currentsettings;
		}

		public ClubCloud_Setting SetFaceBook(ClubCloud_Setting settings)
		{
			CheckDatabase();

			ClubCloud_Setting currentsettings = new ClubCloud_Setting();
			using (ClubCloud.Service.Model.ClubCloudModelContainer model = new Model.ClubCloudModelContainer(GetConnectionString()))
			{
				currentsettings = model.ClubCloud_Settings.Find(settings.Id);
				currentsettings.facebook_allow = settings.facebook_allow;
				currentsettings.facebook_access_token = settings.facebook_access_token;
				currentsettings.facebook_setting = settings.facebook_setting;
				model.SaveChanges();
			}

			currentsettings.mijnknltb_password = string.Empty;
			return currentsettings;
		}

		public ClubCloud_Setting SetFinancieel(ClubCloud_Setting settings)
		{
			CheckDatabase();

			ClubCloud_Setting currentsettings = new ClubCloud_Setting();
			using (ClubCloud.Service.Model.ClubCloudModelContainer model = new Model.ClubCloudModelContainer(GetConnectionString()))
			{
				currentsettings = model.ClubCloud_Settings.Find(settings.Id);
				currentsettings.financieel = settings.financieel;
				model.SaveChanges();
			}

			currentsettings.mijnknltb_password = string.Empty;
			return currentsettings;
		}

		public ClubCloud_Setting SetTracking(ClubCloud_Setting settings)
		{
			CheckDatabase();

			ClubCloud_Setting currentsettings = new ClubCloud_Setting();
			using (ClubCloud.Service.Model.ClubCloudModelContainer model = new Model.ClubCloudModelContainer(GetConnectionString()))
			{
				currentsettings = model.ClubCloud_Settings.Find(settings.Id);
				currentsettings.mijnknltb_tracking = settings.mijnknltb_tracking;
				model.SaveChanges();
			}

			currentsettings.mijnknltb_password = string.Empty;
			return currentsettings;
		}

		public ClubCloud_Setting GetClubCloudSettings(string bondsnummer)
		{
			CheckDatabase();

			ClubCloud_Setting currentsettings = new ClubCloud_Setting();
			using (ClubCloud.Service.Model.ClubCloudModelContainer model = new Model.ClubCloudModelContainer(GetConnectionString()))
			{
				try
				{
				currentsettings = model.ClubCloud_Settings.Find(int.Parse(bondsnummer));
				}
				catch
				{

					currentsettings = null;
				}

				if(currentsettings == null)// || !currentsettings.mijnknltb_Id.HasValue)
				{
					currentsettings = new ClubCloud_Setting { Id = int.Parse(bondsnummer) };
					model.ClubCloud_Settings.Add(currentsettings);
					bool haschanges = model.ChangeTracker.HasChanges();
					model.SaveChanges();
					currentsettings.Id = int.Parse(bondsnummer);
					model.SaveChanges();
				}
			}
			currentsettings.mijnknltb_password = string.Empty;

			return currentsettings;
		}
		#endregion

		public ClubCloud_Gebruiker GetClubCloudGebruiker(string bondsnummer, bool refresh = false)
		{
			CheckDatabase();

			ClubCloud_Gebruiker gebruiker = new ClubCloud_Gebruiker();

			using (ClubCloud.Service.Model.ClubCloudModelContainer model = new Model.ClubCloudModelContainer(GetConnectionString()))
			{
				ClubCloud_Setting settings = model.ClubCloud_Settings.Find(int.Parse(bondsnummer));

				if (settings != null)
				{
					if (settings.mijnknltb_Id.HasValue)
					{
						gebruiker = model.ClubCloud_Gebruikers.Find(settings.mijnknltb_Id.Value);
					}
					else
					{
						gebruiker = null;
					}

					if (gebruiker == null || refresh)
					{
						if (settings.mijnknltb_allow && !string.IsNullOrWhiteSpace(settings.mijnknltb_password))
						{
							CookieContainer cc = RequestContainer(settings.Id.ToString(), settings.mijnknltb_password);

							if (cc != null)
							{
                                /*
								LedenadministratieServiceClient LedenAdministratie = new LedenadministratieServiceClient(cc, bondsnummer);

								GetPersoonsgegevensResponse persoonResponse = LedenAdministratie.GetPersoonsgegevens(new GetPersoonsgegevensRequest { Bondsnummer = bondsnummer });
								if (persoonResponse != null && persoonResponse.Persoonsgegevens != null)
								{
									Persoonsgegevens persoon = persoonResponse.Persoonsgegevens;

									if (gebruiker == null)
									{
										if (!settings.mijnknltb_Id.HasValue)
										{
											settings.mijnknltb_Id = persoon.Id;
										}

										gebruiker = new ClubCloud_Gebruiker
										{
											Achternaam = persoon.Achternaam,
											DistrictNaam = persoon.DistrictNaam,
											Email = persoon.Email,
											Geboortedatum = persoon.Geboortedatum,
											Geboorteplaats = persoon.Geboorteplaats,
											Gemeente = persoon.Gemeente,
											Geslacht = persoon.Geslacht,
											Huisnummer = persoon.Huisnummer,
											Id = persoon.Id,
											IsLid = persoon.IsLid,
											Mobiel = persoon.Mobiel,
											NationaliteitId = persoon.NationaliteitId,
											OrganisatieNummer = persoon.OrganisatieNummer,
											Plaats = persoon.Plaats,
											Postcode = persoon.Postcode,
											RatingDubbel = persoon.RatingDubbel,
											RatingEnkel = persoon.RatingEnkel,
											Roepnaam = persoon.Roepnaam,
											SpeelsterkteDubbel = persoon.SpeelsterkteDubbel,
											SpeelsterkteEnkel = persoon.SpeelsterkteEnkel,
											Straat = persoon.Straat,
											TelefoonAvond = persoon.TelefoonAvond,
											TelefoonOverdag = persoon.TelefoonOverdag,
											Toevoeging = persoon.Toevoeging,
											Tussenvoegsel = persoon.Tussenvoegsel,
											VolledigeNaam = persoon.VolledigeNaam,
											Voorletters = persoon.Voorletters,
											Voornamen = persoon.Voornamen
										};
										
										model.ClubCloud_Gebruikers.Add(gebruiker);
									}
									else
									{
										gebruiker.Achternaam = persoon.Achternaam;
										gebruiker.DistrictNaam = persoon.DistrictNaam;
										gebruiker.Email = persoon.Email;
										gebruiker.Geboortedatum = persoon.Geboortedatum;
										gebruiker.Geboorteplaats = persoon.Geboorteplaats;
										gebruiker.Gemeente = persoon.Gemeente;
										gebruiker.Geslacht = persoon.Geslacht;
										gebruiker.Huisnummer = persoon.Huisnummer;
										gebruiker.Id = persoon.Id;
										gebruiker.IsLid = persoon.IsLid;
										gebruiker.Mobiel = persoon.Mobiel;
										gebruiker.NationaliteitId = persoon.NationaliteitId;
										gebruiker.OrganisatieNummer = persoon.OrganisatieNummer;
										gebruiker.Plaats = persoon.Plaats;
										gebruiker.Postcode = persoon.Postcode;
										gebruiker.RatingDubbel = persoon.RatingDubbel;
										gebruiker.RatingEnkel = persoon.RatingEnkel;
										gebruiker.Roepnaam = persoon.Roepnaam;
										gebruiker.SpeelsterkteDubbel = persoon.SpeelsterkteDubbel;
										gebruiker.SpeelsterkteEnkel = persoon.SpeelsterkteEnkel;
										gebruiker.Straat = persoon.Straat;
										gebruiker.TelefoonAvond = persoon.TelefoonAvond;
										gebruiker.TelefoonOverdag = persoon.TelefoonOverdag;
										gebruiker.Toevoeging = persoon.Toevoeging;
										gebruiker.Tussenvoegsel = persoon.Tussenvoegsel;
										gebruiker.VolledigeNaam = persoon.VolledigeNaam;
										gebruiker.Voorletters = persoon.Voorletters;
										gebruiker.Voornamen = persoon.Voornamen;
									}                                  
								}
                                */
							}
							
						}
					}
				}
				
				if(model.ChangeTracker.HasChanges())
				{
					UpdateMembershipuser(gebruiker);
				}
				model.SaveChanges();

				
			}
			return gebruiker;
		}

        public ClubCloud_Gebruiker GetClubCloudGebruikerByBondsnummer(string bondsnummer, string bondsnummerGebruiker, bool refresh = false)
        {
            CheckDatabase();

            ClubCloud_Gebruiker gebruiker = new ClubCloud_Gebruiker();

            using (ClubCloud.Service.Model.ClubCloudModelContainer model = new Model.ClubCloudModelContainer(GetConnectionString()))
            {
                ClubCloud_Setting settings = model.ClubCloud_Settings.Find(int.Parse(bondsnummerGebruiker));

                if (settings != null)
                {
                    if (settings.mijnknltb_Id.HasValue)
                    {
                        gebruiker = model.ClubCloud_Gebruikers.Find(settings.mijnknltb_Id.Value);
                    }
                    else
                    {
                        gebruiker = null;
                    }
                }

                if (gebruiker == null || refresh)
                {
                    settings = model.ClubCloud_Settings.Find(int.Parse(bondsnummer));

                    if (settings.mijnknltb_allow && !string.IsNullOrWhiteSpace(settings.mijnknltb_password))
                    {
                        CookieContainer cc = RequestContainer(settings.Id.ToString(), settings.mijnknltb_password);

                        if (cc != null)
                        {
                            /*
                            LedenadministratieServiceClient LedenAdministratie = new LedenadministratieServiceClient(cc, bondsnummer);

                            GetPersoonsgegevensResponse persoonResponse = LedenAdministratie.GetPersoonsgegevens(new GetPersoonsgegevensRequest { Bondsnummer = bondsnummerGebruiker });
                            if (persoonResponse != null && persoonResponse.Persoonsgegevens != null)
                            {
                                Persoonsgegevens persoon = persoonResponse.Persoonsgegevens;

                                gebruiker = new ClubCloud_Gebruiker
                                {
                                    Achternaam = persoon.Achternaam,
                                    DistrictNaam = persoon.DistrictNaam,
                                    Email = persoon.Email,
                                    Geboortedatum = persoon.Geboortedatum,
                                    Geboorteplaats = persoon.Geboorteplaats,
                                    Gemeente = persoon.Gemeente,
                                    Geslacht = persoon.Geslacht,
                                    Huisnummer = persoon.Huisnummer,
                                    Id = persoon.Id,
                                    IsLid = persoon.IsLid,
                                    Mobiel = persoon.Mobiel,
                                    NationaliteitId = persoon.NationaliteitId,
                                    OrganisatieNummer = persoon.OrganisatieNummer,
                                    Plaats = persoon.Plaats,
                                    Postcode = persoon.Postcode,
                                    RatingDubbel = persoon.RatingDubbel,
                                    RatingEnkel = persoon.RatingEnkel,
                                    Roepnaam = persoon.Roepnaam,
                                    SpeelsterkteDubbel = persoon.SpeelsterkteDubbel,
                                    SpeelsterkteEnkel = persoon.SpeelsterkteEnkel,
                                    Straat = persoon.Straat,
                                    TelefoonAvond = persoon.TelefoonAvond,
                                    TelefoonOverdag = persoon.TelefoonOverdag,
                                    Toevoeging = persoon.Toevoeging,
                                    Tussenvoegsel = persoon.Tussenvoegsel,
                                    VolledigeNaam = persoon.VolledigeNaam,
                                    Voorletters = persoon.Voorletters,
                                    Voornamen = persoon.Voornamen
                                };

                                model.ClubCloud_Gebruikers.Add(gebruiker);

                            }
                            */
                        }

                    }

                }

                model.SaveChanges();

                if (model.ChangeTracker.HasChanges())
                {
                    UpdateMembershipuser(gebruiker);
                }

                


            }
            return gebruiker;
        }

		public bool SetClubCloudGebruiker(string bondsnummer, ClubCloud_Gebruiker gebruiker, bool refresh)
		{
			try
			{
				CheckDatabase();

				ClubCloud_Gebruiker currentgebruiker = new ClubCloud_Gebruiker();

				using (ClubCloud.Service.Model.ClubCloudModelContainer model = new Model.ClubCloudModelContainer(GetConnectionString()))
				{
					ClubCloud_Setting settings = model.ClubCloud_Settings.Find(int.Parse(bondsnummer));
					currentgebruiker = model.ClubCloud_Gebruikers.Find(gebruiker.Id);
					//ClubCloud_Gebruiker oldgebruiker = model.ClubCloud_Gebruikers.SingleOrDefault(g => g.Id == gebruiker.Id);

					if (settings != null && currentgebruiker != null)
					{
						if (settings.mijnknltb_Id.HasValue)
						{
							currentgebruiker = model.ClubCloud_Gebruikers.Find(gebruiker.Id);
							currentgebruiker.Achternaam = gebruiker.Achternaam;
							currentgebruiker.Email = gebruiker.Email;
							currentgebruiker.Geboortedatum = gebruiker.Geboortedatum;
							currentgebruiker.Geboorteplaats = gebruiker.Geboorteplaats;
							currentgebruiker.Gemeente = gebruiker.Gemeente;
							currentgebruiker.Geslacht = gebruiker.Geslacht;
							currentgebruiker.Huisnummer = gebruiker.Huisnummer;
							currentgebruiker.Mobiel = gebruiker.Mobiel;
							currentgebruiker.Plaats = gebruiker.Plaats;
							currentgebruiker.Postcode = gebruiker.Postcode;
							currentgebruiker.Roepnaam = gebruiker.Roepnaam;
							currentgebruiker.Straat = gebruiker.Straat;
							currentgebruiker.TelefoonAvond = gebruiker.TelefoonAvond;
							currentgebruiker.TelefoonOverdag = gebruiker.TelefoonOverdag;
							currentgebruiker.Toevoeging = gebruiker.Toevoeging;
							currentgebruiker.Tussenvoegsel = gebruiker.Tussenvoegsel;
							currentgebruiker.Voorletters = gebruiker.Voorletters;
							currentgebruiker.Voornamen = gebruiker.Voornamen;
							currentgebruiker.VolledigeNaam = string.Format("{0} {1}, {2}", gebruiker.Tussenvoegsel, gebruiker.Achternaam, gebruiker.Voorletters);
						}
						else
						{
							gebruiker.VolledigeNaam = string.Format("{0} {1}, {2}", gebruiker.Tussenvoegsel, gebruiker.Achternaam, gebruiker.Voorletters);
							model.ClubCloud_Gebruikers.Add(gebruiker);
						}
					}

					if (model.ChangeTracker.HasChanges())
					{
						UpdateMembershipuser(gebruiker);
					}

					model.SaveChanges();
				}
				return true;
			}
			catch { return false; }

		}

		private bool UpdateMembershipuser(ClubCloud_Gebruiker gebruiker)
		{
			try
			{
				using (ClubCloud.Service.Model.ClubCloudModelContainer model = new Model.ClubCloudModelContainer(GetConnectionString()))
				{

					ClubCloud_Setting updatesettings = model.ClubCloud_Settings.SingleOrDefault(g => g.mijnknltb_Id == gebruiker.Id);
					if (updatesettings != null)// && updatesettings.Id != null)
					{
						ZimbraMembershipUser zuser = Provider.GetZimbraUser(updatesettings.Id.ToString(), true);

						zuser.cn = gebruiker.VolledigeNaam;
						zuser.co = gebruiker.NationaliteitId.ToString();
						zuser.company = gebruiker.OrganisatieNummer;
						zuser.departmentNumber = gebruiker.DistrictNaam;
						zuser.displayName = gebruiker.VolledigeNaam;
						zuser.employeeNumber = gebruiker.Id.ToString();
						zuser.givenName = gebruiker.Voornamen;
						zuser.homePhone = gebruiker.TelefoonAvond;
						zuser.homePostalAddress = gebruiker.Straat + " " + gebruiker.Huisnummer + " " + Environment.NewLine + gebruiker.Postcode + "," + gebruiker.Plaats + " " + Environment.NewLine + gebruiker.Gemeente;
						zuser.initials = gebruiker.Voorletters;
						zuser.l = gebruiker.Plaats;
						zuser.mobile = gebruiker.Mobiel;
						zuser.o = gebruiker.OrganisatieNummer;
						zuser.postalAddress = gebruiker.Straat + " " + gebruiker.Huisnummer + " " + Environment.NewLine + gebruiker.Postcode + "," + gebruiker.Plaats + " " + Environment.NewLine + gebruiker.Gemeente;
						zuser.postalCode = gebruiker.Postcode;
						zuser.sn = gebruiker.Achternaam;
						zuser.st = gebruiker.Gemeente;
						zuser.street = gebruiker.Straat + " " + gebruiker.Huisnummer;
						zuser.telephoneNumber = gebruiker.Mobiel;
						zuser.zimbraPrefMailForwardingAddress = gebruiker.Email;
						Provider.UpdateUser(zuser as MembershipUser);
					}
				}

				return true;
			}
			catch (Exception ex)
			{ 
				return false; 
			}
		}

		private ZimbraMembershipProvider m_membershipProvider;
		public ZimbraMembershipProvider Provider
		{
			get
			{
				if (this.m_membershipProvider == null)
				{
					this.m_membershipProvider = System.Web.Security.Membership.Providers["ZimbraMembershipProvider"] as ZimbraMembershipProvider;
				}
				return this.m_membershipProvider;
			}
		}

        /*
		public SpelersProfiel GetSpelersProfiel(string bondsnummer, bool refresh = false)
		{
			CheckDatabase();

			SpelersProfiel profiel = new SpelersProfiel();


			using (ClubCloud.Service.Model.ClubCloudModelContainer model = new Model.ClubCloudModelContainer(GetConnectionString()))
			{
				ClubCloud_Setting settings = model.ClubCloud_Settings.Find(int.Parse(bondsnummer));

				if (settings != null && settings.mijnknltb_allow && !string.IsNullOrWhiteSpace(settings.mijnknltb_password))
				{
					CookieContainer cc = RequestContainer(settings.Id.ToString(), settings.mijnknltb_password);

					if (cc != null)
					{
						LedenadministratieServiceClient LedenAdministratie = new LedenadministratieServiceClient(cc, bondsnummer);

						GetSpelersProfielDetailResponse profielResponse = LedenAdministratie.GetSpelersProfielDetail(new GetSpelersProfielDetailRequest { Bondsnummer = settings.Id.ToString() });
						if (profielResponse != null)
						{
							profiel = (SpelersProfiel)profielResponse;
						}

						if(refresh)
						{
							GetTracking(bondsnummer, refresh);
						}
					}
				}
			}

			return profiel;
		}
        */
        /*
		public ClubCloud_Tracking GetTracking(string bondsnummer, bool refresh = false)
		{
			CheckDatabase();

			ClubCloud_Tracking spelertracking = new ClubCloud_Tracking();// { Id = int.Parse(bondsnummer) };

			using (ClubCloud.Service.Model.ClubCloudModelContainer model = new Model.ClubCloudModelContainer(GetConnectionString()))
			{
				ClubCloud_Setting settings = model.ClubCloud_Settings.Find(int.Parse(bondsnummer));

				if (settings != null && settings.mijnknltb_tracking)
				{
					spelertracking = model.ClubCloud_TrackingSet.SingleOrDefault(p => p.Id == settings.mijnknltb_Id);

					if (spelertracking == null && settings.mijnknltb_tracking)
					{
						spelertracking = model.ClubCloud_TrackingSet.Create();
						spelertracking.Id = settings.mijnknltb_Id.Value;
						model.ClubCloud_TrackingSet.Add(spelertracking);
						model.SaveChanges();
					}

					if (spelertracking != null && settings.mijnknltb_tracking || refresh)
					{
						List<SpelersProfiel> profielen = null;

						if (!string.IsNullOrWhiteSpace(spelertracking.Data))
						{
							profielen = (List<SpelersProfiel>)DeserializeObjectList<SpelersProfiel>(spelertracking.Data, "SpelersProfiel");
						}
						else
						{
							profielen = new List<SpelersProfiel>();
						}

						if (settings.mijnknltb_allow)
						{
							CookieContainer cc = RequestContainer(settings.Id.ToString(), settings.mijnknltb_password);

							if (cc != null)
							{
								LedenadministratieServiceClient LedenAdministratie = new LedenadministratieServiceClient(cc, bondsnummer);
								GetSpelersProfielDetailResponse profielResponse = LedenAdministratie.GetSpelersProfielDetail(new GetSpelersProfielDetailRequest { Bondsnummer = settings.Id.ToString() });

								if (profielResponse != null)
								{
									SpelersProfiel profiel = profielResponse as SpelersProfiel;
									{
										if (profiel != null)
										{
											if (profielen.Count >= 12)
											{
												profielen.RemoveAt(profielen.Count - 1);
											}
											profielen.Insert(0, profiel);
										}
									}
								}
							}
						}
                        if (profielen.Count > 0)
                        {
                            spelertracking.Data = SerializeObjectList(profielen);
                        }
					}
				}
				model.SaveChanges();
			}
			return spelertracking;
		}
        */
        /*
		public List<ClubCloud_Gebruiker_Vereniging> GetVerenigingen(string bondsnummer, bool refresh = false)
		{
			CheckDatabase();

			List<ClubCloud_Gebruiker_Vereniging> verenigingen = new List<ClubCloud_Gebruiker_Vereniging>();

			using (ClubCloud.Service.Model.ClubCloudModelContainer model = new Model.ClubCloudModelContainer(GetConnectionString()))
			{
				ClubCloud_Setting settings = model.ClubCloud_Settings.Find(int.Parse(bondsnummer));

				if (settings != null && settings.mijnknltb_Id.HasValue)
				{
					verenigingen = model.ClubCloud_Gebruiker_Verenigingen.Where(gv => gv.Id == settings.mijnknltb_Id.Value).ToList<ClubCloud_Gebruiker_Vereniging>();

					if (verenigingen == null || verenigingen.Count == 0 || refresh)
					{

						if (settings.mijnknltb_allow && !string.IsNullOrWhiteSpace(settings.mijnknltb_password))
						{
							CookieContainer cc = RequestContainer(settings.Id.ToString(), settings.mijnknltb_password);

							if (cc != null)
							{
								LedenadministratieServiceClient LedenAdministratie = new LedenadministratieServiceClient(cc, bondsnummer);
								GetMijnVerenigingenResponse verenigingenResponse = LedenAdministratie.GetMijnVerenigingen(new GetMijnVerenigingenRequest { Bondsnummer = bondsnummer });
								if (verenigingenResponse != null && verenigingenResponse.Verenigingen != null && verenigingenResponse.Verenigingen.Length > 0)
								{
									foreach (ClubCloud.KNLTB.ServIt.LedenAdministratieService.Vereniging vereniging in verenigingenResponse.Verenigingen)
									{
										ClubCloud_Gebruiker_Vereniging gebruiker_vereniging = verenigingen.SingleOrDefault(v => v.VerenigingId == vereniging.Id);// && vereniging.Id == settings.mijnknltb_Id.Value);

										if (gebruiker_vereniging == null)// || gebruiker_vereniging.VerenigingId == null || gebruiker_vereniging.VerenigingId == Guid.Empty)
										{
											gebruiker_vereniging = new ClubCloud_Gebruiker_Vereniging
											{
												Id = settings.mijnknltb_Id.Value,
												VerenigingId = vereniging.Id,
												VerenigingNaam = vereniging.Naam
											};
											model.ClubCloud_Gebruiker_Verenigingen.Add(gebruiker_vereniging);
											verenigingen.Add(gebruiker_vereniging);
										}
										else
										{
											gebruiker_vereniging.VerenigingNaam = vereniging.Naam;
										}
									}
								}
							}
						}
					}
				}
				model.SaveChanges();
			}

			return verenigingen;
		}
        */
        /*
		//public List<ClubCloud_Abbonnement> GetAbonnementen(Guid persoonsId, bool refresh = false)
		public List<ClubCloud_Gebruiker_Abonement> GetAbonnementen(string bondsnummer, Guid persoonsId, bool refresh = false)
		{
			CheckDatabase();

			List<ClubCloud_Gebruiker_Abonement> abonnementen = new List<ClubCloud_Gebruiker_Abonement>();

			using (ClubCloud.Service.Model.ClubCloudModelContainer model = new Model.ClubCloudModelContainer(GetConnectionString()))
			{
				ClubCloud_Setting settings = model.ClubCloud_Settings.Find(int.Parse(bondsnummer));

				if (settings != null)
				{
					abonnementen = model.ClubCloud_Gebruiker_Abonementen.Where(gv => gv.Id == settings.mijnknltb_Id.Value).ToList<ClubCloud_Gebruiker_Abonement>();

					if (abonnementen != null && abonnementen.Count == 0 || refresh)
					{
						if (settings.mijnknltb_allow && !string.IsNullOrWhiteSpace(settings.mijnknltb_password))
						{
							CookieContainer cc = RequestContainer(settings.Id.ToString(), settings.mijnknltb_password);

							if (cc != null)
							{
								LedenadministratieServiceClient LedenAdministratie = new LedenadministratieServiceClient(cc, settings.Id.ToString());
								GetSoortAbonneesResponse abonneesResponse = LedenAdministratie.GetSoortAbonnees( new GetSoortAbonneesRequest{ PersoonId = persoonsId});

								if(abonneesResponse != null && abonneesResponse.SoortAbonnement != null && abonneesResponse.SoortAbonnement.Length > 0)
								{
									foreach (SoortAbonnement abonnement in abonneesResponse.SoortAbonnement)
									{
										//abonnement.Beschrijving

									}
								}
							}
						}
					}
				}

				model.SaveChanges();
			}

			return abonnementen;
		}
        */
        /*
		public List<ClubCloud_District> GetDistricten(string bondsnummer, bool refresh = false)
		{
			CheckDatabase();
			List<ClubCloud_District> districten = new List<ClubCloud_District>();
			using (ClubCloud.Service.Model.ClubCloudModelContainer model = new Model.ClubCloudModelContainer(GetConnectionString()))
			{
				districten = model.ClubCloud_Districten.Where(d => d.Id != null).ToList();

				if (districten == null || districten.Count == 0 || refresh)
				{
					if(districten == null)
					{
						districten = new List<ClubCloud_District>();
					}

					ClubCloud_Setting settings = model.ClubCloud_Settings.Find(int.Parse(bondsnummer));
					if (settings != null && settings.mijnknltb_allow && !string.IsNullOrWhiteSpace(settings.mijnknltb_password))
					{
						CookieContainer cc = RequestContainer(settings.Id.ToString(), settings.mijnknltb_password);

						if (cc != null)
						{
							LedenadministratieServiceClient LedenAdministratie = new LedenadministratieServiceClient(cc, bondsnummer);
							GetDistrictResponse districtenResponse = LedenAdministratie.GetDistrict(new GetDistrictRequest { Bondsnummer = bondsnummer });

							if (districtenResponse != null && districtenResponse.Districten.Length > 0)
							{
								foreach (District district in districtenResponse.Districten)
								{
									ClubCloud_District cdistrict = model.ClubCloud_Districten.SingleOrDefault(d => d.Id == district.Id);

									if(cdistrict == null)
									{
										cdistrict = model.ClubCloud_Districten.Create();
										cdistrict.Id = district.Id;
										cdistrict.DistrictNaam = district.DistrictNaam;
										model.ClubCloud_Districten.Add(cdistrict);
										districten.Add(cdistrict);
									}
									else
									{
										cdistrict.DistrictNaam = district.DistrictNaam;
									}
								}


							}
						}
					}
				}
				model.SaveChanges();
			}
			
				return districten;
		}
        */

		#endregion

		#region Club

		public ClubCloud_Vereniging GetVerenigingById(string bondsnummer, Guid verenigingId, bool refresh = false)
		{
			CheckDatabase();

			ClubCloud_Vereniging vereniging = new ClubCloud_Vereniging();
			using (ClubCloud.Service.Model.ClubCloudModelContainer model = new Model.ClubCloudModelContainer(GetConnectionString()))
			{
				vereniging = model.ClubCloud_Verenigingen.Find(verenigingId);

				if ( vereniging == null || refresh)
				{
					ClubCloud_Setting settings = model.ClubCloud_Settings.Find(int.Parse(bondsnummer));                    

					if (settings != null && settings.mijnknltb_allow && !string.IsNullOrWhiteSpace(settings.mijnknltb_password))
					{
						CookieContainer cc = RequestContainer(settings.Id.ToString(), settings.mijnknltb_password);

						if (cc != null)
						{
							LedenadministratieServiceClient LedenAdministratie = new LedenadministratieServiceClient(cc, bondsnummer);
							GetVerenigingResponse verenigingenResponse = LedenAdministratie.GetVereniging(new GetVerenigingRequest { Bondsnummer = bondsnummer, VerenigingId = verenigingId });
							
							if (verenigingenResponse != null)
							{
								if (vereniging == null)
								{
									vereniging = new ClubCloud_Vereniging
									{
                                        /*
										Id = verenigingId,
										BanknummerPlaats = verenigingenResponse.BanknummerPlaats,
										Bezoekadres = verenigingenResponse.Bezoekadres,
										BezoekadresGemeente = verenigingenResponse.BezoekadresGemeente,
										BezoekadresPlaats = verenigingenResponse.BezoekadresPlaats,
										BezoekadresPostcode = verenigingenResponse.BezoekadresPostcode,
										DatumOpgericht = verenigingenResponse.DatumOpgericht,
										District = verenigingenResponse.District,
										Emailadres = verenigingenResponse.Emailadres,
										IbanCode = verenigingenResponse.IbanCode,
										KvKnummer = verenigingenResponse.KvKnummer,
										KvKplaats = verenigingenResponse.KvKplaats,
										Naam = verenigingenResponse.Naam,
										Postadres = verenigingenResponse.Postadres,
										PostadresGemeente = verenigingenResponse.PostadresGemeente,
										PostadresPlaats = verenigingenResponse.PostadresPlaats,
										PostadresPostcode = verenigingenResponse.PostadresPostcode,
										Regio = verenigingenResponse.Regio,
										TelefoonnummerAvond = verenigingenResponse.TelefoonnummerAvond,
										TelefoonnummerOverdag = verenigingenResponse.TelefoonnummerOverdag,
										Verenigingsnummer = verenigingenResponse.Verenigingsnummer,
										Website = verenigingenResponse.Website
                                        */
									};

									model.ClubCloud_Verenigingen.Add(vereniging);
								}
								else
								{
                                    /*
									vereniging.BanknummerPlaats = verenigingenResponse.BanknummerPlaats;
									vereniging.Bezoekadres = verenigingenResponse.Bezoekadres;
									vereniging.BezoekadresGemeente = verenigingenResponse.BezoekadresGemeente;
									vereniging.BezoekadresPlaats = verenigingenResponse.BezoekadresPlaats;
									vereniging.BezoekadresPostcode = verenigingenResponse.BezoekadresPostcode;
									vereniging.DatumOpgericht = verenigingenResponse.DatumOpgericht;
									vereniging.District = verenigingenResponse.District;
									vereniging.Emailadres = verenigingenResponse.Emailadres;
									vereniging.IbanCode = verenigingenResponse.IbanCode;
									vereniging.KvKnummer = verenigingenResponse.KvKnummer;
									vereniging.KvKplaats = verenigingenResponse.KvKplaats;
									vereniging.Naam = verenigingenResponse.Naam;
									vereniging.Postadres = verenigingenResponse.Postadres;
									vereniging.PostadresGemeente = verenigingenResponse.PostadresGemeente;
									vereniging.PostadresPlaats = verenigingenResponse.PostadresPlaats;
									vereniging.PostadresPostcode = verenigingenResponse.PostadresPostcode;
									vereniging.Regio = verenigingenResponse.Regio;
									vereniging.TelefoonnummerAvond = verenigingenResponse.TelefoonnummerAvond;
									vereniging.TelefoonnummerOverdag = verenigingenResponse.TelefoonnummerOverdag;
									vereniging.Verenigingsnummer = verenigingenResponse.Verenigingsnummer;
									vereniging.Website = verenigingenResponse.Website;
                                    */
								}
							}
						}
					}
					
				}
				model.SaveChanges();
			}

			return vereniging;
		}

		public ClubCloud_Vereniging GetVerenigingByNummer(string bondsnummer, string vereniginsnummer, bool refresh = false)
		{
			CheckDatabase();

			ClubCloud_Vereniging vereniging = new ClubCloud_Vereniging();
			using (ClubCloud.Service.Model.ClubCloudModelContainer model = new Model.ClubCloudModelContainer(GetConnectionString()))
			{              
				vereniging = model.ClubCloud_Verenigingen.FirstOrDefault(v => v.Nummer == vereniginsnummer);
				//vereniging = model.ClubCloud_Verenigingen.Select<ClubCloud_Vereniging, ClubCloud_Vereniging>(v => v.Verenigingsnummer == vereniginsnummer).First<ClubCloud_Vereniging>();

				if (vereniging == null || refresh)
				{
					ClubCloud_Setting settings = model.ClubCloud_Settings.Find(int.Parse(bondsnummer));

					if (settings != null && settings.mijnknltb_allow && !string.IsNullOrWhiteSpace(settings.mijnknltb_password))
					{
						CookieContainer cc = RequestContainer(settings.Id.ToString(), settings.mijnknltb_password);

						if (cc != null)
						{
							LedenadministratieServiceClient LedenAdministratie = new LedenadministratieServiceClient(cc, bondsnummer);

							ZoekVerenigingenResponse verenigingenResponse = LedenAdministratie.ZoekVerenigingen(new ZoekVerenigingenRequest { VerenigingsNummer = vereniginsnummer });
							if (verenigingenResponse != null && verenigingenResponse.GevondenVerenigingen != null)
							{
								GevondenVerenigingen gevonden = verenigingenResponse.GevondenVerenigingen.SingleOrDefault(v => v.VerenigingsNummer == vereniginsnummer);

								if (gevonden.Id.Value != null)
								{
									vereniging = GetVerenigingById(bondsnummer, gevonden.Id.Value, refresh);
								}
							}
						}
					}
				}
			}

			return vereniging;
		}

		public ClubCloud_Accomodatie GetAccommodatieForVereniging(string bondsnummer, Guid verenigingId, bool refresh = false)
		{
			CheckDatabase();

            ClubCloud_Accomodatie accomodatie = new ClubCloud_Accomodatie();

			using (ClubCloud.Service.Model.ClubCloudModelContainer model = new Model.ClubCloudModelContainer(GetConnectionString()))
			{
				ClubCloud_Setting settings = model.ClubCloud_Settings.Find(int.Parse(bondsnummer));

                accomodatie = model.ClubCloud_Accomodaties.SingleOrDefault(gv => gv.Id == verenigingId);

				if (settings != null && accomodatie == null || refresh)
				{
					if (settings.mijnknltb_allow && !string.IsNullOrWhiteSpace(settings.mijnknltb_password))
					{
						CookieContainer cc = RequestContainer(settings.Id.ToString(), settings.mijnknltb_password);

						if (cc != null)
						{
                            /*
							LedenadministratieServiceClient LedenAdministratie = new LedenadministratieServiceClient(cc, bondsnummer);

							GetAccommodatieForVerenigingResponse accomodatieResponse = LedenAdministratie.GetAccommodatieForVereniging(new GetAccommodatieForVerenigingRequest { Bondsnummer = bondsnummer, VerenigingId = verenigingId });
							if (accomodatieResponse != null)
							{
								if (accomodatie == null)
								{ 
									accomodatie = new ClubCloud_Vereniging_Accomodatie
									{
										Id = verenigingId,
										AccommodatieNaam = accomodatieResponse.AccommodatieNaam,
										BezoekAdres = new Model.Adres{ Gemeente = accomodatieResponse.BezoekAdres.Gemeente, Huisnummer = accomodatieResponse.BezoekAdres.Huisnummer,Plaats = accomodatieResponse.BezoekAdres.Plaats,Postcode = accomodatieResponse.BezoekAdres.Postcode,Straat = accomodatieResponse.BezoekAdres.Straat, Toevoeging = accomodatieResponse.BezoekAdres.Toevoeging },
										Minibanen = accomodatieResponse.Minibanen,
										Oefenmuren = accomodatieResponse.Oefenmuren,
										Ondergrond = accomodatieResponse.Ondergrond,
										Playgrounds = accomodatieResponse.Playgrounds,
										PostAdres = new Model.Adres { Gemeente = accomodatieResponse.PostAdres.Gemeente, Huisnummer = accomodatieResponse.PostAdres.Huisnummer, Plaats = accomodatieResponse.PostAdres.Plaats, Postcode = accomodatieResponse.PostAdres.Postcode, Straat = accomodatieResponse.PostAdres.Straat, Toevoeging = accomodatieResponse.PostAdres.Toevoeging },
										Speeltoestellen = accomodatieResponse.Speeltoestellen,
										TelefoonNummer = accomodatieResponse.TelefoonNummer

									};
									
									model.ClubCloud_Vereniging_Accomodaties.Add(accomodatie);
								}
								else
								{
										accomodatie.AccommodatieNaam = accomodatieResponse.AccommodatieNaam;
										accomodatie.BezoekAdres = new Model.Adres { Gemeente = accomodatieResponse.BezoekAdres.Gemeente, Huisnummer = accomodatieResponse.BezoekAdres.Huisnummer, Plaats = accomodatieResponse.BezoekAdres.Plaats, Postcode = accomodatieResponse.BezoekAdres.Postcode, Straat = accomodatieResponse.BezoekAdres.Straat, Toevoeging = accomodatieResponse.BezoekAdres.Toevoeging };
										accomodatie.Minibanen = accomodatieResponse.Minibanen;
										accomodatie.Oefenmuren = accomodatieResponse.Oefenmuren;
										accomodatie.Ondergrond = accomodatieResponse.Ondergrond;
										accomodatie.Playgrounds = accomodatieResponse.Playgrounds;
										accomodatie.PostAdres = new Model.Adres { Gemeente = accomodatieResponse.PostAdres.Gemeente, Huisnummer = accomodatieResponse.PostAdres.Huisnummer, Plaats = accomodatieResponse.PostAdres.Plaats, Postcode = accomodatieResponse.PostAdres.Postcode, Straat = accomodatieResponse.PostAdres.Straat, Toevoeging = accomodatieResponse.PostAdres.Toevoeging };
										accomodatie.Speeltoestellen = accomodatieResponse.Speeltoestellen;
										accomodatie.TelefoonNummer = accomodatieResponse.TelefoonNummer;
								}
							}
                            */
						}
					}
				}

				model.SaveChanges();
			}

			return accomodatie;
		}

		public ClubCloud_Accomodatie GetAccommodatie(string bondsnummer, Guid accommodatieId, bool refresh = false)
		{
			CheckDatabase();

			ClubCloud_Accomodatie accomodatie = new ClubCloud_Accomodatie();
			using (ClubCloud.Service.Model.ClubCloudModelContainer model = new Model.ClubCloudModelContainer(GetConnectionString()))
			{
				accomodatie = model.ClubCloud_Accomodaties.Find(accommodatieId);

				if (accomodatie == null || refresh)
				{
					ClubCloud_Setting settings = model.ClubCloud_Settings.Find(int.Parse(bondsnummer));

					if (settings != null && settings.mijnknltb_allow && !string.IsNullOrWhiteSpace(settings.mijnknltb_password))
					{
						CookieContainer cc = RequestContainer(settings.Id.ToString(), settings.mijnknltb_password);

						if (cc != null)
						{
							LedenadministratieServiceClient LedenAdministratie = new LedenadministratieServiceClient(cc, bondsnummer);

							GetAccommodatieResponse accomodatieResponse = LedenAdministratie.GetAccommodatie(new GetAccommodatieRequest { Bondsnummer = bondsnummer, AccommodatieId = accommodatieId });
							if (accomodatieResponse != null)
							{
								if (accomodatie == null)
								{
									accomodatie = new ClubCloud_Accomodatie
									{
										AantalBinnenBanen = accomodatieResponse.AantalBinnenBanen,
										AantalBuitenBanen = accomodatieResponse.AantalBuitenBanen,
										AccommodatieAdres = new Model.Adres { Gemeente = accomodatieResponse.AccommodatieAdres.Gemeente, Huisnummer = accomodatieResponse.AccommodatieAdres.Huisnummer, Plaats = accomodatieResponse.AccommodatieAdres.Plaats, Postcode = accomodatieResponse.AccommodatieAdres.Postcode, Straat = accomodatieResponse.AccommodatieAdres.Straat, Toevoeging = accomodatieResponse.AccommodatieAdres.Toevoeging },
										Blaashal = accomodatieResponse.Blaashal,
										BouwjaarClubhuis = accomodatieResponse.BouwjaarClubhuis,
										DatumKeuring = accomodatieResponse.DatumKeuring,
										DistrictNaam = accomodatieResponse.DistrictNaam,
										Email = accomodatieResponse.Email,
										Faxnummer = accomodatieResponse.Faxnummer,
										GekeurdDoor = accomodatieResponse.GekeurdDoor,
										HalAanwezig = accomodatieResponse.HalAanwezig,
										Id = accommodatieId,
										KleedruimteClubhuisAanwezig = accomodatieResponse.KleedruimteClubhuisAanwezig,
										MetOVBereikbaar = accomodatieResponse.MetOVBereikbaar,
										MinderValideParkeerplaatsen = accomodatieResponse.MinderValideParkeerplaatsen,
										Minibanen = accomodatieResponse.Minibanen,
										Naam = accomodatieResponse.Naam,
										Oefenmuren = accomodatieResponse.Oefenmuren,
										Ondergrond = accomodatieResponse.Ondergrond,
										OppervlakteClubhuis = accomodatieResponse.OppervlakteClubhuis,
										Overkapping = accomodatieResponse.Overkapping,
										Playgrounds = accomodatieResponse.Playgrounds,
										PostAdres = new Model.Adres { Gemeente = accomodatieResponse.PostAdres.Gemeente, Huisnummer = accomodatieResponse.PostAdres.Huisnummer, Plaats = accomodatieResponse.PostAdres.Plaats, Postcode = accomodatieResponse.PostAdres.Postcode, Straat = accomodatieResponse.PostAdres.Straat, Toevoeging = accomodatieResponse.PostAdres.Toevoeging },
										RegioNaam = accomodatieResponse.RegioNaam,
										Resultaatkeuring = accomodatieResponse.Resultaatkeuring,
										RolStoeltoegankelijk = accomodatieResponse.RolStoeltoegankelijk,
										SoortClubhuis = accomodatieResponse.SoortClubhuis,
										Speeltoestellen = accomodatieResponse.Speeltoestellen,
										Telefoonnummer = accomodatieResponse.Telefoonnummer,
										TotaalAantalWasKleedruimte = accomodatieResponse.TotaalAantalWasKleedruimte,
										ValideParkeerplaatsen = accomodatieResponse.ValideParkeerplaatsen,
										WasruimteClubhuisAanwezig = accomodatieResponse.WasruimteClubhuisAanwezig,
										Website = accomodatieResponse.Website

									};

									model.ClubCloud_Accomodaties.Add(accomodatie);
								}
								else
								{
									accomodatie.AantalBinnenBanen = accomodatieResponse.AantalBinnenBanen;
									accomodatie.AantalBuitenBanen = accomodatieResponse.AantalBuitenBanen;
									accomodatie.AccommodatieAdres = new Model.Adres { Gemeente = accomodatieResponse.AccommodatieAdres.Gemeente, Huisnummer = accomodatieResponse.AccommodatieAdres.Huisnummer, Plaats = accomodatieResponse.AccommodatieAdres.Plaats, Postcode = accomodatieResponse.AccommodatieAdres.Postcode, Straat = accomodatieResponse.AccommodatieAdres.Straat, Toevoeging = accomodatieResponse.AccommodatieAdres.Toevoeging };
									accomodatie.Blaashal = accomodatieResponse.Blaashal;
									accomodatie.BouwjaarClubhuis = accomodatieResponse.BouwjaarClubhuis;
									accomodatie.DatumKeuring = accomodatieResponse.DatumKeuring;
									accomodatie.DistrictNaam = accomodatieResponse.DistrictNaam;
									accomodatie.Email = accomodatieResponse.Email;
									accomodatie.Faxnummer = accomodatieResponse.Faxnummer;
									accomodatie.GekeurdDoor = accomodatieResponse.GekeurdDoor;
									accomodatie.HalAanwezig = accomodatieResponse.HalAanwezig;
									accomodatie.KleedruimteClubhuisAanwezig = accomodatieResponse.KleedruimteClubhuisAanwezig;
									accomodatie.MetOVBereikbaar = accomodatieResponse.MetOVBereikbaar;
									accomodatie.MinderValideParkeerplaatsen = accomodatieResponse.MinderValideParkeerplaatsen;
									accomodatie.Minibanen = accomodatieResponse.Minibanen;
									accomodatie.Naam = accomodatieResponse.Naam;
									accomodatie.Oefenmuren = accomodatieResponse.Oefenmuren;
									accomodatie.Ondergrond = accomodatieResponse.Ondergrond;
									accomodatie.OppervlakteClubhuis = accomodatieResponse.OppervlakteClubhuis;
									accomodatie.Overkapping = accomodatieResponse.Overkapping;
									accomodatie.Playgrounds = accomodatieResponse.Playgrounds;
									accomodatie.PostAdres = new Model.Adres { Gemeente = accomodatieResponse.PostAdres.Gemeente, Huisnummer = accomodatieResponse.PostAdres.Huisnummer, Plaats = accomodatieResponse.PostAdres.Plaats, Postcode = accomodatieResponse.PostAdres.Postcode, Straat = accomodatieResponse.PostAdres.Straat, Toevoeging = accomodatieResponse.PostAdres.Toevoeging };
									accomodatie.RegioNaam = accomodatieResponse.RegioNaam;
									accomodatie.Resultaatkeuring = accomodatieResponse.Resultaatkeuring;
									accomodatie.RolStoeltoegankelijk = accomodatieResponse.RolStoeltoegankelijk;
									accomodatie.SoortClubhuis = accomodatieResponse.SoortClubhuis;
									accomodatie.Speeltoestellen = accomodatieResponse.Speeltoestellen;
									accomodatie.Telefoonnummer = accomodatieResponse.Telefoonnummer;
									accomodatie.TotaalAantalWasKleedruimte = accomodatieResponse.TotaalAantalWasKleedruimte;
									accomodatie.ValideParkeerplaatsen = accomodatieResponse.ValideParkeerplaatsen;
									accomodatie.WasruimteClubhuisAanwezig = accomodatieResponse.WasruimteClubhuisAanwezig;
									accomodatie.Website = accomodatieResponse.Website;
								}

							}
						}
					}
				}
				model.SaveChanges();
			}

			return accomodatie;
		}

        public List<Functionaris> GetBestuurForVereniging(string bondsnummer, Guid verenigingId, bool refresh = false)
        {
            CheckDatabase();

            List<Functionaris> functionarissen = new List<Functionaris>();

            using (ClubCloud.Service.Model.MijnModelContainer model = new Model.MijnModelContainer(GetConnectionString()))
            {
                functionarissen = model.Functionarissen.Where(f => f.VerenigingId == verenigingId).ToList();
            }
            return functionarissen;
        }

        /*
		/// <summary>
		/// GetCompetitiesForVerenigingRequest
		/// </summary>
		public List<ClubCloud_Vereniging_Competitie> GetCompetitiesForVereniging(string bondsnummer, Guid verenigingId, bool refresh = false)
		{
			CheckDatabase();
			List<ClubCloud_Vereniging_Competitie> competities = new System.Collections.Generic.List<ClubCloud_Vereniging_Competitie>();

			using (ClubCloud.Service.Model.ClubCloudModelContainer model = new Model.ClubCloudModelContainer(GetConnectionString()))
			{
				competities = model.ClubCloud_Vereniging_Competities.Where(v => v.VerenigingId == verenigingId).ToList<ClubCloud_Vereniging_Competitie>();

				if (competities == null || competities.Count == 0 || refresh)
				{
					if (refresh)
					{
						try
						{
							model.ClubCloud_Vereniging_Competities.RemoveRange(competities);
							model.SaveChanges();
						}
						catch { }
					}

					ClubCloud_Setting settings = model.ClubCloud_Settings.Find(int.Parse(bondsnummer));

					if (settings.mijnknltb_allow && !string.IsNullOrWhiteSpace(settings.mijnknltb_password))
					{
						CookieContainer cc = RequestContainer(settings.Id.ToString(), settings.mijnknltb_password);

						if (cc != null)
						{
							LedenadministratieServiceClient LedenAdministratie = new LedenadministratieServiceClient(cc, bondsnummer);
							GetCompetitiesForVerenigingResponse competitieresponse = LedenAdministratie.GetCompetitiesForVereniging(new GetCompetitiesForVerenigingRequest { Bondsnummer = bondsnummer, VerenigingId = verenigingId });
							if (competitieresponse != null && competitieresponse.Competities.Length > 0)
							{
								foreach (CompetitieForVereniging competitie in competitieresponse.Competities)
								{
									ClubCloud_Vereniging_Competitie comp = competities.SingleOrDefault(v => v.VerenigingId == verenigingId && v.Id == competitie.Id);

									if (comp == null)
									{
										comp = model.ClubCloud_Vereniging_Competities.Create();
										comp.Id = competitie.Id;
										comp.Naam = competitie.Naam;
										comp.VerenigingId = verenigingId;
										comp.AantalPloegen = competitie.AantalPloegen;

										model.ClubCloud_Vereniging_Competities.Add(comp);

										competities.Add(comp);
									}
									else
									{
										comp.VerenigingId = verenigingId;
										comp.Naam = competitie.Naam;
										comp.AantalPloegen = competitie.AantalPloegen;
									}
								}
							}
						}
					}
				}
				model.SaveChanges();
			}

			return competities;
		}

		/// <summary>
		/// GetToernooienForVerenigingRequest
		/// </summary>
		/// <param name="bondsnummer"></param>
		/// <param name="verenigingId"></param>
		/// <param name="refresh"></param>
		/// <returns></returns>
		public List<ClubCloud_Vereniging_Toernooi> GetToernooienForVereniging(string bondsnummer, Guid verenigingId, bool refresh = false)
		{
			CheckDatabase();
			List<ClubCloud_Vereniging_Toernooi> toernooien = new System.Collections.Generic.List<ClubCloud_Vereniging_Toernooi>();

			using (ClubCloud.Service.Model.ClubCloudModelContainer model = new Model.ClubCloudModelContainer(GetConnectionString()))
			{
				toernooien = model.ClubCloud_Vereniging_Toernooien.Where(v => v.VerenigingId == verenigingId).ToList<ClubCloud_Vereniging_Toernooi>();

				if (toernooien == null || toernooien.Count == 0 || refresh)
				{
					if (refresh)
					{
						try
						{
							model.ClubCloud_Vereniging_Toernooien.RemoveRange(toernooien);
							model.SaveChanges();
						}
						catch { }
					}

					ClubCloud_Setting settings = model.ClubCloud_Settings.Find(int.Parse(bondsnummer));

					if (settings.mijnknltb_allow && !string.IsNullOrWhiteSpace(settings.mijnknltb_password))
					{
						CookieContainer cc = RequestContainer(settings.Id.ToString(), settings.mijnknltb_password);

						if (cc != null)
						{
							LedenadministratieServiceClient LedenAdministratie = new LedenadministratieServiceClient(cc, bondsnummer);
							GetToernooienForVerenigingResponse toernooiresponse = LedenAdministratie.GetToernooienForVereniging(new GetToernooienForVerenigingRequest { Bondsnummer = bondsnummer, VerenigingId = verenigingId });
							if (toernooiresponse != null && toernooiresponse.Toernooien.Length > 0)
							{
								foreach (ToernooiForVereniging toernooi in toernooiresponse.Toernooien)
								{
									ClubCloud_Vereniging_Toernooi toer = toernooien.SingleOrDefault(v => v.Id == toernooi.Id);

									if (toer == null)
									{
										toer = model.ClubCloud_Vereniging_Toernooien.Create();
										//toer.Id = toernooi.
										model.ClubCloud_Vereniging_Toernooien.Add(toer);

										toernooien.Add(toer);
									}
									else
									{
										//toer.VerenigingId = verenigingId;
									}
								}
							}
						}
					}
				}
				model.SaveChanges();
			}

			return toernooien;
		}
        */
		#endregion

		#region MetaData

		/// <summary>
		/// GetBasisorganisatiesRequest
		/// </summary>
		/// <returns></returns>
		public List<Basisorganisatie> GetBasisOrganisaties(string bondsnummer, bool refresh = false)
		{
			bool inclusiefAlleTypen = false;
			bool inclusiefVerenigingen = false;

			CheckDatabase();
			List<Basisorganisatie> organisaties = new System.Collections.Generic.List<Basisorganisatie>();

			using (ClubCloud.Service.Model.ClubCloudModelContainer model = new Model.ClubCloudModelContainer(GetConnectionString()))
			{
				ClubCloud_Setting settings = model.ClubCloud_Settings.Find(int.Parse(bondsnummer));

				if (settings.mijnknltb_allow && !string.IsNullOrWhiteSpace(settings.mijnknltb_password))
				{
					CookieContainer cc = RequestContainer(settings.Id.ToString(), settings.mijnknltb_password);

					if (cc != null)
					{
						LedenadministratieServiceClient LedenAdministratie = new LedenadministratieServiceClient(cc, bondsnummer);
						GetBasisorganisatiesResponse organisatieresponse = LedenAdministratie.GetBasisorganisaties(new GetBasisorganisatiesRequest { Bondsnummer = bondsnummer, InclusiefAlleTypen = inclusiefAlleTypen, InclusiefVerenigingen = inclusiefVerenigingen });
						if (organisatieresponse != null && organisatieresponse.Basisorganisaties.Length > 0)
						{
							foreach (Basisorganisatie organisatie in organisatieresponse.Basisorganisaties)
							{
								organisaties.Add(organisatie);
							}
						}
					}
				}
				model.SaveChanges();
			}

			return organisaties;
		}

		/// <summary>
		/// GetBasisOrganisatieForTypeRequest
		/// </summary>
		public List<Basisorganisatie> GetBasisOrganisaties(string bondsnummer, string verenigingsNummer, OrganisatieType organisatieType = OrganisatieType.Vereniging, bool refresh = false)
		{
			CheckDatabase();
			List<Basisorganisatie> organisaties = new System.Collections.Generic.List<Basisorganisatie>();

			using (ClubCloud.Service.Model.ClubCloudModelContainer model = new Model.ClubCloudModelContainer(GetConnectionString()))
			{
				ClubCloud_Setting settings = model.ClubCloud_Settings.Find(int.Parse(bondsnummer));

				if (settings.mijnknltb_allow && !string.IsNullOrWhiteSpace(settings.mijnknltb_password))
				{
					CookieContainer cc = RequestContainer(settings.Id.ToString(), settings.mijnknltb_password);

					if (cc != null)
					{
						LedenadministratieServiceClient LedenAdministratie = new LedenadministratieServiceClient(cc, bondsnummer);
						GetBasisOrganisatieForTypeResponse organisatieresponse = LedenAdministratie.GetBasisOrganisatieForType(new GetBasisOrganisatieForTypeRequest { Bondsnummer = bondsnummer, VerenigingsNummer = verenigingsNummer, OrganisatieType = organisatieType });
						if (organisatieresponse != null && organisatieresponse.Basisorganisaties.Length > 0)
						{
							foreach (Basisorganisatie organisatie in organisatieresponse.Basisorganisaties)
							{
								organisaties.Add(organisatie);
							}
						}
					}
				}
				model.SaveChanges();
			}

			return organisaties;
		}

		/// <summary>
		/// GetBasisOrganisatieForSpecifiekRequest
		/// </summary>
		public List<Basisorganisatie> GetBasisOrganisatie(string bondsnummer, string verenigingsNummer, Guid basisorganisatieId, bool refresh = false)
		{
			CheckDatabase();
			List<Basisorganisatie> organisaties = new System.Collections.Generic.List<Basisorganisatie>();

			using (ClubCloud.Service.Model.ClubCloudModelContainer model = new Model.ClubCloudModelContainer(GetConnectionString()))
			{
				ClubCloud_Setting settings = model.ClubCloud_Settings.Find(int.Parse(bondsnummer));

				if (settings.mijnknltb_allow && !string.IsNullOrWhiteSpace(settings.mijnknltb_password))
				{
					CookieContainer cc = RequestContainer(settings.Id.ToString(), settings.mijnknltb_password);

					if (cc != null)
					{
						LedenadministratieServiceClient LedenAdministratie = new LedenadministratieServiceClient(cc, bondsnummer);
						GetBasisOrganisatieForSpecifiekResponse organisatieresponse = LedenAdministratie.GetBasisOrganisatieForSpecifiek(new GetBasisOrganisatieForSpecifiekRequest { Bondsnummer = bondsnummer, Verenigingsnummer = verenigingsNummer, BasisorganisatieId = basisorganisatieId });
						if (organisatieresponse != null)
						{
							Basisorganisatie organisatie = new Basisorganisatie { Id = organisatieresponse.Id.Value, Organisatienaam = organisatieresponse.Organisatienaam, Organisatienummer = organisatieresponse.Organisatienummer };
								organisaties.Add(organisatie);
						}
					}
				}
				model.SaveChanges();
			}

			return organisaties;
		}

		/// <summary>
		/// GetBasisOrganisatieLandelijkRequest
		/// </summary>
		public string GetBasisOrganisatieLandelijk(string bondsnummer, bool refresh = false)
		{
			string OrganisatieLandelijk = string.Empty;

			CheckDatabase();

			using (ClubCloud.Service.Model.ClubCloudModelContainer model = new Model.ClubCloudModelContainer(GetConnectionString()))
			{
				ClubCloud_Setting settings = model.ClubCloud_Settings.Find(int.Parse(bondsnummer));

				if (settings.mijnknltb_allow && !string.IsNullOrWhiteSpace(settings.mijnknltb_password))
				{
					CookieContainer cc = RequestContainer(settings.Id.ToString(), settings.mijnknltb_password);

					if (cc != null)
					{
						LedenadministratieServiceClient LedenAdministratie = new LedenadministratieServiceClient(cc, bondsnummer);
						GetBasisOrganisatieLandelijkResponse organisatieresponse = LedenAdministratie.GetBasisOrganisatieLandelijk(new GetBasisOrganisatieLandelijkRequest { });
						if (organisatieresponse != null)
						{
							OrganisatieLandelijk = organisatieresponse.BasisOrganisatieLandelijk;
						}
					}
				}
				model.SaveChanges();
			}
			return OrganisatieLandelijk;
		}

		/// <summary>
		/// GetNationaliteiten
		/// </summary>
		/// <param name="bondsnummer"></param>
		/// <param name="refresh"></param>
		/// <returns></returns>
		public List<ClubCloud_Nationaliteit> GetNationaliteiten(string bondsnummer, bool refresh = false)
		{
			List<ClubCloud_Nationaliteit> nationaliteiten = new System.Collections.Generic.List<ClubCloud_Nationaliteit>();

			CheckDatabase();

			using (ClubCloud.Service.Model.ClubCloudModelContainer model = new Model.ClubCloudModelContainer(GetConnectionString()))
			{
				nationaliteiten = model.ClubCloud_Nationaliteiten.Where(n => n.Naam != string.Empty).ToList<ClubCloud_Nationaliteit>();

				ClubCloud_Setting settings = model.ClubCloud_Settings.Find(int.Parse(bondsnummer));

				if (nationaliteiten == null && nationaliteiten.Count == 0 || refresh)
				{
					if (refresh)
					{
						try
						{
							model.ClubCloud_Nationaliteiten.RemoveRange(nationaliteiten);
							model.SaveChanges();
						}
						catch { }
					}

					if (settings.mijnknltb_allow && !string.IsNullOrWhiteSpace(settings.mijnknltb_password))
					{
						CookieContainer cc = RequestContainer(settings.Id.ToString(), settings.mijnknltb_password);

						if (cc != null)
						{
							LedenadministratieServiceClient LedenAdministratie = new LedenadministratieServiceClient(cc, bondsnummer);
							GetNationaliteitenResponse nationaliteitenresponse = LedenAdministratie.GetNationaliteiten(new GetNationaliteitenRequest { Bondsnummer = bondsnummer });

							if (nationaliteitenresponse != null && nationaliteitenresponse.Nationaliteiten.Length > 0)
							{
								foreach (Nationaliteit nationaliteit in nationaliteitenresponse.Nationaliteiten)
								{
									ClubCloud_Nationaliteit nation = nationaliteiten.SingleOrDefault(b => b.Id == nationaliteit.Id);

									if(nation == null)
									{
										nation = model.ClubCloud_Nationaliteiten.Create();

										nation.Id = nationaliteit.Id;
										nation.Naam = nationaliteit.Naam;
										model.ClubCloud_Nationaliteiten.Add(nation);
										nationaliteiten.Add(nation);

									}
									else
									{
										nation.Naam = nationaliteit.Naam;
									}
								}
							}
						}
					}
				}
				model.SaveChanges();
			}
			return nationaliteiten;
		}

		#endregion

		#region Competitie

		public List<Guid> GetCompetitiesForInschrijving(string bondsnummer, Guid verenigingId, Guid districtId, bool refresh = false)
		{
			CheckDatabase();

			List<Guid> competities = new System.Collections.Generic.List<Guid>();

			using (ClubCloud.Service.Model.ClubCloudModelContainer model = new Model.ClubCloudModelContainer(GetConnectionString()))
			{
				ClubCloud_Setting settings = model.ClubCloud_Settings.Find(int.Parse(bondsnummer));

				if (settings != null && settings.mijnknltb_allow && !string.IsNullOrWhiteSpace(settings.mijnknltb_password))
				{
					CookieContainer cc = RequestContainer(settings.Id.ToString(), settings.mijnknltb_password);

					if (cc != null)
					{
						CompetitieServiceClient Competitie = new CompetitieServiceClient(cc, bondsnummer);
						GetCompetitiesForInschrijvingResponse competitieResponse = Competitie.GetCompetitiesForInschrijving(new GetCompetitiesForInschrijvingRequest { DistrictId = districtId, VerenigingId = verenigingId });

						if(competitieResponse != null && competitieResponse.Competities.Length > 0)
						{
							foreach (Guid competitie in competitieResponse.Competities)
							{
								competities.Add(competitie);      
							}
						}
					}
				}
				model.SaveChanges();
			}
			return competities;
		}

		public List<Competitie> GetCompetitiesAfgelopenJaar(string bondsnummer, bool refresh = false)
		{
			return GetCompetities(bondsnummer,GetCompetitiesFilter.CompetitiesAfgelopenJaar, refresh);
		}

		public List<Competitie> GetCompetitiesMijnKnltb(string bondsnummer, bool refresh = false)
		{
			return GetCompetities(bondsnummer, GetCompetitiesFilter.CompetitiesMijnKnltb, refresh);
		}

		private List<Competitie> GetCompetities(string bondsnummer, GetCompetitiesFilter filter, bool refresh = false)
		{
			CheckDatabase();
			
			List<Competitie> competities = new System.Collections.Generic.List<Competitie>();

			using (ClubCloud.Service.Model.ClubCloudModelContainer model = new Model.ClubCloudModelContainer(GetConnectionString()))
			{
				ClubCloud_Setting settings = model.ClubCloud_Settings.Find(int.Parse(bondsnummer));

				if (settings != null && settings.mijnknltb_allow && !string.IsNullOrWhiteSpace(settings.mijnknltb_password))
				{
					CookieContainer cc = RequestContainer(settings.Id.ToString(), settings.mijnknltb_password);

					if (cc != null)
					{
						CompetitieServiceClient Competitie = new CompetitieServiceClient(cc, bondsnummer);
						GetCompetitiesResponse competitieResponse = Competitie.GetCompetities(new GetCompetitiesRequest { Filter = filter });

						if(competitieResponse != null && competitieResponse.Competities.Length > 0)
						{
							foreach (Competitie competitie in competitieResponse.Competities)
							{
								competities.Add(competitie);
							}
						}
					}
				}
				model.SaveChanges();
			}
			return competities;
		}

		public List<Klassengroep> GetKlassengroepenForInschrijvingGeopend(string bondsnummer, Guid verenigingId, Guid competitieId, bool refresh = false)
		{
			return GetKlassengroepenForInschrijving(bondsnummer, verenigingId, competitieId, StatusCompetitieFilter.InschrijvingGeopend, refresh);
		}

		public List<Klassengroep> GetKlassengroepenForInschrijvingGeopendEnGesloten(string bondsnummer, Guid verenigingId, Guid competitieId, bool refresh = false)
		{
			return GetKlassengroepenForInschrijving(bondsnummer, verenigingId, competitieId, StatusCompetitieFilter.InschrijvingGeopendEnGesloten, refresh);
		}

		private List<Klassengroep> GetKlassengroepenForInschrijving(string bondsnummer, Guid verenigingId, Guid competitieId, StatusCompetitieFilter statusFilter, bool refresh = false)
		{
			CheckDatabase();
			List<Klassengroep> klassengroepen = new List<Klassengroep>();

			using (ClubCloud.Service.Model.ClubCloudModelContainer model = new Model.ClubCloudModelContainer(GetConnectionString()))
			{
				ClubCloud_Setting settings = model.ClubCloud_Settings.Find(int.Parse(bondsnummer));

				if (settings != null && settings.mijnknltb_allow && !string.IsNullOrWhiteSpace(settings.mijnknltb_password))
				{
					CookieContainer cc = RequestContainer(settings.Id.ToString(), settings.mijnknltb_password);

					if (cc != null)
					{
						CompetitieServiceClient Competitie = new CompetitieServiceClient(cc, bondsnummer);
						GetKlassengroepenForInschrijvingResponse klassengroepResponse = Competitie.GetKlassengroepenForInschrijving(new GetKlassengroepenForInschrijvingRequest { CompetitieId = competitieId, StatusFilter = statusFilter, VerenigingId = verenigingId });

						if (klassengroepResponse != null && klassengroepResponse.Klassengroepen.Length > 0)
						{
							foreach (Klassengroep klassengroep in klassengroepResponse.Klassengroepen)
							{
								klassengroepen.Add(klassengroep);
							}
						}
					}
				}
				model.SaveChanges();
			}
			return klassengroepen;
		}

		public List<Klassengroep> GetKlassengroepen(string bondsnummer, Guid competitieId, bool refresh = false)
		{
			CheckDatabase();

			List<Klassengroep> klassengroepen = new List<Klassengroep>();

			using (ClubCloud.Service.Model.ClubCloudModelContainer model = new Model.ClubCloudModelContainer(GetConnectionString()))
			{
				ClubCloud_Setting settings = model.ClubCloud_Settings.Find(int.Parse(bondsnummer));

				if (settings != null && settings.mijnknltb_allow && !string.IsNullOrWhiteSpace(settings.mijnknltb_password))
				{
					CookieContainer cc = RequestContainer(settings.Id.ToString(), settings.mijnknltb_password);

					if (cc != null)
					{
						CompetitieServiceClient Competitie = new CompetitieServiceClient(cc, bondsnummer);
						GetKlassengroepenResponse klassengroepResponse = Competitie.GetKlassengroepen(new GetKlassengroepenRequest { CompetitieId = competitieId });

						if (klassengroepResponse != null && klassengroepResponse.Klassengroepen.Length > 0)
						{
							foreach (Klassengroep klassengroep in klassengroepResponse.Klassengroepen)
							{
								klassengroepen.Add(klassengroep);
							}

						}
					}
				}
				model.SaveChanges();
			}
			return klassengroepen;
		}

		public List<Partijresultaat> GetPartijresultaten(string bondsnummer, Guid wedstrijdgegevenId, bool refresh = false)
		{
			CheckDatabase();

			List<Partijresultaat> partijen = new System.Collections.Generic.List<Partijresultaat>();

			using (ClubCloud.Service.Model.ClubCloudModelContainer model = new Model.ClubCloudModelContainer(GetConnectionString()))
			{
				ClubCloud_Setting settings = model.ClubCloud_Settings.Find(int.Parse(bondsnummer));

				if (settings != null && settings.mijnknltb_allow && !string.IsNullOrWhiteSpace(settings.mijnknltb_password))
				{
					CookieContainer cc = RequestContainer(settings.Id.ToString(), settings.mijnknltb_password);

					if (cc != null)
					{
						CompetitieServiceClient Competitie = new CompetitieServiceClient(cc, bondsnummer);
						GetPartijresultatenResponse partijResponse = Competitie.GetPartijresultaten(new GetPartijresultatenRequest { WedstrijdgegevenId = wedstrijdgegevenId });

						if(partijResponse != null && partijResponse.Partijresultaten.Length > 0)
						{

							foreach (Partijresultaat partij in partijResponse.Partijresultaten)
							{
								partijen.Add(partij);
							}
						}
					}
				}
				model.SaveChanges();
			}
			return partijen;
		}

		public List<Ploeg> GetPloegen(string bondsnummer, Guid competitieId, bool refresh = false)
		{
			CheckDatabase();

			List<Ploeg> ploegen = new System.Collections.Generic.List<Ploeg>();
			using (ClubCloud.Service.Model.ClubCloudModelContainer model = new Model.ClubCloudModelContainer(GetConnectionString()))
			{
				ClubCloud_Setting settings = model.ClubCloud_Settings.Find(int.Parse(bondsnummer));

				if (settings != null && settings.mijnknltb_allow && !string.IsNullOrWhiteSpace(settings.mijnknltb_password))
				{
					CookieContainer cc = RequestContainer(settings.Id.ToString(), settings.mijnknltb_password);

					if (cc != null)
					{
						CompetitieServiceClient Competitie = new CompetitieServiceClient(cc, bondsnummer);
						GetPloegenResponse ploegenResponse = Competitie.GetPloegen(new GetPloegenRequest { CompetitieId = competitieId });

						if(ploegenResponse != null && ploegenResponse.Ploegen.Length > 0)
						{

							foreach (Ploeg ploeg in ploegenResponse.Ploegen)
							{
								ploegen.Add(ploeg);   
							}
						}
					}
				}
				model.SaveChanges();
			}
			return ploegen;
		}

		public List<Stand> GetStandenByPloeg(string bondsnummer, Guid ploegId, Guid competitieId, bool refresh = false)
		{
			return GetStanden(bondsnummer,ploegId, competitieId,GetStandenRequestFilter.GetStandenForCompetitieAndPloeg,refresh);
		}

		public List<Stand> GetStandenByVereniging(string bondsnummer, Guid verenigingId, Guid competitieId, bool refresh = false)
		{
			return GetStanden(bondsnummer, verenigingId, competitieId, GetStandenRequestFilter.GetStandenForCompetitieAndVereniging, refresh);
		}

		public List<Stand> GetStandenByAfdeling(string bondsnummer, Guid afdelingId, Guid competitieId, bool refresh = false)
		{
			return GetStanden(bondsnummer, afdelingId, competitieId, GetStandenRequestFilter.GetStandenForCompetitieAndAfdeling, refresh);
		}

		private List<Stand> GetStanden(string bondsnummer, Guid filterId, Guid competitieId, GetStandenRequestFilter filter, bool refresh = false)
		{
			CheckDatabase();

			List<Stand> standen = new System.Collections.Generic.List<Stand>();

			using (ClubCloud.Service.Model.ClubCloudModelContainer model = new Model.ClubCloudModelContainer(GetConnectionString()))
			{
				ClubCloud_Setting settings = model.ClubCloud_Settings.Find(int.Parse(bondsnummer));

				if (settings != null && settings.mijnknltb_allow && !string.IsNullOrWhiteSpace(settings.mijnknltb_password))
				{
					CookieContainer cc = RequestContainer(settings.Id.ToString(), settings.mijnknltb_password);

					if (cc != null)
					{
						CompetitieServiceClient Competitie = new CompetitieServiceClient(cc, bondsnummer);
						GetStandenResponse standenResponse = Competitie.GetStanden(new GetStandenRequest { AfdelingVerenigingPloegId = filterId, CompetitieId = competitieId, Filter = filter });

						if(standenResponse != null && standenResponse.Standen.Length > 0)
						{
							foreach (Stand stand in standenResponse.Standen)
							{
								standen.Add(stand);  
							}
						}
					}
				}
				model.SaveChanges();
			}

			return standen;
		}

		public List<UitslagAfdeling> GetUitslagenAfdeling(string bondsnummer, Guid afdelingId, Guid competitieId, Guid piramideId, bool refresh = false)
		{
			CheckDatabase();

			List<UitslagAfdeling> uitslagen = new System.Collections.Generic.List<UitslagAfdeling>();

			using (ClubCloud.Service.Model.ClubCloudModelContainer model = new Model.ClubCloudModelContainer(GetConnectionString()))
			{
				ClubCloud_Setting settings = model.ClubCloud_Settings.Find(int.Parse(bondsnummer));

				if (settings != null && settings.mijnknltb_allow && !string.IsNullOrWhiteSpace(settings.mijnknltb_password))
				{
					CookieContainer cc = RequestContainer(settings.Id.ToString(), settings.mijnknltb_password);

					if (cc != null)
					{
						CompetitieServiceClient Competitie = new CompetitieServiceClient(cc, bondsnummer);
						GetUitslagenAfdelingResponse uitslagenResponse = Competitie.GetUitslagenAfdeling(new GetUitslagenAfdelingRequest { AfdelingId = afdelingId, CompetitieId = competitieId, PiramideId = piramideId });

						if(uitslagenResponse != null && uitslagenResponse.UitslagenAfdeling.Length > 0)
						{

							foreach (UitslagAfdeling uitslag in uitslagenResponse.UitslagenAfdeling)
							{
								uitslagen.Add(uitslag);
							}
						}
					}
				}
				model.SaveChanges();
			}
			return uitslagen;
		}

		public List<ClubCloud.KNLTB.ServIt.CompetitieService.Vereniging> GetVerenigingen(string bondsnummer, Guid competitieId, GetVerenigingenFilter filter, string verenigingsNummer, bool refresh = false)
		{
			CheckDatabase();

			List<ClubCloud.KNLTB.ServIt.CompetitieService.Vereniging> verenigingen = new System.Collections.Generic.List<KNLTB.ServIt.CompetitieService.Vereniging>();

			using (ClubCloud.Service.Model.ClubCloudModelContainer model = new Model.ClubCloudModelContainer(GetConnectionString()))
			{
				ClubCloud_Setting settings = model.ClubCloud_Settings.Find(int.Parse(bondsnummer));

				if (settings != null && settings.mijnknltb_allow && !string.IsNullOrWhiteSpace(settings.mijnknltb_password))
				{
					CookieContainer cc = RequestContainer(settings.Id.ToString(), settings.mijnknltb_password);

					if (cc != null)
					{
						CompetitieServiceClient Competitie = new CompetitieServiceClient(cc, bondsnummer);
						GetVerenigingenResponse verenigingenResponse = Competitie.GetVerenigingen(new GetVerenigingenRequest { CompetitieId = competitieId, Filter = filter, VerenigingsNummer = verenigingsNummer });

						if(verenigingenResponse  != null && verenigingenResponse.Verenigingen.Length> 0)
						{
							foreach (ClubCloud.KNLTB.ServIt.CompetitieService.Vereniging vereniging in verenigingenResponse.Verenigingen)
							{
								verenigingen.Add(vereniging);
							}
						}
					}
				}
				model.SaveChanges();
			}
			return verenigingen;
		}

		public List<Wedstrijdgegevens> GetWedstrijdgegevensForAfdeling(string bondsnummer, Guid competitieId, Guid afdelingId, bool refresh = false)
		{
			return GetWedstrijdgegevens(bondsnummer, competitieId, GetWedstrijdgegevensFilter.WedstrijdgegevensForAfdeling, afdelingId, refresh);
		}

		public List<Wedstrijdgegevens> GetWedstrijdgegevensForVereniging(string bondsnummer, Guid competitieId, Guid verenigingId, bool refresh = false)
		{
			return GetWedstrijdgegevens(bondsnummer, competitieId, GetWedstrijdgegevensFilter.WedstrijdgegevensForVereniging, verenigingId, refresh);
		}

		public List<Wedstrijdgegevens> GetWedstrijdgegevensForWedstrijdgegeven(string bondsnummer, Guid competitieId, Guid wedstrijdgegevenId, bool refresh = false)
		{
			return GetWedstrijdgegevens(bondsnummer, competitieId, GetWedstrijdgegevensFilter.WedstrijdgegevensForWedstrijdgegeven, wedstrijdgegevenId, refresh);
		}

		private List<Wedstrijdgegevens> GetWedstrijdgegevens(string bondsnummer, Guid competitieId, GetWedstrijdgegevensFilter filter, Guid filterId, bool refresh = false)
		{
			CheckDatabase();

			List<Wedstrijdgegevens> wedstrijdgegevens = new System.Collections.Generic.List<Wedstrijdgegevens>();

			using (ClubCloud.Service.Model.ClubCloudModelContainer model = new Model.ClubCloudModelContainer(GetConnectionString()))
			{
				ClubCloud_Setting settings = model.ClubCloud_Settings.Find(int.Parse(bondsnummer));

				if (settings != null && settings.mijnknltb_allow && !string.IsNullOrWhiteSpace(settings.mijnknltb_password))
				{
					CookieContainer cc = RequestContainer(settings.Id.ToString(), settings.mijnknltb_password);

					if (cc != null)
					{
						CompetitieServiceClient Competitie = new CompetitieServiceClient(cc, bondsnummer);
						GetWedstrijdgegevensResponse wedstrijdgegevensResponse = Competitie.GetWedstrijdgegevens(new GetWedstrijdgegevensRequest { CompetitieId = competitieId, Filter = filter, AfdelingVerenigingWedstrijdgegevenId = filterId, GeslachtNvt = true });

						if (wedstrijdgegevensResponse != null && wedstrijdgegevensResponse.Wedstrijdgegevens.Length > 0)
						{
							foreach (Wedstrijdgegevens gegevens in wedstrijdgegevensResponse.Wedstrijdgegevens)
							{
								wedstrijdgegevens.Add(gegevens);
							}
						}
					}
				}
				model.SaveChanges();
			}
			return wedstrijdgegevens;
		}

		#endregion

        #region Beheer

        #region District

        /// <summary>
        /// sgt_alg_district
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="refresh"></param>
        /// <returns></returns>
        public List<ClubCloud_District> Districten(string bondsnummer, bool refresh = false)
        {
            CheckDatabase();

            List<ClubCloud_District> districten = new List<ClubCloud_District>();

            using (ClubCloud.Service.Model.ClubCloudModelContainer model = new Model.ClubCloudModelContainer(GetConnectionString()))
            {
                districten = model.ClubCloud_Districten.ToList();

                if (districten != null && districten.Count == 0)
                {
                    ClubCloud_Setting settings = model.ClubCloud_Settings.Find(int.Parse(bondsnummer));
                    if (settings != null && settings.mijnknltb_allow && !string.IsNullOrWhiteSpace(settings.mijnknltb_password))
                    {
                        CookieContainer cc = RequestContainer(settings.Id.ToString(), settings.mijnknltb_password);

                        if (cc != null)
                        {
                            ClubCloud.KNLTB.ServIt.CrmService.CrmService service = new KNLTB.ServIt.CrmService.CrmService(cc);
                            /*
                            service.CallerOriginTokenValue = null;
                            service.CorrelationTokenValue = null;
                            service.CrmAuthenticationTokenValue = new KNLTB.ServIt.CrmService.CrmAuthenticationToken { AuthenticationType = 0, OrganizationName = "KNLTB", CrmTicket = string.Empty, CallerId = new Guid("00000000-0000-0000-0000-000000000000") };
                            service.CrmCookieContainer = cc;
                            */

                            bool moreRecords = true;
                            int pageNum = 1;
                            while (moreRecords)
                            {
                                List<BusinessEntity> entities = RetrieveMultiple(service, "sgt_alg_district", out moreRecords, ref pageNum);

                                foreach (sgt_alg_district entity in entities)
                                {
                                    ClubCloud_District district = model.ClubCloud_Districten.Find(entity.sgt_alg_districtid.Value);

                                    if (district == null)
                                    {
                                        district = model.ClubCloud_Districten.Create();
                                        district.Id = entity.sgt_alg_districtid.Value;
                                        district.Beschrijving = entity.sgt_beschrijving;
                                        district.Naam = entity.sgt_alg_district1;
                                        district.Omschrijving = entity.sgt_omschrijving;
                                        district.Beschrijving = entity.sgt_beschrijving;
                                        RegioById(bondsnummer, entity.sgt_regioid.Value, entity.sgt_regioid.name, true);
                                        district.RegioId = entity.sgt_regioid.Value;
                                        district.Actief = entity.statuscode.name;
                                        model.ClubCloud_Districten.Add(district);
                                        districten.Add(district);
                                    }
                                    else
                                    {
                                        district.Beschrijving = entity.sgt_beschrijving;
                                        district.Naam = entity.sgt_alg_district1;
                                        district.Omschrijving = entity.sgt_omschrijving;
                                        district.Beschrijving = entity.sgt_beschrijving;
                                        district.RegioId = entity.sgt_regioid.Value;
                                        district.Actief = entity.statuscode.name;
                                    }
                                }
                            }
                        }
                    }
                }
                model.SaveChanges();
            }
            return districten;
            //sgt_alg_functie
        }

        /// <summary>
        /// sgt_alg_district
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="districtId"></param>
        /// <param name="refresh"></param>
        /// <returns></returns>
        public ClubCloud_District DistrictById(string bondsnummer, Guid districtId, bool refresh = false)
        {
            CheckDatabase();

            ClubCloud_District district = new ClubCloud_District();

            using (ClubCloud.Service.Model.ClubCloudModelContainer model = new Model.ClubCloudModelContainer(GetConnectionString()))
            {
                district = model.ClubCloud_Districten.Find(districtId);

                if (district != null)
                {
                    ClubCloud_Setting settings = model.ClubCloud_Settings.Find(int.Parse(bondsnummer));

                    if (settings != null && settings.mijnknltb_allow && !string.IsNullOrWhiteSpace(settings.mijnknltb_password))
                    {
                        CookieContainer cc = RequestContainer(settings.Id.ToString(), settings.mijnknltb_password);

                        if (cc != null)
                        {
                            ClubCloud.KNLTB.ServIt.CrmService.CrmService service = new KNLTB.ServIt.CrmService.CrmService(cc);

                            bool moreRecords = true;
                            int pageNum = 1;
                            while (moreRecords)
                            {
                                ConditionExpression condition = new ConditionExpression { AttributeName = "sgt_alg_districtid", Operator = ConditionOperator.Equal, Values = new object[1] { districtId } };
                                FilterExpression expression = new FilterExpression { FilterOperator = LogicalOperator.And, Conditions = new ConditionExpression[1] { condition } };

                                List<BusinessEntity> entities = RetrieveMultiple(service, "sgt_alg_district", out moreRecords, ref pageNum, expression);

                                foreach (sgt_alg_district entity in entities)
                                {
                                    district = model.ClubCloud_Districten.Find(entity.sgt_alg_districtid.Value);

                                    if (district == null)
                                    {
                                        district = model.ClubCloud_Districten.Create();
                                        district.Id = entity.sgt_alg_districtid.Value;
                                        district.Beschrijving = entity.sgt_beschrijving;
                                        district.Naam = entity.sgt_alg_district1;
                                        district.Omschrijving = entity.sgt_omschrijving;
                                        district.Beschrijving = entity.sgt_beschrijving;
                                        RegioById(bondsnummer, entity.sgt_regioid.Value, entity.sgt_regioid.name, true);
                                        district.RegioId = entity.sgt_regioid.Value;
                                        district.Actief = entity.statuscode.name;
                                        model.ClubCloud_Districten.Add(district);

                                    }
                                    else
                                    {
                                        district.Beschrijving = entity.sgt_beschrijving;
                                        district.Naam = entity.sgt_alg_district1;
                                        district.Omschrijving = entity.sgt_omschrijving;
                                        district.Beschrijving = entity.sgt_beschrijving;
                                        district.RegioId = entity.sgt_regioid.Value;
                                        district.Actief = entity.statuscode.name;
                                    }
                                }
                            }
                        }
                    }
                }
                model.SaveChanges();
            }
            return district;
            //sgt_alg_functie
        }

        /// <summary>
        /// sgt_alg_district
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="regioId"></param>
        /// <param name="refresh"></param>
        /// <returns></returns>
        public ClubCloud_District DistrictByRegio(string bondsnummer, Guid regioId, bool refresh = false)
        {
            CheckDatabase();

            ClubCloud_District district = new ClubCloud_District();

            using (ClubCloud.Service.Model.ClubCloudModelContainer model = new Model.ClubCloudModelContainer(GetConnectionString()))
            {
                district = model.ClubCloud_Districten.SingleOrDefault(d => d.RegioId == regioId);

                if (district != null)
                {
                    ClubCloud_Setting settings = model.ClubCloud_Settings.Find(int.Parse(bondsnummer));
                    if (settings != null && settings.mijnknltb_allow && !string.IsNullOrWhiteSpace(settings.mijnknltb_password))
                    {
                        CookieContainer cc = RequestContainer(settings.Id.ToString(), settings.mijnknltb_password);

                        if (cc != null)
                        {
                            ClubCloud.KNLTB.ServIt.CrmService.CrmService service = new KNLTB.ServIt.CrmService.CrmService(cc);

                            bool moreRecords = true;
                            int pageNum = 1;
                            while (moreRecords)
                            {
                                ConditionExpression condition = new ConditionExpression { AttributeName = "sgt_regioid", Operator = ConditionOperator.Equal, Values = new object[1] { regioId } };
                                FilterExpression expression = new FilterExpression { FilterOperator = LogicalOperator.And, Conditions = new ConditionExpression[1] { condition } };

                                List<BusinessEntity> entities = RetrieveMultiple(service, "sgt_alg_district", out moreRecords, ref pageNum, expression);

                                foreach (sgt_alg_district entity in entities)
                                {
                                    district = model.ClubCloud_Districten.Find(entity.sgt_alg_districtid.Value);

                                    if (district == null)
                                    {
                                        district = model.ClubCloud_Districten.Create();
                                        district.Id = entity.sgt_alg_districtid.Value;
                                        district.Beschrijving = entity.sgt_beschrijving;
                                        district.Naam = entity.sgt_alg_district1;
                                        district.Omschrijving = entity.sgt_omschrijving;
                                        district.Beschrijving = entity.sgt_beschrijving;
                                        RegioById(bondsnummer, entity.sgt_regioid.Value, entity.sgt_regioid.name, true);
                                        district.RegioId = entity.sgt_regioid.Value;
                                        district.Actief = entity.statuscode.name;
                                        model.ClubCloud_Districten.Add(district);
                                    }
                                    else
                                    {
                                        district.Id = entity.sgt_alg_districtid.Value;
                                        district.Beschrijving = entity.sgt_beschrijving;
                                        district.Naam = entity.sgt_alg_district1;
                                        district.Omschrijving = entity.sgt_omschrijving;
                                        district.Beschrijving = entity.sgt_beschrijving;
                                        RegioById(bondsnummer, entity.sgt_regioid.Value, entity.sgt_regioid.name, true);
                                        district.RegioId = entity.sgt_regioid.Value;
                                        district.Actief = entity.statuscode.name;
                                    }
                                }
                            }
                        }
                    }
                }
                model.SaveChanges();
            }
            return district;
            //sgt_alg_functie
        }

        #endregion

        #region Regio

        public List<ClubCloud_Regio> Regios(string bondsnummer, bool refresh = false)
        {
            CheckDatabase();

            List<ClubCloud_Regio> regios = new List<ClubCloud_Regio>();

            using (ClubCloud.Service.Model.ClubCloudModelContainer model = new Model.ClubCloudModelContainer(GetConnectionString()))
            {
                regios = model.ClubCloud_Regios.ToList();

            }
            return regios;
        }

        public ClubCloud_Regio RegioById(string bondsnummer, Guid regioId, string naam = null, bool refresh = false)
        {
            CheckDatabase();

            ClubCloud_Regio regio = new ClubCloud_Regio();

            using (ClubCloud.Service.Model.ClubCloudModelContainer model = new Model.ClubCloudModelContainer(GetConnectionString()))
            {
                regio = model.ClubCloud_Regios.Find(regioId);

                if(regio == null && naam != null)
                {
                    regio = model.ClubCloud_Regios.Create();
                    regio.Id = regioId;
                    regio.Naam = naam;
                    model.ClubCloud_Regios.Add(regio);
                }
                model.SaveChanges();
            }
            return regio;
        }

        #endregion

        #region Rechtsvorm

        public List<ClubCloud_Rechtsvorm> Rechtsvormen(string bondsnummer, bool refresh = false)
        {
            CheckDatabase();

            List<ClubCloud_Rechtsvorm> rechtsvormen = new List<ClubCloud_Rechtsvorm>();

            using (ClubCloud.Service.Model.ClubCloudModelContainer model = new Model.ClubCloudModelContainer(GetConnectionString()))
            {
                rechtsvormen = model.ClubCloud_Rechtsvormen.ToList();

                if (rechtsvormen != null && rechtsvormen.Count == 0)
                {
                    ClubCloud_Setting settings = model.ClubCloud_Settings.Find(int.Parse(bondsnummer));
                    if (settings != null && settings.mijnknltb_allow && !string.IsNullOrWhiteSpace(settings.mijnknltb_password))
                    {
                        CookieContainer cc = RequestContainer(settings.Id.ToString(), settings.mijnknltb_password);

                        if (cc != null)
                        {
                            ClubCloud.KNLTB.ServIt.CrmService.CrmService service = new KNLTB.ServIt.CrmService.CrmService(cc);
                            /*
                            service.CallerOriginTokenValue = null;
                            service.CorrelationTokenValue = null;
                            service.CrmAuthenticationTokenValue = new KNLTB.ServIt.CrmService.CrmAuthenticationToken { AuthenticationType = 0, OrganizationName = "KNLTB", CrmTicket = string.Empty, CallerId = new Guid("00000000-0000-0000-0000-000000000000") };
                            service.CrmCookieContainer = cc;
                            */

                            bool moreRecords = true;
                            int pageNum = 1;
                            while (moreRecords)
                            {
                                List<BusinessEntity> entities = RetrieveMultiple(service, "sgt_alg_rechtsvorm", out moreRecords, ref pageNum);

                                foreach (sgt_alg_rechtsvorm entity in entities)
                                {
                                    ClubCloud_Rechtsvorm rechtsvorm = model.ClubCloud_Rechtsvormen.Find(entity.sgt_alg_rechtsvormid.Value);

                                    if (rechtsvorm == null)
                                    {
                                        rechtsvorm = model.ClubCloud_Rechtsvormen.Create();
                                        rechtsvorm.Id = entity.sgt_alg_rechtsvormid.Value;
                                        rechtsvorm.Naam = entity.sgt_alg_rechtsvorm1;
                                        rechtsvorm.Omschrijving = entity.sgt_omschrijving;
                                        rechtsvorm.Beschrijving = entity.sgt_beschrijving;
                                        rechtsvorm.Meervoud = entity.sgt_meervoudsnaam;
                                        rechtsvorm.Code = entity.sgt_verkorte_code;
                                        rechtsvorm.Actief = entity.statuscode.name;
                                        model.ClubCloud_Rechtsvormen.Add(rechtsvorm);
                                        rechtsvormen.Add(rechtsvorm);
                                    }
                                    else
                                    {
                                        rechtsvorm.Naam = entity.sgt_alg_rechtsvorm1;
                                        rechtsvorm.Omschrijving = entity.sgt_omschrijving;
                                        rechtsvorm.Beschrijving = entity.sgt_beschrijving;
                                        rechtsvorm.Meervoud = entity.sgt_meervoudsnaam;
                                        rechtsvorm.Code = entity.sgt_verkorte_code;
                                        rechtsvorm.Actief = entity.statuscode.name;
                                    }
                                }
                            }
                        }
                    }
                }
                model.SaveChanges();
            }
            return rechtsvormen;
            //sgt_alg_functie
        }

        public ClubCloud_Rechtsvorm RechtsvormById(string bondsnummer, Guid rechtsvormId, bool refresh = false)
        {
            CheckDatabase();

            ClubCloud_Rechtsvorm rechtsvorm = new ClubCloud_Rechtsvorm();

            using (ClubCloud.Service.Model.ClubCloudModelContainer model = new Model.ClubCloudModelContainer(GetConnectionString()))
            {
                rechtsvorm = model.ClubCloud_Rechtsvormen.Find(rechtsvormId);

                if (rechtsvorm != null || refresh)
                {
                    ClubCloud_Setting settings = model.ClubCloud_Settings.Find(int.Parse(bondsnummer));
                    if (settings != null && settings.mijnknltb_allow && !string.IsNullOrWhiteSpace(settings.mijnknltb_password))
                    {
                        CookieContainer cc = RequestContainer(settings.Id.ToString(), settings.mijnknltb_password);

                        if (cc != null)
                        {
                            ClubCloud.KNLTB.ServIt.CrmService.CrmService service = new KNLTB.ServIt.CrmService.CrmService(cc);

                            bool moreRecords = true;
                            int pageNum = 1;
                            while (moreRecords)
                            {
                                ConditionExpression condition = new ConditionExpression { AttributeName = "sgt_alg_rechtsvormid", Operator = ConditionOperator.Equal, Values = new object[1] { rechtsvormId } };
                                FilterExpression expression = new FilterExpression { FilterOperator = LogicalOperator.And, Conditions = new ConditionExpression[1] { condition } };

                                List<BusinessEntity> entities = RetrieveMultiple(service, "sgt_alg_rechtsvorm", out moreRecords, ref pageNum, expression);

                                foreach (sgt_alg_rechtsvorm entity in entities)
                                {
                                    rechtsvorm = model.ClubCloud_Rechtsvormen.Find(entity.sgt_alg_rechtsvormid.Value);

                                    if (rechtsvorm == null)
                                    {
                                        rechtsvorm = model.ClubCloud_Rechtsvormen.Create();
                                        rechtsvorm.Id = entity.sgt_alg_rechtsvormid.Value;
                                        rechtsvorm.Naam = entity.sgt_alg_rechtsvorm1;
                                        rechtsvorm.Omschrijving = entity.sgt_omschrijving;
                                        rechtsvorm.Beschrijving = entity.sgt_beschrijving;
                                        rechtsvorm.Meervoud = entity.sgt_meervoudsnaam;
                                        rechtsvorm.Code = entity.sgt_verkorte_code;
                                        rechtsvorm.Actief = entity.statuscode.name;
                                        model.ClubCloud_Rechtsvormen.Add(rechtsvorm);
                                    }
                                    else
                                    {
                                        rechtsvorm.Naam = entity.sgt_alg_rechtsvorm1;
                                        rechtsvorm.Omschrijving = entity.sgt_omschrijving;
                                        rechtsvorm.Beschrijving = entity.sgt_beschrijving;
                                        rechtsvorm.Meervoud = entity.sgt_meervoudsnaam;
                                        rechtsvorm.Code = entity.sgt_verkorte_code;
                                        rechtsvorm.Actief = entity.statuscode.name;
                                    }
                                }
                            }
                        }
                    }
                }
                model.SaveChanges();
            }
            return rechtsvorm;
            //sgt_alg_functie
        }

        #endregion

        #region Vereniging

        /// <summary>
        /// account
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="verenigingNummer"></param>
        /// <param name="refresh"></param>
        /// <returns></returns>
        public ClubCloud_Vereniging VerenigingByNummer(string bondsnummer, string verenigingNummer, bool refresh = false)
        {
            CheckDatabase();

            ClubCloud_Vereniging vereniging = new ClubCloud_Vereniging();


            using (ClubCloud.Service.Model.ClubCloudModelContainer model = new Model.ClubCloudModelContainer(GetConnectionString()))
            {
                vereniging = model.ClubCloud_Verenigingen.SingleOrDefault(l => l.Nummer == verenigingNummer);

                if (vereniging == null || refresh)
                {
                    ClubCloud_Setting settings = model.ClubCloud_Settings.Find(int.Parse(bondsnummer));

                    if (settings != null && settings.mijnknltb_allow && !string.IsNullOrWhiteSpace(settings.mijnknltb_password))
                    {
                        CookieContainer cc = RequestContainer(settings.Id.ToString(), settings.mijnknltb_password);

                        if (cc != null)
                        {
                            ClubCloud.KNLTB.ServIt.CrmService.CrmService service = new KNLTB.ServIt.CrmService.CrmService(cc);

                            bool moreRecords = true;
                            int pageNum = 1;
                            while (moreRecords)
                            {
                                ConditionExpression condition = new ConditionExpression { AttributeName = "accountnumber", Operator = ConditionOperator.Equal, Values = new object[1] { verenigingNummer } };
                                FilterExpression expression = new FilterExpression { FilterOperator = LogicalOperator.And, Conditions = new ConditionExpression[1] { condition } };

                                List<BusinessEntity> entities = RetrieveMultiple(service, "account", out moreRecords, ref pageNum, expression);

                                foreach (account entity in entities)
                                {
                                    vereniging = model.ClubCloud_Verenigingen.Find(entity.accountid.Value);

                                    if (vereniging == null)
                                    {
                                        vereniging = model.ClubCloud_Verenigingen.Create();
                                        vereniging.Id = entity.accountid.Value;
                                        vereniging.Nummer = entity.accountnumber;
                                        vereniging.Naam = entity.name;

                                        DistrictById(bondsnummer, entity.sgt_districtid.Value, true);
                                        vereniging.DistrictId = entity.sgt_districtid.Value;
                                        
                                        vereniging.KvKnummer = entity.sgt_kvk_nummer;
                                        vereniging.KvKplaats = entity.sgt_kvkplaatsid.name;

                                        vereniging.BankNummer = entity.sgt_rekeningnummer;
                                        vereniging.BankIban = entity.sgt_iban_code;
                                        vereniging.BankPlaats = entity.sgt_rekeningnummer_plaats;

                                        RechtsvormById(bondsnummer, entity.sgt_rechtsvormid.Value, true);
                                        vereniging.RechtsvormId = entity.sgt_rechtsvormid.Value;

                                        AccommodatieById(bondsnummer, entity.sgt_hoofdaccomodatieid.Value,true);
                                        vereniging.AccomodatieId = entity.sgt_hoofdaccomodatieid.Value;

                                        AdresById(bondsnummer, entity.address1_addressid.Value, true);
                                        AdresById(bondsnummer, entity.address2_addressid.Value, true);

                                        RegioById(bondsnummer, entity.parentaccountid.Value, entity.parentaccountid.name, true);
                                        vereniging.RegioId = entity.parentaccountid.Value;

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
                                        vereniging.Oprichting = DateTime.Parse(entity.sgt_datum_oprichting.Value);
                                        vereniging.Erkenning = DateTime.Parse(entity.sgt_datumer_kenning.Value);
                                        vereniging.Gestopt = DateTime.Parse(entity.sgt_datum_afmelding.Value);
                                        vereniging.Maanden = entity.sgt_aantal_maanden_geopend.Value;                                            
                                        vereniging.Actief = entity.statuscode.name;

                                        model.ClubCloud_Verenigingen.Add(vereniging);

                                    }
                                    else
                                    {
                                        vereniging.Nummer = entity.accountnumber;
                                        vereniging.Naam = entity.name;

                                        DistrictById(bondsnummer, entity.sgt_districtid.Value, true);
                                        vereniging.DistrictId = entity.sgt_districtid.Value;

                                        vereniging.KvKnummer = entity.sgt_kvk_nummer;
                                        vereniging.KvKplaats = entity.sgt_kvkplaatsid.name;

                                        vereniging.BankNummer = entity.sgt_rekeningnummer;
                                        vereniging.BankIban = entity.sgt_iban_code;
                                        vereniging.BankPlaats = entity.sgt_rekeningnummer_plaats;

                                        RechtsvormById(bondsnummer, entity.sgt_rechtsvormid.Value, true);
                                        vereniging.RechtsvormId = entity.sgt_rechtsvormid.Value;

                                        AccommodatieById(bondsnummer, entity.sgt_hoofdaccomodatieid.Value, true);
                                        vereniging.AccomodatieId = entity.sgt_hoofdaccomodatieid.Value;

                                        AdresById(bondsnummer, entity.address1_addressid.Value, true);
                                        AdresById(bondsnummer, entity.address2_addressid.Value, true);

                                        RegioById(bondsnummer, entity.parentaccountid.Value, entity.parentaccountid.name, true);
                                        vereniging.RegioId = entity.parentaccountid.Value;

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
                                        vereniging.Oprichting = DateTime.Parse(entity.sgt_datum_oprichting.Value);
                                        vereniging.Erkenning = DateTime.Parse(entity.sgt_datumer_kenning.Value);
                                        vereniging.Gestopt = DateTime.Parse(entity.sgt_datum_afmelding.Value);
                                        vereniging.Maanden = entity.sgt_aantal_maanden_geopend.Value;
                                        vereniging.Actief = entity.statuscode.name;

                                    }
                                }
                            }
                        }
                    }
                }
                model.SaveChanges();
            }

            return vereniging;
            //sgt_lidid = {238DF8BA-5715-4A91-947F-1C95405C8AF4}
        }

        /// <summary>
        /// account
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="verenigingId"></param>
        /// <param name="refresh"></param>
        /// <returns></returns>
        public ClubCloud_Vereniging VerenigingById(string bondsnummer, Guid verenigingId, bool refresh = false)
        {
            CheckDatabase();

            ClubCloud_Vereniging vereniging = new ClubCloud_Vereniging();


            using (ClubCloud.Service.Model.ClubCloudModelContainer model = new Model.ClubCloudModelContainer(GetConnectionString()))
            {
                vereniging = model.ClubCloud_Verenigingen.Find(verenigingId);

                if (vereniging == null || refresh)
                {
                    ClubCloud_Setting settings = model.ClubCloud_Settings.Find(int.Parse(bondsnummer));

                    if (settings != null && settings.mijnknltb_allow && !string.IsNullOrWhiteSpace(settings.mijnknltb_password))
                    {
                        CookieContainer cc = RequestContainer(settings.Id.ToString(), settings.mijnknltb_password);

                        if (cc != null)
                        {
                            ClubCloud.KNLTB.ServIt.CrmService.CrmService service = new KNLTB.ServIt.CrmService.CrmService(cc);

                            bool moreRecords = true;
                            int pageNum = 1;
                            while (moreRecords)
                            {
                                ConditionExpression condition = new ConditionExpression { AttributeName = "accountid ", Operator = ConditionOperator.Equal, Values = new object[1] { verenigingId } };
                                FilterExpression expression = new FilterExpression { FilterOperator = LogicalOperator.And, Conditions = new ConditionExpression[1] { condition } };

                                List<BusinessEntity> entities = RetrieveMultiple(service, "account", out moreRecords, ref pageNum, expression);

                                foreach (account entity in entities)
                                {
                                    vereniging = model.ClubCloud_Verenigingen.Find(entity.accountid.Value);

                                    vereniging = model.ClubCloud_Verenigingen.Find(entity.accountid.Value);

                                    if (vereniging == null)
                                    {
                                        vereniging = model.ClubCloud_Verenigingen.Create();
                                        vereniging.Id = entity.accountid.Value;
                                        vereniging.Nummer = entity.accountnumber;
                                        vereniging.Naam = entity.name;

                                        DistrictById(bondsnummer, entity.sgt_districtid.Value, true);
                                        vereniging.DistrictId = entity.sgt_districtid.Value;

                                        vereniging.KvKnummer = entity.sgt_kvk_nummer;
                                        vereniging.KvKplaats = entity.sgt_kvkplaatsid.name;

                                        vereniging.BankNummer = entity.sgt_rekeningnummer;
                                        vereniging.BankIban = entity.sgt_iban_code;
                                        vereniging.BankPlaats = entity.sgt_rekeningnummer_plaats;

                                        RechtsvormById(bondsnummer, entity.sgt_rechtsvormid.Value, true);
                                        vereniging.RechtsvormId = entity.sgt_rechtsvormid.Value;

                                        AccommodatieById(bondsnummer, entity.sgt_hoofdaccomodatieid.Value, true);
                                        vereniging.AccomodatieId = entity.sgt_hoofdaccomodatieid.Value;

                                        AdresById(bondsnummer, entity.address1_addressid.Value, true);
                                        AdresById(bondsnummer, entity.address2_addressid.Value, true);

                                        RegioById(bondsnummer, entity.parentaccountid.Value, entity.parentaccountid.name, true);
                                        vereniging.RegioId = entity.parentaccountid.Value;

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
                                        vereniging.Oprichting = DateTime.Parse(entity.sgt_datum_oprichting.Value);
                                        vereniging.Erkenning = DateTime.Parse(entity.sgt_datumer_kenning.Value);
                                        vereniging.Gestopt = DateTime.Parse(entity.sgt_datum_afmelding.Value);
                                        vereniging.Maanden = entity.sgt_aantal_maanden_geopend.Value;
                                        vereniging.Actief = entity.statuscode.name;

                                        model.ClubCloud_Verenigingen.Add(vereniging);

                                    }
                                    else
                                    {
                                        vereniging.Nummer = entity.accountnumber;
                                        vereniging.Naam = entity.name;

                                        DistrictById(bondsnummer, entity.sgt_districtid.Value, true);
                                        vereniging.DistrictId = entity.sgt_districtid.Value;

                                        vereniging.KvKnummer = entity.sgt_kvk_nummer;
                                        vereniging.KvKplaats = entity.sgt_kvkplaatsid.name;

                                        vereniging.BankNummer = entity.sgt_rekeningnummer;
                                        vereniging.BankIban = entity.sgt_iban_code;
                                        vereniging.BankPlaats = entity.sgt_rekeningnummer_plaats;

                                        RechtsvormById(bondsnummer, entity.sgt_rechtsvormid.Value, true);
                                        vereniging.RechtsvormId = entity.sgt_rechtsvormid.Value;

                                        AccommodatieById(bondsnummer, entity.sgt_hoofdaccomodatieid.Value, true);
                                        vereniging.AccomodatieId = entity.sgt_hoofdaccomodatieid.Value;

                                        AdresById(bondsnummer, entity.address1_addressid.Value, true);
                                        AdresById(bondsnummer, entity.address2_addressid.Value, true);

                                        RegioById(bondsnummer, entity.parentaccountid.Value, entity.parentaccountid.name, true);
                                        vereniging.RegioId = entity.parentaccountid.Value;

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
                                        vereniging.Oprichting = DateTime.Parse(entity.sgt_datum_oprichting.Value);
                                        vereniging.Erkenning = DateTime.Parse(entity.sgt_datumer_kenning.Value);
                                        vereniging.Gestopt = DateTime.Parse(entity.sgt_datum_afmelding.Value);
                                        vereniging.Maanden = entity.sgt_aantal_maanden_geopend.Value;
                                        vereniging.Actief = entity.statuscode.name;

                                    }
                                }
                            }
                        }
                    }
                }
                model.SaveChanges();
            }

            return vereniging;

        }

        #endregion

        #region Adres

        public ClubCloud_Address AdresById(string bondsnummer, Guid addressId, bool refresh = false)
        {
            CheckDatabase();

            ClubCloud_Address address = new ClubCloud_Address();


            using (ClubCloud.Service.Model.ClubCloudModelContainer model = new Model.ClubCloudModelContainer(GetConnectionString()))
            {
                address = model.ClubCloud_Addresses.Find(addressId);

                if (address == null || refresh)
                {
                    ClubCloud_Setting settings = model.ClubCloud_Settings.Find(int.Parse(bondsnummer));

                    if (settings != null && settings.mijnknltb_allow && !string.IsNullOrWhiteSpace(settings.mijnknltb_password))
                    {
                        CookieContainer cc = RequestContainer(settings.Id.ToString(), settings.mijnknltb_password);

                        if (cc != null)
                        {
                            ClubCloud.KNLTB.ServIt.CrmService.CrmService service = new KNLTB.ServIt.CrmService.CrmService(cc);

                            bool moreRecords = true;
                            int pageNum = 1;
                            while (moreRecords)
                            {
                                ConditionExpression condition = new ConditionExpression { AttributeName = "customeraddressid", Operator = ConditionOperator.Equal, Values = new object[1] { addressId } };
                                FilterExpression expression = new FilterExpression { FilterOperator = LogicalOperator.And, Conditions = new ConditionExpression[1] { condition } };

                                List<BusinessEntity> entities = RetrieveMultiple(service, "customeraddress", out moreRecords, ref pageNum, expression);

                                foreach (customeraddress entity in entities)
                                {
                                    address = model.ClubCloud_Addresses.Find(entity.customeraddressid.Value);

                                    if (address == null)
                                    {
                                        address = model.ClubCloud_Addresses.Create();
                                        address.Id = entity.customeraddressid.Value;
                                        address.Stad = entity.city;
                                        address.Latitude = entity.latitude.Value;
                                        address.Longitude = entity.longitude.Value;
                                        address.Land = entity.country;
                                        address.Fax = entity.fax;
                                        address.Straat =entity.line1;
                                        address.Nummer = entity.line2;
                                        address.Toevoeging = entity.line3;
                                        address.Naam = entity.name;
                                        address.ParentId = entity.parentid.Value;
                                        address.Postcode = entity.postalcode;
                                        address.Postbus = entity.postofficebox;
                                        address.Provincie = entity.stateorprovince;
                                        address.TelefoonPrimair = entity.telephone1;
                                        address.TelefoonSecundair = entity.telephone2;
                                        address.TelefoonTertiair = entity.telephone3;
                                        model.ClubCloud_Addresses.Add(address);
                                    }
                                    else
                                    {
                                        address.Stad = entity.city;
                                        address.Latitude = entity.latitude.Value;
                                        address.Longitude = entity.longitude.Value;
                                        address.Land = entity.country;
                                        address.Fax = entity.fax;
                                        address.Straat = entity.line1;
                                        address.Nummer = entity.line2;
                                        address.Toevoeging = entity.line3;
                                        address.Naam = entity.name;
                                        address.ParentId = entity.parentid.Value;
                                        address.Postcode = entity.postalcode;
                                        address.Postbus = entity.postofficebox;
                                        address.Provincie = entity.stateorprovince;
                                        address.TelefoonPrimair = entity.telephone1;
                                        address.TelefoonSecundair = entity.telephone2;
                                        address.TelefoonTertiair = entity.telephone3;
                                    }
                                }
                            }
                        }
                    }
                }
                model.SaveChanges();
            }

            return address;
        }

        public List<ClubCloud_Address> AdresByParent(string bondsnummer, Guid parentId, bool refresh = false)
        {
            CheckDatabase();

            List<ClubCloud_Address> addresses = new List<ClubCloud_Address>();


            using (ClubCloud.Service.Model.ClubCloudModelContainer model = new Model.ClubCloudModelContainer(GetConnectionString()))
            {
                addresses = model.ClubCloud_Addresses.Where(a => a.ParentId == parentId).ToList();

                if (addresses == null || refresh)
                {
                    ClubCloud_Setting settings = model.ClubCloud_Settings.Find(int.Parse(bondsnummer));

                    if (settings != null && settings.mijnknltb_allow && !string.IsNullOrWhiteSpace(settings.mijnknltb_password))
                    {
                        CookieContainer cc = RequestContainer(settings.Id.ToString(), settings.mijnknltb_password);

                        if (cc != null)
                        {
                            ClubCloud.KNLTB.ServIt.CrmService.CrmService service = new KNLTB.ServIt.CrmService.CrmService(cc);

                            bool moreRecords = true;
                            int pageNum = 1;
                            while (moreRecords)
                            {
                                ConditionExpression condition = new ConditionExpression { AttributeName = "parentid", Operator = ConditionOperator.Equal, Values = new object[1] { parentId } };
                                FilterExpression expression = new FilterExpression { FilterOperator = LogicalOperator.And, Conditions = new ConditionExpression[1] { condition } };

                                List<BusinessEntity> entities = RetrieveMultiple(service, "customeraddress", out moreRecords, ref pageNum, expression);

                                foreach (customeraddress entity in entities)
                                {
                                    ClubCloud_Address address = model.ClubCloud_Addresses.Find(entity.customeraddressid.Value);

                                    if (addresses == null)
                                    {
                                        address = model.ClubCloud_Addresses.Create();
                                        address.Id = entity.customeraddressid.Value;
                                        address.Stad = entity.city;
                                        address.Latitude = entity.latitude.Value;
                                        address.Longitude = entity.longitude.Value;
                                        address.Land = entity.country;
                                        address.Fax = entity.fax;
                                        address.Straat = entity.line1;
                                        address.Nummer = entity.line2;
                                        address.Toevoeging = entity.line3;
                                        address.Naam = entity.name;
                                        address.ParentId = entity.parentid.Value;
                                        address.Postcode = entity.postalcode;
                                        address.Postbus = entity.postofficebox;
                                        address.Provincie = entity.stateorprovince;
                                        address.TelefoonPrimair = entity.telephone1;
                                        address.TelefoonSecundair = entity.telephone2;
                                        address.TelefoonTertiair = entity.telephone3;
                                        model.ClubCloud_Addresses.Add(address);
                                        addresses.Add(address);

                                    }
                                    else
                                    {
                                        address.Stad = entity.city;
                                        address.Latitude = entity.latitude.Value;
                                        address.Longitude = entity.longitude.Value;
                                        address.Land = entity.country;
                                        address.Fax = entity.fax;
                                        address.Straat = entity.line1;
                                        address.Nummer = entity.line2;
                                        address.Toevoeging = entity.line3;
                                        address.Naam = entity.name;
                                        address.ParentId = entity.parentid.Value;
                                        address.Postcode = entity.postalcode;
                                        address.Postbus = entity.postofficebox;
                                        address.Provincie = entity.stateorprovince;
                                        address.TelefoonPrimair = entity.telephone1;
                                        address.TelefoonSecundair = entity.telephone2;
                                        address.TelefoonTertiair = entity.telephone3;
                                    }
                                }
                            }
                        }
                    }
                }
                model.SaveChanges();
            }

            return addresses;
        }

        #endregion

        #region Functie

        /// <summary>
        /// sgt_alg_functie
        /// </summary>
        public List<ClubCloud_Functie> Functies(string bondsnummer, bool refresh = false)
        {
            CheckDatabase();

            List<ClubCloud_Functie> functies = new List<ClubCloud_Functie>();

            using (ClubCloud.Service.Model.ClubCloudModelContainer model = new Model.ClubCloudModelContainer(GetConnectionString()))
            {
                functies = model.ClubCloud_Functies.ToList();
                if (functies != null && functies.Count == 0)
                {
                    ClubCloud_Setting settings = model.ClubCloud_Settings.Find(int.Parse(bondsnummer));
                    if (settings != null && settings.mijnknltb_allow && !string.IsNullOrWhiteSpace(settings.mijnknltb_password))
                    {
                        CookieContainer cc = RequestContainer(settings.Id.ToString(), settings.mijnknltb_password);

                        if (cc != null)
                        {
                            ClubCloud.KNLTB.ServIt.CrmService.CrmService service = new KNLTB.ServIt.CrmService.CrmService(cc);

                            bool moreRecords = true;
                            int pageNum = 1;
                            while (moreRecords)
                            {
                                List<BusinessEntity> entities = RetrieveMultiple(service, "sgt_alg_functie", out moreRecords, ref pageNum);

                                foreach (sgt_alg_functie entity in entities)
                                {
                                    ClubCloud_Functie functie = model.ClubCloud_Functies.Find(entity.sgt_alg_functieid.Value);

                                    if (functie == null)
                                    {
                                        functie = model.ClubCloud_Functies.Create();
                                        functie.Id = entity.sgt_alg_functieid.Value;
                                        functie.Beschrijving = entity.sgt_beschrijving;
                                        functie.Code = entity.sgt_verkorte_code;
                                        functie.Meervoud = entity.sgt_meervoudsnaam;
                                        functie.Naam = entity.sgt_alg_functie1;
                                        functie.Omschrijving = entity.sgt_omschrijving;
                                        functie.Toegang = entity.sgt_toegang_crm_toegestaan.Value;
                                        functie.Actief = entity.statuscode.name;
                                        model.ClubCloud_Functies.Add(functie);
                                        functies.Add(functie);
                                    }
                                    else
                                    {
                                        functie.Beschrijving = entity.sgt_beschrijving;
                                        functie.Code = entity.sgt_verkorte_code;
                                        functie.Meervoud = entity.sgt_meervoudsnaam;
                                        functie.Naam = entity.sgt_alg_functie1;
                                        functie.Omschrijving = entity.sgt_omschrijving;
                                        functie.Toegang = entity.sgt_toegang_crm_toegestaan.Value;
                                        functie.Actief = entity.statuscode.name;
                                    }
                                }
                            }
                        }
                    }
                }
                model.SaveChanges();
            }
            return functies;
            //sgt_alg_functie
        }

        public ClubCloud_Functie FunctieById(string bondsnummer, Guid functieId, bool refresh = false)
        {
            CheckDatabase();

            ClubCloud_Functie functie = new ClubCloud_Functie();

            using (ClubCloud.Service.Model.ClubCloudModelContainer model = new Model.ClubCloudModelContainer(GetConnectionString()))
            {
                functie = model.ClubCloud_Functies.Find(functieId);

                if (functie == null )
                {
                    ClubCloud_Setting settings = model.ClubCloud_Settings.Find(int.Parse(bondsnummer));
                    if (settings != null && settings.mijnknltb_allow && !string.IsNullOrWhiteSpace(settings.mijnknltb_password))
                    {
                        CookieContainer cc = RequestContainer(settings.Id.ToString(), settings.mijnknltb_password);

                        if (cc != null)
                        {
                            ClubCloud.KNLTB.ServIt.CrmService.CrmService service = new KNLTB.ServIt.CrmService.CrmService(cc);

                            bool moreRecords = true;
                            int pageNum = 1;
                            while (moreRecords)
                            {
                                ConditionExpression condition = new ConditionExpression { AttributeName = "sgt_alg_functieid", Operator = ConditionOperator.Equal, Values = new object[1] { functieId } };
                                FilterExpression expression = new FilterExpression { FilterOperator = LogicalOperator.And, Conditions = new ConditionExpression[1] { condition } };

                                List<BusinessEntity> entities = RetrieveMultiple(service, "sgt_alg_functie", out moreRecords, ref pageNum);

                                foreach (sgt_alg_functie entity in entities)
                                {
                                    functie = model.ClubCloud_Functies.Find(entity.sgt_alg_functieid.Value);

                                    if (functie == null)
                                    {
                                        functie = model.ClubCloud_Functies.Create();
                                        functie.Id = entity.sgt_alg_functieid.Value;
                                        functie.Beschrijving = entity.sgt_beschrijving;
                                        functie.Code = entity.sgt_verkorte_code;
                                        functie.Meervoud = entity.sgt_meervoudsnaam;
                                        functie.Naam = entity.sgt_alg_functie1;
                                        functie.Omschrijving = entity.sgt_omschrijving;
                                        functie.Toegang = entity.sgt_toegang_crm_toegestaan.Value;
                                        functie.Actief = entity.statuscode.name;
                                        model.ClubCloud_Functies.Add(functie);
                                    }
                                    else
                                    {
                                        functie.Beschrijving = entity.sgt_beschrijving;
                                        functie.Code = entity.sgt_verkorte_code;
                                        functie.Meervoud = entity.sgt_meervoudsnaam;
                                        functie.Naam = entity.sgt_alg_functie1;
                                        functie.Omschrijving = entity.sgt_omschrijving;
                                        functie.Toegang = entity.sgt_toegang_crm_toegestaan.Value;
                                        functie.Actief = entity.statuscode.name;
                                    }
                                }
                            }
                        }
                    }
                }
                model.SaveChanges();
            }
            return functie;
            //sgt_alg_functie
        }

        /// <summary>
        /// sgt_alg_functionaris
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="VerenigingId"></param>
        /// <param name="refresh"></param>
        /// <returns></returns>
        public List<ClubCloud_Functionaris> FunctionarissenByVereniging(string bondsnummer, Guid VerenigingId, bool refresh = false)
        {
            CheckDatabase();

            List<ClubCloud_Functionaris> functionarissen = new List<ClubCloud_Functionaris>();

            using (ClubCloud.Service.Model.ClubCloudModelContainer model = new Model.ClubCloudModelContainer(GetConnectionString()))
            {
                functionarissen = model.ClubCloud_Functionarissen.Where(f => f.VerenigingId == VerenigingId && f.Actief == Sgt_alg_functionarisState.Active.ToString()).ToList();

                if (functionarissen != null && functionarissen.Count == 0 || refresh)
                {
                    ClubCloud_Setting settings = model.ClubCloud_Settings.Find(int.Parse(bondsnummer));

                    if (settings != null && settings.mijnknltb_allow && !string.IsNullOrWhiteSpace(settings.mijnknltb_password))
                    {
                        CookieContainer cc = RequestContainer(settings.Id.ToString(), settings.mijnknltb_password);

                        if (cc != null)
                        {
                            ClubCloud.KNLTB.ServIt.CrmService.CrmService service = new KNLTB.ServIt.CrmService.CrmService(cc);

                            bool moreRecords = true;
                            int pageNum = 1;
                            while (moreRecords)
                            {
                                List<BusinessEntity> entities = RetrieveMultiple(service, "sgt_alg_functionaris", out moreRecords, ref pageNum);

                                foreach (sgt_alg_functionaris entity in entities)
                                {
                                    ClubCloud_Functionaris functionaris = model.ClubCloud_Functionarissen.Find(entity.sgt_alg_functionarisid.Value);

                                    if (functionaris == null)
                                    {
                                        functionaris = model.ClubCloud_Functionarissen.Create();
                                        functionaris.Id = entity.sgt_alg_functionarisid.Value;

                                        FunctieById(bondsnummer, entity.sgt_functieid.Value, true);
                                        functionaris.FunctieId = entity.sgt_functieid.Value;

                                        GebruikerById(bondsnummer, entity.sgt_functionarisid.Value, true);
                                        functionaris.GebruikerId = entity.sgt_functionarisid.Value;

                                        VerenigingById(bondsnummer, entity.sgt_basisorganisatieid.Value, true);
                                        functionaris.VerenigingId = entity.sgt_basisorganisatieid.Value;

                                        BestuursOrgaanById(bondsnummer, entity.sgt_bestuursorgaanid.Value, true);
                                        functionaris.BestuursorgaanId = entity.sgt_bestuursorgaanid.Value;
                                        
                                        functionaris.TermijnBegin = DateTime.Parse(entity.sgt_termijn_begint.Value);
                                        functionaris.TermijnEinde = DateTime.Parse(entity.sgt_termijn_loopt_af.Value); ;
                                        functionaris.Autorisatie = entity.sgt_autorisatie_gezet.Value;
                                        functionaris.Actief = entity.statuscode.name;
                                        model.ClubCloud_Functionarissen.Add(functionaris);
                                        functionarissen.Add(functionaris);

                                    }
                                    else
                                    {
                                        FunctieById(bondsnummer, entity.sgt_functieid.Value, true);
                                        functionaris.FunctieId = entity.sgt_functieid.Value;

                                        GebruikerById(bondsnummer, entity.sgt_functionarisid.Value, true);
                                        functionaris.GebruikerId = entity.sgt_functionarisid.Value;

                                        VerenigingById(bondsnummer, entity.sgt_basisorganisatieid.Value, true);
                                        functionaris.VerenigingId = entity.sgt_basisorganisatieid.Value;

                                        BestuursOrgaanById(bondsnummer, entity.sgt_bestuursorgaanid.Value, true);
                                        functionaris.BestuursorgaanId = entity.sgt_bestuursorgaanid.Value;

                                        functionaris.TermijnBegin = DateTime.Parse(entity.sgt_termijn_begint.Value);
                                        functionaris.TermijnEinde = DateTime.Parse(entity.sgt_termijn_loopt_af.Value); ;
                                        functionaris.Autorisatie = entity.sgt_autorisatie_gezet.Value;
                                        functionaris.Actief = entity.statuscode.name;
                                    }
                                }
                            }
                        }
                    }
                    model.SaveChanges();
                    functionarissen = model.ClubCloud_Functionarissen.Where(f => f.VerenigingId == VerenigingId).ToList();
                }
                model.SaveChanges();
            }
            return functionarissen;

        }

        /// <summary>
        /// sgt_alg_functionaris
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="VerenigingId"></param>
        /// <param name="FunctieId"></param>
        /// <param name="refresh"></param>
        /// <returns></returns>
        public List<ClubCloud_Functionaris> FunctionarissenByFunctie(string bondsnummer, Guid VerenigingId, Guid FunctieId, bool refresh = false)
        {
            CheckDatabase();

            List<ClubCloud_Functionaris> functionarissen = new List<ClubCloud_Functionaris>();

            using (ClubCloud.Service.Model.ClubCloudModelContainer model = new Model.ClubCloudModelContainer(GetConnectionString()))
            {
                functionarissen = model.ClubCloud_Functionarissen.Where(f => f.VerenigingId == VerenigingId && f.FunctieId == FunctieId && f.Actief == Sgt_alg_functionarisState.Active.ToString()).ToList();

                if (functionarissen != null && functionarissen.Count == 0 || refresh)
                {
                    ClubCloud_Setting settings = model.ClubCloud_Settings.Find(int.Parse(bondsnummer));

                    if (settings != null && settings.mijnknltb_allow && !string.IsNullOrWhiteSpace(settings.mijnknltb_password))
                    {
                        CookieContainer cc = RequestContainer(settings.Id.ToString(), settings.mijnknltb_password);

                        if (cc != null)
                        {
                            ClubCloud.KNLTB.ServIt.CrmService.CrmService service = new KNLTB.ServIt.CrmService.CrmService(cc);

                            ConditionExpression condition = new ConditionExpression { AttributeName = "sgt_functieid", Operator = ConditionOperator.Equal, Values = new object[1] { FunctieId } };
                            FilterExpression expression = new FilterExpression { FilterOperator = LogicalOperator.And, Conditions = new ConditionExpression[1] { condition } };

                            bool moreRecords = true;
                            int pageNum = 1;
                            while (moreRecords)
                            {
                                List<BusinessEntity> entities = RetrieveMultiple(service, "sgt_alg_functionaris", out moreRecords, ref pageNum, expression);
                                
                                foreach (sgt_alg_functionaris entity in entities)
                                {
                                    ClubCloud_Functionaris functionaris = model.ClubCloud_Functionarissen.SingleOrDefault(f => f.Id == entity.sgt_alg_functionarisid.Value);

                                    if (functionaris == null)
                                    {
                                        functionaris = model.ClubCloud_Functionarissen.Create();
                                        functionaris.Id = entity.sgt_alg_functionarisid.Value;
                                        FunctieById(bondsnummer, entity.sgt_functieid.Value, true);
                                        functionaris.FunctieId = entity.sgt_functieid.Value;

                                        GebruikerById(bondsnummer, entity.sgt_functionarisid.Value, true);
                                        functionaris.GebruikerId = entity.sgt_functionarisid.Value;

                                        VerenigingById(bondsnummer, entity.sgt_basisorganisatieid.Value, true);
                                        functionaris.VerenigingId = entity.sgt_basisorganisatieid.Value;

                                        BestuursOrgaanById(bondsnummer, entity.sgt_bestuursorgaanid.Value, true);
                                        functionaris.BestuursorgaanId = entity.sgt_bestuursorgaanid.Value;

                                        functionaris.TermijnBegin = DateTime.Parse(entity.sgt_termijn_begint.Value);
                                        functionaris.TermijnEinde = DateTime.Parse(entity.sgt_termijn_loopt_af.Value); ;
                                        functionaris.Autorisatie = entity.sgt_autorisatie_gezet.Value;
                                        functionaris.Actief = entity.statuscode.name;

                                        model.ClubCloud_Functionarissen.Add(functionaris);
                                        functionarissen.Add(functionaris);

                                    }
                                    else
                                    {
                                        FunctieById(bondsnummer, entity.sgt_functieid.Value, true);
                                        functionaris.FunctieId = entity.sgt_functieid.Value;

                                        GebruikerById(bondsnummer, entity.sgt_functionarisid.Value, true);
                                        functionaris.GebruikerId = entity.sgt_functionarisid.Value;

                                        VerenigingById(bondsnummer, entity.sgt_basisorganisatieid.Value, true);
                                        functionaris.VerenigingId = entity.sgt_basisorganisatieid.Value;

                                        BestuursOrgaanById(bondsnummer, entity.sgt_bestuursorgaanid.Value, true);
                                        functionaris.BestuursorgaanId = entity.sgt_bestuursorgaanid.Value;

                                        functionaris.TermijnBegin = DateTime.Parse(entity.sgt_termijn_begint.Value);
                                        functionaris.TermijnEinde = DateTime.Parse(entity.sgt_termijn_loopt_af.Value); ;
                                        functionaris.Autorisatie = entity.sgt_autorisatie_gezet.Value;
                                        functionaris.Actief = entity.statuscode.name;
                                    }
                                }
                            }
                        }
                    }
                    model.SaveChanges();
                    functionarissen = model.ClubCloud_Functionarissen.Where(f => f.VerenigingId == VerenigingId && f.FunctieId == FunctieId && f.Actief == Sgt_alg_functionarisState.Active.ToString()).ToList();
                }
                model.SaveChanges();
            }
            return functionarissen;

        }

        /// <summary>
        /// sgt_alg_functionaris
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="VerenigingId"></param>
        /// <param name="GebruikerId"></param>
        /// <param name="refresh"></param>
        /// <returns></returns>
        public List<ClubCloud_Functionaris> FunctionarissenByGebruiker(string bondsnummer, Guid GebruikerId, bool refresh = false)
        {
            CheckDatabase();

            List<ClubCloud_Functionaris> functionarissen = new List<ClubCloud_Functionaris>();

            using (ClubCloud.Service.Model.ClubCloudModelContainer model = new Model.ClubCloudModelContainer(GetConnectionString()))
            {
                functionarissen = model.ClubCloud_Functionarissen.Where(f => f.GebruikerId == GebruikerId && f.Actief == Sgt_alg_functionarisState.Active.ToString()).ToList();

                if (functionarissen != null && functionarissen.Count == 0 || refresh)
                {
                    ClubCloud_Setting settings = model.ClubCloud_Settings.Find(int.Parse(bondsnummer));

                    if (settings != null && settings.mijnknltb_allow && !string.IsNullOrWhiteSpace(settings.mijnknltb_password))
                    {
                        CookieContainer cc = RequestContainer(settings.Id.ToString(), settings.mijnknltb_password);

                        if (cc != null)
                        {
                            ClubCloud.KNLTB.ServIt.CrmService.CrmService service = new KNLTB.ServIt.CrmService.CrmService(cc);

                            ConditionExpression condition = new ConditionExpression { AttributeName = "sgt_functionarisid", Operator = ConditionOperator.Equal, Values = new object[1] { GebruikerId } };
                            FilterExpression expression = new FilterExpression { FilterOperator = LogicalOperator.And, Conditions = new ConditionExpression[1] { condition } };

                            bool moreRecords = true;
                            int pageNum = 1;
                            while (moreRecords)
                            {
                                List<BusinessEntity> entities = RetrieveMultiple(service, "sgt_alg_functionaris", out moreRecords, ref pageNum, expression);

                                foreach (sgt_alg_functionaris entity in entities)
                                {
                                    ClubCloud_Functionaris functionaris = model.ClubCloud_Functionarissen.Find(entity.sgt_alg_functionarisid.Value);

                                    if (functionaris == null)
                                    {
                                        functionaris = model.ClubCloud_Functionarissen.Create();
                                        functionaris.Id = entity.sgt_alg_functionarisid.Value;
                                        FunctieById(bondsnummer, entity.sgt_functieid.Value, true);
                                        functionaris.FunctieId = entity.sgt_functieid.Value;

                                        GebruikerById(bondsnummer, entity.sgt_functionarisid.Value, true);
                                        functionaris.GebruikerId = entity.sgt_functionarisid.Value;

                                        VerenigingById(bondsnummer, entity.sgt_basisorganisatieid.Value, true);
                                        functionaris.VerenigingId = entity.sgt_basisorganisatieid.Value;

                                        BestuursOrgaanById(bondsnummer, entity.sgt_bestuursorgaanid.Value, true);
                                        functionaris.BestuursorgaanId = entity.sgt_bestuursorgaanid.Value;

                                        functionaris.TermijnBegin = DateTime.Parse(entity.sgt_termijn_begint.Value);
                                        functionaris.TermijnEinde = DateTime.Parse(entity.sgt_termijn_loopt_af.Value); ;
                                        functionaris.Autorisatie = entity.sgt_autorisatie_gezet.Value;
                                        functionaris.Actief = entity.statuscode.name;

                                        model.ClubCloud_Functionarissen.Add(functionaris);
                                        functionarissen.Add(functionaris);

                                    }
                                    else
                                    {
                                        FunctieById(bondsnummer, entity.sgt_functieid.Value, true);
                                        functionaris.FunctieId = entity.sgt_functieid.Value;

                                        GebruikerById(bondsnummer, entity.sgt_functionarisid.Value, true);
                                        functionaris.GebruikerId = entity.sgt_functionarisid.Value;

                                        VerenigingById(bondsnummer, entity.sgt_basisorganisatieid.Value, true);
                                        functionaris.VerenigingId = entity.sgt_basisorganisatieid.Value;

                                        BestuursOrgaanById(bondsnummer, entity.sgt_bestuursorgaanid.Value, true);
                                        functionaris.BestuursorgaanId = entity.sgt_bestuursorgaanid.Value;

                                        functionaris.TermijnBegin = DateTime.Parse(entity.sgt_termijn_begint.Value);
                                        functionaris.TermijnEinde = DateTime.Parse(entity.sgt_termijn_loopt_af.Value); ;
                                        functionaris.Autorisatie = entity.sgt_autorisatie_gezet.Value;
                                        functionaris.Actief = entity.statuscode.name;
                                    }
                                }
                            }
                        }
                    }
                    model.SaveChanges();
                    functionarissen = model.ClubCloud_Functionarissen.Where(f => f.VerenigingId == VerenigingId && f.GebruikerId == GebruikerId && f.Actief == Sgt_alg_functionarisState.Active.ToString()).ToList();
                }
                model.SaveChanges();
            }
            return functionarissen;

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="functionaris"></param>
        /// <param name="refresh"></param>
        /// <returns></returns>
        public ClubCloud_Functionaris FunctionarisUpdate(string bondsnummer, ClubCloud_Functionaris functionaris, bool refresh = false)
        {
            CheckDatabase();
            ClubCloud_Functionaris updatable = functionaris;

            using (ClubCloud.Service.Model.ClubCloudModelContainer model = new Model.ClubCloudModelContainer(GetConnectionString()))
            {
                updatable = model.ClubCloud_Functionarissen.Find(functionaris.Id);
                updatable.TermijnBegin = functionaris.TermijnBegin;
                updatable.TermijnEinde = functionaris.TermijnEinde;


                if (model.ChangeTracker.HasChanges())
                {
                    ClubCloud_Setting settings = model.ClubCloud_Settings.Find(int.Parse(bondsnummer));

                    if (settings != null && settings.mijnknltb_allow && !string.IsNullOrWhiteSpace(settings.mijnknltb_password))
                    {
                        CookieContainer cc = RequestContainer(settings.Id.ToString(), settings.mijnknltb_password);

                        if (cc != null)
                        {
                            ClubCloud.KNLTB.ServIt.CrmService.CrmService service = new KNLTB.ServIt.CrmService.CrmService(cc);

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

                    model.SaveChanges();
                    updatable = model.ClubCloud_Functionarissen.Find(functionaris.Id);
                }
            }

            return updatable;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="functionaris"></param>
        /// <param name="refresh"></param>
        /// <returns></returns>
        public ClubCloud_Functionaris FunctionarisCreate(string bondsnummer, ClubCloud_Functionaris functionaris, bool refresh = false)
        {
            CheckDatabase();

            using (ClubCloud.Service.Model.ClubCloudModelContainer model = new Model.ClubCloudModelContainer(GetConnectionString()))
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
                    

                    model.ClubCloud_Functionarissen.Add(functionaris);
                }
            }

            return functionaris;
        }

        #endregion

        #region Bestuur

        /// <summary>
        /// sgt_alg_bestuursorgaan
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="refresh"></param>
        /// <returns></returns>
        public List<ClubCloud_Bestuursorgaan> BestuursOrganen(string bondsnummer, bool refresh = false)
        {
            CheckDatabase();

            List<ClubCloud_Bestuursorgaan> bestuursorganen = new List<ClubCloud_Bestuursorgaan>();

            using (ClubCloud.Service.Model.ClubCloudModelContainer model = new Model.ClubCloudModelContainer(GetConnectionString()))
            {
                bestuursorganen = model.ClubCloud_Bestuursorganen.ToList();

                if (bestuursorganen != null && bestuursorganen.Count == 0)
                {
                    ClubCloud_Setting settings = model.ClubCloud_Settings.Find(int.Parse(bondsnummer));
                    if (settings != null && settings.mijnknltb_allow && !string.IsNullOrWhiteSpace(settings.mijnknltb_password))
                    {
                        CookieContainer cc = RequestContainer(settings.Id.ToString(), settings.mijnknltb_password);

                        if (cc != null)
                        {
                            ClubCloud.KNLTB.ServIt.CrmService.CrmService service = new KNLTB.ServIt.CrmService.CrmService(cc);

                            bool moreRecords = true;
                            int pageNum = 1;
                            while (moreRecords)
                            {
                                List<BusinessEntity> entities = RetrieveMultiple(service, "sgt_alg_bestuursorgaan", out moreRecords, ref pageNum);

                                foreach (sgt_alg_bestuursorgaan entity in entities)
                                {
                                    ClubCloud_Bestuursorgaan bestuursorgaan = model.ClubCloud_Bestuursorganen.Find(entity.sgt_alg_bestuursorgaanid.Value);

                                    if (bestuursorgaan == null)
                                    {
                                        bestuursorgaan = model.ClubCloud_Bestuursorganen.Create();
                                        bestuursorgaan.Id = entity.sgt_alg_bestuursorgaanid.Value;
                                        bestuursorgaan.Naam = entity.sgt_alg_bestuursorgaan1;
                                        bestuursorgaan.Beschrijving = entity.sgt_beschrijving;
                                        VerenigingById(bondsnummer, entity.sgt_basisorganisatieid.Value, true);
                                        bestuursorgaan.VerenigingId = entity.sgt_basisorganisatieid.Value;
                                        bestuursorgaan.TypeId = entity.sgt_typebestuursorgaanid.Value;
                                        bestuursorgaan.Actief = entity.statuscode.name;
                                        model.ClubCloud_Bestuursorganen.Add(bestuursorgaan);
                                        bestuursorganen.Add(bestuursorgaan);
                                    }
                                    else
                                    {
                                        bestuursorgaan.Naam = entity.sgt_alg_bestuursorgaan1;
                                        bestuursorgaan.Beschrijving = entity.sgt_beschrijving;
                                        VerenigingById(bondsnummer, entity.sgt_basisorganisatieid.Value, true);
                                        bestuursorgaan.VerenigingId = entity.sgt_basisorganisatieid.Value;
                                        bestuursorgaan.TypeId = entity.sgt_typebestuursorgaanid.Value;
                                        bestuursorgaan.Actief = entity.statuscode.name;
                                    }
                                }
                            }
                        }
                    }
                }
                model.SaveChanges();
            }
            return bestuursorganen;
            //sgt_alg_functie
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="bestuursorgaanId"></param>
        /// <param name="refresh"></param>
        /// <returns></returns>
        public ClubCloud_Bestuursorgaan BestuursOrgaanById(string bondsnummer, Guid bestuursorgaanId, bool refresh = false)
        {
            CheckDatabase();

            ClubCloud_Bestuursorgaan bestuursorgaan = new ClubCloud_Bestuursorgaan();

            using (ClubCloud.Service.Model.ClubCloudModelContainer model = new Model.ClubCloudModelContainer(GetConnectionString()))
            {
                bestuursorgaan = model.ClubCloud_Bestuursorganen.Find(bestuursorgaanId);

                if (bestuursorgaan == null )
                {
                    ClubCloud_Setting settings = model.ClubCloud_Settings.Find(int.Parse(bondsnummer));
                    if (settings != null && settings.mijnknltb_allow && !string.IsNullOrWhiteSpace(settings.mijnknltb_password))
                    {
                        CookieContainer cc = RequestContainer(settings.Id.ToString(), settings.mijnknltb_password);

                        if (cc != null)
                        {
                            ClubCloud.KNLTB.ServIt.CrmService.CrmService service = new KNLTB.ServIt.CrmService.CrmService(cc);

                            bool moreRecords = true;
                            int pageNum = 1;
                            while (moreRecords)
                            {
                                ConditionExpression condition = new ConditionExpression { AttributeName = "sgt_alg_bestuursorgaanid", Operator = ConditionOperator.Equal, Values = new object[1] { bestuursorgaanId } };
                                FilterExpression expression = new FilterExpression { FilterOperator = LogicalOperator.And, Conditions = new ConditionExpression[1] { condition } };

                                List<BusinessEntity> entities = RetrieveMultiple(service, "sgt_alg_bestuursorgaan", out moreRecords, ref pageNum, expression);

                                foreach (sgt_alg_bestuursorgaan entity in entities)
                                {
                                    bestuursorgaan = model.ClubCloud_Bestuursorganen.Find(entity.sgt_alg_bestuursorgaanid.Value);

                                    if (bestuursorgaan == null)
                                    {
                                        bestuursorgaan = model.ClubCloud_Bestuursorganen.Create();
                                        bestuursorgaan.Id = entity.sgt_alg_bestuursorgaanid.Value;
                                        bestuursorgaan.Naam = entity.sgt_alg_bestuursorgaan1;
                                        bestuursorgaan.Beschrijving = entity.sgt_beschrijving;
                                        VerenigingById(bondsnummer, entity.sgt_basisorganisatieid.Value, true);
                                        bestuursorgaan.VerenigingId = entity.sgt_basisorganisatieid.Value;
                                        bestuursorgaan.TypeId = entity.sgt_typebestuursorgaanid.Value;
                                        bestuursorgaan.Actief = entity.statuscode.name;
                                        model.ClubCloud_Bestuursorganen.Add(bestuursorgaan);
                                    }
                                    else
                                    {
                                        bestuursorgaan.Naam = entity.sgt_alg_bestuursorgaan1;
                                        bestuursorgaan.Beschrijving = entity.sgt_beschrijving;
                                        VerenigingById(bondsnummer, entity.sgt_basisorganisatieid.Value, true);
                                        bestuursorgaan.VerenigingId = entity.sgt_basisorganisatieid.Value;
                                        bestuursorgaan.TypeId = entity.sgt_typebestuursorgaanid.Value;
                                        bestuursorgaan.Actief = entity.statuscode.name;
                                    }
                                }
                            }
                        }
                    }
                }
                model.SaveChanges();
            }
            return bestuursorgaan;
            //sgt_alg_functie
        }

        /// <summary>
        /// sgt_alg_bestuursorgaan
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="verenigingId"></param>
        /// <param name="refresh"></param>
        /// <returns></returns>
        public List<ClubCloud_Bestuursorgaan> BestuursOrgaanByVereniging(string bondsnummer, Guid verenigingId, bool refresh = false)
        {
            CheckDatabase();

            List<ClubCloud_Bestuursorgaan> bestuursorganen = new List<ClubCloud_Bestuursorgaan>();

            using (ClubCloud.Service.Model.ClubCloudModelContainer model = new Model.ClubCloudModelContainer(GetConnectionString()))
            {
                bestuursorganen = model.ClubCloud_Bestuursorganen.Where(b => b.VerenigingId == verenigingId).ToList();

                if (bestuursorganen != null && bestuursorganen.Count == 0)
                {
                    ClubCloud_Setting settings = model.ClubCloud_Settings.Find(int.Parse(bondsnummer));
                    if (settings != null && settings.mijnknltb_allow && !string.IsNullOrWhiteSpace(settings.mijnknltb_password))
                    {
                        CookieContainer cc = RequestContainer(settings.Id.ToString(), settings.mijnknltb_password);

                        if (cc != null)
                        {
                            ClubCloud.KNLTB.ServIt.CrmService.CrmService service = new KNLTB.ServIt.CrmService.CrmService(cc);

                            bool moreRecords = true;
                            int pageNum = 1;
                            while (moreRecords)
                            {
                                ConditionExpression condition = new ConditionExpression { AttributeName = "sgt_basisorganisatieid", Operator = ConditionOperator.Equal, Values = new object[1] { verenigingId } };
                                FilterExpression expression = new FilterExpression { FilterOperator = LogicalOperator.And, Conditions = new ConditionExpression[1] { condition } };

                                List<BusinessEntity> entities = RetrieveMultiple(service, "sgt_alg_bestuursorgaan", out moreRecords, ref pageNum, expression);

                                foreach (sgt_alg_bestuursorgaan entity in entities)
                                {
                                    ClubCloud_Bestuursorgaan bestuursorgaan = model.ClubCloud_Bestuursorganen.Find(entity.sgt_alg_bestuursorgaanid.Value);

                                    if (bestuursorgaan == null)
                                    {
                                        bestuursorgaan = model.ClubCloud_Bestuursorganen.Create();
                                        bestuursorgaan.Id = entity.sgt_alg_bestuursorgaanid.Value;
                                        bestuursorgaan.Naam = entity.sgt_alg_bestuursorgaan1;
                                        bestuursorgaan.Beschrijving = entity.sgt_beschrijving;
                                        VerenigingById(bondsnummer, entity.sgt_basisorganisatieid.Value, true);
                                        bestuursorgaan.VerenigingId = entity.sgt_basisorganisatieid.Value;
                                        bestuursorgaan.TypeId = entity.sgt_typebestuursorgaanid.Value;
                                        bestuursorgaan.Actief = entity.statuscode.name;
                                        model.ClubCloud_Bestuursorganen.Add(bestuursorgaan);
                                        bestuursorganen.Add(bestuursorgaan);
                                    }
                                    else
                                    {
                                        bestuursorgaan.Naam = entity.sgt_alg_bestuursorgaan1;
                                        bestuursorgaan.Beschrijving = entity.sgt_beschrijving;
                                        VerenigingById(bondsnummer, entity.sgt_basisorganisatieid.Value, true);
                                        bestuursorgaan.VerenigingId = entity.sgt_basisorganisatieid.Value;
                                        bestuursorgaan.TypeId = entity.sgt_typebestuursorgaanid.Value;
                                        bestuursorgaan.Actief = entity.statuscode.name;
                                    }
                                }
                            }
                        }
                    }
                }
                model.SaveChanges();
            }
            return bestuursorganen;
            //sgt_alg_functie
        }

        #endregion

        #region Baan

        /// <summary>
        /// sgt_alg_baantype
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="refresh"></param>
        /// <returns></returns>
        public List<ClubCloud_Baantype> Baantypes(string bondsnummer, bool refresh = false)
        {
            List<ClubCloud_Baantype> baantypes = new List<ClubCloud_Baantype>();

            sgt_alg_baantype baantype = new sgt_alg_baantype();
            //baantype.sgt_beschrijving
            return baantypes;
        }

        /// <summary>
        /// sgt_alg_baantype
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="baantypeId"></param>
        /// <param name="refresh"></param>
        /// <returns></returns>
        public ClubCloud_Baantype BaantypeById(string bondsnummer, Guid baantypeId, bool refresh = false)
        {
        ClubCloud_Baantype baantype= new ClubCloud_Baantype();
            //sgt_alg_baantype baantype = new sgt_alg_baantype();
            return baantype;
        }

        /// <summary>
        /// sgt_alg_baansoort
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="refresh"></param>
        /// <returns></returns>
        public List<ClubCloud_Baansoort> Baansoorten(string bondsnummer, bool refresh = false)
        {
            List<ClubCloud_Baansoort> baansoorten = new List<ClubCloud_Baansoort>();

            sgt_alg_baansoort baansoort = new sgt_alg_baansoort();
            return baansoorten;
        }

        /// <summary>
        /// sgt_alg_baansoort
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="baansoortId"></param>
        /// <param name="refresh"></param>
        /// <returns></returns>
        public ClubCloud_Baansoort BaansoortById(string bondsnummer,Guid baansoortId, bool refresh = false)
        {
            ClubCloud_Baansoort baansoort = new ClubCloud_Baansoort();
            //sgt_alg_baansoort baansoort = new sgt_alg_baansoort();
            return baansoort;
        }

        /// <summary>
        /// sgt_alg_baansoort
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="baantypeId"></param>
        /// <param name="refresh"></param>
        /// <returns></returns>
        public List<ClubCloud_Baansoort> BaansoortenByType(string bondsnummer,Guid baantypeId, bool refresh = false)
        {
            List<ClubCloud_Baansoort> baansoorten = new List<ClubCloud_Baansoort>();
            sgt_alg_baansoort baansoort = new sgt_alg_baansoort();
            return baansoorten;
        }

        /// <summary>
        /// sgt_alg_speciale_baan
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="refresh"></param>
        /// <returns></returns>
        public List<ClubCloud_BaanSpeciaal> Specialebanen(string bondsnummer, bool refresh = false)
        {
            List<ClubCloud_BaanSpeciaal> banen = new List<ClubCloud_BaanSpeciaal>();

            sgt_alg_speciale_baan specialebaan = new sgt_alg_speciale_baan();

            return banen;
        }

        /// <summary>
        /// sgt_alg_speciale_baan
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="specialebaanId"></param>
        /// <param name="refresh"></param>
        /// <returns></returns>
        public List<ClubCloud_BaanSpeciaal> SpecialebaanById(string bondsnummer, Guid specialebaanId, bool refresh = false)
        {
            List<ClubCloud_BaanSpeciaal> banen = new List<ClubCloud_BaanSpeciaal>();

            sgt_alg_speciale_baan specialebaan = new sgt_alg_speciale_baan();
            return banen;
        }
        public List<ClubCloud_BaanSpeciaal> SpecialebaanBySoort(string bondsnummer, Guid baansoortId, bool refresh = false)
        {
            List<ClubCloud_BaanSpeciaal> banen = new List<ClubCloud_BaanSpeciaal>();

            sgt_alg_speciale_baan baansoort = new sgt_alg_speciale_baan();
            return banen;
        }

        /// <summary>
        /// sgt_alg_speciale_baan
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="accomodatieId"></param>
        /// <param name="refresh"></param>
        /// <returns></returns>
        public List<ClubCloud_BaanSpeciaal> SpecialebaanByAccomodatie(string bondsnummer, Guid accomodatieId, bool refresh = false)
        {
            List<ClubCloud_BaanSpeciaal> banen = new List<ClubCloud_BaanSpeciaal>();

            sgt_alg_speciale_baan specialebaan = new sgt_alg_speciale_baan();
            return banen;
        }

        public List<ClubCloud_Baan> Banen(string bondsnummer, bool refresh = false)
        {
            List<ClubCloud_Baan> banen = new List<ClubCloud_Baan>();

            sgt_alg_baan baansoort = new sgt_alg_baan();

            return banen;
        }

        public ClubCloud_Baan BaanById(string bondsnummer, bool refresh = false)
        {
            ClubCloud_Baan baan = new ClubCloud_Baan();

            sgt_alg_baan baansoort = new sgt_alg_baan();
            //baansoort.sgt_accommodatieid
            return baan;
        }

        public List<ClubCloud_BaanSpeciaal> BanenByAccomodatie(string bondsnummer, bool refresh = false)
        {
            List<ClubCloud_BaanSpeciaal> banen = new List<ClubCloud_BaanSpeciaal>();

            sgt_alg_baan baansoort = new sgt_alg_baan();

            return banen;
        }
        #endregion

        #region Bouwaard

        /// <summary>
        /// sgt_alg_bouwaard
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="refresh"></param>
        /// <returns></returns>
        public List<ClubCloud_Bouwaard> Bouwaarden(string bondsnummer, bool refresh = false)
        {
            List<ClubCloud_Bouwaard> bouwaarden = new List<ClubCloud_Bouwaard>();

            sgt_alg_baantype baantype = new sgt_alg_baantype();

            return bouwaarden;
        }

        /// <summary>
        /// sgt_alg_bouwaard
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="bouwaardId"></param>
        /// <param name="refresh"></param>
        /// <returns></returns>
        public ClubCloud_Bouwaard BouwaardById(string bondsnummer, Guid bouwaardId, bool refresh = false)
        {
            ClubCloud_Bouwaard bouwaard = new ClubCloud_Bouwaard();
            //sgt_alg_baantype baantype = new sgt_alg_baantype();
            return bouwaard;
        }

        #endregion

        #region Accomodatie

        /// <summary>
        /// sgt_alg_accommodatie
        /// </summary>
        public ClubCloud_Accomodatie AccommodatieById(string bondsnummer, Guid accomodatieId, bool refresh = false)
        {
            CheckDatabase();

            ClubCloud_Accomodatie accomodatie = new ClubCloud_Accomodatie();

            using (ClubCloud.Service.Model.ClubCloudModelContainer model = new Model.ClubCloudModelContainer(GetConnectionString()))
            {
                accomodatie = model.ClubCloud_Accomodaties.Find(accomodatieId);
            }

            return accomodatie;
        }

        /// <summary>
        /// sgt_alg_accommodatie
        /// </summary>
        public List<ClubCloud_Accomodatie> AccommodatieByVereniging(string bondsnummer, Guid verenigingId, bool refresh = false)
        {
            CheckDatabase();

            List<ClubCloud_Accomodatie> accomodaties = new List<ClubCloud_Accomodatie>();

            using (ClubCloud.Service.Model.ClubCloudModelContainer model = new Model.ClubCloudModelContainer(GetConnectionString()))
            {
                //accomodaties = model.ClubCloud_Accomodaties
            }

            //sgt_alg_accommodatie accomodatie = new sgt_alg_accommodatie { };

            return accomodaties;
        }

        #endregion

        #region Lidmaatschap

        /// <summary>
        /// sgt_alg_lidmaatschap
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="verenigingId"></param>
        /// <param name="refresh"></param>
        /// <returns></returns>
        public List<ClubCloud_Lidmaatschap> Lidmaatschappen(string bondsnummer, Guid verenigingId, bool refresh = false)
        {
            CheckDatabase();

            List<ClubCloud_Lidmaatschap> lidmaatschappen = new List<ClubCloud_Lidmaatschap>();

            using (ClubCloud.Service.Model.ClubCloudModelContainer model = new Model.ClubCloudModelContainer(GetConnectionString()))
            {
                lidmaatschappen = model.ClubCloud_Lidmaatschappen.Where(l => l.VerenigingId == verenigingId).ToList();

                if (lidmaatschappen != null && lidmaatschappen.Count == 0 || refresh)
                {
                    ClubCloud_Setting settings = model.ClubCloud_Settings.Find(int.Parse(bondsnummer));

                    if (settings != null && settings.mijnknltb_allow && !string.IsNullOrWhiteSpace(settings.mijnknltb_password))
                    {
                        CookieContainer cc = RequestContainer(settings.Id.ToString(), settings.mijnknltb_password);

                        if (cc != null)
                        {
                            ClubCloud.KNLTB.ServIt.CrmService.CrmService service = new KNLTB.ServIt.CrmService.CrmService(cc);

                            bool moreRecords = true;
                            int pageNum = 1;
                            while (moreRecords)
                            {
                                List<BusinessEntity> entities = RetrieveMultiple(service, "sgt_alg_lidmaatschap", out moreRecords, ref pageNum);

                                foreach (sgt_alg_lidmaatschap entity in entities)
                                {
                                    ClubCloud_Lidmaatschap lidmaatschap = model.ClubCloud_Lidmaatschappen.Find(entity.sgt_alg_lidmaatschapid.Value);

                                    if (lidmaatschap == null)
                                    {
                                        lidmaatschap = model.ClubCloud_Lidmaatschappen.Create();
                                        lidmaatschap.Autorisatie =entity.sgt_autorisatie_gezet.Value;
                                        //lidmaatschap.BondsNummer = entity.sgt_alg_bondsnummer;
                                        lidmaatschap.Id = entity.sgt_alg_lidmaatschapid.Value;
                                        GebruikerById(bondsnummer, entity.sgt_lidid.Value, true);
                                        lidmaatschap.GebruikerId = entity.sgt_lidid.Value;
                                        lidmaatschap.InternNummer = entity.sgt_lidnummer_bij_vereniging;

                                        lidmaatschap.SoortNaam = entity.sgt_soort_lidmaatschapid.name;
                                        lidmaatschap.SoortId = entity.sgt_soort_lidmaatschapid.Value;

                                        lidmaatschap.VerenigingId = entity.sgt_verenigingid.Value;
                                        
                                        //entity.sgt_toernooiorganisatieid.name;
                                        //entity.sgt_toernooiorganisatieid.type;
                                        //entity.sgt_toernooiorganisatieid.Value;

                                        lidmaatschap.Begin = DateTime.Parse(entity.sgt_lidmaatschap_vanaf.Value);
                                        lidmaatschap.Einde = DateTime.Parse( entity.sgt_lidmaatschap_beeindigd.Value);
                                        lidmaatschap.Opzegging = DateTime.Parse(entity.sgt_datum_opgezegd.Value);
                                        
                                        lidmaatschap.PasNieuw = entity.sgt_nieuwe_pas_nodig.Value;
                                        lidmaatschap.PasTypeNaam = entity.sgt_pastypeid.name;
                                        //lidmaatschap.PasTypeId = entity.sgt_pastypeid.type;
                                        lidmaatschap.PasTypeId = entity.sgt_pastypeid.Value;
                                        lidmaatschap.PasWedstrijd = entity.sgt_wedstrijdpas.Value;
                                        lidmaatschap.PasVolgnummer = entity.sgt_volgnummer_pas;
                                        lidmaatschap.PasNood = entity.sgt_noodpas_nodig.Value;
                                        lidmaatschap.PasNoodDatum = DateTime.Parse(entity.sgt_datum_laatste_noodpas.Value);
                                        lidmaatschap.PasDatum = DateTime.Parse(entity.sgt_datum_laatste_pas.Value);

                                        lidmaatschap.SpeelsterkteDubbel = entity.sgt_speelsterkte_dubbel.Value;
                                        lidmaatschap.SpeelsterkteEnkel = entity.sgt_speelsterkte_enkel.Value;
                                        
                                        lidmaatschap.Actief = entity.statuscode.name;
                                        model.ClubCloud_Lidmaatschappen.Add(lidmaatschap);
                                        lidmaatschappen.Add(lidmaatschap);

                                    }
                                    else
                                    {
                                        lidmaatschap.Autorisatie = entity.sgt_autorisatie_gezet.Value;
                                        //lidmaatschap.BondsNummer = entity.sgt_alg_bondsnummer;
                                        lidmaatschap.Id = entity.sgt_alg_lidmaatschapid.Value;
                                        GebruikerById(bondsnummer, entity.sgt_lidid.Value, true);
                                        lidmaatschap.GebruikerId = entity.sgt_lidid.Value;
                                        lidmaatschap.InternNummer = entity.sgt_lidnummer_bij_vereniging;

                                        lidmaatschap.SoortNaam = entity.sgt_soort_lidmaatschapid.name;
                                        lidmaatschap.SoortId = entity.sgt_soort_lidmaatschapid.Value;

                                        lidmaatschap.VerenigingId = entity.sgt_verenigingid.Value;

                                        //entity.sgt_toernooiorganisatieid.name;
                                        //entity.sgt_toernooiorganisatieid.type;
                                        //entity.sgt_toernooiorganisatieid.Value;
                                        if (!entity.sgt_lidmaatschap_vanaf.IsNull)
                                        {
                                            lidmaatschap.Begin = DateTime.Parse(entity.sgt_lidmaatschap_vanaf.Value);
                                        }
                                        if (!entity.sgt_lidmaatschap_beeindigd.IsNull)
                                        {
                                            lidmaatschap.Einde = DateTime.Parse(entity.sgt_lidmaatschap_beeindigd.Value);
                                        }

                                        if (!entity.sgt_datum_opgezegd.IsNull)
                                        {
                                            lidmaatschap.Opzegging = DateTime.Parse(entity.sgt_datum_opgezegd.Value);
                                        }

                                        lidmaatschap.PasNieuw = entity.sgt_nieuwe_pas_nodig.Value;
                                        lidmaatschap.PasTypeNaam = entity.sgt_pastypeid.name;
                                        //lidmaatschap.PasTypeId = entity.sgt_pastypeid.type;
                                        lidmaatschap.PasTypeId = entity.sgt_pastypeid.Value;
                                        lidmaatschap.PasWedstrijd = entity.sgt_wedstrijdpas.Value;
                                        lidmaatschap.PasVolgnummer = entity.sgt_volgnummer_pas;
                                        lidmaatschap.PasNood = entity.sgt_noodpas_nodig.Value;

                                        if (!entity.sgt_datum_laatste_noodpas.IsNull)
                                        {
                                            lidmaatschap.PasNoodDatum = DateTime.Parse(entity.sgt_datum_laatste_noodpas.Value);
                                        }

                                        lidmaatschap.PasDatum = DateTime.Parse(entity.sgt_datum_laatste_pas.Value);

                                        lidmaatschap.SpeelsterkteDubbel = entity.sgt_speelsterkte_dubbel.Value;
                                        lidmaatschap.SpeelsterkteEnkel = entity.sgt_speelsterkte_enkel.Value;


                                        lidmaatschap.Actief = entity.statuscode.name;

                                    }

                                }
                            }
                        }
                    }
                }
                model.SaveChanges();
            }
            return lidmaatschappen;
        }

        /// <summary>
        /// sgt_alg_lidmaatschap
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="lidId"></param>
        /// <param name="refresh"></param>
        /// <returns></returns>
        public ClubCloud_Lidmaatschap LidmaatschapByGebruiker(string bondsnummer, Guid gebruikerId,  bool refresh = false)
        {
            CheckDatabase();

            ClubCloud_Lidmaatschap lidmaatschap = new ClubCloud_Lidmaatschap();


            using (ClubCloud.Service.Model.ClubCloudModelContainer model = new Model.ClubCloudModelContainer(GetConnectionString()))
            {
                lidmaatschap = model.ClubCloud_Lidmaatschappen.SingleOrDefault(l => l.GebruikerId == gebruikerId);

                if (lidmaatschap == null || refresh)
                {
                    ClubCloud_Setting settings = model.ClubCloud_Settings.Find(int.Parse(bondsnummer));

                    if (settings != null && settings.mijnknltb_allow && !string.IsNullOrWhiteSpace(settings.mijnknltb_password))
                    {
                        CookieContainer cc = RequestContainer(settings.Id.ToString(), settings.mijnknltb_password);

                        if (cc != null)
                        {
                            ClubCloud.KNLTB.ServIt.CrmService.CrmService service = new KNLTB.ServIt.CrmService.CrmService(cc);

                            bool moreRecords = true;
                            int pageNum = 1;
                            while (moreRecords)
                            {
                                ConditionExpression condition = new ConditionExpression { AttributeName = "sgt_lidid", Operator = ConditionOperator.Equal, Values = new object[1] { gebruikerId } };
                                FilterExpression expression = new FilterExpression { FilterOperator = LogicalOperator.And, Conditions = new ConditionExpression[1] { condition } };

                                List<BusinessEntity> entities = RetrieveMultiple(service, "sgt_alg_lidmaatschap", out moreRecords, ref pageNum, expression);

                                foreach (sgt_alg_lidmaatschap entity in entities)
                                {
                                    lidmaatschap = model.ClubCloud_Lidmaatschappen.Find(entity.sgt_alg_lidmaatschapid.Value);

                                    if (lidmaatschap == null)
                                    {
                                        lidmaatschap = model.ClubCloud_Lidmaatschappen.Create();
                                        lidmaatschap.Autorisatie = entity.sgt_autorisatie_gezet.Value;
                                        //lidmaatschap.BondsNummer = entity.sgt_alg_bondsnummer;
                                        lidmaatschap.Id = entity.sgt_alg_lidmaatschapid.Value;

                                        GebruikerById(bondsnummer, entity.sgt_lidid.Value, true);
                                        //SpelersProfielById
                                        lidmaatschap.GebruikerId = entity.sgt_lidid.Value;

                                        lidmaatschap.InternNummer = entity.sgt_lidnummer_bij_vereniging;

                                        lidmaatschap.SoortNaam = entity.sgt_soort_lidmaatschapid.name;
                                        lidmaatschap.SoortId = entity.sgt_soort_lidmaatschapid.Value;

                                        lidmaatschap.VerenigingId = entity.sgt_verenigingid.Value;

                                        //entity.sgt_toernooiorganisatieid.name;
                                        //entity.sgt_toernooiorganisatieid.type;
                                        //entity.sgt_toernooiorganisatieid.Value;

                                        lidmaatschap.Begin = DateTime.Parse(entity.sgt_lidmaatschap_vanaf.Value);
                                        lidmaatschap.Einde = DateTime.Parse(entity.sgt_lidmaatschap_beeindigd.Value);
                                        lidmaatschap.Opzegging = DateTime.Parse(entity.sgt_datum_opgezegd.Value);

                                        lidmaatschap.PasNieuw = entity.sgt_nieuwe_pas_nodig.Value;
                                        lidmaatschap.PasTypeNaam = entity.sgt_pastypeid.name;
                                        //lidmaatschap.PasTypeId = entity.sgt_pastypeid.type;
                                        lidmaatschap.PasTypeId = entity.sgt_pastypeid.Value;
                                        lidmaatschap.PasWedstrijd = entity.sgt_wedstrijdpas.Value;
                                        lidmaatschap.PasVolgnummer = entity.sgt_volgnummer_pas;
                                        lidmaatschap.PasNood = entity.sgt_noodpas_nodig.Value;
                                        lidmaatschap.PasNoodDatum = DateTime.Parse(entity.sgt_datum_laatste_noodpas.Value);
                                        lidmaatschap.PasDatum = DateTime.Parse(entity.sgt_datum_laatste_pas.Value);

                                        lidmaatschap.SpeelsterkteDubbel = entity.sgt_speelsterkte_dubbel.Value;
                                        lidmaatschap.SpeelsterkteEnkel = entity.sgt_speelsterkte_enkel.Value;

                                        lidmaatschap.Actief = entity.statuscode.name;
                                        model.ClubCloud_Lidmaatschappen.Add(lidmaatschap);

                                    }
                                    else
                                    {
                                        lidmaatschap.Autorisatie = entity.sgt_autorisatie_gezet.Value;
                                        //lidmaatschap.BondsNummer = entity.sgt_alg_bondsnummer;
                                        lidmaatschap.Id = entity.sgt_alg_lidmaatschapid.Value;
                                        GebruikerById(bondsnummer, entity.sgt_lidid.Value, true);
                                        lidmaatschap.GebruikerId = entity.sgt_lidid.Value;
                                        lidmaatschap.InternNummer = entity.sgt_lidnummer_bij_vereniging;

                                        lidmaatschap.SoortNaam = entity.sgt_soort_lidmaatschapid.name;
                                        lidmaatschap.SoortId = entity.sgt_soort_lidmaatschapid.Value;

                                        lidmaatschap.VerenigingId = entity.sgt_verenigingid.Value;

                                        //entity.sgt_toernooiorganisatieid.name;
                                        //entity.sgt_toernooiorganisatieid.type;
                                        //entity.sgt_toernooiorganisatieid.Value;
                                        if (!entity.sgt_lidmaatschap_vanaf.IsNull)
                                        {
                                            lidmaatschap.Begin = DateTime.Parse(entity.sgt_lidmaatschap_vanaf.Value);
                                        }
                                        if (!entity.sgt_lidmaatschap_beeindigd.IsNull)
                                        {
                                            lidmaatschap.Einde = DateTime.Parse(entity.sgt_lidmaatschap_beeindigd.Value);
                                        }

                                        if (!entity.sgt_datum_opgezegd.IsNull)
                                        {
                                            lidmaatschap.Opzegging = DateTime.Parse(entity.sgt_datum_opgezegd.Value);
                                        }

                                        lidmaatschap.PasNieuw = entity.sgt_nieuwe_pas_nodig.Value;
                                        lidmaatschap.PasTypeNaam = entity.sgt_pastypeid.name;
                                        //lidmaatschap.PasTypeId = entity.sgt_pastypeid.type;
                                        lidmaatschap.PasTypeId = entity.sgt_pastypeid.Value;
                                        lidmaatschap.PasWedstrijd = entity.sgt_wedstrijdpas.Value;
                                        lidmaatschap.PasVolgnummer = entity.sgt_volgnummer_pas;
                                        lidmaatschap.PasNood = entity.sgt_noodpas_nodig.Value;

                                        if (!entity.sgt_datum_laatste_noodpas.IsNull)
                                        {
                                            lidmaatschap.PasNoodDatum = DateTime.Parse(entity.sgt_datum_laatste_noodpas.Value);
                                        }

                                        lidmaatschap.PasDatum = DateTime.Parse(entity.sgt_datum_laatste_pas.Value);

                                        lidmaatschap.SpeelsterkteDubbel = entity.sgt_speelsterkte_dubbel.Value;
                                        lidmaatschap.SpeelsterkteEnkel = entity.sgt_speelsterkte_enkel.Value;


                                        lidmaatschap.Actief = entity.statuscode.name;

                                    }
                                }
                            }
                        }
                    }
                }
                model.SaveChanges();
            }

            return lidmaatschap;
            //sgt_lidid = {238DF8BA-5715-4A91-947F-1C95405C8AF4}
        }

        /// <summary>
        /// sgt_alg_lidmaatschap
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="verenigingId"></param>
        /// <param name="refresh"></param>
        /// <returns></returns>
        public List<ClubCloud_Lidmaatschap> LidmaatschappenByVereniging(string bondsnummer, Guid verenigingId, bool refresh = false)
        {
            CheckDatabase();

            List<ClubCloud_Lidmaatschap> lidmaatschappen = new List<ClubCloud_Lidmaatschap>();

            using (ClubCloud.Service.Model.ClubCloudModelContainer model = new Model.ClubCloudModelContainer(GetConnectionString()))
            {
                lidmaatschappen = model.ClubCloud_Lidmaatschappen.Where(f => f.VerenigingId == verenigingId && f.Actief == Sgt_alg_functionarisState.Active.ToString()).ToList();

                if (lidmaatschappen != null && lidmaatschappen.Count == 0 || refresh)
                {
                    ClubCloud_Setting settings = model.ClubCloud_Settings.Find(int.Parse(bondsnummer));

                    if (settings != null && settings.mijnknltb_allow && !string.IsNullOrWhiteSpace(settings.mijnknltb_password))
                    {
                        CookieContainer cc = RequestContainer(settings.Id.ToString(), settings.mijnknltb_password);

                        if (cc != null)
                        {
                            ClubCloud.KNLTB.ServIt.CrmService.CrmService service = new KNLTB.ServIt.CrmService.CrmService(cc);

                            bool moreRecords = true;
                            int pageNum = 1;
                            while (moreRecords)
                            {
                                ConditionExpression condition = new ConditionExpression { AttributeName = "sgt_verenigingid", Operator = ConditionOperator.Equal, Values = new object[1] { verenigingId } };
                                FilterExpression expression = new FilterExpression { FilterOperator = LogicalOperator.And, Conditions = new ConditionExpression[1] { condition } };

                                List<BusinessEntity> entities = RetrieveMultiple(service, "sgt_alg_lidmaatschap", out moreRecords, ref pageNum, expression);

                                foreach (sgt_alg_lidmaatschap entity in entities)
                                {
                                    ClubCloud_Lidmaatschap lidmaatschap = model.ClubCloud_Lidmaatschappen.Find(entity.sgt_alg_lidmaatschapid.Value);

                                    if (lidmaatschap == null)
                                    {
                                        lidmaatschap = model.ClubCloud_Lidmaatschappen.Create();
                                        lidmaatschap.Autorisatie = entity.sgt_autorisatie_gezet.Value;
                                        //lidmaatschap.BondsNummer = entity.sgt_alg_bondsnummer;
                                        lidmaatschap.Id = entity.sgt_alg_lidmaatschapid.Value;
                                        GebruikerById(bondsnummer, entity.sgt_lidid.Value, true);
                                        lidmaatschap.GebruikerId = entity.sgt_lidid.Value;
                                        lidmaatschap.InternNummer = entity.sgt_lidnummer_bij_vereniging;

                                        lidmaatschap.SoortNaam = entity.sgt_soort_lidmaatschapid.name;
                                        lidmaatschap.SoortId = entity.sgt_soort_lidmaatschapid.Value;

                                        lidmaatschap.VerenigingId = entity.sgt_verenigingid.Value;

                                        //entity.sgt_toernooiorganisatieid.name;
                                        //entity.sgt_toernooiorganisatieid.type;
                                        //entity.sgt_toernooiorganisatieid.Value;

                                        lidmaatschap.Begin = DateTime.Parse(entity.sgt_lidmaatschap_vanaf.Value);
                                        lidmaatschap.Einde = DateTime.Parse(entity.sgt_lidmaatschap_beeindigd.Value);
                                        lidmaatschap.Opzegging = DateTime.Parse(entity.sgt_datum_opgezegd.Value);

                                        lidmaatschap.PasNieuw = entity.sgt_nieuwe_pas_nodig.Value;
                                        lidmaatschap.PasTypeNaam = entity.sgt_pastypeid.name;
                                        //lidmaatschap.PasTypeId = entity.sgt_pastypeid.type;
                                        lidmaatschap.PasTypeId = entity.sgt_pastypeid.Value;
                                        lidmaatschap.PasWedstrijd = entity.sgt_wedstrijdpas.Value;
                                        lidmaatschap.PasVolgnummer = entity.sgt_volgnummer_pas;
                                        lidmaatschap.PasNood = entity.sgt_noodpas_nodig.Value;
                                        lidmaatschap.PasNoodDatum = DateTime.Parse(entity.sgt_datum_laatste_noodpas.Value);
                                        lidmaatschap.PasDatum = DateTime.Parse(entity.sgt_datum_laatste_pas.Value);

                                        lidmaatschap.SpeelsterkteDubbel = entity.sgt_speelsterkte_dubbel.Value;
                                        lidmaatschap.SpeelsterkteEnkel = entity.sgt_speelsterkte_enkel.Value;


                                        lidmaatschap.Actief = entity.statuscode.name;
                                        model.ClubCloud_Lidmaatschappen.Add(lidmaatschap);
                                        lidmaatschappen.Add(lidmaatschap);

                                    }
                                    else
                                    {
                                        lidmaatschap.Autorisatie = entity.sgt_autorisatie_gezet.Value;
                                        //lidmaatschap.BondsNummer = entity.sgt_alg_bondsnummer;
                                        lidmaatschap.Id = entity.sgt_alg_lidmaatschapid.Value;
                                        GebruikerById(bondsnummer, entity.sgt_lidid.Value, true);
                                        lidmaatschap.GebruikerId = entity.sgt_lidid.Value;
                                        lidmaatschap.InternNummer = entity.sgt_lidnummer_bij_vereniging;

                                        lidmaatschap.SoortNaam = entity.sgt_soort_lidmaatschapid.name;
                                        lidmaatschap.SoortId = entity.sgt_soort_lidmaatschapid.Value;

                                        lidmaatschap.VerenigingId = entity.sgt_verenigingid.Value;

                                        //entity.sgt_toernooiorganisatieid.name;
                                        //entity.sgt_toernooiorganisatieid.type;
                                        //entity.sgt_toernooiorganisatieid.Value;
                                        if (!entity.sgt_lidmaatschap_vanaf.IsNull)
                                        {
                                            lidmaatschap.Begin = DateTime.Parse(entity.sgt_lidmaatschap_vanaf.Value);
                                        }
                                        if (!entity.sgt_lidmaatschap_beeindigd.IsNull)
                                        {
                                            lidmaatschap.Einde = DateTime.Parse(entity.sgt_lidmaatschap_beeindigd.Value);
                                        }

                                        if (!entity.sgt_datum_opgezegd.IsNull)
                                        {
                                            lidmaatschap.Opzegging = DateTime.Parse(entity.sgt_datum_opgezegd.Value);
                                        }

                                        lidmaatschap.PasNieuw = entity.sgt_nieuwe_pas_nodig.Value;
                                        lidmaatschap.PasTypeNaam = entity.sgt_pastypeid.name;
                                        //lidmaatschap.PasTypeId = entity.sgt_pastypeid.type;
                                        lidmaatschap.PasTypeId = entity.sgt_pastypeid.Value;
                                        lidmaatschap.PasWedstrijd = entity.sgt_wedstrijdpas.Value;
                                        lidmaatschap.PasVolgnummer = entity.sgt_volgnummer_pas;
                                        lidmaatschap.PasNood = entity.sgt_noodpas_nodig.Value;

                                        if (!entity.sgt_datum_laatste_noodpas.IsNull)
                                        {
                                            lidmaatschap.PasNoodDatum = DateTime.Parse(entity.sgt_datum_laatste_noodpas.Value);
                                        }

                                        lidmaatschap.PasDatum = DateTime.Parse(entity.sgt_datum_laatste_pas.Value);

                                        lidmaatschap.SpeelsterkteDubbel = entity.sgt_speelsterkte_dubbel.Value;
                                        lidmaatschap.SpeelsterkteEnkel = entity.sgt_speelsterkte_enkel.Value;


                                        lidmaatschap.Actief = entity.statuscode.name;

                                    }
                                }
                            }
                        }
                    }
                }
                model.SaveChanges();
            }
            return lidmaatschappen;
        }

        #endregion

        #region Profielen

        /// <summary>
        /// sgt_dss_spelersprofiel
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="refresh"></param>
        /// <returns></returns>
        public List<ClubCloud_Profiel> SpelersProfielen(string bondsnummer, bool refresh = false)
        {
            List<ClubCloud_Profiel> profielen = new List<ClubCloud_Profiel>();

            using (ClubCloud.Service.Model.ClubCloudModelContainer model = new Model.ClubCloudModelContainer(GetConnectionString()))
            {
                profielen = model.ClubCloud_Profielen.Where(p => p.Id != null).ToList();

                if (profielen != null && profielen.Count == 0)
                {
                    ClubCloud_Setting settings = model.ClubCloud_Settings.Find(int.Parse(bondsnummer));

                    if (settings != null && settings.mijnknltb_allow && !string.IsNullOrWhiteSpace(settings.mijnknltb_password))
                    {
                        CookieContainer cc = RequestContainer(settings.Id.ToString(), settings.mijnknltb_password);

                        if (cc != null)
                        {
                            ClubCloud.KNLTB.ServIt.CrmService.CrmService service = new KNLTB.ServIt.CrmService.CrmService(cc);

                            bool moreRecords = true;
                            int pageNum = 1;
                            while (moreRecords)
                            {
                                List<BusinessEntity> entities = RetrieveMultiple(service, "sgt_dss_spelersprofiel", out moreRecords, ref pageNum);

                                foreach (sgt_dss_spelersprofiel entity in entities)
                                {
                                    //entity.sgt_aantal_partij_resultaten_dubbel
                                    //entity.
                                }
                            }
                        }
                    }
                }
            }

            return profielen;
            //sgt_dss_spelersprofiel profiel = new sgt_dss_spelersprofiel();
            //profiel.sgt_aantal_partij_resultaten_dubbel.Value
        }

        /// <summary>
        /// sgt_dss_spelersprofiel
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="profielId"></param>
        /// <param name="refresh"></param>
        /// <returns></returns>
        public ClubCloud_Profiel SpelersProfielById(string bondsnummer, Guid profielId, bool refresh = false)
        {
            ClubCloud_Profiel profiel = new ClubCloud_Profiel();
            using (ClubCloud.Service.Model.ClubCloudModelContainer model = new Model.ClubCloudModelContainer(GetConnectionString()))
            {
                profiel = model.ClubCloud_Profielen.Find(profielId);

                if (profiel == null || refresh)
                {
                    ClubCloud_Setting settings = model.ClubCloud_Settings.Find(int.Parse(bondsnummer));

                    if (settings != null && settings.mijnknltb_allow && !string.IsNullOrWhiteSpace(settings.mijnknltb_password))
                    {
                        CookieContainer cc = RequestContainer(settings.Id.ToString(), settings.mijnknltb_password);

                        if (cc != null)
                        {
                            ClubCloud.KNLTB.ServIt.CrmService.CrmService service = new KNLTB.ServIt.CrmService.CrmService(cc);

                            bool moreRecords = true;
                            int pageNum = 1;
                            while (moreRecords)
                            {
                                ConditionExpression condition = new ConditionExpression { AttributeName = "sgt_dss_spelersprofielid", Operator = ConditionOperator.Equal, Values = new object[1] { profielId } };
                                FilterExpression expression = new FilterExpression { FilterOperator = LogicalOperator.And, Conditions = new ConditionExpression[1] { condition } };

                                List<BusinessEntity> entities = RetrieveMultiple(service, "sgt_dss_spelersprofiel", out moreRecords, ref pageNum, expression);

                                foreach (sgt_dss_spelersprofiel entity in entities)
                                {
                                    profiel.Id = entity.sgt_dss_spelersprofielid.Value;
                                    //entity.sgt_aantal_partij_resultaten_dubbel
                                    //entity.
                                }
                            }
                        }
                    }
                }
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
        public ClubCloud_Profiel SpelersProfielByNummer(string bondsnummer, string nummer, bool refresh = false)
        {
            ClubCloud_Profiel profiel = new ClubCloud_Profiel();

            using (ClubCloud.Service.Model.ClubCloudModelContainer model = new Model.ClubCloudModelContainer(GetConnectionString()))
            {
                profiel = model.ClubCloud_Profielen.SingleOrDefault(p => p.Bondsnummer == nummer);

                if (profiel == null || refresh)
                {
                    ClubCloud_Setting settings = model.ClubCloud_Settings.Find(int.Parse(bondsnummer));

                    if (settings != null && settings.mijnknltb_allow && !string.IsNullOrWhiteSpace(settings.mijnknltb_password))
                    {
                        CookieContainer cc = RequestContainer(settings.Id.ToString(), settings.mijnknltb_password);

                        if (cc != null)
                        {
                            ClubCloud.KNLTB.ServIt.CrmService.CrmService service = new KNLTB.ServIt.CrmService.CrmService(cc);

                            bool moreRecords = true;
                            int pageNum = 1;
                            while (moreRecords)
                            {
                                ConditionExpression condition = new ConditionExpression { AttributeName = "sgt_dss_bondsnummer", Operator = ConditionOperator.Equal, Values = new object[1] { nummer } };
                                FilterExpression expression = new FilterExpression { FilterOperator = LogicalOperator.And, Conditions = new ConditionExpression[1] { condition } };

                                List<BusinessEntity> entities = RetrieveMultiple(service, "sgt_dss_spelersprofiel", out moreRecords, ref pageNum, expression);

                                foreach (sgt_dss_spelersprofiel entity in entities)
                                {
                                    profiel.Id = entity.sgt_dss_spelersprofielid.Value;
                                    //entity.sgt_aantal_partij_resultaten_dubbel
                                    //entity.
                                }
                            }
                        }
                    }
                }
            }
            return profiel;
        }

        /// <summary>
        /// sgt_dss_spelersprofiel
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="gebruikerId"></param>
        /// <param name="refresh"></param>
        /// <returns></returns>
        public ClubCloud_Profiel SpelersProfielByGebruiker(string bondsnummer, Guid gebruikerId, bool refresh = false)
        {
            ClubCloud_Profiel profiel = new ClubCloud_Profiel();
            using (ClubCloud.Service.Model.ClubCloudModelContainer model = new Model.ClubCloudModelContainer(GetConnectionString()))
            {
                profiel = model.ClubCloud_Profielen.SingleOrDefault(p => p.GebruikerId == gebruikerId);

                if (profiel == null || refresh)
                {
                    ClubCloud_Setting settings = model.ClubCloud_Settings.Find(int.Parse(bondsnummer));

                    if (settings != null && settings.mijnknltb_allow && !string.IsNullOrWhiteSpace(settings.mijnknltb_password))
                    {
                        CookieContainer cc = RequestContainer(settings.Id.ToString(), settings.mijnknltb_password);

                        if (cc != null)
                        {
                            ClubCloud.KNLTB.ServIt.CrmService.CrmService service = new KNLTB.ServIt.CrmService.CrmService(cc);

                            bool moreRecords = true;
                            int pageNum = 1;
                            while (moreRecords)
                            {
                                ConditionExpression condition = new ConditionExpression { AttributeName = "sgt_naamid ", Operator = ConditionOperator.Equal, Values = new object[1] { gebruikerId } };
                                FilterExpression expression = new FilterExpression { FilterOperator = LogicalOperator.And, Conditions = new ConditionExpression[1] { condition } };

                                List<BusinessEntity> entities = RetrieveMultiple(service, "sgt_dss_spelersprofiel", out moreRecords, ref pageNum, expression);

                                foreach (sgt_dss_spelersprofiel entity in entities)
                                {
                                    profiel.Id = entity.sgt_dss_spelersprofielid.Value;
                                    //entity.sgt_aantal_partij_resultaten_dubbel
                                    //entity.
                                }
                            }
                        }
                    }
                }
            } return profiel;
        }

        #endregion

        #region Gebruiker

        /// <summary>
        /// account
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="verenigingId"></param>
        /// <param name="refresh"></param>
        /// <returns></returns>
        public List<ClubCloud_Gebruiker> Gebruikers(string bondsnummer, Guid verenigingId, bool refresh = false)
        {
            List<ClubCloud_Gebruiker> gebruikers = new List<ClubCloud_Gebruiker>();

            using (ClubCloud.Service.Model.ClubCloudModelContainer model = new Model.ClubCloudModelContainer(GetConnectionString()))
            {
                gebruikers = model.ClubCloud_Gebruikers.Where(f => f.VerenigingId == verenigingId && f.Actief == Sgt_alg_functionarisState.Active.ToString()).ToList();

                if (gebruikers != null && gebruikers.Count == 0 || refresh)
                {
                    ClubCloud_Setting settings = model.ClubCloud_Settings.Find(int.Parse(bondsnummer));

                    if (settings != null && settings.mijnknltb_allow && !string.IsNullOrWhiteSpace(settings.mijnknltb_password))
                    {
                        CookieContainer cc = RequestContainer(settings.Id.ToString(), settings.mijnknltb_password);

                        if (cc != null)
                        {
                            ClubCloud.KNLTB.ServIt.CrmService.CrmService service = new KNLTB.ServIt.CrmService.CrmService(cc);

                            bool moreRecords = true;
                            int pageNum = 1;
                            while (moreRecords)
                            {
                                ConditionExpression condition = new ConditionExpression { AttributeName = "sgt_primaire_vereniging_id", Operator = ConditionOperator.Equal, Values = new object[1] { verenigingId } };
                                FilterExpression expression = new FilterExpression { FilterOperator = LogicalOperator.And, Conditions = new ConditionExpression[1] { condition } };

                                List<BusinessEntity> entities = RetrieveMultiple(service, "contact", out moreRecords, ref pageNum, expression);

                                foreach (contact entity in entities)
                                {
                                    ClubCloud_Gebruiker gebruiker = model.ClubCloud_Gebruikers.Find(entity.contactid.Value);

                                    if (gebruiker == null)
                                    {
                                        gebruiker = model.ClubCloud_Gebruikers.Create();
                                        gebruiker.Id = entity.contactid.Value;
                                        gebruiker.Bondsnummer = entity.sgt_bondsnummer;
                                        gebruiker.Beschrijving = entity.description;

                                        //gebruiker.EmailGeheim;
                                        gebruiker.EmailKNLTB = entity.emailaddress1;
                                        gebruiker.EmailWebSite = entity.emailaddress2;
                                        gebruiker.EmailOverig = entity.emailaddress3;
                                        
                                        gebruiker.TelefoonGeheim = entity.sgt_telefoon_geheim.Value;
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

                                        gebruiker.Geslacht = (Geslacht)Enum.Parse(typeof(Geslacht), entity.gendercode.name);
                                        gebruiker.Geboortedatum = DateTime.Parse(entity.birthdate.Value);
                                        gebruiker.Geboorteplaats = entity.sgt_geboorteplaats;
                                        gebruiker.OverlijdensDatum = DateTime.Parse(entity.sgt_datum_overleden.Value);
                                        gebruiker.NationaliteitId = entity.sgt_nationaliteitid.Value;
                                        gebruiker.NationaliteitId = entity.sgt_2e_nationaliteitid.Value;

                                        gebruiker.Beroep = entity.jobtitle;
                                        //gebruiker.Kinderen = entity.haschildrencode.Value;
                                        gebruiker.KinderenAantal = entity.numberofchildren.Value;
                                        gebruiker.Partner = entity.spousesname;                                        
                                                                                
                                        gebruiker.AanhefBrief = entity.sgt_aanhef_briefhoofd_nl;
                                        gebruiker.AanhefAttentie = entity.sgt_aanhef_tav_nl;
                                        
                                        gebruiker.FotoId = entity.sgt_fotonummer;


                                        if (entity.sgt_is_functionaris.Value)
                                        {
                                            FunctionarissenByGebruiker(bondsnummer, entity.contactid.Value, true);
                                        }

                                        gebruiker.AddressGeheim = entity.sgt_adres_geheim.Value;
                                        AdresById(bondsnummer, entity.address1_addressid.Value, true);
                                        AdresById(bondsnummer, entity.address2_addressid.Value, true);
                                        
                                        gebruiker.Actief = entity.statuscode.name;

                                        model.ClubCloud_Gebruikers.Add(gebruiker);
                                        UpdateMembershipuser(gebruiker);
                                        gebruikers.Add(gebruiker);

                                    }
                                    else
                                    {
                                        gebruiker.Bondsnummer = entity.sgt_bondsnummer;
                                        gebruiker.Beschrijving = entity.description;

                                        //gebruiker.EmailGeheim;
                                        gebruiker.EmailKNLTB = entity.emailaddress1;
                                        gebruiker.EmailWebSite = entity.emailaddress2;
                                        gebruiker.EmailOverig = entity.emailaddress3;

                                        gebruiker.TelefoonGeheim = entity.sgt_telefoon_geheim.Value;
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

                                        gebruiker.Geslacht = (Geslacht)Enum.Parse(typeof(Geslacht), entity.gendercode.name);
                                        gebruiker.Geboortedatum = DateTime.Parse(entity.birthdate.Value);
                                        gebruiker.Geboorteplaats = entity.sgt_geboorteplaats;
                                        gebruiker.OverlijdensDatum = DateTime.Parse(entity.sgt_datum_overleden.Value);
                                        gebruiker.NationaliteitId = entity.sgt_nationaliteitid.Value;
                                        gebruiker.NationaliteitId = entity.sgt_2e_nationaliteitid.Value;

                                        gebruiker.Beroep = entity.jobtitle;
                                        //gebruiker.Kinderen = entity.haschildrencode.Value;
                                        gebruiker.KinderenAantal = entity.numberofchildren.Value;
                                        gebruiker.Partner = entity.spousesname;

                                        gebruiker.AanhefBrief = entity.sgt_aanhef_briefhoofd_nl;
                                        gebruiker.AanhefAttentie = entity.sgt_aanhef_tav_nl;

                                        gebruiker.FotoId = entity.sgt_fotonummer;


                                        if (entity.sgt_is_functionaris.Value)
                                        {
                                            FunctionarissenByGebruiker(bondsnummer, entity.contactid.Value, true);
                                        }

                                        gebruiker.AddressGeheim = entity.sgt_adres_geheim.Value;
                                        AdresById(bondsnummer, entity.address1_addressid.Value, true);
                                        AdresById(bondsnummer, entity.address2_addressid.Value, true);

                                        gebruiker.Actief = entity.statuscode.name;
                                        UpdateMembershipuser(gebruiker);

                                    }
                                }
                            }
                        }
                    }
                }
                model.SaveChanges();
            }
            return gebruikers;
        }

        /// <summary>
        /// account
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="gebruikerId"></param>
        /// <param name="refresh"></param>
        /// <returns></returns>
        public ClubCloud_Gebruiker GebruikerById(string bondsnummer, Guid gebruikerId, bool refresh = false)
        {
            ClubCloud_Gebruiker gebruiker = new ClubCloud_Gebruiker();

            using (ClubCloud.Service.Model.ClubCloudModelContainer model = new Model.ClubCloudModelContainer(GetConnectionString()))
            {
                gebruiker = model.ClubCloud_Gebruikers.Find(gebruikerId);

                if (gebruiker == null || refresh)
                {
                    ClubCloud_Setting settings = model.ClubCloud_Settings.Find(int.Parse(bondsnummer));

                    if (settings != null && settings.mijnknltb_allow && !string.IsNullOrWhiteSpace(settings.mijnknltb_password))
                    {
                        CookieContainer cc = RequestContainer(settings.Id.ToString(), settings.mijnknltb_password);

                        if (cc != null)
                        {
                            ClubCloud.KNLTB.ServIt.CrmService.CrmService service = new KNLTB.ServIt.CrmService.CrmService(cc);

                            bool moreRecords = true;
                            int pageNum = 1;
                            while (moreRecords)
                            {
                                ConditionExpression condition = new ConditionExpression { AttributeName = "contactid", Operator = ConditionOperator.Equal, Values = new object[1] { gebruikerId } };
                                FilterExpression expression = new FilterExpression { FilterOperator = LogicalOperator.And, Conditions = new ConditionExpression[1] { condition } };

                                List<BusinessEntity> entities = RetrieveMultiple(service, "contact", out moreRecords, ref pageNum, expression);

                                foreach (contact entity in entities)
                                {
                                    gebruiker = model.ClubCloud_Gebruikers.Find(entity.contactid.Value);

                                    if (gebruiker == null)
                                    {
                                        gebruiker = model.ClubCloud_Gebruikers.Create();
                                        gebruiker.Id = entity.contactid.Value;
                                        gebruiker.Bondsnummer = entity.sgt_bondsnummer;
                                        gebruiker.Beschrijving = entity.description;

                                        //gebruiker.EmailGeheim;
                                        gebruiker.EmailKNLTB = entity.emailaddress1;
                                        gebruiker.EmailWebSite = entity.emailaddress2;
                                        gebruiker.EmailOverig = entity.emailaddress3;

                                        gebruiker.TelefoonGeheim = entity.sgt_telefoon_geheim.Value;
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

                                        gebruiker.Geslacht = (Geslacht)Enum.Parse(typeof(Geslacht), entity.gendercode.name);
                                        gebruiker.Geboortedatum = DateTime.Parse(entity.birthdate.Value);
                                        gebruiker.Geboorteplaats = entity.sgt_geboorteplaats;
                                        gebruiker.OverlijdensDatum = DateTime.Parse(entity.sgt_datum_overleden.Value);
                                        gebruiker.NationaliteitId = entity.sgt_nationaliteitid.Value;
                                        gebruiker.NationaliteitId = entity.sgt_2e_nationaliteitid.Value;

                                        gebruiker.Beroep = entity.jobtitle;
                                        //gebruiker.Kinderen = entity.haschildrencode.Value;
                                        gebruiker.KinderenAantal = entity.numberofchildren.Value;
                                        gebruiker.Partner = entity.spousesname;

                                        gebruiker.AanhefBrief = entity.sgt_aanhef_briefhoofd_nl;
                                        gebruiker.AanhefAttentie = entity.sgt_aanhef_tav_nl;

                                        gebruiker.FotoId = entity.sgt_fotonummer;


                                        if (entity.sgt_is_functionaris.Value)
                                        {
                                            FunctionarissenByGebruiker(bondsnummer, entity.contactid.Value, true);
                                        }

                                        gebruiker.AddressGeheim = entity.sgt_adres_geheim.Value;
                                        AdresById(bondsnummer, entity.address1_addressid.Value, true);
                                        AdresById(bondsnummer, entity.address2_addressid.Value, true);

                                        gebruiker.Actief = entity.statuscode.name;

                                        model.ClubCloud_Gebruikers.Add(gebruiker);
                                        UpdateMembershipuser(gebruiker);

                                    }
                                    else
                                    {
                                        gebruiker.Id = entity.contactid.Value;
                                        gebruiker.Bondsnummer = entity.sgt_bondsnummer;
                                        gebruiker.Beschrijving = entity.description;

                                        //gebruiker.EmailGeheim;
                                        gebruiker.EmailKNLTB = entity.emailaddress1;
                                        gebruiker.EmailWebSite = entity.emailaddress2;
                                        gebruiker.EmailOverig = entity.emailaddress3;

                                        gebruiker.TelefoonGeheim = entity.sgt_telefoon_geheim.Value;
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

                                        gebruiker.Geslacht = (Geslacht)Enum.Parse(typeof(Geslacht), entity.gendercode.name);
                                        gebruiker.Geboortedatum = DateTime.Parse(entity.birthdate.Value);
                                        gebruiker.Geboorteplaats = entity.sgt_geboorteplaats;
                                        gebruiker.OverlijdensDatum = DateTime.Parse(entity.sgt_datum_overleden.Value);
                                        gebruiker.NationaliteitId = entity.sgt_nationaliteitid.Value;
                                        gebruiker.NationaliteitId = entity.sgt_2e_nationaliteitid.Value;

                                        gebruiker.Beroep = entity.jobtitle;
                                        //gebruiker.Kinderen = entity.haschildrencode.Value;
                                        gebruiker.KinderenAantal = entity.numberofchildren.Value;
                                        gebruiker.Partner = entity.spousesname;

                                        gebruiker.AanhefBrief = entity.sgt_aanhef_briefhoofd_nl;
                                        gebruiker.AanhefAttentie = entity.sgt_aanhef_tav_nl;

                                        gebruiker.FotoId = entity.sgt_fotonummer;


                                        if (entity.sgt_is_functionaris.Value)
                                        {
                                            FunctionarissenByGebruiker(bondsnummer, entity.contactid.Value, true);
                                        }

                                        gebruiker.AddressGeheim = entity.sgt_adres_geheim.Value;
                                        AdresById(bondsnummer, entity.address1_addressid.Value, true);
                                        AdresById(bondsnummer, entity.address2_addressid.Value, true);

                                        gebruiker.Actief = entity.statuscode.name;
                                        UpdateMembershipuser(gebruiker);

                                    }
                                }
                            }
                        }
                    }
                }

                if (model.ChangeTracker.HasChanges())
                {
                    UpdateMembershipuser(gebruiker);
                }

                model.SaveChanges();
            }
            return gebruiker;
        }

        /// <summary>
        /// account
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="nummer"></param>
        /// <param name="refresh"></param>
        /// <returns></returns>
        public ClubCloud_Gebruiker GebruikerByNummer(string bondsnummer, string nummer, bool refresh = false)
        {
            ClubCloud_Gebruiker gebruiker = new ClubCloud_Gebruiker();
            //sgt_bondsnummer 
            using (ClubCloud.Service.Model.ClubCloudModelContainer model = new Model.ClubCloudModelContainer(GetConnectionString()))
            {
                //TODO
                //gebruiker = model.ClubCloud_Gebruikers.SingleOrDefault(g = > g.Bondsnummer == nummer);

                if (gebruiker == null || refresh)
                {
                    ClubCloud_Setting settings = model.ClubCloud_Settings.Find(int.Parse(bondsnummer));

                    if (settings != null && settings.mijnknltb_allow && !string.IsNullOrWhiteSpace(settings.mijnknltb_password))
                    {
                        CookieContainer cc = RequestContainer(settings.Id.ToString(), settings.mijnknltb_password);

                        if (cc != null)
                        {
                            ClubCloud.KNLTB.ServIt.CrmService.CrmService service = new KNLTB.ServIt.CrmService.CrmService(cc);

                            bool moreRecords = true;
                            int pageNum = 1;
                            while (moreRecords)
                            {
                                ConditionExpression condition = new ConditionExpression { AttributeName = "sgt_bondsnummer", Operator = ConditionOperator.Equal, Values = new object[1] { nummer } };
                                FilterExpression expression = new FilterExpression { FilterOperator = LogicalOperator.And, Conditions = new ConditionExpression[1] { condition } };

                                List<BusinessEntity> entities = RetrieveMultiple(service, "contact", out moreRecords, ref pageNum, expression);

                                foreach (contact entity in entities)
                                {
                                    gebruiker = model.ClubCloud_Gebruikers.Find(entity.contactid.Value);

                                    if (gebruiker == null)
                                    {
                                        gebruiker = model.ClubCloud_Gebruikers.Create();
                                        gebruiker.Id = entity.contactid.Value;
                                        gebruiker.Bondsnummer = entity.sgt_bondsnummer;
                                        gebruiker.Beschrijving = entity.description;

                                        //gebruiker.EmailGeheim;
                                        gebruiker.EmailKNLTB = entity.emailaddress1;
                                        gebruiker.EmailWebSite = entity.emailaddress2;
                                        gebruiker.EmailOverig = entity.emailaddress3;

                                        gebruiker.TelefoonGeheim = entity.sgt_telefoon_geheim.Value;
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

                                        gebruiker.Geslacht = (Geslacht)Enum.Parse(typeof(Geslacht), entity.gendercode.name);
                                        gebruiker.Geboortedatum = DateTime.Parse(entity.birthdate.Value);
                                        gebruiker.Geboorteplaats = entity.sgt_geboorteplaats;
                                        gebruiker.OverlijdensDatum = DateTime.Parse(entity.sgt_datum_overleden.Value);
                                        gebruiker.NationaliteitId = entity.sgt_nationaliteitid.Value;
                                        gebruiker.NationaliteitId = entity.sgt_2e_nationaliteitid.Value;

                                        gebruiker.Beroep = entity.jobtitle;
                                        //gebruiker.Kinderen = entity.haschildrencode.Value;
                                        gebruiker.KinderenAantal = entity.numberofchildren.Value;
                                        gebruiker.Partner = entity.spousesname;

                                        gebruiker.AanhefBrief = entity.sgt_aanhef_briefhoofd_nl;
                                        gebruiker.AanhefAttentie = entity.sgt_aanhef_tav_nl;

                                        gebruiker.FotoId = entity.sgt_fotonummer;


                                        if (entity.sgt_is_functionaris.Value)
                                        {
                                            FunctionarissenByGebruiker(bondsnummer, entity.contactid.Value, true);
                                        }

                                        gebruiker.AddressGeheim = entity.sgt_adres_geheim.Value;
                                        AdresById(bondsnummer, entity.address1_addressid.Value, true);
                                        AdresById(bondsnummer, entity.address2_addressid.Value, true);

                                        gebruiker.Actief = entity.statuscode.name;

                                        model.ClubCloud_Gebruikers.Add(gebruiker);
                                        UpdateMembershipuser(gebruiker);
                                    }
                                    else
                                    {
                                        gebruiker.Bondsnummer = entity.sgt_bondsnummer;
                                        gebruiker.Beschrijving = entity.description;

                                        //gebruiker.EmailGeheim;
                                        gebruiker.EmailKNLTB = entity.emailaddress1;
                                        gebruiker.EmailWebSite = entity.emailaddress2;
                                        gebruiker.EmailOverig = entity.emailaddress3;

                                        gebruiker.TelefoonGeheim = entity.sgt_telefoon_geheim.Value;
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

                                        gebruiker.Geslacht = (Geslacht)Enum.Parse(typeof(Geslacht), entity.gendercode.name);
                                        gebruiker.Geboortedatum = DateTime.Parse(entity.birthdate.Value);
                                        gebruiker.Geboorteplaats = entity.sgt_geboorteplaats;
                                        gebruiker.OverlijdensDatum = DateTime.Parse(entity.sgt_datum_overleden.Value);
                                        gebruiker.NationaliteitId = entity.sgt_nationaliteitid.Value;
                                        gebruiker.NationaliteitId = entity.sgt_2e_nationaliteitid.Value;

                                        gebruiker.Beroep = entity.jobtitle;
                                        //gebruiker.Kinderen = entity.haschildrencode.Value;
                                        gebruiker.KinderenAantal = entity.numberofchildren.Value;
                                        gebruiker.Partner = entity.spousesname;

                                        gebruiker.AanhefBrief = entity.sgt_aanhef_briefhoofd_nl;
                                        gebruiker.AanhefAttentie = entity.sgt_aanhef_tav_nl;

                                        gebruiker.FotoId = entity.sgt_fotonummer;


                                        if (entity.sgt_is_functionaris.Value)
                                        {
                                            FunctionarissenByGebruiker(bondsnummer, entity.contactid.Value, true);
                                        }

                                        gebruiker.AddressGeheim = entity.sgt_adres_geheim.Value;
                                        AdresById(bondsnummer, entity.address1_addressid.Value, true);
                                        AdresById(bondsnummer, entity.address2_addressid.Value, true);

                                        gebruiker.Actief = entity.statuscode.name;
                                        UpdateMembershipuser(gebruiker);

                                    }
                                }
                            }
                        }
                    }
                }
                model.SaveChanges();
            }
            return gebruiker;
        }

        #endregion

        #endregion

        #endregion

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

				SPDatabaseParameters databaseParameters = null;
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

					using (ClubCloud.Service.Model.ClubCloudModelContainer model = new Model.ClubCloudModelContainer(builder.ConnectionString))
					{

						if (model.Database.CreateIfNotExists())
						{
							model.Database.Initialize(true);
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
								using (ClubCloud.Service.Model.ClubCloudModelContainer model = new Model.ClubCloudModelContainer(builder.ConnectionString))
								{
									vereniging = model.ClubCloud_Verenigingen.Add(new ClubCloud_Vereniging { Nummer = verenigingsnummer, Naam = "S.V. Kampong", Id = new Guid("02ada6c7-80f9-4671-91f9-898ea5da3ccd") });
									model.SaveChanges();

									//vereniging = model.ClubCloud_Verenigingen.Find(int.Parse(verenigingsnummer));
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

		

		public string GetPostcode(string postcode, int huisnummer)
		{
			throw new NotImplementedException();
        }
    }
}
