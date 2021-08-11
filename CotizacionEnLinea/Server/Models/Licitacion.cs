using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CotizacionEnLinea.Server.Models
{
    [Table("Licitacion")]
    public class Licitacion
    {

        [Key]
        public int IdLicitacion { get; set; }

        [Column(TypeName = "nvarchar(9)")]
        [Required(ErrorMessage = "Este campo es obligatorio")]
        [DisplayName("Expediente Nº")]
        public string Expediente { get; set; }

        [Required(ErrorMessage = "Este campo es obligatorio")]
        [DisplayName("Fecha de Creación")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime FecCreacion { get; set; }

        [Required(ErrorMessage = "Este campo es obligatorio")]
        [DisplayName("Fecha de Apertura")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime FecApertura { get; set; }

        public virtual ICollection<LinsxLicit> LineasLicitacion { get; set; }
    }
}
