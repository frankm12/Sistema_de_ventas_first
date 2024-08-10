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
    public partial class Entrada_producto : Form
    {
        private La_conect conexion_2 = new La_conect();
        string Id_producto = "";
        bool Editar = false;
        bool DesdeConsulta = false;
        private Consulta_producto drig = new Consulta_producto();
        public Entrada_producto()
        {
            InitializeComponent();
        }


        public void limpiarform()
        {
            text_nombre.Clear();
            text_linea.Clear();
            text_cantidad.Clear();
            text_precio.Clear();
        }

        private void bt_atras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       

        private void bt_guardar_Click(object sender, EventArgs e)
        {
            if (Editar == false)
            {
                try
                {
                    string idProducto = text_idproducto.Text;
                    string nombre = text_nombre.Text;
                    int idLinea = int.Parse(text_linea.Text);
                    int cantidad = int.Parse(text_cantidad.Text);
                    decimal precio = decimal.Parse(text_precio.Text);

                    Metodo metodos = new Metodo();
                    metodos.Insertar_producto(idProducto, nombre, idLinea, cantidad, precio);
                    MessageBox.Show("Producto agregado correctamente");
                    drig.Actualizar69();
                    limpiarform();
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al agregar producto: " + ex.Message);
                }
            }
            else
            {
                try
                {
                    string idProducto = Id_producto;
                    string nombre = text_nombre.Text;
                    int idLinea = int.Parse(text_linea.Text);
                    int cantidad = int.Parse(text_cantidad.Text);
                    decimal precio = decimal.Parse(text_precio.Text);

                    Metodo metodos = new Metodo();
                   
                    metodos.Editar_producto(idProducto, nombre, idLinea, cantidad, precio);
                    MessageBox.Show("Producto editado correctamente");

                    Editar = false;
                    limpiarform();
                    drig.Actualizar69();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al editar producto: " + ex.Message);
                }
            }
        }
    }
}

