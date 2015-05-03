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
    
    //[Designer(typeof(ClubCloud_LidmaatschapDataSourceViewDesigner)),ToolboxData("<{0}:ClubCloud_Lidmaatschappen_View runat=\"server\"></{0}:ClubCloud_Lidmaatschappen_View>")]
    [System.ComponentModel.DataObject(true)]
    public partial class ClubCloud_Lidmaatschappen_View : ClubCloudDataSourceView
    {
        public ClubCloud_Lidmaatschappen_View(EntityDataSource owner, string viewName) : base(owner, viewName) { }
    
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
    
        partial void OnClubCloud_LidmaatschapSaving(ClubCloud_Lidmaatschap lidmaatschap);
    
        partial void OnClubCloud_LidmaatschapCreating(ClubCloud_Lidmaatschap lidmaatschap);
        partial void OnClubCloud_LidmaatschapCreated(ClubCloud_Lidmaatschap lidmaatschap);
    
        partial void OnClubCloud_LidmaatschapUpdating(ClubCloud_Lidmaatschap lidmaatschap);
        partial void OnClubCloud_LidmaatschapUpdated(ClubCloud_Lidmaatschap lidmaatschap);
    
        partial void OnClubCloud_LidmaatschapSaved(ClubCloud_Lidmaatschap lidmaatschap);
    
        partial void OnClubCloud_LidmaatschapDeleting(ClubCloud_Lidmaatschap lidmaatschap);
        partial void OnClubCloud_LidmaatschapDeleted(ClubCloud_Lidmaatschap lidmaatschap);
    
    	[System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, true)]
        public ClubCloud_Lidmaatschap SelectLidmaatschap() //(string Id)
        {
    		ClubCloud_Lidmaatschap entity = null;
    
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
    										
    					}
    
    					entity = Client.GetLidmaatschapById(Id, false, Settings);
    
    					if(entity != null || entity.Id != Guid.Empty)
    					{
    						entity.ClubCloud_Vereniging  = Client.GetVerenigingForLidmaatschapById(Id, false, Settings);
    						entity.ClubCloud_Gebruiker  = Client.GetGebruikerForLidmaatschapById(Id, false, Settings);
    						entity.ClubCloud_Lidmaatschapsoort  = Client.GetLidmaatschapsoortForLidmaatschapById(Id, false, Settings);
    					}
    				}
    			}
    		}
    
    		return entity;
        }
    
    	[System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, true)]
        public IQueryable<ClubCloud_Lidmaatschap> SelectLidmaatschappen(string sortByExpression, int startRowIndex, int maximumRows, out int totalRowCount)//, bool retrieveTotalRowCount = true)
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
                    ClubCloud_Lidmaatschap_View queryresult = Client.GetLidmaatschappenByQuery(userId, Settings.VerenigingId.Value, new DataSourceSelectArguments{ MaximumRows = maximumRows, StartRowIndex = startRowIndex, RetrieveTotalRowCount = true, SortExpression = sortByExpression }, collection);
    
                    totalRowCount = queryresult.TotalRowCount;
    
    				
    				if(totalRowCount > 0)
    				{
                        foreach (ClubCloud_Lidmaatschap Lidmaatschap in queryresult.ClubCloud_Lidmaatschap)
                        {
    						Lidmaatschap.ClubCloud_Vereniging  = Client.GetVerenigingForLidmaatschapById(Lidmaatschap.Id, false, Settings);
    						Lidmaatschap.ClubCloud_Gebruiker  = Client.GetGebruikerForLidmaatschapById(Lidmaatschap.Id, false, Settings);
    						Lidmaatschap.ClubCloud_Lidmaatschapsoort  = Client.GetLidmaatschapsoortForLidmaatschapById(Lidmaatschap.Id, false, Settings);
                            
                        }
    				}
    				return queryresult.ClubCloud_Lidmaatschap.AsQueryable<ClubCloud_Lidmaatschap>();
                }
            }
    
            totalRowCount = 0;
    		return null;
    	}
    
    
    	[System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, true)]
        public IQueryable<ClubCloud_Lidmaatschapsoort> SelectLidmaatschapsoort()
        {
            if(SPContext.Current.Web.CurrentUser != null)
            {
                string userId = SPContext.Current.Web.CurrentUser.UserId.NameId;
                ClubCloud_Setting Settings = Client.GetClubCloudSettings(userId);
    
                if(Settings != null && Settings.VerenigingId != null) 
                {
    				List<ClubCloud_Lidmaatschapsoort> result = null;
    
    				//Get By ClubCloud_Vereniging
    				result = Client.GetLidmaatschapsoortenForVerenigingById(Settings.VerenigingId.Value, false, Settings);
    
    
    				if(result == null)
    				{
    					result = Client.GetLidmaatschapsoorten(false, Settings);
    				
    				}
    
                    //Default
                    result = result.OrderBy(r => r.Naam).ToList();    				
                    result.Insert(0, new ClubCloud_Lidmaatschapsoort { Naam = "Onbekend" });
        
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
    
                    ClubCloud_Lidmaatschap_View queryresult = Client.GetLidmaatschappenByQuery(userId, Settings.VerenigingId.Value, selectArgs, collection);
    
                    selectArgs.TotalRowCount = queryresult.TotalRowCount;
    				
    				return (IEnumerable)queryresult.ClubCloud_Lidmaatschap;
                }
            }
    
            //return new DataView();
    		return null;
        }
    
    	[System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Delete, true)]
    	public bool DeleteLidmaatschap(ClubCloud_Lidmaatschap entity)
        { 
            if (SPContext.Current.Web.CurrentUser != null)
            {
                int result;
                ClubCloud_Setting Settings = null;
                if (int.TryParse(SPContext.Current.Web.CurrentUser.UserId.NameId, out result))
                    Settings = Client.GetSettingById(result);
    
                if (Settings != null && Settings.VerenigingId != null)
                {
                    return Client.DeleteLidmaatschap(entity, Settings);
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
    					ClubCloud_Lidmaatschap entity = null;
    					if(key == typeof(System.Guid))
    					{
    						entity = Client.GetLidmaatschapById((System.Guid)key);
    					}
                        bool succes = false;
                        if (entity != null)
                            succes = Client.DeleteLidmaatschap(entity);
                        if (succes)
                            count++;
                    }
                }
            }
            return count;
        }
    
    	[System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Insert, true)]
    	public virtual System.Guid InsertLidmaatschap(ClubCloud_Lidmaatschap entity)
    	{
            if (SPContext.Current.Web.CurrentUser != null)
            {
                int result;
                ClubCloud_Setting Settings = null;
                if (int.TryParse(SPContext.Current.Web.CurrentUser.UserId.NameId, out result))
                    Settings = Client.GetSettingById(result);
    
                if (Settings != null && Settings.VerenigingId != null)
                {
                    entity = Client.SetLidmaatschap(entity, Settings);
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
        public void UpdateLidmaatschap(ClubCloud_Lidmaatschap entity) 
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
                    Client.SetLidmaatschap(entity, Settings);
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
    
    //public class Lidmaatschap : ClubCloud_Lidmaatschap {}
    
    public class ClubCloud_LidmaatschapDataSourceViewDesigner : DesignerDataSourceView
    {
        private List<ClubCloud_Lidmaatschap> _data = null;
    
        public ClubCloud_LidmaatschapDataSourceViewDesigner(DataSourceDesigner owner, string viewName)
            : base(owner, viewName)
        {}
    
        public override IEnumerable GetDesignTimeData(
            int minimumRows, out bool isSampleData)
        {
            if (_data == null)
            {
                // Create a set of design-time fake data
                _data = new List<ClubCloud_Lidmaatschap>();
                for (int i = 1; i <= minimumRows; i++)
                {
                    _data.Add(new ClubCloud_Lidmaatschap { Id = Guid.NewGuid() });
                }
            }
            isSampleData = true;
            return _data as IEnumerable;
        }
    
        //public override IDataSourceViewSchema Schema
        //{
        //    get { return new ClubCloud_Lidmaatschap(); }
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
