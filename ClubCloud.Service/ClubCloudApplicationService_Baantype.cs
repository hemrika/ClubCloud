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
    	public ClubCloud_Baantype GetBaantypeById(System.Guid Id , bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		ClubCloud_Baantype result = null;
    
    		using (new SPMonitoredScope("Baantypes GetBaantypeById"))
    		{
    
    			try
    			{			
    				result = beheerModel.ClubCloud_Baantypes.Find(Id);
    		
    				if (result == null || refresh)
    					result = GetBaantypeById(settings.Id.ToString(), Id, refresh, settings);
    
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
    
    		return new ClubCloud_Baantype();
    	}
    
    	public List<ClubCloud_Baantype> GetBaantypes(bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		List<ClubCloud_Baantype> result = null;
    
    		using (new SPMonitoredScope("Baantypes GetBaantypes"))
    		{
    		
    			try
    			{
    				result = beheerModel.ClubCloud_Baantypes.ToList<ClubCloud_Baantype>();
    		
    				if (result == null || result.Count == 0 || refresh)		
    					result = GetBaantypes(settings.Id.ToString(), refresh, settings);
    
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
    
    		return new List<ClubCloud_Baantype>();
    	}
    
    	public ClubCloud_Baantype SetBaantype(ClubCloud_Baantype entity, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		ClubCloud_Baantype tobeupdated = null;
    		
    		using (new SPMonitoredScope("Baantypes SetBaantype"))
    		{
    
    			try
    			{
    				entity = SetBaantype(settings.Id.ToString(), entity, settings);
    
    				if(entity != null)
    					beheerModel.ClubCloud_Baantypes.AddOrUpdate(entity);
    		
    				beheerModel.SaveChanges();
    
    				tobeupdated = beheerModel.ClubCloud_Baantypes.Find(entity.Id);
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
    
    
    	public bool DeleteBaantype(ClubCloud_Baantype entity, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		return DeleteBaantypeById(entity.Id, settings);
    	}
    
    	public bool DeleteBaantypeById(System.Guid Id, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		bool succes = false;
    		ClubCloud_Baantype tobedeleted = null;
    
    		using (new SPMonitoredScope("Baantypes DeleteBaantypeById"))
    		{
    
    			try
    			{
    
    				tobedeleted = beheerModel.ClubCloud_Baantypes.Find(Id);
    		
    				if (tobedeleted != null)
    				{
    					beheerModel.ClubCloud_Baantypes.Remove(tobedeleted);
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
    
    
    	public ClubCloud_Baantype_View GetBaantypesByQuery(string bondsnummer, Guid verenigingId,System.Web.UI.DataSourceSelectArguments selectArgs = null, List<System.Web.UI.WebControls.Parameter> parameters = null, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		ClubCloud_Baantype_View view = new ClubCloud_Baantype_View();
    
    		using (new SPMonitoredScope("Baantypes GetBaantypesByQuery"))
    		{
    
    			StringBuilder querybuilder = new StringBuilder("SELECT * FROM dbo.ClubCloud_Baantype");
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
    
    			view.ClubCloud_Baantype = beheerModel.Database.SqlQuery<ClubCloud_Baantype>(querybuilder.ToString(), sqlparams.ToArray()).Skip(selectArgs.StartRowIndex).Take(selectArgs.MaximumRows).ToList<ClubCloud_Baantype>();
    
    			if (selectArgs.RetrieveTotalRowCount)
    			{
    
    				view.TotalRowCount = beheerModel.Database.SqlQuery<ClubCloud_Baantype>(querybuilder.ToString(), sqlparamscount.ToArray()).Count();
    			}
    		}
    
    		return view;
    	}
    
    	public List<ClubCloud_Baantype> GetBaantypesBySearch(string prefixText, int count, string contextKey, ClubCloud_Setting _settings = null)
    	{
    		if(_settings != null)
    			ValidateSettings(ref _settings);
    
            List<string> baantypes = new List<string>();
    
    		using (new SPMonitoredScope("Baantypes GetBaantypesBySearch"))
    		{
    
    			try
    			{
    				bool enabled = false; //beheerModel.Database.SqlQuery<bool>("SELECT (CAST((FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))AS BIT))").FirstOrDefault();
    
    				List<ClubCloud_Baantype> entities = null;
    
    				if (enabled)
    				{
    					var fts = BeheerFullTextInterceptor.Fts(prefixText);
    				
    		
    				entities = beheerModel.ClubCloud_Baantypes.Where(e => e.Naam.Contains(fts)  || e.Beschrijving.Contains(fts)  || e.Meervoud.Contains(fts)  || e.Omschrijving.Contains(fts)  || e.Code.Contains(fts) ).ToList();
    
    					
    				}
    				else
    				{
    	
    				entities = beheerModel.Database.SqlQuery<ClubCloud_Baantype>("SELECT * FROM ClubCloud_Baantype WHERE  Naam LIKE '%"+ prefixText +"%' OR  Beschrijving LIKE '%"+ prefixText +"%' OR  Meervoud LIKE '%"+ prefixText +"%' OR  Omschrijving LIKE '%"+ prefixText +"%' OR  Code LIKE '%"+ prefixText +"%'").ToList();
    
    					
    				}
    
    				if (entities != null && entities.Count > 0)
    					return entities;
    			}
    			catch (Exception ex)
    			{
    				Logger.WriteLog(Logger.Category.Unexpected, ex.Source, ex.Message);
    			}
    		}
    
            return new List<ClubCloud_Baantype>();
    	}
    
    
    	public List<ClubCloud_Baansoort> GetBaansoortenForBaantype(ClubCloud_Baantype entity, bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		List<ClubCloud_Baansoort> result = null;
    
    		using (new SPMonitoredScope("Baantypes GetBaansoortenForBaantype"))
    		{
    
    			try
    			{
    				entity = beheerModel.ClubCloud_Baantypes.Find(entity.Id);
    				if(entity != null && entity.ClubCloud_Baansoort != null && entity.ClubCloud_Baansoort.Count == 0)
    					beheerModel.Entry(entity).Collection(e => e.ClubCloud_Baansoort).Load();
    
    				if(entity != null)
    					result = entity.ClubCloud_Baansoort.ToList();
    
    				if(result == null || result.Count == 0 || refresh && entity != null)
    					result = GetBaansoortenForBaantype(settings.Id.ToString(), entity, refresh, settings);
    
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
    
    		return new List<ClubCloud_Baansoort>();
    	}
    
    
    	public List<ClubCloud_Baansoort> GetBaansoortenForBaantypeById(System.Guid Id, bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		ClubCloud_Baantype entity = null;
    		List<ClubCloud_Baansoort> result = null;
    
    		using (new SPMonitoredScope("Baantypes GetBaansoortenForBaantypeById"))
    		{
    
    			try
    			{
    				entity = beheerModel.ClubCloud_Baantypes.Find(Id);
    				if(entity != null && entity.ClubCloud_Baansoort != null && entity.ClubCloud_Baansoort.Count == 0)
    					beheerModel.Entry(entity).Collection(e => e.ClubCloud_Baansoort).Load();
    
    				if(entity != null)
    					result = entity.ClubCloud_Baansoort.ToList();
    
    				if(result == null || result.Count == 0 || refresh)
    					result = GetBaansoortenForBaantypeById(settings.Id.ToString(), Id, refresh, settings);
    
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
    
    		return new List<ClubCloud_Baansoort>();	
    	}
    
    	public bool SetBaansoortenForBaantype(List<ClubCloud_Baansoort> Baansoorten, ClubCloud_Baantype entity, bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		bool succes = false;
    		ClubCloud_Baantype result = null;
    
    		using (new SPMonitoredScope("Baantypes SetBaansoortenForBaantype"))
    		{
    
    			try
    			{			
    				entity = beheerModel.ClubCloud_Baantypes.Find(entity.Id);
    		
    				if (entity != null)
    					beheerModel.Entry(entity).Collection(e => e.ClubCloud_Baansoort).Load();
    					//result = GetBaantypeById(settings.Id.ToString(), Id, refresh, settings);
    
    				if (result != null)
    					//return result.ClubCloud_Baantypes.Count == ;
    
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
    
    
    
    	public List<ClubCloud_Baanblok> GetBaanblokkenForBaantype(ClubCloud_Baantype entity, bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		List<ClubCloud_Baanblok> result = null;
    
    		using (new SPMonitoredScope("Baantypes GetBaanblokkenForBaantype"))
    		{
    
    			try
    			{
    				entity = beheerModel.ClubCloud_Baantypes.Find(entity.Id);
    				if(entity != null && entity.ClubCloud_Baanblok != null && entity.ClubCloud_Baanblok.Count == 0)
    					beheerModel.Entry(entity).Collection(e => e.ClubCloud_Baanblok).Load();
    
    				if(entity != null)
    					result = entity.ClubCloud_Baanblok.ToList();
    
    				if(result == null || result.Count == 0 || refresh && entity != null)
    					result = GetBaanblokkenForBaantype(settings.Id.ToString(), entity, refresh, settings);
    
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
    
    
    	public List<ClubCloud_Baanblok> GetBaanblokkenForBaantypeById(System.Guid Id, bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		ClubCloud_Baantype entity = null;
    		List<ClubCloud_Baanblok> result = null;
    
    		using (new SPMonitoredScope("Baantypes GetBaanblokkenForBaantypeById"))
    		{
    
    			try
    			{
    				entity = beheerModel.ClubCloud_Baantypes.Find(Id);
    				if(entity != null && entity.ClubCloud_Baanblok != null && entity.ClubCloud_Baanblok.Count == 0)
    					beheerModel.Entry(entity).Collection(e => e.ClubCloud_Baanblok).Load();
    
    				if(entity != null)
    					result = entity.ClubCloud_Baanblok.ToList();
    
    				if(result == null || result.Count == 0 || refresh)
    					result = GetBaanblokkenForBaantypeById(settings.Id.ToString(), Id, refresh, settings);
    
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
    
    	public bool SetBaanblokkenForBaantype(List<ClubCloud_Baanblok> Baanblokken, ClubCloud_Baantype entity, bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		bool succes = false;
    		ClubCloud_Baantype result = null;
    
    		using (new SPMonitoredScope("Baantypes SetBaanblokkenForBaantype"))
    		{
    
    			try
    			{			
    				entity = beheerModel.ClubCloud_Baantypes.Find(entity.Id);
    		
    				if (entity != null)
    					beheerModel.Entry(entity).Collection(e => e.ClubCloud_Baanblok).Load();
    					//result = GetBaantypeById(settings.Id.ToString(), Id, refresh, settings);
    
    				if (result != null)
    					//return result.ClubCloud_Baantypes.Count == ;
    
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
    [KnownType(typeof(ClubCloud_Baantype))]
    public partial class ClubCloud_Baantype_View
    {
    	public ClubCloud_Baantype_View()
    	{
    		this.ClubCloud_Baantype = new HashSet<ClubCloud_Baantype>();
    	}
    
    	[DataMember]
    	public int TotalRowCount { get; set; }
    
    	[DataMember]
    	public virtual ICollection<ClubCloud_Baantype> ClubCloud_Baantype { get; set; }
    
    }
    	
}

