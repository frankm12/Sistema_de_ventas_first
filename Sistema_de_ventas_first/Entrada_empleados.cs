
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
        // point indica que en un punto tendra una locacion en este lo conectaremos al formulario para que no se mueva
        private Point initialLocation;
        public Entrada_empleados()
        {
            InitializeComponent();
        }
        //Aqui traemos las variables del formulario de consulta y se las asiganamos a los text box
        //para que asi aparezcan dentro de estas y poder editar a placer
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
        //este es un metodo para limpiar los texbox, lo llamamos mas adelante para que despues que guardemos los texbox se limpien
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
        //aqui tenemos el boton de atras con dispose para que salga de la ram
        private void btn_atras_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        //aqui tenemos el proceso de llenar el comobo box, en este ejecutamos un comando en la base de datos
        //que en este caso es un select para que escoja los datos que vamos a utilizar de su respectiva tabla
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
        //en el evento load, que es cargar llamamos el metodo de llenar el combo box para que asi
        //cuando abramos el formulario nuestro combo box se refleje
        //tambien tendremos una inicializacion para hacer que el formulario no se mueva
        private void Entrada_empleados_Load(object sender, EventArgs e)
        {
            LlenarComboBox();
            InitializeComponent();
            initialLocation = this.Location;
            this.Move += new EventHandler(Form_Move);
        }
        private void Form_Move(object sender, EventArgs e)
        {
            this.Location = initialLocation;
        }
        //aqui empieza el evento importate guardar que lo tenemos condicionado dentro de un if
        //y con una variable tipo booleano declarada anteriormente para que cuando traigamos nuesto formulario
        //podamos elegir entre una de las dos opciones

        private void btn_guardar2_Click(object sender, EventArgs e)
        {
            if (Editar == false)
            {
                try
                {
                    //primero inicializamos las variables y decimos que son iguales a cada textbox o combobox que vayamos a utilizar
                    string documento = txt_documento.Text;
                    string nombre = txt_nombre.Text;
                    string apellido = txt_apellido.Text;
                    string extension = txt_extension.Text;
                    string email = txt_email.Text;
                    string cargo = txt_cargo.Text;
                    int oficina = Convert.ToInt32(Cbox_oficina.SelectedValue);
                    //aqui hacemos una consulta en metodo y le asignamos la variable llamada "metodos" y decimos que esta variable sera igual
                    // a una nueva consulta dentro del metodo
                    Metodo metodos = new Metodo();
                    //aqui llamamos el proceso de insertar empleados que esta conectado a metodos que este esta conectado a sql
                    metodos.Insertar_empleados_boton(documento, nombre, apellido, extension, email, cargo, oficina);
                    // aqui mostramos un mensaje por pantalla dependiendo de lo que paso en el codigo
                    MessageBox.Show("Empleado agregado correctamente");

                    limpiarform();
                    // aqui llamamos a la referencia consulta que declaramos arriba y llamamos el metodo de actualizarDatagrid
                    consulta12.ActualizarDatagrid();
                }

                //aqui tenemos una captura de errores por si el codigo por alguna extraña razon de error
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
                    //aqui volvemos a poner a la variable tipo booleano editar en false para no siga guardando
                    Editar = false;
                    //aqui llamamos al metodo para limpiar los texbox
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

