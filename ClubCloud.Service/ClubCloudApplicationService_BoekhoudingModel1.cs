
 


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
    	internal static ClubCloud.Model.BoekhoudingContainer _boekhoudingModel = null;
    
    	public static ClubCloud.Model.BoekhoudingContainer boekhoudingModel
    	{
    		get
    		{
    			if (_boekhoudingModel == null)
    			{
    					
    				_boekhoudingModel = new BoekhoudingContainer(GetConnectionString());
                    _boekhoudingModel.Database.Connection.StateChange += BoekhoudingModel_Connection_StateChange;
                    _boekhoudingModel.Database.Connection.Disposed += BoekhoudingModel_Connection_Disposed;
                    _boekhoudingModel.ObjectContext.SavingChanges += BoekhoudingModel_ObjectContext_SavingChanges;
    				//_boekhoudingModel.ObjectContext.ObjectMaterialized += BoekhoudingModel_ObjectContext_ObjectMaterialized;
    			}
    
                return _boekhoudingModel;
    		}
            private set { _boekhoudingModel = value; }
    	}
    
        static void BoekhoudingModel_ObjectContext_ObjectMaterialized(object sender, ObjectMaterializedEventArgs e)
    	{
    	}
    
        static void BoekhoudingModel_Connection_Disposed(object sender, EventArgs e)
    	{
    	}
    
        static void BoekhoudingModel_Connection_StateChange(object sender, System.Data.StateChangeEventArgs e)
    	{
    		if(e.CurrentState == System.Data.ConnectionState.Broken)
    		{
    			_boekhoudingModel.Database.Connection.Close();
    		}
    
    		if(e.CurrentState == System.Data.ConnectionState.Closed)
    		{
    			_boekhoudingModel.Database.Connection.Open();
    		}
    	}
    
        static void BoekhoudingModel_ObjectContext_SavingChanges(object sender, EventArgs e)
    	{
    		IEnumerable<DbEntityValidationResult> errors = _boekhoudingModel.GetValidationErrors();
    
    		foreach (DbEntityValidationResult error in errors)
    		{
    			error.Entry.State = EntityState.Detached;
    		}
    	}
    }
    
}


