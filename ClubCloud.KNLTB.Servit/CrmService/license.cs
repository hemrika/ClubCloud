using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class license : BusinessEntity
	{
		private CrmDateTime installedonField;
		private Key licenseidField;
		private string licensekeyField;
		private UniqueIdentifier licensetypeField;
		private Lookup organizationidField;
		private CrmNumber timezoneruleversionnumberField;
		private CrmNumber utcconversiontimezonecodeField;
		public CrmDateTime installedon
		{
			get
			{
				return this.installedonField;
			}
			set
			{
				this.installedonField = value;
			}
		}
		public Key licenseid
		{
			get
			{
				return this.licenseidField;
			}
			set
			{
				this.licenseidField = value;
			}
		}
		public string licensekey
		{
			get
			{
				return this.licensekeyField;
			}
			set
			{
				this.licensekeyField = value;
			}
		}
		public UniqueIdentifier licensetype
		{
			get
			{
				return this.licensetypeField;
			}
			set
			{
				this.licensetypeField = value;
			}
		}
		public Lookup organizationid
		{
			get
			{
				return this.organizationidField;
			}
			set
			{
				this.organizationidField = value;
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
