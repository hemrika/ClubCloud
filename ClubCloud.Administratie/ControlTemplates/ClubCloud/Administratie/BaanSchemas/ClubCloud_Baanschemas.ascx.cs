namespace ClubCloud.Administratie.WebControls
{
    using System;
    using System.ComponentModel;
    using System.Linq;
    using System.Web.UI;
    using System.Web.UI.WebControls;
    using System.Web.UI.WebControls.WebParts;
    using System.Data.Entity.Infrastructure;
    using System.Data;
    
    public partial class ClubCloud_BaanschemasUserControl : UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
    
    		/*
            ClubCloud_Baanschema_DataSource.ViewName = this.ViewName;
            ClubCloud_Baanschema_DataSource.Assembly = typeof(ClubCloud_BaanschemasUserControl).Assembly;
    
    		ClubCloud_Baanschema_DataSource.View.WhereParameters = new ParameterCollection();
    
            foreach (string key in Request.QueryString.Keys)
            {
                string value = Request.QueryString[key];
                if (value != null || !string.IsNullOrWhiteSpace(value))
                {
                    Guid DefaultValue = Guid.Empty;
                    if (Guid.TryParse(value, out DefaultValue))
                    {
                        ClubCloud_Baanschema_DataSource.View.WhereParameters.Add(new Parameter { DefaultValue = "{" + DefaultValue.ToString() + "}", Name = key, DbType = DbType.Guid, Direction = ParameterDirection.Input });
                    }
                }
            }
    		*/
        }
    
    	protected void tmr_loader_Baanschemas_Tick(object sender, EventArgs e)
    	{
    		tmr_loader_Baanschemas.Enabled = false;
    
    		if(ClubCloud_Baanschema_DataSource.ViewName != this.ViewName)
    			ClubCloud_Baanschema_DataSource.ViewName = this.ViewName;
    
            System.Reflection.Assembly assembly = typeof(ClubCloud_BaanschemasUserControl).Assembly;
    
            if (ClubCloud_Baanschema_DataSource.Assembly == null || ClubCloud_Baanschema_DataSource.Assembly != assembly)
                ClubCloud_Baanschema_DataSource.Assembly = assembly;
    
    
    		ClubCloud_Baanschema_DataSource.View.WhereParameters = new ParameterCollection();
    
            foreach (string key in Request.QueryString.Keys)
            {
                string value = Request.QueryString[key];
                if (value != null || !string.IsNullOrWhiteSpace(value))
                {
                    Guid DefaultValue = Guid.Empty;
                    if (Guid.TryParse(value, out DefaultValue))
                    {
                        ClubCloud_Baanschema_DataSource.View.WhereParameters.Add(new Parameter { DefaultValue = "{" + DefaultValue.ToString() + "}", Name = key, DbType = DbType.Guid, Direction = ParameterDirection.Input });
                    }
                }
            }
    
    		udp_Baanschemas_progress.Visible = false;
    	}
    
    	protected void GridBaanschemas_CallingDataMethods(object sender, CallingDataMethodsEventArgs e)
    	{
    		if(ClubCloud_Baanschema_DataSource.ViewName != this.ViewName)
    			ClubCloud_Baanschema_DataSource.ViewName = this.ViewName;
    
            System.Reflection.Assembly assembly = typeof(ClubCloud_BaanschemasUserControl).Assembly;
    
            if (ClubCloud_Baanschema_DataSource.Assembly == null || ClubCloud_Baanschema_DataSource.Assembly != assembly)
                ClubCloud_Baanschema_DataSource.Assembly = assembly;
    
    		ClubCloud_Baanschema_DataSource.View.WhereParameters = new ParameterCollection();
    
            foreach (string key in Request.QueryString.Keys)
            {
                string value = Request.QueryString[key];
                if (value != null || !string.IsNullOrWhiteSpace(value))
                {
                    Guid DefaultValue = Guid.Empty;
                    if (Guid.TryParse(value, out DefaultValue))
                    {
                        ClubCloud_Baanschema_DataSource.View.WhereParameters.Add(new Parameter { DefaultValue = "{" + DefaultValue.ToString() + "}", Name = key, DbType = DbType.Guid, Direction = ParameterDirection.Input });
                    }
                }
    		}
    
    		e.DataMethodsObject = ClubCloud_Baanschema_DataSource.View;
    	}
    
        [Browsable(true)]
        public string ViewName { get; set; }
    
    }
}

