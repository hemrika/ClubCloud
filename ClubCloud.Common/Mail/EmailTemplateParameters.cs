using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ClubCloud.Common.Mail
{
    /// <summary>
    /// Stores a name/value pairs dictionary used to serialize the XML input data required by the XSL Transformation templates.
    /// </summary>
    [Serializable]
    public class EmailTemplateParameters : Dictionary<string, object>
    {
        public EmailTemplateParameters() { }

        protected EmailTemplateParameters(SerializationInfo info, StreamingContext context) : base(info, context) { }
    }
}
