using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class bulkoperationlog : BusinessEntity
	{
		private string additionalinfoField;
		private Lookup bulkoperationidField;
		private Key bulkoperationlogidField;
		private Lookup createdobjectidField;
		private CrmNumber errornumberField;
		private UniqueIdentifier owningbusinessunitField;
		private UniqueIdentifier owninguserField;
		private Lookup regardingobjectidField;
		[XmlElement(Order = 0)]
		public string additionalinfo
		{
			get
			{
				return this.additionalinfoField;
			}
			set
			{
				this.additionalinfoField = value;
				base.RaisePropertyChanged("additionalinfo");
			}
		}
		[XmlElement(Order = 1)]
		public Lookup bulkoperationid
		{
			get
			{
				return this.bulkoperationidField;
			}
			set
			{
				this.bulkoperationidField = value;
				base.RaisePropertyChanged("bulkoperationid");
			}
		}
		[XmlElement(Order = 2)]
		public Key bulkoperationlogid
		{
			get
			{
				return this.bulkoperationlogidField;
			}
			set
			{
				this.bulkoperationlogidField = value;
				base.RaisePropertyChanged("bulkoperationlogid");
			}
		}
		[XmlElement(Order = 3)]
		public Lookup createdobjectid
		{
			get
			{
				return this.createdobjectidField;
			}
			set
			{
				this.createdobjectidField = value;
				base.RaisePropertyChanged("createdobjectid");
			}
		}
		[XmlElement(Order = 4)]
		public CrmNumber errornumber
		{
			get
			{
				return this.errornumberField;
			}
			set
			{
				this.errornumberField = value;
				base.RaisePropertyChanged("errornumber");
			}
		}
		[XmlElement(Order = 5)]
		public UniqueIdentifier owningbusinessunit
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
		[XmlElement(Order = 6)]
		public UniqueIdentifier owninguser
		{
			get
			{
				return this.owninguserField;
			}
			set
			{
				this.owninguserField = value;
				base.RaisePropertyChanged("owninguser");
			}
		}
		[XmlElement(Order = 7)]
		public Lookup regardingobjectid
		{
			get
			{
				return this.regardingobjectidField;
			}
			set
			{
				this.regardingobjectidField = value;
				base.RaisePropertyChanged("regardingobjectid");
			}
		}
	}
}
