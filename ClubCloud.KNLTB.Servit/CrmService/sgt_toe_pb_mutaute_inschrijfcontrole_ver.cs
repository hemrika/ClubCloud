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
	public class sgt_toe_pb_mutaute_inschrijfcontrole_ver : BusinessEntity
	{
		private Lookup createdbyField;

		private CrmDateTime createdonField;

		private CrmNumber importsequencenumberField;

		private Lookup modifiedbyField;

		private CrmDateTime modifiedonField;

		private CrmDateTime overriddencreatedonField;

		private Owner owneridField;

		private Lookup owningbusinessunitField;

		private Picklist sgt__import_exportField;

		private CrmDateTime sgt_datum_mutatie_verwerktField;

		private string sgt_districtscodeField;

		private string sgt_districtsnaamField;

		private Lookup sgt_pb_itf_log_toernooien_idField;

		private Key sgt_toe_pb_mutaute_inschrijfcontrole_veridField;

		private string sgt_toe_volgnummerField;

		private string sgt_verenigingsnaamField;

		private string sgt_verenigingsnummerField;

		private string sgt_zoeknaam_verenigingField;

		private Sgt_toe_pb_mutaute_inschrijfcontrole_verStateInfo statecodeField;

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
		public Picklist sgt__import_export
		{
			get
			{
				return this.sgt__import_exportField;
			}
			set
			{
				this.sgt__import_exportField = value;
				base.RaisePropertyChanged("sgt__import_export");
			}
		}

		[XmlElement] //[XmlElement(Order=9)]
		public CrmDateTime sgt_datum_mutatie_verwerkt
		{
			get
			{
				return this.sgt_datum_mutatie_verwerktField;
			}
			set
			{
				this.sgt_datum_mutatie_verwerktField = value;
				base.RaisePropertyChanged("sgt_datum_mutatie_verwerkt");
			}
		}

		[XmlElement] //[XmlElement(Order=10)]
		public string sgt_districtscode
		{
			get
			{
				return this.sgt_districtscodeField;
			}
			set
			{
				this.sgt_districtscodeField = value;
				base.RaisePropertyChanged("sgt_districtscode");
			}
		}

		[XmlElement] //[XmlElement(Order=11)]
		public string sgt_districtsnaam
		{
			get
			{
				return this.sgt_districtsnaamField;
			}
			set
			{
				this.sgt_districtsnaamField = value;
				base.RaisePropertyChanged("sgt_districtsnaam");
			}
		}

		[XmlElement] //[XmlElement(Order=12)]
		public Lookup sgt_pb_itf_log_toernooien_id
		{
			get
			{
				return this.sgt_pb_itf_log_toernooien_idField;
			}
			set
			{
				this.sgt_pb_itf_log_toernooien_idField = value;
				base.RaisePropertyChanged("sgt_pb_itf_log_toernooien_id");
			}
		}

		[XmlElement] //[XmlElement(Order=13)]
		public Key sgt_toe_pb_mutaute_inschrijfcontrole_verid
		{
			get
			{
				return this.sgt_toe_pb_mutaute_inschrijfcontrole_veridField;
			}
			set
			{
				this.sgt_toe_pb_mutaute_inschrijfcontrole_veridField = value;
				base.RaisePropertyChanged("sgt_toe_pb_mutaute_inschrijfcontrole_verid");
			}
		}

		[XmlElement] //[XmlElement(Order=14)]
		public string sgt_toe_volgnummer
		{
			get
			{
				return this.sgt_toe_volgnummerField;
			}
			set
			{
				this.sgt_toe_volgnummerField = value;
				base.RaisePropertyChanged("sgt_toe_volgnummer");
			}
		}

		[XmlElement] //[XmlElement(Order=15)]
		public string sgt_verenigingsnaam
		{
			get
			{
				return this.sgt_verenigingsnaamField;
			}
			set
			{
				this.sgt_verenigingsnaamField = value;
				base.RaisePropertyChanged("sgt_verenigingsnaam");
			}
		}

		[XmlElement] //[XmlElement(Order=16)]
		public string sgt_verenigingsnummer
		{
			get
			{
				return this.sgt_verenigingsnummerField;
			}
			set
			{
				this.sgt_verenigingsnummerField = value;
				base.RaisePropertyChanged("sgt_verenigingsnummer");
			}
		}

		[XmlElement] //[XmlElement(Order=17)]
		public string sgt_zoeknaam_vereniging
		{
			get
			{
				return this.sgt_zoeknaam_verenigingField;
			}
			set
			{
				this.sgt_zoeknaam_verenigingField = value;
				base.RaisePropertyChanged("sgt_zoeknaam_vereniging");
			}
		}

		[XmlElement] //[XmlElement(Order=18)]
		public Sgt_toe_pb_mutaute_inschrijfcontrole_verStateInfo statecode
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

		public sgt_toe_pb_mutaute_inschrijfcontrole_ver()
		{
		}
	}
}