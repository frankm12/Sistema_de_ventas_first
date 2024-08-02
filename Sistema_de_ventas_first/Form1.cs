
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Sistema_de_ventas_first
{
    public partial class Form1 : Form
    {
        private La_conect conexion = new La_conect();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void btingresar_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "SELECT usuario, contraseņa FROM usuarios_ingreso WHERE usuario = @usuario AND contraseņa = @contraseņa";
                string usuario = textBox1.Text;
                string contraseņa = textBox2.Text;

                La_conect conexion = new La_conect();
                SqlConnection conexion_a_base_de_datos = conexion.AbrirConexion();
                SqlCommand comando = new SqlCommand(query, conexion_a_base_de_datos);

                comando.Parameters.AddWithValue("@usuario", usuario);
                comando.Parameters.AddWithValue("@contraseņa", contraseņa);

                SqlDataReader reader = comando.ExecuteReader();

                if (reader.Read())
                {
                    MessageBox.Show("Login Exitoso", "Sistema");
                    Menu_princial principal = new Menu_princial();
                    principal.Show();

                    this.Hide();
                    conexion.CerrarConexion();
                }
                else
                {
                    MessageBox.Show("Login Incorrecto", "Sistema");
                    conexion.CerrarConexion();
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ingresar datos: " + ex.Message);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
