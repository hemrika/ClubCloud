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
    	public ClubCloud_Vereniging GetVerenigingById(System.Guid Id , bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		ClubCloud_Vereniging result = null;
    
    		try
    		{			
    			result = beheerModel.ClubCloud_Verenigingen.Find(Id);
    		
    			if (result == null || refresh)
    				result = GetVerenigingById(settings.Id.ToString(), Id, refresh, settings);
    
    			if (result != null)
    				return result;
    
    			return new ClubCloud_Vereniging();
            }
            finally
            {
    			if(result != null)
    				beheerModel.ObjectContext.Detach(result);
            }
    
    	}
    
    	public List<ClubCloud_Vereniging> GetVerenigingen(bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		List<ClubCloud_Vereniging> result = null;
    		
    		try
    		{
    			result = beheerModel.ClubCloud_Verenigingen.ToList<ClubCloud_Vereniging>();
    		
    			if (result == null || result.Count == 0 || refresh)		
    				result = GetVerenigingen(settings.Id.ToString(), refresh, settings);
    
    			if(result != null)
    				return result;
    
    			return new List<ClubCloud_Vereniging>();
            }
            finally
            {
    			if(result != null)
    			{
    				foreach (object item in result)
    				{
    					if(item != null)
    						beheerModel.ObjectContext.Detach(item);
    				}
    			}
            }
    
    	}
    
    	public ClubCloud_Vereniging SetVereniging(ClubCloud_Vereniging entity, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		ClubCloud_Vereniging tobeupdated = null;
    		
    		try
    		{
    			entity = SetVereniging(settings.Id.ToString(), entity, settings);
    
    			beheerModel.ClubCloud_Verenigingen.AddOrUpdate(entity);
    		
    			beheerModel.SaveChanges();
    
    			tobeupdated = beheerModel.ClubCloud_Verenigingen.Find(entity.Id);
    			return tobeupdated;
            }
            finally
            {
    			if(tobeupdated != null)
    				beheerModel.ObjectContext.Detach(tobeupdated);
            }
    
    	}
    
    
    	public bool DeleteVereniging(ClubCloud_Vereniging entity, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		return DeleteVerenigingById(entity.Id, settings);
    	}
    
    	public bool DeleteVerenigingById(System.Guid Id, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		ClubCloud_Vereniging tobedeleted = null;
    		try
    		{
    
    			tobedeleted = beheerModel.ClubCloud_Verenigingen.Find(Id);
    		
    			if (tobedeleted != null)
    			{
    				beheerModel.ClubCloud_Verenigingen.Remove(tobedeleted);
    				beheerModel.SaveChanges();
    			}
    			return true;
    		}
            finally
            {
    			if(tobedeleted != null)
    				beheerModel.ObjectContext.Detach(tobedeleted);
            }
    
    		return false;
    	}
    
    
    	public ClubCloud_Vereniging_View GetVerenigingenByQuery(string bondsnummer, Guid verenigingId,System.Web.UI.DataSourceSelectArguments selectArgs = null, List<System.Web.UI.WebControls.Parameter> parameters = null, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		ClubCloud_Vereniging_View view = new ClubCloud_Vereniging_View();
    
    		StringBuilder querybuilder = new StringBuilder("SELECT * FROM dbo.ClubCloud_Vereniging");
    		List<SqlParameter> sqlparams = new List<SqlParameter>();
    		List<SqlParameter> sqlparamscount = new List<SqlParameter>();
    		string and = " AND ";
    		if (parameters != null && parameters.Count > 0)
    		{
    			querybuilder.Append(" WHERE ");
    
    			foreach (System.Web.UI.WebControls.Parameter parameter in parameters)
    			{
    				querybuilder.Append(parameter.Name + " = @" + parameter.Name + and);
    				Type type = TypeConvertor.ToNetType(parameter.DbType);
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
    
    		view.ClubCloud_Vereniging = beheerModel.Database.SqlQuery<ClubCloud_Vereniging>(querybuilder.ToString(), sqlparams.ToArray()).Skip(selectArgs.StartRowIndex).Take(selectArgs.MaximumRows).ToList<ClubCloud_Vereniging>();
    
    		if (selectArgs.RetrieveTotalRowCount)
    		{
    
    			view.TotalRowCount = beheerModel.Database.SqlQuery<ClubCloud_Vereniging>(querybuilder.ToString(), sqlparamscount.ToArray()).Count();
    		}
    		return view;
    	}
    
    	public List<ClubCloud_Vereniging> GetVerenigingenBySearch(string prefixText, int count, string contextKey, ClubCloud_Setting _settings = null)
    	{
    		if(_settings != null)
    			ValidateSettings(ref _settings);
    
            List<string> verenigingen = new List<string>();
            try
            {
                bool enabled = beheerModel.Database.SqlQuery<bool>("SELECT (CAST((FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))AS BIT))").FirstOrDefault();
    
                List<ClubCloud_Vereniging> entities = null;
    
                if (enabled)
                {
                    var fts = BeheerFullTextInterceptor.Fts(prefixText);
    				
    
    			entities = beheerModel.ClubCloud_Verenigingen.Where(e => e.Naam.Contains(fts)  || e.Beschrijving.Contains(fts)  || e.Nummer.Contains(fts)  || e.BankNummer.Contains(fts)  || e.BankIban.Contains(fts)  || e.BankPlaats.Contains(fts)  || e.KvKnummer.Contains(fts)  || e.KvKplaats.Contains(fts)  || e.EmailKNLTB.Contains(fts)  || e.EmailWebSite.Contains(fts)  || e.EmailOverig.Contains(fts)  || e.Fax.Contains(fts)  || e.TelefoonAvond.Contains(fts)  || e.TelefoonOverdag.Contains(fts)  || e.TelefoonOverig.Contains(fts)  || e.Website.Contains(fts)  || e.FTPsite.Contains(fts)  || e.Actief.Contains(fts) ).ToList();
    
    				
                }
    			else
    			{
    
    			entities = beheerModel.Database.SqlQuery<ClubCloud_Vereniging>("SELECT * FROM ClubCloud_Vereniging WHERE  Naam LIKE '%"+ prefixText +"%' OR  Beschrijving LIKE '%"+ prefixText +"%' OR  Nummer LIKE '%"+ prefixText +"%' OR  BankNummer LIKE '%"+ prefixText +"%' OR  BankIban LIKE '%"+ prefixText +"%' OR  BankPlaats LIKE '%"+ prefixText +"%' OR  KvKnummer LIKE '%"+ prefixText +"%' OR  KvKplaats LIKE '%"+ prefixText +"%' OR  EmailKNLTB LIKE '%"+ prefixText +"%' OR  EmailWebSite LIKE '%"+ prefixText +"%' OR  EmailOverig LIKE '%"+ prefixText +"%' OR  Fax LIKE '%"+ prefixText +"%' OR  TelefoonAvond LIKE '%"+ prefixText +"%' OR  TelefoonOverdag LIKE '%"+ prefixText +"%' OR  TelefoonOverig LIKE '%"+ prefixText +"%' OR  Website LIKE '%"+ prefixText +"%' OR  FTPsite LIKE '%"+ prefixText +"%' OR  Actief LIKE '%"+ prefixText +"%'").ToList();
    
    				
    			}
    
    			if (entities != null && entities.Count > 0)
    				return entities;
            }
            catch { };
    
            return new List<ClubCloud_Vereniging>();
    	}
    
    
    	public List<ClubCloud_Functionaris> GetFunctionarissenForVereniging(ClubCloud_Vereniging entity, bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		List<ClubCloud_Functionaris> result = null;
    
    		try
    		{
    			entity = beheerModel.ClubCloud_Verenigingen.Find(entity.Id);
    			if(entity != null && entity.ClubCloud_Functionaris != null && entity.ClubCloud_Functionaris.Count == 0)
    				beheerModel.Entry(entity).Collection(e => e.ClubCloud_Functionaris).Load();
    
    			result = entity.ClubCloud_Functionaris.ToList();
    
    			if(result == null || result.Count == 0 || refresh)
    				result = GetFunctionarissenForVereniging(settings.Id.ToString(), entity, refresh, settings);
    
    			if(result != null)
    				return result;
    
    			return new List<ClubCloud_Functionaris>();
    		}
    	    finally
    	    {
    			if(entity != null)
    				beheerModel.ObjectContext.Detach(entity);
    			if(result != null)
    			{
    				foreach (object item in result)
    				{
    					if(item != null)
    						beheerModel.ObjectContext.Detach(item);
    				}
    			}
    		}	
    
    	}
    
    
    	public List<ClubCloud_Functionaris> GetFunctionarissenForVerenigingById(System.Guid Id, bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		ClubCloud_Vereniging entity = null;
    		List<ClubCloud_Functionaris> result = null;
    
    		try
    		{
    			entity = beheerModel.ClubCloud_Verenigingen.Find(Id);
    			if(entity != null && entity.ClubCloud_Functionaris != null && entity.ClubCloud_Functionaris.Count == 0)
    				beheerModel.Entry(entity).Collection(e => e.ClubCloud_Functionaris).Load();
    
    			result = entity.ClubCloud_Functionaris.ToList();
    
    			if(result == null || result.Count == 0 || refresh)
    				result = GetFunctionarissenForVerenigingById(settings.Id.ToString(), Id, refresh, settings);
    
    			if(result != null)
    				return result;
    
    			return new List<ClubCloud_Functionaris>();
    		}
    	    finally
    	    {
    			if(entity != null)
    				beheerModel.ObjectContext.Detach(entity);
    			if(result != null)
    			{
    				foreach (object item in result)
    				{
    					if(item != null)
    						beheerModel.ObjectContext.Detach(item);
    				}
    			}
    		}	
    	}
    
    	public bool SetFunctionarissenForVereniging(List<ClubCloud_Functionaris> Functionarissen, ClubCloud_Vereniging entity, bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		ClubCloud_Vereniging result = null;
    
    		try
    		{			
    			entity = beheerModel.ClubCloud_Verenigingen.Find(entity.Id);
    		
    			if (entity != null)
    				beheerModel.Entry(entity).Collection(e => e.ClubCloud_Functionaris).Load();
    				//result = GetVerenigingById(settings.Id.ToString(), Id, refresh, settings);
    
    			if (result != null)
    				//return result.ClubCloud_Verenigingen.Count == ;
    
    			return false;
            }
            finally
            {
    			if(entity != null)
    				beheerModel.ObjectContext.Detach(entity);
            }
    		return false;
    	}
    
    
    
    	public List<ClubCloud_Lidmaatschap> GetLidmaatschappenForVereniging(ClubCloud_Vereniging entity, bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		List<ClubCloud_Lidmaatschap> result = null;
    
    		try
    		{
    			entity = beheerModel.ClubCloud_Verenigingen.Find(entity.Id);
    			if(entity != null && entity.ClubCloud_Lidmaatschap != null && entity.ClubCloud_Lidmaatschap.Count == 0)
    				beheerModel.Entry(entity).Collection(e => e.ClubCloud_Lidmaatschap).Load();
    
    			result = entity.ClubCloud_Lidmaatschap.ToList();
    
    			if(result == null || result.Count == 0 || refresh)
    				result = GetLidmaatschappenForVereniging(settings.Id.ToString(), entity, refresh, settings);
    
    			if(result != null)
    				return result;
    
    			return new List<ClubCloud_Lidmaatschap>();
    		}
    	    finally
    	    {
    			if(entity != null)
    				beheerModel.ObjectContext.Detach(entity);
    			if(result != null)
    			{
    				foreach (object item in result)
    				{
    					if(item != null)
    						beheerModel.ObjectContext.Detach(item);
    				}
    			}
    		}	
    
    	}
    
    
    	public List<ClubCloud_Lidmaatschap> GetLidmaatschappenForVerenigingById(System.Guid Id, bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		ClubCloud_Vereniging entity = null;
    		List<ClubCloud_Lidmaatschap> result = null;
    
    		try
    		{
    			entity = beheerModel.ClubCloud_Verenigingen.Find(Id);
    			if(entity != null && entity.ClubCloud_Lidmaatschap != null && entity.ClubCloud_Lidmaatschap.Count == 0)
    				beheerModel.Entry(entity).Collection(e => e.ClubCloud_Lidmaatschap).Load();
    
    			result = entity.ClubCloud_Lidmaatschap.ToList();
    
    			if(result == null || result.Count == 0 || refresh)
    				result = GetLidmaatschappenForVerenigingById(settings.Id.ToString(), Id, refresh, settings);
    
    			if(result != null)
    				return result;
    
    			return new List<ClubCloud_Lidmaatschap>();
    		}
    	    finally
    	    {
    			if(entity != null)
    				beheerModel.ObjectContext.Detach(entity);
    			if(result != null)
    			{
    				foreach (object item in result)
    				{
    					if(item != null)
    						beheerModel.ObjectContext.Detach(item);
    				}
    			}
    		}	
    	}
    
    	public bool SetLidmaatschappenForVereniging(List<ClubCloud_Lidmaatschap> Lidmaatschappen, ClubCloud_Vereniging entity, bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		ClubCloud_Vereniging result = null;
    
    		try
    		{			
    			entity = beheerModel.ClubCloud_Verenigingen.Find(entity.Id);
    		
    			if (entity != null)
    				beheerModel.Entry(entity).Collection(e => e.ClubCloud_Lidmaatschap).Load();
    				//result = GetVerenigingById(settings.Id.ToString(), Id, refresh, settings);
    
    			if (result != null)
    				//return result.ClubCloud_Verenigingen.Count == ;
    
    			return false;
            }
            finally
            {
    			if(entity != null)
    				beheerModel.ObjectContext.Detach(entity);
            }
    		return false;
    	}
    
    
    
    	public List<ClubCloud_Bestuursorgaan> GetBestuursorganenForVereniging(ClubCloud_Vereniging entity, bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		List<ClubCloud_Bestuursorgaan> result = null;
    
    		try
    		{
    			entity = beheerModel.ClubCloud_Verenigingen.Find(entity.Id);
    			if(entity != null && entity.ClubCloud_Bestuursorgaan != null && entity.ClubCloud_Bestuursorgaan.Count == 0)
    				beheerModel.Entry(entity).Collection(e => e.ClubCloud_Bestuursorgaan).Load();
    
    			result = entity.ClubCloud_Bestuursorgaan.ToList();
    
    			if(result == null || result.Count == 0 || refresh)
    				result = GetBestuursorganenForVereniging(settings.Id.ToString(), entity, refresh, settings);
    
    			if(result != null)
    				return result;
    
    			return new List<ClubCloud_Bestuursorgaan>();
    		}
    	    finally
    	    {
    			if(entity != null)
    				beheerModel.ObjectContext.Detach(entity);
    			if(result != null)
    			{
    				foreach (object item in result)
    				{
    					if(item != null)
    						beheerModel.ObjectContext.Detach(item);
    				}
    			}
    		}	
    
    	}
    
    
    	public List<ClubCloud_Bestuursorgaan> GetBestuursorganenForVerenigingById(System.Guid Id, bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		ClubCloud_Vereniging entity = null;
    		List<ClubCloud_Bestuursorgaan> result = null;
    
    		try
    		{
    			entity = beheerModel.ClubCloud_Verenigingen.Find(Id);
    			if(entity != null && entity.ClubCloud_Bestuursorgaan != null && entity.ClubCloud_Bestuursorgaan.Count == 0)
    				beheerModel.Entry(entity).Collection(e => e.ClubCloud_Bestuursorgaan).Load();
    
    			result = entity.ClubCloud_Bestuursorgaan.ToList();
    
    			if(result == null || result.Count == 0 || refresh)
    				result = GetBestuursorganenForVerenigingById(settings.Id.ToString(), Id, refresh, settings);
    
    			if(result != null)
    				return result;
    
    			return new List<ClubCloud_Bestuursorgaan>();
    		}
    	    finally
    	    {
    			if(entity != null)
    				beheerModel.ObjectContext.Detach(entity);
    			if(result != null)
    			{
    				foreach (object item in result)
    				{
    					if(item != null)
    						beheerModel.ObjectContext.Detach(item);
    				}
    			}
    		}	
    	}
    
    	public bool SetBestuursorganenForVereniging(List<ClubCloud_Bestuursorgaan> Bestuursorganen, ClubCloud_Vereniging entity, bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		ClubCloud_Vereniging result = null;
    
    		try
    		{			
    			entity = beheerModel.ClubCloud_Verenigingen.Find(entity.Id);
    		
    			if (entity != null)
    				beheerModel.Entry(entity).Collection(e => e.ClubCloud_Bestuursorgaan).Load();
    				//result = GetVerenigingById(settings.Id.ToString(), Id, refresh, settings);
    
    			if (result != null)
    				//return result.ClubCloud_Verenigingen.Count == ;
    
    			return false;
            }
            finally
            {
    			if(entity != null)
    				beheerModel.ObjectContext.Detach(entity);
            }
    		return false;
    	}
    
    
    
    	public ClubCloud_District GetDistrictForVereniging(ClubCloud_Vereniging entity, bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		ClubCloud_District result = null;
    
    		try
    		{
    			entity = beheerModel.ClubCloud_Verenigingen.Find(entity.Id);
    			if(entity != null && entity.ClubCloud_District == null)
    				beheerModel.Entry(entity).Reference(e => e.ClubCloud_District).Load();
    
    			result = entity.ClubCloud_District;
    
    			if (result == null || refresh)
    				result = GetDistrictForVereniging(settings.Id.ToString(), entity, refresh, settings);
    
    			if (result != null)
    				return result;
    
    			return new ClubCloud_District();
    		}
            finally
            {
    			if(entity != null)
    				beheerModel.ObjectContext.Detach(entity);
                if(result != null)
    				beheerModel.ObjectContext.Detach(result);
            }
    
    	}
    
    	public bool SetDistrictForVereniging(ClubCloud_District District, ClubCloud_Vereniging entity , bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		try
    		{		
    			entity = beheerModel.ClubCloud_Verenigingen.Find(entity.Id);	
    
    			if(entity != null && entity.ClubCloud_District == null)
    				beheerModel.Entry(entity).Reference(e => e.ClubCloud_District).Load();
    
    			entity.ClubCloud_District = District;
    
    			beheerModel.SaveChanges();
    			return true;
            }
            finally
            {
    			if(entity != null)
    				beheerModel.ObjectContext.Detach(entity);
            }
    		return false;
    	}
    
    
    	public ClubCloud_District GetDistrictForVerenigingById(System.Guid Id, bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		ClubCloud_Vereniging entity = null;
    		ClubCloud_District result = null;
    
    		try
    		{
    			entity = beheerModel.ClubCloud_Verenigingen.Find(Id);
    			if(entity != null && entity.ClubCloud_District == null)
    				beheerModel.Entry(entity).Reference(e => e.ClubCloud_District).Load();
    
    			result = entity.ClubCloud_District;
    
    			if (result == null || refresh)
    				result = GetDistrictForVerenigingById(settings.Id.ToString(), Id, refresh, settings);
    
    			if (result != null)
    				return result;
    
    			return new ClubCloud_District();
    		}
            finally
            {
    			if(entity != null)
    				beheerModel.ObjectContext.Detach(entity);
                if(result != null)
    				beheerModel.ObjectContext.Detach(result);
            }
    	}
    
    	public bool SetDistrictForVerenigingById(ClubCloud_District District, System.Guid Id , bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		ClubCloud_Vereniging entity = null;
    
    		try
    		{		
    			entity = beheerModel.ClubCloud_Verenigingen.Find(Id);	
    
    			if(entity != null && entity.ClubCloud_District == null)
    				beheerModel.Entry(entity).Reference(e => e.ClubCloud_District).Load();
    
    			entity.ClubCloud_District = District;
    
    			beheerModel.SaveChanges();
    			return true;
            }
            finally
            {
    			if(entity != null)
    				beheerModel.ObjectContext.Detach(entity);
            }
    		return false;
    	}
    
    
    	public ClubCloud_Rechtsvorm GetRechtsvormForVereniging(ClubCloud_Vereniging entity, bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		ClubCloud_Rechtsvorm result = null;
    
    		try
    		{
    			entity = beheerModel.ClubCloud_Verenigingen.Find(entity.Id);
    			if(entity != null && entity.ClubCloud_Rechtsvorm == null)
    				beheerModel.Entry(entity).Reference(e => e.ClubCloud_Rechtsvorm).Load();
    
    			result = entity.ClubCloud_Rechtsvorm;
    
    			if (result == null || refresh)
    				result = GetRechtsvormForVereniging(settings.Id.ToString(), entity, refresh, settings);
    
    			if (result != null)
    				return result;
    
    			return new ClubCloud_Rechtsvorm();
    		}
            finally
            {
    			if(entity != null)
    				beheerModel.ObjectContext.Detach(entity);
                if(result != null)
    				beheerModel.ObjectContext.Detach(result);
            }
    
    	}
    
    	public bool SetRechtsvormForVereniging(ClubCloud_Rechtsvorm Rechtsvorm, ClubCloud_Vereniging entity , bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		try
    		{		
    			entity = beheerModel.ClubCloud_Verenigingen.Find(entity.Id);	
    
    			if(entity != null && entity.ClubCloud_Rechtsvorm == null)
    				beheerModel.Entry(entity).Reference(e => e.ClubCloud_Rechtsvorm).Load();
    
    			entity.ClubCloud_Rechtsvorm = Rechtsvorm;
    
    			beheerModel.SaveChanges();
    			return true;
            }
            finally
            {
    			if(entity != null)
    				beheerModel.ObjectContext.Detach(entity);
            }
    		return false;
    	}
    
    
    	public ClubCloud_Rechtsvorm GetRechtsvormForVerenigingById(System.Guid Id, bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		ClubCloud_Vereniging entity = null;
    		ClubCloud_Rechtsvorm result = null;
    
    		try
    		{
    			entity = beheerModel.ClubCloud_Verenigingen.Find(Id);
    			if(entity != null && entity.ClubCloud_Rechtsvorm == null)
    				beheerModel.Entry(entity).Reference(e => e.ClubCloud_Rechtsvorm).Load();
    
    			result = entity.ClubCloud_Rechtsvorm;
    
    			if (result == null || refresh)
    				result = GetRechtsvormForVerenigingById(settings.Id.ToString(), Id, refresh, settings);
    
    			if (result != null)
    				return result;
    
    			return new ClubCloud_Rechtsvorm();
    		}
            finally
            {
    			if(entity != null)
    				beheerModel.ObjectContext.Detach(entity);
                if(result != null)
    				beheerModel.ObjectContext.Detach(result);
            }
    	}
    
    	public bool SetRechtsvormForVerenigingById(ClubCloud_Rechtsvorm Rechtsvorm, System.Guid Id , bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		ClubCloud_Vereniging entity = null;
    
    		try
    		{		
    			entity = beheerModel.ClubCloud_Verenigingen.Find(Id);	
    
    			if(entity != null && entity.ClubCloud_Rechtsvorm == null)
    				beheerModel.Entry(entity).Reference(e => e.ClubCloud_Rechtsvorm).Load();
    
    			entity.ClubCloud_Rechtsvorm = Rechtsvorm;
    
    			beheerModel.SaveChanges();
    			return true;
            }
            finally
            {
    			if(entity != null)
    				beheerModel.ObjectContext.Detach(entity);
            }
    		return false;
    	}
    
    
    	public ClubCloud_Accommodatie GetAccommodatieForVereniging(ClubCloud_Vereniging entity, bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		ClubCloud_Accommodatie result = null;
    
    		try
    		{
    			entity = beheerModel.ClubCloud_Verenigingen.Find(entity.Id);
    			if(entity != null && entity.ClubCloud_Accommodatie == null)
    				beheerModel.Entry(entity).Reference(e => e.ClubCloud_Accommodatie).Load();
    
    			result = entity.ClubCloud_Accommodatie;
    
    			if (result == null || refresh)
    				result = GetAccommodatieForVereniging(settings.Id.ToString(), entity, refresh, settings);
    
    			if (result != null)
    				return result;
    
    			return new ClubCloud_Accommodatie();
    		}
            finally
            {
    			if(entity != null)
    				beheerModel.ObjectContext.Detach(entity);
                if(result != null)
    				beheerModel.ObjectContext.Detach(result);
            }
    
    	}
    
    	public bool SetAccommodatieForVereniging(ClubCloud_Accommodatie Accommodatie, ClubCloud_Vereniging entity , bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		try
    		{		
    			entity = beheerModel.ClubCloud_Verenigingen.Find(entity.Id);	
    
    			if(entity != null && entity.ClubCloud_Accommodatie == null)
    				beheerModel.Entry(entity).Reference(e => e.ClubCloud_Accommodatie).Load();
    
    			entity.ClubCloud_Accommodatie = Accommodatie;
    
    			beheerModel.SaveChanges();
    			return true;
            }
            finally
            {
    			if(entity != null)
    				beheerModel.ObjectContext.Detach(entity);
            }
    		return false;
    	}
    
    
    	public ClubCloud_Accommodatie GetAccommodatieForVerenigingById(System.Guid Id, bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		ClubCloud_Vereniging entity = null;
    		ClubCloud_Accommodatie result = null;
    
    		try
    		{
    			entity = beheerModel.ClubCloud_Verenigingen.Find(Id);
    			if(entity != null && entity.ClubCloud_Accommodatie == null)
    				beheerModel.Entry(entity).Reference(e => e.ClubCloud_Accommodatie).Load();
    
    			result = entity.ClubCloud_Accommodatie;
    
    			if (result == null || refresh)
    				result = GetAccommodatieForVerenigingById(settings.Id.ToString(), Id, refresh, settings);
    
    			if (result != null)
    				return result;
    
    			return new ClubCloud_Accommodatie();
    		}
            finally
            {
    			if(entity != null)
    				beheerModel.ObjectContext.Detach(entity);
                if(result != null)
    				beheerModel.ObjectContext.Detach(result);
            }
    	}
    
    	public bool SetAccommodatieForVerenigingById(ClubCloud_Accommodatie Accommodatie, System.Guid Id , bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		ClubCloud_Vereniging entity = null;
    
    		try
    		{		
    			entity = beheerModel.ClubCloud_Verenigingen.Find(Id);	
    
    			if(entity != null && entity.ClubCloud_Accommodatie == null)
    				beheerModel.Entry(entity).Reference(e => e.ClubCloud_Accommodatie).Load();
    
    			entity.ClubCloud_Accommodatie = Accommodatie;
    
    			beheerModel.SaveChanges();
    			return true;
            }
            finally
            {
    			if(entity != null)
    				beheerModel.ObjectContext.Detach(entity);
            }
    		return false;
    	}
    
    
    	public List<ClubCloud_Address> GetAddressesForVereniging(ClubCloud_Vereniging entity, bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		List<ClubCloud_Address> result = null;
    
    		try
    		{
    			entity = beheerModel.ClubCloud_Verenigingen.Find(entity.Id);
    			if(entity != null && entity.ClubCloud_Address != null && entity.ClubCloud_Address.Count == 0)
    				beheerModel.Entry(entity).Collection(e => e.ClubCloud_Address).Load();
    
    			result = entity.ClubCloud_Address.ToList();
    
    			if(result == null || result.Count == 0 || refresh)
    				result = GetAddressesForVereniging(settings.Id.ToString(), entity, refresh, settings);
    
    			if(result != null)
    				return result;
    
    			return new List<ClubCloud_Address>();
    		}
    	    finally
    	    {
    			if(entity != null)
    				beheerModel.ObjectContext.Detach(entity);
    			if(result != null)
    			{
    				foreach (object item in result)
    				{
    					if(item != null)
    						beheerModel.ObjectContext.Detach(item);
    				}
    			}
    		}	
    
    	}
    
    
    	public List<ClubCloud_Address> GetAddressesForVerenigingById(System.Guid Id, bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		ClubCloud_Vereniging entity = null;
    		List<ClubCloud_Address> result = null;
    
    		try
    		{
    			entity = beheerModel.ClubCloud_Verenigingen.Find(Id);
    			if(entity != null && entity.ClubCloud_Address != null && entity.ClubCloud_Address.Count == 0)
    				beheerModel.Entry(entity).Collection(e => e.ClubCloud_Address).Load();
    
    			result = entity.ClubCloud_Address.ToList();
    
    			if(result == null || result.Count == 0 || refresh)
    				result = GetAddressesForVerenigingById(settings.Id.ToString(), Id, refresh, settings);
    
    			if(result != null)
    				return result;
    
    			return new List<ClubCloud_Address>();
    		}
    	    finally
    	    {
    			if(entity != null)
    				beheerModel.ObjectContext.Detach(entity);
    			if(result != null)
    			{
    				foreach (object item in result)
    				{
    					if(item != null)
    						beheerModel.ObjectContext.Detach(item);
    				}
    			}
    		}	
    	}
    
    	public bool SetAddressesForVereniging(List<ClubCloud_Address> Addresses, ClubCloud_Vereniging entity, bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		ClubCloud_Vereniging result = null;
    
    		try
    		{			
    			entity = beheerModel.ClubCloud_Verenigingen.Find(entity.Id);
    		
    			if (entity != null)
    				beheerModel.Entry(entity).Collection(e => e.ClubCloud_Address).Load();
    				//result = GetVerenigingById(settings.Id.ToString(), Id, refresh, settings);
    
    			if (result != null)
    				//return result.ClubCloud_Verenigingen.Count == ;
    
    			return false;
            }
            finally
            {
    			if(entity != null)
    				beheerModel.ObjectContext.Detach(entity);
            }
    		return false;
    	}
    
    
    
    	public ClubCloud_Regio GetRegioForVereniging(ClubCloud_Vereniging entity, bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		ClubCloud_Regio result = null;
    
    		try
    		{
    			entity = beheerModel.ClubCloud_Verenigingen.Find(entity.Id);
    			if(entity != null && entity.ClubCloud_Regio == null)
    				beheerModel.Entry(entity).Reference(e => e.ClubCloud_Regio).Load();
    
    			result = entity.ClubCloud_Regio;
    
    			if (result == null || refresh)
    				result = GetRegioForVereniging(settings.Id.ToString(), entity, refresh, settings);
    
    			if (result != null)
    				return result;
    
    			return new ClubCloud_Regio();
    		}
            finally
            {
    			if(entity != null)
    				beheerModel.ObjectContext.Detach(entity);
                if(result != null)
    				beheerModel.ObjectContext.Detach(result);
            }
    
    	}
    
    	public bool SetRegioForVereniging(ClubCloud_Regio Regio, ClubCloud_Vereniging entity , bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		try
    		{		
    			entity = beheerModel.ClubCloud_Verenigingen.Find(entity.Id);	
    
    			if(entity != null && entity.ClubCloud_Regio == null)
    				beheerModel.Entry(entity).Reference(e => e.ClubCloud_Regio).Load();
    
    			entity.ClubCloud_Regio = Regio;
    
    			beheerModel.SaveChanges();
    			return true;
            }
            finally
            {
    			if(entity != null)
    				beheerModel.ObjectContext.Detach(entity);
            }
    		return false;
    	}
    
    
    	public ClubCloud_Regio GetRegioForVerenigingById(System.Guid Id, bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		ClubCloud_Vereniging entity = null;
    		ClubCloud_Regio result = null;
    
    		try
    		{
    			entity = beheerModel.ClubCloud_Verenigingen.Find(Id);
    			if(entity != null && entity.ClubCloud_Regio == null)
    				beheerModel.Entry(entity).Reference(e => e.ClubCloud_Regio).Load();
    
    			result = entity.ClubCloud_Regio;
    
    			if (result == null || refresh)
    				result = GetRegioForVerenigingById(settings.Id.ToString(), Id, refresh, settings);
    
    			if (result != null)
    				return result;
    
    			return new ClubCloud_Regio();
    		}
            finally
            {
    			if(entity != null)
    				beheerModel.ObjectContext.Detach(entity);
                if(result != null)
    				beheerModel.ObjectContext.Detach(result);
            }
    	}
    
    	public bool SetRegioForVerenigingById(ClubCloud_Regio Regio, System.Guid Id , bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		ClubCloud_Vereniging entity = null;
    
    		try
    		{		
    			entity = beheerModel.ClubCloud_Verenigingen.Find(Id);	
    
    			if(entity != null && entity.ClubCloud_Regio == null)
    				beheerModel.Entry(entity).Reference(e => e.ClubCloud_Regio).Load();
    
    			entity.ClubCloud_Regio = Regio;
    
    			beheerModel.SaveChanges();
    			return true;
            }
            finally
            {
    			if(entity != null)
    				beheerModel.ObjectContext.Detach(entity);
            }
    		return false;
    	}
    
    
    	public List<ClubCloud_Gebruiker> GetGebruikersForVereniging(ClubCloud_Vereniging entity, bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		List<ClubCloud_Gebruiker> result = null;
    
    		try
    		{
    			entity = beheerModel.ClubCloud_Verenigingen.Find(entity.Id);
    			if(entity != null && entity.ClubCloud_Gebruiker != null && entity.ClubCloud_Gebruiker.Count == 0)
    				beheerModel.Entry(entity).Collection(e => e.ClubCloud_Gebruiker).Load();
    
    			result = entity.ClubCloud_Gebruiker.ToList();
    
    			if(result == null || result.Count == 0 || refresh)
    				result = GetGebruikersForVereniging(settings.Id.ToString(), entity, refresh, settings);
    
    			if(result != null)
    				return result;
    
    			return new List<ClubCloud_Gebruiker>();
    		}
    	    finally
    	    {
    			if(entity != null)
    				beheerModel.ObjectContext.Detach(entity);
    			if(result != null)
    			{
    				foreach (object item in result)
    				{
    					if(item != null)
    						beheerModel.ObjectContext.Detach(item);
    				}
    			}
    		}	
    
    	}
    
    
    	public List<ClubCloud_Gebruiker> GetGebruikersForVerenigingById(System.Guid Id, bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		ClubCloud_Vereniging entity = null;
    		List<ClubCloud_Gebruiker> result = null;
    
    		try
    		{
    			entity = beheerModel.ClubCloud_Verenigingen.Find(Id);
    			if(entity != null && entity.ClubCloud_Gebruiker != null && entity.ClubCloud_Gebruiker.Count == 0)
    				beheerModel.Entry(entity).Collection(e => e.ClubCloud_Gebruiker).Load();
    
    			result = entity.ClubCloud_Gebruiker.ToList();
    
    			if(result == null || result.Count == 0 || refresh)
    				result = GetGebruikersForVerenigingById(settings.Id.ToString(), Id, refresh, settings);
    
    			if(result != null)
    				return result;
    
    			return new List<ClubCloud_Gebruiker>();
    		}
    	    finally
    	    {
    			if(entity != null)
    				beheerModel.ObjectContext.Detach(entity);
    			if(result != null)
    			{
    				foreach (object item in result)
    				{
    					if(item != null)
    						beheerModel.ObjectContext.Detach(item);
    				}
    			}
    		}	
    	}
    
    	public bool SetGebruikersForVereniging(List<ClubCloud_Gebruiker> Gebruikers, ClubCloud_Vereniging entity, bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		ClubCloud_Vereniging result = null;
    
    		try
    		{			
    			entity = beheerModel.ClubCloud_Verenigingen.Find(entity.Id);
    		
    			if (entity != null)
    				beheerModel.Entry(entity).Collection(e => e.ClubCloud_Gebruiker).Load();
    				//result = GetVerenigingById(settings.Id.ToString(), Id, refresh, settings);
    
    			if (result != null)
    				//return result.ClubCloud_Verenigingen.Count == ;
    
    			return false;
            }
            finally
            {
    			if(entity != null)
    				beheerModel.ObjectContext.Detach(entity);
            }
    		return false;
    	}
    
    
    
    	public List<ClubCloud_Afhang> GetAfhangenForVereniging(ClubCloud_Vereniging entity, bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		List<ClubCloud_Afhang> result = null;
    
    		try
    		{
    			entity = beheerModel.ClubCloud_Verenigingen.Find(entity.Id);
    			if(entity != null && entity.ClubCloud_Afhang != null && entity.ClubCloud_Afhang.Count == 0)
    				beheerModel.Entry(entity).Collection(e => e.ClubCloud_Afhang).Load();
    
    			result = entity.ClubCloud_Afhang.ToList();
    
    			if(result == null || result.Count == 0 || refresh)
    				result = GetAfhangenForVereniging(settings.Id.ToString(), entity, refresh, settings);
    
    			if(result != null)
    				return result;
    
    			return new List<ClubCloud_Afhang>();
    		}
    	    finally
    	    {
    			if(entity != null)
    				beheerModel.ObjectContext.Detach(entity);
    			if(result != null)
    			{
    				foreach (object item in result)
    				{
    					if(item != null)
    						beheerModel.ObjectContext.Detach(item);
    				}
    			}
    		}	
    
    	}
    
    
    	public List<ClubCloud_Afhang> GetAfhangenForVerenigingById(System.Guid Id, bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		ClubCloud_Vereniging entity = null;
    		List<ClubCloud_Afhang> result = null;
    
    		try
    		{
    			entity = beheerModel.ClubCloud_Verenigingen.Find(Id);
    			if(entity != null && entity.ClubCloud_Afhang != null && entity.ClubCloud_Afhang.Count == 0)
    				beheerModel.Entry(entity).Collection(e => e.ClubCloud_Afhang).Load();
    
    			result = entity.ClubCloud_Afhang.ToList();
    
    			if(result == null || result.Count == 0 || refresh)
    				result = GetAfhangenForVerenigingById(settings.Id.ToString(), Id, refresh, settings);
    
    			if(result != null)
    				return result;
    
    			return new List<ClubCloud_Afhang>();
    		}
    	    finally
    	    {
    			if(entity != null)
    				beheerModel.ObjectContext.Detach(entity);
    			if(result != null)
    			{
    				foreach (object item in result)
    				{
    					if(item != null)
    						beheerModel.ObjectContext.Detach(item);
    				}
    			}
    		}	
    	}
    
    	public bool SetAfhangenForVereniging(List<ClubCloud_Afhang> Afhangen, ClubCloud_Vereniging entity, bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		ClubCloud_Vereniging result = null;
    
    		try
    		{			
    			entity = beheerModel.ClubCloud_Verenigingen.Find(entity.Id);
    		
    			if (entity != null)
    				beheerModel.Entry(entity).Collection(e => e.ClubCloud_Afhang).Load();
    				//result = GetVerenigingById(settings.Id.ToString(), Id, refresh, settings);
    
    			if (result != null)
    				//return result.ClubCloud_Verenigingen.Count == ;
    
    			return false;
            }
            finally
            {
    			if(entity != null)
    				beheerModel.ObjectContext.Detach(entity);
            }
    		return false;
    	}
    
    
    
    	public List<ClubCloud_Sponsor> GetSponsorenForVereniging(ClubCloud_Vereniging entity, bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		List<ClubCloud_Sponsor> result = null;
    
    		try
    		{
    			entity = beheerModel.ClubCloud_Verenigingen.Find(entity.Id);
    			if(entity != null && entity.ClubCloud_Sponsor != null && entity.ClubCloud_Sponsor.Count == 0)
    				beheerModel.Entry(entity).Collection(e => e.ClubCloud_Sponsor).Load();
    
    			result = entity.ClubCloud_Sponsor.ToList();
    
    			if(result == null || result.Count == 0 || refresh)
    				result = GetSponsorenForVereniging(settings.Id.ToString(), entity, refresh, settings);
    
    			if(result != null)
    				return result;
    
    			return new List<ClubCloud_Sponsor>();
    		}
    	    finally
    	    {
    			if(entity != null)
    				beheerModel.ObjectContext.Detach(entity);
    			if(result != null)
    			{
    				foreach (object item in result)
    				{
    					if(item != null)
    						beheerModel.ObjectContext.Detach(item);
    				}
    			}
    		}	
    
    	}
    
    
    	public List<ClubCloud_Sponsor> GetSponsorenForVerenigingById(System.Guid Id, bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		ClubCloud_Vereniging entity = null;
    		List<ClubCloud_Sponsor> result = null;
    
    		try
    		{
    			entity = beheerModel.ClubCloud_Verenigingen.Find(Id);
    			if(entity != null && entity.ClubCloud_Sponsor != null && entity.ClubCloud_Sponsor.Count == 0)
    				beheerModel.Entry(entity).Collection(e => e.ClubCloud_Sponsor).Load();
    
    			result = entity.ClubCloud_Sponsor.ToList();
    
    			if(result == null || result.Count == 0 || refresh)
    				result = GetSponsorenForVerenigingById(settings.Id.ToString(), Id, refresh, settings);
    
    			if(result != null)
    				return result;
    
    			return new List<ClubCloud_Sponsor>();
    		}
    	    finally
    	    {
    			if(entity != null)
    				beheerModel.ObjectContext.Detach(entity);
    			if(result != null)
    			{
    				foreach (object item in result)
    				{
    					if(item != null)
    						beheerModel.ObjectContext.Detach(item);
    				}
    			}
    		}	
    	}
    
    	public bool SetSponsorenForVereniging(List<ClubCloud_Sponsor> Sponsoren, ClubCloud_Vereniging entity, bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		ClubCloud_Vereniging result = null;
    
    		try
    		{			
    			entity = beheerModel.ClubCloud_Verenigingen.Find(entity.Id);
    		
    			if (entity != null)
    				beheerModel.Entry(entity).Collection(e => e.ClubCloud_Sponsor).Load();
    				//result = GetVerenigingById(settings.Id.ToString(), Id, refresh, settings);
    
    			if (result != null)
    				//return result.ClubCloud_Verenigingen.Count == ;
    
    			return false;
            }
            finally
            {
    			if(entity != null)
    				beheerModel.ObjectContext.Detach(entity);
            }
    		return false;
    	}
    
    
    
    	public List<ClubCloud_Setting> GetSettingsForVereniging(ClubCloud_Vereniging entity, bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		List<ClubCloud_Setting> result = null;
    
    		try
    		{
    			entity = beheerModel.ClubCloud_Verenigingen.Find(entity.Id);
    			if(entity != null && entity.ClubCloud_Setting != null && entity.ClubCloud_Setting.Count == 0)
    				beheerModel.Entry(entity).Collection(e => e.ClubCloud_Setting).Load();
    
    			result = entity.ClubCloud_Setting.ToList();
    
    			if(result == null || result.Count == 0 || refresh)
    				result = GetSettingsForVereniging(settings.Id.ToString(), entity, refresh, settings);
    
    			if(result != null)
    				return result;
    
    			return new List<ClubCloud_Setting>();
    		}
    	    finally
    	    {
    			if(entity != null)
    				beheerModel.ObjectContext.Detach(entity);
    			if(result != null)
    			{
    				foreach (object item in result)
    				{
    					if(item != null)
    						beheerModel.ObjectContext.Detach(item);
    				}
    			}
    		}	
    
    	}
    
    
    	public List<ClubCloud_Setting> GetSettingsForVerenigingById(System.Guid Id, bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		ClubCloud_Vereniging entity = null;
    		List<ClubCloud_Setting> result = null;
    
    		try
    		{
    			entity = beheerModel.ClubCloud_Verenigingen.Find(Id);
    			if(entity != null && entity.ClubCloud_Setting != null && entity.ClubCloud_Setting.Count == 0)
    				beheerModel.Entry(entity).Collection(e => e.ClubCloud_Setting).Load();
    
    			result = entity.ClubCloud_Setting.ToList();
    
    			if(result == null || result.Count == 0 || refresh)
    				result = GetSettingsForVerenigingById(settings.Id.ToString(), Id, refresh, settings);
    
    			if(result != null)
    				return result;
    
    			return new List<ClubCloud_Setting>();
    		}
    	    finally
    	    {
    			if(entity != null)
    				beheerModel.ObjectContext.Detach(entity);
    			if(result != null)
    			{
    				foreach (object item in result)
    				{
    					if(item != null)
    						beheerModel.ObjectContext.Detach(item);
    				}
    			}
    		}	
    	}
    
    	public bool SetSettingsForVereniging(List<ClubCloud_Setting> Settings, ClubCloud_Vereniging entity, bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		ClubCloud_Vereniging result = null;
    
    		try
    		{			
    			entity = beheerModel.ClubCloud_Verenigingen.Find(entity.Id);
    		
    			if (entity != null)
    				beheerModel.Entry(entity).Collection(e => e.ClubCloud_Setting).Load();
    				//result = GetVerenigingById(settings.Id.ToString(), Id, refresh, settings);
    
    			if (result != null)
    				//return result.ClubCloud_Verenigingen.Count == ;
    
    			return false;
            }
            finally
            {
    			if(entity != null)
    				beheerModel.ObjectContext.Detach(entity);
            }
    		return false;
    	}
    
    
    
    	public List<ClubCloud_Baanschema> GetBaanschemasForVereniging(ClubCloud_Vereniging entity, bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		List<ClubCloud_Baanschema> result = null;
    
    		try
    		{
    			entity = beheerModel.ClubCloud_Verenigingen.Find(entity.Id);
    			if(entity != null && entity.ClubCloud_Baanschema != null && entity.ClubCloud_Baanschema.Count == 0)
    				beheerModel.Entry(entity).Collection(e => e.ClubCloud_Baanschema).Load();
    
    			result = entity.ClubCloud_Baanschema.ToList();
    
    			if(result == null || result.Count == 0 || refresh)
    				result = GetBaanschemasForVereniging(settings.Id.ToString(), entity, refresh, settings);
    
    			if(result != null)
    				return result;
    
    			return new List<ClubCloud_Baanschema>();
    		}
    	    finally
    	    {
    			if(entity != null)
    				beheerModel.ObjectContext.Detach(entity);
    			if(result != null)
    			{
    				foreach (object item in result)
    				{
    					if(item != null)
    						beheerModel.ObjectContext.Detach(item);
    				}
    			}
    		}	
    
    	}
    
    
    	public List<ClubCloud_Baanschema> GetBaanschemasForVerenigingById(System.Guid Id, bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		ClubCloud_Vereniging entity = null;
    		List<ClubCloud_Baanschema> result = null;
    
    		try
    		{
    			entity = beheerModel.ClubCloud_Verenigingen.Find(Id);
    			if(entity != null && entity.ClubCloud_Baanschema != null && entity.ClubCloud_Baanschema.Count == 0)
    				beheerModel.Entry(entity).Collection(e => e.ClubCloud_Baanschema).Load();
    
    			result = entity.ClubCloud_Baanschema.ToList();
    
    			if(result == null || result.Count == 0 || refresh)
    				result = GetBaanschemasForVerenigingById(settings.Id.ToString(), Id, refresh, settings);
    
    			if(result != null)
    				return result;
    
    			return new List<ClubCloud_Baanschema>();
    		}
    	    finally
    	    {
    			if(entity != null)
    				beheerModel.ObjectContext.Detach(entity);
    			if(result != null)
    			{
    				foreach (object item in result)
    				{
    					if(item != null)
    						beheerModel.ObjectContext.Detach(item);
    				}
    			}
    		}	
    	}
    
    	public bool SetBaanschemasForVereniging(List<ClubCloud_Baanschema> Baanschemas, ClubCloud_Vereniging entity, bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		ClubCloud_Vereniging result = null;
    
    		try
    		{			
    			entity = beheerModel.ClubCloud_Verenigingen.Find(entity.Id);
    		
    			if (entity != null)
    				beheerModel.Entry(entity).Collection(e => e.ClubCloud_Baanschema).Load();
    				//result = GetVerenigingById(settings.Id.ToString(), Id, refresh, settings);
    
    			if (result != null)
    				//return result.ClubCloud_Verenigingen.Count == ;
    
    			return false;
            }
            finally
            {
    			if(entity != null)
    				beheerModel.ObjectContext.Detach(entity);
            }
    		return false;
    	}
    
    
    }
    
    [Serializable]
    [DataContract(IsReference = true)]
    [KnownType(typeof(ClubCloud_Vereniging))]
    public partial class ClubCloud_Vereniging_View
    {
    	public ClubCloud_Vereniging_View()
    	{
    		this.ClubCloud_Vereniging = new HashSet<ClubCloud_Vereniging>();
    	}
    
    	[DataMember]
    	public int TotalRowCount { get; set; }
    
    	[DataMember]
    	public virtual ICollection<ClubCloud_Vereniging> ClubCloud_Vereniging { get; set; }
    
    }
    	
}

