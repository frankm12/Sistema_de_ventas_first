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
        private SqlCommand comando = new SqlCommand();

        public void Insertar_empleados(string documento, string nombre, string apellido, string extension, string email, string cargo, int oficina)
        {
            SqlConnection conexion_a_basededatos = conexion.AbrirConexion();
            try
            {
                comando.Connection = conexion_a_basededatos;
                comando.CommandText = "AgregarEmpleado";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Clear();
                comando.Parameters.AddWithValue("@documento", documento);
                comando.Parameters.AddWithValue("@nombre", nombre);
                comando.Parameters.AddWithValue("@apellido", apellido);
                comando.Parameters.AddWithValue("@extension", extension);
                comando.Parameters.AddWithValue("@email", email);
                comando.Parameters.AddWithValue("@cargo", cargo);
                comando.Parameters.AddWithValue("@id_oficina", oficina);
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar empleado: " + ex.Message);
            }
            finally
            {
                conexion.CerrarConexion();
            }
        }
        public void Insertar_empleados_boton(string documento, string nombre, string apellido, string extension, string email, string cargo, int oficina)
        {
            Insertar_empleados(documento, nombre, apellido, extension, email, cargo, oficina);
        }

        public void Eliminar_empleados(int id)
        {
            SqlConnection conexion_a_basededatos = conexion.AbrirConexion();
            try
            {
                comando.Connection = conexion_a_basededatos;
                comando.CommandText = "EliminarEmpleado";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Clear();
                comando.Parameters.AddWithValue("@idpro", id);
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar empleado: " + ex.Message);
            }
            finally
            {
                conexion.CerrarConexion();
            }
        }
        public void Eliminar_empleados_boton(string id)
        {
            Eliminar_empleados(Convert.ToInt32(id));
        }

        public void Editar_empleados(string documento, string nombre, string apellido, string extension, string email, string cargo, int oficina, int id_empleado)
        {
            SqlConnection conexion_a_basededatos = conexion.AbrirConexion();
            try
            {
                comando.Connection = conexion_a_basededatos;
                comando.CommandText = "EditarEmpleado";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Clear();
                comando.Parameters.AddWithValue("@documento", documento);
                comando.Parameters.AddWithValue("@nombre", nombre);
                comando.Parameters.AddWithValue("@apellido", apellido);
                comando.Parameters.AddWithValue("@extension", extension);
                comando.Parameters.AddWithValue("@email", email);
                comando.Parameters.AddWithValue("@cargo", cargo);
                comando.Parameters.AddWithValue("@id_oficina", oficina);
                comando.Parameters.AddWithValue("@Id_empleado", id_empleado);
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al editar empleado: " + ex.Message);
            }
            finally
            {
                conexion.CerrarConexion();
            }
        }
        public void Editar_empleados_boton(string documento, string nombre, string apellido, string extension, string email, string cargo, int oficina, string id_empleado)
        {
            Editar_empleados(documento, nombre, apellido, extension, email, cargo, oficina, Convert.ToInt32(id_empleado));
        }

        public void Insertar_producto(string nombre, string idLinea, int cantidad, decimal precio)
        {
            SqlConnection conexion_a_basededatos = conexion.AbrirConexion();
            try
            {
                comando.Connection = conexion_a_basededatos;
                comando.CommandText = "AgregarProducto";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Clear();
                comando.Parameters.AddWithValue("@nombreProducto", nombre);
                comando.Parameters.AddWithValue("@id_lineaProducto", idLinea);
                comando.Parameters.AddWithValue("@cantidad", cantidad);
                comando.Parameters.AddWithValue("@precioVenta", precio);
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar producto: " + ex.Message);
            }
            finally
            {
                conexion.CerrarConexion();
            }
        }
        public void Insertar_producto_boton(string nombre, string idLinea, int cantidad, decimal precio)
        {
            Insertar_producto(nombre, idLinea, cantidad, precio);
        }

        public void Editar_producto(int idProducto, string nombre, int idLinea, int cantidad, decimal precio)
        {
            SqlConnection conexion_a_basededatos = conexion.AbrirConexion();
            try
            {
                comando.Connection = conexion_a_basededatos;
                comando.CommandText = "EditarProducto";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Clear();
                comando.Parameters.AddWithValue("@id_producto", idProducto);
                comando.Parameters.AddWithValue("@nombreProducto", nombre);
                comando.Parameters.AddWithValue("@id_lineaProducto", idLinea);
                comando.Parameters.AddWithValue("@cantidad", cantidad);
                comando.Parameters.AddWithValue("@precioVenta", precio);
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al editar producto: " + ex.Message);
            }
            finally
            {
                conexion.CerrarConexion();
            }
        }
        public void Editar_producto_boton(int idProducto, string nombre, int idLinea, int cantidad, decimal precio)
        {
            Editar_producto(Convert.ToInt32(idProducto), nombre, idLinea, cantidad, precio);
        }

        public void Eliminar_producto(string idProducto)
        {
            SqlConnection conexion_a_basededatos = conexion.AbrirConexion();
            try
            {
                comando.Connection = conexion_a_basededatos;
                comando.CommandText = "EliminarProducto";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Clear();
                comando.Parameters.AddWithValue("@id_producto", idProducto);
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar producto: " + ex.Message);
            }
            finally
            {
                conexion.CerrarConexion();
            }
        }
        public void Eliminar_producto_boton(string idProducto)
        {
            Eliminar_producto(idProducto);
        }

        public void Insertar_clientes(string empresa, string apellido, string nombre, string telefono, string direccion, string ciudad, string departamento, int codigoPostal, string pais, int empleadoAtiende)
        {
            SqlConnection conexion_a_basededatos = conexion.AbrirConexion();
            try
            {
                comando.Connection = conexion_a_basededatos;
                comando.CommandText = "Insertarclientes";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Clear();
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
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar cliente: " + ex.Message);
            }
            finally
            {
                conexion.CerrarConexion();
            }
        }

        public void Eliminar_clientes(int id)
        {
            SqlConnection conexion_a_basededatos = conexion.AbrirConexion();
            try
            {
                comando.Connection = conexion_a_basededatos;
                comando.CommandText = "Eliminarclientes";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Clear();
                comando.Parameters.AddWithValue("@Id_cliente", id);
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar cliente: " + ex.Message);
            }
            finally
            {
                conexion.CerrarConexion();
            }
        }

        public void Editar_clientes(string empresa, string apellido, string nombre, string telefono, string direccion, string ciudad, string departamento, int codigoPostal, string pais, int empleadoAtiende)
        {
            SqlConnection conexion_a_basededatos = conexion.AbrirConexion();
            try
            {
                comando.Connection = conexion_a_basededatos;
                comando.CommandText = "Editarclientes";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Clear();
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
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al editar cliente: " + ex.Message);
            }
            finally
            {
                conexion.CerrarConexion();
            }
        }
    }
}