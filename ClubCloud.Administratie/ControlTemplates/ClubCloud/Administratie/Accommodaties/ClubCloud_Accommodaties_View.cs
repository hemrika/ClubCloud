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
    
    //[Designer(typeof(ClubCloud_AccommodatieDataSourceViewDesigner)),ToolboxData("<{0}:ClubCloud_Accommodaties_View runat=\"server\"></{0}:ClubCloud_Accommodaties_View>")]
    [System.ComponentModel.DataObject(true)]
    public partial class ClubCloud_Accommodaties_View : ClubCloudDataSourceView
    {
        public ClubCloud_Accommodaties_View(EntityDataSource owner, string viewName) : base(owner, viewName) { }
    
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
    
        partial void OnClubCloud_AccommodatieSaving(ClubCloud_Accommodatie accommodatie);
    
        partial void OnClubCloud_AccommodatieCreating(ClubCloud_Accommodatie accommodatie);
        partial void OnClubCloud_AccommodatieCreated(ClubCloud_Accommodatie accommodatie);
    
        partial void OnClubCloud_AccommodatieUpdating(ClubCloud_Accommodatie accommodatie);
        partial void OnClubCloud_AccommodatieUpdated(ClubCloud_Accommodatie accommodatie);
    
        partial void OnClubCloud_AccommodatieSaved(ClubCloud_Accommodatie accommodatie);
    
        partial void OnClubCloud_AccommodatieDeleting(ClubCloud_Accommodatie accommodatie);
        partial void OnClubCloud_AccommodatieDeleted(ClubCloud_Accommodatie accommodatie);
    
    	[System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, true)]
        public ClubCloud_Accommodatie SelectAccommodatie() //(string Id)
        {
    		ClubCloud_Accommodatie entity = null;
    
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
    								break;
    							}
    						}
    					}
    
    					if(Id == Guid.Empty)
    					{
    										
        					Settings.ClubCloud_Vereniging = Client.GetVerenigingById(Settings.VerenigingId.Value,false, Settings);    
    						Id = Settings.ClubCloud_Vereniging.AccommodatieId.Value;
    					
    					}
    
    					entity = Client.GetAccommodatieById(Id, false, Settings);
    
    					if(entity != null || entity.Id != Guid.Empty)
    					{
    						entity.ClubCloud_District  = Client.GetDistrictForAccommodatieById(Id, false, Settings);
    						entity.ClubCloud_Regio  = Client.GetRegioForAccommodatieById(Id, false, Settings);
    						entity.ClubCloud_Baanblok  = new System.Collections.ObjectModel.ObservableCollection<ClubCloud_Baanblok>(Client.GetBaanblokkenForAccommodatieById(Id, false, Settings));
    						entity.ClubCloud_Baan  = new System.Collections.ObjectModel.ObservableCollection<ClubCloud_Baan>(Client.GetBanenForAccommodatieById(Id, false, Settings));
    						entity.ClubCloud_BaanSpeciaal  = new System.Collections.ObjectModel.ObservableCollection<ClubCloud_BaanSpeciaal>(Client.GetBanenSpeciaalForAccommodatieById(Id, false, Settings));
    						entity.ClubCloud_Address  = new System.Collections.ObjectModel.ObservableCollection<ClubCloud_Address>(Client.GetAddressenForAccommodatieById(Id, false, Settings));
    					}
    				}
    			}
    		}
    
    		return entity;
        }
    
    	[System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, true)]
        public IQueryable<ClubCloud_Accommodatie> SelectAccommodaties(string sortByExpression, int startRowIndex, int maximumRows, out int totalRowCount)//, bool retrieveTotalRowCount = true)
        {
            if(SPContext.Current.Web.CurrentUser != null)
            {
                string userId = SPContext.Current.Web.CurrentUser.UserId.NameId;
                ClubCloud_Setting Settings = Client.GetClubCloudSettings(userId);
    
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
                    ClubCloud_Accommodatie_View queryresult = Client.GetAccommodatiesByQuery(userId, Settings.VerenigingId.Value, new DataSourceSelectArguments{ MaximumRows = maximumRows, StartRowIndex = startRowIndex, RetrieveTotalRowCount = true, SortExpression = sortByExpression }, collection);
    
                    totalRowCount = queryresult.TotalRowCount;
    
    				
    				if(totalRowCount > 0)
    				{
                        foreach (ClubCloud_Accommodatie Accommodatie in queryresult.ClubCloud_Accommodatie)
                        {
    						Accommodatie.ClubCloud_District  = Client.GetDistrictForAccommodatieById(Accommodatie.Id, false, Settings);
    						Accommodatie.ClubCloud_Regio  = Client.GetRegioForAccommodatieById(Accommodatie.Id, false, Settings);
    						Accommodatie.ClubCloud_Baanblok  = new System.Collections.ObjectModel.ObservableCollection<ClubCloud_Baanblok>(Client.GetBaanblokkenForAccommodatieById(Accommodatie.Id, false, Settings));
    						Accommodatie.ClubCloud_Baan  = new System.Collections.ObjectModel.ObservableCollection<ClubCloud_Baan>(Client.GetBanenForAccommodatieById(Accommodatie.Id, false, Settings));
    						Accommodatie.ClubCloud_BaanSpeciaal  = new System.Collections.ObjectModel.ObservableCollection<ClubCloud_BaanSpeciaal>(Client.GetBanenSpeciaalForAccommodatieById(Accommodatie.Id, false, Settings));
    						Accommodatie.ClubCloud_Address  = new System.Collections.ObjectModel.ObservableCollection<ClubCloud_Address>(Client.GetAddressenForAccommodatieById(Accommodatie.Id, false, Settings));
                            
                        }
    				}
    				return queryresult.ClubCloud_Accommodatie.AsQueryable<ClubCloud_Accommodatie>();
                }
            }
    
            totalRowCount = 0;
    		return null;
    	}
    
    
    	[System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, true)]
        public IQueryable<ClubCloud_Baanblok> SelectBaanblok()
        {
            if(SPContext.Current.Web.CurrentUser != null)
            {
                string userId = SPContext.Current.Web.CurrentUser.UserId.NameId;
                ClubCloud_Setting Settings = Client.GetClubCloudSettings(userId);
    
                if(Settings != null && Settings.VerenigingId != null) 
                {
    				List<ClubCloud_Baanblok> result = null;
    
    				//Get By ClubCloud_Accommodatie
    				Settings.ClubCloud_Vereniging = Client.GetVerenigingById(Settings.VerenigingId.Value,false, Settings);
    				result = Client.GetBaanblokkenForAccommodatieById(Settings.ClubCloud_Vereniging.AccommodatieId.Value, false, Settings);
    
    
    				if(result == null)
    				{
    					result = Client.GetBaanblokken(false, Settings);
    				
    				}
    
                    //Default
                    result = result.OrderBy(r => r.Naam).ToList();    				
                    result.Insert(0, new ClubCloud_Baanblok { Naam = "Onbekend" });
        
        			return result.AsQueryable<ClubCloud_Baanblok>();
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
    
                    ClubCloud_Accommodatie_View queryresult = Client.GetAccommodatiesByQuery(userId, Settings.VerenigingId.Value, selectArgs, collection);
    
                    selectArgs.TotalRowCount = queryresult.TotalRowCount;
    				
    				return (IEnumerable)queryresult.ClubCloud_Accommodatie;
                }
            }
    
            //return new DataView();
    		return null;
        }
    
    	[System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Delete, true)]
    	public bool DeleteAccommodatie(ClubCloud_Accommodatie entity)
        { 
            if (SPContext.Current.Web.CurrentUser != null)
            {
                int result;
                ClubCloud_Setting Settings = null;
                if (int.TryParse(SPContext.Current.Web.CurrentUser.UserId.NameId, out result))
                    Settings = Client.GetSettingById(result);
    
                if (Settings != null && Settings.VerenigingId != null)
                {
                    return Client.DeleteAccommodatie(entity, Settings);
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
    					ClubCloud_Accommodatie entity = null;
    					if(key == typeof(System.Guid))
    					{
    						entity = Client.GetAccommodatieById((System.Guid)key);
    					}
                        bool succes = false;
                        if (entity != null)
                            succes = Client.DeleteAccommodatie(entity);
                        if (succes)
                            count++;
                    }
                }
            }
            return count;
        }
    
    	[System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Insert, true)]
    	public virtual System.Guid InsertAccommodatie(ClubCloud_Accommodatie entity)
    	{
            if (SPContext.Current.Web.CurrentUser != null)
            {
                int result;
                ClubCloud_Setting Settings = null;
                if (int.TryParse(SPContext.Current.Web.CurrentUser.UserId.NameId, out result))
                    Settings = Client.GetSettingById(result);
    
                if (Settings != null && Settings.VerenigingId != null)
                {
                    entity = Client.SetAccommodatie(entity, Settings);
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
        public void UpdateAccommodatie(ClubCloud_Accommodatie entity) 
    	{
            if (SPContext.Current.Web.CurrentUser != null)
            {
                int result;
                ClubCloud_Setting Settings = null;
                if (int.TryParse(SPContext.Current.Web.CurrentUser.UserId.NameId, out result))
                    Settings = Client.GetSettingById(result);
    
                if (Settings != null && Settings.VerenigingId != null)
                {
                    Client.SetAccommodatie(entity, Settings);
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
    
    //public class Accommodatie : ClubCloud_Accommodatie {}
    
    public class ClubCloud_AccommodatieDataSourceViewDesigner : DesignerDataSourceView
    {
        private List<ClubCloud_Accommodatie> _data = null;
    
        public ClubCloud_AccommodatieDataSourceViewDesigner(DataSourceDesigner owner, string viewName)
            : base(owner, viewName)
        {}
    
        public override IEnumerable GetDesignTimeData(
            int minimumRows, out bool isSampleData)
        {
            if (_data == null)
            {
                // Create a set of design-time fake data
                _data = new List<ClubCloud_Accommodatie>();
                for (int i = 1; i <= minimumRows; i++)
                {
                    _data.Add(new ClubCloud_Accommodatie { Id = Guid.NewGuid() });
                }
            }
            isSampleData = true;
            return _data as IEnumerable;
        }
    
        //public override IDataSourceViewSchema Schema
        //{
        //    get { return new ClubCloud_Accommodatie(); }
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
