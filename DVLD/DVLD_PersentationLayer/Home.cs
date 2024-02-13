﻿using System;
using DVLD_BusinessLayer;
using System.Windows.Forms;


namespace DVLD
{
    public partial class Home : Form
    {
        public delegate void ShowFormHandler();
        public ShowFormHandler ShowForm;
        public ShowFormHandler CloseForm;



        public Home()
        {
            InitializeComponent();
        }

     
        private void tsmNewLocalLicense_Click(object sender, EventArgs e)
        {
            frmNew_LDL_Application frm = new frmNew_LDL_Application(-1);
            frm.ShowDialog();
        }
        private void tsmInternationalLicense_Click(object sender, EventArgs e)
        {

        }

        private void tsmManagePeople_Click(object sender, EventArgs e)
        {

            frmManagePeopleUsers frm = new frmManagePeopleUsers(((ToolStripMenuItem)sender).Text);
            frm.ShowDialog();

        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void tsmShowUserInfo_Click(object sender, EventArgs e)
        {
            frmShowUserInfo frm = new frmShowUserInfo(GlobalSettings.CurrentUser.UserID);
            frm.ShowDialog();
        }

        private void tsmLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            ShowForm?.Invoke();
        }

        private void Home_FormClosed(object sender, FormClosedEventArgs e)
        {
            CloseForm?.Invoke();
            
        }

        private void tsmChangePassword_Click(object sender, EventArgs e)
        {
            frmChangeUserPassword frm = new frmChangeUserPassword(GlobalSettings.CurrentUser.UserID);
            frm.ShowDialog();
        }

        private void tsmManageApplicationTypes_Click(object sender, EventArgs e)
        {
            frmManageApplicationsAndTests frm = new frmManageApplicationsAndTests("ManageApplicationsTypes");
            frm.ShowDialog();
        }

        private void tsmManageTestsTypes_Click(object sender, EventArgs e)
        {
            frmManageApplicationsAndTests frm = new frmManageApplicationsAndTests("ManageTestsTypes");
            frm.ShowDialog();
        }

        private void toolStripDetainLicense_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.ShowDialog();
        }

        private void driversToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManageApplicationTypes f = new frmManageApplicationTypes();
            f.ShowDialog(); 
        }
    }
}