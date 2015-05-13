
 


namespace ClubCloud.Service
{
    using ClubCloud.Model;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Core.Objects;
    using System.Data.Entity.Validation;
    
    internal partial class ClubCloudApplicationService
    {	
    	internal static ClubCloud.Model.StoreContainer _storeModel = null;
    
    	public static ClubCloud.Model.StoreContainer storeModel
    	{
    		get
    		{
    			if (_storeModel == null)
    			{
    					
    				_storeModel = new StoreContainer(GetConnectionString("ClubCloudService_Store"));
                    _storeModel.Database.Connection.StateChange += StoreModel_Connection_StateChange;
                    _storeModel.Database.Connection.Disposed += StoreModel_Connection_Disposed;
                    _storeModel.ObjectContext.SavingChanges += StoreModel_ObjectContext_SavingChanges;
    				//_storeModel.ObjectContext.ObjectMaterialized += StoreModel_ObjectContext_ObjectMaterialized;
    			}
    
                return _storeModel;
    		}
            private set { _storeModel = value; }
    	}
    
        static void StoreModel_ObjectContext_ObjectMaterialized(object sender, ObjectMaterializedEventArgs e)
    	{
    	}
    
        static void StoreModel_Connection_Disposed(object sender, EventArgs e)
    	{
    	}
    
        static void StoreModel_Connection_StateChange(object sender, System.Data.StateChangeEventArgs e)
    	{
    		if(e.CurrentState == System.Data.ConnectionState.Broken)
    		{
    			_storeModel.Database.Connection.Close();
    		}
    
    		if(e.CurrentState == System.Data.ConnectionState.Closed)
    		{
    			_storeModel.Database.Connection.Open();
    		}
    	}
    
        static void StoreModel_ObjectContext_SavingChanges(object sender, EventArgs e)
    	{
    		IEnumerable<DbEntityValidationResult> errors = _storeModel.GetValidationErrors();
    
    		foreach (DbEntityValidationResult error in errors)
    		{
    			error.Entry.State = EntityState.Detached;
    		}
    	}
    }
    
}


