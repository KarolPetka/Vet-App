using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Vet_App.Context;
using Vet_App.Models;

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

        [HttpGet]
        public IEnumerable<Animal> Get()
        {
            return _animalDatabaseContext.Animals;
        }

        [HttpGet("{id}", Name = "ById")]
        public Animal Get(int id)
        {
            return _animalDatabaseContext.Animals.SingleOrDefault(x => x.Id == id);
        }

        [HttpPost]
        public void Post([FromBody] Animal animal)
        {
            _animalDatabaseContext.Animals.Add(animal);
            _animalDatabaseContext.SaveChanges();
        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Animal animal)
        {
            _animalDatabaseContext.Animals.Update(animal);
            _animalDatabaseContext.SaveChanges();
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var animal = _animalDatabaseContext.Animals.FirstOrDefault(x => x.Id == id);
            if (animal != null)
            {
                _animalDatabaseContext.Animals.Remove(animal);
                _animalDatabaseContext.SaveChanges();
            }
        }
    }
}
