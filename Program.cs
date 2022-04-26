using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Par_ou_impar
{
    class Program
    {
       static void Main(string[] args)
        { 
            int num;

            Console.WriteLine("Escreva um número:");
            num= int.Parse(Console.ReadLine());
            parOuImpar(num);
        }
        static void parOuImpar(int num1)
        {
            if (num1 % 2 == 0)
            {
                Console.WriteLine("Este número é par");
            }
            else
            {
                Console.WriteLine("Este número é impar");
            }
        }
    }
}
