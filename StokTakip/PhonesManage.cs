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
    public partial class PhonesManage : Form
    {
        public PhonesManage()
        {
            InitializeComponent();
        }
        UnitOfWork _uw = new UnitOfWork();
        private void PhonesManage_Load(object sender, EventArgs e)
        {
            FillPhonesGrid();
            FillBrandsCombobox();
            
        }

        private void FillBrandsCombobox()
        {
            UIHelper.FillBrandCombobox(cboxBrand, Properties.Resources.AllBrands);
        }

        public void FillPhonesGrid()
        {
            gridPhones.DataSource = null;
            gridPhones.DataSource = _uw.Phones.GetPhonesForDisplay();
        }

        private void btnAddPhone_Click(object sender, EventArgs e)
        {
            new AddPhone().Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            _uw.Phones.DeletePhone((int)gridPhones.CurrentRow.Cells[0].Value);
            FillPhonesGrid();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            gridPhones.DataSource = null;
            var chosenBrandId = (int)cboxBrand.SelectedValue;
            
            gridPhones.DataSource = _uw.Phones.SearchPhone(chosenBrandId,txtModelCode.Text);
        }
    }
}
