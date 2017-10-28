using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3Persona
{
    class Persona
    {
        public String Nombre { get; set; }
        public Int32 Edad { get; set; }
        public Int32 CI { get; set; }
        public Boolean Sexo { get; set; } //true hombre, false mujer
        public Int32 Peso { get; set; }
        public Double Altura { get; set; }

        public Persona(Int32 cédula, String nombre, Int32 edad, Boolean sexo)
        {
            this.CI = cédula;
            this.Nombre = nombre;
            this.Edad = edad;
            this.Sexo = sexo;
        }

        public Boolean EsMayorDeEdad()
        {
            if(this.Edad >= 18)
            {
                return true;
            }
            return false;
        }

        public int CalcularIMC()
        {
            int altura2 = Convert.ToInt32(Altura);
            int IMC = this.Peso / altura2*altura2;
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
            Console.WriteLine("Nombre: " + Nombre);
            Console.WriteLine("CI: " + CI);
            Console.WriteLine("Edad: " + Edad);
            Console.WriteLine("Sexo: " + Sexo);
            Console.WriteLine("Peso y altura: " + Convert.ToString(Peso) + "kg, " + Convert.ToString(Altura) + " m");

        }                
    }
}
