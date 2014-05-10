using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
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
		public Lookup importmapid
		{
			get
			{
				return this.importmapidField;
			}
			set
			{
				this.importmapidField = value;
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
		public Key ownermappingid
		{
			get
			{
				return this.ownermappingidField;
			}
			set
			{
				this.ownermappingidField = value;
			}
		}
		public Picklist processcode
		{
			get
			{
				return this.processcodeField;
			}
			set
			{
				this.processcodeField = value;
			}
		}
		public string sourcesystemusername
		{
			get
			{
				return this.sourcesystemusernameField;
			}
			set
			{
				this.sourcesystemusernameField = value;
			}
		}
		public string sourceuservalueforsourcecrmuserlink
		{
			get
			{
				return this.sourceuservalueforsourcecrmuserlinkField;
			}
			set
			{
				this.sourceuservalueforsourcecrmuserlinkField = value;
			}
		}
		public OwnerMappingStateInfo statecode
		{
			get
			{
				return this.statecodeField;
			}
			set
			{
				this.statecodeField = value;
			}
		}
		public Status statuscode
		{
			get
			{
				return this.statuscodeField;
			}
			set
			{
				this.statuscodeField = value;
			}
		}
		public string targetsystemuserdomainname
		{
			get
			{
				return this.targetsystemuserdomainnameField;
			}
			set
			{
				this.targetsystemuserdomainnameField = value;
			}
		}
		public Lookup targetsystemuserid
		{
			get
			{
				return this.targetsystemuseridField;
			}
			set
			{
				this.targetsystemuseridField = value;
			}
		}
		public string targetuservalueforsourcecrmuserlink
		{
			get
			{
				return this.targetuservalueforsourcecrmuserlinkField;
			}
			set
			{
				this.targetuservalueforsourcecrmuserlinkField = value;
			}
		}
	}
}
