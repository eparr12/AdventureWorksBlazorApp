using System.ComponentModel.DataAnnotations;

namespace AdventureWorksBlazorUI.Models.DropDowns
{
    public class EmployeeFullNameUIModeI
    {
        [Required(ErrorMessage ="Must Select An Employee!")]
        public string FullName { get; set; }
    }
}
