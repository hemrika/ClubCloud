using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateSgt_rol_verbergen_tabbladen_sectiesRequest : Request
	{
		private Guid entityIdField;
		private Sgt_rol_verbergen_tabbladen_sectiesState sgt_rol_verbergen_tabbladen_sectiesStateField;
		private int sgt_rol_verbergen_tabbladen_sectiesStatusField;
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
		public Sgt_rol_verbergen_tabbladen_sectiesState Sgt_rol_verbergen_tabbladen_sectiesState
		{
			get
			{
				return this.sgt_rol_verbergen_tabbladen_sectiesStateField;
			}
			set
			{
				this.sgt_rol_verbergen_tabbladen_sectiesStateField = value;
			}
		}
		public int Sgt_rol_verbergen_tabbladen_sectiesStatus
		{
			get
			{
				return this.sgt_rol_verbergen_tabbladen_sectiesStatusField;
			}
			set
			{
				this.sgt_rol_verbergen_tabbladen_sectiesStatusField = value;
			}
		}
	}
}
