namespace ClubCloud.Administratie.WebControls
{
    using System;
    using System.ComponentModel;
    using System.Data;
    using System.Linq;
    using System.Web.UI;
    using System.Web.UI.WebControls;
    using System.Web.UI.WebControls.WebParts;
    using System.Data.Entity.Infrastructure;
    
    public partial class ClubCloud_ReserveringUserControl : UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ClubCloud_Reservering_DataSource.ViewName = this.ViewName;
            ClubCloud_Reservering_DataSource.Assembly = typeof(ClubCloud_ReserveringUserControl).Assembly;
    
    		ClubCloud_Reservering_DataSource.View.WhereParameters = new ParameterCollection();
    
            foreach (string key in Request.QueryString.Keys)
            {
                string value = Request.QueryString[key];
                if (value != null || !string.IsNullOrWhiteSpace(value))
                {
                    Guid DefaultValue = Guid.Empty;
                    if (Guid.TryParse(value, out DefaultValue))
                        ClubCloud_Reservering_DataSource.View.WhereParameters.Add(new Parameter { DefaultValue = "{" + DefaultValue.ToString() + "}", Name = key, DbType = DbType.Guid, Direction = ParameterDirection.Input });
                }
    		}    
    	}
    
    	[Browsable(true)]
        public string ViewName { get; set; }
    
    	protected void SelectReserveringform_CallingDataMethods(object sender, CallingDataMethodsEventArgs e)
    	{
    		e.DataMethodsObject = ClubCloud_Reservering_DataSource.View;
    	}
    
    	protected void GoBack(object sender, EventArgs e)
    	{
    		Response.Clear();
            Response.Write("<script type=\"text/javascript\">window.frameElement.commonModalDialogClose(1);</script>"); 
            Response.End();
    
    		//Response.Redirect("Reserveringen.aspx");
    	}
    
    	protected void GoEdit(object sender, EventArgs e)
    	{
    		LinkButton btn = (LinkButton)sender;
    
            if(Request.QueryString.AllKeys.Contains("IsDlg"))
    			Response.Redirect(string.Format("Reservering_Edit.aspx?Id={0}&IsDlg=1", btn.CommandArgument.ToString()));
    
            Response.Redirect(string.Format("Reservering_Edit.aspx?Id={0}", btn.CommandArgument.ToString()));
    
    	}
    
    	protected void GoEdit(object sender, CommandEventArgs e)
        {
            if(Request.QueryString.AllKeys.Contains("IsDlg"))
    			Response.Redirect(string.Format("Reservering_Edit.aspx?Id={0}&IsDlg=1", e.CommandArgument.ToString()));
    
            Response.Redirect(string.Format("Reservering_Edit.aspx?Id={0}", e.CommandArgument.ToString()));
        }
    }
}

