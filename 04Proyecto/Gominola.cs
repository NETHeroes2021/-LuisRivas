using System;
using System.Collections.Generic;
using System.Text;

namespace _04Proyecto
{
    /// <summary>
    /// Clase del objeto gominola
    /// </summary>
    public class Gominola : IInflamable, IPerezable
    {
        private readonly decimal Peso;
        private readonly bool Arde;
        private readonly bool Caducado;


        /// <summary>
        /// Cosntructor que crea un nuevo elemento Gominola con el peso
        /// en KG del elemento, un booleano de si esta ardiendo y otro
        /// booleano de si el elemento esta caducado o no.
        /// </summary>
        /// <param name="peso">Peso en KG</param>
        /// <param name="arde">booleano de si esta ardiendo</param>
        /// <param name="caducado">booleano de si esta caducado</param>
        public Gominola(decimal peso, bool arde, bool caducado)
        {
            Peso = peso;
            Arde = arde;
            Caducado = caducado;
        }

        /// <summary>
        /// Devuelve cuanto pesa un elemento de la clase Gominola
        /// </summary>
        /// <returns>Peso</returns>
        public decimal DevolverPeso()
        {
            return Peso;
        }

        /// <summary>
        /// Devuelve si el elemtno gominola esta ardiendo o no
        /// </summary>
        /// <returns>Arde</returns>
        public bool EstaArdiendo()
        {
            return Arde;
        }

        /// <summary>
        /// Devuelve si el elemento gominola esta caducado o no
        /// </summary>
        /// <returns>Caducado</returns>
        public bool EstaCaducado()
        {
            return Caducado;
        }
    }
}