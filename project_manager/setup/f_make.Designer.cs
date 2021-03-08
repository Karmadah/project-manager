namespace project_manager.setup
{
    partial class f_make
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
            this.tb_project_name = new Siticone.UI.WinForms.SiticoneRoundedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.b_create = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.siticoneTransparentDrag1 = new Siticone.UI.WinForms.SiticoneTransparentDrag();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
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
            this.tb_project_name.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("GeForce", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(116, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Project Name";
            // 
            // b_create
            // 
            this.b_create.CheckedState.Parent = this.b_create;
            this.b_create.CustomImages.Parent = this.b_create;
            this.b_create.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.b_create.Font = new System.Drawing.Font("GeForce", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_create.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.b_create.HoveredState.Parent = this.b_create;
            this.b_create.Location = new System.Drawing.Point(16, 72);
            this.b_create.Name = "b_create";
            this.b_create.ShadowDecoration.Parent = this.b_create;
            this.b_create.Size = new System.Drawing.Size(299, 34);
            this.b_create.TabIndex = 5;
            this.b_create.Text = "CREATE";
            this.b_create.Click += new System.EventHandler(this.b_create_Click);
            // 
            // siticoneTransparentDrag1
            // 
            this.siticoneTransparentDrag1.DragEndTransparencyValue = 1D;
            this.siticoneTransparentDrag1.DragStartTransparencyValue = 0.9D;
            this.siticoneTransparentDrag1.TargetDragControl = this;
            // 
            // f_make
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(327, 121);
            this.Controls.Add(this.b_create);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_project_name);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "f_make";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "f_make";
            this.Load += new System.EventHandler(this.f_make_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Siticone.UI.WinForms.SiticoneRoundedTextBox tb_project_name;
        private System.Windows.Forms.Label label1;
        private Siticone.UI.WinForms.SiticoneRoundedButton b_create;
        private Siticone.UI.WinForms.SiticoneTransparentDrag siticoneTransparentDrag1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }   
}