using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateSgt_alg_virtueelteamRequest : Request
	{
		private Guid entityIdField;
		private Sgt_alg_virtueelteamState sgt_alg_virtueelteamStateField;
		private int sgt_alg_virtueelteamStatusField;
		[XmlElement(Order = 0)]
		public Guid EntityId
		{
			get
			{
				return this.entityIdField;
			}
			set
			{
				this.entityIdField = value;
				base.RaisePropertyChanged("EntityId");
			}
		}
		[XmlElement(Order = 1)]
		public Sgt_alg_virtueelteamState Sgt_alg_virtueelteamState
		{
			get
			{
				return this.sgt_alg_virtueelteamStateField;
			}
			set
			{
				this.sgt_alg_virtueelteamStateField = value;
				base.RaisePropertyChanged("Sgt_alg_virtueelteamState");
			}
		}
		[XmlElement(Order = 2)]
		public int Sgt_alg_virtueelteamStatus
		{
			get
			{
				return this.sgt_alg_virtueelteamStatusField;
			}
			set
			{
				this.sgt_alg_virtueelteamStatusField = value;
				base.RaisePropertyChanged("Sgt_alg_virtueelteamStatus");
			}
		}
	}
}
