using System;

namespace SimpleProjectApi.Models
{
    public class Employee
    {
        public long EmployeeId { get; set; }
        public required string EmployeeNumber { get; set; }
        public required string EmployeeName { get; set; }
        public DateTime DOB { get; set; }
        public long ReligionId { get; set; }
        public required string RoleName { get; set; }
        public DateTime DOJ { get; set; }
        public decimal BasicSalary { get; set; }
        public bool ActiveStatus { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
    }
}
