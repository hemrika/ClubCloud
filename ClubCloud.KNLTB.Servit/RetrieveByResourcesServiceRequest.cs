using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class RetrieveByResourcesServiceRequest : Request
	{
		private Guid[] resourceIdsField;
		private QueryBase queryField;
		private bool returnDynamicEntitiesField;
		[XmlArray(Order = 0)]
		public Guid[] ResourceIds
		{
			get
			{
				return this.resourceIdsField;
			}
			set
			{
				this.resourceIdsField = value;
				base.RaisePropertyChanged("ResourceIds");
			}
		}
		[XmlElement(Order = 1)]
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
	}
}
