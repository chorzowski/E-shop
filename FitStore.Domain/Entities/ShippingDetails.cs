using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace FitStore.Domain.Entities
{
   public class ShippingDetails
    {
        [Required(ErrorMessage ="Prosze podać nazwisko.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Prosze podać pierwszy wiersz adresu.")]
        public string Line1 { get; set; }
        public string Line2 { get; set; }
        public string Line3 { get; set; }

        [Required(ErrorMessage = "Prosze podać nazwe miasta.")]
        public string City { get; set; }

        [Required(ErrorMessage = "Prosze podać nazwe województwa.")]
        public string State { get; set; }

        public string Zip { get; set; }

        [Required(ErrorMessage = "Prosze podać nazwe kraju.")]
        public string Country { get; set; }

        public bool GiftWrap { get; set; }
    }
}
