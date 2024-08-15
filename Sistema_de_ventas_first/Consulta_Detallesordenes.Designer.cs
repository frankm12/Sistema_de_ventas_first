namespace Sistema_de_ventas_first
{
    partial class Consulta_Detallesordenes
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
            dataGridView1 = new DataGridView();
            btn_editar = new Button();
            btn_eliminar = new Button();
            lbl_detalles = new Label();
            btn_atras = new Button();
            btn_actualizar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(14, 49);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1098, 271);
            dataGridView1.TabIndex = 0;
            // 
            // btn_editar
            // 
            btn_editar.Location = new Point(435, 340);
            btn_editar.Margin = new Padding(3, 4, 3, 4);
            btn_editar.Name = "btn_editar";
            btn_editar.Size = new Size(154, 35);
            btn_editar.TabIndex = 1;
            btn_editar.Text = "Editar";
            btn_editar.UseVisualStyleBackColor = true;
            btn_editar.Click += btn_editar_Click;
            // 
            // btn_eliminar
            // 
            btn_eliminar.Location = new Point(610, 340);
            btn_eliminar.Margin = new Padding(3, 4, 3, 4);
            btn_eliminar.Name = "btn_eliminar";
            btn_eliminar.Size = new Size(154, 35);
            btn_eliminar.TabIndex = 2;
            btn_eliminar.Text = "Eliminar";
            btn_eliminar.UseVisualStyleBackColor = true;
            btn_eliminar.Click += btn_eliminar_Click;
            // 
            // lbl_detalles
            // 
            lbl_detalles.AutoSize = true;
            lbl_detalles.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_detalles.Location = new Point(14, 12);
            lbl_detalles.Name = "lbl_detalles";
            lbl_detalles.Size = new Size(105, 32);
            lbl_detalles.TabIndex = 4;
            lbl_detalles.Text = "Detalles";
            // 
            // btn_atras
            // 
            btn_atras.Location = new Point(962, 338);
            btn_atras.Margin = new Padding(3, 4, 3, 4);
            btn_atras.Name = "btn_atras";
            btn_atras.Size = new Size(154, 35);
            btn_atras.TabIndex = 5;
            btn_atras.Text = "Atras";
            btn_atras.UseVisualStyleBackColor = true;
            btn_atras.Click += btn_atras_Click;
            // 
            // btn_actualizar
            // 
            btn_actualizar.Location = new Point(787, 338);
            btn_actualizar.Margin = new Padding(3, 4, 3, 4);
            btn_actualizar.Name = "btn_actualizar";
            btn_actualizar.Size = new Size(154, 37);
            btn_actualizar.TabIndex = 6;
            btn_actualizar.Text = "Actualizar";
            btn_actualizar.UseVisualStyleBackColor = true;
            btn_actualizar.Click += btn_actualizar_Click;
            // 
            // Consulta_Detallesordenes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1124, 400);
            Controls.Add(btn_actualizar);
            Controls.Add(btn_atras);
            Controls.Add(lbl_detalles);
            Controls.Add(btn_eliminar);
            Controls.Add(btn_editar);
            Controls.Add(dataGridView1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Consulta_Detallesordenes";
            Text = "Consulta_Detallesordenes";
            Load += Consulta_Detallesordenes_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btn_editar;
        private Button btn_eliminar;
        private Label lbl_detalles;
        private Button btn_atras;
        private Button btn_actualizar;
    }
}