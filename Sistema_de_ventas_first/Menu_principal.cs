﻿using System;
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
            consultaEmpleados.ShowDialog();
        }

        private void empleadosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Entrada_empleados principalForm = new Entrada_empleados();
            principalForm.ShowDialog();
        }

        private void clientesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form entradaClientes = new Entrada_clientes();
            entradaClientes.ShowDialog();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form consultaClientes = new Consulta_clientes();
            consultaClientes.ShowDialog();
        }

        private void pagosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form entradaPagos = new Entrada_pagos();
            entradaPagos.ShowDialog();
        }

        private void pagosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form consultaPagos = new Consulta_pagos();
            consultaPagos.ShowDialog();
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
                Application.Exit();
            }
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form consultasproducto = new Consulta_producto();
            consultasproducto.ShowDialog();
        }

        private void productosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form entradaProducto = new Entrada_producto();
            entradaProducto.ShowDialog();
        }

        private void ordenesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form ConsultaOrdenes = new Consulta_Ordenes();
            ConsultaOrdenes.ShowDialog();
        }

        private void ordenesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form EntradaOrdenes = new Entrada_Ordenes();
            EntradaOrdenes.ShowDialog();
        }

        private void detallesDeOrdenesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form Consultadetallesordenes = new Consulta_Detallesordenes();
            Consultadetallesordenes.ShowDialog();
        }

        private void detallesDeOrdenesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form entradetallesordenes = new Entrada_Detallesordenes();
            entradetallesordenes.ShowDialog();
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Acerca_de acerca = new Acerca_de();
            acerca.ShowDialog();
        }
    }
}
