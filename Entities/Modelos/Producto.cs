using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Modelos
{
    [Table("productos")]
    public class Producto
    {
        [Key]
        public int producto_id { get; set; }

        [Required(ErrorMessage = "Codigo es requerido")]
        public string cod_producto { get; set; }

        [Required(ErrorMessage = "Descripcion es requerido")]
        public string descripcion { get; set; }

        [Required(ErrorMessage = "Status es requerido")]
        public string status { get; set; }
        
        public int catprod_id { get; set; }

        public decimal precio { get; set; }

        public decimal costo { get; set; }

        public string codigo_barras { get; set; }

        public string referencia_interna { get; set; }

        public string desc_clientes { get; set; }        

        public DateTime fecha_creacion { get; set; }

        public DateTime fecha_actualizacion { get; set; }
    }
}
