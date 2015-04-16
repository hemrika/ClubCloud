
 


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
    	internal static ClubCloud.Model.BeheerContainer _beheerModel = null;
    
    	public static ClubCloud.Model.BeheerContainer beheerModel
    	{
    		get
    		{
    			if (_beheerModel == null)
    			{
    					
    				_beheerModel = new BeheerContainer(GetConnectionString());
                    _beheerModel.Database.Connection.StateChange += BeheerModel_Connection_StateChange;
                    _beheerModel.Database.Connection.Disposed += BeheerModel_Connection_Disposed;
                    _beheerModel.ObjectContext.SavingChanges += BeheerModel_ObjectContext_SavingChanges;
    				//_beheerModel.ObjectContext.ObjectMaterialized += BeheerModel_ObjectContext_ObjectMaterialized;
    			}
    
                return _beheerModel;
    		}
            private set { _beheerModel = value; }
    	}
    
        static void BeheerModel_ObjectContext_ObjectMaterialized(object sender, ObjectMaterializedEventArgs e)
    	{
    	}
    
        static void BeheerModel_Connection_Disposed(object sender, EventArgs e)
    	{
    	}
    
        static void BeheerModel_Connection_StateChange(object sender, System.Data.StateChangeEventArgs e)
    	{
    		if(e.CurrentState == System.Data.ConnectionState.Broken)
    		{
    			_beheerModel.Database.Connection.Close();
    		}
    
    		if(e.CurrentState == System.Data.ConnectionState.Closed)
    		{
    			_beheerModel.Database.Connection.Open();
    		}
    	}
    
        static void BeheerModel_ObjectContext_SavingChanges(object sender, EventArgs e)
    	{
    		IEnumerable<DbEntityValidationResult> errors = _beheerModel.GetValidationErrors();
    
    		foreach (DbEntityValidationResult error in errors)
    		{
    			error.Entry.State = EntityState.Detached;
    		}
    	}
    }
    
}


