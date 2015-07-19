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
    	public ClubCloud_BaanSpeciaal GetBaanSpeciaalById(System.Guid Id , bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		ClubCloud_BaanSpeciaal result = null;
    
    		using (new SPMonitoredScope("BanenSpeciaal GetBaanSpeciaalById"))
    		{
    
    			try
    			{			
    				result = beheerModel.ClubCloud_BanenSpeciaal.Find(Id);
    		
    				if (result == null || refresh)
    					result = GetBaanSpeciaalById(settings.Id.ToString(), Id, refresh, settings);
    
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
    
    		return new ClubCloud_BaanSpeciaal();
    	}
    
    	public List<ClubCloud_BaanSpeciaal> GetBanenSpeciaal(bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		List<ClubCloud_BaanSpeciaal> result = null;
    
    		using (new SPMonitoredScope("BanenSpeciaal GetBanenSpeciaal"))
    		{
    		
    			try
    			{
    				result = beheerModel.ClubCloud_BanenSpeciaal.ToList<ClubCloud_BaanSpeciaal>();
    		
    				if (result == null || result.Count == 0 || refresh)		
    					result = GetBanenSpeciaal(settings.Id.ToString(), refresh, settings);
    
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
    
    		return new List<ClubCloud_BaanSpeciaal>();
    	}
    
    	public ClubCloud_BaanSpeciaal SetBaanSpeciaal(ClubCloud_BaanSpeciaal entity, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		ClubCloud_BaanSpeciaal tobeupdated = null;
    		
    		using (new SPMonitoredScope("BanenSpeciaal SetBaanSpeciaal"))
    		{
    
    			try
    			{
    				entity = SetBaanSpeciaal(settings.Id.ToString(), entity, settings);
    
    				if(entity != null)
    					beheerModel.ClubCloud_BanenSpeciaal.AddOrUpdate(entity);
    		
    				beheerModel.SaveChanges();
    
    				tobeupdated = beheerModel.ClubCloud_BanenSpeciaal.Find(entity.Id);
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
    
    
    	public bool DeleteBaanSpeciaal(ClubCloud_BaanSpeciaal entity, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		return DeleteBaanSpeciaalById(entity.Id, settings);
    	}
    
    	public bool DeleteBaanSpeciaalById(System.Guid Id, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		bool succes = false;
    		ClubCloud_BaanSpeciaal tobedeleted = null;
    
    		using (new SPMonitoredScope("BanenSpeciaal DeleteBaanSpeciaalById"))
    		{
    
    			try
    			{
    
    				tobedeleted = beheerModel.ClubCloud_BanenSpeciaal.Find(Id);
    		
    				if (tobedeleted != null)
    				{
    					beheerModel.ClubCloud_BanenSpeciaal.Remove(tobedeleted);
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
    
    
    	public ClubCloud_BaanSpeciaal_View GetBanenSpeciaalByQuery(string bondsnummer, Guid verenigingId,System.Web.UI.DataSourceSelectArguments selectArgs = null, List<System.Web.UI.WebControls.Parameter> parameters = null, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		ClubCloud_BaanSpeciaal_View view = new ClubCloud_BaanSpeciaal_View();
    
    		using (new SPMonitoredScope("BanenSpeciaal GetBanenSpeciaalByQuery"))
    		{
    
    			StringBuilder querybuilder = new StringBuilder("SELECT * FROM dbo.ClubCloud_BaanSpeciaal");
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
    
    			view.ClubCloud_BaanSpeciaal = beheerModel.Database.SqlQuery<ClubCloud_BaanSpeciaal>(querybuilder.ToString(), sqlparams.ToArray()).Skip(selectArgs.StartRowIndex).Take(selectArgs.MaximumRows).ToList<ClubCloud_BaanSpeciaal>();
    
    			if (selectArgs.RetrieveTotalRowCount)
    			{
    
    				view.TotalRowCount = beheerModel.Database.SqlQuery<ClubCloud_BaanSpeciaal>(querybuilder.ToString(), sqlparamscount.ToArray()).Count();
    			}
    		}
    
    		return view;
    	}
    
    	public List<ClubCloud_BaanSpeciaal> GetBanenSpeciaalBySearch(string prefixText, int count, string contextKey, ClubCloud_Setting _settings = null)
    	{
    		if(_settings != null)
    			ValidateSettings(ref _settings);
    
            List<string> banenspeciaal = new List<string>();
    
    		using (new SPMonitoredScope("BanenSpeciaal GetBanenSpeciaalBySearch"))
    		{
    
    			try
    			{
    				bool enabled = false; //beheerModel.Database.SqlQuery<bool>("SELECT (CAST((FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))AS BIT))").FirstOrDefault();
    
    				List<ClubCloud_BaanSpeciaal> entities = null;
    
    				if (enabled)
    				{
    					var fts = BeheerFullTextInterceptor.Fts(prefixText);
    				
    		
    				entities = beheerModel.ClubCloud_BanenSpeciaal.Where(e => e.Naam.Contains(fts) ).ToList();
    
    					
    				}
    				else
    				{
    	
    				entities = beheerModel.Database.SqlQuery<ClubCloud_BaanSpeciaal>("SELECT * FROM ClubCloud_BaanSpeciaal WHERE  Naam LIKE '%"+ prefixText +"%'").ToList();
    
    					
    				}
    
    				if (entities != null && entities.Count > 0)
    					return entities;
    			}
    			catch (Exception ex)
    			{
    				Logger.WriteLog(Logger.Category.Unexpected, ex.Source, ex.Message);
    			}
    		}
    
            return new List<ClubCloud_BaanSpeciaal>();
    	}
    
    
    	public ClubCloud_Accommodatie GetAccommodatieForBaanSpeciaal(ClubCloud_BaanSpeciaal entity, bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		ClubCloud_Accommodatie result = null;
    
    		using (new SPMonitoredScope("BanenSpeciaal GetAccommodatieForBaanSpeciaal"))
    		{
    
    			try
    			{
    				entity = beheerModel.ClubCloud_BanenSpeciaal.Find(entity.Id);
    				if(entity != null && entity.ClubCloud_Accommodatie == null)
    					beheerModel.Entry(entity).Reference(e => e.ClubCloud_Accommodatie).Load();
    
    				if(entity != null)
    					result = entity.ClubCloud_Accommodatie;
    
    				if (result == null || refresh && entity != null)
    					result = GetAccommodatieForBaanSpeciaal(settings.Id.ToString(), entity, refresh, settings);
    
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
    
    		return new ClubCloud_Accommodatie();
    	}
    
    	public bool SetAccommodatieForBaanSpeciaal(ClubCloud_Accommodatie Accommodatie, ClubCloud_BaanSpeciaal entity , bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		bool succes = false;
    
    		using (new SPMonitoredScope("BanenSpeciaal SetAccommodatieForBaanSpeciaal"))
    		{
    
    			try
    			{		
    				entity = beheerModel.ClubCloud_BanenSpeciaal.Find(entity.Id);	
    
    				if(entity != null && entity.ClubCloud_Accommodatie == null)
    					beheerModel.Entry(entity).Reference(e => e.ClubCloud_Accommodatie).Load();
    
    				if(entity != null)
    					entity.ClubCloud_Accommodatie = Accommodatie;
    
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
    
    
    	public ClubCloud_Accommodatie GetAccommodatieForBaanSpeciaalById(System.Guid Id, bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		ClubCloud_BaanSpeciaal entity = null;
    		ClubCloud_Accommodatie result = null;
    
    		using (new SPMonitoredScope("BanenSpeciaal GetAccommodatieForBaanSpeciaalById"))
    		{
    
    			try
    			{
    				entity = beheerModel.ClubCloud_BanenSpeciaal.Find(Id);
    				if(entity != null && entity.ClubCloud_Accommodatie == null)
    					beheerModel.Entry(entity).Reference(e => e.ClubCloud_Accommodatie).Load();
    
    				if(entity != null)
    					result = entity.ClubCloud_Accommodatie;
    
    				if (result == null || refresh)
    					result = GetAccommodatieForBaanSpeciaalById(settings.Id.ToString(), Id, refresh, settings);
    
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
    
    		return new ClubCloud_Accommodatie();
    	}
    
    	public bool SetAccommodatieForBaanSpeciaalById(ClubCloud_Accommodatie Accommodatie, System.Guid Id , bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		ClubCloud_BaanSpeciaal entity = null;
    		bool succes = false;
    
    		using (new SPMonitoredScope("BanenSpeciaal SetAccommodatieForBaanSpeciaalById"))
    		{
    
    			try
    			{		
    				entity = beheerModel.ClubCloud_BanenSpeciaal.Find(Id);	
    
    				if(entity != null && entity.ClubCloud_Accommodatie == null)
    					beheerModel.Entry(entity).Reference(e => e.ClubCloud_Accommodatie).Load();
    
    				if(entity != null)
    					entity.ClubCloud_Accommodatie = Accommodatie;
    
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
    
    
    	public ClubCloud_Baantoplaag GetBaantoplaagForBaanSpeciaal(ClubCloud_BaanSpeciaal entity, bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		ClubCloud_Baantoplaag result = null;
    
    		using (new SPMonitoredScope("BanenSpeciaal GetBaantoplaagForBaanSpeciaal"))
    		{
    
    			try
    			{
    				entity = beheerModel.ClubCloud_BanenSpeciaal.Find(entity.Id);
    				if(entity != null && entity.ClubCloud_Baantoplaag == null)
    					beheerModel.Entry(entity).Reference(e => e.ClubCloud_Baantoplaag).Load();
    
    				if(entity != null)
    					result = entity.ClubCloud_Baantoplaag;
    
    				if (result == null || refresh && entity != null)
    					result = GetBaantoplaagForBaanSpeciaal(settings.Id.ToString(), entity, refresh, settings);
    
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
    
    		return new ClubCloud_Baantoplaag();
    	}
    
    	public bool SetBaantoplaagForBaanSpeciaal(ClubCloud_Baantoplaag Baantoplaag, ClubCloud_BaanSpeciaal entity , bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		bool succes = false;
    
    		using (new SPMonitoredScope("BanenSpeciaal SetBaantoplaagForBaanSpeciaal"))
    		{
    
    			try
    			{		
    				entity = beheerModel.ClubCloud_BanenSpeciaal.Find(entity.Id);	
    
    				if(entity != null && entity.ClubCloud_Baantoplaag == null)
    					beheerModel.Entry(entity).Reference(e => e.ClubCloud_Baantoplaag).Load();
    
    				if(entity != null)
    					entity.ClubCloud_Baantoplaag = Baantoplaag;
    
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
    
    
    	public ClubCloud_Baantoplaag GetBaantoplaagForBaanSpeciaalById(System.Guid Id, bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		ClubCloud_BaanSpeciaal entity = null;
    		ClubCloud_Baantoplaag result = null;
    
    		using (new SPMonitoredScope("BanenSpeciaal GetBaantoplaagForBaanSpeciaalById"))
    		{
    
    			try
    			{
    				entity = beheerModel.ClubCloud_BanenSpeciaal.Find(Id);
    				if(entity != null && entity.ClubCloud_Baantoplaag == null)
    					beheerModel.Entry(entity).Reference(e => e.ClubCloud_Baantoplaag).Load();
    
    				if(entity != null)
    					result = entity.ClubCloud_Baantoplaag;
    
    				if (result == null || refresh)
    					result = GetBaantoplaagForBaanSpeciaalById(settings.Id.ToString(), Id, refresh, settings);
    
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
    
    		return new ClubCloud_Baantoplaag();
    	}
    
    	public bool SetBaantoplaagForBaanSpeciaalById(ClubCloud_Baantoplaag Baantoplaag, System.Guid Id , bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		ClubCloud_BaanSpeciaal entity = null;
    		bool succes = false;
    
    		using (new SPMonitoredScope("BanenSpeciaal SetBaantoplaagForBaanSpeciaalById"))
    		{
    
    			try
    			{		
    				entity = beheerModel.ClubCloud_BanenSpeciaal.Find(Id);	
    
    				if(entity != null && entity.ClubCloud_Baantoplaag == null)
    					beheerModel.Entry(entity).Reference(e => e.ClubCloud_Baantoplaag).Load();
    
    				if(entity != null)
    					entity.ClubCloud_Baantoplaag = Baantoplaag;
    
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
    [KnownType(typeof(ClubCloud_BaanSpeciaal))]
    public partial class ClubCloud_BaanSpeciaal_View
    {
    	public ClubCloud_BaanSpeciaal_View()
    	{
    		this.ClubCloud_BaanSpeciaal = new HashSet<ClubCloud_BaanSpeciaal>();
    	}
    
    	[DataMember]
    	public int TotalRowCount { get; set; }
    
    	[DataMember]
    	public virtual ICollection<ClubCloud_BaanSpeciaal> ClubCloud_BaanSpeciaal { get; set; }
    
    }
    	
}

