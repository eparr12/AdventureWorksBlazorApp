using AdventureWorksBlazorClassLibrary.Models.DropDowns;

namespace AdventureWorksBlazorClassLibrary.Data
{
    public interface IDropDownData
    {
        Task<List<DepartmentIDModel>> GetDepartmentIDs();
        Task<List<EmployeeFullNameModel>> GetNonSalesEmployeeFullNames();
        Task<List<StateProvinceIDModel>> GetStateProvinceIDs();
    }
}