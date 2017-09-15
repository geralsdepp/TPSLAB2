using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1_CALCULADORA
{
    class Numero
    {
        private double numero;

        public double getNumero()
        {
            double retorno;
            
            retorno = this.numero;
            
            return retorno;
        }
        public Numero()
        {
            this.numero = 0;
        }
        public Numero(double numero)
        {
            this.numero = numero;
        }
        public Numero(string numero)
        {
            setNumero(numero);
        }
        private void setNumero(string numero)
        {
            this.numero = validarNumero(numero); //me falta recibir el numero
        }

        private double validarNumero(string numeroString)
        {
            double retorno;

            if (double.TryParse(numeroString, out retorno) == true) //valida si el string contiene un double. devuelve el double si es true y 0 si es false
            {
                return retorno;
            }
            else
                return retorno;    
        }

        public static double operator +(Numero numero1, Numero numero2)
        {
            double retorno;

            retorno = numero1.getNumero() + numero2.getNumero();

            return retorno;
        }

        public static double operator -(Numero numero1, Numero numero2)
        {
            double retorno;

            retorno = numero1.getNumero() - numero2.getNumero();

            return retorno;
        }

        public static double operator *(Numero numero1, Numero numero2)
        {
            double retorno;

            retorno = numero1.getNumero() * numero2.getNumero();

            return retorno;
        }

        public static double operator /(Numero numero1, Numero numero2)
        {
            double retorno;

            retorno = numero1.getNumero() / numero2.getNumero();

            return retorno;
        }

        public static bool operator !=(Numero numero2, int cero)
        {
            bool retorno = false;
            
            if (numero2.getNumero() != cero)
            {
                retorno = true;
            }
            
            return retorno;
        }

        public static bool operator ==(Numero numero2, int cero)
        {
            bool retorno = false;
           
            if (numero2.getNumero() == cero)
            {
                retorno = true;
            }

            return retorno;
        }
    }
}
