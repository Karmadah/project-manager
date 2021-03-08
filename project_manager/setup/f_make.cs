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
using project_manager;

namespace project_manager.setup
{
    public partial class f_make : Form
    {
        public f_make()
        {
            InitializeComponent();
        }

        private void f_make_Load(object sender, EventArgs e)
        {
       
        }

        private void b_create_Click(object sender, EventArgs e)
        {
            string path_todo = tb_project_name.Text + "_todo.ini";
            File.WriteAllText(path_todo, "");
            string path_started = tb_project_name.Text + "_started.ini";
            File.WriteAllText(path_started, "");
            string path_done = tb_project_name.Text + "_done.ini";
            File.WriteAllText(path_done, "");

            f_main.project = tb_project_name.Text;

            Hide();

            f_main main = new f_main();
            main.ShowDialog();
        }
    }
}
