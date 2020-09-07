namespace HospitalManagementSystem
{
    partial class DoctorInformation
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DoctorInformation));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.contact = new System.Windows.Forms.MaskedTextBox();
            this.hiredate = new System.Windows.Forms.DateTimePicker();
            this.gender = new System.Windows.Forms.ComboBox();
            this.country = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.province = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label15 = new System.Windows.Forms.Label();
            this.job = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label13 = new System.Windows.Forms.Label();
            this.postalcode = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.city = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.colony = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.street = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.house = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label11 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lnametxt = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.fnametxt = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label2 = new System.Windows.Forms.Label();
            this.staffID = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnclose = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnadd = new Bunifu.Framework.UI.BunifuThinButton2();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label14 = new System.Windows.Forms.Label();
            this.btnupdate = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnunselect = new Bunifu.Framework.UI.BunifuThinButton2();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.contact);
            this.groupBox1.Controls.Add(this.hiredate);
            this.groupBox1.Controls.Add(this.gender);
            this.groupBox1.Controls.Add(this.country);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.province);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.job);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.postalcode);
            this.groupBox1.Controls.Add(this.city);
            this.groupBox1.Controls.Add(this.colony);
            this.groupBox1.Controls.Add(this.street);
            this.groupBox1.Controls.Add(this.house);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.lnametxt);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.fnametxt);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.staffID);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Location = new System.Drawing.Point(614, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(472, 654);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add New Staff";
            // 
            // contact
            // 
            this.contact.BackColor = System.Drawing.SystemColors.Control;
            this.contact.ForeColor = System.Drawing.SystemColors.WindowText;
            this.contact.Location = new System.Drawing.Point(229, 509);
            this.contact.Mask = "0000-0000000";
            this.contact.Name = "contact";
            this.contact.Size = new System.Drawing.Size(221, 30);
            this.contact.TabIndex = 43;
            this.contact.ValidatingType = typeof(System.DateTime);
            // 
            // hiredate
            // 
            this.hiredate.CalendarTitleBackColor = System.Drawing.SystemColors.Control;
            this.hiredate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hiredate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.hiredate.Location = new System.Drawing.Point(234, 599);
            this.hiredate.Name = "hiredate";
            this.hiredate.Size = new System.Drawing.Size(212, 32);
            this.hiredate.TabIndex = 26;
            // 
            // gender
            // 
            this.gender.BackColor = System.Drawing.SystemColors.Control;
            this.gender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.gender.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gender.FormattingEnabled = true;
            this.gender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.gender.Location = new System.Drawing.Point(233, 183);
            this.gender.Name = "gender";
            this.gender.Size = new System.Drawing.Size(212, 31);
            this.gender.TabIndex = 21;
            // 
            // country
            // 
            this.country.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.country.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.country.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.country.HintForeColor = System.Drawing.Color.Empty;
            this.country.HintText = "";
            this.country.isPassword = false;
            this.country.LineFocusedColor = System.Drawing.Color.Blue;
            this.country.LineIdleColor = System.Drawing.Color.Gray;
            this.country.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.country.LineThickness = 3;
            this.country.Location = new System.Drawing.Point(233, 427);
            this.country.Margin = new System.Windows.Forms.Padding(4);
            this.country.Name = "country";
            this.country.Size = new System.Drawing.Size(216, 30);
            this.country.TabIndex = 10;
            this.country.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(31, 431);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(81, 25);
            this.label12.TabIndex = 37;
            this.label12.Text = "Country";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(32, 606);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 25);
            this.label10.TabIndex = 36;
            this.label10.Text = "Date";
            // 
            // province
            // 
            this.province.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.province.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.province.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.province.HintForeColor = System.Drawing.Color.Empty;
            this.province.HintText = "";
            this.province.isPassword = false;
            this.province.LineFocusedColor = System.Drawing.Color.Blue;
            this.province.LineIdleColor = System.Drawing.Color.Gray;
            this.province.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.province.LineThickness = 3;
            this.province.Location = new System.Drawing.Point(233, 387);
            this.province.Margin = new System.Windows.Forms.Padding(4);
            this.province.Name = "province";
            this.province.Size = new System.Drawing.Size(216, 30);
            this.province.TabIndex = 9;
            this.province.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(32, 514);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(80, 25);
            this.label15.TabIndex = 31;
            this.label15.Text = "Contact";
            // 
            // job
            // 
            this.job.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.job.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.job.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.job.HintForeColor = System.Drawing.Color.Empty;
            this.job.HintText = "";
            this.job.isPassword = false;
            this.job.LineFocusedColor = System.Drawing.Color.Blue;
            this.job.LineIdleColor = System.Drawing.Color.Gray;
            this.job.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.job.LineThickness = 3;
            this.job.Location = new System.Drawing.Point(233, 557);
            this.job.Margin = new System.Windows.Forms.Padding(4);
            this.job.Name = "job";
            this.job.Size = new System.Drawing.Size(217, 30);
            this.job.TabIndex = 13;
            this.job.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(32, 561);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(45, 25);
            this.label13.TabIndex = 29;
            this.label13.Text = "Job";
            // 
            // postalcode
            // 
            this.postalcode.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.postalcode.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.postalcode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.postalcode.HintForeColor = System.Drawing.Color.Empty;
            this.postalcode.HintText = "";
            this.postalcode.isPassword = false;
            this.postalcode.LineFocusedColor = System.Drawing.Color.Blue;
            this.postalcode.LineIdleColor = System.Drawing.Color.Gray;
            this.postalcode.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.postalcode.LineThickness = 3;
            this.postalcode.Location = new System.Drawing.Point(233, 473);
            this.postalcode.Margin = new System.Windows.Forms.Padding(4);
            this.postalcode.Name = "postalcode";
            this.postalcode.Size = new System.Drawing.Size(216, 30);
            this.postalcode.TabIndex = 11;
            this.postalcode.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // city
            // 
            this.city.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.city.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.city.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.city.HintForeColor = System.Drawing.Color.Empty;
            this.city.HintText = "";
            this.city.isPassword = false;
            this.city.LineFocusedColor = System.Drawing.Color.Blue;
            this.city.LineIdleColor = System.Drawing.Color.Gray;
            this.city.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.city.LineThickness = 3;
            this.city.Location = new System.Drawing.Point(233, 342);
            this.city.Margin = new System.Windows.Forms.Padding(4);
            this.city.Name = "city";
            this.city.Size = new System.Drawing.Size(216, 30);
            this.city.TabIndex = 8;
            this.city.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // colony
            // 
            this.colony.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.colony.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colony.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.colony.HintForeColor = System.Drawing.Color.Empty;
            this.colony.HintText = "";
            this.colony.isPassword = false;
            this.colony.LineFocusedColor = System.Drawing.Color.Blue;
            this.colony.LineIdleColor = System.Drawing.Color.Gray;
            this.colony.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.colony.LineThickness = 3;
            this.colony.Location = new System.Drawing.Point(233, 302);
            this.colony.Margin = new System.Windows.Forms.Padding(4);
            this.colony.Name = "colony";
            this.colony.Size = new System.Drawing.Size(212, 30);
            this.colony.TabIndex = 7;
            this.colony.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // street
            // 
            this.street.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.street.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.street.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.street.HintForeColor = System.Drawing.Color.Empty;
            this.street.HintText = "";
            this.street.isPassword = false;
            this.street.LineFocusedColor = System.Drawing.Color.Blue;
            this.street.LineIdleColor = System.Drawing.Color.Gray;
            this.street.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.street.LineThickness = 3;
            this.street.Location = new System.Drawing.Point(233, 263);
            this.street.Margin = new System.Windows.Forms.Padding(4);
            this.street.Name = "street";
            this.street.Size = new System.Drawing.Size(212, 30);
            this.street.TabIndex = 6;
            this.street.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // house
            // 
            this.house.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.house.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.house.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.house.HintForeColor = System.Drawing.Color.Empty;
            this.house.HintText = "";
            this.house.isPassword = false;
            this.house.LineFocusedColor = System.Drawing.Color.Blue;
            this.house.LineIdleColor = System.Drawing.Color.Gray;
            this.house.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.house.LineThickness = 3;
            this.house.Location = new System.Drawing.Point(233, 220);
            this.house.Margin = new System.Windows.Forms.Padding(4);
            this.house.Name = "house";
            this.house.Size = new System.Drawing.Size(212, 30);
            this.house.TabIndex = 5;
            this.house.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(31, 391);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(88, 25);
            this.label11.TabIndex = 19;
            this.label11.Text = "Province";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(27, 306);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 25);
            this.label7.TabIndex = 17;
            this.label7.Text = "Colony";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(31, 477);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(119, 25);
            this.label8.TabIndex = 16;
            this.label8.Text = "Postal Code";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(31, 346);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 25);
            this.label9.TabIndex = 15;
            this.label9.Text = "City";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(27, 182);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 25);
            this.label6.TabIndex = 13;
            this.label6.Text = "Gender";
            // 
            // lnametxt
            // 
            this.lnametxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lnametxt.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnametxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lnametxt.HintForeColor = System.Drawing.Color.Empty;
            this.lnametxt.HintText = "";
            this.lnametxt.isPassword = false;
            this.lnametxt.LineFocusedColor = System.Drawing.Color.Blue;
            this.lnametxt.LineIdleColor = System.Drawing.Color.Gray;
            this.lnametxt.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.lnametxt.LineThickness = 3;
            this.lnametxt.Location = new System.Drawing.Point(234, 134);
            this.lnametxt.Margin = new System.Windows.Forms.Padding(4);
            this.lnametxt.Name = "lnametxt";
            this.lnametxt.Size = new System.Drawing.Size(208, 30);
            this.lnametxt.TabIndex = 3;
            this.lnametxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(27, 267);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 25);
            this.label5.TabIndex = 6;
            this.label5.Text = "Street";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(27, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "House";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(24, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Last Name";
            // 
            // fnametxt
            // 
            this.fnametxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.fnametxt.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fnametxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.fnametxt.HintForeColor = System.Drawing.Color.Empty;
            this.fnametxt.HintText = "";
            this.fnametxt.isPassword = false;
            this.fnametxt.LineFocusedColor = System.Drawing.Color.Blue;
            this.fnametxt.LineIdleColor = System.Drawing.Color.Gray;
            this.fnametxt.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.fnametxt.LineThickness = 3;
            this.fnametxt.Location = new System.Drawing.Point(233, 89);
            this.fnametxt.Margin = new System.Windows.Forms.Padding(4);
            this.fnametxt.Name = "fnametxt";
            this.fnametxt.Size = new System.Drawing.Size(208, 30);
            this.fnametxt.TabIndex = 2;
            this.fnametxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(23, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "First Name";
            // 
            // staffID
            // 
            this.staffID.Cursor = System.Windows.Forms.Cursors.No;
            this.staffID.Enabled = false;
            this.staffID.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staffID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.staffID.HintForeColor = System.Drawing.Color.Empty;
            this.staffID.HintText = "";
            this.staffID.isPassword = false;
            this.staffID.LineFocusedColor = System.Drawing.Color.Blue;
            this.staffID.LineIdleColor = System.Drawing.Color.Gray;
            this.staffID.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.staffID.LineThickness = 3;
            this.staffID.Location = new System.Drawing.Point(233, 47);
            this.staffID.Margin = new System.Windows.Forms.Padding(4);
            this.staffID.Name = "staffID";
            this.staffID.Size = new System.Drawing.Size(105, 30);
            this.staffID.TabIndex = 1;
            this.staffID.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(23, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Staff ID";
            // 
            // btnclose
            // 
            this.btnclose.ActiveBorderThickness = 1;
            this.btnclose.ActiveCornerRadius = 20;
            this.btnclose.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnclose.ActiveForecolor = System.Drawing.Color.White;
            this.btnclose.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnclose.BackColor = System.Drawing.SystemColors.Control;
            this.btnclose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnclose.BackgroundImage")));
            this.btnclose.ButtonText = "Close";
            this.btnclose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnclose.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnclose.IdleBorderThickness = 1;
            this.btnclose.IdleCornerRadius = 20;
            this.btnclose.IdleFillColor = System.Drawing.Color.White;
            this.btnclose.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(161)))), ((int)(((byte)(242)))));
            this.btnclose.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(161)))), ((int)(((byte)(242)))));
            this.btnclose.Location = new System.Drawing.Point(976, 676);
            this.btnclose.Margin = new System.Windows.Forms.Padding(5);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(110, 48);
            this.btnclose.TabIndex = 16;
            this.btnclose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnadd
            // 
            this.btnadd.ActiveBorderThickness = 1;
            this.btnadd.ActiveCornerRadius = 20;
            this.btnadd.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnadd.ActiveForecolor = System.Drawing.Color.White;
            this.btnadd.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnadd.BackColor = System.Drawing.SystemColors.Control;
            this.btnadd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnadd.BackgroundImage")));
            this.btnadd.ButtonText = "Add";
            this.btnadd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnadd.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnadd.IdleBorderThickness = 1;
            this.btnadd.IdleCornerRadius = 20;
            this.btnadd.IdleFillColor = System.Drawing.Color.White;
            this.btnadd.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(161)))), ((int)(((byte)(242)))));
            this.btnadd.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(161)))), ((int)(((byte)(242)))));
            this.btnadd.Location = new System.Drawing.Point(614, 676);
            this.btnadd.Margin = new System.Windows.Forms.Padding(5);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(125, 48);
            this.btnadd.TabIndex = 15;
            this.btnadd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnadd.Click += new System.EventHandler(this.Btnadd_Click_1);
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 19;
            this.listBox1.Location = new System.Drawing.Point(42, 196);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(212, 403);
            this.listBox1.TabIndex = 19;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.ListBox1_SelectedIndexChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(46, 168);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(163, 23);
            this.label14.TabIndex = 20;
            this.label14.Text = "Doctor\'s Names";
            // 
            // btnupdate
            // 
            this.btnupdate.ActiveBorderThickness = 1;
            this.btnupdate.ActiveCornerRadius = 20;
            this.btnupdate.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnupdate.ActiveForecolor = System.Drawing.Color.White;
            this.btnupdate.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnupdate.BackColor = System.Drawing.SystemColors.Control;
            this.btnupdate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnupdate.BackgroundImage")));
            this.btnupdate.ButtonText = "Update";
            this.btnupdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnupdate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnupdate.IdleBorderThickness = 1;
            this.btnupdate.IdleCornerRadius = 20;
            this.btnupdate.IdleFillColor = System.Drawing.Color.White;
            this.btnupdate.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(161)))), ((int)(((byte)(242)))));
            this.btnupdate.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(161)))), ((int)(((byte)(242)))));
            this.btnupdate.Location = new System.Drawing.Point(797, 676);
            this.btnupdate.Margin = new System.Windows.Forms.Padding(5);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(125, 48);
            this.btnupdate.TabIndex = 21;
            this.btnupdate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnupdate.Click += new System.EventHandler(this.Btnupdate_Click);
            // 
            // btnunselect
            // 
            this.btnunselect.ActiveBorderThickness = 1;
            this.btnunselect.ActiveCornerRadius = 20;
            this.btnunselect.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnunselect.ActiveForecolor = System.Drawing.Color.White;
            this.btnunselect.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnunselect.BackColor = System.Drawing.SystemColors.Control;
            this.btnunselect.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnunselect.BackgroundImage")));
            this.btnunselect.ButtonText = "UnSelect";
            this.btnunselect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnunselect.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnunselect.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnunselect.IdleBorderThickness = 1;
            this.btnunselect.IdleCornerRadius = 20;
            this.btnunselect.IdleFillColor = System.Drawing.Color.White;
            this.btnunselect.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(161)))), ((int)(((byte)(242)))));
            this.btnunselect.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(161)))), ((int)(((byte)(242)))));
            this.btnunselect.Location = new System.Drawing.Point(42, 607);
            this.btnunselect.Margin = new System.Windows.Forms.Padding(5);
            this.btnunselect.Name = "btnunselect";
            this.btnunselect.Size = new System.Drawing.Size(212, 48);
            this.btnunselect.TabIndex = 32;
            this.btnunselect.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnunselect.Click += new System.EventHandler(this.Btnunselect_Click);
            // 
            // DoctorInformation
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.btnunselect);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Name = "DoctorInformation";
            this.Size = new System.Drawing.Size(1500, 1000);
            this.Load += new System.EventHandler(this.DoctorInformation_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label10;
        private Bunifu.Framework.UI.BunifuMaterialTextbox province;
        private System.Windows.Forms.Label label15;
        private Bunifu.Framework.UI.BunifuMaterialTextbox job;
        private System.Windows.Forms.Label label13;
        private Bunifu.Framework.UI.BunifuMaterialTextbox postalcode;
        private Bunifu.Framework.UI.BunifuMaterialTextbox city;
        private Bunifu.Framework.UI.BunifuMaterialTextbox colony;
        private Bunifu.Framework.UI.BunifuMaterialTextbox street;
        private Bunifu.Framework.UI.BunifuMaterialTextbox house;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private Bunifu.Framework.UI.BunifuMaterialTextbox lnametxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuMaterialTextbox fnametxt;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox staffID;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox country;
        private System.Windows.Forms.Label label12;
        private Bunifu.Framework.UI.BunifuThinButton2 btnclose;
        private Bunifu.Framework.UI.BunifuThinButton2 btnadd;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox gender;
        private Bunifu.Framework.UI.BunifuThinButton2 btnupdate;
        private System.Windows.Forms.DateTimePicker hiredate;
        private System.Windows.Forms.MaskedTextBox contact;
        private Bunifu.Framework.UI.BunifuThinButton2 btnunselect;
    }
}
