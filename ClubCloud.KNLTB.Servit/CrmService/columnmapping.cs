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
	public class columnmapping : BusinessEntity
	{
		private Key columnmappingidField;

		private Lookup createdbyField;

		private CrmDateTime createdonField;

		private Lookup importmapidField;

		private Lookup modifiedbyField;

		private CrmDateTime modifiedonField;

		private Picklist processcodeField;

		private string sourceattributenameField;

		private string sourceentitynameField;

		private ColumnMappingStateInfo statecodeField;

		private Status statuscodeField;

		private string targetattributenameField;

		private string targetentitynameField;

		[XmlElement] //[XmlElement(Order=0)]
		public Key columnmappingid
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
		public Lookup importmapid
		{
			get
			{
				return this.importmapidField;
			}
			set
			{
				this.importmapidField = value;
				base.RaisePropertyChanged("importmapid");
			}
		}

		[XmlElement] //[XmlElement(Order=4)]
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

		[XmlElement] //[XmlElement(Order=5)]
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

		[XmlElement] //[XmlElement(Order=6)]
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

		[XmlElement] //[XmlElement(Order=7)]
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

		[XmlElement] //[XmlElement(Order=8)]
		public string sourceentityname
		{
			get
			{
				return this.sourceentitynameField;
			}
			set
			{
				this.sourceentitynameField = value;
				base.RaisePropertyChanged("sourceentityname");
			}
		}

		[XmlElement] //[XmlElement(Order=9)]
		public ColumnMappingStateInfo statecode
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

		[XmlElement] //[XmlElement(Order=10)]
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

		[XmlElement] //[XmlElement(Order=11)]
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

		[XmlElement] //[XmlElement(Order=12)]
		public string targetentityname
		{
			get
			{
				return this.targetentitynameField;
			}
			set
			{
				this.targetentitynameField = value;
				base.RaisePropertyChanged("targetentityname");
			}
		}

		public columnmapping()
		{
		}
	}
}