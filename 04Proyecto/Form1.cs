using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _04Proyecto
{
    /// <summary>
    /// Funcionalidad de la pantalla principal
    /// </summary>
    public partial class Form1 : Form
    {
        List<IElemento> listaElementos = new List<IElemento>();

        /// <summary>
        /// Inciacion del programa
        /// </summary>
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Evento de click del boton
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void button_Click(object sender, EventArgs e)
        {
            String texto = (sender as Button).Text;

            IElemento elemento1 = new TipoBoton().DevolverTipo(texto);
            if(elemento1 != null)
            {
                listaElementos.Add(elemento1);
            }
            listBoxElementos.DataSource = new ListarNombres().recuperarNombreObjetos(listaElementos);
            labelResultadoKLinflama.Text = new SumaPereNi().RealizarCuentas(listaElementos).ToString();
            labelResultadoCantAlmacen.Text = listaElementos.Count.ToString();
            labelResultadoNPerecedero.Text = new MediaNp().RealizarCuentas(listaElementos).ToString("0.##")+"%";
        }
    }
}
