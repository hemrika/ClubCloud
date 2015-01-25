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
	public class SetLocLabelsRequest : Request
	{
		private Moniker entityMonikerField;

		private string attributeNameField;

		private LocLabel[] labelsField;

		[XmlElement] //[XmlElement(Order=1)]
		public string AttributeName
		{
			get
			{
				return this.attributeNameField;
			}
			set
			{
				this.attributeNameField = value;
				base.RaisePropertyChanged("AttributeName");
			}
		}

		[XmlElement] //[XmlElement(Order=0)]
		public Moniker EntityMoniker
		{
			get
			{
				return this.entityMonikerField;
			}
			set
			{
				this.entityMonikerField = value;
				base.RaisePropertyChanged("EntityMoniker");
			}
		}

		[XmlArray] //[XmlArray(Order=2)]
		public LocLabel[] Labels
		{
			get
			{
				return this.labelsField;
			}
			set
			{
				this.labelsField = value;
				base.RaisePropertyChanged("Labels");
			}
		}

		public SetLocLabelsRequest()
		{
		}
	}
}