using System;
using System.Collections.Generic;
using System.Text;

namespace _04Proyecto
{
    /// <summary>
    /// Interfaz de elemnto perecederos
    /// </summary>
    public interface IPerezable : IElemento
    {

        /// <summary>
        /// esta caducado?
        /// </summary>
        /// <returns>true o false</returns>
        bool EstaCaducado();
    }
}