﻿namespace DVLD
{
    partial class frmManage_LDL_Applications
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
            this.SuspendLayout();
            // 
            // cbxFilter
            // 
            this.cbxFilter.SelectedIndexChanged += new System.EventHandler(this.cbxFilter_SelectedIndexChanged);
            // 
            // txtFilterExpressions
            // 
            this.txtFilterExpressions.TextChanged += new System.EventHandler(this.txtFilterExpressions_TextChanged);
            this.txtFilterExpressions.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFilterExpressions_KeyPress);
            // 
            // button1
            // 
            this.button1.Click += new System.EventHandler(this.btnClose_click);
            // 
            // btnAdd
            // 
            this.btnAdd.Text = "Add LDL app";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblHeading
            // 
            this.lblHeading.Location = new System.Drawing.Point(347, 9);
            // 
            // frmManage_LDL_Applications
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 653);
            this.Name = "frmManage_LDL_Applications";
            this.Text = "frmManage_LDL_Applications";
            this.Load += new System.EventHandler(this.frmManage_LDL_Applications_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}