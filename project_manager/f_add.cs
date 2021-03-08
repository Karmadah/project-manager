using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using project_manager;

namespace project_manager
{
    public partial class f_add : Form
    {
        public static string text_to_add = "";
        public f_add()
        {
            InitializeComponent();
        }

        private void tb_add_item_TextChanged(object sender, EventArgs e)
        {
            text_to_add = tb_add_item.Text;
        }

        private void f_add_Load(object sender, EventArgs e)
        {

        }

        private void b_add_do_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
