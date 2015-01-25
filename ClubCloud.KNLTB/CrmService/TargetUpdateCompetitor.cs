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
	public class TargetUpdateCompetitor : TargetUpdate
	{
		private competitor competitorField;

		[XmlElement] //[XmlElement(Order=0)]
		public competitor Competitor
		{
			get
			{
				return this.competitorField;
			}
			set
			{
				this.competitorField = value;
				base.RaisePropertyChanged("Competitor");
			}
		}

		public TargetUpdateCompetitor()
		{
		}
	}
}