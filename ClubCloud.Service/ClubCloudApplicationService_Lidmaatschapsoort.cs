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
    	public ClubCloud_Lidmaatschapsoort GetLidmaatschapsoortById(System.Guid Id , bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		ClubCloud_Lidmaatschapsoort result = null;
    
    		try
    		{			
    			result = beheerModel.ClubCloud_Lidmaatschapsoorten.Find(Id);
    		
    			if (result == null || refresh)
    				result = GetLidmaatschapsoortById(settings.Id.ToString(), Id, refresh, settings);
    
    			if (result != null)
    				return result;
    
    			return new ClubCloud_Lidmaatschapsoort();
            }
            finally
            {
    			if(result != null)
    				try { beheerModel.ObjectContext.Detach(result);} catch{}
            }
    
    	}
    
    	public List<ClubCloud_Lidmaatschapsoort> GetLidmaatschapsoorten(bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		List<ClubCloud_Lidmaatschapsoort> result = null;
    		
    		try
    		{
    			result = beheerModel.ClubCloud_Lidmaatschapsoorten.ToList<ClubCloud_Lidmaatschapsoort>();
    		
    			if (result == null || result.Count == 0 || refresh)		
    				result = GetLidmaatschapsoorten(settings.Id.ToString(), refresh, settings);
    
    			if(result != null)
    				return result;
    
    			return new List<ClubCloud_Lidmaatschapsoort>();
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
    
    	public ClubCloud_Lidmaatschapsoort SetLidmaatschapsoort(ClubCloud_Lidmaatschapsoort entity, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		ClubCloud_Lidmaatschapsoort tobeupdated = null;
    		
    		try
    		{
    			entity = SetLidmaatschapsoort(settings.Id.ToString(), entity, settings);
    
    			beheerModel.ClubCloud_Lidmaatschapsoorten.AddOrUpdate(entity);
    		
    			beheerModel.SaveChanges();
    
    			tobeupdated = beheerModel.ClubCloud_Lidmaatschapsoorten.Find(entity.Id);
    			return tobeupdated;
            }
            finally
            {
    			if(tobeupdated != null)
    				try { beheerModel.ObjectContext.Detach(tobeupdated); } catch{}
            }
    
    	}
    
    
    	public bool DeleteLidmaatschapsoort(ClubCloud_Lidmaatschapsoort entity, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		return DeleteLidmaatschapsoortById(entity.Id, settings);
    	}
    
    	public bool DeleteLidmaatschapsoortById(System.Guid Id, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		ClubCloud_Lidmaatschapsoort tobedeleted = null;
    		try
    		{
    
    			tobedeleted = beheerModel.ClubCloud_Lidmaatschapsoorten.Find(Id);
    		
    			if (tobedeleted != null)
    			{
    				beheerModel.ClubCloud_Lidmaatschapsoorten.Remove(tobedeleted);
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
    
    
    	public ClubCloud_Lidmaatschapsoort_View GetLidmaatschapsoortenByQuery(string bondsnummer, Guid verenigingId,System.Web.UI.DataSourceSelectArguments selectArgs = null, List<System.Web.UI.WebControls.Parameter> parameters = null, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		ClubCloud_Lidmaatschapsoort_View view = new ClubCloud_Lidmaatschapsoort_View();
    
    		StringBuilder querybuilder = new StringBuilder("SELECT * FROM dbo.ClubCloud_Lidmaatschapsoort");
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
    
    		view.ClubCloud_Lidmaatschapsoort = beheerModel.Database.SqlQuery<ClubCloud_Lidmaatschapsoort>(querybuilder.ToString(), sqlparams.ToArray()).Skip(selectArgs.StartRowIndex).Take(selectArgs.MaximumRows).ToList<ClubCloud_Lidmaatschapsoort>();
    
    		if (selectArgs.RetrieveTotalRowCount)
    		{
    
    			view.TotalRowCount = beheerModel.Database.SqlQuery<ClubCloud_Lidmaatschapsoort>(querybuilder.ToString(), sqlparamscount.ToArray()).Count();
    		}
    		return view;
    	}
    
    	public List<ClubCloud_Lidmaatschapsoort> GetLidmaatschapsoortenBySearch(string prefixText, int count, string contextKey, ClubCloud_Setting _settings = null)
    	{
    		if(_settings != null)
    			ValidateSettings(ref _settings);
    
            List<string> lidmaatschapsoorten = new List<string>();
            try
            {
                bool enabled = beheerModel.Database.SqlQuery<bool>("SELECT (CAST((FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))AS BIT))").FirstOrDefault();
    
                List<ClubCloud_Lidmaatschapsoort> entities = null;
    
                if (enabled)
                {
                    var fts = BeheerFullTextInterceptor.Fts(prefixText);
    				
    
    			entities = beheerModel.ClubCloud_Lidmaatschapsoorten.Where(e => e.Naam.Contains(fts)  || e.Beschrijving.Contains(fts)  || e.Omschrijving.Contains(fts)  || e.Code.Contains(fts)  || e.Tarief.Contains(fts)  || e.Actief.Contains(fts) ).ToList();
    
    				
                }
    			else
    			{
    
    			entities = beheerModel.Database.SqlQuery<ClubCloud_Lidmaatschapsoort>("SELECT * FROM ClubCloud_Lidmaatschapsoort WHERE  Naam LIKE '%"+ prefixText +"%' OR  Beschrijving LIKE '%"+ prefixText +"%' OR  Omschrijving LIKE '%"+ prefixText +"%' OR  Code LIKE '%"+ prefixText +"%' OR  Tarief LIKE '%"+ prefixText +"%' OR  Actief LIKE '%"+ prefixText +"%'").ToList();
    
    				
    			}
    
    			if (entities != null && entities.Count > 0)
    				return entities;
            }
            catch { };
    
            return new List<ClubCloud_Lidmaatschapsoort>();
    	}
    
    
    	public List<ClubCloud_Lidmaatschap> GetLidmaatschappenForLidmaatschapsoort(ClubCloud_Lidmaatschapsoort entity, bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		List<ClubCloud_Lidmaatschap> result = null;
    
    		try
    		{
    			entity = beheerModel.ClubCloud_Lidmaatschapsoorten.Find(entity.Id);
    			if(entity != null && entity.ClubCloud_Lidmaatschap != null && entity.ClubCloud_Lidmaatschap.Count == 0)
    				beheerModel.Entry(entity).Collection(e => e.ClubCloud_Lidmaatschap).Load();
    
    			result = entity.ClubCloud_Lidmaatschap.ToList();
    
    			if(result == null || result.Count == 0 || refresh)
    				result = GetLidmaatschappenForLidmaatschapsoort(settings.Id.ToString(), entity, refresh, settings);
    
    			if(result != null)
    				return result;
    
    			return new List<ClubCloud_Lidmaatschap>();
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
    
    
    	public List<ClubCloud_Lidmaatschap> GetLidmaatschappenForLidmaatschapsoortById(System.Guid Id, bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		ClubCloud_Lidmaatschapsoort entity = null;
    		List<ClubCloud_Lidmaatschap> result = null;
    
    		try
    		{
    			entity = beheerModel.ClubCloud_Lidmaatschapsoorten.Find(Id);
    			if(entity != null && entity.ClubCloud_Lidmaatschap != null && entity.ClubCloud_Lidmaatschap.Count == 0)
    				beheerModel.Entry(entity).Collection(e => e.ClubCloud_Lidmaatschap).Load();
    
    			result = entity.ClubCloud_Lidmaatschap.ToList();
    
    			if(result == null || result.Count == 0 || refresh)
    				result = GetLidmaatschappenForLidmaatschapsoortById(settings.Id.ToString(), Id, refresh, settings);
    
    			if(result != null)
    				return result;
    
    			return new List<ClubCloud_Lidmaatschap>();
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
    
    	public bool SetLidmaatschappenForLidmaatschapsoort(List<ClubCloud_Lidmaatschap> Lidmaatschappen, ClubCloud_Lidmaatschapsoort entity, bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		ClubCloud_Lidmaatschapsoort result = null;
    
    		try
    		{			
    			entity = beheerModel.ClubCloud_Lidmaatschapsoorten.Find(entity.Id);
    		
    			if (entity != null)
    				beheerModel.Entry(entity).Collection(e => e.ClubCloud_Lidmaatschap).Load();
    				//result = GetLidmaatschapsoortById(settings.Id.ToString(), Id, refresh, settings);
    
    			if (result != null)
    				//return result.ClubCloud_Lidmaatschapsoorten.Count == ;
    
    			return false;
            }
            finally
            {
    			if(entity != null)
    				try { beheerModel.ObjectContext.Detach(entity); } catch{}
            }
    		return false;
    	}
    
    
    
    	public ClubCloud_Vereniging GetVerenigingForLidmaatschapsoort(ClubCloud_Lidmaatschapsoort entity, bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		ClubCloud_Vereniging result = null;
    
    		try
    		{
    			entity = beheerModel.ClubCloud_Lidmaatschapsoorten.Find(entity.Id);
    			if(entity != null && entity.ClubCloud_Vereniging == null)
    				beheerModel.Entry(entity).Reference(e => e.ClubCloud_Vereniging).Load();
    
    			result = entity.ClubCloud_Vereniging;
    
    			if (result == null || refresh)
    				result = GetVerenigingForLidmaatschapsoort(settings.Id.ToString(), entity, refresh, settings);
    
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
    
    	public bool SetVerenigingForLidmaatschapsoort(ClubCloud_Vereniging Vereniging, ClubCloud_Lidmaatschapsoort entity , bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		try
    		{		
    			entity = beheerModel.ClubCloud_Lidmaatschapsoorten.Find(entity.Id);	
    
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
    
    
    	public ClubCloud_Vereniging GetVerenigingForLidmaatschapsoortById(System.Guid Id, bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		ClubCloud_Lidmaatschapsoort entity = null;
    		ClubCloud_Vereniging result = null;
    
    		try
    		{
    			entity = beheerModel.ClubCloud_Lidmaatschapsoorten.Find(Id);
    			if(entity != null && entity.ClubCloud_Vereniging == null)
    				beheerModel.Entry(entity).Reference(e => e.ClubCloud_Vereniging).Load();
    
    			result = entity.ClubCloud_Vereniging;
    
    			if (result == null || refresh)
    				result = GetVerenigingForLidmaatschapsoortById(settings.Id.ToString(), Id, refresh, settings);
    
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
    
    	public bool SetVerenigingForLidmaatschapsoortById(ClubCloud_Vereniging Vereniging, System.Guid Id , bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		ClubCloud_Lidmaatschapsoort entity = null;
    
    		try
    		{		
    			entity = beheerModel.ClubCloud_Lidmaatschapsoorten.Find(Id);	
    
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
    [KnownType(typeof(ClubCloud_Lidmaatschapsoort))]
    public partial class ClubCloud_Lidmaatschapsoort_View
    {
    	public ClubCloud_Lidmaatschapsoort_View()
    	{
    		this.ClubCloud_Lidmaatschapsoort = new HashSet<ClubCloud_Lidmaatschapsoort>();
    	}
    
    	[DataMember]
    	public int TotalRowCount { get; set; }
    
    	[DataMember]
    	public virtual ICollection<ClubCloud_Lidmaatschapsoort> ClubCloud_Lidmaatschapsoort { get; set; }
    
    }
    	
}

