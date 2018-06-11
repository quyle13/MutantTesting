using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace MutantTestingApp
{
    public partial class XMainForm : DevExpress.XtraEditors.XtraForm
    {
        public XMainForm()
        {
            InitializeComponent();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
            {
                this.Close();
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void btnShowMutant_Click(object sender, EventArgs e)
        {
            XCompareCode compareForm = new XCompareCode();
            compareForm.Show();
        }
    }
}