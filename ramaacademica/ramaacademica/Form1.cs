using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
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
        DataSet ds = new DataSet();
        DataTable dt = new DataTable();
        String accion = "nuevo";
        int posicion = 0;

        private void obtenerDatos()
        {
            ds.Clear();
            ds = objConexion.ibtenerDatos();
            dt = ds.Tables["Alumnos"];
            dt.PrimaryKey = new DataColumn[] { dt.Columns["idAlumno"] };

        }

        private void mostrarDatos()
        {
            if (dt.Rows.Count > 0)
            {
                txtCodigoAlumno.Text = dt.Rows[posicion]["codigo"].ToString();

            }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            (btnAgregarAlumno.Text = "Agregar");
            btnAgregarAlumno.Text = "Guardar";
            btnModificarAlumno.Text = "Cancelar";

        }else{//Guardar
           btnModificarAlumno.Text = "Agregar

         }
    }
}
