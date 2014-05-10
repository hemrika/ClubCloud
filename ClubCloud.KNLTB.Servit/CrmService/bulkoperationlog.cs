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
		public string additionalinfo
		{
			get
			{
				return this.additionalinfoField;
			}
			set
			{
				this.additionalinfoField = value;
			}
		}
		public Lookup bulkoperationid
		{
			get
			{
				return this.bulkoperationidField;
			}
			set
			{
				this.bulkoperationidField = value;
			}
		}
		public Key bulkoperationlogid
		{
			get
			{
				return this.bulkoperationlogidField;
			}
			set
			{
				this.bulkoperationlogidField = value;
			}
		}
		public Lookup createdobjectid
		{
			get
			{
				return this.createdobjectidField;
			}
			set
			{
				this.createdobjectidField = value;
			}
		}
		public CrmNumber errornumber
		{
			get
			{
				return this.errornumberField;
			}
			set
			{
				this.errornumberField = value;
			}
		}
		public UniqueIdentifier owningbusinessunit
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
		public UniqueIdentifier owninguser
		{
			get
			{
				return this.owninguserField;
			}
			set
			{
				this.owninguserField = value;
			}
		}
		public Lookup regardingobjectid
		{
			get
			{
				return this.regardingobjectidField;
			}
			set
			{
				this.regardingobjectidField = value;
			}
		}
	}
}
