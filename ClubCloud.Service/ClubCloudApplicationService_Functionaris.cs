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
    	public ClubCloud_Functionaris GetFunctionarisById(System.Guid Id , bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		ClubCloud_Functionaris result = null;
    
    		try
    		{			
    			result = beheerModel.ClubCloud_Functionarissen.Find(Id);
    		
    			if (result == null || refresh)
    				result = GetFunctionarisById(settings.Id.ToString(), Id, refresh, settings);
    
    			if (result != null)
    				return result;
    
    			return new ClubCloud_Functionaris();
            }
            finally
            {
    			if(result != null)
    				try { beheerModel.ObjectContext.Detach(result);} catch{}
            }
    
    	}
    
    	public List<ClubCloud_Functionaris> GetFunctionarissen(bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		List<ClubCloud_Functionaris> result = null;
    		
    		try
    		{
    			result = beheerModel.ClubCloud_Functionarissen.ToList<ClubCloud_Functionaris>();
    		
    			if (result == null || result.Count == 0 || refresh)		
    				result = GetFunctionarissen(settings.Id.ToString(), refresh, settings);
    
    			if(result != null)
    				return result;
    
    			return new List<ClubCloud_Functionaris>();
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
    
    	public ClubCloud_Functionaris SetFunctionaris(ClubCloud_Functionaris entity, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		ClubCloud_Functionaris tobeupdated = null;
    		
    		try
    		{
    			entity = SetFunctionaris(settings.Id.ToString(), entity, settings);
    
    			beheerModel.ClubCloud_Functionarissen.AddOrUpdate(entity);
    		
    			beheerModel.SaveChanges();
    
    			tobeupdated = beheerModel.ClubCloud_Functionarissen.Find(entity.Id);
    			return tobeupdated;
            }
            finally
            {
    			if(tobeupdated != null)
    				try { beheerModel.ObjectContext.Detach(tobeupdated); } catch{}
            }
    
    	}
    
    
    	public bool DeleteFunctionaris(ClubCloud_Functionaris entity, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		return DeleteFunctionarisById(entity.Id, settings);
    	}
    
    	public bool DeleteFunctionarisById(System.Guid Id, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		bool succes = false;
    		ClubCloud_Functionaris tobedeleted = null;
    		try
    		{
    
    			tobedeleted = beheerModel.ClubCloud_Functionarissen.Find(Id);
    		
    			if (tobedeleted != null)
    			{
    				beheerModel.ClubCloud_Functionarissen.Remove(tobedeleted);
    				beheerModel.SaveChanges();
    			}
    			succes = true;
    		}
            finally
            {
    			if(tobedeleted != null)
    				try { beheerModel.ObjectContext.Detach(tobedeleted); } catch{}
            }
    
    		return succes;
    	}
    
    
    	public ClubCloud_Functionaris_View GetFunctionarissenByQuery(string bondsnummer, Guid verenigingId,System.Web.UI.DataSourceSelectArguments selectArgs = null, List<System.Web.UI.WebControls.Parameter> parameters = null, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		ClubCloud_Functionaris_View view = new ClubCloud_Functionaris_View();
    
    		StringBuilder querybuilder = new StringBuilder("SELECT * FROM dbo.ClubCloud_Functionaris");
    		List<SqlParameter> sqlparams = new List<SqlParameter>();
    		List<SqlParameter> sqlparamscount = new List<SqlParameter>();
    		string and = " AND ";
    		if (parameters != null && parameters.Count > 0)
    		{
    			querybuilder.Append(" WHERE ");
    
        		foreach (System.Web.UI.WebControls.Parameter parameter in parameters)
        		{
                    object value = null;
    
        			Type type = TypeConvertor.ToNetType(parameter.DbType);
        			if(type == typeof(DateTime))
        			{    					
                        IFormatProvider culture = new System.Globalization.CultureInfo("nl-NL", true);
                        value = DateTime.Parse(parameter.DefaultValue, culture, System.Globalization.DateTimeStyles.AssumeLocal);
                        querybuilder.Append(parameter.Name + " >= @" + parameter.Name + and);
        			}
        			else
        			{
                        value = TypeDescriptor.GetConverter(type).ConvertFrom(parameter.DefaultValue);
                        querybuilder.Append(parameter.Name + " = @" + parameter.Name + and);
        			}
    
                    if (value != null)
                    {
                        sqlparams.Add(new SqlParameter { Value = value, ParameterName = "@" + parameter.Name, DbType = parameter.DbType, Direction = parameter.Direction });
                        sqlparamscount.Add(new SqlParameter { Value = value, ParameterName = "@" + parameter.Name, DbType = parameter.DbType, Direction = parameter.Direction });
                    }
        		}
    
                if (querybuilder.Length > and.Length)
        			querybuilder.Remove(querybuilder.Length - and.Length, and.Length);
    		}
    
    		if (!string.IsNullOrWhiteSpace(selectArgs.SortExpression))
    		{
    			querybuilder.Append(" ORDER BY " + selectArgs.SortExpression);
    		}
    
    		view.ClubCloud_Functionaris = beheerModel.Database.SqlQuery<ClubCloud_Functionaris>(querybuilder.ToString(), sqlparams.ToArray()).Skip(selectArgs.StartRowIndex).Take(selectArgs.MaximumRows).ToList<ClubCloud_Functionaris>();
    
    		if (selectArgs.RetrieveTotalRowCount)
    		{
    
    			view.TotalRowCount = beheerModel.Database.SqlQuery<ClubCloud_Functionaris>(querybuilder.ToString(), sqlparamscount.ToArray()).Count();
    		}
    		return view;
    	}
    
    	public List<ClubCloud_Functionaris> GetFunctionarissenBySearch(string prefixText, int count, string contextKey, ClubCloud_Setting _settings = null)
    	{
    		if(_settings != null)
    			ValidateSettings(ref _settings);
    
            List<string> functionarissen = new List<string>();
            try
            {
                bool enabled = beheerModel.Database.SqlQuery<bool>("SELECT (CAST((FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))AS BIT))").FirstOrDefault();
    
                List<ClubCloud_Functionaris> entities = null;
    
                if (enabled)
                {
                    var fts = BeheerFullTextInterceptor.Fts(prefixText);
    				
    
    			entities = beheerModel.ClubCloud_Functionarissen.Where(e => e.Actief.Contains(fts) ).ToList();
    
    				
                }
    			else
    			{
    
    			entities = beheerModel.Database.SqlQuery<ClubCloud_Functionaris>("SELECT * FROM ClubCloud_Functionaris WHERE  Actief LIKE '%"+ prefixText +"%'").ToList();
    
    				
    			}
    
    			if (entities != null && entities.Count > 0)
    				return entities;
            }
            catch { };
    
            return new List<ClubCloud_Functionaris>();
    	}
    
    
    	public ClubCloud_Functie GetFunctieForFunctionaris(ClubCloud_Functionaris entity, bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		ClubCloud_Functie result = null;
    
    		try
    		{
    			entity = beheerModel.ClubCloud_Functionarissen.Find(entity.Id);
    			if(entity != null && entity.ClubCloud_Functie == null)
    				beheerModel.Entry(entity).Reference(e => e.ClubCloud_Functie).Load();
    
    			result = entity.ClubCloud_Functie;
    
    			if (result == null || refresh)
    				result = GetFunctieForFunctionaris(settings.Id.ToString(), entity, refresh, settings);
    
    			if (result != null)
    				return result;
    
    			return new ClubCloud_Functie();
    		}
            finally
            {
    			if(entity != null)
    				try { beheerModel.ObjectContext.Detach(entity); } catch{}
                if(result != null)
    				try { beheerModel.ObjectContext.Detach(result); } catch{}
            }
    
    	}
    
    	public bool SetFunctieForFunctionaris(ClubCloud_Functie Functie, ClubCloud_Functionaris entity , bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		bool succes = false;
    		try
    		{		
    			entity = beheerModel.ClubCloud_Functionarissen.Find(entity.Id);	
    
    			if(entity != null && entity.ClubCloud_Functie == null)
    				beheerModel.Entry(entity).Reference(e => e.ClubCloud_Functie).Load();
    
    			entity.ClubCloud_Functie = Functie;
    
    			beheerModel.SaveChanges();
    			succes = true;
            }
            finally
            {
    			if(entity != null)
    				try { beheerModel.ObjectContext.Detach(entity); } catch{}
            }
    		return succes;
    	}
    
    
    	public ClubCloud_Functie GetFunctieForFunctionarisById(System.Guid Id, bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		ClubCloud_Functionaris entity = null;
    		ClubCloud_Functie result = null;
    
    		try
    		{
    			entity = beheerModel.ClubCloud_Functionarissen.Find(Id);
    			if(entity != null && entity.ClubCloud_Functie == null)
    				beheerModel.Entry(entity).Reference(e => e.ClubCloud_Functie).Load();
    
    			result = entity.ClubCloud_Functie;
    
    			if (result == null || refresh)
    				result = GetFunctieForFunctionarisById(settings.Id.ToString(), Id, refresh, settings);
    
    			if (result != null)
    				return result;
    
    			return new ClubCloud_Functie();
    		}
            finally
            {
    			if(entity != null)
    				try { beheerModel.ObjectContext.Detach(entity); } catch{}
                if(result != null)
    				try { beheerModel.ObjectContext.Detach(result); } catch{}
            }
    	}
    
    	public bool SetFunctieForFunctionarisById(ClubCloud_Functie Functie, System.Guid Id , bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		ClubCloud_Functionaris entity = null;
    		bool succes = false;
    
    		try
    		{		
    			entity = beheerModel.ClubCloud_Functionarissen.Find(Id);	
    
    			if(entity != null && entity.ClubCloud_Functie == null)
    				beheerModel.Entry(entity).Reference(e => e.ClubCloud_Functie).Load();
    
    			entity.ClubCloud_Functie = Functie;
    
    			beheerModel.SaveChanges();
    			succes= true;
            }
            finally
            {
    			if(entity != null)
    				try { beheerModel.ObjectContext.Detach(entity); } catch{}
            }
    		return succes;
    	}
    
    
    	public ClubCloud_Vereniging GetVerenigingForFunctionaris(ClubCloud_Functionaris entity, bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		ClubCloud_Vereniging result = null;
    
    		try
    		{
    			entity = beheerModel.ClubCloud_Functionarissen.Find(entity.Id);
    			if(entity != null && entity.ClubCloud_Vereniging == null)
    				beheerModel.Entry(entity).Reference(e => e.ClubCloud_Vereniging).Load();
    
    			result = entity.ClubCloud_Vereniging;
    
    			if (result == null || refresh)
    				result = GetVerenigingForFunctionaris(settings.Id.ToString(), entity, refresh, settings);
    
    			if (result != null)
    				return result;
    
    			return new ClubCloud_Vereniging();
    		}
            finally
            {
    			if(entity != null)
    				try { beheerModel.ObjectContext.Detach(entity); } catch{}
                if(result != null)
    				try { beheerModel.ObjectContext.Detach(result); } catch{}
            }
    
    	}
    
    	public bool SetVerenigingForFunctionaris(ClubCloud_Vereniging Vereniging, ClubCloud_Functionaris entity , bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		bool succes = false;
    		try
    		{		
    			entity = beheerModel.ClubCloud_Functionarissen.Find(entity.Id);	
    
    			if(entity != null && entity.ClubCloud_Vereniging == null)
    				beheerModel.Entry(entity).Reference(e => e.ClubCloud_Vereniging).Load();
    
    			entity.ClubCloud_Vereniging = Vereniging;
    
    			beheerModel.SaveChanges();
    			succes = true;
            }
            finally
            {
    			if(entity != null)
    				try { beheerModel.ObjectContext.Detach(entity); } catch{}
            }
    		return succes;
    	}
    
    
    	public ClubCloud_Vereniging GetVerenigingForFunctionarisById(System.Guid Id, bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		ClubCloud_Functionaris entity = null;
    		ClubCloud_Vereniging result = null;
    
    		try
    		{
    			entity = beheerModel.ClubCloud_Functionarissen.Find(Id);
    			if(entity != null && entity.ClubCloud_Vereniging == null)
    				beheerModel.Entry(entity).Reference(e => e.ClubCloud_Vereniging).Load();
    
    			result = entity.ClubCloud_Vereniging;
    
    			if (result == null || refresh)
    				result = GetVerenigingForFunctionarisById(settings.Id.ToString(), Id, refresh, settings);
    
    			if (result != null)
    				return result;
    
    			return new ClubCloud_Vereniging();
    		}
            finally
            {
    			if(entity != null)
    				try { beheerModel.ObjectContext.Detach(entity); } catch{}
                if(result != null)
    				try { beheerModel.ObjectContext.Detach(result); } catch{}
            }
    	}
    
    	public bool SetVerenigingForFunctionarisById(ClubCloud_Vereniging Vereniging, System.Guid Id , bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		ClubCloud_Functionaris entity = null;
    		bool succes = false;
    
    		try
    		{		
    			entity = beheerModel.ClubCloud_Functionarissen.Find(Id);	
    
    			if(entity != null && entity.ClubCloud_Vereniging == null)
    				beheerModel.Entry(entity).Reference(e => e.ClubCloud_Vereniging).Load();
    
    			entity.ClubCloud_Vereniging = Vereniging;
    
    			beheerModel.SaveChanges();
    			succes= true;
            }
            finally
            {
    			if(entity != null)
    				try { beheerModel.ObjectContext.Detach(entity); } catch{}
            }
    		return succes;
    	}
    
    
    	public ClubCloud_Gebruiker GetGebruikerForFunctionaris(ClubCloud_Functionaris entity, bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		ClubCloud_Gebruiker result = null;
    
    		try
    		{
    			entity = beheerModel.ClubCloud_Functionarissen.Find(entity.Id);
    			if(entity != null && entity.ClubCloud_Gebruiker == null)
    				beheerModel.Entry(entity).Reference(e => e.ClubCloud_Gebruiker).Load();
    
    			result = entity.ClubCloud_Gebruiker;
    
    			if (result == null || refresh)
    				result = GetGebruikerForFunctionaris(settings.Id.ToString(), entity, refresh, settings);
    
    			if (result != null)
    				return result;
    
    			return new ClubCloud_Gebruiker();
    		}
            finally
            {
    			if(entity != null)
    				try { beheerModel.ObjectContext.Detach(entity); } catch{}
                if(result != null)
    				try { beheerModel.ObjectContext.Detach(result); } catch{}
            }
    
    	}
    
    	public bool SetGebruikerForFunctionaris(ClubCloud_Gebruiker Gebruiker, ClubCloud_Functionaris entity , bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		bool succes = false;
    		try
    		{		
    			entity = beheerModel.ClubCloud_Functionarissen.Find(entity.Id);	
    
    			if(entity != null && entity.ClubCloud_Gebruiker == null)
    				beheerModel.Entry(entity).Reference(e => e.ClubCloud_Gebruiker).Load();
    
    			entity.ClubCloud_Gebruiker = Gebruiker;
    
    			beheerModel.SaveChanges();
    			succes = true;
            }
            finally
            {
    			if(entity != null)
    				try { beheerModel.ObjectContext.Detach(entity); } catch{}
            }
    		return succes;
    	}
    
    
    	public ClubCloud_Gebruiker GetGebruikerForFunctionarisById(System.Guid Id, bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		ClubCloud_Functionaris entity = null;
    		ClubCloud_Gebruiker result = null;
    
    		try
    		{
    			entity = beheerModel.ClubCloud_Functionarissen.Find(Id);
    			if(entity != null && entity.ClubCloud_Gebruiker == null)
    				beheerModel.Entry(entity).Reference(e => e.ClubCloud_Gebruiker).Load();
    
    			result = entity.ClubCloud_Gebruiker;
    
    			if (result == null || refresh)
    				result = GetGebruikerForFunctionarisById(settings.Id.ToString(), Id, refresh, settings);
    
    			if (result != null)
    				return result;
    
    			return new ClubCloud_Gebruiker();
    		}
            finally
            {
    			if(entity != null)
    				try { beheerModel.ObjectContext.Detach(entity); } catch{}
                if(result != null)
    				try { beheerModel.ObjectContext.Detach(result); } catch{}
            }
    	}
    
    	public bool SetGebruikerForFunctionarisById(ClubCloud_Gebruiker Gebruiker, System.Guid Id , bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		ClubCloud_Functionaris entity = null;
    		bool succes = false;
    
    		try
    		{		
    			entity = beheerModel.ClubCloud_Functionarissen.Find(Id);	
    
    			if(entity != null && entity.ClubCloud_Gebruiker == null)
    				beheerModel.Entry(entity).Reference(e => e.ClubCloud_Gebruiker).Load();
    
    			entity.ClubCloud_Gebruiker = Gebruiker;
    
    			beheerModel.SaveChanges();
    			succes= true;
            }
            finally
            {
    			if(entity != null)
    				try { beheerModel.ObjectContext.Detach(entity); } catch{}
            }
    		return succes;
    	}
    
    
    	public ClubCloud_District GetDistrictForFunctionaris(ClubCloud_Functionaris entity, bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		ClubCloud_District result = null;
    
    		try
    		{
    			entity = beheerModel.ClubCloud_Functionarissen.Find(entity.Id);
    			if(entity != null && entity.ClubCloud_District == null)
    				beheerModel.Entry(entity).Reference(e => e.ClubCloud_District).Load();
    
    			result = entity.ClubCloud_District;
    
    			if (result == null || refresh)
    				result = GetDistrictForFunctionaris(settings.Id.ToString(), entity, refresh, settings);
    
    			if (result != null)
    				return result;
    
    			return new ClubCloud_District();
    		}
            finally
            {
    			if(entity != null)
    				try { beheerModel.ObjectContext.Detach(entity); } catch{}
                if(result != null)
    				try { beheerModel.ObjectContext.Detach(result); } catch{}
            }
    
    	}
    
    	public bool SetDistrictForFunctionaris(ClubCloud_District District, ClubCloud_Functionaris entity , bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		bool succes = false;
    		try
    		{		
    			entity = beheerModel.ClubCloud_Functionarissen.Find(entity.Id);	
    
    			if(entity != null && entity.ClubCloud_District == null)
    				beheerModel.Entry(entity).Reference(e => e.ClubCloud_District).Load();
    
    			entity.ClubCloud_District = District;
    
    			beheerModel.SaveChanges();
    			succes = true;
            }
            finally
            {
    			if(entity != null)
    				try { beheerModel.ObjectContext.Detach(entity); } catch{}
            }
    		return succes;
    	}
    
    
    	public ClubCloud_District GetDistrictForFunctionarisById(System.Guid Id, bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		ClubCloud_Functionaris entity = null;
    		ClubCloud_District result = null;
    
    		try
    		{
    			entity = beheerModel.ClubCloud_Functionarissen.Find(Id);
    			if(entity != null && entity.ClubCloud_District == null)
    				beheerModel.Entry(entity).Reference(e => e.ClubCloud_District).Load();
    
    			result = entity.ClubCloud_District;
    
    			if (result == null || refresh)
    				result = GetDistrictForFunctionarisById(settings.Id.ToString(), Id, refresh, settings);
    
    			if (result != null)
    				return result;
    
    			return new ClubCloud_District();
    		}
            finally
            {
    			if(entity != null)
    				try { beheerModel.ObjectContext.Detach(entity); } catch{}
                if(result != null)
    				try { beheerModel.ObjectContext.Detach(result); } catch{}
            }
    	}
    
    	public bool SetDistrictForFunctionarisById(ClubCloud_District District, System.Guid Id , bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		ClubCloud_Functionaris entity = null;
    		bool succes = false;
    
    		try
    		{		
    			entity = beheerModel.ClubCloud_Functionarissen.Find(Id);	
    
    			if(entity != null && entity.ClubCloud_District == null)
    				beheerModel.Entry(entity).Reference(e => e.ClubCloud_District).Load();
    
    			entity.ClubCloud_District = District;
    
    			beheerModel.SaveChanges();
    			succes= true;
            }
            finally
            {
    			if(entity != null)
    				try { beheerModel.ObjectContext.Detach(entity); } catch{}
            }
    		return succes;
    	}
    
    
    	public ClubCloud_Bestuursorgaan GetBestuursorgaanForFunctionaris(ClubCloud_Functionaris entity, bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		ClubCloud_Bestuursorgaan result = null;
    
    		try
    		{
    			entity = beheerModel.ClubCloud_Functionarissen.Find(entity.Id);
    			if(entity != null && entity.ClubCloud_Bestuursorgaan == null)
    				beheerModel.Entry(entity).Reference(e => e.ClubCloud_Bestuursorgaan).Load();
    
    			result = entity.ClubCloud_Bestuursorgaan;
    
    			if (result == null || refresh)
    				result = GetBestuursorgaanForFunctionaris(settings.Id.ToString(), entity, refresh, settings);
    
    			if (result != null)
    				return result;
    
    			return new ClubCloud_Bestuursorgaan();
    		}
            finally
            {
    			if(entity != null)
    				try { beheerModel.ObjectContext.Detach(entity); } catch{}
                if(result != null)
    				try { beheerModel.ObjectContext.Detach(result); } catch{}
            }
    
    	}
    
    	public bool SetBestuursorgaanForFunctionaris(ClubCloud_Bestuursorgaan Bestuursorgaan, ClubCloud_Functionaris entity , bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		bool succes = false;
    		try
    		{		
    			entity = beheerModel.ClubCloud_Functionarissen.Find(entity.Id);	
    
    			if(entity != null && entity.ClubCloud_Bestuursorgaan == null)
    				beheerModel.Entry(entity).Reference(e => e.ClubCloud_Bestuursorgaan).Load();
    
    			entity.ClubCloud_Bestuursorgaan = Bestuursorgaan;
    
    			beheerModel.SaveChanges();
    			succes = true;
            }
            finally
            {
    			if(entity != null)
    				try { beheerModel.ObjectContext.Detach(entity); } catch{}
            }
    		return succes;
    	}
    
    
    	public ClubCloud_Bestuursorgaan GetBestuursorgaanForFunctionarisById(System.Guid Id, bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		ClubCloud_Functionaris entity = null;
    		ClubCloud_Bestuursorgaan result = null;
    
    		try
    		{
    			entity = beheerModel.ClubCloud_Functionarissen.Find(Id);
    			if(entity != null && entity.ClubCloud_Bestuursorgaan == null)
    				beheerModel.Entry(entity).Reference(e => e.ClubCloud_Bestuursorgaan).Load();
    
    			result = entity.ClubCloud_Bestuursorgaan;
    
    			if (result == null || refresh)
    				result = GetBestuursorgaanForFunctionarisById(settings.Id.ToString(), Id, refresh, settings);
    
    			if (result != null)
    				return result;
    
    			return new ClubCloud_Bestuursorgaan();
    		}
            finally
            {
    			if(entity != null)
    				try { beheerModel.ObjectContext.Detach(entity); } catch{}
                if(result != null)
    				try { beheerModel.ObjectContext.Detach(result); } catch{}
            }
    	}
    
    	public bool SetBestuursorgaanForFunctionarisById(ClubCloud_Bestuursorgaan Bestuursorgaan, System.Guid Id , bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		ClubCloud_Functionaris entity = null;
    		bool succes = false;
    
    		try
    		{		
    			entity = beheerModel.ClubCloud_Functionarissen.Find(Id);	
    
    			if(entity != null && entity.ClubCloud_Bestuursorgaan == null)
    				beheerModel.Entry(entity).Reference(e => e.ClubCloud_Bestuursorgaan).Load();
    
    			entity.ClubCloud_Bestuursorgaan = Bestuursorgaan;
    
    			beheerModel.SaveChanges();
    			succes= true;
            }
            finally
            {
    			if(entity != null)
    				try { beheerModel.ObjectContext.Detach(entity); } catch{}
            }
    		return succes;
    	}
    
    }
    
    [Serializable]
    [DataContract(IsReference = true)]
    [KnownType(typeof(ClubCloud_Functionaris))]
    public partial class ClubCloud_Functionaris_View
    {
    	public ClubCloud_Functionaris_View()
    	{
    		this.ClubCloud_Functionaris = new HashSet<ClubCloud_Functionaris>();
    	}
    
    	[DataMember]
    	public int TotalRowCount { get; set; }
    
    	[DataMember]
    	public virtual ICollection<ClubCloud_Functionaris> ClubCloud_Functionaris { get; set; }
    
    }
    	
}

