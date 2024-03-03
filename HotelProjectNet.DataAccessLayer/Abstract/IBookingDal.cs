using HotelProjectNet.EntityLayer.Concrete;

namespace HotelProjectNet.DataAccessLayer.Abstract
{
    public interface IBookingDal : IGenericDal<Booking>
    {
        void BookingStatusChangeApproved(Booking booking);
        void BookingStatusChangeApproved(int id);
    }
}
