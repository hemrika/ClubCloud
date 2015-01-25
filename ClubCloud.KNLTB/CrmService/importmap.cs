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
	public class importmap : BusinessEntity
	{
		private Lookup createdbyField;

		private CrmDateTime createdonField;

		private string descriptionField;

		private Key importmapidField;

		private Picklist importmaptypeField;

		private CrmBoolean isvalidforimportField;

		private CrmBoolean iswizardcreatedField;

		private Lookup modifiedbyField;

		private CrmDateTime modifiedonField;

		private string nameField;

		private Owner owneridField;

		private Lookup owningbusinessunitField;

		private string sourceField;

		private string sourceuseridentifierforsourcecrmuserlinkField;

		private string sourceuseridentifierforsourcedatasourceuserlinkField;

		private ImportMapStateInfo statecodeField;

		private Status statuscodeField;

		private Picklist targetentityField;

		private string targetuseridentifierforsourcecrmuserlinkField;

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
		public string description
		{
			get
			{
				return this.descriptionField;
			}
			set
			{
				this.descriptionField = value;
				base.RaisePropertyChanged("description");
			}
		}

		[XmlElement] //[XmlElement(Order=3)]
		public Key importmapid
		{
			get
			{
				return this.importmapidField;
			}
			set
			{
				this.importmapidField = value;
				base.RaisePropertyChanged("importmapid");
			}
		}

		[XmlElement] //[XmlElement(Order=4)]
		public Picklist importmaptype
		{
			get
			{
				return this.importmaptypeField;
			}
			set
			{
				this.importmaptypeField = value;
				base.RaisePropertyChanged("importmaptype");
			}
		}

		[XmlElement] //[XmlElement(Order=5)]
		public CrmBoolean isvalidforimport
		{
			get
			{
				return this.isvalidforimportField;
			}
			set
			{
				this.isvalidforimportField = value;
				base.RaisePropertyChanged("isvalidforimport");
			}
		}

		[XmlElement] //[XmlElement(Order=6)]
		public CrmBoolean iswizardcreated
		{
			get
			{
				return this.iswizardcreatedField;
			}
			set
			{
				this.iswizardcreatedField = value;
				base.RaisePropertyChanged("iswizardcreated");
			}
		}

		[XmlElement] //[XmlElement(Order=7)]
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

		[XmlElement] //[XmlElement(Order=8)]
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

		[XmlElement] //[XmlElement(Order=9)]
		public string name
		{
			get
			{
				return this.nameField;
			}
			set
			{
				this.nameField = value;
				base.RaisePropertyChanged("name");
			}
		}

		[XmlElement] //[XmlElement(Order=10)]
		public Owner ownerid
		{
			get
			{
				return this.owneridField;
			}
			set
			{
				this.owneridField = value;
				base.RaisePropertyChanged("ownerid");
			}
		}

		[XmlElement] //[XmlElement(Order=11)]
		public Lookup owningbusinessunit
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

		[XmlElement] //[XmlElement(Order=12)]
		public string source
		{
			get
			{
				return this.sourceField;
			}
			set
			{
				this.sourceField = value;
				base.RaisePropertyChanged("source");
			}
		}

		[XmlElement] //[XmlElement(Order=13)]
		public string sourceuseridentifierforsourcecrmuserlink
		{
			get
			{
				return this.sourceuseridentifierforsourcecrmuserlinkField;
			}
			set
			{
				this.sourceuseridentifierforsourcecrmuserlinkField = value;
				base.RaisePropertyChanged("sourceuseridentifierforsourcecrmuserlink");
			}
		}

		[XmlElement] //[XmlElement(Order=14)]
		public string sourceuseridentifierforsourcedatasourceuserlink
		{
			get
			{
				return this.sourceuseridentifierforsourcedatasourceuserlinkField;
			}
			set
			{
				this.sourceuseridentifierforsourcedatasourceuserlinkField = value;
				base.RaisePropertyChanged("sourceuseridentifierforsourcedatasourceuserlink");
			}
		}

		[XmlElement] //[XmlElement(Order=15)]
		public ImportMapStateInfo statecode
		{
			get
			{
				return this.statecodeField;
			}
			set
			{
				this.statecodeField = value;
				base.RaisePropertyChanged("statecode");
			}
		}

		[XmlElement] //[XmlElement(Order=16)]
		public Status statuscode
		{
			get
			{
				return this.statuscodeField;
			}
			set
			{
				this.statuscodeField = value;
				base.RaisePropertyChanged("statuscode");
			}
		}

		[XmlElement] //[XmlElement(Order=17)]
		public Picklist targetentity
		{
			get
			{
				return this.targetentityField;
			}
			set
			{
				this.targetentityField = value;
				base.RaisePropertyChanged("targetentity");
			}
		}

		[XmlElement] //[XmlElement(Order=18)]
		public string targetuseridentifierforsourcecrmuserlink
		{
			get
			{
				return this.targetuseridentifierforsourcecrmuserlinkField;
			}
			set
			{
				this.targetuseridentifierforsourcecrmuserlinkField = value;
				base.RaisePropertyChanged("targetuseridentifierforsourcecrmuserlink");
			}
		}

		public importmap()
		{
		}
	}
}