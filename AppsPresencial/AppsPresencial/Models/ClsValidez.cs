using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AppsPresencial.Models
{
    public class ClsValidez
    {
         [Display(Name ="Nombre")]
         [Required(ErrorMessage ="Este campo es requerido")]
         public string Nombre { get; set; }





        [Display(Name ="Edad")]
        [Required(ErrorMessage ="Este campo es requerido")]
        public int Edad { get; set; }



        [Display(Name ="Sexo")]
        [Required(ErrorMessage ="Este campo es requerido")]
        public String Sexo { get; set; }





        [Display(Name ="TipoDeEstudio")]
        [Required(ErrorMessage ="Este campo es requerido")]
        public String TipoDeEstudio { get; set; }
    }
}
