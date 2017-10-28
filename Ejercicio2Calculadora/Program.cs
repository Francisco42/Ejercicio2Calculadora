using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3Persona
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona a = new Persona(49042045, "Bruno", 18, true);
            a.Peso = 60;
            a.Altura = 170;
            Console.WriteLine(a.CalcularIMC());
            a.Info();
            Console.ReadKey();
        }
    }
}
