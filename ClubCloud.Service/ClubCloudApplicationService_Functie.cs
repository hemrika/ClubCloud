namespace ClubCloud.Service
{
    using ClubCloud.Model;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data.Entity.Migrations;
    using System.Data.SqlClient;
    using System.Linq;
    using System.Runtime.Serialization;
    using System.Text;
    
    internal partial class ClubCloudApplicationService
    {
    	public ClubCloud_Functie GetFunctieById(System.Guid Id , bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		ClubCloud_Functie result = null;
    
    		try
    		{			
    			result = beheerModel.ClubCloud_Functies.Find(Id);
    		
    			if (result == null || refresh)
    				result = GetFunctieById(settings.Id.ToString(), Id, refresh, settings);
    
    			if (result != null)
    				return result;
    
    			return new ClubCloud_Functie();
            }
            finally
            {
    			if(result != null)
    				try { beheerModel.ObjectContext.Detach(result);} catch{}
            }
    
    	}
    
    	public List<ClubCloud_Functie> GetFuncties(bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		List<ClubCloud_Functie> result = null;
    		
    		try
    		{
    			result = beheerModel.ClubCloud_Functies.ToList<ClubCloud_Functie>();
    		
    			if (result == null || result.Count == 0 || refresh)		
    				result = GetFuncties(settings.Id.ToString(), refresh, settings);
    
    			if(result != null)
    				return result;
    
    			return new List<ClubCloud_Functie>();
            }
            finally
            {
    			if(result != null)
    			{
    				foreach (object item in result)
    				{
    					if(item != null)
    						try {beheerModel.ObjectContext.Detach(item); } catch{}
    				}
    			}
            }
    
    	}
    
    	public ClubCloud_Functie SetFunctie(ClubCloud_Functie entity, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		ClubCloud_Functie tobeupdated = null;
    		
    		try
    		{
    			entity = SetFunctie(settings.Id.ToString(), entity, settings);
    
    			beheerModel.ClubCloud_Functies.AddOrUpdate(entity);
    		
    			beheerModel.SaveChanges();
    
    			tobeupdated = beheerModel.ClubCloud_Functies.Find(entity.Id);
    			return tobeupdated;
            }
            finally
            {
    			if(tobeupdated != null)
    				try { beheerModel.ObjectContext.Detach(tobeupdated); } catch{}
            }
    
    	}
    
    
    	public bool DeleteFunctie(ClubCloud_Functie entity, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		return DeleteFunctieById(entity.Id, settings);
    	}
    
    	public bool DeleteFunctieById(System.Guid Id, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		ClubCloud_Functie tobedeleted = null;
    		try
    		{
    
    			tobedeleted = beheerModel.ClubCloud_Functies.Find(Id);
    		
    			if (tobedeleted != null)
    			{
    				beheerModel.ClubCloud_Functies.Remove(tobedeleted);
    				beheerModel.SaveChanges();
    			}
    			return true;
    		}
            finally
            {
    			if(tobedeleted != null)
    				try { beheerModel.ObjectContext.Detach(tobedeleted); } catch{}
            }
    
    		return false;
    	}
    
    
    	public ClubCloud_Functie_View GetFunctiesByQuery(string bondsnummer, Guid verenigingId,System.Web.UI.DataSourceSelectArguments selectArgs = null, List<System.Web.UI.WebControls.Parameter> parameters = null, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		ClubCloud_Functie_View view = new ClubCloud_Functie_View();
    
    		StringBuilder querybuilder = new StringBuilder("SELECT * FROM dbo.ClubCloud_Functie");
    		List<SqlParameter> sqlparams = new List<SqlParameter>();
    		List<SqlParameter> sqlparamscount = new List<SqlParameter>();
    		string and = " AND ";
    		if (parameters != null && parameters.Count > 0)
    		{
    			querybuilder.Append(" WHERE ");
    
    			foreach (System.Web.UI.WebControls.Parameter parameter in parameters)
    			{
    				Type type = TypeConvertor.ToNetType(parameter.DbType);
    				if(type == typeof(DateTime))
    				{
    					querybuilder.Append(parameter.Name + " >= " + parameter.Name + and);
    				}
    				else
    				{
    					querybuilder.Append(parameter.Name + " = @" + parameter.Name + and);
    				}
    				object value = TypeDescriptor.GetConverter(type).ConvertFrom(parameter.DefaultValue);// typeof(string)));
    
    				sqlparams.Add(new SqlParameter { Value = value, ParameterName = "@" + parameter.Name, DbType = parameter.DbType, Direction = parameter.Direction });
    				sqlparamscount.Add(new SqlParameter { Value = value, ParameterName = "@" + parameter.Name, DbType = parameter.DbType, Direction = parameter.Direction });
    			}
    
    			querybuilder.Remove(querybuilder.Length - and.Length, and.Length);
    
    		}
    
    		if (!string.IsNullOrWhiteSpace(selectArgs.SortExpression))
    		{
    			querybuilder.Append(" ORDER BY " + selectArgs.SortExpression);
    		}
    
    		view.ClubCloud_Functie = beheerModel.Database.SqlQuery<ClubCloud_Functie>(querybuilder.ToString(), sqlparams.ToArray()).Skip(selectArgs.StartRowIndex).Take(selectArgs.MaximumRows).ToList<ClubCloud_Functie>();
    
    		if (selectArgs.RetrieveTotalRowCount)
    		{
    
    			view.TotalRowCount = beheerModel.Database.SqlQuery<ClubCloud_Functie>(querybuilder.ToString(), sqlparamscount.ToArray()).Count();
    		}
    		return view;
    	}
    
    	public List<ClubCloud_Functie> GetFunctiesBySearch(string prefixText, int count, string contextKey, ClubCloud_Setting _settings = null)
    	{
    		if(_settings != null)
    			ValidateSettings(ref _settings);
    
            List<string> functies = new List<string>();
            try
            {
                bool enabled = beheerModel.Database.SqlQuery<bool>("SELECT (CAST((FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))AS BIT))").FirstOrDefault();
    
                List<ClubCloud_Functie> entities = null;
    
                if (enabled)
                {
                    var fts = BeheerFullTextInterceptor.Fts(prefixText);
    				
    
    			entities = beheerModel.ClubCloud_Functies.Where(e => e.Naam.Contains(fts)  || e.Beschrijving.Contains(fts)  || e.Meervoud.Contains(fts)  || e.Omschrijving.Contains(fts)  || e.Code.Contains(fts)  || e.Actief.Contains(fts) ).ToList();
    
    				
                }
    			else
    			{
    
    			entities = beheerModel.Database.SqlQuery<ClubCloud_Functie>("SELECT * FROM ClubCloud_Functie WHERE  Naam LIKE '%"+ prefixText +"%' OR  Beschrijving LIKE '%"+ prefixText +"%' OR  Meervoud LIKE '%"+ prefixText +"%' OR  Omschrijving LIKE '%"+ prefixText +"%' OR  Code LIKE '%"+ prefixText +"%' OR  Actief LIKE '%"+ prefixText +"%'").ToList();
    
    				
    			}
    
    			if (entities != null && entities.Count > 0)
    				return entities;
            }
            catch { };
    
            return new List<ClubCloud_Functie>();
    	}
    
    
    	public List<ClubCloud_Functionaris> GetFunctionarissenForFunctie(ClubCloud_Functie entity, bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		List<ClubCloud_Functionaris> result = null;
    
    		try
    		{
    			entity = beheerModel.ClubCloud_Functies.Find(entity.Id);
    			if(entity != null && entity.ClubCloud_Functionaris != null && entity.ClubCloud_Functionaris.Count == 0)
    				beheerModel.Entry(entity).Collection(e => e.ClubCloud_Functionaris).Load();
    
    			result = entity.ClubCloud_Functionaris.ToList();
    
    			if(result == null || result.Count == 0 || refresh)
    				result = GetFunctionarissenForFunctie(settings.Id.ToString(), entity, refresh, settings);
    
    			if(result != null)
    				return result;
    
    			return new List<ClubCloud_Functionaris>();
    		}
    	    finally
    	    {
    			if(entity != null)
    				try { beheerModel.ObjectContext.Detach(entity); } catch{}
    			if(result != null)
    			{
    				foreach (object item in result)
    				{
    					if(item != null)
    						try { beheerModel.ObjectContext.Detach(item); } catch{}
    				}
    			}
    		}	
    
    	}
    
    
    	public List<ClubCloud_Functionaris> GetFunctionarissenForFunctieById(System.Guid Id, bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		ClubCloud_Functie entity = null;
    		List<ClubCloud_Functionaris> result = null;
    
    		try
    		{
    			entity = beheerModel.ClubCloud_Functies.Find(Id);
    			if(entity != null && entity.ClubCloud_Functionaris != null && entity.ClubCloud_Functionaris.Count == 0)
    				beheerModel.Entry(entity).Collection(e => e.ClubCloud_Functionaris).Load();
    
    			result = entity.ClubCloud_Functionaris.ToList();
    
    			if(result == null || result.Count == 0 || refresh)
    				result = GetFunctionarissenForFunctieById(settings.Id.ToString(), Id, refresh, settings);
    
    			if(result != null)
    				return result;
    
    			return new List<ClubCloud_Functionaris>();
    		}
    	    finally
    	    {
    			if(entity != null)
    				try { beheerModel.ObjectContext.Detach(entity); } catch{}
    			if(result != null)
    			{
    				foreach (object item in result)
    				{
    					if(item != null)
    						try { beheerModel.ObjectContext.Detach(item); } catch{}
    				}
    			}
    		}	
    	}
    
    	public bool SetFunctionarissenForFunctie(List<ClubCloud_Functionaris> Functionarissen, ClubCloud_Functie entity, bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		ClubCloud_Functie result = null;
    
    		try
    		{			
    			entity = beheerModel.ClubCloud_Functies.Find(entity.Id);
    		
    			if (entity != null)
    				beheerModel.Entry(entity).Collection(e => e.ClubCloud_Functionaris).Load();
    				//result = GetFunctieById(settings.Id.ToString(), Id, refresh, settings);
    
    			if (result != null)
    				//return result.ClubCloud_Functies.Count == ;
    
    			return false;
            }
            finally
            {
    			if(entity != null)
    				try { beheerModel.ObjectContext.Detach(entity); } catch{}
            }
    		return false;
    	}
    
    
    }
    
    [Serializable]
    [DataContract(IsReference = true)]
    [KnownType(typeof(ClubCloud_Functie))]
    public partial class ClubCloud_Functie_View
    {
    	public ClubCloud_Functie_View()
    	{
    		this.ClubCloud_Functie = new HashSet<ClubCloud_Functie>();
    	}
    
    	[DataMember]
    	public int TotalRowCount { get; set; }
    
    	[DataMember]
    	public virtual ICollection<ClubCloud_Functie> ClubCloud_Functie { get; set; }
    
    }
    	
}

