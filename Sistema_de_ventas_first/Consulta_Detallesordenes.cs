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
    public partial class Consulta_Detallesordenes : Form
    {

        private La_conect conexion = new La_conect();

        public Consulta_Detallesordenes()
        {
            InitializeComponent();
        }

        private void Consulta_Detallesordenes_Load(object sender, EventArgs e)
        {
            ActualizarDatagrid();
        }

        public void ActualizarDatagrid()
        {

            SqlConnection conexion_a_base_de_datos = conexion.AbrirConexion();
            SqlDataAdapter dataAdapter = new SqlDataAdapter("select * from detallesordenes", conexion_a_base_de_datos);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            conexion.CerrarConexion();

        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                try
                {
                    int id_orden = Convert.ToInt32(0);
                    Metodo metodos = new Metodo();
                    id_orden = Convert.ToInt32(dataGridView1.CurrentRow.Cells["id_orden"].Value.ToString());
                    metodos.Eliminar_detallesordenes_boton(id_orden);
                    MessageBox.Show("Eliminado correctamente");

                    SqlConnection conexion_a_base_de_datos = conexion.AbrirConexion();
                    SqlDataAdapter dataAdapter = new SqlDataAdapter("select * from detallesordenes", conexion_a_base_de_datos);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);
                    dataGridView1.DataSource = dataTable;
                    conexion.CerrarConexion();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar detalles de la orden: " + ex.Message);
                }

            }
            else
            {
                MessageBox.Show("selecciones una fila para eliminar por favor");
            }
        }

        private void btn_atras_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    DataGridViewRow row = dataGridView1.SelectedRows[0];
                    int id_orden = Convert.ToInt32(row.Cells["id_orden"].Value.ToString());
                    int id_producto = Convert.ToInt32(row.Cells["id_producto"].Value.ToString());
                    int cantidadPedida = int.Parse(row.Cells["cantidadPedida"].Value.ToString());
                    decimal valorUnitario = Convert.ToDecimal(row.Cells["valorUnitario"].Value.ToString());
                    DateTime ordenEntrega = Convert.ToDateTime(row.Cells["ordenEntrega"].Value.ToString());

                    Entrada_Detallesordenes Form = new Entrada_Detallesordenes(id_orden, id_producto, cantidadPedida, valorUnitario, ordenEntrega, true);
                    Form.Show();

                }
                else
                {
                    MessageBox.Show("Por favor, selecciona una fila para editar.");
                }
            }
            else
            {
                MessageBox.Show("seleccione una fila para eliminar por favor");
            }
        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            ActualizarDatagrid();
        }
    }
}
