﻿using HotelProjectNet.BusinessLayer.Abstract;
using HotelProjectNet.DataAccessLayer.Abstract;
using HotelProjectNet.EntityLayer.Concrete;

namespace HotelProjectNet.BusinessLayer.Concrete
{
    public class TestimonialManager : ITestimonialService
    {
        private readonly ITestimonialDal _testimonialDal;

        public TestimonialManager(ITestimonialDal testimonialDal)
        {
            _testimonialDal = testimonialDal;
        }

        void IGenericService<Testimonial>.TDelete(Testimonial t)
        {
            _testimonialDal.Delete(t);
        }

        Testimonial IGenericService<Testimonial>.TGetByID(int id)
        {
            return _testimonialDal.GetByID(id);
        }

        List<Testimonial> IGenericService<Testimonial>.TGetList()
        {

            return _testimonialDal.GetList();
        }

        void IGenericService<Testimonial>.TInsert(Testimonial t)
        {
            _testimonialDal.Insert(t);
        }

        void IGenericService<Testimonial>.TUpdate(Testimonial t)
        {
            _testimonialDal.Update(t);
        }
    }
}
