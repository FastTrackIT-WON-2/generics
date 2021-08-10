using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public static class VariableHelper
    {
        public static void Swap<T>(ref T var1, ref T var2)
        {
            T aux = var1;
            var1 = var2;
            var2 = aux;
        }

        public static T CreateVar<T>()
            where T: new()
        {
            return new T();
        }

        public static T[] Clone<T>(T[] original)
        {
            if (original is null)
            {
                return new T[0];
            }

            T[] result = new T[original.Length];
            for (int i = 0; i < original.Length; i++)
            {
                result[i] = original[i];
            }

            return result;
        }

        public static T[] SortAsc<T>(params T[] array)
            where T: IComparable<T>
        {
            if (array is null)
            {
                return new T[0];
            }

            T[] result = Clone(array);

            for (int i = 0; i < result.Length - 1; i++)
            {
                for (int j = i + 1; j < result.Length; j++)
                {
                    // result[i] must be < than result[j]
                    int order = result[i]?.CompareTo(result[j]) ?? -1;

                    if (order > 0)
                    {
                        Swap(ref result[i], ref result[j]);
                    }
                }
            }

            return result;
        }
    }
}
