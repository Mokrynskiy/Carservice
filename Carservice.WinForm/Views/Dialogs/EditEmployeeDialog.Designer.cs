namespace Carservice.WinForm.Views.Dialogs
{
    partial class EditEmployeeDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditEmployeeDialog));
            this.tbSurname = new DevExpress.XtraEditors.TextEdit();
            this.tbName = new DevExpress.XtraEditors.TextEdit();
            this.tbPatronymic = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.buttonCancel = new DevExpress.XtraEditors.SimpleButton();
            this.buttonOk = new DevExpress.XtraEditors.SimpleButton();
            this.mvvmContext1 = new DevExpress.Utils.MVVM.MVVMContext(this.components);
            this.cbPositions = new DevExpress.XtraEditors.LookUpEdit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSurname.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbPatronymic.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContext1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbPositions.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // tbSurname
            // 
            this.tbSurname.Location = new System.Drawing.Point(162, 41);
            this.tbSurname.Name = "tbSurname";
            this.tbSurname.Size = new System.Drawing.Size(265, 22);
            this.tbSurname.TabIndex = 0;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(162, 70);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(265, 22);
            this.tbName.TabIndex = 1;
            // 
            // tbPatronymic
            // 
            this.tbPatronymic.Location = new System.Drawing.Point(162, 100);
            this.tbPatronymic.Name = "tbPatronymic";
            this.tbPatronymic.Size = new System.Drawing.Size(265, 22);
            this.tbPatronymic.TabIndex = 2;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(68, 44);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(53, 16);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "Фамилия";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(98, 73);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(23, 16);
            this.labelControl2.TabIndex = 5;
            this.labelControl2.Text = "Имя";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(68, 103);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(55, 16);
            this.labelControl3.TabIndex = 6;
            this.labelControl3.Text = "Отчество";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(57, 133);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(66, 16);
            this.labelControl4.TabIndex = 7;
            this.labelControl4.Text = "Должность";
            // 
            // buttonCancel
            // 
            this.buttonCancel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.buttonCancel.Location = new System.Drawing.Point(369, 184);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(110, 36);
            this.buttonCancel.TabIndex = 9;
            this.buttonCancel.Text = "Отмена";
            // 
            // buttonOk
            // 
            this.buttonOk.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.buttonOk.Location = new System.Drawing.Point(235, 184);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(110, 36);
            this.buttonOk.TabIndex = 10;
            this.buttonOk.Text = "Сохранить";
            // 
            // mvvmContext1
            // 
            this.mvvmContext1.ContainerControl = this;
            this.mvvmContext1.ViewModelType = typeof(Carservice.WinForm.Views.Dialogs.EditEmployeeDialogViewModel);
            // 
            // cbPositions
            // 
            this.cbPositions.Location = new System.Drawing.Point(162, 130);
            this.cbPositions.Name = "cbPositions";
            this.cbPositions.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbPositions.Size = new System.Drawing.Size(265, 22);
            this.cbPositions.TabIndex = 12;
            // 
            // EditEmployeeDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cbPositions);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.tbPatronymic);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.tbSurname);
            this.Name = "EditEmployeeDialog";
            this.Size = new System.Drawing.Size(499, 244);
            ((System.ComponentModel.ISupportInitialize)(this.tbSurname.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbPatronymic.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContext1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbPositions.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit tbSurname;
        private DevExpress.XtraEditors.TextEdit tbName;
        private DevExpress.XtraEditors.TextEdit tbPatronymic;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.Utils.MVVM.MVVMContext mvvmContext1;
        private DevExpress.XtraEditors.SimpleButton buttonOk;
        private DevExpress.XtraEditors.SimpleButton buttonCancel;
        private DevExpress.XtraEditors.LookUpEdit cbPositions;
    }
}
