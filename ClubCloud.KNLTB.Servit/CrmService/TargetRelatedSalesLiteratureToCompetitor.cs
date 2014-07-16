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
	public class TargetRelatedSalesLiteratureToCompetitor : TargetRelated
	{
		private Guid salesLiteratureIdField;

		private Guid competitorIdField;

		[XmlElement] //[XmlElement(Order=1)]
		public Guid CompetitorId
		{
			get
			{
				return this.competitorIdField;
			}
			set
			{
				this.competitorIdField = value;
				base.RaisePropertyChanged("CompetitorId");
			}
		}

		[XmlElement] //[XmlElement(Order=0)]
		public Guid SalesLiteratureId
		{
			get
			{
				return this.salesLiteratureIdField;
			}
			set
			{
				this.salesLiteratureIdField = value;
				base.RaisePropertyChanged("SalesLiteratureId");
			}
		}

		public TargetRelatedSalesLiteratureToCompetitor()
		{
		}
	}
}