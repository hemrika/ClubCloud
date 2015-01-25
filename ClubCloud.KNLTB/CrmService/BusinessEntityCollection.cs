using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Threading;
using System.Xml.Serialization;

namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[GeneratedCode("System.Xml", "4.0.30319.33440")]
	[Serializable]
	[XmlType(Namespace="http://schemas.microsoft.com/crm/2006/WebServices")]
	public class BusinessEntityCollection : INotifyPropertyChanged
	{
		private BusinessEntity[] businessEntitiesField;

		private string entityNameField;

		private bool moreRecordsField;

		private string pagingCookieField;

		private string versionField;

		[XmlArray] //[XmlArray(Order=0)]
		[XmlArrayItem(IsNullable=false)]
		public BusinessEntity[] BusinessEntities
		{
			get
			{
				return this.businessEntitiesField;
			}
			set
			{
				this.businessEntitiesField = value;
				this.RaisePropertyChanged("BusinessEntities");
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
				this.RaisePropertyChanged("EntityName");
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
				this.RaisePropertyChanged("MoreRecords");
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
				this.RaisePropertyChanged("PagingCookie");
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
				this.RaisePropertyChanged("Version");
			}
		}

		public BusinessEntityCollection()
		{
		}

		protected void RaisePropertyChanged(string propertyName)
		{
			PropertyChangedEventHandler propertyChangedEventHandler = this.PropertyChanged;
			if (propertyChangedEventHandler != null)
			{
				propertyChangedEventHandler(this, new PropertyChangedEventArgs(propertyName));
			}
		}

		public event PropertyChangedEventHandler PropertyChanged;
	}
}