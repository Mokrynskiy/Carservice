namespace Carservice.WinForm.Views
{
    partial class CarCatalogView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CarCatalogView));
            this.stackPanel1 = new DevExpress.Utils.Layout.StackPanel();
            this.buttonCancel = new DevExpress.XtraEditors.SimpleButton();
            this.buttonOk = new DevExpress.XtraEditors.SimpleButton();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.stackPanel2 = new DevExpress.Utils.Layout.StackPanel();
            this.buttonAddBrand = new DevExpress.XtraEditors.SimpleButton();
            this.toolTipController1 = new DevExpress.Utils.ToolTipController(this.components);
            this.buttonEditBrand = new DevExpress.XtraEditors.SimpleButton();
            this.buttonDeleteBrand = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.stackPanel3 = new DevExpress.Utils.Layout.StackPanel();
            this.buttonAddModel = new DevExpress.XtraEditors.SimpleButton();
            this.buttonEditModel = new DevExpress.XtraEditors.SimpleButton();
            this.buttonDeleteModel = new DevExpress.XtraEditors.SimpleButton();
            this.mvvmContext1 = new DevExpress.Utils.MVVM.MVVMContext(this.components);
            this.listBoxBrands = new DevExpress.XtraEditors.ImageListBoxControl();
            this.listBoxModels = new DevExpress.XtraEditors.ImageListBoxControl();
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
            ((System.ComponentModel.ISupportInitialize)(this.stackPanel2)).BeginInit();
            this.stackPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stackPanel3)).BeginInit();
            this.stackPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContext1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listBoxBrands)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listBoxModels)).BeginInit();
            this.SuspendLayout();
            // 
            // stackPanel1
            // 
            this.stackPanel1.AutoSize = true;
            this.stackPanel1.Controls.Add(this.buttonCancel);
            this.stackPanel1.Controls.Add(this.buttonOk);
            this.stackPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.stackPanel1.LayoutDirection = DevExpress.Utils.Layout.StackPanelLayoutDirection.RightToLeft;
            this.stackPanel1.Location = new System.Drawing.Point(0, 422);
            this.stackPanel1.Name = "stackPanel1";
            this.stackPanel1.Size = new System.Drawing.Size(740, 55);
            this.stackPanel1.TabIndex = 5;
            // 
            // buttonCancel
            // 
            this.buttonCancel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("buttonCancel.ImageOptions.Image")));
            this.buttonCancel.Location = new System.Drawing.Point(610, 10);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(3, 10, 20, 10);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(110, 35);
            this.buttonCancel.TabIndex = 1;
            this.buttonCancel.Text = "Отмена";
            // 
            // buttonOk
            // 
            this.buttonOk.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("buttonOk.ImageOptions.Image")));
            this.buttonOk.Location = new System.Drawing.Point(467, 10);
            this.buttonOk.Margin = new System.Windows.Forms.Padding(3, 10, 30, 10);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(110, 35);
            this.buttonOk.TabIndex = 0;
            this.buttonOk.Text = "Применить";
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.FixedPanel = DevExpress.XtraEditors.SplitFixedPanel.None;
            this.splitContainerControl1.IsSplitterFixed = true;
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
            this.splitContainerControl1.Size = new System.Drawing.Size(740, 422);
            this.splitContainerControl1.SplitterPosition = 349;
            this.splitContainerControl1.TabIndex = 6;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.listBoxBrands);
            this.groupControl1.Controls.Add(this.stackPanel2);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(349, 422);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Марка автомобиля";
            // 
            // stackPanel2
            // 
            this.stackPanel2.AutoSize = true;
            this.stackPanel2.Controls.Add(this.buttonAddBrand);
            this.stackPanel2.Controls.Add(this.buttonEditBrand);
            this.stackPanel2.Controls.Add(this.buttonDeleteBrand);
            this.stackPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.stackPanel2.Location = new System.Drawing.Point(2, 28);
            this.stackPanel2.Name = "stackPanel2";
            this.stackPanel2.Size = new System.Drawing.Size(345, 46);
            this.stackPanel2.TabIndex = 1;
            // 
            // buttonAddBrand
            // 
            this.buttonAddBrand.AutoSize = true;
            this.buttonAddBrand.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("buttonAddBrand.ImageOptions.Image")));
            this.buttonAddBrand.Location = new System.Drawing.Point(5, 5);
            this.buttonAddBrand.Margin = new System.Windows.Forms.Padding(5);
            this.buttonAddBrand.Name = "buttonAddBrand";
            this.buttonAddBrand.Size = new System.Drawing.Size(38, 36);
            this.buttonAddBrand.TabIndex = 2;
            this.buttonAddBrand.ToolTip = "марку автомобиля";
            this.buttonAddBrand.ToolTipController = this.toolTipController1;
            this.buttonAddBrand.ToolTipTitle = "Добавить";
            // 
            // buttonEditBrand
            // 
            this.buttonEditBrand.AutoSize = true;
            this.buttonEditBrand.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("buttonEditBrand.ImageOptions.Image")));
            this.buttonEditBrand.Location = new System.Drawing.Point(53, 5);
            this.buttonEditBrand.Margin = new System.Windows.Forms.Padding(5);
            this.buttonEditBrand.Name = "buttonEditBrand";
            this.buttonEditBrand.Size = new System.Drawing.Size(38, 36);
            this.buttonEditBrand.TabIndex = 1;
            this.buttonEditBrand.ToolTip = "марку автомобиля";
            this.buttonEditBrand.ToolTipController = this.toolTipController1;
            this.buttonEditBrand.ToolTipTitle = "Редактировать";
            // 
            // buttonDeleteBrand
            // 
            this.buttonDeleteBrand.AutoSize = true;
            this.buttonDeleteBrand.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("buttonDeleteBrand.ImageOptions.Image")));
            this.buttonDeleteBrand.Location = new System.Drawing.Point(101, 5);
            this.buttonDeleteBrand.Margin = new System.Windows.Forms.Padding(5);
            this.buttonDeleteBrand.Name = "buttonDeleteBrand";
            this.buttonDeleteBrand.Size = new System.Drawing.Size(38, 36);
            this.buttonDeleteBrand.TabIndex = 0;
            this.buttonDeleteBrand.ToolTip = "марку автомобиля";
            this.buttonDeleteBrand.ToolTipController = this.toolTipController1;
            this.buttonDeleteBrand.ToolTipTitle = "Удалить";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.listBoxModels);
            this.groupControl2.Controls.Add(this.stackPanel3);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(0, 0);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(379, 422);
            this.groupControl2.TabIndex = 0;
            this.groupControl2.Text = "Модель автомобиля";
            // 
            // stackPanel3
            // 
            this.stackPanel3.AutoSize = true;
            this.stackPanel3.Controls.Add(this.buttonAddModel);
            this.stackPanel3.Controls.Add(this.buttonEditModel);
            this.stackPanel3.Controls.Add(this.buttonDeleteModel);
            this.stackPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.stackPanel3.Location = new System.Drawing.Point(2, 28);
            this.stackPanel3.Name = "stackPanel3";
            this.stackPanel3.Size = new System.Drawing.Size(375, 46);
            this.stackPanel3.TabIndex = 2;
            // 
            // buttonAddModel
            // 
            this.buttonAddModel.AutoSize = true;
            this.buttonAddModel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("buttonAddModel.ImageOptions.Image")));
            this.buttonAddModel.Location = new System.Drawing.Point(5, 5);
            this.buttonAddModel.Margin = new System.Windows.Forms.Padding(5);
            this.buttonAddModel.Name = "buttonAddModel";
            this.buttonAddModel.Size = new System.Drawing.Size(38, 36);
            this.buttonAddModel.TabIndex = 2;
            this.buttonAddModel.ToolTip = "модель автомобиля";
            this.buttonAddModel.ToolTipController = this.toolTipController1;
            this.buttonAddModel.ToolTipTitle = "Добавить";
            // 
            // buttonEditModel
            // 
            this.buttonEditModel.AutoSize = true;
            this.buttonEditModel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("buttonEditModel.ImageOptions.Image")));
            this.buttonEditModel.Location = new System.Drawing.Point(53, 5);
            this.buttonEditModel.Margin = new System.Windows.Forms.Padding(5);
            this.buttonEditModel.Name = "buttonEditModel";
            this.buttonEditModel.Size = new System.Drawing.Size(38, 36);
            this.buttonEditModel.TabIndex = 1;
            this.buttonEditModel.ToolTip = "модель автомобиля";
            this.buttonEditModel.ToolTipController = this.toolTipController1;
            this.buttonEditModel.ToolTipTitle = "Редактировать";
            // 
            // buttonDeleteModel
            // 
            this.buttonDeleteModel.AutoSize = true;
            this.buttonDeleteModel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("buttonDeleteModel.ImageOptions.Image")));
            this.buttonDeleteModel.Location = new System.Drawing.Point(101, 5);
            this.buttonDeleteModel.Margin = new System.Windows.Forms.Padding(5);
            this.buttonDeleteModel.Name = "buttonDeleteModel";
            this.buttonDeleteModel.Size = new System.Drawing.Size(38, 36);
            this.buttonDeleteModel.TabIndex = 0;
            this.buttonDeleteModel.ToolTip = "модель автомобиля";
            this.buttonDeleteModel.ToolTipController = this.toolTipController1;
            this.buttonDeleteModel.ToolTipTitle = "Удалить";
            // 
            // mvvmContext1
            // 
            this.mvvmContext1.ContainerControl = this;
            this.mvvmContext1.ViewModelType = typeof(Carservice.WinForm.ViewModels.CarCatalogViewModel);
            // 
            // listBoxBrands
            // 
            this.listBoxBrands.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxBrands.Location = new System.Drawing.Point(2, 74);
            this.listBoxBrands.Name = "listBoxBrands";
            this.listBoxBrands.Size = new System.Drawing.Size(345, 346);
            this.listBoxBrands.TabIndex = 2;
            // 
            // listBoxModels
            // 
            this.listBoxModels.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxModels.Location = new System.Drawing.Point(2, 74);
            this.listBoxModels.Name = "listBoxModels";
            this.listBoxModels.Size = new System.Drawing.Size(375, 346);
            this.listBoxModels.TabIndex = 3;
            // 
            // CarCatalogView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainerControl1);
            this.Controls.Add(this.stackPanel1);
            this.Name = "CarCatalogView";
            this.Size = new System.Drawing.Size(740, 477);
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
            ((System.ComponentModel.ISupportInitialize)(this.stackPanel2)).EndInit();
            this.stackPanel2.ResumeLayout(false);
            this.stackPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stackPanel3)).EndInit();
            this.stackPanel3.ResumeLayout(false);
            this.stackPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContext1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listBoxBrands)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listBoxModels)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.Utils.Layout.StackPanel stackPanel1;
        private DevExpress.XtraEditors.SimpleButton buttonOk;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.Utils.Layout.StackPanel stackPanel2;
        private DevExpress.XtraEditors.SimpleButton buttonAddBrand;
        private DevExpress.Utils.ToolTipController toolTipController1;
        private DevExpress.XtraEditors.SimpleButton buttonEditBrand;
        private DevExpress.XtraEditors.SimpleButton buttonDeleteBrand;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.Utils.Layout.StackPanel stackPanel3;
        private DevExpress.XtraEditors.SimpleButton buttonAddModel;
        private DevExpress.XtraEditors.SimpleButton buttonEditModel;
        private DevExpress.XtraEditors.SimpleButton buttonDeleteModel;
        private DevExpress.XtraEditors.SimpleButton buttonCancel;
        private DevExpress.Utils.MVVM.MVVMContext mvvmContext1;
        private DevExpress.XtraEditors.ImageListBoxControl listBoxBrands;
        private DevExpress.XtraEditors.ImageListBoxControl listBoxModels;
    }
}
