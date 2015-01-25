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
	public class SetStateSgt_alg_logboek_fact_import_betalingenRequest : Request
	{
		private Guid entityIdField;

		private ClubCloud.KNLTB.ServIt.CrmService.Sgt_alg_logboek_fact_import_betalingenState sgt_alg_logboek_fact_import_betalingenStateField;

		private int sgt_alg_logboek_fact_import_betalingenStatusField;

		[XmlElement] //[XmlElement(Order=0)]
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

		[XmlElement] //[XmlElement(Order=1)]
		public ClubCloud.KNLTB.ServIt.CrmService.Sgt_alg_logboek_fact_import_betalingenState Sgt_alg_logboek_fact_import_betalingenState
		{
			get
			{
				return this.sgt_alg_logboek_fact_import_betalingenStateField;
			}
			set
			{
				this.sgt_alg_logboek_fact_import_betalingenStateField = value;
				base.RaisePropertyChanged("Sgt_alg_logboek_fact_import_betalingenState");
			}
		}

		[XmlElement] //[XmlElement(Order=2)]
		public int Sgt_alg_logboek_fact_import_betalingenStatus
		{
			get
			{
				return this.sgt_alg_logboek_fact_import_betalingenStatusField;
			}
			set
			{
				this.sgt_alg_logboek_fact_import_betalingenStatusField = value;
				base.RaisePropertyChanged("Sgt_alg_logboek_fact_import_betalingenStatus");
			}
		}

		public SetStateSgt_alg_logboek_fact_import_betalingenRequest()
		{
		}
	}
}