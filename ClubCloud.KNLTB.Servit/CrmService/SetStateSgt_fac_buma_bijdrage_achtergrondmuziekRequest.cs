using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateSgt_fac_buma_bijdrage_achtergrondmuziekRequest : Request
	{
		private Guid entityIdField;
		private Sgt_fac_buma_bijdrage_achtergrondmuziekState sgt_fac_buma_bijdrage_achtergrondmuziekStateField;
		private int sgt_fac_buma_bijdrage_achtergrondmuziekStatusField;
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
		public Sgt_fac_buma_bijdrage_achtergrondmuziekState Sgt_fac_buma_bijdrage_achtergrondmuziekState
		{
			get
			{
				return this.sgt_fac_buma_bijdrage_achtergrondmuziekStateField;
			}
			set
			{
				this.sgt_fac_buma_bijdrage_achtergrondmuziekStateField = value;
			}
		}
		public int Sgt_fac_buma_bijdrage_achtergrondmuziekStatus
		{
			get
			{
				return this.sgt_fac_buma_bijdrage_achtergrondmuziekStatusField;
			}
			set
			{
				this.sgt_fac_buma_bijdrage_achtergrondmuziekStatusField = value;
			}
		}
	}
}
