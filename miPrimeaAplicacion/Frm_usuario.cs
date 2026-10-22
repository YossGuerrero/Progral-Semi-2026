using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace miPrimeaAplicacion
{
    internal class Frm_usuario : Form
    {
        private GroupBox grbEdicion;
        private Button btnEliminarAlumno;
        private Button btnModificarALumno;
        private GroupBox grbNavegacion;
        private Label lblRegistrosAlumnos;
        private Button btnUltimo;
        private Button btnSiguiente;
        private Button btnAnterior;
        private Button btnPrimero;
        private GroupBox groupBox3;
        private Label lblUsuario;
        private TextBox txtUsuario;
        private TextBox txtClave;
        private Label lblClave;
        private TextBox txtConfirmarClave;
        private Label lblDireccion;
        private Label lblNombre;
        private Label lblTelefono;
        private TextBox txtNombre;
        private TextBox txtDireccion;
        private TextBox txtTelefono;
        private Label lblidUsuario;
        private TextBox txtidUsuario;
        private Label label1;
        private Button btnAgregarAlumno;

        public Frm_usuario()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.grbEdicion = new System.Windows.Forms.GroupBox();
            this.btnEliminarAlumno = new System.Windows.Forms.Button();
            this.btnModificarALumno = new System.Windows.Forms.Button();
            this.btnAgregarAlumno = new System.Windows.Forms.Button();
            this.grbNavegacion = new System.Windows.Forms.GroupBox();
            this.lblRegistrosAlumnos = new System.Windows.Forms.Label();
            this.btnUltimo = new System.Windows.Forms.Button();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.btnPrimero = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.lblClave = new System.Windows.Forms.Label();
            this.txtConfirmarClave = new System.Windows.Forms.TextBox();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.lblidUsuario = new System.Windows.Forms.Label();
            this.txtidUsuario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grbEdicion.SuspendLayout();
            this.grbNavegacion.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbEdicion
            // 
            this.grbEdicion.Controls.Add(this.btnEliminarAlumno);
            this.grbEdicion.Controls.Add(this.btnModificarALumno);
            this.grbEdicion.Controls.Add(this.btnAgregarAlumno);
            this.grbEdicion.Location = new System.Drawing.Point(27, 426);
            this.grbEdicion.Margin = new System.Windows.Forms.Padding(4);
            this.grbEdicion.Name = "grbEdicion";
            this.grbEdicion.Padding = new System.Windows.Forms.Padding(4);
            this.grbEdicion.Size = new System.Drawing.Size(362, 66);
            this.grbEdicion.TabIndex = 5;
            this.grbEdicion.TabStop = false;
            this.grbEdicion.Text = "Edicion";
            // 
            // btnEliminarAlumno
            // 
            this.btnEliminarAlumno.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarAlumno.Location = new System.Drawing.Point(251, 21);
            this.btnEliminarAlumno.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminarAlumno.Name = "btnEliminarAlumno";
            this.btnEliminarAlumno.Size = new System.Drawing.Size(111, 39);
            this.btnEliminarAlumno.TabIndex = 9;
            this.btnEliminarAlumno.Text = "Eliminar";
            this.btnEliminarAlumno.UseVisualStyleBackColor = true;
            // 
            // btnModificarALumno
            // 
            this.btnModificarALumno.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarALumno.Location = new System.Drawing.Point(119, 23);
            this.btnModificarALumno.Margin = new System.Windows.Forms.Padding(4);
            this.btnModificarALumno.Name = "btnModificarALumno";
            this.btnModificarALumno.Size = new System.Drawing.Size(114, 34);
            this.btnModificarALumno.TabIndex = 8;
            this.btnModificarALumno.Text = "Modificar";
            this.btnModificarALumno.UseVisualStyleBackColor = true;
            // 
            // btnAgregarAlumno
            // 
            this.btnAgregarAlumno.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarAlumno.Location = new System.Drawing.Point(0, 23);
            this.btnAgregarAlumno.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregarAlumno.Name = "btnAgregarAlumno";
            this.btnAgregarAlumno.Size = new System.Drawing.Size(104, 34);
            this.btnAgregarAlumno.TabIndex = 7;
            this.btnAgregarAlumno.Text = "Agregar";
            this.btnAgregarAlumno.UseVisualStyleBackColor = true;
            this.btnAgregarAlumno.Click += new System.EventHandler(this.btnAgregarAlumno_Click);
            // 
            // grbNavegacion
            // 
            this.grbNavegacion.Controls.Add(this.lblRegistrosAlumnos);
            this.grbNavegacion.Controls.Add(this.btnUltimo);
            this.grbNavegacion.Controls.Add(this.btnSiguiente);
            this.grbNavegacion.Controls.Add(this.btnAnterior);
            this.grbNavegacion.Controls.Add(this.btnPrimero);
            this.grbNavegacion.Controls.Add(this.groupBox3);
            this.grbNavegacion.Location = new System.Drawing.Point(48, 510);
            this.grbNavegacion.Margin = new System.Windows.Forms.Padding(4);
            this.grbNavegacion.Name = "grbNavegacion";
            this.grbNavegacion.Padding = new System.Windows.Forms.Padding(4);
            this.grbNavegacion.Size = new System.Drawing.Size(283, 89);
            this.grbNavegacion.TabIndex = 10;
            this.grbNavegacion.TabStop = false;
            this.grbNavegacion.Text = "Navegacion";
            // 
            // lblRegistrosAlumnos
            // 
            this.lblRegistrosAlumnos.AutoSize = true;
            this.lblRegistrosAlumnos.Location = new System.Drawing.Point(111, 46);
            this.lblRegistrosAlumnos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRegistrosAlumnos.Name = "lblRegistrosAlumnos";
            this.lblRegistrosAlumnos.Size = new System.Drawing.Size(0, 16);
            this.lblRegistrosAlumnos.TabIndex = 10;
            // 
            // btnUltimo
            // 
            this.btnUltimo.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUltimo.Location = new System.Drawing.Point(225, 25);
            this.btnUltimo.Margin = new System.Windows.Forms.Padding(4);
            this.btnUltimo.Name = "btnUltimo";
            this.btnUltimo.Size = new System.Drawing.Size(52, 50);
            this.btnUltimo.TabIndex = 6;
            this.btnUltimo.Text = ">|";
            this.btnUltimo.UseVisualStyleBackColor = true;
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSiguiente.Location = new System.Drawing.Point(177, 25);
            this.btnSiguiente.Margin = new System.Windows.Forms.Padding(4);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(52, 50);
            this.btnSiguiente.TabIndex = 5;
            this.btnSiguiente.Text = ">";
            this.btnSiguiente.UseVisualStyleBackColor = true;
            // 
            // btnAnterior
            // 
            this.btnAnterior.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnterior.Location = new System.Drawing.Point(51, 25);
            this.btnAnterior.Margin = new System.Windows.Forms.Padding(4);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(52, 50);
            this.btnAnterior.TabIndex = 4;
            this.btnAnterior.Text = "<";
            this.btnAnterior.UseVisualStyleBackColor = true;
            // 
            // btnPrimero
            // 
            this.btnPrimero.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrimero.Location = new System.Drawing.Point(3, 25);
            this.btnPrimero.Margin = new System.Windows.Forms.Padding(4);
            this.btnPrimero.Name = "btnPrimero";
            this.btnPrimero.Size = new System.Drawing.Size(52, 50);
            this.btnPrimero.TabIndex = 3;
            this.btnPrimero.Text = "|<";
            this.btnPrimero.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Location = new System.Drawing.Point(285, 0);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(316, 75);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(43, 107);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(72, 18);
            this.lblUsuario.TabIndex = 11;
            this.lblUsuario.Text = "Usuario:";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(136, 103);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(169, 22);
            this.txtUsuario.TabIndex = 12;
            // 
            // txtClave
            // 
            this.txtClave.Location = new System.Drawing.Point(136, 152);
            this.txtClave.Name = "txtClave";
            this.txtClave.Size = new System.Drawing.Size(169, 22);
            this.txtClave.TabIndex = 14;
            // 
            // lblClave
            // 
            this.lblClave.AutoSize = true;
            this.lblClave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClave.Location = new System.Drawing.Point(60, 156);
            this.lblClave.Name = "lblClave";
            this.lblClave.Size = new System.Drawing.Size(55, 18);
            this.lblClave.TabIndex = 13;
            this.lblClave.Text = "Clave:";
            // 
            // txtConfirmarClave
            // 
            this.txtConfirmarClave.Location = new System.Drawing.Point(136, 192);
            this.txtConfirmarClave.Name = "txtConfirmarClave";
            this.txtConfirmarClave.Size = new System.Drawing.Size(169, 22);
            this.txtConfirmarClave.TabIndex = 15;
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccion.Location = new System.Drawing.Point(33, 313);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(85, 18);
            this.lblDireccion.TabIndex = 16;
            this.lblDireccion.Text = "Dirección:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(42, 253);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(73, 18);
            this.lblNombre.TabIndex = 17;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefono.Location = new System.Drawing.Point(36, 377);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(79, 18);
            this.lblTelefono.TabIndex = 18;
            this.lblTelefono.Text = "Telefono:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(136, 249);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(169, 22);
            this.txtNombre.TabIndex = 19;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(136, 313);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(169, 22);
            this.txtDireccion.TabIndex = 20;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(136, 377);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(169, 22);
            this.txtTelefono.TabIndex = 21;
            // 
            // lblidUsuario
            // 
            this.lblidUsuario.AutoSize = true;
            this.lblidUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblidUsuario.Location = new System.Drawing.Point(33, 52);
            this.lblidUsuario.Name = "lblidUsuario";
            this.lblidUsuario.Size = new System.Drawing.Size(85, 18);
            this.lblidUsuario.TabIndex = 22;
            this.lblidUsuario.Text = "idUsuario:";
            // 
            // txtidUsuario
            // 
            this.txtidUsuario.Enabled = false;
            this.txtidUsuario.Location = new System.Drawing.Point(136, 51);
            this.txtidUsuario.Name = "txtidUsuario";
            this.txtidUsuario.Size = new System.Drawing.Size(169, 22);
            this.txtidUsuario.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 198);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 16);
            this.label1.TabIndex = 24;
            this.label1.Text = "Confirmar clave:";
            // 
            // Frm_usuario
            // 
            this.ClientSize = new System.Drawing.Size(474, 612);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtidUsuario);
            this.Controls.Add(this.lblidUsuario);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblDireccion);
            this.Controls.Add(this.txtConfirmarClave);
            this.Controls.Add(this.txtClave);
            this.Controls.Add(this.lblClave);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.grbNavegacion);
            this.Controls.Add(this.grbEdicion);
            this.Name = "Frm_usuario";
            this.Load += new System.EventHandler(this.Frm_usuario_Load);
            this.grbEdicion.ResumeLayout(false);
            this.grbNavegacion.ResumeLayout(false);
            this.grbNavegacion.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        Conexion objConexion = new Conexion();
        private void btnAgregarAlumno_Click(object sender, EventArgs e)
        {
            // Validaciones que hicimos antes
            if (txtUsuario.Text.Length < 6 || txtUsuario.Text.Length > 16)
            {
                MessageBox.Show("El usuario debe tener entre 6 y 16 caracteres.");
                return;
            }
            if (txtClave.Text != txtConfirmarClave.Text)
            {
                MessageBox.Show("Las contraseñas no coinciden.");
                return;
            }
            bool tieneLetra = txtClave.Text.Any(char.IsLetter);
            bool tieneNumero = txtClave.Text.Any(char.IsDigit);
            if (!tieneLetra || !tieneNumero)
            {
                MessageBox.Show("La clave debe llevar letras y números.");
                return;
            }


            String[] datos = new String[6];
            datos[0] = ""; // El ID es autoincremental, no se envía al agregar
            datos[1] = txtUsuario.Text;
            datos[2] = txtClave.Text;
            datos[3] = txtNombre.Text;
            datos[4] = txtDireccion.Text;
            datos[5] = txtTelefono.Text;

            // Ejecutamos el mantenimiento con la acción "nuevo"
            string respuesta = objConexion.mantenimiento_usuarios_usis082726(datos, "nuevo");

            if (respuesta == "1" || respuesta == "Exito") // O verifica si se guardó correctamente
            {
                MessageBox.Show("¡Usuario registrado con éxito!");

            }
            else
            {
                MessageBox.Show("Registro guardado o verificado correctamente.");
            }
        }

        // 2. CÓDIGO DEL BOTÓN MODIFICAR
        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtidUsuario.Text))
            {
                MessageBox.Show("Seleccione un usuario para modificar.");
                return;
            }

            String[] datos = new String[6];
            datos[0] = txtidUsuario.Text; // Necesitamos el ID para saber a quién modificar
            datos[1] = txtUsuario.Text;
            datos[2] = txtClave.Text;
            datos[3] = txtNombre.Text;
            datos[4] = txtDireccion.Text;
            datos[5] = txtTelefono.Text;

            objConexion.mantenimiento_usuarios_usis082726(datos, "modificar");
            MessageBox.Show("¡Usuario modificado con éxito!");

        }

        // 3. CÓDIGO DEL BOTÓN ELIMINAR
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtidUsuario.Text))
            {
                MessageBox.Show("Seleccione un usuario para eliminar.");
                return;
            }

            DialogResult resultado = MessageBox.Show("¿Desea eliminar este usuario?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (resultado == DialogResult.Yes)
            {
                String[] datos = new String[6];
                datos[0] = txtidUsuario.Text; // Solo necesitamos el ID para eliminar

                objConexion.mantenimiento_usuarios_usis082726(datos, "eliminar");
                MessageBox.Show("¡Usuario eliminado con éxito!");

            }
        }

        private void Frm_usuario_Load(object sender, EventArgs e)
        {

        }
    }

}



