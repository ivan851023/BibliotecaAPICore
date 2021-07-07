using BBibliotecaAPICore.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BibliotecaAPICore.DAL
{
    public interface IAutor
    {
        void Insert(Autor entity);

        Autor GetById(int id);

        IEnumerable<Autor> GetAutores();
    }
}
