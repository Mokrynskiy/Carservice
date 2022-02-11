using Carservice.WinForm.Models;
using Carservice.WinForm.ViewModels;
using DevExpress.XtraEditors;
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
    public partial class ServicesView : DevExpress.XtraEditors.XtraUserControl
    {
        public ServicesView()
        {
            InitializeComponent();
            if (!mvvmContext1.IsDesignMode)
                InitializeBindings();
        }

        void InitializeBindings()
        {
            var fluent = mvvmContext1.OfType<ServicesViewModel>();
            fluent.SetBinding(gridServices, gControl => gControl.DataSource, vm => vm.Services);
            fluent.WithEvent<ColumnView, FocusedRowObjectChangedEventArgs>(gridViewServices, "FocusedRowObjectChanged")
                .SetBinding(x => x.SelectedService,
                    args => args.Row as ServiceModel,
                    (gView, entity) => gView.FocusedRowHandle = gView.FindRow(entity));
            fluent.BindCommand(buttonCancel, vm => vm.CloseView);
        }
    }
}
