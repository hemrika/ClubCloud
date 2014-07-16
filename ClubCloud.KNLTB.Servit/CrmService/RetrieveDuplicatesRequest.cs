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
	public class RetrieveDuplicatesRequest : Request
	{
		private ClubCloud.KNLTB.ServIt.CrmService.BusinessEntity businessEntityField;

		private string matchingEntityNameField;

		private ClubCloud.KNLTB.ServIt.CrmService.PagingInfo pagingInfoField;

		private bool returnDynamicEntitiesField;

		[XmlElement] //[XmlElement(Order=0)]
		public ClubCloud.KNLTB.ServIt.CrmService.BusinessEntity BusinessEntity
		{
			get
			{
				return this.businessEntityField;
			}
			set
			{
				this.businessEntityField = value;
				base.RaisePropertyChanged("BusinessEntity");
			}
		}

		[XmlElement] //[XmlElement(Order=1)]
		public string MatchingEntityName
		{
			get
			{
				return this.matchingEntityNameField;
			}
			set
			{
				this.matchingEntityNameField = value;
				base.RaisePropertyChanged("MatchingEntityName");
			}
		}

		[XmlElement] //[XmlElement(Order=2)]
		public ClubCloud.KNLTB.ServIt.CrmService.PagingInfo PagingInfo
		{
			get
			{
				return this.pagingInfoField;
			}
			set
			{
				this.pagingInfoField = value;
				base.RaisePropertyChanged("PagingInfo");
			}
		}

		[XmlAttribute]
		public bool ReturnDynamicEntities
		{
			get
			{
				return this.returnDynamicEntitiesField;
			}
			set
			{
				this.returnDynamicEntitiesField = value;
				base.RaisePropertyChanged("ReturnDynamicEntities");
			}
		}

		public RetrieveDuplicatesRequest()
		{
		}
	}
}