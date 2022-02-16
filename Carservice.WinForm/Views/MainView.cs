using Carservice.WinForm.ViewModels;
using CarService.WinForm.Models;
using DevExpress.Utils.MVVM.Services;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using System.Windows.Forms;

namespace Carservice.WinForm.Views
{
    public partial class MainView : DevExpress.XtraEditors.XtraForm
    {
        public MainView()
        {
            InitializeComponent();
            if (!mvvmContext.IsDesignMode)
                InitializeBindings();
        }

        void InitializeBindings()
        {
            var fluent = mvvmContext.OfType<MainViewModel>();
            mvvmContext.RegisterService(WindowedDocumentManagerService.Create());
            fluent.BindCommand(barButtonIShowCarCatalog, vm => vm.ShowCarCatalogView);
            fluent.BindCommand(barButtonShowEmployeesView, vm => vm.ShowEmployeesView);
            fluent.BindCommand(barButtonShowClients, vm => vm.ShowClientsView);
            fluent.BindCommand(barButtonShowServices, vm => vm.ShowServicesView);
            fluent.BindCommand(barButtonOrderEdit, vm => vm.EditOrder);
            fluent.BindCommand(barButtonOrderAdd, vm => vm.AddOrder);
            fluent.SetBinding(gridOrders, gControl => gControl.DataSource, vm => vm.Orders);
            fluent.WithEvent<ColumnView, FocusedRowObjectChangedEventArgs>(gridViewOrders, "FocusedRowObjectChanged")
                .SetBinding(x => x.SelectedOrder,
                    args => args.Row as OrderRowModel,
                    (gView, entity) => gView.FocusedRowHandle = gView.FindRow(entity));
            fluent.WithEvent<RowClickEventArgs>(gridViewOrders, "RowClick")
                .EventToCommand(x => x.EditOrder, args => (args.Clicks == 2) && (args.Button == MouseButtons.Left));
            fluent.WithCommand(vm => vm.DeleteOrder)
                .Bind(barButtonOrderDelete);
            fluent.WithCommand(vm => vm.PrintOrder)
                .Bind(barButtonOrderPrint);

        }

        
    }
}