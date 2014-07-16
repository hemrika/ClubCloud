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
	public class sgt_pbmutatietoernooidefinitieonderdeel : BusinessEntity
	{
		private Lookup createdbyField;

		private CrmDateTime createdonField;

		private CrmNumber importsequencenumberField;

		private Lookup modifiedbyField;

		private CrmDateTime modifiedonField;

		private CrmDateTime overriddencreatedonField;

		private Owner owneridField;

		private Lookup owningbusinessunitField;

		private Picklist sgt_geslachtField;

		private CrmNumber sgt_leeftijd_tmField;

		private CrmNumber sgt_leeftijd_vanafField;

		private Lookup sgt_pb_itf_log_toernooien_idField;

		private Key sgt_pbmutatietoernooidefinitieonderdeelidField;

		private Lookup sgt_schemasoort_idField;

		private string sgt_sleutel_toernooipakketField;

		private Lookup sgt_speelsterkte_idField;

		private Picklist sgt_spelsoortField;

		private string sgt_statusField;

		private string sgt_toe_volgnummerField;

		private Lookup sgt_toernooi_verwijzing_idField;

		private Lookup sgt_toernooionderdeel_idField;

		private Sgt_pbmutatietoernooidefinitieonderdeelStateInfo statecodeField;

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
		public Picklist sgt_geslacht
		{
			get
			{
				return this.sgt_geslachtField;
			}
			set
			{
				this.sgt_geslachtField = value;
				base.RaisePropertyChanged("sgt_geslacht");
			}
		}

		[XmlElement] //[XmlElement(Order=9)]
		public CrmNumber sgt_leeftijd_tm
		{
			get
			{
				return this.sgt_leeftijd_tmField;
			}
			set
			{
				this.sgt_leeftijd_tmField = value;
				base.RaisePropertyChanged("sgt_leeftijd_tm");
			}
		}

		[XmlElement] //[XmlElement(Order=10)]
		public CrmNumber sgt_leeftijd_vanaf
		{
			get
			{
				return this.sgt_leeftijd_vanafField;
			}
			set
			{
				this.sgt_leeftijd_vanafField = value;
				base.RaisePropertyChanged("sgt_leeftijd_vanaf");
			}
		}

		[XmlElement] //[XmlElement(Order=11)]
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

		[XmlElement] //[XmlElement(Order=12)]
		public Key sgt_pbmutatietoernooidefinitieonderdeelid
		{
			get
			{
				return this.sgt_pbmutatietoernooidefinitieonderdeelidField;
			}
			set
			{
				this.sgt_pbmutatietoernooidefinitieonderdeelidField = value;
				base.RaisePropertyChanged("sgt_pbmutatietoernooidefinitieonderdeelid");
			}
		}

		[XmlElement] //[XmlElement(Order=13)]
		public Lookup sgt_schemasoort_id
		{
			get
			{
				return this.sgt_schemasoort_idField;
			}
			set
			{
				this.sgt_schemasoort_idField = value;
				base.RaisePropertyChanged("sgt_schemasoort_id");
			}
		}

		[XmlElement] //[XmlElement(Order=14)]
		public string sgt_sleutel_toernooipakket
		{
			get
			{
				return this.sgt_sleutel_toernooipakketField;
			}
			set
			{
				this.sgt_sleutel_toernooipakketField = value;
				base.RaisePropertyChanged("sgt_sleutel_toernooipakket");
			}
		}

		[XmlElement] //[XmlElement(Order=15)]
		public Lookup sgt_speelsterkte_id
		{
			get
			{
				return this.sgt_speelsterkte_idField;
			}
			set
			{
				this.sgt_speelsterkte_idField = value;
				base.RaisePropertyChanged("sgt_speelsterkte_id");
			}
		}

		[XmlElement] //[XmlElement(Order=16)]
		public Picklist sgt_spelsoort
		{
			get
			{
				return this.sgt_spelsoortField;
			}
			set
			{
				this.sgt_spelsoortField = value;
				base.RaisePropertyChanged("sgt_spelsoort");
			}
		}

		[XmlElement] //[XmlElement(Order=17)]
		public string sgt_status
		{
			get
			{
				return this.sgt_statusField;
			}
			set
			{
				this.sgt_statusField = value;
				base.RaisePropertyChanged("sgt_status");
			}
		}

		[XmlElement] //[XmlElement(Order=18)]
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

		[XmlElement] //[XmlElement(Order=19)]
		public Lookup sgt_toernooi_verwijzing_id
		{
			get
			{
				return this.sgt_toernooi_verwijzing_idField;
			}
			set
			{
				this.sgt_toernooi_verwijzing_idField = value;
				base.RaisePropertyChanged("sgt_toernooi_verwijzing_id");
			}
		}

		[XmlElement] //[XmlElement(Order=20)]
		public Lookup sgt_toernooionderdeel_id
		{
			get
			{
				return this.sgt_toernooionderdeel_idField;
			}
			set
			{
				this.sgt_toernooionderdeel_idField = value;
				base.RaisePropertyChanged("sgt_toernooionderdeel_id");
			}
		}

		[XmlElement] //[XmlElement(Order=21)]
		public Sgt_pbmutatietoernooidefinitieonderdeelStateInfo statecode
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

		[XmlElement] //[XmlElement(Order=22)]
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

		[XmlElement] //[XmlElement(Order=23)]
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

		[XmlElement] //[XmlElement(Order=24)]
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

		public sgt_pbmutatietoernooidefinitieonderdeel()
		{
		}
	}
}