using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BibliotecaDAL
{
    public class Autor
    {

        public int Id { get; set; }
        public string Nombres { get; set; }

        public DateTime FechaNacimiento { get; set; }

        public string Ciudad { get; set; }

        public string Correo { get; set; }
    }
}
