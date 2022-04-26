using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Vet_App.Context;

namespace Vet_App.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnimalsController : ControllerBase
    {
        private readonly AnimalDatabaseContext _animalDatabaseContext;

        public AnimalsController(AnimalDatabaseContext animalDatabaseContext)
        {
            _animalDatabaseContext = animalDatabaseContext;
        }
    }
}
