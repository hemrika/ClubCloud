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
		public CrmBoolean sgt_akkoord_voor_verwerkingsverslag
		{
			get
			{
				return this.sgt_akkoord_voor_verwerkingsverslagField;
			}
			set
			{
				this.sgt_akkoord_voor_verwerkingsverslagField = value;
			}
		}
		public string sgt_alg_lognummer
		{
			get
			{
				return this.sgt_alg_lognummerField;
			}
			set
			{
				this.sgt_alg_lognummerField = value;
			}
		}
		public Key sgt_alg_pb_interface_logboekid
		{
			get
			{
				return this.sgt_alg_pb_interface_logboekidField;
			}
			set
			{
				this.sgt_alg_pb_interface_logboekidField = value;
			}
		}
		public CrmBoolean sgt_alle_pb_interfaces
		{
			get
			{
				return this.sgt_alle_pb_interfacesField;
			}
			set
			{
				this.sgt_alle_pb_interfacesField = value;
			}
		}
		public CrmBoolean sgt_alle_verenigingen
		{
			get
			{
				return this.sgt_alle_verenigingenField;
			}
			set
			{
				this.sgt_alle_verenigingenField = value;
			}
		}
		public CrmBoolean sgt_automatisch_gestart
		{
			get
			{
				return this.sgt_automatisch_gestartField;
			}
			set
			{
				this.sgt_automatisch_gestartField = value;
			}
		}
		public string sgt_bericht_aan_ledenadministrateur
		{
			get
			{
				return this.sgt_bericht_aan_ledenadministrateurField;
			}
			set
			{
				this.sgt_bericht_aan_ledenadministrateurField = value;
			}
		}
		public string sgt_bestandsnaam
		{
			get
			{
				return this.sgt_bestandsnaamField;
			}
			set
			{
				this.sgt_bestandsnaamField = value;
			}
		}
		public CrmDateTime sgt_datum_tm
		{
			get
			{
				return this.sgt_datum_tmField;
			}
			set
			{
				this.sgt_datum_tmField = value;
			}
		}
		public CrmDateTime sgt_datum_vanaf
		{
			get
			{
				return this.sgt_datum_vanafField;
			}
			set
			{
				this.sgt_datum_vanafField = value;
			}
		}
		public Lookup sgt_gestart_vanuit_logboekid
		{
			get
			{
				return this.sgt_gestart_vanuit_logboekidField;
			}
			set
			{
				this.sgt_gestart_vanuit_logboekidField = value;
			}
		}
		public Picklist sgt_import_export
		{
			get
			{
				return this.sgt_import_exportField;
			}
			set
			{
				this.sgt_import_exportField = value;
			}
		}
		public CrmNumber sgt_interfaceberichtid
		{
			get
			{
				return this.sgt_interfaceberichtidField;
			}
			set
			{
				this.sgt_interfaceberichtidField = value;
			}
		}
		public CrmBoolean sgt_logbestand_verwerkt
		{
			get
			{
				return this.sgt_logbestand_verwerktField;
			}
			set
			{
				this.sgt_logbestand_verwerktField = value;
			}
		}
		public Picklist sgt_mutatietype
		{
			get
			{
				return this.sgt_mutatietypeField;
			}
			set
			{
				this.sgt_mutatietypeField = value;
			}
		}
		public Lookup sgt_pb_interfaceid
		{
			get
			{
				return this.sgt_pb_interfaceidField;
			}
			set
			{
				this.sgt_pb_interfaceidField = value;
			}
		}
		public Picklist sgt_status_logboek
		{
			get
			{
				return this.sgt_status_logboekField;
			}
			set
			{
				this.sgt_status_logboekField = value;
			}
		}
		public CrmDateTime sgt_uitvoerdatum
		{
			get
			{
				return this.sgt_uitvoerdatumField;
			}
			set
			{
				this.sgt_uitvoerdatumField = value;
			}
		}
		public Lookup sgt_verenigingid
		{
			get
			{
				return this.sgt_verenigingidField;
			}
			set
			{
				this.sgt_verenigingidField = value;
			}
		}
		public Sgt_alg_pb_interface_logboekStateInfo statecode
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
