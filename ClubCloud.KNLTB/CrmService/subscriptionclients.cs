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
	public class subscriptionclients : BusinessEntity
	{
		private UniqueIdentifier clientidField;

		private CrmBoolean isprimaryclientField;

		private string machinenameField;

		private Key subscriptionclientidField;

		private UniqueIdentifier subscriptionidField;

		[XmlElement] //[XmlElement(Order=0)]
		public UniqueIdentifier clientid
		{
			get
			{
				return this.clientidField;
			}
			set
			{
				this.clientidField = value;
				base.RaisePropertyChanged("clientid");
			}
		}

		[XmlElement] //[XmlElement(Order=1)]
		public CrmBoolean isprimaryclient
		{
			get
			{
				return this.isprimaryclientField;
			}
			set
			{
				this.isprimaryclientField = value;
				base.RaisePropertyChanged("isprimaryclient");
			}
		}

		[XmlElement] //[XmlElement(Order=2)]
		public string machinename
		{
			get
			{
				return this.machinenameField;
			}
			set
			{
				this.machinenameField = value;
				base.RaisePropertyChanged("machinename");
			}
		}

		[XmlElement] //[XmlElement(Order=3)]
		public Key subscriptionclientid
		{
			get
			{
				return this.subscriptionclientidField;
			}
			set
			{
				this.subscriptionclientidField = value;
				base.RaisePropertyChanged("subscriptionclientid");
			}
		}

		[XmlElement] //[XmlElement(Order=4)]
		public UniqueIdentifier subscriptionid
		{
			get
			{
				return this.subscriptionidField;
			}
			set
			{
				this.subscriptionidField = value;
				base.RaisePropertyChanged("subscriptionid");
			}
		}

		public subscriptionclients()
		{
		}
	}
}