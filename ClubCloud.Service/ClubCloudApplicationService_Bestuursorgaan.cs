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
    	public ClubCloud_Bestuursorgaan GetBestuursorgaanById(System.Guid Id , bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		ClubCloud_Bestuursorgaan result = null;
    
    		try
    		{			
    			result = beheerModel.ClubCloud_Bestuursorganen.Find(Id);
    		
    			if (result == null || refresh)
    				result = GetBestuursorgaanById(settings.Id.ToString(), Id, refresh, settings);
    
    			if (result != null)
    				return result;
    
    			return new ClubCloud_Bestuursorgaan();
            }
            finally
            {
    			if(result != null)
    				try { beheerModel.ObjectContext.Detach(result);} catch{}
            }
    
    	}
    
    	public List<ClubCloud_Bestuursorgaan> GetBestuursorganen(bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		List<ClubCloud_Bestuursorgaan> result = null;
    		
    		try
    		{
    			result = beheerModel.ClubCloud_Bestuursorganen.ToList<ClubCloud_Bestuursorgaan>();
    		
    			if (result == null || result.Count == 0 || refresh)		
    				result = GetBestuursorganen(settings.Id.ToString(), refresh, settings);
    
    			if(result != null)
    				return result;
    
    			return new List<ClubCloud_Bestuursorgaan>();
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
    
    	public ClubCloud_Bestuursorgaan SetBestuursorgaan(ClubCloud_Bestuursorgaan entity, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		ClubCloud_Bestuursorgaan tobeupdated = null;
    		
    		try
    		{
    			entity = SetBestuursorgaan(settings.Id.ToString(), entity, settings);
    
    			beheerModel.ClubCloud_Bestuursorganen.AddOrUpdate(entity);
    		
    			beheerModel.SaveChanges();
    
    			tobeupdated = beheerModel.ClubCloud_Bestuursorganen.Find(entity.Id);
    			return tobeupdated;
            }
            finally
            {
    			if(tobeupdated != null)
    				try { beheerModel.ObjectContext.Detach(tobeupdated); } catch{}
            }
    
    	}
    
    
    	public bool DeleteBestuursorgaan(ClubCloud_Bestuursorgaan entity, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		return DeleteBestuursorgaanById(entity.Id, settings);
    	}
    
    	public bool DeleteBestuursorgaanById(System.Guid Id, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		ClubCloud_Bestuursorgaan tobedeleted = null;
    		try
    		{
    
    			tobedeleted = beheerModel.ClubCloud_Bestuursorganen.Find(Id);
    		
    			if (tobedeleted != null)
    			{
    				beheerModel.ClubCloud_Bestuursorganen.Remove(tobedeleted);
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
    
    
    	public ClubCloud_Bestuursorgaan_View GetBestuursorganenByQuery(string bondsnummer, Guid verenigingId,System.Web.UI.DataSourceSelectArguments selectArgs = null, List<System.Web.UI.WebControls.Parameter> parameters = null, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		ClubCloud_Bestuursorgaan_View view = new ClubCloud_Bestuursorgaan_View();
    
    		StringBuilder querybuilder = new StringBuilder("SELECT * FROM dbo.ClubCloud_Bestuursorgaan");
    		List<SqlParameter> sqlparams = new List<SqlParameter>();
    		List<SqlParameter> sqlparamscount = new List<SqlParameter>();
    		string and = " AND ";
    		if (parameters != null && parameters.Count > 0)
    		{
    			querybuilder.Append(" WHERE ");
    
    			foreach (System.Web.UI.WebControls.Parameter parameter in parameters)
    			{
    				Type type = TypeConvertor.ToNetType(parameter.DbType);
    				if(type == typeof(DateTime))
    				{
    					querybuilder.Append(parameter.Name + " >= " + parameter.Name + and);
    				}
    				else
    				{
    					querybuilder.Append(parameter.Name + " = @" + parameter.Name + and);
    				}
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
    
    		view.ClubCloud_Bestuursorgaan = beheerModel.Database.SqlQuery<ClubCloud_Bestuursorgaan>(querybuilder.ToString(), sqlparams.ToArray()).Skip(selectArgs.StartRowIndex).Take(selectArgs.MaximumRows).ToList<ClubCloud_Bestuursorgaan>();
    
    		if (selectArgs.RetrieveTotalRowCount)
    		{
    
    			view.TotalRowCount = beheerModel.Database.SqlQuery<ClubCloud_Bestuursorgaan>(querybuilder.ToString(), sqlparamscount.ToArray()).Count();
    		}
    		return view;
    	}
    
    	public List<ClubCloud_Bestuursorgaan> GetBestuursorganenBySearch(string prefixText, int count, string contextKey, ClubCloud_Setting _settings = null)
    	{
    		if(_settings != null)
    			ValidateSettings(ref _settings);
    
            List<string> bestuursorganen = new List<string>();
            try
            {
                bool enabled = beheerModel.Database.SqlQuery<bool>("SELECT (CAST((FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))AS BIT))").FirstOrDefault();
    
                List<ClubCloud_Bestuursorgaan> entities = null;
    
                if (enabled)
                {
                    var fts = BeheerFullTextInterceptor.Fts(prefixText);
    				
    
    			entities = beheerModel.ClubCloud_Bestuursorganen.Where(e => e.Naam.Contains(fts)  || e.Beschrijving.Contains(fts)  || e.Groep.Contains(fts)  || e.Actief.Contains(fts) ).ToList();
    
    				
                }
    			else
    			{
    
    			entities = beheerModel.Database.SqlQuery<ClubCloud_Bestuursorgaan>("SELECT * FROM ClubCloud_Bestuursorgaan WHERE  Naam LIKE '%"+ prefixText +"%' OR  Beschrijving LIKE '%"+ prefixText +"%' OR  Groep LIKE '%"+ prefixText +"%' OR  Actief LIKE '%"+ prefixText +"%'").ToList();
    
    				
    			}
    
    			if (entities != null && entities.Count > 0)
    				return entities;
            }
            catch { };
    
            return new List<ClubCloud_Bestuursorgaan>();
    	}
    
    
    	public List<ClubCloud_Functionaris> GetFunctionarissenForBestuursorgaan(ClubCloud_Bestuursorgaan entity, bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		List<ClubCloud_Functionaris> result = null;
    
    		try
    		{
    			entity = beheerModel.ClubCloud_Bestuursorganen.Find(entity.Id);
    			if(entity != null && entity.ClubCloud_Functionaris != null && entity.ClubCloud_Functionaris.Count == 0)
    				beheerModel.Entry(entity).Collection(e => e.ClubCloud_Functionaris).Load();
    
    			result = entity.ClubCloud_Functionaris.ToList();
    
    			if(result == null || result.Count == 0 || refresh)
    				result = GetFunctionarissenForBestuursorgaan(settings.Id.ToString(), entity, refresh, settings);
    
    			if(result != null)
    				return result;
    
    			return new List<ClubCloud_Functionaris>();
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
    
    
    	public List<ClubCloud_Functionaris> GetFunctionarissenForBestuursorgaanById(System.Guid Id, bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		ClubCloud_Bestuursorgaan entity = null;
    		List<ClubCloud_Functionaris> result = null;
    
    		try
    		{
    			entity = beheerModel.ClubCloud_Bestuursorganen.Find(Id);
    			if(entity != null && entity.ClubCloud_Functionaris != null && entity.ClubCloud_Functionaris.Count == 0)
    				beheerModel.Entry(entity).Collection(e => e.ClubCloud_Functionaris).Load();
    
    			result = entity.ClubCloud_Functionaris.ToList();
    
    			if(result == null || result.Count == 0 || refresh)
    				result = GetFunctionarissenForBestuursorgaanById(settings.Id.ToString(), Id, refresh, settings);
    
    			if(result != null)
    				return result;
    
    			return new List<ClubCloud_Functionaris>();
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
    
    	public bool SetFunctionarissenForBestuursorgaan(List<ClubCloud_Functionaris> Functionarissen, ClubCloud_Bestuursorgaan entity, bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		ClubCloud_Bestuursorgaan result = null;
    
    		try
    		{			
    			entity = beheerModel.ClubCloud_Bestuursorganen.Find(entity.Id);
    		
    			if (entity != null)
    				beheerModel.Entry(entity).Collection(e => e.ClubCloud_Functionaris).Load();
    				//result = GetBestuursorgaanById(settings.Id.ToString(), Id, refresh, settings);
    
    			if (result != null)
    				//return result.ClubCloud_Bestuursorganen.Count == ;
    
    			return false;
            }
            finally
            {
    			if(entity != null)
    				try { beheerModel.ObjectContext.Detach(entity); } catch{}
            }
    		return false;
    	}
    
    
    
    	public ClubCloud_Vereniging GetVerenigingForBestuursorgaan(ClubCloud_Bestuursorgaan entity, bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		ClubCloud_Vereniging result = null;
    
    		try
    		{
    			entity = beheerModel.ClubCloud_Bestuursorganen.Find(entity.Id);
    			if(entity != null && entity.ClubCloud_Vereniging == null)
    				beheerModel.Entry(entity).Reference(e => e.ClubCloud_Vereniging).Load();
    
    			result = entity.ClubCloud_Vereniging;
    
    			if (result == null || refresh)
    				result = GetVerenigingForBestuursorgaan(settings.Id.ToString(), entity, refresh, settings);
    
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
    
    	public bool SetVerenigingForBestuursorgaan(ClubCloud_Vereniging Vereniging, ClubCloud_Bestuursorgaan entity , bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		try
    		{		
    			entity = beheerModel.ClubCloud_Bestuursorganen.Find(entity.Id);	
    
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
    
    
    	public ClubCloud_Vereniging GetVerenigingForBestuursorgaanById(System.Guid Id, bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		ClubCloud_Bestuursorgaan entity = null;
    		ClubCloud_Vereniging result = null;
    
    		try
    		{
    			entity = beheerModel.ClubCloud_Bestuursorganen.Find(Id);
    			if(entity != null && entity.ClubCloud_Vereniging == null)
    				beheerModel.Entry(entity).Reference(e => e.ClubCloud_Vereniging).Load();
    
    			result = entity.ClubCloud_Vereniging;
    
    			if (result == null || refresh)
    				result = GetVerenigingForBestuursorgaanById(settings.Id.ToString(), Id, refresh, settings);
    
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
    
    	public bool SetVerenigingForBestuursorgaanById(ClubCloud_Vereniging Vereniging, System.Guid Id , bool refresh = false, ClubCloud_Setting settings = null)
    	{
    		if(settings != null)
    			ValidateSettings(ref settings);
    
    		ClubCloud_Bestuursorgaan entity = null;
    
    		try
    		{		
    			entity = beheerModel.ClubCloud_Bestuursorganen.Find(Id);	
    
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
    
    }
    
    [Serializable]
    [DataContract(IsReference = true)]
    [KnownType(typeof(ClubCloud_Bestuursorgaan))]
    public partial class ClubCloud_Bestuursorgaan_View
    {
    	public ClubCloud_Bestuursorgaan_View()
    	{
    		this.ClubCloud_Bestuursorgaan = new HashSet<ClubCloud_Bestuursorgaan>();
    	}
    
    	[DataMember]
    	public int TotalRowCount { get; set; }
    
    	[DataMember]
    	public virtual ICollection<ClubCloud_Bestuursorgaan> ClubCloud_Bestuursorgaan { get; set; }
    
    }
    	
}

