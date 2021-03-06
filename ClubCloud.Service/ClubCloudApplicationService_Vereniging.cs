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
    	public ClubCloud_Vereniging GetVerenigingById(System.Guid Id , bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		ClubCloud_Vereniging result = null;
    
    		using (new SPMonitoredScope("Verenigingen GetVerenigingById"))
    		{
    
    			try
    			{			
    				result = beheerModel.ClubCloud_Verenigingen.Find(Id);
    		
    				if (result == null || refresh)
    					result = GetVerenigingById(settings.Id.ToString(), Id, refresh, settings);
    
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
    
    		return new ClubCloud_Vereniging();
    	}
    
    	public List<ClubCloud_Vereniging> GetVerenigingen(bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		List<ClubCloud_Vereniging> result = null;
    
    		using (new SPMonitoredScope("Verenigingen GetVerenigingen"))
    		{
    		
    			try
    			{
    				result = beheerModel.ClubCloud_Verenigingen.ToList<ClubCloud_Vereniging>();
    		
    				if (result == null || result.Count == 0 || refresh)		
    					result = GetVerenigingen(settings.Id.ToString(), refresh, settings);
    
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
    
    		return new List<ClubCloud_Vereniging>();
    	}
    
    	public ClubCloud_Vereniging SetVereniging(ClubCloud_Vereniging entity, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		ClubCloud_Vereniging tobeupdated = null;
    		
    		using (new SPMonitoredScope("Verenigingen SetVereniging"))
    		{
    
    			try
    			{
    				entity = SetVereniging(settings.Id.ToString(), entity, settings);
    
    				if(entity != null)
    					beheerModel.ClubCloud_Verenigingen.AddOrUpdate(entity);
    		
    				beheerModel.SaveChanges();
    
    				tobeupdated = beheerModel.ClubCloud_Verenigingen.Find(entity.Id);
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
    
    
    	public bool DeleteVereniging(ClubCloud_Vereniging entity, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		return DeleteVerenigingById(entity.Id, settings);
    	}
    
    	public bool DeleteVerenigingById(System.Guid Id, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		bool succes = false;
    		ClubCloud_Vereniging tobedeleted = null;
    
    		using (new SPMonitoredScope("Verenigingen DeleteVerenigingById"))
    		{
    
    			try
    			{
    
    				tobedeleted = beheerModel.ClubCloud_Verenigingen.Find(Id);
    		
    				if (tobedeleted != null)
    				{
    					beheerModel.ClubCloud_Verenigingen.Remove(tobedeleted);
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
    
    
    	public ClubCloud_Vereniging_View GetVerenigingenByQuery(string bondsnummer, Guid verenigingId,System.Web.UI.DataSourceSelectArguments selectArgs = null, List<System.Web.UI.WebControls.Parameter> parameters = null, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		ClubCloud_Vereniging_View view = new ClubCloud_Vereniging_View();
    
    		using (new SPMonitoredScope("Verenigingen GetVerenigingenByQuery"))
    		{
    
    			StringBuilder querybuilder = new StringBuilder("SELECT * FROM dbo.ClubCloud_Vereniging");
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
    
    			view.ClubCloud_Vereniging = beheerModel.Database.SqlQuery<ClubCloud_Vereniging>(querybuilder.ToString(), sqlparams.ToArray()).Skip(selectArgs.StartRowIndex).Take(selectArgs.MaximumRows).ToList<ClubCloud_Vereniging>();
    
    			if (selectArgs.RetrieveTotalRowCount)
    			{
    
    				view.TotalRowCount = beheerModel.Database.SqlQuery<ClubCloud_Vereniging>(querybuilder.ToString(), sqlparamscount.ToArray()).Count();
    			}
    		}
    
    		return view;
    	}
    
    	public List<ClubCloud_Vereniging> GetVerenigingenBySearch(string prefixText, int count, string contextKey, ClubCloud_Setting _settings = null)
    	{
    		if(_settings != null)
    			ValidateSettings(ref _settings);
    
            List<string> verenigingen = new List<string>();
    
    		using (new SPMonitoredScope("Verenigingen GetVerenigingenBySearch"))
    		{
    
    			try
    			{
    				bool enabled = false; //beheerModel.Database.SqlQuery<bool>("SELECT (CAST((FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))AS BIT))").FirstOrDefault();
    
    				List<ClubCloud_Vereniging> entities = null;
    
    				if (enabled)
    				{
    					var fts = BeheerFullTextInterceptor.Fts(prefixText);
    				
    		
    				entities = beheerModel.ClubCloud_Verenigingen.Where(e => e.Naam.Contains(fts)  || e.Beschrijving.Contains(fts)  || e.Nummer.Contains(fts)  || e.BankNummer.Contains(fts)  || e.BankIban.Contains(fts)  || e.BankPlaats.Contains(fts)  || e.KvKnummer.Contains(fts)  || e.KvKplaats.Contains(fts)  || e.EmailKNLTB.Contains(fts)  || e.EmailWebSite.Contains(fts)  || e.EmailOverig.Contains(fts)  || e.Fax.Contains(fts)  || e.TelefoonAvond.Contains(fts)  || e.TelefoonOverdag.Contains(fts)  || e.TelefoonOverig.Contains(fts)  || e.Website.Contains(fts)  || e.FTPsite.Contains(fts) ).ToList();
    
    					
    				}
    				else
    				{
    	
    				entities = beheerModel.Database.SqlQuery<ClubCloud_Vereniging>("SELECT * FROM ClubCloud_Vereniging WHERE  Naam LIKE '%"+ prefixText +"%' OR  Beschrijving LIKE '%"+ prefixText +"%' OR  Nummer LIKE '%"+ prefixText +"%' OR  BankNummer LIKE '%"+ prefixText +"%' OR  BankIban LIKE '%"+ prefixText +"%' OR  BankPlaats LIKE '%"+ prefixText +"%' OR  KvKnummer LIKE '%"+ prefixText +"%' OR  KvKplaats LIKE '%"+ prefixText +"%' OR  EmailKNLTB LIKE '%"+ prefixText +"%' OR  EmailWebSite LIKE '%"+ prefixText +"%' OR  EmailOverig LIKE '%"+ prefixText +"%' OR  Fax LIKE '%"+ prefixText +"%' OR  TelefoonAvond LIKE '%"+ prefixText +"%' OR  TelefoonOverdag LIKE '%"+ prefixText +"%' OR  TelefoonOverig LIKE '%"+ prefixText +"%' OR  Website LIKE '%"+ prefixText +"%' OR  FTPsite LIKE '%"+ prefixText +"%'").ToList();
    
    					
    				}
    
    				if (entities != null && entities.Count > 0)
    					return entities;
    			}
    			catch (Exception ex)
    			{
    				Logger.WriteLog(Logger.Category.Unexpected, ex.Source, ex.Message);
    			}
    		}
    
            return new List<ClubCloud_Vereniging>();
    	}
    
    
    	public List<ClubCloud_Functionaris> GetFunctionarissenForVereniging(ClubCloud_Vereniging entity, bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		List<ClubCloud_Functionaris> result = null;
    
    		using (new SPMonitoredScope("Verenigingen GetFunctionarissenForVereniging"))
    		{
    
    			try
    			{
    				entity = beheerModel.ClubCloud_Verenigingen.Find(entity.Id);
    				if(entity != null && entity.ClubCloud_Functionaris != null && entity.ClubCloud_Functionaris.Count == 0)
    					beheerModel.Entry(entity).Collection(e => e.ClubCloud_Functionaris).Load();
    
    				if(entity != null)
    					result = entity.ClubCloud_Functionaris.ToList();
    
    				if(result == null || result.Count == 0 || refresh && entity != null)
    					result = GetFunctionarissenForVereniging(settings.Id.ToString(), entity, refresh, settings);
    
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
    
    
    	public List<ClubCloud_Functionaris> GetFunctionarissenForVerenigingById(System.Guid Id, bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		ClubCloud_Vereniging entity = null;
    		List<ClubCloud_Functionaris> result = null;
    
    		using (new SPMonitoredScope("Verenigingen GetFunctionarissenForVerenigingById"))
    		{
    
    			try
    			{
    				entity = beheerModel.ClubCloud_Verenigingen.Find(Id);
    				if(entity != null && entity.ClubCloud_Functionaris != null && entity.ClubCloud_Functionaris.Count == 0)
    					beheerModel.Entry(entity).Collection(e => e.ClubCloud_Functionaris).Load();
    
    				if(entity != null)
    					result = entity.ClubCloud_Functionaris.ToList();
    
    				if(result == null || result.Count == 0 || refresh)
    					result = GetFunctionarissenForVerenigingById(settings.Id.ToString(), Id, refresh, settings);
    
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
    
    	public bool SetFunctionarissenForVereniging(List<ClubCloud_Functionaris> Functionarissen, ClubCloud_Vereniging entity, bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		bool succes = false;
    		ClubCloud_Vereniging result = null;
    
    		using (new SPMonitoredScope("Verenigingen SetFunctionarissenForVereniging"))
    		{
    
    			try
    			{			
    				entity = beheerModel.ClubCloud_Verenigingen.Find(entity.Id);
    		
    				if (entity != null)
    					beheerModel.Entry(entity).Collection(e => e.ClubCloud_Functionaris).Load();
    					//result = GetVerenigingById(settings.Id.ToString(), Id, refresh, settings);
    
    				if (result != null)
    					//return result.ClubCloud_Verenigingen.Count == ;
    
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
    
    
    
    	public List<ClubCloud_Lidmaatschap> GetLidmaatschappenForVereniging(ClubCloud_Vereniging entity, bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		List<ClubCloud_Lidmaatschap> result = null;
    
    		using (new SPMonitoredScope("Verenigingen GetLidmaatschappenForVereniging"))
    		{
    
    			try
    			{
    				entity = beheerModel.ClubCloud_Verenigingen.Find(entity.Id);
    				if(entity != null && entity.ClubCloud_Lidmaatschap != null && entity.ClubCloud_Lidmaatschap.Count == 0)
    					beheerModel.Entry(entity).Collection(e => e.ClubCloud_Lidmaatschap).Load();
    
    				if(entity != null)
    					result = entity.ClubCloud_Lidmaatschap.ToList();
    
    				if(result == null || result.Count == 0 || refresh && entity != null)
    					result = GetLidmaatschappenForVereniging(settings.Id.ToString(), entity, refresh, settings);
    
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
    
    		return new List<ClubCloud_Lidmaatschap>();
    	}
    
    
    	public List<ClubCloud_Lidmaatschap> GetLidmaatschappenForVerenigingById(System.Guid Id, bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		ClubCloud_Vereniging entity = null;
    		List<ClubCloud_Lidmaatschap> result = null;
    
    		using (new SPMonitoredScope("Verenigingen GetLidmaatschappenForVerenigingById"))
    		{
    
    			try
    			{
    				entity = beheerModel.ClubCloud_Verenigingen.Find(Id);
    				if(entity != null && entity.ClubCloud_Lidmaatschap != null && entity.ClubCloud_Lidmaatschap.Count == 0)
    					beheerModel.Entry(entity).Collection(e => e.ClubCloud_Lidmaatschap).Load();
    
    				if(entity != null)
    					result = entity.ClubCloud_Lidmaatschap.ToList();
    
    				if(result == null || result.Count == 0 || refresh)
    					result = GetLidmaatschappenForVerenigingById(settings.Id.ToString(), Id, refresh, settings);
    
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
    
    		return new List<ClubCloud_Lidmaatschap>();	
    	}
    
    	public bool SetLidmaatschappenForVereniging(List<ClubCloud_Lidmaatschap> Lidmaatschappen, ClubCloud_Vereniging entity, bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		bool succes = false;
    		ClubCloud_Vereniging result = null;
    
    		using (new SPMonitoredScope("Verenigingen SetLidmaatschappenForVereniging"))
    		{
    
    			try
    			{			
    				entity = beheerModel.ClubCloud_Verenigingen.Find(entity.Id);
    		
    				if (entity != null)
    					beheerModel.Entry(entity).Collection(e => e.ClubCloud_Lidmaatschap).Load();
    					//result = GetVerenigingById(settings.Id.ToString(), Id, refresh, settings);
    
    				if (result != null)
    					//return result.ClubCloud_Verenigingen.Count == ;
    
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
    
    
    
    	public List<ClubCloud_Bestuursorgaan> GetBestuursorganenForVereniging(ClubCloud_Vereniging entity, bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		List<ClubCloud_Bestuursorgaan> result = null;
    
    		using (new SPMonitoredScope("Verenigingen GetBestuursorganenForVereniging"))
    		{
    
    			try
    			{
    				entity = beheerModel.ClubCloud_Verenigingen.Find(entity.Id);
    				if(entity != null && entity.ClubCloud_Bestuursorgaan != null && entity.ClubCloud_Bestuursorgaan.Count == 0)
    					beheerModel.Entry(entity).Collection(e => e.ClubCloud_Bestuursorgaan).Load();
    
    				if(entity != null)
    					result = entity.ClubCloud_Bestuursorgaan.ToList();
    
    				if(result == null || result.Count == 0 || refresh && entity != null)
    					result = GetBestuursorganenForVereniging(settings.Id.ToString(), entity, refresh, settings);
    
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
    
    		return new List<ClubCloud_Bestuursorgaan>();
    	}
    
    
    	public List<ClubCloud_Bestuursorgaan> GetBestuursorganenForVerenigingById(System.Guid Id, bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		ClubCloud_Vereniging entity = null;
    		List<ClubCloud_Bestuursorgaan> result = null;
    
    		using (new SPMonitoredScope("Verenigingen GetBestuursorganenForVerenigingById"))
    		{
    
    			try
    			{
    				entity = beheerModel.ClubCloud_Verenigingen.Find(Id);
    				if(entity != null && entity.ClubCloud_Bestuursorgaan != null && entity.ClubCloud_Bestuursorgaan.Count == 0)
    					beheerModel.Entry(entity).Collection(e => e.ClubCloud_Bestuursorgaan).Load();
    
    				if(entity != null)
    					result = entity.ClubCloud_Bestuursorgaan.ToList();
    
    				if(result == null || result.Count == 0 || refresh)
    					result = GetBestuursorganenForVerenigingById(settings.Id.ToString(), Id, refresh, settings);
    
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
    
    		return new List<ClubCloud_Bestuursorgaan>();	
    	}
    
    	public bool SetBestuursorganenForVereniging(List<ClubCloud_Bestuursorgaan> Bestuursorganen, ClubCloud_Vereniging entity, bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		bool succes = false;
    		ClubCloud_Vereniging result = null;
    
    		using (new SPMonitoredScope("Verenigingen SetBestuursorganenForVereniging"))
    		{
    
    			try
    			{			
    				entity = beheerModel.ClubCloud_Verenigingen.Find(entity.Id);
    		
    				if (entity != null)
    					beheerModel.Entry(entity).Collection(e => e.ClubCloud_Bestuursorgaan).Load();
    					//result = GetVerenigingById(settings.Id.ToString(), Id, refresh, settings);
    
    				if (result != null)
    					//return result.ClubCloud_Verenigingen.Count == ;
    
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
    
    
    
    	public ClubCloud_District GetDistrictForVereniging(ClubCloud_Vereniging entity, bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		ClubCloud_District result = null;
    
    		using (new SPMonitoredScope("Verenigingen GetDistrictForVereniging"))
    		{
    
    			try
    			{
    				entity = beheerModel.ClubCloud_Verenigingen.Find(entity.Id);
    				if(entity != null && entity.ClubCloud_District == null)
    					beheerModel.Entry(entity).Reference(e => e.ClubCloud_District).Load();
    
    				if(entity != null)
    					result = entity.ClubCloud_District;
    
    				if (result == null || refresh && entity != null)
    					result = GetDistrictForVereniging(settings.Id.ToString(), entity, refresh, settings);
    
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
    
    		return new ClubCloud_District();
    	}
    
    	public bool SetDistrictForVereniging(ClubCloud_District District, ClubCloud_Vereniging entity , bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		bool succes = false;
    
    		using (new SPMonitoredScope("Verenigingen SetDistrictForVereniging"))
    		{
    
    			try
    			{		
    				entity = beheerModel.ClubCloud_Verenigingen.Find(entity.Id);	
    
    				if(entity != null && entity.ClubCloud_District == null)
    					beheerModel.Entry(entity).Reference(e => e.ClubCloud_District).Load();
    
    				if(entity != null)
    					entity.ClubCloud_District = District;
    
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
    
    
    	public ClubCloud_District GetDistrictForVerenigingById(System.Guid Id, bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		ClubCloud_Vereniging entity = null;
    		ClubCloud_District result = null;
    
    		using (new SPMonitoredScope("Verenigingen GetDistrictForVerenigingById"))
    		{
    
    			try
    			{
    				entity = beheerModel.ClubCloud_Verenigingen.Find(Id);
    				if(entity != null && entity.ClubCloud_District == null)
    					beheerModel.Entry(entity).Reference(e => e.ClubCloud_District).Load();
    
    				if(entity != null)
    					result = entity.ClubCloud_District;
    
    				if (result == null || refresh)
    					result = GetDistrictForVerenigingById(settings.Id.ToString(), Id, refresh, settings);
    
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
    
    		return new ClubCloud_District();
    	}
    
    	public bool SetDistrictForVerenigingById(ClubCloud_District District, System.Guid Id , bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		ClubCloud_Vereniging entity = null;
    		bool succes = false;
    
    		using (new SPMonitoredScope("Verenigingen SetDistrictForVerenigingById"))
    		{
    
    			try
    			{		
    				entity = beheerModel.ClubCloud_Verenigingen.Find(Id);	
    
    				if(entity != null && entity.ClubCloud_District == null)
    					beheerModel.Entry(entity).Reference(e => e.ClubCloud_District).Load();
    
    				if(entity != null)
    					entity.ClubCloud_District = District;
    
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
    
    
    	public ClubCloud_Rechtsvorm GetRechtsvormForVereniging(ClubCloud_Vereniging entity, bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		ClubCloud_Rechtsvorm result = null;
    
    		using (new SPMonitoredScope("Verenigingen GetRechtsvormForVereniging"))
    		{
    
    			try
    			{
    				entity = beheerModel.ClubCloud_Verenigingen.Find(entity.Id);
    				if(entity != null && entity.ClubCloud_Rechtsvorm == null)
    					beheerModel.Entry(entity).Reference(e => e.ClubCloud_Rechtsvorm).Load();
    
    				if(entity != null)
    					result = entity.ClubCloud_Rechtsvorm;
    
    				if (result == null || refresh && entity != null)
    					result = GetRechtsvormForVereniging(settings.Id.ToString(), entity, refresh, settings);
    
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
    
    		return new ClubCloud_Rechtsvorm();
    	}
    
    	public bool SetRechtsvormForVereniging(ClubCloud_Rechtsvorm Rechtsvorm, ClubCloud_Vereniging entity , bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		bool succes = false;
    
    		using (new SPMonitoredScope("Verenigingen SetRechtsvormForVereniging"))
    		{
    
    			try
    			{		
    				entity = beheerModel.ClubCloud_Verenigingen.Find(entity.Id);	
    
    				if(entity != null && entity.ClubCloud_Rechtsvorm == null)
    					beheerModel.Entry(entity).Reference(e => e.ClubCloud_Rechtsvorm).Load();
    
    				if(entity != null)
    					entity.ClubCloud_Rechtsvorm = Rechtsvorm;
    
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
    
    
    	public ClubCloud_Rechtsvorm GetRechtsvormForVerenigingById(System.Guid Id, bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		ClubCloud_Vereniging entity = null;
    		ClubCloud_Rechtsvorm result = null;
    
    		using (new SPMonitoredScope("Verenigingen GetRechtsvormForVerenigingById"))
    		{
    
    			try
    			{
    				entity = beheerModel.ClubCloud_Verenigingen.Find(Id);
    				if(entity != null && entity.ClubCloud_Rechtsvorm == null)
    					beheerModel.Entry(entity).Reference(e => e.ClubCloud_Rechtsvorm).Load();
    
    				if(entity != null)
    					result = entity.ClubCloud_Rechtsvorm;
    
    				if (result == null || refresh)
    					result = GetRechtsvormForVerenigingById(settings.Id.ToString(), Id, refresh, settings);
    
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
    
    		return new ClubCloud_Rechtsvorm();
    	}
    
    	public bool SetRechtsvormForVerenigingById(ClubCloud_Rechtsvorm Rechtsvorm, System.Guid Id , bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		ClubCloud_Vereniging entity = null;
    		bool succes = false;
    
    		using (new SPMonitoredScope("Verenigingen SetRechtsvormForVerenigingById"))
    		{
    
    			try
    			{		
    				entity = beheerModel.ClubCloud_Verenigingen.Find(Id);	
    
    				if(entity != null && entity.ClubCloud_Rechtsvorm == null)
    					beheerModel.Entry(entity).Reference(e => e.ClubCloud_Rechtsvorm).Load();
    
    				if(entity != null)
    					entity.ClubCloud_Rechtsvorm = Rechtsvorm;
    
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
    
    
    	public ClubCloud_Accommodatie GetAccommodatieForVereniging(ClubCloud_Vereniging entity, bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		ClubCloud_Accommodatie result = null;
    
    		using (new SPMonitoredScope("Verenigingen GetAccommodatieForVereniging"))
    		{
    
    			try
    			{
    				entity = beheerModel.ClubCloud_Verenigingen.Find(entity.Id);
    				if(entity != null && entity.ClubCloud_Accommodatie == null)
    					beheerModel.Entry(entity).Reference(e => e.ClubCloud_Accommodatie).Load();
    
    				if(entity != null)
    					result = entity.ClubCloud_Accommodatie;
    
    				if (result == null || refresh && entity != null)
    					result = GetAccommodatieForVereniging(settings.Id.ToString(), entity, refresh, settings);
    
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
    
    	public bool SetAccommodatieForVereniging(ClubCloud_Accommodatie Accommodatie, ClubCloud_Vereniging entity , bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		bool succes = false;
    
    		using (new SPMonitoredScope("Verenigingen SetAccommodatieForVereniging"))
    		{
    
    			try
    			{		
    				entity = beheerModel.ClubCloud_Verenigingen.Find(entity.Id);	
    
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
    
    
    	public ClubCloud_Accommodatie GetAccommodatieForVerenigingById(System.Guid Id, bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		ClubCloud_Vereniging entity = null;
    		ClubCloud_Accommodatie result = null;
    
    		using (new SPMonitoredScope("Verenigingen GetAccommodatieForVerenigingById"))
    		{
    
    			try
    			{
    				entity = beheerModel.ClubCloud_Verenigingen.Find(Id);
    				if(entity != null && entity.ClubCloud_Accommodatie == null)
    					beheerModel.Entry(entity).Reference(e => e.ClubCloud_Accommodatie).Load();
    
    				if(entity != null)
    					result = entity.ClubCloud_Accommodatie;
    
    				if (result == null || refresh)
    					result = GetAccommodatieForVerenigingById(settings.Id.ToString(), Id, refresh, settings);
    
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
    
    	public bool SetAccommodatieForVerenigingById(ClubCloud_Accommodatie Accommodatie, System.Guid Id , bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		ClubCloud_Vereniging entity = null;
    		bool succes = false;
    
    		using (new SPMonitoredScope("Verenigingen SetAccommodatieForVerenigingById"))
    		{
    
    			try
    			{		
    				entity = beheerModel.ClubCloud_Verenigingen.Find(Id);	
    
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
    
    
    	public List<ClubCloud_Address> GetAddressenForVereniging(ClubCloud_Vereniging entity, bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		List<ClubCloud_Address> result = null;
    
    		using (new SPMonitoredScope("Verenigingen GetAddressenForVereniging"))
    		{
    
    			try
    			{
    				entity = beheerModel.ClubCloud_Verenigingen.Find(entity.Id);
    				if(entity != null && entity.ClubCloud_Address != null && entity.ClubCloud_Address.Count == 0)
    					beheerModel.Entry(entity).Collection(e => e.ClubCloud_Address).Load();
    
    				if(entity != null)
    					result = entity.ClubCloud_Address.ToList();
    
    				if(result == null || result.Count == 0 || refresh && entity != null)
    					result = GetAddressenForVereniging(settings.Id.ToString(), entity, refresh, settings);
    
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
    
    
    	public List<ClubCloud_Address> GetAddressenForVerenigingById(System.Guid Id, bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		ClubCloud_Vereniging entity = null;
    		List<ClubCloud_Address> result = null;
    
    		using (new SPMonitoredScope("Verenigingen GetAddressenForVerenigingById"))
    		{
    
    			try
    			{
    				entity = beheerModel.ClubCloud_Verenigingen.Find(Id);
    				if(entity != null && entity.ClubCloud_Address != null && entity.ClubCloud_Address.Count == 0)
    					beheerModel.Entry(entity).Collection(e => e.ClubCloud_Address).Load();
    
    				if(entity != null)
    					result = entity.ClubCloud_Address.ToList();
    
    				if(result == null || result.Count == 0 || refresh)
    					result = GetAddressenForVerenigingById(settings.Id.ToString(), Id, refresh, settings);
    
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
    
    	public bool SetAddressenForVereniging(List<ClubCloud_Address> Addressen, ClubCloud_Vereniging entity, bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		bool succes = false;
    		ClubCloud_Vereniging result = null;
    
    		using (new SPMonitoredScope("Verenigingen SetAddressenForVereniging"))
    		{
    
    			try
    			{			
    				entity = beheerModel.ClubCloud_Verenigingen.Find(entity.Id);
    		
    				if (entity != null)
    					beheerModel.Entry(entity).Collection(e => e.ClubCloud_Address).Load();
    					//result = GetVerenigingById(settings.Id.ToString(), Id, refresh, settings);
    
    				if (result != null)
    					//return result.ClubCloud_Verenigingen.Count == ;
    
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
    
    
    
    	public ClubCloud_Regio GetRegioForVereniging(ClubCloud_Vereniging entity, bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		ClubCloud_Regio result = null;
    
    		using (new SPMonitoredScope("Verenigingen GetRegioForVereniging"))
    		{
    
    			try
    			{
    				entity = beheerModel.ClubCloud_Verenigingen.Find(entity.Id);
    				if(entity != null && entity.ClubCloud_Regio == null)
    					beheerModel.Entry(entity).Reference(e => e.ClubCloud_Regio).Load();
    
    				if(entity != null)
    					result = entity.ClubCloud_Regio;
    
    				if (result == null || refresh && entity != null)
    					result = GetRegioForVereniging(settings.Id.ToString(), entity, refresh, settings);
    
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
    
    	public bool SetRegioForVereniging(ClubCloud_Regio Regio, ClubCloud_Vereniging entity , bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		bool succes = false;
    
    		using (new SPMonitoredScope("Verenigingen SetRegioForVereniging"))
    		{
    
    			try
    			{		
    				entity = beheerModel.ClubCloud_Verenigingen.Find(entity.Id);	
    
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
    
    
    	public ClubCloud_Regio GetRegioForVerenigingById(System.Guid Id, bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		ClubCloud_Vereniging entity = null;
    		ClubCloud_Regio result = null;
    
    		using (new SPMonitoredScope("Verenigingen GetRegioForVerenigingById"))
    		{
    
    			try
    			{
    				entity = beheerModel.ClubCloud_Verenigingen.Find(Id);
    				if(entity != null && entity.ClubCloud_Regio == null)
    					beheerModel.Entry(entity).Reference(e => e.ClubCloud_Regio).Load();
    
    				if(entity != null)
    					result = entity.ClubCloud_Regio;
    
    				if (result == null || refresh)
    					result = GetRegioForVerenigingById(settings.Id.ToString(), Id, refresh, settings);
    
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
    
    	public bool SetRegioForVerenigingById(ClubCloud_Regio Regio, System.Guid Id , bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		ClubCloud_Vereniging entity = null;
    		bool succes = false;
    
    		using (new SPMonitoredScope("Verenigingen SetRegioForVerenigingById"))
    		{
    
    			try
    			{		
    				entity = beheerModel.ClubCloud_Verenigingen.Find(Id);	
    
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
    
    
    	public List<ClubCloud_Gebruiker> GetGebruikersForVereniging(ClubCloud_Vereniging entity, bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		List<ClubCloud_Gebruiker> result = null;
    
    		using (new SPMonitoredScope("Verenigingen GetGebruikersForVereniging"))
    		{
    
    			try
    			{
    				entity = beheerModel.ClubCloud_Verenigingen.Find(entity.Id);
    				if(entity != null && entity.ClubCloud_Gebruiker != null && entity.ClubCloud_Gebruiker.Count == 0)
    					beheerModel.Entry(entity).Collection(e => e.ClubCloud_Gebruiker).Load();
    
    				if(entity != null)
    					result = entity.ClubCloud_Gebruiker.ToList();
    
    				if(result == null || result.Count == 0 || refresh && entity != null)
    					result = GetGebruikersForVereniging(settings.Id.ToString(), entity, refresh, settings);
    
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
    
    		return new List<ClubCloud_Gebruiker>();
    	}
    
    
    	public List<ClubCloud_Gebruiker> GetGebruikersForVerenigingById(System.Guid Id, bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		ClubCloud_Vereniging entity = null;
    		List<ClubCloud_Gebruiker> result = null;
    
    		using (new SPMonitoredScope("Verenigingen GetGebruikersForVerenigingById"))
    		{
    
    			try
    			{
    				entity = beheerModel.ClubCloud_Verenigingen.Find(Id);
    				if(entity != null && entity.ClubCloud_Gebruiker != null && entity.ClubCloud_Gebruiker.Count == 0)
    					beheerModel.Entry(entity).Collection(e => e.ClubCloud_Gebruiker).Load();
    
    				if(entity != null)
    					result = entity.ClubCloud_Gebruiker.ToList();
    
    				if(result == null || result.Count == 0 || refresh)
    					result = GetGebruikersForVerenigingById(settings.Id.ToString(), Id, refresh, settings);
    
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
    
    		return new List<ClubCloud_Gebruiker>();	
    	}
    
    	public bool SetGebruikersForVereniging(List<ClubCloud_Gebruiker> Gebruikers, ClubCloud_Vereniging entity, bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		bool succes = false;
    		ClubCloud_Vereniging result = null;
    
    		using (new SPMonitoredScope("Verenigingen SetGebruikersForVereniging"))
    		{
    
    			try
    			{			
    				entity = beheerModel.ClubCloud_Verenigingen.Find(entity.Id);
    		
    				if (entity != null)
    					beheerModel.Entry(entity).Collection(e => e.ClubCloud_Gebruiker).Load();
    					//result = GetVerenigingById(settings.Id.ToString(), Id, refresh, settings);
    
    				if (result != null)
    					//return result.ClubCloud_Verenigingen.Count == ;
    
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
    
    
    
    	public List<ClubCloud_Afhang> GetAfhangenForVereniging(ClubCloud_Vereniging entity, bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		List<ClubCloud_Afhang> result = null;
    
    		using (new SPMonitoredScope("Verenigingen GetAfhangenForVereniging"))
    		{
    
    			try
    			{
    				entity = beheerModel.ClubCloud_Verenigingen.Find(entity.Id);
    				if(entity != null && entity.ClubCloud_Afhang != null && entity.ClubCloud_Afhang.Count == 0)
    					beheerModel.Entry(entity).Collection(e => e.ClubCloud_Afhang).Load();
    
    				if(entity != null)
    					result = entity.ClubCloud_Afhang.ToList();
    
    				if(result == null || result.Count == 0 || refresh && entity != null)
    					result = GetAfhangenForVereniging(settings.Id.ToString(), entity, refresh, settings);
    
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
    
    		return new List<ClubCloud_Afhang>();
    	}
    
    
    	public List<ClubCloud_Afhang> GetAfhangenForVerenigingById(System.Guid Id, bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		ClubCloud_Vereniging entity = null;
    		List<ClubCloud_Afhang> result = null;
    
    		using (new SPMonitoredScope("Verenigingen GetAfhangenForVerenigingById"))
    		{
    
    			try
    			{
    				entity = beheerModel.ClubCloud_Verenigingen.Find(Id);
    				if(entity != null && entity.ClubCloud_Afhang != null && entity.ClubCloud_Afhang.Count == 0)
    					beheerModel.Entry(entity).Collection(e => e.ClubCloud_Afhang).Load();
    
    				if(entity != null)
    					result = entity.ClubCloud_Afhang.ToList();
    
    				if(result == null || result.Count == 0 || refresh)
    					result = GetAfhangenForVerenigingById(settings.Id.ToString(), Id, refresh, settings);
    
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
    
    		return new List<ClubCloud_Afhang>();	
    	}
    
    	public bool SetAfhangenForVereniging(List<ClubCloud_Afhang> Afhangen, ClubCloud_Vereniging entity, bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		bool succes = false;
    		ClubCloud_Vereniging result = null;
    
    		using (new SPMonitoredScope("Verenigingen SetAfhangenForVereniging"))
    		{
    
    			try
    			{			
    				entity = beheerModel.ClubCloud_Verenigingen.Find(entity.Id);
    		
    				if (entity != null)
    					beheerModel.Entry(entity).Collection(e => e.ClubCloud_Afhang).Load();
    					//result = GetVerenigingById(settings.Id.ToString(), Id, refresh, settings);
    
    				if (result != null)
    					//return result.ClubCloud_Verenigingen.Count == ;
    
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
    
    
    
    	public List<ClubCloud_Sponsor> GetSponsorenForVereniging(ClubCloud_Vereniging entity, bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		List<ClubCloud_Sponsor> result = null;
    
    		using (new SPMonitoredScope("Verenigingen GetSponsorenForVereniging"))
    		{
    
    			try
    			{
    				entity = beheerModel.ClubCloud_Verenigingen.Find(entity.Id);
    				if(entity != null && entity.ClubCloud_Sponsor != null && entity.ClubCloud_Sponsor.Count == 0)
    					beheerModel.Entry(entity).Collection(e => e.ClubCloud_Sponsor).Load();
    
    				if(entity != null)
    					result = entity.ClubCloud_Sponsor.ToList();
    
    				if(result == null || result.Count == 0 || refresh && entity != null)
    					result = GetSponsorenForVereniging(settings.Id.ToString(), entity, refresh, settings);
    
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
    
    		return new List<ClubCloud_Sponsor>();
    	}
    
    
    	public List<ClubCloud_Sponsor> GetSponsorenForVerenigingById(System.Guid Id, bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		ClubCloud_Vereniging entity = null;
    		List<ClubCloud_Sponsor> result = null;
    
    		using (new SPMonitoredScope("Verenigingen GetSponsorenForVerenigingById"))
    		{
    
    			try
    			{
    				entity = beheerModel.ClubCloud_Verenigingen.Find(Id);
    				if(entity != null && entity.ClubCloud_Sponsor != null && entity.ClubCloud_Sponsor.Count == 0)
    					beheerModel.Entry(entity).Collection(e => e.ClubCloud_Sponsor).Load();
    
    				if(entity != null)
    					result = entity.ClubCloud_Sponsor.ToList();
    
    				if(result == null || result.Count == 0 || refresh)
    					result = GetSponsorenForVerenigingById(settings.Id.ToString(), Id, refresh, settings);
    
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
    
    		return new List<ClubCloud_Sponsor>();	
    	}
    
    	public bool SetSponsorenForVereniging(List<ClubCloud_Sponsor> Sponsoren, ClubCloud_Vereniging entity, bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		bool succes = false;
    		ClubCloud_Vereniging result = null;
    
    		using (new SPMonitoredScope("Verenigingen SetSponsorenForVereniging"))
    		{
    
    			try
    			{			
    				entity = beheerModel.ClubCloud_Verenigingen.Find(entity.Id);
    		
    				if (entity != null)
    					beheerModel.Entry(entity).Collection(e => e.ClubCloud_Sponsor).Load();
    					//result = GetVerenigingById(settings.Id.ToString(), Id, refresh, settings);
    
    				if (result != null)
    					//return result.ClubCloud_Verenigingen.Count == ;
    
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
    
    
    
    	public List<ClubCloud_Setting> GetSettingsForVereniging(ClubCloud_Vereniging entity, bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		List<ClubCloud_Setting> result = null;
    
    		using (new SPMonitoredScope("Verenigingen GetSettingsForVereniging"))
    		{
    
    			try
    			{
    				entity = beheerModel.ClubCloud_Verenigingen.Find(entity.Id);
    				if(entity != null && entity.ClubCloud_Setting != null && entity.ClubCloud_Setting.Count == 0)
    					beheerModel.Entry(entity).Collection(e => e.ClubCloud_Setting).Load();
    
    				if(entity != null)
    					result = entity.ClubCloud_Setting.ToList();
    
    				if(result == null || result.Count == 0 || refresh && entity != null)
    					result = GetSettingsForVereniging(settings.Id.ToString(), entity, refresh, settings);
    
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
    
    		return new List<ClubCloud_Setting>();
    	}
    
    
    	public List<ClubCloud_Setting> GetSettingsForVerenigingById(System.Guid Id, bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		ClubCloud_Vereniging entity = null;
    		List<ClubCloud_Setting> result = null;
    
    		using (new SPMonitoredScope("Verenigingen GetSettingsForVerenigingById"))
    		{
    
    			try
    			{
    				entity = beheerModel.ClubCloud_Verenigingen.Find(Id);
    				if(entity != null && entity.ClubCloud_Setting != null && entity.ClubCloud_Setting.Count == 0)
    					beheerModel.Entry(entity).Collection(e => e.ClubCloud_Setting).Load();
    
    				if(entity != null)
    					result = entity.ClubCloud_Setting.ToList();
    
    				if(result == null || result.Count == 0 || refresh)
    					result = GetSettingsForVerenigingById(settings.Id.ToString(), Id, refresh, settings);
    
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
    
    		return new List<ClubCloud_Setting>();	
    	}
    
    	public bool SetSettingsForVereniging(List<ClubCloud_Setting> Settings, ClubCloud_Vereniging entity, bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		bool succes = false;
    		ClubCloud_Vereniging result = null;
    
    		using (new SPMonitoredScope("Verenigingen SetSettingsForVereniging"))
    		{
    
    			try
    			{			
    				entity = beheerModel.ClubCloud_Verenigingen.Find(entity.Id);
    		
    				if (entity != null)
    					beheerModel.Entry(entity).Collection(e => e.ClubCloud_Setting).Load();
    					//result = GetVerenigingById(settings.Id.ToString(), Id, refresh, settings);
    
    				if (result != null)
    					//return result.ClubCloud_Verenigingen.Count == ;
    
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
    
    
    
    	public List<ClubCloud_Baanschema> GetBaanschemasForVereniging(ClubCloud_Vereniging entity, bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		List<ClubCloud_Baanschema> result = null;
    
    		using (new SPMonitoredScope("Verenigingen GetBaanschemasForVereniging"))
    		{
    
    			try
    			{
    				entity = beheerModel.ClubCloud_Verenigingen.Find(entity.Id);
    				if(entity != null && entity.ClubCloud_Baanschema != null && entity.ClubCloud_Baanschema.Count == 0)
    					beheerModel.Entry(entity).Collection(e => e.ClubCloud_Baanschema).Load();
    
    				if(entity != null)
    					result = entity.ClubCloud_Baanschema.ToList();
    
    				if(result == null || result.Count == 0 || refresh && entity != null)
    					result = GetBaanschemasForVereniging(settings.Id.ToString(), entity, refresh, settings);
    
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
    
    		return new List<ClubCloud_Baanschema>();
    	}
    
    
    	public List<ClubCloud_Baanschema> GetBaanschemasForVerenigingById(System.Guid Id, bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		ClubCloud_Vereniging entity = null;
    		List<ClubCloud_Baanschema> result = null;
    
    		using (new SPMonitoredScope("Verenigingen GetBaanschemasForVerenigingById"))
    		{
    
    			try
    			{
    				entity = beheerModel.ClubCloud_Verenigingen.Find(Id);
    				if(entity != null && entity.ClubCloud_Baanschema != null && entity.ClubCloud_Baanschema.Count == 0)
    					beheerModel.Entry(entity).Collection(e => e.ClubCloud_Baanschema).Load();
    
    				if(entity != null)
    					result = entity.ClubCloud_Baanschema.ToList();
    
    				if(result == null || result.Count == 0 || refresh)
    					result = GetBaanschemasForVerenigingById(settings.Id.ToString(), Id, refresh, settings);
    
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
    
    		return new List<ClubCloud_Baanschema>();	
    	}
    
    	public bool SetBaanschemasForVereniging(List<ClubCloud_Baanschema> Baanschemas, ClubCloud_Vereniging entity, bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		bool succes = false;
    		ClubCloud_Vereniging result = null;
    
    		using (new SPMonitoredScope("Verenigingen SetBaanschemasForVereniging"))
    		{
    
    			try
    			{			
    				entity = beheerModel.ClubCloud_Verenigingen.Find(entity.Id);
    		
    				if (entity != null)
    					beheerModel.Entry(entity).Collection(e => e.ClubCloud_Baanschema).Load();
    					//result = GetVerenigingById(settings.Id.ToString(), Id, refresh, settings);
    
    				if (result != null)
    					//return result.ClubCloud_Verenigingen.Count == ;
    
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
    
    
    
    	public List<ClubCloud_Lidmaatschapsoort> GetLidmaatschapsoortenForVereniging(ClubCloud_Vereniging entity, bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		List<ClubCloud_Lidmaatschapsoort> result = null;
    
    		using (new SPMonitoredScope("Verenigingen GetLidmaatschapsoortenForVereniging"))
    		{
    
    			try
    			{
    				entity = beheerModel.ClubCloud_Verenigingen.Find(entity.Id);
    				if(entity != null && entity.ClubCloud_Lidmaatschapsoort != null && entity.ClubCloud_Lidmaatschapsoort.Count == 0)
    					beheerModel.Entry(entity).Collection(e => e.ClubCloud_Lidmaatschapsoort).Load();
    
    				if(entity != null)
    					result = entity.ClubCloud_Lidmaatschapsoort.ToList();
    
    				if(result == null || result.Count == 0 || refresh && entity != null)
    					result = GetLidmaatschapsoortenForVereniging(settings.Id.ToString(), entity, refresh, settings);
    
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
    
    		return new List<ClubCloud_Lidmaatschapsoort>();
    	}
    
    
    	public List<ClubCloud_Lidmaatschapsoort> GetLidmaatschapsoortenForVerenigingById(System.Guid Id, bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		ClubCloud_Vereniging entity = null;
    		List<ClubCloud_Lidmaatschapsoort> result = null;
    
    		using (new SPMonitoredScope("Verenigingen GetLidmaatschapsoortenForVerenigingById"))
    		{
    
    			try
    			{
    				entity = beheerModel.ClubCloud_Verenigingen.Find(Id);
    				if(entity != null && entity.ClubCloud_Lidmaatschapsoort != null && entity.ClubCloud_Lidmaatschapsoort.Count == 0)
    					beheerModel.Entry(entity).Collection(e => e.ClubCloud_Lidmaatschapsoort).Load();
    
    				if(entity != null)
    					result = entity.ClubCloud_Lidmaatschapsoort.ToList();
    
    				if(result == null || result.Count == 0 || refresh)
    					result = GetLidmaatschapsoortenForVerenigingById(settings.Id.ToString(), Id, refresh, settings);
    
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
    
    		return new List<ClubCloud_Lidmaatschapsoort>();	
    	}
    
    	public bool SetLidmaatschapsoortenForVereniging(List<ClubCloud_Lidmaatschapsoort> Lidmaatschapsoorten, ClubCloud_Vereniging entity, bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		bool succes = false;
    		ClubCloud_Vereniging result = null;
    
    		using (new SPMonitoredScope("Verenigingen SetLidmaatschapsoortenForVereniging"))
    		{
    
    			try
    			{			
    				entity = beheerModel.ClubCloud_Verenigingen.Find(entity.Id);
    		
    				if (entity != null)
    					beheerModel.Entry(entity).Collection(e => e.ClubCloud_Lidmaatschapsoort).Load();
    					//result = GetVerenigingById(settings.Id.ToString(), Id, refresh, settings);
    
    				if (result != null)
    					//return result.ClubCloud_Verenigingen.Count == ;
    
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
    [KnownType(typeof(ClubCloud_Vereniging))]
    public partial class ClubCloud_Vereniging_View
    {
    	public ClubCloud_Vereniging_View()
    	{
    		this.ClubCloud_Vereniging = new HashSet<ClubCloud_Vereniging>();
    	}
    
    	[DataMember]
    	public int TotalRowCount { get; set; }
    
    	[DataMember]
    	public virtual ICollection<ClubCloud_Vereniging> ClubCloud_Vereniging { get; set; }
    
    }
    	
}

