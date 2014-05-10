using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
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
		public Lookup createdby
		{
			get
			{
				return this.createdbyField;
			}
			set
			{
				this.createdbyField = value;
			}
		}
		public CrmDateTime createdon
		{
			get
			{
				return this.createdonField;
			}
			set
			{
				this.createdonField = value;
			}
		}
		public CrmNumber importsequencenumber
		{
			get
			{
				return this.importsequencenumberField;
			}
			set
			{
				this.importsequencenumberField = value;
			}
		}
		public Lookup modifiedby
		{
			get
			{
				return this.modifiedbyField;
			}
			set
			{
				this.modifiedbyField = value;
			}
		}
		public CrmDateTime modifiedon
		{
			get
			{
				return this.modifiedonField;
			}
			set
			{
				this.modifiedonField = value;
			}
		}
		public Lookup organizationid
		{
			get
			{
				return this.organizationidField;
			}
			set
			{
				this.organizationidField = value;
			}
		}
		public CrmDateTime overriddencreatedon
		{
			get
			{
				return this.overriddencreatedonField;
			}
			set
			{
				this.overriddencreatedonField = value;
			}
		}
		public CrmDateTime sgt_dd_hoofdtoernooi_aanvang
		{
			get
			{
				return this.sgt_dd_hoofdtoernooi_aanvangField;
			}
			set
			{
				this.sgt_dd_hoofdtoernooi_aanvangField = value;
			}
		}
		public CrmDateTime sgt_dd_hoofdtoernooi_loting
		{
			get
			{
				return this.sgt_dd_hoofdtoernooi_lotingField;
			}
			set
			{
				this.sgt_dd_hoofdtoernooi_lotingField = value;
			}
		}
		public CrmDateTime sgt_dd_hoofdtoernooi_sluiting_email_insch
		{
			get
			{
				return this.sgt_dd_hoofdtoernooi_sluiting_email_inschField;
			}
			set
			{
				this.sgt_dd_hoofdtoernooi_sluiting_email_inschField = value;
			}
		}
		public CrmDateTime sgt_dd_hoofdtoernooi_sluiting_inschrijving
		{
			get
			{
				return this.sgt_dd_hoofdtoernooi_sluiting_inschrijvingField;
			}
			set
			{
				this.sgt_dd_hoofdtoernooi_sluiting_inschrijvingField = value;
			}
		}
		public CrmDateTime sgt_dd_kwalificatie_aanvang
		{
			get
			{
				return this.sgt_dd_kwalificatie_aanvangField;
			}
			set
			{
				this.sgt_dd_kwalificatie_aanvangField = value;
			}
		}
		public CrmDateTime sgt_dd_kwalificatie_loting
		{
			get
			{
				return this.sgt_dd_kwalificatie_lotingField;
			}
			set
			{
				this.sgt_dd_kwalificatie_lotingField = value;
			}
		}
		public CrmDateTime sgt_dd_kwalificatie_sluiting_email_inschr
		{
			get
			{
				return this.sgt_dd_kwalificatie_sluiting_email_inschrField;
			}
			set
			{
				this.sgt_dd_kwalificatie_sluiting_email_inschrField = value;
			}
		}
		public CrmDateTime sgt_dd_kwalificatie_sluiting_inschrijving
		{
			get
			{
				return this.sgt_dd_kwalificatie_sluiting_inschrijvingField;
			}
			set
			{
				this.sgt_dd_kwalificatie_sluiting_inschrijvingField = value;
			}
		}
		public CrmDateTime sgt_de_hoofdtoernooi_aanvang
		{
			get
			{
				return this.sgt_de_hoofdtoernooi_aanvangField;
			}
			set
			{
				this.sgt_de_hoofdtoernooi_aanvangField = value;
			}
		}
		public CrmDateTime sgt_de_hoofdtoernooi_loting
		{
			get
			{
				return this.sgt_de_hoofdtoernooi_lotingField;
			}
			set
			{
				this.sgt_de_hoofdtoernooi_lotingField = value;
			}
		}
		public CrmDateTime sgt_de_hoofdtoernooi_sluiting_email_insch
		{
			get
			{
				return this.sgt_de_hoofdtoernooi_sluiting_email_inschField;
			}
			set
			{
				this.sgt_de_hoofdtoernooi_sluiting_email_inschField = value;
			}
		}
		public CrmDateTime sgt_de_kwalificatie_aanvang
		{
			get
			{
				return this.sgt_de_kwalificatie_aanvangField;
			}
			set
			{
				this.sgt_de_kwalificatie_aanvangField = value;
			}
		}
		public CrmDateTime sgt_de_kwalificatie_loting
		{
			get
			{
				return this.sgt_de_kwalificatie_lotingField;
			}
			set
			{
				this.sgt_de_kwalificatie_lotingField = value;
			}
		}
		public CrmDateTime sgt_de_kwalificatie_sluiting_email_insch
		{
			get
			{
				return this.sgt_de_kwalificatie_sluiting_email_inschField;
			}
			set
			{
				this.sgt_de_kwalificatie_sluiting_email_inschField = value;
			}
		}
		public CrmDateTime sgt_de_kwalificatie_sluiting_inschrijving
		{
			get
			{
				return this.sgt_de_kwalificatie_sluiting_inschrijvingField;
			}
			set
			{
				this.sgt_de_kwalificatie_sluiting_inschrijvingField = value;
			}
		}
		public CrmDateTime sgt_hd_hoofdtoernooi_aanvang
		{
			get
			{
				return this.sgt_hd_hoofdtoernooi_aanvangField;
			}
			set
			{
				this.sgt_hd_hoofdtoernooi_aanvangField = value;
			}
		}
		public CrmDateTime sgt_hd_hoofdtoernooi_loting
		{
			get
			{
				return this.sgt_hd_hoofdtoernooi_lotingField;
			}
			set
			{
				this.sgt_hd_hoofdtoernooi_lotingField = value;
			}
		}
		public CrmDateTime sgt_hd_hoofdtoernooi_sluiting_email_insch
		{
			get
			{
				return this.sgt_hd_hoofdtoernooi_sluiting_email_inschField;
			}
			set
			{
				this.sgt_hd_hoofdtoernooi_sluiting_email_inschField = value;
			}
		}
		public CrmDecimal sgt_hd_hoofdtoernooi_sluiting_inschrijving
		{
			get
			{
				return this.sgt_hd_hoofdtoernooi_sluiting_inschrijvingField;
			}
			set
			{
				this.sgt_hd_hoofdtoernooi_sluiting_inschrijvingField = value;
			}
		}
		public CrmDateTime sgt_hd_ht_sluiting_inschrijving
		{
			get
			{
				return this.sgt_hd_ht_sluiting_inschrijvingField;
			}
			set
			{
				this.sgt_hd_ht_sluiting_inschrijvingField = value;
			}
		}
		public CrmDateTime sgt_hd_kwalificatie_aanvang
		{
			get
			{
				return this.sgt_hd_kwalificatie_aanvangField;
			}
			set
			{
				this.sgt_hd_kwalificatie_aanvangField = value;
			}
		}
		public CrmDateTime sgt_hd_kwalificatie_loting
		{
			get
			{
				return this.sgt_hd_kwalificatie_lotingField;
			}
			set
			{
				this.sgt_hd_kwalificatie_lotingField = value;
			}
		}
		public CrmDateTime sgt_hd_kwalificatie_sluiting_email_insch
		{
			get
			{
				return this.sgt_hd_kwalificatie_sluiting_email_inschField;
			}
			set
			{
				this.sgt_hd_kwalificatie_sluiting_email_inschField = value;
			}
		}
		public CrmDateTime sgt_hd_kwalificatie_sluiting_inschrijving
		{
			get
			{
				return this.sgt_hd_kwalificatie_sluiting_inschrijvingField;
			}
			set
			{
				this.sgt_hd_kwalificatie_sluiting_inschrijvingField = value;
			}
		}
		public CrmDateTime sgt_he_hoofdtoernooi_aanvang
		{
			get
			{
				return this.sgt_he_hoofdtoernooi_aanvangField;
			}
			set
			{
				this.sgt_he_hoofdtoernooi_aanvangField = value;
			}
		}
		public CrmDateTime sgt_he_hoofdtoernooi_loting
		{
			get
			{
				return this.sgt_he_hoofdtoernooi_lotingField;
			}
			set
			{
				this.sgt_he_hoofdtoernooi_lotingField = value;
			}
		}
		public CrmDateTime sgt_he_hoofdtoernooi_sluiting_email_insch
		{
			get
			{
				return this.sgt_he_hoofdtoernooi_sluiting_email_inschField;
			}
			set
			{
				this.sgt_he_hoofdtoernooi_sluiting_email_inschField = value;
			}
		}
		public CrmDateTime sgt_he_kwalificatie_aanvang
		{
			get
			{
				return this.sgt_he_kwalificatie_aanvangField;
			}
			set
			{
				this.sgt_he_kwalificatie_aanvangField = value;
			}
		}
		public CrmDateTime sgt_he_kwalificatie_loting
		{
			get
			{
				return this.sgt_he_kwalificatie_lotingField;
			}
			set
			{
				this.sgt_he_kwalificatie_lotingField = value;
			}
		}
		public CrmDateTime sgt_he_kwalificatie_sluiting_email_insch
		{
			get
			{
				return this.sgt_he_kwalificatie_sluiting_email_inschField;
			}
			set
			{
				this.sgt_he_kwalificatie_sluiting_email_inschField = value;
			}
		}
		public CrmDateTime sgt_he_kwalificatie_sluiting_inschrijving
		{
			get
			{
				return this.sgt_he_kwalificatie_sluiting_inschrijvingField;
			}
			set
			{
				this.sgt_he_kwalificatie_sluiting_inschrijvingField = value;
			}
		}
		public string sgt_inschrijven_dubbel_per_email
		{
			get
			{
				return this.sgt_inschrijven_dubbel_per_emailField;
			}
			set
			{
				this.sgt_inschrijven_dubbel_per_emailField = value;
			}
		}
		public string sgt_inschrijven_dubbel_per_fax
		{
			get
			{
				return this.sgt_inschrijven_dubbel_per_faxField;
			}
			set
			{
				this.sgt_inschrijven_dubbel_per_faxField = value;
			}
		}
		public string sgt_inschrijven_dubbel_via_internet
		{
			get
			{
				return this.sgt_inschrijven_dubbel_via_internetField;
			}
			set
			{
				this.sgt_inschrijven_dubbel_via_internetField = value;
			}
		}
		public CrmBoolean sgt_kledingreclamecode_van_toepassing
		{
			get
			{
				return this.sgt_kledingreclamecode_van_toepassingField;
			}
			set
			{
				this.sgt_kledingreclamecode_van_toepassingField = value;
			}
		}
		public string sgt_opmerking_1
		{
			get
			{
				return this.sgt_opmerking_1Field;
			}
			set
			{
				this.sgt_opmerking_1Field = value;
			}
		}
		public string sgt_opmerking_2
		{
			get
			{
				return this.sgt_opmerking_2Field;
			}
			set
			{
				this.sgt_opmerking_2Field = value;
			}
		}
		public Lookup sgt_soort_balid
		{
			get
			{
				return this.sgt_soort_balidField;
			}
			set
			{
				this.sgt_soort_balidField = value;
			}
		}
		public string sgt_toe_name
		{
			get
			{
				return this.sgt_toe_nameField;
			}
			set
			{
				this.sgt_toe_nameField = value;
			}
		}
		public Key sgt_toe_spelersmemoid
		{
			get
			{
				return this.sgt_toe_spelersmemoidField;
			}
			set
			{
				this.sgt_toe_spelersmemoidField = value;
			}
		}
		public Lookup sgt_toernooiid
		{
			get
			{
				return this.sgt_toernooiidField;
			}
			set
			{
				this.sgt_toernooiidField = value;
			}
		}
		public Sgt_toe_spelersmemoStateInfo statecode
		{
			get
			{
				return this.statecodeField;
			}
			set
			{
				this.statecodeField = value;
			}
		}
		public Status statuscode
		{
			get
			{
				return this.statuscodeField;
			}
			set
			{
				this.statuscodeField = value;
			}
		}
		public CrmNumber timezoneruleversionnumber
		{
			get
			{
				return this.timezoneruleversionnumberField;
			}
			set
			{
				this.timezoneruleversionnumberField = value;
			}
		}
		public CrmNumber utcconversiontimezonecode
		{
			get
			{
				return this.utcconversiontimezonecodeField;
			}
			set
			{
				this.utcconversiontimezonecodeField = value;
			}
		}
	}
}
