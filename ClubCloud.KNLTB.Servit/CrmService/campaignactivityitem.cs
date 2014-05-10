using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class campaignactivityitem : BusinessEntity
	{
		private Lookup campaignactivityidField;
		private Key campaignactivityitemidField;
		private UniqueIdentifier itemidField;
		private EntityNameReference itemobjecttypecodeField;
		private UniqueIdentifier owningbusinessunitField;
		private UniqueIdentifier owninguserField;
		public Lookup campaignactivityid
		{
			get
			{
				return this.campaignactivityidField;
			}
			set
			{
				this.campaignactivityidField = value;
			}
		}
		public Key campaignactivityitemid
		{
			get
			{
				return this.campaignactivityitemidField;
			}
			set
			{
				this.campaignactivityitemidField = value;
			}
		}
		public UniqueIdentifier itemid
		{
			get
			{
				return this.itemidField;
			}
			set
			{
				this.itemidField = value;
			}
		}
		public EntityNameReference itemobjecttypecode
		{
			get
			{
				return this.itemobjecttypecodeField;
			}
			set
			{
				this.itemobjecttypecodeField = value;
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
