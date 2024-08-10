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
            Entrada_clientes entrada = new Entrada_clientes();
            entrada.Show();
            this.Close();
        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            Entrada_clientes editar = new Entrada_clientes();
            editar.Show();

            this.Close();
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            Entrada_clientes eliminar = new Entrada_clientes();
            eliminar.Show();
            this.Close();
        }

        private void btn_cargar_Click(object sender, EventArgs e)
        {
            SqlConnection conexion_a_base_de_datos = conexion_2.AbrirConexion();
            SqlDataAdapter dataAdapter = new SqlDataAdapter("select * from clientes", conexion_a_base_de_datos);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            conexion_2.CerrarConexion();
        }

        private void Consulta_clientes_Load(object sender, EventArgs e)
        {
            
        }
    }
}
