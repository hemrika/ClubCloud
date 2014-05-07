using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubCloud.KNLTB.Security
{
    public abstract class AsyncLock
    {
        public AsyncLock()
        {
        }

        public AsyncLock()
        {
            // TODO: Complete member initialization
        }

        internal bool finished = false;
        internal bool running = false;

        public abstract Task<Releaser> LockAsync();

        public struct Releaser : IDisposable
        {
            public void Dispose() { }
        }
    }

}
