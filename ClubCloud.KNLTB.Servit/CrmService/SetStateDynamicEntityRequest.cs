using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[GeneratedCode("System.Xml", "4.0.30319.33440")]
	[Serializable]
	[XmlType(Namespace="http://schemas.microsoft.com/crm/2007/WebServices")]
	public class SetStateDynamicEntityRequest : Request
	{
		private Moniker entityField;

		private string stateField;

		private int statusField;

		[XmlElement] //[XmlElement(Order=0)]
		public Moniker Entity
		{
			get
			{
				return this.entityField;
			}
			set
			{
				this.entityField = value;
				base.RaisePropertyChanged("Entity");
			}
		}

		[XmlElement] //[XmlElement(Order=1)]
		public string State
		{
			get
			{
				return this.stateField;
			}
			set
			{
				this.stateField = value;
				base.RaisePropertyChanged("State");
			}
		}

		[XmlElement] //[XmlElement(Order=2)]
		public int Status
		{
			get
			{
				return this.statusField;
			}
			set
			{
				this.statusField = value;
				base.RaisePropertyChanged("Status");
			}
		}

		public SetStateDynamicEntityRequest()
		{
		}
	}
}