using Berut.Entities.Concrete;
using BerutDataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BerutDataAccess.Concrete.MSSQL
{
    public class MssqlUserDal :MssqlEntityRepository<User,BerutContext>,IUserDal
    {
    }
}
