using System;
using System.Windows.Forms;

namespace Sistema_de_ventas_first
{
    public partial class Menu_principal : Form
    {
        
        public Menu_principal()
        {
            InitializeComponent();
            this.FormClosing += Menu_principal_FormClosing;
        }

        private void Menu_principal_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void consultaToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void empleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form consultaEmpleados = new Consulta_empleadoscs();
            consultaEmpleados.Show();
            //// this.Hide();
        }

        private void empleadosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Entrada_empleados principalForm = new Entrada_empleados();
            principalForm.Show();
        }

        private void clientesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form entradaClientes = new Entrada_clientes();
            entradaClientes.Show();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form consultaClientes = new Consulta_clientes();
            consultaClientes.Show();
        }

        private void pagosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form entradaPagos = new Entrada_pagos();
            entradaPagos.Show();
        }

        private void pagosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form consultaPagos = new Consulta_pagos();
            consultaPagos.Show();
        }

        private void entradaToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void Menu_principal_FormClosing(object? sender, FormClosingEventArgs e)
        {
            var result = MessageBox.Show("¿Estás seguro de que quieres salir?", "Confirmar salida", MessageBoxButtons.YesNo);


            if (result == DialogResult.No)
            {
                e.Cancel = true; // Cancela el cierre del formulario
            }
            if (result == DialogResult.Yes)
            {
                this.Dispose();
            }
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form consultasproducto = new Consulta_producto();
            consultasproducto.Show();
        }

        private void productosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form entradaProducto = new Entrada_producto();
            entradaProducto.Show();
        }
    }
}
