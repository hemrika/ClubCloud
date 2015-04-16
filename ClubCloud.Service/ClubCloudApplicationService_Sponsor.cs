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
    	public ClubCloud_Sponsor GetSponsorById(System.Guid Id , bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		ClubCloud_Sponsor result = null;
    
    		try
    		{			
    			result = beheerModel.ClubCloud_Sponsoren.Find(Id);
    		
    			if (result == null || refresh)
    				result = GetSponsorById(settings.Id.ToString(), Id, refresh, settings);
    
    			if (result != null)
    				return result;
    
    			return new ClubCloud_Sponsor();
            }
            finally
            {
    			if(result != null)
    				beheerModel.ObjectContext.Detach(result);
            }
    
    	}
    
    	public List<ClubCloud_Sponsor> GetSponsoren(bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		List<ClubCloud_Sponsor> result = null;
    		
    		try
    		{
    			result = beheerModel.ClubCloud_Sponsoren.ToList<ClubCloud_Sponsor>();
    		
    			if (result == null || result.Count == 0 || refresh)		
    				result = GetSponsoren(settings.Id.ToString(), refresh, settings);
    
    			if(result != null)
    				return result;
    
    			return new List<ClubCloud_Sponsor>();
            }
            finally
            {
    			if(result != null)
    			{
    				foreach (object item in result)
    				{
    					if(item != null)
    						beheerModel.ObjectContext.Detach(item);
    				}
    			}
            }
    
    	}
    
    	public ClubCloud_Sponsor SetSponsor(ClubCloud_Sponsor entity, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		ClubCloud_Sponsor tobeupdated = null;
    		
    		try
    		{
    			entity = SetSponsor(settings.Id.ToString(), entity, settings);
    
    			beheerModel.ClubCloud_Sponsoren.AddOrUpdate(entity);
    		
    			beheerModel.SaveChanges();
    
    			tobeupdated = beheerModel.ClubCloud_Sponsoren.Find(entity.Id);
    			return tobeupdated;
            }
            finally
            {
    			if(tobeupdated != null)
    				beheerModel.ObjectContext.Detach(tobeupdated);
            }
    
    	}
    
    
    	public bool DeleteSponsor(ClubCloud_Sponsor entity, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		return DeleteSponsorById(entity.Id, settings);
    	}
    
    	public bool DeleteSponsorById(System.Guid Id, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		ClubCloud_Sponsor tobedeleted = null;
    		try
    		{
    
    			tobedeleted = beheerModel.ClubCloud_Sponsoren.Find(Id);
    		
    			if (tobedeleted != null)
    			{
    				beheerModel.ClubCloud_Sponsoren.Remove(tobedeleted);
    				beheerModel.SaveChanges();
    			}
    			return true;
    		}
            finally
            {
    			if(tobedeleted != null)
    				beheerModel.ObjectContext.Detach(tobedeleted);
            }
    
    		return false;
    	}
    
    
    	public ClubCloud_Sponsor_View GetSponsorenByQuery(string bondsnummer, Guid verenigingId,System.Web.UI.DataSourceSelectArguments selectArgs = null, List<System.Web.UI.WebControls.Parameter> parameters = null, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		ClubCloud_Sponsor_View view = new ClubCloud_Sponsor_View();
    
    		StringBuilder querybuilder = new StringBuilder("SELECT * FROM dbo.ClubCloud_Sponsor");
    		List<SqlParameter> sqlparams = new List<SqlParameter>();
    		List<SqlParameter> sqlparamscount = new List<SqlParameter>();
    		string and = " AND ";
    		if (parameters != null && parameters.Count > 0)
    		{
    			querybuilder.Append(" WHERE ");
    
    			foreach (System.Web.UI.WebControls.Parameter parameter in parameters)
    			{
    				querybuilder.Append(parameter.Name + " = @" + parameter.Name + and);
    				Type type = TypeConvertor.ToNetType(parameter.DbType);
    				object value = TypeDescriptor.GetConverter(type).ConvertFrom(parameter.DefaultValue);// typeof(string)));
    
    				sqlparams.Add(new SqlParameter { Value = value, ParameterName = "@" + parameter.Name, DbType = parameter.DbType, Direction = parameter.Direction });
    				sqlparamscount.Add(new SqlParameter { Value = value, ParameterName = "@" + parameter.Name, DbType = parameter.DbType, Direction = parameter.Direction });
    			}
    
    			querybuilder.Remove(querybuilder.Length - and.Length, and.Length);
    
    		}
    
    		if (!string.IsNullOrWhiteSpace(selectArgs.SortExpression))
    		{
    			querybuilder.Append(" ORDER BY " + selectArgs.SortExpression);
    		}
    
    		view.ClubCloud_Sponsor = beheerModel.Database.SqlQuery<ClubCloud_Sponsor>(querybuilder.ToString(), sqlparams.ToArray()).Skip(selectArgs.StartRowIndex).Take(selectArgs.MaximumRows).ToList<ClubCloud_Sponsor>();
    
    		if (selectArgs.RetrieveTotalRowCount)
    		{
    
    			view.TotalRowCount = beheerModel.Database.SqlQuery<ClubCloud_Sponsor>(querybuilder.ToString(), sqlparamscount.ToArray()).Count();
    		}
    		return view;
    	}
    
    	public List<ClubCloud_Sponsor> GetSponsorenBySearch(string prefixText, int count, string contextKey, ClubCloud_Setting _settings = null)
    	{
    		if(_settings != null)
    			ValidateSettings(ref _settings);
    
            List<string> sponsoren = new List<string>();
            try
            {
                bool enabled = beheerModel.Database.SqlQuery<bool>("SELECT (CAST((FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))AS BIT))").FirstOrDefault();
    
                List<ClubCloud_Sponsor> entities = null;
    
                if (enabled)
                {
                    var fts = BeheerFullTextInterceptor.Fts(prefixText);
    				
    
    			entities = beheerModel.ClubCloud_Sponsoren.Where(e => e.Naam.Contains(fts)  || e.Tekst.Contains(fts) ).ToList();
    
    				
                }
    			else
    			{
    
    			entities = beheerModel.Database.SqlQuery<ClubCloud_Sponsor>("SELECT * FROM ClubCloud_Sponsor WHERE  Naam LIKE '%"+ prefixText +"%' OR  Tekst LIKE '%"+ prefixText +"%'").ToList();
    
    				
    			}
    
    			if (entities != null && entities.Count > 0)
    				return entities;
            }
            catch { };
    
            return new List<ClubCloud_Sponsor>();
    	}
    
    
    	public ClubCloud_Vereniging GetVerenigingForSponsor(ClubCloud_Sponsor entity, bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		ClubCloud_Vereniging result = null;
    
    		try
    		{
    			entity = beheerModel.ClubCloud_Sponsoren.Find(entity.Id);
    			if(entity != null && entity.ClubCloud_Vereniging == null)
    				beheerModel.Entry(entity).Reference(e => e.ClubCloud_Vereniging).Load();
    
    			result = entity.ClubCloud_Vereniging;
    
    			if (result == null || refresh)
    				result = GetVerenigingForSponsor(settings.Id.ToString(), entity, refresh, settings);
    
    			if (result != null)
    				return result;
    
    			return new ClubCloud_Vereniging();
    		}
            finally
            {
    			if(entity != null)
    				beheerModel.ObjectContext.Detach(entity);
                if(result != null)
    				beheerModel.ObjectContext.Detach(result);
            }
    
    	}
    
    	public bool SetVerenigingForSponsor(ClubCloud_Vereniging Vereniging, ClubCloud_Sponsor entity , bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		try
    		{		
    			entity = beheerModel.ClubCloud_Sponsoren.Find(entity.Id);	
    
    			if(entity != null && entity.ClubCloud_Vereniging == null)
    				beheerModel.Entry(entity).Reference(e => e.ClubCloud_Vereniging).Load();
    
    			entity.ClubCloud_Vereniging = Vereniging;
    
    			beheerModel.SaveChanges();
    			return true;
            }
            finally
            {
    			if(entity != null)
    				beheerModel.ObjectContext.Detach(entity);
            }
    		return false;
    	}
    
    
    	public ClubCloud_Vereniging GetVerenigingForSponsorById(System.Guid Id, bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		ClubCloud_Sponsor entity = null;
    		ClubCloud_Vereniging result = null;
    
    		try
    		{
    			entity = beheerModel.ClubCloud_Sponsoren.Find(Id);
    			if(entity != null && entity.ClubCloud_Vereniging == null)
    				beheerModel.Entry(entity).Reference(e => e.ClubCloud_Vereniging).Load();
    
    			result = entity.ClubCloud_Vereniging;
    
    			if (result == null || refresh)
    				result = GetVerenigingForSponsorById(settings.Id.ToString(), Id, refresh, settings);
    
    			if (result != null)
    				return result;
    
    			return new ClubCloud_Vereniging();
    		}
            finally
            {
    			if(entity != null)
    				beheerModel.ObjectContext.Detach(entity);
                if(result != null)
    				beheerModel.ObjectContext.Detach(result);
            }
    	}
    
    	public bool SetVerenigingForSponsorById(ClubCloud_Vereniging Vereniging, System.Guid Id , bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		ClubCloud_Sponsor entity = null;
    
    		try
    		{		
    			entity = beheerModel.ClubCloud_Sponsoren.Find(Id);	
    
    			if(entity != null && entity.ClubCloud_Vereniging == null)
    				beheerModel.Entry(entity).Reference(e => e.ClubCloud_Vereniging).Load();
    
    			entity.ClubCloud_Vereniging = Vereniging;
    
    			beheerModel.SaveChanges();
    			return true;
            }
            finally
            {
    			if(entity != null)
    				beheerModel.ObjectContext.Detach(entity);
            }
    		return false;
    	}
    
    
    	public ClubCloud_Sponsor_Afbeelding GetAfbeeldingForSponsor(ClubCloud_Sponsor entity, bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		ClubCloud_Sponsor_Afbeelding result = null;
    
    		try
    		{
    			entity = beheerModel.ClubCloud_Sponsoren.Find(entity.Id);
    			if(entity != null && entity.ClubCloud_Sponsor_Afbeelding == null)
    				beheerModel.Entry(entity).Reference(e => e.ClubCloud_Sponsor_Afbeelding).Load();
    
    			result = entity.ClubCloud_Sponsor_Afbeelding;
    
    			if (result == null || refresh)
    				result = GetAfbeeldingForSponsor(settings.Id.ToString(), entity, refresh, settings);
    
    			if (result != null)
    				return result;
    
    			return new ClubCloud_Sponsor_Afbeelding();
    		}
            finally
            {
    			if(entity != null)
    				beheerModel.ObjectContext.Detach(entity);
                if(result != null)
    				beheerModel.ObjectContext.Detach(result);
            }
    
    	}
    
    	public bool SetAfbeeldingForSponsor(ClubCloud_Sponsor_Afbeelding Afbeelding, ClubCloud_Sponsor entity , bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		try
    		{		
    			entity = beheerModel.ClubCloud_Sponsoren.Find(entity.Id);	
    
    			if(entity != null && entity.ClubCloud_Sponsor_Afbeelding == null)
    				beheerModel.Entry(entity).Reference(e => e.ClubCloud_Sponsor_Afbeelding).Load();
    
    			entity.ClubCloud_Sponsor_Afbeelding = Afbeelding;
    
    			beheerModel.SaveChanges();
    			return true;
            }
            finally
            {
    			if(entity != null)
    				beheerModel.ObjectContext.Detach(entity);
            }
    		return false;
    	}
    
    
    	public ClubCloud_Sponsor_Afbeelding GetAfbeeldingForSponsorById(System.Guid Id, bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		ClubCloud_Sponsor entity = null;
    		ClubCloud_Sponsor_Afbeelding result = null;
    
    		try
    		{
    			entity = beheerModel.ClubCloud_Sponsoren.Find(Id);
    			if(entity != null && entity.ClubCloud_Sponsor_Afbeelding == null)
    				beheerModel.Entry(entity).Reference(e => e.ClubCloud_Sponsor_Afbeelding).Load();
    
    			result = entity.ClubCloud_Sponsor_Afbeelding;
    
    			if (result == null || refresh)
    				result = GetAfbeeldingForSponsorById(settings.Id.ToString(), Id, refresh, settings);
    
    			if (result != null)
    				return result;
    
    			return new ClubCloud_Sponsor_Afbeelding();
    		}
            finally
            {
    			if(entity != null)
    				beheerModel.ObjectContext.Detach(entity);
                if(result != null)
    				beheerModel.ObjectContext.Detach(result);
            }
    	}
    
    	public bool SetAfbeeldingForSponsorById(ClubCloud_Sponsor_Afbeelding Afbeelding, System.Guid Id , bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		ClubCloud_Sponsor entity = null;
    
    		try
    		{		
    			entity = beheerModel.ClubCloud_Sponsoren.Find(Id);	
    
    			if(entity != null && entity.ClubCloud_Sponsor_Afbeelding == null)
    				beheerModel.Entry(entity).Reference(e => e.ClubCloud_Sponsor_Afbeelding).Load();
    
    			entity.ClubCloud_Sponsor_Afbeelding = Afbeelding;
    
    			beheerModel.SaveChanges();
    			return true;
            }
            finally
            {
    			if(entity != null)
    				beheerModel.ObjectContext.Detach(entity);
            }
    		return false;
    	}
    
    }
    
    [Serializable]
    [DataContract(IsReference = true)]
    [KnownType(typeof(ClubCloud_Sponsor))]
    public partial class ClubCloud_Sponsor_View
    {
    	public ClubCloud_Sponsor_View()
    	{
    		this.ClubCloud_Sponsor = new HashSet<ClubCloud_Sponsor>();
    	}
    
    	[DataMember]
    	public int TotalRowCount { get; set; }
    
    	[DataMember]
    	public virtual ICollection<ClubCloud_Sponsor> ClubCloud_Sponsor { get; set; }
    
    }
    	
}

