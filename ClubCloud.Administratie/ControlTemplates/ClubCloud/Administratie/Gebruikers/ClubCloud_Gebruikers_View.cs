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
    
    //[Designer(typeof(ClubCloud_GebruikerDataSourceViewDesigner)),ToolboxData("<{0}:ClubCloud_Gebruikers_View runat=\"server\"></{0}:ClubCloud_Gebruikers_View>")]
    [System.ComponentModel.DataObject(true)]
    public partial class ClubCloud_Gebruikers_View : ClubCloudDataSourceView
    {
        public ClubCloud_Gebruikers_View(EntityDataSource owner, string viewName) : base(owner, viewName) { }
    
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
    
        partial void OnClubCloud_GebruikerSaving(ClubCloud_Gebruiker gebruiker);
    
        partial void OnClubCloud_GebruikerCreating(ClubCloud_Gebruiker gebruiker);
        partial void OnClubCloud_GebruikerCreated(ClubCloud_Gebruiker gebruiker);
    
        partial void OnClubCloud_GebruikerUpdating(ClubCloud_Gebruiker gebruiker);
        partial void OnClubCloud_GebruikerUpdated(ClubCloud_Gebruiker gebruiker);
    
        partial void OnClubCloud_GebruikerSaved(ClubCloud_Gebruiker gebruiker);
    
        partial void OnClubCloud_GebruikerDeleting(ClubCloud_Gebruiker gebruiker);
        partial void OnClubCloud_GebruikerDeleted(ClubCloud_Gebruiker gebruiker);
    
    	[System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, true)]
        public ClubCloud_Gebruiker SelectGebruiker() //(string Id)
        {
    		ClubCloud_Gebruiker entity = null;
    
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
    								entity = Client.GetGebruikerById(Id, false, Settings);
    
    								if(entity != null || entity.Id != Guid.Empty)
    								{
    
    									entity.ClubCloud_Functionaris  = new System.Collections.ObjectModel.ObservableCollection<ClubCloud_Functionaris>(Client.GetFunctionarissenForGebruikerById(Id, false, Settings));
    									entity.ClubCloud_Lidmaatschap  = new System.Collections.ObjectModel.ObservableCollection<ClubCloud_Lidmaatschap>(Client.GetLidmaatschappenForGebruikerById(Id, false, Settings));
    									entity.ClubCloud_Address  = new System.Collections.ObjectModel.ObservableCollection<ClubCloud_Address>(Client.GetAddressenForGebruikerById(Id, false, Settings));
    									entity.ClubCloud_Profiel  = new System.Collections.ObjectModel.ObservableCollection<ClubCloud_Profiel>(Client.GetProfielenForGebruikerById(Id, false, Settings));
    									entity.ClubCloud_Nationaliteit  = Client.GetNationaliteitForGebruikerById(Id, false, Settings);
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
        public IQueryable<ClubCloud_Gebruiker> SelectGebruikers(string sortByExpression, int startRowIndex, int maximumRows, out int totalRowCount)//, bool retrieveTotalRowCount = true)
        {
            if(SPContext.Current.Web.CurrentUser != null)
            {
                string userId = SPContext.Current.Web.CurrentUser.UserId.NameId;
                ClubCloud_Setting Settings = Client.GetClubCloudSettings(userId);
    
                if(Settings != null && Settings.VerenigingId != null) 
                {
                    List<Parameter> collection = new List<Parameter>();
    
                
    				collection.Add(new Parameter { DefaultValue = "{"+Settings.VerenigingId.Value.ToString()+"}" , Name = "VerenigingId", DbType = DbType.Guid, Direction = ParameterDirection.Input });
            
    		    
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
                    ClubCloud_Gebruiker_View queryresult = Client.GetGebruikersByQuery(userId, Settings.VerenigingId.Value, new DataSourceSelectArguments{ MaximumRows = maximumRows, StartRowIndex = startRowIndex, RetrieveTotalRowCount = true, SortExpression = sortByExpression }, collection);
    
                    totalRowCount = queryresult.TotalRowCount;
    
    				
    				if(totalRowCount > 0)
    				{
                        foreach (ClubCloud_Gebruiker Gebruiker in queryresult.ClubCloud_Gebruiker)
                        {
    						Gebruiker.ClubCloud_Functionaris  = new System.Collections.ObjectModel.ObservableCollection<ClubCloud_Functionaris>(Client.GetFunctionarissenForGebruikerById(Gebruiker.Id, false, Settings));
    						Gebruiker.ClubCloud_Lidmaatschap  = new System.Collections.ObjectModel.ObservableCollection<ClubCloud_Lidmaatschap>(Client.GetLidmaatschappenForGebruikerById(Gebruiker.Id, false, Settings));
    						Gebruiker.ClubCloud_Address  = new System.Collections.ObjectModel.ObservableCollection<ClubCloud_Address>(Client.GetAddressenForGebruikerById(Gebruiker.Id, false, Settings));
    						Gebruiker.ClubCloud_Profiel  = new System.Collections.ObjectModel.ObservableCollection<ClubCloud_Profiel>(Client.GetProfielenForGebruikerById(Gebruiker.Id, false, Settings));
    						Gebruiker.ClubCloud_Nationaliteit  = Client.GetNationaliteitForGebruikerById(Gebruiker.Id, false, Settings);
                            
                        }
    				}
    				return queryresult.ClubCloud_Gebruiker.AsQueryable<ClubCloud_Gebruiker>();
                }
            }
    
            totalRowCount = 0;
    		return null;
    	}
    
    	//Functionarissen
    	//Lidmaatschappen
    	//Addressen
    	//Verenigingen
    	//Profielen
    	//Reserveringen
    	//Reserveringen
    	//Reserveringen
    	//Reserveringen
    	//Settings
    	//Nationaliteiten
    
    	[System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, true)]
        public IQueryable<ClubCloud_Nationaliteit> SelectNationaliteit()
        {
            if(SPContext.Current.Web.CurrentUser != null)
            {
                string userId = SPContext.Current.Web.CurrentUser.UserId.NameId;
                ClubCloud_Setting Settings = Client.GetClubCloudSettings(userId);
    
                if(Settings != null && Settings.VerenigingId != null) 
                {
    				List<ClubCloud_Nationaliteit> result = Client.GetNationaliteiten(false, Settings);
    				return result.AsQueryable<ClubCloud_Nationaliteit>();
    			}
    		}
    
    		return null;
    	}
    
    	[System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, true)]
        public Hashtable SelectGeslacht()
        {
            if(SPContext.Current.Web.CurrentUser != null)
            {
                string userId = SPContext.Current.Web.CurrentUser.UserId.NameId;
                ClubCloud_Setting Settings = Client.GetClubCloudSettings(userId);
    
                if(Settings != null && Settings.VerenigingId != null) 
                {
    				string[] names = Enum.GetNames(typeof(GeslachtSoort));
    				Array values = Enum.GetValues(typeof(GeslachtSoort));
    				Hashtable ht = new Hashtable();
    				for (int i = 0; i < names.Length; i++)
    					ht.Add(names[i], names[i]);//(int)values.GetValue(i));
    
    				return ht;
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
    
                
    				collection.Add(new Parameter { DefaultValue = "{"+Settings.VerenigingId.Value.ToString()+"}" , Name = "VerenigingId", DbType = DbType.Guid, Direction = ParameterDirection.Input });
            
    		    
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
    
                    ClubCloud_Gebruiker_View queryresult = Client.GetGebruikersByQuery(userId, Settings.VerenigingId.Value, selectArgs, collection);
    
                    selectArgs.TotalRowCount = queryresult.TotalRowCount;
    				
    				return (IEnumerable)queryresult.ClubCloud_Gebruiker;
                }
            }
    
            //return new DataView();
    		return null;
        }
    
    	[System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Delete, true)]
    	public bool DeleteGebruiker(ClubCloud_Gebruiker entity)
        { 
            if (SPContext.Current.Web.CurrentUser != null)
            {
                int result;
                ClubCloud_Setting Settings = null;
                if (int.TryParse(SPContext.Current.Web.CurrentUser.UserId.NameId, out result))
                    Settings = Client.GetSettingById(result);
    
                if (Settings != null && Settings.VerenigingId != null)
                {
                    return Client.DeleteGebruiker(entity, Settings);
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
    					ClubCloud_Gebruiker entity = null;
    					if(key == typeof(System.Guid))
    					{
    						entity = Client.GetGebruikerById((System.Guid)key);
    					}
                        bool succes = false;
                        if (entity != null)
                            succes = Client.DeleteGebruiker(entity);
                        if (succes)
                            count++;
                    }
                }
            }
            return count;
        }
    
    	[System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Insert, true)]
    	public virtual System.Guid InsertGebruiker(ClubCloud_Gebruiker entity)
    	{
            if (SPContext.Current.Web.CurrentUser != null)
            {
                int result;
                ClubCloud_Setting Settings = null;
                if (int.TryParse(SPContext.Current.Web.CurrentUser.UserId.NameId, out result))
                    Settings = Client.GetSettingById(result);
    
                if (Settings != null && Settings.VerenigingId != null)
                {
                    entity = Client.SetGebruiker(entity, Settings);
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
        public void UpdateGebruiker(ClubCloud_Gebruiker entity) 
    	{
            if (SPContext.Current.Web.CurrentUser != null)
            {
                int result;
                ClubCloud_Setting Settings = null;
                if (int.TryParse(SPContext.Current.Web.CurrentUser.UserId.NameId, out result))
                    Settings = Client.GetSettingById(result);
    
                if (Settings != null && Settings.VerenigingId != null)
                {
    				entity.VerenigingId = Settings.VerenigingId.Value;
                    Client.SetGebruiker(entity, Settings);
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
    
    //public class Gebruiker : ClubCloud_Gebruiker {}
    
    public class ClubCloud_GebruikerDataSourceViewDesigner : DesignerDataSourceView
    {
        private List<ClubCloud_Gebruiker> _data = null;
    
        public ClubCloud_GebruikerDataSourceViewDesigner(DataSourceDesigner owner, string viewName)
            : base(owner, viewName)
        {}
    
        public override IEnumerable GetDesignTimeData(
            int minimumRows, out bool isSampleData)
        {
            if (_data == null)
            {
                // Create a set of design-time fake data
                _data = new List<ClubCloud_Gebruiker>();
                for (int i = 1; i <= minimumRows; i++)
                {
                    _data.Add(new ClubCloud_Gebruiker { Id = Guid.NewGuid() });
                }
            }
            isSampleData = true;
            return _data as IEnumerable;
        }
    
        //public override IDataSourceViewSchema Schema
        //{
        //    get { return new ClubCloud_Gebruiker(); }
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