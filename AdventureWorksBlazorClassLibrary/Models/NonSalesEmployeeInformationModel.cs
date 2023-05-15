namespace AdventureWorksBlazorClassLibrary.Models
{
    public class NonSalesEmployeeInformationModel : PersonModel
    {
        public string PersonName { get; set; }
        public int PersonID { get; set; }
        public string PersonType { get; set; }
        public string PersonType2 { get; set; }
        public string Country { get; set; }
        public string JobGroup { get; set; }
        public string ShiftName { get; set; }
        public bool CurrentEmployee { get; set; }
        public string FormatHourlyPay
        {
            get
            {
                return HourlyPayRate.ToString("C");
            }
        }
        public string FormatBirthDate
        {
            get
            {
                return BirthDate.ToString("MM/dd/yyyy");
            }
        }

        public string FormatHireDate
        {
            get
            {
                return BirthDate.ToString("MM/dd/yyyy");
            }
        }
    }
}
