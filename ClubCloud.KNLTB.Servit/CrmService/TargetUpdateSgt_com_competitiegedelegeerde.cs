using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class TargetUpdateSgt_com_competitiegedelegeerde : TargetUpdate
	{
		private sgt_com_competitiegedelegeerde sgt_com_competitiegedelegeerdeField;
		public sgt_com_competitiegedelegeerde Sgt_com_competitiegedelegeerde
		{
			get
			{
				return this.sgt_com_competitiegedelegeerdeField;
			}
			set
			{
				this.sgt_com_competitiegedelegeerdeField = value;
			}
		}
	}
}
