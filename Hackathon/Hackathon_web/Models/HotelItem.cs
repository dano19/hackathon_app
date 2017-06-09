using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hackathon_web.Models
{

    public enum DisabilityType
    {
          
    }

    public enum Rate {
        Poor,
        Fair, 
        Good,
        Very_Good,
        Excellent
    }

    public enum FacilitiesType
    {
    }



    public class HotelItem
    {
        public Dictionary<DisabilityType, Rate> DisabilityAndRateMap { get; set; }
        public String Name { get; set; }
        public String UrlToPicture { get; set; }
        public Rate HotelRate { get; set; }
        public Double Price { get; set; }
        public String Address { get; set; }
        public Dictionary<FacilitiesType, String> facilitiesAndIcon { get; set; }

    }

    
}