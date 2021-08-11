using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CotizacionEnLinea.Server.Models
{
    [Table("LinsxLicit")]

    public class LinsxLicit
    {
        public enum UnidadesMedida
        {
            Metro,
            Unidad,
            Litro
        }

        [Key]
        public int Id { get; set; }

        [Required]
        public int Cantidad { get; set; }
        [Required]

        [Column(TypeName = "nvarchar(150)")]
        public string Detalle { get; set; }

        public UnidadesMedida UnidadMedida { get; set; }

        [Required]
        [Column(TypeName = "decimal(10,2)")]
        public decimal Precio { get; set; }

        public int IdLicitacion { get; set; }
        [ForeignKey("IdLicitacion")]
        public virtual Licitacion Licitacion { get; set; }

        public virtual ICollection<LinsxCotiz> LinsxCotizs { get; set; }

    }
}
