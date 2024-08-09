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
    public partial class Entrada_clientes : Form
    {
        private La_conect conexion_4 = new La_conect();

        bool Editar = false;

        public Entrada_clientes()
        {
            InitializeComponent();
        }

        private void LlenarComboBox2()
        {
            SqlConnection conexion = conexion_4.AbrirConexion();
            SqlCommand comando = new SqlCommand("select Id_empleado, nombre from empleados", conexion);
            SqlDataReader reader = comando.ExecuteReader();
            DataTable dataTable = new DataTable();
            dataTable.Load(reader);
            Cbox_empleadoAtiende.DataSource = dataTable;
            Cbox_empleadoAtiende.DisplayMember = "nombre";
            Cbox_empleadoAtiende.ValueMember = "Id_empleado";

            conexion_4.CerrarConexion();
        }
        private void btn_guardar_Click(object sender, EventArgs e)
        {
            if (Editar == false)
            {
                try
                {
                    string empresa = txt_empresa.Text;
                    string nombre = txt_nombre_del_cliente.Text;
                    string apellido = txt_apellido.Text;
                    int telefono = int.Parse(txt_telefono.Text);
                    string direccion = txt_direccion.Text;
                    string ciudad = txt_ciudad.Text;
                    string departamento = txt_departamento.Text;
                    int codigoPostal = int.Parse(txt_codigo_postal.Text);
                    string pais = txt_pais.Text;
                    int empleadoAtiende = int.Parse(Cbox_empleadoAtiende.Text);

                    Metodo metodo = new Metodo();
                    metodo.Insertar_clientes_boton(empresa, nombre, apellido, telefono, direccion, ciudad, departamento, codigoPostal, pais, empleadoAtiende);
                    MessageBox.Show("Cliente agregado correctamente");
                    SqlConnection conexion_a_base_de_datos = conexion_4.AbrirConexion();
                    SqlDataAdapter dataAdapter = new SqlDataAdapter("select * from clientes", conexion_a_base_de_datos);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);
                    dataGridView1.DataSource = dataTable;
                    conexion_4.CerrarConexion();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al agregar cliente: " + ex.Message);
                }
            }
            if (Editar == true)
            {
                Metodo metodo = new Metodo
            }
        }

        private void Entrada_clientes_Load(object sender, EventArgs e)
        {
            SqlConnection conexion_a_base_de_datos = conexion_4.AbrirConexion();
            SqlDataAdapter dataAdapter = new SqlDataAdapter("Select * from clientes", conexion_a_base_de_datos);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            conexion_4.CerrarConexion();
            LlenarComboBox2();

        }
    }
}
