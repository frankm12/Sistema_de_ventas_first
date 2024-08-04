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
    public partial class Consulta_empleadoscs : Form
    {
        public Consulta_empleadoscs()
        {
            InitializeComponent();
        }


        private void btn_atras_Click(object sender, EventArgs e)
        {
            Form Menu_princial = new Menu_princial();
            Menu_princial.Show();
            this.Close();
        }

        private void Consulta_empleadoscs_Load(object sender, EventArgs e)
        {
            
        }
    }
}
