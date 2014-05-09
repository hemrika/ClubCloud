using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace ClubCloud.KNLTB.ServIt
{
    public delegate void DeleteCompletedEventHandler(object sender, AsyncCompletedEventArgs e);
    public delegate void ExecuteCompletedEventHandler(object sender, ExecuteCompletedEventArgs e);
    public delegate void FetchCompletedEventHandler(object sender, FetchCompletedEventArgs e);
    public delegate void RetrieveCompletedEventHandler(object sender, RetrieveCompletedEventArgs e);
    public delegate void RetrieveMultipleCompletedEventHandler(object sender, RetrieveMultipleCompletedEventArgs e);
    public delegate void UpdateCompletedEventHandler(object sender, AsyncCompletedEventArgs e);
    public delegate void CreateCompletedEventHandler(object sender, CreateCompletedEventArgs e);

    public class CreateCompletedEventArgs : AsyncCompletedEventArgs
    {
        private object[] results;

        public Guid Result
        {
            get
            {
                base.RaiseExceptionIfNecessary();
                return (Guid)this.results[0];
            }
        }

        internal CreateCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState)
            : base(exception, cancelled, userState)
        {
            this.results = results;
        }
    }

    public class ExecuteCompletedEventArgs : AsyncCompletedEventArgs
    {
        private object[] results;

        public MetadataServiceResponse Result
        {
            get
            {
                base.RaiseExceptionIfNecessary();
                return (MetadataServiceResponse)this.results[0];
            }
        }

        internal ExecuteCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState)
            : base(exception, cancelled, userState)
        {
            this.results = results;
        }
    }

    public class FetchCompletedEventArgs : AsyncCompletedEventArgs
    {
        private object[] results;

        public string Result
        {
            get
            {
                base.RaiseExceptionIfNecessary();
                return (string)this.results[0];
            }
        }

        internal FetchCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState)
            : base(exception, cancelled, userState)
        {
            this.results = results;
        }
    }

    public class RetrieveCompletedEventArgs : AsyncCompletedEventArgs
    {
        private object[] results;

        public BusinessEntity Result
        {
            get
            {
                base.RaiseExceptionIfNecessary();
                return (BusinessEntity)this.results[0];
            }
        }

        internal RetrieveCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState)
            : base(exception, cancelled, userState)
        {
            this.results = results;
        }
    }

    public class RetrieveMultipleCompletedEventArgs : AsyncCompletedEventArgs
    {
        private object[] results;

        public BusinessEntityCollection Result
        {
            get
            {
                base.RaiseExceptionIfNecessary();
                return (BusinessEntityCollection)this.results[0];
            }
        }

        internal RetrieveMultipleCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState)
            : base(exception, cancelled, userState)
        {
            this.results = results;
        }
    }

    [Serializable]
    /*
    [XmlInclude(typeof(CanBeReferencedResponse))]
    [XmlInclude(typeof(CanBeReferencingResponse))]
    [XmlInclude(typeof(CanManyToManyResponse))]
    [XmlInclude(typeof(CreateAttributeResponse))]
    [XmlInclude(typeof(CreateEntityResponse))]
    [XmlInclude(typeof(CreateManyToManyResponse))]
    [XmlInclude(typeof(CreateOneToManyResponse))]
    [XmlInclude(typeof(DeleteAttributeResponse))]
    [XmlInclude(typeof(DeleteEntityResponse))]
    [XmlInclude(typeof(DeleteOptionValueResponse))]
    [XmlInclude(typeof(DeleteRelationshipResponse))]
    [XmlInclude(typeof(GetValidManyToManyResponse))]
    [XmlInclude(typeof(GetValidReferencedEntitiesResponse))]
    [XmlInclude(typeof(GetValidReferencingEntitiesResponse))]
    [XmlInclude(typeof(InsertOptionValueResponse))]
    [XmlInclude(typeof(InsertStatusValueResponse))]
    [XmlInclude(typeof(OrderOptionResponse))]
    [XmlInclude(typeof(RetrieveAllEntitiesResponse))]
    [XmlInclude(typeof(RetrieveAttributeResponse))]
    [XmlInclude(typeof(RetrieveEntityResponse))]
    [XmlInclude(typeof(RetrieveRelationshipResponse))]
    [XmlInclude(typeof(RetrieveTimestampResponse))]
    [XmlInclude(typeof(UpdateAttributeResponse))]
    [XmlInclude(typeof(UpdateEntityResponse))]
    [XmlInclude(typeof(UpdateOptionValueResponse))]
    [XmlInclude(typeof(UpdateRelationshipResponse))]
    */
    [XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
    public abstract class MetadataServiceResponse
    {
        protected MetadataServiceResponse()
        {
        }
    }
}
