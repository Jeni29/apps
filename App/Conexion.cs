using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;


public class Conexion
{
    public SqlConnection conexion = new SqlConnection("Data Source=DESKTOP-KMUU5H6\\MSSQLSERVER01;Initial Catalog=App;Integrated Security=True");
    private SqlCommandBuilder ob;
    public DataSet data;
    public SqlDataAdapter adaptadorDatos;
    public SqlCommand comando;

    public Conexion()
    {

    }

    public void conectar()
    {
        try
        {
            conexion.Open();
        }
        catch (Exception)
        {
            conexion.Close();
        }

    }
}
/* protected SqlDataReader reader;
    protected SqlDataAdapter adaptadorDatos;
    protected DataSet data;
    protected SqlConnection conexion = new SqlConnection();
    public Conexion ()
    {
    }

    public void conectar(string tabla)
    {
        string strConeccion = ConfigurationManager.ConnectionStrings["AppConnectionString"].ConnectionString;
        conexion.ConnectionString = strConeccion;
        conexion.Open();
        adaptadorDatos = new SqlDataAdapter("select * from " +tabla, conexion);
        SqlCommandBuilder ejecutacomandos = new SqlCommandBuilder(adaptadorDatos);
        Data = new DataSet();
        adaptadorDatos.Fill(Data, tabla);
        conexion.Close();
    }

    public DataSet Data
    {
        set { data = value; }
        get { return data; }
    }

    public SqlDataReader DataReader
    {
        set { reader = value; }
        get { return reader; }
    }*/
