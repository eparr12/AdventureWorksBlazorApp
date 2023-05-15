using System.ComponentModel.DataAnnotations;

namespace AdventureWorksBlazorUI.Models.DropDowns
{
    public class StateProvinceIDUIModel
    {
        [Required(ErrorMessage = "Must Select A State Or Province!")]
        public string Name { get; set; }
    }
}
