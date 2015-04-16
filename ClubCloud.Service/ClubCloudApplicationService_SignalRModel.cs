
 


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
    	internal static ClubCloud.Model.SignalRContainer _signalRModel = null;
    
    	public static ClubCloud.Model.SignalRContainer signalRModel
    	{
    		get
    		{
    			if (_signalRModel == null)
    			{
    					
    				_signalRModel = new SignalRContainer(GetConnectionString());
                    _signalRModel.Database.Connection.StateChange += SignalRModel_Connection_StateChange;
                    _signalRModel.Database.Connection.Disposed += SignalRModel_Connection_Disposed;
                    _signalRModel.ObjectContext.SavingChanges += SignalRModel_ObjectContext_SavingChanges;
    				//_signalRModel.ObjectContext.ObjectMaterialized += SignalRModel_ObjectContext_ObjectMaterialized;
    			}
    
                return _signalRModel;
    		}
            private set { _signalRModel = value; }
    	}
    
        static void SignalRModel_ObjectContext_ObjectMaterialized(object sender, ObjectMaterializedEventArgs e)
    	{
    	}
    
        static void SignalRModel_Connection_Disposed(object sender, EventArgs e)
    	{
    	}
    
        static void SignalRModel_Connection_StateChange(object sender, System.Data.StateChangeEventArgs e)
    	{
    		if(e.CurrentState == System.Data.ConnectionState.Broken)
    		{
    			_signalRModel.Database.Connection.Close();
    		}
    
    		if(e.CurrentState == System.Data.ConnectionState.Closed)
    		{
    			_signalRModel.Database.Connection.Open();
    		}
    	}
    
        static void SignalRModel_ObjectContext_SavingChanges(object sender, EventArgs e)
    	{
    		IEnumerable<DbEntityValidationResult> errors = _signalRModel.GetValidationErrors();
    
    		foreach (DbEntityValidationResult error in errors)
    		{
    			error.Entry.State = EntityState.Detached;
    		}
    	}
    }
    
}


