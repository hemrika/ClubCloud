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
		[XmlElement(Order = 0)]
		public Lookup campaignactivityid
		{
			get
			{
				return this.campaignactivityidField;
			}
			set
			{
				this.campaignactivityidField = value;
				base.RaisePropertyChanged("campaignactivityid");
			}
		}
		[XmlElement(Order = 1)]
		public Key campaignactivityitemid
		{
			get
			{
				return this.campaignactivityitemidField;
			}
			set
			{
				this.campaignactivityitemidField = value;
				base.RaisePropertyChanged("campaignactivityitemid");
			}
		}
		[XmlElement(Order = 2)]
		public UniqueIdentifier itemid
		{
			get
			{
				return this.itemidField;
			}
			set
			{
				this.itemidField = value;
				base.RaisePropertyChanged("itemid");
			}
		}
		[XmlElement(Order = 3)]
		public EntityNameReference itemobjecttypecode
		{
			get
			{
				return this.itemobjecttypecodeField;
			}
			set
			{
				this.itemobjecttypecodeField = value;
				base.RaisePropertyChanged("itemobjecttypecode");
			}
		}
		[XmlElement(Order = 4)]
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
		[XmlElement(Order = 5)]
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
	}
}
