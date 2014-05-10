using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class campaignitem : BusinessEntity
	{
		private Lookup campaignidField;
		private Key campaignitemidField;
		private UniqueIdentifier entityidField;
		private string entitytypeField;
		private UniqueIdentifier owningbusinessunitField;
		private UniqueIdentifier owninguserField;
		public Lookup campaignid
		{
			get
			{
				return this.campaignidField;
			}
			set
			{
				this.campaignidField = value;
			}
		}
		public Key campaignitemid
		{
			get
			{
				return this.campaignitemidField;
			}
			set
			{
				this.campaignitemidField = value;
			}
		}
		public UniqueIdentifier entityid
		{
			get
			{
				return this.entityidField;
			}
			set
			{
				this.entityidField = value;
			}
		}
		public string entitytype
		{
			get
			{
				return this.entitytypeField;
			}
			set
			{
				this.entitytypeField = value;
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
	}
}
