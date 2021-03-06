using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Sfa.Das.Sas.Indexer.Core.Extensions
{
    public static class ListExtensions
    {
        public static async Task ForEachAsync<T>(this IEnumerable<T> list, Func<T, Task> action)
        {
            foreach (var item in list)
            {
                await action(item).ConfigureAwait(false);
            }
        }

        public static void ForEach<T>(this IEnumerable<T> list, Action<T> action)
        {
            if (list != null)
            {
                foreach (var item in list)
                {
                    action(item);
                }
            }
        }
    }
}