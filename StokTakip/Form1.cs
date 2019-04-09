using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Windows.Forms;

namespace StokTakip
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void markalarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BrandManage f = new BrandManage();
            f.MdiParent = this;
            f.Show();
            //new BrandManage().Show();
        }

        private void telefonlarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PhonesManage f = new PhonesManage();
            f.MdiParent = this;
            f.Show();
           // new PhonesManage().Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }
        

        private void türkçeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ayar.ChangeLanguge(Languages.tr); 
            this.Controls.Clear();
            InitializeComponent();
        }

        private void englishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ayar.ChangeLanguge(Languages.en);       
            this.Controls.Clear();
            InitializeComponent();
        }

        private void telefonKılıflarıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PhoneCaseManage f = new PhoneCaseManage();
            f.MdiParent = this;
            f.Show();
        }

        private void satışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sales f = new Sales();
            f.MdiParent = this;
            f.Show();
        }
    }
}
