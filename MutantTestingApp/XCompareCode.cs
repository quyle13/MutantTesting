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
    public partial class XCompareCode : DevExpress.XtraEditors.XtraForm
    {
        public XCompareCode()
        {
            InitializeComponent();
        }

        private void labelControl1_Click(object sender, EventArgs e)
        {

        }

        private void simpleButtonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}