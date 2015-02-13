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
using ClubCloud.Model;
using Microsoft.SharePoint;
using System.Reflection;
using System.Web.UI.WebControls;
using ClubCloud.Common.Controls;

namespace ClubCloud.Administratie.WebControls
{
    public class ClubCloudViewLedenJunior : ClubCloudDataSourceView
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

        private ClubCloud.Service.ClubCloudServiceClient _client = null;

        public ClubCloud.Service.ClubCloudServiceClient Client
        {
            get
            {
                if (_client == null)
                {
                    _client = new Service.ClubCloudServiceClient(SPServiceContext.Current);
                }
                return _client;
            }
        }

        public ClubCloudViewLedenJunior(IDataSource owner, string viewName) : base(owner, viewName) { }


        [SPDisposeCheckIgnore(SPDisposeCheckID.SPDisposeCheckID_140, "RootWeb disposed automatically")]
        protected override IEnumerable ExecuteSelect(DataSourceSelectArguments selectArgs)
        {
            //WhereParameters.Insert(0, new Parameter { DefaultValue = DateTime.Now.AddYears(-17).ToString(), Direction = ParameterDirection.Input, Name = "Geboortedatum", Type = TypeCode.DateTime, ConvertEmptyStringToNull = false, DbType = DbType.Date });
            DataSet ds = new DataSet("result");

            string userId = SPContext.Current.Web.CurrentUser.UserId.NameId;
            ClubCloud_Setting Settings = Client.GetClubCloudSettings(userId);

            if (string.IsNullOrEmpty(selectArgs.SortExpression))
            {
                selectArgs.SortExpression = "Volledigenaam";
            }

            List<Parameter> collection = new List<Parameter>();
            collection.Insert(0, new Parameter { DefaultValue = "Actief", Name = "Actief", DbType = DbType.String, Direction = ParameterDirection.Input });
            collection.Insert(1, new Parameter { DefaultValue = "{" + Settings.VerenigingId.Value.ToString() + "}", Name = "VerenigingId", DbType = DbType.Guid, Direction = ParameterDirection.Input });
            collection.Insert(1, new Parameter { DefaultValue = "{" + Settings.VerenigingId.Value.ToString() + "}", Name = "VerenigingId", DbType = DbType.Guid, Direction = ParameterDirection.Input });
            foreach (Parameter where in WhereParameters)
            {
                collection.Add(where);
            }

            ClubCloud_Gebruiker_DataView gebruikers = Client.GetGebruikersByQuery(userId, Settings.VerenigingId.Value, selectArgs, collection);

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