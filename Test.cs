using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Test
    {
        static int zeroMethod()
        {
            return 0;
        }

        static void assignmentRemainderOfMethodResult()
        {
            int a = 5;
            a %= zeroMethod(); // VIOLATION
        }

        static void assignRemainderOfVar()
        {
            int a = 5;
            int b = Convert.ToInt32(ReturnZero());
            //int b = 0;
            a %= b; // no VIOLATION
        }
        static byte ReturnZero() {
            byte b = 0;
            return b;
        }
        /*
        static byte ReturnZero2()
        {
            int i = 1;
            byte b = Convert.ToByte(i);
            return b;
        }
        */
    }
}
