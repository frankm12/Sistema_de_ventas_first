namespace Sistema_de_ventas_first
{
    partial class Menu_princial
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
            label1 = new Label();
            btnentrada = new Button();
            btnsistema = new Button();
            btnconsulta = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 36F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(242, 24);
            label1.Name = "label1";
            label1.Size = new Size(315, 55);
            label1.TabIndex = 0;
            label1.Text = "Menu Principal";
            // 
            // btnentrada
            // 
            btnentrada.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnentrada.Location = new Point(107, 211);
            btnentrada.Name = "btnentrada";
            btnentrada.Size = new Size(601, 67);
            btnentrada.TabIndex = 3;
            btnentrada.Text = "Entrada";
            btnentrada.UseVisualStyleBackColor = true;
            // 
            // btnsistema
            // 
            btnsistema.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnsistema.Location = new Point(107, 309);
            btnsistema.Name = "btnsistema";
            btnsistema.Size = new Size(601, 66);
            btnsistema.TabIndex = 4;
            btnsistema.Text = "Sistema";
            btnsistema.UseVisualStyleBackColor = true;
            // 
            // btnconsulta
            // 
            btnconsulta.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnconsulta.Location = new Point(107, 109);
            btnconsulta.Name = "btnconsulta";
            btnconsulta.Size = new Size(601, 69);
            btnconsulta.TabIndex = 5;
            btnconsulta.Text = "Consulta";
            btnconsulta.UseVisualStyleBackColor = true;
            // 
            // Menu_princial
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnconsulta);
            Controls.Add(btnsistema);
            Controls.Add(btnentrada);
            Controls.Add(label1);
            Name = "Menu_princial";
            Text = "Menu_princial";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnentrada;
        private Button btnsistema;
        private Button btnconsulta;
    }
}