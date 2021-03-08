using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_manager.setup
{
    public partial class f_open : Form
    {
        public f_open()
        {
            InitializeComponent();
        }

        private void b_open_Click(object sender, EventArgs e)
        {
            f_main.project = tb_project_name.Text;

            Hide();

            f_main main = new f_main();
            main.ShowDialog();
        }
    }
}
