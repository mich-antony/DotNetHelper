using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetHelper.Extentions
{
    public static partial class ObjectExt
    {
        public static bool IsNull<T> (this T obj)
        {
            return obj == null;
        }

        public static bool IsNotNull<T>(this T obj)
        {
            return obj != null;
        }

        public static T IfNullReturnOtherValORself<T>(this T value, T othervalue)
        {
            return value == null ? othervalue : value;
        }
    }
}
