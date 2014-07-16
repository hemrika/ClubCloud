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
	public class sgt_toe_pb_interface_logboek_toernooien : BusinessEntity
	{
		private Lookup createdbyField;

		private CrmDateTime createdonField;

		private CrmNumber importsequencenumberField;

		private Lookup modifiedbyField;

		private CrmDateTime modifiedonField;

		private CrmDateTime overriddencreatedonField;

		private Owner owneridField;

		private Lookup owningbusinessunitField;

		private string sgt_bondsnummerField;

		private CrmNumber sgt_interfaceberichtidField;

		private Picklist sgt_soort_interfaceField;

		private Picklist sgt_status_interfaceField;

		private string sgt_toe_lognummerField;

		private Lookup sgt_toe_pb_interface_logboek_toernooiField;

		private Key sgt_toe_pb_interface_logboek_toernooienidField;

		private Picklist sgt_type_interfaceField;

		private Sgt_toe_pb_interface_logboek_toernooienStateInfo statecodeField;

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
		public string sgt_bondsnummer
		{
			get
			{
				return this.sgt_bondsnummerField;
			}
			set
			{
				this.sgt_bondsnummerField = value;
				base.RaisePropertyChanged("sgt_bondsnummer");
			}
		}

		[XmlElement] //[XmlElement(Order=9)]
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

		[XmlElement] //[XmlElement(Order=10)]
		public Picklist sgt_soort_interface
		{
			get
			{
				return this.sgt_soort_interfaceField;
			}
			set
			{
				this.sgt_soort_interfaceField = value;
				base.RaisePropertyChanged("sgt_soort_interface");
			}
		}

		[XmlElement] //[XmlElement(Order=11)]
		public Picklist sgt_status_interface
		{
			get
			{
				return this.sgt_status_interfaceField;
			}
			set
			{
				this.sgt_status_interfaceField = value;
				base.RaisePropertyChanged("sgt_status_interface");
			}
		}

		[XmlElement] //[XmlElement(Order=12)]
		public string sgt_toe_lognummer
		{
			get
			{
				return this.sgt_toe_lognummerField;
			}
			set
			{
				this.sgt_toe_lognummerField = value;
				base.RaisePropertyChanged("sgt_toe_lognummer");
			}
		}

		[XmlElement] //[XmlElement(Order=13)]
		public Lookup sgt_toe_pb_interface_logboek_toernooi
		{
			get
			{
				return this.sgt_toe_pb_interface_logboek_toernooiField;
			}
			set
			{
				this.sgt_toe_pb_interface_logboek_toernooiField = value;
				base.RaisePropertyChanged("sgt_toe_pb_interface_logboek_toernooi");
			}
		}

		[XmlElement] //[XmlElement(Order=14)]
		public Key sgt_toe_pb_interface_logboek_toernooienid
		{
			get
			{
				return this.sgt_toe_pb_interface_logboek_toernooienidField;
			}
			set
			{
				this.sgt_toe_pb_interface_logboek_toernooienidField = value;
				base.RaisePropertyChanged("sgt_toe_pb_interface_logboek_toernooienid");
			}
		}

		[XmlElement] //[XmlElement(Order=15)]
		public Picklist sgt_type_interface
		{
			get
			{
				return this.sgt_type_interfaceField;
			}
			set
			{
				this.sgt_type_interfaceField = value;
				base.RaisePropertyChanged("sgt_type_interface");
			}
		}

		[XmlElement] //[XmlElement(Order=16)]
		public Sgt_toe_pb_interface_logboek_toernooienStateInfo statecode
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

		[XmlElement] //[XmlElement(Order=17)]
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

		[XmlElement] //[XmlElement(Order=18)]
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

		[XmlElement] //[XmlElement(Order=19)]
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

		public sgt_toe_pb_interface_logboek_toernooien()
		{
		}
	}
}