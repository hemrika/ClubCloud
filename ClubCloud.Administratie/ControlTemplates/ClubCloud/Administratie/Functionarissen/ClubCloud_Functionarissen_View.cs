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
    using Microsoft.SharePoint.Utilities;
    
    //[Designer(typeof(ClubCloud_FunctionarisDataSourceViewDesigner)),ToolboxData("<{0}:ClubCloud_Functionarissen_View runat=\"server\"></{0}:ClubCloud_Functionarissen_View>")]
    [System.ComponentModel.DataObject(true)]
    public partial class ClubCloud_Functionarissen_View : ClubCloudDataSourceView
    {
        public ClubCloud_Functionarissen_View(EntityDataSource owner, string viewName) : base(owner, viewName) { }
    
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
        partial void OnClubCloud_FunctionarisSaving(ClubCloud_Functionaris functionaris);
    
        partial void OnClubCloud_FunctionarisCreating(ClubCloud_Functionaris functionaris);
        partial void OnClubCloud_FunctionarisCreated(ClubCloud_Functionaris functionaris);
    
        partial void OnClubCloud_FunctionarisUpdating(ClubCloud_Functionaris functionaris);
        partial void OnClubCloud_FunctionarisUpdated(ClubCloud_Functionaris functionaris);
    
        partial void OnClubCloud_FunctionarisSaved(ClubCloud_Functionaris functionaris);
    
        partial void OnClubCloud_FunctionarisDeleting(ClubCloud_Functionaris functionaris);
        partial void OnClubCloud_FunctionarisDeleted(ClubCloud_Functionaris functionaris);
    	*/
    
    	[System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, true)]
        public ClubCloud_Functionaris SelectFunctionaris([QueryString] Guid? Id) //(string Id)
        {
    		ClubCloud_Functionaris entity = null;
    
    	    using (new SPMonitoredScope("Functionarissen SelectFunctionaris"))
            {
    
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
    
    						entity = Client.GetFunctionarisById(Id.Value, false, Settings);
    
    						if(entity != null || entity.Id != Guid.Empty)
    						{
    									entity.ClubCloud_Functie  = Client.GetFunctieForFunctionarisById(Id.Value, false, Settings);
    								entity.ClubCloud_Vereniging  = Client.GetVerenigingForFunctionarisById(Id.Value, false, Settings);
    								entity.ClubCloud_Gebruiker  = Client.GetGebruikerForFunctionarisById(Id.Value, false, Settings);
    								entity.ClubCloud_District  = Client.GetDistrictForFunctionarisById(Id.Value, false, Settings);
    								entity.ClubCloud_Bestuursorgaan  = Client.GetBestuursorgaanForFunctionarisById(Id.Value, false, Settings);
    							}
    					}
    				}
    			}
    		}
    
    		return entity;
        }
    
    	[System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Fill, true)]
        public IQueryable<ClubCloud_Functionaris> SelectFunctionarissen(string sortByExpression, int startRowIndex, int maximumRows, out int totalRowCount)//, bool retrieveTotalRowCount = true)
        {
    		using (new SPMonitoredScope("Functionarissen SelectFunctionarissen"))
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
    
    						if(String.IsNullOrWhiteSpace(sortByExpression))
    					{
    						sortByExpression = "FunctieId";
    					}
    					else
    					{
    						if(!sortByExpression.Contains("FunctieId"))
    							sortByExpression += ", FunctieId";
    					}
    						DataSourceSelectArguments selectArgs = new DataSourceSelectArguments{ MaximumRows = maximumRows, StartRowIndex = startRowIndex, RetrieveTotalRowCount = true, SortExpression = sortByExpression };
    					ClubCloud_Functionaris_View queryresult = Client.GetFunctionarissenByQuery(bondsnummer.ToString(), Settings.VerenigingId.Value, new DataSourceSelectArguments{ MaximumRows = maximumRows, StartRowIndex = startRowIndex, RetrieveTotalRowCount = true, SortExpression = sortByExpression }, collection);
    
    					totalRowCount = queryresult.TotalRowCount;
    
    					
    					if(totalRowCount > 0)
    					{
    						foreach (ClubCloud_Functionaris Functionaris in queryresult.ClubCloud_Functionaris)
    						{
    								Functionaris.ClubCloud_Functie  = Client.GetFunctieForFunctionarisById(Functionaris.Id, false, Settings);
    								Functionaris.ClubCloud_Vereniging  = Client.GetVerenigingForFunctionarisById(Functionaris.Id, false, Settings);
    								Functionaris.ClubCloud_Gebruiker  = Client.GetGebruikerForFunctionarisById(Functionaris.Id, false, Settings);
    								Functionaris.ClubCloud_District  = Client.GetDistrictForFunctionarisById(Functionaris.Id, false, Settings);
    								Functionaris.ClubCloud_Bestuursorgaan  = Client.GetBestuursorgaanForFunctionarisById(Functionaris.Id, false, Settings);
    	                        
    						}
    					}
    						return queryresult.ClubCloud_Functionaris.AsQueryable<ClubCloud_Functionaris>();
    				}
    			}
    		}
    
            totalRowCount = 0;
    		return null;
    	}
    
    
    	[System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, true)]
        public IQueryable<ClubCloud_Functie> SelectFunctie()
        {
    		using (new SPMonitoredScope("Functionarissen SelectFunctie"))
            {
    
    			if(SPContext.Current.Web.CurrentUser != null)
    			{
    				int bondsnummer;
    				ClubCloud_Setting Settings = null;
    				if (int.TryParse(SPContext.Current.Web.CurrentUser.UserId.NameId, out bondsnummer))
    					Settings = Client.GetSettingById(bondsnummer);
    
    				if(Settings != null && Settings.VerenigingId != null) 
    				{
    					List<ClubCloud_Functie> result = null;
    	
    					if(result == null)
    					{
    						result = Client.GetFuncties(false, Settings);
    				
    					}
    
    					//Default
    					result = result.OrderBy(r => r.Naam).ToList();    				
    					//result.Insert(0, new ClubCloud_Functie { Naam = "Onbekend" });
        
        				return result.AsQueryable<ClubCloud_Functie>();
    				}
    			}
    		}
    
    		return null;
    	}
    
    
    	[System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, true)]
        public IQueryable<ClubCloud_Bestuursorgaan> SelectBestuursorgaan()
        {
    		using (new SPMonitoredScope("Functionarissen SelectBestuursorgaan"))
            {
    
    			if(SPContext.Current.Web.CurrentUser != null)
    			{
    				int bondsnummer;
    				ClubCloud_Setting Settings = null;
    				if (int.TryParse(SPContext.Current.Web.CurrentUser.UserId.NameId, out bondsnummer))
    					Settings = Client.GetSettingById(bondsnummer);
    
    				if(Settings != null && Settings.VerenigingId != null) 
    				{
    					List<ClubCloud_Bestuursorgaan> result = null;
    	
    					//Get By ClubCloud_Vereniging
    					result = Client.GetBestuursorganenForVerenigingById(Settings.VerenigingId.Value, false, Settings);
    
    	
    					if(result == null)
    					{
    						result = Client.GetBestuursorganen(false, Settings);
    				
    					}
    
    					//Default
    					result = result.OrderBy(r => r.Naam).ToList();    				
    					//result.Insert(0, new ClubCloud_Bestuursorgaan { Naam = "Onbekend" });
        
        				return result.AsQueryable<ClubCloud_Bestuursorgaan>();
    				}
    			}
    		}
    
    		return null;
    	}
    
    
    	//public Hashtable SelectActief()
    	[System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, true)]    
    	public IQueryable<DictionaryEntry> SelectActief()
        {
    		using (new SPMonitoredScope("Functionarissen SelectActief"))
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
                		Array values = Enum.GetValues(typeof(ActiefSoort));
    					Array.Sort(values);
    					foreach (int value in values)
    					{
    						result.Add(new DictionaryEntry(value, (ActiefSoort)value));
    					}
    					return result.AsQueryable<DictionaryEntry>();
        			}
    				/*
    				if(Settings != null && Settings.VerenigingId != null) 
    				{
    					Hashtable ht = new Hashtable();
    					ht.Add(string.Empty,"Onbekend");
        				Array values = Enum.GetValues(typeof(ActiefSoort));
    					Array.Sort(values);
    					foreach (int value in values)
    					{
    						string name = ((ActiefSoort)value).ToString();
    						ht.Add(name,name);
    					}    
        				return ht;
    				}
    				*/
    			}
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
    
                    ClubCloud_Functionaris_View queryresult = Client.GetFunctionarissenByQuery(userId, Settings.VerenigingId.Value, selectArgs, collection);
    
                    selectArgs.TotalRowCount = queryresult.TotalRowCount;
    				
    				return (IEnumerable)queryresult.ClubCloud_Functionaris;
                }
            }
    
            //return new DataView();
    		return null;
        }
    	*/
    
    	[System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Delete, true)]
    	public bool DeleteFunctionaris(ClubCloud_Functionaris entity)
        { 
    		using (new SPMonitoredScope("Functionarissen DeleteFunctionaris"))
            {
    
    			if (SPContext.Current.Web.CurrentUser != null)
    			{
    				int bondsnummer;
    				ClubCloud_Setting Settings = null;
    				if (int.TryParse(SPContext.Current.Web.CurrentUser.UserId.NameId, out bondsnummer))
    					Settings = Client.GetSettingById(bondsnummer);
    
    				if (Settings != null && Settings.VerenigingId != null)
    				{
    					return Client.DeleteFunctionaris(entity, Settings);
    				}
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
    					ClubCloud_Functionaris entity = null;
    					if(key == typeof(System.Guid))
    					{
    						entity = Client.GetFunctionarisById((System.Guid)key);
    					}
                        bool succes = false;
                        if (entity != null)
                            succes = Client.DeleteFunctionaris(entity);
                        if (succes)
                            count++;
                    }
                }
            }
            return count;
        }
    	*/
    
    	[System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Insert, true)]
    	public int InsertFunctionaris(ClubCloud_Functionaris entity)
    	{
    		using (new SPMonitoredScope("Functionarissen InsertFunctionaris"))
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
    						entity = Client.SetFunctionaris(entity, Settings);
    					this.OnDataSourceViewChanged(EventArgs.Empty);
    				}
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
        public void UpdateFunctionaris(ClubCloud_Functionaris entity) 
    	{
    		using (new SPMonitoredScope("Functionarissen UpdateFunctionaris"))
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
    						Client.SetFunctionaris(entity, Settings);
    					this.OnDataSourceViewChanged(EventArgs.Empty);
    				}
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
    
    //public class Functionaris : ClubCloud_Functionaris {}
    
    public class ClubCloud_FunctionarisDataSourceViewDesigner : DesignerDataSourceView
    {
        private List<ClubCloud_Functionaris> _data = null;
    
        public ClubCloud_FunctionarisDataSourceViewDesigner(DataSourceDesigner owner, string viewName)
            : base(owner, viewName)
        {}
    
        public override IEnumerable GetDesignTimeData(
            int minimumRows, out bool isSampleData)
        {
            if (_data == null)
            {
                // Create a set of design-time fake data
                _data = new List<ClubCloud_Functionaris>();
                for (int i = 1; i <= minimumRows; i++)
                {
                    _data.Add(new ClubCloud_Functionaris { Id = Guid.NewGuid() });
                }
            }
            isSampleData = true;
            return _data as IEnumerable;
        }
    
        //public override IDataSourceViewSchema Schema
        //{
        //    get { return new ClubCloud_Functionaris(); }
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
