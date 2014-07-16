using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Collections;
using System.Web.UI;
using Microsoft.SharePoint.Utilities;
using System.Reflection;

namespace ClubCloud.Administratie.WebControls
{
    public class ClubCloudDataSource: DataSourceControl
    {
        private string _viewName;
        private DataSourceView _view = null;

        public ClubCloudDataSource() : base() { }

        public string ViewName
        {
            get { return _viewName; }
            set { _viewName = value; }
        }

        /// <summary>
        /// return a strongly typed view for the current data source control
        /// </summary>
        /// <param name="viewName"></param>
        /// <returns></returns> 
        protected override DataSourceView GetView(string viewName)
        {
            // only retrieve a view if a membership provider can be found
            if (_view == null)
            {
                try
                {
                    switch (viewName)
                    {

                        case "UsersView":
                            _view = new ClubCloudUsersView(this, viewName);
                            break;
                        case "RolesView":
                            _view = new ClubCloudRolesView(this, viewName);
                            break;
                        case "GroupsViews":
                            _view = new ClubCloudGroupsView(this, viewName);
                            break;

                        default:
                            GetView(ViewName);
                            break;
                    }
                }
                catch (Exception ex)
                {
                    SPUtility.TransferToErrorPage(ex.Message);
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
            List<Type> types = GetClasses(typeof(DataSourceView));
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
    }

}
