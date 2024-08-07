using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_ventas_first
{

    public partial class Menu_princial : Form
    {
        public Menu_princial()
        {
            InitializeComponent();
        }

        private void consultaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void empleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form Consulta_empleadoscs = new Consulta_empleadoscs();
            Consulta_empleadoscs.Show();
            this.Close();
        }

        private void empleadosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form Entrada_empleados = new Entrada_empleados();
            Entrada_empleados.Show();
            this.Close();
        }

        private void Menu_princial_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void clientesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form entrada_clientes = new Entrada_clientes();
            entrada_clientes.Show();
            this.Close();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form consulta_clientes = new Consulta_clientes();
            consulta_clientes.Show();
            this.Close();
        }

        private void pagosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form entrada_pagos = new Entrada_pagos();
            entrada_pagos.Show();
            this.Close();
        }

        private void pagosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form consulta_pagos = new Consulta_clientes();
            consulta_pagos.Show();
            this.Close();
        }
    }
}
