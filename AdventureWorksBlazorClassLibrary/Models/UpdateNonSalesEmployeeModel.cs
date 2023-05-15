namespace AdventureWorksBlazorClassLibrary.Models
{
    public class UpdateNonSalesEmployeeModel : PersonModel
    {
        public string FullName { get; set; }
        public string PersonType { get; set; }
        public bool CurrentEmployee { get; set; }
    }
}
