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
            dataGridView1.Location = new Point(10, 10);
            dataGridView1.Margin = new Padding(2, 2, 2, 2);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(621, 318);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // bt_editar
            // 
            bt_editar.Location = new Point(222, 348);
            bt_editar.Margin = new Padding(2, 2, 2, 2);
            bt_editar.Name = "bt_editar";
            bt_editar.Size = new Size(198, 42);
            bt_editar.TabIndex = 1;
            bt_editar.Text = "Editar";
            bt_editar.UseVisualStyleBackColor = true;
            bt_editar.Click += bt_editar_Click;
            // 
            // bt_eliminar
            // 
            bt_eliminar.Location = new Point(10, 348);
            bt_eliminar.Margin = new Padding(2, 2, 2, 2);
            bt_eliminar.Name = "bt_eliminar";
            bt_eliminar.Size = new Size(198, 42);
            bt_eliminar.TabIndex = 2;
            bt_eliminar.Text = "Eliminar";
            bt_eliminar.UseVisualStyleBackColor = true;
            bt_eliminar.Click += bt_eliminar_Click;
            // 
            // bt_atras
            // 
            bt_atras.Location = new Point(433, 348);
            bt_atras.Margin = new Padding(2, 2, 2, 2);
            bt_atras.Name = "bt_atras";
            bt_atras.Size = new Size(198, 42);
            bt_atras.TabIndex = 3;
            bt_atras.Text = "Atras";
            bt_atras.UseVisualStyleBackColor = true;
            bt_atras.Click += bt_atras_Click;
            // 
            // Consulta_producto
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(640, 433);
            Controls.Add(bt_atras);
            Controls.Add(bt_eliminar);
            Controls.Add(bt_editar);
            Controls.Add(dataGridView1);
            Margin = new Padding(2, 2, 2, 2);
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