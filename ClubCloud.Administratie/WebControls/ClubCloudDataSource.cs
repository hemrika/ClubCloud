/*
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Security.Permissions;
using System.Web;
using System.Web.UI;
using System.Web.UI.Design;
using System.Web.UI.WebControls;

namespace ClubCloud.Administratie.WebControls
{
    [PersistChildren(false), ParseChildren(true)]
    [Designer(typeof(DataSourceDesigner))]
    [AspNetHostingPermission(SecurityAction.Demand, Level = AspNetHostingPermissionLevel.Minimal)]
    public class ClubCloudDataSource : DataSourceControl, IDataSource, IQueryableDataSource
    {

        public ClubCloudDataSource() : base() { }

        private string _viewName;

        public string ViewName
        {
            get { return _viewName; }
            set { _viewName = value; }
        }

        private static DataSourceView _view = null;

        protected DataSourceView View
        {
            get
            {

                if (_view == null && !string.IsNullOrEmpty(ViewName))
                {
                    try
                    {

                        List<Type> types = GetClasses(typeof(ClubCloudDataSourceView));
                        Type type = types.SingleOrDefault(v => v.Name == ViewName);
                        if (type != null)
                        {
                            var parameters = new object[2] { this, type.Name };
                            var constructor = type.GetConstructor(new Type[] { typeof(IDataSource), typeof(string) });
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

            if (_view == null)
            {
                try
                {
                    List<Type> types = GetClasses(typeof(ClubCloudDataSourceView));
                    Type type = types.SingleOrDefault(v => v.Name == viewName);
                    if (type != null)
                    {
                        var parameters = new object[2] { this, type.Name };
                        var constructor = type.GetConstructor(new Type[] { typeof(IDataSource), typeof(string) });
                        if (constructor != null)
                        {
                            _view = constructor.Invoke(parameters) as ClubCloudDataSourceView;
                            //
                            //if (base.IsTrackingViewState)
                            //{
                            //    ((IStateManager)_view).TrackViewState();
                            //}
                            //
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


        public static List<Type> GetClasses(Type baseType)
        {
            return Assembly.GetCallingAssembly().GetTypes().Where(type => type.IsSubclassOf(baseType)).ToList();
        }

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

        public void RaiseViewChanged()
        {
            ((IQueryableDataSource)this.View).RaiseViewChanged();
        }
    }

}
*/