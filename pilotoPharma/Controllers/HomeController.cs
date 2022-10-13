using Microsoft.AspNetCore.Mvc;
using Npgsql;
using Npgsql.Replication.PgOutput.Messages;
using pilotoPharma.Models;
using pilotoPharma.Models.Conexion;
using pilotoPharma.Models.Consultas;
using pilotoPharma.Models.DTO;
using pilotoPharma.Models.DTO.ADTO;
using pilotoPharma.Models.Tools;
using System.Diagnostics;

namespace pilotoPharma.Controllers

    //Clase en la que se controla todo el proyecto y todo lo que se ejecuta está aquí.
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index(ConexionPostgreSQL conexionPostgreSQL)
        {
            System.Console.WriteLine("[INFORMACIÓN-HomeController-Index] Entra en Index");

            //CONSTANTES DE LA CONEXION A BASE DE DATOS
            const string HOST = VariablesConexionPostgreSQL.HOST;
            const string PORT = VariablesConexionPostgreSQL.PORT;
            const string USER = VariablesConexionPostgreSQL.USER;
            const string PASS = VariablesConexionPostgreSQL.PASS;
            const string DB = VariablesConexionPostgreSQL.DB;


            //Se genera una conexión a PostgreSQL y validamos que esté abierta fuera del método
            var estadoGenerada = "";
            NpgsqlConnection conexionGenerada = new NpgsqlConnection();

            //Ahora hacemos conexion llamando a los metodos y mostramos en pantalla el estado(open/closed)
            conexionGenerada = conexionPostgreSQL.GeneraConexion(HOST, PORT, DB, USER, PASS);
            estadoGenerada = conexionGenerada.State.ToString();
            System.Console.WriteLine("[INFORMACIÓN-HomeController-Index] Estado conexión generada: " + estadoGenerada);

            //Una vez hecha la conexion, vamos a empezar con la consulta a la base de datos.
            NpgsqlCommand consulta = new NpgsqlCommand();
            conexionGenerada = conexionPostgreSQL.GeneraConexion(HOST, PORT, DB, USER, PASS);
            Models.Consultas.InsertProductosPostgreSQL.ConsultaInsertProductos(conexionGenerada);//en el propio metodo ya se cierra la conexion

            //Ahora vamos a recorrer la lista de los productos y a mostrarlos por pantalla.
            //creo lista
            List<DTO_productos> listProductos = new List<DTO_productos>();
            //creo conexion
            conexionGenerada = new NpgsqlConnection();
            conexionGenerada = conexionPostgreSQL.GeneraConexion(HOST, PORT, DB, USER, PASS);

            estadoGenerada = conexionGenerada.State.ToString();
            System.Console.WriteLine("[INFORMACIÓN-HomeController-Index-ListaProductos] Estado conexión generada: " + estadoGenerada);

            //asigno la consulta a la lista
            listProductos = SelectProductosPostgreSQL.ConsultaSelectProductos(conexionGenerada);
            //la recorro con el metodo para mostrarlo en pantalla
            RecorreList.RecorreListaProductos(listProductos);

            conexionGenerada.Close(); //Cierro conexion de todos modos aunque en los metodos ya lo haya hecho
            return View();
        }
    }

}