using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class timezonelocalizedname : BusinessEntity
	{
		private Lookup createdbyField;
		private CrmDateTime createdonField;
		private CrmNumber cultureidField;
		private string daylightnameField;
		private Lookup modifiedbyField;
		private CrmDateTime modifiedonField;
		private Lookup organizationidField;
		private string standardnameField;
		private Lookup timezonedefinitionidField;
		private Key timezonelocalizednameidField;
		private string userinterfacenameField;
		[XmlElement(Order = 0)]
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
		public CrmNumber cultureid
		{
			get
			{
				return this.cultureidField;
			}
			set
			{
				this.cultureidField = value;
				base.RaisePropertyChanged("cultureid");
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
		[XmlElement(Order = 8)]
		public Lookup timezonedefinitionid
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
		[XmlElement(Order = 9)]
		public Key timezonelocalizednameid
		{
			get
			{
				return this.timezonelocalizednameidField;
			}
			set
			{
				this.timezonelocalizednameidField = value;
				base.RaisePropertyChanged("timezonelocalizednameid");
			}
		}
		[XmlElement(Order = 10)]
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
