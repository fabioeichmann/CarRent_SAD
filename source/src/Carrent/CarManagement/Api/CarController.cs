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
            _mapper = mapper;
            _carService = carService;
        }

        // GET: api/<CarController>
        [HttpGet]
        public List<CarDto> Get()
        {
            return _carService.GetAllCars().Select(car => _mapper.Map<CarDto>(car)).ToList();
        }

        // GET api/<CarController>/5
        [HttpGet("{id}")]
        public CarDto Get(Guid id)
        {
            var car = _carService.GetCarById(id);
            return _mapper.Map<CarDto>(car);
        }

        // POST api/<CarController>
        [HttpPost]
        public void Post([FromBody] CarDto carDto)
        {
            var car = _mapper.Map<Car>(carDto);
            _carService.Add(car);
        }

        // PUT api/<CarController>/5
        [HttpPut("{id}")]
        public void Put(Guid id, [FromBody] CarDto carDto)
        {
            var car = _mapper.Map<Car>(carDto);
            _carService.Update(car);
        }

        // DELETE api/<CarController>/5
        [HttpDelete("{id}")]
        public void Delete(Guid id)
        {
            _carService.DeleteById(id);
        }
    }
}
