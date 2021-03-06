﻿using KTrackERP.Entity.KTrackERPDB;
using KTrackERP.Repository.Interface.KTrackERPDB;
using KTrackERP.Service.Interface;
using System;
using System.Collections.Generic;

namespace KTrackERP.Service
{
    public class CarService : ICarService
    {
        private readonly ICarRepository carRepository;

        public CarService(ICarRepository carRepository)
        {
            this.carRepository = carRepository;
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IList<Car> Get()
        {
            throw new NotImplementedException();
        }

        public object GetById(int id)
        {
            return carRepository.GetById(id);
        }

        public bool Insert(Car model)
        {
            return carRepository.Insert(model);
        }

        public bool Update(int id, Car model)
        {
            throw new NotImplementedException();
        }
    }
}
