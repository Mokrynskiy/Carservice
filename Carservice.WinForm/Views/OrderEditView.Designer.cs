namespace Carservice.WinForm.Views
{
    partial class OrderEditView
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
            this.mvvmContextOrderEdit = new DevExpress.Utils.MVVM.MVVMContext(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContextOrderEdit)).BeginInit();
            this.SuspendLayout();
            // 
            // mvvmContextOrderEdit
            // 
            this.mvvmContextOrderEdit.ContainerControl = this;
            this.mvvmContextOrderEdit.ViewModelType = typeof(Carservice.WinForm.ViewModels.OrderEditViewModel);
            // 
            // OrderEditView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "OrderEditView";
            this.Size = new System.Drawing.Size(1159, 548);
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContextOrderEdit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.Utils.MVVM.MVVMContext mvvmContextOrderEdit;
    }
}
