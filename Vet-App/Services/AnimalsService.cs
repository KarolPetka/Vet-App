using Vet_App.Context;
using Vet_App.Models;

namespace Vet_App.Services
{
    public class AnimalsService
    {
        private readonly AnimalDatabaseContext _animalDatabaseContext;

        public AnimalsService(AnimalDatabaseContext animalDatabaseContext)
        {
            _animalDatabaseContext = animalDatabaseContext;
        }

        public IEnumerable<Animal> Get()
        {
            return _animalDatabaseContext.Animals;
        }

        public Animal Get(int id)
        {
            return _animalDatabaseContext.Animals.SingleOrDefault(x => x.Id == id);
        }
    }
}
