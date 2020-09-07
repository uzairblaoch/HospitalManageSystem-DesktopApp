namespace HospitalManagementSystem
{
    partial class MedicineInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MedicineInfo));
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.drugID = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label2 = new System.Windows.Forms.Label();
            this.dosage = new System.Windows.Forms.MaskedTextBox();
            this.drugname = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.drugtype = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.btnadd = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnclose = new Bunifu.Framework.UI.BunifuThinButton2();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnupdate = new Bunifu.Framework.UI.BunifuThinButton2();
            this.hidden = new System.Windows.Forms.Label();
            this.btnunselect = new Bunifu.Framework.UI.BunifuThinButton2();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.drugID);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.dosage);
            this.groupBox3.Controls.Add(this.drugname);
            this.groupBox3.Controls.Add(this.drugtype);
            this.groupBox3.Controls.Add(this.label19);
            this.groupBox3.Controls.Add(this.label23);
            this.groupBox3.Controls.Add(this.label24);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(470, 185);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(462, 276);
            this.groupBox3.TabIndex = 23;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Add Medicines";
            // 
            // drugID
            // 
            this.drugID.Cursor = System.Windows.Forms.Cursors.No;
            this.drugID.Enabled = false;
            this.drugID.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drugID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.drugID.HintForeColor = System.Drawing.Color.Empty;
            this.drugID.HintText = "";
            this.drugID.isPassword = false;
            this.drugID.LineFocusedColor = System.Drawing.Color.Blue;
            this.drugID.LineIdleColor = System.Drawing.Color.Gray;
            this.drugID.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.drugID.LineThickness = 3;
            this.drugID.Location = new System.Drawing.Point(195, 57);
            this.drugID.Margin = new System.Windows.Forms.Padding(4);
            this.drugID.Name = "drugID";
            this.drugID.Size = new System.Drawing.Size(105, 30);
            this.drugID.TabIndex = 45;
            this.drugID.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 25);
            this.label2.TabIndex = 44;
            this.label2.Text = "Drug ID";
            // 
            // dosage
            // 
            this.dosage.BackColor = System.Drawing.SystemColors.Control;
            this.dosage.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dosage.Location = new System.Drawing.Point(195, 157);
            this.dosage.Mask = "000-mg";
            this.dosage.Name = "dosage";
            this.dosage.Size = new System.Drawing.Size(208, 32);
            this.dosage.TabIndex = 29;
            // 
            // drugname
            // 
            this.drugname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.drugname.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drugname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.drugname.HintForeColor = System.Drawing.Color.Empty;
            this.drugname.HintText = "";
            this.drugname.isPassword = false;
            this.drugname.LineFocusedColor = System.Drawing.Color.Blue;
            this.drugname.LineIdleColor = System.Drawing.Color.Gray;
            this.drugname.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.drugname.LineThickness = 3;
            this.drugname.Location = new System.Drawing.Point(195, 105);
            this.drugname.Margin = new System.Windows.Forms.Padding(4);
            this.drugname.Name = "drugname";
            this.drugname.Size = new System.Drawing.Size(208, 30);
            this.drugname.TabIndex = 36;
            this.drugname.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // drugtype
            // 
            this.drugtype.BackColor = System.Drawing.SystemColors.Control;
            this.drugtype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.drugtype.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drugtype.FormattingEnabled = true;
            this.drugtype.Items.AddRange(new object[] {
            "Tabet",
            "Insulin",
            "Syrup"});
            this.drugtype.Location = new System.Drawing.Point(195, 219);
            this.drugtype.Name = "drugtype";
            this.drugtype.Size = new System.Drawing.Size(208, 31);
            this.drugtype.TabIndex = 43;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(30, 109);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(106, 25);
            this.label19.TabIndex = 4;
            this.label19.Text = "DrugName";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(30, 225);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(99, 25);
            this.label23.TabIndex = 2;
            this.label23.Text = "DrugType";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(30, 164);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(80, 25);
            this.label24.TabIndex = 0;
            this.label24.Text = "Dosage";
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
            this.btnadd.Location = new System.Drawing.Point(465, 488);
            this.btnadd.Margin = new System.Windows.Forms.Padding(5);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(125, 48);
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
            this.btnclose.IdleFillColor = System.Drawing.Color.White;
            this.btnclose.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(161)))), ((int)(((byte)(242)))));
            this.btnclose.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(161)))), ((int)(((byte)(242)))));
            this.btnclose.Location = new System.Drawing.Point(808, 488);
            this.btnclose.Margin = new System.Windows.Forms.Padding(5);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(125, 48);
            this.btnclose.TabIndex = 25;
            this.btnclose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 23;
            this.listBox1.Location = new System.Drawing.Point(71, 185);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(191, 280);
            this.listBox1.TabIndex = 26;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.ListBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(66, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 25);
            this.label1.TabIndex = 28;
            this.label1.Text = "Medicines Names";
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
            this.btnupdate.Location = new System.Drawing.Point(645, 488);
            this.btnupdate.Margin = new System.Windows.Forms.Padding(5);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(125, 48);
            this.btnupdate.TabIndex = 29;
            this.btnupdate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnupdate.Click += new System.EventHandler(this.Btnupdate_Click);
            // 
            // hidden
            // 
            this.hidden.AutoSize = true;
            this.hidden.ForeColor = System.Drawing.SystemColors.Control;
            this.hidden.Location = new System.Drawing.Point(1059, 242);
            this.hidden.Name = "hidden";
            this.hidden.Size = new System.Drawing.Size(0, 17);
            this.hidden.TabIndex = 30;
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
            this.btnunselect.Location = new System.Drawing.Point(71, 473);
            this.btnunselect.Margin = new System.Windows.Forms.Padding(5);
            this.btnunselect.Name = "btnunselect";
            this.btnunselect.Size = new System.Drawing.Size(191, 48);
            this.btnunselect.TabIndex = 31;
            this.btnunselect.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnunselect.Click += new System.EventHandler(this.Btnunselect_Click);
            // 
            // MedicineInfo
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.btnunselect);
            this.Controls.Add(this.hidden);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.groupBox3);
            this.Name = "MedicineInfo";
            this.Size = new System.Drawing.Size(1500, 1000);
            this.Load += new System.EventHandler(this.MedicineInfo_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private Bunifu.Framework.UI.BunifuMaterialTextbox drugname;
        private Bunifu.Framework.UI.BunifuThinButton2 btnadd;
        private Bunifu.Framework.UI.BunifuThinButton2 btnclose;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox drugtype;
        private System.Windows.Forms.MaskedTextBox dosage;
        private Bunifu.Framework.UI.BunifuThinButton2 btnupdate;
        private Bunifu.Framework.UI.BunifuMaterialTextbox drugID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label hidden;
        private Bunifu.Framework.UI.BunifuThinButton2 btnunselect;
    }
}
