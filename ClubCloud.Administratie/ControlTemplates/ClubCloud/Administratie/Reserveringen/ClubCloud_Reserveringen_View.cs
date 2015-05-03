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
    
    //[Designer(typeof(ClubCloud_ReserveringDataSourceViewDesigner)),ToolboxData("<{0}:ClubCloud_Reserveringen_View runat=\"server\"></{0}:ClubCloud_Reserveringen_View>")]
    [System.ComponentModel.DataObject(true)]
    public partial class ClubCloud_Reserveringen_View : ClubCloudDataSourceView
    {
        public ClubCloud_Reserveringen_View(EntityDataSource owner, string viewName) : base(owner, viewName) { }
    
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
    
        partial void OnClubCloud_ReserveringSaving(ClubCloud_Reservering reservering);
    
        partial void OnClubCloud_ReserveringCreating(ClubCloud_Reservering reservering);
        partial void OnClubCloud_ReserveringCreated(ClubCloud_Reservering reservering);
    
        partial void OnClubCloud_ReserveringUpdating(ClubCloud_Reservering reservering);
        partial void OnClubCloud_ReserveringUpdated(ClubCloud_Reservering reservering);
    
        partial void OnClubCloud_ReserveringSaved(ClubCloud_Reservering reservering);
    
        partial void OnClubCloud_ReserveringDeleting(ClubCloud_Reservering reservering);
        partial void OnClubCloud_ReserveringDeleted(ClubCloud_Reservering reservering);
    
    	[System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, true)]
        public ClubCloud_Reservering SelectReservering() //(string Id)
        {
    		ClubCloud_Reservering entity = null;
    
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
    
    					entity = Client.GetReserveringById(Id, false, Settings);
    
    					if(entity != null || entity.Id != Guid.Empty)
    					{
    						entity.ClubCloud_Baan  = Client.GetBaanForReserveringById(Id, false, Settings);
    						if(entity.Gebruiker_Een != null)
    							entity.ClubCloud_Gebruiker_Een  = Client.GetGebruikerById(entity.Gebruiker_Een.Value, false, Settings);
    						if(entity.Gebruiker_Twee != null)
    							entity.ClubCloud_Gebruiker_Twee  = Client.GetGebruikerById(entity.Gebruiker_Twee.Value, false, Settings);
    						if(entity.Gebruiker_Drie != null)
    							entity.ClubCloud_Gebruiker_Drie  = Client.GetGebruikerById(entity.Gebruiker_Drie.Value, false, Settings);
    						if(entity.Gebruiker_Vier != null)
    							entity.ClubCloud_Gebruiker_Vier  = Client.GetGebruikerById(entity.Gebruiker_Vier.Value, false, Settings);
    					}
    				}
    			}
    		}
    
    		return entity;
        }
    
    	[System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, true)]
        public IQueryable<ClubCloud_Reservering> SelectReserveringen(string sortByExpression, int startRowIndex, int maximumRows, out int totalRowCount)//, bool retrieveTotalRowCount = true)
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
                    ClubCloud_Reservering_View queryresult = Client.GetReserveringenByQuery(userId, Settings.VerenigingId.Value, new DataSourceSelectArguments{ MaximumRows = maximumRows, StartRowIndex = startRowIndex, RetrieveTotalRowCount = true, SortExpression = sortByExpression }, collection);
    
                    totalRowCount = queryresult.TotalRowCount;
    
    				
    				if(totalRowCount > 0)
    				{
                        foreach (ClubCloud_Reservering Reservering in queryresult.ClubCloud_Reservering)
                        {
    						Reservering.ClubCloud_Baan  = Client.GetBaanForReserveringById(Reservering.Id, false, Settings);
    						if(Reservering.Gebruiker_Een != null)
    							Reservering.ClubCloud_Gebruiker_Een  = Client.GetGebruikerById(Reservering.Gebruiker_Een.Value, false, Settings);
    						if(Reservering.Gebruiker_Twee != null)
    							Reservering.ClubCloud_Gebruiker_Twee  = Client.GetGebruikerById(Reservering.Gebruiker_Twee.Value, false, Settings);
    						if(Reservering.Gebruiker_Drie != null)
    							Reservering.ClubCloud_Gebruiker_Drie  = Client.GetGebruikerById(Reservering.Gebruiker_Drie.Value, false, Settings);
    						if(Reservering.Gebruiker_Vier != null)
    							Reservering.ClubCloud_Gebruiker_Vier  = Client.GetGebruikerById(Reservering.Gebruiker_Vier.Value, false, Settings);
                            
                        }
    				}
    				return queryresult.ClubCloud_Reservering.AsQueryable<ClubCloud_Reservering>();
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
                string userId = SPContext.Current.Web.CurrentUser.UserId.NameId;
                ClubCloud_Setting Settings = Client.GetClubCloudSettings(userId);
    
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
    
    
    	[System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, true)]
        public Hashtable Select_Reservering()
        {
            if(SPContext.Current.Web.CurrentUser != null)
            {
                string userId = SPContext.Current.Web.CurrentUser.UserId.NameId;
                ClubCloud_Setting Settings = Client.GetClubCloudSettings(userId);
    
                if(Settings != null && Settings.VerenigingId != null) 
                {
    				string[] names = Enum.GetNames(typeof(ReserveringSoort));
    				Array values = Enum.GetValues(typeof(ReserveringSoort));
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
    
                    ClubCloud_Reservering_View queryresult = Client.GetReserveringenByQuery(userId, Settings.VerenigingId.Value, selectArgs, collection);
    
                    selectArgs.TotalRowCount = queryresult.TotalRowCount;
    				
    				return (IEnumerable)queryresult.ClubCloud_Reservering;
                }
            }
    
            //return new DataView();
    		return null;
        }
    
    	[System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Delete, true)]
    	public bool DeleteReservering(ClubCloud_Reservering entity)
        { 
            if (SPContext.Current.Web.CurrentUser != null)
            {
                int result;
                ClubCloud_Setting Settings = null;
                if (int.TryParse(SPContext.Current.Web.CurrentUser.UserId.NameId, out result))
                    Settings = Client.GetSettingById(result);
    
                if (Settings != null && Settings.VerenigingId != null)
                {
                    return Client.DeleteReservering(entity, Settings);
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
    					ClubCloud_Reservering entity = null;
    					if(key == typeof(System.Guid))
    					{
    						entity = Client.GetReserveringById((System.Guid)key);
    					}
                        bool succes = false;
                        if (entity != null)
                            succes = Client.DeleteReservering(entity);
                        if (succes)
                            count++;
                    }
                }
            }
            return count;
        }
    
    	[System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Insert, true)]
    	public virtual System.Guid InsertReservering(ClubCloud_Reservering entity)
    	{
            if (SPContext.Current.Web.CurrentUser != null)
            {
                int result;
                ClubCloud_Setting Settings = null;
                if (int.TryParse(SPContext.Current.Web.CurrentUser.UserId.NameId, out result))
                    Settings = Client.GetSettingById(result);
    
                if (Settings != null && Settings.VerenigingId != null)
                {
                    entity = Client.SetReservering(entity, Settings);
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
        public void UpdateReservering(ClubCloud_Reservering entity) 
    	{
            if (SPContext.Current.Web.CurrentUser != null)
            {
                int result;
                ClubCloud_Setting Settings = null;
                if (int.TryParse(SPContext.Current.Web.CurrentUser.UserId.NameId, out result))
                    Settings = Client.GetSettingById(result);
    
                if (Settings != null && Settings.VerenigingId != null)
                {
                    Client.SetReservering(entity, Settings);
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
    
    //public class Reservering : ClubCloud_Reservering {}
    
    public class ClubCloud_ReserveringDataSourceViewDesigner : DesignerDataSourceView
    {
        private List<ClubCloud_Reservering> _data = null;
    
        public ClubCloud_ReserveringDataSourceViewDesigner(DataSourceDesigner owner, string viewName)
            : base(owner, viewName)
        {}
    
        public override IEnumerable GetDesignTimeData(
            int minimumRows, out bool isSampleData)
        {
            if (_data == null)
            {
                // Create a set of design-time fake data
                _data = new List<ClubCloud_Reservering>();
                for (int i = 1; i <= minimumRows; i++)
                {
                    _data.Add(new ClubCloud_Reservering { Id = Guid.NewGuid() });
                }
            }
            isSampleData = true;
            return _data as IEnumerable;
        }
    
        //public override IDataSourceViewSchema Schema
        //{
        //    get { return new ClubCloud_Reservering(); }
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
