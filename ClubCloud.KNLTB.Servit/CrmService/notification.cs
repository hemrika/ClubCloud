using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class notification : BusinessEntity
	{
		private CrmDateTime createdonField;
		private string createdonstringField;
		private string eventdataField;
		private CrmNumber eventidField;
		private Key notificationidField;
		private CrmNumber notificationnumberField;
		private Key organizationidField;
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
		public string createdonstring
		{
			get
			{
				return this.createdonstringField;
			}
			set
			{
				this.createdonstringField = value;
			}
		}
		public string eventdata
		{
			get
			{
				return this.eventdataField;
			}
			set
			{
				this.eventdataField = value;
			}
		}
		public CrmNumber eventid
		{
			get
			{
				return this.eventidField;
			}
			set
			{
				this.eventidField = value;
			}
		}
		public Key notificationid
		{
			get
			{
				return this.notificationidField;
			}
			set
			{
				this.notificationidField = value;
			}
		}
		public CrmNumber notificationnumber
		{
			get
			{
				return this.notificationnumberField;
			}
			set
			{
				this.notificationnumberField = value;
			}
		}
		public Key organizationid
		{
			get
			{
				return this.organizationidField;
			}
			set
			{
				this.organizationidField = value;
			}
		}
	}
}
