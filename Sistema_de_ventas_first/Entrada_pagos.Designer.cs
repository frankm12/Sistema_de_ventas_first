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
            lbl_entrada_pagos = new Label();
            lbl_clientes = new Label();
            Cbox_cliente = new ComboBox();
            lbl_fecha_de_pago = new Label();
            dtp_fecha = new DateTimePicker();
            lbl_numero_de_factura = new Label();
            txt_numero_de_factura = new TextBox();
            txt_total_pago = new TextBox();
            lbl_total_pago = new Label();
            btn_habilitar = new Button();
            btn_guardarp = new Button();
            SuspendLayout();
            // 
            // btn_atras
            // 
            btn_atras.Location = new Point(151, 251);
            btn_atras.Margin = new Padding(3, 2, 3, 2);
            btn_atras.Name = "btn_atras";
            btn_atras.Size = new Size(132, 25);
            btn_atras.TabIndex = 0;
            btn_atras.Text = "Atras";
            btn_atras.UseVisualStyleBackColor = true;
            btn_atras.Click += btn_atras_Click;
            // 
            // lbl_entrada_pagos
            // 
            lbl_entrada_pagos.AutoSize = true;
            lbl_entrada_pagos.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_entrada_pagos.Location = new Point(10, 4);
            lbl_entrada_pagos.Name = "lbl_entrada_pagos";
            lbl_entrada_pagos.Size = new Size(88, 37);
            lbl_entrada_pagos.TabIndex = 2;
            lbl_entrada_pagos.Text = "Pagos";
            // 
            // lbl_clientes
            // 
            lbl_clientes.AutoSize = true;
            lbl_clientes.Location = new Point(51, 60);
            lbl_clientes.Name = "lbl_clientes";
            lbl_clientes.Size = new Size(47, 15);
            lbl_clientes.TabIndex = 3;
            lbl_clientes.Text = "Cliente:";
            // 
            // Cbox_cliente
            // 
            Cbox_cliente.DropDownStyle = ComboBoxStyle.DropDownList;
            Cbox_cliente.FormattingEnabled = true;
            Cbox_cliente.Location = new Point(131, 55);
            Cbox_cliente.Margin = new Padding(3, 2, 3, 2);
            Cbox_cliente.Name = "Cbox_cliente";
            Cbox_cliente.Size = new Size(225, 23);
            Cbox_cliente.TabIndex = 4;
            // 
            // lbl_fecha_de_pago
            // 
            lbl_fecha_de_pago.AutoSize = true;
            lbl_fecha_de_pago.Location = new Point(4, 153);
            lbl_fecha_de_pago.Name = "lbl_fecha_de_pago";
            lbl_fecha_de_pago.Size = new Size(122, 15);
            lbl_fecha_de_pago.TabIndex = 5;
            lbl_fecha_de_pago.Text = "Fecha en la que pago:";
            // 
            // dtp_fecha
            // 
            dtp_fecha.CustomFormat = "dd-MM-yyyy";
            dtp_fecha.Format = DateTimePickerFormat.Custom;
            dtp_fecha.Location = new Point(132, 153);
            dtp_fecha.Margin = new Padding(3, 2, 3, 2);
            dtp_fecha.Name = "dtp_fecha";
            dtp_fecha.Size = new Size(224, 23);
            dtp_fecha.TabIndex = 6;
            // 
            // lbl_numero_de_factura
            // 
            lbl_numero_de_factura.AutoSize = true;
            lbl_numero_de_factura.Location = new Point(16, 110);
            lbl_numero_de_factura.Name = "lbl_numero_de_factura";
            lbl_numero_de_factura.Size = new Size(110, 15);
            lbl_numero_de_factura.TabIndex = 7;
            lbl_numero_de_factura.Text = "Numero de factura:";
            // 
            // txt_numero_de_factura
            // 
            txt_numero_de_factura.Location = new Point(132, 107);
            txt_numero_de_factura.Margin = new Padding(3, 2, 3, 2);
            txt_numero_de_factura.Name = "txt_numero_de_factura";
            txt_numero_de_factura.Size = new Size(224, 23);
            txt_numero_de_factura.TabIndex = 8;
            // 
            // txt_total_pago
            // 
            txt_total_pago.Location = new Point(132, 192);
            txt_total_pago.Margin = new Padding(3, 2, 3, 2);
            txt_total_pago.Name = "txt_total_pago";
            txt_total_pago.Size = new Size(224, 23);
            txt_total_pago.TabIndex = 10;
            // 
            // lbl_total_pago
            // 
            lbl_total_pago.AutoSize = true;
            lbl_total_pago.Location = new Point(36, 195);
            lbl_total_pago.Name = "lbl_total_pago";
            lbl_total_pago.Size = new Size(65, 15);
            lbl_total_pago.TabIndex = 9;
            lbl_total_pago.Text = "Total pago:";
            // 
            // btn_habilitar
            // 
            btn_habilitar.Location = new Point(290, 251);
            btn_habilitar.Margin = new Padding(3, 2, 3, 2);
            btn_habilitar.Name = "btn_habilitar";
            btn_habilitar.Size = new Size(132, 25);
            btn_habilitar.TabIndex = 11;
            btn_habilitar.Text = "Habilitar";
            btn_habilitar.UseVisualStyleBackColor = true;
            // 
            // btn_guardarp
            // 
            btn_guardarp.Location = new Point(10, 251);
            btn_guardarp.Margin = new Padding(3, 2, 3, 2);
            btn_guardarp.Name = "btn_guardarp";
            btn_guardarp.Size = new Size(132, 25);
            btn_guardarp.TabIndex = 13;
            btn_guardarp.Text = "Guardar";
            btn_guardarp.UseVisualStyleBackColor = true;
            btn_guardarp.Click += btn_guardarp_Click;
            // 
            // Entrada_pagos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(434, 293);
            Controls.Add(btn_guardarp);
            Controls.Add(btn_habilitar);
            Controls.Add(txt_total_pago);
            Controls.Add(lbl_total_pago);
            Controls.Add(txt_numero_de_factura);
            Controls.Add(lbl_numero_de_factura);
            Controls.Add(dtp_fecha);
            Controls.Add(lbl_fecha_de_pago);
            Controls.Add(Cbox_cliente);
            Controls.Add(lbl_clientes);
            Controls.Add(lbl_entrada_pagos);
            Controls.Add(btn_atras);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Entrada_pagos";
            Text = "Entrada_pagos";
            Load += Entrada_pagos_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_atras;
        private Label lbl_entrada_pagos;
        private Label lbl_clientes;
        private ComboBox Cbox_cliente;
        private Label lbl_fecha_de_pago;
        private DateTimePicker dtp_fecha;
        private Label lbl_numero_de_factura;
        private TextBox txt_numero_de_factura;
        private TextBox txt_total_pago;
        private Label lbl_total_pago;
        private Button btn_habilitar;
        private Button btn_guardarp;
    }
}