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
	public class TargetRollupDynamic : TargetRollup
	{
		private string entityNameField;

		private Guid entityIdField;

		private QueryBase queryField;

		[XmlElement] //[XmlElement(Order=1)]
		public Guid EntityId
		{
			get
			{
				return this.entityIdField;
			}
			set
			{
				this.entityIdField = value;
				base.RaisePropertyChanged("EntityId");
			}
		}

		[XmlElement] //[XmlElement(Order=0)]
		public string EntityName
		{
			get
			{
				return this.entityNameField;
			}
			set
			{
				this.entityNameField = value;
				base.RaisePropertyChanged("EntityName");
			}
		}

		[XmlElement] //[XmlElement(Order=2)]
		public QueryBase Query
		{
			get
			{
				return this.queryField;
			}
			set
			{
				this.queryField = value;
				base.RaisePropertyChanged("Query");
			}
		}

		public TargetRollupDynamic()
		{
		}
	}
}