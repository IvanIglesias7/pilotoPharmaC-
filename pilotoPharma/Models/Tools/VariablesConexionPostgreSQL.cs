namespace pilotoPharma.Models.Tools
{
    /*Clase que nos va a servir para indicar que valores tiene cada parametro en la conexion
    a base de datos*/

    public class VariablesConexionPostgreSQL
    {
        //Variables que van a servir para la conexion a la base de datos, en este caso, PostgreSQL.
        public const string USER = "postgres";
        public const string PASS = "1234";
        public const string PORT = "5432";
        public const string HOST = "localhost";
        public const string DB = "pilotoPharma";
    }
}
