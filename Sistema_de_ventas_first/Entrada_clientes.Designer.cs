namespace Sistema_de_ventas_first
{
    partial class Entrada_clientes
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
            lbl_entrada_clientes = new Label();
            dataGridView1 = new DataGridView();
            txt_empresa = new TextBox();
            lbl_empresa = new Label();
            lbl_nombre = new Label();
            txt_nombre_del_cliente = new TextBox();
            lbl_telefono = new Label();
            txt_telefono = new TextBox();
            lbl_apellido = new Label();
            txt_apellido = new TextBox();
            lbl_direccion = new Label();
            txt_direccion = new TextBox();
            lbl_ciudad = new Label();
            txt_ciudad = new TextBox();
            lbl_empleado_atiende = new Label();
            lbl_pais = new Label();
            txt_pais = new TextBox();
            lbl_codigo_postal = new Label();
            txt_codigo_postal = new TextBox();
            lbl_departamento = new Label();
            txt_departamento = new TextBox();
            Cbox_empleadoAtiende = new ComboBox();
            btn_guardar = new Button();
            btn_editar = new Button();
            btn_eliminar = new Button();
            btn_atras = new Button();
            btn_habilitar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // lbl_entrada_clientes
            // 
            lbl_entrada_clientes.AutoSize = true;
            lbl_entrada_clientes.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_entrada_clientes.Location = new Point(10, 7);
            lbl_entrada_clientes.Name = "lbl_entrada_clientes";
            lbl_entrada_clientes.Size = new Size(111, 37);
            lbl_entrada_clientes.TabIndex = 0;
            lbl_entrada_clientes.Text = "Clientes";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(10, 44);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(747, 141);
            dataGridView1.TabIndex = 1;
            // 
            // txt_empresa
            // 
            txt_empresa.Location = new Point(10, 214);
            txt_empresa.Margin = new Padding(3, 2, 3, 2);
            txt_empresa.Name = "txt_empresa";
            txt_empresa.Size = new Size(358, 23);
            txt_empresa.TabIndex = 2;
            // 
            // lbl_empresa
            // 
            lbl_empresa.AutoSize = true;
            lbl_empresa.Location = new Point(10, 197);
            lbl_empresa.Name = "lbl_empresa";
            lbl_empresa.Size = new Size(115, 15);
            lbl_empresa.TabIndex = 3;
            lbl_empresa.Text = "Nombre de empresa";
            // 
            // lbl_nombre
            // 
            lbl_nombre.AutoSize = true;
            lbl_nombre.Location = new Point(10, 242);
            lbl_nombre.Name = "lbl_nombre";
            lbl_nombre.Size = new Size(108, 15);
            lbl_nombre.TabIndex = 5;
            lbl_nombre.Text = "Nombre del cliente";
            // 
            // txt_nombre_del_cliente
            // 
            txt_nombre_del_cliente.Location = new Point(10, 260);
            txt_nombre_del_cliente.Margin = new Padding(3, 2, 3, 2);
            txt_nombre_del_cliente.Name = "txt_nombre_del_cliente";
            txt_nombre_del_cliente.Size = new Size(358, 23);
            txt_nombre_del_cliente.TabIndex = 4;
            // 
            // lbl_telefono
            // 
            lbl_telefono.AutoSize = true;
            lbl_telefono.Location = new Point(10, 333);
            lbl_telefono.Name = "lbl_telefono";
            lbl_telefono.Size = new Size(52, 15);
            lbl_telefono.TabIndex = 9;
            lbl_telefono.Text = "Telefono";
            // 
            // txt_telefono
            // 
            txt_telefono.Location = new Point(10, 350);
            txt_telefono.Margin = new Padding(3, 2, 3, 2);
            txt_telefono.Name = "txt_telefono";
            txt_telefono.Size = new Size(358, 23);
            txt_telefono.TabIndex = 8;
            // 
            // lbl_apellido
            // 
            lbl_apellido.AutoSize = true;
            lbl_apellido.Location = new Point(10, 288);
            lbl_apellido.Name = "lbl_apellido";
            lbl_apellido.Size = new Size(109, 15);
            lbl_apellido.TabIndex = 7;
            lbl_apellido.Text = "Apellido Del cliente";
            // 
            // txt_apellido
            // 
            txt_apellido.Location = new Point(10, 305);
            txt_apellido.Margin = new Padding(3, 2, 3, 2);
            txt_apellido.Name = "txt_apellido";
            txt_apellido.Size = new Size(358, 23);
            txt_apellido.TabIndex = 6;
            // 
            // lbl_direccion
            // 
            lbl_direccion.AutoSize = true;
            lbl_direccion.Location = new Point(10, 378);
            lbl_direccion.Name = "lbl_direccion";
            lbl_direccion.Size = new Size(57, 15);
            lbl_direccion.TabIndex = 11;
            lbl_direccion.Text = "Direccion";
            // 
            // txt_direccion
            // 
            txt_direccion.Location = new Point(10, 395);
            txt_direccion.Margin = new Padding(3, 2, 3, 2);
            txt_direccion.Name = "txt_direccion";
            txt_direccion.Size = new Size(358, 23);
            txt_direccion.TabIndex = 10;
            // 
            // lbl_ciudad
            // 
            lbl_ciudad.AutoSize = true;
            lbl_ciudad.Location = new Point(10, 421);
            lbl_ciudad.Name = "lbl_ciudad";
            lbl_ciudad.Size = new Size(45, 15);
            lbl_ciudad.TabIndex = 13;
            lbl_ciudad.Text = "Ciudad";
            // 
            // txt_ciudad
            // 
            txt_ciudad.Location = new Point(10, 438);
            txt_ciudad.Margin = new Padding(3, 2, 3, 2);
            txt_ciudad.Name = "txt_ciudad";
            txt_ciudad.Size = new Size(358, 23);
            txt_ciudad.TabIndex = 12;
            // 
            // lbl_empleado_atiende
            // 
            lbl_empleado_atiende.AutoSize = true;
            lbl_empleado_atiende.Location = new Point(400, 333);
            lbl_empleado_atiende.Name = "lbl_empleado_atiende";
            lbl_empleado_atiende.Size = new Size(138, 15);
            lbl_empleado_atiende.TabIndex = 21;
            lbl_empleado_atiende.Text = "Empleado que lo atiende";
            // 
            // lbl_pais
            // 
            lbl_pais.AutoSize = true;
            lbl_pais.Location = new Point(400, 288);
            lbl_pais.Name = "lbl_pais";
            lbl_pais.Size = new Size(28, 15);
            lbl_pais.TabIndex = 19;
            lbl_pais.Text = "Pais";
            // 
            // txt_pais
            // 
            txt_pais.Location = new Point(400, 305);
            txt_pais.Margin = new Padding(3, 2, 3, 2);
            txt_pais.Name = "txt_pais";
            txt_pais.Size = new Size(358, 23);
            txt_pais.TabIndex = 18;
            // 
            // lbl_codigo_postal
            // 
            lbl_codigo_postal.AutoSize = true;
            lbl_codigo_postal.Location = new Point(400, 242);
            lbl_codigo_postal.Name = "lbl_codigo_postal";
            lbl_codigo_postal.Size = new Size(81, 15);
            lbl_codigo_postal.TabIndex = 17;
            lbl_codigo_postal.Text = "Codigo postal";
            // 
            // txt_codigo_postal
            // 
            txt_codigo_postal.Location = new Point(400, 260);
            txt_codigo_postal.Margin = new Padding(3, 2, 3, 2);
            txt_codigo_postal.Name = "txt_codigo_postal";
            txt_codigo_postal.Size = new Size(358, 23);
            txt_codigo_postal.TabIndex = 16;
            // 
            // lbl_departamento
            // 
            lbl_departamento.AutoSize = true;
            lbl_departamento.Location = new Point(400, 197);
            lbl_departamento.Name = "lbl_departamento";
            lbl_departamento.Size = new Size(83, 15);
            lbl_departamento.TabIndex = 15;
            lbl_departamento.Text = "Departamento";
            // 
            // txt_departamento
            // 
            txt_departamento.Location = new Point(400, 214);
            txt_departamento.Margin = new Padding(3, 2, 3, 2);
            txt_departamento.Name = "txt_departamento";
            txt_departamento.Size = new Size(358, 23);
            txt_departamento.TabIndex = 14;
            // 
            // Cbox_empleadoAtiende
            // 
            Cbox_empleadoAtiende.DropDownStyle = ComboBoxStyle.DropDownList;
            Cbox_empleadoAtiende.FormattingEnabled = true;
            Cbox_empleadoAtiende.Location = new Point(400, 350);
            Cbox_empleadoAtiende.Margin = new Padding(3, 2, 3, 2);
            Cbox_empleadoAtiende.Name = "Cbox_empleadoAtiende";
            Cbox_empleadoAtiende.Size = new Size(358, 23);
            Cbox_empleadoAtiende.TabIndex = 26;
            // 
            // btn_guardar
            // 
            btn_guardar.Location = new Point(400, 391);
            btn_guardar.Margin = new Padding(3, 2, 3, 2);
            btn_guardar.Name = "btn_guardar";
            btn_guardar.Size = new Size(82, 22);
            btn_guardar.TabIndex = 27;
            btn_guardar.Text = "Guardar";
            btn_guardar.UseVisualStyleBackColor = true;
            btn_guardar.Click += btn_guardar_Click;
            // 
            // btn_editar
            // 
            btn_editar.Location = new Point(493, 391);
            btn_editar.Margin = new Padding(3, 2, 3, 2);
            btn_editar.Name = "btn_editar";
            btn_editar.Size = new Size(82, 22);
            btn_editar.TabIndex = 28;
            btn_editar.Text = "Editar";
            btn_editar.UseVisualStyleBackColor = true;
            // 
            // btn_eliminar
            // 
            btn_eliminar.Location = new Point(585, 391);
            btn_eliminar.Margin = new Padding(3, 2, 3, 2);
            btn_eliminar.Name = "btn_eliminar";
            btn_eliminar.Size = new Size(82, 22);
            btn_eliminar.TabIndex = 29;
            btn_eliminar.Text = "Eliminar";
            btn_eliminar.UseVisualStyleBackColor = true;
            // 
            // btn_atras
            // 
            btn_atras.Location = new Point(400, 421);
            btn_atras.Margin = new Padding(3, 2, 3, 2);
            btn_atras.Name = "btn_atras";
            btn_atras.Size = new Size(358, 38);
            btn_atras.TabIndex = 30;
            btn_atras.Text = "Atras";
            btn_atras.UseVisualStyleBackColor = true;
            // 
            // btn_habilitar
            // 
            btn_habilitar.Location = new Point(676, 391);
            btn_habilitar.Margin = new Padding(3, 2, 3, 2);
            btn_habilitar.Name = "btn_habilitar";
            btn_habilitar.Size = new Size(82, 22);
            btn_habilitar.TabIndex = 31;
            btn_habilitar.Text = "Habilitar";
            btn_habilitar.UseVisualStyleBackColor = true;
            // 
            // Entrada_clientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(783, 474);
            Controls.Add(btn_habilitar);
            Controls.Add(btn_atras);
            Controls.Add(btn_eliminar);
            Controls.Add(btn_editar);
            Controls.Add(btn_guardar);
            Controls.Add(Cbox_empleadoAtiende);
            Controls.Add(lbl_empleado_atiende);
            Controls.Add(lbl_pais);
            Controls.Add(txt_pais);
            Controls.Add(lbl_codigo_postal);
            Controls.Add(txt_codigo_postal);
            Controls.Add(lbl_departamento);
            Controls.Add(txt_departamento);
            Controls.Add(lbl_ciudad);
            Controls.Add(txt_ciudad);
            Controls.Add(lbl_direccion);
            Controls.Add(txt_direccion);
            Controls.Add(lbl_telefono);
            Controls.Add(txt_telefono);
            Controls.Add(lbl_apellido);
            Controls.Add(txt_apellido);
            Controls.Add(lbl_nombre);
            Controls.Add(txt_nombre_del_cliente);
            Controls.Add(lbl_empresa);
            Controls.Add(txt_empresa);
            Controls.Add(dataGridView1);
            Controls.Add(lbl_entrada_clientes);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Entrada_clientes";
            Text = "Entrada_clientes";
            Load += Entrada_clientes_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_entrada_clientes;
        private DataGridView dataGridView1;
        private TextBox txt_empresa;
        private Label lbl_empresa;
        private Label lbl_nombre;
        private TextBox txt_nombre_del_cliente;
        private Label lbl_telefono;
        private TextBox txt_telefono;
        private Label lbl_apellido;
        private TextBox txt_apellido;
        private Label lbl_direccion;
        private TextBox txt_direccion;
        private Label lbl_ciudad;
        private TextBox txt_ciudad;
        private Label lbl_empleado_atiende;
        private Label lbl_pais;
        private TextBox txt_pais;
        private Label lbl_codigo_postal;
        private TextBox txt_codigo_postal;
        private Label lbl_departamento;
        private TextBox txt_departamento;
        private ComboBox Cbox_empleadoAtiende;
        private Button btn_guardar;
        private Button btn_editar;
        private Button btn_eliminar;
        private Button btn_atras;
        private Button btn_habilitar;
    }
}