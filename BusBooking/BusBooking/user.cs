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
        [StringLength(50, ErrorMessage = "name should be Max length of 50")]
        public string name { get; set; }

        [Required(ErrorMessage = "Please Enter Email Address")]
        [RegularExpression(".+@.+\\..+", ErrorMessage = "Please Enter Correct Email Address")]
        public string email { get; set; }

        [StringLength(10, ErrorMessage = "Contact should be Max length of 10")]
        public string contact { get; set; }

        [StringLength(10, ErrorMessage = "Apartment number should be Max length of 10")]
        public string apt_number { get; set; }

        [StringLength(10, ErrorMessage = "Street Number should be Max length of 10")]
        public string street_number { get; set; }

        [StringLength(10, ErrorMessage = "City should be Max length of 10")]
        public string city { get; set; }

        [StringLength(10, ErrorMessage = "State should be Max length of 10")]
        public string state { get; set; }

        [StringLength(10, ErrorMessage = "Country should be Max length of 10")]
        public string country { get; set; }

        [StringLength(10, ErrorMessage = "Postal Code should be Max length of 10")]
        public string postal_Code { get; set; }

        [Required(ErrorMessage = "Please Enter Password")]
        public string password { get; set; }

        public string role { get; set; }

        [NotMapped]
        [Required(ErrorMessage = "Please Enter Confirm Password")]
        [Compare(nameof(password), ErrorMessage = "Password and confirm Password do not match")]
        public string confirmPassword { get; set; }

        [NotMapped]
        public string loginErrorMessage { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<transaction> transactions { get; set; }
    }
}
