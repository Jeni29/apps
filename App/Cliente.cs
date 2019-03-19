using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;


public class Cliente : Conexion
{
    public int IdCliente;
    public string NombreCliente;
    public string DireccionCliente;
    public string TelefonoCliente;

    public Cliente()
    {

    }

     public int insertarCliente()
    {
        int valor = 0;
        try
        {
            conexion.Close();

            SqlCommand proin = new SqlCommand();
            conectar();
            proin.Connection = conexion;
            proin.CommandType = System.Data.CommandType.StoredProcedure;
            proin.CommandText = "Cliente";
            proin.Parameters.AddWithValue("@IdCliente", IdCliente);
            proin.Parameters.AddWithValue("@NombreCliente", NombreCliente);
            proin.Parameters.AddWithValue("@DireccionCliente", DireccionCliente);
            proin.Parameters.AddWithValue("@TelefonoCliente", TelefonoCliente);

            SqlDataReader reader = proin.ExecuteReader();
            reader.Close();
            conexion.Close();
            return valor;

        }
    }


}

/*string tabla = "Cliente";
   protected string NombreCliente, DireccionCliente, TelefonoCliente;
   protected int IdCliente;


   public Cliente(int IdCliente, string NombreCliente, string DireccionCliente, string TelefonoCliente)
   {
       this.IdCliente = IdCliente;
       this.NombreCliente = NombreCliente;
       this.DireccionCliente = DireccionCliente;
       this.TelefonoCliente = TelefonoCliente;
   }

   //Metodos
   public int idCliente
   {
       set { IdCliente = value; }
       get { return IdCliente; }
   }
   public string nombreCliente
   {
       set { NombreCliente = value; }
       get { return NombreCliente; }
   }
   public string direccionCliente
   {
       set { DireccionCliente = value; }
       get { return DireccionCliente; }
   }
   public string telefonoCliente
   {
       set { TelefonoCliente = value; }
       get { return TelefonoCliente; }
   }

   //Metodo Agregar
   public void Agregar()
   {
       conectar(tabla);
       DataRow fila;
       fila = Data.Tables[tabla].NewRow();
       fila["IdCliente"] = IdCliente;
       fila["NombreCliente"] = NombreCliente;
       fila["DireccionCliente"] = DireccionCliente;
       fila["TelefonoCliente"] = TelefonoCliente;

       Data.Tables[tabla].Rows.Add(fila);
       adaptadorDatos.Update(Data, tabla);
   }*/
