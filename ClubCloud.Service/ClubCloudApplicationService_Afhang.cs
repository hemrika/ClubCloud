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
    	public ClubCloud_Afhang GetAfhangById(System.Guid Id , bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		ClubCloud_Afhang result = null;
    
    		using (new SPMonitoredScope("Afhangen GetAfhangById"))
    		{
    
    			try
    			{			
    				result = beheerModel.ClubCloud_Afhangen.Find(Id);
    		
    				if (result == null || refresh)
    					result = GetAfhangById(settings.Id.ToString(), Id, refresh, settings);
    
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
    
    		return new ClubCloud_Afhang();
    	}
    
    	public List<ClubCloud_Afhang> GetAfhangen(bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		List<ClubCloud_Afhang> result = null;
    
    		using (new SPMonitoredScope("Afhangen GetAfhangen"))
    		{
    		
    			try
    			{
    				result = beheerModel.ClubCloud_Afhangen.ToList<ClubCloud_Afhang>();
    		
    				if (result == null || result.Count == 0 || refresh)		
    					result = GetAfhangen(settings.Id.ToString(), refresh, settings);
    
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
    
    		return new List<ClubCloud_Afhang>();
    	}
    
    	public ClubCloud_Afhang SetAfhang(ClubCloud_Afhang entity, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		ClubCloud_Afhang tobeupdated = null;
    		
    		using (new SPMonitoredScope("Afhangen SetAfhang"))
    		{
    
    			try
    			{
    				entity = SetAfhang(settings.Id.ToString(), entity, settings);
    
    				if(entity != null)
    					beheerModel.ClubCloud_Afhangen.AddOrUpdate(entity);
    		
    				beheerModel.SaveChanges();
    
    				tobeupdated = beheerModel.ClubCloud_Afhangen.Find(entity.Id);
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
    
    
    	public bool DeleteAfhang(ClubCloud_Afhang entity, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		return DeleteAfhangById(entity.Id, settings);
    	}
    
    	public bool DeleteAfhangById(System.Guid Id, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		bool succes = false;
    		ClubCloud_Afhang tobedeleted = null;
    
    		using (new SPMonitoredScope("Afhangen DeleteAfhangById"))
    		{
    
    			try
    			{
    
    				tobedeleted = beheerModel.ClubCloud_Afhangen.Find(Id);
    		
    				if (tobedeleted != null)
    				{
    					beheerModel.ClubCloud_Afhangen.Remove(tobedeleted);
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
    
    
    	public ClubCloud_Afhang_View GetAfhangenByQuery(string bondsnummer, Guid verenigingId,System.Web.UI.DataSourceSelectArguments selectArgs = null, List<System.Web.UI.WebControls.Parameter> parameters = null, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		ClubCloud_Afhang_View view = new ClubCloud_Afhang_View();
    
    		using (new SPMonitoredScope("Afhangen GetAfhangenByQuery"))
    		{
    
    			StringBuilder querybuilder = new StringBuilder("SELECT * FROM dbo.ClubCloud_Afhang");
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
    
    			view.ClubCloud_Afhang = beheerModel.Database.SqlQuery<ClubCloud_Afhang>(querybuilder.ToString(), sqlparams.ToArray()).Skip(selectArgs.StartRowIndex).Take(selectArgs.MaximumRows).ToList<ClubCloud_Afhang>();
    
    			if (selectArgs.RetrieveTotalRowCount)
    			{
    
    				view.TotalRowCount = beheerModel.Database.SqlQuery<ClubCloud_Afhang>(querybuilder.ToString(), sqlparamscount.ToArray()).Count();
    			}
    		}
    
    		return view;
    	}
    
    	public List<ClubCloud_Afhang> GetAfhangenBySearch(string prefixText, int count, string contextKey, ClubCloud_Setting _settings = null)
    	{
    		if(_settings != null)
    			ValidateSettings(ref _settings);
    
            List<string> afhangen = new List<string>();
    
    		using (new SPMonitoredScope("Afhangen GetAfhangenBySearch"))
    		{
    
    			try
    			{
    				bool enabled = false; //beheerModel.Database.SqlQuery<bool>("SELECT (CAST((FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))AS BIT))").FirstOrDefault();
    
    				List<ClubCloud_Afhang> entities = null;
    
    				if (enabled)
    				{
    					var fts = BeheerFullTextInterceptor.Fts(prefixText);
    				
    						
    				}
    				else
    				{
    					
    				}
    
    				if (entities != null && entities.Count > 0)
    					return entities;
    			}
    			catch (Exception ex)
    			{
    				Logger.WriteLog(Logger.Category.Unexpected, ex.Source, ex.Message);
    			}
    		}
    
            return new List<ClubCloud_Afhang>();
    	}
    
    
    	public ClubCloud_Vereniging GetVerenigingForAfhang(ClubCloud_Afhang entity, bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		ClubCloud_Vereniging result = null;
    
    		using (new SPMonitoredScope("Afhangen GetVerenigingForAfhang"))
    		{
    
    			try
    			{
    				entity = beheerModel.ClubCloud_Afhangen.Find(entity.Id);
    				if(entity != null && entity.ClubCloud_Vereniging == null)
    					beheerModel.Entry(entity).Reference(e => e.ClubCloud_Vereniging).Load();
    
    				if(entity != null)
    					result = entity.ClubCloud_Vereniging;
    
    				if (result == null || refresh && entity != null)
    					result = GetVerenigingForAfhang(settings.Id.ToString(), entity, refresh, settings);
    
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
    
    	public bool SetVerenigingForAfhang(ClubCloud_Vereniging Vereniging, ClubCloud_Afhang entity , bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		bool succes = false;
    
    		using (new SPMonitoredScope("Afhangen SetVerenigingForAfhang"))
    		{
    
    			try
    			{		
    				entity = beheerModel.ClubCloud_Afhangen.Find(entity.Id);	
    
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
    
    
    	public ClubCloud_Vereniging GetVerenigingForAfhangById(System.Guid Id, bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		ClubCloud_Afhang entity = null;
    		ClubCloud_Vereniging result = null;
    
    		using (new SPMonitoredScope("Afhangen GetVerenigingForAfhangById"))
    		{
    
    			try
    			{
    				entity = beheerModel.ClubCloud_Afhangen.Find(Id);
    				if(entity != null && entity.ClubCloud_Vereniging == null)
    					beheerModel.Entry(entity).Reference(e => e.ClubCloud_Vereniging).Load();
    
    				if(entity != null)
    					result = entity.ClubCloud_Vereniging;
    
    				if (result == null || refresh)
    					result = GetVerenigingForAfhangById(settings.Id.ToString(), Id, refresh, settings);
    
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
    
    	public bool SetVerenigingForAfhangById(ClubCloud_Vereniging Vereniging, System.Guid Id , bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		ClubCloud_Afhang entity = null;
    		bool succes = false;
    
    		using (new SPMonitoredScope("Afhangen SetVerenigingForAfhangById"))
    		{
    
    			try
    			{		
    				entity = beheerModel.ClubCloud_Afhangen.Find(Id);	
    
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
    [KnownType(typeof(ClubCloud_Afhang))]
    public partial class ClubCloud_Afhang_View
    {
    	public ClubCloud_Afhang_View()
    	{
    		this.ClubCloud_Afhang = new HashSet<ClubCloud_Afhang>();
    	}
    
    	[DataMember]
    	public int TotalRowCount { get; set; }
    
    	[DataMember]
    	public virtual ICollection<ClubCloud_Afhang> ClubCloud_Afhang { get; set; }
    
    }
    	
}

