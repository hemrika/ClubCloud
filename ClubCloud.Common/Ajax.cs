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
                AddRuntimeAssemblyBinding();
                AddSaveControls();

                return _modifications; 
            }
        }

        private static void AddajaxToolkit()
        {
            var configModajaxToolkit = new SPWebConfigModification
            {
                Name = "add[@tagPrefix='ajax'][@assembly='AjaxControlToolkit, Version=15.1.1.100, Culture=neutral, PublicKeyToken=28f01b0e84b6d53e'][@namespace='AjaxControlToolkit']",
                Owner = "ClubCloud",
                Sequence = 0,
                Path = "configuration/system.web/pages/controls",
                Type = SPWebConfigModification.SPWebConfigModificationType.EnsureChildNode,
                Value = "<add tagPrefix=\"ajax\" assembly=\"AjaxControlToolkit, Version=15.1.1.100, Culture=neutral, PublicKeyToken=28f01b0e84b6d53e\" namespace=\"AjaxControlToolkit\" />"

            };
            _modifications.Add(configModajaxToolkit);

        }

        private static void AddAssemblies()
        {
            var configModAjaxControlToolkit = new SPWebConfigModification
            {
                Name = "add[@assembly='AjaxControlToolkit, Version=15.1.1.100, Culture=neutral, PublicKeyToken=28f01b0e84b6d53e']",
                Owner = "ClubCloud",
                Sequence = 0,
                Path = "configuration/system.web/compilation/assemblies",
                Type = SPWebConfigModification.SPWebConfigModificationType.EnsureChildNode,
                Value = "<add assembly=\"AjaxControlToolkit, Version=15.1.1.100, Culture=neutral, PublicKeyToken=28f01b0e84b6d53e\" />"

            };
            _modifications.Add(configModAjaxControlToolkit);
        }

        private static void AddRuntimeAssemblyBinding()
        {
            /*
            <dependentAssembly>
            <assemblyIdentity name="AjaxMin" publicKeyToken="21ef50ce11b5d80f" culture="neutral" />
            <bindingRedirect oldVersion="0.0.0.0-5.13.5463.15277" newVersion="5.13.5463.15277" />
            </dependentAssembly>
            */

            var configModAjaxMin = new SPWebConfigModification
            {
                Name = "*[local-name()='dependentAssembly'][*/@name='AjaxMin'][*/@publicKeyToken='21ef50ce11b5d80f'][*/@culture='neutral']",
                Owner = Owner,
                Sequence = 0,
                Path = "configuration/runtime/*[local-name()='assemblyBinding' and namespace-uri()='urn:schemas-microsoft-com:asm.v1']",
                Type = SPWebConfigModification.SPWebConfigModificationType.EnsureChildNode,
                Value = "<dependentAssembly><assemblyIdentity name='AjaxMin' publicKeyToken='21ef50ce11b5d80f' culture='neutral' /><bindingRedirect oldVersion='0.0.0.0-5.13.5463.15277' newVersion='5.13.5463.15277' /></dependentAssembly>"

            };
            _modifications.Add(configModAjaxMin);
        }

        private static void AddSaveControls()
        {
            var configModAjaxControlToolkit = new SPWebConfigModification
            {
                Name = "SafeControl[@Assembly='AjaxControlToolkit, Version=15.1.1.100, Culture=neutral, PublicKeyToken=28f01b0e84b6d53e'][@Namespace='AjaxControlToolkit'][@TypeName='*'][@Safe='True'][@SafeAgainstScript='True']",
                Owner = "ClubCloud",
                Sequence = 0,
                Path = "configuration/SharePoint/SafeControls",
                Type = SPWebConfigModification.SPWebConfigModificationType.EnsureChildNode,
                Value = "<SafeControl Assembly=\"AjaxControlToolkit, Version=15.1.1.100, Culture=neutral, PublicKeyToken=28f01b0e84b6d53e\" Namespace=\"AjaxControlToolkit\" TypeName=\"*\" Safe=\"True\" SafeAgainstScript=\"True\" />"

            };
            _modifications.Add(configModAjaxControlToolkit);

            var configModAjaxMin = new SPWebConfigModification
            {
                Name = "SafeControl[@Assembly='AjaxMin, Version=5.13.5463.15277, Culture=neutral, PublicKeyToken=21ef50ce11b5d80f'][@Namespace='Microsoft.Ajax.Utilities'][@TypeName='*'][@Safe='True'][@SafeAgainstScript='True']",
                Owner = "ClubCloud",
                Sequence = 0,
                Path = "configuration/SharePoint/SafeControls",
                Type = SPWebConfigModification.SPWebConfigModificationType.EnsureChildNode,
                Value = "<SafeControl Assembly='AjaxMin, Version=5.13.5463.15277, Culture=neutral, PublicKeyToken=21ef50ce11b5d80f' Namespace='Microsoft.Ajax.Utilities' TypeName='*' Safe='True' SafeAgainstScript='True' />"

            };
            _modifications.Add(configModAjaxMin);

            var configModHtmlAgilityPack = new SPWebConfigModification
            {
                Name = "SafeControl[@Assembly='HtmlAgilityPack, Version=1.4.9.0, Culture=neutral, PublicKeyToken=bd319b19eaf3b43a'][@Namespace='HtmlAgilityPack'][@TypeName='*'][@Safe='True'][@SafeAgainstScript='True']",
                Owner = "ClubCloud",
                Sequence = 0,
                Path = "configuration/SharePoint/SafeControls",
                Type = SPWebConfigModification.SPWebConfigModificationType.EnsureChildNode,
                Value = "<SafeControl Assembly='HtmlAgilityPack, Version=1.4.9.0, Culture=neutral, PublicKeyToken=bd319b19eaf3b43a' Namespace='HtmlAgilityPack' TypeName='*' Safe='True' SafeAgainstScript='True' />"

            };
            _modifications.Add(configModHtmlAgilityPack);
            
        }

        #endregion
    }
}
