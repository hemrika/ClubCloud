using ClubCloud.Model;
using ClubCloud.Service;
using Microsoft.SharePoint;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Reflection;
using System.Web.Security;
using System.Web.UI;

namespace ClubCloud.Administratie.WebControls
{
    public class ClubCloudRolesView : DataSourceView, IStateManager
    {
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

        public ClubCloudRolesView(IDataSource owner, string viewName) : base(owner, viewName) { }

        [SPDisposeCheckIgnore(SPDisposeCheckID.SPDisposeCheckID_140, "RootWeb disposed automatically")]
        protected override IEnumerable ExecuteSelect(DataSourceSelectArguments selectArgs)
        {
            DataSet ds = new DataSet("result");

            string userId = SPContext.Current.Web.CurrentUser.UserId.NameId;
            ClubCloud_Setting Settings = Client.GetClubCloudSettings(userId);

            ClubCloud_Gebruiker_View gebruikers = Client.GetGebruikersByQuery(userId, Settings.VerenigingId.Value, selectArgs);

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

        private static void ObjectToTableConvert(Object p_obj, ref DataSet p_ds, String p_tableName)
        {

            Type t = p_obj.GetType();
            PropertyInfo[] tmpP = t.GetProperties();
            if (p_ds.Tables[p_tableName] == null)
            {
                p_ds.Tables.Add(p_tableName);

                foreach (PropertyInfo xtemp2 in tmpP)
                {
                    p_ds.Tables[p_tableName].Columns.Add(xtemp2.Name, Nullable.GetUnderlyingType(xtemp2.PropertyType) ?? xtemp2.PropertyType);
                }
            }

            Object[] tmpObj = new Object[tmpP.Length];

            for (Int32 i = 0; i <= tmpObj.Length - 1; i++)
            {
                tmpObj[i] = t.InvokeMember(tmpP[i].Name, BindingFlags.GetProperty, null, p_obj, new object[0]);

            }
            p_ds.Tables[p_tableName].LoadDataRow(tmpObj, true);
        }

        bool IStateManager.IsTrackingViewState
        {
            get { return Tracking; }
        }

        void IStateManager.LoadViewState(object state)
        {
            LoadViewState(state);
        }

        object IStateManager.SaveViewState()
        {
            return SaveViewState();
        }

        void IStateManager.TrackViewState()
        {
            TrackViewState();
        }

        private bool _tracking;
        public bool Tracking
        {
            get
            {
                return _tracking;
            }

            set
            {
                _tracking = value;
            }
        }


        protected virtual void LoadViewState(object savedState)
        {
            if (savedState != null)
            {
                ((IStateManager)this).LoadViewState(savedState);
            }
        }

        protected virtual object SaveViewState()
        {
            return ((IStateManager)this).SaveViewState();
        }

        protected virtual void TrackViewState()
        {
            _tracking = true;

            ((IStateManager)this).TrackViewState();
        }
    }
}