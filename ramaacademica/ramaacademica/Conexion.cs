using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ramaacademica
{
    public class Conexion
    {
        // Definir miembros, atributos y objetos de ADO.NET
        public SqlConnection objConexion = new SqlConnection();
        public SqlCommand objComando = new SqlCommand();
        public SqlDataAdapter objDataAdapter = new SqlDataAdapter();
        DataSet objDs = new DataSet();

        // Constructor e inicializador de los miembros de la clase
        public Conexion()
        {
            // Apunta al archivo .mdf configurado
            String cadenaConexion = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\db_academica.mdf;Integrated Security=True";

            objConexion.ConnectionString = cadenaConexion;

            // Verificamos que la conexión esté abierta
            if (objConexion.State == ConnectionState.Closed)
            {
                objConexion.Open();
            }
        }

        public DataSet obtenerDatos()
        {
            objDs.Clear(); // Limpiar el dataset

            objComando.Connection = objConexion;
            objDataAdapter.SelectCommand = objComando;

            // 1. Cargar Alumnos
            objComando.CommandText = "SELECT * FROM alumnos";
            objDataAdapter.Fill(objDs, "alumnos");

            // 2. Cargar Materias
            objComando.CommandText = "SELECT * FROM Materias";
            objDataAdapter.Fill(objDs, "materias");

            // 3. Cargar Periodos
            objComando.CommandText = "SELECT * FROM periodos";
            objDataAdapter.Fill(objDs, "periodos");

            // 4. Cargar Notas y Detalle de Notas
            objComando.CommandText = @"SELECT dn.idDnota, a.Nombre AS Alumno, m.nombre AS Materia, 
                                              p.nombre AS Periodo, dn.nota 
                                       FROM dnotas dn
                                       INNER JOIN notas n ON dn.idNota = n.idNota
                                       INNER JOIN alumnos a ON n.idAlumno = a.IdAlumno
                                       INNER JOIN Materias m ON n.idMateria = m.IdMateria
                                       INNER JOIN periodos p ON dn.idPeriodo = p.idPeriodo";
            objDataAdapter.Fill(objDs, "notas");

            return objDs;
        }

        public string administrarDatosAlumnos(String[] datos, String accion)
        {
            String sql = "";
            if (accion == "nuevo")
            {
                sql = "INSERT INTO alumnos (codigo, nombre, direccion, telefono, email) VALUES ('" + datos[1] + "', '" + datos[2] + "', '" + datos[3] + "', '" + datos[4] + "', '" + datos[5] + "')";
            }
            else if (accion == "modificar")
            {
                sql = "UPDATE alumnos SET codigo='" + datos[1] + "', nombre='" + datos[2] + "', direccion='" + datos[3] + "', telefono='" + datos[4] + "', email='" + datos[5] + "' WHERE IdAlumno=" + datos[0];
            }
            else if (accion == "eliminar")
            {
                sql = "DELETE FROM alumnos WHERE IdAlumno=" + datos[0];
            }
            return ejecutarSQL(sql);
        }

        public string administrarDatosMaterias(String[] datos, String accion)
        {
            String sql = "";
            if (accion == "nuevo")
            {
                sql = "INSERT INTO Materias (codigo, nombre, uv) VALUES ('" + datos[1] + "', '" + datos[2] + "', " + datos[3] + ")";
            }
            else if (accion == "modificar")
            {
                sql = "UPDATE Materias SET codigo='" + datos[1] + "', nombre='" + datos[2] + "', uv=" + datos[3] + " WHERE IdMateria=" + datos[0];
            }
            else if (accion == "eliminar")
            {
                sql = "DELETE FROM Materias WHERE IdMateria=" + datos[0];
            }
            return ejecutarSQL(sql);
        }

        public string administrarDatosPeriodos(String[] datos, String accion)
        {
            String sql = "";
            if (accion == "nuevo")
            {
                sql = "INSERT INTO periodos (codigo, nombre) VALUES ('" + datos[1] + "', '" + datos[2] + "')";
            }
            else if (accion == "modificar")
            {
                sql = "UPDATE periodos SET codigo='" + datos[1] + "', nombre='" + datos[2] + "' WHERE idPeriodo=" + datos[0];
            }
            else if (accion == "eliminar")
            {
                sql = "DELETE FROM periodos WHERE idPeriodo=" + datos[0];
            }
            return ejecutarSQL(sql);
        }

        public string administrarDatosNotas(String[] datos, String accion)
        {
            String sql = "";
            if (accion == "nuevo")
            {
                // datos[0] = idAlumno, datos[1] = idMateria
                sql = "INSERT INTO notas (idAlumno, idMateria) VALUES (" + datos[0] + ", " + datos[1] + ")";
            }
            return ejecutarSQL(sql);
        }

        public String ejecutarSQL(String sql)
        {
            try
            {
                objComando.Connection = objConexion;
                objComando.CommandText = sql;
                return objComando.ExecuteNonQuery().ToString();
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}