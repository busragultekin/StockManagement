using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StokTakip
{
    public partial class PhoneCaseCreate : Form
    {
        public PhoneCaseCreate()
        {
            InitializeComponent();
        }
        UnitOfWork _uw = new UnitOfWork();
        private void btnSave_Click(object sender, EventArgs e)
        {
            PhoneCase pc = new PhoneCase();
            pc.ProductName = txtProductName.Text;
            pc.CaseColor =(CaseColor) cboxColor.SelectedIndex;
            pc.Price =(int) numericPrice.Value;
            pc.Quantity = (int)numericQty.Value;
            _uw.PhoneCases.InsertPhoneCase(pc);
            RefreshMainGrid();
            FillPhoneCasesCombo();
        }

        private void RefreshMainGrid()
        {
            PhoneCaseManage f = (PhoneCaseManage)Application.OpenForms["PhoneCaseManage"];
            if (f != null)
                f.FillPhoneCasesGrid();
        }

        public void SelectPhoneCase(int chosenId)
        {
            tabControl1.SelectTab(1);
            cb_cases.SelectedValue = chosenId;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtProductName.Clear();            
            numericPrice.Value = 0;
            numericQty.Value = 0;
        }

        private void PhoneCaseCreate_Load(object sender, EventArgs e)
        {
            FillColorsCombo();
            FillPhoneCasesCombo();
            RefreshCurrentStock();
        }

        private void FillPhoneCasesCombo()
        {
            cb_cases.DataSource = null;
            cb_cases.DisplayMember = "ProductName";
            cb_cases.ValueMember = "ID";
            cb_cases.DataSource = _uw.PhoneCases.GetPhoneCases();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int id = (int)cb_cases.SelectedValue;
            int qty = (int)nm_qty.Value;
            _uw.PhoneCases.AddStockToPhoneCase(id, qty);
            RefreshMainGrid();
            FillPhoneCasesCombo();
        }
        private void FillColorsCombo()
        {
            Type T = typeof(CaseColor);
            List<string> options;
            if (CultureInfo.CurrentUICulture.TwoLetterISOLanguageName == "en")
            {
                //Normal değerler(türkçe)
                options = T.GetEnumNames().ToList();//string[]-->List<string>
            }
            else
            {
                var attrs = T.GetFields().SelectMany(x => x.CustomAttributes);
                var attrName = attrs.SelectMany(x => x.ConstructorArguments);
                options = attrName.Select(x => (string)x.Value).ToList();
            }
            cboxColor.DataSource = options;
        }
        private void RefreshCurrentStock()
        {
            if (cb_cases.SelectedItem == null)
                return;
            string template = CultureInfo.CurrentUICulture.TwoLetterISOLanguageName=="en"? "Stock will be updated as 0 when saved." : "Kaydettiğinizde adet 0 olarak güncellenecektir.";
            var chosenCase = (PhoneCase)cb_cases.SelectedItem;
            var currentStock = chosenCase.Quantity;
            int latest = currentStock + (int)nm_qty.Value;
            lbl_info.Text = template.Replace("0", latest.ToString());
        }

        private void cb_cases_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshCurrentStock();
        }

        private void nm_qty_ValueChanged(object sender, EventArgs e)
        {
            RefreshCurrentStock();
        }

        private void nm_qty_KeyUp(object sender, KeyEventArgs e)
        {
            RefreshCurrentStock();
        }

        private void nm_qty_Scroll(object sender, ScrollEventArgs e)
        {
            RefreshCurrentStock();
        }
    }
}
