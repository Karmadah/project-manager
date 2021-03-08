using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using project_manager.setup;

namespace project_manager
{
    public partial class f_make_or_open : Form
    {
        public f_make_or_open()
        {
            InitializeComponent();
        }

        private void b_continue_Click(object sender, EventArgs e)
        {
            if (dd_select.SelectedIndex == 0)
            {
                f_open open = new f_open();
                Hide();
                open.ShowDialog();
            }
            else if(dd_select.SelectedIndex == 1)
            {
                f_make make = new f_make();
                Hide();
                make.ShowDialog();
            }
        }
    }
}
