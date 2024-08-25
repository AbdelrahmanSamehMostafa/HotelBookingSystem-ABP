using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using HotelBookingSystem_Abp.Reviews;
using Volo.Abp.Application.Dtos;

namespace HotelBookingSystem_Abp.Customers
{
    public class CustomerInputDto : EntityDto
    {
        [Required]
        [StringLength(50, ErrorMessage = "First Name cannot exceed 50 characters.")]
        public required string FirstName { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "Last Name cannot exceed 50 characters.")]
        public required string LastName { get; set; }

        [Required]
        [EmailAddress(ErrorMessage = "Invalid Email Address format.")]
        [StringLength(100, ErrorMessage = "Email cannot exceed 100 characters.")]
        public required string Email { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 8, ErrorMessage = "Password must be between 8 and 100 characters.")]
        [DataType(DataType.Password)]
        public required string Password { get; set; }

        public bool IsEmailVerified { get; set; }

        public List<string>? Wishlists { get; set; }

        public List<ReviewInputDto>? Reviews { get; set; }
    }
}