using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class subscriptionclients : BusinessEntity
	{
		private UniqueIdentifier clientidField;
		private CrmBoolean isprimaryclientField;
		private string machinenameField;
		private Key subscriptionclientidField;
		private UniqueIdentifier subscriptionidField;
		public UniqueIdentifier clientid
		{
			get
			{
				return this.clientidField;
			}
			set
			{
				this.clientidField = value;
			}
		}
		public CrmBoolean isprimaryclient
		{
			get
			{
				return this.isprimaryclientField;
			}
			set
			{
				this.isprimaryclientField = value;
			}
		}
		public string machinename
		{
			get
			{
				return this.machinenameField;
			}
			set
			{
				this.machinenameField = value;
			}
		}
		public Key subscriptionclientid
		{
			get
			{
				return this.subscriptionclientidField;
			}
			set
			{
				this.subscriptionclientidField = value;
			}
		}
		public UniqueIdentifier subscriptionid
		{
			get
			{
				return this.subscriptionidField;
			}
			set
			{
				this.subscriptionidField = value;
			}
		}
	}
}
