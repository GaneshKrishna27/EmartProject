using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Emart.Models
{
    public class Buyer
    {
        [Key]
        [Required(ErrorMessage = "Please Enter Valid Id")]
        [DisplayName("Buyer ID")]
        public int Bid { get; set; }
        [DisplayName("Buyer Name")]
        [Required(ErrorMessage = "Please Enter Name")]
        [StringLength(maximumLength: 20, MinimumLength = 4, ErrorMessage = "Please Enter Valid Name")]
        public string Bname { get; set; }
        [DataType("Password")]
        [DisplayName("Password")]
        [Required(ErrorMessage = "Please Enter Valid Password")]
        [RegularExpression("[a-z0-9]{6,8}",ErrorMessage ="use 6 to 8 letters")]
        public string Bpwd { get; set; }
        [Required(ErrorMessage = "Please Enter Mail")]
        [EmailAddress(ErrorMessage = "Please Enter Valid ")]
        public string Email { get; set; }
        [RegularExpression(@"[6-9]\d{9}", ErrorMessage = "Please Enter Valid Mobile no")]
        public string Mobile { get; set; }
        [Required(ErrorMessage = "Please Enter DateTime")]
        public DateTime DateTime { get; set; }
    }
}
