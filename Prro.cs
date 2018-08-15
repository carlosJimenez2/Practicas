using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mascota
{
    class Prro
    {
        public string Tamaño;
        public string Raza;
        public string Sexo;
        public int Peso;
        public string Color;
        enum TIPOSDECOMIDA{CROQUETAS, BASURA, AGUA}

        public Prro()
        {
            Raza = " Pitbull ";
            Peso = 8;
            Sexo = "Macho";
            Tamaño = "Grande";
        }

        public Prro(string raza, int peso, string sexo, string tamaño)

        {
            Raza = raza;
            Peso = peso;
            Sexo = sexo;
            Tamaño = tamaño;
        }




        public void Ladrar()
        {

        }

        public void Correr()
        {

        }

        public bool Comer(int alimento)
        {
            bool resultado = false;
            if (alimento == (int)TIPOSDECOMIDA.AGUA)
            {
                resultado = false;
            }
            else if (alimento == (int)TIPOSDECOMIDA.BASURA)
            {
                resultado = true;
            }
            else if (alimento == (int)TIPOSDECOMIDA.CROQUETAS)
            {
                resultado = true;
            }
            return resultado;

        }

        public void Cagar()
        {

        }


    }
}
