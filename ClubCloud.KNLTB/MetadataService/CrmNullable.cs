using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.MetadataService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlInclude(typeof(CrmAttributeRequiredLevel)), XmlInclude(typeof(CrmPrivilegeType)), XmlInclude(typeof(CrmAttributeType)), XmlInclude(typeof(CrmDisplayMasks)), XmlInclude(typeof(CrmDateTimeFormat)), XmlInclude(typeof(CrmImeMode)), XmlInclude(typeof(CrmStringFormat)), XmlInclude(typeof(CrmIntegerFormat)), XmlInclude(typeof(CrmAssociatedMenuBehavior)), XmlInclude(typeof(CrmAssociatedMenuGroup)), XmlInclude(typeof(CrmCascadeType)), XmlInclude(typeof(CrmOwnershipTypes)), XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public abstract class CrmNullable
	{
		private bool isNullField;
		private bool isNullFieldSpecified;
		public bool IsNull
		{
			get
			{
				return this.isNullField;
			}
			set
			{
				this.isNullField = value;
			}
		}
		[XmlIgnore]
		public bool IsNullSpecified
		{
			get
			{
				return this.isNullFieldSpecified;
			}
			set
			{
				this.isNullFieldSpecified = value;
			}
		}
	}
}
