using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class sgt_dynamicform : BusinessEntity
	{
		private Lookup createdbyField;
		private CrmDateTime createdonField;
		private CrmNumber importsequencenumberField;
		private Lookup modifiedbyField;
		private CrmDateTime modifiedonField;
		private CrmDateTime overriddencreatedonField;
		private Owner owneridField;
		private Lookup owningbusinessunitField;
		private string sgt_basisorganisatie_veld_volgordeField;
		private CrmNumber sgt_basisorganisatie_volgordeField;
		private CrmBoolean sgt_basisorganisatie_zichtbaarField;
		private string sgt_bevestigd_veld_volgordeField;
		private CrmBoolean sgt_bevestigd_zichtbaarField;
		private Key sgt_dynamicformidField;
		private Picklist sgt_formulier_gebruikt_voorField;
		private string sgt_label_basisorganisatieField;
		private string sgt_label_bevestigdField;
		private string sgt_label_persoon1Field;
		private string sgt_label_persoon2Field;
		private string sgt_label_voorkeur1Field;
		private string sgt_label_voorkeur2Field;
		private string sgt_label_voorkeur3Field;
		private string sgt_linkedrecordidField;
		private string sgt_nameField;
		private CrmBoolean sgt_persoon1_invulbaarField;
		private string sgt_persoon1_veld_volgordeField;
		private CrmNumber sgt_persoon1_volgordeField;
		private CrmBoolean sgt_persoon1_zichtbaarField;
		private string sgt_persoon2_veld_volgordeField;
		private CrmNumber sgt_persoon2_volgordeField;
		private CrmBoolean sgt_persoon2_zichtbaarField;
		private string sgt_voorkeur1_veld_volgordeField;
		private CrmBoolean sgt_voorkeur1_zichtbaarField;
		private string sgt_voorkeur2_veld_volgordeField;
		private CrmBoolean sgt_voorkeur2_zichtbaarField;
		private string sgt_voorkeur3_veld_volgordeField;
		private CrmBoolean sgt_voorkeur3_zichtbaarField;
		private Sgt_dynamicformStateInfo statecodeField;
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
		public Owner ownerid
		{
			get
			{
				return this.owneridField;
			}
			set
			{
				this.owneridField = value;
			}
		}
		public Lookup owningbusinessunit
		{
			get
			{
				return this.owningbusinessunitField;
			}
			set
			{
				this.owningbusinessunitField = value;
			}
		}
		public string sgt_basisorganisatie_veld_volgorde
		{
			get
			{
				return this.sgt_basisorganisatie_veld_volgordeField;
			}
			set
			{
				this.sgt_basisorganisatie_veld_volgordeField = value;
			}
		}
		public CrmNumber sgt_basisorganisatie_volgorde
		{
			get
			{
				return this.sgt_basisorganisatie_volgordeField;
			}
			set
			{
				this.sgt_basisorganisatie_volgordeField = value;
			}
		}
		public CrmBoolean sgt_basisorganisatie_zichtbaar
		{
			get
			{
				return this.sgt_basisorganisatie_zichtbaarField;
			}
			set
			{
				this.sgt_basisorganisatie_zichtbaarField = value;
			}
		}
		public string sgt_bevestigd_veld_volgorde
		{
			get
			{
				return this.sgt_bevestigd_veld_volgordeField;
			}
			set
			{
				this.sgt_bevestigd_veld_volgordeField = value;
			}
		}
		public CrmBoolean sgt_bevestigd_zichtbaar
		{
			get
			{
				return this.sgt_bevestigd_zichtbaarField;
			}
			set
			{
				this.sgt_bevestigd_zichtbaarField = value;
			}
		}
		public Key sgt_dynamicformid
		{
			get
			{
				return this.sgt_dynamicformidField;
			}
			set
			{
				this.sgt_dynamicformidField = value;
			}
		}
		public Picklist sgt_formulier_gebruikt_voor
		{
			get
			{
				return this.sgt_formulier_gebruikt_voorField;
			}
			set
			{
				this.sgt_formulier_gebruikt_voorField = value;
			}
		}
		public string sgt_label_basisorganisatie
		{
			get
			{
				return this.sgt_label_basisorganisatieField;
			}
			set
			{
				this.sgt_label_basisorganisatieField = value;
			}
		}
		public string sgt_label_bevestigd
		{
			get
			{
				return this.sgt_label_bevestigdField;
			}
			set
			{
				this.sgt_label_bevestigdField = value;
			}
		}
		public string sgt_label_persoon1
		{
			get
			{
				return this.sgt_label_persoon1Field;
			}
			set
			{
				this.sgt_label_persoon1Field = value;
			}
		}
		public string sgt_label_persoon2
		{
			get
			{
				return this.sgt_label_persoon2Field;
			}
			set
			{
				this.sgt_label_persoon2Field = value;
			}
		}
		public string sgt_label_voorkeur1
		{
			get
			{
				return this.sgt_label_voorkeur1Field;
			}
			set
			{
				this.sgt_label_voorkeur1Field = value;
			}
		}
		public string sgt_label_voorkeur2
		{
			get
			{
				return this.sgt_label_voorkeur2Field;
			}
			set
			{
				this.sgt_label_voorkeur2Field = value;
			}
		}
		public string sgt_label_voorkeur3
		{
			get
			{
				return this.sgt_label_voorkeur3Field;
			}
			set
			{
				this.sgt_label_voorkeur3Field = value;
			}
		}
		public string sgt_linkedrecordid
		{
			get
			{
				return this.sgt_linkedrecordidField;
			}
			set
			{
				this.sgt_linkedrecordidField = value;
			}
		}
		public string sgt_name
		{
			get
			{
				return this.sgt_nameField;
			}
			set
			{
				this.sgt_nameField = value;
			}
		}
		public CrmBoolean sgt_persoon1_invulbaar
		{
			get
			{
				return this.sgt_persoon1_invulbaarField;
			}
			set
			{
				this.sgt_persoon1_invulbaarField = value;
			}
		}
		public string sgt_persoon1_veld_volgorde
		{
			get
			{
				return this.sgt_persoon1_veld_volgordeField;
			}
			set
			{
				this.sgt_persoon1_veld_volgordeField = value;
			}
		}
		public CrmNumber sgt_persoon1_volgorde
		{
			get
			{
				return this.sgt_persoon1_volgordeField;
			}
			set
			{
				this.sgt_persoon1_volgordeField = value;
			}
		}
		public CrmBoolean sgt_persoon1_zichtbaar
		{
			get
			{
				return this.sgt_persoon1_zichtbaarField;
			}
			set
			{
				this.sgt_persoon1_zichtbaarField = value;
			}
		}
		public string sgt_persoon2_veld_volgorde
		{
			get
			{
				return this.sgt_persoon2_veld_volgordeField;
			}
			set
			{
				this.sgt_persoon2_veld_volgordeField = value;
			}
		}
		public CrmNumber sgt_persoon2_volgorde
		{
			get
			{
				return this.sgt_persoon2_volgordeField;
			}
			set
			{
				this.sgt_persoon2_volgordeField = value;
			}
		}
		public CrmBoolean sgt_persoon2_zichtbaar
		{
			get
			{
				return this.sgt_persoon2_zichtbaarField;
			}
			set
			{
				this.sgt_persoon2_zichtbaarField = value;
			}
		}
		public string sgt_voorkeur1_veld_volgorde
		{
			get
			{
				return this.sgt_voorkeur1_veld_volgordeField;
			}
			set
			{
				this.sgt_voorkeur1_veld_volgordeField = value;
			}
		}
		public CrmBoolean sgt_voorkeur1_zichtbaar
		{
			get
			{
				return this.sgt_voorkeur1_zichtbaarField;
			}
			set
			{
				this.sgt_voorkeur1_zichtbaarField = value;
			}
		}
		public string sgt_voorkeur2_veld_volgorde
		{
			get
			{
				return this.sgt_voorkeur2_veld_volgordeField;
			}
			set
			{
				this.sgt_voorkeur2_veld_volgordeField = value;
			}
		}
		public CrmBoolean sgt_voorkeur2_zichtbaar
		{
			get
			{
				return this.sgt_voorkeur2_zichtbaarField;
			}
			set
			{
				this.sgt_voorkeur2_zichtbaarField = value;
			}
		}
		public string sgt_voorkeur3_veld_volgorde
		{
			get
			{
				return this.sgt_voorkeur3_veld_volgordeField;
			}
			set
			{
				this.sgt_voorkeur3_veld_volgordeField = value;
			}
		}
		public CrmBoolean sgt_voorkeur3_zichtbaar
		{
			get
			{
				return this.sgt_voorkeur3_zichtbaarField;
			}
			set
			{
				this.sgt_voorkeur3_zichtbaarField = value;
			}
		}
		public Sgt_dynamicformStateInfo statecode
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
