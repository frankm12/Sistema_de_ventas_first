namespace Sistema_de_ventas_first
{
    partial class Entrada_pagos
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
            btn_atras = new Button();
            dataGridView1 = new DataGridView();
            lbl_entrada_pagos = new Label();
            lbl_clientes = new Label();
            comboBox1 = new ComboBox();
            lbl_fecha_de_pago = new Label();
            dateTimePicker1 = new DateTimePicker();
            lbl_numero_de_factura = new Label();
            txt_numero_de_factura = new TextBox();
            txt_total_pago = new TextBox();
            lbl_total_pago = new Label();
            btn_habilitar = new Button();
            btn_eliminar = new Button();
            btn_editar = new Button();
            btn_guardar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btn_atras
            // 
            btn_atras.Location = new Point(357, 456);
            btn_atras.Name = "btn_atras";
            btn_atras.Size = new Size(98, 29);
            btn_atras.TabIndex = 0;
            btn_atras.Text = "Atras";
            btn_atras.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 55);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(555, 188);
            dataGridView1.TabIndex = 1;
            // 
            // lbl_entrada_pagos
            // 
            lbl_entrada_pagos.AutoSize = true;
            lbl_entrada_pagos.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_entrada_pagos.Location = new Point(12, 6);
            lbl_entrada_pagos.Name = "lbl_entrada_pagos";
            lbl_entrada_pagos.Size = new Size(109, 46);
            lbl_entrada_pagos.TabIndex = 2;
            lbl_entrada_pagos.Text = "Pagos";
            // 
            // lbl_clientes
            // 
            lbl_clientes.AutoSize = true;
            lbl_clientes.Location = new Point(12, 255);
            lbl_clientes.Name = "lbl_clientes";
            lbl_clientes.Size = new Size(55, 20);
            lbl_clientes.TabIndex = 3;
            lbl_clientes.Text = "Cliente";
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(12, 278);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(323, 28);
            comboBox1.TabIndex = 4;
            // 
            // lbl_fecha_de_pago
            // 
            lbl_fecha_de_pago.AutoSize = true;
            lbl_fecha_de_pago.Location = new Point(12, 372);
            lbl_fecha_de_pago.Name = "lbl_fecha_de_pago";
            lbl_fecha_de_pago.Size = new Size(151, 20);
            lbl_fecha_de_pago.TabIndex = 5;
            lbl_fecha_de_pago.Text = "Fecha en la que pago";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(12, 395);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(323, 27);
            dateTimePicker1.TabIndex = 6;
            // 
            // lbl_numero_de_factura
            // 
            lbl_numero_de_factura.AutoSize = true;
            lbl_numero_de_factura.Location = new Point(12, 314);
            lbl_numero_de_factura.Name = "lbl_numero_de_factura";
            lbl_numero_de_factura.Size = new Size(134, 20);
            lbl_numero_de_factura.TabIndex = 7;
            lbl_numero_de_factura.Text = "Numero de factura";
            // 
            // txt_numero_de_factura
            // 
            txt_numero_de_factura.Location = new Point(12, 337);
            txt_numero_de_factura.Name = "txt_numero_de_factura";
            txt_numero_de_factura.Size = new Size(323, 27);
            txt_numero_de_factura.TabIndex = 8;
            // 
            // txt_total_pago
            // 
            txt_total_pago.Location = new Point(12, 457);
            txt_total_pago.Name = "txt_total_pago";
            txt_total_pago.Size = new Size(323, 27);
            txt_total_pago.TabIndex = 10;
            // 
            // lbl_total_pago
            // 
            lbl_total_pago.AutoSize = true;
            lbl_total_pago.Location = new Point(12, 434);
            lbl_total_pago.Name = "lbl_total_pago";
            lbl_total_pago.Size = new Size(81, 20);
            lbl_total_pago.TabIndex = 9;
            lbl_total_pago.Text = "Total pago";
            // 
            // btn_habilitar
            // 
            btn_habilitar.Location = new Point(469, 457);
            btn_habilitar.Name = "btn_habilitar";
            btn_habilitar.Size = new Size(98, 29);
            btn_habilitar.TabIndex = 11;
            btn_habilitar.Text = "Habilitar";
            btn_habilitar.UseVisualStyleBackColor = true;
            // 
            // btn_eliminar
            // 
            btn_eliminar.Location = new Point(357, 396);
            btn_eliminar.Name = "btn_eliminar";
            btn_eliminar.Size = new Size(210, 55);
            btn_eliminar.TabIndex = 12;
            btn_eliminar.Text = "Eliminar";
            btn_eliminar.UseVisualStyleBackColor = true;
            // 
            // btn_editar
            // 
            btn_editar.Location = new Point(357, 335);
            btn_editar.Name = "btn_editar";
            btn_editar.Size = new Size(210, 55);
            btn_editar.TabIndex = 13;
            btn_editar.Text = "Editar";
            btn_editar.UseVisualStyleBackColor = true;
            // 
            // btn_guardar
            // 
            btn_guardar.Location = new Point(357, 274);
            btn_guardar.Name = "btn_guardar";
            btn_guardar.Size = new Size(210, 55);
            btn_guardar.TabIndex = 14;
            btn_guardar.Text = "Guardar";
            btn_guardar.UseVisualStyleBackColor = true;
            // 
            // Entrada_pagos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(587, 528);
            Controls.Add(btn_guardar);
            Controls.Add(btn_editar);
            Controls.Add(btn_eliminar);
            Controls.Add(btn_habilitar);
            Controls.Add(txt_total_pago);
            Controls.Add(lbl_total_pago);
            Controls.Add(txt_numero_de_factura);
            Controls.Add(lbl_numero_de_factura);
            Controls.Add(dateTimePicker1);
            Controls.Add(lbl_fecha_de_pago);
            Controls.Add(comboBox1);
            Controls.Add(lbl_clientes);
            Controls.Add(lbl_entrada_pagos);
            Controls.Add(dataGridView1);
            Controls.Add(btn_atras);
            Name = "Entrada_pagos";
            Text = "Entrada_pagos";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_atras;
        private DataGridView dataGridView1;
        private Label lbl_entrada_pagos;
        private Label lbl_clientes;
        private ComboBox comboBox1;
        private Label lbl_fecha_de_pago;
        private DateTimePicker dateTimePicker1;
        private Label lbl_numero_de_factura;
        private TextBox txt_numero_de_factura;
        private TextBox txt_total_pago;
        private Label lbl_total_pago;
        private Button btn_habilitar;
        private Button btn_eliminar;
        private Button btn_editar;
        private Button btn_guardar;
    }
}