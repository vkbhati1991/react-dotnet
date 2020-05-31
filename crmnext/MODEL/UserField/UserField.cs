using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL.UserField
{
    public class UserField
    {
        [Required]
        [StringLength(100)]
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        [Required]
        [StringLength(100)]
        public string LastName { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Phone { get; set; }
        public string DOB { get; set; }
        public string DobInText { get; set; }
        public string Gender { get; set; }
        public string Photo { get; set; }
        public string HandiCapped { get; set; }
        public string BloodGroup { get; set; }
        public string Regigion { get; set; }
        public string Category { get; set; }
        public string AadharNo { get; set; }
        public string BankAccountNumber { get; set; }
        public string BankName { get; set; }
        public string BankIFSCCode { get; set; }
        public string FatherFirstName { get; set; }
        public string FatherMiddleName { get; set; }
        public string FatheLastName { get; set; }
        public string MotherFirstName { get; set; }
        public string MotherMiddleName { get; set; }
        public string MotherLastName { get; set; }
        public string AddressOne { get; set; }
        public string AddressTwo { get; set; }
        public string Block { get; set; }
        public string PinCode { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string LandMark { get; set; }
        public string PermAddressOne { get; set; }
        public string PermAddressTwo { get; set; }
        public string PermBlock { get; set; }
        public string PermPinCode { get; set; }
        public string PermCity { get; set; }
        public string PermState { get; set; }
        public string PermCountry { get; set; }
        public string PermLandMark { get; set; }
        public string CreatedOn { get; set; }
        public string Role { get; set; }
        public int IsActive { get; set; }
    }
}
