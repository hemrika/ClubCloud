using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class sgt_fac_factuurverzameling : BusinessEntity
	{
		private Lookup createdbyField;
		private CrmDateTime createdonField;
		private CrmNumber importsequencenumberField;
		private Lookup modifiedbyField;
		private CrmDateTime modifiedonField;
		private CrmDateTime overriddencreatedonField;
		private Owner owneridField;
		private Lookup owningbusinessunitField;
		private Lookup sgt_administratieidField;
		private string sgt_bovenschrift_factuurField;
		private string sgt_fac_factuurverzameling1Field;
		private Key sgt_fac_factuurverzamelingidField;
		private CrmDateTime sgt_fac_totenmetField;
		private CrmDateTime sgt_fac_vanafField;
		private Lookup sgt_factuurtypeidField;
		private Picklist sgt_periodeField;
		private Picklist sgt_periode_jaarField;
		private Picklist sgt_periode_kwartaalField;
		private Picklist sgt_periode_maandField;
		private Lookup sgt_prijslijstidField;
		private Picklist sgt_status_factuurverzamelingField;
		private CrmDateTime sgt_uitvoerdatumField;
		private Lookup sgt_valutaidField;
		private Sgt_fac_factuurverzamelingStateInfo statecodeField;
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
		public Lookup sgt_administratieid
		{
			get
			{
				return this.sgt_administratieidField;
			}
			set
			{
				this.sgt_administratieidField = value;
				base.RaisePropertyChanged("sgt_administratieid");
			}
		}
		[XmlElement(Order = 9)]
		public string sgt_bovenschrift_factuur
		{
			get
			{
				return this.sgt_bovenschrift_factuurField;
			}
			set
			{
				this.sgt_bovenschrift_factuurField = value;
				base.RaisePropertyChanged("sgt_bovenschrift_factuur");
			}
		}
		[XmlElement("sgt_fac_factuurverzameling", Order = 10)]
		public string sgt_fac_factuurverzameling1
		{
			get
			{
				return this.sgt_fac_factuurverzameling1Field;
			}
			set
			{
				this.sgt_fac_factuurverzameling1Field = value;
				base.RaisePropertyChanged("sgt_fac_factuurverzameling1");
			}
		}
		[XmlElement(Order = 11)]
		public Key sgt_fac_factuurverzamelingid
		{
			get
			{
				return this.sgt_fac_factuurverzamelingidField;
			}
			set
			{
				this.sgt_fac_factuurverzamelingidField = value;
				base.RaisePropertyChanged("sgt_fac_factuurverzamelingid");
			}
		}
		[XmlElement(Order = 12)]
		public CrmDateTime sgt_fac_totenmet
		{
			get
			{
				return this.sgt_fac_totenmetField;
			}
			set
			{
				this.sgt_fac_totenmetField = value;
				base.RaisePropertyChanged("sgt_fac_totenmet");
			}
		}
		[XmlElement(Order = 13)]
		public CrmDateTime sgt_fac_vanaf
		{
			get
			{
				return this.sgt_fac_vanafField;
			}
			set
			{
				this.sgt_fac_vanafField = value;
				base.RaisePropertyChanged("sgt_fac_vanaf");
			}
		}
		[XmlElement(Order = 14)]
		public Lookup sgt_factuurtypeid
		{
			get
			{
				return this.sgt_factuurtypeidField;
			}
			set
			{
				this.sgt_factuurtypeidField = value;
				base.RaisePropertyChanged("sgt_factuurtypeid");
			}
		}
		[XmlElement(Order = 15)]
		public Picklist sgt_periode
		{
			get
			{
				return this.sgt_periodeField;
			}
			set
			{
				this.sgt_periodeField = value;
				base.RaisePropertyChanged("sgt_periode");
			}
		}
		[XmlElement(Order = 16)]
		public Picklist sgt_periode_jaar
		{
			get
			{
				return this.sgt_periode_jaarField;
			}
			set
			{
				this.sgt_periode_jaarField = value;
				base.RaisePropertyChanged("sgt_periode_jaar");
			}
		}
		[XmlElement(Order = 17)]
		public Picklist sgt_periode_kwartaal
		{
			get
			{
				return this.sgt_periode_kwartaalField;
			}
			set
			{
				this.sgt_periode_kwartaalField = value;
				base.RaisePropertyChanged("sgt_periode_kwartaal");
			}
		}
		[XmlElement(Order = 18)]
		public Picklist sgt_periode_maand
		{
			get
			{
				return this.sgt_periode_maandField;
			}
			set
			{
				this.sgt_periode_maandField = value;
				base.RaisePropertyChanged("sgt_periode_maand");
			}
		}
		[XmlElement(Order = 19)]
		public Lookup sgt_prijslijstid
		{
			get
			{
				return this.sgt_prijslijstidField;
			}
			set
			{
				this.sgt_prijslijstidField = value;
				base.RaisePropertyChanged("sgt_prijslijstid");
			}
		}
		[XmlElement(Order = 20)]
		public Picklist sgt_status_factuurverzameling
		{
			get
			{
				return this.sgt_status_factuurverzamelingField;
			}
			set
			{
				this.sgt_status_factuurverzamelingField = value;
				base.RaisePropertyChanged("sgt_status_factuurverzameling");
			}
		}
		[XmlElement(Order = 21)]
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
		[XmlElement(Order = 22)]
		public Lookup sgt_valutaid
		{
			get
			{
				return this.sgt_valutaidField;
			}
			set
			{
				this.sgt_valutaidField = value;
				base.RaisePropertyChanged("sgt_valutaid");
			}
		}
		[XmlElement(Order = 23)]
		public Sgt_fac_factuurverzamelingStateInfo statecode
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
