using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Modelos
{
    [Table("roles")]
    public class Rol
    {
        [Key]
        public int rol_id { get; set; }

        [Required(ErrorMessage = "Nombre de rol es requerido")]
        [StringLength(45, ErrorMessage = "Nombre de rol no puede ser mayor de 45 caracteres")]
        public string rol { get; set; }
       
        [StringLength(245, ErrorMessage = "Descripcion no puede ser mayor de 245 caracteres")]
        public string descripcion { get; set; }

        public DateTime fecha_creacion { get; set; }

        public DateTime fecha_actualizacion { get; set; }
    }
}
