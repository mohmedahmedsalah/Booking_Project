﻿using System.ComponentModel.DataAnnotations.Schema;

namespace Booking_Project.Models
{
    public class Amenities_Hotel
    {
        public int Id { get; set; }
        [Column(TypeName = "money")]
        public decimal Price { get; set; }
        [ForeignKey("hotel")]
        public int HotelId { get; set; }
        public virtual Hotel? hotel { get; set; }
        [ForeignKey("amenities")]
        public int AmentiesId { get; set; }
        public virtual Amenities? amenities { get; set; }


    }
}