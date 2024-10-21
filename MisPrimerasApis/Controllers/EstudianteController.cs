using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MisPrimerasApis.Models;
using MisPrimerasApis.Repositories;
using System.Reflection.Metadata.Ecma335;

namespace MisPrimerasApis.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class EstudianteController : ControllerBase
    {
        [Route("InformacionEstudiante")]
        [HttpGet]
        public Estudiante DevuelveInformacionEstudiante()
        {
            EstudiantesRepository repositorio = new EstudiantesRepository();
            var estudiante = repositorio.DevuelveInformacionEstudiante();
            return estudiante;
        }



        [Route("ListadoEstudiantes")]
        [HttpGet]
        public List<Estudiante> DevuelveListadoEstudiantes()
        {
            EstudiantesRepository respository = new EstudiantesRepository();
            return respository.DevuelveListadoEstudiantes();
        }

        [Route("ListadoEstudiantesInscritos")]
        [HttpGet]
        public List<Estudiante> DevuelveListadoEstudiantesInscritos()
        {
            EstudiantesRepository repositorio = new EstudiantesRepository();
            return repositorio.DevuelveListadoEstudiantes().Where(x => x.EstaInscrito == true).ToList();
        }

        [Route("ListadoEstudiantesInscritos")]
        [HttpGet]
        public List<Estudiante> DevuelveListadoEstudiantesPorNombre(string nombre)
        {
            EstudiantesRepository repositorio = new EstudiantesRepository();
            return repositorio.DevuelveListadoEstudiantes().Where(x => x.Nombre == nombre).ToList();
        }
    }
}
