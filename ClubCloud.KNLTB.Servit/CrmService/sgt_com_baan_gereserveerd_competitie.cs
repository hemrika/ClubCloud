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
	public class sgt_com_baan_gereserveerd_competitie : BusinessEntity
	{
		private Lookup createdbyField;

		private CrmDateTime createdonField;

		private CrmNumber importsequencenumberField;

		private Lookup modifiedbyField;

		private CrmDateTime modifiedonField;

		private CrmDateTime overriddencreatedonField;

		private Owner owneridField;

		private Lookup owningbusinessunitField;

		private Lookup sgt_accomodatieidField;

		private CrmNumber sgt_binnen_avondField;

		private CrmNumber sgt_binnen_middagField;

		private CrmNumber sgt_binnen_morgenField;

		private CrmNumber sgt_buiten_avondField;

		private CrmNumber sgt_buiten_middagField;

		private CrmNumber sgt_buiten_morgenField;

		private Key sgt_com_baan_gereserveerd_competitieidField;

		private string sgt_com_nameField;

		private Lookup sgt_competitieidField;

		private Lookup sgt_competitieinschrijvingidField;

		private Picklist sgt_dagField;

		private string sgt_dagnrField;

		private Lookup sgt_verenigingidField;

		private CrmBoolean sgt_verlichtingField;

		private Sgt_com_baan_gereserveerd_competitieStateInfo statecodeField;

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
		public Lookup sgt_accomodatieid
		{
			get
			{
				return this.sgt_accomodatieidField;
			}
			set
			{
				this.sgt_accomodatieidField = value;
				base.RaisePropertyChanged("sgt_accomodatieid");
			}
		}

		[XmlElement] //[XmlElement(Order=9)]
		public CrmNumber sgt_binnen_avond
		{
			get
			{
				return this.sgt_binnen_avondField;
			}
			set
			{
				this.sgt_binnen_avondField = value;
				base.RaisePropertyChanged("sgt_binnen_avond");
			}
		}

		[XmlElement] //[XmlElement(Order=10)]
		public CrmNumber sgt_binnen_middag
		{
			get
			{
				return this.sgt_binnen_middagField;
			}
			set
			{
				this.sgt_binnen_middagField = value;
				base.RaisePropertyChanged("sgt_binnen_middag");
			}
		}

		[XmlElement] //[XmlElement(Order=11)]
		public CrmNumber sgt_binnen_morgen
		{
			get
			{
				return this.sgt_binnen_morgenField;
			}
			set
			{
				this.sgt_binnen_morgenField = value;
				base.RaisePropertyChanged("sgt_binnen_morgen");
			}
		}

		[XmlElement] //[XmlElement(Order=12)]
		public CrmNumber sgt_buiten_avond
		{
			get
			{
				return this.sgt_buiten_avondField;
			}
			set
			{
				this.sgt_buiten_avondField = value;
				base.RaisePropertyChanged("sgt_buiten_avond");
			}
		}

		[XmlElement] //[XmlElement(Order=13)]
		public CrmNumber sgt_buiten_middag
		{
			get
			{
				return this.sgt_buiten_middagField;
			}
			set
			{
				this.sgt_buiten_middagField = value;
				base.RaisePropertyChanged("sgt_buiten_middag");
			}
		}

		[XmlElement] //[XmlElement(Order=14)]
		public CrmNumber sgt_buiten_morgen
		{
			get
			{
				return this.sgt_buiten_morgenField;
			}
			set
			{
				this.sgt_buiten_morgenField = value;
				base.RaisePropertyChanged("sgt_buiten_morgen");
			}
		}

		[XmlElement] //[XmlElement(Order=15)]
		public Key sgt_com_baan_gereserveerd_competitieid
		{
			get
			{
				return this.sgt_com_baan_gereserveerd_competitieidField;
			}
			set
			{
				this.sgt_com_baan_gereserveerd_competitieidField = value;
				base.RaisePropertyChanged("sgt_com_baan_gereserveerd_competitieid");
			}
		}

		[XmlElement] //[XmlElement(Order=16)]
		public string sgt_com_name
		{
			get
			{
				return this.sgt_com_nameField;
			}
			set
			{
				this.sgt_com_nameField = value;
				base.RaisePropertyChanged("sgt_com_name");
			}
		}

		[XmlElement] //[XmlElement(Order=17)]
		public Lookup sgt_competitieid
		{
			get
			{
				return this.sgt_competitieidField;
			}
			set
			{
				this.sgt_competitieidField = value;
				base.RaisePropertyChanged("sgt_competitieid");
			}
		}

		[XmlElement] //[XmlElement(Order=18)]
		public Lookup sgt_competitieinschrijvingid
		{
			get
			{
				return this.sgt_competitieinschrijvingidField;
			}
			set
			{
				this.sgt_competitieinschrijvingidField = value;
				base.RaisePropertyChanged("sgt_competitieinschrijvingid");
			}
		}

		[XmlElement] //[XmlElement(Order=19)]
		public Picklist sgt_dag
		{
			get
			{
				return this.sgt_dagField;
			}
			set
			{
				this.sgt_dagField = value;
				base.RaisePropertyChanged("sgt_dag");
			}
		}

		[XmlElement] //[XmlElement(Order=20)]
		public string sgt_dagnr
		{
			get
			{
				return this.sgt_dagnrField;
			}
			set
			{
				this.sgt_dagnrField = value;
				base.RaisePropertyChanged("sgt_dagnr");
			}
		}

		[XmlElement] //[XmlElement(Order=21)]
		public Lookup sgt_verenigingid
		{
			get
			{
				return this.sgt_verenigingidField;
			}
			set
			{
				this.sgt_verenigingidField = value;
				base.RaisePropertyChanged("sgt_verenigingid");
			}
		}

		[XmlElement] //[XmlElement(Order=22)]
		public CrmBoolean sgt_verlichting
		{
			get
			{
				return this.sgt_verlichtingField;
			}
			set
			{
				this.sgt_verlichtingField = value;
				base.RaisePropertyChanged("sgt_verlichting");
			}
		}

		[XmlElement] //[XmlElement(Order=23)]
		public Sgt_com_baan_gereserveerd_competitieStateInfo statecode
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

		[XmlElement] //[XmlElement(Order=24)]
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

		[XmlElement] //[XmlElement(Order=25)]
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

		[XmlElement] //[XmlElement(Order=26)]
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

		public sgt_com_baan_gereserveerd_competitie()
		{
		}
	}
}