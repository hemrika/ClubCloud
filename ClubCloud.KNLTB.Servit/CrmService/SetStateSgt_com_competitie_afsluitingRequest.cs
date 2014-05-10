using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateSgt_com_competitie_afsluitingRequest : Request
	{
		private Guid entityIdField;
		private Sgt_com_competitie_afsluitingState sgt_com_competitie_afsluitingStateField;
		private int sgt_com_competitie_afsluitingStatusField;
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
		public Sgt_com_competitie_afsluitingState Sgt_com_competitie_afsluitingState
		{
			get
			{
				return this.sgt_com_competitie_afsluitingStateField;
			}
			set
			{
				this.sgt_com_competitie_afsluitingStateField = value;
			}
		}
		public int Sgt_com_competitie_afsluitingStatus
		{
			get
			{
				return this.sgt_com_competitie_afsluitingStatusField;
			}
			set
			{
				this.sgt_com_competitie_afsluitingStatusField = value;
			}
		}
	}
}
