namespace SistemaEstadistico
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
            lblOpciones = new Label();
            label2 = new Label();
            lblTiempoCelular = new Label();
            lblTiempoUbg = new Label();
            lblNombre = new Label();
            lblEdad = new Label();
            dgvDatos = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            btnAgregar = new Button();
            btnCalcular = new Button();
            btnSalir = new Button();
            cmbOpciones = new ComboBox();
            txtEdad = new TextBox();
            txtTiempoUgb = new TextBox();
            txtEstudiantes = new TextBox();
            txtTiempoCelular = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvDatos).BeginInit();
            SuspendLayout();
            // 
            // lblOpciones
            // 
            lblOpciones.AutoSize = true;
            lblOpciones.Location = new Point(192, 98);
            lblOpciones.Name = "lblOpciones";
            lblOpciones.Size = new Size(71, 20);
            lblOpciones.TabIndex = 0;
            lblOpciones.Text = "Opciones";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(361, 329);
            label2.Name = "label2";
            label2.Size = new Size(0, 20);
            label2.TabIndex = 1;
            // 
            // lblTiempoCelular
            // 
            lblTiempoCelular.AutoSize = true;
            lblTiempoCelular.Location = new Point(584, 264);
            lblTiempoCelular.Name = "lblTiempoCelular";
            lblTiempoCelular.Size = new Size(147, 20);
            lblTiempoCelular.TabIndex = 2;
            lblTiempoCelular.Text = "Tiempo en el celular:";
            // 
            // lblTiempoUbg
            // 
            lblTiempoUbg.AutoSize = true;
            lblTiempoUbg.Location = new Point(81, 255);
            lblTiempoUbg.Name = "lblTiempoUbg";
            lblTiempoUbg.Size = new Size(170, 20);
            lblTiempoUbg.TabIndex = 3;
            lblTiempoUbg.Text = "Tiempo en llegar a UGB:";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(81, 174);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(161, 20);
            lblNombre.TabIndex = 4;
            lblNombre.Text = "Nombre de Estudiante:";
            // 
            // lblEdad
            // 
            lblEdad.AutoSize = true;
            lblEdad.Location = new Point(584, 174);
            lblEdad.Name = "lblEdad";
            lblEdad.Size = new Size(46, 20);
            lblEdad.TabIndex = 5;
            lblEdad.Text = "Edad:";
            // 
            // dgvDatos
            // 
            dgvDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDatos.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4 });
            dgvDatos.Location = new Point(81, 329);
            dgvDatos.Name = "dgvDatos";
            dgvDatos.RowHeadersWidth = 51;
            dgvDatos.Size = new Size(553, 277);
            dgvDatos.TabIndex = 6;
            // 
            // Column1
            // 
            Column1.HeaderText = "Nombre de estudiante";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Width = 125;
            // 
            // Column2
            // 
            Column2.HeaderText = "Edad";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Width = 125;
            // 
            // Column3
            // 
            Column3.HeaderText = "Tiempo en llegar a UGB";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            Column3.Width = 125;
            // 
            // Column4
            // 
            Column4.HeaderText = "Tiempo de uso del celular";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            Column4.Width = 125;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(708, 442);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(127, 50);
            btnAgregar.TabIndex = 7;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(708, 352);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(127, 50);
            btnCalcular.TabIndex = 8;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(708, 532);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(127, 50);
            btnSalir.TabIndex = 9;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // cmbOpciones
            // 
            cmbOpciones.FormattingEnabled = true;
            cmbOpciones.Location = new Point(269, 95);
            cmbOpciones.Name = "cmbOpciones";
            cmbOpciones.Size = new Size(261, 28);
            cmbOpciones.TabIndex = 10;
            // 
            // txtEdad
            // 
            txtEdad.Location = new Point(641, 174);
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(250, 27);
            txtEdad.TabIndex = 11;
            // 
            // txtTiempoUgb
            // 
            txtTiempoUgb.Location = new Point(269, 248);
            txtTiempoUgb.Name = "txtTiempoUgb";
            txtTiempoUgb.Size = new Size(250, 27);
            txtTiempoUgb.TabIndex = 12;
            // 
            // txtEstudiantes
            // 
            txtEstudiantes.Location = new Point(248, 174);
            txtEstudiantes.Name = "txtEstudiantes";
            txtEstudiantes.Size = new Size(250, 27);
            txtEstudiantes.TabIndex = 13;
            // 
            // txtTiempoCelular
            // 
            txtTiempoCelular.Location = new Point(737, 264);
            txtTiempoCelular.Name = "txtTiempoCelular";
            txtTiempoCelular.Size = new Size(250, 27);
            txtTiempoCelular.TabIndex = 14;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1040, 745);
            Controls.Add(txtTiempoCelular);
            Controls.Add(txtEstudiantes);
            Controls.Add(txtTiempoUgb);
            Controls.Add(txtEdad);
            Controls.Add(cmbOpciones);
            Controls.Add(btnSalir);
            Controls.Add(btnCalcular);
            Controls.Add(btnAgregar);
            Controls.Add(dgvDatos);
            Controls.Add(lblEdad);
            Controls.Add(lblNombre);
            Controls.Add(lblTiempoUbg);
            Controls.Add(lblTiempoCelular);
            Controls.Add(label2);
            Controls.Add(lblOpciones);
            Name = "Form1";
            Text = "Estadisticas";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDatos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblOpciones;
        private Label label2;
        private Label lblTiempoCelular;
        private Label lblTiempoUbg;
        private Label lblNombre;
        private Label lblEdad;
        private DataGridView dgvDatos;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private Button btnAgregar;
        private Button btnCalcular;
        private Button btnSalir;
        private ComboBox cmbOpciones;
        private TextBox txtEdad;
        private TextBox txtTiempoUgb;
        private TextBox txtEstudiantes;
        private TextBox txtTiempoCelular;
    }
}
