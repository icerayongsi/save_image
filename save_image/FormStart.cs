using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Save_image
{
    public partial class FormStart : Form
    {
        private Button currentButton;
        private Form activeForm;
        public FormStart()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void timerMain_Tick(object sender, EventArgs e)
        {
            string date = DateTime.Now.ToString("dd/MM/yy", new System.Globalization.CultureInfo("en-US"));
            string time = DateTime.Now.ToString("HH:mm:ss", new System.Globalization.CultureInfo("en-US"));
            txtdate.Text = $"Date: " + date;
            txttime.Text = $"Time: " + time;
        }
        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                // Disable previous current button
                if (currentButton != null)
                {
                    //currentButton.Enabled = true; // Re-enable the previous button
                    currentButton.BackColor = Color.FromArgb(0, 26, 114); // Reset the previous button's background color
                    currentButton.ForeColor = Color.White; // Reset the previous button's foreground color
                }
                currentButton = (Button)btnSender;
                //currentButton.Enabled = false; // Disable the current button
                currentButton.BackColor = Color.FromArgb(0, 26, 114); ; // Set the current button's background color to indicate it's disabled
                currentButton.ForeColor = Color.White; // Set the current button's foreground color for better readability
            }
        }


        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
                activeForm.Close();
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktopPane.Controls.Add(childForm);
            this.panelDesktopPane.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnFormMonitor_Click(object sender, EventArgs e)
        {
            if (activeForm == null || activeForm.Text != "FormMonitor")
            {
                OpenChildForm(new FormMonitor(), sender);
            }
        }

        private void btnFormHistory_Click(object sender, EventArgs e)
        {

        }

        private void btnFormUser_Click(object sender, EventArgs e)
        {

        }

        private void btnFormSetting_Click(object sender, EventArgs e)
        {

        }
    }
}
