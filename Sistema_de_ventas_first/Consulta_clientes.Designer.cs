namespace Sistema_de_ventas_first
{
    partial class Consulta_clientes
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
            btn_atras = new Button();
            btn_cargar = new Button();
            btneditar = new Button();
            btneliminar = new Button();
            lbl_clientes = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(11, 54);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1341, 359);
            dataGridView1.TabIndex = 0;
            // 
            // btn_atras
            // 
            btn_atras.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            btn_atras.Location = new Point(1260, 427);
            btn_atras.Name = "btn_atras";
            btn_atras.Size = new Size(94, 31);
            btn_atras.TabIndex = 1;
            btn_atras.Text = "Atras";
            btn_atras.UseVisualStyleBackColor = true;
            btn_atras.Click += btn_atras_Click;
            // 
            // btn_cargar
            // 
            btn_cargar.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            btn_cargar.Location = new Point(976, 428);
            btn_cargar.Name = "btn_cargar";
            btn_cargar.Size = new Size(94, 31);
            btn_cargar.TabIndex = 2;
            btn_cargar.Text = "Cargar";
            btn_cargar.UseVisualStyleBackColor = true;
            btn_cargar.Click += btn_cargar_Click;
            // 
            // btneditar
            // 
            btneditar.Location = new Point(1077, 427);
            btneditar.Margin = new Padding(3, 4, 3, 4);
            btneditar.Name = "btneditar";
            btneditar.Size = new Size(86, 31);
            btneditar.TabIndex = 6;
            btneditar.Text = "Editar";
            btneditar.UseVisualStyleBackColor = true;
            btneditar.Click += btneditar_Click;
            // 
            // btneliminar
            // 
            btneliminar.Location = new Point(1168, 427);
            btneliminar.Margin = new Padding(3, 4, 3, 4);
            btneliminar.Name = "btneliminar";
            btneliminar.Size = new Size(86, 31);
            btneliminar.TabIndex = 7;
            btneliminar.Text = "Eliminar";
            btneliminar.UseVisualStyleBackColor = true;
            btneliminar.Click += btneliminar_Click;
            // 
            // lbl_clientes
            // 
            lbl_clientes.AutoSize = true;
            lbl_clientes.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_clientes.Location = new Point(11, 5);
            lbl_clientes.Name = "lbl_clientes";
            lbl_clientes.Size = new Size(138, 46);
            lbl_clientes.TabIndex = 8;
            lbl_clientes.Text = "Clientes";
            // 
            // Consulta_clientes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1364, 476);
            Controls.Add(lbl_clientes);
            Controls.Add(btneliminar);
            Controls.Add(btneditar);
            Controls.Add(btn_cargar);
            Controls.Add(btn_atras);
            Controls.Add(dataGridView1);
            Name = "Consulta_clientes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Consulta_clientes";
            Load += Consulta_clientes_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btn_atras;
        private Button btn_cargar;
        private Button btneditar;
        private Button btneliminar;
        private Label lbl_clientes;
    }
}