using System.ComponentModel.DataAnnotations;

namespace AdventureWorksBlazorUI.Models
{
    public class UpdateNonSalesEmployeeUIModel : PersonUIModel
    {
        [Required(ErrorMessage ="Must Enter A Full Name!")]
        public string FullName { get; set; }

        [Required(ErrorMessage = "Must Select A Person Type!")]
        public string PersonType { get; set; }

        [Required(ErrorMessage = "Must Select A Value For Current Employee!")]
        public bool CurrentEmployee { get; set; }

        [Required(ErrorMessage = "Must Enter A Verify LoginID!")]
        [RegularExpression(@"^[0-9a-zA-Z!@#$%^&*()?]+$", ErrorMessage = "Verify Login ID Must Contain Only Numbers Letters And Approved Characters (!@#$%^&*()?)!")]
        [Compare(nameof(LoginID), ErrorMessage = "Verify Login ID Must Match Login ID!")]
        public string VerifyLoginID { get; set; }
    }
}
