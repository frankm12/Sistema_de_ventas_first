using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Sistema_de_ventas_first
{
    public partial class Entrada_pagos : Form
    {

        private La_conect conexion = new La_conect();
        public int id_pagos;
        private bool Editar = false;
        bool DesdeConsulta = false;

        public Entrada_pagos()
        {
            InitializeComponent();
        }

        public Entrada_pagos(int id_pago, int id_cliente, string numeroFactura, DateTime fechaPago, decimal totalPago, bool desdeconsulta = false)
        {
            InitializeComponent();
            Editar = true;
            id_pagos = id_pago;
            DesdeConsulta = desdeconsulta;

            Cbox_cliente.SelectedValue = id_cliente;
            txt_numero_de_factura.Text = numeroFactura.ToString();
            dtp_fecha.Value = fechaPago;
            txt_total_pago.Text = totalPago.ToString();
        }

        public void LimpiarForm3()
        {
            txt_numero_de_factura.Clear();
            txt_total_pago.Clear();
        }

        private void LlenarComboBox3()
        {
            SqlConnection conexion = null;
            SqlCommand cmd = null;
            SqlDataReader reader = null;

            try
            {
                conexion = this.conexion.AbrirConexion();
                cmd = new SqlCommand("select nombre, id_cliente from clientes", conexion);
                reader = cmd.ExecuteReader();
                DataTable dataTable = new DataTable();
                dataTable.Load(reader);
                Cbox_cliente.DataSource = dataTable;
                Cbox_cliente.DisplayMember = "nombre";
                Cbox_cliente.ValueMember = "id_cliente";
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

        private void btn_guardarp_Click(object sender, EventArgs e)
        {
            try
            {
                int id_pago = id_pagos;
                int id_cliente = Convert.ToInt32(Cbox_cliente.SelectedValue);
                string numeroFactura = txt_numero_de_factura.Text;
                DateTime fechaPago = Convert.ToDateTime(dtp_fecha.Value);
                decimal totalPago = Convert.ToDecimal(txt_total_pago.Text);



                Metodo metodo = new Metodo();

                if (!Editar)
                {
                    metodo.Insertar_pago(id_cliente, numeroFactura, fechaPago, totalPago);
                    MessageBox.Show("Pago agregado correctamente");
                }
                else
                {
                    metodo.Editar_pagos_boton(id_pago, id_cliente, numeroFactura, fechaPago, totalPago);
                    MessageBox.Show("Pago editado correctamente");
                    Editar = false;
                }

                LimpiarForm3();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar pago: " + ex.Message);
            }
        }

        private void Entrada_pagos_Load(object sender, EventArgs e)
        {
            LlenarComboBox3();
            DeshabilitarTodo();
        }

        private void btn_atras_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btn_habilitar_Click(object sender, EventArgs e)
        {
            HabilitarTodo();
        }
        public void DeshabilitarTodo()
        {

            Cbox_cliente.Enabled = false;
            txt_numero_de_factura.Enabled = false;
            dtp_fecha.Enabled = false;
            txt_total_pago.Enabled = false;
        }

        public void HabilitarTodo()
        {
            Cbox_cliente.Enabled = true;
            txt_numero_de_factura.Enabled = true;
            dtp_fecha.Enabled = true;
            txt_total_pago.Enabled = true;
        }
    }
}
