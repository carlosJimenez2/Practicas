﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mascota
{
    class Program
    {
        enum TIPOSDECOMIDA { CROQUETAS, BASURA, AGUA }
        static void Main(string[] args)
        {
            bool alimentado = false;

            Prro Prro1 = new Prro();

            Prro1.Raza = " French Puddle ";
            Prro1.Peso = 7;
            Prro1.Sexo = "Macho";
            Prro1.Tamaño = "Pequeña";

            alimentado = Prro1.Comer((int)TIPOSDECOMIDA.BASURA);

            if (alimentado)
            {
                Console.WriteLine("El perro " + Prro1.Raza + " comio " + Convert.ToString(TIPOSDECOMIDA.AGUA));
            }
            else
            {
                Console.WriteLine("El perro no ha comido");

            }
            

            Prro Prro2 = new Prro();
            Console.WriteLine("El perro " + Prro2.Raza + " comio " + Convert.ToString(TIPOSDECOMIDA.AGUA));
          
            Prro Prro3 = new Prro("Shitzu", 15, "Hembra", "pequeño");
            Console.WriteLine("El perro " + Prro3.Raza + " comio " + Convert.ToString(TIPOSDECOMIDA.AGUA));
            Console.Read();


        }
    }
}
