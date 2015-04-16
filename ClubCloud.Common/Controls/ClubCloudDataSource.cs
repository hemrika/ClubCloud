using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.UI;
using System.Web.UI.Design;
using System.Web.UI.WebControls;

namespace ClubCloud.Common.Controls
{
    [PersistChildren(false), ParseChildren(true)]
    [Designer(typeof(ClubCloudDataSourceDesigner)), ToolboxData("<{0}:ClubCloudDataSource runat=\"server\"></{0}:ClubCloudDataSource>")]
    [AspNetHostingPermission(SecurityAction.Demand, Level = AspNetHostingPermissionLevel.Minimal)]
    public class ClubCloudDataSource : EntityDataSource //DataSourceControl, IDataSource, IQueryableDataSource
    {

        public ClubCloudDataSource() : base() { }

        private string _viewName;

        public string ViewName
        {
            get { return _viewName; }
            set { _viewName = value; }
        }

        private static Assembly _assembly;

        public Assembly Assembly 
        {
            get { return _assembly; }
            set { _assembly = value; }
        }


        private static ClubCloudDataSourceView _view = null;

        public ClubCloudDataSourceView View
        {
            get
            {

                if (_view == null || _view.Name != ViewName)
                {
                    try
                    {

                        List<Type> types = GetClasses(typeof(ClubCloudDataSourceView));
                        Type type = types.SingleOrDefault(v => v.Name == ViewName);
                        if (type != null)
                        {
                            var parameters = new object[2] { this, type.Name };
                            var constructor = type.GetConstructor(new Type[] { typeof(EntityDataSource), typeof(string) });
                            if (constructor != null)
                            {
                                _view = constructor.Invoke(parameters) as ClubCloudDataSourceView;

                                //if (base.IsTrackingViewState)
                                //{
                                //    ((IStateManager)_view).TrackViewState();
                                //}
                            }
                        }
                    }
                    catch (Exception)
                    {
                        _view = null;
                        //SPUtility.TransferToErrorPage(ex.Message);
                    }

                }

                return _view;
            }
            set
            {
                _view = value;
            }
        }

        /// <summary>
        /// return a strongly typed view for the current data source control
        /// </summary>
        /// <param name="viewName"></param>
        /// <returns></returns> 
        protected override DataSourceView GetView(string viewName)
        {
            if (string.IsNullOrEmpty(viewName))
            {
                viewName = ViewName;
            }

            if (_view == null || _view.Name != viewName)
            {
                try
                {
                    List<Type> types = GetClasses(typeof(ClubCloudDataSourceView));
                    Type type = types.SingleOrDefault(v => v.Name == viewName);
                    if (type != null)
                    {
                        var parameters = new object[2] { this, type.Name };
                        var constructor = type.GetConstructor(new Type[] { typeof(EntityDataSource), typeof(string) });
                        if (constructor != null)
                        {
                            _view = constructor.Invoke(parameters) as ClubCloudDataSourceView;
                            /*
                            if (base.IsTrackingViewState)
                            {
                                ((IStateManager)_view).TrackViewState();
                            }
                            */
                        }
                    }
                }
                catch (Exception)
                {
                    _view = null;
                    //SPUtility.TransferToErrorPage(ex.Message);
                }
            }
            return _view;
        }

        /// <summary>
        /// return a collection of available views
        /// </summary>
        /// <returns></returns> 
        protected override ICollection GetViewNames()
        {
            List<Type> types = GetClasses(typeof(ClubCloudDataSourceView));
            ArrayList views = new ArrayList(types.Count);
            foreach (Type type in types)
            {
                views.Add(type.Name);
            }
            return views as ICollection;
        }


        private static List<Type> GetClasses(Type baseType)
        {
            if (_assembly != null)
            {
                return _assembly.GetTypes().Where(type => type.IsSubclassOf(baseType)).ToList();
            }
            else
            {
                return Assembly.GetCallingAssembly().GetTypes().Where(type => type.IsSubclassOf(baseType)).ToList();
            }
        }
        /*
        public event EventHandler<QueryCreatedEventArgs> QueryCreated
        {
            add
            {
                base.Events.AddHandler(ClubCloudDataSourceView.EventQueryCreated, value);
            }
            remove
            {
                base.Events.RemoveHandler(ClubCloudDataSourceView.EventQueryCreated, value);
            }
        }
        */
        public void RaiseViewChanged()
        {
            ((IQueryableDataSource)this.View).RaiseViewChanged();
        }

    }
}
