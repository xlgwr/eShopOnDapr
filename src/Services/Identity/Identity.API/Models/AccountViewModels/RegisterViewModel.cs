using Identity.API.ResourcesCus;
using System.ComponentModel.DataAnnotations;

namespace Microsoft.eShopOnContainers.Services.Identity.API.Models.AccountViewModels
{
    public class RegisterViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        //[Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        [Compare("Password", ErrorMessageResourceType = typeof(Resource), ErrorMessageResourceName = "MobileRequire")]
        //[Required(ErrorMessageResourceType = typeof(IdentityServer4.Models.ErrorMessage), ErrorMessageResourceName = "MobileRequire")]
        [Display(Name = "Confirm password", ResourceType = typeof(Resource))]

        public string ConfirmPassword { get; set; }

        public ApplicationUser User { get; set; }
    }
}
