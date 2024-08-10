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
        private La_conect conexion_2 = new La_conect();
        string Id_clientes = "";
        bool Editar = false;
        bool DesdeConsulta = false;
        private Consulta_clientes consulta3 = new Consulta_clientes();

        public Entrada_clientes()
        {
            InitializeComponent();
        }

        public Entrada_clientes(string id_clientes, string empresa, string apellido, string nombre, string telefono, string direccion, string ciudad, string departamento, int codigoPostal, string pais, int empleadoAtiende, bool Desdeconsulta = false)
        {
            InitializeComponent();
            Editar = true;
            Id_clientes = id_clientes;
            DesdeConsulta = Desdeconsulta;

            txt_empresa.Text = empresa;
            txt_nombre_del_cliente.Text = nombre;
            txt_apellido.Text = apellido;
            txt_telefono.Text = telefono.ToString();
            txt_direccion.Text = direccion;
            txt_ciudad.Text = ciudad;
            txt_departamento.Text = departamento;
            txt_codigo_postal.Text = codigoPostal.ToString();
            txt_pais.Text = pais;
            Cbox_empleadoAtiende.Text = empleadoAtiende.ToString();
        }

        private void LimpiarForm2()
        {
            txt_empresa.Clear();
            txt_nombre_del_cliente.Clear();
            txt_apellido.Clear();
            txt_telefono.Clear();
            txt_direccion.Clear();
            txt_ciudad.Clear();
            txt_departamento.Clear();
            txt_codigo_postal.Clear();
            txt_pais.Clear();
        }

        private void LlenarComboBox2()
        {
            SqlConnection conexion = conexion_2.AbrirConexion();
            SqlCommand comando = new SqlCommand("select Id_empleado, nombre from empleados", conexion);
            SqlDataReader reader = comando.ExecuteReader();
            DataTable dataTable = new DataTable();
            dataTable.Load(reader);
            Cbox_empleadoAtiende.DataSource = dataTable;
            Cbox_empleadoAtiende.DisplayMember = "nombre";
            Cbox_empleadoAtiende.ValueMember = "Id_empleado";

            conexion_2.CerrarConexion();
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
                    string telefono = txt_telefono.Text;
                    string direccion = txt_direccion.Text;
                    string ciudad = txt_ciudad.Text;
                    string departamento = txt_departamento.Text;
                    int codigoPostal = int.Parse(txt_codigo_postal.Text);
                    string pais = txt_pais.Text;
                    int empleadoAtiende = int.Parse(Cbox_empleadoAtiende.Text);

                    Metodo metodo = new Metodo();
                    metodo.Insertar_clientes_boton(empresa, nombre, apellido, telefono, direccion, ciudad, departamento, codigoPostal, pais, empleadoAtiende);
                    MessageBox.Show("Cliente agregado correctamente");
                    LimpiarForm2();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al agregar cliente: " + ex.Message);
                }
            }
            else
            {
                try
                {
                    Metodo metodos = new Metodo();
                    string empresa = txt_empresa.Text;
                    string nombre = txt_nombre_del_cliente.Text;
                    string apellido = txt_apellido.Text;
                    string telefono = txt_telefono.Text;
                    string direccion = txt_direccion.Text;
                    string ciudad = txt_ciudad.Text;
                    string departamento = txt_departamento.Text;
                    int codigoPostal = int.Parse(txt_codigo_postal.Text);
                    string pais = txt_pais.Text;
                    int empleadoAtiende = int.Parse(Cbox_empleadoAtiende.Text);

                    metodos.Editar_clientes_boton(empresa, nombre, apellido, telefono, direccion, ciudad, departamento, codigoPostal, pais, empleadoAtiende);
                    MessageBox.Show("Editado correctamente");

                    Editar = false;
                    LimpiarForm2();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al editar cliente" + ex.Message);
                }
            }
        }

        private void Entrada_clientes_Load(object sender, EventArgs e)
        {
            LlenarComboBox2();
        }

        private void btn_atras_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
