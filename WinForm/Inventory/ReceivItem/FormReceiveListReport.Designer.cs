namespace WinForm.Inventory.ReceivItem
{
    partial class FormReceiveListReport
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
            this.crystalReport1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.rptReceiveItem1 = new WinForm.Reports.rptReceiveItem();
            this.SuspendLayout();
            // 
            // crystalReport1
            // 
            this.crystalReport1.ActiveViewIndex = -1;
            this.crystalReport1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReport1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReport1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReport1.Location = new System.Drawing.Point(0, 0);
            this.crystalReport1.Name = "crystalReport1";
            this.crystalReport1.ReportSource = this.rptReceiveItem1;
            this.crystalReport1.Size = new System.Drawing.Size(778, 487);
            this.crystalReport1.TabIndex = 0;
            this.crystalReport1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            this.crystalReport1.Load += new System.EventHandler(this.crvReportreceive_Load);
            // 
            // FormReceiveListReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 487);
            this.Controls.Add(this.crystalReport1);
            this.Name = "FormReceiveListReport";
            this.Text = "FormReceiveListReport";
            this.Load += new System.EventHandler(this.FormReceiveListReport_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReport1;
        private Reports.rptReceiveItem rptReceiveItem1;
    }
}