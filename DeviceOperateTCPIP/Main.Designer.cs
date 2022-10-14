namespace GUIDemo
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.orgTitle = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.settingdbtn = new System.Windows.Forms.Button();
            this.dashboardbtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // orgTitle
            // 
            this.orgTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.orgTitle.AutoSize = true;
            this.orgTitle.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.orgTitle.ForeColor = System.Drawing.Color.Black;
            this.orgTitle.Location = new System.Drawing.Point(747, 27);
            this.orgTitle.Name = "orgTitle";
            this.orgTitle.Size = new System.Drawing.Size(204, 24);
            this.orgTitle.TabIndex = 17;
            this.orgTitle.Text = "Organization Name";
            this.orgTitle.SizeChanged += new System.EventHandler(this.orgTitle_SizeChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SkyBlue;
            this.panel1.Controls.Add(this.settingdbtn);
            this.panel1.Controls.Add(this.dashboardbtn);
            this.panel1.Location = new System.Drawing.Point(1, 77);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(159, 839);
            this.panel1.TabIndex = 19;
            // 
            // settingdbtn
            // 
            this.settingdbtn.BackColor = System.Drawing.Color.SkyBlue;
            this.settingdbtn.FlatAppearance.BorderSize = 0;
            this.settingdbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settingdbtn.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.settingdbtn.Location = new System.Drawing.Point(3, 110);
            this.settingdbtn.Name = "settingdbtn";
            this.settingdbtn.Size = new System.Drawing.Size(148, 29);
            this.settingdbtn.TabIndex = 1;
            this.settingdbtn.Text = "Settings";
            this.settingdbtn.UseVisualStyleBackColor = false;
            this.settingdbtn.Click += new System.EventHandler(this.settingdbtn_Click);
            // 
            // dashboardbtn
            // 
            this.dashboardbtn.BackColor = System.Drawing.Color.SkyBlue;
            this.dashboardbtn.FlatAppearance.BorderSize = 0;
            this.dashboardbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dashboardbtn.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dashboardbtn.Location = new System.Drawing.Point(3, 75);
            this.dashboardbtn.Name = "dashboardbtn";
            this.dashboardbtn.Size = new System.Drawing.Size(148, 29);
            this.dashboardbtn.TabIndex = 0;
            this.dashboardbtn.Text = "Dashboard";
            this.dashboardbtn.UseVisualStyleBackColor = false;
            this.dashboardbtn.Click += new System.EventHandler(this.dashboardbtn_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Location = new System.Drawing.Point(154, 77);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1614, 841);
            this.panel2.TabIndex = 20;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel3.Controls.Add(this.orgTitle);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1767, 80);
            this.panel3.TabIndex = 21;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1767, 916);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Text = "Dashboard-UpWork";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Load += new System.EventHandler(this.Main_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Label orgTitle;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Button settingdbtn;
        private Button dashboardbtn;
    }
}