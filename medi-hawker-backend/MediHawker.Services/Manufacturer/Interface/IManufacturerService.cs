using System;
using System.Collections.Generic;
using System.Text;
using MediHawker.Data;
using MediHawker.Data.Custom_Models;

namespace MediHawker.Services.Manufacture.Interface
{
    public interface IManufacturerService
    {
         List<Manufacturer> getAllManufacturer();

    }
}
