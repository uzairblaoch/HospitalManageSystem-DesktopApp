namespace HospitalManagementSystem
{
    partial class Appointment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Appointment));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.apptime = new System.Windows.Forms.DateTimePicker();
            this.appdate = new System.Windows.Forms.DateTimePicker();
            this.docnamedd = new System.Windows.Forms.ComboBox();
            this.cnictxt = new System.Windows.Forms.MaskedTextBox();
            this.lname = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.fname = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label2 = new System.Windows.Forms.Label();
            this.appID = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnclose = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnadd = new Bunifu.Framework.UI.BunifuThinButton2();
            this.hidden = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.apptime);
            this.groupBox1.Controls.Add(this.appdate);
            this.groupBox1.Controls.Add(this.docnamedd);
            this.groupBox1.Controls.Add(this.cnictxt);
            this.groupBox1.Controls.Add(this.lname);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.fname);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.appID);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(98, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(495, 436);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Appointment";
            // 
            // apptime
            // 
            this.apptime.CalendarTitleBackColor = System.Drawing.SystemColors.Control;
            this.apptime.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apptime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.apptime.Location = new System.Drawing.Point(232, 305);
            this.apptime.Name = "apptime";
            this.apptime.Size = new System.Drawing.Size(212, 32);
            this.apptime.TabIndex = 24;
            // 
            // appdate
            // 
            this.appdate.CalendarTitleBackColor = System.Drawing.SystemColors.Control;
            this.appdate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.appdate.Location = new System.Drawing.Point(232, 349);
            this.appdate.Name = "appdate";
            this.appdate.Size = new System.Drawing.Size(212, 32);
            this.appdate.TabIndex = 25;
            // 
            // docnamedd
            // 
            this.docnamedd.BackColor = System.Drawing.SystemColors.Control;
            this.docnamedd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.docnamedd.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.docnamedd.FormattingEnabled = true;
            this.docnamedd.Location = new System.Drawing.Point(232, 267);
            this.docnamedd.Name = "docnamedd";
            this.docnamedd.Size = new System.Drawing.Size(208, 31);
            this.docnamedd.TabIndex = 41;
            // 
            // cnictxt
            // 
            this.cnictxt.BackColor = System.Drawing.SystemColors.Control;
            this.cnictxt.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cnictxt.Location = new System.Drawing.Point(232, 224);
            this.cnictxt.Mask = "00000-0000000-0";
            this.cnictxt.Name = "cnictxt";
            this.cnictxt.Size = new System.Drawing.Size(208, 30);
            this.cnictxt.TabIndex = 18;
            this.cnictxt.ValidatingType = typeof(System.DateTime);
            // 
            // lname
            // 
            this.lname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lname.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lname.HintForeColor = System.Drawing.Color.Empty;
            this.lname.HintText = "";
            this.lname.isPassword = false;
            this.lname.LineFocusedColor = System.Drawing.Color.Blue;
            this.lname.LineIdleColor = System.Drawing.Color.Gray;
            this.lname.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.lname.LineThickness = 3;
            this.lname.Location = new System.Drawing.Point(232, 169);
            this.lname.Margin = new System.Windows.Forms.Padding(4);
            this.lname.Name = "lname";
            this.lname.Size = new System.Drawing.Size(208, 30);
            this.lname.TabIndex = 1;
            this.lname.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(22, 173);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 25);
            this.label7.TabIndex = 16;
            this.label7.Text = "Last Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(22, 273);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 25);
            this.label6.TabIndex = 13;
            this.label6.Text = "Doctor Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(22, 356);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(168, 25);
            this.label5.TabIndex = 6;
            this.label5.Text = "Appointment Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 312);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(171, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "Appointment Time";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "CNIC";
            // 
            // fname
            // 
            this.fname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.fname.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.fname.HintForeColor = System.Drawing.Color.Empty;
            this.fname.HintText = "";
            this.fname.isPassword = false;
            this.fname.LineFocusedColor = System.Drawing.Color.Blue;
            this.fname.LineIdleColor = System.Drawing.Color.Gray;
            this.fname.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.fname.LineThickness = 3;
            this.fname.Location = new System.Drawing.Point(232, 117);
            this.fname.Margin = new System.Windows.Forms.Padding(4);
            this.fname.Name = "fname";
            this.fname.Size = new System.Drawing.Size(208, 30);
            this.fname.TabIndex = 0;
            this.fname.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "First Name";
            // 
            // appID
            // 
            this.appID.Cursor = System.Windows.Forms.Cursors.No;
            this.appID.Enabled = false;
            this.appID.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.appID.HintForeColor = System.Drawing.Color.Empty;
            this.appID.HintText = "";
            this.appID.isPassword = false;
            this.appID.LineFocusedColor = System.Drawing.Color.Blue;
            this.appID.LineIdleColor = System.Drawing.Color.Gray;
            this.appID.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.appID.LineThickness = 3;
            this.appID.Location = new System.Drawing.Point(232, 65);
            this.appID.Margin = new System.Windows.Forms.Padding(4);
            this.appID.Name = "appID";
            this.appID.Size = new System.Drawing.Size(105, 30);
            this.appID.TabIndex = 1;
            this.appID.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Appointment No";
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
            this.btnclose.Location = new System.Drawing.Point(483, 479);
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
            this.btnadd.Location = new System.Drawing.Point(98, 479);
            this.btnadd.Margin = new System.Windows.Forms.Padding(5);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(125, 48);
            this.btnadd.TabIndex = 15;
            this.btnadd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnadd.Click += new System.EventHandler(this.Btnadd_Click);
            // 
            // hidden
            // 
            this.hidden.AutoSize = true;
            this.hidden.ForeColor = System.Drawing.SystemColors.Control;
            this.hidden.Location = new System.Drawing.Point(690, 48);
            this.hidden.Name = "hidden";
            this.hidden.Size = new System.Drawing.Size(0, 17);
            this.hidden.TabIndex = 17;
            // 
            // Appointment
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.hidden);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnadd);
            this.Name = "Appointment";
            this.Size = new System.Drawing.Size(1500, 1000);
            this.Load += new System.EventHandler(this.Appointment_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuMaterialTextbox fname;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox appID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private Bunifu.Framework.UI.BunifuThinButton2 btnclose;
        private Bunifu.Framework.UI.BunifuThinButton2 btnadd;
        private System.Windows.Forms.Label hidden;
        private Bunifu.Framework.UI.BunifuMaterialTextbox lname;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox cnictxt;
        private System.Windows.Forms.ComboBox docnamedd;
        private System.Windows.Forms.DateTimePicker apptime;
        private System.Windows.Forms.DateTimePicker appdate;
    }
}
