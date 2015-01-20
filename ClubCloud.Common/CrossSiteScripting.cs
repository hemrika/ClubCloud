using Microsoft.SharePoint.Administration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubCloud.Common
{
    internal class CrossSiteScripting
    {
        #region Modifications

        private static List<SPWebConfigModification> _modifications;

        public static List<SPWebConfigModification> Modifications
        {
            get {
                _modifications = new List<SPWebConfigModification>();

                AddCustomHeaders();

                return _modifications; 
            }
        }

        private static void AddCustomHeaders()
        {
            /*
            var configModcustomHeadersOrigin = new SPWebConfigModification
            {
                Name = "add[@name='Access-Control-Allow-Origin'][@value='http://fromhere.kc-dev.com']",
                Owner = "ClubCloud",
                Path = "configuration/system.webServer/httpProtocol/customHeaders",
                Type = SPWebConfigModification.SPWebConfigModificationType.EnsureChildNode,
                Value = "<add tagPrefix='ajaxToolkit' assembly='AjaxControlToolkit, Version=4.5.7.1213, Culture=neutral, PublicKeyToken=28f01b0e84b6d53e' namespace='AjaxControlToolkit' />"

            };
            _modifications.Add(configModcustomHeadersOrigin);
            */

            var configModcustomHeadersMethod = new SPWebConfigModification
            {
                Name = "add[@name='Access-Control-Request-Method'][@value='GET,POST,HEAD,OPTIONS']",
                Owner = "ClubCloud",
                Sequence = 0,
                Path = "configuration/system.webServer/httpProtocol/customHeaders",
                Type = SPWebConfigModification.SPWebConfigModificationType.EnsureChildNode,
                Value = "<add name='Access-Control-Request-Method' value='GET,POST,HEAD,OPTIONS' />"

            };
            _modifications.Add(configModcustomHeadersMethod);

            var configModcustomHeadersHeaders = new SPWebConfigModification
            {
                Name = "add[@name='Access-Control-Request-Headers'][@value='Content-Type,Authorization']",
                Owner = "ClubCloud",
                Sequence = 0,
                Path = "configuration/system.webServer/httpProtocol/customHeaders",
                Type = SPWebConfigModification.SPWebConfigModificationType.EnsureChildNode,
                Value = "<add tagPrefix='ajaxToolkit' assembly='AjaxControlToolkit, Version=4.5.7.1213, Culture=neutral, PublicKeyToken=28f01b0e84b6d53e' namespace='AjaxControlToolkit' />"

            };
            _modifications.Add(configModcustomHeadersHeaders);

            var configModcustomHeadersCredentials = new SPWebConfigModification
            {
                Name = "add[@name='Access-Control-Allow-Credentials'][@value='true']",
                Owner = "ClubCloud",
                Sequence = 0,
                Path = "configuration/system.webServer/httpProtocol/customHeaders",
                Type = SPWebConfigModification.SPWebConfigModificationType.EnsureChildNode,
                Value = "<add name='Access-Control-Allow-Credentials' value='true' />"

            };
            _modifications.Add(configModcustomHeadersCredentials);
        }

        /*
        
        $myModification1 = new-object Microsoft.SharePoint.Administration.SPWebConfigModification
$myModification1.Path = "configuration/system.webServer/httpProtocol/customHeaders"
$myModification1.Name = "add[@name='Access-Control-Allow-Origin'][@value='http://fromhere.kc-dev.com']"
$myModification1.Sequence = 0
$myModification1.Owner = "CrossSiteScripting"
#0 = for the enum value "SPWebConfigModification.SPWebConfigModificationType.EnsureChildNode"
$myModification1.Type = 0
$myModification1.Value = "<add name='Access-Control-Allow-Origin' value='http://fromhere.kc-dev.com' />"
$webapp.WebConfigModifications.Add($myModification1)

$myModification1 = new-object Microsoft.SharePoint.Administration.SPWebConfigModification
$myModification1.Path = "configuration/system.webServer/httpProtocol/customHeaders"
$myModification1.Name = "add[@name='Access-Control-Request-Method'][@value='GET,POST,HEAD,OPTIONS']"
$myModification1.Sequence = 0
$myModification1.Owner = "CrossSiteScripting"
$myModification1.Type = 0
$myModification1.Value = "<add name='Access-Control-Request-Method' value='GET,POST,HEAD,OPTIONS' />"
$webapp.WebConfigModifications.Add($myModification1)

$myModification1 = new-object Microsoft.SharePoint.Administration.SPWebConfigModification
$myModification1.Path = "configuration/system.webServer/httpProtocol/customHeaders"
$myModification1.Name = "add[@name='Access-Control-Request-Headers'][@value='Content-Type,Authorization']"
$myModification1.Sequence = 0
$myModification1.Owner = "CrossSiteScripting"
$myModification1.Type = 0
$myModification1.Value = "<add name='Access-Control-Request-Headers' value='Content-Type,Authorization' />"
$webapp.WebConfigModifications.Add($myModification1)

$myModification1 = new-objectMicrosoft.SharePoint.Administration.SPWebConfigModification
$myModification1.Path = "configuration/system.webServer/httpProtocol/customHeaders"
$myModification1.Name = "add[@name='Access-Control-Allow-Credentials'][@value='true']"
$myModification1.Sequence = 0
$myModification1.Owner = "CrossSiteScripting"
$myModification1.Type = 0
$myModification1.Value = "<add name='Access-Control-Allow-Credentials' value='true' />"
$webapp.WebConfigModifications.Add($myModification1)
        
        */
        #endregion
    }
}
