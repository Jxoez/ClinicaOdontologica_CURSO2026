using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaOdontologica.Modelos
{
    [Table("Recetas")]
    public class Receta
    {
        [Key]
        [Column("id_receta", TypeName = "Serial")]
        public int idReceta { get; set; }

        [Column("fecha_emision", TypeName = "timestamp")]
        [Required]
        public DateOnly fechaEmision { get; set; }

        [Column("indicaciones", TypeName = "text")]
        [MaxLength(300)]
        [Required]
        public string indicaciones { get; set; }

        [ForeignKey("Cita")]
        [Column("id_cita")]
        public int idCita { get; set; }
        public Cita? Cita { get; set; }
    }
}
