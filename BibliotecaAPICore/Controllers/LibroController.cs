using BibliotecaAPICore.DAL;
using BibliotecaAPICore.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BibliotecaAPICore.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class LibroController : ControllerBase
    {
        private IConfiguration _configuration;

        private const int limiteLibros = 5;

        private BibliotecaContext Context { get; }


        private readonly ILibros _libros;

        private readonly IAutor _autor;

        public LibroController(IConfiguration configuration, ILibros ilibros, IAutor iautor)
        {
            _libros = ilibros;
            _autor = iautor;
            _configuration = configuration;

        }
    


        // GET: api/<LibroController>
        [HttpGet]
        public IEnumerable<Libros> Get()
        {
            
            return _libros.GetLibros().ToList();
        }

        
        // POST api/<LibroController>
        [HttpPost]
        public IActionResult Insert(Libros table)
        {
            try
            {
                var result = new ResultEntityMessage<int>();

                int count = _libros.GetLibros().Count();

                var autor = _autor.GetById(table.IdAutor);

                if (autor == null)
                {
                    return StatusCode(500, "El autor no está registrado");
                }

                if (count == limiteLibros)
                {
                    return StatusCode(500, "Se alcanzo el limite de registro de libros");
                }
                


                _libros.Insert(table);

                
                result.status = true;
                result.message = "Resultado Exitoso";
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
            
            
        }


    }
}
