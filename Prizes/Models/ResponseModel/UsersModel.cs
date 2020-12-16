using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Prizes.Models.ResponseModel
{
    public class UsersModel
    {
        [Required(ErrorMessage = "Full name field is required.")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Email field is required.")]
        public string Email { get; set; }
        //[Required(ErrorMessage = "Date of birth field is required.")]
        public DateTime? DateOfBirth { get; set; }
        [Required(ErrorMessage = "Phone number field is required.")]
        public string PhoneNumber { get; set; }
        //[Required(ErrorMessage = "Nationality field is required.")]
        public int? NationalityId { get; set; }
    }
}
