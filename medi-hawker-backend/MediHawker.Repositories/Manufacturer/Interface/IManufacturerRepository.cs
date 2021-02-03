using System;
using System.Collections.Generic;
using System.Text;
using MediHawker.Data;
using MediHawker.Data.Custom_Models;

namespace MediHawker.Repositories.Manufacture.Interface
{
   public interface IManufacturerRepository
    {
        List<Manufacturer> getAllManufacturer();
    }
}
