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
            lbl_consulta_pagos.Location = new Point(11, 9);
            lbl_consulta_pagos.Name = "lbl_consulta_pagos";
            lbl_consulta_pagos.Size = new Size(82, 35);
            lbl_consulta_pagos.TabIndex = 0;
            lbl_consulta_pagos.Text = "Pagos";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(11, 51);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(897, 287);
            dataGridView1.TabIndex = 1;
            // 
            // btn_atras
            // 
            btn_atras.Location = new Point(814, 344);
            btn_atras.Name = "btn_atras";
            btn_atras.Size = new Size(94, 32);
            btn_atras.TabIndex = 4;
            btn_atras.Text = "Atras";
            btn_atras.UseVisualStyleBackColor = true;
            btn_atras.Click += btn_atras_Click;
            // 
            // btn_cargar
            // 
            btn_cargar.Location = new Point(533, 345);
            btn_cargar.Name = "btn_cargar";
            btn_cargar.Size = new Size(94, 32);
            btn_cargar.TabIndex = 5;
            btn_cargar.Text = "Cargar";
            btn_cargar.UseVisualStyleBackColor = true;
            btn_cargar.Click += btn_cargar_Click;
            // 
            // btn_editarp
            // 
            btn_editarp.Location = new Point(633, 345);
            btn_editarp.Margin = new Padding(3, 4, 3, 4);
            btn_editarp.Name = "btn_editarp";
            btn_editarp.Size = new Size(86, 32);
            btn_editarp.TabIndex = 6;
            btn_editarp.Text = "Editar";
            btn_editarp.UseVisualStyleBackColor = true;
            btn_editarp.Click += btn_editarp_Click;
            // 
            // btn_eliminarp
            // 
            btn_eliminarp.Location = new Point(724, 345);
            btn_eliminarp.Margin = new Padding(3, 4, 3, 4);
            btn_eliminarp.Name = "btn_eliminarp";
            btn_eliminarp.Size = new Size(86, 31);
            btn_eliminarp.TabIndex = 7;
            btn_eliminarp.Text = "Eliminar";
            btn_eliminarp.UseVisualStyleBackColor = true;
            btn_eliminarp.Click += btn_eliminarp_Click;
            // 
            // Consulta_pagos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(920, 388);
            Controls.Add(btn_eliminarp);
            Controls.Add(btn_editarp);
            Controls.Add(btn_cargar);
            Controls.Add(btn_atras);
            Controls.Add(dataGridView1);
            Controls.Add(lbl_consulta_pagos);
            Name = "Consulta_pagos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Consulta pagos";
            Load += Consulta_pagos_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_consulta_pagos;
        private DataGridView dataGridView1;
        private Button btn_atras;
        private Button btn_cargar;
        private Button btn_editarp;
        private Button btn_eliminarp;
    }
}