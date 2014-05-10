using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class reportlink : BusinessEntity
	{
		private Lookup createdbyField;
		private CrmDateTime createdonField;
		private CrmNumber importsequencenumberField;
		private Lookup linkedreportidField;
		private string linkedreportnameField;
		private Picklist linktypecodeField;
		private Lookup modifiedbyField;
		private CrmDateTime modifiedonField;
		private UniqueIdentifier owningbusinessunitField;
		private UniqueIdentifier owninguserField;
		private Lookup reportidField;
		private Key reportlinkidField;
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
		public Lookup linkedreportid
		{
			get
			{
				return this.linkedreportidField;
			}
			set
			{
				this.linkedreportidField = value;
			}
		}
		public string linkedreportname
		{
			get
			{
				return this.linkedreportnameField;
			}
			set
			{
				this.linkedreportnameField = value;
			}
		}
		public Picklist linktypecode
		{
			get
			{
				return this.linktypecodeField;
			}
			set
			{
				this.linktypecodeField = value;
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
		public Lookup reportid
		{
			get
			{
				return this.reportidField;
			}
			set
			{
				this.reportidField = value;
			}
		}
		public Key reportlinkid
		{
			get
			{
				return this.reportlinkidField;
			}
			set
			{
				this.reportlinkidField = value;
			}
		}
	}
}
