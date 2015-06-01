﻿namespace MoneyManagerDesktop
{
    partial class frmMainMaster
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param Name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.mnuEntries = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuUsers = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuUsersSelect = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuUsersInsert = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuUsersUpdate = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuUsersDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuUsersRetore = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.mnuClose = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuConfig = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuColors = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDataBase = new System.Windows.Forms.ToolStripMenuItem();
            this.btnHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.ptbMoney = new System.Windows.Forms.PictureBox();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbMoney)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuEntries,
            this.mnuConfig,
            this.btnHelp});
            this.menuStrip.Location = new System.Drawing.Point(20, 60);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(532, 29);
            this.menuStrip.TabIndex = 2;
            this.menuStrip.Text = "menuStrip1";
            // 
            // mnuEntries
            // 
            this.mnuEntries.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuUsers,
            this.toolStripSeparator,
            this.mnuClose});
            this.mnuEntries.Name = "mnuEntries";
            this.mnuEntries.Size = new System.Drawing.Size(127, 25);
            this.mnuEntries.Text = "%mnuEntries%";
            // 
            // mnuUsers
            // 
            this.mnuUsers.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuUsersSelect,
            this.mnuUsersInsert,
            this.mnuUsersUpdate,
            this.mnuUsersDelete,
            this.mnuUsersRetore});
            this.mnuUsers.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mnuUsers.Name = "mnuUsers";
            this.mnuUsers.Size = new System.Drawing.Size(177, 26);
            this.mnuUsers.Text = "%mnuUsers%";
            // 
            // mnuUsersSelect
            // 
            this.mnuUsersSelect.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mnuUsersSelect.Name = "mnuUsersSelect";
            this.mnuUsersSelect.Size = new System.Drawing.Size(227, 26);
            this.mnuUsersSelect.Text = "%mnuUsersSelect%";
            this.mnuUsersSelect.Click += new System.EventHandler(this.mnuUsersSelect_Click);
            // 
            // mnuUsersInsert
            // 
            this.mnuUsersInsert.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mnuUsersInsert.Name = "mnuUsersInsert";
            this.mnuUsersInsert.Size = new System.Drawing.Size(227, 26);
            this.mnuUsersInsert.Text = "%mnuUsersInsert%";
            this.mnuUsersInsert.Click += new System.EventHandler(this.mnuUsersInsert_Click);
            // 
            // mnuUsersUpdate
            // 
            this.mnuUsersUpdate.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mnuUsersUpdate.Name = "mnuUsersUpdate";
            this.mnuUsersUpdate.Size = new System.Drawing.Size(227, 26);
            this.mnuUsersUpdate.Text = "%mnuUsersUpdate%";
            this.mnuUsersUpdate.Click += new System.EventHandler(this.mnuUsersUpdate_Click);
            // 
            // mnuUsersDelete
            // 
            this.mnuUsersDelete.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mnuUsersDelete.Name = "mnuUsersDelete";
            this.mnuUsersDelete.Size = new System.Drawing.Size(227, 26);
            this.mnuUsersDelete.Text = "%mnuUsersDelete%";
            this.mnuUsersDelete.Click += new System.EventHandler(this.mnuUsersDelete_Click);
            // 
            // mnuUsersRetore
            // 
            this.mnuUsersRetore.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mnuUsersRetore.Name = "mnuUsersRetore";
            this.mnuUsersRetore.Size = new System.Drawing.Size(227, 26);
            this.mnuUsersRetore.Text = "%mnuUsersRetore%";
            this.mnuUsersRetore.Click += new System.EventHandler(this.mnuUsersRetore_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(174, 6);
            // 
            // mnuClose
            // 
            this.mnuClose.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mnuClose.Name = "mnuClose";
            this.mnuClose.Size = new System.Drawing.Size(177, 26);
            this.mnuClose.Text = "%mnuClose%";
            this.mnuClose.Click += new System.EventHandler(this.mnuClose_Click);
            // 
            // mnuConfig
            // 
            this.mnuConfig.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuColors,
            this.mnuDataBase});
            this.mnuConfig.Name = "mnuConfig";
            this.mnuConfig.Size = new System.Drawing.Size(126, 25);
            this.mnuConfig.Text = "%mnuConfig%";
            // 
            // mnuColors
            // 
            this.mnuColors.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mnuColors.Name = "mnuColors";
            this.mnuColors.Size = new System.Drawing.Size(202, 26);
            this.mnuColors.Text = "%mnuColors%";
            this.mnuColors.Click += new System.EventHandler(this.mnuColors_Click);
            // 
            // mnuDataBase
            // 
            this.mnuDataBase.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mnuDataBase.Name = "mnuDataBase";
            this.mnuDataBase.Size = new System.Drawing.Size(202, 26);
            this.mnuDataBase.Text = "%mnuDataBase%";
            this.mnuDataBase.Click += new System.EventHandler(this.mnuDataBase_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAbout});
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(103, 25);
            this.btnHelp.Text = "%btnHelp%";
            // 
            // mnuAbout
            // 
            this.mnuAbout.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mnuAbout.Name = "mnuAbout";
            this.mnuAbout.Size = new System.Drawing.Size(180, 26);
            this.mnuAbout.Text = "%mnuAbout%";
            this.mnuAbout.Click += new System.EventHandler(this.mnuAbout_Click);
            // 
            // ptbMoney
            // 
            this.ptbMoney.Location = new System.Drawing.Point(200, 7);
            this.ptbMoney.Name = "ptbMoney";
            this.ptbMoney.Size = new System.Drawing.Size(49, 50);
            this.ptbMoney.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.ptbMoney.TabIndex = 3;
            this.ptbMoney.TabStop = false;
            // 
            // frmMainMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 451);
            this.Controls.Add(this.ptbMoney);
            this.Controls.Add(this.menuStrip);
            this.Name = "frmMainMaster";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.Text = "%frmMainMaster%";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMainBase_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmMainMaster_KeyDown);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbMoney)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem mnuEntries;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem mnuClose;
        private System.Windows.Forms.ToolStripMenuItem mnuConfig;
        private System.Windows.Forms.ToolStripMenuItem btnHelp;
        private System.Windows.Forms.ToolStripMenuItem mnuAbout;
        private System.Windows.Forms.PictureBox ptbMoney;
        private System.Windows.Forms.ToolStripMenuItem mnuColors;
        private System.Windows.Forms.ToolStripMenuItem mnuDataBase;
        private System.Windows.Forms.ToolStripMenuItem mnuUsers;
        private System.Windows.Forms.ToolStripMenuItem mnuUsersInsert;
        private System.Windows.Forms.ToolStripMenuItem mnuUsersUpdate;
        private System.Windows.Forms.ToolStripMenuItem mnuUsersDelete;
        private System.Windows.Forms.ToolStripMenuItem mnuUsersSelect;
        private System.Windows.Forms.ToolStripMenuItem mnuUsersRetore;

    }
}