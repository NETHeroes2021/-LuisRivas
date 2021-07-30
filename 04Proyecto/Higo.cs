using System;
using System.Collections.Generic;
using System.Text;

namespace _04Proyecto
{
    /// <summary>
    /// clase del objeto Higo
    /// </summary>
    public class Higo : IPerezable
    {
        private readonly decimal Peso;
        private readonly bool Caducado;

        /// <summary>
        /// Cosntructor que crea un nuevo elemento Gominola con el peso
        /// en KG del elemento, y un booleano de si el elemento esta caducado o no.
        /// </summary>
        /// <param name="peso">Peso en KG</param>
        /// <param name="caducado">booleano de si esta caducado</param>
        public Higo(decimal peso, bool caducado)
        {
            Peso = peso;
            Caducado = caducado;
        }

        /// <summary>
        /// Devuelve cuanto pesa un elemento de la clase Higo
        /// </summary>
        /// <returns>Peso</returns>
        public decimal DevolverPeso()
        {
            return Peso;
        }

        /// <summary>
        /// Devuelve si el elemento Higo esta caducado
        /// </summary>
        /// <returns>Caducado</returns>
        public bool EstaCaducado()
        {
           return Caducado;
        }
    }
}