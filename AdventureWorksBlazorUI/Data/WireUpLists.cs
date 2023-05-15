using AdventureWorksBlazorClassLibrary.Data;
using AdventureWorksBlazorClassLibrary.DataAccess;
using AdventureWorksBlazorClassLibrary.Models;
using AdventureWorksBlazorClassLibrary.Models.DropDowns;
using AdventureWorksBlazorUI.Models.DropDowns;
using AutoMapper;

namespace AdventureWorksBlazorUI.Data
{
    public class WireUpLists
    {
        private ISqlDataAccess _da;
        private IDropDownData _db;
        private IMapper _mapper;
        List<EmployeeFullNameModel> _libraryFullNameList = new();
        List<StateProvinceIDModel> _libraryStateProvinceList = new();
        List<DepartmentIDModel> _libraryDepartmentList = new();

        public WireUpLists(ISqlDataAccess da, IDropDownData db, IMapper mapper)
        {
            _da = da;
            _db = db;
            _mapper = mapper;
        }

        public async Task<List<EmployeeFullNameUIModeI>>  EmployeeFullNameList()
        {
            List<EmployeeFullNameUIModeI> employeeFullName = new();

            try
            {
                _libraryFullNameList = await _db.GetNonSalesEmployeeFullNames();

                var r = _mapper.Map<List<EmployeeFullNameUIModeI>>(_libraryFullNameList);
                foreach (EmployeeFullNameUIModeI e in r)
                {
                    employeeFullName.Add(e);
                }

                return employeeFullName;
            }
            catch (Exception e)
            {
                var ex = e.Message;
                throw;
            }
        }

        public async Task<List<StateProvinceIDUIModel>> StateProvinceIDList()
        {
            List<StateProvinceIDUIModel> stateProvinceList = new();

            try
            {
                _libraryStateProvinceList = await _db.GetStateProvinceIDs();

                var r = _mapper.Map<List<StateProvinceIDUIModel>>(_libraryStateProvinceList);
                foreach (StateProvinceIDUIModel s in r)
                {
                    stateProvinceList.Add(s);
                }

                return stateProvinceList;
            }
            catch (Exception e)
            {
                var ex = e.Message;
                throw;
            }
        }

        public async Task<List<DepartmentIDUIModel>> DepartmentIDList()
        {
            List<DepartmentIDUIModel> departmentIDList = new();

            try
            {
                _libraryDepartmentList = await _db.GetDepartmentIDs();

                var r = _mapper.Map<List<DepartmentIDUIModel>>(_libraryDepartmentList);
                foreach (DepartmentIDUIModel d in r)
                {
                    departmentIDList.Add(d);
                }

                return departmentIDList;
            }
            catch (Exception e)
            {
                var ex = e.Message;
                throw;
            }
        }
        public List<string> TitleList()
        {
            List<string> title = new();

            title.Add("");
            title.Add("Mr.");
            title.Add("Mrs.");
            title.Add("Ms.");

            return title;
        }

        public List<string> SuffixList()
        {
            List<string> suffix = new();

            suffix.Add("");
            suffix.Add("I");
            suffix.Add("II");
            suffix.Add("III");
            suffix.Add("IV");
            suffix.Add("Jr.");
            suffix.Add("PhD");
            suffix.Add("Sr.");

            return suffix;
        }

        public List<string> PhoneNumberTypeList()
        {
            List<string> phoneNumberType = new();

            phoneNumberType.Add("");
            phoneNumberType.Add("Cell");
            phoneNumberType.Add("Home");
            phoneNumberType.Add("Work");

            return phoneNumberType;
        }

        public List<string> AddressTypeIDList()
        {
            List<string> addressTypeID = new();

            addressTypeID.Add("");
            addressTypeID.Add("Archive");
            addressTypeID.Add("Billing");
            addressTypeID.Add("Home");
            addressTypeID.Add("Main Office");
            addressTypeID.Add("Primary");
            addressTypeID.Add("Shipping");

            return addressTypeID;
        }

        public List<string> MaritalStatusList()
        {
            List<string> maritalStatus = new();

            maritalStatus.Add("");
            maritalStatus.Add("Married");
            maritalStatus.Add("Single");

            return maritalStatus;
        }

        public List<string> GenderList()
        {
            List<string> gender = new();

            gender.Add("");
            gender.Add("Female");
            gender.Add("Male");

            return gender;
        }

        public List<string> PayFrequencyList()
        {
            List<string> payFrequency = new();

            payFrequency.Add("");
            payFrequency.Add("Bi-Weekly");
            payFrequency.Add("Weekly");

            return payFrequency;
        }

        public List<string> UserRoleList()
        {
            List<string> userRole = new();

            userRole.Add("");
            userRole.Add("Administrator");
            userRole.Add("Basic");

            return userRole;
        }

        public List<string> PersonTypeList()
        {
            List<string> personType = new();

            personType.Add("");
            personType.Add("SC");
            personType.Add("IN");
            personType.Add("SP");
            personType.Add("EM");
            personType.Add("VC");
            personType.Add("GC");

            return personType;
        }
    }
}
