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
        [Column("id_cita")]
        public int idCita { get; set; }

        [Column("fecha_cita", TypeName = "timestamp")]
        [Required]
        public DateTime fechaCita { get; set; }

        [Column(TypeName = "varchar(200)")]
        [Required]
        public string motivo { get; set; }

        [Column(TypeName = "varchar(20)")]
        [Required]
        public string estado { get; set; }

        [ForeignKey("Paciente")]
        [Column("id_paciente")]
        public int idPaciente { get; set; }

        [ForeignKey("Odontologo")]
        [Column("id_odontologo")]
        public int idOdontologo { get; set; }
        
        [ForeignKey("Consultorio")]
        [Column("id_consultorio")]
        public int idConsultorio { get; set; }
        

        // Objetos de navegacion 
        public Paciente? Paciente { get; set; }
        public Odontologo? Odontologo { get; set; }
        public Consultorio? Consultorio { get; set; }

        // Relaciones
        List<DetalleCita>? DetallesCita { get; set; } = new List<DetalleCita>();
        List<Receta>? Recetas { get; set; } = new List<Receta>();

        public Factura? Facturas { get; set; }
    }
}
