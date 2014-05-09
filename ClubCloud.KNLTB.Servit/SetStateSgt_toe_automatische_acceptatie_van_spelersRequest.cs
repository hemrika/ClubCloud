using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateSgt_toe_automatische_acceptatie_van_spelersRequest : Request
	{
		private Guid entityIdField;
		private Sgt_toe_automatische_acceptatie_van_spelersState sgt_toe_automatische_acceptatie_van_spelersStateField;
		private int sgt_toe_automatische_acceptatie_van_spelersStatusField;
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
		public Sgt_toe_automatische_acceptatie_van_spelersState Sgt_toe_automatische_acceptatie_van_spelersState
		{
			get
			{
				return this.sgt_toe_automatische_acceptatie_van_spelersStateField;
			}
			set
			{
				this.sgt_toe_automatische_acceptatie_van_spelersStateField = value;
				base.RaisePropertyChanged("Sgt_toe_automatische_acceptatie_van_spelersState");
			}
		}
		[XmlElement(Order = 2)]
		public int Sgt_toe_automatische_acceptatie_van_spelersStatus
		{
			get
			{
				return this.sgt_toe_automatische_acceptatie_van_spelersStatusField;
			}
			set
			{
				this.sgt_toe_automatische_acceptatie_van_spelersStatusField = value;
				base.RaisePropertyChanged("Sgt_toe_automatische_acceptatie_van_spelersStatus");
			}
		}
	}
}
