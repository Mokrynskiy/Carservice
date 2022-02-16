using Carservice.WinForm.Reports.Models;

namespace Carservice.WinForm.Reports.Abstract
{
    public interface IOrderReportBuilder
    {
        OrderReportModel Build(int orderId);
    }
}
