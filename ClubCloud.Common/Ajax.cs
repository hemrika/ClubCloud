using Microsoft.SharePoint.Administration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubCloud.Common
{
    internal class Ajax
    {
        #region Modifications

        private static List<SPWebConfigModification> _modifications;

        private static string _owner = "ClubCloud";

        public static string Owner
        {
            get { return Ajax._owner; }
            set { Ajax._owner = value; }
        }

        public static List<SPWebConfigModification> Modifications
        {
            get {
                _modifications = new List<SPWebConfigModification>();

                AddajaxToolkit();
                AddAssemblies();
                AddSaveControls();

                return _modifications; 
            }
        }

        private static void AddajaxToolkit()
        {
            var configModajaxToolkit = new SPWebConfigModification
            {
                Name = "add[@tagPrefix='ajaxToolkit'][assembly='AjaxControlToolkit, Version=4.5.7.1213, Culture=neutral, PublicKeyToken=28f01b0e84b6d53e'][namespace='AjaxControlToolkit']",
                //Name = "add[@tagPrefix=\"ajaxToolkit\" assembly=\"AjaxControlToolkit, Version=4.5.7.1213, Culture=neutral, PublicKeyToken=28f01b0e84b6d53e\" namespace=\"AjaxControlToolkit\"]",
                //Name = "ajaxToolkit",
                Owner = "ClubCloud",
                Sequence = 0,
                Path = "configuration/system.web/pages/controls",
                Type = SPWebConfigModification.SPWebConfigModificationType.EnsureSection,
                Value = "<add tagPrefix='ajaxToolkit' assembly='AjaxControlToolkit, Version=4.5.7.1213, Culture=neutral, PublicKeyToken=28f01b0e84b6d53e' namespace='AjaxControlToolkit' />"

            };
            _modifications.Add(configModajaxToolkit);

        }

        private static void AddAssemblies()
        {
            var configModAjaxControlToolkit = new SPWebConfigModification
            {
                Name = "add[@Assembly='AjaxControlToolkit, Version=4.5.7.1213, Culture=neutral, PublicKeyToken=28f01b0e84b6d53e']",
                //Name = "add[@assembly=\"AjaxControlToolkit, Version=4.5.7.1213, Culture=neutral, PublicKeyToken=28f01b0e84b6d53e\"]",
                //Name = "AjaxControlToolkit",
                Owner = "ClubCloud",
                Sequence = 0,
                Path = "configuration/system.web/compilation/assemblies",
                Type = SPWebConfigModification.SPWebConfigModificationType.EnsureSection,
                Value = "<add assembly='AjaxControlToolkit, Version=4.5.7.1213, Culture=neutral, PublicKeyToken=28f01b0e84b6d53e' />"

            };
            _modifications.Add(configModAjaxControlToolkit);
        }

        private static void AddSaveControls()
        {
            var configModAjaxControlToolkit = new SPWebConfigModification
            {
                Name = "SafeControl[@Assembly='AjaxControlToolkit, Version=4.5.7.1213, Culture=neutral, PublicKeyToken=28f01b0e84b6d53e'][@Namespace='AjaxControlToolkit'][@TypeName='*'][@Safe='True'][SafeAgainstScript='True']",
                Owner = "ClubCloud",
                Sequence = 0,
                Path = "configuration/SharePoint/SafeControls",
                Type = SPWebConfigModification.SPWebConfigModificationType.EnsureSection,
                Value = "<SafeControl Assembly='AjaxControlToolkit, Version=4.5.7.1213, Culture=neutral, PublicKeyToken=28f01b0e84b6d53e' Namespace='AjaxControlToolkit' TypeName='*' Safe='True' SafeAgainstScript='True' />"

            };
            _modifications.Add(configModAjaxControlToolkit);

            var configModAjaxMin = new SPWebConfigModification
            {
                Name = "SafeControl[@Assembly='AjaxMin, Version=4.97.4951.28478, Culture=neutral, PublicKeyToken=21ef50ce11b5d80f'][@Namespace='Microsoft.Ajax.Utilities'][@TypeName='*'][@Safe='True'][SafeAgainstScript='True']",
                Owner = "ClubCloud",
                Sequence = 0,
                Path = "configuration/SharePoint/SafeControls",
                Type = SPWebConfigModification.SPWebConfigModificationType.EnsureSection,
                Value = "<SafeControl Assembly='AjaxMin, Version=4.97.4951.28478, Culture=neutral, PublicKeyToken=21ef50ce11b5d80f' Namespace='Microsoft.Ajax.Utilities' TypeName='*' Safe='True' SafeAgainstScript='True' />"

            };
            _modifications.Add(configModAjaxMin);

            var configModHtmlAgilityPack = new SPWebConfigModification
            {
                Name = "SafeControl[@Assembly='HtmlAgilityPack, Version=1.4.6.0, Culture=neutral, PublicKeyToken=bd319b19eaf3b43a'][@Namespace='HtmlAgilityPack'][@TypeName='*'][@Safe='True'][SafeAgainstScript='True']",
                Owner = "ClubCloud",
                Sequence = 0,
                Path = "configuration/SharePoint/SafeControls",
                Type = SPWebConfigModification.SPWebConfigModificationType.EnsureSection,
                Value = "<SafeControl Assembly='HtmlAgilityPack, Version=1.4.6.0, Culture=neutral, PublicKeyToken=bd319b19eaf3b43a' Namespace='HtmlAgilityPack' TypeName='*' Safe='True' SafeAgainstScript='True' />"

            };
            _modifications.Add(configModHtmlAgilityPack);
            
        }

        #endregion
    }
}
