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
	public class listmember : BusinessEntity
	{
		private Lookup createdbyField;

		private CrmDateTime createdonField;

		private Lookup entityidField;

		private string entitytypeField;

		private Lookup listidField;

		private Key listmemberidField;

		private Lookup modifiedbyField;

		private CrmDateTime modifiedonField;

		private UniqueIdentifier owningbusinessunitField;

		private UniqueIdentifier owninguserField;

		[XmlElement] //[XmlElement(Order=0)]
		public Lookup createdby
		{
			get
			{
				return this.createdbyField;
			}
			set
			{
				this.createdbyField = value;
				base.RaisePropertyChanged("createdby");
			}
		}

		[XmlElement] //[XmlElement(Order=1)]
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

		[XmlElement] //[XmlElement(Order=2)]
		public Lookup entityid
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
		public Lookup listid
		{
			get
			{
				return this.listidField;
			}
			set
			{
				this.listidField = value;
				base.RaisePropertyChanged("listid");
			}
		}

		[XmlElement] //[XmlElement(Order=5)]
		public Key listmemberid
		{
			get
			{
				return this.listmemberidField;
			}
			set
			{
				this.listmemberidField = value;
				base.RaisePropertyChanged("listmemberid");
			}
		}

		[XmlElement] //[XmlElement(Order=6)]
		public Lookup modifiedby
		{
			get
			{
				return this.modifiedbyField;
			}
			set
			{
				this.modifiedbyField = value;
				base.RaisePropertyChanged("modifiedby");
			}
		}

		[XmlElement] //[XmlElement(Order=7)]
		public CrmDateTime modifiedon
		{
			get
			{
				return this.modifiedonField;
			}
			set
			{
				this.modifiedonField = value;
				base.RaisePropertyChanged("modifiedon");
			}
		}

		[XmlElement] //[XmlElement(Order=8)]
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

		[XmlElement] //[XmlElement(Order=9)]
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

		public listmember()
		{
		}
	}
}