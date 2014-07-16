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
	public class TargetCreateSgt_fac_buma_bijdrage_amusementsmuziek : TargetCreate
	{
		private sgt_fac_buma_bijdrage_amusementsmuziek sgt_fac_buma_bijdrage_amusementsmuziekField;

		[XmlElement] //[XmlElement(Order=0)]
		public sgt_fac_buma_bijdrage_amusementsmuziek Sgt_fac_buma_bijdrage_amusementsmuziek
		{
			get
			{
				return this.sgt_fac_buma_bijdrage_amusementsmuziekField;
			}
			set
			{
				this.sgt_fac_buma_bijdrage_amusementsmuziekField = value;
				base.RaisePropertyChanged("Sgt_fac_buma_bijdrage_amusementsmuziek");
			}
		}

		public TargetCreateSgt_fac_buma_bijdrage_amusementsmuziek()
		{
		}
	}
}