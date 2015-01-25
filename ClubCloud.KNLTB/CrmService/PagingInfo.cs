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
	[XmlType(Namespace="http://schemas.microsoft.com/crm/2006/Query")]
	public class PagingInfo : INotifyPropertyChanged
	{
		private int pageNumberField;

		private int countField;

		private string pagingCookieField;

		[XmlElement] //[XmlElement(Order=1)]
		public int Count
		{
			get
			{
				return this.countField;
			}
			set
			{
				this.countField = value;
				this.RaisePropertyChanged("Count");
			}
		}

		[XmlElement] //[XmlElement(Order=0)]
		public int PageNumber
		{
			get
			{
				return this.pageNumberField;
			}
			set
			{
				this.pageNumberField = value;
				this.RaisePropertyChanged("PageNumber");
			}
		}

		[XmlElement] //[XmlElement(Order=2)]
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

		public PagingInfo()
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