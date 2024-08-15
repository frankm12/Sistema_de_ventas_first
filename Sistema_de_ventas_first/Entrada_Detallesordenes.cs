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
    public partial class Entrada_Detallesordenes : Form
    {

        private La_conect conexion = new La_conect();
        public int Id_orden;
        private bool Editar = false;
        bool DesdeConsulta = false;

        public Entrada_Detallesordenes()
        {
            InitializeComponent();
        }

        public Entrada_Detallesordenes(int id_orden, int id_producto, int cantidadPedida, decimal valorUnitario, DateTime ordenEntrega, bool desdeconsulta = false)
        {
            InitializeComponent();
            Editar = true;
            Id_orden = id_orden;
            DesdeConsulta = desdeconsulta;

            Cbox_idorden.SelectedValue = id_orden;
            Cbox_id_producto2.SelectedValue = id_producto;
            txt_cantidadpedida.Text = cantidadPedida.ToString();
            txt_valorunitario.Text = valorUnitario.ToString();
            dtp_ordenentrega.Value = ordenEntrega;
        }

        private void LimpiarForm()
        {
            txt_cantidadpedida.Clear();
            txt_valorunitario.Clear();
        }

        private void LlenarComboBox()
        {
            SqlConnection conexion = null;
            SqlCommand cmd = null;
            SqlDataReader reader = null;

            try
            {
                conexion = this.conexion.AbrirConexion();
                cmd = new SqlCommand("select id_orden from ordenes", conexion);
                reader = cmd.ExecuteReader();
                DataTable dataTable = new DataTable();
                dataTable.Load(reader);
                Cbox_idorden.DataSource = dataTable;
                Cbox_idorden.DisplayMember = "id_orden";
                Cbox_idorden.ValueMember = "id_orden";
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

        private void LlenarComboBox2()
        {
            SqlConnection conexion = null;
            SqlCommand cmd = null;
            SqlDataReader reader = null;

            try
            {
                conexion = this.conexion.AbrirConexion();
                cmd = new SqlCommand("select id_producto from productos", conexion);
                reader = cmd.ExecuteReader();
                DataTable dataTable = new DataTable();
                dataTable.Load(reader);
                Cbox_id_producto2.DataSource = dataTable;
                Cbox_id_producto2.DisplayMember = "id_producto";
                Cbox_id_producto2.ValueMember = "id_producto";
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

        private void btn_atras_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Entrada_Detallesordenes_Load(object sender, EventArgs e)
        {
            LlenarComboBox();
            LlenarComboBox2();
            DeshabilitarTodo();
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            try
            {
                int id_orden = Convert.ToInt32(Cbox_idorden.SelectedValue);
                int id_producto = Convert.ToInt32(Cbox_id_producto2.SelectedValue);
                int cantidadPedida = int.Parse(txt_cantidadpedida.Text);
                decimal valorUnitario = Convert.ToDecimal(txt_valorunitario.Text);
                DateTime ordenEntrega = Convert.ToDateTime(dtp_ordenentrega.Value);

                Metodo metodo = new Metodo();

                if (!Editar)
                {
                    metodo.Insertar_detallesordenes_boton(id_orden, id_producto, cantidadPedida, valorUnitario, ordenEntrega);
                    MessageBox.Show("Detalles agregados correctamente");
                }
                else
                {
                    metodo.Editar_detallesordenes_boton(id_orden, id_producto, cantidadPedida, valorUnitario, ordenEntrega);
                    MessageBox.Show("Detalles editados correctamente");
                    Editar = false;
                }

                LimpiarForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar detalles de orden: " + ex.Message);
            }

        }
        public void DeshabilitarTodo()
        {
            Cbox_idorden.Enabled = false;
            Cbox_id_producto2.Enabled = false;
            txt_cantidadpedida.Enabled = false;
            txt_valorunitario.Enabled = false;
            dtp_ordenentrega.Enabled = false;
        }

        public void HabilitarTodo()
        {
            Cbox_idorden.Enabled = true;
            Cbox_id_producto2.Enabled = true;
            txt_cantidadpedida.Enabled = true;
            txt_valorunitario.Enabled = true;
            dtp_ordenentrega.Enabled = true;
        }

        private void btn_habilitar_Click(object sender, EventArgs e)
        {
            HabilitarTodo();
        }
    }
}
