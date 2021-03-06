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
    	public ClubCloud_Regio GetRegioById(System.Guid Id , bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		ClubCloud_Regio result = null;
    
    		using (new SPMonitoredScope("Regios GetRegioById"))
    		{
    
    			try
    			{			
    				result = beheerModel.ClubCloud_Regios.Find(Id);
    		
    				if (result == null || refresh)
    					result = GetRegioById(settings.Id.ToString(), Id, refresh, settings);
    
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
    
    		return new ClubCloud_Regio();
    	}
    
    	public List<ClubCloud_Regio> GetRegios(bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		List<ClubCloud_Regio> result = null;
    
    		using (new SPMonitoredScope("Regios GetRegios"))
    		{
    		
    			try
    			{
    				result = beheerModel.ClubCloud_Regios.ToList<ClubCloud_Regio>();
    		
    				if (result == null || result.Count == 0 || refresh)		
    					result = GetRegios(settings.Id.ToString(), refresh, settings);
    
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
    
    		return new List<ClubCloud_Regio>();
    	}
    
    	public ClubCloud_Regio SetRegio(ClubCloud_Regio entity, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		ClubCloud_Regio tobeupdated = null;
    		
    		using (new SPMonitoredScope("Regios SetRegio"))
    		{
    
    			try
    			{
    				entity = SetRegio(settings.Id.ToString(), entity, settings);
    
    				if(entity != null)
    					beheerModel.ClubCloud_Regios.AddOrUpdate(entity);
    		
    				beheerModel.SaveChanges();
    
    				tobeupdated = beheerModel.ClubCloud_Regios.Find(entity.Id);
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
    
    
    	public bool DeleteRegio(ClubCloud_Regio entity, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		return DeleteRegioById(entity.Id, settings);
    	}
    
    	public bool DeleteRegioById(System.Guid Id, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		bool succes = false;
    		ClubCloud_Regio tobedeleted = null;
    
    		using (new SPMonitoredScope("Regios DeleteRegioById"))
    		{
    
    			try
    			{
    
    				tobedeleted = beheerModel.ClubCloud_Regios.Find(Id);
    		
    				if (tobedeleted != null)
    				{
    					beheerModel.ClubCloud_Regios.Remove(tobedeleted);
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
    
    
    	public ClubCloud_Regio_View GetRegiosByQuery(string bondsnummer, Guid verenigingId,System.Web.UI.DataSourceSelectArguments selectArgs = null, List<System.Web.UI.WebControls.Parameter> parameters = null, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		ClubCloud_Regio_View view = new ClubCloud_Regio_View();
    
    		using (new SPMonitoredScope("Regios GetRegiosByQuery"))
    		{
    
    			StringBuilder querybuilder = new StringBuilder("SELECT * FROM dbo.ClubCloud_Regio");
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
    
    			view.ClubCloud_Regio = beheerModel.Database.SqlQuery<ClubCloud_Regio>(querybuilder.ToString(), sqlparams.ToArray()).Skip(selectArgs.StartRowIndex).Take(selectArgs.MaximumRows).ToList<ClubCloud_Regio>();
    
    			if (selectArgs.RetrieveTotalRowCount)
    			{
    
    				view.TotalRowCount = beheerModel.Database.SqlQuery<ClubCloud_Regio>(querybuilder.ToString(), sqlparamscount.ToArray()).Count();
    			}
    		}
    
    		return view;
    	}
    
    	public List<ClubCloud_Regio> GetRegiosBySearch(string prefixText, int count, string contextKey, ClubCloud_Setting _settings = null)
    	{
    		if(_settings != null)
    			ValidateSettings(ref _settings);
    
            List<string> regios = new List<string>();
    
    		using (new SPMonitoredScope("Regios GetRegiosBySearch"))
    		{
    
    			try
    			{
    				bool enabled = false; //beheerModel.Database.SqlQuery<bool>("SELECT (CAST((FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))AS BIT))").FirstOrDefault();
    
    				List<ClubCloud_Regio> entities = null;
    
    				if (enabled)
    				{
    					var fts = BeheerFullTextInterceptor.Fts(prefixText);
    				
    		
    				entities = beheerModel.ClubCloud_Regios.Where(e => e.Naam.Contains(fts)  || e.EmailKNLTB.Contains(fts)  || e.TelefoonAvond.Contains(fts)  || e.TelefoonOverdag.Contains(fts)  || e.Fax.Contains(fts) ).ToList();
    
    					
    				}
    				else
    				{
    	
    				entities = beheerModel.Database.SqlQuery<ClubCloud_Regio>("SELECT * FROM ClubCloud_Regio WHERE  Naam LIKE '%"+ prefixText +"%' OR  EmailKNLTB LIKE '%"+ prefixText +"%' OR  TelefoonAvond LIKE '%"+ prefixText +"%' OR  TelefoonOverdag LIKE '%"+ prefixText +"%' OR  Fax LIKE '%"+ prefixText +"%'").ToList();
    
    					
    				}
    
    				if (entities != null && entities.Count > 0)
    					return entities;
    			}
    			catch (Exception ex)
    			{
    				Logger.WriteLog(Logger.Category.Unexpected, ex.Source, ex.Message);
    			}
    		}
    
            return new List<ClubCloud_Regio>();
    	}
    
    
    	public List<ClubCloud_Vereniging> GetVerenigingenForRegio(ClubCloud_Regio entity, bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		List<ClubCloud_Vereniging> result = null;
    
    		using (new SPMonitoredScope("Regios GetVerenigingenForRegio"))
    		{
    
    			try
    			{
    				entity = beheerModel.ClubCloud_Regios.Find(entity.Id);
    				if(entity != null && entity.ClubCloud_Vereniging != null && entity.ClubCloud_Vereniging.Count == 0)
    					beheerModel.Entry(entity).Collection(e => e.ClubCloud_Vereniging).Load();
    
    				if(entity != null)
    					result = entity.ClubCloud_Vereniging.ToList();
    
    				if(result == null || result.Count == 0 || refresh && entity != null)
    					result = GetVerenigingenForRegio(settings.Id.ToString(), entity, refresh, settings);
    
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
    
    		return new List<ClubCloud_Vereniging>();
    	}
    
    
    	public List<ClubCloud_Vereniging> GetVerenigingenForRegioById(System.Guid Id, bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		ClubCloud_Regio entity = null;
    		List<ClubCloud_Vereniging> result = null;
    
    		using (new SPMonitoredScope("Regios GetVerenigingenForRegioById"))
    		{
    
    			try
    			{
    				entity = beheerModel.ClubCloud_Regios.Find(Id);
    				if(entity != null && entity.ClubCloud_Vereniging != null && entity.ClubCloud_Vereniging.Count == 0)
    					beheerModel.Entry(entity).Collection(e => e.ClubCloud_Vereniging).Load();
    
    				if(entity != null)
    					result = entity.ClubCloud_Vereniging.ToList();
    
    				if(result == null || result.Count == 0 || refresh)
    					result = GetVerenigingenForRegioById(settings.Id.ToString(), Id, refresh, settings);
    
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
    
    		return new List<ClubCloud_Vereniging>();	
    	}
    
    	public bool SetVerenigingenForRegio(List<ClubCloud_Vereniging> Verenigingen, ClubCloud_Regio entity, bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		bool succes = false;
    		ClubCloud_Regio result = null;
    
    		using (new SPMonitoredScope("Regios SetVerenigingenForRegio"))
    		{
    
    			try
    			{			
    				entity = beheerModel.ClubCloud_Regios.Find(entity.Id);
    		
    				if (entity != null)
    					beheerModel.Entry(entity).Collection(e => e.ClubCloud_Vereniging).Load();
    					//result = GetRegioById(settings.Id.ToString(), Id, refresh, settings);
    
    				if (result != null)
    					//return result.ClubCloud_Regios.Count == ;
    
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
    
    
    
    	public List<ClubCloud_District> GetDistrictenForRegio(ClubCloud_Regio entity, bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		List<ClubCloud_District> result = null;
    
    		using (new SPMonitoredScope("Regios GetDistrictenForRegio"))
    		{
    
    			try
    			{
    				entity = beheerModel.ClubCloud_Regios.Find(entity.Id);
    				if(entity != null && entity.ClubCloud_District != null && entity.ClubCloud_District.Count == 0)
    					beheerModel.Entry(entity).Collection(e => e.ClubCloud_District).Load();
    
    				if(entity != null)
    					result = entity.ClubCloud_District.ToList();
    
    				if(result == null || result.Count == 0 || refresh && entity != null)
    					result = GetDistrictenForRegio(settings.Id.ToString(), entity, refresh, settings);
    
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
    
    		return new List<ClubCloud_District>();
    	}
    
    
    	public List<ClubCloud_District> GetDistrictenForRegioById(System.Guid Id, bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		ClubCloud_Regio entity = null;
    		List<ClubCloud_District> result = null;
    
    		using (new SPMonitoredScope("Regios GetDistrictenForRegioById"))
    		{
    
    			try
    			{
    				entity = beheerModel.ClubCloud_Regios.Find(Id);
    				if(entity != null && entity.ClubCloud_District != null && entity.ClubCloud_District.Count == 0)
    					beheerModel.Entry(entity).Collection(e => e.ClubCloud_District).Load();
    
    				if(entity != null)
    					result = entity.ClubCloud_District.ToList();
    
    				if(result == null || result.Count == 0 || refresh)
    					result = GetDistrictenForRegioById(settings.Id.ToString(), Id, refresh, settings);
    
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
    
    		return new List<ClubCloud_District>();	
    	}
    
    	public bool SetDistrictenForRegio(List<ClubCloud_District> Districten, ClubCloud_Regio entity, bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		bool succes = false;
    		ClubCloud_Regio result = null;
    
    		using (new SPMonitoredScope("Regios SetDistrictenForRegio"))
    		{
    
    			try
    			{			
    				entity = beheerModel.ClubCloud_Regios.Find(entity.Id);
    		
    				if (entity != null)
    					beheerModel.Entry(entity).Collection(e => e.ClubCloud_District).Load();
    					//result = GetRegioById(settings.Id.ToString(), Id, refresh, settings);
    
    				if (result != null)
    					//return result.ClubCloud_Regios.Count == ;
    
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
    
    
    
    	public List<ClubCloud_Accommodatie> GetAccommodatiesForRegio(ClubCloud_Regio entity, bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		List<ClubCloud_Accommodatie> result = null;
    
    		using (new SPMonitoredScope("Regios GetAccommodatiesForRegio"))
    		{
    
    			try
    			{
    				entity = beheerModel.ClubCloud_Regios.Find(entity.Id);
    				if(entity != null && entity.ClubCloud_Accommodatie != null && entity.ClubCloud_Accommodatie.Count == 0)
    					beheerModel.Entry(entity).Collection(e => e.ClubCloud_Accommodatie).Load();
    
    				if(entity != null)
    					result = entity.ClubCloud_Accommodatie.ToList();
    
    				if(result == null || result.Count == 0 || refresh && entity != null)
    					result = GetAccommodatiesForRegio(settings.Id.ToString(), entity, refresh, settings);
    
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
    
    		return new List<ClubCloud_Accommodatie>();
    	}
    
    
    	public List<ClubCloud_Accommodatie> GetAccommodatiesForRegioById(System.Guid Id, bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		ClubCloud_Regio entity = null;
    		List<ClubCloud_Accommodatie> result = null;
    
    		using (new SPMonitoredScope("Regios GetAccommodatiesForRegioById"))
    		{
    
    			try
    			{
    				entity = beheerModel.ClubCloud_Regios.Find(Id);
    				if(entity != null && entity.ClubCloud_Accommodatie != null && entity.ClubCloud_Accommodatie.Count == 0)
    					beheerModel.Entry(entity).Collection(e => e.ClubCloud_Accommodatie).Load();
    
    				if(entity != null)
    					result = entity.ClubCloud_Accommodatie.ToList();
    
    				if(result == null || result.Count == 0 || refresh)
    					result = GetAccommodatiesForRegioById(settings.Id.ToString(), Id, refresh, settings);
    
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
    
    		return new List<ClubCloud_Accommodatie>();	
    	}
    
    	public bool SetAccommodatiesForRegio(List<ClubCloud_Accommodatie> Accommodaties, ClubCloud_Regio entity, bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		bool succes = false;
    		ClubCloud_Regio result = null;
    
    		using (new SPMonitoredScope("Regios SetAccommodatiesForRegio"))
    		{
    
    			try
    			{			
    				entity = beheerModel.ClubCloud_Regios.Find(entity.Id);
    		
    				if (entity != null)
    					beheerModel.Entry(entity).Collection(e => e.ClubCloud_Accommodatie).Load();
    					//result = GetRegioById(settings.Id.ToString(), Id, refresh, settings);
    
    				if (result != null)
    					//return result.ClubCloud_Regios.Count == ;
    
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
    
    
    
    	public List<ClubCloud_Address> GetAddressenForRegio(ClubCloud_Regio entity, bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		List<ClubCloud_Address> result = null;
    
    		using (new SPMonitoredScope("Regios GetAddressenForRegio"))
    		{
    
    			try
    			{
    				entity = beheerModel.ClubCloud_Regios.Find(entity.Id);
    				if(entity != null && entity.ClubCloud_Address != null && entity.ClubCloud_Address.Count == 0)
    					beheerModel.Entry(entity).Collection(e => e.ClubCloud_Address).Load();
    
    				if(entity != null)
    					result = entity.ClubCloud_Address.ToList();
    
    				if(result == null || result.Count == 0 || refresh && entity != null)
    					result = GetAddressenForRegio(settings.Id.ToString(), entity, refresh, settings);
    
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
    
    		return new List<ClubCloud_Address>();
    	}
    
    
    	public List<ClubCloud_Address> GetAddressenForRegioById(System.Guid Id, bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		ClubCloud_Regio entity = null;
    		List<ClubCloud_Address> result = null;
    
    		using (new SPMonitoredScope("Regios GetAddressenForRegioById"))
    		{
    
    			try
    			{
    				entity = beheerModel.ClubCloud_Regios.Find(Id);
    				if(entity != null && entity.ClubCloud_Address != null && entity.ClubCloud_Address.Count == 0)
    					beheerModel.Entry(entity).Collection(e => e.ClubCloud_Address).Load();
    
    				if(entity != null)
    					result = entity.ClubCloud_Address.ToList();
    
    				if(result == null || result.Count == 0 || refresh)
    					result = GetAddressenForRegioById(settings.Id.ToString(), Id, refresh, settings);
    
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
    
    		return new List<ClubCloud_Address>();	
    	}
    
    	public bool SetAddressenForRegio(List<ClubCloud_Address> Addressen, ClubCloud_Regio entity, bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		bool succes = false;
    		ClubCloud_Regio result = null;
    
    		using (new SPMonitoredScope("Regios SetAddressenForRegio"))
    		{
    
    			try
    			{			
    				entity = beheerModel.ClubCloud_Regios.Find(entity.Id);
    		
    				if (entity != null)
    					beheerModel.Entry(entity).Collection(e => e.ClubCloud_Address).Load();
    					//result = GetRegioById(settings.Id.ToString(), Id, refresh, settings);
    
    				if (result != null)
    					//return result.ClubCloud_Regios.Count == ;
    
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
    [KnownType(typeof(ClubCloud_Regio))]
    public partial class ClubCloud_Regio_View
    {
    	public ClubCloud_Regio_View()
    	{
    		this.ClubCloud_Regio = new HashSet<ClubCloud_Regio>();
    	}
    
    	[DataMember]
    	public int TotalRowCount { get; set; }
    
    	[DataMember]
    	public virtual ICollection<ClubCloud_Regio> ClubCloud_Regio { get; set; }
    
    }
    	
}

