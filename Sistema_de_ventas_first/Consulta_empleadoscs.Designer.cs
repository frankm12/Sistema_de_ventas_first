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
            bt_editar = new Button();
            bt_eliminar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // lbl_empleados
            // 
            lbl_empleados.AutoSize = true;
            lbl_empleados.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_empleados.Location = new Point(15, 11);
            lbl_empleados.Margin = new Padding(4, 0, 4, 0);
            lbl_empleados.Name = "lbl_empleados";
            lbl_empleados.Size = new Size(216, 54);
            lbl_empleados.TabIndex = 0;
            lbl_empleados.Text = "Empleados";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(15, 72);
            dataGridView1.Margin = new Padding(4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(970, 386);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // btn_atras
            // 
            btn_atras.Location = new Point(868, 469);
            btn_atras.Margin = new Padding(4);
            btn_atras.Name = "btn_atras";
            btn_atras.Size = new Size(118, 36);
            btn_atras.TabIndex = 2;
            btn_atras.Text = "Atras";
            btn_atras.UseVisualStyleBackColor = true;
            btn_atras.Click += btn_atras_Click;
            // 
            // bt_editar
            // 
            bt_editar.Location = new Point(665, 469);
            bt_editar.Name = "bt_editar";
            bt_editar.Size = new Size(95, 36);
            bt_editar.TabIndex = 4;
            bt_editar.Text = "Editar";
            bt_editar.UseVisualStyleBackColor = true;
            bt_editar.Click += bt_editar_Click;
            // 
            // bt_eliminar
            // 
            bt_eliminar.Location = new Point(766, 469);
            bt_eliminar.Name = "bt_eliminar";
            bt_eliminar.Size = new Size(95, 36);
            bt_eliminar.TabIndex = 5;
            bt_eliminar.Text = "Eliminar";
            bt_eliminar.UseVisualStyleBackColor = true;
            bt_eliminar.Click += bt_eliminar_Click;
            // 
            // Consulta_empleadoscs
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 524);
            Controls.Add(bt_eliminar);
            Controls.Add(bt_editar);
            Controls.Add(btn_atras);
            Controls.Add(dataGridView1);
            Controls.Add(lbl_empleados);
            Margin = new Padding(4);
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
        private Button bt_editar;
        private Button bt_eliminar;
    }
}