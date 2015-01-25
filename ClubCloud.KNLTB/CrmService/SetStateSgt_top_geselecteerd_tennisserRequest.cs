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
	public class SetStateSgt_top_geselecteerd_tennisserRequest : Request
	{
		private Guid entityIdField;

		private ClubCloud.KNLTB.ServIt.CrmService.Sgt_top_geselecteerd_tennisserState sgt_top_geselecteerd_tennisserStateField;

		private int sgt_top_geselecteerd_tennisserStatusField;

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
		public ClubCloud.KNLTB.ServIt.CrmService.Sgt_top_geselecteerd_tennisserState Sgt_top_geselecteerd_tennisserState
		{
			get
			{
				return this.sgt_top_geselecteerd_tennisserStateField;
			}
			set
			{
				this.sgt_top_geselecteerd_tennisserStateField = value;
				base.RaisePropertyChanged("Sgt_top_geselecteerd_tennisserState");
			}
		}

		[XmlElement] //[XmlElement(Order=2)]
		public int Sgt_top_geselecteerd_tennisserStatus
		{
			get
			{
				return this.sgt_top_geselecteerd_tennisserStatusField;
			}
			set
			{
				this.sgt_top_geselecteerd_tennisserStatusField = value;
				base.RaisePropertyChanged("Sgt_top_geselecteerd_tennisserStatus");
			}
		}

		public SetStateSgt_top_geselecteerd_tennisserRequest()
		{
		}
	}
}