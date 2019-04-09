namespace StokTakip
{
    partial class PhonesManage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PhonesManage));
            this.cboxBrand = new System.Windows.Forms.ComboBox();
            this.gridPhones = new System.Windows.Forms.DataGridView();
            this.btnAddPhone = new System.Windows.Forms.Button();
            this.txtModelCode = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridPhones)).BeginInit();
            this.SuspendLayout();
            // 
            // cboxBrand
            // 
            resources.ApplyResources(this.cboxBrand, "cboxBrand");
            this.cboxBrand.FormattingEnabled = true;
            this.cboxBrand.Name = "cboxBrand";
            // 
            // gridPhones
            // 
            resources.ApplyResources(this.gridPhones, "gridPhones");
            this.gridPhones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridPhones.Name = "gridPhones";
            // 
            // btnAddPhone
            // 
            resources.ApplyResources(this.btnAddPhone, "btnAddPhone");
            this.btnAddPhone.Name = "btnAddPhone";
            this.btnAddPhone.UseVisualStyleBackColor = true;
            this.btnAddPhone.Click += new System.EventHandler(this.btnAddPhone_Click);
            // 
            // txtModelCode
            // 
            resources.ApplyResources(this.txtModelCode, "txtModelCode");
            this.txtModelCode.Name = "txtModelCode";
            // 
            // btnSearch
            // 
            resources.ApplyResources(this.btnSearch, "btnSearch");
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnDelete
            // 
            resources.ApplyResources(this.btnDelete, "btnDelete");
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // PhonesManage
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtModelCode);
            this.Controls.Add(this.btnAddPhone);
            this.Controls.Add(this.gridPhones);
            this.Controls.Add(this.cboxBrand);
            this.Name = "PhonesManage";
            this.Load += new System.EventHandler(this.PhonesManage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridPhones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboxBrand;
        private System.Windows.Forms.DataGridView gridPhones;
        private System.Windows.Forms.Button btnAddPhone;
        private System.Windows.Forms.TextBox txtModelCode;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnDelete;
    }
}