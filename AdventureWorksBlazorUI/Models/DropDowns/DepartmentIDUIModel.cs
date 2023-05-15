using System.ComponentModel.DataAnnotations;

namespace AdventureWorksBlazorUI.Models.DropDowns
{
    public class DepartmentIDUIModel
    {
        [Required(ErrorMessage ="Must Select A Department!")]
        public string Name { get; set; }
    }
}
