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
        public void Editar_empleados_boton(string documento, string nombre, string apellido, string extension, string email, string cargo, int oficina, int id_empleado)
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

        public void Editar_producto(int idProducto, string nombre, string idLinea, int cantidad, decimal precio)
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
        public void Editar_producto_boton(int idProducto, string nombre, string idLinea, int cantidad, decimal precio)
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

        public void Editar_clientes(int id_Cliente,string empresa, string apellido, string nombre, string telefono, string direccion, string ciudad, string departamento, int codigoPostal, string pais, int empleadoAtiende)
        {
            SqlConnection conexion_a_basededatos = conexion.AbrirConexion();
            try
            {
                comando.Connection = conexion_a_basededatos;
                comando.CommandText = "Editarclientes";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Clear();
                comando.Parameters.AddWithValue("@id_cliente", id_Cliente);
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

        public void Editar_clientes_boton(int id_Cliente, string empresa, string apellido, string nombre, string telefono, string direccion, string ciudad, string departamento, int codigoPostal, string pais, int empleadoAtiende)
        {
            Editar_clientes(Convert.ToInt32(id_Cliente),empresa, apellido, nombre, telefono, direccion, ciudad, departamento, Convert.ToInt32(codigoPostal), pais, Convert.ToInt32(empleadoAtiende));
        }

        public void Insertar_pago(int id_cliente, string numeroFactura, DateTime fechaPago, decimal totalPago)
        {
            SqlConnection conexion_a_base_de_datos = conexion.AbrirConexion();
            try
            {
                comando.Connection = conexion_a_base_de_datos;
                comando.CommandText = "Insertarpagos";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Clear();
                comando.Parameters.AddWithValue("@id_cliente", id_cliente);
                comando.Parameters.AddWithValue("@numeroFactura", numeroFactura);
                comando.Parameters.AddWithValue("@fechaPago", fechaPago);
                comando.Parameters.AddWithValue("@totalPago", totalPago);
                comando.ExecuteNonQuery();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar pago: " + ex.Message);
            }

            finally
            {
                conexion.CerrarConexion();
            }
        }
        public void Insertar_pagos_boton(int id_cliente, string numeroFactura, DateTime fechaPago, decimal totalPago)
        {
            Insertar_pago(id_cliente, numeroFactura, fechaPago, totalPago);
        }

        public void Eliminar_pagos(int id)
        {
            SqlConnection conexion_a_basededatos = conexion.AbrirConexion();
            try
            {
                comando.Connection = conexion_a_basededatos;
                comando.CommandText = "Eliminarpagos";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Clear();
                comando.Parameters.AddWithValue("@id_pago", id);
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar pago: " + ex.Message);
            }
            finally
            {
                conexion.CerrarConexion();
            }
        }

        public void Eliminar_pagos_boton(int id)
        {
            Eliminar_pagos(Convert.ToInt32(id));
        }

        public void Editar_pagos(int id_pago, int id_cliente, string numeroFactura, DateTime fechaPago, decimal totalPago)
        {
            SqlConnection conexion_a_basededatos = conexion.AbrirConexion();
            try
            {
                comando.Connection = conexion_a_basededatos;
                comando.CommandText = "Editarpagos";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Clear();
                comando.Parameters.AddWithValue("@id_pago", id_pago);
                comando.Parameters.AddWithValue("@id_cliente", id_cliente);
                comando.Parameters.AddWithValue("@numeroFactura", numeroFactura);
                comando.Parameters.AddWithValue("@fechaPago", fechaPago);
                comando.Parameters.AddWithValue("@totalPago", totalPago);
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al editar pago: " + ex.Message);
            }
            finally
            {
                conexion.CerrarConexion();
            }
        }

        public void Editar_pagos_boton(int id_pago, int id_cliente, string numeroFactura, DateTime fechaPago, decimal totalPago)
        {
            Editar_pagos(Convert.ToInt32(id_pago),Convert.ToInt32(id_cliente), numeroFactura, fechaPago, totalPago);
        }

        public void Insertar_ordenes(DateTime fechaRecibido, DateTime fechaLimiteEntrega, DateTime fechaEntrega, string estado, string observacion, int id_cliente)
        {
            SqlConnection conexion_a_base_de_datos = conexion.AbrirConexion();
            try
            {
                comando.Connection = conexion_a_base_de_datos;
                comando.CommandText = "Insertarordenes";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Clear();
                comando.Parameters.AddWithValue("@fechaRecibido", fechaRecibido);
                comando.Parameters.AddWithValue("@fechaLimiteEntrega", fechaLimiteEntrega);
                comando.Parameters.AddWithValue("@fechaEntrega", fechaEntrega);
                comando.Parameters.AddWithValue("@estado", estado);
                comando.Parameters.AddWithValue("observacion", observacion);
                comando.Parameters.AddWithValue("@id_cliente", id_cliente);
                comando.ExecuteNonQuery();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar orden: " + ex.Message);
            }

            finally
            {
                conexion.CerrarConexion();
            }
        }
        public void Insertar_ordenes_boton(DateTime fechaRecibido, DateTime fechaLimiteEntrega, DateTime fechaEntrega, string estado, string observacion, int id_cliente)
        {
            Insertar_ordenes(fechaRecibido, fechaLimiteEntrega, fechaEntrega, estado, observacion, id_cliente);
        }

        public void Eliminar_ordenes(int id)
        {
            SqlConnection conexion_a_basededatos = conexion.AbrirConexion();
            try
            {
                comando.Connection = conexion_a_basededatos;
                comando.CommandText = "Eliminarordenes";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Clear();
                comando.Parameters.AddWithValue("@id_orden", id);
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar orden: " + ex.Message);
            }
            finally
            {
                conexion.CerrarConexion();
            }
        }

        public void Eliminar_ordenes_boton(int id)
        {
            Eliminar_ordenes(Convert.ToInt32(id));
        }

        public void Editar_ordenes(int id_orden, DateTime fechaRecibido, DateTime fechaLimiteEntrega, DateTime fechaEntrega, string estado, string observacion, int id_cliente)
        {
            SqlConnection conexion_a_basededatos = conexion.AbrirConexion();
            try
            {
                comando.Connection = conexion_a_basededatos;
                comando.CommandText = "Editarordenes";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Clear();
                comando.Parameters.AddWithValue("@id_orden", id_orden);
                comando.Parameters.AddWithValue("@fechaRecibido", fechaRecibido);
                comando.Parameters.AddWithValue("@fechaLimiteEntrega", fechaLimiteEntrega);
                comando.Parameters.AddWithValue("@fechaEntrega", fechaEntrega);
                comando.Parameters.AddWithValue("@estado", estado);
                comando.Parameters.AddWithValue("observacion", observacion);
                comando.Parameters.AddWithValue("@id_cliente", id_cliente);
                comando.ExecuteNonQuery();
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al editar orden: " + ex.Message);
            }
            finally
            {
                conexion.CerrarConexion();
            }
        }

        public void Editar_ordenes_boton(int id_orden, DateTime fechaRecibido, DateTime fechaLimiteEntrega, DateTime fechaEntrega, string estado, string observacion, int id_cliente)
        {
            Editar_ordenes(Convert.ToInt32(id_orden), fechaRecibido, fechaLimiteEntrega, fechaEntrega, estado, observacion, Convert.ToInt32(id_cliente));
        }

        public void Insertar_detallesordenes(int id_orden, int id_producto, int cantidadPedida, decimal valorUnitario, DateTime ordenEntrega)
        {
            SqlConnection conexion_a_base_de_datos = conexion.AbrirConexion();
            try
            {
                comando.Connection = conexion_a_base_de_datos;
                comando.CommandText = "Insertardetallesordenes";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Clear();
                comando.Parameters.AddWithValue("@id_orden", id_orden);
                comando.Parameters.AddWithValue("@id_producto", id_producto);
                comando.Parameters.AddWithValue("@cantidadPedida", cantidadPedida);
                comando.Parameters.AddWithValue("@valorUnitario", valorUnitario);
                comando.Parameters.AddWithValue("ordenEntrega", ordenEntrega);
                comando.ExecuteNonQuery();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar detalles de orden: " + ex.Message);
            }

            finally
            {
                conexion.CerrarConexion();
            }
        }

        public void Insertar_detallesordenes_boton(int id_orden, int id_producto, int cantidadPedida, decimal valorUnitario, DateTime ordenEntrega)
        {
            Insertar_detallesordenes(id_orden, id_producto, cantidadPedida, valorUnitario, ordenEntrega);
        }

        public void Eliminar_detallesordenes(int id)
        {
            SqlConnection conexion_a_basededatos = conexion.AbrirConexion();
            try
            {
                comando.Connection = conexion_a_basededatos;
                comando.CommandText = "Eliminardetallesordenes";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Clear();
                comando.Parameters.AddWithValue("@id_orden", id);
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar detalles de orden: " + ex.Message);
            }
            finally
            {
                conexion.CerrarConexion();
            }
        }

        public void Eliminar_detallesordenes_boton(int id)
        {
            Eliminar_detallesordenes(Convert.ToInt32(id));
        }

        public void Editar_detallesordenes(int id_orden, int id_producto, int cantidadPedida, decimal valorUnitario, DateTime ordenEntrega)
        {
            SqlConnection conexion_a_basededatos = conexion.AbrirConexion();
            try
            {
                comando.Connection = conexion_a_basededatos;
                comando.CommandText = "Editardetallesordenes";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Clear();
                comando.Parameters.AddWithValue("@id_orden", id_orden);
                comando.Parameters.AddWithValue("@id_producto", id_producto);
                comando.Parameters.AddWithValue("@cantidadPedida", cantidadPedida);
                comando.Parameters.AddWithValue("@valorUnitario", valorUnitario);
                comando.Parameters.AddWithValue("@ordenEntrega", ordenEntrega);
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al editar detalles de orden: " + ex.Message);
            }
            finally
            {
                conexion.CerrarConexion();
            }
        }

        public void Editar_detallesordenes_boton(int id_orden, int id_producto, int cantidadPedida, decimal valorUnitario, DateTime ordenEntrega)
        {
            Editar_detallesordenes(id_orden, id_producto, cantidadPedida, valorUnitario, ordenEntrega);
        }
    }
}