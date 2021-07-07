using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace BibliotecaAPICore.DAL
{
    public interface ILibros
    {

        IEnumerable<Libros> GetLibros();

        void Insert(Libros entity);
    }
}
