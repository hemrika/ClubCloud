using Microsoft.SharePoint;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ClubCloud.Common.Controls
{
    public abstract class ClubCloudDataSourceView : DataSourceView, IStateManager//, IQueryableDataSource
    {
        public ClubCloudDataSourceView(IDataSource owner, string viewName) : base(owner, viewName) { }

        private ParameterCollection _whereParameters;

        internal readonly static object EventQueryCreated;

        private bool _isTracking;

        //Removed for external dependency
        /*
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
        */

        public static void ObjectToTableConvert(Object p_obj, ref DataSet p_ds, String p_tableName)
        {

            Type t = p_obj.GetType();
            PropertyInfo[] tmpP = t.GetProperties();// (BindingFlags.GetField);
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
                try
                {
                    tmpObj[i] = t.InvokeMember(tmpP[i].Name, BindingFlags.GetProperty, null, p_obj, new object[0]);
                }
                catch (Exception ex)
                {
                    string message = ex.Message;
                }
            }
            p_ds.Tables[p_tableName].LoadDataRow(tmpObj, true);
        }

        bool IStateManager.IsTrackingViewState
        {
            [TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")]
            get
            {
                return this._isTracking;
            }
        }

        object IStateManager.SaveViewState()
        {
            object[] objArray = new object[] { SaveViewState(this._whereParameters), null };
            return objArray;
        }

        public static object SaveViewState(ParameterCollection parameters)
        {
            if (parameters == null)
            {
                return null;
            }
            return ((IStateManager)parameters).SaveViewState();
        }

        public void LoadViewState(object state)
        {
            if (state != null)
            {
                object[] objArray = (object[])state;
                if (objArray[0] != null)
                {
                    ((IStateManager)this.WhereParameters).LoadViewState(objArray[0]);
                }
            }
        }


        public virtual ParameterCollection WhereParameters
        {
            get
            {
                if (this._whereParameters == null)
                {
                    this._whereParameters = new ParameterCollection();
                    this._whereParameters.ParametersChanged += new EventHandler(this.OnQueryParametersChanged);
                    if (this._isTracking)
                    {
                        TrackViewState(this._whereParameters);
                    }
                }
                return this._whereParameters;
            }
            set
            {
                this._whereParameters = value;
                this._whereParameters.ParametersChanged += new EventHandler(this.OnQueryParametersChanged);
                if (this._isTracking)
                {
                    TrackViewState(this._whereParameters);
                }
            }
        }

        private void TrackViewState(ParameterCollection parameterCollection)
        {
            this._isTracking = true;
            SaveViewState(parameterCollection);
        }

        [TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")]
        protected void OnQueryParametersChanged(object sender, EventArgs e)
        {
            this.OnDataSourceViewChanged(EventArgs.Empty);
        }

        void IStateManager.TrackViewState()
        {
            this._isTracking = true;
            TrackViewState(this._whereParameters);
        }

        public event EventHandler<QueryCreatedEventArgs> QueryCreated;

        /*
        public void RaiseViewChanged()
        {
            throw new NotImplementedException();
        }

        public event EventHandler DataSourceChanged;

        public DataSourceView GetView(string viewName)
        {
            throw new NotImplementedException();
        }

        public System.Collections.ICollection GetViewNames()
        {
            throw new NotImplementedException();
        }
        */
    }
}
