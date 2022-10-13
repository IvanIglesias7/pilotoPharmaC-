namespace pilotoPharma.Models.DTO.ADTO
{
    public class RecorreList
    {
        public static void RecorreListaProductos(List<DTO_productos> ListProductos)
        {
            for (int i = 0; i < ListProductos.Count; i++)
            {
                Console.WriteLine("\t{0}", ListProductos[0].Md_uuid);
                Console.WriteLine("\t{0}", ListProductos[0].Id_producto);
                Console.WriteLine("\t{0}", ListProductos[0].Cod_producto);
                Console.WriteLine("\t{0}", ListProductos[0].Nombre_producto);
                Console.WriteLine("\t{0}", ListProductos[0].Tipo_producto_origen);
                Console.WriteLine("\t{0}", ListProductos[0].Tipo_producto_clase);
                Console.Write("\t{0}", ListProductos[0].Des_producto);
            }
        }
    }
}
