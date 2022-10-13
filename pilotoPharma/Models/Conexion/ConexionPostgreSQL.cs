using Npgsql; //importo Npgsql para que pueda usar la conexion.

namespace pilotoPharma.Models.Conexion
{
    /* Clase que sirve para hacer la conexion a base de datos recogiendo los valores de los parametros
     de la clase VariablesConexionPostgreSQL*/
    public class ConexionPostgreSQL
    {
        public NpgsqlConnection GeneraConexion(string host, string port,string db, 
            string user, string pass)
        {
            System.Console.WriteLine("[INFORMACIÓN-ConexionPostgreSQL-GeneraConexion] Entra en GeneraConexion");

            //Se crea una nueva conexión y la cadena con los datos de conexión.
            NpgsqlConnection conexion = new NpgsqlConnection();
            
            //En la variable metemos los parametros que mas tarde le meteremos de la clase
            //VariablesConexionPostgreSQL
            var datosConexion = "Server=" + host + "; Port=" + port + "; User Id=" + user + 
                "; Password=" + pass + "; Database=" + db;

            System.Console.WriteLine(datosConexion); //Mostramos los datos

            var estado = "";

            if (!string.IsNullOrWhiteSpace(datosConexion))
            {
                try
                {
                    conexion = new NpgsqlConnection(datosConexion);
                    conexion.Open();
                    //Se obtiene el estado de conexión para informarlo por consola
                    estado = conexion.State.ToString();
                    System.Console.WriteLine("[INFORMACIÓN-ConexionPostgreSQL-GeneraConexion] Estado conexión: " + estado);
                }
                catch (Exception e)
                {
                    //Si da error, mostramos error y cerramos conexion.
                    System.Console.WriteLine("[ERROR-ConexionPostgreSQL-GeneraConexion] Error al crear conexión:" + e);
                    conexion.Close();
                }
            }

            return conexion;

        }
    }
}
