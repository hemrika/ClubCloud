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
    	public ClubCloud_Accommodatie GetAccommodatieById(System.Guid Id , bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		ClubCloud_Accommodatie result = null;
    
    		try
    		{			
    			result = beheerModel.ClubCloud_Accommodaties.Find(Id);
    		
    			if (result == null || refresh)
    				result = GetAccommodatieById(settings.Id.ToString(), Id, refresh, settings);
    
    			if (result != null)
    				return result;
    
    			return new ClubCloud_Accommodatie();
            }
            finally
            {
    			if(result != null)
    				try { beheerModel.ObjectContext.Detach(result);} catch{}
            }
    
    	}
    
    	public List<ClubCloud_Accommodatie> GetAccommodaties(bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		List<ClubCloud_Accommodatie> result = null;
    		
    		try
    		{
    			result = beheerModel.ClubCloud_Accommodaties.ToList<ClubCloud_Accommodatie>();
    		
    			if (result == null || result.Count == 0 || refresh)		
    				result = GetAccommodaties(settings.Id.ToString(), refresh, settings);
    
    			if(result != null)
    				return result;
    
    			return new List<ClubCloud_Accommodatie>();
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
    
    	public ClubCloud_Accommodatie SetAccommodatie(ClubCloud_Accommodatie entity, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		ClubCloud_Accommodatie tobeupdated = null;
    		
    		try
    		{
    			entity = SetAccommodatie(settings.Id.ToString(), entity, settings);
    
    			beheerModel.ClubCloud_Accommodaties.AddOrUpdate(entity);
    		
    			beheerModel.SaveChanges();
    
    			tobeupdated = beheerModel.ClubCloud_Accommodaties.Find(entity.Id);
    			return tobeupdated;
            }
            finally
            {
    			if(tobeupdated != null)
    				try { beheerModel.ObjectContext.Detach(tobeupdated); } catch{}
            }
    
    	}
    
    
    	public bool DeleteAccommodatie(ClubCloud_Accommodatie entity, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		return DeleteAccommodatieById(entity.Id, settings);
    	}
    
    	public bool DeleteAccommodatieById(System.Guid Id, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		ClubCloud_Accommodatie tobedeleted = null;
    		try
    		{
    
    			tobedeleted = beheerModel.ClubCloud_Accommodaties.Find(Id);
    		
    			if (tobedeleted != null)
    			{
    				beheerModel.ClubCloud_Accommodaties.Remove(tobedeleted);
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
    
    
    	public ClubCloud_Accommodatie_View GetAccommodatiesByQuery(string bondsnummer, Guid verenigingId,System.Web.UI.DataSourceSelectArguments selectArgs = null, List<System.Web.UI.WebControls.Parameter> parameters = null, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		ClubCloud_Accommodatie_View view = new ClubCloud_Accommodatie_View();
    
    		StringBuilder querybuilder = new StringBuilder("SELECT * FROM dbo.ClubCloud_Accommodatie");
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
    
    		view.ClubCloud_Accommodatie = beheerModel.Database.SqlQuery<ClubCloud_Accommodatie>(querybuilder.ToString(), sqlparams.ToArray()).Skip(selectArgs.StartRowIndex).Take(selectArgs.MaximumRows).ToList<ClubCloud_Accommodatie>();
    
    		if (selectArgs.RetrieveTotalRowCount)
    		{
    
    			view.TotalRowCount = beheerModel.Database.SqlQuery<ClubCloud_Accommodatie>(querybuilder.ToString(), sqlparamscount.ToArray()).Count();
    		}
    		return view;
    	}
    
    	public List<ClubCloud_Accommodatie> GetAccommodatiesBySearch(string prefixText, int count, string contextKey, ClubCloud_Setting _settings = null)
    	{
    		if(_settings != null)
    			ValidateSettings(ref _settings);
    
            List<string> accommodaties = new List<string>();
            try
            {
                bool enabled = beheerModel.Database.SqlQuery<bool>("SELECT (CAST((FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))AS BIT))").FirstOrDefault();
    
                List<ClubCloud_Accommodatie> entities = null;
    
                if (enabled)
                {
                    var fts = BeheerFullTextInterceptor.Fts(prefixText);
    				
    
    			entities = beheerModel.ClubCloud_Accommodaties.Where(e => e.Naam.Contains(fts)  || e.BlaashalSoort.Contains(fts)  || e.OverkappingSoort.Contains(fts)  || e.Email.Contains(fts)  || e.Telefoon.Contains(fts)  || e.Website.Contains(fts)  || e.ClubhuisStatus.Contains(fts)  || e.ClubhuisBouwjaar.Contains(fts)  || e.ClubhuisBouwaard.Contains(fts)  || e.ClubhuisLigging.Contains(fts)  || e.ClubhuisBeveiliging.Contains(fts)  || e.HalStatus.Contains(fts)  || e.HalBouwjaar.Contains(fts)  || e.HalBouwaard.Contains(fts)  || e.Speeltoestellen.Contains(fts)  || e.Actief.Contains(fts) ).ToList();
    
    				
                }
    			else
    			{
    
    			entities = beheerModel.Database.SqlQuery<ClubCloud_Accommodatie>("SELECT * FROM ClubCloud_Accommodatie WHERE  Naam LIKE '%"+ prefixText +"%' OR  BlaashalSoort LIKE '%"+ prefixText +"%' OR  OverkappingSoort LIKE '%"+ prefixText +"%' OR  Email LIKE '%"+ prefixText +"%' OR  Telefoon LIKE '%"+ prefixText +"%' OR  Website LIKE '%"+ prefixText +"%' OR  ClubhuisStatus LIKE '%"+ prefixText +"%' OR  ClubhuisBouwjaar LIKE '%"+ prefixText +"%' OR  ClubhuisBouwaard LIKE '%"+ prefixText +"%' OR  ClubhuisLigging LIKE '%"+ prefixText +"%' OR  ClubhuisBeveiliging LIKE '%"+ prefixText +"%' OR  HalStatus LIKE '%"+ prefixText +"%' OR  HalBouwjaar LIKE '%"+ prefixText +"%' OR  HalBouwaard LIKE '%"+ prefixText +"%' OR  Speeltoestellen LIKE '%"+ prefixText +"%' OR  Actief LIKE '%"+ prefixText +"%'").ToList();
    
    				
    			}
    
    			if (entities != null && entities.Count > 0)
    				return entities;
            }
            catch { };
    
            return new List<ClubCloud_Accommodatie>();
    	}
    
    
    	public List<ClubCloud_Vereniging> GetVerenigingenForAccommodatie(ClubCloud_Accommodatie entity, bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		List<ClubCloud_Vereniging> result = null;
    
    		try
    		{
    			entity = beheerModel.ClubCloud_Accommodaties.Find(entity.Id);
    			if(entity != null && entity.ClubCloud_Vereniging != null && entity.ClubCloud_Vereniging.Count == 0)
    				beheerModel.Entry(entity).Collection(e => e.ClubCloud_Vereniging).Load();
    
    			result = entity.ClubCloud_Vereniging.ToList();
    
    			if(result == null || result.Count == 0 || refresh)
    				result = GetVerenigingenForAccommodatie(settings.Id.ToString(), entity, refresh, settings);
    
    			if(result != null)
    				return result;
    
    			return new List<ClubCloud_Vereniging>();
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
    
    
    	public List<ClubCloud_Vereniging> GetVerenigingenForAccommodatieById(System.Guid Id, bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		ClubCloud_Accommodatie entity = null;
    		List<ClubCloud_Vereniging> result = null;
    
    		try
    		{
    			entity = beheerModel.ClubCloud_Accommodaties.Find(Id);
    			if(entity != null && entity.ClubCloud_Vereniging != null && entity.ClubCloud_Vereniging.Count == 0)
    				beheerModel.Entry(entity).Collection(e => e.ClubCloud_Vereniging).Load();
    
    			result = entity.ClubCloud_Vereniging.ToList();
    
    			if(result == null || result.Count == 0 || refresh)
    				result = GetVerenigingenForAccommodatieById(settings.Id.ToString(), Id, refresh, settings);
    
    			if(result != null)
    				return result;
    
    			return new List<ClubCloud_Vereniging>();
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
    
    	public bool SetVerenigingenForAccommodatie(List<ClubCloud_Vereniging> Verenigingen, ClubCloud_Accommodatie entity, bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		ClubCloud_Accommodatie result = null;
    
    		try
    		{			
    			entity = beheerModel.ClubCloud_Accommodaties.Find(entity.Id);
    		
    			if (entity != null)
    				beheerModel.Entry(entity).Collection(e => e.ClubCloud_Vereniging).Load();
    				//result = GetAccommodatieById(settings.Id.ToString(), Id, refresh, settings);
    
    			if (result != null)
    				//return result.ClubCloud_Accommodaties.Count == ;
    
    			return false;
            }
            finally
            {
    			if(entity != null)
    				try { beheerModel.ObjectContext.Detach(entity); } catch{}
            }
    		return false;
    	}
    
    
    
    	public ClubCloud_District GetDistrictForAccommodatie(ClubCloud_Accommodatie entity, bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		ClubCloud_District result = null;
    
    		try
    		{
    			entity = beheerModel.ClubCloud_Accommodaties.Find(entity.Id);
    			if(entity != null && entity.ClubCloud_District == null)
    				beheerModel.Entry(entity).Reference(e => e.ClubCloud_District).Load();
    
    			result = entity.ClubCloud_District;
    
    			if (result == null || refresh)
    				result = GetDistrictForAccommodatie(settings.Id.ToString(), entity, refresh, settings);
    
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
    
    	public bool SetDistrictForAccommodatie(ClubCloud_District District, ClubCloud_Accommodatie entity , bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		try
    		{		
    			entity = beheerModel.ClubCloud_Accommodaties.Find(entity.Id);	
    
    			if(entity != null && entity.ClubCloud_District == null)
    				beheerModel.Entry(entity).Reference(e => e.ClubCloud_District).Load();
    
    			entity.ClubCloud_District = District;
    
    			beheerModel.SaveChanges();
    			return true;
            }
            finally
            {
    			if(entity != null)
    				try { beheerModel.ObjectContext.Detach(entity); } catch{}
            }
    		return false;
    	}
    
    
    	public ClubCloud_District GetDistrictForAccommodatieById(System.Guid Id, bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		ClubCloud_Accommodatie entity = null;
    		ClubCloud_District result = null;
    
    		try
    		{
    			entity = beheerModel.ClubCloud_Accommodaties.Find(Id);
    			if(entity != null && entity.ClubCloud_District == null)
    				beheerModel.Entry(entity).Reference(e => e.ClubCloud_District).Load();
    
    			result = entity.ClubCloud_District;
    
    			if (result == null || refresh)
    				result = GetDistrictForAccommodatieById(settings.Id.ToString(), Id, refresh, settings);
    
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
    
    	public bool SetDistrictForAccommodatieById(ClubCloud_District District, System.Guid Id , bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		ClubCloud_Accommodatie entity = null;
    
    		try
    		{		
    			entity = beheerModel.ClubCloud_Accommodaties.Find(Id);	
    
    			if(entity != null && entity.ClubCloud_District == null)
    				beheerModel.Entry(entity).Reference(e => e.ClubCloud_District).Load();
    
    			entity.ClubCloud_District = District;
    
    			beheerModel.SaveChanges();
    			return true;
            }
            finally
            {
    			if(entity != null)
    				try { beheerModel.ObjectContext.Detach(entity); } catch{}
            }
    		return false;
    	}
    
    
    	public ClubCloud_Regio GetRegioForAccommodatie(ClubCloud_Accommodatie entity, bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		ClubCloud_Regio result = null;
    
    		try
    		{
    			entity = beheerModel.ClubCloud_Accommodaties.Find(entity.Id);
    			if(entity != null && entity.ClubCloud_Regio == null)
    				beheerModel.Entry(entity).Reference(e => e.ClubCloud_Regio).Load();
    
    			result = entity.ClubCloud_Regio;
    
    			if (result == null || refresh)
    				result = GetRegioForAccommodatie(settings.Id.ToString(), entity, refresh, settings);
    
    			if (result != null)
    				return result;
    
    			return new ClubCloud_Regio();
    		}
            finally
            {
    			if(entity != null)
    				try { beheerModel.ObjectContext.Detach(entity); } catch{}
                if(result != null)
    				try { beheerModel.ObjectContext.Detach(result); } catch{}
            }
    
    	}
    
    	public bool SetRegioForAccommodatie(ClubCloud_Regio Regio, ClubCloud_Accommodatie entity , bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		try
    		{		
    			entity = beheerModel.ClubCloud_Accommodaties.Find(entity.Id);	
    
    			if(entity != null && entity.ClubCloud_Regio == null)
    				beheerModel.Entry(entity).Reference(e => e.ClubCloud_Regio).Load();
    
    			entity.ClubCloud_Regio = Regio;
    
    			beheerModel.SaveChanges();
    			return true;
            }
            finally
            {
    			if(entity != null)
    				try { beheerModel.ObjectContext.Detach(entity); } catch{}
            }
    		return false;
    	}
    
    
    	public ClubCloud_Regio GetRegioForAccommodatieById(System.Guid Id, bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		ClubCloud_Accommodatie entity = null;
    		ClubCloud_Regio result = null;
    
    		try
    		{
    			entity = beheerModel.ClubCloud_Accommodaties.Find(Id);
    			if(entity != null && entity.ClubCloud_Regio == null)
    				beheerModel.Entry(entity).Reference(e => e.ClubCloud_Regio).Load();
    
    			result = entity.ClubCloud_Regio;
    
    			if (result == null || refresh)
    				result = GetRegioForAccommodatieById(settings.Id.ToString(), Id, refresh, settings);
    
    			if (result != null)
    				return result;
    
    			return new ClubCloud_Regio();
    		}
            finally
            {
    			if(entity != null)
    				try { beheerModel.ObjectContext.Detach(entity); } catch{}
                if(result != null)
    				try { beheerModel.ObjectContext.Detach(result); } catch{}
            }
    	}
    
    	public bool SetRegioForAccommodatieById(ClubCloud_Regio Regio, System.Guid Id , bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		ClubCloud_Accommodatie entity = null;
    
    		try
    		{		
    			entity = beheerModel.ClubCloud_Accommodaties.Find(Id);	
    
    			if(entity != null && entity.ClubCloud_Regio == null)
    				beheerModel.Entry(entity).Reference(e => e.ClubCloud_Regio).Load();
    
    			entity.ClubCloud_Regio = Regio;
    
    			beheerModel.SaveChanges();
    			return true;
            }
            finally
            {
    			if(entity != null)
    				try { beheerModel.ObjectContext.Detach(entity); } catch{}
            }
    		return false;
    	}
    
    
    	public List<ClubCloud_Baanblok> GetBaanblokkenForAccommodatie(ClubCloud_Accommodatie entity, bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		List<ClubCloud_Baanblok> result = null;
    
    		try
    		{
    			entity = beheerModel.ClubCloud_Accommodaties.Find(entity.Id);
    			if(entity != null && entity.ClubCloud_Baanblok != null && entity.ClubCloud_Baanblok.Count == 0)
    				beheerModel.Entry(entity).Collection(e => e.ClubCloud_Baanblok).Load();
    
    			result = entity.ClubCloud_Baanblok.ToList();
    
    			if(result == null || result.Count == 0 || refresh)
    				result = GetBaanblokkenForAccommodatie(settings.Id.ToString(), entity, refresh, settings);
    
    			if(result != null)
    				return result;
    
    			return new List<ClubCloud_Baanblok>();
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
    
    
    	public List<ClubCloud_Baanblok> GetBaanblokkenForAccommodatieById(System.Guid Id, bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		ClubCloud_Accommodatie entity = null;
    		List<ClubCloud_Baanblok> result = null;
    
    		try
    		{
    			entity = beheerModel.ClubCloud_Accommodaties.Find(Id);
    			if(entity != null && entity.ClubCloud_Baanblok != null && entity.ClubCloud_Baanblok.Count == 0)
    				beheerModel.Entry(entity).Collection(e => e.ClubCloud_Baanblok).Load();
    
    			result = entity.ClubCloud_Baanblok.ToList();
    
    			if(result == null || result.Count == 0 || refresh)
    				result = GetBaanblokkenForAccommodatieById(settings.Id.ToString(), Id, refresh, settings);
    
    			if(result != null)
    				return result;
    
    			return new List<ClubCloud_Baanblok>();
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
    
    	public bool SetBaanblokkenForAccommodatie(List<ClubCloud_Baanblok> Baanblokken, ClubCloud_Accommodatie entity, bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		ClubCloud_Accommodatie result = null;
    
    		try
    		{			
    			entity = beheerModel.ClubCloud_Accommodaties.Find(entity.Id);
    		
    			if (entity != null)
    				beheerModel.Entry(entity).Collection(e => e.ClubCloud_Baanblok).Load();
    				//result = GetAccommodatieById(settings.Id.ToString(), Id, refresh, settings);
    
    			if (result != null)
    				//return result.ClubCloud_Accommodaties.Count == ;
    
    			return false;
            }
            finally
            {
    			if(entity != null)
    				try { beheerModel.ObjectContext.Detach(entity); } catch{}
            }
    		return false;
    	}
    
    
    
    	public List<ClubCloud_Baan> GetBanenForAccommodatie(ClubCloud_Accommodatie entity, bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		List<ClubCloud_Baan> result = null;
    
    		try
    		{
    			entity = beheerModel.ClubCloud_Accommodaties.Find(entity.Id);
    			if(entity != null && entity.ClubCloud_Baan != null && entity.ClubCloud_Baan.Count == 0)
    				beheerModel.Entry(entity).Collection(e => e.ClubCloud_Baan).Load();
    
    			result = entity.ClubCloud_Baan.ToList();
    
    			if(result == null || result.Count == 0 || refresh)
    				result = GetBanenForAccommodatie(settings.Id.ToString(), entity, refresh, settings);
    
    			if(result != null)
    				return result;
    
    			return new List<ClubCloud_Baan>();
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
    
    
    	public List<ClubCloud_Baan> GetBanenForAccommodatieById(System.Guid Id, bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		ClubCloud_Accommodatie entity = null;
    		List<ClubCloud_Baan> result = null;
    
    		try
    		{
    			entity = beheerModel.ClubCloud_Accommodaties.Find(Id);
    			if(entity != null && entity.ClubCloud_Baan != null && entity.ClubCloud_Baan.Count == 0)
    				beheerModel.Entry(entity).Collection(e => e.ClubCloud_Baan).Load();
    
    			result = entity.ClubCloud_Baan.ToList();
    
    			if(result == null || result.Count == 0 || refresh)
    				result = GetBanenForAccommodatieById(settings.Id.ToString(), Id, refresh, settings);
    
    			if(result != null)
    				return result;
    
    			return new List<ClubCloud_Baan>();
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
    
    	public bool SetBanenForAccommodatie(List<ClubCloud_Baan> Banen, ClubCloud_Accommodatie entity, bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		ClubCloud_Accommodatie result = null;
    
    		try
    		{			
    			entity = beheerModel.ClubCloud_Accommodaties.Find(entity.Id);
    		
    			if (entity != null)
    				beheerModel.Entry(entity).Collection(e => e.ClubCloud_Baan).Load();
    				//result = GetAccommodatieById(settings.Id.ToString(), Id, refresh, settings);
    
    			if (result != null)
    				//return result.ClubCloud_Accommodaties.Count == ;
    
    			return false;
            }
            finally
            {
    			if(entity != null)
    				try { beheerModel.ObjectContext.Detach(entity); } catch{}
            }
    		return false;
    	}
    
    
    
    	public List<ClubCloud_BaanSpeciaal> GetBanenSpeciaalForAccommodatie(ClubCloud_Accommodatie entity, bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		List<ClubCloud_BaanSpeciaal> result = null;
    
    		try
    		{
    			entity = beheerModel.ClubCloud_Accommodaties.Find(entity.Id);
    			if(entity != null && entity.ClubCloud_BaanSpeciaal != null && entity.ClubCloud_BaanSpeciaal.Count == 0)
    				beheerModel.Entry(entity).Collection(e => e.ClubCloud_BaanSpeciaal).Load();
    
    			result = entity.ClubCloud_BaanSpeciaal.ToList();
    
    			if(result == null || result.Count == 0 || refresh)
    				result = GetBanenSpeciaalForAccommodatie(settings.Id.ToString(), entity, refresh, settings);
    
    			if(result != null)
    				return result;
    
    			return new List<ClubCloud_BaanSpeciaal>();
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
    
    
    	public List<ClubCloud_BaanSpeciaal> GetBanenSpeciaalForAccommodatieById(System.Guid Id, bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		ClubCloud_Accommodatie entity = null;
    		List<ClubCloud_BaanSpeciaal> result = null;
    
    		try
    		{
    			entity = beheerModel.ClubCloud_Accommodaties.Find(Id);
    			if(entity != null && entity.ClubCloud_BaanSpeciaal != null && entity.ClubCloud_BaanSpeciaal.Count == 0)
    				beheerModel.Entry(entity).Collection(e => e.ClubCloud_BaanSpeciaal).Load();
    
    			result = entity.ClubCloud_BaanSpeciaal.ToList();
    
    			if(result == null || result.Count == 0 || refresh)
    				result = GetBanenSpeciaalForAccommodatieById(settings.Id.ToString(), Id, refresh, settings);
    
    			if(result != null)
    				return result;
    
    			return new List<ClubCloud_BaanSpeciaal>();
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
    
    	public bool SetBanenSpeciaalForAccommodatie(List<ClubCloud_BaanSpeciaal> BanenSpeciaal, ClubCloud_Accommodatie entity, bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		ClubCloud_Accommodatie result = null;
    
    		try
    		{			
    			entity = beheerModel.ClubCloud_Accommodaties.Find(entity.Id);
    		
    			if (entity != null)
    				beheerModel.Entry(entity).Collection(e => e.ClubCloud_BaanSpeciaal).Load();
    				//result = GetAccommodatieById(settings.Id.ToString(), Id, refresh, settings);
    
    			if (result != null)
    				//return result.ClubCloud_Accommodaties.Count == ;
    
    			return false;
            }
            finally
            {
    			if(entity != null)
    				try { beheerModel.ObjectContext.Detach(entity); } catch{}
            }
    		return false;
    	}
    
    
    
    	public List<ClubCloud_Address> GetAddressenForAccommodatie(ClubCloud_Accommodatie entity, bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		List<ClubCloud_Address> result = null;
    
    		try
    		{
    			entity = beheerModel.ClubCloud_Accommodaties.Find(entity.Id);
    			if(entity != null && entity.ClubCloud_Address != null && entity.ClubCloud_Address.Count == 0)
    				beheerModel.Entry(entity).Collection(e => e.ClubCloud_Address).Load();
    
    			result = entity.ClubCloud_Address.ToList();
    
    			if(result == null || result.Count == 0 || refresh)
    				result = GetAddressenForAccommodatie(settings.Id.ToString(), entity, refresh, settings);
    
    			if(result != null)
    				return result;
    
    			return new List<ClubCloud_Address>();
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
    
    
    	public List<ClubCloud_Address> GetAddressenForAccommodatieById(System.Guid Id, bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		ClubCloud_Accommodatie entity = null;
    		List<ClubCloud_Address> result = null;
    
    		try
    		{
    			entity = beheerModel.ClubCloud_Accommodaties.Find(Id);
    			if(entity != null && entity.ClubCloud_Address != null && entity.ClubCloud_Address.Count == 0)
    				beheerModel.Entry(entity).Collection(e => e.ClubCloud_Address).Load();
    
    			result = entity.ClubCloud_Address.ToList();
    
    			if(result == null || result.Count == 0 || refresh)
    				result = GetAddressenForAccommodatieById(settings.Id.ToString(), Id, refresh, settings);
    
    			if(result != null)
    				return result;
    
    			return new List<ClubCloud_Address>();
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
    
    	public bool SetAddressenForAccommodatie(List<ClubCloud_Address> Addressen, ClubCloud_Accommodatie entity, bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		ClubCloud_Accommodatie result = null;
    
    		try
    		{			
    			entity = beheerModel.ClubCloud_Accommodaties.Find(entity.Id);
    		
    			if (entity != null)
    				beheerModel.Entry(entity).Collection(e => e.ClubCloud_Address).Load();
    				//result = GetAccommodatieById(settings.Id.ToString(), Id, refresh, settings);
    
    			if (result != null)
    				//return result.ClubCloud_Accommodaties.Count == ;
    
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
    [KnownType(typeof(ClubCloud_Accommodatie))]
    public partial class ClubCloud_Accommodatie_View
    {
    	public ClubCloud_Accommodatie_View()
    	{
    		this.ClubCloud_Accommodatie = new HashSet<ClubCloud_Accommodatie>();
    	}
    
    	[DataMember]
    	public int TotalRowCount { get; set; }
    
    	[DataMember]
    	public virtual ICollection<ClubCloud_Accommodatie> ClubCloud_Accommodatie { get; set; }
    
    }
    	
}

