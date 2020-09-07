namespace HospitalManagementSystem
{
    partial class PatientInformation
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.patientcatgDD = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(23, 90);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1156, 587);
            this.dataGridView1.TabIndex = 0;
            // 
            // patientcatgDD
            // 
            this.patientcatgDD.BackColor = System.Drawing.SystemColors.Control;
            this.patientcatgDD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.patientcatgDD.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientcatgDD.FormattingEnabled = true;
            this.patientcatgDD.Location = new System.Drawing.Point(996, 32);
            this.patientcatgDD.Name = "patientcatgDD";
            this.patientcatgDD.Size = new System.Drawing.Size(183, 31);
            this.patientcatgDD.TabIndex = 41;
            this.patientcatgDD.SelectedIndexChanged += new System.EventHandler(this.PatientcatgDD_SelectedIndexChanged);
            // 
            // PatientInformation
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.patientcatgDD);
            this.Controls.Add(this.dataGridView1);
            this.Name = "PatientInformation";
            this.Size = new System.Drawing.Size(1500, 1000);
            this.Load += new System.EventHandler(this.PatientInformation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox patientcatgDD;
    }
}
