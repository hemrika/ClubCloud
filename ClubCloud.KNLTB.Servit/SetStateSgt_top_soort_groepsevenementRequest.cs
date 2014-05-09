using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateSgt_top_soort_groepsevenementRequest : Request
	{
		private Guid entityIdField;
		private Sgt_top_soort_groepsevenementState sgt_top_soort_groepsevenementStateField;
		private int sgt_top_soort_groepsevenementStatusField;
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
		public Sgt_top_soort_groepsevenementState Sgt_top_soort_groepsevenementState
		{
			get
			{
				return this.sgt_top_soort_groepsevenementStateField;
			}
			set
			{
				this.sgt_top_soort_groepsevenementStateField = value;
				base.RaisePropertyChanged("Sgt_top_soort_groepsevenementState");
			}
		}
		[XmlElement(Order = 2)]
		public int Sgt_top_soort_groepsevenementStatus
		{
			get
			{
				return this.sgt_top_soort_groepsevenementStatusField;
			}
			set
			{
				this.sgt_top_soort_groepsevenementStatusField = value;
				base.RaisePropertyChanged("Sgt_top_soort_groepsevenementStatus");
			}
		}
	}
}
