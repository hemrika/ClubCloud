using Microsoft.SharePoint.Administration;
using System.Collections.Generic;

namespace ClubCloud.Common
{
    internal class CrossSiteScripting
    {
        #region Modifications

        private static List<SPWebConfigModification> _modifications;
        private static string _owner = "ClubCloud";

        public static string Owner
        {
            get { return CrossSiteScripting._owner; }
            set { CrossSiteScripting._owner = value; }
        }
        public static List<SPWebConfigModification> Modifications
        {
            get
            {
                _modifications = new List<SPWebConfigModification>();

                AddCustomHeaders();

                return _modifications;
            }
        }

        private static void AddCustomHeaders()
        {
            var configModcustomHeadersOrigin = new SPWebConfigModification
            {
                Name = "add[@name='Access-Control-Allow-Origin'][@value='*']",
                Owner = "ClubCloud",
                Path = "configuration/system.webServer/httpProtocol/customHeaders",
                Type = SPWebConfigModification.SPWebConfigModificationType.EnsureSection,
                Value = "<add tagPrefix='ajaxToolkit' assembly='AjaxControlToolkit, Version=4.5.7.1213, Culture=neutral, PublicKeyToken=28f01b0e84b6d53e' namespace='AjaxControlToolkit' />"

            };
            _modifications.Add(configModcustomHeadersOrigin);

            var configModcustomHeadersMethod = new SPWebConfigModification
            {
                Name = "add[@name='Access-Control-Request-Method'][@value='GET,POST,HEAD,OPTIONS']",
                Owner = "ClubCloud",
                Sequence = 0,
                Path = "configuration/system.webServer/httpProtocol/customHeaders",
                Type = SPWebConfigModification.SPWebConfigModificationType.EnsureSection,
                Value = "<add name='Access-Control-Request-Method' value='GET,POST,HEAD,OPTIONS' />"

            };
            _modifications.Add(configModcustomHeadersMethod);

            var configModcustomHeadersHeaders = new SPWebConfigModification
            {
                Name = "add[@name='Access-Control-Request-Headers'][@value='Content-Type,Authorization']",
                Owner = "ClubCloud",
                Sequence = 0,
                Path = "configuration/system.webServer/httpProtocol/customHeaders",
                Type = SPWebConfigModification.SPWebConfigModificationType.EnsureSection,
                Value = "<add tagPrefix='ajaxToolkit' assembly='AjaxControlToolkit, Version=4.5.7.1213, Culture=neutral, PublicKeyToken=28f01b0e84b6d53e' namespace='AjaxControlToolkit' />"

            };
            _modifications.Add(configModcustomHeadersHeaders);

            var configModcustomHeadersCredentials = new SPWebConfigModification
            {
                Name = "add[@name='Access-Control-Allow-Credentials'][@value='true']",
                Owner = "ClubCloud",
                Sequence = 0,
                Path = "configuration/system.webServer/httpProtocol/customHeaders",
                Type = SPWebConfigModification.SPWebConfigModificationType.EnsureSection,
                Value = "<add name='Access-Control-Allow-Credentials' value='true' />"

            };
            _modifications.Add(configModcustomHeadersCredentials);
        }
        #endregion
    }
}
