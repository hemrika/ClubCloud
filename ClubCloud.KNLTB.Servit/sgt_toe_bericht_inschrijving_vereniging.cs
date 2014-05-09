using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class sgt_toe_bericht_inschrijving_vereniging : BusinessEntity
	{
		private Lookup createdbyField;
		private CrmDateTime createdonField;
		private CrmNumber importsequencenumberField;
		private Lookup modifiedbyField;
		private CrmDateTime modifiedonField;
		private CrmDateTime overriddencreatedonField;
		private Owner owneridField;
		private Lookup owningbusinessunitField;
		private CrmDateTime sgt_datum_bericht_versturenField;
		private CrmDateTime sgt_datum_bericht_verstuurtField;
		private CrmDateTime sgt_datum_herinnering_verstuurtField;
		private string sgt_toe_bericht_inschrijving_vereniging1Field;
		private Key sgt_toe_bericht_inschrijving_verenigingidField;
		private Lookup sgt_toernooi_aanvraag_verwerking_idField;
		private Lookup sgt_toernooiidField;
		private Lookup sgt_verenigingidField;
		private Sgt_toe_bericht_inschrijving_verenigingStateInfo statecodeField;
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
		public CrmDateTime sgt_datum_bericht_versturen
		{
			get
			{
				return this.sgt_datum_bericht_versturenField;
			}
			set
			{
				this.sgt_datum_bericht_versturenField = value;
				base.RaisePropertyChanged("sgt_datum_bericht_versturen");
			}
		}
		[XmlElement(Order = 9)]
		public CrmDateTime sgt_datum_bericht_verstuurt
		{
			get
			{
				return this.sgt_datum_bericht_verstuurtField;
			}
			set
			{
				this.sgt_datum_bericht_verstuurtField = value;
				base.RaisePropertyChanged("sgt_datum_bericht_verstuurt");
			}
		}
		[XmlElement(Order = 10)]
		public CrmDateTime sgt_datum_herinnering_verstuurt
		{
			get
			{
				return this.sgt_datum_herinnering_verstuurtField;
			}
			set
			{
				this.sgt_datum_herinnering_verstuurtField = value;
				base.RaisePropertyChanged("sgt_datum_herinnering_verstuurt");
			}
		}
		[XmlElement("sgt_toe_bericht_inschrijving_vereniging", Order = 11)]
		public string sgt_toe_bericht_inschrijving_vereniging1
		{
			get
			{
				return this.sgt_toe_bericht_inschrijving_vereniging1Field;
			}
			set
			{
				this.sgt_toe_bericht_inschrijving_vereniging1Field = value;
				base.RaisePropertyChanged("sgt_toe_bericht_inschrijving_vereniging1");
			}
		}
		[XmlElement(Order = 12)]
		public Key sgt_toe_bericht_inschrijving_verenigingid
		{
			get
			{
				return this.sgt_toe_bericht_inschrijving_verenigingidField;
			}
			set
			{
				this.sgt_toe_bericht_inschrijving_verenigingidField = value;
				base.RaisePropertyChanged("sgt_toe_bericht_inschrijving_verenigingid");
			}
		}
		[XmlElement(Order = 13)]
		public Lookup sgt_toernooi_aanvraag_verwerking_id
		{
			get
			{
				return this.sgt_toernooi_aanvraag_verwerking_idField;
			}
			set
			{
				this.sgt_toernooi_aanvraag_verwerking_idField = value;
				base.RaisePropertyChanged("sgt_toernooi_aanvraag_verwerking_id");
			}
		}
		[XmlElement(Order = 14)]
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
		[XmlElement(Order = 15)]
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
		[XmlElement(Order = 16)]
		public Sgt_toe_bericht_inschrijving_verenigingStateInfo statecode
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
		[XmlElement(Order = 17)]
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
		[XmlElement(Order = 18)]
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
		[XmlElement(Order = 19)]
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
