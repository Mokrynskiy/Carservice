namespace Carservice.WinForm.Views
{
    partial class ServicesView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ServicesView));
            this.stackPanel1 = new DevExpress.Utils.Layout.StackPanel();
            this.buttonClose = new DevExpress.XtraEditors.SimpleButton();
            this.stackPanel2 = new DevExpress.Utils.Layout.StackPanel();
            this.buttonAddService = new DevExpress.XtraEditors.SimpleButton();
            this.buttonEditService = new DevExpress.XtraEditors.SimpleButton();
            this.buttonDeleteService = new DevExpress.XtraEditors.SimpleButton();
            this.gridServices = new DevExpress.XtraGrid.GridControl();
            this.gridViewServices = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MesureShortName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Cost = new DevExpress.XtraGrid.Columns.GridColumn();
            this.mvvmContext1 = new DevExpress.Utils.MVVM.MVVMContext(this.components);
            this.buttonOk = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.stackPanel1)).BeginInit();
            this.stackPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stackPanel2)).BeginInit();
            this.stackPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridServices)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewServices)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContext1)).BeginInit();
            this.SuspendLayout();
            // 
            // stackPanel1
            // 
            this.stackPanel1.AutoSize = true;
            this.stackPanel1.Controls.Add(this.buttonClose);
            this.stackPanel1.Controls.Add(this.buttonOk);
            this.stackPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.stackPanel1.LayoutDirection = DevExpress.Utils.Layout.StackPanelLayoutDirection.RightToLeft;
            this.stackPanel1.Location = new System.Drawing.Point(0, 336);
            this.stackPanel1.Name = "stackPanel1";
            this.stackPanel1.Size = new System.Drawing.Size(796, 56);
            this.stackPanel1.TabIndex = 0;
            // 
            // buttonClose
            // 
            this.buttonClose.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("buttonCancel.ImageOptions.Image")));
            this.buttonClose.Location = new System.Drawing.Point(676, 10);
            this.buttonClose.Margin = new System.Windows.Forms.Padding(10);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(110, 36);
            this.buttonClose.TabIndex = 0;
            this.buttonClose.Text = "Выход";
            // 
            // stackPanel2
            // 
            this.stackPanel2.AutoSize = true;
            this.stackPanel2.Controls.Add(this.buttonAddService);
            this.stackPanel2.Controls.Add(this.buttonEditService);
            this.stackPanel2.Controls.Add(this.buttonDeleteService);
            this.stackPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.stackPanel2.Location = new System.Drawing.Point(0, 0);
            this.stackPanel2.Name = "stackPanel2";
            this.stackPanel2.Size = new System.Drawing.Size(796, 56);
            this.stackPanel2.TabIndex = 1;
            // 
            // buttonAddService
            // 
            this.buttonAddService.AutoSize = true;
            this.buttonAddService.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("buttonAddService.ImageOptions.Image")));
            this.buttonAddService.Location = new System.Drawing.Point(10, 10);
            this.buttonAddService.Margin = new System.Windows.Forms.Padding(10);
            this.buttonAddService.Name = "buttonAddService";
            this.buttonAddService.Size = new System.Drawing.Size(38, 36);
            this.buttonAddService.TabIndex = 2;
            // 
            // buttonEditService
            // 
            this.buttonEditService.AutoSize = true;
            this.buttonEditService.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("buttonEditService.ImageOptions.Image")));
            this.buttonEditService.Location = new System.Drawing.Point(68, 10);
            this.buttonEditService.Margin = new System.Windows.Forms.Padding(10);
            this.buttonEditService.Name = "buttonEditService";
            this.buttonEditService.Size = new System.Drawing.Size(38, 36);
            this.buttonEditService.TabIndex = 1;
            // 
            // buttonDeleteService
            // 
            this.buttonDeleteService.AutoSize = true;
            this.buttonDeleteService.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("buttonDeleteService.ImageOptions.Image")));
            this.buttonDeleteService.Location = new System.Drawing.Point(126, 10);
            this.buttonDeleteService.Margin = new System.Windows.Forms.Padding(10);
            this.buttonDeleteService.Name = "buttonDeleteService";
            this.buttonDeleteService.Size = new System.Drawing.Size(38, 36);
            this.buttonDeleteService.TabIndex = 0;
            // 
            // gridServices
            // 
            this.gridServices.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridServices.Location = new System.Drawing.Point(0, 56);
            this.gridServices.MainView = this.gridViewServices;
            this.gridServices.Name = "gridServices";
            this.gridServices.Size = new System.Drawing.Size(796, 280);
            this.gridServices.TabIndex = 2;
            this.gridServices.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewServices});
            // 
            // gridViewServices
            // 
            this.gridViewServices.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Name,
            this.MesureShortName,
            this.Cost});
            this.gridViewServices.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            this.gridViewServices.GridControl = this.gridServices;
            this.gridViewServices.Name = "gridViewServices";
            this.gridViewServices.OptionsView.ShowIndicator = false;
            // 
            // Name
            // 
            this.Name.Caption = "Наименование услуги";
            this.Name.FieldName = "Name";
            this.Name.MinWidth = 25;
            this.Name.Name = "Name";
            this.Name.OptionsColumn.AllowEdit = false;
            this.Name.OptionsColumn.AllowFocus = false;
            this.Name.Visible = true;
            this.Name.VisibleIndex = 0;
            this.Name.Width = 94;
            // 
            // MesureShortName
            // 
            this.MesureShortName.Caption = "Ед. изм.";
            this.MesureShortName.FieldName = "MeasureShortName";
            this.MesureShortName.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Right;
            this.MesureShortName.MinWidth = 25;
            this.MesureShortName.Name = "MesureShortName";
            this.MesureShortName.OptionsColumn.AllowEdit = false;
            this.MesureShortName.OptionsColumn.AllowFocus = false;
            this.MesureShortName.Visible = true;
            this.MesureShortName.VisibleIndex = 1;
            this.MesureShortName.Width = 94;
            // 
            // Cost
            // 
            this.Cost.Caption = "Цена";
            this.Cost.DisplayFormat.FormatString = "c2";
            this.Cost.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.Cost.FieldName = "Cost";
            this.Cost.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Right;
            this.Cost.MinWidth = 25;
            this.Cost.Name = "Cost";
            this.Cost.OptionsColumn.AllowEdit = false;
            this.Cost.OptionsColumn.AllowFocus = false;
            this.Cost.Visible = true;
            this.Cost.VisibleIndex = 2;
            this.Cost.Width = 94;
            // 
            // mvvmContext1
            // 
            this.mvvmContext1.ContainerControl = this;
            this.mvvmContext1.ViewModelType = typeof(Carservice.WinForm.ViewModels.ServicesViewModel);
            // 
            // buttonOk
            // 
            this.buttonOk.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.buttonOk.Location = new System.Drawing.Point(546, 10);
            this.buttonOk.Margin = new System.Windows.Forms.Padding(10);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(110, 36);
            this.buttonOk.TabIndex = 0;
            this.buttonOk.Text = "Ок";
            // 
            // ServicesView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridServices);
            this.Controls.Add(this.stackPanel2);
            this.Controls.Add(this.stackPanel1);            
            this.Size = new System.Drawing.Size(796, 392);
            ((System.ComponentModel.ISupportInitialize)(this.stackPanel1)).EndInit();
            this.stackPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.stackPanel2)).EndInit();
            this.stackPanel2.ResumeLayout(false);
            this.stackPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridServices)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewServices)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContext1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.Utils.Layout.StackPanel stackPanel1;
        private DevExpress.XtraEditors.SimpleButton buttonClose;
        private DevExpress.Utils.Layout.StackPanel stackPanel2;
        private DevExpress.XtraEditors.SimpleButton buttonAddService;
        private DevExpress.XtraEditors.SimpleButton buttonEditService;
        private DevExpress.XtraEditors.SimpleButton buttonDeleteService;
        private DevExpress.XtraGrid.GridControl gridServices;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewServices;
        private DevExpress.Utils.MVVM.MVVMContext mvvmContext1;
        private DevExpress.XtraGrid.Columns.GridColumn Name;
        private DevExpress.XtraGrid.Columns.GridColumn MesureShortName;
        private DevExpress.XtraGrid.Columns.GridColumn Cost;
        private DevExpress.XtraEditors.SimpleButton buttonOk;
    }
}
