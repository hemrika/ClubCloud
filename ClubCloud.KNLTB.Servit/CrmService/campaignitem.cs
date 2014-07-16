using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[GeneratedCode("System.Xml", "4.0.30319.33440")]
	[Serializable]
	[XmlType(Namespace="http://schemas.microsoft.com/crm/2007/WebServices")]
	public class campaignitem : BusinessEntity
	{
		private Lookup campaignidField;

		private Key campaignitemidField;

		private UniqueIdentifier entityidField;

		private string entitytypeField;

		private UniqueIdentifier owningbusinessunitField;

		private UniqueIdentifier owninguserField;

		[XmlElement] //[XmlElement(Order=0)]
		public Lookup campaignid
		{
			get
			{
				return this.campaignidField;
			}
			set
			{
				this.campaignidField = value;
				base.RaisePropertyChanged("campaignid");
			}
		}

		[XmlElement] //[XmlElement(Order=1)]
		public Key campaignitemid
		{
			get
			{
				return this.campaignitemidField;
			}
			set
			{
				this.campaignitemidField = value;
				base.RaisePropertyChanged("campaignitemid");
			}
		}

		[XmlElement] //[XmlElement(Order=2)]
		public UniqueIdentifier entityid
		{
			get
			{
				return this.entityidField;
			}
			set
			{
				this.entityidField = value;
				base.RaisePropertyChanged("entityid");
			}
		}

		[XmlElement] //[XmlElement(Order=3)]
		public string entitytype
		{
			get
			{
				return this.entitytypeField;
			}
			set
			{
				this.entitytypeField = value;
				base.RaisePropertyChanged("entitytype");
			}
		}

		[XmlElement] //[XmlElement(Order=4)]
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

		[XmlElement] //[XmlElement(Order=5)]
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

		public campaignitem()
		{
		}
	}
}