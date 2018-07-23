using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Modelos
{
    [Table("ordenes_compra")]
    public class OrdenCompra
    {
        [Key]
        public int oc_id { get; set; }

        [StringLength(255, ErrorMessage = "Referencia no puede ser mayor de 255 caracteres")]
        public string referencia { get; set; }

        [StringLength(50, ErrorMessage = "Status no puede ser mayor de 150 caracteres")]
        public string status { get; set; }        

        public int proveedor_id { get; set; }

        public DateTime fecha_creacion { get; set; }

        public DateTime fecha_actualizacion { get; set; }
    }
}
