using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public static class ExceptionLogger
    {
        public static void Log<T>(T exception)
            where T : Exception
        {
            Console.WriteLine(exception.Message);
            Console.WriteLine(exception.StackTrace);
            if (exception.InnerException != null)
            {
                ExceptionLogger.Log(exception.InnerException);
            }
        }
    }
}
