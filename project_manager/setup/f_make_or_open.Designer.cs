namespace project_manager
{
    partial class f_make_or_open
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
            this.dd_select = new Siticone.UI.WinForms.SiticoneRoundedComboBox();
            this.b_continue = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.siticoneTransparentDrag1 = new Siticone.UI.WinForms.SiticoneTransparentDrag();
            this.panel1 = new System.Windows.Forms.Panel();
            this.siticoneTransparentDrag2 = new Siticone.UI.WinForms.SiticoneTransparentDrag();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.siticoneButton1 = new Siticone.UI.WinForms.SiticoneButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dd_select
            // 
            this.dd_select.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.dd_select.BorderColor = System.Drawing.Color.Transparent;
            this.dd_select.BorderThickness = 0;
            this.dd_select.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.dd_select.DropDownHeight = 100;
            this.dd_select.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dd_select.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.dd_select.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dd_select.FocusedColor = System.Drawing.Color.White;
            this.dd_select.Font = new System.Drawing.Font("GeForce", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dd_select.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.dd_select.FormattingEnabled = true;
            this.dd_select.HoveredState.Parent = this.dd_select;
            this.dd_select.IntegralHeight = false;
            this.dd_select.ItemHeight = 30;
            this.dd_select.Items.AddRange(new object[] {
            "open",
            "start new"});
            this.dd_select.ItemsAppearance.Parent = this.dd_select;
            this.dd_select.Location = new System.Drawing.Point(33, 37);
            this.dd_select.Name = "dd_select";
            this.dd_select.ShadowDecoration.Parent = this.dd_select;
            this.dd_select.Size = new System.Drawing.Size(346, 36);
            this.dd_select.TabIndex = 2;
            // 
            // b_continue
            // 
            this.b_continue.CheckedState.Parent = this.b_continue;
            this.b_continue.CustomImages.Parent = this.b_continue;
            this.b_continue.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.b_continue.Font = new System.Drawing.Font("GeForce", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_continue.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.b_continue.HoveredState.Parent = this.b_continue;
            this.b_continue.Location = new System.Drawing.Point(33, 125);
            this.b_continue.Name = "b_continue";
            this.b_continue.ShadowDecoration.Parent = this.b_continue;
            this.b_continue.Size = new System.Drawing.Size(362, 45);
            this.b_continue.TabIndex = 3;
            this.b_continue.Text = "Continue";
            this.b_continue.Click += new System.EventHandler(this.b_continue_Click);
            // 
            // siticoneTransparentDrag1
            // 
            this.siticoneTransparentDrag1.DragEndTransparencyValue = 1D;
            this.siticoneTransparentDrag1.DragStartTransparencyValue = 0.9D;
            this.siticoneTransparentDrag1.TargetDragControl = this;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.panel1.Controls.Add(this.siticoneButton1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(1, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(461, 41);
            this.panel1.TabIndex = 4;
            // 
            // siticoneTransparentDrag2
            // 
            this.siticoneTransparentDrag2.DragEndTransparencyValue = 1D;
            this.siticoneTransparentDrag2.DragStartTransparencyValue = 0.9D;
            this.siticoneTransparentDrag2.TargetDragControl = this.panel1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.dd_select);
            this.panel2.Controls.Add(this.b_continue);
            this.panel2.Location = new System.Drawing.Point(12, 49);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(439, 188);
            this.panel2.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("GeForce", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(30, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 21);
            this.label1.TabIndex = 4;
            this.label1.Text = "Selection\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("GeForce", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(11, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "Open or Create a Project";
            // 
            // siticoneButton1
            // 
            this.siticoneButton1.CheckedState.Parent = this.siticoneButton1;
            this.siticoneButton1.CustomImages.Parent = this.siticoneButton1;
            this.siticoneButton1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.siticoneButton1.Font = new System.Drawing.Font("GeForce", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneButton1.ForeColor = System.Drawing.Color.White;
            this.siticoneButton1.HoveredState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.siticoneButton1.HoveredState.Parent = this.siticoneButton1;
            this.siticoneButton1.Location = new System.Drawing.Point(408, 3);
            this.siticoneButton1.Name = "siticoneButton1";
            this.siticoneButton1.ShadowDecoration.Parent = this.siticoneButton1;
            this.siticoneButton1.Size = new System.Drawing.Size(53, 35);
            this.siticoneButton1.TabIndex = 6;
            this.siticoneButton1.Text = "X";
            // 
            // f_make_or_open
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(463, 249);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "f_make_or_open";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "f_make_or_open";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Siticone.UI.WinForms.SiticoneRoundedComboBox dd_select;
        private Siticone.UI.WinForms.SiticoneRoundedButton b_continue;
        private Siticone.UI.WinForms.SiticoneTransparentDrag siticoneTransparentDrag1;
        private System.Windows.Forms.Panel panel1;
        private Siticone.UI.WinForms.SiticoneTransparentDrag siticoneTransparentDrag2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Siticone.UI.WinForms.SiticoneButton siticoneButton1;
    }
}