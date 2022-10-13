using Npgsql;

namespace pilotoPharma.Models.DTO.ADTO
{
    public class LectorListaDTO
    {
        public static List<DTO_productos> LectorProductos(NpgsqlDataReader resultadoConsulta)
        {
            List<DTO_productos> listProductos = new List<DTO_productos>();
            while (resultadoConsulta.Read())
            {
                listProductos.Add(new DTO_productos(
                    resultadoConsulta[0].ToString(),
                    (int)Int64.Parse(resultadoConsulta[1].ToString()),
                    resultadoConsulta[2].ToString(),
                    resultadoConsulta[3].ToString(),
                    resultadoConsulta[4].ToString(),
                    resultadoConsulta[5].ToString(),
                    resultadoConsulta[6].ToString())
                    );

            }
            return listProductos;
        }
    }
}
