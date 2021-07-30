using System;
using System.Collections.Generic;
using System.Text;

namespace _04Proyecto
{
    /// <summary>
    /// Clase de papel
    /// </summary>
    public class Papel : IInflamable
    {
        private readonly decimal Peso;
        private readonly bool Arde;


        /// <summary>
        /// Cosntructor que crea un nuevo elemento Gominola con el peso
        /// en KG del elemento, y un booleano de si el elemento esta ardiendo o no.
        /// </summary>
        /// <param name="peso">Peso en Kg</param>
        /// <param name="arde">boolenao de si esta ardiendo</param>
        public Papel(decimal peso, bool arde)
        {
            Peso = peso;
            Arde = arde;
        }


        /// <summary>
        /// Devuelve cuanto pesa un elemento de la clase Papel
        /// </summary>
        /// <returns>Peso</returns>
        public decimal DevolverPeso()
        {
            return Peso;
        }

        /// <summary>
        /// Devuelve si el elemento Papel esta ardiendo o no
        /// </summary>
        /// <returns>Arder</returns>
        public bool EstaArdiendo()
        {
            return Arde;
        }
    }
}