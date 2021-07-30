using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _04Proyecto
{
    /// <summary>
    /// Clase para devolver la lista de nombres para el listbox
    /// </summary>
    public class ListarNombres : IListarNombres
    {

        /// <summary>
        /// Metodo que realiza una lista de los nombres de los elementos utilizando LINQ
        /// </summary>
        /// <param name="lista">Lista de Elementos</param>
        /// <returns>Lista de strings de los nombres de los elemnentos de la lista dada</returns>
        public List<string> recuperarNombreObjetos(List<IElemento> lista)
        {
            var r = (from elemento in lista select elemento.GetType().Name).ToList<string>();

            return r;
        }
    }
}
