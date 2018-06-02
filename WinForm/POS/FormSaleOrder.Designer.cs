namespace WinForm.POS
{
    partial class FormSaleOrder
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtSaleId = new System.Windows.Forms.TabControl();
            this.ts = new System.Windows.Forms.TabPage();
            this.btnWarehouse = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column14 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSave = new System.Windows.Forms.Button();
            this.dateSaleOrder = new System.Windows.Forms.DateTimePicker();
            this.txtSubtotal = new System.Windows.Forms.TextBox();
            this.txtDeposit = new System.Windows.Forms.TextBox();
            this.txtDisAmount = new System.Windows.Forms.TextBox();
            this.txtDiscountP = new System.Windows.Forms.TextBox();
            this.txtGrandTotal = new System.Windows.Forms.TextBox();
            this.txtBalance = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtWarehouseName = new System.Windows.Forms.TextBox();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.txtWarehouseId = new System.Windows.Forms.TextBox();
            this.txtUserId = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtCustomerID = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtSaleOrderID = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCustomer = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.List = new System.Windows.Forms.TabPage();
            this.panel1.SuspendLayout();
            this.txtSaleId.SuspendLayout();
            this.ts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtSaleId);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(936, 594);
            this.panel1.TabIndex = 0;
            // 
            // txtSaleId
            // 
            this.txtSaleId.Controls.Add(this.ts);
            this.txtSaleId.Controls.Add(this.List);
            this.txtSaleId.Location = new System.Drawing.Point(12, 12);
            this.txtSaleId.Name = "txtSaleId";
            this.txtSaleId.SelectedIndex = 0;
            this.txtSaleId.Size = new System.Drawing.Size(901, 579);
            this.txtSaleId.TabIndex = 0;
            // 
            // ts
            // 
            this.ts.Controls.Add(this.btnWarehouse);
            this.ts.Controls.Add(this.dataGridView1);
            this.ts.Controls.Add(this.btnSave);
            this.ts.Controls.Add(this.dateSaleOrder);
            this.ts.Controls.Add(this.txtSubtotal);
            this.ts.Controls.Add(this.txtDeposit);
            this.ts.Controls.Add(this.txtDisAmount);
            this.ts.Controls.Add(this.txtDiscountP);
            this.ts.Controls.Add(this.txtGrandTotal);
            this.ts.Controls.Add(this.txtBalance);
            this.ts.Controls.Add(this.txtUserName);
            this.ts.Controls.Add(this.txtWarehouseName);
            this.ts.Controls.Add(this.txtCustomerName);
            this.ts.Controls.Add(this.txtNote);
            this.ts.Controls.Add(this.txtWarehouseId);
            this.ts.Controls.Add(this.txtUserId);
            this.ts.Controls.Add(this.label13);
            this.ts.Controls.Add(this.label15);
            this.ts.Controls.Add(this.txtCustomerID);
            this.ts.Controls.Add(this.label11);
            this.ts.Controls.Add(this.label12);
            this.ts.Controls.Add(this.label14);
            this.ts.Controls.Add(this.txtSaleOrderID);
            this.ts.Controls.Add(this.label9);
            this.ts.Controls.Add(this.label6);
            this.ts.Controls.Add(this.label8);
            this.ts.Controls.Add(this.label10);
            this.ts.Controls.Add(this.label4);
            this.ts.Controls.Add(this.label5);
            this.ts.Controls.Add(this.label7);
            this.ts.Controls.Add(this.label2);
            this.ts.Controls.Add(this.label3);
            this.ts.Controls.Add(this.btnCustomer);
            this.ts.Controls.Add(this.label1);
            this.ts.Location = new System.Drawing.Point(4, 22);
            this.ts.Name = "ts";
            this.ts.Padding = new System.Windows.Forms.Padding(3);
            this.ts.Size = new System.Drawing.Size(893, 553);
            this.ts.TabIndex = 0;
            this.ts.Text = "New";
            this.ts.UseVisualStyleBackColor = true;
            // 
            // btnWarehouse
            // 
            this.btnWarehouse.Location = new System.Drawing.Point(374, 126);
            this.btnWarehouse.Name = "btnWarehouse";
            this.btnWarehouse.Size = new System.Drawing.Size(34, 23);
            this.btnWarehouse.TabIndex = 20;
            this.btnWarehouse.Text = "...";
            this.btnWarehouse.UseVisualStyleBackColor = true;
            this.btnWarehouse.Click += new System.EventHandler(this.btnWarehouse_Click);
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column3,
            this.Column4,
            this.Column8,
            this.Column9,
            this.Column14,
            this.Column6,
            this.Column2,
            this.Column10,
            this.Column11,
            this.Column5,
            this.Column12,
            this.Column13});
            this.dataGridView1.Location = new System.Drawing.Point(35, 257);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView1.Size = new System.Drawing.Size(821, 163);
            this.dataGridView1.TabIndex = 19;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentEndEdit);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ProId";
            this.Column1.Name = "Column1";
            this.Column1.Width = 50;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Name EN";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Name KH";
            this.Column4.Name = "Column4";
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Category";
            this.Column8.Name = "Column8";
            this.Column8.Width = 50;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Measure";
            this.Column9.Name = "Column9";
            this.Column9.Width = 50;
            // 
            // Column14
            // 
            this.Column14.HeaderText = "Add";
            this.Column14.Name = "Column14";
            this.Column14.Width = 30;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Qty";
            this.Column6.Name = "Column6";
            this.Column6.Width = 50;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Dis";
            this.Column2.Name = "Column2";
            this.Column2.Width = 50;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "DisA";
            this.Column10.Name = "Column10";
            this.Column10.Width = 50;
            // 
            // Column11
            // 
            this.Column11.HeaderText = "VAT";
            this.Column11.Name = "Column11";
            this.Column11.Width = 50;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Price";
            this.Column5.Name = "Column5";
            this.Column5.Width = 50;
            // 
            // Column12
            // 
            this.Column12.HeaderText = "Amount";
            this.Column12.Name = "Column12";
            // 
            // Column13
            // 
            this.Column13.HeaderText = "Note";
            this.Column13.Name = "Column13";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(35, 438);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dateSaleOrder
            // 
            this.dateSaleOrder.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateSaleOrder.Location = new System.Drawing.Point(619, 32);
            this.dateSaleOrder.Name = "dateSaleOrder";
            this.dateSaleOrder.Size = new System.Drawing.Size(237, 20);
            this.dateSaleOrder.TabIndex = 17;
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.Location = new System.Drawing.Point(322, 440);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.Size = new System.Drawing.Size(201, 20);
            this.txtSubtotal.TabIndex = 12;
            this.txtSubtotal.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtDeposit
            // 
            this.txtDeposit.Location = new System.Drawing.Point(322, 520);
            this.txtDeposit.Name = "txtDeposit";
            this.txtDeposit.Size = new System.Drawing.Size(201, 20);
            this.txtDeposit.TabIndex = 12;
            this.txtDeposit.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtDisAmount
            // 
            this.txtDisAmount.Location = new System.Drawing.Point(322, 482);
            this.txtDisAmount.Name = "txtDisAmount";
            this.txtDisAmount.Size = new System.Drawing.Size(201, 20);
            this.txtDisAmount.TabIndex = 12;
            this.txtDisAmount.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtDiscountP
            // 
            this.txtDiscountP.Location = new System.Drawing.Point(655, 438);
            this.txtDiscountP.Name = "txtDiscountP";
            this.txtDiscountP.Size = new System.Drawing.Size(201, 20);
            this.txtDiscountP.TabIndex = 12;
            this.txtDiscountP.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtDiscountP_KeyUp);
            // 
            // txtGrandTotal
            // 
            this.txtGrandTotal.Location = new System.Drawing.Point(655, 518);
            this.txtGrandTotal.Name = "txtGrandTotal";
            this.txtGrandTotal.Size = new System.Drawing.Size(201, 20);
            this.txtGrandTotal.TabIndex = 12;
            // 
            // txtBalance
            // 
            this.txtBalance.Location = new System.Drawing.Point(655, 480);
            this.txtBalance.Name = "txtBalance";
            this.txtBalance.Size = new System.Drawing.Size(201, 20);
            this.txtBalance.TabIndex = 12;
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(619, 168);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(237, 20);
            this.txtUserName.TabIndex = 12;
            // 
            // txtWarehouseName
            // 
            this.txtWarehouseName.Location = new System.Drawing.Point(619, 126);
            this.txtWarehouseName.Name = "txtWarehouseName";
            this.txtWarehouseName.Size = new System.Drawing.Size(237, 20);
            this.txtWarehouseName.TabIndex = 13;
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(619, 82);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(237, 20);
            this.txtCustomerName.TabIndex = 13;
            // 
            // txtNote
            // 
            this.txtNote.Location = new System.Drawing.Point(168, 213);
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(688, 20);
            this.txtNote.TabIndex = 14;
            // 
            // txtWarehouseId
            // 
            this.txtWarehouseId.Location = new System.Drawing.Point(168, 126);
            this.txtWarehouseId.Name = "txtWarehouseId";
            this.txtWarehouseId.Size = new System.Drawing.Size(200, 20);
            this.txtWarehouseId.TabIndex = 15;
            // 
            // txtUserId
            // 
            this.txtUserId.Location = new System.Drawing.Point(168, 168);
            this.txtUserId.Name = "txtUserId";
            this.txtUserId.Size = new System.Drawing.Size(237, 20);
            this.txtUserId.TabIndex = 14;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(207, 445);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(62, 13);
            this.label13.TabIndex = 4;
            this.label13.Text = "Sub Total $";
            this.label13.Click += new System.EventHandler(this.label11_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(207, 525);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(52, 13);
            this.label15.TabIndex = 4;
            this.label15.Text = "Deposit $";
            this.label15.Click += new System.EventHandler(this.label11_Click);
            // 
            // txtCustomerID
            // 
            this.txtCustomerID.Location = new System.Drawing.Point(168, 82);
            this.txtCustomerID.Name = "txtCustomerID";
            this.txtCustomerID.Size = new System.Drawing.Size(200, 20);
            this.txtCustomerID.TabIndex = 15;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(207, 487);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(97, 13);
            this.label11.TabIndex = 4;
            this.label11.Text = "Discount Amount $";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(540, 443);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(60, 13);
            this.label12.TabIndex = 4;
            this.label12.Text = "Discount %";
            this.label12.Click += new System.EventHandler(this.label9_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(540, 523);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(72, 13);
            this.label14.TabIndex = 4;
            this.label14.Text = "Grand Total $";
            this.label14.Click += new System.EventHandler(this.label9_Click);
            // 
            // txtSaleOrderID
            // 
            this.txtSaleOrderID.Location = new System.Drawing.Point(168, 34);
            this.txtSaleOrderID.Name = "txtSaleOrderID";
            this.txtSaleOrderID.Size = new System.Drawing.Size(237, 20);
            this.txtSaleOrderID.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(540, 485);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "Balance $";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(517, 172);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "User Name";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(517, 130);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "Warehouse Name";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(66, 217);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(30, 13);
            this.label10.TabIndex = 6;
            this.label10.Text = "Note";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(517, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Customer Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(66, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "User Id";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(66, 130);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Warehouse ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(517, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(66, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Customer Id";
            // 
            // btnCustomer
            // 
            this.btnCustomer.Location = new System.Drawing.Point(374, 80);
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.Size = new System.Drawing.Size(34, 23);
            this.btnCustomer.TabIndex = 11;
            this.btnCustomer.Text = "...";
            this.btnCustomer.UseVisualStyleBackColor = true;
            this.btnCustomer.Click += new System.EventHandler(this.btnCustomer_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "SaleOrder Id";
            // 
            // List
            // 
            this.List.Location = new System.Drawing.Point(4, 22);
            this.List.Name = "List";
            this.List.Padding = new System.Windows.Forms.Padding(3);
            this.List.Size = new System.Drawing.Size(893, 553);
            this.List.TabIndex = 1;
            this.List.Text = "List";
            this.List.UseVisualStyleBackColor = true;
            this.List.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // FormSaleOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 594);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Name = "FormSaleOrder";
            this.Text = "FormSaleOrder";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormSaleOrder_Load);
            this.panel1.ResumeLayout(false);
            this.txtSaleId.ResumeLayout(false);
            this.ts.ResumeLayout(false);
            this.ts.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl txtSaleId;
        private System.Windows.Forms.TabPage ts;
        private System.Windows.Forms.TabPage List;
        private System.Windows.Forms.DateTimePicker dateSaleOrder;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.TextBox txtUserId;
        private System.Windows.Forms.TextBox txtCustomerID;
        private System.Windows.Forms.TextBox txtSaleOrderID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCustomer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtBalance;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtWarehouseName;
        private System.Windows.Forms.TextBox txtWarehouseId;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnWarehouse;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewButtonColumn Column14;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.TextBox txtSubtotal;
        private System.Windows.Forms.TextBox txtDeposit;
        private System.Windows.Forms.TextBox txtDisAmount;
        private System.Windows.Forms.TextBox txtDiscountP;
        private System.Windows.Forms.TextBox txtGrandTotal;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
    }
}