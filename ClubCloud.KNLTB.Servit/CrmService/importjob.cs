using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class importjob : BusinessEntity
	{
		private CrmDateTime completedonField;
		private CrmDateTime createdonField;
		private string dataField;
		private Key importjobidField;
		private CrmDateTime modifiedonField;
		private string nameField;
		private CrmDateTime startedonField;
		private CrmNumber timezoneruleversionnumberField;
		private CrmNumber utcconversiontimezonecodeField;
		public CrmDateTime completedon
		{
			get
			{
				return this.completedonField;
			}
			set
			{
				this.completedonField = value;
			}
		}
		public CrmDateTime createdon
		{
			get
			{
				return this.createdonField;
			}
			set
			{
				this.createdonField = value;
			}
		}
		public string data
		{
			get
			{
				return this.dataField;
			}
			set
			{
				this.dataField = value;
			}
		}
		public Key importjobid
		{
			get
			{
				return this.importjobidField;
			}
			set
			{
				this.importjobidField = value;
			}
		}
		public CrmDateTime modifiedon
		{
			get
			{
				return this.modifiedonField;
			}
			set
			{
				this.modifiedonField = value;
			}
		}
		public string name
		{
			get
			{
				return this.nameField;
			}
			set
			{
				this.nameField = value;
			}
		}
		public CrmDateTime startedon
		{
			get
			{
				return this.startedonField;
			}
			set
			{
				this.startedonField = value;
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
