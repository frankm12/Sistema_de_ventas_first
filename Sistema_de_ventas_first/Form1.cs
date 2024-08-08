
using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Sistema_de_ventas_first
{
    public partial class Form1 : Form
    {
        private La_conect conexion = new La_conect();

        public Form1()
        {
            InitializeComponent();
            // Asociar el evento KeyDown de los TextBox con el manejador
            textBox1.KeyDown += new KeyEventHandler(textBox_KeyDown);
            textBox2.KeyDown += new KeyEventHandler(textBox_KeyDown);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void btingresar_Click(object sender, EventArgs e)
        {
            Ingresar();
        }

        private void textBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // Evitar el sonido de la tecla Enter en el TextBox
                e.SuppressKeyPress = true;
                Ingresar();
            }
        }

        private void Ingresar()
        {
            try
            {
                string query = "SELECT usuario, contraseña FROM usuarios_ingreso WHERE usuario = @usuario AND contraseña = @contraseña";
                string usuario = textBox1.Text;
                string contraseña = textBox2.Text;

                SqlConnection conexion_a_base_de_datos = conexion.AbrirConexion();
                SqlCommand comando = new SqlCommand(query, conexion_a_base_de_datos);

                comando.Parameters.AddWithValue("@usuario", usuario);
                comando.Parameters.AddWithValue("@contraseña", contraseña);

                SqlDataReader reader = comando.ExecuteReader();

                if (reader.Read())
                {
                    MessageBox.Show("Login Exitoso", "Sistema");
                    Menu_princial principal = new Menu_princial();
                    principal.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Login Incorrecto", "Sistema");
                }

                conexion.CerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ingresar datos: " + ex.Message);
            }
            finally
            {
                conexion.CerrarConexion();
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
