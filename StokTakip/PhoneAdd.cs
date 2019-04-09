using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StokTakip
{
    public partial class AddPhone : Form
    {
        public AddPhone()
        {
            InitializeComponent();
        }
        UnitOfWork _uw = new UnitOfWork();
        private void AddPhone_Load(object sender, EventArgs e)
        {
            UIHelper.FillBrandCombobox(cboxBrands, Properties.Resources.Choose);
        }

        private void FillBrandsCombobox()
        {
            //cboxBrands.DisplayMember = "BrandName";
            //cboxBrands.ValueMember = "ID";
            //cboxBrands.DataSource = _uw.Brands.GetBrands();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Phone p = new Phone();
            p.ProductName = txtProductName.Text;
            p.Price = numericPrice.Value;
            p.IMEI1 = txtIMEI1.Text;
            p.IMEI2 = txtIMEI2.Text;
            p.ModelCode = txtCode.Text;
            p.Brand =(Brand) cboxBrands.SelectedItem;
            _uw.Phones.InsertPhone(p);
            RefreshMainPhoneGrid();
        }

        private void RefreshMainPhoneGrid()
        {
            Form openForm = Application.OpenForms["PhonesManage"];
            PhonesManage pcForm = (PhonesManage)openForm;
            pcForm.FillPhonesGrid();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            txtProductName.Clear();
            numericPrice.Value = 0;
            txtIMEI1.Clear();
            txtIMEI2.Clear();
            txtCode.Clear();
            
        }
    }
}
