﻿using System;
using System.ComponentModel.DataAnnotations;

namespace VidlyNet48.Presentation.Models
{
    public class Customer
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter customer's name!")]
        [StringLength(255)]
        public string Name { get; set; }

        public bool IsSubscribedToNewsletter { get; set; }

        public MembershipType MembershipType { get; set; }

        [Display(Name = "Membership Type")]
        public int MembershipTypeId { get; set; }

        [Display(Name = "Data of Birth")]
        [Min18YearsIfMember]
        public DateTime? Birthdate { get; set; }
    }
}