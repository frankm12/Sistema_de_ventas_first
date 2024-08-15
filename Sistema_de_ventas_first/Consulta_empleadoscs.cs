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
    public partial class Consulta_empleadoscs : Form
    {
        private La_conect conexion_2 = new La_conect();
        public Consulta_empleadoscs()
        {
            InitializeComponent();
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void ActualizarDatagrid()
        {

            SqlConnection conexion_a_base_de_datos = conexion_2.AbrirConexion();
            SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM empleados", conexion_a_base_de_datos);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            conexion_2.CerrarConexion();

        }
        private void Empleados_Load_Click(object sender, EventArgs e)
        {
            ActualizarDatagrid();
        }

        private void btn_atras_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void bt_editar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dataGridView1.SelectedRows[0];
                int idEmpleado = int.Parse(row.Cells["Id_empleado"].Value.ToString());
                string documento = row.Cells["documento"].Value.ToString();
                string nombre = row.Cells["nombre"].Value.ToString();
                string apellido = row.Cells["apellido"].Value.ToString();
                string extension = row.Cells["extension"].Value.ToString();
                string email = row.Cells["email"].Value.ToString();
                string cargo = row.Cells["cargo"].Value.ToString();
                int idOficina = int.Parse(row.Cells["id_oficina"].Value.ToString());

                Entrada_empleados entradaEmpleadosForm = new Entrada_empleados(idEmpleado, documento, nombre, apellido, extension, email, cargo, idOficina, true);
                entradaEmpleadosForm.Show();


            }
            else
            {
                MessageBox.Show("Por favor, selecciona una fila para editar.");
            }
        }

        private void bt_eliminar_Click(object sender, EventArgs e)
        {

            if (dataGridView1.SelectedRows.Count > 0)
            {
                try
                {
                    string Id_empleado = null;
                    Metodo metodos = new Metodo();
                    Id_empleado = dataGridView1.CurrentRow.Cells["Id_empleado"].Value.ToString();
                    metodos.Eliminar_empleados_boton(Id_empleado);
                    MessageBox.Show("Eliminado correctamente");

                    SqlConnection conexion_a_base_de_datos = conexion_2.AbrirConexion();
                    SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM empleados", conexion_a_base_de_datos);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);
                    dataGridView1.DataSource = dataTable;
                    conexion_2.CerrarConexion();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar empleado: " + ex.Message);
                }

            }
            else
            {
                MessageBox.Show("selecciones una fila a editar por favor");
            }
        }

        private void Consulta_empleadoscs_Load(object sender, EventArgs e)
        {
            SqlConnection conexion_a_base_de_datos = conexion_2.AbrirConexion();
            SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM empleados", conexion_a_base_de_datos);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            conexion_2.CerrarConexion();
        }

        private void btn_cargar_Click(object sender, EventArgs e)
        {

            SqlConnection conexion_a_base_de_datos = conexion_2.AbrirConexion();
            SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM empleados", conexion_a_base_de_datos);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            conexion_2.CerrarConexion();

        }
    }

}
