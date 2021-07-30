using _04Proyecto;
using NUnit.Framework;
using System.Collections.Generic;

namespace _04Proyecto2.test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        /// <summary>
        /// Test de que si el boton se llama Acero crea correctamente un acero que pesa 100
        /// </summary>
        [Test]
        public void TestNombrebotones1()
        {
            IElemento elemento = new TipoBoton().DevolverTipo("Acero");
            Assert.AreEqual(100, elemento.DevolverPeso());
        }
        /// <summary>
        /// Test de que si el boton se llama Higo crea correctamente un higo que pesa 6.7
        /// </summary>
        [Test]
        public void TestNombrebotones2()
        {
            IElemento elemento = new TipoBoton().DevolverTipo("Higo");
            Assert.AreEqual((decimal)6.7, elemento.DevolverPeso());
        }
        /// <summary>
        /// Test de que si el boton se llama Higo crea correctamente un higo que no pesa 6.7
        /// </summary>
        [Test]
        public void TestNombrebotones3()
        {
            IElemento elemento = new TipoBoton().DevolverTipo("Higo");
            Assert.AreNotEqual(100, elemento.DevolverPeso());
        }

        /// <summary>
        /// Test que prueba si suma correctamente el peso de los elementos perecederos no inflamables
        /// que deberia ser 21.1
        /// </summary>
        [Test]
        public void TestSumaNiP1()
        {
            List<IElemento> lista = new List<IElemento>();
            IElemento elemento;
            elemento = new Acero(111);
            lista.Add(elemento);
            elemento = new Higo(10,false);
            lista.Add(elemento);
            elemento = new Acero(111);
            lista.Add(elemento);
            elemento = new Gominola(5,false,false);
            lista.Add(elemento);
            elemento = new Higo(11.1m,false);
            lista.Add(elemento);
            elemento = new Papel(25,false);
            lista.Add(elemento);
            Assert.AreEqual(21.1,new SumaPereNi().RealizarCuentas(lista));
        }

        /// <summary>
        /// Test que prueba si la suma del peso de los elementos perecederos no inflamables
        /// no es 21.1
        /// </summary>
        [Test]
        public void TestSumaNiP2()
        {
            List<IElemento> lista = new List<IElemento>();
            IElemento elemento;
            elemento = new Acero(111);
            lista.Add(elemento);
            elemento = new Escoba(10, false);
            lista.Add(elemento);
            elemento = new Acero(111);
            lista.Add(elemento);
            elemento = new Gominola(5, false, false);
            lista.Add(elemento);
            elemento = new Chip(11.1m);
            lista.Add(elemento);
            elemento = new Papel(25, false);
            lista.Add(elemento);
            Assert.AreNotEqual(21.1, new SumaPereNi().RealizarCuentas(lista));
        }

        /// <summary>
        /// Test de prueba si la media de los productos no perecederos es 57.14 con una 
        /// desbiacion aceptable de 0.01
        /// </summary>
        [Test]
        public void TestMediaNp1()
        {
            List<IElemento> lista = new List<IElemento>();
            IElemento elemento;
            elemento = new Acero(50);
            lista.Add(elemento);
            elemento = new Higo(10, false);
            lista.Add(elemento);
            elemento = new Acero(111);
            lista.Add(elemento);
            elemento = new Gominola(5, false, false);
            lista.Add(elemento);
            elemento = new Higo(11.1m, false);
            lista.Add(elemento);
            elemento = new Papel(25, false);
            lista.Add(elemento);
            elemento = new Papel(25, false);
            lista.Add(elemento);
            Assert.AreEqual(57.14, (double)new MediaNp().RealizarCuentas(lista),0.01f);
        }

        /// <summary>
        /// Test de prueba si la media de los productos no perecederos no es 57.14
        /// </summary>
        [Test]
        public void TestMediaNp2()
        {
            List<IElemento> lista = new List<IElemento>();
            IElemento elemento;
            elemento = new Acero(111);
            lista.Add(elemento);
            elemento = new Escoba(10, false);
            lista.Add(elemento);
            elemento = new Acero(111);
            lista.Add(elemento);
            elemento = new Gominola(5, false, false);
            lista.Add(elemento);
            elemento = new Chip(11.1m);
            lista.Add(elemento);
            elemento = new Papel(25, false);
            lista.Add(elemento);
            Assert.AreNotEqual(57.14, (double)new MediaNp().RealizarCuentas(lista));
        }

        /// <summary>
        /// Test que compueba el metodo que tras dar una lista de elementos devuelve otra con 
        /// solo el nombre de cada elemento
        /// </summary>
        [Test]
        public void TestListaNombres1()
        {
            List<IElemento> lista = new List<IElemento>();
            IElemento elemento;
            List<string> listaE = new List<string>();
            elemento = new Acero(111);
            lista.Add(elemento);
            listaE.Add(elemento.GetType().Name);
            elemento = new Escoba(10, false);
            lista.Add(elemento);
            listaE.Add(elemento.GetType().Name);
            elemento = new Acero(111);
            lista.Add(elemento);
            listaE.Add(elemento.GetType().Name);
            elemento = new Gominola(5, false, false);
            lista.Add(elemento);
            listaE.Add(elemento.GetType().Name);
            elemento = new Chip(11.1m);
            lista.Add(elemento);
            listaE.Add(elemento.GetType().Name);
            elemento = new Papel(25, false);
            lista.Add(elemento);
            listaE.Add(elemento.GetType().Name);
            Assert.AreEqual(listaE,new ListarNombres().recuperarNombreObjetos(lista));
        }


        /// <summary>
        /// Test que compueba el metodo que tras dar una lista de elementos devuelve otra con 
        /// solo el nombre de cada elemento comprueba que no es igual a una lista con un elemento diferente
        /// </summary>
        [Test]
        public void TestListaNombres2()
        {
            List<IElemento> lista = new List<IElemento>();
            IElemento elemento;
            List<string> listaE = new List<string>();
            elemento = new Acero(111);
            lista.Add(elemento);
            listaE.Add(elemento.GetType().Name);
            elemento = new Escoba(10, false);
            lista.Add(elemento);
            listaE.Add(elemento.GetType().Name);
            elemento = new Acero(111);
            lista.Add(elemento);
            listaE.Add(elemento.GetType().Name);
            elemento = new Gominola(5, false, false);
            lista.Add(elemento);
            listaE.Add(elemento.GetType().Name);
            elemento = new Chip(11.1m);
            lista.Add(elemento);
            listaE.Add(elemento.GetType().Name);
            elemento = new Papel(25, false);
            lista.Add(elemento);
            listaE.Add("Escoba");
            Assert.AreNotEqual(listaE, new ListarNombres().recuperarNombreObjetos(lista));
        }


    }
}