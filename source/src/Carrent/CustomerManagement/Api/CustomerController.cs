using AutoMapper;
using Carrent.CustomerManagement.Application;
using Carrent.CustomerManagement.Domain;
using Carrent.CustomerManagement.Model;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Carrent.CustomerManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {

        public readonly ICustomerService _customerService;
        CustomerController( ICustomerService customerService)
        {
            _customerService = customerService;
        }

        // GET: api/<CustomerController>
        [HttpGet]
        public List<CustomerDto> Get()
        {
            var customer = _customerService.GetAll();
            return customer.Select(customer => new CustomerDto()
            {
                Id = customer.Id,
                Firstname = customer.Firstname,
                Familyname = customer.Familyname,
                Street = customer.Street,
                HouseNumber = customer.HouseNumber
            }).ToList();
        }

        // GET api/<CustomerController>/5
        [HttpGet("{id}")]
        public CustomerDto Get(Guid id)
        {
            var customer = _customerService.GetById(id);
            return new CustomerDto()
            {
                Id = customer.Id,
                Firstname = customer.Firstname,
                Familyname = customer.Familyname,
                Street = customer.Street,
                HouseNumber = customer.HouseNumber,
            };
        }

        // POST api/<CustomerController>
        [HttpPost]
        public void Post([FromBody] CustomerDto customerDto)
        {
            var customer = new Customer()
            {
                Id = Guid.NewGuid(),
                Firstname = customerDto.Firstname,
                Familyname = customerDto.Familyname,
                Street = customerDto.Street,
                HouseNumber = customerDto.HouseNumber
            };

            _customerService.Add(customer);
        }

        // PUT api/<CustomerController>/5
        [HttpPut("{id}")]
        public void Put(Guid id, [FromBody] CustomerDto customerDto)
        {
            var customer = new Customer()
            {
                Id = id,
                Firstname = customerDto.Firstname,
                Familyname = customerDto.Familyname,
                Street = customerDto.Street,
                HouseNumber = customerDto.HouseNumber
            };
            _customerService.Update(customer);
        }

        // DELETE api/<CustomerController>/5
        [HttpDelete("{id}")]
        public void Delete(Guid id)
        {
            _customerService.DeleteById(id);
        }
    }
}
