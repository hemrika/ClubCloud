namespace ClubCloud.Service
{
    using ClubCloud.Model;
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
    	public ClubCloud_Address GetAddressById(System.Guid Id , bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		ClubCloud_Address result = null;
    
    		try
    		{			
    			result = beheerModel.ClubCloud_Addressen.Find(Id);
    		
    			if (result == null || refresh)
    				result = GetAddressById(settings.Id.ToString(), Id, refresh, settings);
    
    			if (result != null)
    				return result;
    
    			return new ClubCloud_Address();
            }
            finally
            {
    			if(result != null)
    				try { beheerModel.ObjectContext.Detach(result);} catch{}
            }
    
    	}
    
    	public List<ClubCloud_Address> GetAddressen(bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		List<ClubCloud_Address> result = null;
    		
    		try
    		{
    			result = beheerModel.ClubCloud_Addressen.ToList<ClubCloud_Address>();
    		
    			if (result == null || result.Count == 0 || refresh)		
    				result = GetAddressen(settings.Id.ToString(), refresh, settings);
    
    			if(result != null)
    				return result;
    
    			return new List<ClubCloud_Address>();
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
    
    	public ClubCloud_Address SetAddress(ClubCloud_Address entity, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		ClubCloud_Address tobeupdated = null;
    		
    		try
    		{
    			entity = SetAddress(settings.Id.ToString(), entity, settings);
    
    			beheerModel.ClubCloud_Addressen.AddOrUpdate(entity);
    		
    			beheerModel.SaveChanges();
    
    			tobeupdated = beheerModel.ClubCloud_Addressen.Find(entity.Id);
    			return tobeupdated;
            }
            finally
            {
    			if(tobeupdated != null)
    				try { beheerModel.ObjectContext.Detach(tobeupdated); } catch{}
            }
    
    	}
    
    
    	public bool DeleteAddress(ClubCloud_Address entity, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		return DeleteAddressById(entity.Id, settings);
    	}
    
    	public bool DeleteAddressById(System.Guid Id, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		ClubCloud_Address tobedeleted = null;
    		try
    		{
    
    			tobedeleted = beheerModel.ClubCloud_Addressen.Find(Id);
    		
    			if (tobedeleted != null)
    			{
    				beheerModel.ClubCloud_Addressen.Remove(tobedeleted);
    				beheerModel.SaveChanges();
    			}
    			return true;
    		}
            finally
            {
    			if(tobedeleted != null)
    				try { beheerModel.ObjectContext.Detach(tobedeleted); } catch{}
            }
    
    		return false;
    	}
    
    
    	public ClubCloud_Address_View GetAddressenByQuery(string bondsnummer, Guid verenigingId,System.Web.UI.DataSourceSelectArguments selectArgs = null, List<System.Web.UI.WebControls.Parameter> parameters = null, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		ClubCloud_Address_View view = new ClubCloud_Address_View();
    
    		StringBuilder querybuilder = new StringBuilder("SELECT * FROM dbo.ClubCloud_Address");
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
    
    		view.ClubCloud_Address = beheerModel.Database.SqlQuery<ClubCloud_Address>(querybuilder.ToString(), sqlparams.ToArray()).Skip(selectArgs.StartRowIndex).Take(selectArgs.MaximumRows).ToList<ClubCloud_Address>();
    
    		if (selectArgs.RetrieveTotalRowCount)
    		{
    
    			view.TotalRowCount = beheerModel.Database.SqlQuery<ClubCloud_Address>(querybuilder.ToString(), sqlparamscount.ToArray()).Count();
    		}
    		return view;
    	}
    
    	public List<ClubCloud_Address> GetAddressenBySearch(string prefixText, int count, string contextKey, ClubCloud_Setting _settings = null)
    	{
    		if(_settings != null)
    			ValidateSettings(ref _settings);
    
            List<string> addressen = new List<string>();
            try
            {
                bool enabled = beheerModel.Database.SqlQuery<bool>("SELECT (CAST((FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))AS BIT))").FirstOrDefault();
    
                List<ClubCloud_Address> entities = null;
    
                if (enabled)
                {
                    var fts = BeheerFullTextInterceptor.Fts(prefixText);
    				
    
    			entities = beheerModel.ClubCloud_Addressen.Where(e => e.Stad.Contains(fts)  || e.Provincie.Contains(fts)  || e.Postcode.Contains(fts)  || e.Straat.Contains(fts)  || e.Nummer.Contains(fts)  || e.Actief.Contains(fts)  || e.Fax.Contains(fts)  || e.Toevoeging.Contains(fts)  || e.Postbus.Contains(fts)  || e.TelefoonPrimair.Contains(fts)  || e.TelefoonSecundair.Contains(fts)  || e.TelefoonTertiair.Contains(fts)  || e.Gemeente.Contains(fts) ).ToList();
    
    				
                }
    			else
    			{
    
    			entities = beheerModel.Database.SqlQuery<ClubCloud_Address>("SELECT * FROM ClubCloud_Address WHERE  Stad LIKE '%"+ prefixText +"%' OR  Provincie LIKE '%"+ prefixText +"%' OR  Postcode LIKE '%"+ prefixText +"%' OR  Straat LIKE '%"+ prefixText +"%' OR  Nummer LIKE '%"+ prefixText +"%' OR  Actief LIKE '%"+ prefixText +"%' OR  Fax LIKE '%"+ prefixText +"%' OR  Toevoeging LIKE '%"+ prefixText +"%' OR  Postbus LIKE '%"+ prefixText +"%' OR  TelefoonPrimair LIKE '%"+ prefixText +"%' OR  TelefoonSecundair LIKE '%"+ prefixText +"%' OR  TelefoonTertiair LIKE '%"+ prefixText +"%' OR  Gemeente LIKE '%"+ prefixText +"%'").ToList();
    
    				
    			}
    
    			if (entities != null && entities.Count > 0)
    				return entities;
            }
            catch { };
    
            return new List<ClubCloud_Address>();
    	}
    
    
    	public ClubCloud_Vereniging GetVerenigingForAddress(ClubCloud_Address entity, bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		ClubCloud_Vereniging result = null;
    
    		try
    		{
    			entity = beheerModel.ClubCloud_Addressen.Find(entity.Id);
    			if(entity != null && entity.ClubCloud_Vereniging == null)
    				beheerModel.Entry(entity).Reference(e => e.ClubCloud_Vereniging).Load();
    
    			result = entity.ClubCloud_Vereniging;
    
    			if (result == null || refresh)
    				result = GetVerenigingForAddress(settings.Id.ToString(), entity, refresh, settings);
    
    			if (result != null)
    				return result;
    
    			return new ClubCloud_Vereniging();
    		}
            finally
            {
    			if(entity != null)
    				try { beheerModel.ObjectContext.Detach(entity); } catch{}
                if(result != null)
    				try { beheerModel.ObjectContext.Detach(result); } catch{}
            }
    
    	}
    
    	public bool SetVerenigingForAddress(ClubCloud_Vereniging Vereniging, ClubCloud_Address entity , bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		try
    		{		
    			entity = beheerModel.ClubCloud_Addressen.Find(entity.Id);	
    
    			if(entity != null && entity.ClubCloud_Vereniging == null)
    				beheerModel.Entry(entity).Reference(e => e.ClubCloud_Vereniging).Load();
    
    			entity.ClubCloud_Vereniging = Vereniging;
    
    			beheerModel.SaveChanges();
    			return true;
            }
            finally
            {
    			if(entity != null)
    				try { beheerModel.ObjectContext.Detach(entity); } catch{}
            }
    		return false;
    	}
    
    
    	public ClubCloud_Vereniging GetVerenigingForAddressById(System.Guid Id, bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		ClubCloud_Address entity = null;
    		ClubCloud_Vereniging result = null;
    
    		try
    		{
    			entity = beheerModel.ClubCloud_Addressen.Find(Id);
    			if(entity != null && entity.ClubCloud_Vereniging == null)
    				beheerModel.Entry(entity).Reference(e => e.ClubCloud_Vereniging).Load();
    
    			result = entity.ClubCloud_Vereniging;
    
    			if (result == null || refresh)
    				result = GetVerenigingForAddressById(settings.Id.ToString(), Id, refresh, settings);
    
    			if (result != null)
    				return result;
    
    			return new ClubCloud_Vereniging();
    		}
            finally
            {
    			if(entity != null)
    				try { beheerModel.ObjectContext.Detach(entity); } catch{}
                if(result != null)
    				try { beheerModel.ObjectContext.Detach(result); } catch{}
            }
    	}
    
    	public bool SetVerenigingForAddressById(ClubCloud_Vereniging Vereniging, System.Guid Id , bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		ClubCloud_Address entity = null;
    
    		try
    		{		
    			entity = beheerModel.ClubCloud_Addressen.Find(Id);	
    
    			if(entity != null && entity.ClubCloud_Vereniging == null)
    				beheerModel.Entry(entity).Reference(e => e.ClubCloud_Vereniging).Load();
    
    			entity.ClubCloud_Vereniging = Vereniging;
    
    			beheerModel.SaveChanges();
    			return true;
            }
            finally
            {
    			if(entity != null)
    				try { beheerModel.ObjectContext.Detach(entity); } catch{}
            }
    		return false;
    	}
    
    
    	public ClubCloud_Gebruiker GetGebruikerForAddress(ClubCloud_Address entity, bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		ClubCloud_Gebruiker result = null;
    
    		try
    		{
    			entity = beheerModel.ClubCloud_Addressen.Find(entity.Id);
    			if(entity != null && entity.ClubCloud_Gebruiker == null)
    				beheerModel.Entry(entity).Reference(e => e.ClubCloud_Gebruiker).Load();
    
    			result = entity.ClubCloud_Gebruiker;
    
    			if (result == null || refresh)
    				result = GetGebruikerForAddress(settings.Id.ToString(), entity, refresh, settings);
    
    			if (result != null)
    				return result;
    
    			return new ClubCloud_Gebruiker();
    		}
            finally
            {
    			if(entity != null)
    				try { beheerModel.ObjectContext.Detach(entity); } catch{}
                if(result != null)
    				try { beheerModel.ObjectContext.Detach(result); } catch{}
            }
    
    	}
    
    	public bool SetGebruikerForAddress(ClubCloud_Gebruiker Gebruiker, ClubCloud_Address entity , bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		try
    		{		
    			entity = beheerModel.ClubCloud_Addressen.Find(entity.Id);	
    
    			if(entity != null && entity.ClubCloud_Gebruiker == null)
    				beheerModel.Entry(entity).Reference(e => e.ClubCloud_Gebruiker).Load();
    
    			entity.ClubCloud_Gebruiker = Gebruiker;
    
    			beheerModel.SaveChanges();
    			return true;
            }
            finally
            {
    			if(entity != null)
    				try { beheerModel.ObjectContext.Detach(entity); } catch{}
            }
    		return false;
    	}
    
    
    	public ClubCloud_Gebruiker GetGebruikerForAddressById(System.Guid Id, bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		ClubCloud_Address entity = null;
    		ClubCloud_Gebruiker result = null;
    
    		try
    		{
    			entity = beheerModel.ClubCloud_Addressen.Find(Id);
    			if(entity != null && entity.ClubCloud_Gebruiker == null)
    				beheerModel.Entry(entity).Reference(e => e.ClubCloud_Gebruiker).Load();
    
    			result = entity.ClubCloud_Gebruiker;
    
    			if (result == null || refresh)
    				result = GetGebruikerForAddressById(settings.Id.ToString(), Id, refresh, settings);
    
    			if (result != null)
    				return result;
    
    			return new ClubCloud_Gebruiker();
    		}
            finally
            {
    			if(entity != null)
    				try { beheerModel.ObjectContext.Detach(entity); } catch{}
                if(result != null)
    				try { beheerModel.ObjectContext.Detach(result); } catch{}
            }
    	}
    
    	public bool SetGebruikerForAddressById(ClubCloud_Gebruiker Gebruiker, System.Guid Id , bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		ClubCloud_Address entity = null;
    
    		try
    		{		
    			entity = beheerModel.ClubCloud_Addressen.Find(Id);	
    
    			if(entity != null && entity.ClubCloud_Gebruiker == null)
    				beheerModel.Entry(entity).Reference(e => e.ClubCloud_Gebruiker).Load();
    
    			entity.ClubCloud_Gebruiker = Gebruiker;
    
    			beheerModel.SaveChanges();
    			return true;
            }
            finally
            {
    			if(entity != null)
    				try { beheerModel.ObjectContext.Detach(entity); } catch{}
            }
    		return false;
    	}
    
    
    	public ClubCloud_Regio GetRegioForAddress(ClubCloud_Address entity, bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		ClubCloud_Regio result = null;
    
    		try
    		{
    			entity = beheerModel.ClubCloud_Addressen.Find(entity.Id);
    			if(entity != null && entity.ClubCloud_Regio == null)
    				beheerModel.Entry(entity).Reference(e => e.ClubCloud_Regio).Load();
    
    			result = entity.ClubCloud_Regio;
    
    			if (result == null || refresh)
    				result = GetRegioForAddress(settings.Id.ToString(), entity, refresh, settings);
    
    			if (result != null)
    				return result;
    
    			return new ClubCloud_Regio();
    		}
            finally
            {
    			if(entity != null)
    				try { beheerModel.ObjectContext.Detach(entity); } catch{}
                if(result != null)
    				try { beheerModel.ObjectContext.Detach(result); } catch{}
            }
    
    	}
    
    	public bool SetRegioForAddress(ClubCloud_Regio Regio, ClubCloud_Address entity , bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		try
    		{		
    			entity = beheerModel.ClubCloud_Addressen.Find(entity.Id);	
    
    			if(entity != null && entity.ClubCloud_Regio == null)
    				beheerModel.Entry(entity).Reference(e => e.ClubCloud_Regio).Load();
    
    			entity.ClubCloud_Regio = Regio;
    
    			beheerModel.SaveChanges();
    			return true;
            }
            finally
            {
    			if(entity != null)
    				try { beheerModel.ObjectContext.Detach(entity); } catch{}
            }
    		return false;
    	}
    
    
    	public ClubCloud_Regio GetRegioForAddressById(System.Guid Id, bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		ClubCloud_Address entity = null;
    		ClubCloud_Regio result = null;
    
    		try
    		{
    			entity = beheerModel.ClubCloud_Addressen.Find(Id);
    			if(entity != null && entity.ClubCloud_Regio == null)
    				beheerModel.Entry(entity).Reference(e => e.ClubCloud_Regio).Load();
    
    			result = entity.ClubCloud_Regio;
    
    			if (result == null || refresh)
    				result = GetRegioForAddressById(settings.Id.ToString(), Id, refresh, settings);
    
    			if (result != null)
    				return result;
    
    			return new ClubCloud_Regio();
    		}
            finally
            {
    			if(entity != null)
    				try { beheerModel.ObjectContext.Detach(entity); } catch{}
                if(result != null)
    				try { beheerModel.ObjectContext.Detach(result); } catch{}
            }
    	}
    
    	public bool SetRegioForAddressById(ClubCloud_Regio Regio, System.Guid Id , bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		ClubCloud_Address entity = null;
    
    		try
    		{		
    			entity = beheerModel.ClubCloud_Addressen.Find(Id);	
    
    			if(entity != null && entity.ClubCloud_Regio == null)
    				beheerModel.Entry(entity).Reference(e => e.ClubCloud_Regio).Load();
    
    			entity.ClubCloud_Regio = Regio;
    
    			beheerModel.SaveChanges();
    			return true;
            }
            finally
            {
    			if(entity != null)
    				try { beheerModel.ObjectContext.Detach(entity); } catch{}
            }
    		return false;
    	}
    
    
    	public ClubCloud_Accommodatie GetAccommodatieForAddress(ClubCloud_Address entity, bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		ClubCloud_Accommodatie result = null;
    
    		try
    		{
    			entity = beheerModel.ClubCloud_Addressen.Find(entity.Id);
    			if(entity != null && entity.ClubCloud_Accommodatie == null)
    				beheerModel.Entry(entity).Reference(e => e.ClubCloud_Accommodatie).Load();
    
    			result = entity.ClubCloud_Accommodatie;
    
    			if (result == null || refresh)
    				result = GetAccommodatieForAddress(settings.Id.ToString(), entity, refresh, settings);
    
    			if (result != null)
    				return result;
    
    			return new ClubCloud_Accommodatie();
    		}
            finally
            {
    			if(entity != null)
    				try { beheerModel.ObjectContext.Detach(entity); } catch{}
                if(result != null)
    				try { beheerModel.ObjectContext.Detach(result); } catch{}
            }
    
    	}
    
    	public bool SetAccommodatieForAddress(ClubCloud_Accommodatie Accommodatie, ClubCloud_Address entity , bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		try
    		{		
    			entity = beheerModel.ClubCloud_Addressen.Find(entity.Id);	
    
    			if(entity != null && entity.ClubCloud_Accommodatie == null)
    				beheerModel.Entry(entity).Reference(e => e.ClubCloud_Accommodatie).Load();
    
    			entity.ClubCloud_Accommodatie = Accommodatie;
    
    			beheerModel.SaveChanges();
    			return true;
            }
            finally
            {
    			if(entity != null)
    				try { beheerModel.ObjectContext.Detach(entity); } catch{}
            }
    		return false;
    	}
    
    
    	public ClubCloud_Accommodatie GetAccommodatieForAddressById(System.Guid Id, bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		ClubCloud_Address entity = null;
    		ClubCloud_Accommodatie result = null;
    
    		try
    		{
    			entity = beheerModel.ClubCloud_Addressen.Find(Id);
    			if(entity != null && entity.ClubCloud_Accommodatie == null)
    				beheerModel.Entry(entity).Reference(e => e.ClubCloud_Accommodatie).Load();
    
    			result = entity.ClubCloud_Accommodatie;
    
    			if (result == null || refresh)
    				result = GetAccommodatieForAddressById(settings.Id.ToString(), Id, refresh, settings);
    
    			if (result != null)
    				return result;
    
    			return new ClubCloud_Accommodatie();
    		}
            finally
            {
    			if(entity != null)
    				try { beheerModel.ObjectContext.Detach(entity); } catch{}
                if(result != null)
    				try { beheerModel.ObjectContext.Detach(result); } catch{}
            }
    	}
    
    	public bool SetAccommodatieForAddressById(ClubCloud_Accommodatie Accommodatie, System.Guid Id , bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		ClubCloud_Address entity = null;
    
    		try
    		{		
    			entity = beheerModel.ClubCloud_Addressen.Find(Id);	
    
    			if(entity != null && entity.ClubCloud_Accommodatie == null)
    				beheerModel.Entry(entity).Reference(e => e.ClubCloud_Accommodatie).Load();
    
    			entity.ClubCloud_Accommodatie = Accommodatie;
    
    			beheerModel.SaveChanges();
    			return true;
            }
            finally
            {
    			if(entity != null)
    				try { beheerModel.ObjectContext.Detach(entity); } catch{}
            }
    		return false;
    	}
    
    
    	public ClubCloud_Land GetLandForAddress(ClubCloud_Address entity, bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		ClubCloud_Land result = null;
    
    		try
    		{
    			entity = beheerModel.ClubCloud_Addressen.Find(entity.Id);
    			if(entity != null && entity.ClubCloud_Land == null)
    				beheerModel.Entry(entity).Reference(e => e.ClubCloud_Land).Load();
    
    			result = entity.ClubCloud_Land;
    
    			if (result == null || refresh)
    				result = GetLandForAddress(settings.Id.ToString(), entity, refresh, settings);
    
    			if (result != null)
    				return result;
    
    			return new ClubCloud_Land();
    		}
            finally
            {
    			if(entity != null)
    				try { beheerModel.ObjectContext.Detach(entity); } catch{}
                if(result != null)
    				try { beheerModel.ObjectContext.Detach(result); } catch{}
            }
    
    	}
    
    	public bool SetLandForAddress(ClubCloud_Land Land, ClubCloud_Address entity , bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		try
    		{		
    			entity = beheerModel.ClubCloud_Addressen.Find(entity.Id);	
    
    			if(entity != null && entity.ClubCloud_Land == null)
    				beheerModel.Entry(entity).Reference(e => e.ClubCloud_Land).Load();
    
    			entity.ClubCloud_Land = Land;
    
    			beheerModel.SaveChanges();
    			return true;
            }
            finally
            {
    			if(entity != null)
    				try { beheerModel.ObjectContext.Detach(entity); } catch{}
            }
    		return false;
    	}
    
    
    	public ClubCloud_Land GetLandForAddressById(System.Guid Id, bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		ClubCloud_Address entity = null;
    		ClubCloud_Land result = null;
    
    		try
    		{
    			entity = beheerModel.ClubCloud_Addressen.Find(Id);
    			if(entity != null && entity.ClubCloud_Land == null)
    				beheerModel.Entry(entity).Reference(e => e.ClubCloud_Land).Load();
    
    			result = entity.ClubCloud_Land;
    
    			if (result == null || refresh)
    				result = GetLandForAddressById(settings.Id.ToString(), Id, refresh, settings);
    
    			if (result != null)
    				return result;
    
    			return new ClubCloud_Land();
    		}
            finally
            {
    			if(entity != null)
    				try { beheerModel.ObjectContext.Detach(entity); } catch{}
                if(result != null)
    				try { beheerModel.ObjectContext.Detach(result); } catch{}
            }
    	}
    
    	public bool SetLandForAddressById(ClubCloud_Land Land, System.Guid Id , bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		ClubCloud_Address entity = null;
    
    		try
    		{		
    			entity = beheerModel.ClubCloud_Addressen.Find(Id);	
    
    			if(entity != null && entity.ClubCloud_Land == null)
    				beheerModel.Entry(entity).Reference(e => e.ClubCloud_Land).Load();
    
    			entity.ClubCloud_Land = Land;
    
    			beheerModel.SaveChanges();
    			return true;
            }
            finally
            {
    			if(entity != null)
    				try { beheerModel.ObjectContext.Detach(entity); } catch{}
            }
    		return false;
    	}
    
    }
    
    [Serializable]
    [DataContract(IsReference = true)]
    [KnownType(typeof(ClubCloud_Address))]
    public partial class ClubCloud_Address_View
    {
    	public ClubCloud_Address_View()
    	{
    		this.ClubCloud_Address = new HashSet<ClubCloud_Address>();
    	}
    
    	[DataMember]
    	public int TotalRowCount { get; set; }
    
    	[DataMember]
    	public virtual ICollection<ClubCloud_Address> ClubCloud_Address { get; set; }
    
    }
    	
}

