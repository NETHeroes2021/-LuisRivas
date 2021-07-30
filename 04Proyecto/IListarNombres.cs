using System;
using System.Collections.Generic;
using System.Text;

namespace _04Proyecto
{
    /// <summary>
    /// Interfad de listar nombres
    /// </summary>
    interface IListarNombres
    {
        public List<string> recuperarNombreObjetos(List<IElemento> lista);
    }
}
