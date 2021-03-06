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
    
    public partial class ClubCloud_AddressenUserControl : UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
    
    		/*
            ClubCloud_Address_DataSource.ViewName = this.ViewName;
            ClubCloud_Address_DataSource.Assembly = typeof(ClubCloud_AddressenUserControl).Assembly;
    
    		ClubCloud_Address_DataSource.View.WhereParameters = new ParameterCollection();
    
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
    						if(key == "Id")
    						{
    
    							ClubCloud_Address_DataSource.View.WhereParameters.Add(new Parameter { DefaultValue = "{" + DefaultValue.ToString() + "}", Name = "ParentId", DbType = DbType.Guid, Direction = ParameterDirection.Input });
    						}
    						else
    						{
    							ClubCloud_Address_DataSource.View.WhereParameters.Add(new Parameter { DefaultValue = "{" + DefaultValue.ToString() + "}", Name = key, DbType = DbType.Guid, Direction = ParameterDirection.Input });
    						}
    					}
    				}      
    			}
    		}
    		*/
        }
    
    	protected void tmr_loader_Addressen_Tick(object sender, EventArgs e)
    	{
    		tmr_loader_Addressen.Enabled = false;
    
    		if(ClubCloud_Address_DataSource.ViewName != this.ViewName)
    			ClubCloud_Address_DataSource.ViewName = this.ViewName;
    
            System.Reflection.Assembly assembly = typeof(ClubCloud_AddressenUserControl).Assembly;
    
            if (ClubCloud_Address_DataSource.Assembly == null || ClubCloud_Address_DataSource.Assembly != assembly)
                ClubCloud_Address_DataSource.Assembly = assembly;
    
    
    		ClubCloud_Address_DataSource.View.WhereParameters = new ParameterCollection();
    
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
    						if(key == "Id")
    						{
    
    							ClubCloud_Address_DataSource.View.WhereParameters.Add(new Parameter { DefaultValue = "{" + DefaultValue.ToString() + "}", Name = "ParentId", DbType = DbType.Guid, Direction = ParameterDirection.Input });
    						}
    						else
    						{
    							ClubCloud_Address_DataSource.View.WhereParameters.Add(new Parameter { DefaultValue = "{" + DefaultValue.ToString() + "}", Name = key, DbType = DbType.Guid, Direction = ParameterDirection.Input });
    						}
    					}
    				}      
    			}
    		}
    
    		udp_Addressen_progress.Visible = false;
    	}
    
    	protected void GridAddressen_CallingDataMethods(object sender, CallingDataMethodsEventArgs e)
    	{
    		if(ClubCloud_Address_DataSource.ViewName != this.ViewName)
    			ClubCloud_Address_DataSource.ViewName = this.ViewName;
    
            System.Reflection.Assembly assembly = typeof(ClubCloud_AddressenUserControl).Assembly;
    
            if (ClubCloud_Address_DataSource.Assembly == null || ClubCloud_Address_DataSource.Assembly != assembly)
                ClubCloud_Address_DataSource.Assembly = assembly;
    
    		ClubCloud_Address_DataSource.View.WhereParameters = new ParameterCollection();
    
            foreach (string key in Request.QueryString.Keys)
            {
                string value = Request.QueryString[key];
                if (value != null || !string.IsNullOrWhiteSpace(value))
                {
                    Guid DefaultValue = Guid.Empty;
                    if (Guid.TryParse(value, out DefaultValue))
                    {
    						ClubCloud_Address_DataSource.View.WhereParameters.Add(new Parameter { DefaultValue = "{" + DefaultValue.ToString() + "}", Name = "ParentId", DbType = DbType.Guid, Direction = ParameterDirection.Input });
                    }
                }
    		}
    
    		e.DataMethodsObject = ClubCloud_Address_DataSource.View;
    	}
    
        [Browsable(true)]
        public string ViewName { get; set; }
    
    }
}

