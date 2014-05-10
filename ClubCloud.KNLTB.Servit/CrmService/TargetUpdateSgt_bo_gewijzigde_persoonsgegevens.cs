using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class TargetUpdateSgt_bo_gewijzigde_persoonsgegevens : TargetUpdate
	{
		private sgt_bo_gewijzigde_persoonsgegevens sgt_bo_gewijzigde_persoonsgegevensField;
		public sgt_bo_gewijzigde_persoonsgegevens Sgt_bo_gewijzigde_persoonsgegevens
		{
			get
			{
				return this.sgt_bo_gewijzigde_persoonsgegevensField;
			}
			set
			{
				this.sgt_bo_gewijzigde_persoonsgegevensField = value;
			}
		}
	}
}
