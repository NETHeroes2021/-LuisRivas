using System;
using System.Collections.Generic;
using System.Text;

namespace _04Proyecto
{
    /// <summary>
    /// Clase del objeto bronce
    /// </summary>
    public class Bronce : IElemento
    {
        private readonly decimal Peso;

        /// <summary>
        /// Cosntructor que crea un nuevo elemento Bronce con el peso
        /// en KG del elemtno
        /// </summary>
        /// <param name="peso">KG del elemento</param>
        public Bronce(decimal peso)
        {
            Peso = peso;
        }

        /// <summary>
        /// Devuelve cuanto pesa un elemento de la clase Bronce
        /// </summary>
        /// <returns>Peso</returns>
        public decimal DevolverPeso()
        {
            return Peso;
        }
    }
}