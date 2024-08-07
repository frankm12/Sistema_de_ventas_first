namespace Sistema_de_ventas_first
{
    partial class Consulta_pagos
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
            lbl_consulta_pagos = new Label();
            dataGridView1 = new DataGridView();
            txt_buscar = new TextBox();
            lbl_buscar = new Label();
            btn_atras = new Button();
            btn_cargar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // lbl_consulta_pagos
            // 
            lbl_consulta_pagos.AutoSize = true;
            lbl_consulta_pagos.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_consulta_pagos.Location = new Point(12, 9);
            lbl_consulta_pagos.Name = "lbl_consulta_pagos";
            lbl_consulta_pagos.Size = new Size(82, 35);
            lbl_consulta_pagos.TabIndex = 0;
            lbl_consulta_pagos.Text = "Pagos";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 51);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(776, 326);
            dataGridView1.TabIndex = 1;
            // 
            // txt_buscar
            // 
            txt_buscar.Location = new Point(12, 411);
            txt_buscar.Name = "txt_buscar";
            txt_buscar.Size = new Size(552, 27);
            txt_buscar.TabIndex = 2;
            // 
            // lbl_buscar
            // 
            lbl_buscar.AutoSize = true;
            lbl_buscar.Location = new Point(12, 388);
            lbl_buscar.Name = "lbl_buscar";
            lbl_buscar.Size = new Size(52, 20);
            lbl_buscar.TabIndex = 3;
            lbl_buscar.Text = "Buscar";
            // 
            // btn_atras
            // 
            btn_atras.Location = new Point(694, 409);
            btn_atras.Name = "btn_atras";
            btn_atras.Size = new Size(94, 29);
            btn_atras.TabIndex = 4;
            btn_atras.Text = "Atras";
            btn_atras.UseVisualStyleBackColor = true;
            // 
            // btn_cargar
            // 
            btn_cargar.Location = new Point(585, 409);
            btn_cargar.Name = "btn_cargar";
            btn_cargar.Size = new Size(94, 29);
            btn_cargar.TabIndex = 5;
            btn_cargar.Text = "Cargar";
            btn_cargar.UseVisualStyleBackColor = true;
            // 
            // Consulta_pagos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_cargar);
            Controls.Add(btn_atras);
            Controls.Add(lbl_buscar);
            Controls.Add(txt_buscar);
            Controls.Add(dataGridView1);
            Controls.Add(lbl_consulta_pagos);
            Name = "Consulta_pagos";
            Text = "Consulta_pagos";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_consulta_pagos;
        private DataGridView dataGridView1;
        private TextBox txt_buscar;
        private Label lbl_buscar;
        private Button btn_atras;
        private Button btn_cargar;
    }
}