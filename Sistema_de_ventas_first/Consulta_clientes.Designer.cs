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
            txt_buscar = new TextBox();
            lbl_buscar = new Label();
            btnguardar = new Button();
            btneditar = new Button();
            btneliminar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(11, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(776, 285);
            dataGridView1.TabIndex = 0;
            // 
            // btn_atras
            // 
            btn_atras.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            btn_atras.Location = new Point(694, 327);
            btn_atras.Name = "btn_atras";
            btn_atras.Size = new Size(94, 29);
            btn_atras.TabIndex = 1;
            btn_atras.Text = "Atras";
            btn_atras.UseVisualStyleBackColor = true;
            // 
            // btn_cargar
            // 
            btn_cargar.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            btn_cargar.Location = new Point(595, 327);
            btn_cargar.Name = "btn_cargar";
            btn_cargar.Size = new Size(94, 29);
            btn_cargar.TabIndex = 2;
            btn_cargar.Text = "Cargar";
            btn_cargar.UseVisualStyleBackColor = true;
            btn_cargar.Click += btn_cargar_Click;
            // 
            // txt_buscar
            // 
            txt_buscar.Location = new Point(14, 328);
            txt_buscar.Name = "txt_buscar";
            txt_buscar.Size = new Size(569, 27);
            txt_buscar.TabIndex = 3;
            // 
            // lbl_buscar
            // 
            lbl_buscar.AutoSize = true;
            lbl_buscar.Location = new Point(14, 305);
            lbl_buscar.Name = "lbl_buscar";
            lbl_buscar.Size = new Size(55, 20);
            lbl_buscar.TabIndex = 4;
            lbl_buscar.Text = "Buscar:";
            // 
            // btnguardar
            // 
            btnguardar.Location = new Point(14, 384);
            btnguardar.Margin = new Padding(3, 4, 3, 4);
            btnguardar.Name = "btnguardar";
            btnguardar.Size = new Size(86, 31);
            btnguardar.TabIndex = 5;
            btnguardar.Text = "Guardar";
            btnguardar.UseVisualStyleBackColor = true;
            btnguardar.Click += btnguardar_Click;
            // 
            // btneditar
            // 
            btneditar.Location = new Point(106, 384);
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
            btneliminar.Location = new Point(199, 384);
            btneliminar.Margin = new Padding(3, 4, 3, 4);
            btneliminar.Name = "btneliminar";
            btneliminar.Size = new Size(86, 31);
            btneliminar.TabIndex = 7;
            btneliminar.Text = "Eliminar";
            btneliminar.UseVisualStyleBackColor = true;
            btneliminar.Click += btneliminar_Click;
            // 
            // Consulta_clientes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 434);
            Controls.Add(btneliminar);
            Controls.Add(btneditar);
            Controls.Add(btnguardar);
            Controls.Add(lbl_buscar);
            Controls.Add(txt_buscar);
            Controls.Add(btn_cargar);
            Controls.Add(btn_atras);
            Controls.Add(dataGridView1);
            Name = "Consulta_clientes";
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
        private TextBox txt_buscar;
        private Label lbl_buscar;
        private Button btnguardar;
        private Button btneditar;
        private Button btneliminar;
    }
}