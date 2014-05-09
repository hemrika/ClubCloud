using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class RetrieveDuplicatesRequest : Request
	{
		private BusinessEntity businessEntityField;
		private string matchingEntityNameField;
		private PagingInfo pagingInfoField;
		private bool returnDynamicEntitiesField;
		[XmlElement(Order = 0)]
		public BusinessEntity BusinessEntity
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
		[XmlElement(Order = 1)]
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
		[XmlElement(Order = 2)]
		public PagingInfo PagingInfo
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
	}
}
