namespace AdventureWorksBlazorClassLibrary.Models
{
    public class AddNonSalesEmployeeModel : PersonModel
    {
        public string Password { get; set; }
        public string Role { get; set; }
    }
}
