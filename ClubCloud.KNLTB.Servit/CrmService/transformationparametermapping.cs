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
	public class transformationparametermapping : BusinessEntity
	{
		private Lookup createdbyField;

		private CrmDateTime createdonField;

		private string dataField;

		private Picklist datatypecodeField;

		private Lookup modifiedbyField;

		private CrmDateTime modifiedonField;

		private CrmNumber parameterarrayindexField;

		private CrmNumber parametersequenceField;

		private Picklist parametertypecodeField;

		private Lookup transformationmappingidField;

		private Key transformationparametermappingidField;

		[XmlElement] //[XmlElement(Order=0)]
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

		[XmlElement] //[XmlElement(Order=1)]
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

		[XmlElement] //[XmlElement(Order=2)]
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

		[XmlElement] //[XmlElement(Order=3)]
		public Picklist datatypecode
		{
			get
			{
				return this.datatypecodeField;
			}
			set
			{
				this.datatypecodeField = value;
				base.RaisePropertyChanged("datatypecode");
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
		public CrmNumber parameterarrayindex
		{
			get
			{
				return this.parameterarrayindexField;
			}
			set
			{
				this.parameterarrayindexField = value;
				base.RaisePropertyChanged("parameterarrayindex");
			}
		}

		[XmlElement] //[XmlElement(Order=7)]
		public CrmNumber parametersequence
		{
			get
			{
				return this.parametersequenceField;
			}
			set
			{
				this.parametersequenceField = value;
				base.RaisePropertyChanged("parametersequence");
			}
		}

		[XmlElement] //[XmlElement(Order=8)]
		public Picklist parametertypecode
		{
			get
			{
				return this.parametertypecodeField;
			}
			set
			{
				this.parametertypecodeField = value;
				base.RaisePropertyChanged("parametertypecode");
			}
		}

		[XmlElement] //[XmlElement(Order=9)]
		public Lookup transformationmappingid
		{
			get
			{
				return this.transformationmappingidField;
			}
			set
			{
				this.transformationmappingidField = value;
				base.RaisePropertyChanged("transformationmappingid");
			}
		}

		[XmlElement] //[XmlElement(Order=10)]
		public Key transformationparametermappingid
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

		public transformationparametermapping()
		{
		}
	}
}