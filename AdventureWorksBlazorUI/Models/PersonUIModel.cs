using System.ComponentModel.DataAnnotations;

namespace AdventureWorksBlazorUI.Models
{
    public class PersonUIModel
    {
        [Required(ErrorMessage ="Must Select A Title!")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Must Enter A First Name!")]
        [RegularExpression(@"^(?:[a-zA-Z]+\s?)+[a-zA-Z]+$",ErrorMessage ="First Name Must Contain Letters Only And Not Start Or End With Spaces!")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Must Enter A Middle Name!")]
        [RegularExpression(@"^(?:[a-zA-Z]+\s?)+[a-zA-Z]+$", ErrorMessage = "Middle Name Must Contain Letters Only And Not Start Or End With Spaces!")]
        public string MiddleName { get; set; }

        [Required(ErrorMessage = "Must Enter A Last Name!")]
        [RegularExpression(@"^(?:[a-zA-Z]+\s?)+[a-zA-Z]+$", ErrorMessage = "Last Name Must Contain Letters Only And Not Start Or End With Spaces!")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Must Select A Suffix!")]
        public string Suffix { get; set; }

        [Required(ErrorMessage = "Must Enter A Phone Number!")]
        [RegularExpression(@"^[0-9]+$", ErrorMessage = "Phone Number Must Contain Numbers Only And Not Start Or End With Spaces!")]
        [MinLength(11, ErrorMessage = "Phone Number Must Be 11 Numbers!")]
        [MaxLength(11, ErrorMessage = "Phone Number Must Be 11 Numbers!")]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "Must Select A Phone Number Type!")]
        public string PhoneNumberType { get; set; }

        [Required(ErrorMessage = "Must Enter An Address!")]
        [RegularExpression(@"^[a-zA-Z0-9\s]+$", ErrorMessage = "Address Must Be In Proper Format And Not Contain Special Characters! Ex: 123 Main St")]
        public string AddressLine1 { get; set; }

        [Required(ErrorMessage = "Must Select An AddressTypeID!")]
        public string AddressTypeID { get; set; }

        [Required(ErrorMessage = "Must Enter A City!")]
        [RegularExpression(@"^(?:[a-zA-Z]+\s?)+[a-zA-Z]+$", ErrorMessage = "City Must Contain Letters Only!")]
        public string City { get; set; }

        [Required(ErrorMessage = "Must Select A State Or Province!")]
        public string StateOrProvince { get; set; }

        [Required(ErrorMessage = "Must Enter Postal Code!")]
        [RegularExpression(@"^[0-9]+$", ErrorMessage = "Postal Code Must Contain Numbers Only And Not Start Or End With Spaces!")]
        [MinLength(5, ErrorMessage = "Postal Code Must Be 5 Numbers!")]
        [MaxLength(5, ErrorMessage = "Postal Code Must Be 5 Numbers!")]
        public string PostalCode { get; set; }

        [Required(ErrorMessage = "Must Enter An Email Address!")]
        [EmailAddress(ErrorMessage ="Must Enter A Valid Email Address!")]
        public string EmailAddress { get; set; }

        [Required(ErrorMessage = "Must Enter A National ID Number!")]
        [RegularExpression(@"^[0-9]+$", ErrorMessage = "National ID Number Must Contain Numbers Only And Not Start Or End With Spaces!")]
        [MinLength(9, ErrorMessage = "National ID Number Must Be 9 Numbers!")]
        [MaxLength(9, ErrorMessage = "National ID Number Must Be 9 Numbers!")]
        public string SocialSecurityNumber { get; set; }

        [Required(ErrorMessage = "Must Enter A Login ID!")]
        [RegularExpression(@"^[0-9a-zA-Z!@#$%^&*()?]+$", ErrorMessage = "Login ID Must Contain Only Numbers Letters And Approved Characters (!@#$%^&*()?)!")]

        public string LoginID { get; set; }

        [Required(ErrorMessage = "Must Enter A Job Title!")]
        [RegularExpression(@"^(?:[a-zA-Z]+\s?)+[a-zA-Z]+$", ErrorMessage = "Job Title Must Contain Letters Only!")]
        public string JobTitle { get; set; }

        [Required(ErrorMessage = "Must Enter A Birth Date!")]
        public DateTime BirthDate { get; set; }

        [Required(ErrorMessage = "Must Select A Marital Status!")]
        public string MaritalStatus { get; set; }

        [Required(ErrorMessage = "Must Select A Gender!")]
        public string Gender { get; set; }

        [Required(ErrorMessage = "Must Enter A Hire Date!")]
        public DateTime HireDate { get; set; }

        [Required(ErrorMessage = "Must Enter Vacation Hours!")]
        [Range(0,40, ErrorMessage = "Vacation Hours Must Be Between 0 And 40!")]
        public int VacationHours { get; set; }

        [Required(ErrorMessage = "Must Enter Sick Leave Hours!")]
        [Range(0, 40, ErrorMessage = "Sick Leave Hours Must Be Between 0 And 40!")]
        public int SickLeaveHours { get; set; }

        [Required(ErrorMessage = "Must Enter Hourly Pay Rate!")]
        [Range(15.00, 75.00, ErrorMessage = "Hourly Pay Must Be Between 15 And 75!")]
        public decimal HourlyPayRate { get; set; }

        [Required(ErrorMessage = "Must Select Pay Frequency!")]
        public string PayFrequency { get; set; }

        [Required(ErrorMessage = "Must Select A Department!")]
        public string JobDepartment { get; set; }

        [Required(ErrorMessage = "Must Select A Value For Salaried!")]
        public bool SalariedFlag { get; set; }

        [Required(ErrorMessage = "Must Enter A Start Date!")]
        public DateTime StartDate { get; set; }

        [Required(ErrorMessage = "Must Select A Shift!")]
        public int ShiftID { get; set; }
    }
}
