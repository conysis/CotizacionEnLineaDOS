using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CotizacionEnLinea.Server.Models
{
    [Table("Cotizacion")]
    public class Cotizacion
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public DateTime Fecha { get; set; }

        public int IdLicitacion { get; set; }
        [ForeignKey("IdLicitacion")]
        public Licitacion Licitacion { get; set; }
        public ICollection<LinsxCotiz> LineasCotizacion { get; set; }
        public string UserId { get; set; }
        [ForeignKey("UserId")]
        public virtual ApplicationUser OwnerID { get; set; }
    }
}
