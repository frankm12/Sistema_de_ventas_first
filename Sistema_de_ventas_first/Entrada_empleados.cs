using CDConexion;
using Sistema_de_ventas_first;
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
    public partial class Entrada_empleados : Form
    {
        private La_conect conexion = new La_conect();
        bool Editar = false;
        public Entrada_empleados()
        {
            InitializeComponent();
        }

        private void btn_guardar_Click(object sender, EventArgs e, La_conect la_conect)
        {

        }

       
        
        public void limpiarform()
        {
            txt_documento.Clear();
            txt_nombre.Clear();
            txt_apellido.Clear();
            txt_extension.Clear();
            txt_email.Clear();
            txt_cargo.Clear();
        }



        private void btn_editar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                Editar = true;
                txt_documento.Text = dataGridView1.CurrentRow.Cells["documento"].Value.ToString();
                txt_nombre.Text = dataGridView1.CurrentRow.Cells["Nombre"].Value.ToString();
                txt_apellido.Text = dataGridView1.CurrentRow.Cells["Apellido"].Value.ToString();
                txt_extension.Text = dataGridView1.CurrentRow.Cells["extension"].Value.ToString();
                txt_email.Text = dataGridView1.CurrentRow.Cells["Email"].Value.ToString();
                txt_cargo.Text = dataGridView1.CurrentRow.Cells["Cargo"].Value.ToString();
                Cbox_oficina.SelectedValue = dataGridView1.CurrentRow.Cells["Id_oficina"].Value.ToString();

            }
            else
            {
                MessageBox.Show("selecciones una fila a editar por favor");
            }
        }
        private void btn_eliminar_Click(object sender, EventArgs e)
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

                    SqlConnection conexion_a_base_de_datos = conexion.AbrirConexion();
                    SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM empleados", conexion_a_base_de_datos);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);
                    dataGridView1.DataSource = dataTable;
                    conexion.CerrarConexion();
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




        private void Cbox_oficina_SelectedIndexChanged(object sender, EventArgs e)

        {
            SqlConnection sqlConnection = conexion.AbrirConexion();
            SqlConnection conexion_a_base_de_datos = sqlConnection;
            SqlCommand comando = new SqlCommand("SELECT id_oficina, ciudad FROM oficinas", conexion_a_base_de_datos);
            SqlDataReader reader = comando.ExecuteReader();

            DataTable dataTable = new DataTable();
            dataTable.Load(reader);

            Cbox_oficina.DataSource = dataTable;
            Cbox_oficina.DisplayMember = "ciudad";
            Cbox_oficina.ValueMember = "id_oficina";

            conexion.CerrarConexion();
        }


        private void btn_atras_Click(object sender, EventArgs e)
        {
            Menu_princial entrada = new Menu_princial();
            entrada.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Entrada_empleados_Load(object sender, EventArgs e)
        {

        }

        private void btn_guardar2_Click(object sender, EventArgs e)
        
        {

            if (Editar == false)
            {
                try
                {
                    int documento = int.Parse(txt_documento.Text);
                    string nombre = txt_nombre.Text;
                    string apellido = txt_apellido.Text;
                    string extension = txt_extension.Text;
                    string email = txt_email.Text;
                    string cargo = txt_cargo.Text;
                    int oficina = Convert.ToInt32(Cbox_oficina.SelectedValue);

                    Metodo metodos = new Metodo();
                    metodos.insertar_empleados_boton(documento, nombre, apellido, extension, email, cargo, oficina);
                    MessageBox.Show("Empleado agregado correctamente");
                    SqlConnection conexion_a_base_de_datos = conexion.AbrirConexion();
                    SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM empleados", conexion_a_base_de_datos);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);
                    dataGridView1.DataSource = dataTable;
                    conexion.CerrarConexion();
                    limpiarform();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al agregar empleado: " + ex.Message);
                }
            }
            if (Editar == true)
            {

                try
                {

                    Metodo metodos = new Metodo();
                    string Id_empleado = dataGridView1.CurrentRow.Cells["Id_empleado"].Value.ToString();
                    int documento = int.Parse(txt_documento.Text);
                    string nombre = txt_nombre.Text;
                    string apellido = txt_apellido.Text;
                    string extension = txt_extension.Text;
                    string email = txt_email.Text;
                    string cargo = txt_cargo.Text;
                    int oficina = Convert.ToInt32(Cbox_oficina.SelectedValue);
                    metodos.Editar_empleados_boton(documento, nombre, apellido, extension, email, cargo, oficina, Id_empleado);
                    MessageBox.Show("Editado correctamente");

                    SqlConnection conexion_a_base_de_datos = conexion.AbrirConexion();
                    SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM empleados", conexion_a_base_de_datos);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);
                    dataGridView1.DataSource = dataTable;
                    conexion.CerrarConexion();
                    Editar = false;
                    limpiarform();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar empleado: " + ex.Message);
                }
            }

        }
    }
}
