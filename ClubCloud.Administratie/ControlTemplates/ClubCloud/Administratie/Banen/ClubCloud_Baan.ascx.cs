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
    
    public partial class ClubCloud_BaanUserControl : UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ClubCloud_Baan_DataSource.ViewName = this.ViewName;
            ClubCloud_Baan_DataSource.Assembly = typeof(ClubCloud_BaanUserControl).Assembly;
    
    		ClubCloud_Baan_DataSource.View.WhereParameters = new ParameterCollection();
            string value = Request.QueryString["Id"];
            if(value != null)
            {
                Guid DefaultValue = Guid.Empty;
                if(Guid.TryParse(value,out DefaultValue))
    				ClubCloud_Baan_DataSource.View.WhereParameters.Add(new Parameter { DefaultValue = "{" + DefaultValue.ToString() + "}", Name = "Id", DbType = DbType.Guid, Direction = ParameterDirection.Input });
            }
        }
    
    	[Browsable(true)]
        public string ViewName { get; set; }
    
    	protected void SelectBaanform_CallingDataMethods(object sender, CallingDataMethodsEventArgs e)
    	{
    		e.DataMethodsObject = ClubCloud_Baan_DataSource.View;
    	}
    
    	protected void GoBack(object sender, EventArgs e)
    	{
    		Response.Redirect("Banen.aspx");
    	}
    
    	protected void GoEdit(object sender, EventArgs e)
    	{
    		Response.Redirect("Baan_Edit.aspx");
    	}
    
    }
}

