using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Web.Services.Protocols;
using System.Xml;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.MetadataService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlRoot(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices", IsNullable = false), XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/CoreTypes")]
	[Serializable]
	public class CallerOriginToken : SoapHeader
	{
		private CallerOrigin callerOriginField;
		private XmlAttribute[] anyAttrField;
		public CallerOrigin CallerOrigin
		{
			get
			{
				return this.callerOriginField;
			}
			set
			{
				this.callerOriginField = value;
			}
		}
		[XmlAnyAttribute]
		public XmlAttribute[] AnyAttr
		{
			get
			{
				return this.anyAttrField;
			}
			set
			{
				this.anyAttrField = value;
			}
		}
	}
}
