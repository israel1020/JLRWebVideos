using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace JLRWebVideos.Models
{
    public class ArchivoViewModel
    {
        [Required]
        [DisplayName("Mi archivo")]
        public IFormFile Archivo1 { get; set; }
        [Required]
        [DisplayName("Mi archivo2")]
        public IFormFile Archivo2 { get; set; }
        [Required]
        [DisplayName("Mi cadena")]
        public string Cadena { get; set; }
    }
}
