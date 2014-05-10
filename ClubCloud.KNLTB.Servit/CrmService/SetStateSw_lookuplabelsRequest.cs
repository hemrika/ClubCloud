using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateSw_lookuplabelsRequest : Request
	{
		private Guid entityIdField;
		private Sw_lookuplabelsState sw_lookuplabelsStateField;
		private int sw_lookuplabelsStatusField;
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
		public Sw_lookuplabelsState Sw_lookuplabelsState
		{
			get
			{
				return this.sw_lookuplabelsStateField;
			}
			set
			{
				this.sw_lookuplabelsStateField = value;
			}
		}
		public int Sw_lookuplabelsStatus
		{
			get
			{
				return this.sw_lookuplabelsStatusField;
			}
			set
			{
				this.sw_lookuplabelsStatusField = value;
			}
		}
	}
}
