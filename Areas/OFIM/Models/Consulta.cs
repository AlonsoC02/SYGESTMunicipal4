using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SYGESTMunicipal.Areas.OFIM.Models
{
    public partial class Consulta
    {
        [Key]
        [Display(Name = "Consulta ID")]
        public int ConsultaId { get; set; }

        [Display(Name = "Persona ID")]
        public string PersonaOFIMId { get; set; }
        [ForeignKey("PersonaOFIMId")]

        [DataType(DataType.DateTime)]
        [Display(Name = "Fecha")]
        [DisplayFormat(DataFormatString = "{0:dd'/'MM'/'yyyy h:mm tt}", ApplyFormatInEditMode = true)]
        public DateTime Fecha { get; set; }

        [DataType(DataType.Time)]
        [Display(Name = "Hora Inicio")]
        [DisplayFormat(DataFormatString = "{0:h:mm tt}", ApplyFormatInEditMode = true)]
        public DateTime HoraInicio { get; set; }

        [DataType(DataType.Time)]
        [Display(Name = "Hora Fin")]
        [DisplayFormat(DataFormatString = "{0:h:mm tt}", ApplyFormatInEditMode = true)]
        public DateTime HoraFin { get; set; }

        [DisplayName("Descripción")]
        public string Descripcion { get; set; }

        [DisplayName("Respuesta Ofrecida")]
        public string RespuestaOfrecida { get; set; }

        [DisplayName("Seguimiento")]
        public string Seguimiento { get; set; }
        public virtual PersonaOFIM PersonaOFIM { get; set; }
    }
}
