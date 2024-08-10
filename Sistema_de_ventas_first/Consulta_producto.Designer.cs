namespace Sistema_de_ventas_first
{
    partial class Consulta_producto
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
            bt_editar = new Button();
            bt_eliminar = new Button();
            bt_atras = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(776, 398);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // bt_editar
            // 
            bt_editar.Location = new Point(429, 630);
            bt_editar.Name = "bt_editar";
            bt_editar.Size = new Size(116, 52);
            bt_editar.TabIndex = 1;
            bt_editar.Text = "Editar";
            bt_editar.UseVisualStyleBackColor = true;
            bt_editar.Click += bt_editar_Click;
            // 
            // bt_eliminar
            // 
            bt_eliminar.Location = new Point(551, 630);
            bt_eliminar.Name = "bt_eliminar";
            bt_eliminar.Size = new Size(108, 52);
            bt_eliminar.TabIndex = 2;
            bt_eliminar.Text = "Eliminar";
            bt_eliminar.UseVisualStyleBackColor = true;
            bt_eliminar.Click += bt_eliminar_Click;
            // 
            // bt_atras
            // 
            bt_atras.Location = new Point(665, 630);
            bt_atras.Name = "bt_atras";
            bt_atras.Size = new Size(123, 52);
            bt_atras.TabIndex = 3;
            bt_atras.Text = "Atras";
            bt_atras.UseVisualStyleBackColor = true;
            bt_atras.Click += bt_atras_Click;
            // 
            // Consulta_producto
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 694);
            Controls.Add(bt_atras);
            Controls.Add(bt_eliminar);
            Controls.Add(bt_editar);
            Controls.Add(dataGridView1);
            Name = "Consulta_producto";
            Text = "Consulta_producto";
            Load += Consulta_producto_Load_1;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button bt_editar;
        private Button bt_eliminar;
        private Button bt_atras;
    }
}