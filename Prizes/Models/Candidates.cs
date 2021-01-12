using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Prizes.Models
{
    public class Candidates
    {
        public string CandidateId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string NationalityId { get; set; }
    }

    [BindProperties]
    public class CandidatesModel
    {
        [Required(ErrorMessage = "Name required")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Email required")]
        [EmailAddress(ErrorMessage ="Valid email address required")]
        public string Email { get; set; }
        [Required(ErrorMessage = "DateOfBirth required")]
        public string DateOfBirth { get; set; }
        [Required(ErrorMessage = "PhoneNumber required")]
        [Phone(ErrorMessage = "Valid phone number required")]
        public string PhoneNumber { get; set; }
        [Required(ErrorMessage = "Nationality required")]
        public string NationalityId { get; set; }
    }
}
