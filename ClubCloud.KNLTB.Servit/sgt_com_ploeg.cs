using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class sgt_com_ploeg : BusinessEntity
	{
		private Lookup createdbyField;
		private CrmDateTime createdonField;
		private CrmNumber importsequencenumberField;
		private Lookup modifiedbyField;
		private CrmDateTime modifiedonField;
		private CrmDateTime overriddencreatedonField;
		private Owner owneridField;
		private Lookup owningbusinessunitField;
		private string sgt_aangepaste_ploegnaamField;
		private CrmDateTime sgt_aanmelddatumField;
		private Key sgt_com_ploegidField;
		private string sgt_com_ploegnaamField;
		private Lookup sgt_competitie_idField;
		private Lookup sgt_competitieinschrijvingidField;
		private Lookup sgt_klassegroep_idField;
		private Lookup sgt_piramideidField;
		private CrmBoolean sgt_ploegen_op_zelfde_dag_en_dagdeelField;
		private Lookup sgt_ploegidField;
		private CrmNumber sgt_ploegnummerField;
		private string sgt_promotie_toelichtingField;
		private CrmBoolean sgt_spelen_op_1_locatie_mogelijkField;
		private Lookup sgt_vereniging_idField;
		private Lookup sgt_verzoekklasse_idField;
		private Sgt_com_ploegStateInfo statecodeField;
		private Status statuscodeField;
		private CrmNumber timezoneruleversionnumberField;
		private CrmNumber utcconversiontimezonecodeField;
		[XmlElement(Order = 0)]
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
		[XmlElement(Order = 1)]
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
		[XmlElement(Order = 2)]
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
		[XmlElement(Order = 3)]
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
		[XmlElement(Order = 4)]
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
		[XmlElement(Order = 5)]
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
		[XmlElement(Order = 6)]
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
		[XmlElement(Order = 7)]
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
		[XmlElement(Order = 8)]
		public string sgt_aangepaste_ploegnaam
		{
			get
			{
				return this.sgt_aangepaste_ploegnaamField;
			}
			set
			{
				this.sgt_aangepaste_ploegnaamField = value;
				base.RaisePropertyChanged("sgt_aangepaste_ploegnaam");
			}
		}
		[XmlElement(Order = 9)]
		public CrmDateTime sgt_aanmelddatum
		{
			get
			{
				return this.sgt_aanmelddatumField;
			}
			set
			{
				this.sgt_aanmelddatumField = value;
				base.RaisePropertyChanged("sgt_aanmelddatum");
			}
		}
		[XmlElement(Order = 10)]
		public Key sgt_com_ploegid
		{
			get
			{
				return this.sgt_com_ploegidField;
			}
			set
			{
				this.sgt_com_ploegidField = value;
				base.RaisePropertyChanged("sgt_com_ploegid");
			}
		}
		[XmlElement(Order = 11)]
		public string sgt_com_ploegnaam
		{
			get
			{
				return this.sgt_com_ploegnaamField;
			}
			set
			{
				this.sgt_com_ploegnaamField = value;
				base.RaisePropertyChanged("sgt_com_ploegnaam");
			}
		}
		[XmlElement(Order = 12)]
		public Lookup sgt_competitie_id
		{
			get
			{
				return this.sgt_competitie_idField;
			}
			set
			{
				this.sgt_competitie_idField = value;
				base.RaisePropertyChanged("sgt_competitie_id");
			}
		}
		[XmlElement(Order = 13)]
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
		[XmlElement(Order = 14)]
		public Lookup sgt_klassegroep_id
		{
			get
			{
				return this.sgt_klassegroep_idField;
			}
			set
			{
				this.sgt_klassegroep_idField = value;
				base.RaisePropertyChanged("sgt_klassegroep_id");
			}
		}
		[XmlElement(Order = 15)]
		public Lookup sgt_piramideid
		{
			get
			{
				return this.sgt_piramideidField;
			}
			set
			{
				this.sgt_piramideidField = value;
				base.RaisePropertyChanged("sgt_piramideid");
			}
		}
		[XmlElement(Order = 16)]
		public CrmBoolean sgt_ploegen_op_zelfde_dag_en_dagdeel
		{
			get
			{
				return this.sgt_ploegen_op_zelfde_dag_en_dagdeelField;
			}
			set
			{
				this.sgt_ploegen_op_zelfde_dag_en_dagdeelField = value;
				base.RaisePropertyChanged("sgt_ploegen_op_zelfde_dag_en_dagdeel");
			}
		}
		[XmlElement(Order = 17)]
		public Lookup sgt_ploegid
		{
			get
			{
				return this.sgt_ploegidField;
			}
			set
			{
				this.sgt_ploegidField = value;
				base.RaisePropertyChanged("sgt_ploegid");
			}
		}
		[XmlElement(Order = 18)]
		public CrmNumber sgt_ploegnummer
		{
			get
			{
				return this.sgt_ploegnummerField;
			}
			set
			{
				this.sgt_ploegnummerField = value;
				base.RaisePropertyChanged("sgt_ploegnummer");
			}
		}
		[XmlElement(Order = 19)]
		public string sgt_promotie_toelichting
		{
			get
			{
				return this.sgt_promotie_toelichtingField;
			}
			set
			{
				this.sgt_promotie_toelichtingField = value;
				base.RaisePropertyChanged("sgt_promotie_toelichting");
			}
		}
		[XmlElement(Order = 20)]
		public CrmBoolean sgt_spelen_op_1_locatie_mogelijk
		{
			get
			{
				return this.sgt_spelen_op_1_locatie_mogelijkField;
			}
			set
			{
				this.sgt_spelen_op_1_locatie_mogelijkField = value;
				base.RaisePropertyChanged("sgt_spelen_op_1_locatie_mogelijk");
			}
		}
		[XmlElement(Order = 21)]
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
		[XmlElement(Order = 22)]
		public Lookup sgt_verzoekklasse_id
		{
			get
			{
				return this.sgt_verzoekklasse_idField;
			}
			set
			{
				this.sgt_verzoekklasse_idField = value;
				base.RaisePropertyChanged("sgt_verzoekklasse_id");
			}
		}
		[XmlElement(Order = 23)]
		public Sgt_com_ploegStateInfo statecode
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
		[XmlElement(Order = 24)]
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
		[XmlElement(Order = 25)]
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
		[XmlElement(Order = 26)]
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
	}
}
