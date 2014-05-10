using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateSgt_rol_verbergen_entiteitRequest : Request
	{
		private Guid entityIdField;
		private Sgt_rol_verbergen_entiteitState sgt_rol_verbergen_entiteitStateField;
		private int sgt_rol_verbergen_entiteitStatusField;
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
		public Sgt_rol_verbergen_entiteitState Sgt_rol_verbergen_entiteitState
		{
			get
			{
				return this.sgt_rol_verbergen_entiteitStateField;
			}
			set
			{
				this.sgt_rol_verbergen_entiteitStateField = value;
			}
		}
		public int Sgt_rol_verbergen_entiteitStatus
		{
			get
			{
				return this.sgt_rol_verbergen_entiteitStatusField;
			}
			set
			{
				this.sgt_rol_verbergen_entiteitStatusField = value;
			}
		}
	}
}
