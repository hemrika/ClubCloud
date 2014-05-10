using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class subscriptionsyncinfo : BusinessEntity
	{
		private CrmNumber datasizeField;
		private CrmNumber deleteobjectcountField;
		private CrmDateTime endtimeField;
		private CrmNumber insertobjectcountField;
		private CrmDateTime starttimeField;
		private Lookup subscriptionidField;
		private CrmNumber subscriptionsyncinfoidField;
		private CrmBoolean syncresultField;
		private CrmNumber timezoneruleversionnumberField;
		private CrmNumber utcconversiontimezonecodeField;
		public CrmNumber datasize
		{
			get
			{
				return this.datasizeField;
			}
			set
			{
				this.datasizeField = value;
			}
		}
		public CrmNumber deleteobjectcount
		{
			get
			{
				return this.deleteobjectcountField;
			}
			set
			{
				this.deleteobjectcountField = value;
			}
		}
		public CrmDateTime endtime
		{
			get
			{
				return this.endtimeField;
			}
			set
			{
				this.endtimeField = value;
			}
		}
		public CrmNumber insertobjectcount
		{
			get
			{
				return this.insertobjectcountField;
			}
			set
			{
				this.insertobjectcountField = value;
			}
		}
		public CrmDateTime starttime
		{
			get
			{
				return this.starttimeField;
			}
			set
			{
				this.starttimeField = value;
			}
		}
		public Lookup subscriptionid
		{
			get
			{
				return this.subscriptionidField;
			}
			set
			{
				this.subscriptionidField = value;
			}
		}
		public CrmNumber subscriptionsyncinfoid
		{
			get
			{
				return this.subscriptionsyncinfoidField;
			}
			set
			{
				this.subscriptionsyncinfoidField = value;
			}
		}
		public CrmBoolean syncresult
		{
			get
			{
				return this.syncresultField;
			}
			set
			{
				this.syncresultField = value;
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
