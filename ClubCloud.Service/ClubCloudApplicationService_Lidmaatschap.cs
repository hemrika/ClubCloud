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
    	public ClubCloud_Lidmaatschap GetLidmaatschapById(System.Guid Id , bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		ClubCloud_Lidmaatschap result = null;
    
    		try
    		{			
    			result = beheerModel.ClubCloud_Lidmaatschappen.Find(Id);
    		
    			if (result == null || refresh)
    				result = GetLidmaatschapById(settings.Id.ToString(), Id, refresh, settings);
    
    			if (result != null)
    				return result;
    
    			return new ClubCloud_Lidmaatschap();
            }
            finally
            {
    			if(result != null)
    				try { beheerModel.ObjectContext.Detach(result);} catch{}
            }
    
    	}
    
    	public List<ClubCloud_Lidmaatschap> GetLidmaatschappen(bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		List<ClubCloud_Lidmaatschap> result = null;
    		
    		try
    		{
    			result = beheerModel.ClubCloud_Lidmaatschappen.ToList<ClubCloud_Lidmaatschap>();
    		
    			if (result == null || result.Count == 0 || refresh)		
    				result = GetLidmaatschappen(settings.Id.ToString(), refresh, settings);
    
    			if(result != null)
    				return result;
    
    			return new List<ClubCloud_Lidmaatschap>();
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
    
    	public ClubCloud_Lidmaatschap SetLidmaatschap(ClubCloud_Lidmaatschap entity, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		ClubCloud_Lidmaatschap tobeupdated = null;
    		
    		try
    		{
    			entity = SetLidmaatschap(settings.Id.ToString(), entity, settings);
    
    			beheerModel.ClubCloud_Lidmaatschappen.AddOrUpdate(entity);
    		
    			beheerModel.SaveChanges();
    
    			tobeupdated = beheerModel.ClubCloud_Lidmaatschappen.Find(entity.Id);
    			return tobeupdated;
            }
            finally
            {
    			if(tobeupdated != null)
    				try { beheerModel.ObjectContext.Detach(tobeupdated); } catch{}
            }
    
    	}
    
    
    	public bool DeleteLidmaatschap(ClubCloud_Lidmaatschap entity, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		return DeleteLidmaatschapById(entity.Id, settings);
    	}
    
    	public bool DeleteLidmaatschapById(System.Guid Id, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		bool succes = false;
    		ClubCloud_Lidmaatschap tobedeleted = null;
    		try
    		{
    
    			tobedeleted = beheerModel.ClubCloud_Lidmaatschappen.Find(Id);
    		
    			if (tobedeleted != null)
    			{
    				beheerModel.ClubCloud_Lidmaatschappen.Remove(tobedeleted);
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
    
    
    	public ClubCloud_Lidmaatschap_View GetLidmaatschappenByQuery(string bondsnummer, Guid verenigingId,System.Web.UI.DataSourceSelectArguments selectArgs = null, List<System.Web.UI.WebControls.Parameter> parameters = null, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		ClubCloud_Lidmaatschap_View view = new ClubCloud_Lidmaatschap_View();
    
    		StringBuilder querybuilder = new StringBuilder("SELECT * FROM dbo.ClubCloud_Lidmaatschap");
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
    
    		view.ClubCloud_Lidmaatschap = beheerModel.Database.SqlQuery<ClubCloud_Lidmaatschap>(querybuilder.ToString(), sqlparams.ToArray()).Skip(selectArgs.StartRowIndex).Take(selectArgs.MaximumRows).ToList<ClubCloud_Lidmaatschap>();
    
    		if (selectArgs.RetrieveTotalRowCount)
    		{
    
    			view.TotalRowCount = beheerModel.Database.SqlQuery<ClubCloud_Lidmaatschap>(querybuilder.ToString(), sqlparamscount.ToArray()).Count();
    		}
    		return view;
    	}
    
    	public List<ClubCloud_Lidmaatschap> GetLidmaatschappenBySearch(string prefixText, int count, string contextKey, ClubCloud_Setting _settings = null)
    	{
    		if(_settings != null)
    			ValidateSettings(ref _settings);
    
            List<string> lidmaatschappen = new List<string>();
            try
            {
                bool enabled = beheerModel.Database.SqlQuery<bool>("SELECT (CAST((FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))AS BIT))").FirstOrDefault();
    
                List<ClubCloud_Lidmaatschap> entities = null;
    
                if (enabled)
                {
                    var fts = BeheerFullTextInterceptor.Fts(prefixText);
    				
    
    			entities = beheerModel.ClubCloud_Lidmaatschappen.Where(e => e.Bondsnummer.Contains(fts)  || e.InternNummer.Contains(fts)  || e.PasTypeNaam.Contains(fts)  || e.PasVolgnummer.Contains(fts)  || e.Actief.Contains(fts) ).ToList();
    
    				
                }
    			else
    			{
    
    			entities = beheerModel.Database.SqlQuery<ClubCloud_Lidmaatschap>("SELECT * FROM ClubCloud_Lidmaatschap WHERE  Bondsnummer LIKE '%"+ prefixText +"%' OR  InternNummer LIKE '%"+ prefixText +"%' OR  PasTypeNaam LIKE '%"+ prefixText +"%' OR  PasVolgnummer LIKE '%"+ prefixText +"%' OR  Actief LIKE '%"+ prefixText +"%'").ToList();
    
    				
    			}
    
    			if (entities != null && entities.Count > 0)
    				return entities;
            }
            catch { };
    
            return new List<ClubCloud_Lidmaatschap>();
    	}
    
    
    	public ClubCloud_Vereniging GetVerenigingForLidmaatschap(ClubCloud_Lidmaatschap entity, bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		ClubCloud_Vereniging result = null;
    
    		try
    		{
    			entity = beheerModel.ClubCloud_Lidmaatschappen.Find(entity.Id);
    			if(entity != null && entity.ClubCloud_Vereniging == null)
    				beheerModel.Entry(entity).Reference(e => e.ClubCloud_Vereniging).Load();
    
    			result = entity.ClubCloud_Vereniging;
    
    			if (result == null || refresh)
    				result = GetVerenigingForLidmaatschap(settings.Id.ToString(), entity, refresh, settings);
    
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
    
    	public bool SetVerenigingForLidmaatschap(ClubCloud_Vereniging Vereniging, ClubCloud_Lidmaatschap entity , bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		bool succes = false;
    		try
    		{		
    			entity = beheerModel.ClubCloud_Lidmaatschappen.Find(entity.Id);	
    
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
    
    
    	public ClubCloud_Vereniging GetVerenigingForLidmaatschapById(System.Guid Id, bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		ClubCloud_Lidmaatschap entity = null;
    		ClubCloud_Vereniging result = null;
    
    		try
    		{
    			entity = beheerModel.ClubCloud_Lidmaatschappen.Find(Id);
    			if(entity != null && entity.ClubCloud_Vereniging == null)
    				beheerModel.Entry(entity).Reference(e => e.ClubCloud_Vereniging).Load();
    
    			result = entity.ClubCloud_Vereniging;
    
    			if (result == null || refresh)
    				result = GetVerenigingForLidmaatschapById(settings.Id.ToString(), Id, refresh, settings);
    
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
    
    	public bool SetVerenigingForLidmaatschapById(ClubCloud_Vereniging Vereniging, System.Guid Id , bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		ClubCloud_Lidmaatschap entity = null;
    		bool succes = false;
    
    		try
    		{		
    			entity = beheerModel.ClubCloud_Lidmaatschappen.Find(Id);	
    
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
    
    
    	public ClubCloud_Gebruiker GetGebruikerForLidmaatschap(ClubCloud_Lidmaatschap entity, bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		ClubCloud_Gebruiker result = null;
    
    		try
    		{
    			entity = beheerModel.ClubCloud_Lidmaatschappen.Find(entity.Id);
    			if(entity != null && entity.ClubCloud_Gebruiker == null)
    				beheerModel.Entry(entity).Reference(e => e.ClubCloud_Gebruiker).Load();
    
    			result = entity.ClubCloud_Gebruiker;
    
    			if (result == null || refresh)
    				result = GetGebruikerForLidmaatschap(settings.Id.ToString(), entity, refresh, settings);
    
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
    
    	public bool SetGebruikerForLidmaatschap(ClubCloud_Gebruiker Gebruiker, ClubCloud_Lidmaatschap entity , bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		bool succes = false;
    		try
    		{		
    			entity = beheerModel.ClubCloud_Lidmaatschappen.Find(entity.Id);	
    
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
    
    
    	public ClubCloud_Gebruiker GetGebruikerForLidmaatschapById(System.Guid Id, bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		ClubCloud_Lidmaatschap entity = null;
    		ClubCloud_Gebruiker result = null;
    
    		try
    		{
    			entity = beheerModel.ClubCloud_Lidmaatschappen.Find(Id);
    			if(entity != null && entity.ClubCloud_Gebruiker == null)
    				beheerModel.Entry(entity).Reference(e => e.ClubCloud_Gebruiker).Load();
    
    			result = entity.ClubCloud_Gebruiker;
    
    			if (result == null || refresh)
    				result = GetGebruikerForLidmaatschapById(settings.Id.ToString(), Id, refresh, settings);
    
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
    
    	public bool SetGebruikerForLidmaatschapById(ClubCloud_Gebruiker Gebruiker, System.Guid Id , bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		ClubCloud_Lidmaatschap entity = null;
    		bool succes = false;
    
    		try
    		{		
    			entity = beheerModel.ClubCloud_Lidmaatschappen.Find(Id);	
    
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
    
    
    	public ClubCloud_Lidmaatschapsoort GetLidmaatschapsoortForLidmaatschap(ClubCloud_Lidmaatschap entity, bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		ClubCloud_Lidmaatschapsoort result = null;
    
    		try
    		{
    			entity = beheerModel.ClubCloud_Lidmaatschappen.Find(entity.Id);
    			if(entity != null && entity.ClubCloud_Lidmaatschapsoort == null)
    				beheerModel.Entry(entity).Reference(e => e.ClubCloud_Lidmaatschapsoort).Load();
    
    			result = entity.ClubCloud_Lidmaatschapsoort;
    
    			if (result == null || refresh)
    				result = GetLidmaatschapsoortForLidmaatschap(settings.Id.ToString(), entity, refresh, settings);
    
    			if (result != null)
    				return result;
    
    			return new ClubCloud_Lidmaatschapsoort();
    		}
            finally
            {
    			if(entity != null)
    				try { beheerModel.ObjectContext.Detach(entity); } catch{}
                if(result != null)
    				try { beheerModel.ObjectContext.Detach(result); } catch{}
            }
    
    	}
    
    	public bool SetLidmaatschapsoortForLidmaatschap(ClubCloud_Lidmaatschapsoort Lidmaatschapsoort, ClubCloud_Lidmaatschap entity , bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		bool succes = false;
    		try
    		{		
    			entity = beheerModel.ClubCloud_Lidmaatschappen.Find(entity.Id);	
    
    			if(entity != null && entity.ClubCloud_Lidmaatschapsoort == null)
    				beheerModel.Entry(entity).Reference(e => e.ClubCloud_Lidmaatschapsoort).Load();
    
    			entity.ClubCloud_Lidmaatschapsoort = Lidmaatschapsoort;
    
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
    
    
    	public ClubCloud_Lidmaatschapsoort GetLidmaatschapsoortForLidmaatschapById(System.Guid Id, bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		ClubCloud_Lidmaatschap entity = null;
    		ClubCloud_Lidmaatschapsoort result = null;
    
    		try
    		{
    			entity = beheerModel.ClubCloud_Lidmaatschappen.Find(Id);
    			if(entity != null && entity.ClubCloud_Lidmaatschapsoort == null)
    				beheerModel.Entry(entity).Reference(e => e.ClubCloud_Lidmaatschapsoort).Load();
    
    			result = entity.ClubCloud_Lidmaatschapsoort;
    
    			if (result == null || refresh)
    				result = GetLidmaatschapsoortForLidmaatschapById(settings.Id.ToString(), Id, refresh, settings);
    
    			if (result != null)
    				return result;
    
    			return new ClubCloud_Lidmaatschapsoort();
    		}
            finally
            {
    			if(entity != null)
    				try { beheerModel.ObjectContext.Detach(entity); } catch{}
                if(result != null)
    				try { beheerModel.ObjectContext.Detach(result); } catch{}
            }
    	}
    
    	public bool SetLidmaatschapsoortForLidmaatschapById(ClubCloud_Lidmaatschapsoort Lidmaatschapsoort, System.Guid Id , bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		ClubCloud_Lidmaatschap entity = null;
    		bool succes = false;
    
    		try
    		{		
    			entity = beheerModel.ClubCloud_Lidmaatschappen.Find(Id);	
    
    			if(entity != null && entity.ClubCloud_Lidmaatschapsoort == null)
    				beheerModel.Entry(entity).Reference(e => e.ClubCloud_Lidmaatschapsoort).Load();
    
    			entity.ClubCloud_Lidmaatschapsoort = Lidmaatschapsoort;
    
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
    [KnownType(typeof(ClubCloud_Lidmaatschap))]
    public partial class ClubCloud_Lidmaatschap_View
    {
    	public ClubCloud_Lidmaatschap_View()
    	{
    		this.ClubCloud_Lidmaatschap = new HashSet<ClubCloud_Lidmaatschap>();
    	}
    
    	[DataMember]
    	public int TotalRowCount { get; set; }
    
    	[DataMember]
    	public virtual ICollection<ClubCloud_Lidmaatschap> ClubCloud_Lidmaatschap { get; set; }
    
    }
    	
}

