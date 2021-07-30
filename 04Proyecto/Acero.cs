using System;
using System.Collections.Generic;
using System.Text;

namespace _04Proyecto
{
    /// <summary>
    /// Clase de acero
    /// </summary>
    public class Acero : IElemento
    {
        private readonly decimal Peso;

        /// <summary>
        /// Constructor que crea un elemento Acero introduciendo su peso
        /// </summary>
        /// <param name="peso">Kilos de acero</param>
        public Acero(decimal peso)
        {
            this.Peso = peso;
        }

        /// <summary>
        /// Devuelve cuanto pesa un elemento de la clase Acero
        /// </summary>
        /// <returns>Peso</returns>
        public decimal DevolverPeso()
        {
            return Peso;
        }
    }
}