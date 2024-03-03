using HotelProjectNet.EntityLayer.Concrete;
namespace HotelProjectNet.BusinessLayer.Abstract
{
    public interface IBookingService:IGenericService<Booking>
    {
        void TBookingStatusChangeApproved(Booking booking);  
        void TBookingStatusChangeApproved2(int id);
    }
}
