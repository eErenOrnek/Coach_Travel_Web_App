using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Coach_Travel_Web_App.Models
{
    public class UserDetailsModel
    {
        public string UserId { get; set; }
        [Required(ErrorMessage ="This field can not be empty.")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "This field can not be empty.")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "This field can not be empty.")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "This field can not be empty.")]
        [DataType(DataType.EmailAddress, ErrorMessage = "Please enter a valid e-mail address.")]
        public string Email { get; set; }
        public bool EmailConfirmed { get; set; }
        public IEnumerable<string> SelectedRoles { get; set; }
    }
}
