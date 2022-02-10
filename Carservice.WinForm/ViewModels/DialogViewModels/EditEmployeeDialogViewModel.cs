using Carservice.Data;
using Carservice.WinForm.Models;
using DevExpress.Mvvm;
using DevExpress.Mvvm.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Carservice.WinForm.Views.Dialogs
{
    [POCOViewModel()]
    public class EditEmployeeDialogViewModel
    {
        private readonly UnitOfWork uow;
        public virtual EmployeeModel Employee { get; set; }
        public virtual ObservableCollection<PositionModel> Positions { get; set; }
        public EditEmployeeDialogViewModel()
        {
            uow = new UnitOfWork();
            Employee = new EmployeeModel();
            Positions = new ObservableCollection<PositionModel>();
            RegisterAsStringMessageRecepient();
            Load();
        }

        private void Load()
        {
            foreach (var item in uow.PositionRepos.GetAll().ToList())
            {
                Positions.Add(new PositionModel { Id = item.Id, PositionName = item.PositionName });
            }
        }
        public void RegisterAsStringMessageRecepient()
        {
            Messenger.Default.Register<EmployeeModel>(this, OnStringMessage);
        }
        void OnStringMessage(EmployeeModel employee)
        {
            Employee = employee;
        }
    }
}
