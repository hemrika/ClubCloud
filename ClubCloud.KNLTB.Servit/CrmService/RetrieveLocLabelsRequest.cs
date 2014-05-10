using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class RetrieveLocLabelsRequest : Request
	{
		private Moniker entityMonikerField;
		private string attributeNameField;
		private bool includeUnpublishedField;
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
		public bool IncludeUnpublished
		{
			get
			{
				return this.includeUnpublishedField;
			}
			set
			{
				this.includeUnpublishedField = value;
			}
		}
	}
}
