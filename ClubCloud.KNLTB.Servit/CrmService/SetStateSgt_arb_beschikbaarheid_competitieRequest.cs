using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateSgt_arb_beschikbaarheid_competitieRequest : Request
	{
		private Guid entityIdField;
		private Sgt_arb_beschikbaarheid_competitieState sgt_arb_beschikbaarheid_competitieStateField;
		private int sgt_arb_beschikbaarheid_competitieStatusField;
		public Guid EntityId
		{
			get
			{
				return this.entityIdField;
			}
			set
			{
				this.entityIdField = value;
			}
		}
		public Sgt_arb_beschikbaarheid_competitieState Sgt_arb_beschikbaarheid_competitieState
		{
			get
			{
				return this.sgt_arb_beschikbaarheid_competitieStateField;
			}
			set
			{
				this.sgt_arb_beschikbaarheid_competitieStateField = value;
			}
		}
		public int Sgt_arb_beschikbaarheid_competitieStatus
		{
			get
			{
				return this.sgt_arb_beschikbaarheid_competitieStatusField;
			}
			set
			{
				this.sgt_arb_beschikbaarheid_competitieStatusField = value;
			}
		}
	}
}
