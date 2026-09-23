using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaOdontologica.Modelos
{
    [Table("Citas")]
    public class Cita
    {
        [Key]
        [Column("id_cita", TypeName = "Serial")]
        public int idCita { get; set; }

        [Column("fecha_cita", TypeName = "timestamp")]
        [Required]
        public DateTime fechaCita { get; set; }

        [Column(TypeName = "varying(200)")]
        [Required]
        public string motivo { get; set; }

        [Column(TypeName = "varying(20)")]
        [Required]
        public string estado { get; set; }

        [ForeignKey("paciente")]
        [Column("id_paciente")]
        public int idPaciente { get; set; }

        [ForeignKey("odontologo")]
        [Column("id_odontologo")]
        public int idOdontologo { get; set; }
        
        [ForeignKey("consultorio")]
        [Column("id_consultorio")]
        public int idConsultorio { get; set; }
        

        // Objetos de navegacion 
        public Paciente? paciente { get; set; }
        public Odontologo? odontologo { get; set; }
        public Consultorio? consultorio { get; set; }
    }
}
