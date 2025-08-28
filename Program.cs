using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;
using System.Runtime.Versioning;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Documents;


class Program
{
    static void Main(string[] args)
    {

        for (int i = 1; i < 101; i++)
        {
            if ((i % 3 == 0) && (i % 5 == 0))
                Console.WriteLine("FizzBuzz");
            else if (i % 3 == 0)
                Console.WriteLine("Fizz");
            else if (i % 5 == 0)
                Console.WriteLine("Buzz");
            else
                Console.WriteLine(i);
        }






    }       
}

