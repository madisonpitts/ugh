﻿using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Project2.Models
{
    public class Reservation
    {
        [Key]
        [BindNever]
        public int ReservationId { get; set; }
        [Required]
        public string GroupName { get; set; }
        [Required]
        [Range(1, 15, ErrorMessage = "The maximum group size is 15.")]
        public byte GroupSize { get; set; }
        [Required]
        public string Email { get; set; }
        public string Phone { get; set; }

        [Required]
        public TimeSlot TimeSlot { get; set; }
    }
}