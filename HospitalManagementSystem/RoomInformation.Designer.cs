namespace HospitalManagementSystem
{
    partial class RoomInformation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RoomInformation));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.roomPrice = new System.Windows.Forms.MaskedTextBox();
            this.roomNO = new System.Windows.Forms.MaskedTextBox();
            this.roomStatus = new System.Windows.Forms.ComboBox();
            this.roomType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuDatepicker1 = new Bunifu.Framework.UI.BunifuDatepicker();
            this.label14 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.roomID = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnadd = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnclose = new Bunifu.Framework.UI.BunifuThinButton2();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.roomTypeSet = new System.Windows.Forms.ComboBox();
            this.roomDPrice = new System.Windows.Forms.MaskedTextBox();
            this.roomDNo = new System.Windows.Forms.MaskedTextBox();
            this.roomDID = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.roomDStatus = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.roomDType = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label3 = new System.Windows.Forms.Label();
            this.bunifuDatepicker2 = new Bunifu.Framework.UI.BunifuDatepicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnupdate = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnunselect = new Bunifu.Framework.UI.BunifuThinButton2();
            this.hidden = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.roomPrice);
            this.groupBox2.Controls.Add(this.roomNO);
            this.groupBox2.Controls.Add(this.roomStatus);
            this.groupBox2.Controls.Add(this.roomType);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.bunifuDatepicker1);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label20);
            this.groupBox2.Controls.Add(this.roomID);
            this.groupBox2.Controls.Add(this.label21);
            this.groupBox2.Controls.Add(this.label22);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(346, 141);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(407, 294);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Add Rooms";
            // 
            // roomPrice
            // 
            this.roomPrice.BackColor = System.Drawing.SystemColors.Control;
            this.roomPrice.ForeColor = System.Drawing.SystemColors.WindowText;
            this.roomPrice.Location = new System.Drawing.Point(180, 188);
            this.roomPrice.Mask = "00000";
            this.roomPrice.Name = "roomPrice";
            this.roomPrice.Size = new System.Drawing.Size(87, 32);
            this.roomPrice.TabIndex = 45;
            this.roomPrice.ValidatingType = typeof(System.DateTime);
            // 
            // roomNO
            // 
            this.roomNO.BackColor = System.Drawing.SystemColors.Control;
            this.roomNO.ForeColor = System.Drawing.SystemColors.WindowText;
            this.roomNO.Location = new System.Drawing.Point(180, 83);
            this.roomNO.Mask = "000";
            this.roomNO.Name = "roomNO";
            this.roomNO.Size = new System.Drawing.Size(87, 32);
            this.roomNO.TabIndex = 44;
            this.roomNO.ValidatingType = typeof(System.DateTime);
            // 
            // roomStatus
            // 
            this.roomStatus.BackColor = System.Drawing.SystemColors.Control;
            this.roomStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.roomStatus.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomStatus.FormattingEnabled = true;
            this.roomStatus.Items.AddRange(new object[] {
            "Free",
            "Busy"});
            this.roomStatus.Location = new System.Drawing.Point(180, 241);
            this.roomStatus.Name = "roomStatus";
            this.roomStatus.Size = new System.Drawing.Size(208, 31);
            this.roomStatus.TabIndex = 43;
            // 
            // roomType
            // 
            this.roomType.BackColor = System.Drawing.SystemColors.Control;
            this.roomType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.roomType.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomType.FormattingEnabled = true;
            this.roomType.Location = new System.Drawing.Point(180, 136);
            this.roomType.Name = "roomType";
            this.roomType.Size = new System.Drawing.Size(208, 31);
            this.roomType.TabIndex = 42;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(28, 247);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 25);
            this.label1.TabIndex = 33;
            this.label1.Text = "Status";
            // 
            // bunifuDatepicker1
            // 
            this.bunifuDatepicker1.BackColor = System.Drawing.SystemColors.Control;
            this.bunifuDatepicker1.BorderRadius = 0;
            this.bunifuDatepicker1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuDatepicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.bunifuDatepicker1.FormatCustom = null;
            this.bunifuDatepicker1.Location = new System.Drawing.Point(261, 445);
            this.bunifuDatepicker1.Margin = new System.Windows.Forms.Padding(90, 114, 90, 114);
            this.bunifuDatepicker1.Name = "bunifuDatepicker1";
            this.bunifuDatepicker1.Size = new System.Drawing.Size(312, 45);
            this.bunifuDatepicker1.TabIndex = 30;
            this.bunifuDatepicker1.Value = new System.DateTime(2019, 7, 26, 18, 2, 31, 335);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(28, 195);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(56, 25);
            this.label14.TabIndex = 29;
            this.label14.Text = "Price";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.Black;
            this.label20.Location = new System.Drawing.Point(28, 142);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(113, 25);
            this.label20.TabIndex = 4;
            this.label20.Text = "Room Type";
            // 
            // roomID
            // 
            this.roomID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.roomID.Enabled = false;
            this.roomID.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.roomID.HintForeColor = System.Drawing.Color.Empty;
            this.roomID.HintText = "";
            this.roomID.isPassword = false;
            this.roomID.LineFocusedColor = System.Drawing.Color.Blue;
            this.roomID.LineIdleColor = System.Drawing.Color.Gray;
            this.roomID.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.roomID.LineThickness = 3;
            this.roomID.Location = new System.Drawing.Point(180, 40);
            this.roomID.Margin = new System.Windows.Forms.Padding(4);
            this.roomID.Name = "roomID";
            this.roomID.Size = new System.Drawing.Size(87, 30);
            this.roomID.TabIndex = 3;
            this.roomID.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.Black;
            this.label21.Location = new System.Drawing.Point(28, 45);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(87, 25);
            this.label21.TabIndex = 2;
            this.label21.Text = "Room ID";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.Black;
            this.label22.Location = new System.Drawing.Point(28, 88);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(93, 25);
            this.label22.TabIndex = 0;
            this.label22.Text = "Room No";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(45, 181);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(162, 244);
            this.listBox1.TabIndex = 21;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.ListBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(40, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 25);
            this.label2.TabIndex = 23;
            this.label2.Text = "Room No";
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
            this.btnadd.IdleFillColor = System.Drawing.SystemColors.Window;
            this.btnadd.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(161)))), ((int)(((byte)(242)))));
            this.btnadd.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(161)))), ((int)(((byte)(242)))));
            this.btnadd.Location = new System.Drawing.Point(346, 453);
            this.btnadd.Margin = new System.Windows.Forms.Padding(5);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(162, 52);
            this.btnadd.TabIndex = 24;
            this.btnadd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnadd.Click += new System.EventHandler(this.Btnadd_Click);
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
            this.btnclose.IdleFillColor = System.Drawing.SystemColors.Window;
            this.btnclose.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(161)))), ((int)(((byte)(242)))));
            this.btnclose.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(161)))), ((int)(((byte)(242)))));
            this.btnclose.Location = new System.Drawing.Point(591, 453);
            this.btnclose.Margin = new System.Windows.Forms.Padding(5);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(162, 52);
            this.btnclose.TabIndex = 25;
            this.btnclose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.roomTypeSet);
            this.groupBox1.Controls.Add(this.roomDPrice);
            this.groupBox1.Controls.Add(this.roomDNo);
            this.groupBox1.Controls.Add(this.roomDID);
            this.groupBox1.Controls.Add(this.roomDStatus);
            this.groupBox1.Controls.Add(this.roomDType);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.bunifuDatepicker2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(837, 141);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(407, 329);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Room\'s Details";
            // 
            // roomTypeSet
            // 
            this.roomTypeSet.BackColor = System.Drawing.SystemColors.Control;
            this.roomTypeSet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.roomTypeSet.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomTypeSet.FormattingEnabled = true;
            this.roomTypeSet.Location = new System.Drawing.Point(284, 142);
            this.roomTypeSet.Name = "roomTypeSet";
            this.roomTypeSet.Size = new System.Drawing.Size(107, 31);
            this.roomTypeSet.TabIndex = 47;
            this.roomTypeSet.SelectedIndexChanged += new System.EventHandler(this.RoomTypeSet_SelectedIndexChanged);
            // 
            // roomDPrice
            // 
            this.roomDPrice.BackColor = System.Drawing.SystemColors.Control;
            this.roomDPrice.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomDPrice.ForeColor = System.Drawing.SystemColors.WindowText;
            this.roomDPrice.Location = new System.Drawing.Point(180, 202);
            this.roomDPrice.Mask = "00000";
            this.roomDPrice.Name = "roomDPrice";
            this.roomDPrice.Size = new System.Drawing.Size(87, 32);
            this.roomDPrice.TabIndex = 46;
            this.roomDPrice.ValidatingType = typeof(System.DateTime);
            // 
            // roomDNo
            // 
            this.roomDNo.BackColor = System.Drawing.SystemColors.Control;
            this.roomDNo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomDNo.ForeColor = System.Drawing.SystemColors.WindowText;
            this.roomDNo.Location = new System.Drawing.Point(180, 82);
            this.roomDNo.Mask = "000";
            this.roomDNo.Name = "roomDNo";
            this.roomDNo.Size = new System.Drawing.Size(87, 32);
            this.roomDNo.TabIndex = 45;
            this.roomDNo.ValidatingType = typeof(System.DateTime);
            // 
            // roomDID
            // 
            this.roomDID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.roomDID.Enabled = false;
            this.roomDID.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomDID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.roomDID.HintForeColor = System.Drawing.Color.Empty;
            this.roomDID.HintText = "";
            this.roomDID.isPassword = false;
            this.roomDID.LineFocusedColor = System.Drawing.Color.Blue;
            this.roomDID.LineIdleColor = System.Drawing.Color.Gray;
            this.roomDID.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.roomDID.LineThickness = 3;
            this.roomDID.Location = new System.Drawing.Point(180, 40);
            this.roomDID.Margin = new System.Windows.Forms.Padding(4);
            this.roomDID.Name = "roomDID";
            this.roomDID.Size = new System.Drawing.Size(87, 30);
            this.roomDID.TabIndex = 37;
            this.roomDID.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // roomDStatus
            // 
            this.roomDStatus.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.roomDStatus.Enabled = false;
            this.roomDStatus.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomDStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.roomDStatus.HintForeColor = System.Drawing.Color.Empty;
            this.roomDStatus.HintText = "";
            this.roomDStatus.isPassword = false;
            this.roomDStatus.LineFocusedColor = System.Drawing.Color.Blue;
            this.roomDStatus.LineIdleColor = System.Drawing.Color.Gray;
            this.roomDStatus.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.roomDStatus.LineThickness = 3;
            this.roomDStatus.Location = new System.Drawing.Point(180, 265);
            this.roomDStatus.Margin = new System.Windows.Forms.Padding(4);
            this.roomDStatus.Name = "roomDStatus";
            this.roomDStatus.Size = new System.Drawing.Size(87, 30);
            this.roomDStatus.TabIndex = 36;
            this.roomDStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // roomDType
            // 
            this.roomDType.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.roomDType.Enabled = false;
            this.roomDType.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomDType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.roomDType.HintForeColor = System.Drawing.Color.Empty;
            this.roomDType.HintText = "";
            this.roomDType.isPassword = false;
            this.roomDType.LineFocusedColor = System.Drawing.Color.Blue;
            this.roomDType.LineIdleColor = System.Drawing.Color.Gray;
            this.roomDType.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.roomDType.LineThickness = 3;
            this.roomDType.Location = new System.Drawing.Point(180, 142);
            this.roomDType.Margin = new System.Windows.Forms.Padding(4);
            this.roomDType.Name = "roomDType";
            this.roomDType.Size = new System.Drawing.Size(87, 30);
            this.roomDType.TabIndex = 35;
            this.roomDType.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.roomDType.OnValueChanged += new System.EventHandler(this.RoomDType_OnValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(28, 269);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 25);
            this.label3.TabIndex = 33;
            this.label3.Text = "Status";
            // 
            // bunifuDatepicker2
            // 
            this.bunifuDatepicker2.BackColor = System.Drawing.SystemColors.Control;
            this.bunifuDatepicker2.BorderRadius = 0;
            this.bunifuDatepicker2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuDatepicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.bunifuDatepicker2.FormatCustom = null;
            this.bunifuDatepicker2.Location = new System.Drawing.Point(261, 445);
            this.bunifuDatepicker2.Margin = new System.Windows.Forms.Padding(90, 114, 90, 114);
            this.bunifuDatepicker2.Name = "bunifuDatepicker2";
            this.bunifuDatepicker2.Size = new System.Drawing.Size(312, 45);
            this.bunifuDatepicker2.TabIndex = 30;
            this.bunifuDatepicker2.Value = new System.DateTime(2019, 7, 26, 18, 2, 31, 335);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(28, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 25);
            this.label4.TabIndex = 29;
            this.label4.Text = "Price";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(28, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Room Type";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(28, 45);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 25);
            this.label6.TabIndex = 2;
            this.label6.Text = "Room ID";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(28, 85);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 25);
            this.label7.TabIndex = 0;
            this.label7.Text = "Room No";
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
            this.btnupdate.IdleFillColor = System.Drawing.SystemColors.Window;
            this.btnupdate.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(161)))), ((int)(((byte)(242)))));
            this.btnupdate.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(161)))), ((int)(((byte)(242)))));
            this.btnupdate.Location = new System.Drawing.Point(942, 478);
            this.btnupdate.Margin = new System.Windows.Forms.Padding(5);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(162, 52);
            this.btnupdate.TabIndex = 27;
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
            this.btnunselect.IdleFillColor = System.Drawing.SystemColors.Window;
            this.btnunselect.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(161)))), ((int)(((byte)(242)))));
            this.btnunselect.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(161)))), ((int)(((byte)(242)))));
            this.btnunselect.Location = new System.Drawing.Point(45, 433);
            this.btnunselect.Margin = new System.Windows.Forms.Padding(5);
            this.btnunselect.Name = "btnunselect";
            this.btnunselect.Size = new System.Drawing.Size(162, 52);
            this.btnunselect.TabIndex = 28;
            this.btnunselect.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnunselect.Click += new System.EventHandler(this.Btnunselect_Click);
            // 
            // hidden
            // 
            this.hidden.AutoSize = true;
            this.hidden.ForeColor = System.Drawing.SystemColors.Control;
            this.hidden.Location = new System.Drawing.Point(414, 27);
            this.hidden.Name = "hidden";
            this.hidden.Size = new System.Drawing.Size(0, 17);
            this.hidden.TabIndex = 29;
            // 
            // RoomInformation
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.hidden);
            this.Controls.Add(this.btnunselect);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.groupBox2);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Name = "RoomInformation";
            this.Size = new System.Drawing.Size(1500, 1000);
            this.Load += new System.EventHandler(this.RoomInformation_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private Bunifu.Framework.UI.BunifuDatepicker bunifuDatepicker1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label20;
        private Bunifu.Framework.UI.BunifuMaterialTextbox roomID;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuThinButton2 btnadd;
        private Bunifu.Framework.UI.BunifuThinButton2 btnclose;
        private System.Windows.Forms.GroupBox groupBox1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox roomDStatus;
        private Bunifu.Framework.UI.BunifuMaterialTextbox roomDType;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuDatepicker bunifuDatepicker2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox roomStatus;
        private System.Windows.Forms.ComboBox roomType;
        private System.Windows.Forms.MaskedTextBox roomPrice;
        private System.Windows.Forms.MaskedTextBox roomNO;
        private System.Windows.Forms.MaskedTextBox roomDPrice;
        private System.Windows.Forms.MaskedTextBox roomDNo;
        private Bunifu.Framework.UI.BunifuMaterialTextbox roomDID;
        private Bunifu.Framework.UI.BunifuThinButton2 btnupdate;
        private Bunifu.Framework.UI.BunifuThinButton2 btnunselect;
        private System.Windows.Forms.ComboBox roomTypeSet;
        private System.Windows.Forms.Label hidden;
    }
}
