using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateSgt_fac_buma_bijdrage_amusementsmuziekRequest : Request
	{
		private Guid entityIdField;
		private Sgt_fac_buma_bijdrage_amusementsmuziekState sgt_fac_buma_bijdrage_amusementsmuziekStateField;
		private int sgt_fac_buma_bijdrage_amusementsmuziekStatusField;
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
		public Sgt_fac_buma_bijdrage_amusementsmuziekState Sgt_fac_buma_bijdrage_amusementsmuziekState
		{
			get
			{
				return this.sgt_fac_buma_bijdrage_amusementsmuziekStateField;
			}
			set
			{
				this.sgt_fac_buma_bijdrage_amusementsmuziekStateField = value;
			}
		}
		public int Sgt_fac_buma_bijdrage_amusementsmuziekStatus
		{
			get
			{
				return this.sgt_fac_buma_bijdrage_amusementsmuziekStatusField;
			}
			set
			{
				this.sgt_fac_buma_bijdrage_amusementsmuziekStatusField = value;
			}
		}
	}
}
