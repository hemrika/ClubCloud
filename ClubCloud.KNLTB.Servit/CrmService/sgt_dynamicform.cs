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
		public string sgt_basisorganisatie_veld_volgorde
		{
			get
			{
				return this.sgt_basisorganisatie_veld_volgordeField;
			}
			set
			{
				this.sgt_basisorganisatie_veld_volgordeField = value;
				base.RaisePropertyChanged("sgt_basisorganisatie_veld_volgorde");
			}
		}

		[XmlElement] //[XmlElement(Order=9)]
		public CrmNumber sgt_basisorganisatie_volgorde
		{
			get
			{
				return this.sgt_basisorganisatie_volgordeField;
			}
			set
			{
				this.sgt_basisorganisatie_volgordeField = value;
				base.RaisePropertyChanged("sgt_basisorganisatie_volgorde");
			}
		}

		[XmlElement] //[XmlElement(Order=10)]
		public CrmBoolean sgt_basisorganisatie_zichtbaar
		{
			get
			{
				return this.sgt_basisorganisatie_zichtbaarField;
			}
			set
			{
				this.sgt_basisorganisatie_zichtbaarField = value;
				base.RaisePropertyChanged("sgt_basisorganisatie_zichtbaar");
			}
		}

		[XmlElement] //[XmlElement(Order=11)]
		public string sgt_bevestigd_veld_volgorde
		{
			get
			{
				return this.sgt_bevestigd_veld_volgordeField;
			}
			set
			{
				this.sgt_bevestigd_veld_volgordeField = value;
				base.RaisePropertyChanged("sgt_bevestigd_veld_volgorde");
			}
		}

		[XmlElement] //[XmlElement(Order=12)]
		public CrmBoolean sgt_bevestigd_zichtbaar
		{
			get
			{
				return this.sgt_bevestigd_zichtbaarField;
			}
			set
			{
				this.sgt_bevestigd_zichtbaarField = value;
				base.RaisePropertyChanged("sgt_bevestigd_zichtbaar");
			}
		}

		[XmlElement] //[XmlElement(Order=13)]
		public Key sgt_dynamicformid
		{
			get
			{
				return this.sgt_dynamicformidField;
			}
			set
			{
				this.sgt_dynamicformidField = value;
				base.RaisePropertyChanged("sgt_dynamicformid");
			}
		}

		[XmlElement] //[XmlElement(Order=14)]
		public Picklist sgt_formulier_gebruikt_voor
		{
			get
			{
				return this.sgt_formulier_gebruikt_voorField;
			}
			set
			{
				this.sgt_formulier_gebruikt_voorField = value;
				base.RaisePropertyChanged("sgt_formulier_gebruikt_voor");
			}
		}

		[XmlElement] //[XmlElement(Order=15)]
		public string sgt_label_basisorganisatie
		{
			get
			{
				return this.sgt_label_basisorganisatieField;
			}
			set
			{
				this.sgt_label_basisorganisatieField = value;
				base.RaisePropertyChanged("sgt_label_basisorganisatie");
			}
		}

		[XmlElement] //[XmlElement(Order=16)]
		public string sgt_label_bevestigd
		{
			get
			{
				return this.sgt_label_bevestigdField;
			}
			set
			{
				this.sgt_label_bevestigdField = value;
				base.RaisePropertyChanged("sgt_label_bevestigd");
			}
		}

		[XmlElement] //[XmlElement(Order=17)]
		public string sgt_label_persoon1
		{
			get
			{
				return this.sgt_label_persoon1Field;
			}
			set
			{
				this.sgt_label_persoon1Field = value;
				base.RaisePropertyChanged("sgt_label_persoon1");
			}
		}

		[XmlElement] //[XmlElement(Order=18)]
		public string sgt_label_persoon2
		{
			get
			{
				return this.sgt_label_persoon2Field;
			}
			set
			{
				this.sgt_label_persoon2Field = value;
				base.RaisePropertyChanged("sgt_label_persoon2");
			}
		}

		[XmlElement] //[XmlElement(Order=19)]
		public string sgt_label_voorkeur1
		{
			get
			{
				return this.sgt_label_voorkeur1Field;
			}
			set
			{
				this.sgt_label_voorkeur1Field = value;
				base.RaisePropertyChanged("sgt_label_voorkeur1");
			}
		}

		[XmlElement] //[XmlElement(Order=20)]
		public string sgt_label_voorkeur2
		{
			get
			{
				return this.sgt_label_voorkeur2Field;
			}
			set
			{
				this.sgt_label_voorkeur2Field = value;
				base.RaisePropertyChanged("sgt_label_voorkeur2");
			}
		}

		[XmlElement] //[XmlElement(Order=21)]
		public string sgt_label_voorkeur3
		{
			get
			{
				return this.sgt_label_voorkeur3Field;
			}
			set
			{
				this.sgt_label_voorkeur3Field = value;
				base.RaisePropertyChanged("sgt_label_voorkeur3");
			}
		}

		[XmlElement] //[XmlElement(Order=22)]
		public string sgt_linkedrecordid
		{
			get
			{
				return this.sgt_linkedrecordidField;
			}
			set
			{
				this.sgt_linkedrecordidField = value;
				base.RaisePropertyChanged("sgt_linkedrecordid");
			}
		}

		[XmlElement] //[XmlElement(Order=23)]
		public string sgt_name
		{
			get
			{
				return this.sgt_nameField;
			}
			set
			{
				this.sgt_nameField = value;
				base.RaisePropertyChanged("sgt_name");
			}
		}

		[XmlElement] //[XmlElement(Order=24)]
		public CrmBoolean sgt_persoon1_invulbaar
		{
			get
			{
				return this.sgt_persoon1_invulbaarField;
			}
			set
			{
				this.sgt_persoon1_invulbaarField = value;
				base.RaisePropertyChanged("sgt_persoon1_invulbaar");
			}
		}

		[XmlElement] //[XmlElement(Order=25)]
		public string sgt_persoon1_veld_volgorde
		{
			get
			{
				return this.sgt_persoon1_veld_volgordeField;
			}
			set
			{
				this.sgt_persoon1_veld_volgordeField = value;
				base.RaisePropertyChanged("sgt_persoon1_veld_volgorde");
			}
		}

		[XmlElement] //[XmlElement(Order=26)]
		public CrmNumber sgt_persoon1_volgorde
		{
			get
			{
				return this.sgt_persoon1_volgordeField;
			}
			set
			{
				this.sgt_persoon1_volgordeField = value;
				base.RaisePropertyChanged("sgt_persoon1_volgorde");
			}
		}

		[XmlElement] //[XmlElement(Order=27)]
		public CrmBoolean sgt_persoon1_zichtbaar
		{
			get
			{
				return this.sgt_persoon1_zichtbaarField;
			}
			set
			{
				this.sgt_persoon1_zichtbaarField = value;
				base.RaisePropertyChanged("sgt_persoon1_zichtbaar");
			}
		}

		[XmlElement] //[XmlElement(Order=28)]
		public string sgt_persoon2_veld_volgorde
		{
			get
			{
				return this.sgt_persoon2_veld_volgordeField;
			}
			set
			{
				this.sgt_persoon2_veld_volgordeField = value;
				base.RaisePropertyChanged("sgt_persoon2_veld_volgorde");
			}
		}

		[XmlElement] //[XmlElement(Order=29)]
		public CrmNumber sgt_persoon2_volgorde
		{
			get
			{
				return this.sgt_persoon2_volgordeField;
			}
			set
			{
				this.sgt_persoon2_volgordeField = value;
				base.RaisePropertyChanged("sgt_persoon2_volgorde");
			}
		}

		[XmlElement] //[XmlElement(Order=30)]
		public CrmBoolean sgt_persoon2_zichtbaar
		{
			get
			{
				return this.sgt_persoon2_zichtbaarField;
			}
			set
			{
				this.sgt_persoon2_zichtbaarField = value;
				base.RaisePropertyChanged("sgt_persoon2_zichtbaar");
			}
		}

		[XmlElement] //[XmlElement(Order=31)]
		public string sgt_voorkeur1_veld_volgorde
		{
			get
			{
				return this.sgt_voorkeur1_veld_volgordeField;
			}
			set
			{
				this.sgt_voorkeur1_veld_volgordeField = value;
				base.RaisePropertyChanged("sgt_voorkeur1_veld_volgorde");
			}
		}

		[XmlElement] //[XmlElement(Order=32)]
		public CrmBoolean sgt_voorkeur1_zichtbaar
		{
			get
			{
				return this.sgt_voorkeur1_zichtbaarField;
			}
			set
			{
				this.sgt_voorkeur1_zichtbaarField = value;
				base.RaisePropertyChanged("sgt_voorkeur1_zichtbaar");
			}
		}

		[XmlElement] //[XmlElement(Order=33)]
		public string sgt_voorkeur2_veld_volgorde
		{
			get
			{
				return this.sgt_voorkeur2_veld_volgordeField;
			}
			set
			{
				this.sgt_voorkeur2_veld_volgordeField = value;
				base.RaisePropertyChanged("sgt_voorkeur2_veld_volgorde");
			}
		}

		[XmlElement] //[XmlElement(Order=34)]
		public CrmBoolean sgt_voorkeur2_zichtbaar
		{
			get
			{
				return this.sgt_voorkeur2_zichtbaarField;
			}
			set
			{
				this.sgt_voorkeur2_zichtbaarField = value;
				base.RaisePropertyChanged("sgt_voorkeur2_zichtbaar");
			}
		}

		[XmlElement] //[XmlElement(Order=35)]
		public string sgt_voorkeur3_veld_volgorde
		{
			get
			{
				return this.sgt_voorkeur3_veld_volgordeField;
			}
			set
			{
				this.sgt_voorkeur3_veld_volgordeField = value;
				base.RaisePropertyChanged("sgt_voorkeur3_veld_volgorde");
			}
		}

		[XmlElement] //[XmlElement(Order=36)]
		public CrmBoolean sgt_voorkeur3_zichtbaar
		{
			get
			{
				return this.sgt_voorkeur3_zichtbaarField;
			}
			set
			{
				this.sgt_voorkeur3_zichtbaarField = value;
				base.RaisePropertyChanged("sgt_voorkeur3_zichtbaar");
			}
		}

		[XmlElement] //[XmlElement(Order=37)]
		public Sgt_dynamicformStateInfo statecode
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

		[XmlElement] //[XmlElement(Order=38)]
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

		[XmlElement] //[XmlElement(Order=39)]
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

		[XmlElement] //[XmlElement(Order=40)]
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

		public sgt_dynamicform()
		{
		}
	}
}