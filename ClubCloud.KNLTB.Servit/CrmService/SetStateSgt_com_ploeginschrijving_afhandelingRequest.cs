using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateSgt_com_ploeginschrijving_afhandelingRequest : Request
	{
		private Guid entityIdField;
		private Sgt_com_ploeginschrijving_afhandelingState sgt_com_ploeginschrijving_afhandelingStateField;
		private int sgt_com_ploeginschrijving_afhandelingStatusField;
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
		public Sgt_com_ploeginschrijving_afhandelingState Sgt_com_ploeginschrijving_afhandelingState
		{
			get
			{
				return this.sgt_com_ploeginschrijving_afhandelingStateField;
			}
			set
			{
				this.sgt_com_ploeginschrijving_afhandelingStateField = value;
			}
		}
		public int Sgt_com_ploeginschrijving_afhandelingStatus
		{
			get
			{
				return this.sgt_com_ploeginschrijving_afhandelingStatusField;
			}
			set
			{
				this.sgt_com_ploeginschrijving_afhandelingStatusField = value;
			}
		}
	}
}