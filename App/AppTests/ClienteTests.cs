using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;


namespace Tests
{
    [TestClass()]
    public class ClienteTests
    {
        //Metodo Insertar
        [TestMethod()]
        public void insertarClienteTest()
        {
            DataTable dt = new DataTable();
            Cliente clte = new Cliente();
            clte.IdCliente = 1895;
            clte.NombreCliente = "Camila";
            clte.DireccionCliente = "Calle 12";
            clte.TelefonoCliente = "5481";
            int expected = 1;
            int actual;
            string msgResult = "";
            msgResult = clte.insertarCliente(); 
            actual = msgResult == "" ? 1 : 0;
            Debug.WriteLine(msgResult);
            Assert.AreEqual(actual, expected);
            
        }

        //Metodo Modificar
        [TestMethod()]
        public void modificarClienteTest()
        {
            DataTable dt = new DataTable();
            Cliente clte = new Cliente();
            clte.IdCliente = 8457;
            clte.NombreCliente = "Lorena";
            clte.DireccionCliente = "Carrera 10";
            clte.TelefonoCliente = "58745";
            int expected = 1;
            int actual;
            string resultado = "";
            resultado = clte.modificarCliente();
            actual = resultado == "" ? 1 : 0;
            Debug.Write(resultado);
            Assert.AreEqual(actual, expected);
        }

        // Metodo eliminar
        [TestMethod()]
        public void eliminarClienteTest()
        {
            DataTable dt = new DataTable();
            Cliente clte = new Cliente();
            clte.IdCliente = 1895;
            int expected = 1;
            int actual;
            string resultado = "";
            resultado = clte.eliminarCliente();

            actual = resultado == "" ? 1 : 0;
            Debug.Write(resultado);
            Assert.AreEqual(actual, expected);
        }
        //Metodo Consultar
        [TestMethod()]
        public void consultarClienteTest()
        {
            Cliente clte = new Cliente();
            string msError = "";
            clte.IdCliente = 1895;
            if (clte.consultarCliente(clte.IdCliente)) msError = "Registro no eliminado en la BD";

        }
    }
}