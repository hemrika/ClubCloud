using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateSgt_bo_gewijzigde_persoonsgegevensRequest : Request
	{
		private Guid entityIdField;
		private Sgt_bo_gewijzigde_persoonsgegevensState sgt_bo_gewijzigde_persoonsgegevensStateField;
		private int sgt_bo_gewijzigde_persoonsgegevensStatusField;
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
		public Sgt_bo_gewijzigde_persoonsgegevensState Sgt_bo_gewijzigde_persoonsgegevensState
		{
			get
			{
				return this.sgt_bo_gewijzigde_persoonsgegevensStateField;
			}
			set
			{
				this.sgt_bo_gewijzigde_persoonsgegevensStateField = value;
			}
		}
		public int Sgt_bo_gewijzigde_persoonsgegevensStatus
		{
			get
			{
				return this.sgt_bo_gewijzigde_persoonsgegevensStatusField;
			}
			set
			{
				this.sgt_bo_gewijzigde_persoonsgegevensStatusField = value;
			}
		}
	}
}
