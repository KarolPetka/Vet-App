using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Vet_App.Services;
using Vet_App.Models;

namespace Vet_App.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnimalsController : ControllerBase
    {
        private readonly AnimalsService _animalsService;

        public AnimalsController(AnimalsService animalServices)
        {
            _animalsService = animalServices;
        }

        [HttpGet]
        public IEnumerable<Animal> Get()
        {
            return _animalsService.Get();
        }

        [HttpGet("{id}", Name = "ById")]
        public Animal Get(int id)
        {
            return _animalsService.Get(id);
        }

        [HttpPost]
        public void Post([FromBody] Animal animal)
        {
            _animalsService.Post(animal);
        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Animal animal)
        {
            _animalsService.Put(id, animal);
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _animalsService.Delete(id);
        }
    }
}
