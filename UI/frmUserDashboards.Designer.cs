
namespace WindowsABCD
{
    partial class frmUserDashboards
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
            this.menuStripTop = new System.Windows.Forms.MenuStrip();
            this.purchaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salesFormsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inventoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblBilling = new System.Windows.Forms.Label();
            this.lblStoreABC = new System.Windows.Forms.Label();
            this.lblAppFName = new System.Windows.Forms.Label();
            this.lblLoggedInUser = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.pnlFooter = new System.Windows.Forms.Panel();
            this.lblFooter = new System.Windows.Forms.Label();
            this.menuStripTop.SuspendLayout();
            this.pnlFooter.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripTop
            // 
            this.menuStripTop.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.purchaseToolStripMenuItem,
            this.salesFormsToolStripMenuItem,
            this.inventoryToolStripMenuItem});
            this.menuStripTop.Location = new System.Drawing.Point(0, 0);
            this.menuStripTop.Name = "menuStripTop";
            this.menuStripTop.Size = new System.Drawing.Size(800, 24);
            this.menuStripTop.TabIndex = 0;
            this.menuStripTop.Text = "menuStrip1";
            // 
            // purchaseToolStripMenuItem
            // 
            this.purchaseToolStripMenuItem.Name = "purchaseToolStripMenuItem";
            this.purchaseToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.purchaseToolStripMenuItem.Text = "Purchase";
            // 
            // salesFormsToolStripMenuItem
            // 
            this.salesFormsToolStripMenuItem.Name = "salesFormsToolStripMenuItem";
            this.salesFormsToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.salesFormsToolStripMenuItem.Text = "Sales Forms";
            // 
            // inventoryToolStripMenuItem
            // 
            this.inventoryToolStripMenuItem.Name = "inventoryToolStripMenuItem";
            this.inventoryToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.inventoryToolStripMenuItem.Text = "Inventory";
            // 
            // lblBilling
            // 
            this.lblBilling.AutoSize = true;
            this.lblBilling.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBilling.ForeColor = System.Drawing.Color.Chartreuse;
            this.lblBilling.Location = new System.Drawing.Point(132, 209);
            this.lblBilling.Name = "lblBilling";
            this.lblBilling.Size = new System.Drawing.Size(323, 25);
            this.lblBilling.TabIndex = 11;
            this.lblBilling.Text = "Billing and Inventory Management";
            // 
            // lblStoreABC
            // 
            this.lblStoreABC.AutoSize = true;
            this.lblStoreABC.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStoreABC.Location = new System.Drawing.Point(311, 170);
            this.lblStoreABC.Name = "lblStoreABC";
            this.lblStoreABC.Size = new System.Drawing.Size(111, 30);
            this.lblStoreABC.TabIndex = 10;
            this.lblStoreABC.Text = "Store ABC";
            // 
            // lblAppFName
            // 
            this.lblAppFName.AutoSize = true;
            this.lblAppFName.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppFName.Location = new System.Drawing.Point(178, 170);
            this.lblAppFName.Name = "lblAppFName";
            this.lblAppFName.Size = new System.Drawing.Size(127, 30);
            this.lblAppFName.TabIndex = 9;
            this.lblAppFName.Text = "Something ";
            // 
            // lblLoggedInUser
            // 
            this.lblLoggedInUser.AutoSize = true;
            this.lblLoggedInUser.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoggedInUser.Location = new System.Drawing.Point(63, 24);
            this.lblLoggedInUser.Name = "lblLoggedInUser";
            this.lblLoggedInUser.Size = new System.Drawing.Size(46, 21);
            this.lblLoggedInUser.TabIndex = 8;
            this.lblLoggedInUser.Text = "aaaa";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.Location = new System.Drawing.Point(15, 24);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(42, 21);
            this.lblUser.TabIndex = 7;
            this.lblUser.Text = "User";
            // 
            // pnlFooter
            // 
            this.pnlFooter.BackColor = System.Drawing.Color.LimeGreen;
            this.pnlFooter.Controls.Add(this.lblFooter);
            this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFooter.Location = new System.Drawing.Point(0, 624);
            this.pnlFooter.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Size = new System.Drawing.Size(800, 54);
            this.pnlFooter.TabIndex = 12;
            // 
            // lblFooter
            // 
            this.lblFooter.AutoSize = true;
            this.lblFooter.Location = new System.Drawing.Point(444, 17);
            this.lblFooter.Name = "lblFooter";
            this.lblFooter.Size = new System.Drawing.Size(164, 13);
            this.lblFooter.TabIndex = 0;
            this.lblFooter.Text = "Developed By ; Rabindra Amatya";
            // 
            // frmUserDashboards
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 678);
            this.Controls.Add(this.pnlFooter);
            this.Controls.Add(this.lblBilling);
            this.Controls.Add(this.lblStoreABC);
            this.Controls.Add(this.lblAppFName);
            this.Controls.Add(this.lblLoggedInUser);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.menuStripTop);
            this.MainMenuStrip = this.menuStripTop;
            this.Name = "frmUserDashboards";
            this.Text = "User Dashboards";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmUserDashboards_FormClosed);
            this.Load += new System.EventHandler(this.frmUserDashboards_Load);
            this.menuStripTop.ResumeLayout(false);
            this.menuStripTop.PerformLayout();
            this.pnlFooter.ResumeLayout(false);
            this.pnlFooter.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripTop;
        private System.Windows.Forms.ToolStripMenuItem purchaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salesFormsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inventoryToolStripMenuItem;
        private System.Windows.Forms.Label lblBilling;
        private System.Windows.Forms.Label lblStoreABC;
        private System.Windows.Forms.Label lblAppFName;
        private System.Windows.Forms.Label lblLoggedInUser;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Panel pnlFooter;
        private System.Windows.Forms.Label lblFooter;
    }
}