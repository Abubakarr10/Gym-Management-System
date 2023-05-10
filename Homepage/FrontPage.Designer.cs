namespace Homepage
{
    partial class FrontPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrontPage));
            this.button_members = new System.Windows.Forms.Button();
            this.button_trainers = new System.Windows.Forms.Button();
            this.button_help = new System.Windows.Forms.Button();
            this.button_contact = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_members
            // 
            this.button_members.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.button_members.FlatAppearance.BorderSize = 0;
            this.button_members.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_members.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_members.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_members.Location = new System.Drawing.Point(70, 71);
            this.button_members.Name = "button_members";
            this.button_members.Size = new System.Drawing.Size(335, 234);
            this.button_members.TabIndex = 1;
            this.button_members.Text = "Members";
            this.button_members.UseVisualStyleBackColor = false;
            this.button_members.Click += new System.EventHandler(this.button_members_Click);
            this.button_members.MouseEnter += new System.EventHandler(this.button_members_MouseEnter);
            this.button_members.MouseLeave += new System.EventHandler(this.button_members_MouseLeave);
            // 
            // button_trainers
            // 
            this.button_trainers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_trainers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.button_trainers.FlatAppearance.BorderSize = 0;
            this.button_trainers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_trainers.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_trainers.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_trainers.Location = new System.Drawing.Point(496, 71);
            this.button_trainers.Name = "button_trainers";
            this.button_trainers.Size = new System.Drawing.Size(335, 234);
            this.button_trainers.TabIndex = 2;
            this.button_trainers.Text = "Trainers";
            this.button_trainers.UseVisualStyleBackColor = false;
            this.button_trainers.MouseEnter += new System.EventHandler(this.button_trainers_MouseEnter);
            this.button_trainers.MouseLeave += new System.EventHandler(this.button_trainers_MouseLeave);
            // 
            // button_help
            // 
            this.button_help.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_help.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.button_help.FlatAppearance.BorderSize = 0;
            this.button_help.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_help.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_help.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_help.Location = new System.Drawing.Point(70, 389);
            this.button_help.Name = "button_help";
            this.button_help.Size = new System.Drawing.Size(335, 234);
            this.button_help.TabIndex = 3;
            this.button_help.Text = "Help";
            this.button_help.UseVisualStyleBackColor = false;
            this.button_help.MouseEnter += new System.EventHandler(this.button_help_MouseEnter);
            this.button_help.MouseLeave += new System.EventHandler(this.button_help_MouseLeave);
            // 
            // button_contact
            // 
            this.button_contact.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_contact.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.button_contact.FlatAppearance.BorderSize = 0;
            this.button_contact.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_contact.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_contact.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_contact.Location = new System.Drawing.Point(496, 389);
            this.button_contact.Name = "button_contact";
            this.button_contact.Size = new System.Drawing.Size(335, 234);
            this.button_contact.TabIndex = 4;
            this.button_contact.Text = "Contact Us";
            this.button_contact.UseVisualStyleBackColor = false;
            this.button_contact.MouseEnter += new System.EventHandler(this.button_contact_MouseEnter);
            this.button_contact.MouseLeave += new System.EventHandler(this.button_contact_MouseLeave);
            // 
            // FrontPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Homepage.Properties.Resources.black_background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(909, 699);
            this.Controls.Add(this.button_contact);
            this.Controls.Add(this.button_help);
            this.Controls.Add(this.button_trainers);
            this.Controls.Add(this.button_members);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrontPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrontPage";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_members;
        private System.Windows.Forms.Button button_trainers;
        private System.Windows.Forms.Button button_help;
        private System.Windows.Forms.Button button_contact;
    }
}