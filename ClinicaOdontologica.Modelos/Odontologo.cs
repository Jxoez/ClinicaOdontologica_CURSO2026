using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaOdontologica.Modelos
{
    [Table("Odontologos")]
    public class Odontologo
    {
        [Key]
        [Column("id_odontologo", TypeName = "Serial")]
        public int idOdontologo { get; set; }

        [Column(TypeName = "varying(50)")]
        [Required]
        public string nombres { get; set; }

        [Column(TypeName = "varying(50)")]
        [Required]
        public string apellidos { get; set; }

        [Column("registro_medico", TypeName = "varying(20)")]
        [Required]
        public string registroMedico { get; set; }

        [ForeignKey("Especialidad")]
        [Column("id_especialidad")]
        public int idEspecialidad { get; set; }
        public Especialidad? Especialidad { get; set; }

        // Relaciones
        List<Cita> Citas { get; set; } = new List<Cita>();
    }
}
