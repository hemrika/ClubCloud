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
	public class license : BusinessEntity
	{
		private CrmDateTime installedonField;

		private Key licenseidField;

		private string licensekeyField;

		private UniqueIdentifier licensetypeField;

		private Lookup organizationidField;

		private CrmNumber timezoneruleversionnumberField;

		private CrmNumber utcconversiontimezonecodeField;

		[XmlElement] //[XmlElement(Order=0)]
		public CrmDateTime installedon
		{
			get
			{
				return this.installedonField;
			}
			set
			{
				this.installedonField = value;
				base.RaisePropertyChanged("installedon");
			}
		}

		[XmlElement] //[XmlElement(Order=1)]
		public Key licenseid
		{
			get
			{
				return this.licenseidField;
			}
			set
			{
				this.licenseidField = value;
				base.RaisePropertyChanged("licenseid");
			}
		}

		[XmlElement] //[XmlElement(Order=2)]
		public string licensekey
		{
			get
			{
				return this.licensekeyField;
			}
			set
			{
				this.licensekeyField = value;
				base.RaisePropertyChanged("licensekey");
			}
		}

		[XmlElement] //[XmlElement(Order=3)]
		public UniqueIdentifier licensetype
		{
			get
			{
				return this.licensetypeField;
			}
			set
			{
				this.licensetypeField = value;
				base.RaisePropertyChanged("licensetype");
			}
		}

		[XmlElement] //[XmlElement(Order=4)]
		public Lookup organizationid
		{
			get
			{
				return this.organizationidField;
			}
			set
			{
				this.organizationidField = value;
				base.RaisePropertyChanged("organizationid");
			}
		}

		[XmlElement] //[XmlElement(Order=5)]
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

		[XmlElement] //[XmlElement(Order=6)]
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

		public license()
		{
		}
	}
}