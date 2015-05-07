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
    
    //[Designer(typeof(ClubCloud_BaanblokDataSourceViewDesigner)),ToolboxData("<{0}:ClubCloud_Baanblokken_View runat=\"server\"></{0}:ClubCloud_Baanblokken_View>")]
    [System.ComponentModel.DataObject(true)]
    public partial class ClubCloud_Baanblokken_View : ClubCloudDataSourceView
    {
        public ClubCloud_Baanblokken_View(EntityDataSource owner, string viewName) : base(owner, viewName) { }
    
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
        partial void OnClubCloud_BaanblokSaving(ClubCloud_Baanblok baanblok);
    
        partial void OnClubCloud_BaanblokCreating(ClubCloud_Baanblok baanblok);
        partial void OnClubCloud_BaanblokCreated(ClubCloud_Baanblok baanblok);
    
        partial void OnClubCloud_BaanblokUpdating(ClubCloud_Baanblok baanblok);
        partial void OnClubCloud_BaanblokUpdated(ClubCloud_Baanblok baanblok);
    
        partial void OnClubCloud_BaanblokSaved(ClubCloud_Baanblok baanblok);
    
        partial void OnClubCloud_BaanblokDeleting(ClubCloud_Baanblok baanblok);
        partial void OnClubCloud_BaanblokDeleted(ClubCloud_Baanblok baanblok);
    	*/
    
    	[System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, true)]
        public ClubCloud_Baanblok SelectBaanblok([QueryString] Guid? Id) //(string Id)
        {
    		ClubCloud_Baanblok entity = null;
    
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
    
    					entity = Client.GetBaanblokById(Id.Value, false, Settings);
    
    					if(entity != null || entity.Id != Guid.Empty)
    					{
    						entity.ClubCloud_Baan  = new System.Collections.ObjectModel.ObservableCollection<ClubCloud_Baan>(Client.GetBanenForBaanblokById(Id.Value, false, Settings));
    						entity.ClubCloud_Accommodatie  = Client.GetAccommodatieForBaanblokById(Id.Value, false, Settings);
    						entity.ClubCloud_Baantype  = Client.GetBaantypeForBaanblokById(Id.Value, false, Settings);
    						entity.ClubCloud_Baansoort  = Client.GetBaansoortForBaanblokById(Id.Value, false, Settings);
    					}
    				}
    			}
    		}
    
    		return entity;
        }
    
    	[System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Fill, true)]
        public IQueryable<ClubCloud_Baanblok> SelectBaanblokken(string sortByExpression, int startRowIndex, int maximumRows, out int totalRowCount)//, bool retrieveTotalRowCount = true)
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
                    ClubCloud_Baanblok_View queryresult = Client.GetBaanblokkenByQuery(bondsnummer.ToString(), Settings.VerenigingId.Value, new DataSourceSelectArguments{ MaximumRows = maximumRows, StartRowIndex = startRowIndex, RetrieveTotalRowCount = true, SortExpression = sortByExpression }, collection);
    
                    totalRowCount = queryresult.TotalRowCount;
    
    				
    				if(totalRowCount > 0)
    				{
                        foreach (ClubCloud_Baanblok Baanblok in queryresult.ClubCloud_Baanblok)
                        {
    						Baanblok.ClubCloud_Baan  = new System.Collections.ObjectModel.ObservableCollection<ClubCloud_Baan>(Client.GetBanenForBaanblokById(Baanblok.Id, false, Settings));
    						Baanblok.ClubCloud_Accommodatie  = Client.GetAccommodatieForBaanblokById(Baanblok.Id, false, Settings);
    						Baanblok.ClubCloud_Baantype  = Client.GetBaantypeForBaanblokById(Baanblok.Id, false, Settings);
    						Baanblok.ClubCloud_Baansoort  = Client.GetBaansoortForBaanblokById(Baanblok.Id, false, Settings);
                            
                        }
    				}
    				return queryresult.ClubCloud_Baanblok.AsQueryable<ClubCloud_Baanblok>();
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
    
    
    	[System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, true)]
        public IQueryable<ClubCloud_Baantype> SelectBaantype()
        {
            if(SPContext.Current.Web.CurrentUser != null)
            {
                int bondsnummer;
                ClubCloud_Setting Settings = null;
                if (int.TryParse(SPContext.Current.Web.CurrentUser.UserId.NameId, out bondsnummer))
                    Settings = Client.GetSettingById(bondsnummer);
    
                if(Settings != null && Settings.VerenigingId != null) 
                {
    				List<ClubCloud_Baantype> result = null;
    
    				if(result == null)
    				{
    					result = Client.GetBaantypes(false, Settings);
    				
    				}
    
                    //Default
                    result = result.OrderBy(r => r.Naam).ToList();    				
                    result.Insert(0, new ClubCloud_Baantype { Naam = "Onbekend" });
        
        			return result.AsQueryable<ClubCloud_Baantype>();
    			}
    		}
    
    		return null;
    	}
    
    
    	[System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, true)]
        public IQueryable<ClubCloud_Baansoort> SelectBaansoort()
        {
            if(SPContext.Current.Web.CurrentUser != null)
            {
                int bondsnummer;
                ClubCloud_Setting Settings = null;
                if (int.TryParse(SPContext.Current.Web.CurrentUser.UserId.NameId, out bondsnummer))
                    Settings = Client.GetSettingById(bondsnummer);
    
                if(Settings != null && Settings.VerenigingId != null) 
                {
    				List<ClubCloud_Baansoort> result = null;
    
    				if(result == null)
    				{
    					result = Client.GetBaansoorten(false, Settings);
    				
    				}
    
                    //Default
                    result = result.OrderBy(r => r.Naam).ToList();    				
                    result.Insert(0, new ClubCloud_Baansoort { Naam = "Onbekend" });
        
        			return result.AsQueryable<ClubCloud_Baansoort>();
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
    
                    ClubCloud_Baanblok_View queryresult = Client.GetBaanblokkenByQuery(userId, Settings.VerenigingId.Value, selectArgs, collection);
    
                    selectArgs.TotalRowCount = queryresult.TotalRowCount;
    				
    				return (IEnumerable)queryresult.ClubCloud_Baanblok;
                }
            }
    
            //return new DataView();
    		return null;
        }
    	*/
    
    	[System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Delete, true)]
    	public bool DeleteBaanblok(ClubCloud_Baanblok entity)
        { 
            if (SPContext.Current.Web.CurrentUser != null)
            {
                int bondsnummer;
                ClubCloud_Setting Settings = null;
                if (int.TryParse(SPContext.Current.Web.CurrentUser.UserId.NameId, out bondsnummer))
                    Settings = Client.GetSettingById(bondsnummer);
    
                if (Settings != null && Settings.VerenigingId != null)
                {
                    return Client.DeleteBaanblok(entity, Settings);
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
    					ClubCloud_Baanblok entity = null;
    					if(key == typeof(System.Guid))
    					{
    						entity = Client.GetBaanblokById((System.Guid)key);
    					}
                        bool succes = false;
                        if (entity != null)
                            succes = Client.DeleteBaanblok(entity);
                        if (succes)
                            count++;
                    }
                }
            }
            return count;
        }
    	*/
    
    	[System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Insert, true)]
    	public int InsertBaanblok(ClubCloud_Baanblok entity)
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
    				if(Settings.ClubCloud_Vereniging != null)
    				{
    					entity.AccommodatieId = Settings.ClubCloud_Vereniging.AccommodatieId.Value;
    				}
                    entity = Client.SetBaanblok(entity, Settings);
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
        public void UpdateBaanblok(ClubCloud_Baanblok entity) 
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
    				if(Settings.ClubCloud_Vereniging != null)
    				{
    					entity.AccommodatieId = Settings.ClubCloud_Vereniging.AccommodatieId.Value;
    				}
                    Client.SetBaanblok(entity, Settings);
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
    
    //public class Baanblok : ClubCloud_Baanblok {}
    
    public class ClubCloud_BaanblokDataSourceViewDesigner : DesignerDataSourceView
    {
        private List<ClubCloud_Baanblok> _data = null;
    
        public ClubCloud_BaanblokDataSourceViewDesigner(DataSourceDesigner owner, string viewName)
            : base(owner, viewName)
        {}
    
        public override IEnumerable GetDesignTimeData(
            int minimumRows, out bool isSampleData)
        {
            if (_data == null)
            {
                // Create a set of design-time fake data
                _data = new List<ClubCloud_Baanblok>();
                for (int i = 1; i <= minimumRows; i++)
                {
                    _data.Add(new ClubCloud_Baanblok { Id = Guid.NewGuid() });
                }
            }
            isSampleData = true;
            return _data as IEnumerable;
        }
    
        //public override IDataSourceViewSchema Schema
        //{
        //    get { return new ClubCloud_Baanblok(); }
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
