using HotelProjectNet.DataAccessLayer.Abstract;
using HotelProjectNet.DataAccessLayer.Concrete;
using HotelProjectNet.DataAccessLayer.Repositories;
using HotelProjectNet.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProjectNet.DataAccessLayer.EntityFramework
{
    public class EfServiceDal : GenericRepository<Service>, IServicesDal
    {
        public EfServiceDal(Context context) : base(context) { }

    }

}
