using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


    public partial class Formulario_web1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public void btAgregar_Click(object sender, EventArgs e)
        {
            Cliente clte = new Cliente();
            clte.IdCliente = int.Parse(txtidClientes.Text);
            clte.NombreCliente = txtNombre.Text;
            clte.DireccionCliente = txtDireccion.Text;
            clte.TelefonoCliente = txtTelefono.Text;
            clte.insertarCliente();
            lblEstado.Text = "Registro agregado con exito";

        }
}
