using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateSgt_pbmutatietoernooidefinitieonderdeelRequest : Request
	{
		private Guid entityIdField;
		private Sgt_pbmutatietoernooidefinitieonderdeelState sgt_pbmutatietoernooidefinitieonderdeelStateField;
		private int sgt_pbmutatietoernooidefinitieonderdeelStatusField;
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
		public Sgt_pbmutatietoernooidefinitieonderdeelState Sgt_pbmutatietoernooidefinitieonderdeelState
		{
			get
			{
				return this.sgt_pbmutatietoernooidefinitieonderdeelStateField;
			}
			set
			{
				this.sgt_pbmutatietoernooidefinitieonderdeelStateField = value;
			}
		}
		public int Sgt_pbmutatietoernooidefinitieonderdeelStatus
		{
			get
			{
				return this.sgt_pbmutatietoernooidefinitieonderdeelStatusField;
			}
			set
			{
				this.sgt_pbmutatietoernooidefinitieonderdeelStatusField = value;
			}
		}
	}
}
