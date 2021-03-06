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
    	public ClubCloud_District GetDistrictById(System.Guid Id , bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		ClubCloud_District result = null;
    
    		using (new SPMonitoredScope("Districten GetDistrictById"))
    		{
    
    			try
    			{			
    				result = beheerModel.ClubCloud_Districten.Find(Id);
    		
    				if (result == null || refresh)
    					result = GetDistrictById(settings.Id.ToString(), Id, refresh, settings);
    
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
    
    		return new ClubCloud_District();
    	}
    
    	public List<ClubCloud_District> GetDistricten(bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		List<ClubCloud_District> result = null;
    
    		using (new SPMonitoredScope("Districten GetDistricten"))
    		{
    		
    			try
    			{
    				result = beheerModel.ClubCloud_Districten.ToList<ClubCloud_District>();
    		
    				if (result == null || result.Count == 0 || refresh)		
    					result = GetDistricten(settings.Id.ToString(), refresh, settings);
    
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
    
    		return new List<ClubCloud_District>();
    	}
    
    	public ClubCloud_District SetDistrict(ClubCloud_District entity, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		ClubCloud_District tobeupdated = null;
    		
    		using (new SPMonitoredScope("Districten SetDistrict"))
    		{
    
    			try
    			{
    				entity = SetDistrict(settings.Id.ToString(), entity, settings);
    
    				if(entity != null)
    					beheerModel.ClubCloud_Districten.AddOrUpdate(entity);
    		
    				beheerModel.SaveChanges();
    
    				tobeupdated = beheerModel.ClubCloud_Districten.Find(entity.Id);
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
    
    
    	public bool DeleteDistrict(ClubCloud_District entity, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		return DeleteDistrictById(entity.Id, settings);
    	}
    
    	public bool DeleteDistrictById(System.Guid Id, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		bool succes = false;
    		ClubCloud_District tobedeleted = null;
    
    		using (new SPMonitoredScope("Districten DeleteDistrictById"))
    		{
    
    			try
    			{
    
    				tobedeleted = beheerModel.ClubCloud_Districten.Find(Id);
    		
    				if (tobedeleted != null)
    				{
    					beheerModel.ClubCloud_Districten.Remove(tobedeleted);
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
    
    
    	public ClubCloud_District_View GetDistrictenByQuery(string bondsnummer, Guid verenigingId,System.Web.UI.DataSourceSelectArguments selectArgs = null, List<System.Web.UI.WebControls.Parameter> parameters = null, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		ClubCloud_District_View view = new ClubCloud_District_View();
    
    		using (new SPMonitoredScope("Districten GetDistrictenByQuery"))
    		{
    
    			StringBuilder querybuilder = new StringBuilder("SELECT * FROM dbo.ClubCloud_District");
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
    
    			view.ClubCloud_District = beheerModel.Database.SqlQuery<ClubCloud_District>(querybuilder.ToString(), sqlparams.ToArray()).Skip(selectArgs.StartRowIndex).Take(selectArgs.MaximumRows).ToList<ClubCloud_District>();
    
    			if (selectArgs.RetrieveTotalRowCount)
    			{
    
    				view.TotalRowCount = beheerModel.Database.SqlQuery<ClubCloud_District>(querybuilder.ToString(), sqlparamscount.ToArray()).Count();
    			}
    		}
    
    		return view;
    	}
    
    	public List<ClubCloud_District> GetDistrictenBySearch(string prefixText, int count, string contextKey, ClubCloud_Setting _settings = null)
    	{
    		if(_settings != null)
    			ValidateSettings(ref _settings);
    
            List<string> districten = new List<string>();
    
    		using (new SPMonitoredScope("Districten GetDistrictenBySearch"))
    		{
    
    			try
    			{
    				bool enabled = false; //beheerModel.Database.SqlQuery<bool>("SELECT (CAST((FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))AS BIT))").FirstOrDefault();
    
    				List<ClubCloud_District> entities = null;
    
    				if (enabled)
    				{
    					var fts = BeheerFullTextInterceptor.Fts(prefixText);
    				
    		
    				entities = beheerModel.ClubCloud_Districten.Where(e => e.Naam.Contains(fts)  || e.Beschrijving.Contains(fts)  || e.Omschrijving.Contains(fts) ).ToList();
    
    					
    				}
    				else
    				{
    	
    				entities = beheerModel.Database.SqlQuery<ClubCloud_District>("SELECT * FROM ClubCloud_District WHERE  Naam LIKE '%"+ prefixText +"%' OR  Beschrijving LIKE '%"+ prefixText +"%' OR  Omschrijving LIKE '%"+ prefixText +"%'").ToList();
    
    					
    				}
    
    				if (entities != null && entities.Count > 0)
    					return entities;
    			}
    			catch (Exception ex)
    			{
    				Logger.WriteLog(Logger.Category.Unexpected, ex.Source, ex.Message);
    			}
    		}
    
            return new List<ClubCloud_District>();
    	}
    
    
    	public List<ClubCloud_Functionaris> GetFunctionarissenForDistrict(ClubCloud_District entity, bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		List<ClubCloud_Functionaris> result = null;
    
    		using (new SPMonitoredScope("Districten GetFunctionarissenForDistrict"))
    		{
    
    			try
    			{
    				entity = beheerModel.ClubCloud_Districten.Find(entity.Id);
    				if(entity != null && entity.ClubCloud_Functionaris != null && entity.ClubCloud_Functionaris.Count == 0)
    					beheerModel.Entry(entity).Collection(e => e.ClubCloud_Functionaris).Load();
    
    				if(entity != null)
    					result = entity.ClubCloud_Functionaris.ToList();
    
    				if(result == null || result.Count == 0 || refresh && entity != null)
    					result = GetFunctionarissenForDistrict(settings.Id.ToString(), entity, refresh, settings);
    
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
    
    		return new List<ClubCloud_Functionaris>();
    	}
    
    
    	public List<ClubCloud_Functionaris> GetFunctionarissenForDistrictById(System.Guid Id, bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		ClubCloud_District entity = null;
    		List<ClubCloud_Functionaris> result = null;
    
    		using (new SPMonitoredScope("Districten GetFunctionarissenForDistrictById"))
    		{
    
    			try
    			{
    				entity = beheerModel.ClubCloud_Districten.Find(Id);
    				if(entity != null && entity.ClubCloud_Functionaris != null && entity.ClubCloud_Functionaris.Count == 0)
    					beheerModel.Entry(entity).Collection(e => e.ClubCloud_Functionaris).Load();
    
    				if(entity != null)
    					result = entity.ClubCloud_Functionaris.ToList();
    
    				if(result == null || result.Count == 0 || refresh)
    					result = GetFunctionarissenForDistrictById(settings.Id.ToString(), Id, refresh, settings);
    
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
    
    		return new List<ClubCloud_Functionaris>();	
    	}
    
    	public bool SetFunctionarissenForDistrict(List<ClubCloud_Functionaris> Functionarissen, ClubCloud_District entity, bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		bool succes = false;
    		ClubCloud_District result = null;
    
    		using (new SPMonitoredScope("Districten SetFunctionarissenForDistrict"))
    		{
    
    			try
    			{			
    				entity = beheerModel.ClubCloud_Districten.Find(entity.Id);
    		
    				if (entity != null)
    					beheerModel.Entry(entity).Collection(e => e.ClubCloud_Functionaris).Load();
    					//result = GetDistrictById(settings.Id.ToString(), Id, refresh, settings);
    
    				if (result != null)
    					//return result.ClubCloud_Districten.Count == ;
    
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
    
    
    
    	public List<ClubCloud_Vereniging> GetVerenigingenForDistrict(ClubCloud_District entity, bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		List<ClubCloud_Vereniging> result = null;
    
    		using (new SPMonitoredScope("Districten GetVerenigingenForDistrict"))
    		{
    
    			try
    			{
    				entity = beheerModel.ClubCloud_Districten.Find(entity.Id);
    				if(entity != null && entity.ClubCloud_Vereniging != null && entity.ClubCloud_Vereniging.Count == 0)
    					beheerModel.Entry(entity).Collection(e => e.ClubCloud_Vereniging).Load();
    
    				if(entity != null)
    					result = entity.ClubCloud_Vereniging.ToList();
    
    				if(result == null || result.Count == 0 || refresh && entity != null)
    					result = GetVerenigingenForDistrict(settings.Id.ToString(), entity, refresh, settings);
    
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
    
    
    	public List<ClubCloud_Vereniging> GetVerenigingenForDistrictById(System.Guid Id, bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		ClubCloud_District entity = null;
    		List<ClubCloud_Vereniging> result = null;
    
    		using (new SPMonitoredScope("Districten GetVerenigingenForDistrictById"))
    		{
    
    			try
    			{
    				entity = beheerModel.ClubCloud_Districten.Find(Id);
    				if(entity != null && entity.ClubCloud_Vereniging != null && entity.ClubCloud_Vereniging.Count == 0)
    					beheerModel.Entry(entity).Collection(e => e.ClubCloud_Vereniging).Load();
    
    				if(entity != null)
    					result = entity.ClubCloud_Vereniging.ToList();
    
    				if(result == null || result.Count == 0 || refresh)
    					result = GetVerenigingenForDistrictById(settings.Id.ToString(), Id, refresh, settings);
    
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
    
    	public bool SetVerenigingenForDistrict(List<ClubCloud_Vereniging> Verenigingen, ClubCloud_District entity, bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		bool succes = false;
    		ClubCloud_District result = null;
    
    		using (new SPMonitoredScope("Districten SetVerenigingenForDistrict"))
    		{
    
    			try
    			{			
    				entity = beheerModel.ClubCloud_Districten.Find(entity.Id);
    		
    				if (entity != null)
    					beheerModel.Entry(entity).Collection(e => e.ClubCloud_Vereniging).Load();
    					//result = GetDistrictById(settings.Id.ToString(), Id, refresh, settings);
    
    				if (result != null)
    					//return result.ClubCloud_Districten.Count == ;
    
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
    
    
    
    	public ClubCloud_Regio GetRegioForDistrict(ClubCloud_District entity, bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		ClubCloud_Regio result = null;
    
    		using (new SPMonitoredScope("Districten GetRegioForDistrict"))
    		{
    
    			try
    			{
    				entity = beheerModel.ClubCloud_Districten.Find(entity.Id);
    				if(entity != null && entity.ClubCloud_Regio == null)
    					beheerModel.Entry(entity).Reference(e => e.ClubCloud_Regio).Load();
    
    				if(entity != null)
    					result = entity.ClubCloud_Regio;
    
    				if (result == null || refresh && entity != null)
    					result = GetRegioForDistrict(settings.Id.ToString(), entity, refresh, settings);
    
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
    
    		return new ClubCloud_Regio();
    	}
    
    	public bool SetRegioForDistrict(ClubCloud_Regio Regio, ClubCloud_District entity , bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		bool succes = false;
    
    		using (new SPMonitoredScope("Districten SetRegioForDistrict"))
    		{
    
    			try
    			{		
    				entity = beheerModel.ClubCloud_Districten.Find(entity.Id);	
    
    				if(entity != null && entity.ClubCloud_Regio == null)
    					beheerModel.Entry(entity).Reference(e => e.ClubCloud_Regio).Load();
    
    				if(entity != null)
    					entity.ClubCloud_Regio = Regio;
    
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
    
    
    	public ClubCloud_Regio GetRegioForDistrictById(System.Guid Id, bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		ClubCloud_District entity = null;
    		ClubCloud_Regio result = null;
    
    		using (new SPMonitoredScope("Districten GetRegioForDistrictById"))
    		{
    
    			try
    			{
    				entity = beheerModel.ClubCloud_Districten.Find(Id);
    				if(entity != null && entity.ClubCloud_Regio == null)
    					beheerModel.Entry(entity).Reference(e => e.ClubCloud_Regio).Load();
    
    				if(entity != null)
    					result = entity.ClubCloud_Regio;
    
    				if (result == null || refresh)
    					result = GetRegioForDistrictById(settings.Id.ToString(), Id, refresh, settings);
    
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
    
    		return new ClubCloud_Regio();
    	}
    
    	public bool SetRegioForDistrictById(ClubCloud_Regio Regio, System.Guid Id , bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		ClubCloud_District entity = null;
    		bool succes = false;
    
    		using (new SPMonitoredScope("Districten SetRegioForDistrictById"))
    		{
    
    			try
    			{		
    				entity = beheerModel.ClubCloud_Districten.Find(Id);	
    
    				if(entity != null && entity.ClubCloud_Regio == null)
    					beheerModel.Entry(entity).Reference(e => e.ClubCloud_Regio).Load();
    
    				if(entity != null)
    					entity.ClubCloud_Regio = Regio;
    
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
    
    
    	public List<ClubCloud_Accommodatie> GetAccommodatiesForDistrict(ClubCloud_District entity, bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		List<ClubCloud_Accommodatie> result = null;
    
    		using (new SPMonitoredScope("Districten GetAccommodatiesForDistrict"))
    		{
    
    			try
    			{
    				entity = beheerModel.ClubCloud_Districten.Find(entity.Id);
    				if(entity != null && entity.ClubCloud_Accommodatie != null && entity.ClubCloud_Accommodatie.Count == 0)
    					beheerModel.Entry(entity).Collection(e => e.ClubCloud_Accommodatie).Load();
    
    				if(entity != null)
    					result = entity.ClubCloud_Accommodatie.ToList();
    
    				if(result == null || result.Count == 0 || refresh && entity != null)
    					result = GetAccommodatiesForDistrict(settings.Id.ToString(), entity, refresh, settings);
    
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
    
    
    	public List<ClubCloud_Accommodatie> GetAccommodatiesForDistrictById(System.Guid Id, bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		ClubCloud_District entity = null;
    		List<ClubCloud_Accommodatie> result = null;
    
    		using (new SPMonitoredScope("Districten GetAccommodatiesForDistrictById"))
    		{
    
    			try
    			{
    				entity = beheerModel.ClubCloud_Districten.Find(Id);
    				if(entity != null && entity.ClubCloud_Accommodatie != null && entity.ClubCloud_Accommodatie.Count == 0)
    					beheerModel.Entry(entity).Collection(e => e.ClubCloud_Accommodatie).Load();
    
    				if(entity != null)
    					result = entity.ClubCloud_Accommodatie.ToList();
    
    				if(result == null || result.Count == 0 || refresh)
    					result = GetAccommodatiesForDistrictById(settings.Id.ToString(), Id, refresh, settings);
    
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
    
    	public bool SetAccommodatiesForDistrict(List<ClubCloud_Accommodatie> Accommodaties, ClubCloud_District entity, bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		bool succes = false;
    		ClubCloud_District result = null;
    
    		using (new SPMonitoredScope("Districten SetAccommodatiesForDistrict"))
    		{
    
    			try
    			{			
    				entity = beheerModel.ClubCloud_Districten.Find(entity.Id);
    		
    				if (entity != null)
    					beheerModel.Entry(entity).Collection(e => e.ClubCloud_Accommodatie).Load();
    					//result = GetDistrictById(settings.Id.ToString(), Id, refresh, settings);
    
    				if (result != null)
    					//return result.ClubCloud_Districten.Count == ;
    
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
    [KnownType(typeof(ClubCloud_District))]
    public partial class ClubCloud_District_View
    {
    	public ClubCloud_District_View()
    	{
    		this.ClubCloud_District = new HashSet<ClubCloud_District>();
    	}
    
    	[DataMember]
    	public int TotalRowCount { get; set; }
    
    	[DataMember]
    	public virtual ICollection<ClubCloud_District> ClubCloud_District { get; set; }
    
    }
    	
}

