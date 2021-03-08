using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_manager
{
    public partial class f_done : Form
    {
        public static string[] list_of_items = { };
        int index = 0;
        public static string text_to_add = "";
        public f_done()
        {
            InitializeComponent();
        }

        private void f_done_Load(object sender, EventArgs e)
        {
            for (int q = 0; q < list_of_items.Length; q++)
            {
                combo_items.Items.Add(list_of_items[q]);
            }
        }

        private void combo_items_SelectedIndexChanged(object sender, EventArgs e)
        {
            index = combo_items.SelectedIndex;
        }

        private void b_add_do_Click(object sender, EventArgs e)
        {

        }

        private void b_add_do_Click_1(object sender, EventArgs e)
        {
            if (combo_items.Items.Count > 0)
                text_to_add = list_of_items[index];
            else
                MessageBox.Show("Nothing was selected.");

            this.Close();
        }
    }
}
