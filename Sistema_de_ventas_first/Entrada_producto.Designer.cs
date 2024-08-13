namespace Sistema_de_ventas_first
{
    partial class Entrada_producto
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
            bt_nombre = new Label();
            bt_cantidad = new Label();
            linea_producto = new Label();
            bt_precioventa = new Label();
            text_precio = new TextBox();
            text_cantidad = new TextBox();
            text_linea = new TextBox();
            bt_guardar = new Button();
            bt_atras = new Button();
            txt_nombre_bueno = new TextBox();
            SuspendLayout();
            // 
            // bt_nombre
            // 
            bt_nombre.AutoSize = true;
            bt_nombre.Location = new Point(36, 54);
            bt_nombre.Margin = new Padding(2, 0, 2, 0);
            bt_nombre.Name = "bt_nombre";
            bt_nombre.Size = new Size(182, 25);
            bt_nombre.TabIndex = 0;
            bt_nombre.Text = "Nombre de producto";
            // 
            // bt_cantidad
            // 
            bt_cantidad.AutoSize = true;
            bt_cantidad.Location = new Point(36, 224);
            bt_cantidad.Margin = new Padding(2, 0, 2, 0);
            bt_cantidad.Name = "bt_cantidad";
            bt_cantidad.Size = new Size(83, 25);
            bt_cantidad.TabIndex = 2;
            bt_cantidad.Text = "Cantidad";
            // 
            // linea_producto
            // 
            linea_producto.AutoSize = true;
            linea_producto.Location = new Point(35, 134);
            linea_producto.Margin = new Padding(2, 0, 2, 0);
            linea_producto.Name = "linea_producto";
            linea_producto.Size = new Size(156, 25);
            linea_producto.TabIndex = 3;
            linea_producto.Text = "Linea de producto";
            // 
            // bt_precioventa
            // 
            bt_precioventa.AutoSize = true;
            bt_precioventa.Location = new Point(36, 309);
            bt_precioventa.Margin = new Padding(2, 0, 2, 0);
            bt_precioventa.Name = "bt_precioventa";
            bt_precioventa.Size = new Size(133, 25);
            bt_precioventa.TabIndex = 4;
            bt_precioventa.Text = "Precio de venta";
            // 
            // text_precio
            // 
            text_precio.Location = new Point(35, 336);
            text_precio.Margin = new Padding(2);
            text_precio.Name = "text_precio";
            text_precio.Size = new Size(535, 31);
            text_precio.TabIndex = 4;
            // 
            // text_cantidad
            // 
            text_cantidad.Location = new Point(35, 251);
            text_cantidad.Margin = new Padding(2);
            text_cantidad.Name = "text_cantidad";
            text_cantidad.Size = new Size(535, 31);
            text_cantidad.TabIndex = 3;
            // 
            // text_linea
            // 
            text_linea.Location = new Point(36, 164);
            text_linea.Margin = new Padding(2);
            text_linea.Name = "text_linea";
            text_linea.Size = new Size(534, 31);
            text_linea.TabIndex = 2;
            // 
            // bt_guardar
            // 
            bt_guardar.Location = new Point(35, 390);
            bt_guardar.Margin = new Padding(2);
            bt_guardar.Name = "bt_guardar";
            bt_guardar.Size = new Size(231, 54);
            bt_guardar.TabIndex = 5;
            bt_guardar.Text = "Guardar";
            bt_guardar.UseVisualStyleBackColor = true;
            bt_guardar.Click += bt_guardar_Click;
            // 
            // bt_atras
            // 
            bt_atras.Location = new Point(355, 390);
            bt_atras.Margin = new Padding(2);
            bt_atras.Name = "bt_atras";
            bt_atras.Size = new Size(216, 54);
            bt_atras.TabIndex = 6;
            bt_atras.Text = "Atras";
            bt_atras.UseVisualStyleBackColor = true;
            bt_atras.Click += bt_atras_Click;
            // 
            // txt_nombre_bueno
            // 
            txt_nombre_bueno.Location = new Point(35, 88);
            txt_nombre_bueno.Margin = new Padding(4);
            txt_nombre_bueno.Name = "txt_nombre_bueno";
            txt_nombre_bueno.Size = new Size(535, 31);
            txt_nombre_bueno.TabIndex = 7;
            // 
            // Entrada_producto
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(604, 485);
            Controls.Add(txt_nombre_bueno);
            Controls.Add(bt_atras);
            Controls.Add(bt_guardar);
            Controls.Add(text_linea);
            Controls.Add(text_cantidad);
            Controls.Add(text_precio);
            Controls.Add(bt_precioventa);
            Controls.Add(linea_producto);
            Controls.Add(bt_cantidad);
            Controls.Add(bt_nombre);
            Margin = new Padding(2);
            Name = "Entrada_producto";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Entrada_producto";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label bt_nombre;
        private Label bt_cantidad;
        private Label linea_producto;
        private Label bt_precioventa;
        private TextBox text_precio;
        private TextBox text_cantidad;
        private TextBox text_linea;
        private Button bt_guardar;
        private Button bt_atras;
        private TextBox txt_nombre_bueno;
    }
}