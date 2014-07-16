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
	public class sgt_alg_ledenpas_lid : BusinessEntity
	{
		private Lookup createdbyField;

		private CrmDateTime createdonField;

		private CrmNumber importsequencenumberField;

		private Lookup modifiedbyField;

		private CrmDateTime modifiedonField;

		private CrmDateTime overriddencreatedonField;

		private Owner owneridField;

		private Lookup owningbusinessunitField;

		private CrmBoolean sgt_aangemaakt_door_verrijkingField;

		private Key sgt_alg_ledenpas_lididField;

		private string sgt_alg_naamField;

		private Lookup sgt_ledenpas_logboek_idField;

		private Lookup sgt_ledenpas_vereniging_idField;

		private Lookup sgt_lid_idField;

		private Lookup sgt_lidmaatschap_idField;

		private CrmBoolean sgt_nieuwe_pas_facturerenField;

		private string sgt_retour_foutmeldingField;

		private Lookup sgt_vereniging_idField;

		private Sgt_alg_ledenpas_lidStateInfo statecodeField;

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
		public CrmBoolean sgt_aangemaakt_door_verrijking
		{
			get
			{
				return this.sgt_aangemaakt_door_verrijkingField;
			}
			set
			{
				this.sgt_aangemaakt_door_verrijkingField = value;
				base.RaisePropertyChanged("sgt_aangemaakt_door_verrijking");
			}
		}

		[XmlElement] //[XmlElement(Order=9)]
		public Key sgt_alg_ledenpas_lidid
		{
			get
			{
				return this.sgt_alg_ledenpas_lididField;
			}
			set
			{
				this.sgt_alg_ledenpas_lididField = value;
				base.RaisePropertyChanged("sgt_alg_ledenpas_lidid");
			}
		}

		[XmlElement] //[XmlElement(Order=10)]
		public string sgt_alg_naam
		{
			get
			{
				return this.sgt_alg_naamField;
			}
			set
			{
				this.sgt_alg_naamField = value;
				base.RaisePropertyChanged("sgt_alg_naam");
			}
		}

		[XmlElement] //[XmlElement(Order=11)]
		public Lookup sgt_ledenpas_logboek_id
		{
			get
			{
				return this.sgt_ledenpas_logboek_idField;
			}
			set
			{
				this.sgt_ledenpas_logboek_idField = value;
				base.RaisePropertyChanged("sgt_ledenpas_logboek_id");
			}
		}

		[XmlElement] //[XmlElement(Order=12)]
		public Lookup sgt_ledenpas_vereniging_id
		{
			get
			{
				return this.sgt_ledenpas_vereniging_idField;
			}
			set
			{
				this.sgt_ledenpas_vereniging_idField = value;
				base.RaisePropertyChanged("sgt_ledenpas_vereniging_id");
			}
		}

		[XmlElement] //[XmlElement(Order=13)]
		public Lookup sgt_lid_id
		{
			get
			{
				return this.sgt_lid_idField;
			}
			set
			{
				this.sgt_lid_idField = value;
				base.RaisePropertyChanged("sgt_lid_id");
			}
		}

		[XmlElement] //[XmlElement(Order=14)]
		public Lookup sgt_lidmaatschap_id
		{
			get
			{
				return this.sgt_lidmaatschap_idField;
			}
			set
			{
				this.sgt_lidmaatschap_idField = value;
				base.RaisePropertyChanged("sgt_lidmaatschap_id");
			}
		}

		[XmlElement] //[XmlElement(Order=15)]
		public CrmBoolean sgt_nieuwe_pas_factureren
		{
			get
			{
				return this.sgt_nieuwe_pas_facturerenField;
			}
			set
			{
				this.sgt_nieuwe_pas_facturerenField = value;
				base.RaisePropertyChanged("sgt_nieuwe_pas_factureren");
			}
		}

		[XmlElement] //[XmlElement(Order=16)]
		public string sgt_retour_foutmelding
		{
			get
			{
				return this.sgt_retour_foutmeldingField;
			}
			set
			{
				this.sgt_retour_foutmeldingField = value;
				base.RaisePropertyChanged("sgt_retour_foutmelding");
			}
		}

		[XmlElement] //[XmlElement(Order=17)]
		public Lookup sgt_vereniging_id
		{
			get
			{
				return this.sgt_vereniging_idField;
			}
			set
			{
				this.sgt_vereniging_idField = value;
				base.RaisePropertyChanged("sgt_vereniging_id");
			}
		}

		[XmlElement] //[XmlElement(Order=18)]
		public Sgt_alg_ledenpas_lidStateInfo statecode
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

		public sgt_alg_ledenpas_lid()
		{
		}
	}
}