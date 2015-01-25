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
	public class SetStateSgt_com_wedstrijdgegevensRequest : Request
	{
		private Guid entityIdField;

		private ClubCloud.KNLTB.ServIt.CrmService.Sgt_com_wedstrijdgegevensState sgt_com_wedstrijdgegevensStateField;

		private int sgt_com_wedstrijdgegevensStatusField;

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
		public ClubCloud.KNLTB.ServIt.CrmService.Sgt_com_wedstrijdgegevensState Sgt_com_wedstrijdgegevensState
		{
			get
			{
				return this.sgt_com_wedstrijdgegevensStateField;
			}
			set
			{
				this.sgt_com_wedstrijdgegevensStateField = value;
				base.RaisePropertyChanged("Sgt_com_wedstrijdgegevensState");
			}
		}

		[XmlElement] //[XmlElement(Order=2)]
		public int Sgt_com_wedstrijdgegevensStatus
		{
			get
			{
				return this.sgt_com_wedstrijdgegevensStatusField;
			}
			set
			{
				this.sgt_com_wedstrijdgegevensStatusField = value;
				base.RaisePropertyChanged("Sgt_com_wedstrijdgegevensStatus");
			}
		}

		public SetStateSgt_com_wedstrijdgegevensRequest()
		{
		}
	}
}