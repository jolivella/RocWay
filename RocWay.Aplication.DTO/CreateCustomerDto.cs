﻿using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace RocWay.Application.DTO
{
    public class CreateCustomerDto
    {
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
        public IFormFile Logo { get; set; }
    }
}
