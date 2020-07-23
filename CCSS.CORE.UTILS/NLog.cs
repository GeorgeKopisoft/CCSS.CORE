using System;
using System.Collections.Generic;
using System.Text;

namespace CCSS.CORE.UTILS
{
    //TODO: Implementar Nlog para registro de errores en archivo físico
    public static class NLog
    {
        public static void Write(Exception ex)
        {
            Console.WriteLine("ERROR: ", ex.Message);
        }
    }
}
