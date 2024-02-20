using System.ComponentModel.DataAnnotations;

namespace HotelProject.WebUI.Dtos.ServiceDto
{
    public class CreateServiceDto
    {

        [Required(ErrorMessage = "Servis ikon linki giriniz")]
        public string ServiceIcon { get; set; }

        [Required(ErrorMessage = "Hizmet başlığı  giriniz")]
        public string Title { get; set; }
        [StringLength(100, ErrorMessage = "Hizmet başlığı en fazla 100 karakter olabilir")]

        public string Description { get; set; }

    }
}
