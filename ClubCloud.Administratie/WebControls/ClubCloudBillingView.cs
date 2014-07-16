using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Security;
using System.Web.UI;
using System.Runtime.InteropServices;
using ClubCloud.Provider;

namespace ClubCloud.Administratie.WebControls
{
    public class ClubCloudBillingView: DataSourceView
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

        public ClubCloudBillingView(IDataSource owner, string viewName) : base(owner, viewName) { }

        [SPDisposeCheckIgnore(SPDisposeCheckID.SPDisposeCheckID_140, "RootWeb disposed automatically")]
        protected override IEnumerable ExecuteSelect(DataSourceSelectArguments selectArgs)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("KNLTB");
            dt.Columns.Add("Naam");
            dt.Columns.Add("Email");
            dt.Columns.Add("Commentaar");
            dt.Columns.Add("Actief");
            dt.Columns.Add("Uitgesloten");
            dt.Columns.Add("Aangemaakt");
            dt.Columns.Add("Aanmelding");

            MembershipUserCollection users = Membership.GetAllUsers();
            foreach (MembershipUser user in users)
            {
                ZimbraMembershipUser zuser = null;
                if (user != null && user.GetType() == typeof(ZimbraMembershipUser))
                {
                    zuser = user as ZimbraMembershipUser;
                }
                if (zuser != null && !string.IsNullOrWhiteSpace(zuser.displayName))
                {
                    //Add member to the data table
                    DataRow dr = dt.NewRow();
                    dr["KNLTB"] = zuser.UserName;
                    dr["Naam"] = zuser.displayName;
                    dr["Email"] = zuser.Email;
                    dr["Commentaar"] = zuser.Comment;
                    dr["Actief"] = zuser.IsApproved ? "Yes" : "No";
                    dr["Uitgesloten"] = zuser.IsLockedOut ? "Yes" : "No";
                    dr["Aangemaakt"] = zuser.CreationDate;
                    dr["Aanmelding"] = zuser.LastLoginDate;
                    dt.Rows.Add(dr);
                }
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