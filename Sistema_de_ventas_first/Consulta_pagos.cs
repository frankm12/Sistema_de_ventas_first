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
    public partial class Consulta_pagos : Form
    {

        private La_conect conexion = new La_conect();

        public Consulta_pagos()
        {
            InitializeComponent();
        }

        private void Consulta_pagos_Load(object sender, EventArgs e)
        {
            ActualizarDatagrid();
        }

        public void ActualizarDatagrid()
        {

            SqlConnection conexion_a_base_de_datos = conexion.AbrirConexion();
            SqlDataAdapter dataAdapter = new SqlDataAdapter("select * from pagos", conexion_a_base_de_datos);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            conexion.CerrarConexion();

        }

        private void btn_cargar_Click(object sender, EventArgs e)
        {
            ActualizarDatagrid();
        }

        private void btn_eliminarp_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                try
                {
                    int id_pago = Convert.ToInt32(0);
                    Metodo metodos = new Metodo();
                    id_pago = Convert.ToInt32(dataGridView1.CurrentRow.Cells["id_pago"].Value.ToString());
                    metodos.Eliminar_pagos_boton(id_pago);
                    MessageBox.Show("Eliminado correctamente");

                    SqlConnection conexion_a_base_de_datos = conexion.AbrirConexion();
                    SqlDataAdapter dataAdapter = new SqlDataAdapter("select * from pagos", conexion_a_base_de_datos);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);
                    dataGridView1.DataSource = dataTable;
                    conexion.CerrarConexion();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar pago: " + ex.Message);
                }

            }
            else
            {
                MessageBox.Show("selecciones una fila para eliminar por favor");
            }
        }

        private void btn_editarp_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    DataGridViewRow row = dataGridView1.SelectedRows[0];
                    int id_pago = int.Parse(row.Cells["id_pago"].Value.ToString());
                    int id_cliente = int.Parse(row.Cells["id_cliente"].Value.ToString());
                    string numeroFactura = row.Cells["numeroFactura"].Value.ToString();
                    DateTime fechaPago = Convert.ToDateTime(row.Cells["fechaPago"].Value.ToString());
                    decimal totalPago = Convert.ToDecimal(row.Cells["totalPago"].Value.ToString());

                    Entrada_pagos pagosForm = new Entrada_pagos(id_pago, id_cliente, numeroFactura, fechaPago, totalPago, true);
                    pagosForm.Show();

                }
                else
                {
                    MessageBox.Show("Por favor, selecciona una fila para editar.");
                }
            }
            else
            {
                MessageBox.Show("selecciones una fila para eliminar por favor");
            }
        }

        private void btn_atras_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
