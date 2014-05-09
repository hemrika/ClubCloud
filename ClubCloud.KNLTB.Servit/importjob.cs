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
		[XmlElement(Order = 0)]
		public CrmDateTime completedon
		{
			get
			{
				return this.completedonField;
			}
			set
			{
				this.completedonField = value;
				base.RaisePropertyChanged("completedon");
			}
		}
		[XmlElement(Order = 1)]
		public CrmDateTime createdon
		{
			get
			{
				return this.createdonField;
			}
			set
			{
				this.createdonField = value;
				base.RaisePropertyChanged("createdon");
			}
		}
		[XmlElement(Order = 2)]
		public string data
		{
			get
			{
				return this.dataField;
			}
			set
			{
				this.dataField = value;
				base.RaisePropertyChanged("data");
			}
		}
		[XmlElement(Order = 3)]
		public Key importjobid
		{
			get
			{
				return this.importjobidField;
			}
			set
			{
				this.importjobidField = value;
				base.RaisePropertyChanged("importjobid");
			}
		}
		[XmlElement(Order = 4)]
		public CrmDateTime modifiedon
		{
			get
			{
				return this.modifiedonField;
			}
			set
			{
				this.modifiedonField = value;
				base.RaisePropertyChanged("modifiedon");
			}
		}
		[XmlElement(Order = 5)]
		public string name
		{
			get
			{
				return this.nameField;
			}
			set
			{
				this.nameField = value;
				base.RaisePropertyChanged("name");
			}
		}
		[XmlElement(Order = 6)]
		public CrmDateTime startedon
		{
			get
			{
				return this.startedonField;
			}
			set
			{
				this.startedonField = value;
				base.RaisePropertyChanged("startedon");
			}
		}
		[XmlElement(Order = 7)]
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
		[XmlElement(Order = 8)]
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
	}
}
