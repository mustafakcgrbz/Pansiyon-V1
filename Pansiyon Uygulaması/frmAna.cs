using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pansiyon_Uygulaması
{
    public partial class frmAna : Form
    {
        public frmAna()
        {
            InitializeComponent();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            frmLogin form = new frmLogin();
            form.Show();
            this.Hide();
        }

        private void btnYeniMusteri_Click(object sender, EventArgs e)
        {
            frmYeniMusteri form = new frmYeniMusteri();
            form.Show();

        }

        private void btnOdalar_Click(object sender, EventArgs e)
        {
            frmOdalar form = new frmOdalar();
            form.Show();
        }

        private void btnMusteriler_Click(object sender, EventArgs e)
        {
            frmMusteriler form = new frmMusteriler();
            form.Show();
        }
    }
}
