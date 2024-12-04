using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using APISemana11A.Responses;

namespace APISemana11A.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class ApiController : ControllerBase
    {
        [Authorize("Vendedor")]
        [HttpGet(Name = "Get2")]
        public IEnumerable<PersonResponse> Get2()
        {
            List<PersonResponse> personas = new List<PersonResponse>();

            for (int i = 1; i <= 100; i++)
            {
                PersonResponse persona = new PersonResponse();
                persona.FirstName = "Persona" + i;
                persona.LastName = "Apellido" + i;

                personas.Add(persona);
            }

            return personas;
        }

        [Authorize("Administrador")]
        [HttpGet(Name = "Get")]
        public IEnumerable<PersonResponse> Get()
        {
            List<PersonResponse> personas = new List<PersonResponse>();

            for ( int i = 1; i <=100; i++)
            {
                PersonResponse persona = new PersonResponse();
                persona.FirstName = "Persona" + i;
                persona.LastName = "Apellido" + i;

                personas.Add(persona);
            }
            return personas;
        }
    }
}
