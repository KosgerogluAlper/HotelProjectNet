﻿using HotelProjectNet.BusinessLayer.Abstract;
using HotelProjectNet.DataAccessLayer.Abstract;
using HotelProjectNet.EntityLayer.Concrete;
namespace HotelProjectNet.BusinessLayer.Concrete
{


    public class ServiceManager : IServiceService
    {
        private readonly IServicesDal _servicesDal;

        public ServiceManager(IServicesDal servicesDal)
        {
            _servicesDal = servicesDal;
        }

        public void TDelete(Service t)
        {
            _servicesDal.Delete(t);
        }

        public Service TGetByID(int id)
        {
            return _servicesDal.GetByID(id);
        }

        public List<Service> TGetList()
        {
            return _servicesDal.GetList();
        }

        public void TInsert(Service t)
        {
            _servicesDal.Insert(t);
        }

        public void TUpdate(Service t)
        {
            _servicesDal.Update(t);
        }
    }
}
