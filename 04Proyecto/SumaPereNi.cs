using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _04Proyecto
{
    /// <summary>
    /// Clase para relizar la suma de los perecederos no ignifugos
    /// </summary>
    public class SumaPereNi : ICuentasAlmacen
    {


        /// <summary>
        /// Mediante LINQ extrae de una lista de IElementos filtrando por si es IPerecezable y si no es IInflamable y el resultado
        /// extraete el peso y lo suma
        /// </summary>
        /// <param name="lista">Lista de Elementos</param>
        /// <returns>El peso de los elementos perecederos no inflamables</returns>
        public decimal RealizarCuentas(List<IElemento> lista)
        {
            decimal r = (from elemento in lista where elemento is IPerezable && !elemento.GetType().GetInterfaces().Contains(typeof(IInflamable)) select elemento.DevolverPeso()).Sum();

            return r;
        }
    }
}
