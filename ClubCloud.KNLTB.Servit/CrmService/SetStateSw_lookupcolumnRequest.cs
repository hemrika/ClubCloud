using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateSw_lookupcolumnRequest : Request
	{
		private Guid entityIdField;
		private Sw_lookupcolumnState sw_lookupcolumnStateField;
		private int sw_lookupcolumnStatusField;
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
		public Sw_lookupcolumnState Sw_lookupcolumnState
		{
			get
			{
				return this.sw_lookupcolumnStateField;
			}
			set
			{
				this.sw_lookupcolumnStateField = value;
			}
		}
		public int Sw_lookupcolumnStatus
		{
			get
			{
				return this.sw_lookupcolumnStatusField;
			}
			set
			{
				this.sw_lookupcolumnStatusField = value;
			}
		}
	}
}
