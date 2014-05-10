using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateSgt_com_wedstrijd_uitslag_mutatieRequest : Request
	{
		private Guid entityIdField;
		private Sgt_com_wedstrijd_uitslag_mutatieState sgt_com_wedstrijd_uitslag_mutatieStateField;
		private int sgt_com_wedstrijd_uitslag_mutatieStatusField;
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
		public Sgt_com_wedstrijd_uitslag_mutatieState Sgt_com_wedstrijd_uitslag_mutatieState
		{
			get
			{
				return this.sgt_com_wedstrijd_uitslag_mutatieStateField;
			}
			set
			{
				this.sgt_com_wedstrijd_uitslag_mutatieStateField = value;
			}
		}
		public int Sgt_com_wedstrijd_uitslag_mutatieStatus
		{
			get
			{
				return this.sgt_com_wedstrijd_uitslag_mutatieStatusField;
			}
			set
			{
				this.sgt_com_wedstrijd_uitslag_mutatieStatusField = value;
			}
		}
	}
}
