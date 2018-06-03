using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using FastMember;
using WinForm.Administrator.frmProduct;
using WinForm.Inventory.ProductMaster;
using WinForm.Models;
using WinForm.Models.Support;
using WinForm.Reports;
using dsReceiveItem = WinForm.Reports.dsReceiveItem;

namespace WinForm.Inventory.ReceivItem
{
    public partial class FormReceiveItem : Office2007Form
    {
        private readonly AppContext _appContext;
        private List<Models.Support.Setting> _setting;
        private int _idMax;
        private ProducWarehouse _producWarehouse;

        public FormReceiveItem()
        {
            _appContext = new AppContext();
            InitializeComponent();
        }


        private void FormReceiveItem_Load(object sender, EventArgs e)
        {
            if (CurrentUser.GetCurrentUser != "Chamroeun")
            {
                MyMessage.Warning("Please Login as Chamroeun");
                Application.Exit();
            }
            txtUserId.Text = CurrentUser.GetCurrentUserId.ToString();
            txtUserName.Text = CurrentUser.GetCurrentUser;
            var list = _appContext.Transactions.ToList();
            _idMax = list.Equals(null) ? 0 : list.Count;
            _setting = _appContext.Settings.ToList();
            foreach (var setting in _setting)
                txtReceiveId.Text = setting.ReceivePre + DateTime.Today.Year + DateTime.Today.Month.ToString("D2") +
                                    DateTime.Today.Day.ToString("D2") + _idMax.ToString("D3");
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void btnWarehouseId_Click(object sender, EventArgs e)
        {
            var frm = new FormListWarehouse();
            frm.ShowDialog();
            txtWarehouseId.Text = frm.WarehouseId.ToString();
            txtWarehouse.Text = frm.WarehouseName;
        }

        private void btnSupplierId_Click(object sender, EventArgs e)
        {
            var frm = new FormListSupplier();
            frm.ShowDialog();
            txtSupplierId.Text = frm.SupplierId;
            txtSupplier.Text = frm.SupplierName;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex != 3) return;
                if (string.IsNullOrWhiteSpace(txtWarehouseId.Text))
                {
                    MyMessage.Warning("Please Select Warehouse");
                    return;
                }
                if (string.IsNullOrWhiteSpace(txtSupplierId.Text))
                {
                    MyMessage.Warning("Please Select Supplier.");
                    return;
                }
                var frmProduct = new FormListProduct();
                frmProduct.ShowDialog();
                var wId = int.Parse(txtWarehouseId.Text);


                string onhand;
                try
                {
                    var findonhand = _appContext.ProducWarehouses
                        .Where(id => id.WarehouseId == wId && id.ProductId == frmProduct.SelectProduct.Id)
                        .Select(warehouse => warehouse.OnHand).FirstOrDefault();
                    onhand = findonhand.ToString();
                }
                catch (ArgumentNullException)
                {
                    onhand = "0";
                }


                if (dataGridView1.Rows.Cast<DataGridViewRow>()
                    .TakeWhile(row => row.Cells[0].Value != null)
                    .Any(row => frmProduct.Product.Id.ToString() == row.Cells[0].Value.ToString()))
                {
                    MyMessage.Warning("Aleady added");
                    return;
                }

                var dataGridViewRow = (DataGridViewRow) dataGridView1.Rows[0].Clone();
                dataGridViewRow.Cells[0].Value = frmProduct.SelectProduct.Id;
                dataGridViewRow.Cells[1].Value = frmProduct.SelectProduct.NameEn;
                dataGridViewRow.Cells[2].Value = frmProduct.SelectProduct.NameKh;
                // index 3 is for button
                dataGridViewRow.Cells[4].Value = onhand;
                dataGridViewRow.Cells[5].Value = "0";
                dataGridViewRow.Cells[6].Value = "0";
                dataGridViewRow.Cells[7].Value = frmProduct.SelectProduct.Price;

                dataGridViewRow.Cells[8].Value = frmProduct.SelectProduct.Cost;
                dataGridViewRow.Cells[9].Value = "";
                dataGridViewRow.Cells[10].Value = "";

                if (e.RowIndex == dataGridView1.Rows.Count - 1)
                    dataGridView1.Rows.Add(dataGridViewRow);
            }
            catch (Exception exception)
            {
                MessageBox.Show(@"Error :" + exception, @"Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            // ReSharper disable once SwitchStatementMissingSomeCases
            switch (e.ColumnIndex)
            {
                case 5:
                    if (dataGridView1.Rows.Count > 0)
                    {
                        var rowIndex = dataGridView1.CurrentCell.RowIndex;
                        var qty = float.Parse(dataGridView1.Rows[rowIndex].Cells[5].Value.ToString());
                        var cost = float.Parse(dataGridView1.Rows[rowIndex].Cells[8].Value.ToString());
                        var amount = qty * cost;

                        dataGridView1.Rows[rowIndex].Cells[9].Value = amount;
                    }

                    float sum = 0;
                    for (var i = 0; i < dataGridView1.Rows.Count; ++i)
                        sum += Convert.ToSingle(dataGridView1.Rows[i].Cells[9].Value);
                    txtTotalAmount.Text = sum.ToString(CultureInfo.InvariantCulture);
                    break;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                // Initial Transaction
                var transaction = Transaction;
                // Add Transaction to Context
                _appContext.Transactions.Add(transaction); 
                for (var row = 0; row < dataGridView1.RowCount - 1; row++)
                {
                    // Transaction Item
                    var transactionItem = TransactionItem(row);
                    _appContext.TransactionItems.Add(transactionItem);

                    /* Save into Productwarehouse */
                    var wareId = int.Parse(txtWarehouseId.Text);
                    var proId = int.Parse(dataGridView1.Rows[row].Cells[0].Value.ToString());
                    var producWarehouse = _appContext.ProducWarehouses.Find(proId, wareId);
                        // Check Product Onhand Each ProductWarehouse
                    var onhand = int.Parse(dataGridView1.Rows[row].Cells[4].Value.ToString());
                        // Check Product have or not in ProductWarehouse if null Adding if not null will Modified 
                    if (producWarehouse != null) 
                    {
                        onhand = onhand + int.Parse(dataGridView1.Rows[row].Cells[5].Value.ToString());
                        producWarehouse.WarehouseId = int.Parse(txtWarehouseId.Text);
                        producWarehouse.ProductId = int.Parse(dataGridView1.Rows[row].Cells[0].Value.ToString());
                        producWarehouse.OnHand = onhand;
                        producWarehouse.AlertQty = int.Parse(dataGridView1.Rows[row].Cells[6].Value.ToString());
                        producWarehouse.SupplierId = int.Parse(txtSupplierId.Text);
                        producWarehouse.Note = dataGridView1.Rows[row].Cells[10].Value.ToString();
                        producWarehouse.SaleOrderQty = 0;
                        _appContext.Entry(producWarehouse).State = EntityState.Modified;
                    }
                    else
                    {
                        _producWarehouse = new ProducWarehouse
                        {
                            WarehouseId = int.Parse(txtWarehouseId.Text),
                            ProductId = int.Parse(dataGridView1.Rows[row].Cells[0].Value.ToString()),
                            OnHand = int.Parse(dataGridView1.Rows[row].Cells[5].Value.ToString()),
                            AlertQty = int.Parse(dataGridView1.Rows[row].Cells[6].Value.ToString()),
                            SupplierId = int.Parse(txtSupplierId.Text),
                            Note = dataGridView1.Rows[row].Cells[10].Value.ToString(),
                            SaleOrderQty = 0
                        };
                        _appContext.ProducWarehouses.Add(_producWarehouse);
                    }
                }
                // end foreach

                if (_appContext == null) MyMessage.Warning("No Data");
                _appContext.SaveChanges();

                var dialog = MessageBox.Show(@"Do you want to print report?", @"MessageBox", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Information);
                if (dialog != DialogResult.Yes)
                {
                    if (dialog == DialogResult.No)
                        MyMessage.Success("Information saved successfully.");
                }
                else
                {
                    var t = _appContext.Transactions
                        .Where(i => i.TransactionId.Equals(txtReceiveId.Text))
                        .Include(user => user.User)
                        .Include(supplier => supplier.Supplier)
                        .Select(tran => new
                        {
                            tran.TransactionId,
                            tran.UserId,
                            UserName = tran.User.UserNmae,
                            tran.TotalAmount,
                            tran.SupplierId,
                            SupplierName = tran.Supplier.Name,
                            SupplierPhone = tran.Supplier.Phone
                        })
                        .ToList();
                    var ti = _appContext.TransactionItems
                        .Where(i => i.TransactionId.Equals(txtReceiveId.Text))
                        .Include(pro => pro.Product)
                        .Include(cat => cat.Product.Category)
                        .Include(measure => measure.Product.Measure)
                        .Select(item => new
                        {
                            item.ProductId,
                            item.WarehouseId,
                            item.Qty,
                            item.Cost,
                            Category = item.Product.Category.Name,
                            Measure = item.Product.Measure.Name,
                            ProductName = item.Product.NameEn,
                            item.Product.NameKh
                        })
                        .ToList();


                    var dt1 = new DataTable();
                    using (var reader = ObjectReader.Create(t))
                    {
                        dt1.Load(reader);
                    }
                    dt1.TableName = "transaction";

                    var dt2 = new DataTable();
                    using (var reader = ObjectReader.Create(ti))
                    {
                        dt2.Load(reader);
                    }
                    dt2.TableName = "TransactionItem";


                    var ds = new dsReceiveItem();
                    
                    ds.Merge(dt1);
                    ds.Merge(dt2);


                    var rpt = new crptReceiveItem();
                    rpt.SetDataSource(ds);
                    var frm = new frmReceiveReport(rpt);
                    frm.Show();
                }


                dataGridView1.Rows.Clear();
            }
            catch (Exception exception)
            {
                MyMessage.Error(exception.ToString());
            }
        }

        private TransactionItem TransactionItem(int row)
        {
            var transactionItem = new TransactionItem
            {
                TransactionId = txtReceiveId.Text,
                ProductId = int.Parse(dataGridView1.Rows[row].Cells[0].Value.ToString()),
                Qty = int.Parse(dataGridView1.Rows[row].Cells[5].Value.ToString()),

                Price = float.Parse(dataGridView1.Rows[row].Cells[7].Value.ToString()),
                Cost = float.Parse(dataGridView1.Rows[row].Cells[8].Value.ToString()),
                WarehouseId = Convert.ToInt32(txtWarehouseId.Text)
            };
            return transactionItem;
        }

        private Transaction Transaction
        {
            get
            {
                var transaction = new Transaction
                {
                    TransactionId = txtReceiveId.Text,
                    SupplierId = Convert.ToInt32(txtSupplierId.Text),
                    TransactionType = TransactionType.Receive,
                    SynNote = txtSynNote.Text,
                    Note = txtNote.Text,
                    DateTime = Convert.ToDateTime(Convert.ToDateTime(txtDate.Text).ToShortDateString()),
                    UserId = Convert.ToInt32(txtUserId.Text),
                    TotalAmount = Convert.ToSingle(txtTotalAmount.Text)
                };
                return transaction;
            }
        }

        public DataTable ConvertToDataTable<T>(IList<T> data)
        {
            var properties =
                TypeDescriptor.GetProperties(typeof(T));
            var table = new DataTable();
            foreach (PropertyDescriptor prop in properties)
                table.Columns.Add(prop.Name, Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType);
            foreach (var item in data)
            {
                var row = table.NewRow();
                foreach (PropertyDescriptor prop in properties)
                    row[prop.Name] = prop.GetValue(item) ?? DBNull.Value;
                table.Rows.Add(row);
            }
            return table;
        }
    }
}
