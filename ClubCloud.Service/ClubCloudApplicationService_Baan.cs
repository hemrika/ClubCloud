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
    	public ClubCloud_Baan GetBaanById(System.Guid Id , bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		ClubCloud_Baan result = null;
    
    		try
    		{			
    			result = beheerModel.ClubCloud_Banen.Find(Id);
    		
    			if (result == null || refresh)
    				result = GetBaanById(settings.Id.ToString(), Id, refresh, settings);
    
    			if (result != null)
    				return result;
    
    			return new ClubCloud_Baan();
            }
            finally
            {
    			if(result != null)
    				beheerModel.ObjectContext.Detach(result);
            }
    
    	}
    
    	public List<ClubCloud_Baan> GetBanen(bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		List<ClubCloud_Baan> result = null;
    		
    		try
    		{
    			result = beheerModel.ClubCloud_Banen.ToList<ClubCloud_Baan>();
    		
    			if (result == null || result.Count == 0 || refresh)		
    				result = GetBanen(settings.Id.ToString(), refresh, settings);
    
    			if(result != null)
    				return result;
    
    			return new List<ClubCloud_Baan>();
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
    
    	public ClubCloud_Baan SetBaan(ClubCloud_Baan entity, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		ClubCloud_Baan tobeupdated = null;
    		
    		try
    		{
    			entity = SetBaan(settings.Id.ToString(), entity, settings);
    
    			beheerModel.ClubCloud_Banen.AddOrUpdate(entity);
    		
    			beheerModel.SaveChanges();
    
    			tobeupdated = beheerModel.ClubCloud_Banen.Find(entity.Id);
    			return tobeupdated;
            }
            finally
            {
    			if(tobeupdated != null)
    				beheerModel.ObjectContext.Detach(tobeupdated);
            }
    
    	}
    
    
    	public bool DeleteBaan(ClubCloud_Baan entity, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		return DeleteBaanById(entity.Id, settings);
    	}
    
    	public bool DeleteBaanById(System.Guid Id, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		ClubCloud_Baan tobedeleted = null;
    		try
    		{
    
    			tobedeleted = beheerModel.ClubCloud_Banen.Find(Id);
    		
    			if (tobedeleted != null)
    			{
    				beheerModel.ClubCloud_Banen.Remove(tobedeleted);
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
    
    
    	public ClubCloud_Baan_View GetBanenByQuery(string bondsnummer, Guid verenigingId,System.Web.UI.DataSourceSelectArguments selectArgs = null, List<System.Web.UI.WebControls.Parameter> parameters = null, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		ClubCloud_Baan_View view = new ClubCloud_Baan_View();
    
    		StringBuilder querybuilder = new StringBuilder("SELECT * FROM dbo.ClubCloud_Baan");
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
    
    		view.ClubCloud_Baan = beheerModel.Database.SqlQuery<ClubCloud_Baan>(querybuilder.ToString(), sqlparams.ToArray()).Skip(selectArgs.StartRowIndex).Take(selectArgs.MaximumRows).ToList<ClubCloud_Baan>();
    
    		if (selectArgs.RetrieveTotalRowCount)
    		{
    
    			view.TotalRowCount = beheerModel.Database.SqlQuery<ClubCloud_Baan>(querybuilder.ToString(), sqlparamscount.ToArray()).Count();
    		}
    		return view;
    	}
    
    	public List<ClubCloud_Baan> GetBanenBySearch(string prefixText, int count, string contextKey, ClubCloud_Setting _settings = null)
    	{
    		if(_settings != null)
    			ValidateSettings(ref _settings);
    
            List<string> banen = new List<string>();
            try
            {
                bool enabled = beheerModel.Database.SqlQuery<bool>("SELECT (CAST((FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))AS BIT))").FirstOrDefault();
    
                List<ClubCloud_Baan> entities = null;
    
                if (enabled)
                {
                    var fts = BeheerFullTextInterceptor.Fts(prefixText);
    				
    
    			entities = beheerModel.ClubCloud_Banen.Where(e => e.Naam.Contains(fts)  || e.Status.Contains(fts)  || e.Actief.Contains(fts) ).ToList();
    
    				
                }
    			else
    			{
    
    			entities = beheerModel.Database.SqlQuery<ClubCloud_Baan>("SELECT * FROM ClubCloud_Baan WHERE  Naam LIKE '%"+ prefixText +"%' OR  Status LIKE '%"+ prefixText +"%' OR  Actief LIKE '%"+ prefixText +"%'").ToList();
    
    				
    			}
    
    			if (entities != null && entities.Count > 0)
    				return entities;
            }
            catch { };
    
            return new List<ClubCloud_Baan>();
    	}
    
    
    	public ClubCloud_Baanblok GetBaanblokForBaan(ClubCloud_Baan entity, bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		ClubCloud_Baanblok result = null;
    
    		try
    		{
    			entity = beheerModel.ClubCloud_Banen.Find(entity.Id);
    			if(entity != null && entity.ClubCloud_Baanblok == null)
    				beheerModel.Entry(entity).Reference(e => e.ClubCloud_Baanblok).Load();
    
    			result = entity.ClubCloud_Baanblok;
    
    			if (result == null || refresh)
    				result = GetBaanblokForBaan(settings.Id.ToString(), entity, refresh, settings);
    
    			if (result != null)
    				return result;
    
    			return new ClubCloud_Baanblok();
    		}
            finally
            {
    			if(entity != null)
    				beheerModel.ObjectContext.Detach(entity);
                if(result != null)
    				beheerModel.ObjectContext.Detach(result);
            }
    
    	}
    
    	public bool SetBaanblokForBaan(ClubCloud_Baanblok Baanblok, ClubCloud_Baan entity , bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		try
    		{		
    			entity = beheerModel.ClubCloud_Banen.Find(entity.Id);	
    
    			if(entity != null && entity.ClubCloud_Baanblok == null)
    				beheerModel.Entry(entity).Reference(e => e.ClubCloud_Baanblok).Load();
    
    			entity.ClubCloud_Baanblok = Baanblok;
    
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
    
    
    	public ClubCloud_Baanblok GetBaanblokForBaanById(System.Guid Id, bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		ClubCloud_Baan entity = null;
    		ClubCloud_Baanblok result = null;
    
    		try
    		{
    			entity = beheerModel.ClubCloud_Banen.Find(Id);
    			if(entity != null && entity.ClubCloud_Baanblok == null)
    				beheerModel.Entry(entity).Reference(e => e.ClubCloud_Baanblok).Load();
    
    			result = entity.ClubCloud_Baanblok;
    
    			if (result == null || refresh)
    				result = GetBaanblokForBaanById(settings.Id.ToString(), Id, refresh, settings);
    
    			if (result != null)
    				return result;
    
    			return new ClubCloud_Baanblok();
    		}
            finally
            {
    			if(entity != null)
    				beheerModel.ObjectContext.Detach(entity);
                if(result != null)
    				beheerModel.ObjectContext.Detach(result);
            }
    	}
    
    	public bool SetBaanblokForBaanById(ClubCloud_Baanblok Baanblok, System.Guid Id , bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		ClubCloud_Baan entity = null;
    
    		try
    		{		
    			entity = beheerModel.ClubCloud_Banen.Find(Id);	
    
    			if(entity != null && entity.ClubCloud_Baanblok == null)
    				beheerModel.Entry(entity).Reference(e => e.ClubCloud_Baanblok).Load();
    
    			entity.ClubCloud_Baanblok = Baanblok;
    
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
    
    
    	public ClubCloud_Accommodatie GetAccommodatieForBaan(ClubCloud_Baan entity, bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		ClubCloud_Accommodatie result = null;
    
    		try
    		{
    			entity = beheerModel.ClubCloud_Banen.Find(entity.Id);
    			if(entity != null && entity.ClubCloud_Accommodatie == null)
    				beheerModel.Entry(entity).Reference(e => e.ClubCloud_Accommodatie).Load();
    
    			result = entity.ClubCloud_Accommodatie;
    
    			if (result == null || refresh)
    				result = GetAccommodatieForBaan(settings.Id.ToString(), entity, refresh, settings);
    
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
    
    	public bool SetAccommodatieForBaan(ClubCloud_Accommodatie Accommodatie, ClubCloud_Baan entity , bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		try
    		{		
    			entity = beheerModel.ClubCloud_Banen.Find(entity.Id);	
    
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
    
    
    	public ClubCloud_Accommodatie GetAccommodatieForBaanById(System.Guid Id, bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		ClubCloud_Baan entity = null;
    		ClubCloud_Accommodatie result = null;
    
    		try
    		{
    			entity = beheerModel.ClubCloud_Banen.Find(Id);
    			if(entity != null && entity.ClubCloud_Accommodatie == null)
    				beheerModel.Entry(entity).Reference(e => e.ClubCloud_Accommodatie).Load();
    
    			result = entity.ClubCloud_Accommodatie;
    
    			if (result == null || refresh)
    				result = GetAccommodatieForBaanById(settings.Id.ToString(), Id, refresh, settings);
    
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
    
    	public bool SetAccommodatieForBaanById(ClubCloud_Accommodatie Accommodatie, System.Guid Id , bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		ClubCloud_Baan entity = null;
    
    		try
    		{		
    			entity = beheerModel.ClubCloud_Banen.Find(Id);	
    
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
    
    
    	public List<ClubCloud_Baanschema> GetBaanschemasForBaan(ClubCloud_Baan entity, bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		List<ClubCloud_Baanschema> result = null;
    
    		try
    		{
    			entity = beheerModel.ClubCloud_Banen.Find(entity.Id);
    			if(entity != null && entity.ClubCloud_Baanschema != null && entity.ClubCloud_Baanschema.Count == 0)
    				beheerModel.Entry(entity).Collection(e => e.ClubCloud_Baanschema).Load();
    
    			result = entity.ClubCloud_Baanschema.ToList();
    
    			if(result == null || result.Count == 0 || refresh)
    				result = GetBaanschemasForBaan(settings.Id.ToString(), entity, refresh, settings);
    
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
    
    
    	public List<ClubCloud_Baanschema> GetBaanschemasForBaanById(System.Guid Id, bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		ClubCloud_Baan entity = null;
    		List<ClubCloud_Baanschema> result = null;
    
    		try
    		{
    			entity = beheerModel.ClubCloud_Banen.Find(Id);
    			if(entity != null && entity.ClubCloud_Baanschema != null && entity.ClubCloud_Baanschema.Count == 0)
    				beheerModel.Entry(entity).Collection(e => e.ClubCloud_Baanschema).Load();
    
    			result = entity.ClubCloud_Baanschema.ToList();
    
    			if(result == null || result.Count == 0 || refresh)
    				result = GetBaanschemasForBaanById(settings.Id.ToString(), Id, refresh, settings);
    
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
    
    	public bool SetBaanschemasForBaan(List<ClubCloud_Baanschema> Baanschemas, ClubCloud_Baan entity, bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		ClubCloud_Baan result = null;
    
    		try
    		{			
    			entity = beheerModel.ClubCloud_Banen.Find(entity.Id);
    		
    			if (entity != null)
    				beheerModel.Entry(entity).Collection(e => e.ClubCloud_Baanschema).Load();
    				//result = GetBaanById(settings.Id.ToString(), Id, refresh, settings);
    
    			if (result != null)
    				//return result.ClubCloud_Banen.Count == ;
    
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
    [KnownType(typeof(ClubCloud_Baan))]
    public partial class ClubCloud_Baan_View
    {
    	public ClubCloud_Baan_View()
    	{
    		this.ClubCloud_Baan = new HashSet<ClubCloud_Baan>();
    	}
    
    	[DataMember]
    	public int TotalRowCount { get; set; }
    
    	[DataMember]
    	public virtual ICollection<ClubCloud_Baan> ClubCloud_Baan { get; set; }
    
    }
    	
}

