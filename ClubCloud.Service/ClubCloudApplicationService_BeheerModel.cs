
 


namespace ClubCloud.Service
{
    using ClubCloud.Model;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Core.Objects;
    using System.Data.Entity.Validation;
    using System.Reflection;
    
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
    
    
    public static class BeheerContainer_KnownTypes
    {
    	public static IEnumerable<Type> GetKnownTypes(ICustomAttributeProvider provider)
    	{
    		System.Collections.Generic.List<System.Type> knownTypes = new System.Collections.Generic.List<System.Type>();
    		knownTypes.Add(typeof(ClubCloud_Setting));
    		knownTypes.Add(typeof(ClubCloud_Vereniging));
    		knownTypes.Add(typeof(ClubCloud_Gebruiker));
    		knownTypes.Add(typeof(ClubCloud_Accommodatie));
    		knownTypes.Add(typeof(ClubCloud_Nationaliteit));
    		knownTypes.Add(typeof(ClubCloud_District));
    		knownTypes.Add(typeof(ClubCloud_Functie));
    		knownTypes.Add(typeof(ClubCloud_Lidmaatschap));
    		knownTypes.Add(typeof(ClubCloud_Profiel));
    		knownTypes.Add(typeof(ClubCloud_Functionaris));
    		knownTypes.Add(typeof(ClubCloud_Bestuursorgaan));
    		knownTypes.Add(typeof(ClubCloud_Rechtsvorm));
    		knownTypes.Add(typeof(ClubCloud_Address));
    		knownTypes.Add(typeof(ClubCloud_Regio));
    		knownTypes.Add(typeof(ClubCloud_Baansoort));
    		knownTypes.Add(typeof(ClubCloud_Baantype));
    		knownTypes.Add(typeof(ClubCloud_Baan));
    		knownTypes.Add(typeof(ClubCloud_Bouwaard));
    		knownTypes.Add(typeof(ClubCloud_BaanSpeciaal));
    		knownTypes.Add(typeof(ClubCloud_Reservering));
    		knownTypes.Add(typeof(ClubCloud_Afhang));
    		knownTypes.Add(typeof(ClubCloud_Baanschema));
    		knownTypes.Add(typeof(ClubCloud_Foto));
    		knownTypes.Add(typeof(ClubCloud_Lidmaatschapsoort));
    		knownTypes.Add(typeof(ClubCloud_Sponsor));
    		knownTypes.Add(typeof(ClubCloud_Sponsor_Afbeelding));
    		knownTypes.Add(typeof(ClubCloud_Baanblok));
    		knownTypes.Add(typeof(ClubCloud_Baantoplaag));
    		knownTypes.Add(typeof(ClubCloud_Land));
    		return knownTypes;
    	}
    }
    
}


