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

		[XmlElement] //[XmlElement(Order=0)]
		public Lookup activityid
		{
			get
			{
				return this.activityidField;
			}
			set
			{
				this.activityidField = value;
				base.RaisePropertyChanged("activityid");
			}
		}

		[XmlElement] //[XmlElement(Order=1)]
		public Key activitymimeattachmentid
		{
			get
			{
				return this.activitymimeattachmentidField;
			}
			set
			{
				this.activitymimeattachmentidField = value;
				base.RaisePropertyChanged("activitymimeattachmentid");
			}
		}

		[XmlElement] //[XmlElement(Order=2)]
		public CrmNumber attachmentnumber
		{
			get
			{
				return this.attachmentnumberField;
			}
			set
			{
				this.attachmentnumberField = value;
				base.RaisePropertyChanged("attachmentnumber");
			}
		}

		[XmlElement] //[XmlElement(Order=3)]
		public string body
		{
			get
			{
				return this.bodyField;
			}
			set
			{
				this.bodyField = value;
				base.RaisePropertyChanged("body");
			}
		}

		[XmlElement] //[XmlElement(Order=4)]
		public string filename
		{
			get
			{
				return this.filenameField;
			}
			set
			{
				this.filenameField = value;
				base.RaisePropertyChanged("filename");
			}
		}

		[XmlElement] //[XmlElement(Order=5)]
		public CrmNumber filesize
		{
			get
			{
				return this.filesizeField;
			}
			set
			{
				this.filesizeField = value;
				base.RaisePropertyChanged("filesize");
			}
		}

		[XmlElement] //[XmlElement(Order=6)]
		public string mimetype
		{
			get
			{
				return this.mimetypeField;
			}
			set
			{
				this.mimetypeField = value;
				base.RaisePropertyChanged("mimetype");
			}
		}

		[XmlElement] //[XmlElement(Order=7)]
		public string subject
		{
			get
			{
				return this.subjectField;
			}
			set
			{
				this.subjectField = value;
				base.RaisePropertyChanged("subject");
			}
		}

		public activitymimeattachment()
		{
		}
	}
}