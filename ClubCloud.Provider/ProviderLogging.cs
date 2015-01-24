using System;
using System.Collections.Generic;
using Microsoft.SharePoint;
using Microsoft.SharePoint.Administration;
 
namespace ClubCloud.Provider
{
    /// <summary>
    /// Used for logging into Uls in 2010
    /// </summary>
    public class ProviderLogging : SPDiagnosticsServiceBase
    {
        public const string PRODUCT_NAME = "ClubCloud Provider";
        private static ProviderLogging _Current;
        
        public static ProviderLogging Current
        {
            get
            {
                if (_Current == null)
                {
                    _Current = new ProviderLogging();
                }
                return _Current;
            }
        }
 
        private ProviderLogging()
            : base(PRODUCT_NAME, SPFarm.Local)
        {
        }
 
        protected override IEnumerable<SPDiagnosticsArea> ProvideAreas()
        {
            List<SPDiagnosticsArea> areas = new List<SPDiagnosticsArea>        
            {            
                new SPDiagnosticsArea(PRODUCT_NAME, new List<SPDiagnosticsCategory>            
                {                
                    new SPDiagnosticsCategory("Error", TraceSeverity.High, EventSeverity.Error),
                    new SPDiagnosticsCategory("Warning", TraceSeverity.Medium, EventSeverity.Warning),
                    new SPDiagnosticsCategory("Logging", TraceSeverity.Verbose, EventSeverity.Verbose),
                    new SPDiagnosticsCategory("Debugging", TraceSeverity.Verbose, EventSeverity.Verbose)
                })        
            };
            return areas;
        }
 
        private string MapTraceSeverity(TraceSeverity traceSeverity)
        {
            switch (traceSeverity)
            {
                case TraceSeverity.High: return "Error";
 
                case TraceSeverity.Medium: return "Warning";
 
                default:
                case TraceSeverity.Verbose:
                    return "Debugging";
            }
        }
 
        public static void Log(TraceSeverity traceSeverity, Exception ex)
        {
            SPDiagnosticsCategory category = ProviderLogging.Current.Areas[PRODUCT_NAME].Categories["Error"];
            ProviderLogging.Current.WriteTrace(0, category, TraceSeverity.High, ex.Message);
            ProviderLogging.Current.WriteTrace(0, category, TraceSeverity.High, ex.ToString());
        }
 
        public static void Log(TraceSeverity traceSeverity, string message, Exception ex)
        {
            SPDiagnosticsCategory category = ProviderLogging.Current.Areas[PRODUCT_NAME].Categories["Error"];
            ProviderLogging.Current.WriteTrace(0, category, TraceSeverity.High, ex.Message);
            ProviderLogging.Current.WriteTrace(0, category, TraceSeverity.High, ex.ToString());
        }
 
        public static void LogError(Exception ex)
        {
            SPDiagnosticsCategory category = ProviderLogging.Current.Areas[PRODUCT_NAME].Categories["Error"];
            ProviderLogging.Current.WriteTrace(0, category, TraceSeverity.High, ex.Message);
            ProviderLogging.Current.WriteTrace(0, category, TraceSeverity.High, ex.ToString());
        }
 
        public static void LogError(Exception ex, string message)
        {
            SPDiagnosticsCategory category = ProviderLogging.Current.Areas[PRODUCT_NAME].Categories["Error"];
            ProviderLogging.Current.WriteTrace(0, category, TraceSeverity.High, ex.Message);
            ProviderLogging.Current.WriteTrace(0, category, TraceSeverity.High, ex.ToString());
        }
 
        public static void LogError(string message, string stackTrace)
        {
            SPDiagnosticsCategory category = ProviderLogging.Current.Areas[PRODUCT_NAME].Categories["Error"];
            ProviderLogging.Current.WriteTrace(0, category, TraceSeverity.High, message);
        }
 
        public static void LogWarning(string message)
        {
            SPDiagnosticsCategory category = ProviderLogging.Current.Areas[PRODUCT_NAME].Categories["Warning"];
            ProviderLogging.Current.WriteTrace(1, category, TraceSeverity.Medium, message);
        }
 
        public static void LogMessage(string message)
        {
            SPDiagnosticsCategory category = ProviderLogging.Current.Areas[PRODUCT_NAME].Categories["Logging"];
            ProviderLogging.Current.WriteTrace(1, category, TraceSeverity.Verbose, message);
        }
 
        public static void LogDebug(string message)
        {
            SPDiagnosticsCategory category = ProviderLogging.Current.Areas[PRODUCT_NAME].Categories["Debugging"];
            ProviderLogging.Current.WriteTrace(1, category, TraceSeverity.Verbose, message);
        }
 
    }
}