using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubCloud.Service
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, Inherited = true, AllowMultiple = false)]
    public abstract class FilterAttribute : Attribute
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
    }
}
