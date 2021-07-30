using System;
using System.Collections.Generic;
using System.Text;

namespace _04Proyecto
{
    /// <summary>
    /// interfad de los elemntentos tangibles
    /// </summary>
    public interface IElemento
    {
        /// <summary>
        /// cuanto pesa
        /// </summary>
        /// <returns>el peso del elemento</returns>
        decimal DevolverPeso();
    }
}