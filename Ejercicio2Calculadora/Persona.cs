using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2Calculadora
{
    class Persona
    {
        private string nombre { get; set; }
        private int edad { get; set; }
        private int CI;
        private string sexo { get; set; }
        private int peso { get; set; }
        private int altura { get; set; }

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
            int IMC = this.peso / this.altura ^ 2;
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
    }
}
