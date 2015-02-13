using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubCloud.KNLTB.DuplicaatPersonen
{
    [DebuggerStepThrough]
    [GeneratedCode("System.ServiceModel", "4.0.0.0")]
    public class DuplicaatpersonenFoundCompletedEventArgs : AsyncCompletedEventArgs
    {
        private object[] results;

        public bool Result
        {
            get
            {
                base.RaiseExceptionIfNecessary();
                return (bool)this.results[0];
            }
        }

        public DuplicaatpersonenFoundCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState)
            : base(exception, cancelled, userState)
        {
            this.results = results;
        }
    }
}
