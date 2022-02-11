using Carservice.WinForm.Models;
using Carservice.WinForm.ViewModels;
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
    public partial class EmployeesView : DevExpress.XtraEditors.XtraUserControl
    {
        public EmployeesView()
        {
            InitializeComponent();
            if (!mvvmContext1.IsDesignMode)
                InitializeBindings();            
        }

        void InitializeBindings()
        {
            var fluent = mvvmContext1.OfType<EmployeesViewModel>();
            fluent.SetBinding(gridEmployee, gControl => gControl.DataSource, vm => vm.Employees);
            fluent.WithEvent<ColumnView, FocusedRowObjectChangedEventArgs>(gridViewEmployee, "FocusedRowObjectChanged")
                .SetBinding(x => x.SelectedEmployee,
                    args => args.Row as EmployeeModel,
                    (gView, entity) => gView.FocusedRowHandle = gView.FindRow(entity));

            fluent.WithEvent<RowClickEventArgs>(gridViewEmployee, "RowClick")
                .EventToCommand(x => x.EditEmployee, args => (args.Clicks == 2) && (args.Button == MouseButtons.Left));
            fluent.BindCommand(buttonClose, vm => vm.CloseView);
            fluent.BindCommand(buttonAdd, vm => vm.AddEmployee);
            fluent.BindCommand(buttonEdit, vm => vm.ShowEditEmployeeDialog);
            fluent.BindCommand(buttonDelete, vm => vm.DeleteEmployee);            
        }
       
    }
}
