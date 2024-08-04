namespace Sistema_de_ventas_first
{
    partial class Consulta_empleadoscs
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lbl_empleados = new Label();
            dataGridView1 = new DataGridView();
            btn_atras = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // lbl_empleados
            // 
            lbl_empleados.AutoSize = true;
            lbl_empleados.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_empleados.Location = new Point(10, 7);
            lbl_empleados.Name = "lbl_empleados";
            lbl_empleados.Size = new Size(148, 37);
            lbl_empleados.TabIndex = 0;
            lbl_empleados.Text = "Empleados";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(10, 44);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(679, 232);
            dataGridView1.TabIndex = 1;
            // 
            // btn_atras
            // 
            btn_atras.Location = new Point(607, 281);
            btn_atras.Margin = new Padding(3, 2, 3, 2);
            btn_atras.Name = "btn_atras";
            btn_atras.Size = new Size(82, 22);
            btn_atras.TabIndex = 2;
            btn_atras.Text = "Atras";
            btn_atras.UseVisualStyleBackColor = true;
            btn_atras.Click += btn_atras_Click;
            // 
            // Consulta_empleadoscs
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 314);
            Controls.Add(btn_atras);
            Controls.Add(dataGridView1);
            Controls.Add(lbl_empleados);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Consulta_empleadoscs";
            Text = "Consulta_empleadoscs";
            Load += Consulta_empleadoscs_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_empleados;
        private DataGridView dataGridView1;
        private Button btn_atras;
    }
}