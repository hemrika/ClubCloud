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
	public class TargetUpdateSgt_rol_verbergen_tabbladen_secties : TargetUpdate
	{
		private sgt_rol_verbergen_tabbladen_secties sgt_rol_verbergen_tabbladen_sectiesField;

		[XmlElement] //[XmlElement(Order=0)]
		public sgt_rol_verbergen_tabbladen_secties Sgt_rol_verbergen_tabbladen_secties
		{
			get
			{
				return this.sgt_rol_verbergen_tabbladen_sectiesField;
			}
			set
			{
				this.sgt_rol_verbergen_tabbladen_sectiesField = value;
				base.RaisePropertyChanged("Sgt_rol_verbergen_tabbladen_secties");
			}
		}

		public TargetUpdateSgt_rol_verbergen_tabbladen_secties()
		{
		}
	}
}