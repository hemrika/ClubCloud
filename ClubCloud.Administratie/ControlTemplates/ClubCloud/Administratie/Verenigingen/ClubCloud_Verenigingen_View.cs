namespace ClubCloud.Administratie.WebControls
{
    
    using ClubCloud.Common.Controls;
    using ClubCloud.Model;
    using ClubCloud.Service;
    using Microsoft.SharePoint;
    using System;
    using System.Linq;
    using System.Collections;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Web.UI;
    using System.Web.UI.Design;
    using System.Web.UI.WebControls;
    using System.Data.Entity.Infrastructure;
    
    //[Designer(typeof(ClubCloud_VerenigingDataSourceViewDesigner)),ToolboxData("<{0}:ClubCloud_Verenigingen_View runat=\"server\"></{0}:ClubCloud_Verenigingen_View>")]
    [System.ComponentModel.DataObject(true)]
    public partial class ClubCloud_Verenigingen_View : ClubCloudDataSourceView
    {
        public ClubCloud_Verenigingen_View(EntityDataSource owner, string viewName) : base(owner, viewName) { }
    
        private ClubCloud.Service.ClubCloudServiceClient _client = null;
    
        public ClubCloud.Service.ClubCloudServiceClient Client
        {
            get
            {
                if (_client == null)
                {
                    _client = new Service.ClubCloudServiceClient(SPServiceContext.Current);
                }
                return _client;
            }
        }
    
        public override bool CanRetrieveTotalRowCount
        {
            get
            {
                return true;
            }
        }
    
        public override bool CanPage
        {
            get
            {
                return true;
            }
        }
    
        public override bool CanSort
        {
            get
            {
                return true;
            }
        }
    
        partial void OnClubCloud_VerenigingSaving(ClubCloud_Vereniging vereniging);
    
        partial void OnClubCloud_VerenigingCreating(ClubCloud_Vereniging vereniging);
        partial void OnClubCloud_VerenigingCreated(ClubCloud_Vereniging vereniging);
    
        partial void OnClubCloud_VerenigingUpdating(ClubCloud_Vereniging vereniging);
        partial void OnClubCloud_VerenigingUpdated(ClubCloud_Vereniging vereniging);
    
        partial void OnClubCloud_VerenigingSaved(ClubCloud_Vereniging vereniging);
    
        partial void OnClubCloud_VerenigingDeleting(ClubCloud_Vereniging vereniging);
        partial void OnClubCloud_VerenigingDeleted(ClubCloud_Vereniging vereniging);
    
    	[System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, true)]
        public ClubCloud_Vereniging SelectVereniging() //(string Id)
        {
    		ClubCloud_Vereniging entity = null;
    
    		if (SPContext.Current.Web.CurrentUser != null)
    		{
    			string userId = SPContext.Current.Web.CurrentUser.UserId.NameId;
    			ClubCloud_Setting Settings = Client.GetClubCloudSettings(userId);
    
    			if (Settings != null && Settings.VerenigingId != null)
    			{
    				Settings.ClubCloud_Vereniging = Client.GetVerenigingById(Settings.VerenigingId.Value,false, Settings);
    
    				if (Settings.ClubCloud_Vereniging != null)
    				{
    					Guid Id = Guid.Empty;
    					foreach (Parameter where in WhereParameters)
    					{
    						if (where.Name == "Id")
    						{
    							if(Guid.TryParse(where.DefaultValue, out Id))
    							{
    								entity = Client.GetVerenigingById(Id, false, Settings);
    
    								if(entity != null || entity.Id != Guid.Empty)
    								{
    
    									entity.ClubCloud_Functionaris  = new System.Collections.ObjectModel.ObservableCollection<ClubCloud_Functionaris>(Client.GetFunctionarissenForVerenigingById(Id, false, Settings));
    									entity.ClubCloud_Lidmaatschap  = new System.Collections.ObjectModel.ObservableCollection<ClubCloud_Lidmaatschap>(Client.GetLidmaatschappenForVerenigingById(Id, false, Settings));
    									entity.ClubCloud_Bestuursorgaan  = new System.Collections.ObjectModel.ObservableCollection<ClubCloud_Bestuursorgaan>(Client.GetBestuursorganenForVerenigingById(Id, false, Settings));
    									entity.ClubCloud_District  = Client.GetDistrictForVerenigingById(Id, false, Settings);
    									entity.ClubCloud_Rechtsvorm  = Client.GetRechtsvormForVerenigingById(Id, false, Settings);
    									entity.ClubCloud_Address  = new System.Collections.ObjectModel.ObservableCollection<ClubCloud_Address>(Client.GetAddressenForVerenigingById(Id, false, Settings));
    									entity.ClubCloud_Regio  = Client.GetRegioForVerenigingById(Id, false, Settings);
    									entity.ClubCloud_Afhang  = new System.Collections.ObjectModel.ObservableCollection<ClubCloud_Afhang>(Client.GetAfhangenForVerenigingById(Id, false, Settings));
    									entity.ClubCloud_Sponsor  = new System.Collections.ObjectModel.ObservableCollection<ClubCloud_Sponsor>(Client.GetSponsorenForVerenigingById(Id, false, Settings));
    									entity.ClubCloud_Baanschema  = new System.Collections.ObjectModel.ObservableCollection<ClubCloud_Baanschema>(Client.GetBaanschemasForVerenigingById(Id, false, Settings));
    									entity.ClubCloud_Lidmaatschapsoort  = new System.Collections.ObjectModel.ObservableCollection<ClubCloud_Lidmaatschapsoort>(Client.GetLidmaatschapsoortenForVerenigingById(Id, false, Settings));
    								}
    							}
    						}
    					}
    
    				}
    
    			}
    		}
    
    
    		return entity;
        }
    
    	[System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, true)]
        public IQueryable<ClubCloud_Vereniging> SelectVerenigingen(string sortByExpression, int startRowIndex, int maximumRows, out int totalRowCount)//, bool retrieveTotalRowCount = true)
        {
            if(SPContext.Current.Web.CurrentUser != null)
            {
                string userId = SPContext.Current.Web.CurrentUser.UserId.NameId;
                ClubCloud_Setting Settings = Client.GetClubCloudSettings(userId);
    
                if(Settings != null && Settings.VerenigingId != null) 
                {
                    List<Parameter> collection = new List<Parameter>();
    
                
    				Settings.ClubCloud_Vereniging = Client.GetVerenigingById(Settings.VerenigingId.Value,false, Settings);
    
    				if(Settings.ClubCloud_Vereniging != null)
    				{
    					Settings.ClubCloud_Vereniging.ClubCloud_Accommodatie = Client.GetAccommodatieById(Settings.ClubCloud_Vereniging.AccommodatieId.Value, false, Settings);
    					if(Settings.ClubCloud_Vereniging.ClubCloud_Accommodatie != null)
    					collection.Add(new Parameter { DefaultValue = "{"+Settings.ClubCloud_Vereniging.ClubCloud_Accommodatie.Id.ToString()+"}" , Name = "AccommodatieId", DbType = DbType.Guid, Direction = ParameterDirection.Input });
    				}
    
                
                    foreach (Parameter where in WhereParameters)
                    {
                        if (collection.Any(w => w.Name == where.Name))
                        {
                            int index = collection.FindIndex(p => p.Name == where.Name);
                            if (index >= 0)
                                collection[index] = where;
                        }
                        else
                        {
                            collection.Add(where);
                        }
                    }
    
    				DataSourceSelectArguments selectArgs = new DataSourceSelectArguments{ MaximumRows = maximumRows, StartRowIndex = startRowIndex, RetrieveTotalRowCount = true, SortExpression = sortByExpression };
                    ClubCloud_Vereniging_View queryresult = Client.GetVerenigingenByQuery(userId, Settings.VerenigingId.Value, new DataSourceSelectArguments{ MaximumRows = maximumRows, StartRowIndex = startRowIndex, RetrieveTotalRowCount = true, SortExpression = sortByExpression }, collection);
    
                    totalRowCount = queryresult.TotalRowCount;
    
    				
    				if(totalRowCount > 0)
    				{
                        foreach (ClubCloud_Vereniging Vereniging in queryresult.ClubCloud_Vereniging)
                        {
    						Vereniging.ClubCloud_Functionaris  = new System.Collections.ObjectModel.ObservableCollection<ClubCloud_Functionaris>(Client.GetFunctionarissenForVerenigingById(Vereniging.Id, false, Settings));
    						Vereniging.ClubCloud_Lidmaatschap  = new System.Collections.ObjectModel.ObservableCollection<ClubCloud_Lidmaatschap>(Client.GetLidmaatschappenForVerenigingById(Vereniging.Id, false, Settings));
    						Vereniging.ClubCloud_Bestuursorgaan  = new System.Collections.ObjectModel.ObservableCollection<ClubCloud_Bestuursorgaan>(Client.GetBestuursorganenForVerenigingById(Vereniging.Id, false, Settings));
    						Vereniging.ClubCloud_District  = Client.GetDistrictForVerenigingById(Vereniging.Id, false, Settings);
    						Vereniging.ClubCloud_Rechtsvorm  = Client.GetRechtsvormForVerenigingById(Vereniging.Id, false, Settings);
    						Vereniging.ClubCloud_Address  = new System.Collections.ObjectModel.ObservableCollection<ClubCloud_Address>(Client.GetAddressenForVerenigingById(Vereniging.Id, false, Settings));
    						Vereniging.ClubCloud_Regio  = Client.GetRegioForVerenigingById(Vereniging.Id, false, Settings);
    						Vereniging.ClubCloud_Afhang  = new System.Collections.ObjectModel.ObservableCollection<ClubCloud_Afhang>(Client.GetAfhangenForVerenigingById(Vereniging.Id, false, Settings));
    						Vereniging.ClubCloud_Sponsor  = new System.Collections.ObjectModel.ObservableCollection<ClubCloud_Sponsor>(Client.GetSponsorenForVerenigingById(Vereniging.Id, false, Settings));
    						Vereniging.ClubCloud_Baanschema  = new System.Collections.ObjectModel.ObservableCollection<ClubCloud_Baanschema>(Client.GetBaanschemasForVerenigingById(Vereniging.Id, false, Settings));
    						Vereniging.ClubCloud_Lidmaatschapsoort  = new System.Collections.ObjectModel.ObservableCollection<ClubCloud_Lidmaatschapsoort>(Client.GetLidmaatschapsoortenForVerenigingById(Vereniging.Id, false, Settings));
                            
                        }
    				}
    				return queryresult.ClubCloud_Vereniging.AsQueryable<ClubCloud_Vereniging>();
                }
            }
    
            totalRowCount = 0;
    		return null;
    	}
    
    	//Functionarissen
    	//Lidmaatschappen
    	//Bestuursorganen
    
    	[System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, true)]
        public IQueryable<ClubCloud_Bestuursorgaan> SelectBestuursorgaan()
        {
            if(SPContext.Current.Web.CurrentUser != null)
            {
                string userId = SPContext.Current.Web.CurrentUser.UserId.NameId;
                ClubCloud_Setting Settings = Client.GetClubCloudSettings(userId);
    
                if(Settings != null && Settings.VerenigingId != null) 
                {
    				List<ClubCloud_Bestuursorgaan> result = Client.GetBestuursorganen(false, Settings);
    				return result.AsQueryable<ClubCloud_Bestuursorgaan>();
    			}
    		}
    
    		return null;
    	}
    	//Districten
    	//Rechtsvormen
    
    	[System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, true)]
        public IQueryable<ClubCloud_Rechtsvorm> SelectRechtsvorm()
        {
            if(SPContext.Current.Web.CurrentUser != null)
            {
                string userId = SPContext.Current.Web.CurrentUser.UserId.NameId;
                ClubCloud_Setting Settings = Client.GetClubCloudSettings(userId);
    
                if(Settings != null && Settings.VerenigingId != null) 
                {
    				List<ClubCloud_Rechtsvorm> result = Client.GetRechtsvormen(false, Settings);
    				return result.AsQueryable<ClubCloud_Rechtsvorm>();
    			}
    		}
    
    		return null;
    	}
    	//Accommodaties
    	//Addressen
    	//Regios
    	//Gebruikers
    	//Afhangen
    	//Sponsoren
    	//Settings
    	//Baanschemas
    	//Lidmaatschapsoorten
    
    	[System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, true)]
        public IQueryable<ClubCloud_Lidmaatschapsoort> SelectLidmaatschapsoort()
        {
            if(SPContext.Current.Web.CurrentUser != null)
            {
                string userId = SPContext.Current.Web.CurrentUser.UserId.NameId;
                ClubCloud_Setting Settings = Client.GetClubCloudSettings(userId);
    
                if(Settings != null && Settings.VerenigingId != null) 
                {
    				List<ClubCloud_Lidmaatschapsoort> result = Client.GetLidmaatschapsoorten(false, Settings);
    				return result.AsQueryable<ClubCloud_Lidmaatschapsoort>();
    			}
    		}
    
    		return null;
    	}
    
    
        [SPDisposeCheckIgnore(SPDisposeCheckID.SPDisposeCheckID_140, "RootWeb disposed automatically")]
    	[System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, true)]
        protected override IEnumerable ExecuteSelect(DataSourceSelectArguments selectArgs)
        {
            DataSet ds = new DataSet("result");
    
            if(SPContext.Current.Web.CurrentUser != null)
            {
                string userId = SPContext.Current.Web.CurrentUser.UserId.NameId;
                ClubCloud_Setting Settings = Client.GetClubCloudSettings(userId);
    
                if(Settings != null && Settings.VerenigingId != null) 
                {
                    List<Parameter> collection = new List<Parameter>();
    
                
    				Settings.ClubCloud_Vereniging = Client.GetVerenigingById(Settings.VerenigingId.Value,false, Settings);
    
    				if(Settings.ClubCloud_Vereniging != null)
    				{
    					Settings.ClubCloud_Vereniging.ClubCloud_Accommodatie = Client.GetAccommodatieById(Settings.ClubCloud_Vereniging.AccommodatieId.Value, false, Settings);
    					if(Settings.ClubCloud_Vereniging.ClubCloud_Accommodatie != null)
    					collection.Add(new Parameter { DefaultValue = "{"+Settings.ClubCloud_Vereniging.ClubCloud_Accommodatie.Id.ToString()+"}" , Name = "AccommodatieId", DbType = DbType.Guid, Direction = ParameterDirection.Input });
    				}
    
                
                    foreach (Parameter where in WhereParameters)
                    {
                        if (collection.Any(w => w.Name == where.Name))
                        {
                            int index = collection.FindIndex(p => p.Name == where.Name);
                            if (index >= 0)
                                collection[index] = where;
                        }
                        else
                        {
                            collection.Add(where);
                        }
                    }
    
                    ClubCloud_Vereniging_View queryresult = Client.GetVerenigingenByQuery(userId, Settings.VerenigingId.Value, selectArgs, collection);
    
                    selectArgs.TotalRowCount = queryresult.TotalRowCount;
    				
    				return (IEnumerable)queryresult.ClubCloud_Vereniging;
                }
            }
    
            //return new DataView();
    		return null;
        }
    
    	[System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Delete, true)]
    	public bool DeleteVereniging(ClubCloud_Vereniging entity)
        { 
            if (SPContext.Current.Web.CurrentUser != null)
            {
                int result;
                ClubCloud_Setting Settings = null;
                if (int.TryParse(SPContext.Current.Web.CurrentUser.UserId.NameId, out result))
                    Settings = Client.GetSettingById(result);
    
                if (Settings != null && Settings.VerenigingId != null)
                {
                    return Client.DeleteVereniging(entity, Settings);
                }
            }
    		return false;
    	}
    
        protected override int ExecuteDelete(IDictionary keys, IDictionary oldValues)
        {
            int count = 0;
            if (SPContext.Current.Web.CurrentUser != null)
            {
                int result;
                ClubCloud_Setting Settings = null;
                if(int.TryParse(SPContext.Current.Web.CurrentUser.UserId.NameId, out result))
                    Settings = Client.GetSettingById(result);
        
                if (Settings != null && Settings.VerenigingId != null)
                {
                    foreach (Object key in keys)
                    {
    					ClubCloud_Vereniging entity = null;
    					if(key == typeof(System.Guid))
    					{
    						entity = Client.GetVerenigingById((System.Guid)key);
    					}
                        bool succes = false;
                        if (entity != null)
                            succes = Client.DeleteVereniging(entity);
                        if (succes)
                            count++;
                    }
                }
            }
            return count;
        }
    
    	[System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Insert, true)]
    	public virtual System.Guid InsertVereniging(ClubCloud_Vereniging entity)
    	{
            if (SPContext.Current.Web.CurrentUser != null)
            {
                int result;
                ClubCloud_Setting Settings = null;
                if (int.TryParse(SPContext.Current.Web.CurrentUser.UserId.NameId, out result))
                    Settings = Client.GetSettingById(result);
    
                if (Settings != null && Settings.VerenigingId != null)
                {
                    entity = Client.SetVereniging(entity, Settings);
                }
            }
    		return entity.Id;
    	}
    
    
        protected override int ExecuteInsert(IDictionary values)
        {
            int count = 0;
    
            if (SPContext.Current.Web.CurrentUser != null)
            {
                int result;
                ClubCloud_Setting Settings = null;
                if(int.TryParse(SPContext.Current.Web.CurrentUser.UserId.NameId, out result))
                    Settings = Client.GetSettingById(result);
        
                if (Settings != null && Settings.VerenigingId != null)
                {
        
                }
    		}
    
            return count;
        }
    
        [System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, true)]
        public void UpdateVereniging(ClubCloud_Vereniging entity) 
    	{
            if (SPContext.Current.Web.CurrentUser != null)
            {
                int result;
                ClubCloud_Setting Settings = null;
                if (int.TryParse(SPContext.Current.Web.CurrentUser.UserId.NameId, out result))
                    Settings = Client.GetSettingById(result);
    
                if (Settings != null && Settings.VerenigingId != null)
                {
    				Settings.ClubCloud_Vereniging = Client.GetVerenigingById(Settings.VerenigingId.Value,false, Settings);
    				if(Settings.ClubCloud_Vereniging != null)
    				{
    					entity.AccommodatieId = Settings.ClubCloud_Vereniging.AccommodatieId.Value;
    				}
                    Client.SetVereniging(entity, Settings);
                }
            }
    	}
    
        protected override int ExecuteUpdate(IDictionary keys, IDictionary values, IDictionary oldValues)
        {
            int count = 0;
    
            if (SPContext.Current.Web.CurrentUser != null)
            {
                int result;
                ClubCloud_Setting Settings = null;
                if(int.TryParse(SPContext.Current.Web.CurrentUser.UserId.NameId, out result))
                    Settings = Client.GetSettingById(result);
        
                if (Settings != null && Settings.VerenigingId != null)
                {
        
                }
            }
    
            return count;
        }
    
        protected override int ExecuteCommand(string commandName, IDictionary keys, IDictionary values)
        {
            return base.ExecuteCommand(commandName, keys, values);
        }
    }
    
    //public class Vereniging : ClubCloud_Vereniging {}
    
    public class ClubCloud_VerenigingDataSourceViewDesigner : DesignerDataSourceView
    {
        private List<ClubCloud_Vereniging> _data = null;
    
        public ClubCloud_VerenigingDataSourceViewDesigner(DataSourceDesigner owner, string viewName)
            : base(owner, viewName)
        {}
    
        public override IEnumerable GetDesignTimeData(
            int minimumRows, out bool isSampleData)
        {
            if (_data == null)
            {
                // Create a set of design-time fake data
                _data = new List<ClubCloud_Vereniging>();
                for (int i = 1; i <= minimumRows; i++)
                {
                    _data.Add(new ClubCloud_Vereniging { Id = Guid.NewGuid() });
                }
            }
            isSampleData = true;
            return _data as IEnumerable;
        }
    
        //public override IDataSourceViewSchema Schema
        //{
        //    get { return new ClubCloud_Vereniging(); }
        //}
    
        public override bool CanRetrieveTotalRowCount
        {
            get { return true; }
        }
    
        public override bool CanDelete
        {
            get { return true; }
        }
    
        public override bool CanInsert
        {
            get { return true; }
        }
    
        public override bool CanUpdate
        {
            get { return true; }
        }
    
        public override bool CanPage
        {
            get { return true; }
        }
    
        public override bool CanSort
        {
            get { return true; }
        }
    }
    
}
