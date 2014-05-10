using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateSgt_toe_afwezigheid_bondsgedelegeerdeRequest : Request
	{
		private Guid entityIdField;
		private Sgt_toe_afwezigheid_bondsgedelegeerdeState sgt_toe_afwezigheid_bondsgedelegeerdeStateField;
		private int sgt_toe_afwezigheid_bondsgedelegeerdeStatusField;
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
		public Sgt_toe_afwezigheid_bondsgedelegeerdeState Sgt_toe_afwezigheid_bondsgedelegeerdeState
		{
			get
			{
				return this.sgt_toe_afwezigheid_bondsgedelegeerdeStateField;
			}
			set
			{
				this.sgt_toe_afwezigheid_bondsgedelegeerdeStateField = value;
			}
		}
		public int Sgt_toe_afwezigheid_bondsgedelegeerdeStatus
		{
			get
			{
				return this.sgt_toe_afwezigheid_bondsgedelegeerdeStatusField;
			}
			set
			{
				this.sgt_toe_afwezigheid_bondsgedelegeerdeStatusField = value;
			}
		}
	}
}
