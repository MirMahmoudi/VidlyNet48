using System;
using System.ComponentModel.DataAnnotations;

namespace VidlyNet48.Presentation.Models
{
    public class Customer
    {
        public int Id { get; set; }

        [Required, StringLength(255)]
        public string Name { get; set; }
        public bool IsSubscribedToNewsletter { get; set; }
        public MembershipType MembershipType { get; set; }
        public int MembershipTypeId { get; set; }
        public DateTime? Birthdate { get; set; }
    }
}