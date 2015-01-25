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
	public class picklistmapping : BusinessEntity
	{
		private Lookup columnmappingidField;

		private Lookup createdbyField;

		private CrmDateTime createdonField;

		private Lookup modifiedbyField;

		private CrmDateTime modifiedonField;

		private Key picklistmappingidField;

		private Picklist processcodeField;

		private string sourcevalueField;

		private PickListMappingStateInfo statecodeField;

		private Status statuscodeField;

		private CrmNumber targetvalueField;

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

		[XmlElement] //[XmlElement(Order=4)]
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

		[XmlElement] //[XmlElement(Order=5)]
		public Key picklistmappingid
		{
			get
			{
				return this.picklistmappingidField;
			}
			set
			{
				this.picklistmappingidField = value;
				base.RaisePropertyChanged("picklistmappingid");
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
		public string sourcevalue
		{
			get
			{
				return this.sourcevalueField;
			}
			set
			{
				this.sourcevalueField = value;
				base.RaisePropertyChanged("sourcevalue");
			}
		}

		[XmlElement] //[XmlElement(Order=8)]
		public PickListMappingStateInfo statecode
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

		[XmlElement] //[XmlElement(Order=9)]
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

		[XmlElement] //[XmlElement(Order=10)]
		public CrmNumber targetvalue
		{
			get
			{
				return this.targetvalueField;
			}
			set
			{
				this.targetvalueField = value;
				base.RaisePropertyChanged("targetvalue");
			}
		}

		public picklistmapping()
		{
		}
	}
}