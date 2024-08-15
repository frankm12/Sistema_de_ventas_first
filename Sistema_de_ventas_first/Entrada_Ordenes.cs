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
    public partial class Entrada_Ordenes : Form
    {

        private La_conect conexion = new La_conect();
        public int Id_Orden;
        private bool Editar = false;
        bool DesdeConsulta = false;

        public Entrada_Ordenes()
        {
            InitializeComponent();
        }

        public Entrada_Ordenes(int Id_orden, DateTime fechaRecibido, DateTime fechaLimiteEntrega, DateTime fechaEntrega, string estado, string observacion, int id_cliente, bool desdeconsulta = false)
        {
            InitializeComponent();
            Editar = true;
            Id_Orden = Id_orden;
            DesdeConsulta = desdeconsulta;

            txt_estado.Text = estado;
            txt_observacion.Text = observacion;
            dtp_fechaRecibido.Value = fechaRecibido;
            dtp_fechaLimiteEntrega.Value = fechaLimiteEntrega;
            dtp_fechaEntrega.Value = fechaEntrega;
            Cbox_idcliente.SelectedValue = id_cliente;
        }

        private void btn_atras_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void LimpiarForm()
        {
            txt_estado.Clear();
            txt_observacion.Clear();
        }

        private void LlenarComboBox()
        {
            SqlConnection conexion = null;
            SqlCommand cmd = null;
            SqlDataReader reader = null;

            try
            {
                conexion = this.conexion.AbrirConexion();
                cmd = new SqlCommand("select id_cliente, nombre from clientes", conexion);
                reader = cmd.ExecuteReader();
                DataTable dataTable = new DataTable();
                dataTable.Load(reader);
                Cbox_idcliente.DataSource = dataTable;
                Cbox_idcliente.DisplayMember = "nombre";
                Cbox_idcliente.ValueMember = "id_cliente";
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

        private void Entrada_Ordenes_Load(object sender, EventArgs e)
        {
            LlenarComboBox();
            DeshabilitarTodo();
        }

        private void btn_guardaro_Click(object sender, EventArgs e)
        {
            try
            {
                int Id_orden = Id_Orden;
                DateTime fechaRecibido = Convert.ToDateTime(dtp_fechaRecibido.Value);
                DateTime fechaLimiteEntrega = Convert.ToDateTime(dtp_fechaLimiteEntrega.Value);
                DateTime fechaEntrega = Convert.ToDateTime(dtp_fechaEntrega.Value);
                string estado = txt_estado.Text;
                string observacion = txt_observacion.Text;
                int id_cliente = Convert.ToInt32(Cbox_idcliente.SelectedValue);

                Metodo metodo = new Metodo();

                if (!Editar)
                {
                    metodo.Insertar_ordenes_boton(fechaRecibido, fechaLimiteEntrega, fechaEntrega, estado, observacion, id_cliente);
                    MessageBox.Show("Pago agregado correctamente");
                }
                else
                {
                    metodo.Editar_ordenes_boton(Id_orden, fechaRecibido, fechaLimiteEntrega, fechaEntrega, estado, observacion, id_cliente);
                    MessageBox.Show("Pago editado correctamente");
                    Editar = false;
                }

                LimpiarForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar pago: " + ex.Message);
            }
        }

        private void btn_habilitar_Click(object sender, EventArgs e)
        {
            HabilitarTodo();
        }
        public void DeshabilitarTodo()
        {
            dtp_fechaRecibido.Enabled = false;
            dtp_fechaLimiteEntrega.Enabled = false;
            dtp_fechaEntrega.Enabled = false;
            txt_estado.Enabled = false;
            txt_observacion.Enabled = false;
            Cbox_idcliente.Enabled = false;
        }

        public void HabilitarTodo()
        {
            dtp_fechaRecibido.Enabled = true;
            dtp_fechaLimiteEntrega.Enabled = true;
            dtp_fechaEntrega.Enabled = true;
            txt_estado.Enabled = true;
            txt_observacion.Enabled = true;
            Cbox_idcliente.Enabled = true;
        }
    }
}
