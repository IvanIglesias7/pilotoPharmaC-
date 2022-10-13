using System.ComponentModel.DataAnnotations;

namespace pilotoPharma.Models.DTO
{
    /*Clase que me va a permitir sacar los datos e insertarlos de la base de datos y respaldarlos en un objeto
     es decir, en un DTO, gracias a esto podemos crear listas y muchas cosas mas; facilitando el uso y manipulacion 
    de los datos de la DB*/
    public class DTO_productos
    {
        //Todas las propiedades
        string md_uuid;
        DateTime md_fch;
        int id_producto;
        string cod_producto;
        string nombre_producto;
        string tipo_producto_origen;
        string tipo_producto_clase;
        string des_producto;
        DateTime fch_alta_producto;
        string fch_baja_producto;

        //Constructor de lo que no puede estar NULL
        public DTO_productos(string md_uuid, int id_producto, string cod_producto)
        {
            this.md_uuid = md_uuid;
            this.id_producto = id_producto;
            this.cod_producto = cod_producto;
        }

        //Constructor entero
        public DTO_productos(string md_uuid, DateTime md_fch, int id_producto, string cod_producto, 
            string nombre_producto, string tipo_producto_origen, string tipo_producto_clase, string des_producto, 
            DateTime fch_alta_producto, string fch_baja_producto)
        {
            this.md_uuid = md_uuid;
            this.md_fch = md_fch;
            this.id_producto = id_producto;
            this.cod_producto = cod_producto;
            this.nombre_producto = nombre_producto;
            this.tipo_producto_origen = tipo_producto_origen;
            this.tipo_producto_clase = tipo_producto_clase;
            this.des_producto = des_producto;
            this.fch_alta_producto = fch_alta_producto;
            this.fch_baja_producto = fch_baja_producto;
        }

        public DTO_productos(string md_uuid, int id_producto, string cod_producto,
            string nombre_producto, string tipo_producto_origen, string tipo_producto_clase, string des_producto)
        {
            this.md_uuid = md_uuid;
            this.id_producto = id_producto;
            this.cod_producto = cod_producto;
            this.nombre_producto = nombre_producto;
            this.tipo_producto_origen = tipo_producto_origen;
            this.tipo_producto_clase = tipo_producto_clase;
            this.des_producto = des_producto;
        }

        //Encapsulamiento
        public string Md_uuid { get => md_uuid; set => md_uuid = value; }
        public DateTime Md_fch { get => md_fch; set => md_fch = value; }
        public int Id_producto { get => id_producto; set => id_producto = value; }
        public string Cod_producto { get => cod_producto; set => cod_producto = value; }
        public string Nombre_producto { get => nombre_producto; set => nombre_producto = value; }
        public string Tipo_producto_origen { get => tipo_producto_origen; set => tipo_producto_origen = value; }
        public string Tipo_producto_clase { get => tipo_producto_clase; set => tipo_producto_clase = value; }
        public string Des_producto { get => des_producto; set => des_producto = value; }
        public DateTime Fch_alta_producto { get => fch_alta_producto; set => fch_alta_producto = value; }
        public string Fch_baja_producto { get => fch_baja_producto; set => fch_baja_producto = value; }
    }
}
