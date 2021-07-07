using BBibliotecaAPICore.DAL;
using BibliotecaAPICore.DAL.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BibliotecaAPICore.DAL
{
    public class AutorDAL : IAutor
    {
        private readonly IRepositoryBase<Autor> _repository;
        public AutorDAL(IRepositoryBase<Autor> repository)
        {
            _repository = repository;
        }

        public void Insert(Autor table)
        {
            _repository.Insert(table);
        }

        public Autor GetById(int id)
        {
            return _repository.GetById(id);
        }

        public IEnumerable<Autor> GetAutores()
        {
            return _repository.GetAll();
        }

    }
}
