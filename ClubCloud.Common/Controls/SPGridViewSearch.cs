using Microsoft.SharePoint;
using Microsoft.SharePoint.Diagnostics;
using Microsoft.SharePoint.Security;
using Microsoft.SharePoint.Utilities;
using Microsoft.SharePoint.WebControls;
using System;
using System.Collections;
using System.Globalization;
using System.Security.Permissions;
using System.Threading;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ClubCloud.Common.Controls
{
    /// <summary>Represents a pager control for use with the <see cref="T:Microsoft.SharePoint.WebControls.SPGridView" /> control.</summary>
    [AspNetHostingPermission(SecurityAction.InheritanceDemand, Level=AspNetHostingPermissionLevel.Minimal)]
    [AspNetHostingPermission(SecurityAction.LinkDemand, Level=AspNetHostingPermissionLevel.Minimal)]
    public class SPGridViewSearch : System.Web.UI.WebControls.TextBox,IPostBackEventHandler// Control, 
    {
        private readonly static string SearchCommand;

        /*
        private SPGridView gridViewControl;

        /// <summary>Gets the SPGridView value that represents the grid view control.</summary>
        protected SPGridView GridViewControl
        {
            get
            {
                if (this.gridViewControl == null)
                {
                    Control control = Microsoft.SharePoint.WebControls.Menu.FindControlByWalking(this, this.GridViewId);
                    if (control == null)
                    {
                        object[] gridViewId = new object[] { this.GridViewId };
                        throw new ArgumentException(SPResource.GetString("ControlIdNotFound", gridViewId));
                    }
                    SPGridView sPGridView = control as SPGridView;
                    if (sPGridView == null)
                    {
                        object[] objArray = new object[] { this.GridViewId, "SPGridView" };
                        throw new ArgumentException(SPResource.GetString("ControlTypeIncorrect", objArray));
                    }
                    this.gridViewControl = sPGridView;
                }
                return this.gridViewControl;
            }
        }

        /// <summary>Gets or sets the string value that represents the ID of the grid view.</summary>
        public string GridViewId
        {
            get
            {
                return this.ViewState["GridViewId"] as string;
            }
            set
            {
                this.ViewState["GridViewId"] = value;
                this.gridViewControl = null;
            }
        }
        */

        private ClubCloudDataSource clubCloudDataSourceControl;

        protected ClubCloudDataSource DataSourceControl
        {
            get
            {
                if (this.clubCloudDataSourceControl == null)
                {
                    Control control = FindControlByWalking(this, this.DataSourceId);
                    if (control == null)
                    {
                        object[] clubCloudDataSourceId = new object[] { this.DataSourceId };
                        throw new ArgumentException(SPResource.GetString("ControlIdNotFound", clubCloudDataSourceId));
                    }
                    ClubCloudDataSource clubCloudDataSource = control as ClubCloudDataSource;
                    if (clubCloudDataSource == null)
                    {
                        object[] objArray = new object[] { this.DataSourceId, "DataSource" };
                        throw new ArgumentException(SPResource.GetString("ControlTypeIncorrect", objArray));
                    }
                    this.clubCloudDataSourceControl = clubCloudDataSource;
                }
                return this.clubCloudDataSourceControl;
            }
        }

        public string DataSourceId
        {
            get
            {
                return this.ViewState["DataSourceId"] as string;
            }
            set
            {
                this.ViewState["DataSourceId"] = value;
                this.clubCloudDataSourceControl = null;
            }
        }

        internal static Control FindControlByWalking(Control namingContainer, string id)
        {
            Control control = null;

            control = namingContainer.FindControl(id);
            if (control != null)
            {
                return control;
            }
            return FindControlByWalkingInner(namingContainer.Page, id);
        }

        internal static Control FindControlByWalkingInner(Control rootControl, string id)
        {
            Control control;
            if (string.Compare(rootControl.ID, id, true, CultureInfo.InvariantCulture) == 0)
            {
                return rootControl;
            }
            IEnumerator enumerator = rootControl.Controls.GetEnumerator();
            try
            {
                while (enumerator.MoveNext())
                {
                    Control control1 = FindControlByWalkingInner((Control)enumerator.Current, id);
                    if (control1 == null)
                    {
                        continue;
                    }
                    control = control1;
                    return control;
                }
                return null;
            }
            finally
            {
                IDisposable disposable = enumerator as IDisposable;
                if (disposable != null)
                {
                    disposable.Dispose();
                }
            }
            return control;
        }

        static SPGridViewSearch()
        {
            SPGridViewSearch.SearchCommand = "search";
        }

        /// <summary>Initializes a new instance of the <see cref="T:ClubCloud.Common.Controls.SPGridViewSearch" /> class.</summary>
        public SPGridViewSearch()
        {
            this.AutoCompleteType = System.Web.UI.WebControls.AutoCompleteType.Search;
            this.AutoPostBack = true;
        }

        /// <summary>Executes the <see cref="T:Microsoft.SharePoint.WebControls.SPGridView" /> selectcommand with parameters.</summary>
        /// <param name="args"></param>
        protected virtual void OnClickSearch(EventArgs args)
        {
            if (this.DataSourceControl != null)
            {
                ClubCloudDataSource clubCloudDataSourceControl = this.DataSourceControl;
                //clubCloudDataSourceControl.WhereParameters.
            }
            if (this.ClickSearch != null)
            {
                this.ClickSearch(this, args);
            }
        }

        /// <summary>Processes an event raised to this control by a form postback.</summary>
        /// <param name="eventArgument"></param>
        public void RaisePostBackEvent(string eventArgument)
        {
            string text = this.Text;

            if (eventArgument == null)
            {
                throw new ArgumentNullException("eventArgument");
            }
            EventArgs eventArg = new EventArgs();

            this.OnClickSearch(eventArg);

            /*
            if (eventArgument.ToLower(CultureInfo.InvariantCulture) == SPGridViewPager.PreviousPageCommand)
            {
                this.OnClickPrevious(eventArg);
                return;
            }
            if (eventArgument.ToLower(CultureInfo.InvariantCulture) == SPGridViewPager.NextPageCommand)
            {
                this.OnClickNext(eventArg);
            }
            */
        }

        protected override void Render(HtmlTextWriter output)
        {
            base.Render(output);

            if (this.DataSourceControl != null)
            {
                //object[] str = new object[4];
                //int pageIndex = this.GridViewControl.PageIndex;
                //str[0] = pageIndex.ToString(CultureInfo.InvariantCulture);
                //int pageCount = this.GridViewControl.PageCount;
                //str[1] = pageCount.ToString(CultureInfo.InvariantCulture);
                //int lowestDataItemIndex = this.GridViewControl.LowestDataItemIndex;
                //str[2] = lowestDataItemIndex.ToString(CultureInfo.InvariantCulture);
                //int highestDataItemIndex = this.GridViewControl.HighestDataItemIndex;
                //str[3] = highestDataItemIndex.ToString(CultureInfo.InvariantCulture);
                output.Write("<table cellpadding=\"0\" cellspacing=\"0\" border=\"0\"><tr><td valign=\"center\">");
                output.Write("<a href=\"#\" onclick=\"");
                output.Write(this.Page.ClientScript.GetPostBackEventReference(this, SPGridViewSearch.SearchCommand));
                output.Write("; return false;\">Zoeken</a>");
                //this.RenderImage(output, this.PreviousPageLinkIsEnabled, SPGridViewPager.PreviousPageCommand, SPGridViewPager.PreviousImageUrl, string.Concat("/", SPUtility.ContextLayoutsFolder, "/images/blank.gif"), SPResource.GetString("multipagesPreviousPage", new object[0]));
                //this.RenderImage(output, this.NextPageLinkIsEnabled, SPGridViewPager.NextPageCommand, SPGridViewPager.NextImageUrl, string.Concat("/", SPUtility.ContextLayoutsFolder, "/images/blank.gif"), SPResource.GetString("multipagesNextPage", new object[0]));
                output.Write("</td></tr></table>");
            }
        }

        /// <summary>Occurs when the Next button is clicked.</summary>
        public event EventHandler ClickSearch;
    }
}
