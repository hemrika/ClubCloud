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
    using System.Web.ModelBinding;
    
    //[Designer(typeof(ClubCloud_BaanschemaDataSourceViewDesigner)),ToolboxData("<{0}:ClubCloud_Baanschemas_View runat=\"server\"></{0}:ClubCloud_Baanschemas_View>")]
    [System.ComponentModel.DataObject(true)]
    public partial class ClubCloud_Baanschemas_View : ClubCloudDataSourceView
    {
        public ClubCloud_Baanschemas_View(EntityDataSource owner, string viewName) : base(owner, viewName) { }
    
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
    
    	/*
        partial void OnClubCloud_BaanschemaSaving(ClubCloud_Baanschema baanschema);
    
        partial void OnClubCloud_BaanschemaCreating(ClubCloud_Baanschema baanschema);
        partial void OnClubCloud_BaanschemaCreated(ClubCloud_Baanschema baanschema);
    
        partial void OnClubCloud_BaanschemaUpdating(ClubCloud_Baanschema baanschema);
        partial void OnClubCloud_BaanschemaUpdated(ClubCloud_Baanschema baanschema);
    
        partial void OnClubCloud_BaanschemaSaved(ClubCloud_Baanschema baanschema);
    
        partial void OnClubCloud_BaanschemaDeleting(ClubCloud_Baanschema baanschema);
        partial void OnClubCloud_BaanschemaDeleted(ClubCloud_Baanschema baanschema);
    	*/
    
    	[System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, true)]
        public ClubCloud_Baanschema SelectBaanschema([QueryString] Guid? Id) //(string Id)
        {
    		ClubCloud_Baanschema entity = null;
    
    		if (SPContext.Current.Web.CurrentUser != null)
    		{
                int bondsnummer;
                ClubCloud_Setting Settings = null;
                if (int.TryParse(SPContext.Current.Web.CurrentUser.UserId.NameId, out bondsnummer))
                    Settings = Client.GetSettingById(bondsnummer);
    
    			if (Settings != null && Settings.VerenigingId != null)
    			{
    				Settings.ClubCloud_Vereniging = Client.GetVerenigingById(Settings.VerenigingId.Value,false, Settings);
    
    				if (Settings.ClubCloud_Vereniging != null)
    				{
    
    				    if (Id == null)
                        {
                            Guid queryId = Guid.Empty;
                            foreach (Parameter where in WhereParameters)
                            {
                                if (where.Name == "Id")
                                {
                                    if (Guid.TryParse(where.DefaultValue, out queryId))
                                    {
                                        break;
                                    }
                                }
                            }
    
                            Id = queryId;
                        }
    
    					if(Id == Guid.Empty)
    					{
    										
    					}
    
    					entity = Client.GetBaanschemaById(Id.Value, false, Settings);
    
    					if(entity != null || entity.Id != Guid.Empty)
    					{
    						entity.ClubCloud_Baan  = Client.GetBaanForBaanschemaById(Id.Value, false, Settings);
    						entity.ClubCloud_Vereniging  = Client.GetVerenigingForBaanschemaById(Id.Value, false, Settings);
    					}
    				}
    			}
    		}
    
    		return entity;
        }
    
    	[System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Fill, true)]
        public IQueryable<ClubCloud_Baanschema> SelectBaanschemas(string sortByExpression, int startRowIndex, int maximumRows, out int totalRowCount)//, bool retrieveTotalRowCount = true)
        {
            if(SPContext.Current.Web.CurrentUser != null)
            {
                int bondsnummer;
                ClubCloud_Setting Settings = null;
                if (int.TryParse(SPContext.Current.Web.CurrentUser.UserId.NameId, out bondsnummer))
                    Settings = Client.GetSettingById(bondsnummer);
    
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
                    ClubCloud_Baanschema_View queryresult = Client.GetBaanschemasByQuery(bondsnummer.ToString(), Settings.VerenigingId.Value, new DataSourceSelectArguments{ MaximumRows = maximumRows, StartRowIndex = startRowIndex, RetrieveTotalRowCount = true, SortExpression = sortByExpression }, collection);
    
                    totalRowCount = queryresult.TotalRowCount;
    
    				
    				if(totalRowCount > 0)
    				{
                        foreach (ClubCloud_Baanschema Baanschema in queryresult.ClubCloud_Baanschema)
                        {
    						Baanschema.ClubCloud_Baan  = Client.GetBaanForBaanschemaById(Baanschema.Id, false, Settings);
    						Baanschema.ClubCloud_Vereniging  = Client.GetVerenigingForBaanschemaById(Baanschema.Id, false, Settings);
                            
                        }
    				}
    				return queryresult.ClubCloud_Baanschema.AsQueryable<ClubCloud_Baanschema>();
                }
            }
    
            totalRowCount = 0;
    		return null;
    	}
    
    
    	[System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, true)]
        public IQueryable<ClubCloud_Baan> SelectBaan()
        {
            if(SPContext.Current.Web.CurrentUser != null)
            {
                int bondsnummer;
                ClubCloud_Setting Settings = null;
                if (int.TryParse(SPContext.Current.Web.CurrentUser.UserId.NameId, out bondsnummer))
                    Settings = Client.GetSettingById(bondsnummer);
    
                if(Settings != null && Settings.VerenigingId != null) 
                {
    				List<ClubCloud_Baan> result = null;
    
    				//Get By ClubCloud_Accommodatie
    				Settings.ClubCloud_Vereniging = Client.GetVerenigingById(Settings.VerenigingId.Value,false, Settings);
    				result = Client.GetBanenForAccommodatieById(Settings.ClubCloud_Vereniging.AccommodatieId.Value, false, Settings);
    
    
    				if(result == null)
    				{
    					result = Client.GetBanen(false, Settings);
    				
    				}
    
                    //Default
                    result = result.OrderBy(r => r.Naam).ToList();    				
                    result.Insert(0, new ClubCloud_Baan { Naam = "Onbekend" });
        
        			return result.AsQueryable<ClubCloud_Baan>();
    			}
    		}
    
    		return null;
    	}
    
    
    	//public Hashtable SelectMaandBegin()
    	[System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, true)]    
    	public IQueryable<DictionaryEntry> SelectMaandBegin()
        {
            if(SPContext.Current.Web.CurrentUser != null)
            {
                int bondsnummer;
                ClubCloud_Setting Settings = null;
                if (int.TryParse(SPContext.Current.Web.CurrentUser.UserId.NameId, out bondsnummer))
                    Settings = Client.GetSettingById(bondsnummer);
    
    			if(Settings != null && Settings.VerenigingId != null) 
                {
                    List<DictionaryEntry> result = new List<DictionaryEntry>();
                	Array values = Enum.GetValues(typeof(MonthSoort));
                    Array.Sort(values);
                    foreach (int value in values)
                    {
                        result.Add(new DictionaryEntry(value, (MonthSoort)value));
                    }
                    return result.AsQueryable<DictionaryEntry>();
        		}
    			/*
                if(Settings != null && Settings.VerenigingId != null) 
                {
                    Hashtable ht = new Hashtable();
    				ht.Add(string.Empty,"Onbekend");
        			Array values = Enum.GetValues(typeof(MonthSoort));
                    Array.Sort(values);
                    foreach (int value in values)
                    {
                        string name = ((MonthSoort)value).ToString();
                        ht.Add(name,name);
                    }    
        			return ht;
    			}
    			*/
    		}
    
    		return null;
    	}
    	//public Hashtable SelectMaandEinde()
    	[System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, true)]    
    	public IQueryable<DictionaryEntry> SelectMaandEinde()
        {
            if(SPContext.Current.Web.CurrentUser != null)
            {
                int bondsnummer;
                ClubCloud_Setting Settings = null;
                if (int.TryParse(SPContext.Current.Web.CurrentUser.UserId.NameId, out bondsnummer))
                    Settings = Client.GetSettingById(bondsnummer);
    
    			if(Settings != null && Settings.VerenigingId != null) 
                {
                    List<DictionaryEntry> result = new List<DictionaryEntry>();
                	Array values = Enum.GetValues(typeof(MonthSoort));
                    Array.Sort(values);
                    foreach (int value in values)
                    {
                        result.Add(new DictionaryEntry(value, (MonthSoort)value));
                    }
                    return result.AsQueryable<DictionaryEntry>();
        		}
    			/*
                if(Settings != null && Settings.VerenigingId != null) 
                {
                    Hashtable ht = new Hashtable();
    				ht.Add(string.Empty,"Onbekend");
        			Array values = Enum.GetValues(typeof(MonthSoort));
                    Array.Sort(values);
                    foreach (int value in values)
                    {
                        string name = ((MonthSoort)value).ToString();
                        ht.Add(name,name);
                    }    
        			return ht;
    			}
    			*/
    		}
    
    		return null;
    	}
    	//public Hashtable SelectDag()
    	[System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, true)]    
    	public IQueryable<DictionaryEntry> SelectDag()
        {
            if(SPContext.Current.Web.CurrentUser != null)
            {
                int bondsnummer;
                ClubCloud_Setting Settings = null;
                if (int.TryParse(SPContext.Current.Web.CurrentUser.UserId.NameId, out bondsnummer))
                    Settings = Client.GetSettingById(bondsnummer);
    
    			if(Settings != null && Settings.VerenigingId != null) 
                {
                    List<DictionaryEntry> result = new List<DictionaryEntry>();
                	Array values = Enum.GetValues(typeof(DaysSoort));
                    Array.Sort(values);
                    foreach (int value in values)
                    {
                        result.Add(new DictionaryEntry(value, (DaysSoort)value));
                    }
                    return result.AsQueryable<DictionaryEntry>();
        		}
    			/*
                if(Settings != null && Settings.VerenigingId != null) 
                {
                    Hashtable ht = new Hashtable();
    				ht.Add(string.Empty,"Onbekend");
        			Array values = Enum.GetValues(typeof(DaysSoort));
                    Array.Sort(values);
                    foreach (int value in values)
                    {
                        string name = ((DaysSoort)value).ToString();
                        ht.Add(name,name);
                    }    
        			return ht;
    			}
    			*/
    		}
    
    		return null;
    	}
    
    	/*
        [SPDisposeCheckIgnore(SPDisposeCheckID.SPDisposeCheckID_140, "RootWeb disposed automatically")]
    	[System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, true)]
        protected override IEnumerable ExecuteSelect(DataSourceSelectArguments selectArgs)
        {
            if(SPContext.Current.Web.CurrentUser != null)
            {
                int bondsnummer;
                ClubCloud_Setting Settings = null;
                if (int.TryParse(SPContext.Current.Web.CurrentUser.UserId.NameId, out bondsnummer))
                    Settings = Client.GetSettingById(bondsnummer);
    
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
    
                    ClubCloud_Baanschema_View queryresult = Client.GetBaanschemasByQuery(userId, Settings.VerenigingId.Value, selectArgs, collection);
    
                    selectArgs.TotalRowCount = queryresult.TotalRowCount;
    				
    				return (IEnumerable)queryresult.ClubCloud_Baanschema;
                }
            }
    
            //return new DataView();
    		return null;
        }
    	*/
    
    	[System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Delete, true)]
    	public bool DeleteBaanschema(ClubCloud_Baanschema entity)
        { 
            if (SPContext.Current.Web.CurrentUser != null)
            {
                int bondsnummer;
                ClubCloud_Setting Settings = null;
                if (int.TryParse(SPContext.Current.Web.CurrentUser.UserId.NameId, out bondsnummer))
                    Settings = Client.GetSettingById(bondsnummer);
    
                if (Settings != null && Settings.VerenigingId != null)
                {
                    return Client.DeleteBaanschema(entity, Settings);
                }
            }
    		return false;
    	}
    
    	/*
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
    					ClubCloud_Baanschema entity = null;
    					if(key == typeof(System.Guid))
    					{
    						entity = Client.GetBaanschemaById((System.Guid)key);
    					}
                        bool succes = false;
                        if (entity != null)
                            succes = Client.DeleteBaanschema(entity);
                        if (succes)
                            count++;
                    }
                }
            }
            return count;
        }
    	*/
    
    	[System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Insert, true)]
    	public int InsertBaanschema(ClubCloud_Baanschema entity)
    	{
            if (SPContext.Current.Web.CurrentUser != null)
            {
                int bondsnummer;
                ClubCloud_Setting Settings = null;
                if (int.TryParse(SPContext.Current.Web.CurrentUser.UserId.NameId, out bondsnummer))
                    Settings = Client.GetSettingById(bondsnummer);
    
                if (Settings != null && Settings.VerenigingId != null)
                {
    				entity.VerenigingId = Settings.VerenigingId.Value;
                    entity = Client.SetBaanschema(entity, Settings);
    				this.OnDataSourceViewChanged(EventArgs.Empty);
                }
            }
    
    		return 1;
    	}
    
    	/*
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
    	*/
    
        [System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, true)]
        public void UpdateBaanschema(ClubCloud_Baanschema entity) 
    	{
            if (SPContext.Current.Web.CurrentUser != null)
            {
                int bondsnummer;
                ClubCloud_Setting Settings = null;
                if (int.TryParse(SPContext.Current.Web.CurrentUser.UserId.NameId, out bondsnummer))
                    Settings = Client.GetSettingById(bondsnummer);
    
                if (Settings != null && Settings.VerenigingId != null)
                {
    				entity.VerenigingId = Settings.VerenigingId.Value;
                    Client.SetBaanschema(entity, Settings);
    				this.OnDataSourceViewChanged(EventArgs.Empty);
                }
            }
    	}
    
    	/*
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
    	*/
    
    	/*
        protected override int ExecuteCommand(string commandName, IDictionary keys, IDictionary values)
        {
            return base.ExecuteCommand(commandName, keys, values);
        }
    	*/
    
        public override void Insert(IDictionary values, DataSourceViewOperationCallback callback)
        {
            base.Insert(values, callback);
        }
    
        public override void Delete(IDictionary keys, IDictionary oldValues, DataSourceViewOperationCallback callback)
        {
            base.Delete(keys, oldValues, callback);
        }
    
        public override void Select(DataSourceSelectArguments arguments, DataSourceViewSelectCallback callback)
        {
            base.Select(arguments, callback);
        }
    
        public override void Update(IDictionary keys, IDictionary values, IDictionary oldValues, DataSourceViewOperationCallback callback)
        {
            base.Update(keys, values, oldValues, callback);
        }
    }
    
    //public class Baanschema : ClubCloud_Baanschema {}
    
    public class ClubCloud_BaanschemaDataSourceViewDesigner : DesignerDataSourceView
    {
        private List<ClubCloud_Baanschema> _data = null;
    
        public ClubCloud_BaanschemaDataSourceViewDesigner(DataSourceDesigner owner, string viewName)
            : base(owner, viewName)
        {}
    
        public override IEnumerable GetDesignTimeData(
            int minimumRows, out bool isSampleData)
        {
            if (_data == null)
            {
                // Create a set of design-time fake data
                _data = new List<ClubCloud_Baanschema>();
                for (int i = 1; i <= minimumRows; i++)
                {
                    _data.Add(new ClubCloud_Baanschema { Id = Guid.NewGuid() });
                }
            }
            isSampleData = true;
            return _data as IEnumerable;
        }
    
        //public override IDataSourceViewSchema Schema
        //{
        //    get { return new ClubCloud_Baanschema(); }
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
