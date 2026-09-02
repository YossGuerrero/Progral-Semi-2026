namespace Impuesto_ganancia
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
            label1 = new Label();
            lblGanancias = new Label();
            txtEmpresa = new TextBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            txtGanancias = new TextBox();
            dgvDatos = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            btnCalcular = new Button();
            lblEmpresa = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvDatos).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(100, 23);
            label1.TabIndex = 6;
            // 
            // lblGanancias
            // 
            lblGanancias.AutoSize = true;
            lblGanancias.Location = new Point(356, 52);
            lblGanancias.Name = "lblGanancias";
            lblGanancias.Size = new Size(76, 20);
            lblGanancias.TabIndex = 1;
            lblGanancias.Text = "Ganancias";
            // 
            // txtEmpresa
            // 
            txtEmpresa.Location = new Point(147, 49);
            txtEmpresa.Name = "txtEmpresa";
            txtEmpresa.Size = new Size(125, 27);
            txtEmpresa.TabIndex = 2;
            // 
            // txtGanancias
            // 
            txtGanancias.Location = new Point(442, 49);
            txtGanancias.Name = "txtGanancias";
            txtGanancias.Size = new Size(125, 27);
            txtGanancias.TabIndex = 3;
            // 
            // dgvDatos
            // 
            dgvDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDatos.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4 });
            dgvDatos.Location = new Point(61, 106);
            dgvDatos.Name = "dgvDatos";
            dgvDatos.RowHeadersWidth = 51;
            dgvDatos.Size = new Size(554, 198);
            dgvDatos.TabIndex = 4;
            // 
            // Column1
            // 
            Column1.HeaderText = "Nombre de empresa";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 125;
            // 
            // Column2
            // 
            Column2.HeaderText = "Ganancias";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 125;
            // 
            // Column3
            // 
            Column3.HeaderText = "Impuestos";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 125;
            // 
            // Column4
            // 
            Column4.HeaderText = "Adicionales";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.Width = 125;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(263, 331);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(143, 67);
            btnCalcular.TabIndex = 5;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // lblEmpresa
            // 
            lblEmpresa.AutoSize = true;
            lblEmpresa.Location = new Point(81, 56);
            lblEmpresa.Name = "lblEmpresa";
            lblEmpresa.Size = new Size(66, 20);
            lblEmpresa.TabIndex = 7;
            lblEmpresa.Text = "Empresa";
            lblEmpresa.Click += label3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblEmpresa);
            Controls.Add(btnCalcular);
            Controls.Add(dgvDatos);
            Controls.Add(txtGanancias);
            Controls.Add(txtEmpresa);
            Controls.Add(lblGanancias);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvDatos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblGanancias;
        private TextBox txtEmpresa;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private TextBox txtGanancias;
        private DataGridView dgvDatos;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private Button btnCalcular;
        private Label lblEmpresa;
    }
}
