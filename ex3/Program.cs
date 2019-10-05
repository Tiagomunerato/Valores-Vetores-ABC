using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] a = new double[10];
            double[] b = new double[10];
            double[] c = new double[10];

            for (int i = 0; i <= 9; i++)
            {
                Console.Write("Informe o {0}º valor do vetor A => ", i+1);
                a[i] = double.Parse(Console.ReadLine());

            }

            for (int i = 0; i <= 9; i++)
            {
                Console.Write("Informe o {0}º valor do vetor B => ", i+1);
                b[i] = double.Parse(Console.ReadLine());
            }

            for (int i = 0; i <= 9; i++)
            {
                c[i] = a[i] + b[i];

            }
            Console.Clear();
            
            Console.WriteLine("Valores de A        Valores de B        Valores de C");
            Console.WriteLine("****************************************************");
            for (int i = 0; i <= 9; i++)
            {
            Console.WriteLine("   {0}                   {1}                  {2}", a[i], b[i], c[i]);   
            }
            Console.ReadKey();
        }
    }
}
