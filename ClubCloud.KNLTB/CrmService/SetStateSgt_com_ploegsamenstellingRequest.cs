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
	public class SetStateSgt_com_ploegsamenstellingRequest : Request
	{
		private Guid entityIdField;

		private ClubCloud.KNLTB.ServIt.CrmService.Sgt_com_ploegsamenstellingState sgt_com_ploegsamenstellingStateField;

		private int sgt_com_ploegsamenstellingStatusField;

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
		public ClubCloud.KNLTB.ServIt.CrmService.Sgt_com_ploegsamenstellingState Sgt_com_ploegsamenstellingState
		{
			get
			{
				return this.sgt_com_ploegsamenstellingStateField;
			}
			set
			{
				this.sgt_com_ploegsamenstellingStateField = value;
				base.RaisePropertyChanged("Sgt_com_ploegsamenstellingState");
			}
		}

		[XmlElement] //[XmlElement(Order=2)]
		public int Sgt_com_ploegsamenstellingStatus
		{
			get
			{
				return this.sgt_com_ploegsamenstellingStatusField;
			}
			set
			{
				this.sgt_com_ploegsamenstellingStatusField = value;
				base.RaisePropertyChanged("Sgt_com_ploegsamenstellingStatus");
			}
		}

		public SetStateSgt_com_ploegsamenstellingRequest()
		{
		}
	}
}