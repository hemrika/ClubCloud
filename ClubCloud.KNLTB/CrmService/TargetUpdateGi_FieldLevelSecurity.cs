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
	public class TargetUpdateGi_FieldLevelSecurity : TargetUpdate
	{
		private gi_fieldlevelsecurity gi_FieldLevelSecurityField;

		[XmlElement] //[XmlElement(Order=0)]
		public gi_fieldlevelsecurity Gi_FieldLevelSecurity
		{
			get
			{
				return this.gi_FieldLevelSecurityField;
			}
			set
			{
				this.gi_FieldLevelSecurityField = value;
				base.RaisePropertyChanged("Gi_FieldLevelSecurity");
			}
		}

		public TargetUpdateGi_FieldLevelSecurity()
		{
		}
	}
}