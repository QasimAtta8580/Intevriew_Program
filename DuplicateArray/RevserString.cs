using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuplicateArray
{
    class RevserString
    {
        static void Main(string[] args)
        {

            // string name = "Qasim Attaullah";
            string name;
            Console.Write("Enter a Name : ");
            name=Console.ReadLine();
            string revs = "";
            char ch;
            for (int i = 0; i < name.Length; i++)
            {
                ch = name[i];
                revs = ch + revs;
            }
            Console.WriteLine($"Revser String : {revs}");
        }
    }
}
