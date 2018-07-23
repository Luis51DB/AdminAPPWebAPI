using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Modelos
{
    [Table("ordenes_compra_detalle")]
    public class OrdenCompraDetalle
    {
        [Key]
        public int ocdet_id { get; set; }

        public int producto_id { get; set; }

        [Required(ErrorMessage = "Cantidad es requerido")]
        public int cantidad { get; set; }

        public decimal precio_unitario { get; set; }

        public decimal subtotal { get; set; }

        public bool recibido { get; set; }

        public decimal precio_un_facturado { get; set; }

        public DateTime fecha_creacion { get; set; }

        public DateTime fecha_actualizacion { get; set; }
    }
}
