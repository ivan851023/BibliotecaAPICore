using BBibliotecaAPICore.DAL;
using BibliotecaAPICore.DAL;
using BibliotecaAPICore.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
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
    public class AutorController : ControllerBase
    {
        private IConfiguration _configuration;

        private BibliotecaContext Context { get; }
        
        public AutorController(IConfiguration configuration, IAutor iautor)
        {
            _autor = iautor;
            _configuration = configuration;

        }

        private readonly IAutor _autor;

        [HttpGet]
        public IActionResult Index()
        {

            var autores = _autor.GetAutores()
                        .Select(x =>
                                new Autor
                                {
                                    Id = x.Id,
                                    Nombres = x.Nombres,
                                    FechaNacimiento = x.FechaNacimiento,
                                    Ciudad = x.Ciudad,
                                    Correo = x.Correo
                                });

            return Ok(autores);
        }


        // POST api/<LibroController>
        [HttpPost]
        public IActionResult Post(Autor table)
        {
            try
            {
                _autor.Insert(table);

                var result = new ResultEntityMessage<int>();
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
