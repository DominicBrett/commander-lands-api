using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Extensions
{
    public static class StringArrayExtensions
    {
        public static bool ContainsAny(this string[] array, string[] value)
        {
            foreach (var item in value)
            {
                if (array.Contains(item)) return true;
            }
            return false;
        }

        public static bool DoesNotContainsAny(this string[] array, string[] value)
        {
            foreach (var item in value)
            {
                if (array.Contains(item)) return false;
            }
            return true;
        }
    }
}