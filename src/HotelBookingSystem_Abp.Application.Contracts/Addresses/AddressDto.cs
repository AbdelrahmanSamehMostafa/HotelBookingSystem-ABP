using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;

namespace HotelBookingSystem_Abp.Addresses
{
    public class AddressDto : EntityDto
    {
        [Required]
        [StringLength(128)]
        public string City { get; set; }

        [Required]
        [StringLength(128)]
        public string Country { get; set; }

        public AddressDto(string city, string country)
        {
            City = city;
            Country = country;
        }

        // Parameterless constructor for deserialization
        public AddressDto() { }
    }
}