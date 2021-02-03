using MediHawker.Data;
using MediHawker.Repositories.Manufacture.Interface;
using MediHawker.Services.Manufacture.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace MediHawker.Services.Manufacture.Implementation
{
   public class ManufacturerService:IManufacturerService
    {
        private readonly IManufacturerRepository _manufacturerRepository;
        public ManufacturerService(IManufacturerRepository manufacturerRepository)
        {
            _manufacturerRepository = manufacturerRepository;
        }
        public List<Manufacturer> getAllManufacturer()
        {
            return _manufacturerRepository.getAllManufacturer();

        }
    }
}
