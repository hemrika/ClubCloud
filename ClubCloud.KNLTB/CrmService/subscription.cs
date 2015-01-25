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
	public class subscription : BusinessEntity
	{
		private CrmDateTime completedsyncstartedonField;

		private CrmDateTime lastsyncstartedonField;

		private string machinenameField;

		private CrmBoolean reinitializeField;

		private Key subscriptionidField;

		private CrmNumber subscriptiontypeField;

		private string syncentrytablenameField;

		private UniqueIdentifier systemuseridField;

		private CrmNumber timezoneruleversionnumberField;

		private CrmNumber utcconversiontimezonecodeField;

		[XmlElement] //[XmlElement(Order=0)]
		public CrmDateTime completedsyncstartedon
		{
			get
			{
				return this.completedsyncstartedonField;
			}
			set
			{
				this.completedsyncstartedonField = value;
				base.RaisePropertyChanged("completedsyncstartedon");
			}
		}

		[XmlElement] //[XmlElement(Order=1)]
		public CrmDateTime lastsyncstartedon
		{
			get
			{
				return this.lastsyncstartedonField;
			}
			set
			{
				this.lastsyncstartedonField = value;
				base.RaisePropertyChanged("lastsyncstartedon");
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
		public CrmBoolean reinitialize
		{
			get
			{
				return this.reinitializeField;
			}
			set
			{
				this.reinitializeField = value;
				base.RaisePropertyChanged("reinitialize");
			}
		}

		[XmlElement] //[XmlElement(Order=4)]
		public Key subscriptionid
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

		[XmlElement] //[XmlElement(Order=5)]
		public CrmNumber subscriptiontype
		{
			get
			{
				return this.subscriptiontypeField;
			}
			set
			{
				this.subscriptiontypeField = value;
				base.RaisePropertyChanged("subscriptiontype");
			}
		}

		[XmlElement] //[XmlElement(Order=6)]
		public string syncentrytablename
		{
			get
			{
				return this.syncentrytablenameField;
			}
			set
			{
				this.syncentrytablenameField = value;
				base.RaisePropertyChanged("syncentrytablename");
			}
		}

		[XmlElement] //[XmlElement(Order=7)]
		public UniqueIdentifier systemuserid
		{
			get
			{
				return this.systemuseridField;
			}
			set
			{
				this.systemuseridField = value;
				base.RaisePropertyChanged("systemuserid");
			}
		}

		[XmlElement] //[XmlElement(Order=8)]
		public CrmNumber timezoneruleversionnumber
		{
			get
			{
				return this.timezoneruleversionnumberField;
			}
			set
			{
				this.timezoneruleversionnumberField = value;
				base.RaisePropertyChanged("timezoneruleversionnumber");
			}
		}

		[XmlElement] //[XmlElement(Order=9)]
		public CrmNumber utcconversiontimezonecode
		{
			get
			{
				return this.utcconversiontimezonecodeField;
			}
			set
			{
				this.utcconversiontimezonecodeField = value;
				base.RaisePropertyChanged("utcconversiontimezonecode");
			}
		}

		public subscription()
		{
		}
	}
}