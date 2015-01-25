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
	public class attributemap : BusinessEntity
	{
		private Key attributemapidField;

		private Lookup createdbyField;

		private CrmDateTime createdonField;

		private Lookup entitymapidField;

		private CrmBoolean issystemField;

		private Lookup modifiedbyField;

		private CrmDateTime modifiedonField;

		private Lookup organizationidField;

		private Lookup parentattributemapidField;

		private string sourceattributenameField;

		private string targetattributenameField;

		[XmlElement] //[XmlElement(Order=0)]
		public Key attributemapid
		{
			get
			{
				return this.attributemapidField;
			}
			set
			{
				this.attributemapidField = value;
				base.RaisePropertyChanged("attributemapid");
			}
		}

		[XmlElement] //[XmlElement(Order=1)]
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

		[XmlElement] //[XmlElement(Order=2)]
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

		[XmlElement] //[XmlElement(Order=3)]
		public Lookup entitymapid
		{
			get
			{
				return this.entitymapidField;
			}
			set
			{
				this.entitymapidField = value;
				base.RaisePropertyChanged("entitymapid");
			}
		}

		[XmlElement] //[XmlElement(Order=4)]
		public CrmBoolean issystem
		{
			get
			{
				return this.issystemField;
			}
			set
			{
				this.issystemField = value;
				base.RaisePropertyChanged("issystem");
			}
		}

		[XmlElement] //[XmlElement(Order=5)]
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

		[XmlElement] //[XmlElement(Order=6)]
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

		[XmlElement] //[XmlElement(Order=7)]
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

		[XmlElement] //[XmlElement(Order=8)]
		public Lookup parentattributemapid
		{
			get
			{
				return this.parentattributemapidField;
			}
			set
			{
				this.parentattributemapidField = value;
				base.RaisePropertyChanged("parentattributemapid");
			}
		}

		[XmlElement] //[XmlElement(Order=9)]
		public string sourceattributename
		{
			get
			{
				return this.sourceattributenameField;
			}
			set
			{
				this.sourceattributenameField = value;
				base.RaisePropertyChanged("sourceattributename");
			}
		}

		[XmlElement] //[XmlElement(Order=10)]
		public string targetattributename
		{
			get
			{
				return this.targetattributenameField;
			}
			set
			{
				this.targetattributenameField = value;
				base.RaisePropertyChanged("targetattributename");
			}
		}

		public attributemap()
		{
		}
	}
}