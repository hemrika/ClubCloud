using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateSgt_alg_formulier_antwoord_veldRequest : Request
	{
		private Guid entityIdField;
		private Sgt_alg_formulier_antwoord_veldState sgt_alg_formulier_antwoord_veldStateField;
		private int sgt_alg_formulier_antwoord_veldStatusField;
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
		public Sgt_alg_formulier_antwoord_veldState Sgt_alg_formulier_antwoord_veldState
		{
			get
			{
				return this.sgt_alg_formulier_antwoord_veldStateField;
			}
			set
			{
				this.sgt_alg_formulier_antwoord_veldStateField = value;
				base.RaisePropertyChanged("Sgt_alg_formulier_antwoord_veldState");
			}
		}
		[XmlElement(Order = 2)]
		public int Sgt_alg_formulier_antwoord_veldStatus
		{
			get
			{
				return this.sgt_alg_formulier_antwoord_veldStatusField;
			}
			set
			{
				this.sgt_alg_formulier_antwoord_veldStatusField = value;
				base.RaisePropertyChanged("Sgt_alg_formulier_antwoord_veldStatus");
			}
		}
	}
}
