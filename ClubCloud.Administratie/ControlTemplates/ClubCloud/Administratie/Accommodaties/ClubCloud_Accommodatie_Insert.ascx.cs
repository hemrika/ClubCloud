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
    
    public partial class ClubCloud_Accommodatie_InsertUserControl : UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ClubCloud_Accommodatie_DataSource.ViewName = this.ViewName;
            ClubCloud_Accommodatie_DataSource.Assembly = typeof(ClubCloud_Accommodatie_InsertUserControl).Assembly;
    
    		ClubCloud_Accommodatie_DataSource.View.WhereParameters = new ParameterCollection();
        }
    
    	[Browsable(true)]
        public string ViewName { get; set; }
    
    	protected void InsertAccommodatieform_CallingDataMethods(object sender, CallingDataMethodsEventArgs e)
    	{
    		e.DataMethodsObject = ClubCloud_Accommodatie_DataSource.View;
    	}
    
    	protected void GoBack(object sender, EventArgs e)
    	{
    		Response.Redirect("Accommodaties.aspx");
    	}
    }
}

