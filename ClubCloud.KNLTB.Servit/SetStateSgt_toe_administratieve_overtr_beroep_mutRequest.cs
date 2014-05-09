using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateSgt_toe_administratieve_overtr_beroep_mutRequest : Request
	{
		private Guid entityIdField;
		private Sgt_toe_administratieve_overtr_beroep_mutState sgt_toe_administratieve_overtr_beroep_mutStateField;
		private int sgt_toe_administratieve_overtr_beroep_mutStatusField;
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
		public Sgt_toe_administratieve_overtr_beroep_mutState Sgt_toe_administratieve_overtr_beroep_mutState
		{
			get
			{
				return this.sgt_toe_administratieve_overtr_beroep_mutStateField;
			}
			set
			{
				this.sgt_toe_administratieve_overtr_beroep_mutStateField = value;
				base.RaisePropertyChanged("Sgt_toe_administratieve_overtr_beroep_mutState");
			}
		}
		[XmlElement(Order = 2)]
		public int Sgt_toe_administratieve_overtr_beroep_mutStatus
		{
			get
			{
				return this.sgt_toe_administratieve_overtr_beroep_mutStatusField;
			}
			set
			{
				this.sgt_toe_administratieve_overtr_beroep_mutStatusField = value;
				base.RaisePropertyChanged("Sgt_toe_administratieve_overtr_beroep_mutStatus");
			}
		}
	}
}
