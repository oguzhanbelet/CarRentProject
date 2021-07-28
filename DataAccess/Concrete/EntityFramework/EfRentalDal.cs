using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfRentalDal : EfEntityRepositoryBase<Rental, CarForRentContext>, IRentalDal
    {
        public List<RentalDetailDto> GetRentalDetails()
        {
            using (CarForRentContext context = new CarForRentContext())
            {
                var result = from r in context.Rentals
                             join c in context.Cars
                             on r.CarId equals c.CarId
                             join cs in context.Customers
                             on r.CustomerId equals cs.CustomerId
                             select new RentalDetailDto { RentalId = r.RentalId, CustomerId = r.CustomerId, CarId = c.CarId, RentDate = r.RentDate, ReturnDate = r.ReturnDate };
                return result.ToList();
            }
        }
    }
}
