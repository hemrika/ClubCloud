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
	public class SetStateSgt_top_groepsevenementRequest : Request
	{
		private Guid entityIdField;

		private ClubCloud.KNLTB.ServIt.CrmService.Sgt_top_groepsevenementState sgt_top_groepsevenementStateField;

		private int sgt_top_groepsevenementStatusField;

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
		public ClubCloud.KNLTB.ServIt.CrmService.Sgt_top_groepsevenementState Sgt_top_groepsevenementState
		{
			get
			{
				return this.sgt_top_groepsevenementStateField;
			}
			set
			{
				this.sgt_top_groepsevenementStateField = value;
				base.RaisePropertyChanged("Sgt_top_groepsevenementState");
			}
		}

		[XmlElement] //[XmlElement(Order=2)]
		public int Sgt_top_groepsevenementStatus
		{
			get
			{
				return this.sgt_top_groepsevenementStatusField;
			}
			set
			{
				this.sgt_top_groepsevenementStatusField = value;
				base.RaisePropertyChanged("Sgt_top_groepsevenementStatus");
			}
		}

		public SetStateSgt_top_groepsevenementRequest()
		{
		}
	}
}