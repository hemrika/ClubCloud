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
    	public ClubCloud_Setting GetSettingById(int Id , bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		ClubCloud_Setting result = null;
    
    		using (new SPMonitoredScope("Settings GetSettingById"))
    		{
    
    			try
    			{			
    				result = beheerModel.ClubCloud_Settings.Find(Id);
    		
    				if (result == null || refresh)
    					result = GetSettingById(settings.Id.ToString(), Id, refresh, settings);
    
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
    
    		return new ClubCloud_Setting();
    	}
    
    	public List<ClubCloud_Setting> GetSettings(bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		List<ClubCloud_Setting> result = null;
    
    		using (new SPMonitoredScope("Settings GetSettings"))
    		{
    		
    			try
    			{
    				result = beheerModel.ClubCloud_Settings.ToList<ClubCloud_Setting>();
    		
    				if (result == null || result.Count == 0 || refresh)		
    					result = GetSettings(settings.Id.ToString(), refresh, settings);
    
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
    
    		return new List<ClubCloud_Setting>();
    	}
    
    	public ClubCloud_Setting SetSetting(ClubCloud_Setting entity, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		ClubCloud_Setting tobeupdated = null;
    		
    		using (new SPMonitoredScope("Settings SetSetting"))
    		{
    
    			try
    			{
    				entity = SetSetting(settings.Id.ToString(), entity, settings);
    
    				if(entity != null)
    					beheerModel.ClubCloud_Settings.AddOrUpdate(entity);
    		
    				beheerModel.SaveChanges();
    
    				tobeupdated = beheerModel.ClubCloud_Settings.Find(entity.Id);
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
    
    
    	public bool DeleteSetting(ClubCloud_Setting entity, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		return DeleteSettingById(entity.Id, settings);
    	}
    
    	public bool DeleteSettingById(int Id, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		bool succes = false;
    		ClubCloud_Setting tobedeleted = null;
    
    		using (new SPMonitoredScope("Settings DeleteSettingById"))
    		{
    
    			try
    			{
    
    				tobedeleted = beheerModel.ClubCloud_Settings.Find(Id);
    		
    				if (tobedeleted != null)
    				{
    					beheerModel.ClubCloud_Settings.Remove(tobedeleted);
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
    
    
    	public ClubCloud_Setting_View GetSettingsByQuery(string bondsnummer, Guid verenigingId,System.Web.UI.DataSourceSelectArguments selectArgs = null, List<System.Web.UI.WebControls.Parameter> parameters = null, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		ClubCloud_Setting_View view = new ClubCloud_Setting_View();
    
    		using (new SPMonitoredScope("Settings GetSettingsByQuery"))
    		{
    
    			StringBuilder querybuilder = new StringBuilder("SELECT * FROM dbo.ClubCloud_Setting");
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
    
    			view.ClubCloud_Setting = beheerModel.Database.SqlQuery<ClubCloud_Setting>(querybuilder.ToString(), sqlparams.ToArray()).Skip(selectArgs.StartRowIndex).Take(selectArgs.MaximumRows).ToList<ClubCloud_Setting>();
    
    			if (selectArgs.RetrieveTotalRowCount)
    			{
    
    				view.TotalRowCount = beheerModel.Database.SqlQuery<ClubCloud_Setting>(querybuilder.ToString(), sqlparamscount.ToArray()).Count();
    			}
    		}
    
    		return view;
    	}
    
    	public List<ClubCloud_Setting> GetSettingsBySearch(string prefixText, int count, string contextKey, ClubCloud_Setting _settings = null)
    	{
    		if(_settings != null)
    			ValidateSettings(ref _settings);
    
            List<string> settings = new List<string>();
    
    		using (new SPMonitoredScope("Settings GetSettingsBySearch"))
    		{
    
    			try
    			{
    				bool enabled = false; //beheerModel.Database.SqlQuery<bool>("SELECT (CAST((FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))AS BIT))").FirstOrDefault();
    
    				List<ClubCloud_Setting> entities = null;
    
    				if (enabled)
    				{
    					var fts = BeheerFullTextInterceptor.Fts(prefixText);
    				
    		
    				entities = beheerModel.ClubCloud_Settings.Where(e => e.Password.Contains(fts)  || e.twitter_oauth_token.Contains(fts)  || e.twitter_oauth_token_secret.Contains(fts)  || e.facebook_access_token.Contains(fts) ).ToList();
    
    					
    				}
    				else
    				{
    	
    				entities = beheerModel.Database.SqlQuery<ClubCloud_Setting>("SELECT * FROM ClubCloud_Setting WHERE  Password LIKE '%"+ prefixText +"%' OR  twitter_oauth_token LIKE '%"+ prefixText +"%' OR  twitter_oauth_token_secret LIKE '%"+ prefixText +"%' OR  facebook_access_token LIKE '%"+ prefixText +"%'").ToList();
    
    					
    				}
    
    				if (entities != null && entities.Count > 0)
    					return entities;
    			}
    			catch (Exception ex)
    			{
    				Logger.WriteLog(Logger.Category.Unexpected, ex.Source, ex.Message);
    			}
    		}
    
            return new List<ClubCloud_Setting>();
    	}
    
    
    	public ClubCloud_Gebruiker GetGebruikerForSetting(ClubCloud_Setting entity, bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		ClubCloud_Gebruiker result = null;
    
    		using (new SPMonitoredScope("Settings GetGebruikerForSetting"))
    		{
    
    			try
    			{
    				entity = beheerModel.ClubCloud_Settings.Find(entity.Id);
    				if(entity != null && entity.ClubCloud_Gebruiker == null)
    					beheerModel.Entry(entity).Reference(e => e.ClubCloud_Gebruiker).Load();
    
    				if(entity != null)
    					result = entity.ClubCloud_Gebruiker;
    
    				if (result == null || refresh && entity != null)
    					result = GetGebruikerForSetting(settings.Id.ToString(), entity, refresh, settings);
    
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
    
    		return new ClubCloud_Gebruiker();
    	}
    
    	public bool SetGebruikerForSetting(ClubCloud_Gebruiker Gebruiker, ClubCloud_Setting entity , bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		bool succes = false;
    
    		using (new SPMonitoredScope("Settings SetGebruikerForSetting"))
    		{
    
    			try
    			{		
    				entity = beheerModel.ClubCloud_Settings.Find(entity.Id);	
    
    				if(entity != null && entity.ClubCloud_Gebruiker == null)
    					beheerModel.Entry(entity).Reference(e => e.ClubCloud_Gebruiker).Load();
    
    				if(entity != null)
    					entity.ClubCloud_Gebruiker = Gebruiker;
    
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
    
    
    	public ClubCloud_Gebruiker GetGebruikerForSettingById(int Id, bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		ClubCloud_Setting entity = null;
    		ClubCloud_Gebruiker result = null;
    
    		using (new SPMonitoredScope("Settings GetGebruikerForSettingById"))
    		{
    
    			try
    			{
    				entity = beheerModel.ClubCloud_Settings.Find(Id);
    				if(entity != null && entity.ClubCloud_Gebruiker == null)
    					beheerModel.Entry(entity).Reference(e => e.ClubCloud_Gebruiker).Load();
    
    				if(entity != null)
    					result = entity.ClubCloud_Gebruiker;
    
    				if (result == null || refresh)
    					result = GetGebruikerForSettingById(settings.Id.ToString(), Id, refresh, settings);
    
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
    
    		return new ClubCloud_Gebruiker();
    	}
    
    	public bool SetGebruikerForSettingById(ClubCloud_Gebruiker Gebruiker, int Id , bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		ClubCloud_Setting entity = null;
    		bool succes = false;
    
    		using (new SPMonitoredScope("Settings SetGebruikerForSettingById"))
    		{
    
    			try
    			{		
    				entity = beheerModel.ClubCloud_Settings.Find(Id);	
    
    				if(entity != null && entity.ClubCloud_Gebruiker == null)
    					beheerModel.Entry(entity).Reference(e => e.ClubCloud_Gebruiker).Load();
    
    				if(entity != null)
    					entity.ClubCloud_Gebruiker = Gebruiker;
    
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
    
    
    	public ClubCloud_Vereniging GetVerenigingForSetting(ClubCloud_Setting entity, bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		ClubCloud_Vereniging result = null;
    
    		using (new SPMonitoredScope("Settings GetVerenigingForSetting"))
    		{
    
    			try
    			{
    				entity = beheerModel.ClubCloud_Settings.Find(entity.Id);
    				if(entity != null && entity.ClubCloud_Vereniging == null)
    					beheerModel.Entry(entity).Reference(e => e.ClubCloud_Vereniging).Load();
    
    				if(entity != null)
    					result = entity.ClubCloud_Vereniging;
    
    				if (result == null || refresh && entity != null)
    					result = GetVerenigingForSetting(settings.Id.ToString(), entity, refresh, settings);
    
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
    
    		return new ClubCloud_Vereniging();
    	}
    
    	public bool SetVerenigingForSetting(ClubCloud_Vereniging Vereniging, ClubCloud_Setting entity , bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		bool succes = false;
    
    		using (new SPMonitoredScope("Settings SetVerenigingForSetting"))
    		{
    
    			try
    			{		
    				entity = beheerModel.ClubCloud_Settings.Find(entity.Id);	
    
    				if(entity != null && entity.ClubCloud_Vereniging == null)
    					beheerModel.Entry(entity).Reference(e => e.ClubCloud_Vereniging).Load();
    
    				if(entity != null)
    					entity.ClubCloud_Vereniging = Vereniging;
    
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
    
    
    	public ClubCloud_Vereniging GetVerenigingForSettingById(int Id, bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		ClubCloud_Setting entity = null;
    		ClubCloud_Vereniging result = null;
    
    		using (new SPMonitoredScope("Settings GetVerenigingForSettingById"))
    		{
    
    			try
    			{
    				entity = beheerModel.ClubCloud_Settings.Find(Id);
    				if(entity != null && entity.ClubCloud_Vereniging == null)
    					beheerModel.Entry(entity).Reference(e => e.ClubCloud_Vereniging).Load();
    
    				if(entity != null)
    					result = entity.ClubCloud_Vereniging;
    
    				if (result == null || refresh)
    					result = GetVerenigingForSettingById(settings.Id.ToString(), Id, refresh, settings);
    
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
    
    		return new ClubCloud_Vereniging();
    	}
    
    	public bool SetVerenigingForSettingById(ClubCloud_Vereniging Vereniging, int Id , bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		ClubCloud_Setting entity = null;
    		bool succes = false;
    
    		using (new SPMonitoredScope("Settings SetVerenigingForSettingById"))
    		{
    
    			try
    			{		
    				entity = beheerModel.ClubCloud_Settings.Find(Id);	
    
    				if(entity != null && entity.ClubCloud_Vereniging == null)
    					beheerModel.Entry(entity).Reference(e => e.ClubCloud_Vereniging).Load();
    
    				if(entity != null)
    					entity.ClubCloud_Vereniging = Vereniging;
    
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
    
    }
    
    [Serializable]
    [DataContract(IsReference = true)]
    [KnownType(typeof(ClubCloud_Setting))]
    public partial class ClubCloud_Setting_View
    {
    	public ClubCloud_Setting_View()
    	{
    		this.ClubCloud_Setting = new HashSet<ClubCloud_Setting>();
    	}
    
    	[DataMember]
    	public int TotalRowCount { get; set; }
    
    	[DataMember]
    	public virtual ICollection<ClubCloud_Setting> ClubCloud_Setting { get; set; }
    
    }
    	
}

