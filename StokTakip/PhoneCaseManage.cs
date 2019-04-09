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
    public partial class PhoneCaseManage : Form
    {
        public PhoneCaseManage()
        {
            InitializeComponent();
        }

        UnitOfWork _uw = new UnitOfWork();
        public void FillPhoneCasesGrid()
        {
            gridPhoneCase.DataSource = null;
            gridPhoneCase.DataSource = _uw.PhoneCases.GetPhoneCases();
        }

        private void PhoneCaseManage_Load(object sender, EventArgs e)
        {
            FillPhoneCasesGrid();
        }

        private void btnAddStock_Click(object sender, EventArgs e)
        {
            if(gridPhoneCase.SelectedRows.Count == 0)
                new PhoneCaseCreate().Show();
            else
            {
                int chosenId =(int) gridPhoneCase.SelectedRows[0].Cells["ID"].Value;
                PhoneCaseCreate f = new PhoneCaseCreate();
                f.Show();
                f.SelectPhoneCase(chosenId);
            }


        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in gridPhoneCase.SelectedRows)
            {
                int id = (int)item.Cells["ID"].Value;
                _uw.PhoneCases.Delete(id);
            }
           // _uw.PhoneCases.Delete((int)gridPhoneCase.CurrentRow.Cells[2].Value);
            FillPhoneCasesGrid();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            gridPhoneCase.ClearSelection();
            btnAddStock.PerformClick();
        }
    }
}
