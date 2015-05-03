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
    
    public partial class ClubCloud_BanenUserControl : UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
    
    		/*
            ClubCloud_Baan_DataSource.ViewName = this.ViewName;
            ClubCloud_Baan_DataSource.Assembly = typeof(ClubCloud_BanenUserControl).Assembly;
    
    		ClubCloud_Baan_DataSource.View.WhereParameters = new ParameterCollection();
    
            foreach (string key in Request.QueryString.Keys)
            {
                string value = Request.QueryString[key];
                if (value != null || !string.IsNullOrWhiteSpace(value))
                {
                    Guid DefaultValue = Guid.Empty;
                    if (Guid.TryParse(value, out DefaultValue))
                    {
                        ClubCloud_Baan_DataSource.View.WhereParameters.Add(new Parameter { DefaultValue = "{" + DefaultValue.ToString() + "}", Name = key, DbType = DbType.Guid, Direction = ParameterDirection.Input });
                    }
                }
            }
    		*/
        }
    
    	protected void tmr_loader_Banen_Tick(object sender, EventArgs e)
    	{
    		tmr_loader_Banen.Enabled = false;
    
    		if(ClubCloud_Baan_DataSource.ViewName != this.ViewName)
    			ClubCloud_Baan_DataSource.ViewName = this.ViewName;
    
            System.Reflection.Assembly assembly = typeof(ClubCloud_BanenUserControl).Assembly;
    
            if (ClubCloud_Baan_DataSource.Assembly == null || ClubCloud_Baan_DataSource.Assembly != assembly)
                ClubCloud_Baan_DataSource.Assembly = assembly;
    
    
    		ClubCloud_Baan_DataSource.View.WhereParameters = new ParameterCollection();
    
            foreach (string key in Request.QueryString.Keys)
            {
                string value = Request.QueryString[key];
                if (value != null || !string.IsNullOrWhiteSpace(value))
                {
                    Guid DefaultValue = Guid.Empty;
                    if (Guid.TryParse(value, out DefaultValue))
                    {
                        ClubCloud_Baan_DataSource.View.WhereParameters.Add(new Parameter { DefaultValue = "{" + DefaultValue.ToString() + "}", Name = key, DbType = DbType.Guid, Direction = ParameterDirection.Input });
                    }
                }
            }
    
    		udp_Banen_progress.Visible = false;
    	}
    
    	protected void GridBanen_CallingDataMethods(object sender, CallingDataMethodsEventArgs e)
    	{
    		if(ClubCloud_Baan_DataSource.ViewName != this.ViewName)
    			ClubCloud_Baan_DataSource.ViewName = this.ViewName;
    
            System.Reflection.Assembly assembly = typeof(ClubCloud_BanenUserControl).Assembly;
    
            if (ClubCloud_Baan_DataSource.Assembly == null || ClubCloud_Baan_DataSource.Assembly != assembly)
                ClubCloud_Baan_DataSource.Assembly = assembly;
    
    		ClubCloud_Baan_DataSource.View.WhereParameters = new ParameterCollection();
    
            foreach (string key in Request.QueryString.Keys)
            {
                string value = Request.QueryString[key];
                if (value != null || !string.IsNullOrWhiteSpace(value))
                {
                    Guid DefaultValue = Guid.Empty;
                    if (Guid.TryParse(value, out DefaultValue))
                    {
                        ClubCloud_Baan_DataSource.View.WhereParameters.Add(new Parameter { DefaultValue = "{" + DefaultValue.ToString() + "}", Name = key, DbType = DbType.Guid, Direction = ParameterDirection.Input });
                    }
                }
    		}
    
    		e.DataMethodsObject = ClubCloud_Baan_DataSource.View;
    	}
    
        [Browsable(true)]
        public string ViewName { get; set; }
    
    }
}

