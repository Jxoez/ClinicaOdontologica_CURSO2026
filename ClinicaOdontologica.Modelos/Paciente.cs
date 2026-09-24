using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaOdontologica.Modelos
{
    [Table("Pacientes")]
    public class Paciente
    {
        [Key]
        [Column("id_paciente", TypeName = "Serial")]
        public int idPaciente { get; set; }
        
        [Column("dni", TypeName = "varying(10)")]
        [Required]
        public string dni { get; set; }
        
        [Column("nombres", TypeName = "varying(50)")]
        [Required]
        public string nombres { get; set; }
        
        [Column("apellidos", TypeName = "varying(50)")]
        [Required]
        public string apellidos { get; set; }
        
        [Column("fecha_nacimiento", TypeName = "date")]
        [Required]
        public DateOnly fechaNacimiento { get; set; }
        
        [Column("email", TypeName = "varying(100)")]
        [Required]
        public string email { get; set; }

        [Column("telefono", TypeName = "varying(15)")]
        [Required]
        public string telefono { get; set; }

        // Relaciones
        List<Cita>? Citas { get; set; } = new List<Cita>();
        public HistorialMedico? HistorialMedico { get; set; }
    }
}
