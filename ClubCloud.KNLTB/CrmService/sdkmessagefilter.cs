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
	public class sdkmessagefilter : BusinessEntity
	{
		private CrmNumber availabilityField;

		private Lookup createdbyField;

		private CrmDateTime createdonField;

		private CrmNumber customizationlevelField;

		private CrmBoolean iscustomprocessingstepallowedField;

		private Lookup modifiedbyField;

		private CrmDateTime modifiedonField;

		private Lookup organizationidField;

		private EntityNameReference primaryobjecttypecodeField;

		private Key sdkmessagefilteridField;

		private UniqueIdentifier sdkmessagefilteriduniqueField;

		private Lookup sdkmessageidField;

		private EntityNameReference secondaryobjecttypecodeField;

		[XmlElement] //[XmlElement(Order=0)]
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

		[XmlElement] //[XmlElement(Order=4)]
		public CrmBoolean iscustomprocessingstepallowed
		{
			get
			{
				return this.iscustomprocessingstepallowedField;
			}
			set
			{
				this.iscustomprocessingstepallowedField = value;
				base.RaisePropertyChanged("iscustomprocessingstepallowed");
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
		public EntityNameReference primaryobjecttypecode
		{
			get
			{
				return this.primaryobjecttypecodeField;
			}
			set
			{
				this.primaryobjecttypecodeField = value;
				base.RaisePropertyChanged("primaryobjecttypecode");
			}
		}

		[XmlElement] //[XmlElement(Order=9)]
		public Key sdkmessagefilterid
		{
			get
			{
				return this.sdkmessagefilteridField;
			}
			set
			{
				this.sdkmessagefilteridField = value;
				base.RaisePropertyChanged("sdkmessagefilterid");
			}
		}

		[XmlElement] //[XmlElement(Order=10)]
		public UniqueIdentifier sdkmessagefilteridunique
		{
			get
			{
				return this.sdkmessagefilteriduniqueField;
			}
			set
			{
				this.sdkmessagefilteriduniqueField = value;
				base.RaisePropertyChanged("sdkmessagefilteridunique");
			}
		}

		[XmlElement] //[XmlElement(Order=11)]
		public Lookup sdkmessageid
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

		[XmlElement] //[XmlElement(Order=12)]
		public EntityNameReference secondaryobjecttypecode
		{
			get
			{
				return this.secondaryobjecttypecodeField;
			}
			set
			{
				this.secondaryobjecttypecodeField = value;
				base.RaisePropertyChanged("secondaryobjecttypecode");
			}
		}

		public sdkmessagefilter()
		{
		}
	}
}