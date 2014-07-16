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
    public class ClubCloudUsersView : DataSourceView
    {
        private string m_providerName = "ZimbraMembershipProvider";

        public string ProviderName
        {
            get
            {
                return this.m_providerName;
            }
        }

        private ZimbraMembershipProvider m_membershipProvider;

        public ZimbraMembershipProvider Provider
        {
            get
            {
                if (this.m_membershipProvider == null)
                {
                    this.m_membershipProvider = Membership.Providers[this.ProviderName] as ZimbraMembershipProvider;
                }
                return this.m_membershipProvider;
            }
        }

        public override bool CanRetrieveTotalRowCount
        {
            get
            {
                return true;
            }
        }

        public override bool CanPage
        {
            get
            {
                return true;
            }
        }

        public ClubCloudUsersView(IDataSource owner, string viewName) : base(owner, viewName) { }

        [SPDisposeCheckIgnore(SPDisposeCheckID.SPDisposeCheckID_140, "RootWeb disposed automatically")]
        protected override IEnumerable ExecuteSelect(DataSourceSelectArguments selectArgs)
        {
            ClubCloudDataSet ds = new ClubCloudDataSet();

            DataTable dt = new DataTable();
            dt.Columns.Add("KNLTB");
            dt.Columns.Add("Naam");
            dt.Columns.Add("Email");
            dt.Columns.Add("Commentaar");
            dt.Columns.Add("Actief");
            dt.Columns.Add("Uitgesloten");
            dt.Columns.Add("Aangemaakt");
            dt.Columns.Add("Aanmelding");

            int totalrecords;
            int pageIndex = selectArgs.StartRowIndex;
            if(pageIndex > 0)
            {
                pageIndex = (selectArgs.StartRowIndex / selectArgs.MaximumRows);
            }

            MembershipUserCollection users = Provider.GetAllUsers(pageIndex, selectArgs.MaximumRows, out totalrecords);
            selectArgs.TotalRowCount = totalrecords;

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