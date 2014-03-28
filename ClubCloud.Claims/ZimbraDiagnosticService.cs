using Microsoft.SharePoint.Administration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ClubCloud.Provider
{
    [Guid("BEBFE71F-4186-4B08-B8E1-681CDFECF5A7")]
    public class ZimbraDiagnosticService : SPDiagnosticsServiceBase
    {
        private const string Zimbra_Area = "Zimbra";

        public enum LogCategories
        {
            claim,
            provider,
            user,
            role,
            module,
            settings,
        }

        public ZimbraDiagnosticService()
        {

        }

        public ZimbraDiagnosticService(string name, SPFarm parent)
            : base(name, parent)
        {

        }

        public static ZimbraDiagnosticService Local
        {
            get
            {
                return SPDiagnosticsServiceBase.GetLocal<ZimbraDiagnosticService>();
            }
        }

        public void LogMessage(ushort id, LogCategories LogCategory, TraceSeverity traceSeverity, string message, params object[] data)
        {
            if (traceSeverity != TraceSeverity.None)
            {
                SPDiagnosticsCategory category = Local.Areas[Zimbra_Area].Categories[LogCategory.ToString()];
                Local.WriteTrace(id, category, traceSeverity, message, data);
            }
        }

        /*
        protected override IEnumerable<SPDiagnosticsArea> ProvideAreas()
        {
            yield return new SPDiagnosticsArea(LOG_AREA, 0, 0, false,
            
                new List<SPDiagnosticsCategory>()
                {

                new

                SPDiagnosticsCategory(LogCategories.AzureConfig.ToString(),

                                     TraceSeverity.Medium, EventSeverity.Information, 1,

                                     Log.LOG_ID)

                                     });
                        }
        */

        protected override IEnumerable<SPDiagnosticsArea> ProvideAreas()
        {
            throw new NotImplementedException();
        }
    }
}

/*
public override void FeatureInstalled(SPFeatureReceiverProperties properties)

{

try

       {

SteveDiagnosticsService.Local.Update();

}

catch (Exception ex)

       {

throw new Exception("Error installing feature: " + ex.Message);

}

}

 

 

public override void FeatureUninstalling(SPFeatureReceiverProperties properties)

{

try

       {

SteveDiagnosticsService.Local.Delete();

}

catch (Exception ex)

{

throw new Exception("Error uninstalling feature: " + ex.Message);

}

}
*/
