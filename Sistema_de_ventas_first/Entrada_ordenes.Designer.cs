namespace Sistema_de_ventas_first
{
    partial class Entrada_ordenes
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
            lbl_entrada_ordenes = new Label();
            dataGridView1 = new DataGridView();
            lbl_cliente = new Label();
            comboBox1 = new ComboBox();
            lbl_flecha_recibido = new Label();
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            lbl_fecha_limite_de_entrega = new Label();
            lbl_fecha_de_entrega = new Label();
            dateTimePicker3 = new DateTimePicker();
            lbl_estado = new Label();
            txt_estado = new TextBox();
            txt_observacion = new TextBox();
            lbl_observacion = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // lbl_entrada_ordenes
            // 
            lbl_entrada_ordenes.AutoSize = true;
            lbl_entrada_ordenes.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_entrada_ordenes.Location = new Point(12, 9);
            lbl_entrada_ordenes.Name = "lbl_entrada_ordenes";
            lbl_entrada_ordenes.Size = new Size(296, 46);
            lbl_entrada_ordenes.TabIndex = 0;
            lbl_entrada_ordenes.Text = "Ordenes y detalles";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 58);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(776, 204);
            dataGridView1.TabIndex = 1;
            // 
            // lbl_cliente
            // 
            lbl_cliente.AutoSize = true;
            lbl_cliente.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_cliente.Location = new Point(12, 265);
            lbl_cliente.Name = "lbl_cliente";
            lbl_cliente.Size = new Size(72, 28);
            lbl_cliente.TabIndex = 2;
            lbl_cliente.Text = "Cliente";
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(12, 296);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(242, 28);
            comboBox1.TabIndex = 3;
            // 
            // lbl_flecha_recibido
            // 
            lbl_flecha_recibido.AutoSize = true;
            lbl_flecha_recibido.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_flecha_recibido.Location = new Point(12, 329);
            lbl_flecha_recibido.Name = "lbl_flecha_recibido";
            lbl_flecha_recibido.Size = new Size(146, 28);
            lbl_flecha_recibido.TabIndex = 4;
            lbl_flecha_recibido.Text = "Fecha de orden";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(12, 360);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 5;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(12, 423);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(250, 27);
            dateTimePicker2.TabIndex = 7;
            // 
            // lbl_fecha_limite_de_entrega
            // 
            lbl_fecha_limite_de_entrega.AutoSize = true;
            lbl_fecha_limite_de_entrega.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_fecha_limite_de_entrega.Location = new Point(12, 392);
            lbl_fecha_limite_de_entrega.Name = "lbl_fecha_limite_de_entrega";
            lbl_fecha_limite_de_entrega.Size = new Size(215, 28);
            lbl_fecha_limite_de_entrega.TabIndex = 6;
            lbl_fecha_limite_de_entrega.Text = "Fecha limite de entrega";
            // 
            // lbl_fecha_de_entrega
            // 
            lbl_fecha_de_entrega.AutoSize = true;
            lbl_fecha_de_entrega.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_fecha_de_entrega.Location = new Point(12, 456);
            lbl_fecha_de_entrega.Name = "lbl_fecha_de_entrega";
            lbl_fecha_de_entrega.Size = new Size(161, 28);
            lbl_fecha_de_entrega.TabIndex = 8;
            lbl_fecha_de_entrega.Text = "Fecha de entrega";
            // 
            // dateTimePicker3
            // 
            dateTimePicker3.Location = new Point(12, 487);
            dateTimePicker3.Name = "dateTimePicker3";
            dateTimePicker3.Size = new Size(250, 27);
            dateTimePicker3.TabIndex = 9;
            // 
            // lbl_estado
            // 
            lbl_estado.AutoSize = true;
            lbl_estado.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_estado.Location = new Point(12, 520);
            lbl_estado.Name = "lbl_estado";
            lbl_estado.Size = new Size(71, 28);
            lbl_estado.TabIndex = 10;
            lbl_estado.Text = "Estado";
            // 
            // txt_estado
            // 
            txt_estado.Location = new Point(12, 551);
            txt_estado.Name = "txt_estado";
            txt_estado.Size = new Size(250, 27);
            txt_estado.TabIndex = 11;
            // 
            // txt_observacion
            // 
            txt_observacion.Location = new Point(12, 617);
            txt_observacion.Name = "txt_observacion";
            txt_observacion.Size = new Size(776, 27);
            txt_observacion.TabIndex = 13;
            // 
            // lbl_observacion
            // 
            lbl_observacion.AutoSize = true;
            lbl_observacion.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_observacion.Location = new Point(12, 586);
            lbl_observacion.Name = "lbl_observacion";
            lbl_observacion.Size = new Size(121, 28);
            lbl_observacion.TabIndex = 12;
            lbl_observacion.Text = "Observacion";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(269, 265);
            label1.Name = "label1";
            label1.Size = new Size(72, 28);
            label1.TabIndex = 14;
            label1.Text = "Cliente";
            // 
            // Entrada_ordenes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 671);
            Controls.Add(label1);
            Controls.Add(txt_observacion);
            Controls.Add(lbl_observacion);
            Controls.Add(txt_estado);
            Controls.Add(lbl_estado);
            Controls.Add(dateTimePicker3);
            Controls.Add(lbl_fecha_de_entrega);
            Controls.Add(dateTimePicker2);
            Controls.Add(lbl_fecha_limite_de_entrega);
            Controls.Add(dateTimePicker1);
            Controls.Add(lbl_flecha_recibido);
            Controls.Add(comboBox1);
            Controls.Add(lbl_cliente);
            Controls.Add(dataGridView1);
            Controls.Add(lbl_entrada_ordenes);
            Name = "Entrada_ordenes";
            Text = "Entrada_ordenes";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_entrada_ordenes;
        private DataGridView dataGridView1;
        private Label lbl_cliente;
        private ComboBox comboBox1;
        private Label lbl_flecha_recibido;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private Label lbl_fecha_limite_de_entrega;
        private Label lbl_fecha_de_entrega;
        private DateTimePicker dateTimePicker3;
        private Label lbl_estado;
        private TextBox txt_estado;
        private TextBox txt_observacion;
        private Label lbl_observacion;
        private Label label1;
    }
}