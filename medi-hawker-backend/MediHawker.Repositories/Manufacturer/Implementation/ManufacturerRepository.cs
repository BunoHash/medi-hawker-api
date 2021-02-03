using MediHawker.Data;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using MediHawker.Repositories.Manufacture.Interface;

namespace MediHawker.Repositories.Manufacture.Implementation
{
    public class ManufacturerRepository:IManufacturerRepository
    {
        private readonly MedihawkerDbContext _context;
        public ManufacturerRepository(MedihawkerDbContext context)

        {
            _context = context;
        }
        public List<Manufacturer> getAllManufacturer()
        {

            List<Manufacturer> manufacturer = (from x in _context.Manufacturer select x).ToList();
            return manufacturer;
        }
    }
}
