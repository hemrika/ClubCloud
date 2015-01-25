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
	public class SetStateSw_licensemanagerRequest : Request
	{
		private Guid entityIdField;

		private ClubCloud.KNLTB.ServIt.CrmService.Sw_licensemanagerState sw_licensemanagerStateField;

		private int sw_licensemanagerStatusField;

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
		public ClubCloud.KNLTB.ServIt.CrmService.Sw_licensemanagerState Sw_licensemanagerState
		{
			get
			{
				return this.sw_licensemanagerStateField;
			}
			set
			{
				this.sw_licensemanagerStateField = value;
				base.RaisePropertyChanged("Sw_licensemanagerState");
			}
		}

		[XmlElement] //[XmlElement(Order=2)]
		public int Sw_licensemanagerStatus
		{
			get
			{
				return this.sw_licensemanagerStatusField;
			}
			set
			{
				this.sw_licensemanagerStatusField = value;
				base.RaisePropertyChanged("Sw_licensemanagerStatus");
			}
		}

		public SetStateSw_licensemanagerRequest()
		{
		}
	}
}