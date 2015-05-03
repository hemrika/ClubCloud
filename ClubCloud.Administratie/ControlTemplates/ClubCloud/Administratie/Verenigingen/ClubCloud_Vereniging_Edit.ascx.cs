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
    
    public partial class ClubCloud_Vereniging_EditUserControl : UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ClubCloud_Vereniging_DataSource.ViewName = this.ViewName;
            ClubCloud_Vereniging_DataSource.Assembly = typeof(ClubCloud_Vereniging_EditUserControl).Assembly;
    
    		ClubCloud_Vereniging_DataSource.View.WhereParameters = new ParameterCollection();
            string value = Request.QueryString["Id"];
            if(value != null)
            {
                Guid DefaultValue = Guid.Empty;
                if(Guid.TryParse(value,out DefaultValue))
                    ClubCloud_Vereniging_DataSource.View.WhereParameters.Add(new Parameter { DefaultValue = "{" + DefaultValue.ToString() + "}", Name = "Id", DbType = DbType.Guid, Direction = ParameterDirection.Input });
            }
        }
    
    	[Browsable(true)]
        public string ViewName { get; set; }
    
        protected void EditVerenigingform_CallingDataMethods(object sender, CallingDataMethodsEventArgs e)
        {
            e.DataMethodsObject = ClubCloud_Vereniging_DataSource.View;
        }
    
    	protected void GoBack(object sender, EventArgs e)
    	{
    		LinkButton btn = (LinkButton)sender;
    
            if(Request.QueryString.AllKeys.Contains("IsDlg"))
    			Response.Redirect(string.Format("Vereniging.aspx?Id={0}&IsDlg=1", btn.CommandArgument.ToString()));
    
            Response.Redirect(string.Format("Vereniging.aspx?Id={0}", btn.CommandArgument.ToString()));
    
    	}
    
    	protected void GoBack(object sender, CommandEventArgs e)
        {
            if(Request.QueryString.AllKeys.Contains("IsDlg"))
    			Response.Redirect(string.Format("Vereniging.aspx?Id={0}&IsDlg=1", e.CommandArgument.ToString()));
    
            Response.Redirect(string.Format("Vereniging.aspx?Id={0}", e.CommandArgument.ToString()));
        }
    
        public string CheckForNull(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
                return string.Empty;
    
            return input;
        }
    
        public Guid CheckForNull(Nullable<Guid> input)
        {
            if (input.HasValue)
                return input.Value;
        
            return Guid.Empty;
        }
    }
}

