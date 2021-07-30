using System;
using System.Collections.Generic;
using System.Text;

namespace _04Proyecto
{
    /// <summary>
    /// interfaz que realiza alguna cuenta con el contenido del almacen
    /// </summary>
    interface ICuentasAlmacen
    {
        public decimal RealizarCuentas(List<IElemento> lista);
    }
}
