using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateSgt_toe_leeftijdscat_aanvraagformulierRequest : Request
	{
		private Guid entityIdField;
		private Sgt_toe_leeftijdscat_aanvraagformulierState sgt_toe_leeftijdscat_aanvraagformulierStateField;
		private int sgt_toe_leeftijdscat_aanvraagformulierStatusField;
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
		public Sgt_toe_leeftijdscat_aanvraagformulierState Sgt_toe_leeftijdscat_aanvraagformulierState
		{
			get
			{
				return this.sgt_toe_leeftijdscat_aanvraagformulierStateField;
			}
			set
			{
				this.sgt_toe_leeftijdscat_aanvraagformulierStateField = value;
				base.RaisePropertyChanged("Sgt_toe_leeftijdscat_aanvraagformulierState");
			}
		}
		[XmlElement(Order = 2)]
		public int Sgt_toe_leeftijdscat_aanvraagformulierStatus
		{
			get
			{
				return this.sgt_toe_leeftijdscat_aanvraagformulierStatusField;
			}
			set
			{
				this.sgt_toe_leeftijdscat_aanvraagformulierStatusField = value;
				base.RaisePropertyChanged("Sgt_toe_leeftijdscat_aanvraagformulierStatus");
			}
		}
	}
}
