using System.Collections.Generic;

using Mondop.Guard;

namespace Mondop.Core
{
    public static class IEnumerableStringExentions
    {
        public static string Join(this IEnumerable<string> values,string separator)
        {
            Ensure.IsNotNull(separator, nameof(separator));

            if (values == null)
                return null;

            return string.Join(separator, values);
        }
    }
}
