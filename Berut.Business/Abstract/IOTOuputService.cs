using Berut.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Berut.Business.Abstract
{
    public interface IOTOuputService
    {
        List<OTOutput> GetByPlate(string key);
        List<OTOutput> GetByDate(string date1,string date2);
        List<OTOutput> GetAll();
        void Add(OTOutput oTInside);
        string DummyWeight();
        
    }
}
