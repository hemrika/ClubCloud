using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class GenerateSalesOrderFromOpportunityRequest : Request
	{
		private Guid opportunityIdField;
		private ColumnSetBase columnSetField;
		private bool returnDynamicEntitiesField;
		[XmlElement(Order = 0)]
		public Guid OpportunityId
		{
			get
			{
				return this.opportunityIdField;
			}
			set
			{
				this.opportunityIdField = value;
				base.RaisePropertyChanged("OpportunityId");
			}
		}
		[XmlElement(Order = 1)]
		public ColumnSetBase ColumnSet
		{
			get
			{
				return this.columnSetField;
			}
			set
			{
				this.columnSetField = value;
				base.RaisePropertyChanged("ColumnSet");
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
