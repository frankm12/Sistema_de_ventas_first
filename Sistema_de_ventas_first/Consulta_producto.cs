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

    public partial class Consulta_producto : Form
    {
        private La_conect conexion_2 = new La_conect();
        
        public Consulta_producto()
        {
            InitializeComponent();
        }

        

        public void Actualizar69()
        {
            try
            {
                SqlConnection conexion_a_base_de_datos = conexion_2.AbrirConexion();
                SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM productos", conexion_a_base_de_datos);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
                conexion_2.CerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar productos: " + ex.Message);
            }
        }

        private void bt_editar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dataGridView1.SelectedRows[0];
                string idProducto = row.Cells["id_producto"].Value.ToString();
                string nombre = row.Cells["nombreProducto"].Value.ToString();
                int idLinea = int.Parse(row.Cells["id_lineaProducto"].Value.ToString());
                int cantidad = int.Parse(row.Cells["cantidad"].Value.ToString());
                decimal precio = decimal.Parse(row.Cells["precioVenta"].Value.ToString());

                Entrada_producto entradaProductoForm = new Entrada_producto(idProducto, nombre, idLinea, cantidad, precio, true);
                entradaProductoForm.Show();
            }
            else
            {
                MessageBox.Show("Por favor, selecciona una fila para editar.");
            }
        }

        private void bt_eliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                try
                {
                    string idProducto = dataGridView1.CurrentRow.Cells["id_producto"].Value.ToString();
                    Metodo metodos = new Metodo();
                    metodos.Eliminar_producto_boton(idProducto);
                    MessageBox.Show("Producto eliminado correctamente");

                    Actualizar69(); 
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar producto: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona una fila para eliminar.");
            }
        }

        private void bt_atras_Click(object sender, EventArgs e)
        {
            Menu_principal principal = new Menu_principal();
            principal.Show();
            this.Dispose();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void Consulta_producto_Load_1 (object sender, EventArgs e) 
        {
            Actualizar69();
        }
    }
}
