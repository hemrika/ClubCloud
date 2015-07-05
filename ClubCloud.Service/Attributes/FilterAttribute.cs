using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Description;
using System.ServiceModel.Dispatcher;
using System.Text;
using System.Threading.Tasks;

namespace ClubCloud.Service
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method | AttributeTargets.Interface, Inherited = true, AllowMultiple = false)]
    public abstract class FilterAttribute : Attribute, IDispatchMessageInspector,
        IClientMessageInspector, IEndpointBehavior, IServiceBehavior
    {
        private readonly static ConcurrentDictionary<Type, bool> _multiuseAttributeCache;

        private int _order = -1;

        public bool AllowMultiple
        {
            get
            {
                return FilterAttribute.AllowsMultiple(base.GetType());
            }
        }

        public int Order
        {
            get
            {
                return this._order;
            }
            set
            {
                if (value < -1)
                {
                    throw new ArgumentOutOfRangeException("value", "Order Out Of Range");
                }
                this._order = value;
            }
        }

        static FilterAttribute()
        {
            FilterAttribute._multiuseAttributeCache = new ConcurrentDictionary<Type, bool>();
        }

        protected FilterAttribute()
        {
        }

        private static bool AllowsMultiple(Type attributeType)
        {
            return FilterAttribute._multiuseAttributeCache.GetOrAdd(attributeType, (Type type) => type.GetCustomAttributes(typeof(AttributeUsageAttribute), true).Cast<AttributeUsageAttribute>().First<AttributeUsageAttribute>().AllowMultiple);
        }

        public object AfterReceiveRequest(ref System.ServiceModel.Channels.Message request, System.ServiceModel.IClientChannel channel, System.ServiceModel.InstanceContext instanceContext)
        {
            throw new NotImplementedException();
        }

        public void BeforeSendReply(ref System.ServiceModel.Channels.Message reply, object correlationState)
        {
            throw new NotImplementedException();
        }

        public void AfterReceiveReply(ref System.ServiceModel.Channels.Message reply, object correlationState)
        {
            throw new NotImplementedException();
        }

        public object BeforeSendRequest(ref System.ServiceModel.Channels.Message request, System.ServiceModel.IClientChannel channel)
        {   
            throw new NotImplementedException();
        }

        public void AddBindingParameters(ServiceEndpoint endpoint, System.ServiceModel.Channels.BindingParameterCollection bindingParameters)
        {
            throw new NotImplementedException();
        }

        public void ApplyClientBehavior(ServiceEndpoint endpoint, ClientRuntime clientRuntime)
        {
            throw new NotImplementedException();
        }

        public void ApplyDispatchBehavior(ServiceEndpoint endpoint, EndpointDispatcher endpointDispatcher)
        {
            throw new NotImplementedException();
        }

        public void Validate(ServiceEndpoint endpoint)
        {
            throw new NotImplementedException();
        }

        public void AddBindingParameters(ServiceDescription serviceDescription, System.ServiceModel.ServiceHostBase serviceHostBase, System.Collections.ObjectModel.Collection<ServiceEndpoint> endpoints, System.ServiceModel.Channels.BindingParameterCollection bindingParameters)
        {
            throw new NotImplementedException();
        }

        public void ApplyDispatchBehavior(ServiceDescription serviceDescription, System.ServiceModel.ServiceHostBase serviceHostBase)
        {
            throw new NotImplementedException();
        }

        public void Validate(ServiceDescription serviceDescription, System.ServiceModel.ServiceHostBase serviceHostBase)
        {
            throw new NotImplementedException();
        }
    }
}
