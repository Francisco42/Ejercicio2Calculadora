using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3Persona
{
    class Persona
    {
        public string nombre { get; set; }
        public int edad { get; set; }
        public int CI;
        public string sexo { get; set; }
        public int peso { get; set; }
        public float altura { get; set; }

        public Persona(int Cédula)
        {
            CI = Cédula;
            this.nombre = "";
            this.edad = 0;
            this.sexo = "H";
        }

        public bool EsMayorDeEdad()
        {
            if(this.edad >= 18)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public int CalcularIMC()
        {
            int altura2 = Convert.ToInt32(altura);
            int IMC = this.peso / altura2*altura2;
            int final_value = 0;

            if (IMC < 18)
            {
                final_value = -1;
            }
            if (IMC >= 18 && IMC <= 25)
            {
                final_value = 0;
            }
            if (IMC > 25)
            {
                final_value = 1;
            }
            else
            {
                final_value =  10;
            }

            //

            if (final_value == -1)
            {
                return -1;
            }
            if (final_value == 0)
            {
                return 0;
            }
            if (final_value == 1)
            {
                return 1;
            }
            else
            {
                Console.WriteLine("No se pudo realizar el cálculo del IMC");
                return 23742;
            }             
        }
        public void Info()
        {
            Console.WriteLine("Nombre: " + nombre);
            Console.WriteLine("CI: " + CI);
            Console.WriteLine("Edad: " + edad);
            Console.WriteLine("Sexo: " + sexo);
            Console.WriteLine("Peso y altura: " + peso + "kg, " + altura + " m");

        }                
    }
}
