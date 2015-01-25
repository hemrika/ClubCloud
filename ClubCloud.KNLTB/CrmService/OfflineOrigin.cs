using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[GeneratedCode("System.Xml", "4.0.30319.33440")]
	[Serializable]
	[XmlType(Namespace="http://schemas.microsoft.com/crm/2007/CoreTypes")]
	public class OfflineOrigin : CallerOrigin
	{
		private CrmDateTime offlineTimestampField;

		[XmlElement] //[XmlElement(Order=0)]
		public CrmDateTime OfflineTimestamp
		{
			get
			{
				return this.offlineTimestampField;
			}
			set
			{
				this.offlineTimestampField = value;
				base.RaisePropertyChanged("OfflineTimestamp");
			}
		}

		public OfflineOrigin()
		{
		}
	}
}