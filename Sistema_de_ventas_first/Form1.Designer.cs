﻿namespace Sistema_de_ventas_first
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btingresar = new Button();
            label1 = new Label();
            btcontraseña = new Label();
            textnombre = new TextBox();
            textcontraseña = new TextBox();
            SuspendLayout();
            // 
            // btingresar
            // 
            btingresar.Location = new Point(159, 541);
            btingresar.Name = "btingresar";
            btingresar.Size = new Size(166, 58);
            btingresar.TabIndex = 0;
            btingresar.Text = "INGRESAR";
            btingresar.UseVisualStyleBackColor = true;
            btingresar.Click += btingresar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(75, 220);
            label1.Name = "label1";
            label1.Size = new Size(88, 25);
            label1.TabIndex = 1;
            label1.Text = "USUARIO";
            // 
            // btcontraseña
            // 
            btcontraseña.AutoSize = true;
            btcontraseña.Location = new Point(75, 315);
            btcontraseña.Name = "btcontraseña";
            btcontraseña.Size = new Size(126, 25);
            btcontraseña.TabIndex = 2;
            btcontraseña.Text = "CONTRASEÑA";
            // 
            // textnombre
            // 
            textnombre.Location = new Point(169, 214);
            textnombre.Name = "textnombre";
            textnombre.Size = new Size(234, 31);
            textnombre.TabIndex = 3;
            textnombre.TextChanged += textBox1_TextChanged;
            // 
            // textcontraseña
            // 
            textcontraseña.Location = new Point(207, 315);
            textcontraseña.Name = "textcontraseña";
            textcontraseña.Size = new Size(196, 31);
            textcontraseña.TabIndex = 4;
            textcontraseña.TextChanged += textBox2_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(492, 670);
            Controls.Add(textcontraseña);
            Controls.Add(textnombre);
            Controls.Add(btcontraseña);
            Controls.Add(label1);
            Controls.Add(btingresar);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btingresar;
        private Label label1;
        private Label btcontraseña;
        private TextBox textnombre;
        private TextBox textcontraseña;
    }
}
