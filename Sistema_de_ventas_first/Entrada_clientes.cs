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
        private La_conect conexion = new La_conect();
        public int Id_clientes;
        private bool Editar = false;
        bool DesdeConsulta = false;

        public Entrada_clientes()
        {
            InitializeComponent();
        }

        public Entrada_clientes(int id_Clientes, string empresa, string apellido, string nombre, string telefono, string direccion, string ciudad, string departamento, int codigoPostal, string pais, int empleadoAtiende, bool desdeconsulta = false)
        {
            InitializeComponent();
            Editar = true;
            Id_clientes = id_Clientes;
            DesdeConsulta = desdeconsulta;

            txt_empresa.Text = empresa;
            txt_nombre_del_cliente.Text = nombre;
            txt_apellido.Text = apellido;
            txt_telefono.Text = telefono;
            txt_direccion.Text = direccion;
            txt_ciudad.Text = ciudad;
            txt_departamento.Text = departamento;
            txt_codigo_postal.Text = codigoPostal.ToString();
            txt_pais.Text = pais;
            Cbox_empleadoAtiende.SelectedValue = empleadoAtiende;
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
            SqlConnection conexion = null;
            SqlCommand cmd = null;
            SqlDataReader reader = null;

            try
            {
                conexion = this.conexion.AbrirConexion();
                cmd = new SqlCommand("select Id_empleado, nombre from empleados", conexion);
                reader = cmd.ExecuteReader();
                DataTable dataTable = new DataTable();
                dataTable.Load(reader);
                Cbox_empleadoAtiende.DataSource = dataTable;
                Cbox_empleadoAtiende.DisplayMember = "nombre";
                Cbox_empleadoAtiende.ValueMember = "Id_empleado";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al llenar el ComboBox: " + ex.Message);
            }
            finally
            {
                if (reader != null) reader.Close();
                if (conexion != null) this.conexion.CerrarConexion();
            }
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            try
            {
                int id_cliente = Id_clientes;
                string empresa = txt_empresa.Text;
                string nombre = txt_nombre_del_cliente.Text;
                string apellido = txt_apellido.Text;
                string telefono = txt_telefono.Text;
                string direccion = txt_direccion.Text;
                string ciudad = txt_ciudad.Text;
                string departamento = txt_departamento.Text;
                int codigoPostal = int.Parse(txt_codigo_postal.Text);
                string pais = txt_pais.Text;
                int empleadoAtiende = Convert.ToInt32(Cbox_empleadoAtiende.SelectedValue);

                Metodo metodo = new Metodo();

                if (!Editar)
                {
                    metodo.Insertar_clientes(empresa, apellido, nombre, telefono, direccion, ciudad, departamento, codigoPostal, pais, empleadoAtiende);
                    MessageBox.Show("Cliente agregado correctamente");
                }
                else
                {
                    metodo.Editar_clientes_boton(id_cliente, empresa, apellido, nombre, telefono, direccion, ciudad, departamento, codigoPostal, pais, empleadoAtiende);
                    MessageBox.Show("Cliente editado correctamente");
                    Editar = false;
                }

                LimpiarForm2();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar cliente: " + ex.Message);
            }
        }

        private void Entrada_clientes_Load(object sender, EventArgs e)
        {
            LlenarComboBox2();
            DeshabilitarTodo();
        }

        private void btn_atras_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Cbox_empleadoAtiende_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Maneja el cambio de selección si es necesario
        }
        public void DeshabilitarTodo()
        {

            txt_empresa.Enabled = false;
            txt_nombre_del_cliente.Enabled = false;
            txt_apellido.Enabled = false;
            txt_telefono.Enabled = false;
            txt_direccion.Enabled = false;
            txt_ciudad.Enabled = false;
            txt_departamento.Enabled = false;
            txt_codigo_postal.Enabled = false;
            txt_pais.Enabled = false;
            Cbox_empleadoAtiende.Enabled = false;
        }

        public void HabilitarTodo()
        {
            txt_empresa.Enabled = true;
            txt_nombre_del_cliente.Enabled = true;
            txt_apellido.Enabled = true;
            txt_telefono.Enabled = true;
            txt_direccion.Enabled = true;
            txt_ciudad.Enabled = true;
            txt_departamento.Enabled = true;
            txt_codigo_postal.Enabled = true;
            txt_pais.Enabled = true;
            Cbox_empleadoAtiende.Enabled = true;
        }

        private void btn_habilitar_Click(object sender, EventArgs e)
        {
            HabilitarTodo();
        }
    }
}