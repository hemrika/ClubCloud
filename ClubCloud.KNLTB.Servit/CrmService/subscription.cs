using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
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
		public CrmDateTime completedsyncstartedon
		{
			get
			{
				return this.completedsyncstartedonField;
			}
			set
			{
				this.completedsyncstartedonField = value;
			}
		}
		public CrmDateTime lastsyncstartedon
		{
			get
			{
				return this.lastsyncstartedonField;
			}
			set
			{
				this.lastsyncstartedonField = value;
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
		public CrmBoolean reinitialize
		{
			get
			{
				return this.reinitializeField;
			}
			set
			{
				this.reinitializeField = value;
			}
		}
		public Key subscriptionid
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
		public CrmNumber subscriptiontype
		{
			get
			{
				return this.subscriptiontypeField;
			}
			set
			{
				this.subscriptiontypeField = value;
			}
		}
		public string syncentrytablename
		{
			get
			{
				return this.syncentrytablenameField;
			}
			set
			{
				this.syncentrytablenameField = value;
			}
		}
		public UniqueIdentifier systemuserid
		{
			get
			{
				return this.systemuseridField;
			}
			set
			{
				this.systemuseridField = value;
			}
		}
		public CrmNumber timezoneruleversionnumber
		{
			get
			{
				return this.timezoneruleversionnumberField;
			}
			set
			{
				this.timezoneruleversionnumberField = value;
			}
		}
		public CrmNumber utcconversiontimezonecode
		{
			get
			{
				return this.utcconversiontimezonecodeField;
			}
			set
			{
				this.utcconversiontimezonecodeField = value;
			}
		}
	}
}
