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
	public class lookupmapping : BusinessEntity
	{
		private Lookup columnmappingidField;

		private Lookup createdbyField;

		private CrmDateTime createdonField;

		private string lookupattributenameField;

		private string lookupentitynameField;

		private Key lookupmappingidField;

		private Picklist lookupsourcecodeField;

		private Lookup modifiedbyField;

		private CrmDateTime modifiedonField;

		private Picklist processcodeField;

		private LookUpMappingStateInfo statecodeField;

		private Status statuscodeField;

		private Lookup transformationparametermappingidField;

		[XmlElement] //[XmlElement(Order=0)]
		public Lookup columnmappingid
		{
			get
			{
				return this.columnmappingidField;
			}
			set
			{
				this.columnmappingidField = value;
				base.RaisePropertyChanged("columnmappingid");
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
		public string lookupattributename
		{
			get
			{
				return this.lookupattributenameField;
			}
			set
			{
				this.lookupattributenameField = value;
				base.RaisePropertyChanged("lookupattributename");
			}
		}

		[XmlElement] //[XmlElement(Order=4)]
		public string lookupentityname
		{
			get
			{
				return this.lookupentitynameField;
			}
			set
			{
				this.lookupentitynameField = value;
				base.RaisePropertyChanged("lookupentityname");
			}
		}

		[XmlElement] //[XmlElement(Order=5)]
		public Key lookupmappingid
		{
			get
			{
				return this.lookupmappingidField;
			}
			set
			{
				this.lookupmappingidField = value;
				base.RaisePropertyChanged("lookupmappingid");
			}
		}

		[XmlElement] //[XmlElement(Order=6)]
		public Picklist lookupsourcecode
		{
			get
			{
				return this.lookupsourcecodeField;
			}
			set
			{
				this.lookupsourcecodeField = value;
				base.RaisePropertyChanged("lookupsourcecode");
			}
		}

		[XmlElement] //[XmlElement(Order=7)]
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

		[XmlElement] //[XmlElement(Order=8)]
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

		[XmlElement] //[XmlElement(Order=9)]
		public Picklist processcode
		{
			get
			{
				return this.processcodeField;
			}
			set
			{
				this.processcodeField = value;
				base.RaisePropertyChanged("processcode");
			}
		}

		[XmlElement] //[XmlElement(Order=10)]
		public LookUpMappingStateInfo statecode
		{
			get
			{
				return this.statecodeField;
			}
			set
			{
				this.statecodeField = value;
				base.RaisePropertyChanged("statecode");
			}
		}

		[XmlElement] //[XmlElement(Order=11)]
		public Status statuscode
		{
			get
			{
				return this.statuscodeField;
			}
			set
			{
				this.statuscodeField = value;
				base.RaisePropertyChanged("statuscode");
			}
		}

		[XmlElement] //[XmlElement(Order=12)]
		public Lookup transformationparametermappingid
		{
			get
			{
				return this.transformationparametermappingidField;
			}
			set
			{
				this.transformationparametermappingidField = value;
				base.RaisePropertyChanged("transformationparametermappingid");
			}
		}

		public lookupmapping()
		{
		}
	}
}