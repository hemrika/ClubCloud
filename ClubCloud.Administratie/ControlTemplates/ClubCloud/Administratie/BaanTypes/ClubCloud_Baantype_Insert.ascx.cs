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
    using ClubCloud.Model;
    
    public partial class ClubCloud_Baantype_InsertUserControl : UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ClubCloud_Baantype_DataSource.ViewName = this.ViewName;
            ClubCloud_Baantype_DataSource.Assembly = typeof(ClubCloud_Baantype_InsertUserControl).Assembly;
    
    		ClubCloud_Baantype_DataSource.View.WhereParameters = new ParameterCollection();
    
            foreach (string key in Request.QueryString.Keys)
            {
                string value = Request.QueryString[key];
                if (value != null || !string.IsNullOrWhiteSpace(value))
                {
                    Guid DefaultValue = Guid.Empty;
                    if (Guid.TryParse(value, out DefaultValue))
                        ClubCloud_Baantype_DataSource.View.WhereParameters.Add(new Parameter { DefaultValue = "{" + DefaultValue.ToString() + "}", Name = key, DbType = DbType.Guid, Direction = ParameterDirection.Input });
                }
    		}    
        }
    
    	[Browsable(true)]
        public string ViewName { get; set; }
    
    	protected void InsertBaantypeform_CallingDataMethods(object sender, CallingDataMethodsEventArgs e)
    	{
    		e.DataMethodsObject = ClubCloud_Baantype_DataSource.View;
    	}
    
    	protected void GoBack(object sender, EventArgs e)
    	{
    		LinkButton btn = (LinkButton)sender;
    
            if(Request.QueryString.AllKeys.Contains("IsDlg"))
    			Response.Redirect(string.Format("Baantype.aspx?Id={0}&IsDlg=1", btn.CommandArgument.ToString()));
    
            Response.Redirect(string.Format("Baantype.aspx?Id={0}", btn.CommandArgument.ToString()));
    
    	}
    
    	protected void GoBack(object sender, CommandEventArgs e)
        {
            if(Request.QueryString.AllKeys.Contains("IsDlg"))
    			Response.Redirect(string.Format("Baantype.aspx?Id={0}&IsDlg=1", e.CommandArgument.ToString()));
    
            Response.Redirect(string.Format("Baantype.aspx?Id={0}", e.CommandArgument.ToString()));
        }
    
    	protected void InsertBaantypeform_ItemInserted(object sender, FormViewInsertedEventArgs e)
        {
            if (e.Exception != null)
            {
                Baantype_Validator.ErrorMessage = e.Exception.Message;
                e.ExceptionHandled = true;
                e.KeepInInsertMode = true;
            }
            else
            {
                if (Request.QueryString.AllKeys.Contains("IsDlg"))
                {
                    Response.Write("<script type='text/javascript'>window.frameElement.commitPopup()</script>");
                    Response.Flush();
                    Response.End();
                }
                else
                {
                    Response.Redirect("Baantypes.aspx");
                }
            }
        }
    }
}

