namespace Sistema_de_ventas_first
{
    partial class Entrada_empleados
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
            btn_atras = new Button();
            txt_documento = new TextBox();
            lbl_documento = new Label();
            lbl_nombre = new Label();
            txt_nombre = new TextBox();
            lbl_extension = new Label();
            txt_extension = new TextBox();
            lbl_apellido = new Label();
            txt_apellido = new TextBox();
            lbl_cargo = new Label();
            txt_cargo = new TextBox();
            lbl_email = new Label();
            txt_email = new TextBox();
            lbl_oficina = new Label();
            Cbox_oficina = new ComboBox();
            btn_guardar2 = new Button();
            SuspendLayout();
            // 
            // lbl_empleados
            // 
            lbl_empleados.AutoSize = true;
            lbl_empleados.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_empleados.Location = new Point(19, 14);
            lbl_empleados.Margin = new Padding(5, 0, 5, 0);
            lbl_empleados.Name = "lbl_empleados";
            lbl_empleados.Size = new Size(183, 46);
            lbl_empleados.TabIndex = 1;
            lbl_empleados.Text = "Empleados";
            // 
            // btn_atras
            // 
            btn_atras.Location = new Point(28, 660);
            btn_atras.Margin = new Padding(5, 5, 5, 5);
            btn_atras.Name = "btn_atras";
            btn_atras.Size = new Size(519, 48);
            btn_atras.TabIndex = 5;
            btn_atras.Text = "Atras";
            btn_atras.UseVisualStyleBackColor = true;
            btn_atras.Click += btn_atras_Click;
            // 
            // txt_documento
            // 
            txt_documento.Location = new Point(28, 88);
            txt_documento.Margin = new Padding(5, 5, 5, 5);
            txt_documento.Name = "txt_documento";
            txt_documento.Size = new Size(519, 27);
            txt_documento.TabIndex = 6;
            txt_documento.TextChanged += txt_documento_TextChanged;
            // 
            // lbl_documento
            // 
            lbl_documento.AutoSize = true;
            lbl_documento.Location = new Point(28, 63);
            lbl_documento.Margin = new Padding(5, 0, 5, 0);
            lbl_documento.Name = "lbl_documento";
            lbl_documento.Size = new Size(87, 20);
            lbl_documento.TabIndex = 7;
            lbl_documento.Text = "Documento";
            // 
            // lbl_nombre
            // 
            lbl_nombre.AutoSize = true;
            lbl_nombre.Location = new Point(28, 139);
            lbl_nombre.Margin = new Padding(5, 0, 5, 0);
            lbl_nombre.Name = "lbl_nombre";
            lbl_nombre.Size = new Size(64, 20);
            lbl_nombre.TabIndex = 9;
            lbl_nombre.Text = "Nombre";
            // 
            // txt_nombre
            // 
            txt_nombre.Location = new Point(28, 164);
            txt_nombre.Margin = new Padding(5, 5, 5, 5);
            txt_nombre.Name = "txt_nombre";
            txt_nombre.Size = new Size(519, 27);
            txt_nombre.TabIndex = 8;
            // 
            // lbl_extension
            // 
            lbl_extension.AutoSize = true;
            lbl_extension.Location = new Point(28, 289);
            lbl_extension.Margin = new Padding(5, 0, 5, 0);
            lbl_extension.Name = "lbl_extension";
            lbl_extension.Size = new Size(72, 20);
            lbl_extension.TabIndex = 13;
            lbl_extension.Text = "Extension";
            // 
            // txt_extension
            // 
            txt_extension.Location = new Point(28, 315);
            txt_extension.Margin = new Padding(5, 5, 5, 5);
            txt_extension.Name = "txt_extension";
            txt_extension.Size = new Size(519, 27);
            txt_extension.TabIndex = 12;
            // 
            // lbl_apellido
            // 
            lbl_apellido.AutoSize = true;
            lbl_apellido.Location = new Point(28, 213);
            lbl_apellido.Margin = new Padding(5, 0, 5, 0);
            lbl_apellido.Name = "lbl_apellido";
            lbl_apellido.Size = new Size(66, 20);
            lbl_apellido.TabIndex = 11;
            lbl_apellido.Text = "Apellido";
            // 
            // txt_apellido
            // 
            txt_apellido.Location = new Point(28, 239);
            txt_apellido.Margin = new Padding(5, 5, 5, 5);
            txt_apellido.Name = "txt_apellido";
            txt_apellido.Size = new Size(519, 27);
            txt_apellido.TabIndex = 10;
            // 
            // lbl_cargo
            // 
            lbl_cargo.AutoSize = true;
            lbl_cargo.Location = new Point(28, 433);
            lbl_cargo.Margin = new Padding(5, 0, 5, 0);
            lbl_cargo.Name = "lbl_cargo";
            lbl_cargo.Size = new Size(49, 20);
            lbl_cargo.TabIndex = 17;
            lbl_cargo.Text = "Cargo";
            lbl_cargo.Click += lbl_cargo_Click;
            // 
            // txt_cargo
            // 
            txt_cargo.Location = new Point(28, 459);
            txt_cargo.Margin = new Padding(5, 5, 5, 5);
            txt_cargo.Name = "txt_cargo";
            txt_cargo.Size = new Size(365, 27);
            txt_cargo.TabIndex = 16;
            txt_cargo.TextChanged += txt_cargo_TextChanged;
            // 
            // lbl_email
            // 
            lbl_email.AutoSize = true;
            lbl_email.Location = new Point(31, 359);
            lbl_email.Margin = new Padding(5, 0, 5, 0);
            lbl_email.Name = "lbl_email";
            lbl_email.Size = new Size(46, 20);
            lbl_email.TabIndex = 15;
            lbl_email.Text = "Email";
            // 
            // txt_email
            // 
            txt_email.Location = new Point(28, 384);
            txt_email.Margin = new Padding(5, 5, 5, 5);
            txt_email.Name = "txt_email";
            txt_email.Size = new Size(365, 27);
            txt_email.TabIndex = 14;
            // 
            // lbl_oficina
            // 
            lbl_oficina.AutoSize = true;
            lbl_oficina.Location = new Point(31, 508);
            lbl_oficina.Margin = new Padding(5, 0, 5, 0);
            lbl_oficina.Name = "lbl_oficina";
            lbl_oficina.Size = new Size(56, 20);
            lbl_oficina.TabIndex = 18;
            lbl_oficina.Text = "Oficina";
            // 
            // Cbox_oficina
            // 
            Cbox_oficina.DropDownStyle = ComboBoxStyle.DropDownList;
            Cbox_oficina.FormattingEnabled = true;
            Cbox_oficina.Location = new Point(31, 533);
            Cbox_oficina.Margin = new Padding(5, 5, 5, 5);
            Cbox_oficina.Name = "Cbox_oficina";
            Cbox_oficina.Size = new Size(365, 28);
            Cbox_oficina.TabIndex = 19;
            Cbox_oficina.SelectedIndexChanged += Cbox_oficina_SelectedIndexChanged;
            // 
            // btn_guardar2
            // 
            btn_guardar2.Location = new Point(28, 592);
            btn_guardar2.Margin = new Padding(5, 5, 5, 5);
            btn_guardar2.Name = "btn_guardar2";
            btn_guardar2.Size = new Size(519, 48);
            btn_guardar2.TabIndex = 21;
            btn_guardar2.Text = "Guardar";
            btn_guardar2.UseVisualStyleBackColor = true;
            btn_guardar2.Click += btn_guardar2_Click;
            // 
            // Entrada_empleados
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(574, 738);
            Controls.Add(btn_guardar2);
            Controls.Add(Cbox_oficina);
            Controls.Add(lbl_oficina);
            Controls.Add(lbl_cargo);
            Controls.Add(txt_cargo);
            Controls.Add(lbl_email);
            Controls.Add(txt_email);
            Controls.Add(lbl_extension);
            Controls.Add(txt_extension);
            Controls.Add(lbl_apellido);
            Controls.Add(txt_apellido);
            Controls.Add(lbl_nombre);
            Controls.Add(txt_nombre);
            Controls.Add(lbl_documento);
            Controls.Add(txt_documento);
            Controls.Add(btn_atras);
            Controls.Add(lbl_empleados);
            Margin = new Padding(5, 5, 5, 5);
            Name = "Entrada_empleados";
            Text = "Entrada_empleados";
            Load += Entrada_empleados_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lbl_empleados;
        private Button btn_atras;
        private TextBox txt_documento;
        private Label lbl_documento;
        private Label lbl_nombre;
        private TextBox txt_nombre;
        private Label lbl_extension;
        private TextBox txt_extension;
        private Label lbl_apellido;
        private TextBox txt_apellido;
        private Label lbl_cargo;
        private TextBox txt_cargo;
        private Label lbl_email;
        private TextBox txt_email;
        private Label lbl_oficina;
        private ComboBox Cbox_oficina;
        private Button btn_guardar2;
    }
}