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
	[XmlType(Namespace="http://schemas.microsoft.com/crm/2007/WebServices")]
	public class SetStateSw_licenseRequest : Request
	{
		private Guid entityIdField;

		private ClubCloud.KNLTB.ServIt.CrmService.Sw_licenseState sw_licenseStateField;

		private int sw_licenseStatusField;

		[XmlElement] //[XmlElement(Order=0)]
		public Guid EntityId
		{
			get
			{
				return this.entityIdField;
			}
			set
			{
				this.entityIdField = value;
				base.RaisePropertyChanged("EntityId");
			}
		}

		[XmlElement] //[XmlElement(Order=1)]
		public ClubCloud.KNLTB.ServIt.CrmService.Sw_licenseState Sw_licenseState
		{
			get
			{
				return this.sw_licenseStateField;
			}
			set
			{
				this.sw_licenseStateField = value;
				base.RaisePropertyChanged("Sw_licenseState");
			}
		}

		[XmlElement] //[XmlElement(Order=2)]
		public int Sw_licenseStatus
		{
			get
			{
				return this.sw_licenseStatusField;
			}
			set
			{
				this.sw_licenseStatusField = value;
				base.RaisePropertyChanged("Sw_licenseStatus");
			}
		}

		public SetStateSw_licenseRequest()
		{
		}
	}
}