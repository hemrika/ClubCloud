using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class sgt_alg_pb_interface_logboek : BusinessEntity
	{
		private Lookup createdbyField;
		private CrmDateTime createdonField;
		private CrmNumber importsequencenumberField;
		private Lookup modifiedbyField;
		private CrmDateTime modifiedonField;
		private CrmDateTime overriddencreatedonField;
		private Owner owneridField;
		private Lookup owningbusinessunitField;
		private CrmBoolean sgt_akkoord_voor_verwerkingsverslagField;
		private string sgt_alg_lognummerField;
		private Key sgt_alg_pb_interface_logboekidField;
		private CrmBoolean sgt_alle_pb_interfacesField;
		private CrmBoolean sgt_alle_verenigingenField;
		private CrmBoolean sgt_automatisch_gestartField;
		private string sgt_bericht_aan_ledenadministrateurField;
		private string sgt_bestandsnaamField;
		private CrmDateTime sgt_datum_tmField;
		private CrmDateTime sgt_datum_vanafField;
		private Lookup sgt_gestart_vanuit_logboekidField;
		private Picklist sgt_import_exportField;
		private CrmNumber sgt_interfaceberichtidField;
		private CrmBoolean sgt_logbestand_verwerktField;
		private Picklist sgt_mutatietypeField;
		private Lookup sgt_pb_interfaceidField;
		private Picklist sgt_status_logboekField;
		private CrmDateTime sgt_uitvoerdatumField;
		private Lookup sgt_verenigingidField;
		private Sgt_alg_pb_interface_logboekStateInfo statecodeField;
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
		public CrmBoolean sgt_akkoord_voor_verwerkingsverslag
		{
			get
			{
				return this.sgt_akkoord_voor_verwerkingsverslagField;
			}
			set
			{
				this.sgt_akkoord_voor_verwerkingsverslagField = value;
				base.RaisePropertyChanged("sgt_akkoord_voor_verwerkingsverslag");
			}
		}
		[XmlElement(Order = 9)]
		public string sgt_alg_lognummer
		{
			get
			{
				return this.sgt_alg_lognummerField;
			}
			set
			{
				this.sgt_alg_lognummerField = value;
				base.RaisePropertyChanged("sgt_alg_lognummer");
			}
		}
		[XmlElement(Order = 10)]
		public Key sgt_alg_pb_interface_logboekid
		{
			get
			{
				return this.sgt_alg_pb_interface_logboekidField;
			}
			set
			{
				this.sgt_alg_pb_interface_logboekidField = value;
				base.RaisePropertyChanged("sgt_alg_pb_interface_logboekid");
			}
		}
		[XmlElement(Order = 11)]
		public CrmBoolean sgt_alle_pb_interfaces
		{
			get
			{
				return this.sgt_alle_pb_interfacesField;
			}
			set
			{
				this.sgt_alle_pb_interfacesField = value;
				base.RaisePropertyChanged("sgt_alle_pb_interfaces");
			}
		}
		[XmlElement(Order = 12)]
		public CrmBoolean sgt_alle_verenigingen
		{
			get
			{
				return this.sgt_alle_verenigingenField;
			}
			set
			{
				this.sgt_alle_verenigingenField = value;
				base.RaisePropertyChanged("sgt_alle_verenigingen");
			}
		}
		[XmlElement(Order = 13)]
		public CrmBoolean sgt_automatisch_gestart
		{
			get
			{
				return this.sgt_automatisch_gestartField;
			}
			set
			{
				this.sgt_automatisch_gestartField = value;
				base.RaisePropertyChanged("sgt_automatisch_gestart");
			}
		}
		[XmlElement(Order = 14)]
		public string sgt_bericht_aan_ledenadministrateur
		{
			get
			{
				return this.sgt_bericht_aan_ledenadministrateurField;
			}
			set
			{
				this.sgt_bericht_aan_ledenadministrateurField = value;
				base.RaisePropertyChanged("sgt_bericht_aan_ledenadministrateur");
			}
		}
		[XmlElement(Order = 15)]
		public string sgt_bestandsnaam
		{
			get
			{
				return this.sgt_bestandsnaamField;
			}
			set
			{
				this.sgt_bestandsnaamField = value;
				base.RaisePropertyChanged("sgt_bestandsnaam");
			}
		}
		[XmlElement(Order = 16)]
		public CrmDateTime sgt_datum_tm
		{
			get
			{
				return this.sgt_datum_tmField;
			}
			set
			{
				this.sgt_datum_tmField = value;
				base.RaisePropertyChanged("sgt_datum_tm");
			}
		}
		[XmlElement(Order = 17)]
		public CrmDateTime sgt_datum_vanaf
		{
			get
			{
				return this.sgt_datum_vanafField;
			}
			set
			{
				this.sgt_datum_vanafField = value;
				base.RaisePropertyChanged("sgt_datum_vanaf");
			}
		}
		[XmlElement(Order = 18)]
		public Lookup sgt_gestart_vanuit_logboekid
		{
			get
			{
				return this.sgt_gestart_vanuit_logboekidField;
			}
			set
			{
				this.sgt_gestart_vanuit_logboekidField = value;
				base.RaisePropertyChanged("sgt_gestart_vanuit_logboekid");
			}
		}
		[XmlElement(Order = 19)]
		public Picklist sgt_import_export
		{
			get
			{
				return this.sgt_import_exportField;
			}
			set
			{
				this.sgt_import_exportField = value;
				base.RaisePropertyChanged("sgt_import_export");
			}
		}
		[XmlElement(Order = 20)]
		public CrmNumber sgt_interfaceberichtid
		{
			get
			{
				return this.sgt_interfaceberichtidField;
			}
			set
			{
				this.sgt_interfaceberichtidField = value;
				base.RaisePropertyChanged("sgt_interfaceberichtid");
			}
		}
		[XmlElement(Order = 21)]
		public CrmBoolean sgt_logbestand_verwerkt
		{
			get
			{
				return this.sgt_logbestand_verwerktField;
			}
			set
			{
				this.sgt_logbestand_verwerktField = value;
				base.RaisePropertyChanged("sgt_logbestand_verwerkt");
			}
		}
		[XmlElement(Order = 22)]
		public Picklist sgt_mutatietype
		{
			get
			{
				return this.sgt_mutatietypeField;
			}
			set
			{
				this.sgt_mutatietypeField = value;
				base.RaisePropertyChanged("sgt_mutatietype");
			}
		}
		[XmlElement(Order = 23)]
		public Lookup sgt_pb_interfaceid
		{
			get
			{
				return this.sgt_pb_interfaceidField;
			}
			set
			{
				this.sgt_pb_interfaceidField = value;
				base.RaisePropertyChanged("sgt_pb_interfaceid");
			}
		}
		[XmlElement(Order = 24)]
		public Picklist sgt_status_logboek
		{
			get
			{
				return this.sgt_status_logboekField;
			}
			set
			{
				this.sgt_status_logboekField = value;
				base.RaisePropertyChanged("sgt_status_logboek");
			}
		}
		[XmlElement(Order = 25)]
		public CrmDateTime sgt_uitvoerdatum
		{
			get
			{
				return this.sgt_uitvoerdatumField;
			}
			set
			{
				this.sgt_uitvoerdatumField = value;
				base.RaisePropertyChanged("sgt_uitvoerdatum");
			}
		}
		[XmlElement(Order = 26)]
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
		[XmlElement(Order = 27)]
		public Sgt_alg_pb_interface_logboekStateInfo statecode
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
		[XmlElement(Order = 28)]
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
		[XmlElement(Order = 29)]
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
		[XmlElement(Order = 30)]
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
