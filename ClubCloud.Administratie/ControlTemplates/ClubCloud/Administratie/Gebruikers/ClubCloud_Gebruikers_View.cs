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
    									entity.ClubCloud_Address  = new System.Collections.ObjectModel.ObservableCollection<ClubCloud_Address>(Client.GetAddressesForGebruikerById(Id, false, Settings));
    									entity.ClubCloud_Vereniging  = Client.GetVerenigingForGebruikerById(Id, false, Settings);
    									entity.ClubCloud_Setting  = new System.Collections.ObjectModel.ObservableCollection<ClubCloud_Setting>(Client.GetSettingsForGebruikerById(Id, false, Settings));
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
    
        [SPDisposeCheckIgnore(SPDisposeCheckID.SPDisposeCheckID_140, "RootWeb disposed automatically")]
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
    	public void DeleteGebruiker(ClubCloud_Gebruiker entity)
        { 
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
    		return Guid.NewGuid();
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
    
    public class Gebruiker : ClubCloud_Gebruiker {}
    
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
            get { return false; }
        }
    
        public override bool CanInsert
        {
            get { return false; }
        }
    
        public override bool CanUpdate
        {
            get { return false; }
        }
    
        public override bool CanPage
        {
            get { return false; }
        }
    
        public override bool CanSort
        {
            get { return false; }
        }
    }
    
}
