namespace ClubCloud.Service
{
    using ClubCloud.Model;
    using Microsoft.SharePoint.Utilities;
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
    	public ClubCloud_Baansoort GetBaansoortById(System.Guid Id , bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		ClubCloud_Baansoort result = null;
    
    		using (new SPMonitoredScope("Baansoorten GetBaansoortById"))
    		{
    
    			try
    			{			
    				result = beheerModel.ClubCloud_Baansoorten.Find(Id);
    		
    				if (result == null || refresh)
    					result = GetBaansoortById(settings.Id.ToString(), Id, refresh, settings);
    
    				if (result != null)
    					return result;	
    			}
    			catch (Exception ex)
    			{
    				Logger.WriteLog(Logger.Category.Unexpected, ex.Source, ex.Message);
    			}
    			finally
    			{
    				if(result != null)
    					try { beheerModel.ObjectContext.Detach(result);} catch{}
    			}
    		}
    
    		return new ClubCloud_Baansoort();
    	}
    
    	public List<ClubCloud_Baansoort> GetBaansoorten(bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		List<ClubCloud_Baansoort> result = null;
    
    		using (new SPMonitoredScope("Baansoorten GetBaansoorten"))
    		{
    		
    			try
    			{
    				result = beheerModel.ClubCloud_Baansoorten.ToList<ClubCloud_Baansoort>();
    		
    				if (result == null || result.Count == 0 || refresh)		
    					result = GetBaansoorten(settings.Id.ToString(), refresh, settings);
    
    				if(result != null)
    					return result;		
    			}
    			catch (Exception ex)
    			{
    				Logger.WriteLog(Logger.Category.Unexpected, ex.Source, ex.Message);
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
    
    		return new List<ClubCloud_Baansoort>();
    	}
    
    	public ClubCloud_Baansoort SetBaansoort(ClubCloud_Baansoort entity, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		ClubCloud_Baansoort tobeupdated = null;
    		
    		using (new SPMonitoredScope("Baansoorten SetBaansoort"))
    		{
    
    			try
    			{
    				entity = SetBaansoort(settings.Id.ToString(), entity, settings);
    
    				if(entity != null)
    					beheerModel.ClubCloud_Baansoorten.AddOrUpdate(entity);
    		
    				beheerModel.SaveChanges();
    
    				tobeupdated = beheerModel.ClubCloud_Baansoorten.Find(entity.Id);
    				return tobeupdated;
    			}
    			catch (Exception ex)
    			{
    				Logger.WriteLog(Logger.Category.Unexpected, ex.Source, ex.Message);
    			}
    			finally
    			{
    				if(tobeupdated != null)
    					try { beheerModel.ObjectContext.Detach(tobeupdated); } catch{}
    			}
    		}
    
    		return null;
    	}
    
    
    	public bool DeleteBaansoort(ClubCloud_Baansoort entity, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		return DeleteBaansoortById(entity.Id, settings);
    	}
    
    	public bool DeleteBaansoortById(System.Guid Id, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		bool succes = false;
    		ClubCloud_Baansoort tobedeleted = null;
    
    		using (new SPMonitoredScope("Baansoorten DeleteBaansoortById"))
    		{
    
    			try
    			{
    
    				tobedeleted = beheerModel.ClubCloud_Baansoorten.Find(Id);
    		
    				if (tobedeleted != null)
    				{
    					beheerModel.ClubCloud_Baansoorten.Remove(tobedeleted);
    					beheerModel.SaveChanges();
    				}
    				succes = true;
    			}
    			catch (Exception ex)
    			{
    				Logger.WriteLog(Logger.Category.Unexpected, ex.Source, ex.Message);
    			}
    			finally
    			{
    				if(tobedeleted != null)
    					try { beheerModel.ObjectContext.Detach(tobedeleted); } catch{}
    			}
    		}
    
    		return succes;
    	}
    
    
    	public ClubCloud_Baansoort_View GetBaansoortenByQuery(string bondsnummer, Guid verenigingId,System.Web.UI.DataSourceSelectArguments selectArgs = null, List<System.Web.UI.WebControls.Parameter> parameters = null, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		ClubCloud_Baansoort_View view = new ClubCloud_Baansoort_View();
    
    		using (new SPMonitoredScope("Baansoorten GetBaansoortenByQuery"))
    		{
    
    			StringBuilder querybuilder = new StringBuilder("SELECT * FROM dbo.ClubCloud_Baansoort");
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
    
    			view.ClubCloud_Baansoort = beheerModel.Database.SqlQuery<ClubCloud_Baansoort>(querybuilder.ToString(), sqlparams.ToArray()).Skip(selectArgs.StartRowIndex).Take(selectArgs.MaximumRows).ToList<ClubCloud_Baansoort>();
    
    			if (selectArgs.RetrieveTotalRowCount)
    			{
    
    				view.TotalRowCount = beheerModel.Database.SqlQuery<ClubCloud_Baansoort>(querybuilder.ToString(), sqlparamscount.ToArray()).Count();
    			}
    		}
    
    		return view;
    	}
    
    	public List<ClubCloud_Baansoort> GetBaansoortenBySearch(string prefixText, int count, string contextKey, ClubCloud_Setting _settings = null)
    	{
    		if(_settings != null)
    			ValidateSettings(ref _settings);
    
            List<string> baansoorten = new List<string>();
    
    		using (new SPMonitoredScope("Baansoorten GetBaansoortenBySearch"))
    		{
    
    			try
    			{
    				bool enabled = false; //beheerModel.Database.SqlQuery<bool>("SELECT (CAST((FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))AS BIT))").FirstOrDefault();
    
    				List<ClubCloud_Baansoort> entities = null;
    
    				if (enabled)
    				{
    					var fts = BeheerFullTextInterceptor.Fts(prefixText);
    				
    		
    				entities = beheerModel.ClubCloud_Baansoorten.Where(e => e.Naam.Contains(fts)  || e.Beschrijving.Contains(fts)  || e.Meervoud.Contains(fts)  || e.Omschrijving.Contains(fts)  || e.Code.Contains(fts) ).ToList();
    
    					
    				}
    				else
    				{
    	
    				entities = beheerModel.Database.SqlQuery<ClubCloud_Baansoort>("SELECT * FROM ClubCloud_Baansoort WHERE  Naam LIKE '%"+ prefixText +"%' OR  Beschrijving LIKE '%"+ prefixText +"%' OR  Meervoud LIKE '%"+ prefixText +"%' OR  Omschrijving LIKE '%"+ prefixText +"%' OR  Code LIKE '%"+ prefixText +"%'").ToList();
    
    					
    				}
    
    				if (entities != null && entities.Count > 0)
    					return entities;
    			}
    			catch (Exception ex)
    			{
    				Logger.WriteLog(Logger.Category.Unexpected, ex.Source, ex.Message);
    			}
    		}
    
            return new List<ClubCloud_Baansoort>();
    	}
    
    
    	public ClubCloud_Baantype GetBaantypeForBaansoort(ClubCloud_Baansoort entity, bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		ClubCloud_Baantype result = null;
    
    		using (new SPMonitoredScope("Baansoorten GetBaantypeForBaansoort"))
    		{
    
    			try
    			{
    				entity = beheerModel.ClubCloud_Baansoorten.Find(entity.Id);
    				if(entity != null && entity.ClubCloud_Baantype == null)
    					beheerModel.Entry(entity).Reference(e => e.ClubCloud_Baantype).Load();
    
    				if(entity != null)
    					result = entity.ClubCloud_Baantype;
    
    				if (result == null || refresh && entity != null)
    					result = GetBaantypeForBaansoort(settings.Id.ToString(), entity, refresh, settings);
    
    				if (result != null)
    					return result;
    			}
    			catch (Exception ex)
    			{
    				Logger.WriteLog(Logger.Category.Unexpected, ex.Source, ex.Message);
    			}
    			finally
    			{
    				if(entity != null)
    					try { beheerModel.ObjectContext.Detach(entity); } catch{}
    				if(result != null)
    					try { beheerModel.ObjectContext.Detach(result); } catch{}
    			}
    		}
    
    		return new ClubCloud_Baantype();
    	}
    
    	public bool SetBaantypeForBaansoort(ClubCloud_Baantype Baantype, ClubCloud_Baansoort entity , bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		bool succes = false;
    
    		using (new SPMonitoredScope("Baansoorten SetBaantypeForBaansoort"))
    		{
    
    			try
    			{		
    				entity = beheerModel.ClubCloud_Baansoorten.Find(entity.Id);	
    
    				if(entity != null && entity.ClubCloud_Baantype == null)
    					beheerModel.Entry(entity).Reference(e => e.ClubCloud_Baantype).Load();
    
    				if(entity != null)
    					entity.ClubCloud_Baantype = Baantype;
    
    				beheerModel.SaveChanges();
    				succes = true;
    			}
    			catch (Exception ex)
    			{
    				Logger.WriteLog(Logger.Category.Unexpected, ex.Source, ex.Message);
    			}
    			finally
    			{
    				if(entity != null)
    					try { beheerModel.ObjectContext.Detach(entity); } catch{}
    			}
    		}
    
    		return succes;
    	}
    
    
    	public ClubCloud_Baantype GetBaantypeForBaansoortById(System.Guid Id, bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		ClubCloud_Baansoort entity = null;
    		ClubCloud_Baantype result = null;
    
    		using (new SPMonitoredScope("Baansoorten GetBaantypeForBaansoortById"))
    		{
    
    			try
    			{
    				entity = beheerModel.ClubCloud_Baansoorten.Find(Id);
    				if(entity != null && entity.ClubCloud_Baantype == null)
    					beheerModel.Entry(entity).Reference(e => e.ClubCloud_Baantype).Load();
    
    				if(entity != null)
    					result = entity.ClubCloud_Baantype;
    
    				if (result == null || refresh)
    					result = GetBaantypeForBaansoortById(settings.Id.ToString(), Id, refresh, settings);
    
    				if (result != null)
    					return result;
    			}
    			catch (Exception ex)
    			{
    				Logger.WriteLog(Logger.Category.Unexpected, ex.Source, ex.Message);
    			}
    			finally
    			{
    				if(entity != null)
    					try { beheerModel.ObjectContext.Detach(entity); } catch{}
    				if(result != null)
    					try { beheerModel.ObjectContext.Detach(result); } catch{}
    			}
    		}
    
    		return new ClubCloud_Baantype();
    	}
    
    	public bool SetBaantypeForBaansoortById(ClubCloud_Baantype Baantype, System.Guid Id , bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		ClubCloud_Baansoort entity = null;
    		bool succes = false;
    
    		using (new SPMonitoredScope("Baansoorten SetBaantypeForBaansoortById"))
    		{
    
    			try
    			{		
    				entity = beheerModel.ClubCloud_Baansoorten.Find(Id);	
    
    				if(entity != null && entity.ClubCloud_Baantype == null)
    					beheerModel.Entry(entity).Reference(e => e.ClubCloud_Baantype).Load();
    
    				if(entity != null)
    					entity.ClubCloud_Baantype = Baantype;
    
    				beheerModel.SaveChanges();
    				succes= true;
    			}
    			catch (Exception ex)
    			{
    				Logger.WriteLog(Logger.Category.Unexpected, ex.Source, ex.Message);
    			}
    			finally
    			{
    				if(entity != null)
    					try { beheerModel.ObjectContext.Detach(entity); } catch{}
    			}
    		}
    				
    		return succes;
    	}
    
    
    	public List<ClubCloud_Baanblok> GetBaanblokkenForBaansoort(ClubCloud_Baansoort entity, bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		List<ClubCloud_Baanblok> result = null;
    
    		using (new SPMonitoredScope("Baansoorten GetBaanblokkenForBaansoort"))
    		{
    
    			try
    			{
    				entity = beheerModel.ClubCloud_Baansoorten.Find(entity.Id);
    				if(entity != null && entity.ClubCloud_Baanblok != null && entity.ClubCloud_Baanblok.Count == 0)
    					beheerModel.Entry(entity).Collection(e => e.ClubCloud_Baanblok).Load();
    
    				if(entity != null)
    					result = entity.ClubCloud_Baanblok.ToList();
    
    				if(result == null || result.Count == 0 || refresh && entity != null)
    					result = GetBaanblokkenForBaansoort(settings.Id.ToString(), entity, refresh, settings);
    
    				if(result != null)
    					return result;
    			}
    			catch (Exception ex)
    			{
    				Logger.WriteLog(Logger.Category.Unexpected, ex.Source, ex.Message);
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
    
    		return new List<ClubCloud_Baanblok>();
    	}
    
    
    	public List<ClubCloud_Baanblok> GetBaanblokkenForBaansoortById(System.Guid Id, bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		ClubCloud_Baansoort entity = null;
    		List<ClubCloud_Baanblok> result = null;
    
    		using (new SPMonitoredScope("Baansoorten GetBaanblokkenForBaansoortById"))
    		{
    
    			try
    			{
    				entity = beheerModel.ClubCloud_Baansoorten.Find(Id);
    				if(entity != null && entity.ClubCloud_Baanblok != null && entity.ClubCloud_Baanblok.Count == 0)
    					beheerModel.Entry(entity).Collection(e => e.ClubCloud_Baanblok).Load();
    
    				if(entity != null)
    					result = entity.ClubCloud_Baanblok.ToList();
    
    				if(result == null || result.Count == 0 || refresh)
    					result = GetBaanblokkenForBaansoortById(settings.Id.ToString(), Id, refresh, settings);
    
    				if(result != null)
    					return result;			
    			}
    			catch (Exception ex)
    			{
    				Logger.WriteLog(Logger.Category.Unexpected, ex.Source, ex.Message);
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
    
    		return new List<ClubCloud_Baanblok>();	
    	}
    
    	public bool SetBaanblokkenForBaansoort(List<ClubCloud_Baanblok> Baanblokken, ClubCloud_Baansoort entity, bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		bool succes = false;
    		ClubCloud_Baansoort result = null;
    
    		using (new SPMonitoredScope("Baansoorten SetBaanblokkenForBaansoort"))
    		{
    
    			try
    			{			
    				entity = beheerModel.ClubCloud_Baansoorten.Find(entity.Id);
    		
    				if (entity != null)
    					beheerModel.Entry(entity).Collection(e => e.ClubCloud_Baanblok).Load();
    					//result = GetBaansoortById(settings.Id.ToString(), Id, refresh, settings);
    
    				if (result != null)
    					//return result.ClubCloud_Baansoorten.Count == ;
    
    				succes = false;
    			}
    			catch (Exception ex)
    			{
    				Logger.WriteLog(Logger.Category.Unexpected, ex.Source, ex.Message);
    			}
    			finally
    			{
    				if(entity != null)
    					try { beheerModel.ObjectContext.Detach(entity); } catch{}
    			}
    		}
    
    		return succes;
    	}
    
    
    }
    
    [Serializable]
    [DataContract(IsReference = true)]
    [KnownType(typeof(ClubCloud_Baansoort))]
    public partial class ClubCloud_Baansoort_View
    {
    	public ClubCloud_Baansoort_View()
    	{
    		this.ClubCloud_Baansoort = new HashSet<ClubCloud_Baansoort>();
    	}
    
    	[DataMember]
    	public int TotalRowCount { get; set; }
    
    	[DataMember]
    	public virtual ICollection<ClubCloud_Baansoort> ClubCloud_Baansoort { get; set; }
    
    }
    	
}

