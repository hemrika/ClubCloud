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
    	public ClubCloud_Baanblok GetBaanblokById(System.Guid Id , bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		ClubCloud_Baanblok result = null;
    
    		try
    		{			
    			result = beheerModel.ClubCloud_Baanblokken.Find(Id);
    		
    			if (result == null || refresh)
    				result = GetBaanblokById(settings.Id.ToString(), Id, refresh, settings);
    
    			if (result != null)
    				return result;
    
    			return new ClubCloud_Baanblok();
            }
            finally
            {
    			if(result != null)
    				try { beheerModel.ObjectContext.Detach(result);} catch{}
            }
    
    	}
    
    	public List<ClubCloud_Baanblok> GetBaanblokken(bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		List<ClubCloud_Baanblok> result = null;
    		
    		try
    		{
    			result = beheerModel.ClubCloud_Baanblokken.ToList<ClubCloud_Baanblok>();
    		
    			if (result == null || result.Count == 0 || refresh)		
    				result = GetBaanblokken(settings.Id.ToString(), refresh, settings);
    
    			if(result != null)
    				return result;
    
    			return new List<ClubCloud_Baanblok>();
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
    
    	public ClubCloud_Baanblok SetBaanblok(ClubCloud_Baanblok entity, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		ClubCloud_Baanblok tobeupdated = null;
    		
    		try
    		{
    			entity = SetBaanblok(settings.Id.ToString(), entity, settings);
    
    			beheerModel.ClubCloud_Baanblokken.AddOrUpdate(entity);
    		
    			beheerModel.SaveChanges();
    
    			tobeupdated = beheerModel.ClubCloud_Baanblokken.Find(entity.Id);
    			return tobeupdated;
            }
            finally
            {
    			if(tobeupdated != null)
    				try { beheerModel.ObjectContext.Detach(tobeupdated); } catch{}
            }
    
    	}
    
    
    	public bool DeleteBaanblok(ClubCloud_Baanblok entity, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		return DeleteBaanblokById(entity.Id, settings);
    	}
    
    	public bool DeleteBaanblokById(System.Guid Id, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		ClubCloud_Baanblok tobedeleted = null;
    		try
    		{
    
    			tobedeleted = beheerModel.ClubCloud_Baanblokken.Find(Id);
    		
    			if (tobedeleted != null)
    			{
    				beheerModel.ClubCloud_Baanblokken.Remove(tobedeleted);
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
    
    
    	public ClubCloud_Baanblok_View GetBaanblokkenByQuery(string bondsnummer, Guid verenigingId,System.Web.UI.DataSourceSelectArguments selectArgs = null, List<System.Web.UI.WebControls.Parameter> parameters = null, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		ClubCloud_Baanblok_View view = new ClubCloud_Baanblok_View();
    
    		StringBuilder querybuilder = new StringBuilder("SELECT * FROM dbo.ClubCloud_Baanblok");
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
    
    		view.ClubCloud_Baanblok = beheerModel.Database.SqlQuery<ClubCloud_Baanblok>(querybuilder.ToString(), sqlparams.ToArray()).Skip(selectArgs.StartRowIndex).Take(selectArgs.MaximumRows).ToList<ClubCloud_Baanblok>();
    
    		if (selectArgs.RetrieveTotalRowCount)
    		{
    
    			view.TotalRowCount = beheerModel.Database.SqlQuery<ClubCloud_Baanblok>(querybuilder.ToString(), sqlparamscount.ToArray()).Count();
    		}
    		return view;
    	}
    
    	public List<ClubCloud_Baanblok> GetBaanblokkenBySearch(string prefixText, int count, string contextKey, ClubCloud_Setting _settings = null)
    	{
    		if(_settings != null)
    			ValidateSettings(ref _settings);
    
            List<string> baanblokken = new List<string>();
            try
            {
                bool enabled = beheerModel.Database.SqlQuery<bool>("SELECT (CAST((FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))AS BIT))").FirstOrDefault();
    
                List<ClubCloud_Baanblok> entities = null;
    
                if (enabled)
                {
                    var fts = BeheerFullTextInterceptor.Fts(prefixText);
    				
    
    			entities = beheerModel.ClubCloud_Baanblokken.Where(e => e.Naam.Contains(fts)  || e.Locatie.Contains(fts)  || e.Actief.Contains(fts) ).ToList();
    
    				
                }
    			else
    			{
    
    			entities = beheerModel.Database.SqlQuery<ClubCloud_Baanblok>("SELECT * FROM ClubCloud_Baanblok WHERE  Naam LIKE '%"+ prefixText +"%' OR  Locatie LIKE '%"+ prefixText +"%' OR  Actief LIKE '%"+ prefixText +"%'").ToList();
    
    				
    			}
    
    			if (entities != null && entities.Count > 0)
    				return entities;
            }
            catch { };
    
            return new List<ClubCloud_Baanblok>();
    	}
    
    
    	public List<ClubCloud_Baan> GetBanenForBaanblok(ClubCloud_Baanblok entity, bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		List<ClubCloud_Baan> result = null;
    
    		try
    		{
    			entity = beheerModel.ClubCloud_Baanblokken.Find(entity.Id);
    			if(entity != null && entity.ClubCloud_Baan != null && entity.ClubCloud_Baan.Count == 0)
    				beheerModel.Entry(entity).Collection(e => e.ClubCloud_Baan).Load();
    
    			result = entity.ClubCloud_Baan.ToList();
    
    			if(result == null || result.Count == 0 || refresh)
    				result = GetBanenForBaanblok(settings.Id.ToString(), entity, refresh, settings);
    
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
    
    
    	public List<ClubCloud_Baan> GetBanenForBaanblokById(System.Guid Id, bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		ClubCloud_Baanblok entity = null;
    		List<ClubCloud_Baan> result = null;
    
    		try
    		{
    			entity = beheerModel.ClubCloud_Baanblokken.Find(Id);
    			if(entity != null && entity.ClubCloud_Baan != null && entity.ClubCloud_Baan.Count == 0)
    				beheerModel.Entry(entity).Collection(e => e.ClubCloud_Baan).Load();
    
    			result = entity.ClubCloud_Baan.ToList();
    
    			if(result == null || result.Count == 0 || refresh)
    				result = GetBanenForBaanblokById(settings.Id.ToString(), Id, refresh, settings);
    
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
    
    	public bool SetBanenForBaanblok(List<ClubCloud_Baan> Banen, ClubCloud_Baanblok entity, bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		ClubCloud_Baanblok result = null;
    
    		try
    		{			
    			entity = beheerModel.ClubCloud_Baanblokken.Find(entity.Id);
    		
    			if (entity != null)
    				beheerModel.Entry(entity).Collection(e => e.ClubCloud_Baan).Load();
    				//result = GetBaanblokById(settings.Id.ToString(), Id, refresh, settings);
    
    			if (result != null)
    				//return result.ClubCloud_Baanblokken.Count == ;
    
    			return false;
            }
            finally
            {
    			if(entity != null)
    				try { beheerModel.ObjectContext.Detach(entity); } catch{}
            }
    		return false;
    	}
    
    
    
    	public ClubCloud_Accommodatie GetAccommodatieForBaanblok(ClubCloud_Baanblok entity, bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		ClubCloud_Accommodatie result = null;
    
    		try
    		{
    			entity = beheerModel.ClubCloud_Baanblokken.Find(entity.Id);
    			if(entity != null && entity.ClubCloud_Accommodatie == null)
    				beheerModel.Entry(entity).Reference(e => e.ClubCloud_Accommodatie).Load();
    
    			result = entity.ClubCloud_Accommodatie;
    
    			if (result == null || refresh)
    				result = GetAccommodatieForBaanblok(settings.Id.ToString(), entity, refresh, settings);
    
    			if (result != null)
    				return result;
    
    			return new ClubCloud_Accommodatie();
    		}
            finally
            {
    			if(entity != null)
    				try { beheerModel.ObjectContext.Detach(entity); } catch{}
                if(result != null)
    				try { beheerModel.ObjectContext.Detach(result); } catch{}
            }
    
    	}
    
    	public bool SetAccommodatieForBaanblok(ClubCloud_Accommodatie Accommodatie, ClubCloud_Baanblok entity , bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		try
    		{		
    			entity = beheerModel.ClubCloud_Baanblokken.Find(entity.Id);	
    
    			if(entity != null && entity.ClubCloud_Accommodatie == null)
    				beheerModel.Entry(entity).Reference(e => e.ClubCloud_Accommodatie).Load();
    
    			entity.ClubCloud_Accommodatie = Accommodatie;
    
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
    
    
    	public ClubCloud_Accommodatie GetAccommodatieForBaanblokById(System.Guid Id, bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		ClubCloud_Baanblok entity = null;
    		ClubCloud_Accommodatie result = null;
    
    		try
    		{
    			entity = beheerModel.ClubCloud_Baanblokken.Find(Id);
    			if(entity != null && entity.ClubCloud_Accommodatie == null)
    				beheerModel.Entry(entity).Reference(e => e.ClubCloud_Accommodatie).Load();
    
    			result = entity.ClubCloud_Accommodatie;
    
    			if (result == null || refresh)
    				result = GetAccommodatieForBaanblokById(settings.Id.ToString(), Id, refresh, settings);
    
    			if (result != null)
    				return result;
    
    			return new ClubCloud_Accommodatie();
    		}
            finally
            {
    			if(entity != null)
    				try { beheerModel.ObjectContext.Detach(entity); } catch{}
                if(result != null)
    				try { beheerModel.ObjectContext.Detach(result); } catch{}
            }
    	}
    
    	public bool SetAccommodatieForBaanblokById(ClubCloud_Accommodatie Accommodatie, System.Guid Id , bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		ClubCloud_Baanblok entity = null;
    
    		try
    		{		
    			entity = beheerModel.ClubCloud_Baanblokken.Find(Id);	
    
    			if(entity != null && entity.ClubCloud_Accommodatie == null)
    				beheerModel.Entry(entity).Reference(e => e.ClubCloud_Accommodatie).Load();
    
    			entity.ClubCloud_Accommodatie = Accommodatie;
    
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
    
    
    	public ClubCloud_Baantype GetBaantypeForBaanblok(ClubCloud_Baanblok entity, bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		ClubCloud_Baantype result = null;
    
    		try
    		{
    			entity = beheerModel.ClubCloud_Baanblokken.Find(entity.Id);
    			if(entity != null && entity.ClubCloud_Baantype == null)
    				beheerModel.Entry(entity).Reference(e => e.ClubCloud_Baantype).Load();
    
    			result = entity.ClubCloud_Baantype;
    
    			if (result == null || refresh)
    				result = GetBaantypeForBaanblok(settings.Id.ToString(), entity, refresh, settings);
    
    			if (result != null)
    				return result;
    
    			return new ClubCloud_Baantype();
    		}
            finally
            {
    			if(entity != null)
    				try { beheerModel.ObjectContext.Detach(entity); } catch{}
                if(result != null)
    				try { beheerModel.ObjectContext.Detach(result); } catch{}
            }
    
    	}
    
    	public bool SetBaantypeForBaanblok(ClubCloud_Baantype Baantype, ClubCloud_Baanblok entity , bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		try
    		{		
    			entity = beheerModel.ClubCloud_Baanblokken.Find(entity.Id);	
    
    			if(entity != null && entity.ClubCloud_Baantype == null)
    				beheerModel.Entry(entity).Reference(e => e.ClubCloud_Baantype).Load();
    
    			entity.ClubCloud_Baantype = Baantype;
    
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
    
    
    	public ClubCloud_Baantype GetBaantypeForBaanblokById(System.Guid Id, bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		ClubCloud_Baanblok entity = null;
    		ClubCloud_Baantype result = null;
    
    		try
    		{
    			entity = beheerModel.ClubCloud_Baanblokken.Find(Id);
    			if(entity != null && entity.ClubCloud_Baantype == null)
    				beheerModel.Entry(entity).Reference(e => e.ClubCloud_Baantype).Load();
    
    			result = entity.ClubCloud_Baantype;
    
    			if (result == null || refresh)
    				result = GetBaantypeForBaanblokById(settings.Id.ToString(), Id, refresh, settings);
    
    			if (result != null)
    				return result;
    
    			return new ClubCloud_Baantype();
    		}
            finally
            {
    			if(entity != null)
    				try { beheerModel.ObjectContext.Detach(entity); } catch{}
                if(result != null)
    				try { beheerModel.ObjectContext.Detach(result); } catch{}
            }
    	}
    
    	public bool SetBaantypeForBaanblokById(ClubCloud_Baantype Baantype, System.Guid Id , bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		ClubCloud_Baanblok entity = null;
    
    		try
    		{		
    			entity = beheerModel.ClubCloud_Baanblokken.Find(Id);	
    
    			if(entity != null && entity.ClubCloud_Baantype == null)
    				beheerModel.Entry(entity).Reference(e => e.ClubCloud_Baantype).Load();
    
    			entity.ClubCloud_Baantype = Baantype;
    
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
    
    
    	public ClubCloud_Baansoort GetBaansoortForBaanblok(ClubCloud_Baanblok entity, bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		ClubCloud_Baansoort result = null;
    
    		try
    		{
    			entity = beheerModel.ClubCloud_Baanblokken.Find(entity.Id);
    			if(entity != null && entity.ClubCloud_Baansoort == null)
    				beheerModel.Entry(entity).Reference(e => e.ClubCloud_Baansoort).Load();
    
    			result = entity.ClubCloud_Baansoort;
    
    			if (result == null || refresh)
    				result = GetBaansoortForBaanblok(settings.Id.ToString(), entity, refresh, settings);
    
    			if (result != null)
    				return result;
    
    			return new ClubCloud_Baansoort();
    		}
            finally
            {
    			if(entity != null)
    				try { beheerModel.ObjectContext.Detach(entity); } catch{}
                if(result != null)
    				try { beheerModel.ObjectContext.Detach(result); } catch{}
            }
    
    	}
    
    	public bool SetBaansoortForBaanblok(ClubCloud_Baansoort Baansoort, ClubCloud_Baanblok entity , bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		try
    		{		
    			entity = beheerModel.ClubCloud_Baanblokken.Find(entity.Id);	
    
    			if(entity != null && entity.ClubCloud_Baansoort == null)
    				beheerModel.Entry(entity).Reference(e => e.ClubCloud_Baansoort).Load();
    
    			entity.ClubCloud_Baansoort = Baansoort;
    
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
    
    
    	public ClubCloud_Baansoort GetBaansoortForBaanblokById(System.Guid Id, bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		ClubCloud_Baanblok entity = null;
    		ClubCloud_Baansoort result = null;
    
    		try
    		{
    			entity = beheerModel.ClubCloud_Baanblokken.Find(Id);
    			if(entity != null && entity.ClubCloud_Baansoort == null)
    				beheerModel.Entry(entity).Reference(e => e.ClubCloud_Baansoort).Load();
    
    			result = entity.ClubCloud_Baansoort;
    
    			if (result == null || refresh)
    				result = GetBaansoortForBaanblokById(settings.Id.ToString(), Id, refresh, settings);
    
    			if (result != null)
    				return result;
    
    			return new ClubCloud_Baansoort();
    		}
            finally
            {
    			if(entity != null)
    				try { beheerModel.ObjectContext.Detach(entity); } catch{}
                if(result != null)
    				try { beheerModel.ObjectContext.Detach(result); } catch{}
            }
    	}
    
    	public bool SetBaansoortForBaanblokById(ClubCloud_Baansoort Baansoort, System.Guid Id , bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		ClubCloud_Baanblok entity = null;
    
    		try
    		{		
    			entity = beheerModel.ClubCloud_Baanblokken.Find(Id);	
    
    			if(entity != null && entity.ClubCloud_Baansoort == null)
    				beheerModel.Entry(entity).Reference(e => e.ClubCloud_Baansoort).Load();
    
    			entity.ClubCloud_Baansoort = Baansoort;
    
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
    [KnownType(typeof(ClubCloud_Baanblok))]
    public partial class ClubCloud_Baanblok_View
    {
    	public ClubCloud_Baanblok_View()
    	{
    		this.ClubCloud_Baanblok = new HashSet<ClubCloud_Baanblok>();
    	}
    
    	[DataMember]
    	public int TotalRowCount { get; set; }
    
    	[DataMember]
    	public virtual ICollection<ClubCloud_Baanblok> ClubCloud_Baanblok { get; set; }
    
    }
    	
}

