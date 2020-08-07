using System;
using System.ComponentModel.DataAnnotations;

namespace FormSubmission.Models
{
    public class User
    {
        [Required(ErrorMessage = "First Name is required")]
        [MinLength(4, ErrorMessage = "Must be 4 characters minimum")]
        [Display(Name = "First Name: ")]
        [DataType(DataType.Text)]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last Name is required")]
        [MinLength(4, ErrorMessage = "Must be 4 characters minimum")]
        [Display(Name = "Last Name: ")]
        [DataType(DataType.Text)]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Age is required")]
        [Range(0, 1000, ErrorMessage = "Age must be a positive number")]
        [Display(Name = "Age: ")]
        public int Age { get; set; }

        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Must be valid email address")]
        [Display(Name = "Email: ")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password is required")]
        [MinLength(8, ErrorMessage = "Must be 8 characters minimum")]
        [Display(Name = "Password: ")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        // public User(string fName, string lName, int age, string email, string pw)
        // {
        //     FirstName = fName;
        //     LastName = lName;
        //     Age = age;
        //     Email = email;
        //     Password = pw;
        // }
    }
}