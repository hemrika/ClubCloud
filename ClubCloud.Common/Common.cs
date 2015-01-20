using Microsoft.SharePoint.Administration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubCloud.Common
{
    internal class Common
    {
        #region Modifications

        private static List<SPWebConfigModification> _modifications;

        public static List<SPWebConfigModification> Modifications
        {
            get {
                _modifications = new List<SPWebConfigModification>();

                AddSaveControls();
                //AddSaveControlsPrevious();

                return _modifications; 
            }
        }

        private static void AddSaveControls()
        {
            var configModSaveControls = new SPWebConfigModification
            {
                Name = "SafeControl[@Assembly='ClubCloud.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=144fd205e283172e'][@Namespace='ClubCloud.Common.Controls'][@TypeName='*'][@Safe='True'][SafeAgainstScript='True']",
                //Name = "SafeControl[@Assembly=\"ClubCloud.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=144fd205e283172e\" Namespace=\"ClubCloud.Common.Controls\" TypeName=\"*\" Safe=\"True\" SafeAgainstScript=\"True\"]",
                //Name = "ClubCloudSaveControls",
                Owner = "ClubCloud",
                Sequence = 0,
                Path = "configuration/SharePoint/SafeControls",
                Type = SPWebConfigModification.SPWebConfigModificationType.EnsureChildNode,
                Value = "<SafeControl Assembly='ClubCloud.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=144fd205e283172e' Namespace='ClubCloud.Common.Controls' TypeName='*' Safe='True' SafeAgainstScript='True' />"

            };
            _modifications.Add(configModSaveControls);

        }

        /*
        private static void AddSaveControlsPrevious()
        {
            var configModSaveControlsPrevious = new SPWebConfigModification
            {
                Name = "SafeControl[@Assembly=\"ClubCloud.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=144fd205e283172e\" Namespace=\"ClubCloud.Common.Controls\" TypeName=\"*\" Safe=\"True\" SafeAgainstScript=\"True\"]",
                Owner = "ClubCloud",
                Path = "configuration/SharePoint/SafeControls",
                Type = SPWebConfigModification.SPWebConfigModificationType.EnsureChildNode,
                Value = "<SafeControl Assembly=\"ClubCloud.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=144fd205e283172e\" Namespace=\"ClubCloud.Common.Controls\" TypeName=\"*\" Safe=\"True\" SafeAgainstScript=\"True\" />"

            };
            _modifications.Add(configModSaveControlsPrevious);

        }
        */
        #endregion
    }
}
