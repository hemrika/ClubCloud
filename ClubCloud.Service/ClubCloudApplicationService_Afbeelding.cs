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
    	public ClubCloud_Sponsor_Afbeelding GetAfbeeldingById(System.Guid Id , bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		ClubCloud_Sponsor_Afbeelding result = null;
    
    		try
    		{			
    			result = beheerModel.ClubCloud_Sponsor_Afbeeldingen.Find(Id);
    		
    			if (result == null || refresh)
    				result = GetAfbeeldingById(settings.Id.ToString(), Id, refresh, settings);
    
    			if (result != null)
    				return result;
    
    			return new ClubCloud_Sponsor_Afbeelding();
            }
            finally
            {
    			if(result != null)
    				try { beheerModel.ObjectContext.Detach(result);} catch{}
            }
    
    	}
    
    	public List<ClubCloud_Sponsor_Afbeelding> GetAfbeeldingen(bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		List<ClubCloud_Sponsor_Afbeelding> result = null;
    		
    		try
    		{
    			result = beheerModel.ClubCloud_Sponsor_Afbeeldingen.ToList<ClubCloud_Sponsor_Afbeelding>();
    		
    			if (result == null || result.Count == 0 || refresh)		
    				result = GetAfbeeldingen(settings.Id.ToString(), refresh, settings);
    
    			if(result != null)
    				return result;
    
    			return new List<ClubCloud_Sponsor_Afbeelding>();
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
    
    	public ClubCloud_Sponsor_Afbeelding SetAfbeelding(ClubCloud_Sponsor_Afbeelding entity, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		ClubCloud_Sponsor_Afbeelding tobeupdated = null;
    		
    		try
    		{
    			entity = SetAfbeelding(settings.Id.ToString(), entity, settings);
    
    			beheerModel.ClubCloud_Sponsor_Afbeeldingen.AddOrUpdate(entity);
    		
    			beheerModel.SaveChanges();
    
    			tobeupdated = beheerModel.ClubCloud_Sponsor_Afbeeldingen.Find(entity.Id);
    			return tobeupdated;
            }
            finally
            {
    			if(tobeupdated != null)
    				try { beheerModel.ObjectContext.Detach(tobeupdated); } catch{}
            }
    
    	}
    
    
    	public bool DeleteAfbeelding(ClubCloud_Sponsor_Afbeelding entity, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		return DeleteAfbeeldingById(entity.Id, settings);
    	}
    
    	public bool DeleteAfbeeldingById(System.Guid Id, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		ClubCloud_Sponsor_Afbeelding tobedeleted = null;
    		try
    		{
    
    			tobedeleted = beheerModel.ClubCloud_Sponsor_Afbeeldingen.Find(Id);
    		
    			if (tobedeleted != null)
    			{
    				beheerModel.ClubCloud_Sponsor_Afbeeldingen.Remove(tobedeleted);
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
    
    
    	public ClubCloud_Sponsor_Afbeelding_View GetAfbeeldingenByQuery(string bondsnummer, Guid verenigingId,System.Web.UI.DataSourceSelectArguments selectArgs = null, List<System.Web.UI.WebControls.Parameter> parameters = null, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		ClubCloud_Sponsor_Afbeelding_View view = new ClubCloud_Sponsor_Afbeelding_View();
    
    		StringBuilder querybuilder = new StringBuilder("SELECT * FROM dbo.ClubCloud_Sponsor_Afbeelding");
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
    
    		view.ClubCloud_Sponsor_Afbeelding = beheerModel.Database.SqlQuery<ClubCloud_Sponsor_Afbeelding>(querybuilder.ToString(), sqlparams.ToArray()).Skip(selectArgs.StartRowIndex).Take(selectArgs.MaximumRows).ToList<ClubCloud_Sponsor_Afbeelding>();
    
    		if (selectArgs.RetrieveTotalRowCount)
    		{
    
    			view.TotalRowCount = beheerModel.Database.SqlQuery<ClubCloud_Sponsor_Afbeelding>(querybuilder.ToString(), sqlparamscount.ToArray()).Count();
    		}
    		return view;
    	}
    
    	public List<ClubCloud_Sponsor_Afbeelding> GetAfbeeldingenBySearch(string prefixText, int count, string contextKey, ClubCloud_Setting _settings = null)
    	{
    		if(_settings != null)
    			ValidateSettings(ref _settings);
    
            List<string> afbeeldingen = new List<string>();
            try
            {
                bool enabled = beheerModel.Database.SqlQuery<bool>("SELECT (CAST((FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))AS BIT))").FirstOrDefault();
    
                List<ClubCloud_Sponsor_Afbeelding> entities = null;
    
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
            catch { };
    
            return new List<ClubCloud_Sponsor_Afbeelding>();
    	}
    
    
    	public List<ClubCloud_Sponsor> GetSponsorenForAfbeelding(ClubCloud_Sponsor_Afbeelding entity, bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		List<ClubCloud_Sponsor> result = null;
    
    		try
    		{
    			entity = beheerModel.ClubCloud_Sponsor_Afbeeldingen.Find(entity.Id);
    			if(entity != null && entity.ClubCloud_Sponsor != null && entity.ClubCloud_Sponsor.Count == 0)
    				beheerModel.Entry(entity).Collection(e => e.ClubCloud_Sponsor).Load();
    
    			result = entity.ClubCloud_Sponsor.ToList();
    
    			if(result == null || result.Count == 0 || refresh)
    				result = GetSponsorenForAfbeelding(settings.Id.ToString(), entity, refresh, settings);
    
    			if(result != null)
    				return result;
    
    			return new List<ClubCloud_Sponsor>();
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
    
    
    	public List<ClubCloud_Sponsor> GetSponsorenForAfbeeldingById(System.Guid Id, bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		ClubCloud_Sponsor_Afbeelding entity = null;
    		List<ClubCloud_Sponsor> result = null;
    
    		try
    		{
    			entity = beheerModel.ClubCloud_Sponsor_Afbeeldingen.Find(Id);
    			if(entity != null && entity.ClubCloud_Sponsor != null && entity.ClubCloud_Sponsor.Count == 0)
    				beheerModel.Entry(entity).Collection(e => e.ClubCloud_Sponsor).Load();
    
    			result = entity.ClubCloud_Sponsor.ToList();
    
    			if(result == null || result.Count == 0 || refresh)
    				result = GetSponsorenForAfbeeldingById(settings.Id.ToString(), Id, refresh, settings);
    
    			if(result != null)
    				return result;
    
    			return new List<ClubCloud_Sponsor>();
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
    
    	public bool SetSponsorenForAfbeelding(List<ClubCloud_Sponsor> Sponsoren, ClubCloud_Sponsor_Afbeelding entity, bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		ClubCloud_Sponsor_Afbeelding result = null;
    
    		try
    		{			
    			entity = beheerModel.ClubCloud_Sponsor_Afbeeldingen.Find(entity.Id);
    		
    			if (entity != null)
    				beheerModel.Entry(entity).Collection(e => e.ClubCloud_Sponsor).Load();
    				//result = GetAfbeeldingById(settings.Id.ToString(), Id, refresh, settings);
    
    			if (result != null)
    				//return result.ClubCloud_Sponsor_Afbeeldingen.Count == ;
    
    			return false;
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
    [KnownType(typeof(ClubCloud_Sponsor_Afbeelding))]
    public partial class ClubCloud_Sponsor_Afbeelding_View
    {
    	public ClubCloud_Sponsor_Afbeelding_View()
    	{
    		this.ClubCloud_Sponsor_Afbeelding = new HashSet<ClubCloud_Sponsor_Afbeelding>();
    	}
    
    	[DataMember]
    	public int TotalRowCount { get; set; }
    
    	[DataMember]
    	public virtual ICollection<ClubCloud_Sponsor_Afbeelding> ClubCloud_Sponsor_Afbeelding { get; set; }
    
    }
    	
}

