using System.Collections.Generic;

namespace Carservice.WinForm.Reports.Models
{
    public class OrderReportModel
    {
        public OrderReportHeaderModel Header { get; private set; }
        public IList<OrderReportItemModel> Items { get; private set; }
        public OrderReportModel(OrderReportHeaderModel header, IList<OrderReportItemModel> items)
        {
            Header = header;
            Items = items;
        }
    }
}
