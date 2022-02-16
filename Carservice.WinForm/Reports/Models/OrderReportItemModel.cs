namespace Carservice.WinForm.Reports.Models
{
    public class OrderReportItemModel
    {
        public string ServiceName { get; set; }
        public decimal ServiceCost { get; set; }
        public int NumberOfServices { get; set; }
        public string Measure { get; set; }
        public decimal Sum { get; set; }
        public OrderReportItemModel(string serviceName, decimal serviceCost, int numberOfServices, string measure)
        {
            ServiceName = serviceName;
            ServiceCost = serviceCost;
            NumberOfServices = numberOfServices;
            Measure = measure;
            Sum = serviceCost * numberOfServices;
        }
    }
}
