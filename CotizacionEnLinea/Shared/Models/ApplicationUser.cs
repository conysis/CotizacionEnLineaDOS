using Microsoft.AspNetCore.Identity;

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CotizacionEnLinea.Shared.Models
{
    public class ApplicationUser : IdentityUser
    {
        public virtual ICollection<Cotizacion> Cotizaciones { get; set; }

        [Required]
        [PersonalData]
        [Column(TypeName = "nvarchar(25)")]
        public string DocId { get; set; }

        [Required]
        [PersonalData]
        [Column(TypeName = "nvarchar(100)")]
        public string Nombre { get; set; }

        [Required]
        [PersonalData]
        [Column(TypeName = "nvarchar(100)")]
        public string Apellido1 { get; set; }

        [Required]
        [PersonalData]
        [Column(TypeName = "nvarchar(100)")]
        public string Apellido2 { get; set; }

        [Required]
        [PersonalData]
        [Column(TypeName = "nvarchar(100)")]
        public string RazonSocial { get; set; }

        [Required]
        [PersonalData]
        [Column(TypeName = "nvarchar(100)")]
        public string NombreEmpresa { get; set; }

    }
}
