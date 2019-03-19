using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using System.Windows;
using System.Web.UI.WebControls;

public class Cliente : Conexion
{
    public long IdCliente;
    public string NombreCliente;
    public string DireccionCliente;
    public string TelefonoCliente;

    public Cliente()
    {

    }
    public Cliente(long idCliente)
    {
        IdCliente = idCliente;
    }

    //Metodo Insertar Cliente
    public string insertarCliente()
    {     
        string msgError = "";

        try
        {
            conexion.Close();

            SqlCommand proin = new SqlCommand();
            Conectar();
            proin.Connection = conexion;
            proin.CommandType = System.Data.CommandType.StoredProcedure;
            proin.CommandText = "insertarCliente";
            proin.Parameters.AddWithValue("@IdCliente", 0);
            proin.Parameters.AddWithValue("@NombreCliente", NombreCliente);
            proin.Parameters.AddWithValue("@DireccionCliente", DireccionCliente);
            proin.Parameters.AddWithValue("@TelefonoCliente", TelefonoCliente);
            SqlDataReader reader = proin.ExecuteReader();
            reader.Close();
            conexion.Close();
        }
        catch (SqlException ex)
        {
            //valor = 0;
            msgError = ex.Message;           
        }
        //consultar cliente insertado
        if (!consultarCliente(NombreCliente)) msgError = "Registro no insertado en la BD";

        return msgError;
    }


    //Metodo Modificar
    public string modificarCliente()
    {
        string msError = "";
        try
        {
            conexion.Close();
            SqlCommand proin = new SqlCommand();
            Conectar();
            proin.Connection = conexion;
            proin.CommandType = System.Data.CommandType.StoredProcedure;
            proin.CommandText = "actualizarCliente";
            proin.Parameters.AddWithValue("@IdCliente", IdCliente);
            proin.Parameters.AddWithValue("@NombreCliente", NombreCliente);
            proin.Parameters.AddWithValue("@DireccionCliente", DireccionCliente);
            proin.Parameters.AddWithValue("@TelefonoCliente", TelefonoCliente);

            SqlDataReader reader = proin.ExecuteReader();
            reader.Close();
            conexion.Close();

        }
        catch (SqlException e)
        {
            msError = e.Message;
            if (!consultarCliente(NombreCliente)) msError = "Registro no modificado en la BD";
        }

        //consultar cliente modificado
        

        return msError;

    }

    //Metodo Eliminar
    public string eliminarCliente()
    {
        string msError = "";
        try
        {
            conexion.Close();
            SqlCommand proin = new SqlCommand();
            Conectar();
            proin.Connection = conexion;
            proin.CommandType = System.Data.CommandType.StoredProcedure;
            proin.CommandText = "eliminarCliente";
            proin.Parameters.AddWithValue("@IdCliente", IdCliente);
            SqlDataReader reader = proin.ExecuteReader();
            reader.Close();
            conexion.Close();
        }
        catch (SqlException e)
        {
            msError = e.Message;
        }
        //consultar cliente eliminado
        if (consultarCliente(IdCliente)) msError = "Registro no eliminado en la BD";
        return msError;
    }

    //Metodo Consultar por ID
    public bool  consultarCliente(long idCliente)

    {
        bool encontrado;
        DataTable dt = new DataTable();
        encontrado = false;
            try
            {
                conexion.Close();
                
                SqlCommand proin = new SqlCommand();
                Conectar();
                proin.Connection = conexion;
                proin.CommandType = System.Data.CommandType.StoredProcedure;
                proin.CommandText = "consultarCliente";
                proin.Parameters.AddWithValue("@IdCliente", IdCliente);
                SqlDataReader reader = proin.ExecuteReader();
                reader.Close();
                SqlDataAdapter ad = new SqlDataAdapter(proin);
                ad.Fill(dt);
                conexion.Close();
                if (dt.Rows.Count > 0 )
                {
                encontrado = true;
                }
                else
                {
                encontrado = false;
            }

                reader.Close();
                conexion.Close();
            }
            catch (SqlException)
            {
            
            };

        return encontrado;

    }

    //Metodo Consultar por Nombre
    public bool consultarCliente(string nmCliente)

    {
        bool encontrado;
        DataTable dt = new DataTable();
        encontrado = false;
        try
        {
            conexion.Close();

            SqlCommand proin = new SqlCommand();
            Conectar();
            proin.Connection = conexion;
            proin.CommandType = System.Data.CommandType.StoredProcedure;
            proin.CommandText = "consultarNom";
            proin.Parameters.AddWithValue("@NombreCliente", nmCliente);
            SqlDataReader reader = proin.ExecuteReader();
            reader.Close();
            SqlDataAdapter ad = new SqlDataAdapter(proin);
            ad.Fill(dt);
            conexion.Close();
            if (dt.Rows.Count > 0)
            {
                encontrado = true;
            }
            else
            {
                encontrado = false;
            }

            reader.Close();
            conexion.Close();
        }
        catch (SqlException)
        {

        }

        return encontrado;

    }
}

