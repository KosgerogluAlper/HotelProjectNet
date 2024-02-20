using HotelProjectNet.DataAccessLayer.Abstract;
using HotelProjectNet.DataAccessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProjectNet.DataAccessLayer.Repositories
{
    public class GenericRepository<T> : IGenericDal<T> where T : class
    {

        private readonly Context _context;

        public GenericRepository(Context context)
        {
            _context = context;
        }

        void IGenericDal<T>.Delete(T t)
        {
            _context.Remove(t);
            _context.SaveChanges();
        }

        T IGenericDal<T>.GetByID(int id)
        {
            return _context.Set<T>().Find(id);
        }

        List<T> IGenericDal<T>.GetList()
        {
            return _context.Set<T>().ToList();
        }

        void IGenericDal<T>.Insert(T t)
        {
            _context.Add(t);
            _context.SaveChanges();
        }

        void IGenericDal<T>.Update(T t)
        {
            _context.Update(t);
            _context.SaveChanges();
        }


    }
}
