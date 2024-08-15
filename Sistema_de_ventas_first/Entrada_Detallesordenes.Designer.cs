namespace Sistema_de_ventas_first
{
    partial class Entrada_Detallesordenes
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
            lbl_Detalles2 = new Label();
            lbl_idorden = new Label();
            label3 = new Label();
            lbl_valorUnitario = new Label();
            lbl_idproducto = new Label();
            lbl_ordenEntrega = new Label();
            txt_cantidadpedida = new TextBox();
            txt_valorunitario = new TextBox();
            dtp_ordenentrega = new DateTimePicker();
            Cbox_id_producto2 = new ComboBox();
            Cbox_idorden = new ComboBox();
            btn_guardar = new Button();
            btn_atras = new Button();
            btn_habilitar = new Button();
            SuspendLayout();
            // 
            // lbl_Detalles2
            // 
            lbl_Detalles2.AutoSize = true;
            lbl_Detalles2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Detalles2.Location = new Point(14, 12);
            lbl_Detalles2.Name = "lbl_Detalles2";
            lbl_Detalles2.Size = new Size(105, 32);
            lbl_Detalles2.TabIndex = 0;
            lbl_Detalles2.Text = "Detalles";
            // 
            // lbl_idorden
            // 
            lbl_idorden.AutoSize = true;
            lbl_idorden.Location = new Point(79, 61);
            lbl_idorden.Name = "lbl_idorden";
            lbl_idorden.Size = new Size(68, 20);
            lbl_idorden.TabIndex = 1;
            lbl_idorden.Text = "Id orden:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(42, 169);
            label3.Name = "label3";
            label3.Size = new Size(143, 20);
            label3.TabIndex = 2;
            label3.Text = "Cantidad de Pedido:";
            // 
            // lbl_valorUnitario
            // 
            lbl_valorUnitario.AutoSize = true;
            lbl_valorUnitario.Location = new Point(49, 227);
            lbl_valorUnitario.Name = "lbl_valorUnitario";
            lbl_valorUnitario.Size = new Size(125, 20);
            lbl_valorUnitario.TabIndex = 3;
            lbl_valorUnitario.Text = "Valor por Unidad:";
            // 
            // lbl_idproducto
            // 
            lbl_idproducto.AutoSize = true;
            lbl_idproducto.Location = new Point(64, 117);
            lbl_idproducto.Name = "lbl_idproducto";
            lbl_idproducto.Size = new Size(89, 20);
            lbl_idproducto.TabIndex = 4;
            lbl_idproducto.Text = "Id Producto:";
            // 
            // lbl_ordenEntrega
            // 
            lbl_ordenEntrega.AutoSize = true;
            lbl_ordenEntrega.Location = new Point(45, 280);
            lbl_ordenEntrega.Name = "lbl_ordenEntrega";
            lbl_ordenEntrega.Size = new Size(129, 20);
            lbl_ordenEntrega.TabIndex = 5;
            lbl_ordenEntrega.Text = "Orden de entrega:";
            // 
            // txt_cantidadpedida
            // 
            txt_cantidadpedida.Location = new Point(187, 168);
            txt_cantidadpedida.Margin = new Padding(3, 4, 3, 4);
            txt_cantidadpedida.Name = "txt_cantidadpedida";
            txt_cantidadpedida.Size = new Size(170, 27);
            txt_cantidadpedida.TabIndex = 6;
            // 
            // txt_valorunitario
            // 
            txt_valorunitario.Location = new Point(187, 223);
            txt_valorunitario.Margin = new Padding(3, 4, 3, 4);
            txt_valorunitario.Name = "txt_valorunitario";
            txt_valorunitario.Size = new Size(170, 27);
            txt_valorunitario.TabIndex = 7;
            // 
            // dtp_ordenentrega
            // 
            dtp_ordenentrega.Format = DateTimePickerFormat.Custom;
            dtp_ordenentrega.Location = new Point(186, 276);
            dtp_ordenentrega.Margin = new Padding(3, 4, 3, 4);
            dtp_ordenentrega.Name = "dtp_ordenentrega";
            dtp_ordenentrega.Size = new Size(171, 27);
            dtp_ordenentrega.TabIndex = 8;
            // 
            // Cbox_id_producto2
            // 
            Cbox_id_producto2.DropDownStyle = ComboBoxStyle.DropDownList;
            Cbox_id_producto2.FormattingEnabled = true;
            Cbox_id_producto2.Location = new Point(186, 113);
            Cbox_id_producto2.Name = "Cbox_id_producto2";
            Cbox_id_producto2.Size = new Size(171, 28);
            Cbox_id_producto2.TabIndex = 28;
            // 
            // Cbox_idorden
            // 
            Cbox_idorden.DropDownStyle = ComboBoxStyle.DropDownList;
            Cbox_idorden.FormattingEnabled = true;
            Cbox_idorden.Location = new Point(186, 57);
            Cbox_idorden.Name = "Cbox_idorden";
            Cbox_idorden.Size = new Size(171, 28);
            Cbox_idorden.TabIndex = 29;
            // 
            // btn_guardar
            // 
            btn_guardar.Location = new Point(14, 335);
            btn_guardar.Margin = new Padding(3, 4, 3, 4);
            btn_guardar.Name = "btn_guardar";
            btn_guardar.Size = new Size(114, 35);
            btn_guardar.TabIndex = 30;
            btn_guardar.Text = "Guardar";
            btn_guardar.UseVisualStyleBackColor = true;
            btn_guardar.Click += btn_guardar_Click;
            // 
            // btn_atras
            // 
            btn_atras.Location = new Point(144, 335);
            btn_atras.Margin = new Padding(3, 4, 3, 4);
            btn_atras.Name = "btn_atras";
            btn_atras.Size = new Size(114, 35);
            btn_atras.TabIndex = 31;
            btn_atras.Text = "Atras";
            btn_atras.UseVisualStyleBackColor = true;
            btn_atras.Click += btn_atras_Click;
            // 
            // btn_habilitar
            // 
            btn_habilitar.Location = new Point(277, 335);
            btn_habilitar.Margin = new Padding(3, 4, 3, 4);
            btn_habilitar.Name = "btn_habilitar";
            btn_habilitar.Size = new Size(114, 35);
            btn_habilitar.TabIndex = 32;
            btn_habilitar.Text = "Habilitar";
            btn_habilitar.UseVisualStyleBackColor = true;
            btn_habilitar.Click += btn_habilitar_Click;
            // 
            // Entrada_Detallesordenes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(414, 393);
            Controls.Add(btn_habilitar);
            Controls.Add(btn_atras);
            Controls.Add(btn_guardar);
            Controls.Add(Cbox_idorden);
            Controls.Add(Cbox_id_producto2);
            Controls.Add(dtp_ordenentrega);
            Controls.Add(txt_valorunitario);
            Controls.Add(txt_cantidadpedida);
            Controls.Add(lbl_ordenEntrega);
            Controls.Add(lbl_idproducto);
            Controls.Add(lbl_valorUnitario);
            Controls.Add(label3);
            Controls.Add(lbl_idorden);
            Controls.Add(lbl_Detalles2);
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Entrada_Detallesordenes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Entrada_Detallesordenes";
            Load += Entrada_Detallesordenes_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_Detalles2;
        private Label lbl_idorden;
        private Label label3;
        private Label lbl_valorUnitario;
        private Label lbl_idproducto;
        private Label lbl_ordenEntrega;
        private TextBox txt_cantidadpedida;
        private TextBox txt_valorunitario;
        private DateTimePicker dtp_ordenentrega;
        private ComboBox Cbox_id_producto2;
        private ComboBox Cbox_idorden;
        private Button btn_guardar;
        private Button btn_atras;
        private Button btn_habilitar;
    }
}