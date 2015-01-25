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
	public class TargetUpdateSgt_fac_buma_bijdrage_achtergrondmuziek : TargetUpdate
	{
		private sgt_fac_buma_bijdrage_achtergrondmuziek sgt_fac_buma_bijdrage_achtergrondmuziekField;

		[XmlElement] //[XmlElement(Order=0)]
		public sgt_fac_buma_bijdrage_achtergrondmuziek Sgt_fac_buma_bijdrage_achtergrondmuziek
		{
			get
			{
				return this.sgt_fac_buma_bijdrage_achtergrondmuziekField;
			}
			set
			{
				this.sgt_fac_buma_bijdrage_achtergrondmuziekField = value;
				base.RaisePropertyChanged("Sgt_fac_buma_bijdrage_achtergrondmuziek");
			}
		}

		public TargetUpdateSgt_fac_buma_bijdrage_achtergrondmuziek()
		{
		}
	}
}