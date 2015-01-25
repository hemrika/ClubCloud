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
	public class sgt_top_groepsevenement : BusinessEntity
	{
		private Lookup createdbyField;

		private CrmDateTime createdonField;

		private CrmNumber importsequencenumberField;

		private Lookup modifiedbyField;

		private CrmDateTime modifiedonField;

		private CrmDateTime overriddencreatedonField;

		private Owner owneridField;

		private Lookup owningbusinessunitField;

		private string sgt_aantal_banenField;

		private Lookup sgt_accommodatieidField;

		private Lookup sgt_begeleideridField;

		private CrmDateTime sgt_datum_en_tijd_aanvangField;

		private CrmDateTime sgt_datum_en_tijd_eindeField;

		private Lookup sgt_groepidField;

		private string sgt_opmerkingField;

		private Lookup sgt_soortevenementidField;

		private Picklist sgt_top_dagField;

		private string sgt_top_groepsevenement1Field;

		private Key sgt_top_groepsevenementidField;

		private Sgt_top_groepsevenementStateInfo statecodeField;

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
		public string sgt_aantal_banen
		{
			get
			{
				return this.sgt_aantal_banenField;
			}
			set
			{
				this.sgt_aantal_banenField = value;
				base.RaisePropertyChanged("sgt_aantal_banen");
			}
		}

		[XmlElement] //[XmlElement(Order=9)]
		public Lookup sgt_accommodatieid
		{
			get
			{
				return this.sgt_accommodatieidField;
			}
			set
			{
				this.sgt_accommodatieidField = value;
				base.RaisePropertyChanged("sgt_accommodatieid");
			}
		}

		[XmlElement] //[XmlElement(Order=10)]
		public Lookup sgt_begeleiderid
		{
			get
			{
				return this.sgt_begeleideridField;
			}
			set
			{
				this.sgt_begeleideridField = value;
				base.RaisePropertyChanged("sgt_begeleiderid");
			}
		}

		[XmlElement] //[XmlElement(Order=11)]
		public CrmDateTime sgt_datum_en_tijd_aanvang
		{
			get
			{
				return this.sgt_datum_en_tijd_aanvangField;
			}
			set
			{
				this.sgt_datum_en_tijd_aanvangField = value;
				base.RaisePropertyChanged("sgt_datum_en_tijd_aanvang");
			}
		}

		[XmlElement] //[XmlElement(Order=12)]
		public CrmDateTime sgt_datum_en_tijd_einde
		{
			get
			{
				return this.sgt_datum_en_tijd_eindeField;
			}
			set
			{
				this.sgt_datum_en_tijd_eindeField = value;
				base.RaisePropertyChanged("sgt_datum_en_tijd_einde");
			}
		}

		[XmlElement] //[XmlElement(Order=13)]
		public Lookup sgt_groepid
		{
			get
			{
				return this.sgt_groepidField;
			}
			set
			{
				this.sgt_groepidField = value;
				base.RaisePropertyChanged("sgt_groepid");
			}
		}

		[XmlElement] //[XmlElement(Order=14)]
		public string sgt_opmerking
		{
			get
			{
				return this.sgt_opmerkingField;
			}
			set
			{
				this.sgt_opmerkingField = value;
				base.RaisePropertyChanged("sgt_opmerking");
			}
		}

		[XmlElement] //[XmlElement(Order=15)]
		public Lookup sgt_soortevenementid
		{
			get
			{
				return this.sgt_soortevenementidField;
			}
			set
			{
				this.sgt_soortevenementidField = value;
				base.RaisePropertyChanged("sgt_soortevenementid");
			}
		}

		[XmlElement] //[XmlElement(Order=16)]
		public Picklist sgt_top_dag
		{
			get
			{
				return this.sgt_top_dagField;
			}
			set
			{
				this.sgt_top_dagField = value;
				base.RaisePropertyChanged("sgt_top_dag");
			}
		}

		[XmlElement("sgt_top_groepsevenement")] //, Order=17)]
		public string sgt_top_groepsevenement1
		{
			get
			{
				return this.sgt_top_groepsevenement1Field;
			}
			set
			{
				this.sgt_top_groepsevenement1Field = value;
				base.RaisePropertyChanged("sgt_top_groepsevenement1");
			}
		}

		[XmlElement] //[XmlElement(Order=18)]
		public Key sgt_top_groepsevenementid
		{
			get
			{
				return this.sgt_top_groepsevenementidField;
			}
			set
			{
				this.sgt_top_groepsevenementidField = value;
				base.RaisePropertyChanged("sgt_top_groepsevenementid");
			}
		}

		[XmlElement] //[XmlElement(Order=19)]
		public Sgt_top_groepsevenementStateInfo statecode
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

		[XmlElement] //[XmlElement(Order=20)]
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

		[XmlElement] //[XmlElement(Order=21)]
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

		[XmlElement] //[XmlElement(Order=22)]
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

		public sgt_top_groepsevenement()
		{
		}
	}
}