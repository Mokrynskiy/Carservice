using Carservice.WinForm.ViewModels;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
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
    public partial class CarCatalogView : DevExpress.XtraEditors.XtraUserControl
    {
        public CarCatalogView()
        {
            InitializeComponent();
            if (!mvvmContext1.IsDesignMode)
                InitializeBindings();
        }

        void InitializeBindings()
        {
            var fluent = mvvmContext1.OfType<CarCatalogViewModel>();
            fluent.SetItemsSourceBinding(listBoxBrands, lb => lb.Items, x => x.CarBrands, (item, brand) => object.Equals(item.Value, brand),
                brand => new ImageListBoxItem(brand), null, (item, brand) =>
                {
                    item.Description = brand.BrandName;
                });
            fluent.SetBinding(listBoxBrands, lb => lb.SelectedValue, x => x.SelectedBrand);
            fluent.SetItemsSourceBinding(listBoxModels, lb => lb.Items, x => x.CarModels, (item, model) => object.Equals(item.Value, model),
                model => new ImageListBoxItem(model), null, (item, model) =>
                {
                    item.Description = model.ModelName;
                });
            fluent.SetBinding(listBoxModels, lb => lb.SelectedValue, x => x.SelectedModel);

            fluent.BindCommand(buttonAddBrand, vm => vm.AddBrand);
            fluent.BindCommand(buttonEditBrand, vm => vm.EditBrand);
            fluent.BindCommand(buttonDeleteBrand, vm => vm.DeleteBrand);
            fluent.BindCommand(buttonAddModel, vm => vm.AddModel);
            fluent.BindCommand(buttonEditModel, vm => vm.EditModel);
            fluent.BindCommand(buttonDeleteModel, vm => vm.DeleteModel);
            fluent.BindCommand(buttonCancel, vm => vm.CloseView);
        }
    }
}
