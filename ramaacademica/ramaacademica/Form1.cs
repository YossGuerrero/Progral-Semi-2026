using System;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ramaacademica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Conexion objConexion = new Conexion();
        DataSet ds = new DataSet();
        DataTable dt = new DataTable();
        String accion = "nuevo";
        int posicion = 0;

        private void obtenerDatos()
        {
            ds.Clear();
            ds = objConexion.obtenerDatos();
            dt = ds.Tables["Alumnos"];
            dt.PrimaryKey = new DataColumn[] { dt.Columns["idAlumno"] };

            mostrarDatos();
        }

        private void mostrarDatos()
        {
            if (dt.Rows.Count > 0)
            {
                txtCodigoAlumno.Text = dt.Rows[posicion]["codigo"].ToString();
                txtNombreAlumno.Text = dt.Rows[posicion]["nombre"].ToString();
                txtDireccionAlumno.Text = dt.Rows[posicion]["direccion"].ToString();
                txtTelefonoAlumno.Text = dt.Rows[posicion]["telefono"].ToString();
                txtEmailAlumno.Text = dt.Rows[posicion]["email"].ToString();

                lblRegistrarAlumno.Text = (posicion + 1) + " de " + dt.Rows.Count;

            }
        }

        private void activarDesactivarCtrls(Boolean estado)
        {
            grbDatos.Enabled = estado;
            grbNavegacion.Enabled = !estado;
        }

        private void btnAgregarAlumno_Click(object sender, EventArgs e)
        {
            if (btnAgregarAlumno.Text == "Agregar")
            {
                btnAgregarAlumno.Text = "Guardar";
                btnModificarAlumno.Text = "Cancelar";

                activarDesactivarCtrls(true);

            }
            else
            {
                //Guardar
                activarDesactivarCtrls(false);
                btnAgregarAlumno.Text = "Agregar";
                btnModificarAlumno.Text = "Modificar";
            }
        }

        private void btnModificarAlumno_Click(object sender, EventArgs e)
        {
            if (btnModificarAlumno.Text == "Modificar")
            {
                btnAgregarAlumno.Text = "Guardar";
                btnModificarAlumno.Text = "Cancelar";
                activarDesactivarCtrls(true);
            }
            else
            {
                //Guardar
                activarDesactivarCtrls(false);
                btnAgregarAlumno.Text = "Agregar";
                btnModificarAlumno.Text = "Modificar";
            }
        }

        private void btnLooo_Loand(object sender, EventArgs e)
        {
            mostrarDatos();
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
         {
            posicion++;
            mostrarDatos();
         }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            posicion--;
            mostrarDatos();
        }

        private void btnUltimoAlumno_Click(object sender, EventArgs e)
        {
            posicion = dt.Rows.Count - 1;
            mostrarDatos();
        }

        private void btnPrimerAlumno_Click(object sender, EventArgs e)
        {
            posicion = 0;
            mostrarDatos();
        }
    }   

   
}

