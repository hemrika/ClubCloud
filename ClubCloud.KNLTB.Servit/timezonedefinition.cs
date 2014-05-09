using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class timezonedefinition : BusinessEntity
	{
		private CrmNumber biasField;
		private Lookup createdbyField;
		private CrmDateTime createdonField;
		private string daylightnameField;
		private Lookup modifiedbyField;
		private CrmDateTime modifiedonField;
		private Lookup organizationidField;
		private CrmNumber retiredorderField;
		private string standardnameField;
		private CrmNumber timezonecodeField;
		private Key timezonedefinitionidField;
		private string userinterfacenameField;
		[XmlElement(Order = 0)]
		public CrmNumber bias
		{
			get
			{
				return this.biasField;
			}
			set
			{
				this.biasField = value;
				base.RaisePropertyChanged("bias");
			}
		}
		[XmlElement(Order = 1)]
		public Lookup createdby
		{
			get
			{
				return this.createdbyField;
			}
			set
			{
				this.createdbyField = value;
				base.RaisePropertyChanged("createdby");
			}
		}
		[XmlElement(Order = 2)]
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
		[XmlElement(Order = 3)]
		public string daylightname
		{
			get
			{
				return this.daylightnameField;
			}
			set
			{
				this.daylightnameField = value;
				base.RaisePropertyChanged("daylightname");
			}
		}
		[XmlElement(Order = 4)]
		public Lookup modifiedby
		{
			get
			{
				return this.modifiedbyField;
			}
			set
			{
				this.modifiedbyField = value;
				base.RaisePropertyChanged("modifiedby");
			}
		}
		[XmlElement(Order = 5)]
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
		[XmlElement(Order = 6)]
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
		[XmlElement(Order = 7)]
		public CrmNumber retiredorder
		{
			get
			{
				return this.retiredorderField;
			}
			set
			{
				this.retiredorderField = value;
				base.RaisePropertyChanged("retiredorder");
			}
		}
		[XmlElement(Order = 8)]
		public string standardname
		{
			get
			{
				return this.standardnameField;
			}
			set
			{
				this.standardnameField = value;
				base.RaisePropertyChanged("standardname");
			}
		}
		[XmlElement(Order = 9)]
		public CrmNumber timezonecode
		{
			get
			{
				return this.timezonecodeField;
			}
			set
			{
				this.timezonecodeField = value;
				base.RaisePropertyChanged("timezonecode");
			}
		}
		[XmlElement(Order = 10)]
		public Key timezonedefinitionid
		{
			get
			{
				return this.timezonedefinitionidField;
			}
			set
			{
				this.timezonedefinitionidField = value;
				base.RaisePropertyChanged("timezonedefinitionid");
			}
		}
		[XmlElement(Order = 11)]
		public string userinterfacename
		{
			get
			{
				return this.userinterfacenameField;
			}
			set
			{
				this.userinterfacenameField = value;
				base.RaisePropertyChanged("userinterfacename");
			}
		}
	}
}
