using DevExpress.Mvvm;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm.POCO;

namespace Carservice.WinForm.ViewModels
{
    [POCOViewModel]
    public abstract class ViewModelBase
    {

        protected IDocumentManagerService DocumentManagerService => this.GetService<IDocumentManagerService>();
        readonly static object CarCatalogView_ID = new object();
        readonly static object EmployeesView_ID = new object();        
        readonly static object ClientsView_ID = new object();
        readonly static object ServicesView_ID = new object();
        readonly static object OrderEditView_ID = new object();

        public void CreateDocument(object id, string documentType, string title)
        {
            var document = DocumentManagerService.FindDocumentById(id);
            if (document == null)
            {
                document = DocumentManagerService.CreateDocument(
                    documentType, parameter: null, parentViewModel: this);
                document.Id = id;
                document.Title = title;
            }
            document.Show();
        }
        public void ShowCarCatalogView()
        {
            CreateDocument(CarCatalogView_ID, "CarCatalogView", "Каталог автомобилей");
        }
        public void ShowEmployeesView()
        {
            CreateDocument(EmployeesView_ID, "EmployeesView", "Сотрудники");
        }
       
        public void ShowClientsView()
        {
            CreateDocument(ClientsView_ID, "ClientsView", "Клиенты");
        }
        public void ShowServicesView()
        {
            CreateDocument(ServicesView_ID, "ServicesView", "Услуги");
        }
        public void ShowEditOrderView()
        {
            CreateDocument(OrderEditView_ID, "OrderEditView", "Наряд-заказ");
        }
        
        public void CloseView()
        {
            if(DocumentManagerService.ActiveDocument != null)
            DocumentManagerService.ActiveDocument.Close();
        }
        
    }
}