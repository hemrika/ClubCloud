using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class sgt_toe_spelersmemo : BusinessEntity
	{
		private Lookup createdbyField;
		private CrmDateTime createdonField;
		private CrmNumber importsequencenumberField;
		private Lookup modifiedbyField;
		private CrmDateTime modifiedonField;
		private Lookup organizationidField;
		private CrmDateTime overriddencreatedonField;
		private CrmDateTime sgt_dd_hoofdtoernooi_aanvangField;
		private CrmDateTime sgt_dd_hoofdtoernooi_lotingField;
		private CrmDateTime sgt_dd_hoofdtoernooi_sluiting_email_inschField;
		private CrmDateTime sgt_dd_hoofdtoernooi_sluiting_inschrijvingField;
		private CrmDateTime sgt_dd_kwalificatie_aanvangField;
		private CrmDateTime sgt_dd_kwalificatie_lotingField;
		private CrmDateTime sgt_dd_kwalificatie_sluiting_email_inschrField;
		private CrmDateTime sgt_dd_kwalificatie_sluiting_inschrijvingField;
		private CrmDateTime sgt_de_hoofdtoernooi_aanvangField;
		private CrmDateTime sgt_de_hoofdtoernooi_lotingField;
		private CrmDateTime sgt_de_hoofdtoernooi_sluiting_email_inschField;
		private CrmDateTime sgt_de_kwalificatie_aanvangField;
		private CrmDateTime sgt_de_kwalificatie_lotingField;
		private CrmDateTime sgt_de_kwalificatie_sluiting_email_inschField;
		private CrmDateTime sgt_de_kwalificatie_sluiting_inschrijvingField;
		private CrmDateTime sgt_hd_hoofdtoernooi_aanvangField;
		private CrmDateTime sgt_hd_hoofdtoernooi_lotingField;
		private CrmDateTime sgt_hd_hoofdtoernooi_sluiting_email_inschField;
		private CrmDecimal sgt_hd_hoofdtoernooi_sluiting_inschrijvingField;
		private CrmDateTime sgt_hd_ht_sluiting_inschrijvingField;
		private CrmDateTime sgt_hd_kwalificatie_aanvangField;
		private CrmDateTime sgt_hd_kwalificatie_lotingField;
		private CrmDateTime sgt_hd_kwalificatie_sluiting_email_inschField;
		private CrmDateTime sgt_hd_kwalificatie_sluiting_inschrijvingField;
		private CrmDateTime sgt_he_hoofdtoernooi_aanvangField;
		private CrmDateTime sgt_he_hoofdtoernooi_lotingField;
		private CrmDateTime sgt_he_hoofdtoernooi_sluiting_email_inschField;
		private CrmDateTime sgt_he_kwalificatie_aanvangField;
		private CrmDateTime sgt_he_kwalificatie_lotingField;
		private CrmDateTime sgt_he_kwalificatie_sluiting_email_inschField;
		private CrmDateTime sgt_he_kwalificatie_sluiting_inschrijvingField;
		private string sgt_inschrijven_dubbel_per_emailField;
		private string sgt_inschrijven_dubbel_per_faxField;
		private string sgt_inschrijven_dubbel_via_internetField;
		private CrmBoolean sgt_kledingreclamecode_van_toepassingField;
		private string sgt_opmerking_1Field;
		private string sgt_opmerking_2Field;
		private Lookup sgt_soort_balidField;
		private string sgt_toe_nameField;
		private Key sgt_toe_spelersmemoidField;
		private Lookup sgt_toernooiidField;
		private Sgt_toe_spelersmemoStateInfo statecodeField;
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
		public Lookup organizationid
		{
			get
			{
				return this.organizationidField;
			}
			set
			{
				this.organizationidField = value;
				base.RaisePropertyChanged("organizationid");
			}
		}
		[XmlElement(Order = 6)]
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
		[XmlElement(Order = 7)]
		public CrmDateTime sgt_dd_hoofdtoernooi_aanvang
		{
			get
			{
				return this.sgt_dd_hoofdtoernooi_aanvangField;
			}
			set
			{
				this.sgt_dd_hoofdtoernooi_aanvangField = value;
				base.RaisePropertyChanged("sgt_dd_hoofdtoernooi_aanvang");
			}
		}
		[XmlElement(Order = 8)]
		public CrmDateTime sgt_dd_hoofdtoernooi_loting
		{
			get
			{
				return this.sgt_dd_hoofdtoernooi_lotingField;
			}
			set
			{
				this.sgt_dd_hoofdtoernooi_lotingField = value;
				base.RaisePropertyChanged("sgt_dd_hoofdtoernooi_loting");
			}
		}
		[XmlElement(Order = 9)]
		public CrmDateTime sgt_dd_hoofdtoernooi_sluiting_email_insch
		{
			get
			{
				return this.sgt_dd_hoofdtoernooi_sluiting_email_inschField;
			}
			set
			{
				this.sgt_dd_hoofdtoernooi_sluiting_email_inschField = value;
				base.RaisePropertyChanged("sgt_dd_hoofdtoernooi_sluiting_email_insch");
			}
		}
		[XmlElement(Order = 10)]
		public CrmDateTime sgt_dd_hoofdtoernooi_sluiting_inschrijving
		{
			get
			{
				return this.sgt_dd_hoofdtoernooi_sluiting_inschrijvingField;
			}
			set
			{
				this.sgt_dd_hoofdtoernooi_sluiting_inschrijvingField = value;
				base.RaisePropertyChanged("sgt_dd_hoofdtoernooi_sluiting_inschrijving");
			}
		}
		[XmlElement(Order = 11)]
		public CrmDateTime sgt_dd_kwalificatie_aanvang
		{
			get
			{
				return this.sgt_dd_kwalificatie_aanvangField;
			}
			set
			{
				this.sgt_dd_kwalificatie_aanvangField = value;
				base.RaisePropertyChanged("sgt_dd_kwalificatie_aanvang");
			}
		}
		[XmlElement(Order = 12)]
		public CrmDateTime sgt_dd_kwalificatie_loting
		{
			get
			{
				return this.sgt_dd_kwalificatie_lotingField;
			}
			set
			{
				this.sgt_dd_kwalificatie_lotingField = value;
				base.RaisePropertyChanged("sgt_dd_kwalificatie_loting");
			}
		}
		[XmlElement(Order = 13)]
		public CrmDateTime sgt_dd_kwalificatie_sluiting_email_inschr
		{
			get
			{
				return this.sgt_dd_kwalificatie_sluiting_email_inschrField;
			}
			set
			{
				this.sgt_dd_kwalificatie_sluiting_email_inschrField = value;
				base.RaisePropertyChanged("sgt_dd_kwalificatie_sluiting_email_inschr");
			}
		}
		[XmlElement(Order = 14)]
		public CrmDateTime sgt_dd_kwalificatie_sluiting_inschrijving
		{
			get
			{
				return this.sgt_dd_kwalificatie_sluiting_inschrijvingField;
			}
			set
			{
				this.sgt_dd_kwalificatie_sluiting_inschrijvingField = value;
				base.RaisePropertyChanged("sgt_dd_kwalificatie_sluiting_inschrijving");
			}
		}
		[XmlElement(Order = 15)]
		public CrmDateTime sgt_de_hoofdtoernooi_aanvang
		{
			get
			{
				return this.sgt_de_hoofdtoernooi_aanvangField;
			}
			set
			{
				this.sgt_de_hoofdtoernooi_aanvangField = value;
				base.RaisePropertyChanged("sgt_de_hoofdtoernooi_aanvang");
			}
		}
		[XmlElement(Order = 16)]
		public CrmDateTime sgt_de_hoofdtoernooi_loting
		{
			get
			{
				return this.sgt_de_hoofdtoernooi_lotingField;
			}
			set
			{
				this.sgt_de_hoofdtoernooi_lotingField = value;
				base.RaisePropertyChanged("sgt_de_hoofdtoernooi_loting");
			}
		}
		[XmlElement(Order = 17)]
		public CrmDateTime sgt_de_hoofdtoernooi_sluiting_email_insch
		{
			get
			{
				return this.sgt_de_hoofdtoernooi_sluiting_email_inschField;
			}
			set
			{
				this.sgt_de_hoofdtoernooi_sluiting_email_inschField = value;
				base.RaisePropertyChanged("sgt_de_hoofdtoernooi_sluiting_email_insch");
			}
		}
		[XmlElement(Order = 18)]
		public CrmDateTime sgt_de_kwalificatie_aanvang
		{
			get
			{
				return this.sgt_de_kwalificatie_aanvangField;
			}
			set
			{
				this.sgt_de_kwalificatie_aanvangField = value;
				base.RaisePropertyChanged("sgt_de_kwalificatie_aanvang");
			}
		}
		[XmlElement(Order = 19)]
		public CrmDateTime sgt_de_kwalificatie_loting
		{
			get
			{
				return this.sgt_de_kwalificatie_lotingField;
			}
			set
			{
				this.sgt_de_kwalificatie_lotingField = value;
				base.RaisePropertyChanged("sgt_de_kwalificatie_loting");
			}
		}
		[XmlElement(Order = 20)]
		public CrmDateTime sgt_de_kwalificatie_sluiting_email_insch
		{
			get
			{
				return this.sgt_de_kwalificatie_sluiting_email_inschField;
			}
			set
			{
				this.sgt_de_kwalificatie_sluiting_email_inschField = value;
				base.RaisePropertyChanged("sgt_de_kwalificatie_sluiting_email_insch");
			}
		}
		[XmlElement(Order = 21)]
		public CrmDateTime sgt_de_kwalificatie_sluiting_inschrijving
		{
			get
			{
				return this.sgt_de_kwalificatie_sluiting_inschrijvingField;
			}
			set
			{
				this.sgt_de_kwalificatie_sluiting_inschrijvingField = value;
				base.RaisePropertyChanged("sgt_de_kwalificatie_sluiting_inschrijving");
			}
		}
		[XmlElement(Order = 22)]
		public CrmDateTime sgt_hd_hoofdtoernooi_aanvang
		{
			get
			{
				return this.sgt_hd_hoofdtoernooi_aanvangField;
			}
			set
			{
				this.sgt_hd_hoofdtoernooi_aanvangField = value;
				base.RaisePropertyChanged("sgt_hd_hoofdtoernooi_aanvang");
			}
		}
		[XmlElement(Order = 23)]
		public CrmDateTime sgt_hd_hoofdtoernooi_loting
		{
			get
			{
				return this.sgt_hd_hoofdtoernooi_lotingField;
			}
			set
			{
				this.sgt_hd_hoofdtoernooi_lotingField = value;
				base.RaisePropertyChanged("sgt_hd_hoofdtoernooi_loting");
			}
		}
		[XmlElement(Order = 24)]
		public CrmDateTime sgt_hd_hoofdtoernooi_sluiting_email_insch
		{
			get
			{
				return this.sgt_hd_hoofdtoernooi_sluiting_email_inschField;
			}
			set
			{
				this.sgt_hd_hoofdtoernooi_sluiting_email_inschField = value;
				base.RaisePropertyChanged("sgt_hd_hoofdtoernooi_sluiting_email_insch");
			}
		}
		[XmlElement(Order = 25)]
		public CrmDecimal sgt_hd_hoofdtoernooi_sluiting_inschrijving
		{
			get
			{
				return this.sgt_hd_hoofdtoernooi_sluiting_inschrijvingField;
			}
			set
			{
				this.sgt_hd_hoofdtoernooi_sluiting_inschrijvingField = value;
				base.RaisePropertyChanged("sgt_hd_hoofdtoernooi_sluiting_inschrijving");
			}
		}
		[XmlElement(Order = 26)]
		public CrmDateTime sgt_hd_ht_sluiting_inschrijving
		{
			get
			{
				return this.sgt_hd_ht_sluiting_inschrijvingField;
			}
			set
			{
				this.sgt_hd_ht_sluiting_inschrijvingField = value;
				base.RaisePropertyChanged("sgt_hd_ht_sluiting_inschrijving");
			}
		}
		[XmlElement(Order = 27)]
		public CrmDateTime sgt_hd_kwalificatie_aanvang
		{
			get
			{
				return this.sgt_hd_kwalificatie_aanvangField;
			}
			set
			{
				this.sgt_hd_kwalificatie_aanvangField = value;
				base.RaisePropertyChanged("sgt_hd_kwalificatie_aanvang");
			}
		}
		[XmlElement(Order = 28)]
		public CrmDateTime sgt_hd_kwalificatie_loting
		{
			get
			{
				return this.sgt_hd_kwalificatie_lotingField;
			}
			set
			{
				this.sgt_hd_kwalificatie_lotingField = value;
				base.RaisePropertyChanged("sgt_hd_kwalificatie_loting");
			}
		}
		[XmlElement(Order = 29)]
		public CrmDateTime sgt_hd_kwalificatie_sluiting_email_insch
		{
			get
			{
				return this.sgt_hd_kwalificatie_sluiting_email_inschField;
			}
			set
			{
				this.sgt_hd_kwalificatie_sluiting_email_inschField = value;
				base.RaisePropertyChanged("sgt_hd_kwalificatie_sluiting_email_insch");
			}
		}
		[XmlElement(Order = 30)]
		public CrmDateTime sgt_hd_kwalificatie_sluiting_inschrijving
		{
			get
			{
				return this.sgt_hd_kwalificatie_sluiting_inschrijvingField;
			}
			set
			{
				this.sgt_hd_kwalificatie_sluiting_inschrijvingField = value;
				base.RaisePropertyChanged("sgt_hd_kwalificatie_sluiting_inschrijving");
			}
		}
		[XmlElement(Order = 31)]
		public CrmDateTime sgt_he_hoofdtoernooi_aanvang
		{
			get
			{
				return this.sgt_he_hoofdtoernooi_aanvangField;
			}
			set
			{
				this.sgt_he_hoofdtoernooi_aanvangField = value;
				base.RaisePropertyChanged("sgt_he_hoofdtoernooi_aanvang");
			}
		}
		[XmlElement(Order = 32)]
		public CrmDateTime sgt_he_hoofdtoernooi_loting
		{
			get
			{
				return this.sgt_he_hoofdtoernooi_lotingField;
			}
			set
			{
				this.sgt_he_hoofdtoernooi_lotingField = value;
				base.RaisePropertyChanged("sgt_he_hoofdtoernooi_loting");
			}
		}
		[XmlElement(Order = 33)]
		public CrmDateTime sgt_he_hoofdtoernooi_sluiting_email_insch
		{
			get
			{
				return this.sgt_he_hoofdtoernooi_sluiting_email_inschField;
			}
			set
			{
				this.sgt_he_hoofdtoernooi_sluiting_email_inschField = value;
				base.RaisePropertyChanged("sgt_he_hoofdtoernooi_sluiting_email_insch");
			}
		}
		[XmlElement(Order = 34)]
		public CrmDateTime sgt_he_kwalificatie_aanvang
		{
			get
			{
				return this.sgt_he_kwalificatie_aanvangField;
			}
			set
			{
				this.sgt_he_kwalificatie_aanvangField = value;
				base.RaisePropertyChanged("sgt_he_kwalificatie_aanvang");
			}
		}
		[XmlElement(Order = 35)]
		public CrmDateTime sgt_he_kwalificatie_loting
		{
			get
			{
				return this.sgt_he_kwalificatie_lotingField;
			}
			set
			{
				this.sgt_he_kwalificatie_lotingField = value;
				base.RaisePropertyChanged("sgt_he_kwalificatie_loting");
			}
		}
		[XmlElement(Order = 36)]
		public CrmDateTime sgt_he_kwalificatie_sluiting_email_insch
		{
			get
			{
				return this.sgt_he_kwalificatie_sluiting_email_inschField;
			}
			set
			{
				this.sgt_he_kwalificatie_sluiting_email_inschField = value;
				base.RaisePropertyChanged("sgt_he_kwalificatie_sluiting_email_insch");
			}
		}
		[XmlElement(Order = 37)]
		public CrmDateTime sgt_he_kwalificatie_sluiting_inschrijving
		{
			get
			{
				return this.sgt_he_kwalificatie_sluiting_inschrijvingField;
			}
			set
			{
				this.sgt_he_kwalificatie_sluiting_inschrijvingField = value;
				base.RaisePropertyChanged("sgt_he_kwalificatie_sluiting_inschrijving");
			}
		}
		[XmlElement(Order = 38)]
		public string sgt_inschrijven_dubbel_per_email
		{
			get
			{
				return this.sgt_inschrijven_dubbel_per_emailField;
			}
			set
			{
				this.sgt_inschrijven_dubbel_per_emailField = value;
				base.RaisePropertyChanged("sgt_inschrijven_dubbel_per_email");
			}
		}
		[XmlElement(Order = 39)]
		public string sgt_inschrijven_dubbel_per_fax
		{
			get
			{
				return this.sgt_inschrijven_dubbel_per_faxField;
			}
			set
			{
				this.sgt_inschrijven_dubbel_per_faxField = value;
				base.RaisePropertyChanged("sgt_inschrijven_dubbel_per_fax");
			}
		}
		[XmlElement(Order = 40)]
		public string sgt_inschrijven_dubbel_via_internet
		{
			get
			{
				return this.sgt_inschrijven_dubbel_via_internetField;
			}
			set
			{
				this.sgt_inschrijven_dubbel_via_internetField = value;
				base.RaisePropertyChanged("sgt_inschrijven_dubbel_via_internet");
			}
		}
		[XmlElement(Order = 41)]
		public CrmBoolean sgt_kledingreclamecode_van_toepassing
		{
			get
			{
				return this.sgt_kledingreclamecode_van_toepassingField;
			}
			set
			{
				this.sgt_kledingreclamecode_van_toepassingField = value;
				base.RaisePropertyChanged("sgt_kledingreclamecode_van_toepassing");
			}
		}
		[XmlElement(Order = 42)]
		public string sgt_opmerking_1
		{
			get
			{
				return this.sgt_opmerking_1Field;
			}
			set
			{
				this.sgt_opmerking_1Field = value;
				base.RaisePropertyChanged("sgt_opmerking_1");
			}
		}
		[XmlElement(Order = 43)]
		public string sgt_opmerking_2
		{
			get
			{
				return this.sgt_opmerking_2Field;
			}
			set
			{
				this.sgt_opmerking_2Field = value;
				base.RaisePropertyChanged("sgt_opmerking_2");
			}
		}
		[XmlElement(Order = 44)]
		public Lookup sgt_soort_balid
		{
			get
			{
				return this.sgt_soort_balidField;
			}
			set
			{
				this.sgt_soort_balidField = value;
				base.RaisePropertyChanged("sgt_soort_balid");
			}
		}
		[XmlElement(Order = 45)]
		public string sgt_toe_name
		{
			get
			{
				return this.sgt_toe_nameField;
			}
			set
			{
				this.sgt_toe_nameField = value;
				base.RaisePropertyChanged("sgt_toe_name");
			}
		}
		[XmlElement(Order = 46)]
		public Key sgt_toe_spelersmemoid
		{
			get
			{
				return this.sgt_toe_spelersmemoidField;
			}
			set
			{
				this.sgt_toe_spelersmemoidField = value;
				base.RaisePropertyChanged("sgt_toe_spelersmemoid");
			}
		}
		[XmlElement(Order = 47)]
		public Lookup sgt_toernooiid
		{
			get
			{
				return this.sgt_toernooiidField;
			}
			set
			{
				this.sgt_toernooiidField = value;
				base.RaisePropertyChanged("sgt_toernooiid");
			}
		}
		[XmlElement(Order = 48)]
		public Sgt_toe_spelersmemoStateInfo statecode
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
		[XmlElement(Order = 49)]
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
		[XmlElement(Order = 50)]
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
		[XmlElement(Order = 51)]
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
