using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Web;

namespace Conference.Models
{
    [Serializable]
    [XmlRoot("Users"), XmlType("Users")]
    public class Users
    {
        [Required]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "A valid first name is required.")]
        public string FirstName { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "A valid last name is required.")]
        public string LastName { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "A company or institution name is required.")]
        public string Institution { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "A company or institution name is required.")]
        public string Country { get; set; }

        [Required]
        public string SocialEvents { get; set; }

        [Required]
        [StringLength(50)]
        [EmailAddress(ErrorMessage = "A valid email address is required.")]
        public string Email { get; set; }
    }
}