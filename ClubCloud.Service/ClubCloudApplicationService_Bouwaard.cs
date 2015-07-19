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
    	public ClubCloud_Bouwaard GetBouwaardById(System.Guid Id , bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		ClubCloud_Bouwaard result = null;
    
    		using (new SPMonitoredScope("Bouwaarden GetBouwaardById"))
    		{
    
    			try
    			{			
    				result = beheerModel.ClubCloud_Bouwaarden.Find(Id);
    		
    				if (result == null || refresh)
    					result = GetBouwaardById(settings.Id.ToString(), Id, refresh, settings);
    
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
    
    		return new ClubCloud_Bouwaard();
    	}
    
    	public List<ClubCloud_Bouwaard> GetBouwaarden(bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		List<ClubCloud_Bouwaard> result = null;
    
    		using (new SPMonitoredScope("Bouwaarden GetBouwaarden"))
    		{
    		
    			try
    			{
    				result = beheerModel.ClubCloud_Bouwaarden.ToList<ClubCloud_Bouwaard>();
    		
    				if (result == null || result.Count == 0 || refresh)		
    					result = GetBouwaarden(settings.Id.ToString(), refresh, settings);
    
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
    
    		return new List<ClubCloud_Bouwaard>();
    	}
    
    	public ClubCloud_Bouwaard SetBouwaard(ClubCloud_Bouwaard entity, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		ClubCloud_Bouwaard tobeupdated = null;
    		
    		using (new SPMonitoredScope("Bouwaarden SetBouwaard"))
    		{
    
    			try
    			{
    				entity = SetBouwaard(settings.Id.ToString(), entity, settings);
    
    				if(entity != null)
    					beheerModel.ClubCloud_Bouwaarden.AddOrUpdate(entity);
    		
    				beheerModel.SaveChanges();
    
    				tobeupdated = beheerModel.ClubCloud_Bouwaarden.Find(entity.Id);
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
    
    
    	public bool DeleteBouwaard(ClubCloud_Bouwaard entity, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		return DeleteBouwaardById(entity.Id, settings);
    	}
    
    	public bool DeleteBouwaardById(System.Guid Id, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		bool succes = false;
    		ClubCloud_Bouwaard tobedeleted = null;
    
    		using (new SPMonitoredScope("Bouwaarden DeleteBouwaardById"))
    		{
    
    			try
    			{
    
    				tobedeleted = beheerModel.ClubCloud_Bouwaarden.Find(Id);
    		
    				if (tobedeleted != null)
    				{
    					beheerModel.ClubCloud_Bouwaarden.Remove(tobedeleted);
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
    
    
    	public ClubCloud_Bouwaard_View GetBouwaardenByQuery(string bondsnummer, Guid verenigingId,System.Web.UI.DataSourceSelectArguments selectArgs = null, List<System.Web.UI.WebControls.Parameter> parameters = null, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		ClubCloud_Bouwaard_View view = new ClubCloud_Bouwaard_View();
    
    		using (new SPMonitoredScope("Bouwaarden GetBouwaardenByQuery"))
    		{
    
    			StringBuilder querybuilder = new StringBuilder("SELECT * FROM dbo.ClubCloud_Bouwaard");
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
    
    			view.ClubCloud_Bouwaard = beheerModel.Database.SqlQuery<ClubCloud_Bouwaard>(querybuilder.ToString(), sqlparams.ToArray()).Skip(selectArgs.StartRowIndex).Take(selectArgs.MaximumRows).ToList<ClubCloud_Bouwaard>();
    
    			if (selectArgs.RetrieveTotalRowCount)
    			{
    
    				view.TotalRowCount = beheerModel.Database.SqlQuery<ClubCloud_Bouwaard>(querybuilder.ToString(), sqlparamscount.ToArray()).Count();
    			}
    		}
    
    		return view;
    	}
    
    	public List<ClubCloud_Bouwaard> GetBouwaardenBySearch(string prefixText, int count, string contextKey, ClubCloud_Setting _settings = null)
    	{
    		if(_settings != null)
    			ValidateSettings(ref _settings);
    
            List<string> bouwaarden = new List<string>();
    
    		using (new SPMonitoredScope("Bouwaarden GetBouwaardenBySearch"))
    		{
    
    			try
    			{
    				bool enabled = false; //beheerModel.Database.SqlQuery<bool>("SELECT (CAST((FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))AS BIT))").FirstOrDefault();
    
    				List<ClubCloud_Bouwaard> entities = null;
    
    				if (enabled)
    				{
    					var fts = BeheerFullTextInterceptor.Fts(prefixText);
    				
    		
    				entities = beheerModel.ClubCloud_Bouwaarden.Where(e => e.Naam.Contains(fts)  || e.Omschrijving.Contains(fts)  || e.Code.Contains(fts)  || e.Beschrijving.Contains(fts)  || e.Meervoud.Contains(fts) ).ToList();
    
    					
    				}
    				else
    				{
    	
    				entities = beheerModel.Database.SqlQuery<ClubCloud_Bouwaard>("SELECT * FROM ClubCloud_Bouwaard WHERE  Naam LIKE '%"+ prefixText +"%' OR  Omschrijving LIKE '%"+ prefixText +"%' OR  Code LIKE '%"+ prefixText +"%' OR  Beschrijving LIKE '%"+ prefixText +"%' OR  Meervoud LIKE '%"+ prefixText +"%'").ToList();
    
    					
    				}
    
    				if (entities != null && entities.Count > 0)
    					return entities;
    			}
    			catch (Exception ex)
    			{
    				Logger.WriteLog(Logger.Category.Unexpected, ex.Source, ex.Message);
    			}
    		}
    
            return new List<ClubCloud_Bouwaard>();
    	}
    
    }
    
    [Serializable]
    [DataContract(IsReference = true)]
    [KnownType(typeof(ClubCloud_Bouwaard))]
    public partial class ClubCloud_Bouwaard_View
    {
    	public ClubCloud_Bouwaard_View()
    	{
    		this.ClubCloud_Bouwaard = new HashSet<ClubCloud_Bouwaard>();
    	}
    
    	[DataMember]
    	public int TotalRowCount { get; set; }
    
    	[DataMember]
    	public virtual ICollection<ClubCloud_Bouwaard> ClubCloud_Bouwaard { get; set; }
    
    }
    	
}

