using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI;
using System.Web.UI.Design;

namespace ClubCloud.Common.Controls
{
    public class ClubCloudDataSourceDesigner : DataSourceDesigner
    {
        private ClubCloudDataSource _control;

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

        public override void Initialize(IComponent component)
        {
            base.Initialize(component);
            _control = (ClubCloudDataSource)Component;
        }

        private static DesignerDataSourceView _view = null;

        public override DesignerDataSourceView GetView(string viewName)
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
                            _view = constructor.Invoke(parameters) as DesignerDataSourceView;
                            /*
                            if (base.IsTrackingViewState)
                            {
                                ((IStateManager)_view).TrackViewState();
                            }
                            */
                        }
                    }
                }
                catch (Exception ex)
                {
                    Logger.WriteLog(Logger.Category.Unexpected, ex.Source, ex.Message);
                    _view = null;
                    //SPUtility.TransferToErrorPage(ex.Message);
                }
            }
            return _view;
        }


        public override string[] GetViewNames()
        {
            List<Type> types = GetClasses(typeof(ClubCloudDataSourceView));
            string[] views = new string[types.Count];
            //ArrayList views = new ArrayList(types.Count);
            int i = 0;
            foreach (Type type in types)
            {
                views[i] = type.Name;//.Add(type.Name);
                i++;
            }
            return views;
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
    }
}
