using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using AppLibrary.Core.Entities;
using AppLibrary.Repository;

namespace AppLibrary.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LibreriaServicioController : ControllerBase
    {
 
        private readonly IMongoRepository<AutorEntity> _autorGenericoRepository;

        private readonly IMongoRepository<EmpleadoEntity> _empleadoGenericoRepository;
        
        public LibreriaServicioController( IMongoRepository<AutorEntity> autorGenericoRepository, IMongoRepository<EmpleadoEntity> empleadoGenericoRepository) {
            _autorGenericoRepository = autorGenericoRepository;
            _empleadoGenericoRepository = empleadoGenericoRepository;

        }

        [HttpGet("empleadoGenerico")]
        public async Task<ActionResult<IEnumerable<EmpleadoEntity>>> GetEmpleadoGenerico()
        {

            var empleados = await _empleadoGenericoRepository.GetAll();

            return Ok(empleados);
        }

        [HttpGet("autorGenerico")]
        public async Task<ActionResult<IEnumerable<AutorEntity>>> GetAutorGenerico()
        {

            var autores = await _autorGenericoRepository.GetAll();

            return Ok(autores);
        }

        [HttpGet("autorGenerico/{id}")]
        public async Task<ActionResult<IEnumerable<AutorEntity>>> GetAutorId(string id)
        {

            var autores = await _autorGenericoRepository.GetById(id);

            return Ok(autores);
        }


   

        [HttpPost("addAutor")]
        public async Task AddAutor(AutorEntity autor)
        {
            await _autorGenericoRepository.InsertDocument(autor);
        }

        [HttpPut("updateAutor")]
        public async Task UpdateAutor(AutorEntity autor)
        {
            await _autorGenericoRepository.UpdateDocument(autor);
        }

        [HttpDelete("deleteAutor/{id}")]
        public async Task DeleteAutor(string Id)
        {
            await _autorGenericoRepository.DeleteById(Id);
        }

    }
}
