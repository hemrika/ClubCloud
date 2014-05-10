using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class RouteRequest : Request
	{
		private TargetQueued targetField;
		private Guid sourceQueueIdField;
		private RouteType routeTypeField;
		private Guid endpointIdField;
		public TargetQueued Target
		{
			get
			{
				return this.targetField;
			}
			set
			{
				this.targetField = value;
			}
		}
		public Guid SourceQueueId
		{
			get
			{
				return this.sourceQueueIdField;
			}
			set
			{
				this.sourceQueueIdField = value;
			}
		}
		public RouteType RouteType
		{
			get
			{
				return this.routeTypeField;
			}
			set
			{
				this.routeTypeField = value;
			}
		}
		public Guid EndpointId
		{
			get
			{
				return this.endpointIdField;
			}
			set
			{
				this.endpointIdField = value;
			}
		}
	}
}
