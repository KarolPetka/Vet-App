using Vet_App.Models;

namespace Vet_App.Repository
{
    public interface IAnimalsController
    {
        IEnumerable<Animal> Get();
        Animal Get(int id);
        void Post(Animal animal);
        void Put(int id, Animal animal);
        void Delete(int id);
    }
}
