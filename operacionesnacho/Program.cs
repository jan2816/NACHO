using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using operaciones;

namespace operacionesnacho
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int j, i;
            Console.Write("digita el primer numero; ");
            j = int.Parse(Console.ReadLine());
            Console.Write("digita el primer numero: ");
            i = int.Parse(Console.ReadLine());

            long sumar = operaciones.operaciones.suma(j, i);
            long res = operaciones.operaciones.resta(j, i);
            long mul = operaciones.operaciones.multiplicacion(j, i);
            long divi = operaciones.operaciones.division(j, i);

            Console.WriteLine("la suma es:"+sumar);
            Console.WriteLine("la resta es:" + res);
            Console.WriteLine("la multiplicacion es:" + mul);
            Console.WriteLine("la division es:" + divi);
            Console.ReadKey();
        }
    }
}
