using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateSgt_top_groepsevenement_begeleidingRequest : Request
	{
		private Guid entityIdField;
		private Sgt_top_groepsevenement_begeleidingState sgt_top_groepsevenement_begeleidingStateField;
		private int sgt_top_groepsevenement_begeleidingStatusField;
		[XmlElement(Order = 0)]
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
		[XmlElement(Order = 1)]
		public Sgt_top_groepsevenement_begeleidingState Sgt_top_groepsevenement_begeleidingState
		{
			get
			{
				return this.sgt_top_groepsevenement_begeleidingStateField;
			}
			set
			{
				this.sgt_top_groepsevenement_begeleidingStateField = value;
				base.RaisePropertyChanged("Sgt_top_groepsevenement_begeleidingState");
			}
		}
		[XmlElement(Order = 2)]
		public int Sgt_top_groepsevenement_begeleidingStatus
		{
			get
			{
				return this.sgt_top_groepsevenement_begeleidingStatusField;
			}
			set
			{
				this.sgt_top_groepsevenement_begeleidingStatusField = value;
				base.RaisePropertyChanged("Sgt_top_groepsevenement_begeleidingStatus");
			}
		}
	}
}
