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
    	public ClubCloud_Rechtsvorm GetRechtsvormById(System.Guid Id , bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		ClubCloud_Rechtsvorm result = null;
    
    		using (new SPMonitoredScope("Rechtsvormen GetRechtsvormById"))
    		{
    
    			try
    			{			
    				result = beheerModel.ClubCloud_Rechtsvormen.Find(Id);
    		
    				if (result == null || refresh)
    					result = GetRechtsvormById(settings.Id.ToString(), Id, refresh, settings);
    
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
    
    		return new ClubCloud_Rechtsvorm();
    	}
    
    	public List<ClubCloud_Rechtsvorm> GetRechtsvormen(bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		List<ClubCloud_Rechtsvorm> result = null;
    
    		using (new SPMonitoredScope("Rechtsvormen GetRechtsvormen"))
    		{
    		
    			try
    			{
    				result = beheerModel.ClubCloud_Rechtsvormen.ToList<ClubCloud_Rechtsvorm>();
    		
    				if (result == null || result.Count == 0 || refresh)		
    					result = GetRechtsvormen(settings.Id.ToString(), refresh, settings);
    
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
    
    		return new List<ClubCloud_Rechtsvorm>();
    	}
    
    	public ClubCloud_Rechtsvorm SetRechtsvorm(ClubCloud_Rechtsvorm entity, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		ClubCloud_Rechtsvorm tobeupdated = null;
    		
    		using (new SPMonitoredScope("Rechtsvormen SetRechtsvorm"))
    		{
    
    			try
    			{
    				entity = SetRechtsvorm(settings.Id.ToString(), entity, settings);
    
    				if(entity != null)
    					beheerModel.ClubCloud_Rechtsvormen.AddOrUpdate(entity);
    		
    				beheerModel.SaveChanges();
    
    				tobeupdated = beheerModel.ClubCloud_Rechtsvormen.Find(entity.Id);
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
    
    
    	public bool DeleteRechtsvorm(ClubCloud_Rechtsvorm entity, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		return DeleteRechtsvormById(entity.Id, settings);
    	}
    
    	public bool DeleteRechtsvormById(System.Guid Id, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		bool succes = false;
    		ClubCloud_Rechtsvorm tobedeleted = null;
    
    		using (new SPMonitoredScope("Rechtsvormen DeleteRechtsvormById"))
    		{
    
    			try
    			{
    
    				tobedeleted = beheerModel.ClubCloud_Rechtsvormen.Find(Id);
    		
    				if (tobedeleted != null)
    				{
    					beheerModel.ClubCloud_Rechtsvormen.Remove(tobedeleted);
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
    
    
    	public ClubCloud_Rechtsvorm_View GetRechtsvormenByQuery(string bondsnummer, Guid verenigingId,System.Web.UI.DataSourceSelectArguments selectArgs = null, List<System.Web.UI.WebControls.Parameter> parameters = null, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		ClubCloud_Rechtsvorm_View view = new ClubCloud_Rechtsvorm_View();
    
    		using (new SPMonitoredScope("Rechtsvormen GetRechtsvormenByQuery"))
    		{
    
    			StringBuilder querybuilder = new StringBuilder("SELECT * FROM dbo.ClubCloud_Rechtsvorm");
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
    
    			view.ClubCloud_Rechtsvorm = beheerModel.Database.SqlQuery<ClubCloud_Rechtsvorm>(querybuilder.ToString(), sqlparams.ToArray()).Skip(selectArgs.StartRowIndex).Take(selectArgs.MaximumRows).ToList<ClubCloud_Rechtsvorm>();
    
    			if (selectArgs.RetrieveTotalRowCount)
    			{
    
    				view.TotalRowCount = beheerModel.Database.SqlQuery<ClubCloud_Rechtsvorm>(querybuilder.ToString(), sqlparamscount.ToArray()).Count();
    			}
    		}
    
    		return view;
    	}
    
    	public List<ClubCloud_Rechtsvorm> GetRechtsvormenBySearch(string prefixText, int count, string contextKey, ClubCloud_Setting _settings = null)
    	{
    		if(_settings != null)
    			ValidateSettings(ref _settings);
    
            List<string> rechtsvormen = new List<string>();
    
    		using (new SPMonitoredScope("Rechtsvormen GetRechtsvormenBySearch"))
    		{
    
    			try
    			{
    				bool enabled = false; //beheerModel.Database.SqlQuery<bool>("SELECT (CAST((FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))AS BIT))").FirstOrDefault();
    
    				List<ClubCloud_Rechtsvorm> entities = null;
    
    				if (enabled)
    				{
    					var fts = BeheerFullTextInterceptor.Fts(prefixText);
    				
    		
    				entities = beheerModel.ClubCloud_Rechtsvormen.Where(e => e.Naam.Contains(fts)  || e.Omschrijving.Contains(fts)  || e.Code.Contains(fts)  || e.Beschrijving.Contains(fts)  || e.Meervoud.Contains(fts) ).ToList();
    
    					
    				}
    				else
    				{
    	
    				entities = beheerModel.Database.SqlQuery<ClubCloud_Rechtsvorm>("SELECT * FROM ClubCloud_Rechtsvorm WHERE  Naam LIKE '%"+ prefixText +"%' OR  Omschrijving LIKE '%"+ prefixText +"%' OR  Code LIKE '%"+ prefixText +"%' OR  Beschrijving LIKE '%"+ prefixText +"%' OR  Meervoud LIKE '%"+ prefixText +"%'").ToList();
    
    					
    				}
    
    				if (entities != null && entities.Count > 0)
    					return entities;
    			}
    			catch (Exception ex)
    			{
    				Logger.WriteLog(Logger.Category.Unexpected, ex.Source, ex.Message);
    			}
    		}
    
            return new List<ClubCloud_Rechtsvorm>();
    	}
    
    
    	public List<ClubCloud_Vereniging> GetVerenigingenForRechtsvorm(ClubCloud_Rechtsvorm entity, bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		List<ClubCloud_Vereniging> result = null;
    
    		using (new SPMonitoredScope("Rechtsvormen GetVerenigingenForRechtsvorm"))
    		{
    
    			try
    			{
    				entity = beheerModel.ClubCloud_Rechtsvormen.Find(entity.Id);
    				if(entity != null && entity.ClubCloud_Vereniging != null && entity.ClubCloud_Vereniging.Count == 0)
    					beheerModel.Entry(entity).Collection(e => e.ClubCloud_Vereniging).Load();
    
    				if(entity != null)
    					result = entity.ClubCloud_Vereniging.ToList();
    
    				if(result == null || result.Count == 0 || refresh && entity != null)
    					result = GetVerenigingenForRechtsvorm(settings.Id.ToString(), entity, refresh, settings);
    
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
    
    
    	public List<ClubCloud_Vereniging> GetVerenigingenForRechtsvormById(System.Guid Id, bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		ClubCloud_Rechtsvorm entity = null;
    		List<ClubCloud_Vereniging> result = null;
    
    		using (new SPMonitoredScope("Rechtsvormen GetVerenigingenForRechtsvormById"))
    		{
    
    			try
    			{
    				entity = beheerModel.ClubCloud_Rechtsvormen.Find(Id);
    				if(entity != null && entity.ClubCloud_Vereniging != null && entity.ClubCloud_Vereniging.Count == 0)
    					beheerModel.Entry(entity).Collection(e => e.ClubCloud_Vereniging).Load();
    
    				if(entity != null)
    					result = entity.ClubCloud_Vereniging.ToList();
    
    				if(result == null || result.Count == 0 || refresh)
    					result = GetVerenigingenForRechtsvormById(settings.Id.ToString(), Id, refresh, settings);
    
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
    
    	public bool SetVerenigingenForRechtsvorm(List<ClubCloud_Vereniging> Verenigingen, ClubCloud_Rechtsvorm entity, bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		bool succes = false;
    		ClubCloud_Rechtsvorm result = null;
    
    		using (new SPMonitoredScope("Rechtsvormen SetVerenigingenForRechtsvorm"))
    		{
    
    			try
    			{			
    				entity = beheerModel.ClubCloud_Rechtsvormen.Find(entity.Id);
    		
    				if (entity != null)
    					beheerModel.Entry(entity).Collection(e => e.ClubCloud_Vereniging).Load();
    					//result = GetRechtsvormById(settings.Id.ToString(), Id, refresh, settings);
    
    				if (result != null)
    					//return result.ClubCloud_Rechtsvormen.Count == ;
    
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
    [KnownType(typeof(ClubCloud_Rechtsvorm))]
    public partial class ClubCloud_Rechtsvorm_View
    {
    	public ClubCloud_Rechtsvorm_View()
    	{
    		this.ClubCloud_Rechtsvorm = new HashSet<ClubCloud_Rechtsvorm>();
    	}
    
    	[DataMember]
    	public int TotalRowCount { get; set; }
    
    	[DataMember]
    	public virtual ICollection<ClubCloud_Rechtsvorm> ClubCloud_Rechtsvorm { get; set; }
    
    }
    	
}

