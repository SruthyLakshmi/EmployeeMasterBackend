namespace EmployeeMaster.DTOs.Request
{
    public class EmployeeCreateDto
    {
        public string EmployeeCode { get; set; } = string.Empty;

        public string FirstName { get; set; } = string.Empty;

        public string LastName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;

        public string PhoneNumber { get; set; } = string.Empty;

        public string Department { get; set; } = string.Empty;
        public string Designation { get; set; } = string.Empty;

        public DateTime DateOfJoining { get; set; }

        public decimal Salary { get; set; }

        public bool IsActive { get; set; } = true;
    }
}
