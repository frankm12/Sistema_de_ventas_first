namespace Sistema_de_ventas_first
{
    partial class Entrada_Ordenes
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
            dtp_fechaRecibido = new DateTimePicker();
            dtp_fechaLimiteEntrega = new DateTimePicker();
            dtp_fechaEntrega = new DateTimePicker();
            label1 = new Label();
            lbl_fechaRecibido = new Label();
            lbl_fechaLimiteEntrega = new Label();
            lbl_fechaEntrega = new Label();
            lbl_estado = new Label();
            lbl_observacion = new Label();
            label7 = new Label();
            txt_estado = new TextBox();
            txt_observacion = new TextBox();
            Cbox_idcliente = new ComboBox();
            btn_guardaro = new Button();
            btn_atras = new Button();
            btn_habilitar = new Button();
            SuspendLayout();
            // 
            // dtp_fechaRecibido
            // 
            dtp_fechaRecibido.CustomFormat = "dd-MM-yyyy";
            dtp_fechaRecibido.Format = DateTimePickerFormat.Custom;
            dtp_fechaRecibido.Location = new Point(139, 48);
            dtp_fechaRecibido.Name = "dtp_fechaRecibido";
            dtp_fechaRecibido.Size = new Size(200, 23);
            dtp_fechaRecibido.TabIndex = 0;
            // 
            // dtp_fechaLimiteEntrega
            // 
            dtp_fechaLimiteEntrega.CustomFormat = "dd-MM-yyyy";
            dtp_fechaLimiteEntrega.Format = DateTimePickerFormat.Custom;
            dtp_fechaLimiteEntrega.Location = new Point(139, 89);
            dtp_fechaLimiteEntrega.Name = "dtp_fechaLimiteEntrega";
            dtp_fechaLimiteEntrega.Size = new Size(200, 23);
            dtp_fechaLimiteEntrega.TabIndex = 1;
            // 
            // dtp_fechaEntrega
            // 
            dtp_fechaEntrega.CustomFormat = "dd-MM-yyyy";
            dtp_fechaEntrega.Format = DateTimePickerFormat.Custom;
            dtp_fechaEntrega.Location = new Point(139, 132);
            dtp_fechaEntrega.Name = "dtp_fechaEntrega";
            dtp_fechaEntrega.Size = new Size(200, 23);
            dtp_fechaEntrega.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(10, 8);
            label1.Name = "label1";
            label1.Size = new Size(86, 25);
            label1.TabIndex = 3;
            label1.Text = "Ordenes";
            // 
            // lbl_fechaRecibido
            // 
            lbl_fechaRecibido.AutoSize = true;
            lbl_fechaRecibido.Location = new Point(9, 51);
            lbl_fechaRecibido.Name = "lbl_fechaRecibido";
            lbl_fechaRecibido.Size = new Size(127, 15);
            lbl_fechaRecibido.TabIndex = 4;
            lbl_fechaRecibido.Text = "Fecha de recibimiento:";
            // 
            // lbl_fechaLimiteEntrega
            // 
            lbl_fechaLimiteEntrega.AutoSize = true;
            lbl_fechaLimiteEntrega.Location = new Point(35, 93);
            lbl_fechaLimiteEntrega.Name = "lbl_fechaLimiteEntrega";
            lbl_fechaLimiteEntrega.Size = new Size(77, 15);
            lbl_fechaLimiteEntrega.TabIndex = 5;
            lbl_fechaLimiteEntrega.Text = "Fecha Limite:";
            // 
            // lbl_fechaEntrega
            // 
            lbl_fechaEntrega.AutoSize = true;
            lbl_fechaEntrega.Location = new Point(21, 135);
            lbl_fechaEntrega.Name = "lbl_fechaEntrega";
            lbl_fechaEntrega.Size = new Size(100, 15);
            lbl_fechaEntrega.TabIndex = 6;
            lbl_fechaEntrega.Text = "Fecha de entrega:";
            // 
            // lbl_estado
            // 
            lbl_estado.AutoSize = true;
            lbl_estado.Location = new Point(51, 181);
            lbl_estado.Name = "lbl_estado";
            lbl_estado.Size = new Size(45, 15);
            lbl_estado.TabIndex = 7;
            lbl_estado.Text = "Estado:";
            // 
            // lbl_observacion
            // 
            lbl_observacion.AutoSize = true;
            lbl_observacion.Location = new Point(33, 224);
            lbl_observacion.Name = "lbl_observacion";
            lbl_observacion.Size = new Size(76, 15);
            lbl_observacion.TabIndex = 8;
            lbl_observacion.Text = "Observacion:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(49, 270);
            label7.Name = "label7";
            label7.Size = new Size(47, 15);
            label7.TabIndex = 9;
            label7.Text = "Cliente:";
            // 
            // txt_estado
            // 
            txt_estado.Location = new Point(138, 178);
            txt_estado.Name = "txt_estado";
            txt_estado.Size = new Size(201, 23);
            txt_estado.TabIndex = 10;
            // 
            // txt_observacion
            // 
            txt_observacion.Location = new Point(138, 221);
            txt_observacion.Name = "txt_observacion";
            txt_observacion.Size = new Size(200, 23);
            txt_observacion.TabIndex = 11;
            // 
            // Cbox_idcliente
            // 
            Cbox_idcliente.DropDownStyle = ComboBoxStyle.DropDownList;
            Cbox_idcliente.FormattingEnabled = true;
            Cbox_idcliente.Location = new Point(139, 267);
            Cbox_idcliente.Margin = new Padding(3, 2, 3, 2);
            Cbox_idcliente.Name = "Cbox_idcliente";
            Cbox_idcliente.Size = new Size(200, 23);
            Cbox_idcliente.TabIndex = 27;
            // 
            // btn_guardaro
            // 
            btn_guardaro.Location = new Point(10, 318);
            btn_guardaro.Name = "btn_guardaro";
            btn_guardaro.Size = new Size(117, 27);
            btn_guardaro.TabIndex = 28;
            btn_guardaro.Text = "Guardar";
            btn_guardaro.UseVisualStyleBackColor = true;
            btn_guardaro.Click += btn_guardaro_Click;
            // 
            // btn_atras
            // 
            btn_atras.Location = new Point(135, 318);
            btn_atras.Name = "btn_atras";
            btn_atras.Size = new Size(117, 27);
            btn_atras.TabIndex = 29;
            btn_atras.Text = "Atras";
            btn_atras.UseVisualStyleBackColor = true;
            btn_atras.Click += btn_atras_Click;
            // 
            // btn_habilitar
            // 
            btn_habilitar.Location = new Point(257, 318);
            btn_habilitar.Name = "btn_habilitar";
            btn_habilitar.Size = new Size(117, 27);
            btn_habilitar.TabIndex = 30;
            btn_habilitar.Text = "Habilitar";
            btn_habilitar.UseVisualStyleBackColor = true;
            // 
            // Entrada_Ordenes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 361);
            Controls.Add(btn_habilitar);
            Controls.Add(btn_atras);
            Controls.Add(btn_guardaro);
            Controls.Add(Cbox_idcliente);
            Controls.Add(txt_observacion);
            Controls.Add(txt_estado);
            Controls.Add(label7);
            Controls.Add(lbl_observacion);
            Controls.Add(lbl_estado);
            Controls.Add(lbl_fechaEntrega);
            Controls.Add(lbl_fechaLimiteEntrega);
            Controls.Add(lbl_fechaRecibido);
            Controls.Add(label1);
            Controls.Add(dtp_fechaEntrega);
            Controls.Add(dtp_fechaLimiteEntrega);
            Controls.Add(dtp_fechaRecibido);
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "Entrada_Ordenes";
            Text = "Entrada_Ordenes";
            Load += Entrada_Ordenes_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dtp_fechaRecibido;
        private DateTimePicker dtp_fechaLimiteEntrega;
        private DateTimePicker dtp_fechaEntrega;
        private Label label1;
        private Label lbl_fechaRecibido;
        private Label lbl_fechaLimiteEntrega;
        private Label lbl_fechaEntrega;
        private Label lbl_estado;
        private Label lbl_observacion;
        private Label label7;
        private TextBox txt_estado;
        private TextBox txt_observacion;
        private ComboBox Cbox_idcliente;
        private Button btn_guardaro;
        private Button btn_atras;
        private Button btn_habilitar;
    }
}