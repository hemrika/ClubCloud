using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class bulkdeletefailure : BusinessEntity
	{
		private Lookup asyncoperationidField;
		private Key bulkdeletefailureidField;
		private Lookup bulkdeleteoperationidField;
		private string errordescriptionField;
		private CrmNumber errornumberField;
		private CrmNumber orderedqueryindexField;
		private UniqueIdentifier owningbusinessunitField;
		private UniqueIdentifier owninguserField;
		private Lookup regardingobjectidField;
		public Lookup asyncoperationid
		{
			get
			{
				return this.asyncoperationidField;
			}
			set
			{
				this.asyncoperationidField = value;
			}
		}
		public Key bulkdeletefailureid
		{
			get
			{
				return this.bulkdeletefailureidField;
			}
			set
			{
				this.bulkdeletefailureidField = value;
			}
		}
		public Lookup bulkdeleteoperationid
		{
			get
			{
				return this.bulkdeleteoperationidField;
			}
			set
			{
				this.bulkdeleteoperationidField = value;
			}
		}
		public string errordescription
		{
			get
			{
				return this.errordescriptionField;
			}
			set
			{
				this.errordescriptionField = value;
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
		public CrmNumber orderedqueryindex
		{
			get
			{
				return this.orderedqueryindexField;
			}
			set
			{
				this.orderedqueryindexField = value;
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
