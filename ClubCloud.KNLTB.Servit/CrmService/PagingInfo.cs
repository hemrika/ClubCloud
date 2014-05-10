using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2006/Query")]
	[Serializable]
	public class PagingInfo
	{
		private int pageNumberField;
		private int countField;
		private string pagingCookieField;
		public int PageNumber
		{
			get
			{
				return this.pageNumberField;
			}
			set
			{
				this.pageNumberField = value;
			}
		}
		public int Count
		{
			get
			{
				return this.countField;
			}
			set
			{
				this.countField = value;
			}
		}
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
	}
}
