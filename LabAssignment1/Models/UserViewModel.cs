using LabAssignment1.Attributes;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace LabAssignment1.Models
{
    public class UserViewModel
    {
        public UserViewModel()
        {
            Countries = ListCountry();
        }

        public List<SelectListItem> ListCountry()
        {
            List<SelectListItem> countryList = new List<SelectListItem>() {
                new SelectListItem{ Text = "India", Value = "1" },
                new SelectListItem { Text = "USA", Value = "2" },
                new SelectListItem { Text = "UK", Value = "3" },
            };
            return countryList;
        }

        [Required(ErrorMessage = "Please Enter Name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please Enter Username")]
        public string UserName { get; set; }

        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Please Enter Password")]
        [RegularExpression(@"^(?=.*\d)(?=.*[A-Z])(?=.*[@#$%^&+=]).{6,}$", ErrorMessage = "Password should be atleast six characters long and must have at least one Uppercase letter, number and special characters")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Please Enter ConfirmPassword")]
        [Compare("Password", ErrorMessage = "Password and Confirm Password doesn't match")]
        [Display(Name = "Confirm Password")]
        public string ConfirmPassword { get; set; }

        [Required(ErrorMessage = "Please Enter Contact No")]
        public string Contact { get; set; }

        [Required(ErrorMessage = "Please Select Country")]
        public string Country { get; set; }

        [Required(ErrorMessage = "Please Select City")]
        public string City { get; set; }

        [Required(ErrorMessage = "Please Select Gender")]
        public string Gender { get; set; }

        [ValidateCheckBox(ErrorMessage = "Please Accept Terms")]
        [Display(Name = "Accept Terms")]
        public bool AcceptTerms { get; set; }

        public List<SelectListItem> Countries { get; set; }

        public List<SelectListItem> GetCityByCountryId(int countryId)
        {
            List<SelectListItem> cityList = new List<SelectListItem>();

            if (countryId == 1)
            {
                cityList = new List<SelectListItem>()
                {
                    new SelectListItem{Text="Delhi", Value = "1" }  ,
                    new SelectListItem{Text="Mumbai", Value = "2" }  ,
                    new SelectListItem{Text="Pune", Value = "3" }
                };
            }
            else if (countryId == 2)
            {
                cityList = new List<SelectListItem>()
                {
                    new SelectListItem{Text="Washington", Value="1"},
                    new SelectListItem{Text="New York", Value="2"}
                };
            }
            else if (countryId == 3)
            {
                cityList = new List<SelectListItem>()
                {
                    new SelectListItem{Text="London", Value="1"},
                    new SelectListItem{Text="England", Value="2"}
                };
            }
            return cityList;
        }
    }
}
