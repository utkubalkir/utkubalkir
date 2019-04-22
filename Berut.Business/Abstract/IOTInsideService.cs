using Berut.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Berut.Business.Abstract
{
    public interface IOTInsideService
    {
        List<OTInside> GetByPlate(string key);
        List<OTInside> GetAll();
        void Add(OTInside oTInside);
        void Delete(OTInside oTInside);
        int VehicleCount();
    }
}
