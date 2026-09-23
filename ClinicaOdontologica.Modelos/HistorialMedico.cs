using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaOdontologica.Modelos
{
    [Table("HistorialesMedicos")]
    public class HistorialMedico
    {
        [Key]
        [Column("id_historial", TypeName = "Serial")]
        public int idHistorialMedico { get; set; }
        
        [Column("alergias", TypeName = "varying(100)")]
        public string alergias { get; set; }

        [Column("enfermedades_previas", TypeName = "varying(100)")]
        public string enfermedadesPrevias { get; set; }

        [Column("tipo_sangre", TypeName = "varying(10)")]
        [Required]
        public string tipoSangre { get; set; }

        [ForeignKey("paciente")]
        [Column("id_paciente")]
        public int idPaciente { get; set; }
        public Paciente? paciente { get; set; }
    }
}
