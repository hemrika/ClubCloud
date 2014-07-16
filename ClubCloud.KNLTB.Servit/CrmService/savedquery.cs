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
	public class savedquery : BusinessEntity
	{
		private string columnsetxmlField;

		private Lookup createdbyField;

		private CrmDateTime createdonField;

		private CrmNumber customizationlevelField;

		private string descriptionField;

		private string fetchxmlField;

		private CrmBoolean inproductionField;

		private CrmBoolean iscustomizableField;

		private CrmBoolean isdefaultField;

		private CrmBoolean isprivateField;

		private CrmBoolean isquickfindqueryField;

		private CrmBoolean isuserdefinedField;

		private string layoutxmlField;

		private Lookup modifiedbyField;

		private CrmDateTime modifiedonField;

		private string nameField;

		private Lookup organizationidField;

		private string queryapiField;

		private CrmNumber queryappusageField;

		private CrmNumber querytypeField;

		private string returnedtypecodeField;

		private Key savedqueryidField;

		private UniqueIdentifier savedqueryiduniqueField;

		[XmlElement] //[XmlElement(Order=0)]
		public string columnsetxml
		{
			get
			{
				return this.columnsetxmlField;
			}
			set
			{
				this.columnsetxmlField = value;
				base.RaisePropertyChanged("columnsetxml");
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
		public string description
		{
			get
			{
				return this.descriptionField;
			}
			set
			{
				this.descriptionField = value;
				base.RaisePropertyChanged("description");
			}
		}

		[XmlElement] //[XmlElement(Order=5)]
		public string fetchxml
		{
			get
			{
				return this.fetchxmlField;
			}
			set
			{
				this.fetchxmlField = value;
				base.RaisePropertyChanged("fetchxml");
			}
		}

		[XmlElement] //[XmlElement(Order=6)]
		public CrmBoolean inproduction
		{
			get
			{
				return this.inproductionField;
			}
			set
			{
				this.inproductionField = value;
				base.RaisePropertyChanged("inproduction");
			}
		}

		[XmlElement] //[XmlElement(Order=7)]
		public CrmBoolean iscustomizable
		{
			get
			{
				return this.iscustomizableField;
			}
			set
			{
				this.iscustomizableField = value;
				base.RaisePropertyChanged("iscustomizable");
			}
		}

		[XmlElement] //[XmlElement(Order=8)]
		public CrmBoolean isdefault
		{
			get
			{
				return this.isdefaultField;
			}
			set
			{
				this.isdefaultField = value;
				base.RaisePropertyChanged("isdefault");
			}
		}

		[XmlElement] //[XmlElement(Order=9)]
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

		[XmlElement] //[XmlElement(Order=10)]
		public CrmBoolean isquickfindquery
		{
			get
			{
				return this.isquickfindqueryField;
			}
			set
			{
				this.isquickfindqueryField = value;
				base.RaisePropertyChanged("isquickfindquery");
			}
		}

		[XmlElement] //[XmlElement(Order=11)]
		public CrmBoolean isuserdefined
		{
			get
			{
				return this.isuserdefinedField;
			}
			set
			{
				this.isuserdefinedField = value;
				base.RaisePropertyChanged("isuserdefined");
			}
		}

		[XmlElement] //[XmlElement(Order=12)]
		public string layoutxml
		{
			get
			{
				return this.layoutxmlField;
			}
			set
			{
				this.layoutxmlField = value;
				base.RaisePropertyChanged("layoutxml");
			}
		}

		[XmlElement] //[XmlElement(Order=13)]
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

		[XmlElement] //[XmlElement(Order=14)]
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

		[XmlElement] //[XmlElement(Order=15)]
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

		[XmlElement] //[XmlElement(Order=16)]
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

		[XmlElement] //[XmlElement(Order=17)]
		public string queryapi
		{
			get
			{
				return this.queryapiField;
			}
			set
			{
				this.queryapiField = value;
				base.RaisePropertyChanged("queryapi");
			}
		}

		[XmlElement] //[XmlElement(Order=18)]
		public CrmNumber queryappusage
		{
			get
			{
				return this.queryappusageField;
			}
			set
			{
				this.queryappusageField = value;
				base.RaisePropertyChanged("queryappusage");
			}
		}

		[XmlElement] //[XmlElement(Order=19)]
		public CrmNumber querytype
		{
			get
			{
				return this.querytypeField;
			}
			set
			{
				this.querytypeField = value;
				base.RaisePropertyChanged("querytype");
			}
		}

		[XmlElement] //[XmlElement(Order=20)]
		public string returnedtypecode
		{
			get
			{
				return this.returnedtypecodeField;
			}
			set
			{
				this.returnedtypecodeField = value;
				base.RaisePropertyChanged("returnedtypecode");
			}
		}

		[XmlElement] //[XmlElement(Order=21)]
		public Key savedqueryid
		{
			get
			{
				return this.savedqueryidField;
			}
			set
			{
				this.savedqueryidField = value;
				base.RaisePropertyChanged("savedqueryid");
			}
		}

		[XmlElement] //[XmlElement(Order=22)]
		public UniqueIdentifier savedqueryidunique
		{
			get
			{
				return this.savedqueryiduniqueField;
			}
			set
			{
				this.savedqueryiduniqueField = value;
				base.RaisePropertyChanged("savedqueryidunique");
			}
		}

		public savedquery()
		{
		}
	}
}