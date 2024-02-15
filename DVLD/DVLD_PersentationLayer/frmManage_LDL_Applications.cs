﻿using System;
using System.Data;
using DVLD_BusinessLayer;
using System.Windows.Forms;

namespace DVLD
{
    public partial class frmManage_LDL_Applications : frmManageScreen
    {
        private DataTable _dt;
        public frmManage_LDL_Applications() : base()
        {
  
            InitializeComponent();
        }

        private void frmManage_LDL_Applications_Load(object sender, EventArgs e)
        {

            txtFilterExpressions.Visible = false;
            cbxFilter.DataSource = new string[] { "None", "LDL app ID", "National No." };
            cbxFilter.SelectedIndex = 0;

            lblHeading.Text = "Manage Local Driving License Applications";
            _dt = cls_LDL_Application.GetAll_LDL_Applications();

            _RefreshDataGridView();

        }

        private void _RefreshDataGridView()
        {
            _dt = cls_LDL_Application.GetAll_LDL_Applications();
            DataGridView.DataSource = _dt;
            lblTotalMembers.Text = DataGridView.Rows.Count.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddUpdate_LDL_Application frm = new frmAddUpdate_LDL_Application(-1);
            frm.ShowDialog();

            _RefreshDataGridView();
        }

        private void btnClose_click(object sender, EventArgs e)
        {
            Close();
        }

        private void cbxFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            _ = (cbxFilter.SelectedItem.ToString() == "None") ? txtFilterExpressions.Visible = false : txtFilterExpressions.Visible = true;
            txtFilterExpressions.Text = "";


        }

        private void txtFilterExpressions_TextChanged(object sender, EventArgs e)
        {
            if (txtFilterExpressions.Text == "")
            {
                _RefreshDataGridView();
                return;
            }
            DataView dataView = _dt.DefaultView;
            if (cbxFilter.SelectedItem.ToString() == "LDL app ID")
            {
                dataView.RowFilter = $"[LDL app ID] = '{txtFilterExpressions.Text}'";
                return;
            }
            dataView.RowFilter = $"[National No.] LIKE '%{txtFilterExpressions.Text}%'";
        }

        private void txtFilterExpressions_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (cbxFilter.SelectedItem.ToString() == "LDL app ID")
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }
            }

        }        
    }
}
