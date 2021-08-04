using Core.Entities.Concrete;
using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IUserService
    {
        //IDataResult<List<User>> GetAll();
        //IDataResult<User> GetById(int userId);
        //IResult Add(User user);
        //IResult Update(User user);
        //IResult Delete(User user);

        List<OperationClaim> GetClaims(User user);
        void Add(User user);

        User GetByMail(string email);

    }
}
