using StokTakip.BusinessLogic;
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
    public partial class BrandManage : Form
    {
        public BrandManage()
        {
            InitializeComponent();
        }
        UnitOfWork _uw = new UnitOfWork();
        //BrandRepo b = new BrandRepo();
        private void BrandManage_Load(object sender, EventArgs e)
        {

            RefreshListBox();
        }

        private void RefreshListBox()
        {
            lst_Brands.DisplayMember = "BrandName";
            lst_Brands.ValueMember = "ID";
            lst_Brands.DataSource = _uw.Brands.GetBrands();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Brand b = new Brand();
            b.BrandName = txtBrandName.Text;
            _uw.Brands.InsertBrand(b);
            MessageBox.Show("Kaydedildi");
            lst_Brands.DataSource = null;
            BrandManage_Load(sender, e);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            _uw.Brands.DeleteBrand((int)lst_Brands.SelectedValue);
            RefreshListBox();
        }
    }
}
