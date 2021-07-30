using System;
using System.Collections.Generic;
using System.Text;

namespace _04Proyecto
{
    /// <summary>
    /// Clase que identifica el boton y crea su objeto
    /// </summary>
    public class TipoBoton
    {

        /// <summary>
        /// Pide el nombre del boton y mediante un switch reconece cual es y 
        /// crea un objeto de eses tipo y lo devuelve
        /// </summary>
        /// <param name="sender">nombre del boton</param>
        /// <returns>el objeto deseado</returns>
        public IElemento DevolverTipo(String sender)
        {
            switch (sender)
            {
                case "Acero": return (new Acero(100));
                case "Bronce": return (new Bronce((decimal)50.5)); 
                case "Chip": return (new Chip((decimal)0.75));
                case "Escoba": return (new Escoba(5, false)); 
                case "Gominola": return (new Gominola(1, false, false));
                case "Higo": return (new Higo((decimal)6.7, true));
                case "Papel": return (new Papel(12, false));
                default: return null;
            }
        }
    }
}
