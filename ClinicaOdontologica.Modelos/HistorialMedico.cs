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
        [Column("id_historial")]
        public int idHistorialMedico { get; set; }
        
        [Column("alergias", TypeName = "varchar(100)")]
        public string alergias { get; set; }

        [Column("enfermedades_previas", TypeName = "varchar(100)")]
        public string enfermedadesPrevias { get; set; }

        [Column("tipo_sangre", TypeName = "varchar(10)")]
        [Required]
        public string tipoSangre { get; set; }

        [ForeignKey("Paciente")]
        [Column("id_paciente")]
        public int idPaciente { get; set; }
        public Paciente? Paciente { get; set; }
    }
}
