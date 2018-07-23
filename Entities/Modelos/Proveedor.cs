using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Modelos
{
    [Table("proveedores")]
    public class Proveedor
    {
        [Key]
        public int proveedor_id { get; set; }

        [Required(ErrorMessage = "Nombre es requerido")]
        public string nombre { get; set; }

        public string nit { get; set; }

        public string telefono { get; set; }

        public string email { get; set; }

        public string status { get; set; }

        public string direccion { get; set; }

        public DateTime fecha_creacion { get; set; }

        public DateTime fecha_actualizacion { get; set; }
    }
}
