namespace Carservice.WinForm.Reports.Models
{
    public class OrderReportHeaderModel
    {
        public int Id { get; set; }
        public string OpenDate { get; set; }
        public string DueDate { get; set; }
        public string CloseDate { get; set; }
        public string ClientSurname { get; set; }
        public string ClientName { get; set; }
        public string ClientPatronymic { get; set; }
        public string CarColor { get; set; }
        public string CarBrand { get; set; }
        public string CarModel { get; set; }
        public string CarRegNumber { get; set; }
        public string CarProductionDate { get; set; }
        public string EmployeeSurname { get; set; }
        public string EmployeeName { get; set; }
        public string EmployeePatronymic { get; set; }
        public string EmployeePosition { get; set; }
    }
}
