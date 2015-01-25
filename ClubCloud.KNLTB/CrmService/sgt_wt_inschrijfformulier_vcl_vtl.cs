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
	public class sgt_wt_inschrijfformulier_vcl_vtl : BusinessEntity
	{
		private Lookup createdbyField;

		private CrmDateTime createdonField;

		private CrmNumber importsequencenumberField;

		private Lookup modifiedbyField;

		private CrmDateTime modifiedonField;

		private CrmDateTime overriddencreatedonField;

		private Owner owneridField;

		private Lookup owningbusinessunitField;

		private string sgt_bondsnummer1Field;

		private string sgt_bondsnummer2Field;

		private string sgt_bondsnummer3Field;

		private Lookup sgt_cursist1idField;

		private Lookup sgt_cursist2idField;

		private Lookup sgt_cursist3idField;

		private string sgt_emailadres1Field;

		private string sgt_emailadres2Field;

		private string sgt_emailadres3Field;

		private Lookup sgt_opleidingidField;

		private Picklist sgt_statusformulierField;

		private Lookup sgt_verenigingidField;

		private Lookup sgt_voorkeur11idField;

		private Lookup sgt_voorkeur12idField;

		private Lookup sgt_voorkeur13idField;

		private Lookup sgt_voorkeur21idField;

		private Lookup sgt_voorkeur22idField;

		private Lookup sgt_voorkeur23idField;

		private Lookup sgt_voorkeur31idField;

		private Lookup sgt_voorkeur32idField;

		private Lookup sgt_voorkeur33idField;

		private string sgt_wt_inschrijfformulier_vcl_vtl1Field;

		private Key sgt_wt_inschrijfformulier_vcl_vtlidField;

		private Sgt_wt_inschrijfformulier_vcl_vtlStateInfo statecodeField;

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
		public string sgt_bondsnummer1
		{
			get
			{
				return this.sgt_bondsnummer1Field;
			}
			set
			{
				this.sgt_bondsnummer1Field = value;
				base.RaisePropertyChanged("sgt_bondsnummer1");
			}
		}

		[XmlElement] //[XmlElement(Order=9)]
		public string sgt_bondsnummer2
		{
			get
			{
				return this.sgt_bondsnummer2Field;
			}
			set
			{
				this.sgt_bondsnummer2Field = value;
				base.RaisePropertyChanged("sgt_bondsnummer2");
			}
		}

		[XmlElement] //[XmlElement(Order=10)]
		public string sgt_bondsnummer3
		{
			get
			{
				return this.sgt_bondsnummer3Field;
			}
			set
			{
				this.sgt_bondsnummer3Field = value;
				base.RaisePropertyChanged("sgt_bondsnummer3");
			}
		}

		[XmlElement] //[XmlElement(Order=11)]
		public Lookup sgt_cursist1id
		{
			get
			{
				return this.sgt_cursist1idField;
			}
			set
			{
				this.sgt_cursist1idField = value;
				base.RaisePropertyChanged("sgt_cursist1id");
			}
		}

		[XmlElement] //[XmlElement(Order=12)]
		public Lookup sgt_cursist2id
		{
			get
			{
				return this.sgt_cursist2idField;
			}
			set
			{
				this.sgt_cursist2idField = value;
				base.RaisePropertyChanged("sgt_cursist2id");
			}
		}

		[XmlElement] //[XmlElement(Order=13)]
		public Lookup sgt_cursist3id
		{
			get
			{
				return this.sgt_cursist3idField;
			}
			set
			{
				this.sgt_cursist3idField = value;
				base.RaisePropertyChanged("sgt_cursist3id");
			}
		}

		[XmlElement] //[XmlElement(Order=14)]
		public string sgt_emailadres1
		{
			get
			{
				return this.sgt_emailadres1Field;
			}
			set
			{
				this.sgt_emailadres1Field = value;
				base.RaisePropertyChanged("sgt_emailadres1");
			}
		}

		[XmlElement] //[XmlElement(Order=15)]
		public string sgt_emailadres2
		{
			get
			{
				return this.sgt_emailadres2Field;
			}
			set
			{
				this.sgt_emailadres2Field = value;
				base.RaisePropertyChanged("sgt_emailadres2");
			}
		}

		[XmlElement] //[XmlElement(Order=16)]
		public string sgt_emailadres3
		{
			get
			{
				return this.sgt_emailadres3Field;
			}
			set
			{
				this.sgt_emailadres3Field = value;
				base.RaisePropertyChanged("sgt_emailadres3");
			}
		}

		[XmlElement] //[XmlElement(Order=17)]
		public Lookup sgt_opleidingid
		{
			get
			{
				return this.sgt_opleidingidField;
			}
			set
			{
				this.sgt_opleidingidField = value;
				base.RaisePropertyChanged("sgt_opleidingid");
			}
		}

		[XmlElement] //[XmlElement(Order=18)]
		public Picklist sgt_statusformulier
		{
			get
			{
				return this.sgt_statusformulierField;
			}
			set
			{
				this.sgt_statusformulierField = value;
				base.RaisePropertyChanged("sgt_statusformulier");
			}
		}

		[XmlElement] //[XmlElement(Order=19)]
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

		[XmlElement] //[XmlElement(Order=20)]
		public Lookup sgt_voorkeur11id
		{
			get
			{
				return this.sgt_voorkeur11idField;
			}
			set
			{
				this.sgt_voorkeur11idField = value;
				base.RaisePropertyChanged("sgt_voorkeur11id");
			}
		}

		[XmlElement] //[XmlElement(Order=21)]
		public Lookup sgt_voorkeur12id
		{
			get
			{
				return this.sgt_voorkeur12idField;
			}
			set
			{
				this.sgt_voorkeur12idField = value;
				base.RaisePropertyChanged("sgt_voorkeur12id");
			}
		}

		[XmlElement] //[XmlElement(Order=22)]
		public Lookup sgt_voorkeur13id
		{
			get
			{
				return this.sgt_voorkeur13idField;
			}
			set
			{
				this.sgt_voorkeur13idField = value;
				base.RaisePropertyChanged("sgt_voorkeur13id");
			}
		}

		[XmlElement] //[XmlElement(Order=23)]
		public Lookup sgt_voorkeur21id
		{
			get
			{
				return this.sgt_voorkeur21idField;
			}
			set
			{
				this.sgt_voorkeur21idField = value;
				base.RaisePropertyChanged("sgt_voorkeur21id");
			}
		}

		[XmlElement] //[XmlElement(Order=24)]
		public Lookup sgt_voorkeur22id
		{
			get
			{
				return this.sgt_voorkeur22idField;
			}
			set
			{
				this.sgt_voorkeur22idField = value;
				base.RaisePropertyChanged("sgt_voorkeur22id");
			}
		}

		[XmlElement] //[XmlElement(Order=25)]
		public Lookup sgt_voorkeur23id
		{
			get
			{
				return this.sgt_voorkeur23idField;
			}
			set
			{
				this.sgt_voorkeur23idField = value;
				base.RaisePropertyChanged("sgt_voorkeur23id");
			}
		}

		[XmlElement] //[XmlElement(Order=26)]
		public Lookup sgt_voorkeur31id
		{
			get
			{
				return this.sgt_voorkeur31idField;
			}
			set
			{
				this.sgt_voorkeur31idField = value;
				base.RaisePropertyChanged("sgt_voorkeur31id");
			}
		}

		[XmlElement] //[XmlElement(Order=27)]
		public Lookup sgt_voorkeur32id
		{
			get
			{
				return this.sgt_voorkeur32idField;
			}
			set
			{
				this.sgt_voorkeur32idField = value;
				base.RaisePropertyChanged("sgt_voorkeur32id");
			}
		}

		[XmlElement] //[XmlElement(Order=28)]
		public Lookup sgt_voorkeur33id
		{
			get
			{
				return this.sgt_voorkeur33idField;
			}
			set
			{
				this.sgt_voorkeur33idField = value;
				base.RaisePropertyChanged("sgt_voorkeur33id");
			}
		}

		[XmlElement("sgt_wt_inschrijfformulier_vcl_vtl")] //, Order=29)]
		public string sgt_wt_inschrijfformulier_vcl_vtl1
		{
			get
			{
				return this.sgt_wt_inschrijfformulier_vcl_vtl1Field;
			}
			set
			{
				this.sgt_wt_inschrijfformulier_vcl_vtl1Field = value;
				base.RaisePropertyChanged("sgt_wt_inschrijfformulier_vcl_vtl1");
			}
		}

		[XmlElement] //[XmlElement(Order=30)]
		public Key sgt_wt_inschrijfformulier_vcl_vtlid
		{
			get
			{
				return this.sgt_wt_inschrijfformulier_vcl_vtlidField;
			}
			set
			{
				this.sgt_wt_inschrijfformulier_vcl_vtlidField = value;
				base.RaisePropertyChanged("sgt_wt_inschrijfformulier_vcl_vtlid");
			}
		}

		[XmlElement] //[XmlElement(Order=31)]
		public Sgt_wt_inschrijfformulier_vcl_vtlStateInfo statecode
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

		[XmlElement] //[XmlElement(Order=32)]
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

		[XmlElement] //[XmlElement(Order=33)]
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

		[XmlElement] //[XmlElement(Order=34)]
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

		public sgt_wt_inschrijfformulier_vcl_vtl()
		{
		}
	}
}