using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DuplicateArray.DelegateClass;

namespace DuplicateArray
{
    public class DelegateClass
    {
        public delegate void VoidDelegate();
        public static void Main(string[] args)
        {
            VoidDelegate del1 = Print1;
            myclass.excuteDelegate(del1);
        }
        private static void Print1()
        {
            Console.WriteLine("Method 1");
        }
    }
    class myclass {
        public static void excuteDelegate(VoidDelegate del)
        {
            del();
        }
    }

}
