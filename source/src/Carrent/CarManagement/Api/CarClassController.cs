using AutoMapper;
using Carrent.CarManagement.Application;
using Carrent.CarManagement.Domain;
using Carrent.CarManagement.Model;
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
    public class CarClassController : ControllerBase
    {
        private readonly ICarClassService _carClassService;
        private readonly IMapper _mapper;

        public CarClassController(IMapper mapper, ICarClassService carClassService)
        {
            _mapper = mapper;
            _carClassService = carClassService;
        }

        // GET: api/<CarClassController>
        [HttpGet]
        public List<CarClassDto> Get()
        {
            var carClass = _carClassService.GetAllClasses();
            return carClass.Select(carClass => _mapper.Map<CarClassDto>(carClass)).ToList();
        }

        // GET api/<CarClassController>/5
        [HttpGet("{id}")]
        public CarClassDto GetById(Guid id)
        {
            var carClass = _carClassService.GetClassById(id);
            return _mapper.Map<CarClassDto>(carClass);
        }

        // POST api/<CarClassController>
        [HttpPost]
        public void Post([FromBody] CarClassDto carClassDto)
        {
            var carClass = _mapper.Map<CarClass>(carClassDto);
            _carClassService.Add(carClass);
        }

        // PUT api/<CarClassController>/5
        [HttpPut("{id}")]
        public void Put(Guid id, [FromBody] CarClassDto carClassDto)
        {
            var carClass = _mapper.Map<CarClass>(carClassDto);
            _carClassService.Update(carClass);
        }

        // DELETE api/<CarClassController>/5
        [HttpDelete("{id}")]
        public void Delete(Guid id)
        {
            var carClass = _carClassService.GetClassById(id);
            if (carClass != null)
            {
                _carClassService.DeleteById(id);
            }
        }
    }
}
