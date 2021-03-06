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
    	public ClubCloud_Gebruiker GetGebruikerById(System.Guid Id , bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		ClubCloud_Gebruiker result = null;
    
    		using (new SPMonitoredScope("Gebruikers GetGebruikerById"))
    		{
    
    			try
    			{			
    				result = beheerModel.ClubCloud_Gebruikers.Find(Id);
    		
    				if (result == null || refresh)
    					result = GetGebruikerById(settings.Id.ToString(), Id, refresh, settings);
    
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
    
    		return new ClubCloud_Gebruiker();
    	}
    
    	public List<ClubCloud_Gebruiker> GetGebruikers(bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		List<ClubCloud_Gebruiker> result = null;
    
    		using (new SPMonitoredScope("Gebruikers GetGebruikers"))
    		{
    		
    			try
    			{
    				result = beheerModel.ClubCloud_Gebruikers.ToList<ClubCloud_Gebruiker>();
    		
    				if (result == null || result.Count == 0 || refresh)		
    					result = GetGebruikers(settings.Id.ToString(), refresh, settings);
    
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
    
    		return new List<ClubCloud_Gebruiker>();
    	}
    
    	public ClubCloud_Gebruiker SetGebruiker(ClubCloud_Gebruiker entity, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		ClubCloud_Gebruiker tobeupdated = null;
    		
    		using (new SPMonitoredScope("Gebruikers SetGebruiker"))
    		{
    
    			try
    			{
    				entity = SetGebruiker(settings.Id.ToString(), entity, settings);
    
    				if(entity != null)
    					beheerModel.ClubCloud_Gebruikers.AddOrUpdate(entity);
    		
    				beheerModel.SaveChanges();
    
    				tobeupdated = beheerModel.ClubCloud_Gebruikers.Find(entity.Id);
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
    
    
    	public bool DeleteGebruiker(ClubCloud_Gebruiker entity, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		return DeleteGebruikerById(entity.Id, settings);
    	}
    
    	public bool DeleteGebruikerById(System.Guid Id, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		bool succes = false;
    		ClubCloud_Gebruiker tobedeleted = null;
    
    		using (new SPMonitoredScope("Gebruikers DeleteGebruikerById"))
    		{
    
    			try
    			{
    
    				tobedeleted = beheerModel.ClubCloud_Gebruikers.Find(Id);
    		
    				if (tobedeleted != null)
    				{
    					beheerModel.ClubCloud_Gebruikers.Remove(tobedeleted);
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
    
    
    	public ClubCloud_Gebruiker_View GetGebruikersByQuery(string bondsnummer, Guid verenigingId,System.Web.UI.DataSourceSelectArguments selectArgs = null, List<System.Web.UI.WebControls.Parameter> parameters = null, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		ClubCloud_Gebruiker_View view = new ClubCloud_Gebruiker_View();
    
    		using (new SPMonitoredScope("Gebruikers GetGebruikersByQuery"))
    		{
    
    			StringBuilder querybuilder = new StringBuilder("SELECT * FROM dbo.ClubCloud_Gebruiker");
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
    
    			view.ClubCloud_Gebruiker = beheerModel.Database.SqlQuery<ClubCloud_Gebruiker>(querybuilder.ToString(), sqlparams.ToArray()).Skip(selectArgs.StartRowIndex).Take(selectArgs.MaximumRows).ToList<ClubCloud_Gebruiker>();
    
    			if (selectArgs.RetrieveTotalRowCount)
    			{
    
    				view.TotalRowCount = beheerModel.Database.SqlQuery<ClubCloud_Gebruiker>(querybuilder.ToString(), sqlparamscount.ToArray()).Count();
    			}
    		}
    
    		return view;
    	}
    
    	public List<ClubCloud_Gebruiker> GetGebruikersBySearch(string prefixText, int count, string contextKey, ClubCloud_Setting _settings = null)
    	{
    		if(_settings != null)
    			ValidateSettings(ref _settings);
    
            List<string> gebruikers = new List<string>();
    
    		using (new SPMonitoredScope("Gebruikers GetGebruikersBySearch"))
    		{
    
    			try
    			{
    				bool enabled = false; //beheerModel.Database.SqlQuery<bool>("SELECT (CAST((FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))AS BIT))").FirstOrDefault();
    
    				List<ClubCloud_Gebruiker> entities = null;
    
    				if (enabled)
    				{
    					var fts = BeheerFullTextInterceptor.Fts(prefixText);
    				
    		
    				entities = beheerModel.ClubCloud_Gebruikers.Where(e => e.Beschrijving.Contains(fts)  || e.Bondsnummer.Contains(fts)  || e.Roepnaam.Contains(fts)  || e.Aanhef.Contains(fts)  || e.Voornaam.Contains(fts)  || e.Voornamen.Contains(fts)  || e.Achtervoegsel.Contains(fts)  || e.Tussenvoegsel.Contains(fts)  || e.Achternaam.Contains(fts)  || e.Voorletters.Contains(fts)  || e.EmailKNLTB.Contains(fts)  || e.EmailWebSite.Contains(fts)  || e.EmailOverig.Contains(fts)  || e.TelefoonAvond.Contains(fts)  || e.TelefoonOverdag.Contains(fts)  || e.TelefoonOverig.Contains(fts)  || e.Mobiel.Contains(fts)  || e.Fax.Contains(fts)  || e.BankNummer.Contains(fts)  || e.BankIban.Contains(fts)  || e.BankPlaats.Contains(fts)  || e.Geboorteplaats.Contains(fts)  || e.Website.Contains(fts)  || e.FTPsite.Contains(fts)  || e.Beroep.Contains(fts)  || e.Partner.Contains(fts)  || e.AanhefBrief.Contains(fts)  || e.AanhefAttentie.Contains(fts)  || e.Volledigenaam.Contains(fts) ).ToList();
    
    					
    				}
    				else
    				{
    	
    				entities = beheerModel.Database.SqlQuery<ClubCloud_Gebruiker>("SELECT * FROM ClubCloud_Gebruiker WHERE  Beschrijving LIKE '%"+ prefixText +"%' OR  Bondsnummer LIKE '%"+ prefixText +"%' OR  Roepnaam LIKE '%"+ prefixText +"%' OR  Aanhef LIKE '%"+ prefixText +"%' OR  Voornaam LIKE '%"+ prefixText +"%' OR  Voornamen LIKE '%"+ prefixText +"%' OR  Achtervoegsel LIKE '%"+ prefixText +"%' OR  Tussenvoegsel LIKE '%"+ prefixText +"%' OR  Achternaam LIKE '%"+ prefixText +"%' OR  Voorletters LIKE '%"+ prefixText +"%' OR  EmailKNLTB LIKE '%"+ prefixText +"%' OR  EmailWebSite LIKE '%"+ prefixText +"%' OR  EmailOverig LIKE '%"+ prefixText +"%' OR  TelefoonAvond LIKE '%"+ prefixText +"%' OR  TelefoonOverdag LIKE '%"+ prefixText +"%' OR  TelefoonOverig LIKE '%"+ prefixText +"%' OR  Mobiel LIKE '%"+ prefixText +"%' OR  Fax LIKE '%"+ prefixText +"%' OR  BankNummer LIKE '%"+ prefixText +"%' OR  BankIban LIKE '%"+ prefixText +"%' OR  BankPlaats LIKE '%"+ prefixText +"%' OR  Geboorteplaats LIKE '%"+ prefixText +"%' OR  Website LIKE '%"+ prefixText +"%' OR  FTPsite LIKE '%"+ prefixText +"%' OR  Beroep LIKE '%"+ prefixText +"%' OR  Partner LIKE '%"+ prefixText +"%' OR  AanhefBrief LIKE '%"+ prefixText +"%' OR  AanhefAttentie LIKE '%"+ prefixText +"%' OR  Volledigenaam LIKE '%"+ prefixText +"%'").ToList();
    
    					
    				}
    
    				if (entities != null && entities.Count > 0)
    					return entities;
    			}
    			catch (Exception ex)
    			{
    				Logger.WriteLog(Logger.Category.Unexpected, ex.Source, ex.Message);
    			}
    		}
    
            return new List<ClubCloud_Gebruiker>();
    	}
    
    
    	public List<ClubCloud_Functionaris> GetFunctionarissenForGebruiker(ClubCloud_Gebruiker entity, bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		List<ClubCloud_Functionaris> result = null;
    
    		using (new SPMonitoredScope("Gebruikers GetFunctionarissenForGebruiker"))
    		{
    
    			try
    			{
    				entity = beheerModel.ClubCloud_Gebruikers.Find(entity.Id);
    				if(entity != null && entity.ClubCloud_Functionaris != null && entity.ClubCloud_Functionaris.Count == 0)
    					beheerModel.Entry(entity).Collection(e => e.ClubCloud_Functionaris).Load();
    
    				if(entity != null)
    					result = entity.ClubCloud_Functionaris.ToList();
    
    				if(result == null || result.Count == 0 || refresh && entity != null)
    					result = GetFunctionarissenForGebruiker(settings.Id.ToString(), entity, refresh, settings);
    
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
    
    
    	public List<ClubCloud_Functionaris> GetFunctionarissenForGebruikerById(System.Guid Id, bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		ClubCloud_Gebruiker entity = null;
    		List<ClubCloud_Functionaris> result = null;
    
    		using (new SPMonitoredScope("Gebruikers GetFunctionarissenForGebruikerById"))
    		{
    
    			try
    			{
    				entity = beheerModel.ClubCloud_Gebruikers.Find(Id);
    				if(entity != null && entity.ClubCloud_Functionaris != null && entity.ClubCloud_Functionaris.Count == 0)
    					beheerModel.Entry(entity).Collection(e => e.ClubCloud_Functionaris).Load();
    
    				if(entity != null)
    					result = entity.ClubCloud_Functionaris.ToList();
    
    				if(result == null || result.Count == 0 || refresh)
    					result = GetFunctionarissenForGebruikerById(settings.Id.ToString(), Id, refresh, settings);
    
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
    
    	public bool SetFunctionarissenForGebruiker(List<ClubCloud_Functionaris> Functionarissen, ClubCloud_Gebruiker entity, bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		bool succes = false;
    		ClubCloud_Gebruiker result = null;
    
    		using (new SPMonitoredScope("Gebruikers SetFunctionarissenForGebruiker"))
    		{
    
    			try
    			{			
    				entity = beheerModel.ClubCloud_Gebruikers.Find(entity.Id);
    		
    				if (entity != null)
    					beheerModel.Entry(entity).Collection(e => e.ClubCloud_Functionaris).Load();
    					//result = GetGebruikerById(settings.Id.ToString(), Id, refresh, settings);
    
    				if (result != null)
    					//return result.ClubCloud_Gebruikers.Count == ;
    
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
    
    
    
    	public List<ClubCloud_Lidmaatschap> GetLidmaatschappenForGebruiker(ClubCloud_Gebruiker entity, bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		List<ClubCloud_Lidmaatschap> result = null;
    
    		using (new SPMonitoredScope("Gebruikers GetLidmaatschappenForGebruiker"))
    		{
    
    			try
    			{
    				entity = beheerModel.ClubCloud_Gebruikers.Find(entity.Id);
    				if(entity != null && entity.ClubCloud_Lidmaatschap != null && entity.ClubCloud_Lidmaatschap.Count == 0)
    					beheerModel.Entry(entity).Collection(e => e.ClubCloud_Lidmaatschap).Load();
    
    				if(entity != null)
    					result = entity.ClubCloud_Lidmaatschap.ToList();
    
    				if(result == null || result.Count == 0 || refresh && entity != null)
    					result = GetLidmaatschappenForGebruiker(settings.Id.ToString(), entity, refresh, settings);
    
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
    
    
    	public List<ClubCloud_Lidmaatschap> GetLidmaatschappenForGebruikerById(System.Guid Id, bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		ClubCloud_Gebruiker entity = null;
    		List<ClubCloud_Lidmaatschap> result = null;
    
    		using (new SPMonitoredScope("Gebruikers GetLidmaatschappenForGebruikerById"))
    		{
    
    			try
    			{
    				entity = beheerModel.ClubCloud_Gebruikers.Find(Id);
    				if(entity != null && entity.ClubCloud_Lidmaatschap != null && entity.ClubCloud_Lidmaatschap.Count == 0)
    					beheerModel.Entry(entity).Collection(e => e.ClubCloud_Lidmaatschap).Load();
    
    				if(entity != null)
    					result = entity.ClubCloud_Lidmaatschap.ToList();
    
    				if(result == null || result.Count == 0 || refresh)
    					result = GetLidmaatschappenForGebruikerById(settings.Id.ToString(), Id, refresh, settings);
    
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
    
    	public bool SetLidmaatschappenForGebruiker(List<ClubCloud_Lidmaatschap> Lidmaatschappen, ClubCloud_Gebruiker entity, bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		bool succes = false;
    		ClubCloud_Gebruiker result = null;
    
    		using (new SPMonitoredScope("Gebruikers SetLidmaatschappenForGebruiker"))
    		{
    
    			try
    			{			
    				entity = beheerModel.ClubCloud_Gebruikers.Find(entity.Id);
    		
    				if (entity != null)
    					beheerModel.Entry(entity).Collection(e => e.ClubCloud_Lidmaatschap).Load();
    					//result = GetGebruikerById(settings.Id.ToString(), Id, refresh, settings);
    
    				if (result != null)
    					//return result.ClubCloud_Gebruikers.Count == ;
    
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
    
    
    
    	public List<ClubCloud_Address> GetAddressenForGebruiker(ClubCloud_Gebruiker entity, bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		List<ClubCloud_Address> result = null;
    
    		using (new SPMonitoredScope("Gebruikers GetAddressenForGebruiker"))
    		{
    
    			try
    			{
    				entity = beheerModel.ClubCloud_Gebruikers.Find(entity.Id);
    				if(entity != null && entity.ClubCloud_Address != null && entity.ClubCloud_Address.Count == 0)
    					beheerModel.Entry(entity).Collection(e => e.ClubCloud_Address).Load();
    
    				if(entity != null)
    					result = entity.ClubCloud_Address.ToList();
    
    				if(result == null || result.Count == 0 || refresh && entity != null)
    					result = GetAddressenForGebruiker(settings.Id.ToString(), entity, refresh, settings);
    
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
    
    
    	public List<ClubCloud_Address> GetAddressenForGebruikerById(System.Guid Id, bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		ClubCloud_Gebruiker entity = null;
    		List<ClubCloud_Address> result = null;
    
    		using (new SPMonitoredScope("Gebruikers GetAddressenForGebruikerById"))
    		{
    
    			try
    			{
    				entity = beheerModel.ClubCloud_Gebruikers.Find(Id);
    				if(entity != null && entity.ClubCloud_Address != null && entity.ClubCloud_Address.Count == 0)
    					beheerModel.Entry(entity).Collection(e => e.ClubCloud_Address).Load();
    
    				if(entity != null)
    					result = entity.ClubCloud_Address.ToList();
    
    				if(result == null || result.Count == 0 || refresh)
    					result = GetAddressenForGebruikerById(settings.Id.ToString(), Id, refresh, settings);
    
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
    
    	public bool SetAddressenForGebruiker(List<ClubCloud_Address> Addressen, ClubCloud_Gebruiker entity, bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		bool succes = false;
    		ClubCloud_Gebruiker result = null;
    
    		using (new SPMonitoredScope("Gebruikers SetAddressenForGebruiker"))
    		{
    
    			try
    			{			
    				entity = beheerModel.ClubCloud_Gebruikers.Find(entity.Id);
    		
    				if (entity != null)
    					beheerModel.Entry(entity).Collection(e => e.ClubCloud_Address).Load();
    					//result = GetGebruikerById(settings.Id.ToString(), Id, refresh, settings);
    
    				if (result != null)
    					//return result.ClubCloud_Gebruikers.Count == ;
    
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
    
    
    
    	public ClubCloud_Vereniging GetVerenigingForGebruiker(ClubCloud_Gebruiker entity, bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		ClubCloud_Vereniging result = null;
    
    		using (new SPMonitoredScope("Gebruikers GetVerenigingForGebruiker"))
    		{
    
    			try
    			{
    				entity = beheerModel.ClubCloud_Gebruikers.Find(entity.Id);
    				if(entity != null && entity.ClubCloud_Vereniging == null)
    					beheerModel.Entry(entity).Reference(e => e.ClubCloud_Vereniging).Load();
    
    				if(entity != null)
    					result = entity.ClubCloud_Vereniging;
    
    				if (result == null || refresh && entity != null)
    					result = GetVerenigingForGebruiker(settings.Id.ToString(), entity, refresh, settings);
    
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
    
    	public bool SetVerenigingForGebruiker(ClubCloud_Vereniging Vereniging, ClubCloud_Gebruiker entity , bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		bool succes = false;
    
    		using (new SPMonitoredScope("Gebruikers SetVerenigingForGebruiker"))
    		{
    
    			try
    			{		
    				entity = beheerModel.ClubCloud_Gebruikers.Find(entity.Id);	
    
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
    
    
    	public ClubCloud_Vereniging GetVerenigingForGebruikerById(System.Guid Id, bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		ClubCloud_Gebruiker entity = null;
    		ClubCloud_Vereniging result = null;
    
    		using (new SPMonitoredScope("Gebruikers GetVerenigingForGebruikerById"))
    		{
    
    			try
    			{
    				entity = beheerModel.ClubCloud_Gebruikers.Find(Id);
    				if(entity != null && entity.ClubCloud_Vereniging == null)
    					beheerModel.Entry(entity).Reference(e => e.ClubCloud_Vereniging).Load();
    
    				if(entity != null)
    					result = entity.ClubCloud_Vereniging;
    
    				if (result == null || refresh)
    					result = GetVerenigingForGebruikerById(settings.Id.ToString(), Id, refresh, settings);
    
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
    
    	public bool SetVerenigingForGebruikerById(ClubCloud_Vereniging Vereniging, System.Guid Id , bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		ClubCloud_Gebruiker entity = null;
    		bool succes = false;
    
    		using (new SPMonitoredScope("Gebruikers SetVerenigingForGebruikerById"))
    		{
    
    			try
    			{		
    				entity = beheerModel.ClubCloud_Gebruikers.Find(Id);	
    
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
    
    
    	public List<ClubCloud_Profiel> GetProfielenForGebruiker(ClubCloud_Gebruiker entity, bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		List<ClubCloud_Profiel> result = null;
    
    		using (new SPMonitoredScope("Gebruikers GetProfielenForGebruiker"))
    		{
    
    			try
    			{
    				entity = beheerModel.ClubCloud_Gebruikers.Find(entity.Id);
    				if(entity != null && entity.ClubCloud_Profiel != null && entity.ClubCloud_Profiel.Count == 0)
    					beheerModel.Entry(entity).Collection(e => e.ClubCloud_Profiel).Load();
    
    				if(entity != null)
    					result = entity.ClubCloud_Profiel.ToList();
    
    				if(result == null || result.Count == 0 || refresh && entity != null)
    					result = GetProfielenForGebruiker(settings.Id.ToString(), entity, refresh, settings);
    
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
    
    		return new List<ClubCloud_Profiel>();
    	}
    
    
    	public List<ClubCloud_Profiel> GetProfielenForGebruikerById(System.Guid Id, bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		ClubCloud_Gebruiker entity = null;
    		List<ClubCloud_Profiel> result = null;
    
    		using (new SPMonitoredScope("Gebruikers GetProfielenForGebruikerById"))
    		{
    
    			try
    			{
    				entity = beheerModel.ClubCloud_Gebruikers.Find(Id);
    				if(entity != null && entity.ClubCloud_Profiel != null && entity.ClubCloud_Profiel.Count == 0)
    					beheerModel.Entry(entity).Collection(e => e.ClubCloud_Profiel).Load();
    
    				if(entity != null)
    					result = entity.ClubCloud_Profiel.ToList();
    
    				if(result == null || result.Count == 0 || refresh)
    					result = GetProfielenForGebruikerById(settings.Id.ToString(), Id, refresh, settings);
    
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
    
    		return new List<ClubCloud_Profiel>();	
    	}
    
    	public bool SetProfielenForGebruiker(List<ClubCloud_Profiel> Profielen, ClubCloud_Gebruiker entity, bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		bool succes = false;
    		ClubCloud_Gebruiker result = null;
    
    		using (new SPMonitoredScope("Gebruikers SetProfielenForGebruiker"))
    		{
    
    			try
    			{			
    				entity = beheerModel.ClubCloud_Gebruikers.Find(entity.Id);
    		
    				if (entity != null)
    					beheerModel.Entry(entity).Collection(e => e.ClubCloud_Profiel).Load();
    					//result = GetGebruikerById(settings.Id.ToString(), Id, refresh, settings);
    
    				if (result != null)
    					//return result.ClubCloud_Gebruikers.Count == ;
    
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
    
    
    
    	public List<ClubCloud_Setting> GetSettingsForGebruiker(ClubCloud_Gebruiker entity, bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		List<ClubCloud_Setting> result = null;
    
    		using (new SPMonitoredScope("Gebruikers GetSettingsForGebruiker"))
    		{
    
    			try
    			{
    				entity = beheerModel.ClubCloud_Gebruikers.Find(entity.Id);
    				if(entity != null && entity.ClubCloud_Setting != null && entity.ClubCloud_Setting.Count == 0)
    					beheerModel.Entry(entity).Collection(e => e.ClubCloud_Setting).Load();
    
    				if(entity != null)
    					result = entity.ClubCloud_Setting.ToList();
    
    				if(result == null || result.Count == 0 || refresh && entity != null)
    					result = GetSettingsForGebruiker(settings.Id.ToString(), entity, refresh, settings);
    
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
    
    
    	public List<ClubCloud_Setting> GetSettingsForGebruikerById(System.Guid Id, bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		ClubCloud_Gebruiker entity = null;
    		List<ClubCloud_Setting> result = null;
    
    		using (new SPMonitoredScope("Gebruikers GetSettingsForGebruikerById"))
    		{
    
    			try
    			{
    				entity = beheerModel.ClubCloud_Gebruikers.Find(Id);
    				if(entity != null && entity.ClubCloud_Setting != null && entity.ClubCloud_Setting.Count == 0)
    					beheerModel.Entry(entity).Collection(e => e.ClubCloud_Setting).Load();
    
    				if(entity != null)
    					result = entity.ClubCloud_Setting.ToList();
    
    				if(result == null || result.Count == 0 || refresh)
    					result = GetSettingsForGebruikerById(settings.Id.ToString(), Id, refresh, settings);
    
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
    
    	public bool SetSettingsForGebruiker(List<ClubCloud_Setting> Settings, ClubCloud_Gebruiker entity, bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		bool succes = false;
    		ClubCloud_Gebruiker result = null;
    
    		using (new SPMonitoredScope("Gebruikers SetSettingsForGebruiker"))
    		{
    
    			try
    			{			
    				entity = beheerModel.ClubCloud_Gebruikers.Find(entity.Id);
    		
    				if (entity != null)
    					beheerModel.Entry(entity).Collection(e => e.ClubCloud_Setting).Load();
    					//result = GetGebruikerById(settings.Id.ToString(), Id, refresh, settings);
    
    				if (result != null)
    					//return result.ClubCloud_Gebruikers.Count == ;
    
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
    
    
    
    	public ClubCloud_Nationaliteit GetNationaliteitForGebruiker(ClubCloud_Gebruiker entity, bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		ClubCloud_Nationaliteit result = null;
    
    		using (new SPMonitoredScope("Gebruikers GetNationaliteitForGebruiker"))
    		{
    
    			try
    			{
    				entity = beheerModel.ClubCloud_Gebruikers.Find(entity.Id);
    				if(entity != null && entity.ClubCloud_Nationaliteit == null)
    					beheerModel.Entry(entity).Reference(e => e.ClubCloud_Nationaliteit).Load();
    
    				if(entity != null)
    					result = entity.ClubCloud_Nationaliteit;
    
    				if (result == null || refresh && entity != null)
    					result = GetNationaliteitForGebruiker(settings.Id.ToString(), entity, refresh, settings);
    
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
    
    		return new ClubCloud_Nationaliteit();
    	}
    
    	public bool SetNationaliteitForGebruiker(ClubCloud_Nationaliteit Nationaliteit, ClubCloud_Gebruiker entity , bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		bool succes = false;
    
    		using (new SPMonitoredScope("Gebruikers SetNationaliteitForGebruiker"))
    		{
    
    			try
    			{		
    				entity = beheerModel.ClubCloud_Gebruikers.Find(entity.Id);	
    
    				if(entity != null && entity.ClubCloud_Nationaliteit == null)
    					beheerModel.Entry(entity).Reference(e => e.ClubCloud_Nationaliteit).Load();
    
    				if(entity != null)
    					entity.ClubCloud_Nationaliteit = Nationaliteit;
    
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
    
    
    	public ClubCloud_Nationaliteit GetNationaliteitForGebruikerById(System.Guid Id, bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		ClubCloud_Gebruiker entity = null;
    		ClubCloud_Nationaliteit result = null;
    
    		using (new SPMonitoredScope("Gebruikers GetNationaliteitForGebruikerById"))
    		{
    
    			try
    			{
    				entity = beheerModel.ClubCloud_Gebruikers.Find(Id);
    				if(entity != null && entity.ClubCloud_Nationaliteit == null)
    					beheerModel.Entry(entity).Reference(e => e.ClubCloud_Nationaliteit).Load();
    
    				if(entity != null)
    					result = entity.ClubCloud_Nationaliteit;
    
    				if (result == null || refresh)
    					result = GetNationaliteitForGebruikerById(settings.Id.ToString(), Id, refresh, settings);
    
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
    
    		return new ClubCloud_Nationaliteit();
    	}
    
    	public bool SetNationaliteitForGebruikerById(ClubCloud_Nationaliteit Nationaliteit, System.Guid Id , bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		ClubCloud_Gebruiker entity = null;
    		bool succes = false;
    
    		using (new SPMonitoredScope("Gebruikers SetNationaliteitForGebruikerById"))
    		{
    
    			try
    			{		
    				entity = beheerModel.ClubCloud_Gebruikers.Find(Id);	
    
    				if(entity != null && entity.ClubCloud_Nationaliteit == null)
    					beheerModel.Entry(entity).Reference(e => e.ClubCloud_Nationaliteit).Load();
    
    				if(entity != null)
    					entity.ClubCloud_Nationaliteit = Nationaliteit;
    
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
    [KnownType(typeof(ClubCloud_Gebruiker))]
    public partial class ClubCloud_Gebruiker_View
    {
    	public ClubCloud_Gebruiker_View()
    	{
    		this.ClubCloud_Gebruiker = new HashSet<ClubCloud_Gebruiker>();
    	}
    
    	[DataMember]
    	public int TotalRowCount { get; set; }
    
    	[DataMember]
    	public virtual ICollection<ClubCloud_Gebruiker> ClubCloud_Gebruiker { get; set; }
    
    }
    	
}

