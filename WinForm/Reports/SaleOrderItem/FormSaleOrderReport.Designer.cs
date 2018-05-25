namespace WinForm.Reports.ReceiveItems
{
    partial class FormSaleOrderReport
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
            this.crystalReportSaleOrder = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crystalReportSaleOrder
            // 
            this.crystalReportSaleOrder.ActiveViewIndex = -1;
            this.crystalReportSaleOrder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportSaleOrder.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportSaleOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportSaleOrder.Location = new System.Drawing.Point(0, 0);
            this.crystalReportSaleOrder.Name = "crystalReportSaleOrder";
            this.crystalReportSaleOrder.Size = new System.Drawing.Size(965, 405);
            this.crystalReportSaleOrder.TabIndex = 0;
            this.crystalReportSaleOrder.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // FormSaleOrderReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 405);
            this.Controls.Add(this.crystalReportSaleOrder);
            this.Name = "FormSaleOrderReport";
            this.Text = "FormSaleOrderReport";
            this.Load += new System.EventHandler(this.FormSaleOrderReport_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportSaleOrder;
    }
}