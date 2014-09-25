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
using ClubCloud.Service.Model;
using Microsoft.SharePoint;
using System.Reflection;
using System.Web.UI.WebControls;

namespace ClubCloud.Administratie.WebControls
{
    public class ClubCloudViewLedenNieuw : ClubCloudDataSourceView
    {


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

        public override bool CanSort
        {
            get
            {
                return true;
            }
        }

        public ClubCloudViewLedenNieuw(IDataSource owner, string viewName) : base(owner, viewName) { }


        [SPDisposeCheckIgnore(SPDisposeCheckID.SPDisposeCheckID_140, "RootWeb disposed automatically")]
        protected override IEnumerable ExecuteSelect(DataSourceSelectArguments selectArgs)
        {
            //WhereParameters[0] = new Parameter { DefaultValue = DateTime.Now.AddYears(-17).ToString(), Direction = ParameterDirection.Input, Name = "Geboortedatum", Type = TypeCode.DateTime, ConvertEmptyStringToNull = false, DbType = DbType.Date };

            DataSet ds = new DataSet("result");

            string userId = SPContext.Current.Web.CurrentUser.UserId.NameId;
            ClubCloud_Setting Settings = Client.GetClubCloudSettings(userId);
            
            if(string.IsNullOrEmpty(selectArgs.SortExpression))
            {
                selectArgs.SortExpression = "Volledigenaam";
            }

            ClubCloud_Gebruiker_DataView gebruikers = Client.GetGebruikersByQuery(userId, Settings.VerenigingId.Value, selectArgs);

            selectArgs.TotalRowCount = gebruikers.TotalRowCount;

            foreach (ClubCloud_Gebruiker gebruiker in gebruikers.ClubCloud_Gebruiker)
            {
                ObjectToTableConvert(gebruiker, ref ds, "Gebruikers");
            }

            DataView dataView = new DataView(ds.Tables["Gebruikers"]);

            if (selectArgs.SortExpression != String.Empty)
            {
                dataView.Sort = selectArgs.SortExpression;
            }

            return (IEnumerable)dataView;
        }
    }
}