using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class sgt_com_reeks_speeldatums : BusinessEntity
	{
		private Lookup createdbyField;
		private CrmDateTime createdonField;
		private CrmNumber importsequencenumberField;
		private Lookup modifiedbyField;
		private CrmDateTime modifiedonField;
		private CrmDateTime overriddencreatedonField;
		private Owner owneridField;
		private Lookup owningbusinessunitField;
		private CrmDateTime sgt_10e_inhaaldatumField;
		private string sgt_10e_inhaaldatum_dagaanduidingField;
		private CrmDateTime sgt_10e_speeldatumField;
		private string sgt_10e_speeldatum_dagaanduidingField;
		private CrmDateTime sgt_11e_speeldatumField;
		private string sgt_11e_speeldatum_dagaanduidingField;
		private CrmDateTime sgt_12e_speeldatumField;
		private string sgt_12e_speeldatum_dagaanduidingField;
		private CrmDateTime sgt_13e_speeldatumField;
		private string sgt_13e_speeldatum_dagaanduidingField;
		private CrmDateTime sgt_14e_speeldatumField;
		private string sgt_14e_speeldatum_dagaanduidingField;
		private CrmDateTime sgt_15e_speeldatumField;
		private string sgt_15e_speeldatum_dagaanduidingField;
		private CrmDateTime sgt_16e_speeldatumField;
		private string sgt_16e_speeldatum_dagaanduidingField;
		private CrmDateTime sgt_17e_speeldatumField;
		private string sgt_17e_speeldatum_dagaanduidingField;
		private CrmDateTime sgt_18e_speeldatumField;
		private string sgt_18e_speeldatum_dagaanduidingField;
		private CrmDateTime sgt_19e_speeldatumField;
		private string sgt_19e_speeldatum_dagaanduidingField;
		private CrmDateTime sgt_1e_inhaaldatumField;
		private string sgt_1e_inhaaldatum_dagaanduidingField;
		private CrmDateTime sgt_1e_speeldatumField;
		private string sgt_1e_speeldatum_dagaanduidingField;
		private CrmDateTime sgt_20e_speeldatumField;
		private string sgt_20e_speeldatum_dagaanduidingField;
		private CrmDateTime sgt_2e_inhaaldatumField;
		private string sgt_2e_inhaaldatum_dagaanduidingField;
		private CrmDateTime sgt_2e_speeldatumField;
		private string sgt_2e_speeldatum_dagaanduidingField;
		private CrmDateTime sgt_3e_inhaaldatumField;
		private string sgt_3e_inhaaldatum_dagaanduidingField;
		private CrmDateTime sgt_3e_speeldatumField;
		private string sgt_3e_speeldatum_dagaanduidingField;
		private CrmDateTime sgt_4e_inhaaldatumField;
		private string sgt_4e_inhaaldatum_dagaanduidingField;
		private CrmDateTime sgt_4e_speeldatumField;
		private string sgt_4e_speeldatum_dagaanduidingField;
		private CrmDateTime sgt_5e_inhaaldatumField;
		private string sgt_5e_inhaaldatum_dagaanduidingField;
		private CrmDateTime sgt_5e_speeldatumField;
		private string sgt_5e_speeldatum_dagaanduidingField;
		private CrmDateTime sgt_6e_inhaaldatumField;
		private string sgt_6e_inhaaldatum_dagaanduidingField;
		private CrmDateTime sgt_6e_speeldatumField;
		private string sgt_6e_speeldatum_dagaanduidingField;
		private CrmDateTime sgt_7e_inhaaldatumField;
		private string sgt_7e_inhaaldatum_dagaanduidingField;
		private CrmDateTime sgt_7e_speeldatumField;
		private string sgt_7e_speeldatum_dagaanduidingField;
		private CrmDateTime sgt_8e_inhaaldatumField;
		private string sgt_8e_inhaaldatum_dagaanduidingField;
		private CrmDateTime sgt_8e_speeldatumField;
		private string sgt_8e_speeldatum_dagaanduidingField;
		private CrmDateTime sgt_9e_inhaaldatumField;
		private string sgt_9e_inhaaldatum_dagaanduidingField;
		private CrmDateTime sgt_9e_speeldatumField;
		private string sgt_9e_speeldatum_dagaanduidingField;
		private string sgt_com_reeks_speeldatums1Field;
		private Key sgt_com_reeks_speeldatumsidField;
		private Lookup sgt_competitieidField;
		private Sgt_com_reeks_speeldatumsStateInfo statecodeField;
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
		public CrmDateTime sgt_10e_inhaaldatum
		{
			get
			{
				return this.sgt_10e_inhaaldatumField;
			}
			set
			{
				this.sgt_10e_inhaaldatumField = value;
			}
		}
		public string sgt_10e_inhaaldatum_dagaanduiding
		{
			get
			{
				return this.sgt_10e_inhaaldatum_dagaanduidingField;
			}
			set
			{
				this.sgt_10e_inhaaldatum_dagaanduidingField = value;
			}
		}
		public CrmDateTime sgt_10e_speeldatum
		{
			get
			{
				return this.sgt_10e_speeldatumField;
			}
			set
			{
				this.sgt_10e_speeldatumField = value;
			}
		}
		public string sgt_10e_speeldatum_dagaanduiding
		{
			get
			{
				return this.sgt_10e_speeldatum_dagaanduidingField;
			}
			set
			{
				this.sgt_10e_speeldatum_dagaanduidingField = value;
			}
		}
		public CrmDateTime sgt_11e_speeldatum
		{
			get
			{
				return this.sgt_11e_speeldatumField;
			}
			set
			{
				this.sgt_11e_speeldatumField = value;
			}
		}
		public string sgt_11e_speeldatum_dagaanduiding
		{
			get
			{
				return this.sgt_11e_speeldatum_dagaanduidingField;
			}
			set
			{
				this.sgt_11e_speeldatum_dagaanduidingField = value;
			}
		}
		public CrmDateTime sgt_12e_speeldatum
		{
			get
			{
				return this.sgt_12e_speeldatumField;
			}
			set
			{
				this.sgt_12e_speeldatumField = value;
			}
		}
		public string sgt_12e_speeldatum_dagaanduiding
		{
			get
			{
				return this.sgt_12e_speeldatum_dagaanduidingField;
			}
			set
			{
				this.sgt_12e_speeldatum_dagaanduidingField = value;
			}
		}
		public CrmDateTime sgt_13e_speeldatum
		{
			get
			{
				return this.sgt_13e_speeldatumField;
			}
			set
			{
				this.sgt_13e_speeldatumField = value;
			}
		}
		public string sgt_13e_speeldatum_dagaanduiding
		{
			get
			{
				return this.sgt_13e_speeldatum_dagaanduidingField;
			}
			set
			{
				this.sgt_13e_speeldatum_dagaanduidingField = value;
			}
		}
		public CrmDateTime sgt_14e_speeldatum
		{
			get
			{
				return this.sgt_14e_speeldatumField;
			}
			set
			{
				this.sgt_14e_speeldatumField = value;
			}
		}
		public string sgt_14e_speeldatum_dagaanduiding
		{
			get
			{
				return this.sgt_14e_speeldatum_dagaanduidingField;
			}
			set
			{
				this.sgt_14e_speeldatum_dagaanduidingField = value;
			}
		}
		public CrmDateTime sgt_15e_speeldatum
		{
			get
			{
				return this.sgt_15e_speeldatumField;
			}
			set
			{
				this.sgt_15e_speeldatumField = value;
			}
		}
		public string sgt_15e_speeldatum_dagaanduiding
		{
			get
			{
				return this.sgt_15e_speeldatum_dagaanduidingField;
			}
			set
			{
				this.sgt_15e_speeldatum_dagaanduidingField = value;
			}
		}
		public CrmDateTime sgt_16e_speeldatum
		{
			get
			{
				return this.sgt_16e_speeldatumField;
			}
			set
			{
				this.sgt_16e_speeldatumField = value;
			}
		}
		public string sgt_16e_speeldatum_dagaanduiding
		{
			get
			{
				return this.sgt_16e_speeldatum_dagaanduidingField;
			}
			set
			{
				this.sgt_16e_speeldatum_dagaanduidingField = value;
			}
		}
		public CrmDateTime sgt_17e_speeldatum
		{
			get
			{
				return this.sgt_17e_speeldatumField;
			}
			set
			{
				this.sgt_17e_speeldatumField = value;
			}
		}
		public string sgt_17e_speeldatum_dagaanduiding
		{
			get
			{
				return this.sgt_17e_speeldatum_dagaanduidingField;
			}
			set
			{
				this.sgt_17e_speeldatum_dagaanduidingField = value;
			}
		}
		public CrmDateTime sgt_18e_speeldatum
		{
			get
			{
				return this.sgt_18e_speeldatumField;
			}
			set
			{
				this.sgt_18e_speeldatumField = value;
			}
		}
		public string sgt_18e_speeldatum_dagaanduiding
		{
			get
			{
				return this.sgt_18e_speeldatum_dagaanduidingField;
			}
			set
			{
				this.sgt_18e_speeldatum_dagaanduidingField = value;
			}
		}
		public CrmDateTime sgt_19e_speeldatum
		{
			get
			{
				return this.sgt_19e_speeldatumField;
			}
			set
			{
				this.sgt_19e_speeldatumField = value;
			}
		}
		public string sgt_19e_speeldatum_dagaanduiding
		{
			get
			{
				return this.sgt_19e_speeldatum_dagaanduidingField;
			}
			set
			{
				this.sgt_19e_speeldatum_dagaanduidingField = value;
			}
		}
		public CrmDateTime sgt_1e_inhaaldatum
		{
			get
			{
				return this.sgt_1e_inhaaldatumField;
			}
			set
			{
				this.sgt_1e_inhaaldatumField = value;
			}
		}
		public string sgt_1e_inhaaldatum_dagaanduiding
		{
			get
			{
				return this.sgt_1e_inhaaldatum_dagaanduidingField;
			}
			set
			{
				this.sgt_1e_inhaaldatum_dagaanduidingField = value;
			}
		}
		public CrmDateTime sgt_1e_speeldatum
		{
			get
			{
				return this.sgt_1e_speeldatumField;
			}
			set
			{
				this.sgt_1e_speeldatumField = value;
			}
		}
		public string sgt_1e_speeldatum_dagaanduiding
		{
			get
			{
				return this.sgt_1e_speeldatum_dagaanduidingField;
			}
			set
			{
				this.sgt_1e_speeldatum_dagaanduidingField = value;
			}
		}
		public CrmDateTime sgt_20e_speeldatum
		{
			get
			{
				return this.sgt_20e_speeldatumField;
			}
			set
			{
				this.sgt_20e_speeldatumField = value;
			}
		}
		public string sgt_20e_speeldatum_dagaanduiding
		{
			get
			{
				return this.sgt_20e_speeldatum_dagaanduidingField;
			}
			set
			{
				this.sgt_20e_speeldatum_dagaanduidingField = value;
			}
		}
		public CrmDateTime sgt_2e_inhaaldatum
		{
			get
			{
				return this.sgt_2e_inhaaldatumField;
			}
			set
			{
				this.sgt_2e_inhaaldatumField = value;
			}
		}
		public string sgt_2e_inhaaldatum_dagaanduiding
		{
			get
			{
				return this.sgt_2e_inhaaldatum_dagaanduidingField;
			}
			set
			{
				this.sgt_2e_inhaaldatum_dagaanduidingField = value;
			}
		}
		public CrmDateTime sgt_2e_speeldatum
		{
			get
			{
				return this.sgt_2e_speeldatumField;
			}
			set
			{
				this.sgt_2e_speeldatumField = value;
			}
		}
		public string sgt_2e_speeldatum_dagaanduiding
		{
			get
			{
				return this.sgt_2e_speeldatum_dagaanduidingField;
			}
			set
			{
				this.sgt_2e_speeldatum_dagaanduidingField = value;
			}
		}
		public CrmDateTime sgt_3e_inhaaldatum
		{
			get
			{
				return this.sgt_3e_inhaaldatumField;
			}
			set
			{
				this.sgt_3e_inhaaldatumField = value;
			}
		}
		public string sgt_3e_inhaaldatum_dagaanduiding
		{
			get
			{
				return this.sgt_3e_inhaaldatum_dagaanduidingField;
			}
			set
			{
				this.sgt_3e_inhaaldatum_dagaanduidingField = value;
			}
		}
		public CrmDateTime sgt_3e_speeldatum
		{
			get
			{
				return this.sgt_3e_speeldatumField;
			}
			set
			{
				this.sgt_3e_speeldatumField = value;
			}
		}
		public string sgt_3e_speeldatum_dagaanduiding
		{
			get
			{
				return this.sgt_3e_speeldatum_dagaanduidingField;
			}
			set
			{
				this.sgt_3e_speeldatum_dagaanduidingField = value;
			}
		}
		public CrmDateTime sgt_4e_inhaaldatum
		{
			get
			{
				return this.sgt_4e_inhaaldatumField;
			}
			set
			{
				this.sgt_4e_inhaaldatumField = value;
			}
		}
		public string sgt_4e_inhaaldatum_dagaanduiding
		{
			get
			{
				return this.sgt_4e_inhaaldatum_dagaanduidingField;
			}
			set
			{
				this.sgt_4e_inhaaldatum_dagaanduidingField = value;
			}
		}
		public CrmDateTime sgt_4e_speeldatum
		{
			get
			{
				return this.sgt_4e_speeldatumField;
			}
			set
			{
				this.sgt_4e_speeldatumField = value;
			}
		}
		public string sgt_4e_speeldatum_dagaanduiding
		{
			get
			{
				return this.sgt_4e_speeldatum_dagaanduidingField;
			}
			set
			{
				this.sgt_4e_speeldatum_dagaanduidingField = value;
			}
		}
		public CrmDateTime sgt_5e_inhaaldatum
		{
			get
			{
				return this.sgt_5e_inhaaldatumField;
			}
			set
			{
				this.sgt_5e_inhaaldatumField = value;
			}
		}
		public string sgt_5e_inhaaldatum_dagaanduiding
		{
			get
			{
				return this.sgt_5e_inhaaldatum_dagaanduidingField;
			}
			set
			{
				this.sgt_5e_inhaaldatum_dagaanduidingField = value;
			}
		}
		public CrmDateTime sgt_5e_speeldatum
		{
			get
			{
				return this.sgt_5e_speeldatumField;
			}
			set
			{
				this.sgt_5e_speeldatumField = value;
			}
		}
		public string sgt_5e_speeldatum_dagaanduiding
		{
			get
			{
				return this.sgt_5e_speeldatum_dagaanduidingField;
			}
			set
			{
				this.sgt_5e_speeldatum_dagaanduidingField = value;
			}
		}
		public CrmDateTime sgt_6e_inhaaldatum
		{
			get
			{
				return this.sgt_6e_inhaaldatumField;
			}
			set
			{
				this.sgt_6e_inhaaldatumField = value;
			}
		}
		public string sgt_6e_inhaaldatum_dagaanduiding
		{
			get
			{
				return this.sgt_6e_inhaaldatum_dagaanduidingField;
			}
			set
			{
				this.sgt_6e_inhaaldatum_dagaanduidingField = value;
			}
		}
		public CrmDateTime sgt_6e_speeldatum
		{
			get
			{
				return this.sgt_6e_speeldatumField;
			}
			set
			{
				this.sgt_6e_speeldatumField = value;
			}
		}
		public string sgt_6e_speeldatum_dagaanduiding
		{
			get
			{
				return this.sgt_6e_speeldatum_dagaanduidingField;
			}
			set
			{
				this.sgt_6e_speeldatum_dagaanduidingField = value;
			}
		}
		public CrmDateTime sgt_7e_inhaaldatum
		{
			get
			{
				return this.sgt_7e_inhaaldatumField;
			}
			set
			{
				this.sgt_7e_inhaaldatumField = value;
			}
		}
		public string sgt_7e_inhaaldatum_dagaanduiding
		{
			get
			{
				return this.sgt_7e_inhaaldatum_dagaanduidingField;
			}
			set
			{
				this.sgt_7e_inhaaldatum_dagaanduidingField = value;
			}
		}
		public CrmDateTime sgt_7e_speeldatum
		{
			get
			{
				return this.sgt_7e_speeldatumField;
			}
			set
			{
				this.sgt_7e_speeldatumField = value;
			}
		}
		public string sgt_7e_speeldatum_dagaanduiding
		{
			get
			{
				return this.sgt_7e_speeldatum_dagaanduidingField;
			}
			set
			{
				this.sgt_7e_speeldatum_dagaanduidingField = value;
			}
		}
		public CrmDateTime sgt_8e_inhaaldatum
		{
			get
			{
				return this.sgt_8e_inhaaldatumField;
			}
			set
			{
				this.sgt_8e_inhaaldatumField = value;
			}
		}
		public string sgt_8e_inhaaldatum_dagaanduiding
		{
			get
			{
				return this.sgt_8e_inhaaldatum_dagaanduidingField;
			}
			set
			{
				this.sgt_8e_inhaaldatum_dagaanduidingField = value;
			}
		}
		public CrmDateTime sgt_8e_speeldatum
		{
			get
			{
				return this.sgt_8e_speeldatumField;
			}
			set
			{
				this.sgt_8e_speeldatumField = value;
			}
		}
		public string sgt_8e_speeldatum_dagaanduiding
		{
			get
			{
				return this.sgt_8e_speeldatum_dagaanduidingField;
			}
			set
			{
				this.sgt_8e_speeldatum_dagaanduidingField = value;
			}
		}
		public CrmDateTime sgt_9e_inhaaldatum
		{
			get
			{
				return this.sgt_9e_inhaaldatumField;
			}
			set
			{
				this.sgt_9e_inhaaldatumField = value;
			}
		}
		public string sgt_9e_inhaaldatum_dagaanduiding
		{
			get
			{
				return this.sgt_9e_inhaaldatum_dagaanduidingField;
			}
			set
			{
				this.sgt_9e_inhaaldatum_dagaanduidingField = value;
			}
		}
		public CrmDateTime sgt_9e_speeldatum
		{
			get
			{
				return this.sgt_9e_speeldatumField;
			}
			set
			{
				this.sgt_9e_speeldatumField = value;
			}
		}
		public string sgt_9e_speeldatum_dagaanduiding
		{
			get
			{
				return this.sgt_9e_speeldatum_dagaanduidingField;
			}
			set
			{
				this.sgt_9e_speeldatum_dagaanduidingField = value;
			}
		}
		[XmlElement("sgt_com_reeks_speeldatums")]
		public string sgt_com_reeks_speeldatums1
		{
			get
			{
				return this.sgt_com_reeks_speeldatums1Field;
			}
			set
			{
				this.sgt_com_reeks_speeldatums1Field = value;
			}
		}
		public Key sgt_com_reeks_speeldatumsid
		{
			get
			{
				return this.sgt_com_reeks_speeldatumsidField;
			}
			set
			{
				this.sgt_com_reeks_speeldatumsidField = value;
			}
		}
		public Lookup sgt_competitieid
		{
			get
			{
				return this.sgt_competitieidField;
			}
			set
			{
				this.sgt_competitieidField = value;
			}
		}
		public Sgt_com_reeks_speeldatumsStateInfo statecode
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
