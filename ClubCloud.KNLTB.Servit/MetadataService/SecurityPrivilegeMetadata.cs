using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.MetadataService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SecurityPrivilegeMetadata
	{
		private string nameField;
		private Key privilegeIdField;
		private CrmPrivilegeType privilegeTypeField;
		private bool canBeBasicField;
		private bool canBeLocalField;
		private bool canBeDeepField;
		private bool canBeGlobalField;
		public string Name
		{
			get
			{
				return this.nameField;
			}
			set
			{
				this.nameField = value;
			}
		}
		public Key PrivilegeId
		{
			get
			{
				return this.privilegeIdField;
			}
			set
			{
				this.privilegeIdField = value;
			}
		}
		public CrmPrivilegeType PrivilegeType
		{
			get
			{
				return this.privilegeTypeField;
			}
			set
			{
				this.privilegeTypeField = value;
			}
		}
		public bool CanBeBasic
		{
			get
			{
				return this.canBeBasicField;
			}
			set
			{
				this.canBeBasicField = value;
			}
		}
		public bool CanBeLocal
		{
			get
			{
				return this.canBeLocalField;
			}
			set
			{
				this.canBeLocalField = value;
			}
		}
		public bool CanBeDeep
		{
			get
			{
				return this.canBeDeepField;
			}
			set
			{
				this.canBeDeepField = value;
			}
		}
		public bool CanBeGlobal
		{
			get
			{
				return this.canBeGlobalField;
			}
			set
			{
				this.canBeGlobalField = value;
			}
		}
	}
}
