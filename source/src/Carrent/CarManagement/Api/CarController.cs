using AutoMapper;
using Carrent.CarManagement.Model;
using Carrent.CarManagement.Application;
using Carrent.CarManagement.Domain;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Carrent.CarManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarController : ControllerBase
    {
        private readonly ICarClassService _carClassService;
        private readonly ICarService _carService;

        public CarController(ICarService carService, ICarClassService carClassService)
        {
            _carService = carService;
            _carClassService = carClassService;
        }

        // GET: api/<CarController>
        [HttpGet]
        public List<CarDto> Get()
        {
            return _carService.GetAllCars().Select(car => new CarDto()
            {
                Make = car.Make,
                ClassId = car.ClassId,
                Class = car.Class,
                Id = car.Id,
                Type = car.Type
            }).ToList();
        }

        // GET api/<CarController>/5
        [HttpGet("{id}")]
        public CarDto Get(Guid id)
        {
            var car = _carService.GetCarById(id);
            return new CarDto()
            {
                Make = car.Make,
                ClassId = car.ClassId,
                Id = car.Id
            };
        }

        // POST api/<CarController>
        [HttpPost]
        public void Post([FromBody] CarDto carDto)
        {
            var car = new Car()
            {
                Id = Guid.NewGuid(),
                ClassId = carDto.ClassId,
                Make = carDto.Make,
                Type = carDto.Type,
            };

            car.Class = _carClassService.GetClassById(carDto.ClassId);
            _carService.Add(car);
        }

        // PUT api/<CarController>/5
        [HttpPut("{id}")]
        public void Put(Guid id, [FromBody] CarDto carDto)
        {
            var car = _carService.GetCarById(id);
            if (car != null)
            {
                car.Make = carDto.Make;
                car.ClassId = id;
                car.Type = carDto.Type;
                _carService.Update(car);
            }
        }

        // DELETE api/<CarController>/5
        [HttpDelete("{id}")]
        public void Delete(Guid id)
        {
            _carService.DeleteCarById(id);
        }
    }
}
