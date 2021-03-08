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

namespace project_manager
{
    public partial class f_main : Form
    {
        public static string project = "";
        string todo_file = project + "_todo.ini";
        string started_file = project + "_started.ini";
        string done_file = project + "_done.ini";
        public f_main()
        {
            InitializeComponent();
        }

        private void b_add_todo_Click(object sender, EventArgs e)
        {
            f_add add = new f_add();
            add.ShowDialog();

            add_task(f_add.text_to_add, lb_todo);
            f_add.text_to_add = "";
        }

        private void b_add_started_Click(object sender, EventArgs e)
        {
            f_started.list_of_items = loop_items(lb_todo);

            f_started started = new f_started();
            started.ShowDialog();

            add_task(f_started.text_to_add, lb_started, lb_todo);
            f_started.text_to_add = "";
        }

        private void b_add_done_Click(object sender, EventArgs e)
        {
            f_done.list_of_items = loop_items(lb_started);

            f_done done = new f_done();
            done.ShowDialog();

            add_task(f_done.text_to_add, lb_done, lb_started);
            f_done.text_to_add = "";
        }

        #region helper functions
        public string[] loop_items(ListBox lb)
        {
            string[] items = new string[lb.Items.Count];
            for (int q = 0; q < lb.Items.Count; q++)
            {
                items[q] = lb.Items[q].ToString();
            }
            return items;
        }

        private void add_task(string item, ListBox lb, ListBox lb_remove = null)
        {
            lb.Items.Add(item);
            if (lb_remove != null)
                lb_remove.Items.Remove(item);
        }

        private void get_items(string file, ListBox lb)
        {
            string[] lines = File.ReadAllLines(file);

            for (int q = 0; q < lines.Length; q++)
            {
                add_task(lines[q], lb);
            }
        }
        #endregion

        private void f_main_Load(object sender, EventArgs e)
        {
            get_items(todo_file, lb_todo);
            get_items(started_file, lb_started);
            get_items(done_file, lb_done);
        }

        private void b_min_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void b_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void b_save_Click(object sender, EventArgs e)
        {
            File.WriteAllLines(todo_file, loop_items(lb_todo));
            File.WriteAllLines(started_file, loop_items(lb_started));
            File.WriteAllLines(done_file, loop_items(lb_done));
        }
    }
}
