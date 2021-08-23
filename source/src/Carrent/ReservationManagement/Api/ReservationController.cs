using Carrent.ReservationManagement.Application;
using Carrent.ReservationManagement.Domain;
using Carrent.ReservationManagement.Model;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Carrent.ReservationManagement.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReservationController : ControllerBase
    {

        private readonly IReservationService _reservationService;

        public ReservationController(IReservationService reservationService)
        {
            _reservationService = reservationService;
        }

        // GET: api/<ReservationController>
        [HttpGet]
        public List<ReservationDto> Get()
        {
            return _reservationService.GetAll().Select(r => new ReservationDto()
            {
                Id = r.Id,
                CarId = r.CarId,
                CustomerId = r.CustomerId,
                State = r.State
            }).ToList();
        }

        // GET api/<ReservationController>/5
        [HttpGet("{id}")]
        public ReservationDto Get(Guid id)
        {
            var reservation = _reservationService.GetById(id);
            if (reservation != null)
            {
                return new ReservationDto()
                {
                    Id = reservation.Id,
                    CustomerId = reservation.CustomerId,
                    CarId = reservation.CarId,
                    State = reservation.State,
                    Start = reservation.Start,
                    End = reservation.End
                };
            }

            return new ReservationDto();
        }

        // POST api/<ReservationController>
        [HttpPost]
        public void Post([FromBody] ReservationDto reservationDto)
        {
            var reservation = new Reservation()
            {
                Id = Guid.NewGuid(),
                CustomerId = reservationDto.CustomerId,
                CarId = reservationDto.CarId,
                State = reservationDto.State,
                Start = reservationDto.Start,
                End = reservationDto.End
            };

            _reservationService.Add(reservation);
        }

        // PUT api/<ReservationController>/5
        [HttpPut("{id}")]
        public void Put(Guid id, [FromBody] ReservationDto reservationDto)
        {
            var reservation = new Reservation()
            {
                Id = id,
                CustomerId = reservationDto.CustomerId,
                CarId = reservationDto.CarId,
                State = reservationDto.State,
                Start = reservationDto.Start,
                End = reservationDto.End
            };

            _reservationService.Update(reservation);

        }

        // DELETE api/<ReservationController>/5
        [HttpDelete("{id}")]
        public void Delete(Guid id)
        {
            _reservationService.DeleteById(id);
        }

    }
}
