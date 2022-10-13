using Npgsql;
using pilotoPharma.Models.DTO;

namespace pilotoPharma.Models.Consultas
{
    public class SelectProductosPostgreSQL
    {
        public static List<DTO_productos> ConsultaSelectProductos(NpgsqlConnection conexionGenerada)
        {
            List<DTO_productos> listProductos = new List<DTO_productos>();
            try
            {
                //Se define y ejecuta la consulta Select
                NpgsqlCommand consulta = new NpgsqlCommand("SELECT * FROM \"dlk_operacional_productos\".\"opr_cat_productos\"", conexionGenerada);
                NpgsqlDataReader resultadoConsulta = consulta.ExecuteReader();

                //Paso de DataReader a lista de productos
                listProductos = DTO.ADTO.LectorListaDTO.LectorProductos(resultadoConsulta);


                //cierro conexiones
                conexionGenerada.Close();
                resultadoConsulta.Close();
            }
            catch (Exception e)
            {

                System.Console.WriteLine("[ERROR-SelectProcutosPostgreSQL-ConsultaSelectProductos] Error al ejecutar consulta: " + e);
                conexionGenerada.Close();

            }
            return listProductos;
        }
    }
}
