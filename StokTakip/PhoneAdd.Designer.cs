namespace StokTakip
{
    partial class AddPhone
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddPhone));
            this.lblProductName = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblIMEI1 = new System.Windows.Forms.Label();
            this.lblIMEI2 = new System.Windows.Forms.Label();
            this.lblModelCode = new System.Windows.Forms.Label();
            this.lblBrand = new System.Windows.Forms.Label();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.txtIMEI1 = new System.Windows.Forms.TextBox();
            this.txtIMEI2 = new System.Windows.Forms.TextBox();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.cboxBrands = new System.Windows.Forms.ComboBox();
            this.numericPrice = new System.Windows.Forms.NumericUpDown();
            this.btnSave = new System.Windows.Forms.Button();
            this.btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // lblProductName
            // 
            resources.ApplyResources(this.lblProductName, "lblProductName");
            this.lblProductName.Name = "lblProductName";
            // 
            // lblPrice
            // 
            resources.ApplyResources(this.lblPrice, "lblPrice");
            this.lblPrice.Name = "lblPrice";
            // 
            // lblIMEI1
            // 
            resources.ApplyResources(this.lblIMEI1, "lblIMEI1");
            this.lblIMEI1.Name = "lblIMEI1";
            // 
            // lblIMEI2
            // 
            resources.ApplyResources(this.lblIMEI2, "lblIMEI2");
            this.lblIMEI2.Name = "lblIMEI2";
            // 
            // lblModelCode
            // 
            resources.ApplyResources(this.lblModelCode, "lblModelCode");
            this.lblModelCode.Name = "lblModelCode";
            // 
            // lblBrand
            // 
            resources.ApplyResources(this.lblBrand, "lblBrand");
            this.lblBrand.Name = "lblBrand";
            // 
            // txtProductName
            // 
            resources.ApplyResources(this.txtProductName, "txtProductName");
            this.txtProductName.Name = "txtProductName";
            // 
            // txtIMEI1
            // 
            resources.ApplyResources(this.txtIMEI1, "txtIMEI1");
            this.txtIMEI1.Name = "txtIMEI1";
            // 
            // txtIMEI2
            // 
            resources.ApplyResources(this.txtIMEI2, "txtIMEI2");
            this.txtIMEI2.Name = "txtIMEI2";
            // 
            // txtCode
            // 
            resources.ApplyResources(this.txtCode, "txtCode");
            this.txtCode.Name = "txtCode";
            // 
            // cboxBrands
            // 
            resources.ApplyResources(this.cboxBrands, "cboxBrands");
            this.cboxBrands.FormattingEnabled = true;
            this.cboxBrands.Name = "cboxBrands";
            // 
            // numericPrice
            // 
            resources.ApplyResources(this.numericPrice, "numericPrice");
            this.numericPrice.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericPrice.Name = "numericPrice";
            // 
            // btnSave
            // 
            resources.ApplyResources(this.btnSave, "btnSave");
            this.btnSave.Name = "btnSave";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btn
            // 
            resources.ApplyResources(this.btn, "btn");
            this.btn.Name = "btn";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // AddPhone
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.numericPrice);
            this.Controls.Add(this.cboxBrands);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.txtIMEI2);
            this.Controls.Add(this.txtIMEI1);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.lblBrand);
            this.Controls.Add(this.lblModelCode);
            this.Controls.Add(this.lblIMEI2);
            this.Controls.Add(this.lblIMEI1);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblProductName);
            this.Name = "AddPhone";
            this.Load += new System.EventHandler(this.AddPhone_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericPrice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblIMEI1;
        private System.Windows.Forms.Label lblIMEI2;
        private System.Windows.Forms.Label lblModelCode;
        private System.Windows.Forms.Label lblBrand;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.TextBox txtIMEI1;
        private System.Windows.Forms.TextBox txtIMEI2;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.ComboBox cboxBrands;
        private System.Windows.Forms.NumericUpDown numericPrice;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btn;
    }
}