using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2006/WebServices")]
	[Serializable]
	public class BusinessEntityCollection
	{
		private BusinessEntity[] businessEntitiesField;
		private string entityNameField;
		private bool moreRecordsField;
		private string pagingCookieField;
		private string versionField;
		[XmlArrayItem(IsNullable = false)]
		public BusinessEntity[] BusinessEntities
		{
			get
			{
				return this.businessEntitiesField;
			}
			set
			{
				this.businessEntitiesField = value;
			}
		}
		[XmlAttribute]
		public string EntityName
		{
			get
			{
				return this.entityNameField;
			}
			set
			{
				this.entityNameField = value;
			}
		}
		[XmlAttribute]
		public bool MoreRecords
		{
			get
			{
				return this.moreRecordsField;
			}
			set
			{
				this.moreRecordsField = value;
			}
		}
		[XmlAttribute]
		public string PagingCookie
		{
			get
			{
				return this.pagingCookieField;
			}
			set
			{
				this.pagingCookieField = value;
			}
		}
		[XmlAttribute]
		public string Version
		{
			get
			{
				return this.versionField;
			}
			set
			{
				this.versionField = value;
			}
		}
	}
}
