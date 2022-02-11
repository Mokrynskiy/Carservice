using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Carservice.WinForm.Views.Dialogs
{
    public partial class EditEmployeeDialog : DevExpress.XtraEditors.XtraUserControl
    {
        public EditEmployeeDialog()
        {
            InitializeComponent();
            if (!mvvmContext1.IsDesignMode)
                InitializeBindings();
        }

        void InitializeBindings()
        {
            var fluent = mvvmContext1.OfType<EditEmployeeDialogViewModel>();
            fluent.SetBinding(tbSurname, tb => tb.Text, vm => vm.Employee.Surname);
            fluent.SetBinding(tbName, tb => tb.Text, vm => vm.Employee.Name);
            fluent.SetBinding(tbPatronymic, tb => tb.Text, vm => vm.Employee.Patronymic);
            fluent.SetBinding(cbPositions, cb => cb.Properties.DataSource, vm => vm.Positions);

        }
    }
}
