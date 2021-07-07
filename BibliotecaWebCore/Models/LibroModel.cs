using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BibliotecaWebCore.Models
{
    public class LibroModel
    {
        [Display(Name = "Titulo Libro")]
        public string labelTitulo{ get; set; }

        public string Titulo { get; set; }

        public IEnumerable<SelectListItem> listAutor { get; set; }

        public int selectValueAutor { get; set; }

        [Display(Name = "Seleccione Autor")]
        public string labelAutor { get; set; }

       

    }
}
