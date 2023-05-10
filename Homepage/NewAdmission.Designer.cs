namespace Homepage
{
    partial class NewAdmission
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewAdmission));
            this.label_name = new System.Windows.Forms.Label();
            this.label_fathername = new System.Windows.Forms.Label();
            this.textBox_fathername = new System.Windows.Forms.TextBox();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.label_contact = new System.Windows.Forms.Label();
            this.textBox_contact = new System.Windows.Forms.TextBox();
            this.label_address = new System.Windows.Forms.Label();
            this.textBox_address = new System.Windows.Forms.TextBox();
            this.label_weight = new System.Windows.Forms.Label();
            this.textBox_weight = new System.Windows.Forms.TextBox();
            this.label_height = new System.Windows.Forms.Label();
            this.textBox_height_ft = new System.Windows.Forms.TextBox();
            this.textBox_height_in = new System.Windows.Forms.TextBox();
            this.label_purpose = new System.Windows.Forms.Label();
            this.textBox_purpose = new System.Windows.Forms.TextBox();
            this.label_package = new System.Windows.Forms.Label();
            this.comboBox_package = new System.Windows.Forms.ComboBox();
            this.label_gymno = new System.Windows.Forms.Label();
            this.textBox_gymno = new System.Windows.Forms.TextBox();
            this.label_category = new System.Windows.Forms.Label();
            this.label_admissionfee = new System.Windows.Forms.Label();
            this.textBox_admissionfee = new System.Windows.Forms.TextBox();
            this.label_trainer = new System.Windows.Forms.Label();
            this.comboBox_selecttrainer = new System.Windows.Forms.ComboBox();
            this.label_dateofjoining = new System.Windows.Forms.Label();
            this.dateTimePicker_dateofjoining = new System.Windows.Forms.DateTimePicker();
            this.button_submit_newadmission = new System.Windows.Forms.Button();
            this.button_reset = new System.Windows.Forms.Button();
            this.button_searchmember = new System.Windows.Forms.Button();
            this.label_errorgymno = new System.Windows.Forms.Label();
            this.label_errorname = new System.Windows.Forms.Label();
            this.label_errorcategory = new System.Windows.Forms.Label();
            this.label_errorpackage = new System.Windows.Forms.Label();
            this.label_gender = new System.Windows.Forms.Label();
            this.comboBox_gender = new System.Windows.Forms.ComboBox();
            this.comboBox_category = new System.Windows.Forms.ComboBox();
            this.label_gym_no_exists = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.BackColor = System.Drawing.Color.Transparent;
            this.label_name.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_name.ForeColor = System.Drawing.Color.White;
            this.label_name.Location = new System.Drawing.Point(8, 112);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(82, 35);
            this.label_name.TabIndex = 0;
            this.label_name.Text = "Name";
            // 
            // label_fathername
            // 
            this.label_fathername.AutoSize = true;
            this.label_fathername.BackColor = System.Drawing.Color.Transparent;
            this.label_fathername.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_fathername.ForeColor = System.Drawing.Color.White;
            this.label_fathername.Location = new System.Drawing.Point(602, 115);
            this.label_fathername.Name = "label_fathername";
            this.label_fathername.Size = new System.Drawing.Size(161, 35);
            this.label_fathername.TabIndex = 0;
            this.label_fathername.Text = "Father Name";
            // 
            // textBox_fathername
            // 
            this.textBox_fathername.BackColor = System.Drawing.SystemColors.Window;
            this.textBox_fathername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_fathername.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_fathername.Location = new System.Drawing.Point(769, 117);
            this.textBox_fathername.Name = "textBox_fathername";
            this.textBox_fathername.Size = new System.Drawing.Size(424, 32);
            this.textBox_fathername.TabIndex = 4;
            this.textBox_fathername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_name
            // 
            this.textBox_name.BackColor = System.Drawing.SystemColors.Window;
            this.textBox_name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_name.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_name.Location = new System.Drawing.Point(197, 114);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(323, 32);
            this.textBox_name.TabIndex = 3;
            this.textBox_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_name.Leave += new System.EventHandler(this.textBox_name_Leave);
            // 
            // label_contact
            // 
            this.label_contact.AutoSize = true;
            this.label_contact.BackColor = System.Drawing.Color.Transparent;
            this.label_contact.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_contact.ForeColor = System.Drawing.Color.White;
            this.label_contact.Location = new System.Drawing.Point(8, 195);
            this.label_contact.Name = "label_contact";
            this.label_contact.Size = new System.Drawing.Size(117, 35);
            this.label_contact.TabIndex = 0;
            this.label_contact.Text = "Contact#";
            // 
            // textBox_contact
            // 
            this.textBox_contact.BackColor = System.Drawing.SystemColors.Window;
            this.textBox_contact.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_contact.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_contact.Location = new System.Drawing.Point(197, 195);
            this.textBox_contact.Name = "textBox_contact";
            this.textBox_contact.Size = new System.Drawing.Size(323, 32);
            this.textBox_contact.TabIndex = 5;
            this.textBox_contact.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label_address
            // 
            this.label_address.AutoSize = true;
            this.label_address.BackColor = System.Drawing.Color.Transparent;
            this.label_address.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_address.ForeColor = System.Drawing.Color.White;
            this.label_address.Location = new System.Drawing.Point(602, 195);
            this.label_address.Name = "label_address";
            this.label_address.Size = new System.Drawing.Size(107, 35);
            this.label_address.TabIndex = 4;
            this.label_address.Text = "Address";
            // 
            // textBox_address
            // 
            this.textBox_address.BackColor = System.Drawing.SystemColors.Window;
            this.textBox_address.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_address.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_address.Location = new System.Drawing.Point(769, 195);
            this.textBox_address.Name = "textBox_address";
            this.textBox_address.Size = new System.Drawing.Size(424, 32);
            this.textBox_address.TabIndex = 6;
            this.textBox_address.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label_weight
            // 
            this.label_weight.AutoSize = true;
            this.label_weight.BackColor = System.Drawing.Color.Transparent;
            this.label_weight.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_weight.ForeColor = System.Drawing.Color.White;
            this.label_weight.Location = new System.Drawing.Point(8, 277);
            this.label_weight.Name = "label_weight";
            this.label_weight.Size = new System.Drawing.Size(96, 35);
            this.label_weight.TabIndex = 6;
            this.label_weight.Text = "Weight";
            // 
            // textBox_weight
            // 
            this.textBox_weight.BackColor = System.Drawing.SystemColors.Window;
            this.textBox_weight.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_weight.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_weight.ForeColor = System.Drawing.SystemColors.ControlText;
            this.textBox_weight.Location = new System.Drawing.Point(197, 277);
            this.textBox_weight.Name = "textBox_weight";
            this.textBox_weight.Size = new System.Drawing.Size(323, 32);
            this.textBox_weight.TabIndex = 7;
            this.textBox_weight.Text = "kg";
            this.textBox_weight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_weight.Enter += new System.EventHandler(this.textBox_weight_Enter);
            this.textBox_weight.Leave += new System.EventHandler(this.textBox_weight_Leave);
            // 
            // label_height
            // 
            this.label_height.AutoSize = true;
            this.label_height.BackColor = System.Drawing.Color.Transparent;
            this.label_height.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_height.ForeColor = System.Drawing.Color.White;
            this.label_height.Location = new System.Drawing.Point(602, 277);
            this.label_height.Name = "label_height";
            this.label_height.Size = new System.Drawing.Size(89, 35);
            this.label_height.TabIndex = 8;
            this.label_height.Text = "Height";
            // 
            // textBox_height_ft
            // 
            this.textBox_height_ft.BackColor = System.Drawing.SystemColors.Window;
            this.textBox_height_ft.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_height_ft.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_height_ft.Location = new System.Drawing.Point(769, 277);
            this.textBox_height_ft.Name = "textBox_height_ft";
            this.textBox_height_ft.Size = new System.Drawing.Size(196, 32);
            this.textBox_height_ft.TabIndex = 8;
            this.textBox_height_ft.Text = "ft";
            this.textBox_height_ft.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_height_ft.Enter += new System.EventHandler(this.textBox_height_ft_Enter);
            this.textBox_height_ft.Leave += new System.EventHandler(this.textBox_height_ft_Leave);
            // 
            // textBox_height_in
            // 
            this.textBox_height_in.BackColor = System.Drawing.SystemColors.Window;
            this.textBox_height_in.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_height_in.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_height_in.Location = new System.Drawing.Point(997, 277);
            this.textBox_height_in.Name = "textBox_height_in";
            this.textBox_height_in.Size = new System.Drawing.Size(196, 32);
            this.textBox_height_in.TabIndex = 9;
            this.textBox_height_in.Text = "in";
            this.textBox_height_in.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_height_in.Enter += new System.EventHandler(this.textBox_height_in_Enter);
            this.textBox_height_in.Leave += new System.EventHandler(this.textBox_height_in_Leave);
            // 
            // label_purpose
            // 
            this.label_purpose.AutoSize = true;
            this.label_purpose.BackColor = System.Drawing.Color.Transparent;
            this.label_purpose.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_purpose.ForeColor = System.Drawing.Color.White;
            this.label_purpose.Location = new System.Drawing.Point(8, 356);
            this.label_purpose.Name = "label_purpose";
            this.label_purpose.Size = new System.Drawing.Size(109, 35);
            this.label_purpose.TabIndex = 10;
            this.label_purpose.Text = "Purpose";
            // 
            // textBox_purpose
            // 
            this.textBox_purpose.BackColor = System.Drawing.SystemColors.Window;
            this.textBox_purpose.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_purpose.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_purpose.ForeColor = System.Drawing.SystemColors.ControlText;
            this.textBox_purpose.Location = new System.Drawing.Point(197, 356);
            this.textBox_purpose.Name = "textBox_purpose";
            this.textBox_purpose.Size = new System.Drawing.Size(325, 32);
            this.textBox_purpose.TabIndex = 10;
            this.textBox_purpose.Text = "bulk | cut | fitness";
            this.textBox_purpose.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_purpose.Enter += new System.EventHandler(this.textBox_reason_Enter);
            this.textBox_purpose.Leave += new System.EventHandler(this.textBox_reason_Leave);
            // 
            // label_package
            // 
            this.label_package.AutoSize = true;
            this.label_package.BackColor = System.Drawing.Color.Transparent;
            this.label_package.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_package.ForeColor = System.Drawing.Color.White;
            this.label_package.Location = new System.Drawing.Point(602, 351);
            this.label_package.Name = "label_package";
            this.label_package.Size = new System.Drawing.Size(106, 35);
            this.label_package.TabIndex = 12;
            this.label_package.Text = "Package";
            // 
            // comboBox_package
            // 
            this.comboBox_package.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_package.FormattingEnabled = true;
            this.comboBox_package.Location = new System.Drawing.Point(769, 356);
            this.comboBox_package.Name = "comboBox_package";
            this.comboBox_package.Size = new System.Drawing.Size(424, 32);
            this.comboBox_package.TabIndex = 11;
            this.comboBox_package.Text = "                             Select Package";
            this.comboBox_package.Enter += new System.EventHandler(this.comboBox_package_Enter);
            this.comboBox_package.Leave += new System.EventHandler(this.comboBox_package_Leave);
            // 
            // label_gymno
            // 
            this.label_gymno.AutoSize = true;
            this.label_gymno.BackColor = System.Drawing.Color.Transparent;
            this.label_gymno.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_gymno.ForeColor = System.Drawing.Color.White;
            this.label_gymno.Location = new System.Drawing.Point(8, 37);
            this.label_gymno.Name = "label_gymno";
            this.label_gymno.Size = new System.Drawing.Size(104, 35);
            this.label_gymno.TabIndex = 14;
            this.label_gymno.Text = "Gym no";
            // 
            // textBox_gymno
            // 
            this.textBox_gymno.BackColor = System.Drawing.SystemColors.Window;
            this.textBox_gymno.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_gymno.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_gymno.Location = new System.Drawing.Point(197, 40);
            this.textBox_gymno.Name = "textBox_gymno";
            this.textBox_gymno.Size = new System.Drawing.Size(323, 32);
            this.textBox_gymno.TabIndex = 1;
            this.textBox_gymno.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_gymno.Enter += new System.EventHandler(this.textBox_gymno_Enter);
            this.textBox_gymno.Leave += new System.EventHandler(this.textBox_gymno_Leave);
            // 
            // label_category
            // 
            this.label_category.AutoSize = true;
            this.label_category.BackColor = System.Drawing.Color.Transparent;
            this.label_category.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_category.ForeColor = System.Drawing.Color.White;
            this.label_category.Location = new System.Drawing.Point(602, 37);
            this.label_category.Name = "label_category";
            this.label_category.Size = new System.Drawing.Size(117, 35);
            this.label_category.TabIndex = 16;
            this.label_category.Text = "Category";
            // 
            // label_admissionfee
            // 
            this.label_admissionfee.AutoSize = true;
            this.label_admissionfee.BackColor = System.Drawing.Color.Transparent;
            this.label_admissionfee.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_admissionfee.ForeColor = System.Drawing.Color.White;
            this.label_admissionfee.Location = new System.Drawing.Point(12, 427);
            this.label_admissionfee.Name = "label_admissionfee";
            this.label_admissionfee.Size = new System.Drawing.Size(179, 35);
            this.label_admissionfee.TabIndex = 17;
            this.label_admissionfee.Text = "Admission Fee";
            // 
            // textBox_admissionfee
            // 
            this.textBox_admissionfee.BackColor = System.Drawing.SystemColors.Window;
            this.textBox_admissionfee.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_admissionfee.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_admissionfee.Location = new System.Drawing.Point(197, 429);
            this.textBox_admissionfee.Name = "textBox_admissionfee";
            this.textBox_admissionfee.Size = new System.Drawing.Size(325, 32);
            this.textBox_admissionfee.TabIndex = 12;
            this.textBox_admissionfee.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label_trainer
            // 
            this.label_trainer.AutoSize = true;
            this.label_trainer.BackColor = System.Drawing.Color.Transparent;
            this.label_trainer.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_trainer.ForeColor = System.Drawing.Color.White;
            this.label_trainer.Location = new System.Drawing.Point(603, 423);
            this.label_trainer.Name = "label_trainer";
            this.label_trainer.Size = new System.Drawing.Size(94, 35);
            this.label_trainer.TabIndex = 18;
            this.label_trainer.Text = "Trainer";
            // 
            // comboBox_selecttrainer
            // 
            this.comboBox_selecttrainer.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_selecttrainer.FormattingEnabled = true;
            this.comboBox_selecttrainer.Items.AddRange(new object[] {
            "Public-Trainer",
            "Personal-Trainer Cbum",
            "Personal-Trainer Arnold",
            "Personal-Trainer Noel Dyzel"});
            this.comboBox_selecttrainer.Location = new System.Drawing.Point(769, 432);
            this.comboBox_selecttrainer.Name = "comboBox_selecttrainer";
            this.comboBox_selecttrainer.Size = new System.Drawing.Size(424, 32);
            this.comboBox_selecttrainer.TabIndex = 13;
            this.comboBox_selecttrainer.Text = "                             Select Trainer";
            this.comboBox_selecttrainer.Enter += new System.EventHandler(this.comboBox_selecttrainer_Enter);
            this.comboBox_selecttrainer.Leave += new System.EventHandler(this.comboBox_selecttrainer_Leave);
            // 
            // label_dateofjoining
            // 
            this.label_dateofjoining.AutoSize = true;
            this.label_dateofjoining.BackColor = System.Drawing.Color.Transparent;
            this.label_dateofjoining.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_dateofjoining.ForeColor = System.Drawing.Color.White;
            this.label_dateofjoining.Location = new System.Drawing.Point(8, 501);
            this.label_dateofjoining.Name = "label_dateofjoining";
            this.label_dateofjoining.Size = new System.Drawing.Size(183, 35);
            this.label_dateofjoining.TabIndex = 20;
            this.label_dateofjoining.Text = "Date of Joining";
            // 
            // dateTimePicker_dateofjoining
            // 
            this.dateTimePicker_dateofjoining.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker_dateofjoining.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker_dateofjoining.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_dateofjoining.Location = new System.Drawing.Point(197, 504);
            this.dateTimePicker_dateofjoining.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker_dateofjoining.Name = "dateTimePicker_dateofjoining";
            this.dateTimePicker_dateofjoining.Size = new System.Drawing.Size(325, 32);
            this.dateTimePicker_dateofjoining.TabIndex = 14;
            // 
            // button_submit_newadmission
            // 
            this.button_submit_newadmission.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.button_submit_newadmission.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_submit_newadmission.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_submit_newadmission.ForeColor = System.Drawing.Color.White;
            this.button_submit_newadmission.Location = new System.Drawing.Point(774, 596);
            this.button_submit_newadmission.Name = "button_submit_newadmission";
            this.button_submit_newadmission.Size = new System.Drawing.Size(184, 68);
            this.button_submit_newadmission.TabIndex = 18;
            this.button_submit_newadmission.Text = "Submit";
            this.button_submit_newadmission.UseVisualStyleBackColor = false;
            this.button_submit_newadmission.Click += new System.EventHandler(this.button_submit_newadmission_Click);
            this.button_submit_newadmission.Enter += new System.EventHandler(this.button_submit_newadmission_Enter);
            this.button_submit_newadmission.Leave += new System.EventHandler(this.button_submit_newadmission_Leave);
            this.button_submit_newadmission.MouseEnter += new System.EventHandler(this.button_submit_newadmission_MouseEnter);
            this.button_submit_newadmission.MouseLeave += new System.EventHandler(this.button_submit_newadmission_MouseLeave);
            // 
            // button_reset
            // 
            this.button_reset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.button_reset.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_reset.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_reset.ForeColor = System.Drawing.Color.White;
            this.button_reset.Location = new System.Drawing.Point(290, 596);
            this.button_reset.Name = "button_reset";
            this.button_reset.Size = new System.Drawing.Size(184, 68);
            this.button_reset.TabIndex = 16;
            this.button_reset.Text = "Reset";
            this.button_reset.UseVisualStyleBackColor = false;
            this.button_reset.Click += new System.EventHandler(this.button_reset_Click);
            this.button_reset.Enter += new System.EventHandler(this.button_clear_Enter);
            this.button_reset.Leave += new System.EventHandler(this.button_clear_Leave);
            this.button_reset.MouseEnter += new System.EventHandler(this.button_clear_MouseEnter);
            this.button_reset.MouseLeave += new System.EventHandler(this.button_clear_MouseLeave);
            // 
            // button_searchmember
            // 
            this.button_searchmember.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.button_searchmember.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_searchmember.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold);
            this.button_searchmember.ForeColor = System.Drawing.Color.White;
            this.button_searchmember.Location = new System.Drawing.Point(535, 596);
            this.button_searchmember.Name = "button_searchmember";
            this.button_searchmember.Size = new System.Drawing.Size(184, 68);
            this.button_searchmember.TabIndex = 17;
            this.button_searchmember.Text = "Search Member";
            this.button_searchmember.UseVisualStyleBackColor = false;
            this.button_searchmember.Click += new System.EventHandler(this.button_searchmember_Click);
            this.button_searchmember.Enter += new System.EventHandler(this.button_searchmember_Enter);
            this.button_searchmember.Leave += new System.EventHandler(this.button_searchmember_Leave);
            this.button_searchmember.MouseEnter += new System.EventHandler(this.button_searchmember_MouseEnter);
            this.button_searchmember.MouseLeave += new System.EventHandler(this.button_searchmember_MouseLeave);
            // 
            // label_errorgymno
            // 
            this.label_errorgymno.AutoSize = true;
            this.label_errorgymno.BackColor = System.Drawing.Color.White;
            this.label_errorgymno.Font = new System.Drawing.Font("Calibri", 12F);
            this.label_errorgymno.ForeColor = System.Drawing.Color.Red;
            this.label_errorgymno.Location = new System.Drawing.Point(493, 43);
            this.label_errorgymno.Name = "label_errorgymno";
            this.label_errorgymno.Size = new System.Drawing.Size(25, 29);
            this.label_errorgymno.TabIndex = 21;
            this.label_errorgymno.Text = "*";
            this.label_errorgymno.Visible = false;
            // 
            // label_errorname
            // 
            this.label_errorname.AutoSize = true;
            this.label_errorname.BackColor = System.Drawing.Color.White;
            this.label_errorname.Font = new System.Drawing.Font("Calibri", 12F);
            this.label_errorname.ForeColor = System.Drawing.Color.Red;
            this.label_errorname.Location = new System.Drawing.Point(493, 117);
            this.label_errorname.Name = "label_errorname";
            this.label_errorname.Size = new System.Drawing.Size(25, 29);
            this.label_errorname.TabIndex = 22;
            this.label_errorname.Text = "*";
            this.label_errorname.Visible = false;
            // 
            // label_errorcategory
            // 
            this.label_errorcategory.AutoSize = true;
            this.label_errorcategory.BackColor = System.Drawing.Color.Transparent;
            this.label_errorcategory.Font = new System.Drawing.Font("Calibri", 12F);
            this.label_errorcategory.ForeColor = System.Drawing.Color.Red;
            this.label_errorcategory.Location = new System.Drawing.Point(719, 47);
            this.label_errorcategory.Name = "label_errorcategory";
            this.label_errorcategory.Size = new System.Drawing.Size(25, 29);
            this.label_errorcategory.TabIndex = 23;
            this.label_errorcategory.Text = "*";
            this.label_errorcategory.Visible = false;
            // 
            // label_errorpackage
            // 
            this.label_errorpackage.AutoSize = true;
            this.label_errorpackage.BackColor = System.Drawing.Color.Transparent;
            this.label_errorpackage.Font = new System.Drawing.Font("Calibri", 12F);
            this.label_errorpackage.ForeColor = System.Drawing.Color.Red;
            this.label_errorpackage.Location = new System.Drawing.Point(714, 362);
            this.label_errorpackage.Name = "label_errorpackage";
            this.label_errorpackage.Size = new System.Drawing.Size(25, 29);
            this.label_errorpackage.TabIndex = 24;
            this.label_errorpackage.Text = "*";
            this.label_errorpackage.Visible = false;
            // 
            // label_gender
            // 
            this.label_gender.AutoSize = true;
            this.label_gender.BackColor = System.Drawing.Color.Transparent;
            this.label_gender.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_gender.ForeColor = System.Drawing.Color.White;
            this.label_gender.Location = new System.Drawing.Point(603, 504);
            this.label_gender.Name = "label_gender";
            this.label_gender.Size = new System.Drawing.Size(101, 35);
            this.label_gender.TabIndex = 16;
            this.label_gender.Text = "Gender";
            // 
            // comboBox_gender
            // 
            this.comboBox_gender.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_gender.FormattingEnabled = true;
            this.comboBox_gender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.comboBox_gender.Location = new System.Drawing.Point(769, 507);
            this.comboBox_gender.Name = "comboBox_gender";
            this.comboBox_gender.Size = new System.Drawing.Size(424, 32);
            this.comboBox_gender.TabIndex = 15;
            this.comboBox_gender.Text = "                             Select Gender";
            this.comboBox_gender.Enter += new System.EventHandler(this.comboBox_gender_Enter);
            this.comboBox_gender.Leave += new System.EventHandler(this.comboBox_gender_Leave);
            // 
            // comboBox_category
            // 
            this.comboBox_category.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_category.FormattingEnabled = true;
            this.comboBox_category.Items.AddRange(new object[] {
            "Student",
            "Non Student"});
            this.comboBox_category.Location = new System.Drawing.Point(769, 44);
            this.comboBox_category.Name = "comboBox_category";
            this.comboBox_category.Size = new System.Drawing.Size(424, 32);
            this.comboBox_category.TabIndex = 2;
            this.comboBox_category.Text = "                             Select Category";
            this.comboBox_category.Enter += new System.EventHandler(this.comboBox_category_Enter);
            this.comboBox_category.Leave += new System.EventHandler(this.comboBox_category_Leave);
            // 
            // label_gym_no_exists
            // 
            this.label_gym_no_exists.AutoSize = true;
            this.label_gym_no_exists.BackColor = System.Drawing.Color.Transparent;
            this.label_gym_no_exists.Font = new System.Drawing.Font("Calibri", 9F);
            this.label_gym_no_exists.ForeColor = System.Drawing.Color.White;
            this.label_gym_no_exists.Location = new System.Drawing.Point(330, 15);
            this.label_gym_no_exists.Name = "label_gym_no_exists";
            this.label_gym_no_exists.Size = new System.Drawing.Size(187, 22);
            this.label_gym_no_exists.TabIndex = 25;
            this.label_gym_no_exists.Text = "Gym no already exists!!!";
            this.label_gym_no_exists.Visible = false;
            // 
            // NewAdmission
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1236, 737);
            this.Controls.Add(this.label_gym_no_exists);
            this.Controls.Add(this.comboBox_category);
            this.Controls.Add(this.comboBox_gender);
            this.Controls.Add(this.label_gender);
            this.Controls.Add(this.label_errorpackage);
            this.Controls.Add(this.label_errorcategory);
            this.Controls.Add(this.label_errorname);
            this.Controls.Add(this.label_errorgymno);
            this.Controls.Add(this.button_searchmember);
            this.Controls.Add(this.button_reset);
            this.Controls.Add(this.button_submit_newadmission);
            this.Controls.Add(this.dateTimePicker_dateofjoining);
            this.Controls.Add(this.label_dateofjoining);
            this.Controls.Add(this.comboBox_selecttrainer);
            this.Controls.Add(this.label_trainer);
            this.Controls.Add(this.textBox_admissionfee);
            this.Controls.Add(this.label_admissionfee);
            this.Controls.Add(this.label_category);
            this.Controls.Add(this.textBox_gymno);
            this.Controls.Add(this.label_gymno);
            this.Controls.Add(this.comboBox_package);
            this.Controls.Add(this.label_package);
            this.Controls.Add(this.textBox_purpose);
            this.Controls.Add(this.label_purpose);
            this.Controls.Add(this.textBox_height_in);
            this.Controls.Add(this.textBox_height_ft);
            this.Controls.Add(this.label_height);
            this.Controls.Add(this.textBox_weight);
            this.Controls.Add(this.label_weight);
            this.Controls.Add(this.textBox_address);
            this.Controls.Add(this.label_address);
            this.Controls.Add(this.textBox_contact);
            this.Controls.Add(this.label_contact);
            this.Controls.Add(this.textBox_name);
            this.Controls.Add(this.textBox_fathername);
            this.Controls.Add(this.label_fathername);
            this.Controls.Add(this.label_name);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NewAdmission";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NewAdmission";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.Label label_fathername;
        private System.Windows.Forms.TextBox textBox_fathername;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.Label label_contact;
        private System.Windows.Forms.TextBox textBox_contact;
        private System.Windows.Forms.Label label_address;
        private System.Windows.Forms.TextBox textBox_address;
        private System.Windows.Forms.Label label_weight;
        private System.Windows.Forms.TextBox textBox_weight;
        private System.Windows.Forms.Label label_height;
        private System.Windows.Forms.TextBox textBox_height_ft;
        private System.Windows.Forms.TextBox textBox_height_in;
        private System.Windows.Forms.Label label_purpose;
        private System.Windows.Forms.TextBox textBox_purpose;
        private System.Windows.Forms.Label label_package;
        private System.Windows.Forms.ComboBox comboBox_package;
        private System.Windows.Forms.Label label_gymno;
        private System.Windows.Forms.TextBox textBox_gymno;
        private System.Windows.Forms.Label label_category;
        private System.Windows.Forms.Label label_admissionfee;
        private System.Windows.Forms.TextBox textBox_admissionfee;
        private System.Windows.Forms.Label label_trainer;
        private System.Windows.Forms.ComboBox comboBox_selecttrainer;
        private System.Windows.Forms.Label label_dateofjoining;
        private System.Windows.Forms.DateTimePicker dateTimePicker_dateofjoining;
        private System.Windows.Forms.Button button_submit_newadmission;
        private System.Windows.Forms.Button button_reset;
        private System.Windows.Forms.Button button_searchmember;
        private System.Windows.Forms.Label label_errorgymno;
        private System.Windows.Forms.Label label_errorname;
        private System.Windows.Forms.Label label_errorcategory;
        private System.Windows.Forms.Label label_errorpackage;
        private System.Windows.Forms.Label label_gender;
        private System.Windows.Forms.ComboBox comboBox_gender;
        private System.Windows.Forms.ComboBox comboBox_category;
        private System.Windows.Forms.Label label_gym_no_exists;
    }
}