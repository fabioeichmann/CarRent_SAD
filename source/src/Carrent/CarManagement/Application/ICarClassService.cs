﻿using Carrent.CarManagement.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Carrent.CarManagement.Application
{
    public interface ICarClassService
    {
        List<CarClass> GetAllClasses();
        List<CarClass> GetClassById(Guid id);
        void Add(CarClass carClass);
        void Delete(CarClass carClass);
        void DeleteById(Guid id);
        void Update(CarClass carClass);
    }
}