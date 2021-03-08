namespace project_manager
{
    partial class f_main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel = new System.Windows.Forms.Panel();
            this.b_add_done = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.b_add_started = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.b_add_todo = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.p_done = new System.Windows.Forms.Panel();
            this.p_contents_done = new System.Windows.Forms.Panel();
            this.t_done = new Siticone.UI.WinForms.SiticoneLabel();
            this.p_started = new System.Windows.Forms.Panel();
            this.p_contents_started = new System.Windows.Forms.Panel();
            this.lb_started = new System.Windows.Forms.ListBox();
            this.t_started = new Siticone.UI.WinForms.SiticoneLabel();
            this.p_todo = new System.Windows.Forms.Panel();
            this.p_contents_todo = new System.Windows.Forms.Panel();
            this.lb_todo = new System.Windows.Forms.ListBox();
            this.t_todo = new Siticone.UI.WinForms.SiticoneLabel();
            this.siticoneTransparentDrag1 = new Siticone.UI.WinForms.SiticoneTransparentDrag();
            this.t_name_form = new Siticone.UI.WinForms.SiticoneLabel();
            this.siticoneTransparentDrag2 = new Siticone.UI.WinForms.SiticoneTransparentDrag();
            this.lb_done = new System.Windows.Forms.ListBox();
            this.b_exit = new Siticone.UI.WinForms.SiticoneCircleButton();
            this.siticoneRoundedButton1 = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.siticoneRoundedButton2 = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.siticoneRoundedButton3 = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.b_min = new Siticone.UI.WinForms.SiticoneCircleButton();
            this.b_save = new Siticone.UI.WinForms.SiticoneCircleButton();
            this.panel.SuspendLayout();
            this.p_done.SuspendLayout();
            this.p_contents_done.SuspendLayout();
            this.p_started.SuspendLayout();
            this.p_contents_started.SuspendLayout();
            this.p_todo.SuspendLayout();
            this.p_contents_todo.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.panel.Controls.Add(this.siticoneRoundedButton3);
            this.panel.Controls.Add(this.siticoneRoundedButton2);
            this.panel.Controls.Add(this.siticoneRoundedButton1);
            this.panel.Controls.Add(this.b_add_done);
            this.panel.Controls.Add(this.b_add_started);
            this.panel.Controls.Add(this.b_add_todo);
            this.panel.Controls.Add(this.p_done);
            this.panel.Controls.Add(this.p_started);
            this.panel.Controls.Add(this.p_todo);
            this.panel.Location = new System.Drawing.Point(0, 55);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(805, 395);
            this.panel.TabIndex = 0;
            // 
            // b_add_done
            // 
            this.b_add_done.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.b_add_done.BorderThickness = 3;
            this.b_add_done.CheckedState.Parent = this.b_add_done;
            this.b_add_done.CustomImages.Parent = this.b_add_done;
            this.b_add_done.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.b_add_done.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.b_add_done.ForeColor = System.Drawing.Color.White;
            this.b_add_done.HoveredState.Parent = this.b_add_done;
            this.b_add_done.Location = new System.Drawing.Point(551, 371);
            this.b_add_done.Name = "b_add_done";
            this.b_add_done.ShadowDecoration.Parent = this.b_add_done;
            this.b_add_done.Size = new System.Drawing.Size(116, 21);
            this.b_add_done.TabIndex = 9;
            this.b_add_done.Text = "ADD";
            this.b_add_done.Click += new System.EventHandler(this.b_add_done_Click);
            // 
            // b_add_started
            // 
            this.b_add_started.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.b_add_started.BorderThickness = 3;
            this.b_add_started.CheckedState.Parent = this.b_add_started;
            this.b_add_started.CustomImages.Parent = this.b_add_started;
            this.b_add_started.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.b_add_started.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.b_add_started.ForeColor = System.Drawing.Color.White;
            this.b_add_started.HoveredState.Parent = this.b_add_started;
            this.b_add_started.Location = new System.Drawing.Point(282, 371);
            this.b_add_started.Name = "b_add_started";
            this.b_add_started.ShadowDecoration.Parent = this.b_add_started;
            this.b_add_started.Size = new System.Drawing.Size(116, 21);
            this.b_add_started.TabIndex = 8;
            this.b_add_started.Text = "ADD";
            this.b_add_started.Click += new System.EventHandler(this.b_add_started_Click);
            // 
            // b_add_todo
            // 
            this.b_add_todo.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.b_add_todo.BorderThickness = 3;
            this.b_add_todo.CheckedState.Parent = this.b_add_todo;
            this.b_add_todo.CustomImages.Parent = this.b_add_todo;
            this.b_add_todo.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.b_add_todo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.b_add_todo.ForeColor = System.Drawing.Color.White;
            this.b_add_todo.HoveredState.Parent = this.b_add_todo;
            this.b_add_todo.Location = new System.Drawing.Point(12, 371);
            this.b_add_todo.Name = "b_add_todo";
            this.b_add_todo.ShadowDecoration.Parent = this.b_add_todo;
            this.b_add_todo.Size = new System.Drawing.Size(116, 21);
            this.b_add_todo.TabIndex = 7;
            this.b_add_todo.Text = "ADD";
            this.b_add_todo.Click += new System.EventHandler(this.b_add_todo_Click);
            // 
            // p_done
            // 
            this.p_done.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.p_done.Controls.Add(this.p_contents_done);
            this.p_done.Controls.Add(this.t_done);
            this.p_done.Location = new System.Drawing.Point(551, 3);
            this.p_done.Name = "p_done";
            this.p_done.Size = new System.Drawing.Size(237, 365);
            this.p_done.TabIndex = 6;
            // 
            // p_contents_done
            // 
            this.p_contents_done.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.p_contents_done.Controls.Add(this.lb_done);
            this.p_contents_done.Location = new System.Drawing.Point(11, 50);
            this.p_contents_done.Name = "p_contents_done";
            this.p_contents_done.Size = new System.Drawing.Size(214, 294);
            this.p_contents_done.TabIndex = 10;
            // 
            // t_done
            // 
            this.t_done.BackColor = System.Drawing.Color.Transparent;
            this.t_done.Font = new System.Drawing.Font("GeForce", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t_done.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.t_done.Location = new System.Drawing.Point(93, 3);
            this.t_done.Name = "t_done";
            this.t_done.Size = new System.Drawing.Size(53, 27);
            this.t_done.TabIndex = 1;
            this.t_done.Text = "DONE";
            // 
            // p_started
            // 
            this.p_started.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.p_started.Controls.Add(this.p_contents_started);
            this.p_started.Controls.Add(this.t_started);
            this.p_started.Location = new System.Drawing.Point(285, 3);
            this.p_started.Name = "p_started";
            this.p_started.Size = new System.Drawing.Size(237, 365);
            this.p_started.TabIndex = 5;
            // 
            // p_contents_started
            // 
            this.p_contents_started.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.p_contents_started.Controls.Add(this.lb_started);
            this.p_contents_started.Location = new System.Drawing.Point(12, 50);
            this.p_contents_started.Name = "p_contents_started";
            this.p_contents_started.Size = new System.Drawing.Size(214, 294);
            this.p_contents_started.TabIndex = 3;
            // 
            // lb_started
            // 
            this.lb_started.AllowDrop = true;
            this.lb_started.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.lb_started.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lb_started.Font = new System.Drawing.Font("GeForce", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_started.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lb_started.FormattingEnabled = true;
            this.lb_started.ItemHeight = 17;
            this.lb_started.Location = new System.Drawing.Point(9, 10);
            this.lb_started.Name = "lb_started";
            this.lb_started.ScrollAlwaysVisible = true;
            this.lb_started.Size = new System.Drawing.Size(197, 274);
            this.lb_started.TabIndex = 1;
            // 
            // t_started
            // 
            this.t_started.BackColor = System.Drawing.Color.Transparent;
            this.t_started.Font = new System.Drawing.Font("GeForce", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t_started.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.t_started.Location = new System.Drawing.Point(77, 3);
            this.t_started.Name = "t_started";
            this.t_started.Size = new System.Drawing.Size(85, 27);
            this.t_started.TabIndex = 1;
            this.t_started.Text = "STARTED";
            // 
            // p_todo
            // 
            this.p_todo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.p_todo.Controls.Add(this.p_contents_todo);
            this.p_todo.Controls.Add(this.t_todo);
            this.p_todo.Location = new System.Drawing.Point(12, 3);
            this.p_todo.Name = "p_todo";
            this.p_todo.Size = new System.Drawing.Size(237, 365);
            this.p_todo.TabIndex = 4;
            // 
            // p_contents_todo
            // 
            this.p_contents_todo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.p_contents_todo.Controls.Add(this.lb_todo);
            this.p_contents_todo.Location = new System.Drawing.Point(11, 50);
            this.p_contents_todo.Name = "p_contents_todo";
            this.p_contents_todo.Size = new System.Drawing.Size(214, 294);
            this.p_contents_todo.TabIndex = 2;
            // 
            // lb_todo
            // 
            this.lb_todo.AllowDrop = true;
            this.lb_todo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.lb_todo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lb_todo.Font = new System.Drawing.Font("GeForce", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_todo.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lb_todo.FormattingEnabled = true;
            this.lb_todo.ItemHeight = 17;
            this.lb_todo.Location = new System.Drawing.Point(9, 10);
            this.lb_todo.Name = "lb_todo";
            this.lb_todo.ScrollAlwaysVisible = true;
            this.lb_todo.Size = new System.Drawing.Size(197, 274);
            this.lb_todo.TabIndex = 0;
            // 
            // t_todo
            // 
            this.t_todo.BackColor = System.Drawing.Color.Transparent;
            this.t_todo.Font = new System.Drawing.Font("GeForce", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t_todo.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.t_todo.Location = new System.Drawing.Point(88, 3);
            this.t_todo.Name = "t_todo";
            this.t_todo.Size = new System.Drawing.Size(53, 27);
            this.t_todo.TabIndex = 1;
            this.t_todo.Text = "TODO";
            // 
            // siticoneTransparentDrag1
            // 
            this.siticoneTransparentDrag1.DragEndTransparencyValue = 1D;
            this.siticoneTransparentDrag1.DragStartTransparencyValue = 0.9D;
            this.siticoneTransparentDrag1.TargetDragControl = this;
            // 
            // t_name_form
            // 
            this.t_name_form.BackColor = System.Drawing.Color.Transparent;
            this.t_name_form.Font = new System.Drawing.Font("GeForce", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t_name_form.ForeColor = System.Drawing.Color.Snow;
            this.t_name_form.Location = new System.Drawing.Point(251, 12);
            this.t_name_form.Name = "t_name_form";
            this.t_name_form.Size = new System.Drawing.Size(307, 30);
            this.t_name_form.TabIndex = 1;
            this.t_name_form.Text = "PROJECT / TEAM MANAGER AIO";
            // 
            // siticoneTransparentDrag2
            // 
            this.siticoneTransparentDrag2.DragEndTransparencyValue = 1D;
            this.siticoneTransparentDrag2.DragStartTransparencyValue = 0.9D;
            this.siticoneTransparentDrag2.TargetDragControl = this.t_name_form;
            // 
            // lb_done
            // 
            this.lb_done.AllowDrop = true;
            this.lb_done.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.lb_done.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lb_done.Font = new System.Drawing.Font("GeForce", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_done.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lb_done.FormattingEnabled = true;
            this.lb_done.ItemHeight = 17;
            this.lb_done.Location = new System.Drawing.Point(9, 10);
            this.lb_done.Name = "lb_done";
            this.lb_done.ScrollAlwaysVisible = true;
            this.lb_done.Size = new System.Drawing.Size(197, 274);
            this.lb_done.TabIndex = 2;
            // 
            // b_exit
            // 
            this.b_exit.CheckedState.Parent = this.b_exit;
            this.b_exit.CustomImages.Parent = this.b_exit;
            this.b_exit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.b_exit.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_exit.ForeColor = System.Drawing.Color.White;
            this.b_exit.HoveredState.Parent = this.b_exit;
            this.b_exit.Location = new System.Drawing.Point(755, 2);
            this.b_exit.Name = "b_exit";
            this.b_exit.ShadowDecoration.Mode = Siticone.UI.WinForms.Enums.ShadowMode.Circle;
            this.b_exit.ShadowDecoration.Parent = this.b_exit;
            this.b_exit.Size = new System.Drawing.Size(38, 40);
            this.b_exit.TabIndex = 2;
            this.b_exit.Text = "X";
            this.b_exit.Click += new System.EventHandler(this.b_exit_Click);
            // 
            // siticoneRoundedButton1
            // 
            this.siticoneRoundedButton1.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.siticoneRoundedButton1.BorderThickness = 3;
            this.siticoneRoundedButton1.CheckedState.Parent = this.siticoneRoundedButton1;
            this.siticoneRoundedButton1.CustomImages.Parent = this.siticoneRoundedButton1;
            this.siticoneRoundedButton1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.siticoneRoundedButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.siticoneRoundedButton1.ForeColor = System.Drawing.Color.White;
            this.siticoneRoundedButton1.HoveredState.Parent = this.siticoneRoundedButton1;
            this.siticoneRoundedButton1.Location = new System.Drawing.Point(668, 371);
            this.siticoneRoundedButton1.Name = "siticoneRoundedButton1";
            this.siticoneRoundedButton1.ShadowDecoration.Parent = this.siticoneRoundedButton1;
            this.siticoneRoundedButton1.Size = new System.Drawing.Size(120, 21);
            this.siticoneRoundedButton1.TabIndex = 10;
            this.siticoneRoundedButton1.Text = "SETTINGS";
            // 
            // siticoneRoundedButton2
            // 
            this.siticoneRoundedButton2.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.siticoneRoundedButton2.BorderThickness = 3;
            this.siticoneRoundedButton2.CheckedState.Parent = this.siticoneRoundedButton2;
            this.siticoneRoundedButton2.CustomImages.Parent = this.siticoneRoundedButton2;
            this.siticoneRoundedButton2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.siticoneRoundedButton2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.siticoneRoundedButton2.ForeColor = System.Drawing.Color.White;
            this.siticoneRoundedButton2.HoveredState.Parent = this.siticoneRoundedButton2;
            this.siticoneRoundedButton2.Location = new System.Drawing.Point(133, 371);
            this.siticoneRoundedButton2.Name = "siticoneRoundedButton2";
            this.siticoneRoundedButton2.ShadowDecoration.Parent = this.siticoneRoundedButton2;
            this.siticoneRoundedButton2.Size = new System.Drawing.Size(116, 21);
            this.siticoneRoundedButton2.TabIndex = 11;
            this.siticoneRoundedButton2.Text = "SETTINGS";
            // 
            // siticoneRoundedButton3
            // 
            this.siticoneRoundedButton3.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.siticoneRoundedButton3.BorderThickness = 3;
            this.siticoneRoundedButton3.CheckedState.Parent = this.siticoneRoundedButton3;
            this.siticoneRoundedButton3.CustomImages.Parent = this.siticoneRoundedButton3;
            this.siticoneRoundedButton3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.siticoneRoundedButton3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.siticoneRoundedButton3.ForeColor = System.Drawing.Color.White;
            this.siticoneRoundedButton3.HoveredState.Parent = this.siticoneRoundedButton3;
            this.siticoneRoundedButton3.Location = new System.Drawing.Point(403, 371);
            this.siticoneRoundedButton3.Name = "siticoneRoundedButton3";
            this.siticoneRoundedButton3.ShadowDecoration.Parent = this.siticoneRoundedButton3;
            this.siticoneRoundedButton3.Size = new System.Drawing.Size(116, 21);
            this.siticoneRoundedButton3.TabIndex = 12;
            this.siticoneRoundedButton3.Text = "SETTINGS";
            // 
            // b_min
            // 
            this.b_min.CheckedState.Parent = this.b_min;
            this.b_min.CustomImages.Parent = this.b_min;
            this.b_min.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.b_min.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_min.ForeColor = System.Drawing.Color.White;
            this.b_min.HoveredState.Parent = this.b_min;
            this.b_min.Location = new System.Drawing.Point(711, 2);
            this.b_min.Name = "b_min";
            this.b_min.ShadowDecoration.Mode = Siticone.UI.WinForms.Enums.ShadowMode.Circle;
            this.b_min.ShadowDecoration.Parent = this.b_min;
            this.b_min.Size = new System.Drawing.Size(38, 40);
            this.b_min.TabIndex = 3;
            this.b_min.Text = "-";
            this.b_min.Click += new System.EventHandler(this.b_min_Click);
            // 
            // b_save
            // 
            this.b_save.CheckedState.Parent = this.b_save;
            this.b_save.CustomImages.Parent = this.b_save;
            this.b_save.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.b_save.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_save.ForeColor = System.Drawing.Color.White;
            this.b_save.HoveredState.Parent = this.b_save;
            this.b_save.Location = new System.Drawing.Point(12, 2);
            this.b_save.Name = "b_save";
            this.b_save.ShadowDecoration.Mode = Siticone.UI.WinForms.Enums.ShadowMode.Circle;
            this.b_save.ShadowDecoration.Parent = this.b_save;
            this.b_save.Size = new System.Drawing.Size(38, 40);
            this.b_save.TabIndex = 4;
            this.b_save.Text = "[+]";
            this.b_save.Click += new System.EventHandler(this.b_save_Click);
            // 
            // f_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(805, 450);
            this.Controls.Add(this.b_save);
            this.Controls.Add(this.b_min);
            this.Controls.Add(this.b_exit);
            this.Controls.Add(this.t_name_form);
            this.Controls.Add(this.panel);
            this.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "f_main";
            this.Text = "Task Manager";
            this.Load += new System.EventHandler(this.f_main_Load);
            this.panel.ResumeLayout(false);
            this.p_done.ResumeLayout(false);
            this.p_done.PerformLayout();
            this.p_contents_done.ResumeLayout(false);
            this.p_started.ResumeLayout(false);
            this.p_started.PerformLayout();
            this.p_contents_started.ResumeLayout(false);
            this.p_todo.ResumeLayout(false);
            this.p_todo.PerformLayout();
            this.p_contents_todo.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private Siticone.UI.WinForms.SiticoneTransparentDrag siticoneTransparentDrag1;
        private System.Windows.Forms.Panel p_done;
        private Siticone.UI.WinForms.SiticoneLabel t_done;
        private System.Windows.Forms.Panel p_started;
        private Siticone.UI.WinForms.SiticoneLabel t_started;
        private System.Windows.Forms.Panel p_todo;
        private Siticone.UI.WinForms.SiticoneLabel t_todo;
        private Siticone.UI.WinForms.SiticoneLabel t_name_form;
        private Siticone.UI.WinForms.SiticoneRoundedButton b_add_done;
        private Siticone.UI.WinForms.SiticoneRoundedButton b_add_started;
        private Siticone.UI.WinForms.SiticoneRoundedButton b_add_todo;
        private Siticone.UI.WinForms.SiticoneTransparentDrag siticoneTransparentDrag2;
        private System.Windows.Forms.Panel p_contents_done;
        private System.Windows.Forms.Panel p_contents_started;
        private System.Windows.Forms.Panel p_contents_todo;
        private System.Windows.Forms.ListBox lb_todo;
        private System.Windows.Forms.ListBox lb_started;
        private System.Windows.Forms.ListBox lb_done;
        private Siticone.UI.WinForms.SiticoneRoundedButton siticoneRoundedButton3;
        private Siticone.UI.WinForms.SiticoneRoundedButton siticoneRoundedButton2;
        private Siticone.UI.WinForms.SiticoneRoundedButton siticoneRoundedButton1;
        private Siticone.UI.WinForms.SiticoneCircleButton b_min;
        private Siticone.UI.WinForms.SiticoneCircleButton b_exit;
        private Siticone.UI.WinForms.SiticoneCircleButton b_save;
    }
}

