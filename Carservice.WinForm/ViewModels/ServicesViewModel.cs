using Carservice.Data;
using Carservice.Data.Repositories.Abstract;
using Carservice.WinForm.Models;
using DevExpress.Mvvm;
using DevExpress.Mvvm.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Carservice.WinForm.ViewModels
{
    [POCOViewModel()]
    public class ServicesViewModel: ViewModelBase
    {
        private readonly IUnitOfWork uow;
        public virtual ObservableCollection<ServiceModel> Services { get; set; }
        public virtual ServiceModel SelectedService { get; set; }
        public virtual bool IsSelectMode { get; set; } = false;
        public virtual string CloseButtonCaption { get; set; } = "Выход";       

        public ServicesViewModel()
        {
            uow = new UnitOfWork();
            Services = new ObservableCollection<ServiceModel>();
            SelectedService = new ServiceModel();
            Messenger.Default.Register<bool>(this, "IsSelectServiceMod", SetSelectMod);
            LoadData();
        }
        private void SetSelectMod(bool isSelectMod)
        {
            IsSelectMode = isSelectMod;
            CloseButtonCaption = "Отмена";
        }
        public void SendSelectedService()
        {
            Messenger.Default.Send<ServiceModel>(SelectedService, "AddService");
            CloseView();
        }
        private void LoadData()
        {
            try
            {
                foreach (var item in uow.ServiceRepos.GetAll().ToList())
                {
                    var mesure = uow.MeasureRepos.Get(item.MeasureId);
                    Services.Add(new ServiceModel
                    {
                        Id = item.Id,
                        Name = item.ServiceName,
                        Cost = item.ServiceCost,
                        MeasureId = item.MeasureId,
                        MeasureShortName = mesure.MeasureShortName,
                        Measure = new MeasureModel { Id = mesure.Id, Name = mesure.MeasureName, ShortName = mesure.MeasureShortName }
                    }) ;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
    }
}
