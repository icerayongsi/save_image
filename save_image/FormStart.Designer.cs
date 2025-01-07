namespace Save_image
{
    partial class FormStart
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormStart));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnFormSetting = new System.Windows.Forms.Button();
            this.btnFormData = new System.Windows.Forms.Button();
            this.btnFormHistory = new System.Windows.Forms.Button();
            this.btnFormMonitor = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.txttime = new System.Windows.Forms.Label();
            this.txtdate = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.timerMain = new System.Windows.Forms.Timer(this.components);
            this.panel12 = new System.Windows.Forms.Panel();
            this.panelDesktopPane = new System.Windows.Forms.Panel();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.panel1.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panelDesktopPane.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(26)))), ((int)(((byte)(114)))));
            this.panel1.Controls.Add(this.panel10);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(1);
            this.panel1.Size = new System.Drawing.Size(122, 1021);
            this.panel1.TabIndex = 0;
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.panelMenu);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel10.Location = new System.Drawing.Point(1, 66);
            this.panel10.Name = "panel10";
            this.panel10.Padding = new System.Windows.Forms.Padding(5);
            this.panel10.Size = new System.Drawing.Size(120, 954);
            this.panel10.TabIndex = 2;
            // 
            // panelMenu
            // 
            this.panelMenu.Controls.Add(this.btnExit);
            this.panelMenu.Controls.Add(this.btnFormSetting);
            this.panelMenu.Controls.Add(this.btnFormData);
            this.panelMenu.Controls.Add(this.btnFormHistory);
            this.panelMenu.Controls.Add(this.btnFormMonitor);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMenu.Location = new System.Drawing.Point(5, 5);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Padding = new System.Windows.Forms.Padding(1);
            this.panelMenu.Size = new System.Drawing.Size(110, 944);
            this.panelMenu.TabIndex = 0;
            // 
            // btnExit
            // 
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(26)))), ((int)(((byte)(114)))));
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumBlue;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.Location = new System.Drawing.Point(1, 893);
            this.btnExit.Name = "btnExit";
            this.btnExit.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnExit.Size = new System.Drawing.Size(108, 50);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            this.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // btnFormSetting
            // 
            this.btnFormSetting.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnFormSetting.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFormSetting.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(26)))), ((int)(((byte)(114)))));
            this.btnFormSetting.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumBlue;
            this.btnFormSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFormSetting.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFormSetting.ForeColor = System.Drawing.Color.White;
            this.btnFormSetting.Image = global::Save_image.Properties.Resources.Setting;
            this.btnFormSetting.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFormSetting.Location = new System.Drawing.Point(1, 136);
            this.btnFormSetting.Name = "btnFormSetting";
            this.btnFormSetting.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnFormSetting.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnFormSetting.Size = new System.Drawing.Size(108, 45);
            this.btnFormSetting.TabIndex = 5;
            this.btnFormSetting.Text = "Setting";
            this.btnFormSetting.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFormSetting.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFormSetting.UseVisualStyleBackColor = true;
            this.btnFormSetting.Click += new System.EventHandler(this.btnFormSetting_Click);
            // 
            // btnFormData
            // 
            this.btnFormData.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnFormData.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFormData.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(26)))), ((int)(((byte)(114)))));
            this.btnFormData.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumBlue;
            this.btnFormData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFormData.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFormData.ForeColor = System.Drawing.Color.White;
            this.btnFormData.Image = global::Save_image.Properties.Resources.Database;
            this.btnFormData.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFormData.Location = new System.Drawing.Point(1, 91);
            this.btnFormData.Name = "btnFormData";
            this.btnFormData.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.btnFormData.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnFormData.Size = new System.Drawing.Size(108, 45);
            this.btnFormData.TabIndex = 4;
            this.btnFormData.Text = "Storage";
            this.btnFormData.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFormData.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFormData.UseVisualStyleBackColor = true;
            this.btnFormData.Click += new System.EventHandler(this.btnFormUser_Click);
            // 
            // btnFormHistory
            // 
            this.btnFormHistory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnFormHistory.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFormHistory.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(26)))), ((int)(((byte)(114)))));
            this.btnFormHistory.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumBlue;
            this.btnFormHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFormHistory.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFormHistory.ForeColor = System.Drawing.Color.White;
            this.btnFormHistory.Image = global::Save_image.Properties.Resources.History1;
            this.btnFormHistory.Location = new System.Drawing.Point(1, 46);
            this.btnFormHistory.Name = "btnFormHistory";
            this.btnFormHistory.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnFormHistory.Size = new System.Drawing.Size(108, 45);
            this.btnFormHistory.TabIndex = 3;
            this.btnFormHistory.Text = "History\r\n";
            this.btnFormHistory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFormHistory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFormHistory.UseVisualStyleBackColor = true;
            this.btnFormHistory.Click += new System.EventHandler(this.btnFormHistory_Click);
            // 
            // btnFormMonitor
            // 
            this.btnFormMonitor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnFormMonitor.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFormMonitor.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(26)))), ((int)(((byte)(114)))));
            this.btnFormMonitor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumBlue;
            this.btnFormMonitor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFormMonitor.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFormMonitor.ForeColor = System.Drawing.Color.White;
            this.btnFormMonitor.Image = global::Save_image.Properties.Resources.Cam;
            this.btnFormMonitor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFormMonitor.Location = new System.Drawing.Point(1, 1);
            this.btnFormMonitor.Name = "btnFormMonitor";
            this.btnFormMonitor.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.btnFormMonitor.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnFormMonitor.Size = new System.Drawing.Size(108, 45);
            this.btnFormMonitor.TabIndex = 1;
            this.btnFormMonitor.Text = "Monitor";
            this.btnFormMonitor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFormMonitor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFormMonitor.UseVisualStyleBackColor = true;
            this.btnFormMonitor.Click += new System.EventHandler(this.btnFormMonitor_Click);
            // 
            // panel4
            // 
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(1, 1);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(15);
            this.panel4.Size = new System.Drawing.Size(120, 65);
            this.panel4.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.BackgroundImage = global::Save_image.Properties.Resources.LogoAisin;
            this.panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(15, 15);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(90, 35);
            this.panel5.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gray;
            this.panel2.Controls.Add(this.panel7);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(122, 0);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(5);
            this.panel2.Size = new System.Drawing.Size(1762, 59);
            this.panel2.TabIndex = 4;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.panel9);
            this.panel7.Controls.Add(this.panel8);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(5, 5);
            this.panel7.Name = "panel7";
            this.panel7.Padding = new System.Windows.Forms.Padding(2);
            this.panel7.Size = new System.Drawing.Size(1752, 49);
            this.panel7.TabIndex = 0;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.txttime);
            this.panel9.Controls.Add(this.txtdate);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel9.Location = new System.Drawing.Point(1450, 2);
            this.panel9.Name = "panel9";
            this.panel9.Padding = new System.Windows.Forms.Padding(1);
            this.panel9.Size = new System.Drawing.Size(300, 45);
            this.panel9.TabIndex = 1;
            // 
            // txttime
            // 
            this.txttime.Dock = System.Windows.Forms.DockStyle.Right;
            this.txttime.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttime.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.txttime.Location = new System.Drawing.Point(29, 1);
            this.txttime.Name = "txttime";
            this.txttime.Size = new System.Drawing.Size(135, 43);
            this.txttime.TabIndex = 1;
            this.txttime.Text = "........................";
            this.txttime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtdate
            // 
            this.txtdate.Dock = System.Windows.Forms.DockStyle.Right;
            this.txtdate.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdate.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtdate.Location = new System.Drawing.Point(164, 1);
            this.txtdate.Name = "txtdate";
            this.txtdate.Size = new System.Drawing.Size(135, 43);
            this.txtdate.TabIndex = 0;
            this.txtdate.Text = "........................";
            this.txtdate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.label1);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel8.Location = new System.Drawing.Point(2, 2);
            this.panel8.Name = "panel8";
            this.panel8.Padding = new System.Windows.Forms.Padding(1);
            this.panel8.Size = new System.Drawing.Size(677, 45);
            this.panel8.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Roboto", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(1, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(675, 43);
            this.label1.TabIndex = 0;
            this.label1.Text = "Project Name";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // timerMain
            // 
            this.timerMain.Enabled = true;
            this.timerMain.Interval = 1000;
            this.timerMain.Tick += new System.EventHandler(this.timerMain_Tick);
            // 
            // panel12
            // 
            this.panel12.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel12.BackgroundImage")));
            this.panel12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel12.Location = new System.Drawing.Point(554, 227);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(604, 165);
            this.panel12.TabIndex = 12;
            // 
            // panelDesktopPane
            // 
            this.panelDesktopPane.BackColor = System.Drawing.Color.Transparent;
            this.panelDesktopPane.Controls.Add(this.progressBar1);
            this.panelDesktopPane.Controls.Add(this.panel12);
            this.panelDesktopPane.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktopPane.Location = new System.Drawing.Point(122, 59);
            this.panelDesktopPane.Name = "panelDesktopPane";
            this.panelDesktopPane.Padding = new System.Windows.Forms.Padding(5);
            this.panelDesktopPane.Size = new System.Drawing.Size(1762, 962);
            this.panelDesktopPane.TabIndex = 3;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(686, 398);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(343, 23);
            this.progressBar1.Step = 1;
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progressBar1.TabIndex = 13;
            this.progressBar1.Value = 20;
            // 
            // FormStart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Save_image.Properties.Resources.BG1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1884, 1021);
            this.Controls.Add(this.panelDesktopPane);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormStart";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panelMenu.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panelDesktopPane.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnFormSetting;
        private System.Windows.Forms.Button btnFormData;
        private System.Windows.Forms.Button btnFormHistory;
        private System.Windows.Forms.Button btnFormMonitor;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label txttime;
        private System.Windows.Forms.Label txtdate;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timerMain;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Panel panelDesktopPane;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}

