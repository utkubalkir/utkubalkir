using Berut.Business.Abstract;
using Berut.Entities.Concrete;
using BerutDataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Berut.Business.Concrete
{
    public class OTInsideManager:IOTInsideService
    {
        private IOTInside _vehicleDal;
        public OTInsideManager(IOTInside vehicleDal)
        {
            _vehicleDal = vehicleDal;

        }

        public List<OTInside> GetAll()
        {
            //Business code
            return _vehicleDal.GetAll();
        }

        public void Add(OTInside oTInside)
        {
            _vehicleDal.Add(oTInside);
        }
        public void Delete(OTInside oTInside)
        {
            _vehicleDal.Delete(oTInside);

        }

        public List<OTInside> GetByPlate(string key)
        {
            if (string.IsNullOrEmpty(key))
            {
                return _vehicleDal.GetAll();
            }
            else
            {
                return _vehicleDal.GetAll(p => p.Plate.ToLower().Contains(key.ToLower()));
            }
        }

        public int VehicleCount()
        {
            return _vehicleDal.GetAll().Count();
        }
    }
}
