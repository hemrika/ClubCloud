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
	public class SetStateSw_lookupviewtranslationRequest : Request
	{
		private Guid entityIdField;

		private ClubCloud.KNLTB.ServIt.CrmService.Sw_lookupviewtranslationState sw_lookupviewtranslationStateField;

		private int sw_lookupviewtranslationStatusField;

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
		public ClubCloud.KNLTB.ServIt.CrmService.Sw_lookupviewtranslationState Sw_lookupviewtranslationState
		{
			get
			{
				return this.sw_lookupviewtranslationStateField;
			}
			set
			{
				this.sw_lookupviewtranslationStateField = value;
				base.RaisePropertyChanged("Sw_lookupviewtranslationState");
			}
		}

		[XmlElement] //[XmlElement(Order=2)]
		public int Sw_lookupviewtranslationStatus
		{
			get
			{
				return this.sw_lookupviewtranslationStatusField;
			}
			set
			{
				this.sw_lookupviewtranslationStatusField = value;
				base.RaisePropertyChanged("Sw_lookupviewtranslationStatus");
			}
		}

		public SetStateSw_lookupviewtranslationRequest()
		{
		}
	}
}