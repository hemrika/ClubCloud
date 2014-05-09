using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class TargetCompoundDuplicateRule : TargetCompound
	{
		private duplicaterule duplicateRuleField;
		private duplicaterulecondition[] duplicateRuleConditionsField;
		[XmlElement(Order = 0)]
		public duplicaterule DuplicateRule
		{
			get
			{
				return this.duplicateRuleField;
			}
			set
			{
				this.duplicateRuleField = value;
				base.RaisePropertyChanged("DuplicateRule");
			}
		}
		[XmlArray(Order = 1), XmlArrayItem(IsNullable = false)]
		public duplicaterulecondition[] DuplicateRuleConditions
		{
			get
			{
				return this.duplicateRuleConditionsField;
			}
			set
			{
				this.duplicateRuleConditionsField = value;
				base.RaisePropertyChanged("DuplicateRuleConditions");
			}
		}
	}
}
