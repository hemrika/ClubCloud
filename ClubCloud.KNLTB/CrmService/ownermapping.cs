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
	public class ownermapping : BusinessEntity
	{
		private Lookup createdbyField;

		private CrmDateTime createdonField;

		private Lookup importmapidField;

		private Lookup modifiedbyField;

		private CrmDateTime modifiedonField;

		private Key ownermappingidField;

		private Picklist processcodeField;

		private string sourcesystemusernameField;

		private string sourceuservalueforsourcecrmuserlinkField;

		private OwnerMappingStateInfo statecodeField;

		private Status statuscodeField;

		private string targetsystemuserdomainnameField;

		private Lookup targetsystemuseridField;

		private string targetuservalueforsourcecrmuserlinkField;

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
		public Lookup importmapid
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
		public Key ownermappingid
		{
			get
			{
				return this.ownermappingidField;
			}
			set
			{
				this.ownermappingidField = value;
				base.RaisePropertyChanged("ownermappingid");
			}
		}

		[XmlElement] //[XmlElement(Order=6)]
		public Picklist processcode
		{
			get
			{
				return this.processcodeField;
			}
			set
			{
				this.processcodeField = value;
				base.RaisePropertyChanged("processcode");
			}
		}

		[XmlElement] //[XmlElement(Order=7)]
		public string sourcesystemusername
		{
			get
			{
				return this.sourcesystemusernameField;
			}
			set
			{
				this.sourcesystemusernameField = value;
				base.RaisePropertyChanged("sourcesystemusername");
			}
		}

		[XmlElement] //[XmlElement(Order=8)]
		public string sourceuservalueforsourcecrmuserlink
		{
			get
			{
				return this.sourceuservalueforsourcecrmuserlinkField;
			}
			set
			{
				this.sourceuservalueforsourcecrmuserlinkField = value;
				base.RaisePropertyChanged("sourceuservalueforsourcecrmuserlink");
			}
		}

		[XmlElement] //[XmlElement(Order=9)]
		public OwnerMappingStateInfo statecode
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

		[XmlElement] //[XmlElement(Order=10)]
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

		[XmlElement] //[XmlElement(Order=11)]
		public string targetsystemuserdomainname
		{
			get
			{
				return this.targetsystemuserdomainnameField;
			}
			set
			{
				this.targetsystemuserdomainnameField = value;
				base.RaisePropertyChanged("targetsystemuserdomainname");
			}
		}

		[XmlElement] //[XmlElement(Order=12)]
		public Lookup targetsystemuserid
		{
			get
			{
				return this.targetsystemuseridField;
			}
			set
			{
				this.targetsystemuseridField = value;
				base.RaisePropertyChanged("targetsystemuserid");
			}
		}

		[XmlElement] //[XmlElement(Order=13)]
		public string targetuservalueforsourcecrmuserlink
		{
			get
			{
				return this.targetuservalueforsourcecrmuserlinkField;
			}
			set
			{
				this.targetuservalueforsourcecrmuserlinkField = value;
				base.RaisePropertyChanged("targetuservalueforsourcecrmuserlink");
			}
		}

		public ownermapping()
		{
		}
	}
}