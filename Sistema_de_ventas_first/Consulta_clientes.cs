using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_ventas_first
{
    public partial class Consulta_clientes : Form
    {
        private La_conect conexion_2 = new La_conect();

        public Consulta_clientes()
        {
            InitializeComponent();
        }



        private void btnguardar_Click(object sender, EventArgs e)
        {

        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dataGridView1.SelectedRows[0];
                int id_clientes = int.Parse(row.Cells["id_cliente"].Value.ToString());
                string empresa = row.Cells["empresa"].Value.ToString();
                string apellido = row.Cells["apellido"].Value.ToString();
                string nombre = row.Cells["nombre"].Value.ToString();
                string telefono = row.Cells["telefono"].Value.ToString();
                string direccion = row.Cells["direccion"].Value.ToString();
                string ciudad = row.Cells["ciudad"].Value.ToString();
                string departamento = row.Cells["departamento"].Value.ToString();
                int codigoPostal = int.Parse(row.Cells["codigoPostal"].Value.ToString());
                string pais = row.Cells["pais"].Value.ToString();
                int empleadoAtiende = int.Parse(row.Cells["empleadoAtiende"].Value.ToString());

                Entrada_clientes entradaEmpleadosForm = new Entrada_clientes(id_clientes, empresa, apellido, nombre, telefono, direccion, ciudad, departamento, codigoPostal, pais, empleadoAtiende, true);
                entradaEmpleadosForm.Show();

            }
            else
            {
                MessageBox.Show("Por favor, selecciona una fila para editar.");
            }
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {

            if (dataGridView1.SelectedRows.Count > 0)
            {
                try
                {
                    int id_cliente = Convert.ToInt32(0);
                    Metodo metodos = new Metodo();
                    id_cliente = Convert.ToInt32(dataGridView1.CurrentRow.Cells["id_cliente"].Value.ToString());
                    metodos.Eliminar_clientes(id_cliente);
                    MessageBox.Show("Eliminado correctamente");

                    SqlConnection conexion_a_base_de_datos = conexion_2.AbrirConexion();
                    SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM clientes", conexion_a_base_de_datos);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);
                    dataGridView1.DataSource = dataTable;
                    conexion_2.CerrarConexion();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar cliente: " + ex.Message);
                }

            }
            else
            {
                MessageBox.Show("selecciones una fila para eliminar por favor");
            }
        }

        private void btn_cargar_Click(object sender, EventArgs e)
        {
            ActualizarDatagrid();
        }

        private void Consulta_clientes_Load(object sender, EventArgs e)
        {
            ActualizarDatagrid();
        }
        public void ActualizarDatagrid()
        {

            SqlConnection conexion_a_base_de_datos = conexion_2.AbrirConexion();
            SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM clientes", conexion_a_base_de_datos);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            conexion_2.CerrarConexion();

        }

        private void btn_atras_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
