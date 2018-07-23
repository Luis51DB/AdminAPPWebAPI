using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Modelos
{
    [Table("usuarios")]
    public class Usuario
    {            
        [Key]
        public int id_usuario { get; set; }

        [Required(ErrorMessage = "Nombre de usuario es requerido")]
        [StringLength(16, ErrorMessage = "Nombre no puede ser mayor de 160 caracteres")]
        public string username { get; set; }

        [Required(ErrorMessage = "Email es requerido")]
        [StringLength(255, ErrorMessage = "Email no puede ser mayor de 255 caracteres")]
        public string email { get; set; }

        [Required(ErrorMessage = "Password es requerido")]
        [StringLength(32, ErrorMessage = "Password no puede ser mayor de 32 caracteres")]
        public string password { get; set; }

        public DateTime fecha_creacion { get; set; }

        public DateTime fecha_actualizacion { get; set; }

        [Required(ErrorMessage = "Rol Id es requerido")]
        public int rol_id { get; set; }
    }
}
