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
	public class sgt_toe_bondsgedelegeerde : BusinessEntity
	{
		private Lookup createdbyField;

		private CrmDateTime createdonField;

		private CrmNumber importsequencenumberField;

		private Lookup modifiedbyField;

		private CrmDateTime modifiedonField;

		private CrmDateTime overriddencreatedonField;

		private Owner owneridField;

		private Lookup owningbusinessunitField;

		private Lookup sgt_bondsgedelegeerde_idField;

		private CrmBoolean sgt_e_mail_zichtbaarField;

		private CrmBoolean sgt_mobiel_zichtbaarField;

		private string sgt_opmerkingenField;

		private CrmBoolean sgt_overdag_beschikbaarField;

		private CrmBoolean sgt_telefoon_zichtbaarField;

		private string sgt_toe_bondsgedelegeerde1Field;

		private Key sgt_toe_bondsgedelegeerdeidField;

		private Lookup sgt_toernooikalender_idField;

		private Sgt_toe_bondsgedelegeerdeStateInfo statecodeField;

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
		public Lookup sgt_bondsgedelegeerde_id
		{
			get
			{
				return this.sgt_bondsgedelegeerde_idField;
			}
			set
			{
				this.sgt_bondsgedelegeerde_idField = value;
				base.RaisePropertyChanged("sgt_bondsgedelegeerde_id");
			}
		}

		[XmlElement] //[XmlElement(Order=9)]
		public CrmBoolean sgt_e_mail_zichtbaar
		{
			get
			{
				return this.sgt_e_mail_zichtbaarField;
			}
			set
			{
				this.sgt_e_mail_zichtbaarField = value;
				base.RaisePropertyChanged("sgt_e_mail_zichtbaar");
			}
		}

		[XmlElement] //[XmlElement(Order=10)]
		public CrmBoolean sgt_mobiel_zichtbaar
		{
			get
			{
				return this.sgt_mobiel_zichtbaarField;
			}
			set
			{
				this.sgt_mobiel_zichtbaarField = value;
				base.RaisePropertyChanged("sgt_mobiel_zichtbaar");
			}
		}

		[XmlElement] //[XmlElement(Order=11)]
		public string sgt_opmerkingen
		{
			get
			{
				return this.sgt_opmerkingenField;
			}
			set
			{
				this.sgt_opmerkingenField = value;
				base.RaisePropertyChanged("sgt_opmerkingen");
			}
		}

		[XmlElement] //[XmlElement(Order=12)]
		public CrmBoolean sgt_overdag_beschikbaar
		{
			get
			{
				return this.sgt_overdag_beschikbaarField;
			}
			set
			{
				this.sgt_overdag_beschikbaarField = value;
				base.RaisePropertyChanged("sgt_overdag_beschikbaar");
			}
		}

		[XmlElement] //[XmlElement(Order=13)]
		public CrmBoolean sgt_telefoon_zichtbaar
		{
			get
			{
				return this.sgt_telefoon_zichtbaarField;
			}
			set
			{
				this.sgt_telefoon_zichtbaarField = value;
				base.RaisePropertyChanged("sgt_telefoon_zichtbaar");
			}
		}

		[XmlElement("sgt_toe_bondsgedelegeerde")] //, Order=14)]
		public string sgt_toe_bondsgedelegeerde1
		{
			get
			{
				return this.sgt_toe_bondsgedelegeerde1Field;
			}
			set
			{
				this.sgt_toe_bondsgedelegeerde1Field = value;
				base.RaisePropertyChanged("sgt_toe_bondsgedelegeerde1");
			}
		}

		[XmlElement] //[XmlElement(Order=15)]
		public Key sgt_toe_bondsgedelegeerdeid
		{
			get
			{
				return this.sgt_toe_bondsgedelegeerdeidField;
			}
			set
			{
				this.sgt_toe_bondsgedelegeerdeidField = value;
				base.RaisePropertyChanged("sgt_toe_bondsgedelegeerdeid");
			}
		}

		[XmlElement] //[XmlElement(Order=16)]
		public Lookup sgt_toernooikalender_id
		{
			get
			{
				return this.sgt_toernooikalender_idField;
			}
			set
			{
				this.sgt_toernooikalender_idField = value;
				base.RaisePropertyChanged("sgt_toernooikalender_id");
			}
		}

		[XmlElement] //[XmlElement(Order=17)]
		public Sgt_toe_bondsgedelegeerdeStateInfo statecode
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

		[XmlElement] //[XmlElement(Order=18)]
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

		[XmlElement] //[XmlElement(Order=19)]
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

		[XmlElement] //[XmlElement(Order=20)]
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

		public sgt_toe_bondsgedelegeerde()
		{
		}
	}
}