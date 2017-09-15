using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1_CALCULADORA
{
    class Calculadora
    {
        public double operar(Numero numero1, Numero numero2, string operador)
        {
            double retorno = 0;

            if (operador == "+")
            {
                retorno = numero1 + numero2;
            }
            else if (operador == "-")
            {
                retorno = numero1 - numero2;
            }
            else if (operador == "*")
            {
                retorno = numero1 * numero2;
            }
            else if (operador == "/")
            {
                if (numero2 != 0)
                    retorno = numero1 / numero2;
                else
                    retorno = -1;
            }


            return retorno;
        }

        public string validarOperador(string operador)
        {
            string retorno;

            if (operador == "+" || operador == "-" || operador == "*" || operador == "/")
            {
                retorno = operador;
            }
            else
                retorno = "+";
            return retorno;
        }

    }
}
