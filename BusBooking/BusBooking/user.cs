//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BusBooking
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class user
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public user()
        {
            this.transactions = new HashSet<transaction>();
        }
        public int user_id { get; set; }

        [Required(ErrorMessage = "Please Enter Name ")]
        [Display(Name = "Name")]
        [StringLength(50, ErrorMessage = "name should be Max length of 50")]
        public string name { get; set; }

        [Required(ErrorMessage = "Please Enter Email Address")]
        [Display(Name = "Email")]
        [RegularExpression("^([\\w\\.\\-]+)@([\\w\\-]+)((\\.(\\w){2,3})+)$", ErrorMessage = "Please Enter Correct Email Address")]
        public string email { get; set; }

        [Required(ErrorMessage = "Please enter Phone Number")]
        [Display(Name = "Phone Number")]
        [StringLength(11, ErrorMessage = "Phone Number should be maximum of 10", MinimumLength = 10)]
        [RegularExpression("^\\(?([0-9]{3})\\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Please Enter Correct Phone Number")]

        public string contact { get; set; }
        [Required(ErrorMessage = "Please Enter Apartment Number")]
        [Display(Name = "Apt#")]
        public string apt_number { get; set; }

        [Required(ErrorMessage = "Please Enter Street Number")]
        [Display(Name = "Street#")]
        public string street_number { get; set; }

        [Required(ErrorMessage = "Please Enter City")]
        [Display(Name = "City")]
        public string city { get; set; }

        [Required(ErrorMessage = "Please Enter Province/State")]
        [Display(Name = "Province/State")]
        public string state { get; set; }

        [Required(ErrorMessage = "Please Enter Country")]
        [Display(Name = "Country")]
        public string country { get; set; }

        [Required(ErrorMessage = "Please Enter Postal Code")]
        [Display(Name = "Postal Code")]
        [RegularExpression("[ABCEGHJKLMNPRSTVXY][0-9][ABCEGHJKLMNPRSTVWXYZ][0-9][ABCEGHJKLMNPRSTVWXYZ][0-9]", ErrorMessage = "Please Enter Valid Postal Code")]
        public string postal_Code { get; set; }

        [Required(ErrorMessage = "Please Enter Password")]
        [Display(Name = "Password")]
        [DataType(DataType.Password)]
        public string password { get; set; }

        [Required(ErrorMessage = "Please Choose a Role")]
        [Display(Name = "Role")]
        public string role { get; set; }


        [NotMapped]
        [Required(ErrorMessage = "Please Enter Confirm Password")]
        [Display(Name = "Confirm Password")]
        [DataType(DataType.Password)]
        [Compare(nameof(password), ErrorMessage = "Password and confirm Password do not match")]
        public string confirmPassword { get; set; }

        [NotMapped]
        public string loginErrorMessage { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<transaction> transactions { get; set; }
    }
}
