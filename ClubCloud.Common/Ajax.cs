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

        public static List<SPWebConfigModification> Modifications
        {
            get {
                _modifications = new List<SPWebConfigModification>();

                AddajaxToolkit();
                AddAssemblies();

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
                Type = SPWebConfigModification.SPWebConfigModificationType.EnsureChildNode,
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
                Type = SPWebConfigModification.SPWebConfigModificationType.EnsureChildNode,
                Value = "<add Assembly='AjaxControlToolkit, Version=4.5.7.1213, Culture=neutral, PublicKeyToken=28f01b0e84b6d53e' />"

            };
            _modifications.Add(configModAjaxControlToolkit);
        }
        #endregion
    }
}
