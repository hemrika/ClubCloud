using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class duplicaterulecondition : BusinessEntity
	{
		private string baseattributenameField;
		private Lookup createdbyField;
		private CrmDateTime createdonField;
		private Key duplicateruleconditionidField;
		private string matchingattributenameField;
		private Lookup modifiedbyField;
		private CrmDateTime modifiedonField;
		private Picklist operatorcodeField;
		private CrmNumber operatorparamField;
		private UniqueIdentifier owningbusinessunitField;
		private UniqueIdentifier owninguserField;
		private Lookup regardingobjectidField;
		public string baseattributename
		{
			get
			{
				return this.baseattributenameField;
			}
			set
			{
				this.baseattributenameField = value;
			}
		}
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
		public Key duplicateruleconditionid
		{
			get
			{
				return this.duplicateruleconditionidField;
			}
			set
			{
				this.duplicateruleconditionidField = value;
			}
		}
		public string matchingattributename
		{
			get
			{
				return this.matchingattributenameField;
			}
			set
			{
				this.matchingattributenameField = value;
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
		public Picklist operatorcode
		{
			get
			{
				return this.operatorcodeField;
			}
			set
			{
				this.operatorcodeField = value;
			}
		}
		public CrmNumber operatorparam
		{
			get
			{
				return this.operatorparamField;
			}
			set
			{
				this.operatorparamField = value;
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
