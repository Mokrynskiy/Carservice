using Carservice.Data;
using Carservice.WinForm.Models;
using Carservice.WinForm.Views.Dialogs;
using DevExpress.Mvvm;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Utils.CommonDialogs.Internal;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DialogResult = System.Windows.Forms.DialogResult;

namespace Carservice.WinForm.ViewModels
{
    [POCOViewModel()]
    public class EmployeesViewModel: ViewModelBase
    {
        private readonly UnitOfWork uow;
        public virtual ObservableCollection<EmployeeModel> Employees { get; set; }
        public virtual EmployeeModel SelectedEmployee { get; set; }
        public EmployeesViewModel()
        {
            uow = new UnitOfWork();
            Employees = new ObservableCollection<EmployeeModel>();
            SelectedEmployee = new EmployeeModel();
            loadData();
        }
        private void loadData()
        {
            foreach (var item in uow.EmployeeRepos.GetAll().ToList())
            {
                Employees.Add(new EmployeeModel { Id = item.Id, Surname = item.Surname, Name = item.Name, 
                    Patronymic = item.Patronymic, PositionId = item.PositionId, PositionName = item.Position.PositionName });
            }
        }
        public void DeleteEmployee()
        {
            if (XtraMessageBox.Show($"Вы действительно хотите удалить сотрудника: {SelectedEmployee.Surname} {SelectedEmployee.Name} {SelectedEmployee.Patronymic}", "Внимание!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (uow.OrderRepos.FindAll(en => en.EmployeeId == SelectedEmployee.Id).Any())
                {
                    XtraMessageBox.Show($"Невозможно удалить сотрудника {SelectedEmployee.Surname} {SelectedEmployee.Name} {SelectedEmployee.Patronymic}" +
                        $" так как с этим сотрудником связаны записи в таблице заказов", "Внимание!");
                }
                else
                {
                    try
                    {
                        uow.EmployeeRepos.Delete(SelectedEmployee.Id);
                        Employees.Remove(SelectedEmployee);
                    }
                    catch (Exception e)
                    {
                        XtraMessageBox.Show(e.Message);
                    }
                }
            }           
        }
        public void EditEmployee()
        {
            SendCustomMessage();
            XtraDialog.Show(new EditEmployeeDialog());
           
        }
        public void AddEmployee()
        {

        }
        public void SendCustomMessage()
        {
            Messenger.Default.Send(SelectedEmployee);
        }
    }
}
