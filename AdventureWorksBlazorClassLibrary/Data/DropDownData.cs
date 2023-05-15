using AdventureWorksBlazorClassLibrary.DataAccess;
using AdventureWorksBlazorClassLibrary.Models.DropDowns;

namespace AdventureWorksBlazorClassLibrary.Data
{
    public class DropDownData : IDropDownData
    {
        private readonly ISqlDataAccess _db;
        public DropDownData(ISqlDataAccess db)
        {
            _db = db;
        }

        public Task<List<EmployeeFullNameModel>> GetNonSalesEmployeeFullNames() =>
        _db.LoadData<EmployeeFullNameModel, dynamic>("SP_DropdownNonSalesemployeeFullName", new { });

        public Task<List<StateProvinceIDModel>> GetStateProvinceIDs() =>
        _db.LoadData<StateProvinceIDModel, dynamic>("SP_DropdownStateProvinceIDs", new { });

        public Task<List<DepartmentIDModel>> GetDepartmentIDs() =>
        _db.LoadData<DepartmentIDModel, dynamic>("SP_DropdownDepartmentIDs", new { });

    }
}
