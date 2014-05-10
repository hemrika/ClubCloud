using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class TargetUpdateSgt_fac_buma_bijdrage_achtergrondmuziek : TargetUpdate
	{
		private sgt_fac_buma_bijdrage_achtergrondmuziek sgt_fac_buma_bijdrage_achtergrondmuziekField;
		public sgt_fac_buma_bijdrage_achtergrondmuziek Sgt_fac_buma_bijdrage_achtergrondmuziek
		{
			get
			{
				return this.sgt_fac_buma_bijdrage_achtergrondmuziekField;
			}
			set
			{
				this.sgt_fac_buma_bijdrage_achtergrondmuziekField = value;
			}
		}
	}
}
