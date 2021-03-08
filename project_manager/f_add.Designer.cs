namespace project_manager
{
    partial class f_add
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
            this.tb_add_item = new System.Windows.Forms.TextBox();
            this.b_add_do = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.SuspendLayout();
            // 
            // tb_add_item
            // 
            this.tb_add_item.Location = new System.Drawing.Point(26, 26);
            this.tb_add_item.Name = "tb_add_item";
            this.tb_add_item.Size = new System.Drawing.Size(166, 20);
            this.tb_add_item.TabIndex = 0;
            this.tb_add_item.TextChanged += new System.EventHandler(this.tb_add_item_TextChanged);
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
            this.b_add_do.TabIndex = 3;
            this.b_add_do.Text = "ADD";
            this.b_add_do.Click += new System.EventHandler(this.b_add_do_Click);
            // 
            // f_add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(220, 119);
            this.Controls.Add(this.b_add_do);
            this.Controls.Add(this.tb_add_item);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "f_add";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "f_add";
            this.Load += new System.EventHandler(this.f_add_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_add_item;
        private Siticone.UI.WinForms.SiticoneRoundedButton b_add_do;
    }
}