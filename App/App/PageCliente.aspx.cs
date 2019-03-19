using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class Formulario_web1 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btAgregar_Click(object sender, EventArgs e)
    {
        Cliente clte = new Cliente();
        clte.IdCliente = int.Parse(txtidClientes.Text);
        clte.NombreCliente = txtNombre.Text;
        clte.DireccionCliente = txtDireccion.Text;
        clte.TelefonoCliente = txtTelefono.Text;
        clte.insertarCliente();
        lblEstado.Text = "Registro agregado con exito";
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Cliente clte = new Cliente();
        clte.IdCliente = int.Parse(txtidClientes.Text);
        clte.NombreCliente = txtNombre.Text;
        clte.DireccionCliente = txtDireccion.Text;
        clte.TelefonoCliente = txtTelefono.Text;
        clte.modificarCliente();
        lblEstado.Text = "Modificación agregada con exito";
    }

    protected void Button1_Click1(object sender, EventArgs e)
    {
        Cliente clte = new Cliente();
        clte.IdCliente = int.Parse(txtidClientes.Text);
        clte.NombreCliente = txtNombre.Text;
        clte.DireccionCliente = txtDireccion.Text;
        clte.TelefonoCliente = txtTelefono.Text;
        clte.eliminarCliente();
        lblEstado.Text = "Se elimino";
    }

    protected void Button1_Click2(object sender, EventArgs e)
    {
        Cliente clte = new Cliente();
        clte.IdCliente = Convert.ToInt64(txtidClientes.Text);
        //clte.consultarCliente(ref txtNombre, ref txtDireccion, ref txtTelefono);
        lblEstado.Text = "Encontrado";       
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        if (Page.IsPostBack)
        {
            BuscarCliente();
        }       
    }

    public void BuscarCliente()
    {
        Conexion co = new Conexion();
        co.conexion.Open();
        SqlDataAdapter DatosCliente = new SqlDataAdapter("select * from VCliente", co.conexion);
        DataSet dsCliente = new DataSet();
        DatosCliente.Fill(dsCliente, "VCliente");
        GridView1.DataSource = dsCliente;
        GridView1.DataBind();
        GridView1.DataMember = "VCliente";
        co.conexion.Close();
    }
}
