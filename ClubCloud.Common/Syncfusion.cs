using Microsoft.SharePoint.Administration;
using System.Collections.Generic;

namespace ClubCloud.Common
{
    internal class Syncfusion
    {
        #region Modifications

        private static List<SPWebConfigModification> _modifications;
        private static string _owner = "ClubCloud";

        public static string Owner
        {
            get { return Syncfusion._owner; }
            set { Syncfusion._owner = value; }
        }
        public static List<SPWebConfigModification> Modifications
        {
            get
            {
                _modifications = new List<SPWebConfigModification>();

                //AddPageCompressionHandler();
                AddAssemblies();
                AddSaveControls();

                return _modifications;
            }
        }

        /// <summary>
        /// Incompatible with AjaxControlToolkit
        /// </summary>
        private static void AddPageCompressionHandler()
        {
            var configModSyncfusionPageCompressionHandlerWeb = new SPWebConfigModification
            {
                Name = "add[@name='HttpCompressModule'][type='Syncfusion.Web.UI.WebControls.Handler.PageCompressHandler, Syncfusion.Shared.Web, Version=12.4451.0.24, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89']",
                Owner = "ClubCloud",
                Sequence = 0,
                Path = "configuration/system.web/httpModules",
                Type = SPWebConfigModification.SPWebConfigModificationType.EnsureChildNode,
                Value = "<add name='HttpCompressModule' type='Syncfusion.Web.UI.WebControls.Handler.PageCompressHandler, Syncfusion.Shared.Web, Version=12.4451.0.24, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89' />"

            };
            _modifications.Add(configModSyncfusionPageCompressionHandlerWeb);

            var configModSyncfusionPageCompressionHandlerwebServer = new SPWebConfigModification
            {
                Name = "add[@name='HttpCompressModule'][type='Syncfusion.Web.UI.WebControls.Handler.PageCompressHandler, Syncfusion.Shared.Web, Version=12.4451.0.24, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89']",
                Owner = "ClubCloud",
                Sequence = 0,
                Path = "configuration/system.webServer/modules",
                Type = SPWebConfigModification.SPWebConfigModificationType.EnsureChildNode,
                Value = "<add name='HttpCompressModule' type='Syncfusion.Web.UI.WebControls.Handler.PageCompressHandler,Syncfusion.Shared.Web, Version=12.4451.0.24, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89' />"

            };
            _modifications.Add(configModSyncfusionPageCompressionHandlerwebServer);
        }

        private static void AddAssemblies()
        {
            var configModSyncfusionAssembliesEJ = new SPWebConfigModification
            {
                Name = "add[@assembly='Syncfusion.EJ, Version=12.4451.0.24, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89']",
                Owner = "ClubCloud",
                Sequence = 0,
                Path = "configuration/system.web/compilation/assemblies",
                Type = SPWebConfigModification.SPWebConfigModificationType.EnsureChildNode,
                Value = "<add assembly='Syncfusion.EJ, Version=12.4451.0.24, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89' />"

            };
            _modifications.Add(configModSyncfusionAssembliesEJ);

            var configModSyncfusionAssembliesEJWeb = new SPWebConfigModification
            {
                Name = "add[@assembly='Syncfusion.EJ.Web, Version=12.4451.0.24, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89']",
                Owner = "ClubCloud",
                Sequence = 0,
                Path = "configuration/system.web/compilation/assemblies",
                Type = SPWebConfigModification.SPWebConfigModificationType.EnsureChildNode,
                Value = "<add assembly='Syncfusion.EJ.Web, Version=12.4451.0.24, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89' />"

            };
            _modifications.Add(configModSyncfusionAssembliesEJWeb);
        }
        private static void AddSaveControls()
        {
            var configModSyncfusionSharedWeb = new SPWebConfigModification
            {
                Name = "SafeControl[@Assembly='Syncfusion.Shared.Web, Version=12.4451.0.24, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89'][@Namespace='Syncfusion.Web.UI.WebControls.Shared'][@TypeName='*'][@Safe='True'][SafeAgainstScript='True']",
                Owner = "ClubCloud",
                Sequence = 0,
                Path = "configuration/SharePoint/SafeControls",
                Type = SPWebConfigModification.SPWebConfigModificationType.EnsureChildNode,
                Value = "<SafeControl Assembly='Syncfusion.Shared.Web, Version=12.4451.0.24, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89' Namespace='Syncfusion.Web.UI.WebControls.Shared' TypeName='*' Safe='True' SafeAgainstScript='True' />"

            };
            _modifications.Add(configModSyncfusionSharedWeb);

            var configModSyncfusionEJ = new SPWebConfigModification
            {
                Name = "SafeControl[@Assembly='Syncfusion.EJ, Version=12.4451.0.24, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89'][@Namespace='Syncfusion.JavaScript.Web'][@TypeName='*'][@Safe='True'][SafeAgainstScript='True']",
                Owner = "ClubCloud",
                Sequence = 0,
                Path = "configuration/SharePoint/SafeControls",
                Type = SPWebConfigModification.SPWebConfigModificationType.EnsureChildNode,
                Value = "<SafeControl Assembly='Syncfusion.EJ, Version=12.4451.0.24, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89' Namespace='Syncfusion.JavaScript.Web' TypeName='*' Safe='True' SafeAgainstScript='True' />"

            };
            _modifications.Add(configModSyncfusionEJ);

            var configModSyncfusionEJWeb = new SPWebConfigModification
            {
                Name = "SafeControl[@Assembly='Syncfusion.EJ.Web, Version=12.4451.0.24, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89'][@Namespace='Syncfusion.JavaScript.Web'][@TypeName='*'][@Safe='True'][SafeAgainstScript='True']",
                Owner = "ClubCloud",
                Sequence = 0,
                Path = "configuration/SharePoint/SafeControls",
                Type = SPWebConfigModification.SPWebConfigModificationType.EnsureChildNode,
                Value = "<SafeControl Assembly='Syncfusion.EJ.Web, Version=12.4451.0.24, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89' Namespace='Syncfusion.JavaScript.Web' TypeName='*' Safe='True' SafeAgainstScript='True' />"

            };
            _modifications.Add(configModSyncfusionEJWeb);

        }
        #endregion
    }
}
