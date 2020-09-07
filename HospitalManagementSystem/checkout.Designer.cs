namespace HospitalManagementSystem
{
    partial class checkout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(checkout));
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dob = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label16 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.cnic = new System.Windows.Forms.MaskedTextBox();
            this.gender = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.statusofdisease = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.postalcode = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.contact = new System.Windows.Forms.MaskedTextBox();
            this.admitteddate = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label15 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.disease = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label12 = new System.Windows.Forms.Label();
            this.city = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.colony = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.street = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.house = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label11 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lname = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.fname = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label2 = new System.Windows.Forms.Label();
            this.patientno = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.finalfee = new System.Windows.Forms.MaskedTextBox();
            this.roomno = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.roomtype = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label10 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.btncheckout = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuThinButton22 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnunselect = new Bunifu.Framework.UI.BunifuThinButton2();
            this.hidden = new System.Windows.Forms.Label();
            this.checkoutstatus = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label17 = new System.Windows.Forms.Label();
            this.refresh = new Bunifu.Framework.UI.BunifuThinButton2();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(16, 24);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(188, 292);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.ListBox1_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dob);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.cnic);
            this.groupBox1.Controls.Add(this.gender);
            this.groupBox1.Controls.Add(this.statusofdisease);
            this.groupBox1.Controls.Add(this.postalcode);
            this.groupBox1.Controls.Add(this.contact);
            this.groupBox1.Controls.Add(this.admitteddate);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.disease);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.city);
            this.groupBox1.Controls.Add(this.colony);
            this.groupBox1.Controls.Add(this.street);
            this.groupBox1.Controls.Add(this.house);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.lname);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.fname);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.patientno);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(241, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(472, 653);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Appointment";
            // 
            // dob
            // 
            this.dob.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.dob.Enabled = false;
            this.dob.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dob.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dob.HintForeColor = System.Drawing.Color.Empty;
            this.dob.HintText = "";
            this.dob.isPassword = false;
            this.dob.LineFocusedColor = System.Drawing.Color.Blue;
            this.dob.LineIdleColor = System.Drawing.Color.Gray;
            this.dob.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.dob.LineThickness = 3;
            this.dob.Location = new System.Drawing.Point(232, 243);
            this.dob.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.dob.Name = "dob";
            this.dob.Size = new System.Drawing.Size(208, 32);
            this.dob.TabIndex = 50;
            this.dob.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(22, 250);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(55, 25);
            this.label16.TabIndex = 49;
            this.label16.Text = "DOB";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(22, 165);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(61, 25);
            this.label14.TabIndex = 48;
            this.label14.Text = "CNIC";
            // 
            // cnic
            // 
            this.cnic.BackColor = System.Drawing.SystemColors.Control;
            this.cnic.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cnic.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cnic.Location = new System.Drawing.Point(232, 158);
            this.cnic.Mask = "00000-0000000-0";
            this.cnic.Name = "cnic";
            this.cnic.Size = new System.Drawing.Size(208, 32);
            this.cnic.TabIndex = 47;
            this.cnic.ValidatingType = typeof(System.DateTime);
            // 
            // gender
            // 
            this.gender.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gender.Enabled = false;
            this.gender.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gender.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.gender.HintForeColor = System.Drawing.Color.Empty;
            this.gender.HintText = "";
            this.gender.isPassword = false;
            this.gender.LineFocusedColor = System.Drawing.Color.Blue;
            this.gender.LineIdleColor = System.Drawing.Color.Gray;
            this.gender.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.gender.LineThickness = 3;
            this.gender.Location = new System.Drawing.Point(232, 199);
            this.gender.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.gender.Name = "gender";
            this.gender.Size = new System.Drawing.Size(208, 32);
            this.gender.TabIndex = 46;
            this.gender.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // statusofdisease
            // 
            this.statusofdisease.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.statusofdisease.Enabled = false;
            this.statusofdisease.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusofdisease.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.statusofdisease.HintForeColor = System.Drawing.Color.Empty;
            this.statusofdisease.HintText = "";
            this.statusofdisease.isPassword = false;
            this.statusofdisease.LineFocusedColor = System.Drawing.Color.Blue;
            this.statusofdisease.LineIdleColor = System.Drawing.Color.Gray;
            this.statusofdisease.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.statusofdisease.LineThickness = 3;
            this.statusofdisease.Location = new System.Drawing.Point(232, 603);
            this.statusofdisease.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.statusofdisease.Name = "statusofdisease";
            this.statusofdisease.Size = new System.Drawing.Size(208, 32);
            this.statusofdisease.TabIndex = 45;
            this.statusofdisease.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // postalcode
            // 
            this.postalcode.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.postalcode.Enabled = false;
            this.postalcode.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.postalcode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.postalcode.HintForeColor = System.Drawing.Color.Empty;
            this.postalcode.HintText = "";
            this.postalcode.isPassword = false;
            this.postalcode.LineFocusedColor = System.Drawing.Color.Blue;
            this.postalcode.LineIdleColor = System.Drawing.Color.Gray;
            this.postalcode.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.postalcode.LineThickness = 3;
            this.postalcode.Location = new System.Drawing.Point(232, 445);
            this.postalcode.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.postalcode.Name = "postalcode";
            this.postalcode.Size = new System.Drawing.Size(208, 32);
            this.postalcode.TabIndex = 26;
            this.postalcode.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // contact
            // 
            this.contact.BackColor = System.Drawing.SystemColors.Control;
            this.contact.Enabled = false;
            this.contact.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contact.ForeColor = System.Drawing.SystemColors.WindowText;
            this.contact.Location = new System.Drawing.Point(232, 484);
            this.contact.Mask = "0000-0000000";
            this.contact.Name = "contact";
            this.contact.Size = new System.Drawing.Size(208, 32);
            this.contact.TabIndex = 44;
            this.contact.ValidatingType = typeof(System.DateTime);
            // 
            // admitteddate
            // 
            this.admitteddate.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.admitteddate.Enabled = false;
            this.admitteddate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admitteddate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.admitteddate.HintForeColor = System.Drawing.Color.Empty;
            this.admitteddate.HintText = "";
            this.admitteddate.isPassword = false;
            this.admitteddate.LineFocusedColor = System.Drawing.Color.Blue;
            this.admitteddate.LineIdleColor = System.Drawing.Color.Gray;
            this.admitteddate.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.admitteddate.LineThickness = 3;
            this.admitteddate.Location = new System.Drawing.Point(232, 523);
            this.admitteddate.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.admitteddate.Name = "admitteddate";
            this.admitteddate.Size = new System.Drawing.Size(208, 32);
            this.admitteddate.TabIndex = 35;
            this.admitteddate.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(22, 484);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(80, 25);
            this.label15.TabIndex = 31;
            this.label15.Text = "Contact";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(22, 610);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(165, 25);
            this.label13.TabIndex = 29;
            this.label13.Text = "Status of Disease";
            // 
            // disease
            // 
            this.disease.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.disease.Enabled = false;
            this.disease.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.disease.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.disease.HintForeColor = System.Drawing.Color.Empty;
            this.disease.HintText = "";
            this.disease.isPassword = false;
            this.disease.LineFocusedColor = System.Drawing.Color.Blue;
            this.disease.LineIdleColor = System.Drawing.Color.Gray;
            this.disease.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.disease.LineThickness = 3;
            this.disease.Location = new System.Drawing.Point(232, 563);
            this.disease.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.disease.Name = "disease";
            this.disease.Size = new System.Drawing.Size(208, 32);
            this.disease.TabIndex = 28;
            this.disease.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(22, 570);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(83, 25);
            this.label12.TabIndex = 27;
            this.label12.Text = "Disease";
            // 
            // city
            // 
            this.city.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.city.Enabled = false;
            this.city.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.city.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.city.HintForeColor = System.Drawing.Color.Empty;
            this.city.HintText = "";
            this.city.isPassword = false;
            this.city.LineFocusedColor = System.Drawing.Color.Blue;
            this.city.LineIdleColor = System.Drawing.Color.Gray;
            this.city.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.city.LineThickness = 3;
            this.city.Location = new System.Drawing.Point(232, 405);
            this.city.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.city.Name = "city";
            this.city.Size = new System.Drawing.Size(208, 32);
            this.city.TabIndex = 25;
            this.city.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // colony
            // 
            this.colony.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.colony.Enabled = false;
            this.colony.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colony.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.colony.HintForeColor = System.Drawing.Color.Empty;
            this.colony.HintText = "";
            this.colony.isPassword = false;
            this.colony.LineFocusedColor = System.Drawing.Color.Blue;
            this.colony.LineIdleColor = System.Drawing.Color.Gray;
            this.colony.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.colony.LineThickness = 3;
            this.colony.Location = new System.Drawing.Point(232, 365);
            this.colony.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.colony.Name = "colony";
            this.colony.Size = new System.Drawing.Size(208, 32);
            this.colony.TabIndex = 24;
            this.colony.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // street
            // 
            this.street.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.street.Enabled = false;
            this.street.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.street.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.street.HintForeColor = System.Drawing.Color.Empty;
            this.street.HintText = "";
            this.street.isPassword = false;
            this.street.LineFocusedColor = System.Drawing.Color.Blue;
            this.street.LineIdleColor = System.Drawing.Color.Gray;
            this.street.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.street.LineThickness = 3;
            this.street.Location = new System.Drawing.Point(232, 325);
            this.street.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.street.Name = "street";
            this.street.Size = new System.Drawing.Size(208, 32);
            this.street.TabIndex = 23;
            this.street.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // house
            // 
            this.house.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.house.Enabled = false;
            this.house.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.house.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.house.HintForeColor = System.Drawing.Color.Empty;
            this.house.HintText = "";
            this.house.isPassword = false;
            this.house.LineFocusedColor = System.Drawing.Color.Blue;
            this.house.LineIdleColor = System.Drawing.Color.Gray;
            this.house.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.house.LineThickness = 3;
            this.house.Location = new System.Drawing.Point(232, 285);
            this.house.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.house.Name = "house";
            this.house.Size = new System.Drawing.Size(208, 32);
            this.house.TabIndex = 22;
            this.house.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(22, 530);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(135, 25);
            this.label11.TabIndex = 19;
            this.label11.Text = "Admitted Date";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(22, 372);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 25);
            this.label7.TabIndex = 17;
            this.label7.Text = "Colony";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(22, 447);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(119, 25);
            this.label8.TabIndex = 16;
            this.label8.Text = "Postal Code";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(22, 412);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 25);
            this.label9.TabIndex = 15;
            this.label9.Text = "City";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(22, 206);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 25);
            this.label6.TabIndex = 13;
            this.label6.Text = "Gender";
            // 
            // lname
            // 
            this.lname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lname.Enabled = false;
            this.lname.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lname.HintForeColor = System.Drawing.Color.Empty;
            this.lname.HintText = "";
            this.lname.isPassword = false;
            this.lname.LineFocusedColor = System.Drawing.Color.Blue;
            this.lname.LineIdleColor = System.Drawing.Color.Gray;
            this.lname.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.lname.LineThickness = 3;
            this.lname.Location = new System.Drawing.Point(232, 116);
            this.lname.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.lname.Name = "lname";
            this.lname.Size = new System.Drawing.Size(208, 32);
            this.lname.TabIndex = 7;
            this.lname.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(22, 336);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 25);
            this.label5.TabIndex = 6;
            this.label5.Text = "Street";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 292);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "House";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Last Name";
            // 
            // fname
            // 
            this.fname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.fname.Enabled = false;
            this.fname.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.fname.HintForeColor = System.Drawing.Color.Empty;
            this.fname.HintText = "";
            this.fname.isPassword = false;
            this.fname.LineFocusedColor = System.Drawing.Color.Blue;
            this.fname.LineIdleColor = System.Drawing.Color.Gray;
            this.fname.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.fname.LineThickness = 3;
            this.fname.Location = new System.Drawing.Point(232, 76);
            this.fname.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.fname.Name = "fname";
            this.fname.Size = new System.Drawing.Size(208, 32);
            this.fname.TabIndex = 3;
            this.fname.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "First Name";
            // 
            // patientno
            // 
            this.patientno.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.patientno.Enabled = false;
            this.patientno.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientno.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.patientno.HintForeColor = System.Drawing.Color.Empty;
            this.patientno.HintText = "";
            this.patientno.isPassword = false;
            this.patientno.LineFocusedColor = System.Drawing.Color.Blue;
            this.patientno.LineIdleColor = System.Drawing.Color.Gray;
            this.patientno.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.patientno.LineThickness = 3;
            this.patientno.Location = new System.Drawing.Point(232, 35);
            this.patientno.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.patientno.Name = "patientno";
            this.patientno.Size = new System.Drawing.Size(126, 32);
            this.patientno.TabIndex = 1;
            this.patientno.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Patient No";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkoutstatus);
            this.groupBox2.Controls.Add(this.finalfee);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.roomno);
            this.groupBox2.Controls.Add(this.roomtype);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label20);
            this.groupBox2.Controls.Add(this.label22);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(784, 20);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(407, 246);
            this.groupBox2.TabIndex = 39;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Room\'s Information";
            // 
            // finalfee
            // 
            this.finalfee.BackColor = System.Drawing.SystemColors.Control;
            this.finalfee.Enabled = false;
            this.finalfee.ForeColor = System.Drawing.SystemColors.WindowText;
            this.finalfee.Location = new System.Drawing.Point(181, 132);
            this.finalfee.Mask = "0000";
            this.finalfee.Name = "finalfee";
            this.finalfee.Size = new System.Drawing.Size(53, 30);
            this.finalfee.TabIndex = 45;
            this.finalfee.ValidatingType = typeof(System.DateTime);
            // 
            // roomno
            // 
            this.roomno.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.roomno.Enabled = false;
            this.roomno.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomno.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.roomno.HintForeColor = System.Drawing.Color.Empty;
            this.roomno.HintText = "";
            this.roomno.isPassword = false;
            this.roomno.LineFocusedColor = System.Drawing.Color.Blue;
            this.roomno.LineIdleColor = System.Drawing.Color.Gray;
            this.roomno.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.roomno.LineThickness = 3;
            this.roomno.Location = new System.Drawing.Point(181, 83);
            this.roomno.Margin = new System.Windows.Forms.Padding(4);
            this.roomno.Name = "roomno";
            this.roomno.Size = new System.Drawing.Size(91, 30);
            this.roomno.TabIndex = 42;
            this.roomno.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // roomtype
            // 
            this.roomtype.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.roomtype.Enabled = false;
            this.roomtype.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomtype.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.roomtype.HintForeColor = System.Drawing.Color.Empty;
            this.roomtype.HintText = "";
            this.roomtype.isPassword = false;
            this.roomtype.LineFocusedColor = System.Drawing.Color.Blue;
            this.roomtype.LineIdleColor = System.Drawing.Color.Gray;
            this.roomtype.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.roomtype.LineThickness = 3;
            this.roomtype.Location = new System.Drawing.Point(181, 42);
            this.roomtype.Margin = new System.Windows.Forms.Padding(4);
            this.roomtype.Name = "roomtype";
            this.roomtype.Size = new System.Drawing.Size(91, 30);
            this.roomtype.TabIndex = 41;
            this.roomtype.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(22, 137);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(128, 25);
            this.label10.TabIndex = 39;
            this.label10.Text = "Admitted Fee";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(22, 42);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(113, 25);
            this.label20.TabIndex = 4;
            this.label20.Text = "Room Type";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(22, 87);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(93, 25);
            this.label22.TabIndex = 0;
            this.label22.Text = "Room No";
            // 
            // btncheckout
            // 
            this.btncheckout.ActiveBorderThickness = 1;
            this.btncheckout.ActiveCornerRadius = 20;
            this.btncheckout.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btncheckout.ActiveForecolor = System.Drawing.Color.White;
            this.btncheckout.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btncheckout.BackColor = System.Drawing.SystemColors.Control;
            this.btncheckout.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btncheckout.BackgroundImage")));
            this.btncheckout.ButtonText = "Checkout";
            this.btncheckout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncheckout.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncheckout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btncheckout.IdleBorderThickness = 1;
            this.btncheckout.IdleCornerRadius = 20;
            this.btncheckout.IdleFillColor = System.Drawing.Color.White;
            this.btncheckout.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(161)))), ((int)(((byte)(242)))));
            this.btncheckout.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(161)))), ((int)(((byte)(242)))));
            this.btncheckout.Location = new System.Drawing.Point(784, 289);
            this.btncheckout.Margin = new System.Windows.Forms.Padding(5);
            this.btncheckout.Name = "btncheckout";
            this.btncheckout.Size = new System.Drawing.Size(135, 48);
            this.btncheckout.TabIndex = 40;
            this.btncheckout.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btncheckout.Click += new System.EventHandler(this.Btncheckout_Click);
            // 
            // bunifuThinButton22
            // 
            this.bunifuThinButton22.ActiveBorderThickness = 1;
            this.bunifuThinButton22.ActiveCornerRadius = 20;
            this.bunifuThinButton22.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.bunifuThinButton22.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton22.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.bunifuThinButton22.BackColor = System.Drawing.SystemColors.Control;
            this.bunifuThinButton22.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton22.BackgroundImage")));
            this.bunifuThinButton22.ButtonText = "Close";
            this.bunifuThinButton22.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton22.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton22.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.bunifuThinButton22.IdleBorderThickness = 1;
            this.bunifuThinButton22.IdleCornerRadius = 20;
            this.bunifuThinButton22.IdleFillColor = System.Drawing.Color.White;
            this.bunifuThinButton22.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(161)))), ((int)(((byte)(242)))));
            this.bunifuThinButton22.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(161)))), ((int)(((byte)(242)))));
            this.bunifuThinButton22.Location = new System.Drawing.Point(1065, 288);
            this.bunifuThinButton22.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuThinButton22.Name = "bunifuThinButton22";
            this.bunifuThinButton22.Size = new System.Drawing.Size(126, 48);
            this.bunifuThinButton22.TabIndex = 41;
            this.bunifuThinButton22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.btnunselect.Location = new System.Drawing.Point(16, 323);
            this.btnunselect.Margin = new System.Windows.Forms.Padding(5);
            this.btnunselect.Name = "btnunselect";
            this.btnunselect.Size = new System.Drawing.Size(188, 48);
            this.btnunselect.TabIndex = 42;
            this.btnunselect.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnunselect.Click += new System.EventHandler(this.Btnunselect_Click);
            // 
            // hidden
            // 
            this.hidden.AutoSize = true;
            this.hidden.ForeColor = System.Drawing.SystemColors.Control;
            this.hidden.Location = new System.Drawing.Point(872, 396);
            this.hidden.Name = "hidden";
            this.hidden.Size = new System.Drawing.Size(0, 17);
            this.hidden.TabIndex = 43;
            // 
            // checkoutstatus
            // 
            this.checkoutstatus.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.checkoutstatus.Enabled = false;
            this.checkoutstatus.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkoutstatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.checkoutstatus.HintForeColor = System.Drawing.Color.Empty;
            this.checkoutstatus.HintText = "";
            this.checkoutstatus.isPassword = false;
            this.checkoutstatus.LineFocusedColor = System.Drawing.Color.Blue;
            this.checkoutstatus.LineIdleColor = System.Drawing.Color.Gray;
            this.checkoutstatus.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.checkoutstatus.LineThickness = 3;
            this.checkoutstatus.Location = new System.Drawing.Point(181, 179);
            this.checkoutstatus.Margin = new System.Windows.Forms.Padding(4);
            this.checkoutstatus.Name = "checkoutstatus";
            this.checkoutstatus.Size = new System.Drawing.Size(91, 30);
            this.checkoutstatus.TabIndex = 45;
            this.checkoutstatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(22, 184);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(152, 25);
            this.label17.TabIndex = 44;
            this.label17.Text = "CheckoutStatus";
            // 
            // refresh
            // 
            this.refresh.ActiveBorderThickness = 1;
            this.refresh.ActiveCornerRadius = 20;
            this.refresh.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.refresh.ActiveForecolor = System.Drawing.Color.White;
            this.refresh.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.refresh.BackColor = System.Drawing.SystemColors.Control;
            this.refresh.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("refresh.BackgroundImage")));
            this.refresh.ButtonText = "Refresh";
            this.refresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.refresh.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refresh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.refresh.IdleBorderThickness = 1;
            this.refresh.IdleCornerRadius = 20;
            this.refresh.IdleFillColor = System.Drawing.Color.White;
            this.refresh.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(161)))), ((int)(((byte)(242)))));
            this.refresh.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(161)))), ((int)(((byte)(242)))));
            this.refresh.Location = new System.Drawing.Point(16, 369);
            this.refresh.Margin = new System.Windows.Forms.Padding(5);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(188, 48);
            this.refresh.TabIndex = 44;
            this.refresh.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.refresh.Click += new System.EventHandler(this.Refresh_Click);
            // 
            // checkout
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.refresh);
            this.Controls.Add(this.hidden);
            this.Controls.Add(this.btnunselect);
            this.Controls.Add(this.bunifuThinButton22);
            this.Controls.Add(this.btncheckout);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listBox1);
            this.Name = "checkout";
            this.Size = new System.Drawing.Size(1500, 1000);
            this.Load += new System.EventHandler(this.Checkout_Load);
            
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label13;
        private Bunifu.Framework.UI.BunifuMaterialTextbox disease;
        private System.Windows.Forms.Label label12;
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
        private Bunifu.Framework.UI.BunifuMaterialTextbox lname;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuMaterialTextbox fname;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox patientno;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox roomno;
        private Bunifu.Framework.UI.BunifuMaterialTextbox roomtype;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label22;
        private Bunifu.Framework.UI.BunifuThinButton2 btncheckout;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton22;
        private System.Windows.Forms.MaskedTextBox contact;
        private Bunifu.Framework.UI.BunifuMaterialTextbox admitteddate;
        private Bunifu.Framework.UI.BunifuMaterialTextbox statusofdisease;
        private System.Windows.Forms.MaskedTextBox finalfee;
        private Bunifu.Framework.UI.BunifuThinButton2 btnunselect;
        private Bunifu.Framework.UI.BunifuMaterialTextbox gender;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.MaskedTextBox cnic;
        private Bunifu.Framework.UI.BunifuMaterialTextbox dob;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label hidden;
        private Bunifu.Framework.UI.BunifuMaterialTextbox checkoutstatus;
        private System.Windows.Forms.Label label17;
        private Bunifu.Framework.UI.BunifuThinButton2 refresh;
    }
}
