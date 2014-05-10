using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class IsValidStateTransitionRequest : Request
	{
		private Moniker entityField;
		private string newStateField;
		private int newStatusField;
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
		public string NewState
		{
			get
			{
				return this.newStateField;
			}
			set
			{
				this.newStateField = value;
			}
		}
		public int NewStatus
		{
			get
			{
				return this.newStatusField;
			}
			set
			{
				this.newStatusField = value;
			}
		}
	}
}
