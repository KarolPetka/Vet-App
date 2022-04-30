using Vet_App.Context;
using Vet_App.Models;
using Vet_App.Repository;

namespace Vet_App.Services
{
    public class AnimalsService : IAnimalsController
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
            var animalToUpdate = _animalDatabaseContext.Animals.FirstOrDefault(x => x.Id == id);
            if (animalToUpdate != null)
            {
                animal.Id = id;
                _animalDatabaseContext.Animals.Update(animal);
                _animalDatabaseContext.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            var animalToDelete = _animalDatabaseContext.Animals.FirstOrDefault(x => x.Id == id);
            if (animalToDelete != null)
            {
                _animalDatabaseContext.Animals.Remove(animalToDelete);
                _animalDatabaseContext.SaveChanges();
            }
        }
    }
}
