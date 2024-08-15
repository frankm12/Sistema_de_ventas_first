namespace Sistema_de_ventas_first
{
    partial class Acerca_de
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
            lbl_acerca_de = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btn_atras = new Button();
            SuspendLayout();
            // 
            // lbl_acerca_de
            // 
            lbl_acerca_de.AutoSize = true;
            lbl_acerca_de.Font = new Font("Times New Roman", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_acerca_de.Location = new Point(138, 40);
            lbl_acerca_de.Name = "lbl_acerca_de";
            lbl_acerca_de.Size = new Size(523, 39);
            lbl_acerca_de.TabIndex = 0;
            lbl_acerca_de.Text = "Este sistema de ventas fue creado por";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(23, 149);
            label1.Name = "label1";
            label1.Size = new Size(420, 22);
            label1.TabIndex = 1;
            label1.Text = "Franklyn D. Martinez (2021-3631) (Lider de grupo)";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(23, 195);
            label2.Name = "label2";
            label2.Size = new Size(446, 22);
            label2.TabIndex = 2;
            label2.Text = "John Manuel Guerrero Vilorio(2023-0670) (Integrante)";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(23, 242);
            label3.Name = "label3";
            label3.Size = new Size(368, 22);
            label3.TabIndex = 3;
            label3.Text = "Alejandro Capellan (2023-0669) (Integrante)";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(336, 404);
            label4.Name = "label4";
            label4.Size = new Size(133, 22);
            label4.TabIndex = 4;
            label4.Text = "VERSION 3.22";
            // 
            // btn_atras
            // 
            btn_atras.Location = new Point(694, 409);
            btn_atras.Name = "btn_atras";
            btn_atras.Size = new Size(94, 29);
            btn_atras.TabIndex = 5;
            btn_atras.Text = "Atras";
            btn_atras.UseVisualStyleBackColor = true;
            btn_atras.Click += btn_atras_Click;
            // 
            // Acerca_de
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_atras);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lbl_acerca_de);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Acerca_de";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Acerca_de";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_acerca_de;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btn_atras;
    }
}