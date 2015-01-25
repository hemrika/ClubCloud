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
	public class GetTrackingTokenEmailResponse : Response
	{
		private string trackingTokenField;

		[XmlElement] //[XmlElement(Order=0)]
		public string TrackingToken
		{
			get
			{
				return this.trackingTokenField;
			}
			set
			{
				this.trackingTokenField = value;
				base.RaisePropertyChanged("TrackingToken");
			}
		}

		public GetTrackingTokenEmailResponse()
		{
		}
	}
}