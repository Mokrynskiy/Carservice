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
            this.tbSurname = new DevExpress.XtraEditors.TextEdit();
            this.tbName = new DevExpress.XtraEditors.TextEdit();
            this.tbPatronymic = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.cbPosition = new DevExpress.XtraEditors.ComboBoxEdit();
            this.mvvmContext1 = new DevExpress.Utils.MVVM.MVVMContext(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.tbSurname.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbPatronymic.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbPosition.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContext1)).BeginInit();
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
            // cbPosition
            // 
            this.cbPosition.Location = new System.Drawing.Point(162, 130);
            this.cbPosition.Name = "cbPosition";
            this.cbPosition.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbPosition.Size = new System.Drawing.Size(265, 22);
            this.cbPosition.TabIndex = 8;
            // 
            // mvvmContext1
            // 
            this.mvvmContext1.ContainerControl = this;
            this.mvvmContext1.ViewModelType = typeof(Carservice.WinForm.Views.Dialogs.EditEmployeeDialogViewModel);
            // 
            // EditEmployeeDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cbPosition);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.tbPatronymic);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.tbSurname);
            this.Name = "EditEmployeeDialog";
            this.Size = new System.Drawing.Size(499, 200);
            ((System.ComponentModel.ISupportInitialize)(this.tbSurname.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbPatronymic.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbPosition.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContext1)).EndInit();
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
        private DevExpress.XtraEditors.ComboBoxEdit cbPosition;
        private DevExpress.Utils.MVVM.MVVMContext mvvmContext1;
    }
}
