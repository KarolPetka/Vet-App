using Vet_App.Context;

namespace Vet_App.Services
{
    public class AnimalsService
    {
        private readonly AnimalDatabaseContext _animalDatabaseContext;

        public AnimalsService(AnimalDatabaseContext animalDatabaseContext)
        {
            _animalDatabaseContext = animalDatabaseContext;
        }
    }
}
