using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class TargetUpdateSgt_rol_verbergen_entiteit : TargetUpdate
	{
		private sgt_rol_verbergen_entiteit sgt_rol_verbergen_entiteitField;
		[XmlElement(Order = 0)]
		public sgt_rol_verbergen_entiteit Sgt_rol_verbergen_entiteit
		{
			get
			{
				return this.sgt_rol_verbergen_entiteitField;
			}
			set
			{
				this.sgt_rol_verbergen_entiteitField = value;
				base.RaisePropertyChanged("Sgt_rol_verbergen_entiteit");
			}
		}
	}
}
