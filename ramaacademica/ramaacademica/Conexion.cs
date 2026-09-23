using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data; //Esta libreria es para trabajar con bases de datos
using System.Data.SqlClient; //Esta libreria permite usar SQL Server


namespace ramaacademica
{
    internal class Conexion {
        //Definir los mienbros, atributos y metodos de la clase
        public SqlConnection objConexion = new SqlConnection(); //conectarse a la base de datos
        public SqlCommand objComando = new SqlCommand(); //Ejecutar consultas sql (insert, update, delete, select) en la BD
        public SqlDataAdapter objDataAdapter = new SqlDataAdapter(); //Un puente entre la DB y la aplicación
        DataSet objDs = new DataSet(); //Representa una copia en memoria de la arquitectura de la DB


        public Conexion () { //Constructor e inialización de la clase
            String cadenaCoenxion = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\db_academica.mdf;Integrated Security=True";
            objConexion.ConnectionString = cadenaCoenxion;
            objConexion.Open(); //Abrir la DB
        }
         public DataSet obtenerDatos()
        {
            objDs .Clear();//Limpiar el dato
            objComando.Connection = objConexion;

            objDataAdapter.SelectCommand = objComando;
            objComando.CommandText = "SELECT * FROM alumnos";
            objDataAdapter.Fill(objDs, "alumnos");

            return objDs;
         }
    }
}
