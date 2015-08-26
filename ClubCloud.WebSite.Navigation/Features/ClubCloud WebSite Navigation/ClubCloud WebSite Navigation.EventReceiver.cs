using System;
using System.Runtime.InteropServices;
using System.Security.Permissions;
using Microsoft.SharePoint;
using Microsoft.SharePoint.Administration;

namespace ClubCloud.WebSite.Navigation.Features.ClubCloud_WebSite_Navigation
{
    /// <summary>
    /// This class handles events raised during feature activation, deactivation, installation, uninstallation, and upgrade.
    /// </summary>
    /// <remarks>
    /// The GUID attached to this class may be used during packaging and should not be modified.
    /// </remarks>

    [Guid("415cb657-278f-4fea-b4f1-dba7e7ea961a")]
    public class ClubCloud_WebSite_NavigationEventReceiver : SPFeatureReceiver
    {
        // Uncomment the method below to handle the event raised after a feature has been activated.

        public override void FeatureActivated(SPFeatureReceiverProperties properties)
        {
            try
            {
                SPWeb web = properties.Feature.Parent as SPWeb;

                SPList navigation = web.Lists.TryGetList("Navigation");

                if (navigation.BaseTemplate.ToString() == "20005")
                {
                    ConsistantLookup(navigation);
                }
            }
            catch (Exception ex)
            {
                SPDiagnosticsService.Local.WriteTrace(0, new SPDiagnosticsCategory(ex.Source, TraceSeverity.High, EventSeverity.Error), TraceSeverity.High, ex.Message, ex.Data);
                //ex.ToString();
            }
        }


        // Uncomment the method below to handle the event raised before a feature is deactivated.

        //public override void FeatureDeactivating(SPFeatureReceiverProperties properties)
        //{
        //}


        // Uncomment the method below to handle the event raised after a feature has been installed.

        //public override void FeatureInstalled(SPFeatureReceiverProperties properties)
        //{
        //}


        // Uncomment the method below to handle the event raised before a feature is uninstalled.

        //public override void FeatureUninstalling(SPFeatureReceiverProperties properties)
        //{
        //}

        // Uncomment the method below to handle the event raised when a feature is upgrading.

        public override void FeatureUpgrading(SPFeatureReceiverProperties properties, string upgradeActionName, System.Collections.Generic.IDictionary<string, string> parameters)
        {
            try
            {
                SPWeb web = properties.Feature.Parent as SPWeb;

                SPList navigation = web.Lists.TryGetList("Navigation");

                if (navigation.BaseTemplate.ToString() == "20005")
                {
                    ConsistantLookup(navigation);
                }
            }
            catch (Exception ex)
            {
                SPDiagnosticsService.Local.WriteTrace(0, new SPDiagnosticsCategory(ex.Source, TraceSeverity.High, EventSeverity.Error), TraceSeverity.High, ex.Message, ex.Data);
                //ex.ToString();
            }
        }

        private void ConsistantLookup(SPList navigation)
        {
            SPFieldLookup lookupField = (SPFieldLookup)navigation.Fields["Parent"];

            if (string.IsNullOrEmpty(lookupField.LookupList))
            {
                if (lookupField.LookupWebId != navigation.ParentWeb.ID)
                {
                    lookupField.LookupWebId = navigation.ParentWeb.ID;
                }
                if (lookupField.LookupList != navigation.ID.ToString())
                {
                    lookupField.LookupList = navigation.ID.ToString();
                }
            }
            else
            {
                string schema = lookupField.SchemaXml;
                schema = ReplaceXmlAttributeValue(schema, "List", navigation.ID.ToString());
                schema = ReplaceXmlAttributeValue(schema, "WebId", navigation.ID.ToString());
                lookupField.SchemaXml = schema;
            }

            lookupField.Update(true);

        }

        private static string ReplaceXmlAttributeValue(string xml, string attributeName, string value)
        {
            if (string.IsNullOrEmpty(xml))
            {
                throw new ArgumentNullException("xml");
            }

            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentNullException("value");
            }


            int indexOfAttributeName = xml.IndexOf(attributeName, StringComparison.CurrentCultureIgnoreCase);
            if (indexOfAttributeName == -1)
            {
                throw new ArgumentOutOfRangeException("attributeName", string.Format("Attribute {0} not found in source xml", attributeName));
            }

            int indexOfAttibuteValueBegin = xml.IndexOf('"', indexOfAttributeName);
            int indexOfAttributeValueEnd = xml.IndexOf('"', indexOfAttibuteValueBegin + 1);

            return xml.Substring(0, indexOfAttibuteValueBegin + 1) + value + xml.Substring(indexOfAttributeValueEnd);
        }
    }
}
