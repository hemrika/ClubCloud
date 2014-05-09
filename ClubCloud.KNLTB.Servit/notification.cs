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
		[XmlElement(Order = 0)]
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
		[XmlElement(Order = 1)]
		public string createdonstring
		{
			get
			{
				return this.createdonstringField;
			}
			set
			{
				this.createdonstringField = value;
				base.RaisePropertyChanged("createdonstring");
			}
		}
		[XmlElement(Order = 2)]
		public string eventdata
		{
			get
			{
				return this.eventdataField;
			}
			set
			{
				this.eventdataField = value;
				base.RaisePropertyChanged("eventdata");
			}
		}
		[XmlElement(Order = 3)]
		public CrmNumber eventid
		{
			get
			{
				return this.eventidField;
			}
			set
			{
				this.eventidField = value;
				base.RaisePropertyChanged("eventid");
			}
		}
		[XmlElement(Order = 4)]
		public Key notificationid
		{
			get
			{
				return this.notificationidField;
			}
			set
			{
				this.notificationidField = value;
				base.RaisePropertyChanged("notificationid");
			}
		}
		[XmlElement(Order = 5)]
		public CrmNumber notificationnumber
		{
			get
			{
				return this.notificationnumberField;
			}
			set
			{
				this.notificationnumberField = value;
				base.RaisePropertyChanged("notificationnumber");
			}
		}
		[XmlElement(Order = 6)]
		public Key organizationid
		{
			get
			{
				return this.organizationidField;
			}
			set
			{
				this.organizationidField = value;
				base.RaisePropertyChanged("organizationid");
			}
		}
	}
}
