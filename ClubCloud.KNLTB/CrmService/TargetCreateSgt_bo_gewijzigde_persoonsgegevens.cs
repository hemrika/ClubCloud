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
	public class TargetCreateSgt_bo_gewijzigde_persoonsgegevens : TargetCreate
	{
		private sgt_bo_gewijzigde_persoonsgegevens sgt_bo_gewijzigde_persoonsgegevensField;

		[XmlElement] //[XmlElement(Order=0)]
		public sgt_bo_gewijzigde_persoonsgegevens Sgt_bo_gewijzigde_persoonsgegevens
		{
			get
			{
				return this.sgt_bo_gewijzigde_persoonsgegevensField;
			}
			set
			{
				this.sgt_bo_gewijzigde_persoonsgegevensField = value;
				base.RaisePropertyChanged("Sgt_bo_gewijzigde_persoonsgegevens");
			}
		}

		public TargetCreateSgt_bo_gewijzigde_persoonsgegevens()
		{
		}
	}
}