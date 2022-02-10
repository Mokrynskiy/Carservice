namespace Carservice.WinForm.Views
{
    partial class MainView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainView));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barButtonOrderPrint = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonOrderDetail = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonOrderAdd = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonOrderEdit = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonOrderDelete = new DevExpress.XtraBars.BarButtonItem();
            this.Справочник = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem6 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonShowEmployeesView = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonIShowCarCatalog = new DevExpress.XtraBars.BarButtonItem();
            this.Единицы = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar1 = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.gridOrders = new DevExpress.XtraGrid.GridControl();
            this.gridViewOrders = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.OpenDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DueDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CloceDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Client = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Car = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Sum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.mvvmContext = new DevExpress.Utils.MVVM.MVVMContext(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContext)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem,
            this.barButtonOrderPrint,
            this.barButtonOrderDetail,
            this.barButtonOrderAdd,
            this.barButtonOrderEdit,
            this.barButtonOrderDelete,
            this.Справочник,
            this.barButtonItem6,
            this.barButtonShowEmployeesView,
            this.barButtonIShowCarCatalog,
            this.Единицы});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 14;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1,
            this.ribbonPage2});
            this.ribbonControl1.Size = new System.Drawing.Size(1278, 183);
            this.ribbonControl1.StatusBar = this.ribbonStatusBar1;
            // 
            // barButtonOrderPrint
            // 
            this.barButtonOrderPrint.Caption = "Печать";
            this.barButtonOrderPrint.Id = 1;
            this.barButtonOrderPrint.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonOrderPrint.ImageOptions.Image")));
            this.barButtonOrderPrint.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonOrderPrint.ImageOptions.LargeImage")));
            this.barButtonOrderPrint.Name = "barButtonOrderPrint";
            // 
            // barButtonOrderDetail
            // 
            this.barButtonOrderDetail.Caption = "Детали заказа";
            this.barButtonOrderDetail.Id = 2;
            this.barButtonOrderDetail.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonOrderDetail.ImageOptions.Image")));
            this.barButtonOrderDetail.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonOrderDetail.ImageOptions.LargeImage")));
            this.barButtonOrderDetail.Name = "barButtonOrderDetail";
            // 
            // barButtonOrderAdd
            // 
            this.barButtonOrderAdd.Caption = "Создать";
            this.barButtonOrderAdd.Hint = "Создать новый заказ";
            this.barButtonOrderAdd.Id = 3;
            this.barButtonOrderAdd.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonOrderAdd.ImageOptions.Image")));
            this.barButtonOrderAdd.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonOrderAdd.ImageOptions.LargeImage")));
            this.barButtonOrderAdd.Name = "barButtonOrderAdd";
            // 
            // barButtonOrderEdit
            // 
            this.barButtonOrderEdit.Caption = "Редактировать";
            this.barButtonOrderEdit.Hint = "Редактировать заказ";
            this.barButtonOrderEdit.Id = 4;
            this.barButtonOrderEdit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonOrderEdit.ImageOptions.Image")));
            this.barButtonOrderEdit.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonOrderEdit.ImageOptions.LargeImage")));
            this.barButtonOrderEdit.Name = "barButtonOrderEdit";
            // 
            // barButtonOrderDelete
            // 
            this.barButtonOrderDelete.Caption = "Удалить";
            this.barButtonOrderDelete.Hint = "Удалить заказ";
            this.barButtonOrderDelete.Id = 5;
            this.barButtonOrderDelete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonOrderDelete.ImageOptions.Image")));
            this.barButtonOrderDelete.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonOrderDelete.ImageOptions.LargeImage")));
            this.barButtonOrderDelete.Name = "barButtonOrderDelete";
            // 
            // Справочник
            // 
            this.Справочник.Caption = "Клиенты";
            this.Справочник.Id = 6;
            this.Справочник.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Справочник.ImageOptions.Image")));
            this.Справочник.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("Справочник.ImageOptions.LargeImage")));
            this.Справочник.Name = "Справочник";
            // 
            // barButtonItem6
            // 
            this.barButtonItem6.Caption = "Услуги";
            this.barButtonItem6.Id = 7;
            this.barButtonItem6.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem6.ImageOptions.Image")));
            this.barButtonItem6.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem6.ImageOptions.LargeImage")));
            this.barButtonItem6.Name = "barButtonItem6";
            // 
            // barButtonShowEmployeesView
            // 
            this.barButtonShowEmployeesView.Caption = "Сотрудники";
            this.barButtonShowEmployeesView.Id = 8;
            this.barButtonShowEmployeesView.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem7.ImageOptions.Image")));
            this.barButtonShowEmployeesView.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem7.ImageOptions.LargeImage")));
            this.barButtonShowEmployeesView.Name = "barButtonShowEmployeesView";
            // 
            // barButtonIShowCarCatalog
            // 
            this.barButtonIShowCarCatalog.Caption = "Каталог автомобилей";
            this.barButtonIShowCarCatalog.Id = 9;
            this.barButtonIShowCarCatalog.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonIShowCarCatalog.ImageOptions.Image")));
            this.barButtonIShowCarCatalog.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonIShowCarCatalog.ImageOptions.LargeImage")));
            this.barButtonIShowCarCatalog.Name = "barButtonIShowCarCatalog";
            // 
            // Единицы
            // 
            this.Единицы.Caption = "Единицы измерения";
            this.Единицы.Id = 10;
            this.Единицы.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Единицы.ImageOptions.Image")));
            this.Единицы.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("Единицы.ImageOptions.LargeImage")));
            this.Единицы.Name = "Единицы";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2,
            this.ribbonPageGroup3});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Журнал заказов";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonOrderPrint);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.barButtonOrderDetail);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.barButtonOrderAdd);
            this.ribbonPageGroup3.ItemLinks.Add(this.barButtonOrderEdit);
            this.ribbonPageGroup3.ItemLinks.Add(this.barButtonOrderDelete);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup4});
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "Справочники";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.Справочник);
            this.ribbonPageGroup4.ItemLinks.Add(this.barButtonItem6);
            this.ribbonPageGroup4.ItemLinks.Add(this.barButtonShowEmployeesView);
            this.ribbonPageGroup4.ItemLinks.Add(this.barButtonIShowCarCatalog);
            this.ribbonPageGroup4.ItemLinks.Add(this.Единицы);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.Text = "ribbonPageGroup4";
            // 
            // ribbonStatusBar1
            // 
            this.ribbonStatusBar1.Location = new System.Drawing.Point(0, 667);
            this.ribbonStatusBar1.Name = "ribbonStatusBar1";
            this.ribbonStatusBar1.Ribbon = this.ribbonControl1;
            this.ribbonStatusBar1.Size = new System.Drawing.Size(1278, 33);
            // 
            // gridOrders
            // 
            this.gridOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridOrders.Location = new System.Drawing.Point(0, 183);
            this.gridOrders.MainView = this.gridViewOrders;
            this.gridOrders.MenuManager = this.ribbonControl1;
            this.gridOrders.Name = "gridOrders";
            this.gridOrders.Size = new System.Drawing.Size(1278, 484);
            this.gridOrders.TabIndex = 2;
            this.gridOrders.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewOrders});
            // 
            // gridViewOrders
            // 
            this.gridViewOrders.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Id,
            this.OpenDate,
            this.DueDate,
            this.CloceDate,
            this.Client,
            this.Car,
            this.Sum});
            this.gridViewOrders.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            this.gridViewOrders.GridControl = this.gridOrders;
            this.gridViewOrders.Name = "gridViewOrders";
            // 
            // Id
            // 
            this.Id.Caption = "№ заказа";
            this.Id.FieldName = "Id";
            this.Id.MinWidth = 25;
            this.Id.Name = "Id";
            this.Id.OptionsColumn.AllowEdit = false;
            this.Id.OptionsColumn.AllowFocus = false;
            this.Id.OptionsColumn.ReadOnly = true;
            this.Id.Visible = true;
            this.Id.VisibleIndex = 0;
            this.Id.Width = 94;
            // 
            // OpenDate
            // 
            this.OpenDate.Caption = "Дата открытия";
            this.OpenDate.FieldName = "OpenDate";
            this.OpenDate.MinWidth = 25;
            this.OpenDate.Name = "OpenDate";
            this.OpenDate.OptionsColumn.AllowEdit = false;
            this.OpenDate.OptionsColumn.AllowFocus = false;
            this.OpenDate.OptionsColumn.ReadOnly = true;
            this.OpenDate.Visible = true;
            this.OpenDate.VisibleIndex = 1;
            this.OpenDate.Width = 94;
            // 
            // DueDate
            // 
            this.DueDate.Caption = "Срок выполнения";
            this.DueDate.FieldName = "DueDate";
            this.DueDate.MinWidth = 25;
            this.DueDate.Name = "DueDate";
            this.DueDate.OptionsColumn.AllowEdit = false;
            this.DueDate.OptionsColumn.AllowFocus = false;
            this.DueDate.OptionsColumn.ReadOnly = true;
            this.DueDate.Visible = true;
            this.DueDate.VisibleIndex = 2;
            this.DueDate.Width = 94;
            // 
            // CloceDate
            // 
            this.CloceDate.Caption = "Дата закрытия";
            this.CloceDate.FieldName = "CloceDate";
            this.CloceDate.MinWidth = 25;
            this.CloceDate.Name = "CloceDate";
            this.CloceDate.OptionsColumn.AllowEdit = false;
            this.CloceDate.OptionsColumn.AllowFocus = false;
            this.CloceDate.OptionsColumn.ReadOnly = true;
            this.CloceDate.Visible = true;
            this.CloceDate.VisibleIndex = 3;
            this.CloceDate.Width = 94;
            // 
            // Client
            // 
            this.Client.Caption = "ФИО клиента";
            this.Client.FieldName = "Client";
            this.Client.MinWidth = 25;
            this.Client.Name = "Client";
            this.Client.OptionsColumn.AllowEdit = false;
            this.Client.OptionsColumn.AllowFocus = false;
            this.Client.OptionsColumn.ReadOnly = true;
            this.Client.Visible = true;
            this.Client.VisibleIndex = 4;
            this.Client.Width = 94;
            // 
            // Car
            // 
            this.Car.Caption = "Данные автомобиля";
            this.Car.FieldName = "Car";
            this.Car.MinWidth = 25;
            this.Car.Name = "Car";
            this.Car.OptionsColumn.AllowEdit = false;
            this.Car.OptionsColumn.AllowFocus = false;
            this.Car.OptionsColumn.ReadOnly = true;
            this.Car.Visible = true;
            this.Car.VisibleIndex = 5;
            this.Car.Width = 94;
            // 
            // Sum
            // 
            this.Sum.Caption = "Сумма заказа";
            this.Sum.DisplayFormat.FormatString = "C2";
            this.Sum.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.Sum.FieldName = "Sum";
            this.Sum.MinWidth = 25;
            this.Sum.Name = "Sum";
            this.Sum.OptionsColumn.AllowEdit = false;
            this.Sum.OptionsColumn.AllowFocus = false;
            this.Sum.OptionsColumn.ReadOnly = true;
            this.Sum.Visible = true;
            this.Sum.VisibleIndex = 6;
            this.Sum.Width = 94;
            // 
            // mvvmContext
            // 
            this.mvvmContext.ContainerControl = this;
            this.mvvmContext.ViewModelType = typeof(Carservice.WinForm.ViewModels.MainViewModel);
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1278, 700);
            this.Controls.Add(this.gridOrders);
            this.Controls.Add(this.ribbonStatusBar1);
            this.Controls.Add(this.ribbonControl1);
            this.MinimumSize = new System.Drawing.Size(800, 400);
            this.Name = "MainView";
            this.Text = "Автосервис";
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridOrders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewOrders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContext)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem barButtonOrderPrint;
        private DevExpress.XtraBars.BarButtonItem barButtonOrderDetail;
        private DevExpress.XtraBars.BarButtonItem barButtonOrderAdd;
        private DevExpress.XtraBars.BarButtonItem barButtonOrderEdit;
        private DevExpress.XtraBars.BarButtonItem barButtonOrderDelete;
        private DevExpress.XtraBars.BarButtonItem Справочник;
        private DevExpress.XtraBars.BarButtonItem barButtonItem6;
        private DevExpress.XtraBars.BarButtonItem barButtonShowEmployeesView;
        private DevExpress.XtraBars.BarButtonItem barButtonIShowCarCatalog;
        private DevExpress.XtraBars.BarButtonItem Единицы;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar1;
        private DevExpress.XtraGrid.GridControl gridOrders;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewOrders;
        private DevExpress.XtraGrid.Columns.GridColumn Id;
        private DevExpress.XtraGrid.Columns.GridColumn OpenDate;
        private DevExpress.XtraGrid.Columns.GridColumn DueDate;
        private DevExpress.XtraGrid.Columns.GridColumn CloceDate;
        private DevExpress.XtraGrid.Columns.GridColumn Client;
        private DevExpress.XtraGrid.Columns.GridColumn Car;
        private DevExpress.XtraGrid.Columns.GridColumn Sum;
        private DevExpress.Utils.MVVM.MVVMContext mvvmContext;
    }
}