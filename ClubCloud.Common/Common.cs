using Microsoft.SharePoint;
using Microsoft.SharePoint.Administration;
using System.Collections.Generic;

namespace ClubCloud.Common
{
    internal class Common
    {
        #region Modifications

        private static List<SPWebConfigModification> _modifications;
        private static string _owner = "ClubCloud";

        public static string Owner
        {
            get { return Common._owner; }
            set { Common._owner = value; }
        }
        public static List<SPWebConfigModification> Modifications
        {
            get
            {
                _modifications = new List<SPWebConfigModification>();

                AddTargetFramework();
                AddSaveControls();

                return _modifications;
            }
        }

        private static void AddTargetFramework()
        {
            var configModcompilationTargetFramework = new SPWebConfigModification
            {
                Name = "targetFramework",
                Owner = "ClubCloud",
                Sequence = 0,
                Path = "configuration/system.web/compilation",
                Type = SPWebConfigModification.SPWebConfigModificationType.EnsureAttribute,
                Value = "4.5.2"

            };
            _modifications.Add(configModcompilationTargetFramework);


            var configModhttpRuntimeTargetFramework = new SPWebConfigModification
            {
                Name = "targetFramework",
                Owner = "ClubCloud",
                Sequence = 1,
                Path = "configuration/system.web/httpRuntime",
                Type = SPWebConfigModification.SPWebConfigModificationType.EnsureAttribute,
                Value = "4.5.2"

            };
            _modifications.Add(configModhttpRuntimeTargetFramework);
        }

        private static void AddSaveControls()
        {
            var configModSaveControls = new SPWebConfigModification
            {
                Name = "SafeControl[@Assembly='ClubCloud.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=144fd205e283172e'][@Namespace='ClubCloud.Common.Controls'][@TypeName='*'][@Safe='True'][SafeAgainstScript='True']",
                Owner = "ClubCloud",
                Sequence = 0,
                Path = "configuration/SharePoint/SafeControls",
                Type = SPWebConfigModification.SPWebConfigModificationType.EnsureSection,
                Value = "<SafeControl Assembly='ClubCloud.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=144fd205e283172e' Namespace='ClubCloud.Common.Controls' TypeName='*' Safe='True' SafeAgainstScript='True' />"

            };
            _modifications.Add(configModSaveControls);

        }
        #endregion
    }

      

    public class RemoteAdministrator
    {
        public static void Enable()
        {
            SPSecurity.RunWithElevatedPrivileges(delegate()
            {
                SPWebService webservice = SPWebService.ContentService;
                webservice.RemoteAdministratorAccessDenied = false;
                webservice.Update();
            });
        }

        public static void Disable()
        {
            SPSecurity.RunWithElevatedPrivileges(delegate()
            {
                SPWebService webservice = SPWebService.ContentService;
                webservice.RemoteAdministratorAccessDenied = true;
                webservice.Update();
            });
        }
        
    }
}
