namespace Carservice.WinForm.Views
{
    partial class EmployeesView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeesView));
            this.mvvmContext1 = new DevExpress.Utils.MVVM.MVVMContext(this.components);
            this.stackPanel1 = new DevExpress.Utils.Layout.StackPanel();
            this.buttonAdd = new DevExpress.XtraEditors.SimpleButton();
            this.buttonEdit = new DevExpress.XtraEditors.SimpleButton();
            this.buttonDelete = new DevExpress.XtraEditors.SimpleButton();
            this.stackPanel2 = new DevExpress.Utils.Layout.StackPanel();
            this.buttonClose = new DevExpress.XtraEditors.SimpleButton();
            this.gridEmployee = new DevExpress.XtraGrid.GridControl();
            this.gridViewEmployee = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Surname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Patronymic = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PositionName = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContext1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stackPanel1)).BeginInit();
            this.stackPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stackPanel2)).BeginInit();
            this.stackPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridEmployee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewEmployee)).BeginInit();
            this.SuspendLayout();
            // 
            // mvvmContext1
            // 
            this.mvvmContext1.ContainerControl = this;
            this.mvvmContext1.ViewModelType = typeof(Carservice.WinForm.ViewModels.EmployeesViewModel);
            // 
            // stackPanel1
            // 
            this.stackPanel1.AutoSize = true;
            this.stackPanel1.Controls.Add(this.buttonAdd);
            this.stackPanel1.Controls.Add(this.buttonEdit);
            this.stackPanel1.Controls.Add(this.buttonDelete);
            this.stackPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.stackPanel1.Location = new System.Drawing.Point(0, 0);
            this.stackPanel1.Name = "stackPanel1";
            this.stackPanel1.Size = new System.Drawing.Size(822, 42);
            this.stackPanel1.TabIndex = 0;
            // 
            // buttonAdd
            // 
            this.buttonAdd.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("buttonAdd.ImageOptions.Image")));
            this.buttonAdd.Location = new System.Drawing.Point(3, 3);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(150, 36);
            this.buttonAdd.TabIndex = 1;
            this.buttonAdd.Text = "Добавить";
            // 
            // buttonEdit
            // 
            this.buttonEdit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("buttonEdit.ImageOptions.Image")));
            this.buttonEdit.Location = new System.Drawing.Point(159, 3);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(150, 36);
            this.buttonEdit.TabIndex = 0;
            this.buttonEdit.Text = "Редактировать";
            // 
            // buttonDelete
            // 
            this.buttonDelete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("buttonDelete.ImageOptions.Image")));
            this.buttonDelete.Location = new System.Drawing.Point(315, 3);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(150, 36);
            this.buttonDelete.TabIndex = 2;
            this.buttonDelete.Text = "Удалить";
            // 
            // stackPanel2
            // 
            this.stackPanel2.AutoSize = true;
            this.stackPanel2.Controls.Add(this.buttonClose);
            this.stackPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.stackPanel2.LayoutDirection = DevExpress.Utils.Layout.StackPanelLayoutDirection.RightToLeft;
            this.stackPanel2.Location = new System.Drawing.Point(0, 402);
            this.stackPanel2.Name = "stackPanel2";
            this.stackPanel2.Size = new System.Drawing.Size(822, 56);
            this.stackPanel2.TabIndex = 1;
            // 
            // buttonClose
            // 
            this.buttonClose.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("buttonClose.ImageOptions.Image")));
            this.buttonClose.Location = new System.Drawing.Point(702, 10);
            this.buttonClose.Margin = new System.Windows.Forms.Padding(10);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(110, 36);
            this.buttonClose.TabIndex = 0;
            this.buttonClose.Text = "Выход";
            // 
            // gridEmployee
            // 
            this.gridEmployee.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridEmployee.Location = new System.Drawing.Point(0, 42);
            this.gridEmployee.MainView = this.gridViewEmployee;
            this.gridEmployee.Name = "gridEmployee";
            this.gridEmployee.Size = new System.Drawing.Size(822, 360);
            this.gridEmployee.TabIndex = 2;
            this.gridEmployee.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewEmployee});
            // 
            // gridViewEmployee
            // 
            this.gridViewEmployee.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Surname,
            this.Name,
            this.Patronymic,
            this.PositionName});
            this.gridViewEmployee.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            this.gridViewEmployee.GridControl = this.gridEmployee;
            this.gridViewEmployee.Name = "gridViewEmployee";
            // 
            // Surname
            // 
            this.Surname.Caption = "Фамилия";
            this.Surname.FieldName = "Surname";
            this.Surname.MinWidth = 25;
            this.Surname.Name = "Surname";
            this.Surname.OptionsColumn.AllowEdit = false;
            this.Surname.OptionsColumn.AllowFocus = false;
            this.Surname.Visible = true;
            this.Surname.VisibleIndex = 0;
            this.Surname.Width = 94;
            // 
            // Name
            // 
            this.Name.Caption = "Имя";
            this.Name.FieldName = "Name";
            this.Name.MinWidth = 25;
            this.Name.Name = "Name";
            this.Name.OptionsColumn.AllowEdit = false;
            this.Name.OptionsColumn.AllowFocus = false;
            this.Name.Visible = true;
            this.Name.VisibleIndex = 1;
            this.Name.Width = 94;
            // 
            // Patronymic
            // 
            this.Patronymic.Caption = "Отчество";
            this.Patronymic.FieldName = "Patronymic";
            this.Patronymic.MinWidth = 25;
            this.Patronymic.Name = "Patronymic";
            this.Patronymic.OptionsColumn.AllowEdit = false;
            this.Patronymic.OptionsColumn.AllowFocus = false;
            this.Patronymic.Visible = true;
            this.Patronymic.VisibleIndex = 2;
            this.Patronymic.Width = 94;
            // 
            // PositionName
            // 
            this.PositionName.Caption = "Должность";
            this.PositionName.FieldName = "PositionName";
            this.PositionName.MinWidth = 25;
            this.PositionName.Name = "PositionName";
            this.PositionName.OptionsColumn.AllowEdit = false;
            this.PositionName.OptionsColumn.AllowFocus = false;
            this.PositionName.Visible = true;
            this.PositionName.VisibleIndex = 3;
            this.PositionName.Width = 94;
            // 
            // EmployeesView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridEmployee);
            this.Controls.Add(this.stackPanel2);
            this.Controls.Add(this.stackPanel1);            
            this.Size = new System.Drawing.Size(822, 458);
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContext1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stackPanel1)).EndInit();
            this.stackPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.stackPanel2)).EndInit();
            this.stackPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridEmployee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewEmployee)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.Utils.MVVM.MVVMContext mvvmContext1;
        private DevExpress.XtraGrid.GridControl gridEmployee;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewEmployee;
        private DevExpress.XtraGrid.Columns.GridColumn Surname;
        private DevExpress.XtraGrid.Columns.GridColumn Name;
        private DevExpress.XtraGrid.Columns.GridColumn Patronymic;
        private DevExpress.XtraGrid.Columns.GridColumn PositionName;
        private DevExpress.Utils.Layout.StackPanel stackPanel2;
        private DevExpress.XtraEditors.SimpleButton buttonClose;
        private DevExpress.Utils.Layout.StackPanel stackPanel1;
        private DevExpress.XtraEditors.SimpleButton buttonAdd;
        private DevExpress.XtraEditors.SimpleButton buttonEdit;
        private DevExpress.XtraEditors.SimpleButton buttonDelete;
    }
}
