using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace RocWay.Application.DTO
{
    public class CustomerDto
    {
        public int CustomerId { get; set; }
        [Required]
        public string Nit { get; set; }
        [Display(Name = "Regimen"), Required, MaxLength(50)]
        public string RegimenType { get; set; }
        [Display(Name = "Nombre Negocio"), Required, MaxLength(250)]
        public string CompanyName { get; set; }
        [Display(Name = "Ubicacion"), Required, MaxLength(100)]
        public string Location { get; set; }
        [Display(Name = "Contacto"), Required, MaxLength(250)]
        public string ContactName { get; set; }
        [Display(Name = "Telefono"), Required, MaxLength(25)]
        public string Phone { get; set; }
        [Required, DataType(DataType.EmailAddress), MaxLength(100)]
        public string Email { get; set; }
        [Required, MaxLength(1000)]
        public string Logo { get; set; }
    }
}
