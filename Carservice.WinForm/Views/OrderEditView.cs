using Carservice.WinForm.Models;
using Carservice.WinForm.ViewModels;

using DevExpress.XtraGrid.Views.Base;
using System.Windows.Forms;

namespace Carservice.WinForm.Views
{
    public partial class OrderEditView : DevExpress.XtraEditors.XtraUserControl
    {
        public OrderEditView()
        {
            InitializeComponent();
            if (!mvvmContextOrderEdit.IsDesignMode)
                InitializeBindings();
        }

        void InitializeBindings()
        {
            var fluent = mvvmContextOrderEdit.OfType<OrderEditViewModel>();            
            fluent.SetBinding(tbOrderNumber, tb => tb.Text, vm => vm.Order.Id);
            fluent.SetBinding(deOpenDate, tb => tb.EditValue, vm => vm.Order.OpenDate);
            fluent.SetBinding(deDueDate, tb => tb.EditValue, vm => vm.Order.DueDate);
            fluent.SetBinding(deCloseDate, tb => tb.EditValue, vm => vm.Order.CloseDate);
            fluent.SetBinding(tbClientSurname, tb => tb.Text, vm => vm.Order.Car.Client.Surname);
            fluent.SetBinding(tbClientName, tb => tb.Text, vm => vm.Order.Car.Client.Name);
            fluent.SetBinding(tbClientPatronymic, tb => tb.Text, vm => vm.Order.Car.Client.Patronymic);
            fluent.SetBinding(tbCarBrand, tb => tb.Text, vm => vm.Order.Car.Model.CarBrand.BrandName);
            fluent.SetBinding(tbCarModel, tb => tb.Text, vm => vm.Order.Car.Model.ModelName);
            fluent.SetBinding(tbCarRegNumber, tb => tb.Text, vm => vm.Order.Car.RegNumber);
            fluent.SetBinding(tbCarColor, tb => tb.Text, vm => vm.Order.Car.Color);
            fluent.SetBinding(tbCarProductionDate, tb => tb.EditValue, vm => vm.Order.Car.ProductionDate);
            fluent.SetBinding(tbEmployeeSurname, tb => tb.Text, vm => vm.Order.Employee.Surname);
            fluent.SetBinding(tbEmployeeName, tb => tb.Text, vm => vm.Order.Employee.Name);
            fluent.SetBinding(tbEmployeePatronymic, tb => tb.Text, vm => vm.Order.Employee.Patronymic);
            fluent.SetBinding(tbEmployeePosition, tb => tb.Text, vm => vm.Order.Employee.Position.PositionName);

            fluent.SetBinding(gridServices, gControl => gControl.DataSource, vm => vm.Services);
            fluent.WithEvent<ColumnView, FocusedRowObjectChangedEventArgs>(gridViewServices, "FocusedRowObjectChanged")
                .SetBinding(x => x.SelectedService,
                    args => args.Row as ServiceModel,
                    (gView, entity) => gView.FocusedRowHandle = gView.FindRow(entity));
            fluent.WithCommand(vm => vm.SelectClient).Bind(buttonAddClient);
            fluent.WithCommand(vm => vm.SelectEmployee).Bind(buttonAddEmployee);
            fluent.WithCommand(vm => vm.OnEditService).Bind(buttonEditService);
            fluent.WithCommand(vm => vm.SelectService).Bind(buttonAddService);
            fluent.WithCommand(vm => vm.CloseView).Bind(buttonCancel);
            fluent.WithCommand(vm => vm.SaveAndClose).Bind(buttonSave);
            fluent.WithCommand(vm => vm.DeleteService).Bind(buttonDeleteService);
        }

    }
}
