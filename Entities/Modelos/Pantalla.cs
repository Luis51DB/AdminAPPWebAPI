using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Modelos
{
    [Table("pantallas")]
    public class Pantalla
    {
        [Key]
        public int pantalla_id { get; set; }

        [StringLength(245, ErrorMessage = "Pantalla no puede ser mayor de 245 caracteres")]
        public string pantalla { get; set; }

        [StringLength(150, ErrorMessage = "Titulo no puede ser mayor de 150 caracteres")]
        public string titulo { get; set; }

        [StringLength(45, ErrorMessage = "Icono no puede ser mayor de 45 caracteres")]
        public string icono { get; set; }

        [StringLength(245, ErrorMessage = "Link no puede ser mayor de 245 caracteres")]
        public string link { get; set; }

        public bool home { get; set; }

        [Required(ErrorMessage = "Padre es requerido")]
        public int padre_id { get; set; }

        public DateTime fecha_creacion { get; set; }

        public DateTime fecha_actualizacion { get; set; }
    }
}
