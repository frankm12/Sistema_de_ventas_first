namespace Sistema_de_ventas_first
{
    partial class Consulta_Ordenes
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
            dataGridView1 = new DataGridView();
            lbl_Ordenes = new Label();
            btn_editaro = new Button();
            btn_eliminaro = new Button();
            btn_cargaro = new Button();
            btn_atraso = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(14, 45);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1079, 412);
            dataGridView1.TabIndex = 0;
            // 
            // lbl_Ordenes
            // 
            lbl_Ordenes.AutoSize = true;
            lbl_Ordenes.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Ordenes.Location = new Point(14, 8);
            lbl_Ordenes.Name = "lbl_Ordenes";
            lbl_Ordenes.Size = new Size(109, 32);
            lbl_Ordenes.TabIndex = 1;
            lbl_Ordenes.Text = "Ordenes";
            lbl_Ordenes.Click += lbl_Ordenes_Click;
            // 
            // btn_editaro
            // 
            btn_editaro.Location = new Point(824, 465);
            btn_editaro.Margin = new Padding(3, 4, 3, 4);
            btn_editaro.Name = "btn_editaro";
            btn_editaro.Size = new Size(86, 35);
            btn_editaro.TabIndex = 4;
            btn_editaro.Text = "Editar";
            btn_editaro.UseVisualStyleBackColor = true;
            btn_editaro.Click += btn_editaro_Click;
            // 
            // btn_eliminaro
            // 
            btn_eliminaro.Location = new Point(732, 465);
            btn_eliminaro.Margin = new Padding(3, 4, 3, 4);
            btn_eliminaro.Name = "btn_eliminaro";
            btn_eliminaro.Size = new Size(86, 35);
            btn_eliminaro.TabIndex = 5;
            btn_eliminaro.Text = "Eliminar";
            btn_eliminaro.UseVisualStyleBackColor = true;
            btn_eliminaro.Click += btn_eliminaro_Click;
            // 
            // btn_cargaro
            // 
            btn_cargaro.Location = new Point(916, 465);
            btn_cargaro.Margin = new Padding(3, 4, 3, 4);
            btn_cargaro.Name = "btn_cargaro";
            btn_cargaro.Size = new Size(86, 35);
            btn_cargaro.TabIndex = 6;
            btn_cargaro.Text = "Cargar";
            btn_cargaro.UseVisualStyleBackColor = true;
            btn_cargaro.Click += btn_cargaro_Click;
            // 
            // btn_atraso
            // 
            btn_atraso.Location = new Point(1008, 465);
            btn_atraso.Margin = new Padding(3, 4, 3, 4);
            btn_atraso.Name = "btn_atraso";
            btn_atraso.Size = new Size(86, 35);
            btn_atraso.TabIndex = 7;
            btn_atraso.Text = "Atras";
            btn_atraso.UseVisualStyleBackColor = true;
            btn_atraso.Click += btn_atraso_Click;
            // 
            // Consulta_Ordenes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1105, 513);
            Controls.Add(btn_atraso);
            Controls.Add(btn_cargaro);
            Controls.Add(btn_eliminaro);
            Controls.Add(btn_editaro);
            Controls.Add(lbl_Ordenes);
            Controls.Add(dataGridView1);
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "Consulta_Ordenes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Consulta_Ordenes";
            Load += Consulta_Ordenes_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label lbl_Ordenes;
        private Button btn_editaro;
        private Button btn_eliminaro;
        private Button btn_cargaro;
        private Button btn_atraso;
    }
}