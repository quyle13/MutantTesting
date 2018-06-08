using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MutantTestingApp
{
    public partial class frmMainForm : Form
    {
        public frmMainForm()
        {
            InitializeComponent();
            label6.Height = 2;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnShowMutant_Click(object sender, EventArgs e)
        {
            frmCompareCode compareForm = new frmCompareCode();
            compareForm.ShowDialog();
        }
    }
}
