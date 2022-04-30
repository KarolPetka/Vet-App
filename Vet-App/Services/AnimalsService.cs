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

        public void Post(Animal animal)
        {
            _animalDatabaseContext.Animals.Add(animal);
            _animalDatabaseContext.SaveChanges();
        }

        public void Put(int id, Animal animal)
        {
            animal.Id = id;
            _animalDatabaseContext.Animals.Update(animal);
            _animalDatabaseContext.SaveChanges();
        }

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
