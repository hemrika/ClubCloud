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
	public class sdkmessage : BusinessEntity
	{
		private CrmBoolean autotransactField;

		private CrmNumber availabilityField;

		private string categorynameField;

		private Lookup createdbyField;

		private CrmDateTime createdonField;

		private CrmNumber customizationlevelField;

		private CrmBoolean expandField;

		private CrmBoolean isprivateField;

		private Lookup modifiedbyField;

		private CrmDateTime modifiedonField;

		private string nameField;

		private Lookup organizationidField;

		private Key sdkmessageidField;

		private UniqueIdentifier sdkmessageiduniqueField;

		private CrmBoolean templateField;

		[XmlElement] //[XmlElement(Order=0)]
		public CrmBoolean autotransact
		{
			get
			{
				return this.autotransactField;
			}
			set
			{
				this.autotransactField = value;
				base.RaisePropertyChanged("autotransact");
			}
		}

		[XmlElement] //[XmlElement(Order=1)]
		public CrmNumber availability
		{
			get
			{
				return this.availabilityField;
			}
			set
			{
				this.availabilityField = value;
				base.RaisePropertyChanged("availability");
			}
		}

		[XmlElement] //[XmlElement(Order=2)]
		public string categoryname
		{
			get
			{
				return this.categorynameField;
			}
			set
			{
				this.categorynameField = value;
				base.RaisePropertyChanged("categoryname");
			}
		}

		[XmlElement] //[XmlElement(Order=3)]
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

		[XmlElement] //[XmlElement(Order=4)]
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

		[XmlElement] //[XmlElement(Order=5)]
		public CrmNumber customizationlevel
		{
			get
			{
				return this.customizationlevelField;
			}
			set
			{
				this.customizationlevelField = value;
				base.RaisePropertyChanged("customizationlevel");
			}
		}

		[XmlElement] //[XmlElement(Order=6)]
		public CrmBoolean expand
		{
			get
			{
				return this.expandField;
			}
			set
			{
				this.expandField = value;
				base.RaisePropertyChanged("expand");
			}
		}

		[XmlElement] //[XmlElement(Order=7)]
		public CrmBoolean isprivate
		{
			get
			{
				return this.isprivateField;
			}
			set
			{
				this.isprivateField = value;
				base.RaisePropertyChanged("isprivate");
			}
		}

		[XmlElement] //[XmlElement(Order=8)]
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

		[XmlElement] //[XmlElement(Order=9)]
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

		[XmlElement] //[XmlElement(Order=10)]
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

		[XmlElement] //[XmlElement(Order=11)]
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

		[XmlElement] //[XmlElement(Order=12)]
		public Key sdkmessageid
		{
			get
			{
				return this.sdkmessageidField;
			}
			set
			{
				this.sdkmessageidField = value;
				base.RaisePropertyChanged("sdkmessageid");
			}
		}

		[XmlElement] //[XmlElement(Order=13)]
		public UniqueIdentifier sdkmessageidunique
		{
			get
			{
				return this.sdkmessageiduniqueField;
			}
			set
			{
				this.sdkmessageiduniqueField = value;
				base.RaisePropertyChanged("sdkmessageidunique");
			}
		}

		[XmlElement] //[XmlElement(Order=14)]
		public CrmBoolean template
		{
			get
			{
				return this.templateField;
			}
			set
			{
				this.templateField = value;
				base.RaisePropertyChanged("template");
			}
		}

		public sdkmessage()
		{
		}
	}
}