﻿using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recapitulacao
{
    class Program
    {
        static void Main(string[] args)
        {
            string frase = Console.ReadLine();
            string x = Console.ReadLine();
            string y = Console.ReadLine();
            string z = Console.ReadLine();
            string s = Console.ReadLine();

            string[] vect = s.Split(' ');
            string a = vect[0];
            string b = vect[1];
            string c = vect[2];

            Console.WriteLine(frase);
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);

            Console.ReadKey();
                





            Console.ReadKey();
            
        }
    }
}
