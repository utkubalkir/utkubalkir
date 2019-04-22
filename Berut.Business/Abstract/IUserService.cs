using Berut.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Berut.Business.Abstract
{
    public interface IUserService
    {
        
        int Login(User User);
        
        
    }
}
