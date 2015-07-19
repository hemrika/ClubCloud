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
    	public ClubCloud_Baantoplaag GetBaantoplaagById(System.Guid Id , bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		ClubCloud_Baantoplaag result = null;
    
    		using (new SPMonitoredScope("Baantoplagen GetBaantoplaagById"))
    		{
    
    			try
    			{			
    				result = beheerModel.ClubCloud_Baantoplagen.Find(Id);
    		
    				if (result == null || refresh)
    					result = GetBaantoplaagById(settings.Id.ToString(), Id, refresh, settings);
    
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
    
    		return new ClubCloud_Baantoplaag();
    	}
    
    	public List<ClubCloud_Baantoplaag> GetBaantoplagen(bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		List<ClubCloud_Baantoplaag> result = null;
    
    		using (new SPMonitoredScope("Baantoplagen GetBaantoplagen"))
    		{
    		
    			try
    			{
    				result = beheerModel.ClubCloud_Baantoplagen.ToList<ClubCloud_Baantoplaag>();
    		
    				if (result == null || result.Count == 0 || refresh)		
    					result = GetBaantoplagen(settings.Id.ToString(), refresh, settings);
    
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
    
    		return new List<ClubCloud_Baantoplaag>();
    	}
    
    	public ClubCloud_Baantoplaag SetBaantoplaag(ClubCloud_Baantoplaag entity, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		ClubCloud_Baantoplaag tobeupdated = null;
    		
    		using (new SPMonitoredScope("Baantoplagen SetBaantoplaag"))
    		{
    
    			try
    			{
    				entity = SetBaantoplaag(settings.Id.ToString(), entity, settings);
    
    				if(entity != null)
    					beheerModel.ClubCloud_Baantoplagen.AddOrUpdate(entity);
    		
    				beheerModel.SaveChanges();
    
    				tobeupdated = beheerModel.ClubCloud_Baantoplagen.Find(entity.Id);
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
    
    
    	public bool DeleteBaantoplaag(ClubCloud_Baantoplaag entity, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		return DeleteBaantoplaagById(entity.Id, settings);
    	}
    
    	public bool DeleteBaantoplaagById(System.Guid Id, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		bool succes = false;
    		ClubCloud_Baantoplaag tobedeleted = null;
    
    		using (new SPMonitoredScope("Baantoplagen DeleteBaantoplaagById"))
    		{
    
    			try
    			{
    
    				tobedeleted = beheerModel.ClubCloud_Baantoplagen.Find(Id);
    		
    				if (tobedeleted != null)
    				{
    					beheerModel.ClubCloud_Baantoplagen.Remove(tobedeleted);
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
    
    
    	public ClubCloud_Baantoplaag_View GetBaantoplagenByQuery(string bondsnummer, Guid verenigingId,System.Web.UI.DataSourceSelectArguments selectArgs = null, List<System.Web.UI.WebControls.Parameter> parameters = null, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		ClubCloud_Baantoplaag_View view = new ClubCloud_Baantoplaag_View();
    
    		using (new SPMonitoredScope("Baantoplagen GetBaantoplagenByQuery"))
    		{
    
    			StringBuilder querybuilder = new StringBuilder("SELECT * FROM dbo.ClubCloud_Baantoplaag");
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
    
    			view.ClubCloud_Baantoplaag = beheerModel.Database.SqlQuery<ClubCloud_Baantoplaag>(querybuilder.ToString(), sqlparams.ToArray()).Skip(selectArgs.StartRowIndex).Take(selectArgs.MaximumRows).ToList<ClubCloud_Baantoplaag>();
    
    			if (selectArgs.RetrieveTotalRowCount)
    			{
    
    				view.TotalRowCount = beheerModel.Database.SqlQuery<ClubCloud_Baantoplaag>(querybuilder.ToString(), sqlparamscount.ToArray()).Count();
    			}
    		}
    
    		return view;
    	}
    
    	public List<ClubCloud_Baantoplaag> GetBaantoplagenBySearch(string prefixText, int count, string contextKey, ClubCloud_Setting _settings = null)
    	{
    		if(_settings != null)
    			ValidateSettings(ref _settings);
    
            List<string> baantoplagen = new List<string>();
    
    		using (new SPMonitoredScope("Baantoplagen GetBaantoplagenBySearch"))
    		{
    
    			try
    			{
    				bool enabled = false; //beheerModel.Database.SqlQuery<bool>("SELECT (CAST((FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))AS BIT))").FirstOrDefault();
    
    				List<ClubCloud_Baantoplaag> entities = null;
    
    				if (enabled)
    				{
    					var fts = BeheerFullTextInterceptor.Fts(prefixText);
    				
    		
    				entities = beheerModel.ClubCloud_Baantoplagen.Where(e => e.Naam.Contains(fts)  || e.Beschrijving.Contains(fts)  || e.Meervoud.Contains(fts)  || e.Omschrijving.Contains(fts)  || e.Code.Contains(fts) ).ToList();
    
    					
    				}
    				else
    				{
    	
    				entities = beheerModel.Database.SqlQuery<ClubCloud_Baantoplaag>("SELECT * FROM ClubCloud_Baantoplaag WHERE  Naam LIKE '%"+ prefixText +"%' OR  Beschrijving LIKE '%"+ prefixText +"%' OR  Meervoud LIKE '%"+ prefixText +"%' OR  Omschrijving LIKE '%"+ prefixText +"%' OR  Code LIKE '%"+ prefixText +"%'").ToList();
    
    					
    				}
    
    				if (entities != null && entities.Count > 0)
    					return entities;
    			}
    			catch (Exception ex)
    			{
    				Logger.WriteLog(Logger.Category.Unexpected, ex.Source, ex.Message);
    			}
    		}
    
            return new List<ClubCloud_Baantoplaag>();
    	}
    
    
    	public List<ClubCloud_BaanSpeciaal> GetBanenSpeciaalForBaantoplaag(ClubCloud_Baantoplaag entity, bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		List<ClubCloud_BaanSpeciaal> result = null;
    
    		using (new SPMonitoredScope("Baantoplagen GetBanenSpeciaalForBaantoplaag"))
    		{
    
    			try
    			{
    				entity = beheerModel.ClubCloud_Baantoplagen.Find(entity.Id);
    				if(entity != null && entity.ClubCloud_BaanSpeciaal != null && entity.ClubCloud_BaanSpeciaal.Count == 0)
    					beheerModel.Entry(entity).Collection(e => e.ClubCloud_BaanSpeciaal).Load();
    
    				if(entity != null)
    					result = entity.ClubCloud_BaanSpeciaal.ToList();
    
    				if(result == null || result.Count == 0 || refresh && entity != null)
    					result = GetBanenSpeciaalForBaantoplaag(settings.Id.ToString(), entity, refresh, settings);
    
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
    
    		return new List<ClubCloud_BaanSpeciaal>();
    	}
    
    
    	public List<ClubCloud_BaanSpeciaal> GetBanenSpeciaalForBaantoplaagById(System.Guid Id, bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		ClubCloud_Baantoplaag entity = null;
    		List<ClubCloud_BaanSpeciaal> result = null;
    
    		using (new SPMonitoredScope("Baantoplagen GetBanenSpeciaalForBaantoplaagById"))
    		{
    
    			try
    			{
    				entity = beheerModel.ClubCloud_Baantoplagen.Find(Id);
    				if(entity != null && entity.ClubCloud_BaanSpeciaal != null && entity.ClubCloud_BaanSpeciaal.Count == 0)
    					beheerModel.Entry(entity).Collection(e => e.ClubCloud_BaanSpeciaal).Load();
    
    				if(entity != null)
    					result = entity.ClubCloud_BaanSpeciaal.ToList();
    
    				if(result == null || result.Count == 0 || refresh)
    					result = GetBanenSpeciaalForBaantoplaagById(settings.Id.ToString(), Id, refresh, settings);
    
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
    
    		return new List<ClubCloud_BaanSpeciaal>();	
    	}
    
    	public bool SetBanenSpeciaalForBaantoplaag(List<ClubCloud_BaanSpeciaal> BanenSpeciaal, ClubCloud_Baantoplaag entity, bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		bool succes = false;
    		ClubCloud_Baantoplaag result = null;
    
    		using (new SPMonitoredScope("Baantoplagen SetBanenSpeciaalForBaantoplaag"))
    		{
    
    			try
    			{			
    				entity = beheerModel.ClubCloud_Baantoplagen.Find(entity.Id);
    		
    				if (entity != null)
    					beheerModel.Entry(entity).Collection(e => e.ClubCloud_BaanSpeciaal).Load();
    					//result = GetBaantoplaagById(settings.Id.ToString(), Id, refresh, settings);
    
    				if (result != null)
    					//return result.ClubCloud_Baantoplagen.Count == ;
    
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
    [KnownType(typeof(ClubCloud_Baantoplaag))]
    public partial class ClubCloud_Baantoplaag_View
    {
    	public ClubCloud_Baantoplaag_View()
    	{
    		this.ClubCloud_Baantoplaag = new HashSet<ClubCloud_Baantoplaag>();
    	}
    
    	[DataMember]
    	public int TotalRowCount { get; set; }
    
    	[DataMember]
    	public virtual ICollection<ClubCloud_Baantoplaag> ClubCloud_Baantoplaag { get; set; }
    
    }
    	
}

