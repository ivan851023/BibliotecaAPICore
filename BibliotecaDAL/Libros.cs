using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BibliotecaDAL
{
    public class Libros
    {
        public int Id { get; set; }
        public string Titulo  { get; set; }

        public int Anio { get; set; }

        public string Genero { get; set; }

        public int NumeroPaginas { get; set; }

        public int IdAutor { get; set; }
    }
}
