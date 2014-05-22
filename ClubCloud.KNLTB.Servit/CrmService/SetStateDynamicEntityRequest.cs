using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateDynamicEntityRequest : Request
	{
		private Moniker entityField;
		private string stateField;
		private int statusField;
		public Moniker Entity
		{
			get
			{
				return this.entityField;
			}
			set
			{
				this.entityField = value;
			}
		}
		public string State
		{
			get
			{
				return this.stateField;
			}
			set
			{
				this.stateField = value;
			}
		}
		public int Status
		{
			get
			{
				return this.statusField;
			}
			set
			{
				this.statusField = value;
			}
		}
	}
}