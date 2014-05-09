using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class MergeRequest : Request
	{
		private TargetMerge targetField;
		private Guid subordinateIdField;
		private BusinessEntity updateContentField;
		private bool performParentingChecksField;
		[XmlElement(Order = 0)]
		public TargetMerge Target
		{
			get
			{
				return this.targetField;
			}
			set
			{
				this.targetField = value;
				base.RaisePropertyChanged("Target");
			}
		}
		[XmlElement(Order = 1)]
		public Guid SubordinateId
		{
			get
			{
				return this.subordinateIdField;
			}
			set
			{
				this.subordinateIdField = value;
				base.RaisePropertyChanged("SubordinateId");
			}
		}
		[XmlElement(Order = 2)]
		public BusinessEntity UpdateContent
		{
			get
			{
				return this.updateContentField;
			}
			set
			{
				this.updateContentField = value;
				base.RaisePropertyChanged("UpdateContent");
			}
		}
		[XmlElement(Order = 3)]
		public bool PerformParentingChecks
		{
			get
			{
				return this.performParentingChecksField;
			}
			set
			{
				this.performParentingChecksField = value;
				base.RaisePropertyChanged("PerformParentingChecks");
			}
		}
	}
}
