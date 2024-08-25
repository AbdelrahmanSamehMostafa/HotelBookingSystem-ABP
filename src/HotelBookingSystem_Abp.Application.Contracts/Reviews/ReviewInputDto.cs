using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;

namespace HotelBookingSystem_Abp.Reviews
{
    public class ReviewInputDto : EntityDto
    {
        [Required]
        [StringLength(500, ErrorMessage = "The comment cannot exceed 500 characters.")]
        public string Comment { get; set; }

        [Required]
        [Range(1, 5, ErrorMessage = "The rating must be between 1 and 5.")]
        public int Rating { get; set; }

        [Required]
        public DateTime Date { get; set; } = DateTime.Now;

        [Required]
        public Guid CustomerId { get; set; }

        [Required]
        public Guid HotelId { get; set; }
    }
}