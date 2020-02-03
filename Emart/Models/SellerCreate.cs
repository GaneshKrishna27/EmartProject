using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Emart.Models
{
    public class SellerCreate
    {
        [Key]
        [Required(ErrorMessage = "Please Enter Valid Id")]
        [DisplayName("Seller ID")]
        public int Sid { get; set; }
        [Required(ErrorMessage = "Please Enter Name")]
        [DisplayName("Seller Name")]
        [StringLength(maximumLength: 20, MinimumLength = 4, ErrorMessage = "Please Enter Valid Name")]
        public string Sname { get; set; }
        [DataType("Password")]
        [DisplayName("Password")]
        [Required(ErrorMessage = "Please Enter Valid Password")]
        [RegularExpression("[a-z0-9]{6,8}", ErrorMessage = "use 6 to 8 letters")]
        public string Spwd { get; set; }
        [Required(ErrorMessage = "Please Enter CompanyName")]
        public string Companyname { get; set; }
        [Required(ErrorMessage = "Please Enter Mail")]
        [EmailAddress(ErrorMessage = "Please Enter Valid ")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Please Enter Gstin")]
        public double Gstin { get; set; }
        [Required(ErrorMessage = "Please Enter Bank_Details")]
        public string Bank_Details { get; set; }
        [Required(ErrorMessage = "Please Enter Postal_Address")]
        public string Postal_Address { get; set; }
        [RegularExpression(@"[6-9]\d{9}", ErrorMessage = "Please Enter Valid Mobile no")]
        public string Mobile { get; set; }
        public IFormFile Photopath { get; set; }
    }
}
