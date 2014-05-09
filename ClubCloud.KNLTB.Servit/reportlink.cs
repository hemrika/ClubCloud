using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
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
		[XmlElement(Order = 0)]
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
		[XmlElement(Order = 1)]
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
		[XmlElement(Order = 2)]
		public CrmNumber importsequencenumber
		{
			get
			{
				return this.importsequencenumberField;
			}
			set
			{
				this.importsequencenumberField = value;
				base.RaisePropertyChanged("importsequencenumber");
			}
		}
		[XmlElement(Order = 3)]
		public Lookup linkedreportid
		{
			get
			{
				return this.linkedreportidField;
			}
			set
			{
				this.linkedreportidField = value;
				base.RaisePropertyChanged("linkedreportid");
			}
		}
		[XmlElement(Order = 4)]
		public string linkedreportname
		{
			get
			{
				return this.linkedreportnameField;
			}
			set
			{
				this.linkedreportnameField = value;
				base.RaisePropertyChanged("linkedreportname");
			}
		}
		[XmlElement(Order = 5)]
		public Picklist linktypecode
		{
			get
			{
				return this.linktypecodeField;
			}
			set
			{
				this.linktypecodeField = value;
				base.RaisePropertyChanged("linktypecode");
			}
		}
		[XmlElement(Order = 6)]
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
		[XmlElement(Order = 7)]
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
		[XmlElement(Order = 8)]
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
		[XmlElement(Order = 9)]
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
		[XmlElement(Order = 10)]
		public Lookup reportid
		{
			get
			{
				return this.reportidField;
			}
			set
			{
				this.reportidField = value;
				base.RaisePropertyChanged("reportid");
			}
		}
		[XmlElement(Order = 11)]
		public Key reportlinkid
		{
			get
			{
				return this.reportlinkidField;
			}
			set
			{
				this.reportlinkidField = value;
				base.RaisePropertyChanged("reportlinkid");
			}
		}
	}
}
