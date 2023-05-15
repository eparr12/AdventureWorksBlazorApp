using AdventureWorksBlazorClassLibrary.Models;

namespace AdventureWorksBlazorClassLibrary.Data
{
    public interface INonSalesEmployeeData
    {
        Task AddNonSalesEmployee(AddNonSalesEmployeeModel employee);
        Task DeleteNonSalesEmployee(string fullName);
        Task<NonSalesEmployeeInformationModel?> GetNonSalesEmployee(string employeeFullName);
        Task<List<NonSalesEmployeeInformationModel>> GetNonSalesEmployees();
        Task UpdateNonSalesEmployee(UpdateNonSalesEmployeeModel employee);
    }
}