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
    	public ClubCloud_Baanschema GetBaanschemaById(System.Guid Id , bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		ClubCloud_Baanschema result = null;
    
    		try
    		{			
    			result = beheerModel.ClubCloud_Baanschemas.Find(Id);
    		
    			if (result == null || refresh)
    				result = GetBaanschemaById(settings.Id.ToString(), Id, refresh, settings);
    
    			if (result != null)
    				return result;
    
    			return new ClubCloud_Baanschema();
            }
            finally
            {
    			if(result != null)
    				try { beheerModel.ObjectContext.Detach(result);} catch{}
            }
    
    	}
    
    	public List<ClubCloud_Baanschema> GetBaanschemas(bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		List<ClubCloud_Baanschema> result = null;
    		
    		try
    		{
    			result = beheerModel.ClubCloud_Baanschemas.ToList<ClubCloud_Baanschema>();
    		
    			if (result == null || result.Count == 0 || refresh)		
    				result = GetBaanschemas(settings.Id.ToString(), refresh, settings);
    
    			if(result != null)
    				return result;
    
    			return new List<ClubCloud_Baanschema>();
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
    
    	public ClubCloud_Baanschema SetBaanschema(ClubCloud_Baanschema entity, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		ClubCloud_Baanschema tobeupdated = null;
    		
    		try
    		{
    			entity = SetBaanschema(settings.Id.ToString(), entity, settings);
    
    			beheerModel.ClubCloud_Baanschemas.AddOrUpdate(entity);
    		
    			beheerModel.SaveChanges();
    
    			tobeupdated = beheerModel.ClubCloud_Baanschemas.Find(entity.Id);
    			return tobeupdated;
            }
            finally
            {
    			if(tobeupdated != null)
    				try { beheerModel.ObjectContext.Detach(tobeupdated); } catch{}
            }
    
    	}
    
    
    	public bool DeleteBaanschema(ClubCloud_Baanschema entity, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		return DeleteBaanschemaById(entity.Id, settings);
    	}
    
    	public bool DeleteBaanschemaById(System.Guid Id, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		ClubCloud_Baanschema tobedeleted = null;
    		try
    		{
    
    			tobedeleted = beheerModel.ClubCloud_Baanschemas.Find(Id);
    		
    			if (tobedeleted != null)
    			{
    				beheerModel.ClubCloud_Baanschemas.Remove(tobedeleted);
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
    
    
    	public ClubCloud_Baanschema_View GetBaanschemasByQuery(string bondsnummer, Guid verenigingId,System.Web.UI.DataSourceSelectArguments selectArgs = null, List<System.Web.UI.WebControls.Parameter> parameters = null, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		ClubCloud_Baanschema_View view = new ClubCloud_Baanschema_View();
    
    		StringBuilder querybuilder = new StringBuilder("SELECT * FROM dbo.ClubCloud_Baanschema");
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
    
    		view.ClubCloud_Baanschema = beheerModel.Database.SqlQuery<ClubCloud_Baanschema>(querybuilder.ToString(), sqlparams.ToArray()).Skip(selectArgs.StartRowIndex).Take(selectArgs.MaximumRows).ToList<ClubCloud_Baanschema>();
    
    		if (selectArgs.RetrieveTotalRowCount)
    		{
    
    			view.TotalRowCount = beheerModel.Database.SqlQuery<ClubCloud_Baanschema>(querybuilder.ToString(), sqlparamscount.ToArray()).Count();
    		}
    		return view;
    	}
    
    	public List<ClubCloud_Baanschema> GetBaanschemasBySearch(string prefixText, int count, string contextKey, ClubCloud_Setting _settings = null)
    	{
    		if(_settings != null)
    			ValidateSettings(ref _settings);
    
            List<string> baanschemas = new List<string>();
            try
            {
                bool enabled = beheerModel.Database.SqlQuery<bool>("SELECT (CAST((FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))AS BIT))").FirstOrDefault();
    
                List<ClubCloud_Baanschema> entities = null;
    
                if (enabled)
                {
                    var fts = BeheerFullTextInterceptor.Fts(prefixText);
    				
    				
                }
    			else
    			{
    				
    			}
    
    			if (entities != null && entities.Count > 0)
    				return entities;
            }
            catch { };
    
            return new List<ClubCloud_Baanschema>();
    	}
    
    
    	public ClubCloud_Baan GetBaanForBaanschema(ClubCloud_Baanschema entity, bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		ClubCloud_Baan result = null;
    
    		try
    		{
    			entity = beheerModel.ClubCloud_Baanschemas.Find(entity.Id);
    			if(entity != null && entity.ClubCloud_Baan == null)
    				beheerModel.Entry(entity).Reference(e => e.ClubCloud_Baan).Load();
    
    			result = entity.ClubCloud_Baan;
    
    			if (result == null || refresh)
    				result = GetBaanForBaanschema(settings.Id.ToString(), entity, refresh, settings);
    
    			if (result != null)
    				return result;
    
    			return new ClubCloud_Baan();
    		}
            finally
            {
    			if(entity != null)
    				try { beheerModel.ObjectContext.Detach(entity); } catch{}
                if(result != null)
    				try { beheerModel.ObjectContext.Detach(result); } catch{}
            }
    
    	}
    
    	public bool SetBaanForBaanschema(ClubCloud_Baan Baan, ClubCloud_Baanschema entity , bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		try
    		{		
    			entity = beheerModel.ClubCloud_Baanschemas.Find(entity.Id);	
    
    			if(entity != null && entity.ClubCloud_Baan == null)
    				beheerModel.Entry(entity).Reference(e => e.ClubCloud_Baan).Load();
    
    			entity.ClubCloud_Baan = Baan;
    
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
    
    
    	public ClubCloud_Baan GetBaanForBaanschemaById(System.Guid Id, bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		ClubCloud_Baanschema entity = null;
    		ClubCloud_Baan result = null;
    
    		try
    		{
    			entity = beheerModel.ClubCloud_Baanschemas.Find(Id);
    			if(entity != null && entity.ClubCloud_Baan == null)
    				beheerModel.Entry(entity).Reference(e => e.ClubCloud_Baan).Load();
    
    			result = entity.ClubCloud_Baan;
    
    			if (result == null || refresh)
    				result = GetBaanForBaanschemaById(settings.Id.ToString(), Id, refresh, settings);
    
    			if (result != null)
    				return result;
    
    			return new ClubCloud_Baan();
    		}
            finally
            {
    			if(entity != null)
    				try { beheerModel.ObjectContext.Detach(entity); } catch{}
                if(result != null)
    				try { beheerModel.ObjectContext.Detach(result); } catch{}
            }
    	}
    
    	public bool SetBaanForBaanschemaById(ClubCloud_Baan Baan, System.Guid Id , bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		ClubCloud_Baanschema entity = null;
    
    		try
    		{		
    			entity = beheerModel.ClubCloud_Baanschemas.Find(Id);	
    
    			if(entity != null && entity.ClubCloud_Baan == null)
    				beheerModel.Entry(entity).Reference(e => e.ClubCloud_Baan).Load();
    
    			entity.ClubCloud_Baan = Baan;
    
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
    
    
    	public ClubCloud_Vereniging GetVerenigingForBaanschema(ClubCloud_Baanschema entity, bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		ClubCloud_Vereniging result = null;
    
    		try
    		{
    			entity = beheerModel.ClubCloud_Baanschemas.Find(entity.Id);
    			if(entity != null && entity.ClubCloud_Vereniging == null)
    				beheerModel.Entry(entity).Reference(e => e.ClubCloud_Vereniging).Load();
    
    			result = entity.ClubCloud_Vereniging;
    
    			if (result == null || refresh)
    				result = GetVerenigingForBaanschema(settings.Id.ToString(), entity, refresh, settings);
    
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
    
    	public bool SetVerenigingForBaanschema(ClubCloud_Vereniging Vereniging, ClubCloud_Baanschema entity , bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		try
    		{		
    			entity = beheerModel.ClubCloud_Baanschemas.Find(entity.Id);	
    
    			if(entity != null && entity.ClubCloud_Vereniging == null)
    				beheerModel.Entry(entity).Reference(e => e.ClubCloud_Vereniging).Load();
    
    			entity.ClubCloud_Vereniging = Vereniging;
    
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
    
    
    	public ClubCloud_Vereniging GetVerenigingForBaanschemaById(System.Guid Id, bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		ClubCloud_Baanschema entity = null;
    		ClubCloud_Vereniging result = null;
    
    		try
    		{
    			entity = beheerModel.ClubCloud_Baanschemas.Find(Id);
    			if(entity != null && entity.ClubCloud_Vereniging == null)
    				beheerModel.Entry(entity).Reference(e => e.ClubCloud_Vereniging).Load();
    
    			result = entity.ClubCloud_Vereniging;
    
    			if (result == null || refresh)
    				result = GetVerenigingForBaanschemaById(settings.Id.ToString(), Id, refresh, settings);
    
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
    
    	public bool SetVerenigingForBaanschemaById(ClubCloud_Vereniging Vereniging, System.Guid Id , bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		ClubCloud_Baanschema entity = null;
    
    		try
    		{		
    			entity = beheerModel.ClubCloud_Baanschemas.Find(Id);	
    
    			if(entity != null && entity.ClubCloud_Vereniging == null)
    				beheerModel.Entry(entity).Reference(e => e.ClubCloud_Vereniging).Load();
    
    			entity.ClubCloud_Vereniging = Vereniging;
    
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
    
    }
    
    [Serializable]
    [DataContract(IsReference = true)]
    [KnownType(typeof(ClubCloud_Baanschema))]
    public partial class ClubCloud_Baanschema_View
    {
    	public ClubCloud_Baanschema_View()
    	{
    		this.ClubCloud_Baanschema = new HashSet<ClubCloud_Baanschema>();
    	}
    
    	[DataMember]
    	public int TotalRowCount { get; set; }
    
    	[DataMember]
    	public virtual ICollection<ClubCloud_Baanschema> ClubCloud_Baanschema { get; set; }
    
    }
    	
}

