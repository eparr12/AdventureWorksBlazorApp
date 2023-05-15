using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace AdventureWorksBlazorUI.Models
{
    public class AddNonSalesEmployeeUIModel : PersonUIModel
    {
        [Required(ErrorMessage ="Must Enter Verify Login!")]
        [RegularExpression(@"^[0-9a-zA-Z!@#$%^&*()?]+$", ErrorMessage = "Verify Login ID Must Contain Only Numbers Letters And Approved Characters (!@#$%^&*()?)!")]
        [Compare(nameof(LoginID),ErrorMessage = "Verify Login ID Must Match Login ID!")]
        public string VerifyLoginID { get; set; }

        [Required(ErrorMessage ="Must Enter A Password!")]
        [RegularExpression(@"^[0-9a-zA-Z!@#$%^&*()?]+$", ErrorMessage = "Password Must Contain Only Numbers Letters And Approved Characters (!@#$%^&*()?)!")]
        public string Password { get; set; }

        [Required(ErrorMessage ="Must Enter Verify Password!")]
        [RegularExpression(@"^[0-9a-zA-Z!@#$%^&*()?]+$", ErrorMessage = "Verify Password Must Contain Only Numbers Letters And Approved Characters (!@#$%^&*()?)!")]
        [Compare(nameof(Password), ErrorMessage = "Verify Password Must Match Password!")]
        public string VerifyPassword { get; set; }

        [Required(ErrorMessage = "Must Select A Role!")]
        public string Role { get; set; }
    }
}
