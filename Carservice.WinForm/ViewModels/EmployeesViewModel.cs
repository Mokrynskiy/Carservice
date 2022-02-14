using Carservice.Data;
using Carservice.Data.Repositories.Abstract;
using Carservice.WinForm.Models;
using DevExpress.Mvvm;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.XtraEditors;
using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Forms;

namespace Carservice.WinForm.ViewModels
{
    [POCOViewModel()]
    public class EmployeesViewModel: ViewModelBase
    {
        private readonly IUnitOfWork uow;
        public virtual ObservableCollection<EmployeeModel> Employees { get; set; }
        public virtual EmployeeModel SelectedEmployee { get; set; }
        public virtual bool IsSelectMode { get; set; } = false;
        public virtual string CloseButtonCaption { get; set; } = "Выход";
        public EmployeesViewModel()
        {
            uow = new UnitOfWork();
            Employees = new ObservableCollection<EmployeeModel>();
            SelectedEmployee = new EmployeeModel();
            Messenger.Default.Register<bool>(this, "IsSelectEmployeeMod", SetSelectMod);
            LoadData();
        }
        private void SetSelectMod(bool isSelected)
        {
            IsSelectMode = isSelected;
            CloseButtonCaption = "Отмена";
        }
        public void SendSelectedEmployee()
        {
            Messenger.Default.Send<EmployeeModel>(SelectedEmployee, "SetEmployee");
            CloseView();
        }
        private void LoadData()
        {
            foreach (var item in uow.EmployeeRepos.GetAll().ToList())
            {
                Employees.Add(new EmployeeModel
                {
                    Id = item.Id,
                    Surname = item.Surname,
                    Name = item.Name,
                    Patronymic = item.Patronymic,
                    PositionId = item.PositionId,
                    PositionName = item.Position.PositionName,
                    Position = new PositionModel { Id = item.PositionId, PositionName = item.Position.PositionName }
                }) ;
            }
            SelectedEmployee = Employees.FirstOrDefault();
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
           
        }
        public void AddEmployee()
        {
        }
        
    }
}
