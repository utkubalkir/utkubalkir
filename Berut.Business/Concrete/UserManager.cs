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
    public class UserManager:IUserService
    {
        private IUserDal _userDal;
        public UserManager(IUserDal userdal)
        {
            _userDal = userdal;

        }

        

        public int Login(User user)
        {


            return _userDal.GetAll(p => p.UserName == user.UserName && p.Password == user.Password).Count();
        }

       /* public void Logout()
        {

        }*/

    }
}
