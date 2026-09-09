namespace AguaPorMetros
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
            btnCalcular = new Button();
            btnSalir = new Button();
            lblMetros = new Label();
            lblAgua = new Label();
            txtMetros = new TextBox();
            txtAgua = new TextBox();
            SuspendLayout();
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(34, 309);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(141, 59);
            btnCalcular.TabIndex = 0;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(225, 309);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(141, 59);
            btnSalir.TabIndex = 1;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // lblMetros
            // 
            lblMetros.AutoSize = true;
            lblMetros.Location = new Point(46, 103);
            lblMetros.Name = "lblMetros";
            lblMetros.Size = new Size(58, 20);
            lblMetros.TabIndex = 2;
            lblMetros.Text = "Metros:";
            // 
            // lblAgua
            // 
            lblAgua.AutoSize = true;
            lblAgua.Location = new Point(34, 185);
            lblAgua.Name = "lblAgua";
            lblAgua.Size = new Size(110, 20);
            lblAgua.TabIndex = 3;
            lblAgua.Text = "Agua Utilizada:";
            // 
            // txtMetros
            // 
            txtMetros.Location = new Point(143, 96);
            txtMetros.Name = "txtMetros";
            txtMetros.Size = new Size(246, 27);
            txtMetros.TabIndex = 4;
            // 
            // txtAgua
            // 
            txtAgua.Location = new Point(150, 182);
            txtAgua.Name = "txtAgua";
            txtAgua.Size = new Size(246, 27);
            txtAgua.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(524, 450);
            Controls.Add(txtAgua);
            Controls.Add(txtMetros);
            Controls.Add(lblAgua);
            Controls.Add(lblMetros);
            Controls.Add(btnSalir);
            Controls.Add(btnCalcular);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCalcular;
        private Button btnSalir;
        private Label lblMetros;
        private Label lblAgua;
        private TextBox txtMetros;
        private TextBox txtAgua;
    }
}
