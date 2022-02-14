namespace Carservice.WinForm.Views
{
    partial class ClientsView
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientsView));
            this.mvvmContext1 = new DevExpress.Utils.MVVM.MVVMContext(this.components);
            this.stackPanel1 = new DevExpress.Utils.Layout.StackPanel();
            this.buttonClose = new DevExpress.XtraEditors.SimpleButton();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.listBoxClients = new DevExpress.XtraEditors.ImageListBoxControl();
            this.stackPanel2 = new DevExpress.Utils.Layout.StackPanel();
            this.buttonAddClient = new DevExpress.XtraEditors.SimpleButton();
            this.buttonEditClient = new DevExpress.XtraEditors.SimpleButton();
            this.buttonDeleteClient = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.gridClients = new DevExpress.XtraGrid.GridControl();
            this.gridViewClients = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.CarColor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CarBrand = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CarModel = new DevExpress.XtraGrid.Columns.GridColumn();
            this.RegNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ProductionDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.stackPanel3 = new DevExpress.Utils.Layout.StackPanel();
            this.buttonAddCar = new DevExpress.XtraEditors.SimpleButton();
            this.buttonEditCar = new DevExpress.XtraEditors.SimpleButton();
            this.buttonDeleteCar = new DevExpress.XtraEditors.SimpleButton();
            this.buttonOk = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContext1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stackPanel1)).BeginInit();
            this.stackPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel1)).BeginInit();
            this.splitContainerControl1.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel2)).BeginInit();
            this.splitContainerControl1.Panel2.SuspendLayout();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listBoxClients)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stackPanel2)).BeginInit();
            this.stackPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridClients)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewClients)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stackPanel3)).BeginInit();
            this.stackPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // mvvmContext1
            // 
            this.mvvmContext1.ContainerControl = this;
            this.mvvmContext1.ViewModelType = typeof(Carservice.WinForm.ViewModels.ClientsViewModel);
            // 
            // stackPanel1
            // 
            this.stackPanel1.AutoSize = true;
            this.stackPanel1.Controls.Add(this.buttonClose);
            this.stackPanel1.Controls.Add(this.buttonOk);
            this.stackPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.stackPanel1.LayoutDirection = DevExpress.Utils.Layout.StackPanelLayoutDirection.RightToLeft;
            this.stackPanel1.Location = new System.Drawing.Point(0, 481);
            this.stackPanel1.Name = "stackPanel1";
            this.stackPanel1.Size = new System.Drawing.Size(912, 56);
            this.stackPanel1.TabIndex = 0;
            // 
            // buttonClose
            // 
            this.buttonClose.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("buttonClose.ImageOptions.Image")));
            this.buttonClose.Location = new System.Drawing.Point(792, 10);
            this.buttonClose.Margin = new System.Windows.Forms.Padding(10);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(110, 36);
            this.buttonClose.TabIndex = 0;
            this.buttonClose.Text = "Выход";
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            // 
            // splitContainerControl1.Panel1
            // 
            this.splitContainerControl1.Panel1.Controls.Add(this.groupControl1);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            // 
            // splitContainerControl1.Panel2
            // 
            this.splitContainerControl1.Panel2.Controls.Add(this.groupControl2);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(912, 481);
            this.splitContainerControl1.SplitterPosition = 310;
            this.splitContainerControl1.TabIndex = 1;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.listBoxClients);
            this.groupControl1.Controls.Add(this.stackPanel2);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(310, 481);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Клиенты";
            // 
            // listBoxClients
            // 
            this.listBoxClients.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxClients.Location = new System.Drawing.Point(2, 84);
            this.listBoxClients.Name = "listBoxClients";
            this.listBoxClients.Size = new System.Drawing.Size(306, 395);
            this.listBoxClients.TabIndex = 1;
            // 
            // stackPanel2
            // 
            this.stackPanel2.AutoSize = true;
            this.stackPanel2.Controls.Add(this.buttonAddClient);
            this.stackPanel2.Controls.Add(this.buttonEditClient);
            this.stackPanel2.Controls.Add(this.buttonDeleteClient);
            this.stackPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.stackPanel2.Location = new System.Drawing.Point(2, 28);
            this.stackPanel2.Name = "stackPanel2";
            this.stackPanel2.Size = new System.Drawing.Size(306, 56);
            this.stackPanel2.TabIndex = 0;
            // 
            // buttonAddClient
            // 
            this.buttonAddClient.AutoSize = true;
            this.buttonAddClient.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("buttonAddClient.ImageOptions.Image")));
            this.buttonAddClient.Location = new System.Drawing.Point(10, 10);
            this.buttonAddClient.Margin = new System.Windows.Forms.Padding(10);
            this.buttonAddClient.Name = "buttonAddClient";
            this.buttonAddClient.Size = new System.Drawing.Size(38, 36);
            this.buttonAddClient.TabIndex = 2;
            this.buttonAddClient.ToolTip = "Добавить клиента";
            // 
            // buttonEditClient
            // 
            this.buttonEditClient.AutoSize = true;
            this.buttonEditClient.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("buttonEditClient.ImageOptions.Image")));
            this.buttonEditClient.Location = new System.Drawing.Point(68, 10);
            this.buttonEditClient.Margin = new System.Windows.Forms.Padding(10);
            this.buttonEditClient.Name = "buttonEditClient";
            this.buttonEditClient.Size = new System.Drawing.Size(38, 36);
            this.buttonEditClient.TabIndex = 1;
            this.buttonEditClient.ToolTip = "Редактировать клиента";
            // 
            // buttonDeleteClient
            // 
            this.buttonDeleteClient.AutoSize = true;
            this.buttonDeleteClient.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("buttonDeleteClient.ImageOptions.Image")));
            this.buttonDeleteClient.Location = new System.Drawing.Point(126, 10);
            this.buttonDeleteClient.Margin = new System.Windows.Forms.Padding(10);
            this.buttonDeleteClient.Name = "buttonDeleteClient";
            this.buttonDeleteClient.Size = new System.Drawing.Size(38, 36);
            this.buttonDeleteClient.TabIndex = 0;
            this.buttonDeleteClient.ToolTip = "Удалить клиента";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.gridClients);
            this.groupControl2.Controls.Add(this.stackPanel3);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(0, 0);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(590, 481);
            this.groupControl2.TabIndex = 0;
            this.groupControl2.Text = "Автомобили клиентов";
            // 
            // gridClients
            // 
            this.gridClients.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridClients.Location = new System.Drawing.Point(2, 84);
            this.gridClients.MainView = this.gridViewClients;
            this.gridClients.Name = "gridClients";
            this.gridClients.Size = new System.Drawing.Size(586, 395);
            this.gridClients.TabIndex = 2;
            this.gridClients.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewClients});
            // 
            // gridViewClients
            // 
            this.gridViewClients.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.CarColor,
            this.CarBrand,
            this.CarModel,
            this.RegNumber,
            this.ProductionDate});
            this.gridViewClients.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            this.gridViewClients.GridControl = this.gridClients;
            this.gridViewClients.Name = "gridViewClients";
            this.gridViewClients.OptionsView.ShowIndicator = false;
            // 
            // CarColor
            // 
            this.CarColor.Caption = "Цвет";
            this.CarColor.FieldName = "Color";
            this.CarColor.MinWidth = 25;
            this.CarColor.Name = "CarColor";
            this.CarColor.OptionsColumn.AllowEdit = false;
            this.CarColor.OptionsColumn.AllowFocus = false;
            this.CarColor.Visible = true;
            this.CarColor.VisibleIndex = 0;
            this.CarColor.Width = 94;
            // 
            // CarBrand
            // 
            this.CarBrand.Caption = "Марка";
            this.CarBrand.FieldName = "BrandName";
            this.CarBrand.MinWidth = 25;
            this.CarBrand.Name = "CarBrand";
            this.CarBrand.OptionsColumn.AllowEdit = false;
            this.CarBrand.OptionsColumn.AllowFocus = false;
            this.CarBrand.Visible = true;
            this.CarBrand.VisibleIndex = 1;
            this.CarBrand.Width = 94;
            // 
            // CarModel
            // 
            this.CarModel.Caption = "Модель";
            this.CarModel.FieldName = "ModelName";
            this.CarModel.MinWidth = 25;
            this.CarModel.Name = "CarModel";
            this.CarModel.OptionsColumn.AllowEdit = false;
            this.CarModel.OptionsColumn.AllowFocus = false;
            this.CarModel.Visible = true;
            this.CarModel.VisibleIndex = 2;
            this.CarModel.Width = 94;
            // 
            // RegNumber
            // 
            this.RegNumber.Caption = "Гос. Номер";
            this.RegNumber.FieldName = "RegNumber";
            this.RegNumber.MinWidth = 25;
            this.RegNumber.Name = "RegNumber";
            this.RegNumber.OptionsColumn.AllowEdit = false;
            this.RegNumber.OptionsColumn.AllowFocus = false;
            this.RegNumber.Visible = true;
            this.RegNumber.VisibleIndex = 3;
            this.RegNumber.Width = 94;
            // 
            // ProductionDate
            // 
            this.ProductionDate.Caption = "Год выпуска";
            this.ProductionDate.DisplayFormat.FormatString = "Y";
            this.ProductionDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.ProductionDate.FieldName = "ProductionDate";
            this.ProductionDate.MinWidth = 25;
            this.ProductionDate.Name = "ProductionDate";
            this.ProductionDate.OptionsColumn.AllowEdit = false;
            this.ProductionDate.OptionsColumn.AllowFocus = false;
            this.ProductionDate.Visible = true;
            this.ProductionDate.VisibleIndex = 4;
            this.ProductionDate.Width = 94;
            // 
            // stackPanel3
            // 
            this.stackPanel3.AutoSize = true;
            this.stackPanel3.Controls.Add(this.buttonAddCar);
            this.stackPanel3.Controls.Add(this.buttonEditCar);
            this.stackPanel3.Controls.Add(this.buttonDeleteCar);
            this.stackPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.stackPanel3.Location = new System.Drawing.Point(2, 28);
            this.stackPanel3.Name = "stackPanel3";
            this.stackPanel3.Size = new System.Drawing.Size(586, 56);
            this.stackPanel3.TabIndex = 1;
            // 
            // buttonAddCar
            // 
            this.buttonAddCar.AutoSize = true;
            this.buttonAddCar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("buttonAddCar.ImageOptions.Image")));
            this.buttonAddCar.Location = new System.Drawing.Point(10, 10);
            this.buttonAddCar.Margin = new System.Windows.Forms.Padding(10);
            this.buttonAddCar.Name = "buttonAddCar";
            this.buttonAddCar.Size = new System.Drawing.Size(38, 36);
            this.buttonAddCar.TabIndex = 2;
            this.buttonAddCar.ToolTip = "Добавить автомобиль";
            // 
            // buttonEditCar
            // 
            this.buttonEditCar.AutoSize = true;
            this.buttonEditCar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("buttonEditCar.ImageOptions.Image")));
            this.buttonEditCar.Location = new System.Drawing.Point(68, 10);
            this.buttonEditCar.Margin = new System.Windows.Forms.Padding(10);
            this.buttonEditCar.Name = "buttonEditCar";
            this.buttonEditCar.Size = new System.Drawing.Size(38, 36);
            this.buttonEditCar.TabIndex = 1;
            this.buttonEditCar.ToolTip = "Редактировать автомобиль";
            // 
            // buttonDeleteCar
            // 
            this.buttonDeleteCar.AutoSize = true;
            this.buttonDeleteCar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("buttonDeleteCar.ImageOptions.Image")));
            this.buttonDeleteCar.Location = new System.Drawing.Point(126, 10);
            this.buttonDeleteCar.Margin = new System.Windows.Forms.Padding(10);
            this.buttonDeleteCar.Name = "buttonDeleteCar";
            this.buttonDeleteCar.Size = new System.Drawing.Size(38, 36);
            this.buttonDeleteCar.TabIndex = 0;
            this.buttonDeleteCar.ToolTip = "Удалить автомобиль";
            // 
            // buttonOk
            // 
            this.buttonOk.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.buttonOk.Location = new System.Drawing.Point(662, 10);
            this.buttonOk.Margin = new System.Windows.Forms.Padding(10);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(110, 36);
            this.buttonOk.TabIndex = 0;
            this.buttonOk.Text = "OK";
            // 
            // ClientsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainerControl1);
            this.Controls.Add(this.stackPanel1);
            this.Name = "ClientsView";
            this.Size = new System.Drawing.Size(912, 537);
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContext1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stackPanel1)).EndInit();
            this.stackPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel1)).EndInit();
            this.splitContainerControl1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel2)).EndInit();
            this.splitContainerControl1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listBoxClients)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stackPanel2)).EndInit();
            this.stackPanel2.ResumeLayout(false);
            this.stackPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridClients)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewClients)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stackPanel3)).EndInit();
            this.stackPanel3.ResumeLayout(false);
            this.stackPanel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.Utils.MVVM.MVVMContext mvvmContext1;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.Utils.Layout.StackPanel stackPanel1;
        private DevExpress.XtraEditors.SimpleButton buttonClose;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.ImageListBoxControl listBoxClients;
        private DevExpress.Utils.Layout.StackPanel stackPanel2;
        private DevExpress.XtraEditors.SimpleButton buttonAddClient;
        private DevExpress.XtraEditors.SimpleButton buttonEditClient;
        private DevExpress.XtraEditors.SimpleButton buttonDeleteClient;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraGrid.GridControl gridClients;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewClients;
        private DevExpress.XtraGrid.Columns.GridColumn CarColor;
        private DevExpress.XtraGrid.Columns.GridColumn CarBrand;
        private DevExpress.XtraGrid.Columns.GridColumn CarModel;
        private DevExpress.XtraGrid.Columns.GridColumn RegNumber;
        private DevExpress.XtraGrid.Columns.GridColumn ProductionDate;
        private DevExpress.Utils.Layout.StackPanel stackPanel3;
        private DevExpress.XtraEditors.SimpleButton buttonAddCar;
        private DevExpress.XtraEditors.SimpleButton buttonEditCar;
        private DevExpress.XtraEditors.SimpleButton buttonDeleteCar;
        private DevExpress.XtraEditors.SimpleButton buttonOk;
    }
}
