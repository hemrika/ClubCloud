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
	public class RetrieveByResourceResourceGroupRequest : Request
	{
		private Guid resourceIdField;

		private QueryBase queryField;

		private bool returnDynamicEntitiesField;

		[XmlElement] //[XmlElement(Order=1)]
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

		[XmlElement] //[XmlElement(Order=0)]
		public Guid ResourceId
		{
			get
			{
				return this.resourceIdField;
			}
			set
			{
				this.resourceIdField = value;
				base.RaisePropertyChanged("ResourceId");
			}
		}

		[XmlAttribute]
		public bool ReturnDynamicEntities
		{
			get
			{
				return this.returnDynamicEntitiesField;
			}
			set
			{
				this.returnDynamicEntitiesField = value;
				base.RaisePropertyChanged("ReturnDynamicEntities");
			}
		}

		public RetrieveByResourceResourceGroupRequest()
		{
		}
	}
}