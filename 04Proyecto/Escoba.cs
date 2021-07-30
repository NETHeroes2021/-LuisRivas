using System;
using System.Collections.Generic;
using System.Text;

namespace _04Proyecto
{
    /// <summary>
    /// Clase del objeto escoba
    /// </summary>
    public class Escoba : IInflamable
    {
        private readonly decimal Peso;
        private readonly bool Arde;

        /// <summary>
        /// Cosntructor que crea un nuevo elemento Escoba con el peso
        /// en KG del elemento, y un booleano de si esta ardiendo.
        /// </summary>
        /// <param name="peso">Peso del elemento en kg</param>
        /// <param name="arde">booleano de si esta ardiendo</param>
        public Escoba(decimal peso, bool arde)
        {
            Peso = peso;
            Arde = arde;
        }

        /// <summary>
        /// Devuelve cuanto pesa un elemento de la clase Escoba
        /// </summary>
        /// <returns>Peso</returns>
        public decimal DevolverPeso()
        {
            return Peso;
        }

        /// <summary>
        /// Devuelve si el elemento escoba esta ardiendo o no
        /// </summary>
        /// <returns>Arde</returns>
        public bool EstaArdiendo()
        {
            return Arde;
        }
    }
}