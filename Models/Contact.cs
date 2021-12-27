using Microsoft.AspNetCore.Http;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WhatsYourAddy.Models
{
    public class Contact
    {
        // name and contact

        [Required] // To make the feild required
        [Display(Name = "First Name")] // Adding the String label to display on hte form.
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Display(Name = "Phone Number")]
        [DataType(DataType.PhoneNumber)]
        public int PhoneNumber { get; set; }

        // Addressing
        [Display(Name = "Address 1")]
        public string Address1 { get; set; }

        [Display(Name = "Address 2")]
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }

        [Display(Name = "Postal Code")]
        [DataType(DataType.PostalCode)] // ading the correct DataType to the feild
        public string PostalCode { get; set; }

        // Extra
        public DateTime Date { get; set; }

        // Image File using I form file
        [NotMapped]
        [Display(Name = "Image")]
        [DataType(DataType.Upload)]
        public  IFormFile ImageFile { get; set; }
        public byte[] ImageData { get; set; }
        public string ImageType { get; set; }

        // DB Id - Primary Key
        public int Id { get; set; }

        // Full Name function - using NotMapped so it is not made into a db colum 
        [NotMapped]
        public string FullName
        {
            get { return $"{FirstName} {LastName}"; }
        }
    }
}
