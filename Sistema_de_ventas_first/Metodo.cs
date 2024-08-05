using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Text.RegularExpressions;



namespace Sistema_de_ventas_first
{

    public class Metodo
    {
        private La_conect conexion = new La_conect();
        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();


        public void Insertar_empleados(int documento, string nombre, string apellido, string extension, string email, string cargo, int oficina)
        {
            SqlConnection conexion_a_basededatos = new SqlConnection();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "AgregarEmpleado";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@documento", documento);
            comando.Parameters.AddWithValue("@nombre", nombre);
            comando.Parameters.AddWithValue("@apellido", apellido);
            comando.Parameters.AddWithValue("@extension", extension);
            comando.Parameters.AddWithValue("@email", email);
            comando.Parameters.AddWithValue("@cargo", cargo);
            comando.Parameters.AddWithValue("id_oficina", oficina);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }
        public void insertar_empleados_boton(int documento, string nombre, string apellido, string extension, string email, string cargo, int oficina)
        {
            Insertar_empleados(Convert.ToInt32(documento), nombre, apellido, extension, email, cargo, Convert.ToInt32(oficina));
        }
        public void Eliminar_empleados(int id)
        {
            SqlConnection conexion_a_basededatos = new SqlConnection();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EliminarEmpleado";
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@idpro", id);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }
        public void Eliminar_empleados_boton(string id)
        {
            Eliminar_empleados(Convert.ToInt32(id));
        }
        public void Editar_empleados(int documento, string nombre, string apellido, string extension, string email, string cargo, int oficina, int id_empleado)
        {
            SqlConnection conexion_a_basededatos = new SqlConnection();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EditarEmpleado";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@documento", documento);
            comando.Parameters.AddWithValue("@nombre", nombre);
            comando.Parameters.AddWithValue("@apellido", apellido);
            comando.Parameters.AddWithValue("@extension", extension);
            comando.Parameters.AddWithValue("@email", email);
            comando.Parameters.AddWithValue("@cargo", cargo);
            comando.Parameters.AddWithValue("id_oficina", oficina);
            comando.Parameters.AddWithValue("@Id_empleado", id_empleado);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }
        public void Editar_empleados_boton(int documento, string nombre, string apellido, string extension, string email, string cargo, int oficina, string id_empleado)
        {
            Editar_empleados(Convert.ToInt32(documento), nombre, apellido, extension, email, cargo, Convert.ToInt32(oficina), Convert.ToInt32(id_empleado));
        }
    }
}