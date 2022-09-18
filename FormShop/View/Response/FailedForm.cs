using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormShop.View
{
    public partial class FailedForm : Form
    {


        public FailedForm(string msg = "Dima gay")
        {
            InitializeComponent();
            ErrorMessage_LBL.Text = msg;
        }

        private void ErrorMessage_LBL_Click(object sender, EventArgs e)
        {

        }
    }
}
