using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using BibliotecaAPICore.DAL;
using BibliotecaAPICore.DAL.Repository;

namespace BibliotecaAPICore.DAL
{
    public class LibrosDAL : ILibros
    {
        private readonly IRepositoryBase<Libros> _repository;
        public LibrosDAL(IRepositoryBase<Libros> repository)
        {
            _repository = repository;
        }

        public IEnumerable<Libros> GetLibros()
        {
            return _repository.GetAll();
        }

        public void Insert(Libros table)
        {
            _repository.Insert(table);
        }
    }
}
