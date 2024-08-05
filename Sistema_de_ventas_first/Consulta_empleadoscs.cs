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
        private La_conect conexion = new La_conect();
        public Consulta_empleadoscs()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Empleados_Load_Click(object sender, EventArgs e)
        {
            SqlConnection conexion_a_base_de_datos = conexion.AbrirConexion();
            SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM empleados", conexion_a_base_de_datos);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            conexion.CerrarConexion();
        }

        private void btn_atras_Click(object sender, EventArgs e)
        {
            Menu_princial principal = new Menu_princial();
            principal.Show();

            this.Hide();
        }

        

    }
}
