using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.MetadataService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlInclude(typeof(RetrieveRelationshipRequest)), XmlInclude(typeof(CreateManyToManyRequest)), XmlInclude(typeof(UpdateOptionValueRequest)), XmlInclude(typeof(DeleteOptionValueRequest)), XmlInclude(typeof(OrderOptionRequest)), XmlInclude(typeof(RetrieveAllEntitiesRequest)), XmlInclude(typeof(InsertStatusValueRequest)), XmlInclude(typeof(CanBeReferencedRequest)), XmlInclude(typeof(CanBeReferencingRequest)), XmlInclude(typeof(GetValidReferencingEntitiesRequest)), XmlInclude(typeof(GetValidReferencedEntitiesRequest)), XmlInclude(typeof(GetValidManyToManyRequest)), XmlInclude(typeof(RetrieveTimestampRequest)), XmlInclude(typeof(UpdateRelationshipRequest)), XmlInclude(typeof(DeleteRelationshipRequest)), XmlInclude(typeof(InsertOptionValueRequest)), XmlInclude(typeof(CanManyToManyRequest)), XmlInclude(typeof(CreateEntityRequest)), XmlInclude(typeof(UpdateEntityRequest)), XmlInclude(typeof(DeleteEntityRequest)), XmlInclude(typeof(RetrieveEntityRequest)), XmlInclude(typeof(CreateAttributeRequest)), XmlInclude(typeof(UpdateAttributeRequest)), XmlInclude(typeof(DeleteAttributeRequest)), XmlInclude(typeof(RetrieveAttributeRequest)), XmlInclude(typeof(CreateOneToManyRequest)), XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public abstract class MetadataServiceRequest
	{
	}
}
