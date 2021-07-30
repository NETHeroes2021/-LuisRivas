using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _04Proyecto
{
    /// <summary>
    /// Clase para la realizcion de la "media"
    /// </summary>
    public class MediaNp : ICuentasAlmacen
    {

        /// <summary>
        /// Realiza la media de los productos no perecederos desde una lista de elemntos y 
        /// relaizando el filtrado mediante LINQ
        /// </summary>
        /// <param name="lista">Lista de elementos</param>
        /// <returns>Media de no perecederos</returns>
        public decimal RealizarCuentas(List<IElemento> lista)
        {         
            int r = (from elemento in lista where !elemento.GetType().GetInterfaces().Contains(typeof(IPerezable)) select elemento).Count();
            int cuenta = (from elemento in lista select elemento).Count();
                    
            decimal resultado = (decimal) r * 100 / cuenta;
            return resultado;
        }
    }
}
