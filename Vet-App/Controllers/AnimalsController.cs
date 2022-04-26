﻿using Microsoft.AspNetCore.Http;
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
    }
}
