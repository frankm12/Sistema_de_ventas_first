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
    public partial class Consulta_Ordenes : Form
    {

        private La_conect conexion = new La_conect();

        public Consulta_Ordenes()
        {
            InitializeComponent();
        }

        private void Consulta_Ordenes_Load(object sender, EventArgs e)
        {
            ActualizarDatagrid();
        }
        public void ActualizarDatagrid()
        {

            SqlConnection conexion_a_base_de_datos = conexion.AbrirConexion();
            SqlDataAdapter dataAdapter = new SqlDataAdapter("select * from ordenes", conexion_a_base_de_datos);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            conexion.CerrarConexion();

        }

        private void btn_cargaro_Click(object sender, EventArgs e)
        {
            ActualizarDatagrid();
        }

        private void btn_eliminaro_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                try
                {
                    int id_orden = Convert.ToInt32(0);
                    Metodo metodos = new Metodo();
                    id_orden = Convert.ToInt32(dataGridView1.CurrentRow.Cells["id_orden"].Value.ToString());
                    metodos.Eliminar_pagos_boton(id_orden);
                    MessageBox.Show("Eliminado correctamente");

                    SqlConnection conexion_a_base_de_datos = conexion.AbrirConexion();
                    SqlDataAdapter dataAdapter = new SqlDataAdapter("select * from ordenes", conexion_a_base_de_datos);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);
                    dataGridView1.DataSource = dataTable;
                    conexion.CerrarConexion();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar orden: " + ex.Message);
                }

            }
            else
            {
                MessageBox.Show("selecciones una fila para eliminar por favor");
            }
        }

        private void btn_editaro_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    DataGridViewRow row = dataGridView1.SelectedRows[0];
                    int id_orden = Convert.ToInt32(row.Cells["id_orden"].Value.ToString());
                    DateTime fechaRecibido = Convert.ToDateTime(row.Cells["fechaRecibido"].Value.ToString());
                    DateTime fechaLimiteEntrega = Convert.ToDateTime(row.Cells["fechaLimiteEntrega"].Value.ToString());
                    DateTime fechaEntrega = Convert.ToDateTime(row.Cells["fechaEntrega"].Value.ToString());
                    string estado = row.Cells["estado"].Value.ToString();
                    string observacion = row.Cells["observacion"].Value.ToString();
                    int id_cliente = Convert.ToInt32(row.Cells["id_cliente"].Value.ToString());

                    Entrada_Ordenes ordenesForm = new Entrada_Ordenes(id_orden, fechaRecibido, fechaLimiteEntrega, fechaEntrega, estado, observacion, id_cliente, true);
                    ordenesForm.Show();

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

        private void btn_atraso_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void lbl_Ordenes_Click(object sender, EventArgs e)
        {

        }
    }
}
