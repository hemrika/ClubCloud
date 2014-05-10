using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetLocLabelsRequest : Request
	{
		private Moniker entityMonikerField;
		private string attributeNameField;
		private LocLabel[] labelsField;
		public Moniker EntityMoniker
		{
			get
			{
				return this.entityMonikerField;
			}
			set
			{
				this.entityMonikerField = value;
			}
		}
		public string AttributeName
		{
			get
			{
				return this.attributeNameField;
			}
			set
			{
				this.attributeNameField = value;
			}
		}
		public LocLabel[] Labels
		{
			get
			{
				return this.labelsField;
			}
			set
			{
				this.labelsField = value;
			}
		}
	}
}
