namespace Homepage
{
    partial class SearchMember
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchMember));
            this.textBox_searchmember = new System.Windows.Forms.TextBox();
            this.label_searchmember = new System.Windows.Forms.Label();
            this.button_search = new System.Windows.Forms.Button();
            this.button_clear = new System.Windows.Forms.Button();
            this.label_searchbutton = new System.Windows.Forms.Label();
            this.label_clear = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_searchmember
            // 
            this.textBox_searchmember.BackColor = System.Drawing.SystemColors.Window;
            this.textBox_searchmember.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_searchmember.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_searchmember.Location = new System.Drawing.Point(274, 37);
            this.textBox_searchmember.Name = "textBox_searchmember";
            this.textBox_searchmember.Size = new System.Drawing.Size(683, 32);
            this.textBox_searchmember.TabIndex = 2;
            this.textBox_searchmember.Text = "Enter Gym no or name";
            this.textBox_searchmember.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_searchmember.Enter += new System.EventHandler(this.textBox_searchmember_Enter);
            this.textBox_searchmember.Leave += new System.EventHandler(this.textBox_searchmember_Leave);
            // 
            // label_searchmember
            // 
            this.label_searchmember.AutoSize = true;
            this.label_searchmember.BackColor = System.Drawing.Color.Transparent;
            this.label_searchmember.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_searchmember.ForeColor = System.Drawing.Color.White;
            this.label_searchmember.Location = new System.Drawing.Point(58, 37);
            this.label_searchmember.Name = "label_searchmember";
            this.label_searchmember.Size = new System.Drawing.Size(197, 35);
            this.label_searchmember.TabIndex = 0;
            this.label_searchmember.Text = "Search Member";
            // 
            // button_search
            // 
            this.button_search.BackColor = System.Drawing.Color.White;
            this.button_search.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_search.BackgroundImage")));
            this.button_search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_search.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_search.Location = new System.Drawing.Point(987, 28);
            this.button_search.Name = "button_search";
            this.button_search.Size = new System.Drawing.Size(49, 50);
            this.button_search.TabIndex = 1;
            this.button_search.UseVisualStyleBackColor = false;
            this.button_search.MouseEnter += new System.EventHandler(this.button_search_MouseEnter);
            this.button_search.MouseLeave += new System.EventHandler(this.button_search_MouseLeave);
            // 
            // button_clear
            // 
            this.button_clear.BackColor = System.Drawing.Color.White;
            this.button_clear.BackgroundImage = global::Homepage.Properties.Resources.black_cross;
            this.button_clear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_clear.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_clear.Location = new System.Drawing.Point(1070, 28);
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(47, 50);
            this.button_clear.TabIndex = 3;
            this.button_clear.UseVisualStyleBackColor = false;
            this.button_clear.Click += new System.EventHandler(this.button_clear_Click);
            this.button_clear.MouseEnter += new System.EventHandler(this.button_clear_MouseEnter);
            this.button_clear.MouseLeave += new System.EventHandler(this.button_clear_MouseLeave);
            // 
            // label_searchbutton
            // 
            this.label_searchbutton.AutoSize = true;
            this.label_searchbutton.BackColor = System.Drawing.Color.Transparent;
            this.label_searchbutton.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_searchbutton.ForeColor = System.Drawing.Color.White;
            this.label_searchbutton.Location = new System.Drawing.Point(983, 88);
            this.label_searchbutton.Name = "label_searchbutton";
            this.label_searchbutton.Size = new System.Drawing.Size(64, 24);
            this.label_searchbutton.TabIndex = 21;
            this.label_searchbutton.Text = "search";
            this.label_searchbutton.Visible = false;
            // 
            // label_clear
            // 
            this.label_clear.AutoSize = true;
            this.label_clear.BackColor = System.Drawing.Color.Transparent;
            this.label_clear.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_clear.ForeColor = System.Drawing.Color.White;
            this.label_clear.Location = new System.Drawing.Point(1064, 78);
            this.label_clear.Name = "label_clear";
            this.label_clear.Size = new System.Drawing.Size(64, 48);
            this.label_clear.TabIndex = 22;
            this.label_clear.Text = "clear\r\nsearch";
            this.label_clear.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label_clear.Visible = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(27, 127);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1134, 547);
            this.dataGridView1.TabIndex = 4;
            // 
            // SearchMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Homepage.Properties.Resources.black_background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1187, 702);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label_clear);
            this.Controls.Add(this.label_searchbutton);
            this.Controls.Add(this.button_clear);
            this.Controls.Add(this.button_search);
            this.Controls.Add(this.label_searchmember);
            this.Controls.Add(this.textBox_searchmember);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SearchMember";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SearchMember";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_searchmember;
        private System.Windows.Forms.Label label_searchmember;
        private System.Windows.Forms.Button button_search;
        private System.Windows.Forms.Button button_clear;
        private System.Windows.Forms.Label label_searchbutton;
        private System.Windows.Forms.Label label_clear;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}