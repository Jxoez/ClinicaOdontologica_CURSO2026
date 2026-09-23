using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ClinicaOdontologica.Modelos
{
    [Table("DetallesCita")]
    public class DetalleCita
    {
        [Key]
        [Column("id_detalle_cita", TypeName = "Serial")]
        public int idDetalleCita { get; set; }

        [Column("costo_aplicado", TypeName = "numeric(10, 2)")]
        [Required]
        public decimal costoAplicado { get; set; }
        
        [Column(TypeName = "varying(200)")]
        [Required]
        public string observaciones { get; set; }

        [ForeignKey("cita")]
        [Column("id_cita")]
        public int idCita { get; set; }
        
        [ForeignKey("tratamiento")]
        [Column("id_tratamiento")]
        public int idTratamiento { get; set; }
        
        // Objetos de navegacion 
        public Cita? cita { get; set; }
        public Tratamiento? tratamiento { get; set; }
    }
}
