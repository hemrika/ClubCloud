using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class activitymimeattachment : BusinessEntity
	{
		private Lookup activityidField;
		private Key activitymimeattachmentidField;
		private CrmNumber attachmentnumberField;
		private string bodyField;
		private string filenameField;
		private CrmNumber filesizeField;
		private string mimetypeField;
		private string subjectField;
		public Lookup activityid
		{
			get
			{
				return this.activityidField;
			}
			set
			{
				this.activityidField = value;
			}
		}
		public Key activitymimeattachmentid
		{
			get
			{
				return this.activitymimeattachmentidField;
			}
			set
			{
				this.activitymimeattachmentidField = value;
			}
		}
		public CrmNumber attachmentnumber
		{
			get
			{
				return this.attachmentnumberField;
			}
			set
			{
				this.attachmentnumberField = value;
			}
		}
		public string body
		{
			get
			{
				return this.bodyField;
			}
			set
			{
				this.bodyField = value;
			}
		}
		public string filename
		{
			get
			{
				return this.filenameField;
			}
			set
			{
				this.filenameField = value;
			}
		}
		public CrmNumber filesize
		{
			get
			{
				return this.filesizeField;
			}
			set
			{
				this.filesizeField = value;
			}
		}
		public string mimetype
		{
			get
			{
				return this.mimetypeField;
			}
			set
			{
				this.mimetypeField = value;
			}
		}
		public string subject
		{
			get
			{
				return this.subjectField;
			}
			set
			{
				this.subjectField = value;
			}
		}
	}
}
