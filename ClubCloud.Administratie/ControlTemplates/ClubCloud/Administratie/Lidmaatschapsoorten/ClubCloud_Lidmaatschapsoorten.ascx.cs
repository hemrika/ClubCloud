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
    
    public partial class ClubCloud_LidmaatschapsoortenUserControl : UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
    		udp_Lidmaatschapsoorten_progress.Visible = true;
    		/*
            ClubCloud_Lidmaatschapsoort_DataSource.ViewName = this.ViewName;
            ClubCloud_Lidmaatschapsoort_DataSource.Assembly = typeof(ClubCloud_LidmaatschapsoortenUserControl).Assembly;
    
    		ClubCloud_Lidmaatschapsoort_DataSource.View.WhereParameters = new ParameterCollection();
    
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
    						ClubCloud_Lidmaatschapsoort_DataSource.View.WhereParameters.Add(new Parameter { DefaultValue = "{" + DefaultValue.ToString() + "}", Name = key, DbType = DbType.Guid, Direction = ParameterDirection.Input });
    					}
    				}      
    			}
    		}
    		*/
        }
    
    	protected void tmr_loader_Lidmaatschapsoorten_Tick(object sender, EventArgs e)
    	{
    		tmr_loader_Lidmaatschapsoorten.Enabled = false;
    
    		/*
    		if(ClubCloud_Lidmaatschapsoort_DataSource.ViewName != this.ViewName)
    			ClubCloud_Lidmaatschapsoort_DataSource.ViewName = this.ViewName;
    
            System.Reflection.Assembly assembly = typeof(ClubCloud_LidmaatschapsoortenUserControl).Assembly;
    
            if (ClubCloud_Lidmaatschapsoort_DataSource.Assembly == null || ClubCloud_Lidmaatschapsoort_DataSource.Assembly != assembly)
                ClubCloud_Lidmaatschapsoort_DataSource.Assembly = assembly;
    
    
    		ClubCloud_Lidmaatschapsoort_DataSource.View.WhereParameters = new ParameterCollection();
    
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
    						ClubCloud_Lidmaatschapsoort_DataSource.View.WhereParameters.Add(new Parameter { DefaultValue = "{" + DefaultValue.ToString() + "}", Name = key, DbType = DbType.Guid, Direction = ParameterDirection.Input });
    					}
    				}      
    			}
    		}
    		*/
    
    		udp_Lidmaatschapsoorten_progress.Visible = false;
    	}
    
    	protected void GridLidmaatschapsoorten_CallingDataMethods(object sender, CallingDataMethodsEventArgs e)
    	{
    		
    
    		if(ClubCloud_Lidmaatschapsoort_DataSource.ViewName != this.ViewName)
    			ClubCloud_Lidmaatschapsoort_DataSource.ViewName = this.ViewName;
    
            System.Reflection.Assembly assembly = typeof(ClubCloud_LidmaatschapsoortenUserControl).Assembly;
    
            if (ClubCloud_Lidmaatschapsoort_DataSource.Assembly == null || ClubCloud_Lidmaatschapsoort_DataSource.Assembly != assembly)
                ClubCloud_Lidmaatschapsoort_DataSource.Assembly = assembly;
    
    		ClubCloud_Lidmaatschapsoort_DataSource.View.WhereParameters = new ParameterCollection();
    
            foreach (string key in Request.QueryString.Keys)
            {
                string value = Request.QueryString[key];
                if (value != null || !string.IsNullOrWhiteSpace(value))
                {
                    Guid DefaultValue = Guid.Empty;
                    if (Guid.TryParse(value, out DefaultValue))
                    {
                        ClubCloud_Lidmaatschapsoort_DataSource.View.WhereParameters.Add(new Parameter { DefaultValue = "{" + DefaultValue.ToString() + "}", Name = key, DbType = DbType.Guid, Direction = ParameterDirection.Input });
                    }
                }
    		}
    		e.DataMethodsObject = ClubCloud_Lidmaatschapsoort_DataSource.View;
    		udp_Lidmaatschapsoorten_progress.Visible = false;
    	}
    
        [Browsable(true)]
        public string ViewName { get; set; }
    
    }
}

