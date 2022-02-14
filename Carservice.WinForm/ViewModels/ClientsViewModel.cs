using Carservice.Data;
using Carservice.Data.Repositories.Abstract;
using Carservice.WinForm.Models;
using DevExpress.Mvvm;
using DevExpress.Mvvm.DataAnnotations;
using System;
using System.Collections.ObjectModel;
using System.Linq;

namespace Carservice.WinForm.ViewModels
{
    [POCOViewModel]
    public class ClientsViewModel: ViewModelBase
    {
        private readonly IUnitOfWork uow;
        public virtual ObservableCollection<ClientModel> Clients { get; set; }
        public virtual ClientModel SelectedClient { get; set; }
        public virtual ObservableCollection<CarModel> Cars { get; set; }
        public virtual CarModel SelectedCar { get; set; }
        public virtual bool IsSelectMode { get; set; } = false;
        public virtual string CloseButtonCaption { get; set; } = "Выход";
        public ClientsViewModel()
        {
            uow = new UnitOfWork();
            Clients = new ObservableCollection<ClientModel>();
            Cars = new ObservableCollection<CarModel>();
            SelectedCar = new CarModel();            
            SelectedClient = new ClientModel();
            Messenger.Default.Register<bool>(this, "IsSelectClientMod", SetSelectMod);
            LoadData();
        }

        private void SetSelectMod(bool isSelected)
        {
            IsSelectMode = isSelected;
            CloseButtonCaption = "Отмена";
        }

        private void LoadData()
        {
            try
            {
                foreach(var client in uow.ClientRepos.GetAll().ToList())
                {
                    ClientModel clientRow = new ClientModel();
                    clientRow.Id = client.Id;
                    clientRow.Surname = client.Surname;
                    clientRow.Name = client.Name;
                    clientRow.Patronymic = client.Patronymic;
                    clientRow.FullName = $"{client.Surname} {client.Name} {client.Patronymic}";
                    clientRow.Cars = new ObservableCollection<CarModel>();
                    foreach (var car in client.Cars.ToList())
                    {                        
                        clientRow.Cars.Add(new CarModel
                        {
                            Id = car.Id,
                            ClientId = car.ClientId,                            
                            Color = car.Color,
                            ProductionDate = car.ProductionDate,
                            RegNumber = car.RegNumber,
                            ModelId = car.CarModelId,
                            ModelName = car.CarModel.ModelName,
                            BrandName = car.CarModel.Brand.BrandName,
                            Model = new CarModelModel
                            {
                                Id = car.CarModel.Id,
                                ModelName = car.CarModel.ModelName,
                                CarBrandId = car.CarModel.BrandId,
                                CarBrand = new CarBrandModel { Id = car.CarModel.Brand.Id, BrandName = car.CarModel.Brand.BrandName }
                            },
                            Client = new ClientModel { Id = clientRow.Id, Surname = clientRow.Surname, Name = clientRow.Name, Patronymic = clientRow.Patronymic}
                            
                        });
                    }
                    Clients.Add(clientRow);
                }
                SelectedClient = Clients.FirstOrDefault();
                SelectedCar = SelectedClient.Cars.FirstOrDefault();
            }
            catch (Exception)
            {
                throw;
            }
        }
        public void SendSelectedCar()
        {
            Messenger.Default.Send<CarModel>(SelectedCar, "SetClient");
            CloseView();            
        }
    }
}
