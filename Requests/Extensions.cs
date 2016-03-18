using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Requests
{
    public static partial class Extensions
    {
        public static void AddRange<TKey, TValue>(this Dictionary<TKey, TValue> self, IDictionary<TKey, TValue> values)
        {
            foreach (var x in values)
            {
                if (self.ContainsKey(x.Key))
                    self[x.Key] = x.Value;
                else
                    self.Add(x.Key, x.Value);
            }
        }
    }
}
