﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_2017
{
    /// <summary>
    /// No podrá tener clases heredadas.
    /// </summary>
    public class Changuito
    {
        private List<Producto> _productos;
        private int _espacioDisponible;

        public enum ETipo
        {
            Dulce, Leche, Snacks, Todos
        }

        #region "Constructores"
        private Changuito()
        {
            this._productos = new List<Producto>();
        }
        public Changuito(int espacioDisponible):this()
        {
            this._espacioDisponible = espacioDisponible;
        }
        #endregion

        #region "Sobrecargas"
        /// <summary>
        /// Muestro la concecionaria y TODOS los Productos
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return Changuito.Mostrar(this, ETipo.Todos);
        }
        #endregion

        #region "Métodos"

        /// <summary>
        /// Expone los datos del elemento y su lista (incluidas sus herencias)
        /// SOLO del tipo requerido
        /// </summary>
        /// <param name="c">Elemento a exponer</param>
        /// <param name="ETipo">Tipos de ítems de la lista a mostrar</param>
        /// <returns></returns>
        public static string Mostrar(Changuito c, ETipo tipo) //quitar static
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("Tenemos {0} lugares ocupados de un total de {1} disponibles", c._productos.Count, c._espacioDisponible);
            sb.AppendLine("");
            foreach (Producto v in c._productos)
            {
                if(v is Dulce && tipo == ETipo.Dulce)
                {
                    sb.AppendLine(v.Mostrar());
                }
                else if(v is Leche && tipo == ETipo.Leche)
                {
                    sb.AppendLine(v.Mostrar());
                }
                else if(v is Snacks && tipo == ETipo.Snacks)
                {
                    sb.AppendLine(v.Mostrar());
                }
                else if(tipo == ETipo.Todos)
                {
                    sb.AppendLine(v.Mostrar());
                }
                /*switch (tipo)
                {
                    case ETipo.Snacks:
                        sb.AppendLine(v.Mostrar());
                        break;
                    case ETipo.Dulce:
                        sb.AppendLine(v.Mostrar());
                        break;
                    case ETipo.Leche:
                        sb.AppendLine(v.Mostrar());
                        break;
                    default:
                        sb.AppendLine(v.Mostrar());
                        break;
                }*/
            }

            return sb.ToString();
        }
        #endregion

        #region "Operadores"
        /// <summary>
        /// Agregará un elemento a la lista
        /// </summary>
        /// <param name="c">Objeto donde se agregará el elemento</param>
        /// <param name="p">Objeto a agregar</param>
        /// <returns></returns>
        public static Changuito operator +(Changuito c, Producto p)
        {
            if (c._productos.Contains(p) == false && c._productos.Count < 5)
            {
                c._productos.Add(p);
                
            }
            return c;
        }
        /// <summary>
        /// Quitará un elemento de la lista
        /// </summary>
        /// <param name="c">Objeto donde se quitará el elemento</param>
        /// <param name="p">Objeto a quitar</param>
        /// <returns></returns>
        public static Changuito operator -(Changuito c, Producto p)
        {
            if (c._productos.Contains(p) == true)
            {
                c._productos.Remove(p);
            }

            return c;
        }
        #endregion
    }
}
