using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.MetadataService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/CoreTypes")]
	[Serializable]
	public class OfflineOrigin : CallerOrigin
	{
		private CrmDateTime offlineTimestampField;
		public CrmDateTime OfflineTimestamp
		{
			get
			{
				return this.offlineTimestampField;
			}
			set
			{
				this.offlineTimestampField = value;
			}
		}
	}
}
