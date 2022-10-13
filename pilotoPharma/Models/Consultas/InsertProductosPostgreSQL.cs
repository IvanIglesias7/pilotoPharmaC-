using Npgsql;

namespace pilotoPharma.Models.Consultas
{
    //Clase utilizada para insertar productos en la base de datos.
    public class InsertProductosPostgreSQL
    {
        public static void ConsultaInsertRel_Alumn_AsigPostgreSQL(NpgsqlConnection conexionGenerada)
        {
            try
            {
                //Inserto los datos
                NpgsqlCommand consulta = new NpgsqlCommand("INSERT INTO \"dlk_operacional_productos\".\"opr_cat_productos\"(" +
                    "md_uuid, md_fch, id_producto, cod_producto, nombre_producto, tipo_producto_origen," +
                    " tipo_producto_clase, des_producto, fch_alta_producto, fch_baja_producto)" +
                    "VALUES ('adf131029022fch12345', 2022/10/13, DEFAULT, " +
                    "'hig_p_gelf_f', 'Gel de aceite de fresa, Farlane.'," +
                    "'Propio', 'Higiene', 'Gel de aceite de fresa producido por marca propia Farlane'," +
                    "2022/10/13, 9999/12/31);", conexionGenerada);
                //cierro la conexion
                //conexionGenerada.Close();
            }
            catch (Exception e)
            {
                System.Console.WriteLine("[ERROR-HomeController-Index] Error al insertar datos: " + e);

            }

        }

    }
}
