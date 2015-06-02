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
    
    //[Designer(typeof(ClubCloud_AddressDataSourceViewDesigner)),ToolboxData("<{0}:ClubCloud_Addressen_View runat=\"server\"></{0}:ClubCloud_Addressen_View>")]
    [System.ComponentModel.DataObject(true)]
    public partial class ClubCloud_Addressen_View : ClubCloudDataSourceView
    {
        public ClubCloud_Addressen_View(EntityDataSource owner, string viewName) : base(owner, viewName) { }
    
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
        partial void OnClubCloud_AddressSaving(ClubCloud_Address address);
    
        partial void OnClubCloud_AddressCreating(ClubCloud_Address address);
        partial void OnClubCloud_AddressCreated(ClubCloud_Address address);
    
        partial void OnClubCloud_AddressUpdating(ClubCloud_Address address);
        partial void OnClubCloud_AddressUpdated(ClubCloud_Address address);
    
        partial void OnClubCloud_AddressSaved(ClubCloud_Address address);
    
        partial void OnClubCloud_AddressDeleting(ClubCloud_Address address);
        partial void OnClubCloud_AddressDeleted(ClubCloud_Address address);
    	*/
    
    	[System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, true)]
        public ClubCloud_Address SelectAddress([QueryString] Guid? Id) //(string Id)
        {
    		ClubCloud_Address entity = null;
    
    	    using (new SPMonitoredScope("Addressen SelectAddress"))
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
    
    						entity = Client.GetAddressById(Id.Value, false, Settings);
    
    						if(entity != null || entity.Id != Guid.Empty)
    						{
    									entity.ClubCloud_Vereniging  = Client.GetVerenigingForAddressById(Id.Value, false, Settings);
    								entity.ClubCloud_Gebruiker  = Client.GetGebruikerForAddressById(Id.Value, false, Settings);
    								entity.ClubCloud_Regio  = Client.GetRegioForAddressById(Id.Value, false, Settings);
    								entity.ClubCloud_Accommodatie  = Client.GetAccommodatieForAddressById(Id.Value, false, Settings);
    								entity.ClubCloud_Land  = Client.GetLandForAddressById(Id.Value, false, Settings);
    							}
    					}
    				}
    			}
    		}
    
    		return entity;
        }
    
    	[System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Fill, true)]
        public IQueryable<ClubCloud_Address> SelectAddressen(string sortByExpression, int startRowIndex, int maximumRows, out int totalRowCount)//, bool retrieveTotalRowCount = true)
        {
    		using (new SPMonitoredScope("Addressen SelectAddressen"))
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
    					ClubCloud_Address_View queryresult = Client.GetAddressenByQuery(bondsnummer.ToString(), Settings.VerenigingId.Value, new DataSourceSelectArguments{ MaximumRows = maximumRows, StartRowIndex = startRowIndex, RetrieveTotalRowCount = true, SortExpression = sortByExpression }, collection);
    
    					totalRowCount = queryresult.TotalRowCount;
    
    					
    					if(totalRowCount > 0)
    					{
    						foreach (ClubCloud_Address Address in queryresult.ClubCloud_Address)
    						{
    								Address.ClubCloud_Vereniging  = Client.GetVerenigingForAddressById(Address.Id, false, Settings);
    								Address.ClubCloud_Gebruiker  = Client.GetGebruikerForAddressById(Address.Id, false, Settings);
    								Address.ClubCloud_Regio  = Client.GetRegioForAddressById(Address.Id, false, Settings);
    								Address.ClubCloud_Accommodatie  = Client.GetAccommodatieForAddressById(Address.Id, false, Settings);
    								Address.ClubCloud_Land  = Client.GetLandForAddressById(Address.Id, false, Settings);
    	                        
    						}
    					}
    						return queryresult.ClubCloud_Address.AsQueryable<ClubCloud_Address>();
    				}
    			}
    		}
    
            totalRowCount = 0;
    		return null;
    	}
    
    
    	[System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, true)]
        public IQueryable<ClubCloud_Land> SelectLand()
        {
    		using (new SPMonitoredScope("Addressen SelectLand"))
            {
    
    			if(SPContext.Current.Web.CurrentUser != null)
    			{
    				int bondsnummer;
    				ClubCloud_Setting Settings = null;
    				if (int.TryParse(SPContext.Current.Web.CurrentUser.UserId.NameId, out bondsnummer))
    					Settings = Client.GetSettingById(bondsnummer);
    
    				if(Settings != null && Settings.VerenigingId != null) 
    				{
    					List<ClubCloud_Land> result = null;
    	
    					if(result == null)
    					{
    						result = Client.GetLanden(false, Settings);
    				
    					}
    
    					//Default
    					result = result.OrderBy(r => r.Naam).ToList();    				
    					//result.Insert(0, new ClubCloud_Land { Naam = "Onbekend" });
        
        				return result.AsQueryable<ClubCloud_Land>();
    				}
    			}
    		}
    
    		return null;
    	}
    
    
    	//public Hashtable SelectNaam()
    	[System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, true)]    
    	public IQueryable<DictionaryEntry> SelectNaam()
        {
    		using (new SPMonitoredScope("Addressen SelectNaam"))
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
                		Array values = Enum.GetValues(typeof(AddressSoort));
    					Array.Sort(values);
    					foreach (int value in values)
    					{
    						result.Add(new DictionaryEntry(value, (AddressSoort)value));
    					}
    					return result.AsQueryable<DictionaryEntry>();
        			}
    				/*
    				if(Settings != null && Settings.VerenigingId != null) 
    				{
    					Hashtable ht = new Hashtable();
    					ht.Add(string.Empty,"Onbekend");
        				Array values = Enum.GetValues(typeof(AddressSoort));
    					Array.Sort(values);
    					foreach (int value in values)
    					{
    						string name = ((AddressSoort)value).ToString();
    						ht.Add(name,name);
    					}    
        				return ht;
    				}
    				*/
    			}
    		}
    
    		return null;
    	}
    	//public Hashtable SelectActief()
    	[System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, true)]    
    	public IQueryable<DictionaryEntry> SelectActief()
        {
    		using (new SPMonitoredScope("Addressen SelectActief"))
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
    
                    ClubCloud_Address_View queryresult = Client.GetAddressenByQuery(userId, Settings.VerenigingId.Value, selectArgs, collection);
    
                    selectArgs.TotalRowCount = queryresult.TotalRowCount;
    				
    				return (IEnumerable)queryresult.ClubCloud_Address;
                }
            }
    
            //return new DataView();
    		return null;
        }
    	*/
    
    	[System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Delete, true)]
    	public bool DeleteAddress(ClubCloud_Address entity)
        { 
    		using (new SPMonitoredScope("Addressen DeleteAddress"))
            {
    
    			if (SPContext.Current.Web.CurrentUser != null)
    			{
    				int bondsnummer;
    				ClubCloud_Setting Settings = null;
    				if (int.TryParse(SPContext.Current.Web.CurrentUser.UserId.NameId, out bondsnummer))
    					Settings = Client.GetSettingById(bondsnummer);
    
    				if (Settings != null && Settings.VerenigingId != null)
    				{
    					return Client.DeleteAddress(entity, Settings);
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
    					ClubCloud_Address entity = null;
    					if(key == typeof(System.Guid))
    					{
    						entity = Client.GetAddressById((System.Guid)key);
    					}
                        bool succes = false;
                        if (entity != null)
                            succes = Client.DeleteAddress(entity);
                        if (succes)
                            count++;
                    }
                }
            }
            return count;
        }
    	*/
    
    	[System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Insert, true)]
    	public int InsertAddress(ClubCloud_Address entity)
    	{
    		using (new SPMonitoredScope("Addressen InsertAddress"))
            {
    
    			if (SPContext.Current.Web.CurrentUser != null)
    			{
    				int bondsnummer;
    				ClubCloud_Setting Settings = null;
    				if (int.TryParse(SPContext.Current.Web.CurrentUser.UserId.NameId, out bondsnummer))
    					Settings = Client.GetSettingById(bondsnummer);
    
    				if (Settings != null && Settings.VerenigingId != null)
    				{
    						entity = Client.SetAddress(entity, Settings);
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
        public void UpdateAddress(ClubCloud_Address entity) 
    	{
    		using (new SPMonitoredScope("Addressen UpdateAddress"))
            {
    
    			if (SPContext.Current.Web.CurrentUser != null)
    			{
    				int bondsnummer;
    				ClubCloud_Setting Settings = null;
    				if (int.TryParse(SPContext.Current.Web.CurrentUser.UserId.NameId, out bondsnummer))
    					Settings = Client.GetSettingById(bondsnummer);
    
    				if (Settings != null && Settings.VerenigingId != null)
    				{
    						Client.SetAddress(entity, Settings);
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
    
    //public class Address : ClubCloud_Address {}
    
    public class ClubCloud_AddressDataSourceViewDesigner : DesignerDataSourceView
    {
        private List<ClubCloud_Address> _data = null;
    
        public ClubCloud_AddressDataSourceViewDesigner(DataSourceDesigner owner, string viewName)
            : base(owner, viewName)
        {}
    
        public override IEnumerable GetDesignTimeData(
            int minimumRows, out bool isSampleData)
        {
            if (_data == null)
            {
                // Create a set of design-time fake data
                _data = new List<ClubCloud_Address>();
                for (int i = 1; i <= minimumRows; i++)
                {
                    _data.Add(new ClubCloud_Address { Id = Guid.NewGuid() });
                }
            }
            isSampleData = true;
            return _data as IEnumerable;
        }
    
        //public override IDataSourceViewSchema Schema
        //{
        //    get { return new ClubCloud_Address(); }
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
