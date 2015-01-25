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
	public class sgt_toe_toernooischema : BusinessEntity
	{
		private Lookup createdbyField;

		private CrmDateTime createdonField;

		private CrmNumber importsequencenumberField;

		private Lookup modifiedbyField;

		private CrmDateTime modifiedonField;

		private CrmDateTime overriddencreatedonField;

		private Owner owneridField;

		private Lookup owningbusinessunitField;

		private Lookup sgt_basisschema_1_idField;

		private Lookup sgt_basisschema_2_idField;

		private Lookup sgt_basisschema_3_idField;

		private string sgt_beschrijvingField;

		private string sgt_omschrijvingField;

		private Lookup sgt_schemagrootteidField;

		private string sgt_toe_toernooischema1Field;

		private Key sgt_toe_toernooischemaidField;

		private Lookup sgt_toernooisoort_idField;

		private string sgt_verkorte_codeField;

		private Sgt_toe_toernooischemaStateInfo statecodeField;

		private Status statuscodeField;

		private CrmNumber timezoneruleversionnumberField;

		private CrmNumber utcconversiontimezonecodeField;

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
		public CrmNumber importsequencenumber
		{
			get
			{
				return this.importsequencenumberField;
			}
			set
			{
				this.importsequencenumberField = value;
				base.RaisePropertyChanged("importsequencenumber");
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
		public CrmDateTime overriddencreatedon
		{
			get
			{
				return this.overriddencreatedonField;
			}
			set
			{
				this.overriddencreatedonField = value;
				base.RaisePropertyChanged("overriddencreatedon");
			}
		}

		[XmlElement] //[XmlElement(Order=6)]
		public Owner ownerid
		{
			get
			{
				return this.owneridField;
			}
			set
			{
				this.owneridField = value;
				base.RaisePropertyChanged("ownerid");
			}
		}

		[XmlElement] //[XmlElement(Order=7)]
		public Lookup owningbusinessunit
		{
			get
			{
				return this.owningbusinessunitField;
			}
			set
			{
				this.owningbusinessunitField = value;
				base.RaisePropertyChanged("owningbusinessunit");
			}
		}

		[XmlElement] //[XmlElement(Order=8)]
		public Lookup sgt_basisschema_1_id
		{
			get
			{
				return this.sgt_basisschema_1_idField;
			}
			set
			{
				this.sgt_basisschema_1_idField = value;
				base.RaisePropertyChanged("sgt_basisschema_1_id");
			}
		}

		[XmlElement] //[XmlElement(Order=9)]
		public Lookup sgt_basisschema_2_id
		{
			get
			{
				return this.sgt_basisschema_2_idField;
			}
			set
			{
				this.sgt_basisschema_2_idField = value;
				base.RaisePropertyChanged("sgt_basisschema_2_id");
			}
		}

		[XmlElement] //[XmlElement(Order=10)]
		public Lookup sgt_basisschema_3_id
		{
			get
			{
				return this.sgt_basisschema_3_idField;
			}
			set
			{
				this.sgt_basisschema_3_idField = value;
				base.RaisePropertyChanged("sgt_basisschema_3_id");
			}
		}

		[XmlElement] //[XmlElement(Order=11)]
		public string sgt_beschrijving
		{
			get
			{
				return this.sgt_beschrijvingField;
			}
			set
			{
				this.sgt_beschrijvingField = value;
				base.RaisePropertyChanged("sgt_beschrijving");
			}
		}

		[XmlElement] //[XmlElement(Order=12)]
		public string sgt_omschrijving
		{
			get
			{
				return this.sgt_omschrijvingField;
			}
			set
			{
				this.sgt_omschrijvingField = value;
				base.RaisePropertyChanged("sgt_omschrijving");
			}
		}

		[XmlElement] //[XmlElement(Order=13)]
		public Lookup sgt_schemagrootteid
		{
			get
			{
				return this.sgt_schemagrootteidField;
			}
			set
			{
				this.sgt_schemagrootteidField = value;
				base.RaisePropertyChanged("sgt_schemagrootteid");
			}
		}

		[XmlElement("sgt_toe_toernooischema")] //, Order=14)]
		public string sgt_toe_toernooischema1
		{
			get
			{
				return this.sgt_toe_toernooischema1Field;
			}
			set
			{
				this.sgt_toe_toernooischema1Field = value;
				base.RaisePropertyChanged("sgt_toe_toernooischema1");
			}
		}

		[XmlElement] //[XmlElement(Order=15)]
		public Key sgt_toe_toernooischemaid
		{
			get
			{
				return this.sgt_toe_toernooischemaidField;
			}
			set
			{
				this.sgt_toe_toernooischemaidField = value;
				base.RaisePropertyChanged("sgt_toe_toernooischemaid");
			}
		}

		[XmlElement] //[XmlElement(Order=16)]
		public Lookup sgt_toernooisoort_id
		{
			get
			{
				return this.sgt_toernooisoort_idField;
			}
			set
			{
				this.sgt_toernooisoort_idField = value;
				base.RaisePropertyChanged("sgt_toernooisoort_id");
			}
		}

		[XmlElement] //[XmlElement(Order=17)]
		public string sgt_verkorte_code
		{
			get
			{
				return this.sgt_verkorte_codeField;
			}
			set
			{
				this.sgt_verkorte_codeField = value;
				base.RaisePropertyChanged("sgt_verkorte_code");
			}
		}

		[XmlElement] //[XmlElement(Order=18)]
		public Sgt_toe_toernooischemaStateInfo statecode
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

		[XmlElement] //[XmlElement(Order=19)]
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

		[XmlElement] //[XmlElement(Order=20)]
		public CrmNumber timezoneruleversionnumber
		{
			get
			{
				return this.timezoneruleversionnumberField;
			}
			set
			{
				this.timezoneruleversionnumberField = value;
				base.RaisePropertyChanged("timezoneruleversionnumber");
			}
		}

		[XmlElement] //[XmlElement(Order=21)]
		public CrmNumber utcconversiontimezonecode
		{
			get
			{
				return this.utcconversiontimezonecodeField;
			}
			set
			{
				this.utcconversiontimezonecodeField = value;
				base.RaisePropertyChanged("utcconversiontimezonecode");
			}
		}

		public sgt_toe_toernooischema()
		{
		}
	}
}