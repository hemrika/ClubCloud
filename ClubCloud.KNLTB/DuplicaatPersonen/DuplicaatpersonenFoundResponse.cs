using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ClubCloud.KNLTB.DuplicaatPersonen
{
    [DebuggerStepThrough]
    [EditorBrowsable(EditorBrowsableState.Advanced)]
    [GeneratedCode("System.ServiceModel", "4.0.0.0")]
    [MessageContract(WrapperName = "DuplicaatpersonenFoundResponse", WrapperNamespace = "http://knltb.nl/services", IsWrapped = true)]
    public class DuplicaatpersonenFoundResponse
    {
        [MessageBodyMember(Namespace = "http://knltb.nl/services", Order = 0)]
        public bool DuplicaatpersonenFoundResult;

        public DuplicaatpersonenFoundResponse()
        {
        }

        public DuplicaatpersonenFoundResponse(bool DuplicaatpersonenFoundResult)
        {
            this.DuplicaatpersonenFoundResult = DuplicaatpersonenFoundResult;
        }
    }
}
