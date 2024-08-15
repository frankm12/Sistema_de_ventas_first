
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
        // aqui hacemos las herencias de la clase conexion dandole una variable llamada conexion_2
        private La_conect conexion_2 = new La_conect();
        // aqui ponemos una variable vacia tipo string antes de inicializar el codigo con el fin de
        // almacenar datos en el futuro y poder convertirlos
        string Id_empleado = "";
        bool Editar = false;
        bool DesdeConsulta = false;
        private Consulta_empleadoscs consulta12 = new Consulta_empleadoscs();
        public Entrada_empleados()
        {
            InitializeComponent();
        }

        public Entrada_empleados(string idEmpleado, string documento, string nombre, string apellido, string extension, string email, string cargo, int idOficina, bool desdeConsulta = false)
        {
            InitializeComponent();
            Editar = true;
            Id_empleado = idEmpleado;
            DesdeConsulta = desdeConsulta;

            txt_documento.Text = documento.ToString();
            txt_nombre.Text = nombre;
            txt_apellido.Text = apellido;
            txt_extension.Text = extension;
            txt_email.Text = email;
            txt_cargo.Text = cargo;
            Cbox_oficina.SelectedValue = idOficina;
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

        private void Cbox_oficina_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_atras_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void LlenarComboBox()
        {
            SqlConnection conexion = conexion_2.AbrirConexion();
            SqlCommand comando = new SqlCommand("SELECT id_oficina, ciudad FROM oficinas", conexion);
            SqlDataReader reader = comando.ExecuteReader();

            DataTable dataTable = new DataTable();
            dataTable.Load(reader);

            Cbox_oficina.DataSource = dataTable;
            Cbox_oficina.DisplayMember = "ciudad";
            Cbox_oficina.ValueMember = "id_oficina";

            conexion_2.CerrarConexion();
        }

        private void Entrada_empleados_Load(object sender, EventArgs e)
        {
            LlenarComboBox();
        }

        private void btn_guardar2_Click(object sender, EventArgs e)
        {
            if (Editar == false)
            {
                try
                {
                    string documento = txt_documento.Text;
                    string nombre = txt_nombre.Text;
                    string apellido = txt_apellido.Text;
                    string extension = txt_extension.Text;
                    string email = txt_email.Text;
                    string cargo = txt_cargo.Text;
                    int oficina = Convert.ToInt32(Cbox_oficina.SelectedValue);

                    Metodo metodos = new Metodo();
                    metodos.Insertar_empleados(documento, nombre, apellido, extension, email, cargo, oficina);
                    MessageBox.Show("Empleado agregado correctamente");
                    limpiarform();
                    consulta12.ActualizarDatagrid();

                }


                catch (Exception ex)
                {
                    MessageBox.Show("Error al agregar empleado: " + ex.Message);
                }
            }
            else
            {
                try
                {
                    Metodo metodos = new Metodo();
                    string documento = txt_documento.Text;
                    string nombre = txt_nombre.Text;
                    string apellido = txt_apellido.Text;
                    string extension = txt_extension.Text;
                    string email = txt_email.Text;
                    string cargo = txt_cargo.Text;
                    int oficina = Convert.ToInt32(Cbox_oficina.SelectedValue);
                    metodos.Editar_empleados_boton(documento, nombre, apellido, extension, email, cargo, oficina, Id_empleado);

                    MessageBox.Show("Editado correctamente");

                    Editar = false;
                    limpiarform();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al editar empleado: " + ex.Message);
                }
            }
        }

        private void lbl_cargo_Click(object sender, EventArgs e)
        {

        }

        private void txt_documento_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_cargo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

