namespace project_manager
{
    partial class f_started
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
            this.combo_items = new System.Windows.Forms.ComboBox();
            this.b_add_do = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.SuspendLayout();
            // 
            // combo_items
            // 
            this.combo_items.FormattingEnabled = true;
            this.combo_items.Location = new System.Drawing.Point(26, 26);
            this.combo_items.Name = "combo_items";
            this.combo_items.Size = new System.Drawing.Size(166, 21);
            this.combo_items.TabIndex = 1;
            this.combo_items.SelectedIndexChanged += new System.EventHandler(this.combo_items_SelectedIndexChanged);
            // 
            // b_add_do
            // 
            this.b_add_do.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.b_add_do.BorderThickness = 2;
            this.b_add_do.CheckedState.Parent = this.b_add_do;
            this.b_add_do.CustomImages.Parent = this.b_add_do;
            this.b_add_do.FillColor = System.Drawing.Color.Black;
            this.b_add_do.Font = new System.Drawing.Font("GeForce", 14.25F, System.Drawing.FontStyle.Bold);
            this.b_add_do.ForeColor = System.Drawing.Color.White;
            this.b_add_do.HoveredState.Parent = this.b_add_do;
            this.b_add_do.Location = new System.Drawing.Point(26, 64);
            this.b_add_do.Name = "b_add_do";
            this.b_add_do.ShadowDecoration.Parent = this.b_add_do;
            this.b_add_do.Size = new System.Drawing.Size(166, 39);
            this.b_add_do.TabIndex = 2;
            this.b_add_do.Text = "ADD TO STARTED";
            this.b_add_do.Click += new System.EventHandler(this.b_add_do_Click);
            // 
            // f_started
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(220, 119);
            this.Controls.Add(this.b_add_do);
            this.Controls.Add(this.combo_items);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "f_started";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "f_started";
            this.Load += new System.EventHandler(this.f_started_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox combo_items;
        private Siticone.UI.WinForms.SiticoneRoundedButton b_add_do;
    }
}