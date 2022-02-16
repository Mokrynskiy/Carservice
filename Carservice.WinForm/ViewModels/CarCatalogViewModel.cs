using Carservice.Data;
using Carservice.Data.Entities;
using Carservice.Data.Repositories.Abstract;
using Carservice.WinForm.Models;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.XtraEditors;
using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Forms;

namespace Carservice.WinForm.ViewModels
{
    [POCOViewModel()]
    public class CarCatalogViewModel: ViewModelBase
    {
        private readonly IUnitOfWork uow;
        public virtual ObservableCollection<CarBrandModel> CarBrands { get; set; }
        public virtual ObservableCollection<CarModelModel> CarModels { get; set; }
        public virtual CarBrandModel SelectedBrand { get; set; }
        public virtual CarModelModel SelectedModel { get; set; }
        public CarCatalogViewModel()
        {
            CarBrands = new ObservableCollection<CarBrandModel>();
            CarModels = new ObservableCollection<CarModelModel>();
            SelectedBrand = new CarBrandModel();
            SelectedModel = new CarModelModel();
            uow = new UnitOfWork();
            LoadData();
        }
        protected void OnCatalogChanged()
        {
            SelectedBrand = CarBrands.FirstOrDefault();            
        }
        protected void OnSelectedBrandChanged()
        {
            if (SelectedBrand != null)
            {
                CarModels = SelectedBrand.CarModels;               
            }

        }
        // Загрузка данных
        private void LoadData()
        {
            CarBrands.Clear();
            var brands = uow.CarBrandRepos.GetAll();
            foreach (var brand in brands.ToList())
            {
                ObservableCollection<CarModelModel> models = new ObservableCollection<CarModelModel>();
                foreach (var model in brand.CarModels.ToList())
                {
                    models.Add(new CarModelModel { Id = model.Id, CarBrandId = model.BrandId, ModelName = model.ModelName });
                }
                CarBrands.Add(new CarBrandModel { Id = brand.Id, BrandName = brand.BrandName, CarModels = models });
            }
            SelectedBrand = CarBrands.FirstOrDefault();
            SelectedModel = CarModels.FirstOrDefault();
        }
        
        #region CRUD методы
        //Удаление марки автомобиля
        public void DeleteBrand()
        {
            if (SelectedBrand != null)
            {
                try
                {
                    if (XtraMessageBox.Show($"Вы действительно хотите удалить марку автомобиля {SelectedBrand.BrandName}?", "Внимание!!!", MessageBoxButtons.YesNo) != DialogResult.No)
                    {
                        if (uow.CarModelRepos.FindAll(x =>x.BrandId == SelectedBrand.Id).Any())
                        {
                            XtraMessageBox.Show($"Невозможно удалить марку автомобиля {SelectedBrand.BrandName} так как в таблице моделей автомобилей есть связанные данные", "Ошибка!");
                        }
                        else
                        {
                            var brandEntity = uow.CarBrandRepos.Get(SelectedBrand.Id);
                            CarBrands.Remove(SelectedBrand);
                            uow.CarBrandRepos.Delete(brandEntity);
                            uow.Save();
                        }                        
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            }
        }
        //Удаление модели автомобиля
        public void DeleteModel()
        {
            if (SelectedModel != null)
            {
                try
                {
                    if (XtraMessageBox.Show($"Вы действительно хотите удалить модель автомобиля {SelectedModel.ModelName}?", "Внимание!!!", MessageBoxButtons.YesNo) != DialogResult.No)
                    {
                        if (uow.OrderRepos.FindAll(x => x.Car.CarModelId == SelectedModel.Id).Any())
                        {
                            XtraMessageBox.Show($"Невозможно удалить модель автомобиля {SelectedModel.ModelName} так как в таблице заказов и таблице клиентов есть связанные данные", "Ошибка!");
                        }
                        else
                        {
                            var modelEntity = uow.CarModelRepos.Get(SelectedModel.Id);
                            CarModels.Remove(SelectedModel);
                            uow.CarModelRepos.Delete(modelEntity);
                            uow.Save();
                        }                            
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            }
        }
        //Добавление марки автомобиля
        public void AddBrand()
        {
            var result = XtraInputBox.Show("Ведите название марки автомобиля", "Добавить новую марку автомобиля", "");
            if (result != null && result != String.Empty)
            {
                try
                {
                    uow.CarBrandRepos.Add(new CarBrand { BrandName = result });
                    uow.Save();                    
                    var brandEntity = uow.CarBrandRepos.FindBy(x => x.BrandName == result).FirstOrDefault();
                    CarBrands.Add(new CarBrandModel { BrandName = brandEntity.BrandName, Id = brandEntity.Id, CarModels = new ObservableCollection<CarModelModel>() });
                    SelectedBrand = CarBrands.LastOrDefault();
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            }
        }
        //Добавление модели автомобиля
        public void AddModel()
        {
            var result = XtraInputBox.Show("Ведите название модели", $"Добавить новую модель {SelectedBrand.BrandName}", "");
            if (result != null && result != String.Empty)
            {
                try
                {
                    uow.CarModelRepos.Add(new Data.Entities.CarModel { ModelName = result, BrandId = SelectedBrand.Id });
                    uow.Save();
                    UpdateData();
                    SelectedModel = CarModels.LastOrDefault();
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            }
        }
        //Редактирование марки автомобиля
        public void EditBrand()
        {
            var result = XtraInputBox.Show("Ведите название марки автомобиля", "Редактировать марку автомобиля", SelectedBrand.BrandName);
            if (result != null && result != String.Empty)
            {
                try
                {
                    var brandEntity = uow.CarBrandRepos.Get(SelectedBrand.Id);
                    brandEntity.BrandName = result;
                    uow.CarBrandRepos.Update(brandEntity, SelectedBrand.Id);
                    uow.Save();
                    UpdateData();
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            }
        }
        //Редактирование модели автомобиля
        public void EditModel()
        {
            var result = XtraInputBox.Show("Ведите название марки модели", "Редактировать модель автомобиля", SelectedModel.ModelName);
            if (result != null && result != String.Empty)
            {
                try
                {
                    var modelEntity = uow.CarModelRepos.Get(SelectedModel.Id);
                    modelEntity.ModelName = result;
                    uow.CarModelRepos.Update(modelEntity, SelectedModel.Id);
                    uow.Save();
                    UpdateData();

                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            }
        }
        //Обновление данных
        protected void UpdateData()
        {
            int selectedBrandId = SelectedBrand.Id;
            int selectedModelId = SelectedModel.Id;
            LoadData();
            SelectedBrand = (from b in CarBrands where b.Id == selectedBrandId select b).FirstOrDefault();
            SelectedModel = (from m in CarModels where m.Id == selectedModelId select m).FirstOrDefault();
        }
        #endregion
    }
}
