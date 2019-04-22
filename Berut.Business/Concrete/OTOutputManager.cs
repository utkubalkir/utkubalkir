using Berut.Business.Abstract;
using Berut.Entities.Concrete;
using BerutDataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Berut.Business.Concrete
{
   public class OTOutputManager: IOTOuputService
    {
        private IOTOutput _vehicleDal;
        public OTOutputManager(IOTOutput vehicleDal)
        {
            _vehicleDal = vehicleDal;

        }

        public void Add(OTOutput oTOutput)
        {
            _vehicleDal.Add(oTOutput);
        }

       

        public List<OTOutput> GetAll()
        {
            return _vehicleDal.GetAll();
        }

        public string DummyWeight()
        {
            SerialPort serial = new SerialPort("COM3",
           9600, Parity.None, 8, StopBits.One);


            serial.Open();
            serial.DtrEnable = true;

            string DummyWeight = serial.ReadLine();
           
            serial.Close();

            return DummyWeight;
        }

        public List<OTOutput> GetByDate(string date1,string date2)
        {
            DateTime x = Convert.ToDateTime(date1);
            DateTime y = Convert.ToDateTime(date2);

            return _vehicleDal.GetAll(p => p.EntryDate >= x && p.ReleaseDate <= y);
            
        }

        public List<OTOutput> GetByPlate(string key)
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
    }
}
