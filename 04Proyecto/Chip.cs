using System;
using System.Collections.Generic;
using System.Text;

namespace _04Proyecto
{
    /// <summary>
    /// Clase del objeto Chip
    /// </summary>
    public class Chip : IElemento
    {
        private readonly decimal Peso;


        /// <summary>
        /// Cosntructor que crea un nuevo elemento Chip con el peso
        /// en KG del elemtno
        /// </summary>
        /// <param name="peso"></param>
        public Chip(decimal peso)
        {
            Peso = peso;
        }

        /// <summary>
        /// Devuelve cuanto pesa un elemento de la clase Chip
        /// </summary>
        /// <returns>Peso</returns>
        public decimal DevolverPeso()
        {
            return Peso;
        }
    }
}