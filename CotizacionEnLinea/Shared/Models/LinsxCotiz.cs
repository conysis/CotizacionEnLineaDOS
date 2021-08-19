using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CotizacionEnLinea.Shared.Models
{
    [Table("LinsxCotiz")]
    public class LinsxCotiz
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int Cantidad { get; set; }

        [Required]
        [Column(TypeName = "decimal(10,2)")]
        public decimal Precio { get; set; }


        public int IdLicitacion { get; set; }
        public LinsxLicit LineaLicitacion { get; set; }

        public int IdCotizacion { get; set; }
        public Cotizacion Cotizacion { get; set; }


    }
}
