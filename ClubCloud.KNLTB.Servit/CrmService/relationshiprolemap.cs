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
	public class relationshiprolemap : BusinessEntity
	{
		private EntityNameReference associateobjecttypecodeField;

		private Lookup createdbyField;

		private CrmDateTime createdonField;

		private Lookup modifiedbyField;

		private CrmDateTime modifiedonField;

		private UniqueIdentifier organizationidField;

		private EntityNameReference primaryobjecttypecodeField;

		private Lookup relationshiproleidField;

		private Key relationshiprolemapidField;

		[XmlElement] //[XmlElement(Order=0)]
		public EntityNameReference associateobjecttypecode
		{
			get
			{
				return this.associateobjecttypecodeField;
			}
			set
			{
				this.associateobjecttypecodeField = value;
				base.RaisePropertyChanged("associateobjecttypecode");
			}
		}

		[XmlElement] //[XmlElement(Order=1)]
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

		[XmlElement] //[XmlElement(Order=2)]
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

		[XmlElement] //[XmlElement(Order=3)]
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

		[XmlElement] //[XmlElement(Order=4)]
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

		[XmlElement] //[XmlElement(Order=5)]
		public UniqueIdentifier organizationid
		{
			get
			{
				return this.organizationidField;
			}
			set
			{
				this.organizationidField = value;
				base.RaisePropertyChanged("organizationid");
			}
		}

		[XmlElement] //[XmlElement(Order=6)]
		public EntityNameReference primaryobjecttypecode
		{
			get
			{
				return this.primaryobjecttypecodeField;
			}
			set
			{
				this.primaryobjecttypecodeField = value;
				base.RaisePropertyChanged("primaryobjecttypecode");
			}
		}

		[XmlElement] //[XmlElement(Order=7)]
		public Lookup relationshiproleid
		{
			get
			{
				return this.relationshiproleidField;
			}
			set
			{
				this.relationshiproleidField = value;
				base.RaisePropertyChanged("relationshiproleid");
			}
		}

		[XmlElement] //[XmlElement(Order=8)]
		public Key relationshiprolemapid
		{
			get
			{
				return this.relationshiprolemapidField;
			}
			set
			{
				this.relationshiprolemapidField = value;
				base.RaisePropertyChanged("relationshiprolemapid");
			}
		}

		public relationshiprolemap()
		{
		}
	}
}