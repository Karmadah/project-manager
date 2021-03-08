namespace project_manager.setup
{
    partial class f_open
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
            this.b_open = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_project_name = new Siticone.UI.WinForms.SiticoneRoundedTextBox();
            this.SuspendLayout();
            // 
            // b_open
            // 
            this.b_open.CheckedState.Parent = this.b_open;
            this.b_open.CustomImages.Parent = this.b_open;
            this.b_open.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.b_open.Font = new System.Drawing.Font("GeForce", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_open.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.b_open.HoveredState.Parent = this.b_open;
            this.b_open.Location = new System.Drawing.Point(16, 72);
            this.b_open.Name = "b_open";
            this.b_open.ShadowDecoration.Parent = this.b_open;
            this.b_open.Size = new System.Drawing.Size(299, 34);
            this.b_open.TabIndex = 6;
            this.b_open.Text = "OPEN";
            this.b_open.Click += new System.EventHandler(this.b_open_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("GeForce", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(116, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 21);
            this.label1.TabIndex = 8;
            this.label1.Text = "Project Name";
            // 
            // tb_project_name
            // 
            this.tb_project_name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_project_name.DefaultText = "";
            this.tb_project_name.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tb_project_name.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tb_project_name.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_project_name.DisabledState.Parent = this.tb_project_name;
            this.tb_project_name.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_project_name.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_project_name.FocusedState.Parent = this.tb_project_name;
            this.tb_project_name.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_project_name.HoveredState.Parent = this.tb_project_name;
            this.tb_project_name.Location = new System.Drawing.Point(12, 36);
            this.tb_project_name.Name = "tb_project_name";
            this.tb_project_name.PasswordChar = '\0';
            this.tb_project_name.PlaceholderText = "";
            this.tb_project_name.SelectedText = "";
            this.tb_project_name.ShadowDecoration.Parent = this.tb_project_name;
            this.tb_project_name.Size = new System.Drawing.Size(303, 30);
            this.tb_project_name.TabIndex = 7;
            // 
            // open
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(327, 121);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_project_name);
            this.Controls.Add(this.b_open);
            this.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "open";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "open";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Siticone.UI.WinForms.SiticoneRoundedButton b_open;
        private System.Windows.Forms.Label label1;
        private Siticone.UI.WinForms.SiticoneRoundedTextBox tb_project_name;
    }
}