using ClubCloud.Common.Controls;
using ClubCloud.Model;
using Microsoft.SharePoint;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ClubCloud.Internet
{
    public class AanmeldenView : ClubCloudDataSourceView, IQueryableDataSource
    {
        public AanmeldenView(EntityDataSource owner, string viewName) : base(owner, viewName) { }

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

        protected override System.Collections.IEnumerable ExecuteSelect(System.Web.UI.DataSourceSelectArguments arguments)
        {
            DataSet ds = new DataSet("result");
            DataView dataView = new DataView();

            if (this.WhereParameters.Count > 0)
            {
                string number = this.WhereParameters[0].DefaultValue;
                ClubCloud_Vereniging vereniging = Client.GetVerenigingByNummer("00000000", number, false);

                if (vereniging != null)
                {
                    ObjectToTableConvert(vereniging, ref ds, "Verenigingen");

                    dataView = new DataView(ds.Tables["Verenigingen"]);
                }
            }

            return (IEnumerable)dataView;
        }

        public void RaiseViewChanged()
        {
            //do noting;
        }

        public event EventHandler DataSourceChanged;

        public DataSourceView GetView(string viewName)
        {
            return this;
        }

        public ICollection GetViewNames()
        {
            return new List<string> { this.Name };
            //throw new NotImplementedException();
        }
    }
}
/*
            DataSet ds = new DataSet("result");

            string userId = SPContext.Current.Web.CurrentUser.UserId.NameId;
            ClubCloud_Setting Settings = Client.GetClubCloudSettings(userId);
            
            if(string.IsNullOrEmpty(selectArgs.SortExpression))
            {
                selectArgs.SortExpression = "Volledigenaam";
            }
            List<Parameter> collection = new List<Parameter>();
            collection.Insert(0, new Parameter { DefaultValue = "Actief", Name = "Actief", DbType = DbType.String, Direction = ParameterDirection.Input });
            collection.Insert(1, new Parameter { DefaultValue = "{"+Settings.VerenigingId.Value.ToString()+"}" , Name = "VerenigingId", DbType = DbType.Guid, Direction = ParameterDirection.Input });
            foreach (Parameter where in WhereParameters)
            {
                collection.Add(where);
            }

            ClubCloud_Gebruiker_DataView gebruikers = Client.GetGebruikersByQuery(userId, Settings.VerenigingId.Value, selectArgs,collection,true);

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
*/