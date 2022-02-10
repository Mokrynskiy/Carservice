using Carservice.WinForm.ViewModels;
using CarService.WinForm.Models;
using DevExpress.Utils.MVVM.Services;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

            fluent.SetBinding(gridOrders, gControl => gControl.DataSource, vm => vm.Orders);


            fluent.WithEvent<ColumnView, FocusedRowObjectChangedEventArgs>(gridViewOrders, "FocusedRowObjectChanged")
                .SetBinding(x => x.SelectedOrder,
                    args => args.Row as OrderRowModel,
                    (gView, entity) => gView.FocusedRowHandle = gView.FindRow(entity));

            fluent.WithEvent<RowClickEventArgs>(gridViewOrders, "RowClick")
                .EventToCommand(x => x.Edit, args => (args.Clicks == 2) && (args.Button == MouseButtons.Left));

            fluent.WithCommand(vm => vm.DeleteOrder)
                .Bind(barButtonOrderDelete);

        }
    }
}