using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class TargetUpdateSgt_pbmutatietoernooidefinitieonderdeel : TargetUpdate
	{
		private sgt_pbmutatietoernooidefinitieonderdeel sgt_pbmutatietoernooidefinitieonderdeelField;
		public sgt_pbmutatietoernooidefinitieonderdeel Sgt_pbmutatietoernooidefinitieonderdeel
		{
			get
			{
				return this.sgt_pbmutatietoernooidefinitieonderdeelField;
			}
			set
			{
				this.sgt_pbmutatietoernooidefinitieonderdeelField = value;
			}
		}
	}
}
