using ClubCloud.Provider;
using System;
using System.Collections;
using System.Data;
using System.Web.Security;
using System.Web.UI;

namespace ClubCloud.Administratie.WebControls
{
    public class ClubCloudGroupsView: DataSourceView
    {
        private string m_providerName = "ZimbraMembershipProvider";

        public string ProviderName
        {
            get
            {
                return this.m_providerName;
            }
        }

        private MembershipProvider m_membershipProvider;
        public MembershipProvider Provider
        {
            get
            {
                if (this.m_membershipProvider == null)
                {
                    this.m_membershipProvider = Membership.Providers[this.ProviderName];
                }
                return this.m_membershipProvider;
            }
        }

        public ClubCloudGroupsView(IDataSource owner, string viewName) : base(owner, viewName) { }

        [SPDisposeCheckIgnore(SPDisposeCheckID.SPDisposeCheckID_140, "RootWeb disposed automatically")]
        protected override IEnumerable ExecuteSelect(DataSourceSelectArguments selectArgs)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Username");
            dt.Columns.Add("Email");
            dt.Columns.Add("Description");
            dt.Columns.Add("Active");
            dt.Columns.Add("Locked");
            dt.Columns.Add("Created");
            dt.Columns.Add("LastLogin");

            foreach (MembershipUser user in Membership.GetAllUsers())
            {
                ZimbraMembershipUser zuser = null;
                if (user != null && user.GetType() == typeof(ZimbraMembershipUser))
                {
                    zuser = user as ZimbraMembershipUser;
                }

                //Add member to the data table
                DataRow dr = dt.NewRow();
                dr["Username"] = zuser.UserName;
                dr["Email"] = zuser.Email;
                dr["Description"] = zuser.Comment;
                dr["Active"] = zuser.IsApproved ? "Yes" : "No";
                dr["Locked"] = zuser.IsLockedOut ? "Yes" : "No";
                dr["Created"] = zuser.CreationDate;
                dr["LastLogin"] = zuser.LastLoginDate;
                dt.Rows.Add(dr);
            }

            // sort if a sort expression available
            DataView dataView = new DataView(dt);
            if (selectArgs.SortExpression != String.Empty)
            {
                dataView.Sort = selectArgs.SortExpression;
            }

            // return as a DataList            
            return (IEnumerable)dataView;
        }
    }
}
