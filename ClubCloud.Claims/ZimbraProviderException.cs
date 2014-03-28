using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubCloud.Provider
{
    [Serializable]
    public class ZimbraException : Exception
    {
        public ZimbraException() { }
        public ZimbraException(string message) : base(message) { }
        public ZimbraException(string message, Exception inner) : base(message, inner) { }
        protected ZimbraException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context)
            : base(info, context) { }
    }

    [Serializable]
    public class ZimbraSettingsException : Exception
    {
        public ZimbraSettingsException() { }
        public ZimbraSettingsException(string message) : base(message) { }
        public ZimbraSettingsException(string message, Exception inner) : base(message, inner) { }
        protected ZimbraSettingsException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context)
            : base(info, context) { }
    }

    [Serializable]
    public class ZimbraMembershipException : ZimbraException
    {
        public ZimbraMembershipException() { }
        public ZimbraMembershipException(string message) : base(message) { }
        public ZimbraMembershipException(string message, Exception inner) : base(message, inner) { }
        protected ZimbraMembershipException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context)
            : base(info, context) { }
    }

    [Serializable]
    public class ZimbraRoleException : ZimbraException
    {
        public ZimbraRoleException() { }
        public ZimbraRoleException(string message) : base(message) { }
        public ZimbraRoleException(string message, Exception inner) : base(message, inner) { }
        protected ZimbraRoleException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context)
            : base(info, context) { }
    }

    [Serializable]
    public class ZimbraUserException : ZimbraException
    {
        public ZimbraUserException() { }
        public ZimbraUserException(string message) : base(message) { }
        public ZimbraUserException(string message, Exception inner) : base(message, inner) { }
        protected ZimbraUserException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context)
            : base(info, context) { }
    }

    [Serializable]
    public class ZimbraClaimException : ZimbraException
    {
        public ZimbraClaimException() { }
        public ZimbraClaimException(string message) : base(message) { }
        public ZimbraClaimException(string message, Exception inner) : base(message, inner) { }
        protected ZimbraClaimException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context)
            : base(info, context) { }
    }
}
