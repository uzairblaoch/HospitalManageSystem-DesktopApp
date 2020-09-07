namespace HospitalManagementSystem
{
    partial class CustomMessageBox
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomMessageBox));
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuFormFadeTransition1 = new Bunifu.Framework.UI.BunifuFormFadeTransition(this.components);
            this.icon = new System.Windows.Forms.PictureBox();
            this.icon_delay = new System.Windows.Forms.Timer(this.components);
            this.customdialoglbl = new System.Windows.Forms.Label();
            this.btnok = new Bunifu.Framework.UI.BunifuFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.icon)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this;
            this.bunifuDragControl1.Vertical = true;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuFormFadeTransition1
            // 
            this.bunifuFormFadeTransition1.Delay = 1;
            this.bunifuFormFadeTransition1.TransitionEnd += new System.EventHandler(this.BunifuFormFadeTransition1_TransitionEnd);
            // 
            // icon
            // 
            this.icon.Image = ((System.Drawing.Image)(resources.GetObject("icon.Image")));
            this.icon.Location = new System.Drawing.Point(100, -35);
            this.icon.Name = "icon";
            this.icon.Size = new System.Drawing.Size(312, 207);
            this.icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.icon.TabIndex = 0;
            this.icon.TabStop = false;
            // 
            // icon_delay
            // 
            this.icon_delay.Enabled = true;
            this.icon_delay.Interval = 4000;
            this.icon_delay.Tick += new System.EventHandler(this.Icon_delay_Tick);
            // 
            // customdialoglbl
            // 
            this.customdialoglbl.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customdialoglbl.Location = new System.Drawing.Point(0, 126);
            this.customdialoglbl.Name = "customdialoglbl";
            this.customdialoglbl.Size = new System.Drawing.Size(513, 46);
            this.customdialoglbl.TabIndex = 2;
            this.customdialoglbl.Text = "label1";
            this.customdialoglbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnok
            // 
            this.btnok.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnok.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(180)))), ((int)(((byte)(63)))));
            this.btnok.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnok.BorderRadius = 5;
            this.btnok.ButtonText = "OK";
            this.btnok.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnok.DisabledColor = System.Drawing.Color.Gray;
            this.btnok.Iconcolor = System.Drawing.Color.Transparent;
            this.btnok.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnok.Iconimage")));
            this.btnok.Iconimage_right = null;
            this.btnok.Iconimage_right_Selected = null;
            this.btnok.Iconimage_Selected = null;
            this.btnok.IconMarginLeft = 0;
            this.btnok.IconMarginRight = 0;
            this.btnok.IconRightVisible = false;
            this.btnok.IconRightZoom = 0D;
            this.btnok.IconVisible = false;
            this.btnok.IconZoom = 90D;
            this.btnok.IsTab = false;
            this.btnok.Location = new System.Drawing.Point(203, 176);
            this.btnok.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnok.Name = "btnok";
            this.btnok.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(180)))), ((int)(((byte)(63)))));
            this.btnok.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(210)))), ((int)(((byte)(93)))));
            this.btnok.OnHoverTextColor = System.Drawing.Color.White;
            this.btnok.selected = false;
            this.btnok.Size = new System.Drawing.Size(102, 41);
            this.btnok.TabIndex = 3;
            this.btnok.Text = "OK";
            this.btnok.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnok.Textcolor = System.Drawing.Color.White;
            this.btnok.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnok.Visible = false;
            this.btnok.Click += new System.EventHandler(this.Btnok_Click);
            // 
            // CustomMessageBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(515, 243);
            this.Controls.Add(this.btnok);
            this.Controls.Add(this.customdialoglbl);
            this.Controls.Add(this.icon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CustomMessageBox";
            this.Opacity = 0D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CustomMessageBox";
            this.Load += new System.EventHandler(this.CustomMessageBox_Load);
            ((System.ComponentModel.ISupportInitialize)(this.icon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuFormFadeTransition bunifuFormFadeTransition1;
        private System.Windows.Forms.PictureBox icon;
        private System.Windows.Forms.Timer icon_delay;
        private System.Windows.Forms.Label customdialoglbl;
        private Bunifu.Framework.UI.BunifuFlatButton btnok;
    }
}