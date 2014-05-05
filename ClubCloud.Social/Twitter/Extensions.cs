using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubCloud.Social.Twitter
{
    internal static class Extensions
    {
        internal static bool IsEmpty(this string value)
        {
            return string.IsNullOrEmpty(value);
        }

        internal static bool IsWhiteSpace(this string value)
        {
            return string.IsNullOrWhiteSpace(value);
        }
    }
}
