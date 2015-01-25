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
	public class SetStateSgt_toe_toernooi_aanvraagrechtRequest : Request
	{
		private Guid entityIdField;

		private ClubCloud.KNLTB.ServIt.CrmService.Sgt_toe_toernooi_aanvraagrechtState sgt_toe_toernooi_aanvraagrechtStateField;

		private int sgt_toe_toernooi_aanvraagrechtStatusField;

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
		public ClubCloud.KNLTB.ServIt.CrmService.Sgt_toe_toernooi_aanvraagrechtState Sgt_toe_toernooi_aanvraagrechtState
		{
			get
			{
				return this.sgt_toe_toernooi_aanvraagrechtStateField;
			}
			set
			{
				this.sgt_toe_toernooi_aanvraagrechtStateField = value;
				base.RaisePropertyChanged("Sgt_toe_toernooi_aanvraagrechtState");
			}
		}

		[XmlElement] //[XmlElement(Order=2)]
		public int Sgt_toe_toernooi_aanvraagrechtStatus
		{
			get
			{
				return this.sgt_toe_toernooi_aanvraagrechtStatusField;
			}
			set
			{
				this.sgt_toe_toernooi_aanvraagrechtStatusField = value;
				base.RaisePropertyChanged("Sgt_toe_toernooi_aanvraagrechtStatus");
			}
		}

		public SetStateSgt_toe_toernooi_aanvraagrechtRequest()
		{
		}
	}
}