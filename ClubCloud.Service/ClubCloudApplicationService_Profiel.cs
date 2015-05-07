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
    	public ClubCloud_Profiel GetProfielById(System.Guid Id , bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		ClubCloud_Profiel result = null;
    
    		try
    		{			
    			result = beheerModel.ClubCloud_Profielen.Find(Id);
    		
    			if (result == null || refresh)
    				result = GetProfielById(settings.Id.ToString(), Id, refresh, settings);
    
    			if (result != null)
    				return result;
    
    			return new ClubCloud_Profiel();
            }
            finally
            {
    			if(result != null)
    				try { beheerModel.ObjectContext.Detach(result);} catch{}
            }
    
    	}
    
    	public List<ClubCloud_Profiel> GetProfielen(bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		List<ClubCloud_Profiel> result = null;
    		
    		try
    		{
    			result = beheerModel.ClubCloud_Profielen.ToList<ClubCloud_Profiel>();
    		
    			if (result == null || result.Count == 0 || refresh)		
    				result = GetProfielen(settings.Id.ToString(), refresh, settings);
    
    			if(result != null)
    				return result;
    
    			return new List<ClubCloud_Profiel>();
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
    
    	public ClubCloud_Profiel SetProfiel(ClubCloud_Profiel entity, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		ClubCloud_Profiel tobeupdated = null;
    		
    		try
    		{
    			entity = SetProfiel(settings.Id.ToString(), entity, settings);
    
    			beheerModel.ClubCloud_Profielen.AddOrUpdate(entity);
    		
    			beheerModel.SaveChanges();
    
    			tobeupdated = beheerModel.ClubCloud_Profielen.Find(entity.Id);
    			return tobeupdated;
            }
            finally
            {
    			if(tobeupdated != null)
    				try { beheerModel.ObjectContext.Detach(tobeupdated); } catch{}
            }
    
    	}
    
    
    	public bool DeleteProfiel(ClubCloud_Profiel entity, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		return DeleteProfielById(entity.Id, settings);
    	}
    
    	public bool DeleteProfielById(System.Guid Id, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		ClubCloud_Profiel tobedeleted = null;
    		try
    		{
    
    			tobedeleted = beheerModel.ClubCloud_Profielen.Find(Id);
    		
    			if (tobedeleted != null)
    			{
    				beheerModel.ClubCloud_Profielen.Remove(tobedeleted);
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
    
    
    	public ClubCloud_Profiel_View GetProfielenByQuery(string bondsnummer, Guid verenigingId,System.Web.UI.DataSourceSelectArguments selectArgs = null, List<System.Web.UI.WebControls.Parameter> parameters = null, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		ClubCloud_Profiel_View view = new ClubCloud_Profiel_View();
    
    		StringBuilder querybuilder = new StringBuilder("SELECT * FROM dbo.ClubCloud_Profiel");
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
    
    		view.ClubCloud_Profiel = beheerModel.Database.SqlQuery<ClubCloud_Profiel>(querybuilder.ToString(), sqlparams.ToArray()).Skip(selectArgs.StartRowIndex).Take(selectArgs.MaximumRows).ToList<ClubCloud_Profiel>();
    
    		if (selectArgs.RetrieveTotalRowCount)
    		{
    
    			view.TotalRowCount = beheerModel.Database.SqlQuery<ClubCloud_Profiel>(querybuilder.ToString(), sqlparamscount.ToArray()).Count();
    		}
    		return view;
    	}
    
    	public List<ClubCloud_Profiel> GetProfielenBySearch(string prefixText, int count, string contextKey, ClubCloud_Setting _settings = null)
    	{
    		if(_settings != null)
    			ValidateSettings(ref _settings);
    
            List<string> profielen = new List<string>();
            try
            {
                bool enabled = beheerModel.Database.SqlQuery<bool>("SELECT (CAST((FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))AS BIT))").FirstOrDefault();
    
                List<ClubCloud_Profiel> entities = null;
    
                if (enabled)
                {
                    var fts = BeheerFullTextInterceptor.Fts(prefixText);
    				
    
    			entities = beheerModel.ClubCloud_Profielen.Where(e => e.Bondsnummer.Contains(fts)  || e.Actief.Contains(fts) ).ToList();
    
    				
                }
    			else
    			{
    
    			entities = beheerModel.Database.SqlQuery<ClubCloud_Profiel>("SELECT * FROM ClubCloud_Profiel WHERE  Bondsnummer LIKE '%"+ prefixText +"%' OR  Actief LIKE '%"+ prefixText +"%'").ToList();
    
    				
    			}
    
    			if (entities != null && entities.Count > 0)
    				return entities;
            }
            catch { };
    
            return new List<ClubCloud_Profiel>();
    	}
    
    
    	public ClubCloud_Gebruiker GetGebruikerForProfiel(ClubCloud_Profiel entity, bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		ClubCloud_Gebruiker result = null;
    
    		try
    		{
    			entity = beheerModel.ClubCloud_Profielen.Find(entity.Id);
    			if(entity != null && entity.ClubCloud_Gebruiker == null)
    				beheerModel.Entry(entity).Reference(e => e.ClubCloud_Gebruiker).Load();
    
    			result = entity.ClubCloud_Gebruiker;
    
    			if (result == null || refresh)
    				result = GetGebruikerForProfiel(settings.Id.ToString(), entity, refresh, settings);
    
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
    
    	public bool SetGebruikerForProfiel(ClubCloud_Gebruiker Gebruiker, ClubCloud_Profiel entity , bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		try
    		{		
    			entity = beheerModel.ClubCloud_Profielen.Find(entity.Id);	
    
    			if(entity != null && entity.ClubCloud_Gebruiker == null)
    				beheerModel.Entry(entity).Reference(e => e.ClubCloud_Gebruiker).Load();
    
    			entity.ClubCloud_Gebruiker = Gebruiker;
    
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
    
    
    	public ClubCloud_Gebruiker GetGebruikerForProfielById(System.Guid Id, bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		ClubCloud_Profiel entity = null;
    		ClubCloud_Gebruiker result = null;
    
    		try
    		{
    			entity = beheerModel.ClubCloud_Profielen.Find(Id);
    			if(entity != null && entity.ClubCloud_Gebruiker == null)
    				beheerModel.Entry(entity).Reference(e => e.ClubCloud_Gebruiker).Load();
    
    			result = entity.ClubCloud_Gebruiker;
    
    			if (result == null || refresh)
    				result = GetGebruikerForProfielById(settings.Id.ToString(), Id, refresh, settings);
    
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
    
    	public bool SetGebruikerForProfielById(ClubCloud_Gebruiker Gebruiker, System.Guid Id , bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		ClubCloud_Profiel entity = null;
    
    		try
    		{		
    			entity = beheerModel.ClubCloud_Profielen.Find(Id);	
    
    			if(entity != null && entity.ClubCloud_Gebruiker == null)
    				beheerModel.Entry(entity).Reference(e => e.ClubCloud_Gebruiker).Load();
    
    			entity.ClubCloud_Gebruiker = Gebruiker;
    
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
    [KnownType(typeof(ClubCloud_Profiel))]
    public partial class ClubCloud_Profiel_View
    {
    	public ClubCloud_Profiel_View()
    	{
    		this.ClubCloud_Profiel = new HashSet<ClubCloud_Profiel>();
    	}
    
    	[DataMember]
    	public int TotalRowCount { get; set; }
    
    	[DataMember]
    	public virtual ICollection<ClubCloud_Profiel> ClubCloud_Profiel { get; set; }
    
    }
    	
}

