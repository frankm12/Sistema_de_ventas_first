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
            txt_buscarp = new TextBox();
            lbl_buscar = new Label();
            btn_atras = new Button();
            btn_cargar = new Button();
            btn_editarp = new Button();
            btn_eliminarp = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // lbl_consulta_pagos
            // 
            lbl_consulta_pagos.AutoSize = true;
            lbl_consulta_pagos.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_consulta_pagos.Location = new Point(10, 7);
            lbl_consulta_pagos.Name = "lbl_consulta_pagos";
            lbl_consulta_pagos.Size = new Size(64, 28);
            lbl_consulta_pagos.TabIndex = 0;
            lbl_consulta_pagos.Text = "Pagos";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(10, 38);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(584, 215);
            dataGridView1.TabIndex = 1;
            // 
            // txt_buscarp
            // 
            txt_buscarp.Location = new Point(10, 282);
            txt_buscarp.Margin = new Padding(3, 2, 3, 2);
            txt_buscarp.Name = "txt_buscarp";
            txt_buscarp.Size = new Size(484, 23);
            txt_buscarp.TabIndex = 2;
            // 
            // lbl_buscar
            // 
            lbl_buscar.AutoSize = true;
            lbl_buscar.Location = new Point(10, 261);
            lbl_buscar.Name = "lbl_buscar";
            lbl_buscar.Size = new Size(42, 15);
            lbl_buscar.TabIndex = 3;
            lbl_buscar.Text = "Buscar";
            // 
            // btn_atras
            // 
            btn_atras.Location = new Point(512, 319);
            btn_atras.Margin = new Padding(3, 2, 3, 2);
            btn_atras.Name = "btn_atras";
            btn_atras.Size = new Size(82, 24);
            btn_atras.TabIndex = 4;
            btn_atras.Text = "Atras";
            btn_atras.UseVisualStyleBackColor = true;
            btn_atras.Click += btn_atras_Click;
            // 
            // btn_cargar
            // 
            btn_cargar.Location = new Point(512, 280);
            btn_cargar.Margin = new Padding(3, 2, 3, 2);
            btn_cargar.Name = "btn_cargar";
            btn_cargar.Size = new Size(82, 24);
            btn_cargar.TabIndex = 5;
            btn_cargar.Text = "Cargar";
            btn_cargar.UseVisualStyleBackColor = true;
            btn_cargar.Click += btn_cargar_Click;
            // 
            // btn_editarp
            // 
            btn_editarp.Location = new Point(10, 320);
            btn_editarp.Name = "btn_editarp";
            btn_editarp.Size = new Size(75, 24);
            btn_editarp.TabIndex = 6;
            btn_editarp.Text = "Editar";
            btn_editarp.UseVisualStyleBackColor = true;
            btn_editarp.Click += btn_editarp_Click;
            // 
            // btn_eliminarp
            // 
            btn_eliminarp.Location = new Point(102, 320);
            btn_eliminarp.Name = "btn_eliminarp";
            btn_eliminarp.Size = new Size(75, 23);
            btn_eliminarp.TabIndex = 7;
            btn_eliminarp.Text = "Eliminar";
            btn_eliminarp.UseVisualStyleBackColor = true;
            btn_eliminarp.Click += btn_eliminarp_Click;
            // 
            // Consulta_pagos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(618, 356);
            Controls.Add(btn_eliminarp);
            Controls.Add(btn_editarp);
            Controls.Add(btn_cargar);
            Controls.Add(btn_atras);
            Controls.Add(lbl_buscar);
            Controls.Add(txt_buscarp);
            Controls.Add(dataGridView1);
            Controls.Add(lbl_consulta_pagos);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Consulta_pagos";
            Text = "Consulta_pagos";
            Load += Consulta_pagos_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_consulta_pagos;
        private DataGridView dataGridView1;
        private TextBox txt_buscarp;
        private Label lbl_buscar;
        private Button btn_atras;
        private Button btn_cargar;
        private Button btn_editarp;
        private Button btn_eliminarp;
    }
}