using System;
using System.Collections.Generic;
using System.Text;

namespace _04Proyecto
{
    /// <summary>
    /// Interfaz de los elementos inflamables
    /// </summary>
    public interface IInflamable : IElemento
    {
        /// <summary>
        /// esta ardiendo?
        /// </summary>
        /// <returns>true o falses</returns>
        bool EstaArdiendo();
    }
}