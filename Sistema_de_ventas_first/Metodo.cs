using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Text.RegularExpressions;
using System.Windows.Forms;



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
            comando.Parameters.AddWithValue("@id_oficina", oficina);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }

        public void Insertar_empleados_boton(int documento, string nombre, string apellido, string extension, string email, string cargo, int oficina)
        {
            Insertar_empleados(documento, nombre, apellido, extension, email, cargo, oficina);
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
            conexion.CerrarConexion();
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
            comando.Parameters.AddWithValue("@id_oficina", oficina);
            comando.Parameters.AddWithValue("@Id_empleado", id_empleado);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }

        public void Editar_empleados_boton(int documento, string nombre, string apellido, string extension, string email, string cargo, int oficina, string id_empleado)
        {
            Editar_empleados(documento, nombre, apellido, extension, email, cargo, oficina, Convert.ToInt32(id_empleado));
        }

        public void Insertar_producto(string idProducto, string nombre, int idLinea, int cantidad, decimal precio)
        {
            
                try
                {
                    using (SqlConnection conexion_a_base_de_datos = conexion.AbrirConexion())
                    {
                        comando.Connection = conexion_a_base_de_datos;
                        comando.CommandText = "AgregarProducto";
                        comando.CommandType = CommandType.StoredProcedure;
                        comando.Parameters.Clear();
                        comando.Parameters.AddWithValue("@id_producto", idProducto);
                        comando.Parameters.AddWithValue("@nombreProducto", nombre);
                        comando.Parameters.AddWithValue("@id_lineaProducto", idLinea);
                        comando.Parameters.AddWithValue("@cantidad", cantidad);
                        comando.Parameters.AddWithValue("@precioVenta", precio);
                        comando.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al agregar producto: " + ex.Message);
                }
        }

            public void Insertar_producto_boton(string idProducto, string nombre, int idLinea, int cantidad, decimal precio)
        {
            Insertar_producto(idProducto, nombre, idLinea, cantidad, precio);
        }

        public void Editar_producto(string idProducto, string nombre, int idLinea, int cantidad, decimal precio)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EditarProducto"; 
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@id_producto", idProducto);
            comando.Parameters.AddWithValue("@nombreProducto", nombre);
            comando.Parameters.AddWithValue("@id_lineaProducto", idLinea);
            comando.Parameters.AddWithValue("@cantidad", cantidad);
            comando.Parameters.AddWithValue("@precioVenta", precio);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }

        public void Editar_producto_boton(string idProducto, string nombre, int idLinea, int cantidad, decimal precio)
        {
            Editar_producto(idProducto, nombre, idLinea, cantidad, precio);
        }

        public void Eliminar_producto(string idProducto)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EliminarProducto";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@id_producto", idProducto);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }

        public void Eliminar_producto_boton(string idProducto)
        {
            Eliminar_producto(idProducto);
        }

        public void Insertar_clientes(string empresa, string apellido, string nombre, string telefono, string direccion, string ciudad, string departamento, int codigoPostal, string pais, int empleadoAtiende)
        {
            SqlConnection conexion_a_base_de_datos = new SqlConnection();
            comando.Connection = conexion_2.AbrirConexion();
            comando.CommandText = "Insertarclientes";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@empresa", empresa);
            comando.Parameters.AddWithValue("@apellido", apellido);
            comando.Parameters.AddWithValue("@nombre", nombre);
            comando.Parameters.AddWithValue("@telefono", telefono);
            comando.Parameters.AddWithValue("@direccion", direccion);
            comando.Parameters.AddWithValue("@ciudad", ciudad);
            comando.Parameters.AddWithValue("@departamento", departamento);
            comando.Parameters.AddWithValue("@codigoPostal", codigoPostal);
            comando.Parameters.AddWithValue("@pais", pais);
            comando.Parameters.AddWithValue("@empleadoAtiende", empleadoAtiende);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }

        public void Insertar_clientes_boton(string empresa, string apellido, string nombre, string telefono, string direccion, string ciudad, string departamento, int codigoPostal, string pais, int empleadoAtiende)
        {
            Insertar_clientes(empresa, apellido, nombre, telefono, direccion, ciudad, departamento, Convert.ToInt32(codigoPostal), pais, empleadoAtiende);
        }

        public void Eliminar_clientes(int Id)
        {
            SqlConnection conexion_a_base_de_datos = new SqlConnection();
            comando.Connection = conexion_2.AbrirConexion();
            comando.CommandText = "Eliminarclientes";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Id_cliente", Id);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }

        public void Eliminar_clientes_boton(int Id)
        {
            Eliminar_clientes(Convert.ToInt32(Id));
        }

        public void Editar_clientes(string empresa, string apellido, string nombre, string telefono, string direccion, string ciudad, string departamento, int codigoPostal, string pais, int empleadoAtiende)
        {
            SqlConnection conexion_a_base_de_datos = new SqlConnection();
            comando.Connection = conexion_2.AbrirConexion();
            comando.CommandText = "Editarclientes";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@empresa", empresa);
            comando.Parameters.AddWithValue("@apellido", apellido);
            comando.Parameters.AddWithValue("@nombre", nombre);
            comando.Parameters.AddWithValue("@telefono", telefono);
            comando.Parameters.AddWithValue("@direccion", direccion);
            comando.Parameters.AddWithValue("@ciudad", ciudad);
            comando.Parameters.AddWithValue("@departamento", departamento);
            comando.Parameters.AddWithValue("@codigoPostal", codigoPostal);
            comando.Parameters.AddWithValue("@pais", pais);
            comando.Parameters.AddWithValue("@empleadoAtiende", empleadoAtiende);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }
        public void Editar_clientes_boton(string empresa, string apellido, string nombre, string telefono, string direccion, string ciudad, string departamento, int codigoPostal, string pais, int empleadoAtiende)
        {
            Editar_clientes(empresa, apellido, nombre, telefono, direccion, ciudad, departamento, Convert.ToInt32(codigoPostal), pais, Convert.ToInt32(empleadoAtiende));
        }
    }
}