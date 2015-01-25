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
	public class SetStateSgt_toe_toernooi_resultatenRequest : Request
	{
		private Guid entityIdField;

		private ClubCloud.KNLTB.ServIt.CrmService.Sgt_toe_toernooi_resultatenState sgt_toe_toernooi_resultatenStateField;

		private int sgt_toe_toernooi_resultatenStatusField;

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
		public ClubCloud.KNLTB.ServIt.CrmService.Sgt_toe_toernooi_resultatenState Sgt_toe_toernooi_resultatenState
		{
			get
			{
				return this.sgt_toe_toernooi_resultatenStateField;
			}
			set
			{
				this.sgt_toe_toernooi_resultatenStateField = value;
				base.RaisePropertyChanged("Sgt_toe_toernooi_resultatenState");
			}
		}

		[XmlElement] //[XmlElement(Order=2)]
		public int Sgt_toe_toernooi_resultatenStatus
		{
			get
			{
				return this.sgt_toe_toernooi_resultatenStatusField;
			}
			set
			{
				this.sgt_toe_toernooi_resultatenStatusField = value;
				base.RaisePropertyChanged("Sgt_toe_toernooi_resultatenStatus");
			}
		}

		public SetStateSgt_toe_toernooi_resultatenRequest()
		{
		}
	}
}