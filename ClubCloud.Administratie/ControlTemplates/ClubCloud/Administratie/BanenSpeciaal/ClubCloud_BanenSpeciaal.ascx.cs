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
    
    public partial class ClubCloud_BanenSpeciaalUserControl : UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
    
    		/*
            ClubCloud_BaanSpeciaal_DataSource.ViewName = this.ViewName;
            ClubCloud_BaanSpeciaal_DataSource.Assembly = typeof(ClubCloud_BanenSpeciaalUserControl).Assembly;
    
    		ClubCloud_BaanSpeciaal_DataSource.View.WhereParameters = new ParameterCollection();
    
            if (Request.QueryString.HasKeys())
            {
                foreach (String key in Request.QueryString.AllKeys)
                {
                    string value = Request.QueryString[key];
                    if (value != null)
                    {
                        Guid DefaultValue = Guid.Empty;
                        if (Guid.TryParse(value, out DefaultValue))
    					{
    						ClubCloud_BaanSpeciaal_DataSource.View.WhereParameters.Add(new Parameter { DefaultValue = "{" + DefaultValue.ToString() + "}", Name = key, DbType = DbType.Guid, Direction = ParameterDirection.Input });
    					}
    				}      
    			}
    		}
    		*/
        }
    
    	protected void tmr_loader_BanenSpeciaal_Tick(object sender, EventArgs e)
    	{
    		tmr_loader_BanenSpeciaal.Enabled = false;
    
    		if(ClubCloud_BaanSpeciaal_DataSource.ViewName != this.ViewName)
    			ClubCloud_BaanSpeciaal_DataSource.ViewName = this.ViewName;
    
            System.Reflection.Assembly assembly = typeof(ClubCloud_BanenSpeciaalUserControl).Assembly;
    
            if (ClubCloud_BaanSpeciaal_DataSource.Assembly == null || ClubCloud_BaanSpeciaal_DataSource.Assembly != assembly)
                ClubCloud_BaanSpeciaal_DataSource.Assembly = assembly;
    
    
    		ClubCloud_BaanSpeciaal_DataSource.View.WhereParameters = new ParameterCollection();
    
            if (Request.QueryString.HasKeys())
            {
                foreach (String key in Request.QueryString.AllKeys)
                {
                    string value = Request.QueryString[key];
                    if (value != null)
                    {
                        Guid DefaultValue = Guid.Empty;
                        if (Guid.TryParse(value, out DefaultValue))
    					{
    						ClubCloud_BaanSpeciaal_DataSource.View.WhereParameters.Add(new Parameter { DefaultValue = "{" + DefaultValue.ToString() + "}", Name = key, DbType = DbType.Guid, Direction = ParameterDirection.Input });
    					}
    				}      
    			}
    		}
    
    		udp_BanenSpeciaal_progress.Visible = false;
    	}
    
    	protected void GridBanenSpeciaal_CallingDataMethods(object sender, CallingDataMethodsEventArgs e)
    	{
    		if(ClubCloud_BaanSpeciaal_DataSource.ViewName != this.ViewName)
    			ClubCloud_BaanSpeciaal_DataSource.ViewName = this.ViewName;
    
            System.Reflection.Assembly assembly = typeof(ClubCloud_BanenSpeciaalUserControl).Assembly;
    
            if (ClubCloud_BaanSpeciaal_DataSource.Assembly == null || ClubCloud_BaanSpeciaal_DataSource.Assembly != assembly)
                ClubCloud_BaanSpeciaal_DataSource.Assembly = assembly;
    
    		ClubCloud_BaanSpeciaal_DataSource.View.WhereParameters = new ParameterCollection();
    
            foreach (string key in Request.QueryString.Keys)
            {
                string value = Request.QueryString[key];
                if (value != null || !string.IsNullOrWhiteSpace(value))
                {
                    Guid DefaultValue = Guid.Empty;
                    if (Guid.TryParse(value, out DefaultValue))
                    {
                        ClubCloud_BaanSpeciaal_DataSource.View.WhereParameters.Add(new Parameter { DefaultValue = "{" + DefaultValue.ToString() + "}", Name = key, DbType = DbType.Guid, Direction = ParameterDirection.Input });
                    }
                }
    		}
    
    		e.DataMethodsObject = ClubCloud_BaanSpeciaal_DataSource.View;
    	}
    
        [Browsable(true)]
        public string ViewName { get; set; }
    
    }
}
