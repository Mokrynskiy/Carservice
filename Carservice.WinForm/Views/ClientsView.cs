using Carservice.WinForm.Models;
using Carservice.WinForm.ViewModels;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Views.Base;
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
    public partial class ClientsView : DevExpress.XtraEditors.XtraUserControl
    {
        public ClientsView()
        {
            InitializeComponent();
            if (!mvvmContext1.IsDesignMode)
                InitializeBindings();
        }
        void InitializeBindings()
        {
            var fluent = mvvmContext1.OfType<ClientsViewModel>();            
            fluent.SetItemsSourceBinding(listBoxClients, lb => lb.Items, x => x.Clients, (item, client) => object.Equals(item.Value, client),
                client => new ImageListBoxItem(client), null, (item, client) =>
                {
                    item.Description = client.FullName;
                });
            fluent.SetBinding(listBoxClients, lb => lb.SelectedValue, x => x.SelectedClient);
            
            fluent.SetBinding(gridClients, gControl => gControl.DataSource, vm => vm.SelectedClient.Cars);
            fluent.WithEvent<ColumnView, FocusedRowObjectChangedEventArgs>(gridViewClients, "FocusedRowObjectChanged")
                .SetBinding(x => x.SelectedCar,
                    args => args.Row as CarModel,
                    (gView, entity) => gView.FocusedRowHandle = gView.FindRow(entity));
            fluent.WithCommand(vm => vm.SendSelectedCar).Bind(buttonOk);

            fluent.SetBinding(buttonClose, b => b.Text, vm => vm.CloseButtonCaption);
            fluent.SetBinding(buttonOk, b => b.Visible, vm => vm.IsSelectMode);
            fluent.WithCommand(vm => vm.CloseView).Bind(buttonClose);
        }
    }
}
