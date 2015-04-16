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
    
    public partial class ClubCloud_GebruikerUserControl : UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ClubCloud_Gebruiker_DataSource.ViewName = this.ViewName;
            ClubCloud_Gebruiker_DataSource.Assembly = typeof(ClubCloud_GebruikerUserControl).Assembly;
    
    		ClubCloud_Gebruiker_DataSource.View.WhereParameters = new ParameterCollection();
            string value = Request.QueryString["Id"];
            if(value != null)
            {
                Guid DefaultValue = Guid.Empty;
                if(Guid.TryParse(value,out DefaultValue))
    				ClubCloud_Gebruiker_DataSource.View.WhereParameters.Add(new Parameter { DefaultValue = "{" + DefaultValue.ToString() + "}", Name = "Id", DbType = DbType.Guid, Direction = ParameterDirection.Input });
            }
        }
    
    	[Browsable(true)]
        public string ViewName { get; set; }
    
    	protected void SelectGebruikerform_CallingDataMethods(object sender, CallingDataMethodsEventArgs e)
    	{
    		e.DataMethodsObject = ClubCloud_Gebruiker_DataSource.View;
    	}
    
    	protected void GoBack(object sender, EventArgs e)
    	{
    		Response.Redirect("Gebruikers.aspx");
    	}
    
    	protected void GoEdit(object sender, EventArgs e)
    	{
    		Response.Redirect("Gebruiker_Edit.aspx");
    	}
    
    }
}

