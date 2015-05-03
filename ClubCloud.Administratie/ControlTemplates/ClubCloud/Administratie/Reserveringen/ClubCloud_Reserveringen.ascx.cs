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
    
    public partial class ClubCloud_ReserveringenUserControl : UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
    
    		/*
            ClubCloud_Reservering_DataSource.ViewName = this.ViewName;
            ClubCloud_Reservering_DataSource.Assembly = typeof(ClubCloud_ReserveringenUserControl).Assembly;
    
    		ClubCloud_Reservering_DataSource.View.WhereParameters = new ParameterCollection();
    
            foreach (string key in Request.QueryString.Keys)
            {
                string value = Request.QueryString[key];
                if (value != null || !string.IsNullOrWhiteSpace(value))
                {
                    Guid DefaultValue = Guid.Empty;
                    if (Guid.TryParse(value, out DefaultValue))
                    {
                        ClubCloud_Reservering_DataSource.View.WhereParameters.Add(new Parameter { DefaultValue = "{" + DefaultValue.ToString() + "}", Name = key, DbType = DbType.Guid, Direction = ParameterDirection.Input });
                    }
                }
            }
    		*/
        }
    
    	protected void tmr_loader_Reserveringen_Tick(object sender, EventArgs e)
    	{
    		tmr_loader_Reserveringen.Enabled = false;
    
    		if(ClubCloud_Reservering_DataSource.ViewName != this.ViewName)
    			ClubCloud_Reservering_DataSource.ViewName = this.ViewName;
    
            System.Reflection.Assembly assembly = typeof(ClubCloud_ReserveringenUserControl).Assembly;
    
            if (ClubCloud_Reservering_DataSource.Assembly == null || ClubCloud_Reservering_DataSource.Assembly != assembly)
                ClubCloud_Reservering_DataSource.Assembly = assembly;
    
    
    		ClubCloud_Reservering_DataSource.View.WhereParameters = new ParameterCollection();
    
            foreach (string key in Request.QueryString.Keys)
            {
                string value = Request.QueryString[key];
                if (value != null || !string.IsNullOrWhiteSpace(value))
                {
                    Guid DefaultValue = Guid.Empty;
                    if (Guid.TryParse(value, out DefaultValue))
                    {
                        ClubCloud_Reservering_DataSource.View.WhereParameters.Add(new Parameter { DefaultValue = "{" + DefaultValue.ToString() + "}", Name = key, DbType = DbType.Guid, Direction = ParameterDirection.Input });
                    }
                }
            }
    
    		udp_Reserveringen_progress.Visible = false;
    	}
    
    	protected void GridReserveringen_CallingDataMethods(object sender, CallingDataMethodsEventArgs e)
    	{
    		if(ClubCloud_Reservering_DataSource.ViewName != this.ViewName)
    			ClubCloud_Reservering_DataSource.ViewName = this.ViewName;
    
            System.Reflection.Assembly assembly = typeof(ClubCloud_ReserveringenUserControl).Assembly;
    
            if (ClubCloud_Reservering_DataSource.Assembly == null || ClubCloud_Reservering_DataSource.Assembly != assembly)
                ClubCloud_Reservering_DataSource.Assembly = assembly;
    
    		ClubCloud_Reservering_DataSource.View.WhereParameters = new ParameterCollection();
    
            foreach (string key in Request.QueryString.Keys)
            {
                string value = Request.QueryString[key];
                if (value != null || !string.IsNullOrWhiteSpace(value))
                {
                    Guid DefaultValue = Guid.Empty;
                    if (Guid.TryParse(value, out DefaultValue))
                    {
                        ClubCloud_Reservering_DataSource.View.WhereParameters.Add(new Parameter { DefaultValue = "{" + DefaultValue.ToString() + "}", Name = key, DbType = DbType.Guid, Direction = ParameterDirection.Input });
                    }
                }
    		}
    
    		e.DataMethodsObject = ClubCloud_Reservering_DataSource.View;
    	}
    
        [Browsable(true)]
        public string ViewName { get; set; }
    
    }
}

